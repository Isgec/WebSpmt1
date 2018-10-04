Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Web.Script.Serialization
Partial Class AF_spmtSupplierBill
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtSupplierBill.Init
    DataClassName = "AspmtSupplierBill"
    SetFormView = FVspmtSupplierBill
  End Sub
  Protected Sub TBLspmtSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtSupplierBill.Init
    SetToolBar = TBLspmtSupplierBill
  End Sub
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
  Protected Sub FVspmtSupplierBill_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtSupplierBill.DataBound
    CType(FVspmtSupplierBill.FindControl("F_UOM"), LC_spmtERPUnits).SelectedValue = "nos"
    CType(FVspmtSupplierBill.FindControl("F_Currency"), DropDownList).SelectedValue = "INR"
    CType(FVspmtSupplierBill.FindControl("F_Quantity"), TextBox).Text = "1.00"
    CType(FVspmtSupplierBill.FindControl("F_AssessableValue"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_CessRate"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_CessAmount"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_TotalGST"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_TaxAmount"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_TotalAmount"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_ConversionFactorINR"), TextBox).Text = "1.000000"
    CType(FVspmtSupplierBill.FindControl("F_TotalAmountINR"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_IGSTRate"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_IGSTAmount"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_SGSTRate"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_SGSTAmount"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_CGSTRate"), TextBox).Text = "0.00"
    CType(FVspmtSupplierBill.FindControl("F_CGSTAmount"), TextBox).Text = "0.00"
  End Sub
  Protected Sub FVspmtSupplierBill_ItemInserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.FormViewInsertEventArgs) Handles FVspmtSupplierBill.ItemInserting
    Dim Err As Boolean = False
    Dim msg As String = ""
    Dim ConversionFactorINR As Decimal = e.Values("ConversionFactorINR")
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
    Dim PurchaseType As String = e.Values("PurchaseType")
    Dim IGSTAmount As Decimal = e.Values("IGSTAmount")
    Dim SGSTAmount As Decimal = e.Values("SGSTAmount")
    Dim CGSTAmount As Decimal = e.Values("CGSTAmount")
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

  'Protected Sub FVspmtSupplierBill_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtSupplierBill.DataBound
  '  SIS.SPMT.spmtSupplierBill.SetDefaultValues(sender, e) 
  'End Sub
  Protected Sub FVspmtSupplierBill_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtSupplierBill.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtSupplierBill.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtSupplierBill") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtSupplierBill", mStr)
    End If
    If Request.QueryString("IRNo") IsNot Nothing Then
      CType(FVspmtSupplierBill.FindControl("F_IRNo"), TextBox).Text = Request.QueryString("IRNo")
      CType(FVspmtSupplierBill.FindControl("F_IRNo"), TextBox).Enabled = False
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

  '<System.Web.Services.WebMethod()> _
  'Public Shared Function validate_FK_SPMT_SupplierBill_HSNSACCode(ByVal value As String) As String
  '  Dim aVal() As String = value.Split(",".ToCharArray)
  '  Dim mRet As String="0|" & aVal(0)
  '  Dim BillType As Int32 = CType(aVal(1),Int32)
  '  Dim HSNSACCode As String = CType(aVal(2),String)
  '  Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillType,HSNSACCode)
  '  If oVar Is Nothing Then
  '    mRet = "1|" & aVal(0) & "|Record not found." 
  '  Else
  '    mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
  '  End If
  '  Return mRet
  'End Function
  '<System.Web.Services.WebMethod()> _
  'Public Shared Function validate_FK_SPMT_SupplierBill_SupplierGSTIN(ByVal value As String) As String
  '  Dim aVal() As String = value.Split(",".ToCharArray)
  '  Dim mRet As String="0|" & aVal(0)
  '  Dim BPID As String = CType(aVal(1),String)
  '  Dim SupplierGSTIN As Int32 = CType(aVal(2),Int32)
  '  Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID,SupplierGSTIN)
  '  If oVar Is Nothing Then
  '    mRet = "1|" & aVal(0) & "|Record not found." 
  '  Else
  '    mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
  '  End If
  '  Return mRet
  'End Function
  '<System.Web.Services.WebMethod()> _
  'Public Shared Function validate_FK_SPMT_SupplierBill_BPID(ByVal value As String) As String
  '  Dim aVal() As String = value.Split(",".ToCharArray)
  '  Dim mRet As String="0|" & aVal(0)
  '  Dim BPID As String = CType(aVal(1),String)
  '  Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
  '  If oVar Is Nothing Then
  '    mRet = "1|" & aVal(0) & "|Record not found." 
  '  Else
  '    mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
  '  End If
  '  Return mRet
  'End Function

End Class
