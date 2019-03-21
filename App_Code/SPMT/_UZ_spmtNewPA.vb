Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtNewPA
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
    Public Shared Function InitiateWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtNewPA
      Dim Results As SIS.SPMT.spmtNewPA = spmtNewPAGetByID(AdviceNo)
      Results.StatusID = spmtPAStates.ForwardedToAC
      Results = CopyToOldPaymentAdvice(Results)
      SIS.SPMT.spmtNewPA.UpdateData(Results)
      Return Results
    End Function
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
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CreatedBy",SqlDbType.NVarChar,8, IIf(CreatedBy Is Nothing, String.Empty,CreatedBy))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
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
      Dim _Result as Integer = spmtNewPADelete(Record)
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
        paFound = True
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
          End With
          tmpSB = SIS.SPMT.spmtSupplierBill.InsertData(tmpSB)
        Next
      Next
      Return sPA
    End Function
    Private Shared Sub DeleteSB(ByVal AdviceNo As Integer)
      Dim oSBs As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(0, 9999, "", False, "", AdviceNo)
      For Each tmp As SIS.SPMT.spmtPaymentAdviceSupplierBill In oSBs
        SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtSupplierBillDelete(tmp)
      Next
    End Sub
  End Class
End Namespace
