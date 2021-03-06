Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports ejiVault
Namespace SIS.SPMT
  Partial Public Class spmtNewPA
    Public ReadOnly Property dSupplierName() As String
      Get
        If _BPID <> "" Then
          Return Me.VR_BusinessPartner8_BPName ' FK_SPMT_newPA_BPID.BPName
        End If
        Return _SupplierName
      End Get
    End Property

    Public Shared ReadOnly Property AthHandle As String
      Get
        Dim mRet As String = "J_SPMTNEWPA"
        Dim Comp As String = HttpContext.Current.Session("FinanceCompany")
        If Comp <> "200" Then
          mRet = mRet & "_" & Comp
        End If
        Return mRet
      End Get
    End Property
    Public ReadOnly Property GetAttachLink() As String
      Get
        Dim UrlAuthority As String = HttpContext.Current.Request.Url.Authority
        If UrlAuthority.ToLower <> "cloud.isgec.co.in" Then
          UrlAuthority = "perk01"
        End If
        Dim mRet As String = HttpContext.Current.Request.Url.Scheme & Uri.SchemeDelimiter & UrlAuthority
        mRet &= "/Attachment/Attachment.aspx?AthHandle=" & SIS.SPMT.spmtNewPA.AthHandle
        Dim Index As String = AdviceNo
        Dim User As String = HttpContext.Current.Session("LoginID")
        'User = 1
        Dim canEdit As String = "n"
        'If Editable Then
        '  canEdit = "y"
        'End If
        mRet &= "&Index=" & Index & "&AttachedBy=" & User & "&ed=" & canEdit
        mRet = "javascript:window.open('" & mRet & "', 'win" & AdviceNo & "', 'left=20,top=20,width=500,height=300,toolbar=1,resizable=1,scrollbars=1'); return false;"
        Return mRet
      End Get
    End Property
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Black
      Select Case StatusID
        Case spmtPAStates.Cancelled
          mRet = Drawing.Color.Blue
        Case spmtPAStates.ForwardedToAC
          mRet = Drawing.Color.Green
        Case spmtPAStates.Returned
          mRet = Drawing.Color.Red
        Case spmtPAStates.ReceivedInAC
          mRet = Drawing.Color.DarkOrchid
        Case spmtPAStates.Returning, spmtPAStates.UpdatingVoucher, spmtPAStates.VoucherUpdated
          mRet = Drawing.Color.DarkOrange
        Case spmtPAStates.Locked
          mRet = Drawing.Color.Navy
        Case spmtPAStates.UnderApproval
          mRet = Drawing.Color.Red
      End Select
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEnable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEditable() As Boolean
      Dim mRet As Boolean = False
      Select Case StatusID
        Case spmtPAStates.Returned, spmtPAStates.Free, spmtPAStates.IRLinked
          mRet = True
      End Select
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = False
      Select Case StatusID
        Case spmtPAStates.Free
          mRet = True
      End Select
      Return mRet
    End Function
    Public ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property AttatchVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          Select Case Me.StatusID
            Case spmtPAStates.Returned, spmtPAStates.Free
              mRet = False
          End Select
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          Select Case StatusID
            Case spmtPAStates.IRLinked, spmtPAStates.Returned
              mRet = True
          End Select
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ApproveWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          Select Case StatusID
            Case spmtPAStates.UnderApproval
              mRet = True
          End Select
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ReturnWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          Select Case StatusID
            Case spmtPAStates.UnderApproval
              mRet = True
          End Select
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function InitiateWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtNewPA
      Dim Results As SIS.SPMT.spmtNewPA = spmtNewPAGetByID(AdviceNo)
      If Not Convert.ToBoolean(ConfigurationManager.AppSettings("PAApproval")) Then
        Results.StatusID = spmtPAStates.ForwardedToAC
        'Copy Bill Attachments to Advice Attachments
        Dim tmpBills As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.UZ_spmtNewLinkedSBHSelectList(0, 99999, "", False, "", Results.AdviceNo)
        For Each tmpBill As SIS.SPMT.spmtNewLinkedSBH In tmpBills
          Dim IndexS As String = tmpBill.IRNo
          Dim IndexT As String = Results.AdviceNo
          '======Copy Attachment===========
          'CopyAttachment(IndexS, IndexT)
          'DirectNewCopyAttachment(IndexS, IndexT, "J_SPMTNEWSB", "J_SPMTNEWPA")
          EJI.ediAFile.FileCopy(SIS.SPMT.spmtNewSBH.AthHandle, IndexS, SIS.SPMT.spmtNewPA.AthHandle, IndexT, tmpBill.CreatedBy)
          '======End Copy Attachment=======
        Next
        Results = CopyToOldPaymentAdvice(Results)
        SIS.SPMT.spmtNewPA.UpdateData(Results)
      Else
        Results.StatusID = spmtPAStates.UnderApproval
        Dim tmpBills As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.UZ_spmtNewLinkedSBHSelectList(0, 99999, "", False, "", Results.AdviceNo)
        For Each tmpBill As SIS.SPMT.spmtNewLinkedSBH In tmpBills
          Dim IndexS As String = tmpBill.IRNo
          Dim IndexT As String = Results.AdviceNo
          EJI.ediAFile.FileCopy(SIS.SPMT.spmtNewSBH.AthHandle, IndexS, SIS.SPMT.spmtNewPA.AthHandle, IndexT, tmpBill.CreatedBy)
        Next
        SIS.SPMT.spmtNewPA.UpdateData(Results)
      End If
      Return Results
    End Function

    Public Shared Function ApproveWF(ByVal AdviceNo As Int32, Remarks As String) As SIS.SPMT.spmtNewPA
      Dim Results As SIS.SPMT.spmtNewPA = spmtNewPAGetByID(AdviceNo)
      With Results
        .StatusID = spmtPAStates.ForwardedToAC
        .ApprovalRemarks = Remarks
        .ApprovedOn = Now
      End With
      Results = CopyToOldPaymentAdvice(Results)
      SIS.SPMT.spmtNewPA.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function ReturnWF(ByVal AdviceNo As Int32, Remarks As String) As SIS.SPMT.spmtNewPA
      Dim Results As SIS.SPMT.spmtNewPA = spmtNewPAGetByID(AdviceNo)
      With Results
        .StatusID = spmtPAStates.Returned
        .ApprovalRemarks = Remarks
        .ApprovedOn = Now
      End With
      ejiVault.EJI.ediAFile.DeleteDataByHandleIndex(SIS.SPMT.spmtNewPA.AthHandle, AdviceNo)
      SIS.SPMT.spmtNewPA.UpdateData(Results)
      Return Results
    End Function

    'Public Shared Sub DirectNewCopyAttachment(ByVal S_Index As String, ByVal T_Index As String, ByVal S_Handle As String, ByVal T_Handle As String)
    '  Dim Sql As String = ""
    '  Sql &= " insert into ttcisg132200 (t_drid,t_dcid,t_hndl,t_indx,t_prcd,t_fnam,t_lbcd,t_atby,t_aton,t_Refcntd,t_Refcntu)"
    '  Sql &= " select 1000000 + (ABS(CHECKSUM(NEWID())) % 1000000)  as t_drid ,t_dcid, '" & T_Handle & "' AS t_hndl, "
    '  Sql &= " '" & T_Index & "' as t_indx,"
    '  Sql &= " t_prcd,t_fnam,t_lbcd,t_atby,t_aton,t_Refcntd,t_Refcntu "
    '  Sql &= " from ttcisg132200"
    '  Sql &= " where t_hndl='" & S_Handle & "' "
    '  Sql &= " and t_indx='" & S_Index & "'"
    '  Sql &= ""
    '  Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
    '    Using Cmd As SqlCommand = Con.CreateCommand()
    '      Cmd.CommandType = CommandType.Text
    '      Cmd.CommandText = Sql
    '      Con.Open()
    '      Cmd.ExecuteNonQuery()
    '    End Using
    '  End Using
    'End Sub
    Public Shared Function UZ_spmtNewPASelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal CreatedBy As String, ByVal BPID As String) As List(Of SIS.SPMT.spmtNewPA)
      Dim Results As List(Of SIS.SPMT.spmtNewPA) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_NewPASelectListSearch"
            Cmd.CommandText = "spspmtNewPASelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_NewPASelectListFilteres"
            Cmd.CommandText = "spspmtNewPASelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CreatedBy", SqlDbType.NVarChar, 8, IIf(CreatedBy Is Nothing, String.Empty, CreatedBy))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewPA)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewPA(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtNewPAInsert(ByVal Record As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      With Record
      End With
      Dim _Result As SIS.SPMT.spmtNewPA = spmtNewPAInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtNewPAUpdate(ByVal Record As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      Dim _Result As SIS.SPMT.spmtNewPA = spmtNewPAUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtNewPADelete(ByVal Record As SIS.SPMT.spmtNewPA) As Integer
      Dim _Result As Integer = spmtNewPADelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_AdviceNo"), TextBox).Text = ""
          CType(.FindControl("F_TranTypeID"), Object).SelectedValue = ""
          CType(.FindControl("F_SupplierName"), TextBox).Text = ""
          CType(.FindControl("F_RetensionAmount"), TextBox).Text = "0.00"
          CType(.FindControl("F_RetensionRate"), TextBox).Text = "0.00"
          CType(.FindControl("F_AdvanceAmount"), TextBox).Text = "0.00"
          CType(.FindControl("F_AdvanceRate"), TextBox).Text = "0.00"
          CType(.FindControl("F_Remarks"), TextBox).Text = ""
          CType(.FindControl("F_ConcernedHOD"), TextBox).Text = ""
          CType(.FindControl("F_ConcernedHOD_Display"), Label).Text = ""
          CType(.FindControl("F_BPID"), TextBox).Text = ""
          CType(.FindControl("F_BPID_Display"), Label).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
    Public Shared Function ValidateAdvice(ByVal AdviceNo As Integer) As Boolean
      Dim oAdv As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(AdviceNo)
      Dim oBills As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.spmtNewLinkedSBHSelectList(0, 9999, "", False, "", AdviceNo)
      If oBills.Count <= 0 Then
        oAdv.StatusID = spmtPAStates.Free
        oAdv.TotalAdviceAmount = "0.00"
        SIS.SPMT.spmtNewPA.UpdateData(oAdv)
        Return False
      Else
        Dim tmpTot As Decimal = 0
        For Each tmp As SIS.SPMT.spmtNewLinkedSBH In oBills
          tmpTot += tmp.TotalBillAmount
        Next
        oAdv.StatusID = spmtPAStates.IRLinked
        oAdv.TotalAdviceAmount = tmpTot
        SIS.SPMT.spmtNewPA.UpdateData(oAdv)
        Return True
      End If
    End Function

    Public Shared Function CopyToOldPaymentAdvice(ByVal sPA As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      Dim sSBs As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.spmtNewLinkedSBHSelectList(0, 9999, "", False, "", sPA.AdviceNo)
      Dim paFound As Boolean = False
      Dim tPA As SIS.SPMT.spmtPaymentAdvice = Nothing
      If sPA.OldAdviceNo <> "" Then
        tPA = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(sPA.OldAdviceNo)
        If tPA IsNot Nothing Then
          paFound = True
        Else
          tPA = New SIS.SPMT.spmtPaymentAdvice
        End If
      Else
        tPA = New SIS.SPMT.spmtPaymentAdvice
      End If
      With tPA
        ' Fields & Forwarded To Accounts
        .TranTypeID = sPA.TranTypeID
        .AdviceStatusID = spmtPAStates.ForwardedToAC
        .BPID = sPA.BPID
        .ConcernedHOD = sPA.ConcernedHOD
        .AdviceStatusUser = sPA.CreatedBy
        .AdviceStatusOn = sPA.CreatedOn
        .Remarks = sPA.Remarks
        .ProjectID = sSBs(0).ProjectID
        .ElementID = sSBs(0).ElementID
        .CostCenterID = sSBs(0).CostCenterID
        .EmployeeID = sSBs(0).EmployeeID
        .DepartmentID = sSBs(0).DepartmentID
        .SupplierName = sPA.SupplierName
        .AdvanceRate = sPA.AdvanceRate
        .AdvanceAmount = sPA.AdvanceAmount
        .RetensionRate = sPA.RetensionRate
        .RetensionAmount = sPA.RetensionAmount
        .VoucherNo = sPA.AdviceNo
        .CostCenter = sPA.TotalAdviceAmount
      End With
      If Not paFound Then
        tPA = SIS.SPMT.spmtPaymentAdvice.InsertData(tPA)
      Else
        tPA = SIS.SPMT.spmtPaymentAdvice.UpdateData(tPA)
      End If
      sPA.OldAdviceNo = tPA.AdviceNo
      If paFound Then
        DeleteSB(tPA.AdviceNo)
      End If
      'Dim sSBs As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.spmtNewLinkedSBHSelectList(0, 9999, "", False, "", sPA.AdviceNo)
      For Each sbh As SIS.SPMT.spmtNewLinkedSBH In sSBs
        'Creates a Separate Bill for each Line Item 
        'Ans copies same Bill Attachment in each bill
        Dim sSBDs As List(Of SIS.SPMT.spmtNewSBD) = SIS.SPMT.spmtNewSBD.spmtNewSBDSelectList(0, 9999, "", False, "", sbh.IRNo)
        For Each sbd As SIS.SPMT.spmtNewSBD In sSBDs
          Dim tmpSB As New SIS.SPMT.spmtSupplierBill
          With tmpSB
            .AdviceNo = tPA.AdviceNo
            .TranTypeID = sbh.TranTypeID
            .BillStatusID = 4
            .BillStatusDate = Now
            .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
            .DocNo = "NSPMT"
            .BillAmount = sbd.TotalAmountINR
            .IRReceivedOn = Now
            .BPID = sbh.BPID
            .BillNumber = sbh.BillNumber
            .BillDate = sbh.BillDate
            .Quantity = sbd.Quantity
            .UOM = sbd.UOM
            .Currency = sbd.Currency
            .BillRemarks = sbd.ItemDescription
            .SupplierGSTIN = sbh.SupplierGSTIN
            .IsgecGSTIN = sbh.IsgecGSTIN
            .ShipToState = sbh.ShipToState
            .HSNSACCode = sbd.HSNSACCode
            .BillType = sbd.BillType
            .ConversionFactorINR = sbd.ConversionFactorINR
            .TotalGST = sbd.TotalGSTINR
            .CessAmount = sbd.CessAmount
            .CessRate = sbd.CessRate
            .TaxAmount = sbd.TotalGSTINR
            .RemarksGST = ""
            .TotalAmountINR = sbd.TotalAmountINR
            .TotalAmount = sbd.TotalAmount
            .IGSTAmount = sbd.IGSTAmount
            .IGSTRate = sbd.IGSTRate
            .AssessableValue = sbd.AssessableValue
            .CGSTRate = sbd.CGSTRate
            .SGSTAmount = sbd.SGSTAmount
            .SGSTRate = sbd.SGSTRate
            .CGSTAmount = sbd.CGSTAmount
            .PurchaseType = sbh.PurchaseType
            .SupplierName = sbh.SupplierName
            .SupplierGSTINNumber = sbh.SupplierGSTINNumber
            .DepartmentID = sbd.DepartmentID
            .TCSRate = sbd.TCSRate
            .TCSAmount = sbd.TCSAmount
          End With
          tmpSB = SIS.SPMT.spmtSupplierBill.InsertData(tmpSB)
          '=========Copy Bill Attachment to OLD BILLs===========
          'DirectNewCopyAttachment(sbh.IRNo, tmpSB.IRNo, "J_SPMTNEWSB", "J_SPMTSUPPLIERBILL")
          EJI.ediAFile.FileCopy(SIS.SPMT.spmtNewSBH.AthHandle, sbh.IRNo, SIS.SPMT.spmtSupplierBill.AthHandle, tmpSB.IRNo, sbh.CreatedBy)
          '=============================================
        Next
        '=========Copy Bill Attachment to OLD PA===========
        'DirectNewCopyAttachment(sbh.IRNo, tPA.AdviceNo, "J_SPMTNEWSB", "J_SPMTPAYMENTADVICE")
        EJI.ediAFile.FileCopy(SIS.SPMT.spmtNewSBH.AthHandle, sbh.IRNo, SIS.SPMT.spmtPaymentAdvice.AthHandle, tPA.AdviceNo, sbh.CreatedBy)
        '=============================================
      Next
      Return sPA
    End Function
    Private Shared Sub DeleteSB(ByVal AdviceNo As Integer)
      Dim oSBs As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(0, 9999, "", False, "", AdviceNo)
      For Each tmp As SIS.SPMT.spmtPaymentAdviceSupplierBill In oSBs
        SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtSupplierBillDelete(tmp)
      Next
    End Sub

    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function UnderApprovalSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal CreatedBy As String, Pending As Boolean, AdviceNo As Integer) As List(Of SIS.SPMT.spmtNewPA)
      Dim Results As List(Of SIS.SPMT.spmtNewPA) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_UnderApprovalSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_UnderApprovalSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo", SqlDbType.Int, 10, IIf(AdviceNo = Nothing, 0, AdviceNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CreatedBy", SqlDbType.NVarChar, 8, IIf(CreatedBy Is Nothing, String.Empty, CreatedBy))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Pending", SqlDbType.Bit, 3, Pending)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewPA)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewPA(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtNewPASelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal CreatedBy As String, Pending As Boolean, AdviceNo As Integer) As Integer
      Return _RecordCount
    End Function

  End Class
End Namespace
