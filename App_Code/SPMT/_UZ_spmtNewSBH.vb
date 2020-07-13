Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtNewSBH
    Public Shared ReadOnly Property AthHandle As String
      Get
        Dim mRet As String = "J_SPMTNEWSB"
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
          UrlAuthority = "192.9.200.146"
        End If
        Dim mRet As String = HttpContext.Current.Request.Url.Scheme & Uri.SchemeDelimiter & UrlAuthority
        mRet &= "/Attachment/Attachment.aspx?AthHandle=" & SIS.SPMT.spmtNewSBH.AthHandle
        Dim Index As String = IRNo
        Dim User As String = HttpContext.Current.Session("LoginID")
        'User = 1
        Dim canEdit As String = "n"
        If Editable Then
          canEdit = "y"
        End If
        mRet &= "&Index=" & Index & "&AttachedBy=" & User & "&ed=" & canEdit
        mRet = "javascript:window.open('" & mRet & "', 'win" & IRNo & "', 'left=20,top=20,width=1100,height=600,toolbar=1,resizable=1,scrollbars=1'); return false;"
        Return mRet
      End Get
    End Property
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Blue
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
      If AdviceNo = "" Then
        mRet = True
      End If
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = False
      If AdviceNo = "" Then
        If Convert.ToDecimal(TotalBillAmount) <= 0 Then
          mRet = True
        End If
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
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function UZ_spmtNewSBHSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal IsgecGSTIN As Int32, ByVal PurchaseType As String) As List(Of SIS.SPMT.spmtNewSBH)
      Dim Results As List(Of SIS.SPMT.spmtNewSBH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_NewSBHSelectListSearch"
            Cmd.CommandText = "spspmtNewSBHSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_NewSBHSelectListFilteres"
            Cmd.CommandText = "spspmtNewSBHSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IsgecGSTIN",SqlDbType.Int,10, IIf(IsgecGSTIN = Nothing, 0,IsgecGSTIN))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_PurchaseType",SqlDbType.NVarChar,50, IIf(PurchaseType Is Nothing, String.Empty,PurchaseType))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewSBH)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewSBH(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtNewSBHInsert(ByVal Record As SIS.SPMT.spmtNewSBH) As SIS.SPMT.spmtNewSBH
      Dim DuplicateBill As Boolean = False
      Dim Sql As String = ""
      If Record.BPID = "" Then
        Sql &= " select isnull(count(irno),0) as cnt from spmt_supplierBill "
        Sql &= " where "
        Sql &= " lower(billNumber) = lower('" & Record.BillNumber & "') "
        Sql &= " and billDate = convert(datetime,'" & Record.BillDate & "',103) "
        Sql &= " and lower(suppliername) = lower('" & Record.SupplierName & "') "
      Else
        Sql &= " select isnull(count(irno),0) as cnt from spmt_supplierBill "
        Sql &= " where "
        Sql &= " lower(billNumber) = lower('" & Record.BillNumber & "') "
        Sql &= " and billDate = convert(datetime,'" & Record.BillDate & "',103) "
        Sql &= " and lower(BPID) = lower('" & Record.BPID & "') "
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim cnt As Integer = Cmd.ExecuteScalar
          If cnt > 0 Then DuplicateBill = True
        End Using
      End Using
      If DuplicateBill Then
        Throw New Exception("<h3>Duplicate Bill Entry NOT Allowed</h3>")
      End If

      Dim _Result As SIS.SPMT.spmtNewSBH = spmtNewSBHInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtNewSBHUpdate(ByVal Record As SIS.SPMT.spmtNewSBH) As SIS.SPMT.spmtNewSBH
      Dim DuplicateBill As Boolean = False
      Dim Sql As String = ""
      If Record.BPID = "" Then
        Sql &= " select isnull(count(irno),0) as cnt from spmt_supplierBill "
        Sql &= " where "
        Sql &= " lower(billNumber) = lower('" & Record.BillNumber & "') "
        Sql &= " and billDate = convert(datetime,'" & Record.BillDate & "',103) "
        Sql &= " and lower(suppliername) = lower('" & Record.SupplierName & "') "
        Sql &= " and irno <> " & Record.IRNo
      Else
        Sql &= " select isnull(count(irno),0) as cnt from spmt_supplierBill "
        Sql &= " where "
        Sql &= " lower(billNumber) = lower('" & Record.BillNumber & "') "
        Sql &= " and billDate = convert(datetime,'" & Record.BillDate & "',103) "
        Sql &= " and lower(BPID) = lower('" & Record.BPID & "') "
        Sql &= " and irno <> " & Record.IRNo
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim cnt As Integer = Cmd.ExecuteScalar
          If cnt > 0 Then DuplicateBill = True
        End Using
      End Using
      If DuplicateBill Then
        Throw New Exception("<h3>Duplicate Bill Entry NOT Allowed</h3>")
      End If
      Dim _Result As SIS.SPMT.spmtNewSBH = spmtNewSBHUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtNewSBHDelete(ByVal Record As SIS.SPMT.spmtNewSBH) As Integer
      Dim _Result As Integer = spmtNewSBHDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_IRNo"), TextBox).Text = ""
          CType(.FindControl("F_TranTypeID"), Object).SelectedValue = ""
          CType(.FindControl("F_SupplierName"), TextBox).Text = ""
          CType(.FindControl("F_BillNumber"), TextBox).Text = ""
          CType(.FindControl("F_BillDate"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeID"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeID_Display"), Label).Text = ""
          CType(.FindControl("F_CostCenterID"), Object).SelectedValue = ""
          CType(.FindControl("F_DepartmentID"), Object).SelectedValue = ""
          CType(.FindControl("F_BillRemarks"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID_Display"), Label).Text = ""
          CType(.FindControl("F_ShipToState"), Object).SelectedValue = ""
          CType(.FindControl("F_SupplierGSTINNumber"), TextBox).Text = ""
          CType(.FindControl("F_SupplierGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_SupplierGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_BPID"), TextBox).Text = ""
          CType(.FindControl("F_BPID_Display"), Label).Text = ""
          CType(.FindControl("F_IsgecGSTIN"), Object).SelectedValue = ""
          CType(.FindControl("F_PurchaseType"), DropDownList).SelectedValue = ""
          CType(.FindControl("F_ElementID"), TextBox).Text = ""
          CType(.FindControl("F_ElementID_Display"), Label).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
    Public Shared Sub ValidateSBH(ByVal IRNo As Integer)
      Dim tmpSBH As SIS.SPMT.spmtNewSBH = SIS.SPMT.spmtNewSBH.spmtNewSBHGetByID(IRNo)
      Dim SBDs As List(Of SIS.SPMT.spmtNewSBD) = SIS.SPMT.spmtNewSBD.spmtNewSBDSelectList(0, 9999, "", False, "", IRNo)
      Dim tmpTot As Decimal = 0
      For Each tmp As SIS.SPMT.spmtNewSBD In SBDs
        tmpTot += Convert.ToDecimal(tmp.TotalAmountINR)
      Next
      tmpSBH.TotalBillAmount = tmpTot
      SIS.SPMT.spmtNewSBH.UpdateData(tmpSBH)
    End Sub
  End Class
End Namespace
