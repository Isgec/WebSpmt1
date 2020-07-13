Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtSupplierBill
    Public Shared ReadOnly Property AthHandle As String
      Get
        Dim mRet As String = "J_SPMTSUPPLIERBILL"
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
        mRet &= "/Attachment/Attachment.aspx?AthHandle=" & SIS.SPMT.spmtSupplierBill.AthHandle
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

    Public Property SourceApplication As String
      Get
        Return DocumentNo
      End Get
      Set(value As String)
        DocumentNo = value
      End Set
    End Property
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Black
      Select Case BillStatusID
        Case 6
          mRet = Drawing.Color.Green
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
      Select Case BillStatusID
        Case 4
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
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function UZ_spmtSupplierBillSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal PurchaseType As String, ByVal IRNo As Int32, ByVal TranTypeID As String, ByVal BPID As String) As List(Of SIS.SPMT.spmtSupplierBill)
      Dim Results As List(Of SIS.SPMT.spmtSupplierBill) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_SupplierBillSelectListSearch"
            Cmd.CommandText = "spspmtSupplierBillSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_SupplierBillSelectListFilteres"
            Cmd.CommandText = "spspmtSupplierBillSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_PurchaseType", SqlDbType.NVarChar, 50, IIf(PurchaseType Is Nothing, String.Empty, PurchaseType))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IRNo", SqlDbType.Int, 10, IIf(IRNo = Nothing, 0, IRNo))
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
          Results = New List(Of SIS.SPMT.spmtSupplierBill)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtSupplierBill(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtSupplierBillInsert(ByVal Record As SIS.SPMT.spmtSupplierBill) As SIS.SPMT.spmtSupplierBill
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
      Dim _Rec As SIS.SPMT.spmtSupplierBill = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetNewRecord()
      With _Rec
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .BillStatusID = 4
        .BillStatusDate = Now
        .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
        .DocNo = "SPMT"
        .BillAmount = Record.TotalAmountINR
        .IRReceivedOn = Now
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .Quantity = Record.Quantity
        .UOM = Record.UOM
        .Currency = Record.Currency
        .BillRemarks = Record.BillRemarks
        .IsgecGSTIN = Record.IsgecGSTIN
        .BPID = Record.BPID
        .SupplierGSTIN = Record.SupplierGSTIN
        If .BPID <> String.Empty Then
          .SupplierName = .FK_SPMT_SupplierBill_BPID.BPName
          If .SupplierGSTIN <> String.Empty Then
            .SupplierGSTINNumber = .FK_SPMT_SupplierBill_SupplierGSTIN.Description.ToUpper
          Else
            .SupplierGSTINNumber = Record.SupplierGSTINNumber.ToUpper
          End If
        Else
          .SupplierName = Record.SupplierName
          .SupplierGSTINNumber = Record.SupplierGSTINNumber.ToUpper
        End If
        .ShipToState = Record.ShipToState
        .HSNSACCode = Record.HSNSACCode
        .BillType = Record.BillType
        .ConversionFactorINR = Record.ConversionFactorINR
        .TotalGST = Record.TotalGST
        .CessAmount = Record.CessAmount
        .CessRate = Record.CessRate
        .TaxAmount = Record.TaxAmount
        .RemarksGST = Record.RemarksGST
        .TotalAmountINR = Record.TotalAmountINR
        .TotalAmount = Record.TotalAmount
        .IGSTAmount = Record.IGSTAmount
        .IGSTRate = Record.IGSTRate
        .AssessableValue = Record.AssessableValue
        .CGSTRate = Record.CGSTRate
        .SGSTAmount = Record.SGSTAmount
        .SGSTRate = Record.SGSTRate
        .CGSTAmount = Record.CGSTAmount
        .PurchaseType = Record.PurchaseType
        .DepartmentID = Record.DepartmentID
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtSupplierBill.InsertData(_Rec)
    End Function
    Public Shared Function UZ_spmtSupplierBillUpdate(ByVal Record As SIS.SPMT.spmtSupplierBill) As SIS.SPMT.spmtSupplierBill
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
      Dim _Rec As SIS.SPMT.spmtSupplierBill = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(Record.IRNo)
      With _Rec
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .BillStatusID = 4
        .BillStatusDate = Now
        .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
        .BillAmount = Record.TotalAmountINR
        .IRReceivedOn = Now
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .Quantity = Record.Quantity
        .UOM = Record.UOM
        .Currency = Record.Currency
        .BillRemarks = Record.BillRemarks
        .IsgecGSTIN = Record.IsgecGSTIN
        .BPID = Record.BPID
        .SupplierGSTIN = Record.SupplierGSTIN
        If .BPID <> String.Empty Then
          .SupplierName = .FK_SPMT_SupplierBill_BPID.BPName
          If .SupplierGSTIN <> String.Empty Then
            .SupplierGSTINNumber = .FK_SPMT_SupplierBill_SupplierGSTIN.Description.ToUpper
          Else
            .SupplierGSTINNumber = Record.SupplierGSTINNumber.ToUpper
          End If
        Else
          .SupplierName = Record.SupplierName
          .SupplierGSTINNumber = Record.SupplierGSTINNumber.ToUpper
        End If
        .ShipToState = Record.ShipToState
        .HSNSACCode = Record.HSNSACCode
        .BillType = Record.BillType
        .ConversionFactorINR = Record.ConversionFactorINR
        .TotalGST = Record.TotalGST
        .CessAmount = Record.CessAmount
        .CessRate = Record.CessRate
        .TaxAmount = Record.TaxAmount
        .RemarksGST = Record.RemarksGST
        .TotalAmountINR = Record.TotalAmountINR
        .TotalAmount = Record.TotalAmount
        .IGSTAmount = Record.IGSTAmount
        .IGSTRate = Record.IGSTRate
        .AssessableValue = Record.AssessableValue
        .CGSTRate = Record.CGSTRate
        .SGSTAmount = Record.SGSTAmount
        .SGSTRate = Record.SGSTRate
        .CGSTAmount = Record.CGSTAmount
        .PurchaseType = Record.PurchaseType
        .DepartmentID = Record.DepartmentID
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtSupplierBill.UpdateData(_Rec)
    End Function
    Public Shared Function UZ_spmtSupplierBillDelete(ByVal Record As SIS.SPMT.spmtSupplierBill) As Integer
      Dim _Result As Integer = spmtSupplierBillDelete(Record)
      Return _Result
    End Function
    'Public Shared Function GetBPFromERP(ByVal BPID As String, Optional ByVal Comp As String = "200") As SIS.SPMT.spmtBusinessPartner
    '  Dim Results As SIS.SPMT.spmtBusinessPartner = Nothing
    '  Dim Sql As String = ""
    '  Sql &= "select                                                     "
    '  Sql &= "  suh.t_bpid as BPID,                                      "
    '  Sql &= "  suh.t_nama as BPName,                                    "
    '  Sql &= "  adh.t_ln01 as Address1Line,                              "
    '  Sql &= "  adh.t_ln02 as Address2Line,                                    "
    '  Sql &= "  adh.t_ln03 as Address3,                                        "
    '  Sql &= "  adh.t_ln04 as Address4,                                        "
    '  Sql &= "  adh.t_ln05 as City,                                            "
    '  Sql &= "  adh.t_ln06 as State,                                           "
    '  Sql &= "  adh.t_pstc as Zip,                                             "
    '  Sql &= "  adh.t_ccty as Country,                                         "
    '  Sql &= "  cnh.t_fuln as ContactPerson,                                   "
    '  Sql &= "  cnh.t_telp as ContactNo,                                       "
    '  Sql &= "  cnh.t_info as EMailID                                          "
    '  Sql &= "  from ttccom100" & Comp & " as suh                                       "
    '  Sql &= "  left outer join ttccom130" & Comp & " as adh on suh.t_cadr = adh.t_cadr "
    '  Sql &= "  left outer join ttccom140" & Comp & " as cnh on suh.t_ccnt = cnh.t_ccnt "
    '  Sql &= "  where suh.t_bpid ='" & BPID & "'"
    '  Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
    '    Using Cmd As SqlCommand = Con.CreateCommand()
    '      Cmd.CommandType = CommandType.Text
    '      Cmd.CommandText = Sql
    '      Con.Open()
    '      Dim Reader As SqlDataReader = Cmd.ExecuteReader()
    '      If Reader.Read() Then
    '        Results = New SIS.SPMT.spmtBusinessPartner(Reader)
    '      End If
    '      Reader.Close()
    '    End Using
    '  End Using
    '  If Results IsNot Nothing Then
    '    If Comp <> "200" Then Results.BPID = "S" & Comp & Right(Results.BPID, 5)
    '    Try
    '      Results = SIS.SPMT.spmtBusinessPartner.InsertData(Results)
    '    Catch ex As Exception
    '    End Try
    '    If Comp <> "200" Then
    '      GetBPGSTINFromERP(BPID, 0, Comp, Results.BPID)
    '    Else
    '      GetBPGSTINFromERP(Results.BPID, 0)
    '    End If
    '  End If
    '  Return Results
    'End Function
    'Public Shared Function GetBPGSTINFromERP(ByVal BPID As String, Optional ByVal GSTIN As Int32 = 0, Optional ByVal Comp As String = "200", Optional ByVal NewBPID As String = "") As List(Of SIS.SPMT.spmtBPGSTIN)
    '  Dim Results As New List(Of SIS.SPMT.spmtBPGSTIN)
    '  Dim Sql As String = ""
    '  Sql &= "select                                "
    '  Sql &= "  t_bpid as BPID,                     "
    '  Sql &= "  t_fovn as Description,              "
    '  Sql &= "  t_seqn_l as GSTIN                   "
    '  Sql &= "  from ttctax400" & Comp & "                   "
    '  Sql &= "  where t_bpid ='" & BPID & "'"
    '  Sql &= "  and t_catg_l = 9 "
    '  If GSTIN > 0 Then
    '    Sql &= "  and t_seqn_l ='" & GSTIN & "'"
    '  End If
    '  Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
    '    Using Cmd As SqlCommand = Con.CreateCommand()
    '      Cmd.CommandType = CommandType.Text
    '      Cmd.CommandText = Sql
    '      Con.Open()
    '      Dim Reader As SqlDataReader = Cmd.ExecuteReader()
    '      While Reader.Read()
    '        Results.Add(New SIS.SPMT.spmtBPGSTIN(Reader))
    '      End While
    '      Reader.Close()
    '    End Using
    '  End Using
    '  If Results.Count > 0 Then
    '    For Each tmp As SIS.SPMT.spmtBPGSTIN In Results
    '      If Comp <> "200" Then tmp.BPID = NewBPID
    '      Try
    '        SIS.SPMT.spmtBPGSTIN.InsertData(tmp)
    '      Catch ex As Exception
    '        Try
    '          SIS.SPMT.spmtBPGSTIN.UpdateData(tmp)
    '        Catch exX As Exception
    '        End Try
    '      End Try
    '    Next
    '  End If
    '  Return Results
    'End Function
    Public Shared Function GetHSNSACCodeFromERP(ByVal BillType As Int32, ByVal HSNSACCode As String) As SIS.SPMT.spmtHSNSACCodes
      Dim Comp As String = HttpContext.Current.Session("FinanceCompany")
      Dim Results As SIS.SPMT.spmtHSNSACCodes = Nothing
      Dim Sql As String = ""
      Sql &= "select                                "
      Sql &= "  t_ityp as BillType,                 "
      Sql &= "  t_code as HSNSACCode,               "
      Sql &= "  t_pvat as TaxRate,                  "
      Sql &= "  t_desc as Description               "
      Sql &= "  from ttcisg124" & Comp
      Sql &= "  where t_ityp =" & BillType
      Sql &= "  and t_code = '" & HSNSACCode & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtHSNSACCodes(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      If Results IsNot Nothing Then
        Results = SIS.SPMT.spmtHSNSACCodes.InsertData(Results)
      End If
      Return Results
    End Function

    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_PurchaseType"), DropDownList).SelectedValue = ""
          CType(.FindControl("F_IRNo"), TextBox).Text = ""
          CType(.FindControl("F_TranTypeID"), Object).SelectedValue = ""
          CType(.FindControl("F_IsgecGSTIN"), Object).SelectedValue = ""
          CType(.FindControl("F_BPID"), TextBox).Text = ""
          CType(.FindControl("F_BPID_Display"), Label).Text = ""
          CType(.FindControl("F_SupplierGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_SupplierGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_BillType"), Object).SelectedValue = ""
          CType(.FindControl("F_HSNSACCode"), TextBox).Text = ""
          CType(.FindControl("F_HSNSACCode_Display"), Label).Text = ""
          CType(.FindControl("F_ShipToState"), Object).SelectedValue = ""
          CType(.FindControl("F_BillNumber"), TextBox).Text = ""
          CType(.FindControl("F_BillDate"), TextBox).Text = ""
          CType(.FindControl("F_BillRemarks"), TextBox).Text = ""
          CType(.FindControl("F_UOM"), Object).SelectedValue = ""
          CType(.FindControl("F_Quantity"), TextBox).Text = 0
          CType(.FindControl("F_Currency"), DropDownList).SelectedValue = ""
          CType(.FindControl("F_ConversionFactorINR"), TextBox).Text = 0
          CType(.FindControl("F_AssessableValue"), TextBox).Text = 0
          CType(.FindControl("F_IGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_IGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_CGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_CGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_SGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_SGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_CessRate"), TextBox).Text = 0
          CType(.FindControl("F_CessAmount"), TextBox).Text = 0
          CType(.FindControl("F_TotalGST"), TextBox).Text = 0
          CType(.FindControl("F_TaxAmount"), TextBox).Text = 0
          CType(.FindControl("F_TotalAmount"), TextBox).Text = 0
          CType(.FindControl("F_TotalAmountINR"), TextBox).Text = 0
          CType(.FindControl("F_RemarksGST"), TextBox).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
    Public Shared Function getByAirTIRNo(ByVal IRNo As Int32) As SIS.SPMT.spmtSupplierBill
      Dim Results As SIS.SPMT.spmtSupplierBill = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmt_LG_SupplierBillSelectByAirTIRNo"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo", SqlDbType.Int, IRNo.ToString.Length, IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtSupplierBill(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
  End Class
End Namespace
