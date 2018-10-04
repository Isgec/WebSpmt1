Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Web.Script.Serialization

Partial Class EF_spmtSupplierBill
  Inherits SIS.SYS.UpdateBase
  Public Property Editable() As Boolean
    Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Editable", value)
    End Set
  End Property
  Public Property Deleteable() As Boolean
    Get
      If ViewState("Deleteable") IsNot Nothing Then
        Return CType(ViewState("Deleteable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Deleteable", value)
    End Set
  End Property
  Public Property PrimaryKey() As String
    Get
      If ViewState("PrimaryKey") IsNot Nothing Then
        Return CType(ViewState("PrimaryKey"), String)
      End If
      Return True
    End Get
    Set(ByVal value As String)
      ViewState.Add("PrimaryKey", value)
    End Set
  End Property

  Protected Sub PurchaseType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Dim dd As DropDownList = CType(sender, DropDownList)
    Dim bn As TextBox = CType(FVspmtSupplierBill.FindControl("F_SupplierName"), TextBox)
    Dim rbn As RequiredFieldValidator = CType(FVspmtSupplierBill.FindControl("RFVSupplierName"), RequiredFieldValidator)
    Dim bgn As TextBox = CType(FVspmtSupplierBill.FindControl("F_SupplierGSTINNumber"), TextBox)
    Dim rbgn As RequiredFieldValidator = CType(FVspmtSupplierBill.FindControl("RFVSupplierGSTINNumber"), RequiredFieldValidator)

    Dim BPID As TextBox = CType(FVspmtSupplierBill.FindControl("F_BPID"), TextBox)
    Dim RFVBPID As RequiredFieldValidator = CType(FVspmtSupplierBill.FindControl("RFVBPID"), RequiredFieldValidator)
    Dim SupplierGSTIN As TextBox = CType(FVspmtSupplierBill.FindControl("F_SupplierGSTIN"), TextBox)
    Dim RFVSupplierGSTIN As RequiredFieldValidator = CType(FVspmtSupplierBill.FindControl("RFVSupplierGSTIN"), RequiredFieldValidator)
    Dim BillType As LC_spmtBillTypes = CType(FVspmtSupplierBill.FindControl("F_BillType"), LC_spmtBillTypes)
    Dim HSNSACCode As TextBox = CType(FVspmtSupplierBill.FindControl("F_HSNSACCode"), TextBox)
    Dim RFVHSNSACCode As RequiredFieldValidator = CType(FVspmtSupplierBill.FindControl("RFVHSNSACCode"), RequiredFieldValidator)
    'Dim ShipToState As LC_spmtERPStates = CType(FVspmtSupplierBill.FindControl("F_ShipToState"), LC_spmtERPStates)
    Select Case dd.SelectedValue
      Case "Purchase from Registered Dealer"
        bn.Enabled = False
        bn.CssClass = "dmytxt"
        rbn.Enabled = False
        bgn.Enabled = False
        bgn.CssClass = "dmytxt"
        rbgn.Enabled = False
        SupplierGSTIN.Enabled = True
        SupplierGSTIN.CssClass = "mytxt"
        RFVSupplierGSTIN.Enabled = True
        BillType.Enabled = True
        BillType.CssClass = "mytxt"
        HSNSACCode.Enabled = True
        HSNSACCode.CssClass = "mytxt"
        RFVHSNSACCode.Enabled = True
        'ShipToState.Enabled = True
        'ShipToState.CssClass = "mytxt"
      Case "Purchase from Composition Dealer"
        bn.Enabled = False
        bn.CssClass = "dmytxt"
        rbn.Enabled = False
        bgn.Enabled = False
        bgn.CssClass = "dmytxt"
        rbgn.Enabled = False
        SupplierGSTIN.Enabled = True
        SupplierGSTIN.CssClass = "mytxt"
        RFVSupplierGSTIN.Enabled = True
        BillType.Enabled = True
        BillType.CssClass = "mytxt"
        HSNSACCode.Enabled = True
        HSNSACCode.CssClass = "mytxt"
        RFVHSNSACCode.Enabled = True
        'ShipToState.Enabled = True
        'ShipToState.CssClass = "mytxt"
      Case "Purchase from Unregistered Dealer", "Purchase from Registered Dealer-No ITC"
        bn.Enabled = True
        bn.CssClass = "mytxt"
        rbn.Enabled = False
        bgn.Enabled = True
        bgn.CssClass = "mytxt"
        rbgn.Enabled = False
        RFVBPID.Enabled = False
        SupplierGSTIN.Enabled = True
        SupplierGSTIN.CssClass = "mytxt"
        RFVSupplierGSTIN.Enabled = False
        BillType.Enabled = True
        BillType.CssClass = "mytxt"
        BillType.RequiredFieldErrorMessage = ""
        HSNSACCode.Enabled = True
        HSNSACCode.CssClass = "mytxt"
        RFVHSNSACCode.Enabled = True
        'ShipToState.Enabled = True
        'ShipToState.CssClass = "mytxt"
        'ShipToState.RequiredFieldErrorMessage = ""
      Case "Non GST expenses bill"
        bn.Enabled = True
        bn.CssClass = "mytxt"
        rbn.Enabled = False
        bgn.Enabled = False
        bgn.CssClass = "dmytxt"
        rbgn.Enabled = False
        RFVBPID.Enabled = False
        SupplierGSTIN.Enabled = False
        SupplierGSTIN.CssClass = "dmytxt"
        RFVSupplierGSTIN.Enabled = False
        BillType.Enabled = False
        BillType.CssClass = "dmytxt"
        HSNSACCode.Enabled = False
        HSNSACCode.CssClass = "dmytxt"
        RFVHSNSACCode.Enabled = False
        'ShipToState.Enabled = False
        'ShipToState.CssClass = "dmytxt"
    End Select
  End Sub
  Protected Sub ODSspmtSupplierBill_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtSupplierBill.Selected
    Dim tmp As SIS.SPMT.spmtSupplierBill = CType(e.ReturnValue, SIS.SPMT.spmtSupplierBill)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtSupplierBill.Init
    DataClassName = "EspmtSupplierBill"
    SetFormView = FVspmtSupplierBill
  End Sub
  Protected Sub TBLspmtSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtSupplierBill.Init
    SetToolBar = TBLspmtSupplierBill
  End Sub
  Protected Sub FVspmtSupplierBill_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtSupplierBill.PreRender
    TBLspmtSupplierBill.EnableSave = Editable
    TBLspmtSupplierBill.EnableDelete = Deleteable
    If CType(FVspmtSupplierBill.FindControl("F_Quantity"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_Quantity"), TextBox).Text = "1.00"
    End If
    If CType(FVspmtSupplierBill.FindControl("F_AssessableValue"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_AssessableValue"), TextBox).Text = "0.00"
    End If
    If CType(FVspmtSupplierBill.FindControl("F_TaxAmount"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_TaxAmount"), TextBox).Text = "0.00"
    End If
    If CType(FVspmtSupplierBill.FindControl("F_CessRate"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_CessRate"), TextBox).Text = "0.00"
    End If
    If CType(FVspmtSupplierBill.FindControl("F_CessAmount"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_CessAmount"), TextBox).Text = "0.00"
    End If
    If CType(FVspmtSupplierBill.FindControl("F_TotalGST"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_TotalGST"), TextBox).Text = "0.00"
    End If
    If CType(FVspmtSupplierBill.FindControl("F_TotalAmount"), TextBox).Text = "" Then
      CType(FVspmtSupplierBill.FindControl("F_TotalAmount"), TextBox).Text = "0.00"
    End If
    PurchaseType_SelectedIndexChanged(FVspmtSupplierBill.FindControl("F_PurchaseType"), Nothing)
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtSupplierBill.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtSupplierBill") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtSupplierBill", mStr)
    End If
  End Sub
  Private Sub FVspmtSupplierBill_ItemUpdating(sender As Object, e As FormViewUpdateEventArgs) Handles FVspmtSupplierBill.ItemUpdating
    Dim Err As Boolean = False
    Dim msg As String = ""
    Dim ConversionFactorINR As Decimal = e.NewValues("ConversionFactorINR")
    If ConversionFactorINR = 0 Then
      Err = True
      msg = "Conversion factor can not be zero."
    End If
    Dim bn As TextBox = CType(FVspmtSupplierBill.FindControl("F_SupplierName"), TextBox)
    Dim BPID As TextBox = CType(FVspmtSupplierBill.FindControl("F_BPID"), TextBox)
    If bn.Text = "" And BPID.Text = "" Then
      Err = True
      msg = "Either Supplier ID or Supplier Name is Mandatory."
    End If
    Dim PurchaseType As String = e.NewValues("PurchaseType")
    Dim IGSTAmount As Decimal = e.NewValues("IGSTAmount")
    Dim SGSTAmount As Decimal = e.NewValues("SGSTAmount")
    Dim CGSTAmount As Decimal = e.NewValues("CGSTAmount")
    Select Case PurchaseType
      Case "Purchase from Registered Dealer"
        If IGSTAmount = 0 Then
          If SGSTAmount = 0 Or CGSTAmount = 0 Then
            Err = True
            msg = "If IGST Rate is Zero then SGST Rate and CGST Rate both should be entered."
          End If
        Else
          If SGSTAmount <> 0 Or CGSTAmount <> 0 Then
            Err = True
            msg = "If IGST Rate is entered then SGST Rate and CGST Rate both should be zero."
          End If
        End If
      Case "Purchase from Composition Dealer"
      Case "Purchase from Unregistered Dealer"
      Case "Non GST expenses bill"
    End Select
    If Err Then
      Dim message As String = New JavaScriptSerializer().Serialize(msg)
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End If
  End Sub

  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function SupplierGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_SupplierBill_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BillType As String = CType(aVal(1), String)
    If BillType = "" Then BillType = 0
    Dim HSNSACCode As String = CType(aVal(2), String)
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillType, HSNSACCode)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetHSNSACCodeFromERP(BillType, HSNSACCode)
      oVar = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillType, HSNSACCode)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found in ERP."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_SupplierBill_SupplierGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim SupplierGSTIN As String = CType(aVal(2), String)
    Dim sGst As Integer = 0
    If IsNumeric(SupplierGSTIN) Then
      sGst = Convert.ToInt32(SupplierGSTIN)
    End If
    Dim oVar As SIS.SPMT.spmtBPGSTIN = Nothing
    If sGst > 0 Then
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
    Else
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
    End If
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID)
      If sGst > 0 Then
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
      Else
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
      End If
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found in ERP."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_SupplierBill_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPFromERP(BPID)
      oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID, 0)
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  '<System.Web.Services.WebMethod()>
  'Public Shared Function validate_FK_SPMT_SupplierBill_HSNSACCode(ByVal value As String) As String
  '  Dim aVal() As String = value.Split(",".ToCharArray)
  '  Dim mRet As String = "0|" & aVal(0)
  '  Dim BillType As Int32 = CType(aVal(1), Int32)
  '  Dim HSNSACCode As String = CType(aVal(2), String)
  '  Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillType, HSNSACCode)
  '  If oVar Is Nothing Then
  '    mRet = "1|" & aVal(0) & "|Record not found."
  '  Else
  '    mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
  '  End If
  '  Return mRet
  'End Function
  '<System.Web.Services.WebMethod()>
  'Public Shared Function validate_FK_SPMT_SupplierBill_SupplierGSTIN(ByVal value As String) As String
  '  Dim aVal() As String = value.Split(",".ToCharArray)
  '  Dim mRet As String = "0|" & aVal(0)
  '  Dim BPID As String = CType(aVal(1), String)
  '  Dim SupplierGSTIN As Int32 = CType(aVal(2), Int32)
  '  Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
  '  If oVar Is Nothing Then
  '    mRet = "1|" & aVal(0) & "|Record not found."
  '  Else
  '    mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
  '  End If
  '  Return mRet
  'End Function
  '<System.Web.Services.WebMethod()>
  'Public Shared Function validate_FK_SPMT_SupplierBill_BPID(ByVal value As String) As String
  '  Dim aVal() As String = value.Split(",".ToCharArray)
  '  Dim mRet As String = "0|" & aVal(0)
  '  Dim BPID As String = CType(aVal(1), String)
  '  Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
  '  If oVar Is Nothing Then
  '    mRet = "1|" & aVal(0) & "|Record not found."
  '  Else
  '    mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
  '  End If
  '  Return mRet
  'End Function

End Class
