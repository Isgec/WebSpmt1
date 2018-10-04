Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Net

Namespace SIS.SPMT
  Partial Public Class spmtPaymentAdvice
    Public ReadOnly Property GetAttachLink() As String
      Get
        Dim UrlAuthority As String = HttpContext.Current.Request.Url.Authority
        If UrlAuthority.ToLower <> "cloud.isgec.co.in" Then
          UrlAuthority = "192.9.200.146"
        End If
        Dim mRet As String = HttpContext.Current.Request.Url.Scheme & Uri.SchemeDelimiter & UrlAuthority
        mRet &= "/Attachment/Attachment.aspx?AthHandle=J_SPMTPAYMENTADVICE"
        Dim Index As String = AdviceNo
        Dim User As String = HttpContext.Current.Session("LoginID")
        'User = 1
        Dim canEdit As String = "n"
        'If Editable Then
        '  canEdit = "y"
        'End If
        mRet &= "&Index=" & Index & "&AttachedBy=" & User & "&ed=" & canEdit
        mRet = "javascript:window.open('" & mRet & "', 'win" & AdviceNo & "', 'left=20,top=20,width=1100,height=600,toolbar=1,resizable=1,scrollbars=1'); return false;"
        Return mRet
      End Get
    End Property

    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Black
      If Convert.ToBoolean(Forward) Then
        Select Case AdviceStatusID
          Case 3
            mRet = Drawing.Color.Blue
          Case 7
            mRet = Drawing.Color.Green
          Case 2
            mRet = Drawing.Color.Red
          Case 8
            mRet = Drawing.Color.DarkOrchid
          Case 9, 10, 11
            mRet = Drawing.Color.DarkOrange
          Case 12
            mRet = Drawing.Color.Navy
        End Select
      End If
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
      Dim mRet As Boolean = True
      If Convert.ToBoolean(Forward) = True Then
        mRet = False
      End If
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
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property BillSelectable As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          Select Case AdviceStatusID
            Case spmtPAStates.Returned, spmtPAStates.Free
              mRet = True
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
          If Convert.ToBoolean(Forward) = True Then
            Select Case AdviceStatusID
              Case spmtPAStates.Returned, spmtPAStates.Free
                mRet = True
            End Select
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property AttatchVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          Select Case AdviceStatusID
            Case spmtPAStates.Returned, spmtPAStates.Free
              mRet = False
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
    Public Shared Function InitiateWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtPaymentAdvice
      Dim Results As SIS.SPMT.spmtPaymentAdvice = spmtPaymentAdviceGetByID(AdviceNo)
      'Copy Bill Attachments to Advice Attachments
      Dim tmpBills As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.UZ_spmtPaymentAdviceSupplierBillSelectList(0, 99999, "", False, "", Results.AdviceNo)
      For Each tmpBill As SIS.SPMT.spmtPaymentAdviceSupplierBill In tmpBills
        Dim IndexS As String = tmpBill.IRNo
        Dim IndexT As String = Results.AdviceNo
        '======Copy Attachment===========
        'CopyAttachment(IndexS, IndexT)
        DirectCopyAttachment(IndexS, IndexT)
        '======End Copy Attachment=======
      Next
      With Results
        .AdviceStatusID = spmtPAStates.ForwardedToAC
      End With
      SIS.SPMT.spmtPaymentAdvice.UpdateData(Results)
      Return Results
    End Function
    Private Shared Sub CopyAttachment(ByVal IndexS As String, ByVal IndexT As String)
      Dim xUrl As String = GetCopyLink()
      xUrl = xUrl & "/" & IndexS & "/" & IndexT
      Dim rq As HttpWebRequest = WebRequest.Create(New Uri(xUrl))
      rq.Method = "GET"
      rq.ContentType = "application/json"
      Try
        Dim rs As WebResponse = rq.GetResponse()
        Dim st As IO.Stream = rs.GetResponseStream
        Dim sr As IO.StreamReader = New IO.StreamReader(st)
        Dim strResponse As String = sr.ReadToEnd
        sr.Close()
      Catch ex As Exception
        Dim err As String = ex.Message
      End Try
    End Sub
    Public Shared Function GetCopyLink() As String
      Dim UrlAuthority As String = HttpContext.Current.Request.Url.Authority
      If UrlAuthority.ToLower <> "cloud.isgec.co.in" Then
        UrlAuthority = "192.9.200.146"
      End If
      Dim mRet As String = HttpContext.Current.Request.Url.Scheme & Uri.SchemeDelimiter & UrlAuthority & "/ProjectApi/AttachmentApi.svc/Attachments"
      Dim AthHandleS As String = "J_SPMTSUPPLIERBILL"
      Dim AthHandleT As String = "J_SPMTPAYMENTADVICE"
      Return mRet & "/" & AthHandleS & "/" & AthHandleT
    End Function
    Public Shared Sub DirectCopyAttachment(ByVal IRNo As String, ByVal AdviceNo As String)
      Dim Sql As String = ""
      Sql &= " insert into ttcisg132200 (t_drid,t_dcid,t_hndl,t_indx,t_prcd,t_fnam,t_lbcd,t_atby,t_aton,t_Refcntd,t_Refcntu)"
      Sql &= " select 1000000 + (ABS(CHECKSUM(NEWID())) % 1000000)  as t_drid ,t_dcid, 'J_SPMTPAYMENTADVICE' AS t_hndl, "
      Sql &= " " & AdviceNo & " as t_indx,"
      Sql &= " t_prcd,t_fnam,t_lbcd,t_atby,t_aton,t_Refcntd,t_Refcntu "
      Sql &= " from ttcisg132200"
      Sql &= " where t_hndl='J_SPMTSUPPLIERBILL' "
      Sql &= " and t_indx=" & IRNo
      Sql &= ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Cmd.ExecuteNonQuery()
        End Using
      End Using
    End Sub
    Public Shared Function UZ_spmtPaymentAdviceSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32, ByVal TranTypeID As String, ByVal BPID As String) As List(Of SIS.SPMT.spmtPaymentAdvice)
      Dim Results As List(Of SIS.SPMT.spmtPaymentAdvice) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_PaymentAdviceSelectListSearch"
            Cmd.CommandText = "spspmtPaymentAdviceSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_PaymentAdviceSelectListFilteres"
            Cmd.CommandText = "spspmtPaymentAdviceSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo", SqlDbType.Int, 10, IIf(AdviceNo = Nothing, 0, AdviceNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtPaymentAdvice)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtPaymentAdvice(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function ValidateAdvice(ByVal AdviceNo As Integer) As Boolean
      Dim oAdv As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(AdviceNo)
      Dim oBills As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(0, 9999, "", False, "", AdviceNo)
      If oBills.Count <= 0 Then
        oAdv.Forward = False
        oAdv.CostCenter = "0.00"
        SIS.SPMT.spmtPaymentAdvice.UpdateData(oAdv)
        Return False
      Else
        Dim tmpTot As Decimal = 0
        For Each tmp As SIS.SPMT.spmtPaymentAdviceSupplierBill In oBills
          tmpTot += tmp.TotalAmountINR
        Next
        oAdv.Forward = True
        oAdv.CostCenter = tmpTot
        SIS.SPMT.spmtPaymentAdvice.UpdateData(oAdv)
        Return True
      End If
    End Function
    Public Shared Function UZ_spmtPaymentAdviceInsert(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      With Record
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .AdviceStatusID = 3
        .AdviceStatusOn = Now
        .AdviceStatusUser = HttpContext.Current.Session("LoginID")
      End With
      Dim _Result As SIS.SPMT.spmtPaymentAdvice = spmtPaymentAdviceInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtPaymentAdviceUpdate(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      With Record
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .AdviceStatusID = 3
        .AdviceStatusOn = Now
        .AdviceStatusUser = HttpContext.Current.Session("LoginID")
      End With
      Dim _Result As SIS.SPMT.spmtPaymentAdvice = spmtPaymentAdviceUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtPaymentAdviceDelete(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As Integer
      Dim _Result As Integer = spmtPaymentAdviceDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_AdviceNo"), TextBox).Text = ""
          CType(.FindControl("F_TranTypeID"), Object).SelectedValue = ""
          CType(.FindControl("F_BPID"), TextBox).Text = ""
          CType(.FindControl("F_BPID_Display"), Label).Text = ""
          CType(.FindControl("F_ConcernedHOD"), TextBox).Text = ""
          CType(.FindControl("F_ConcernedHOD_Display"), Label).Text = ""
          CType(.FindControl("F_Remarks"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID_Display"), Label).Text = ""
          CType(.FindControl("F_ElementID"), TextBox).Text = ""
          CType(.FindControl("F_ElementID_Display"), Label).Text = ""
          CType(.FindControl("F_CostCenterID"), Object).SelectedValue = ""
          CType(.FindControl("F_EmployeeID"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeID_Display"), Label).Text = ""
          CType(.FindControl("F_DepartmentID"), Object).SelectedValue = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
