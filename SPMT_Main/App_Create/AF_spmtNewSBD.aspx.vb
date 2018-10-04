Imports System.Web.Script.Serialization
Partial Class AF_spmtNewSBD
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtNewSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBD.Init
    DataClassName = "AspmtNewSBD"
    SetFormView = FVspmtNewSBD
  End Sub
  Protected Sub TBLspmtNewSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewSBD.Init
    SetToolBar = TBLspmtNewSBD
  End Sub
  Protected Sub FVspmtNewSBD_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBD.DataBound
    SIS.SPMT.spmtNewSBD.SetDefaultValues(sender, e)
  End Sub
  Protected Sub FVspmtNewSBD_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBD.PreRender
    Dim oF_IRNo_Display As Label = FVspmtNewSBD.FindControl("F_IRNo_Display")
    oF_IRNo_Display.Text = String.Empty
    If Not Session("F_IRNo_Display") Is Nothing Then
      If Session("F_IRNo_Display") <> String.Empty Then
        oF_IRNo_Display.Text = Session("F_IRNo_Display")
      End If
    End If
    Dim oF_IRNo As TextBox = FVspmtNewSBD.FindControl("F_IRNo")
    oF_IRNo.Enabled = True
    oF_IRNo.Text = String.Empty
    If Not Session("F_IRNo") Is Nothing Then
      If Session("F_IRNo") <> String.Empty Then
        oF_IRNo.Text = Session("F_IRNo")
      End If
    End If
    Dim oF_HSNSACCode_Display As Label = FVspmtNewSBD.FindControl("F_HSNSACCode_Display")
    Dim oF_HSNSACCode As TextBox = FVspmtNewSBD.FindControl("F_HSNSACCode")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtNewSBD.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewSBD") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewSBD", mStr)
    End If
    If Request.QueryString("IRNo") IsNot Nothing Then
      CType(FVspmtNewSBD.FindControl("F_IRNo"), TextBox).Text = Request.QueryString("IRNo")
      CType(FVspmtNewSBD.FindControl("F_IRNo"), TextBox).Enabled = False
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVspmtNewSBD.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVspmtNewSBD.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function IRNoCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtNewSBH.SelectspmtNewSBHAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBD_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BillType As String = CType(aVal(1), String)
    Dim HSNSACCode As String = CType(aVal(2), String)
    If BillType = "" Then BillType = 0
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
  Public Shared Function validate_FK_SPMT_newSBD_IRNo(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim IRNo As Int32 = CType(aVal(1), Int32)
    Dim oVar As SIS.SPMT.spmtNewSBH = SIS.SPMT.spmtNewSBH.spmtNewSBHGetByID(IRNo)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  Private Sub FVspmtNewSBD_ItemInserting(sender As Object, e As FormViewInsertEventArgs) Handles FVspmtNewSBD.ItemInserting
    Dim Err As Boolean = False
    Dim msg As String = ""
    Dim IRNo As String = e.Values("IRNo")
    Dim oIR As SIS.SPMT.spmtNewSBH = SIS.SPMT.spmtNewSBH.spmtNewSBHGetByID(IRNo)
    Dim PurchaseType As String = oIR.PurchaseType
    Dim IGSTAmount As Decimal = e.Values("IGSTAmount")
    Dim SGSTAmount As Decimal = e.Values("SGSTAmount")
    Dim CGSTAmount As Decimal = e.Values("CGSTAmount")
    Dim BillType As String = e.Values("BillType")
    Dim HSNSACCode As String = e.Values("HSNSACCode")
    Select Case PurchaseType
      Case "Purchase from Registered Dealer", "Purchase from Composition Dealer"
        If IGSTAmount <= 0 Then
          If SGSTAmount = 0 Or CGSTAmount = 0 Then
            Err = True
            msg = "If IGST Amount is Zero then SGST Amount and CGST Amount both should be entered."
          End If
        Else
          If SGSTAmount > 0 Or CGSTAmount > 0 Then
            Err = True
            msg = "If IGST Amount is entered then SGST Amount and CGST Amount both should be zero."
          End If
        End If
        If BillType = "" Then
          Err = True
          msg = "Bill Type is Mandatory."
        End If
        If HSNSACCode = "" Then
          Err = True
          msg = "HSN / SAC Code is Mandatory."
        End If
      Case "Purchase from Unregistered Dealer"
        If BillType = "" Then
          Err = True
          msg = "Bill Type is Mandatory."
        End If
        If HSNSACCode = "" Then
          Err = True
          msg = "HSN / SAC Code is Mandatory."
        End If
      Case "Non GST expenses bill"
    End Select
    If Err Then
      Dim message As String = New JavaScriptSerializer().Serialize(msg)
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End If
  End Sub
End Class
