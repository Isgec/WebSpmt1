Partial Class AF_spmtDCDetails
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCDetails.Init
    DataClassName = "AspmtDCDetails"
    SetFormView = FVspmtDCDetails
  End Sub
  Protected Sub TBLspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCDetails.Init
    SetToolBar = TBLspmtDCDetails
  End Sub
  Protected Sub FVspmtDCDetails_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCDetails.DataBound
    SIS.SPMT.spmtDCDetails.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtDCDetails_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCDetails.PreRender
    Dim oF_ChallanID_Display As Label  = FVspmtDCDetails.FindControl("F_ChallanID_Display")
    oF_ChallanID_Display.Text = String.Empty
    If Not Session("F_ChallanID_Display") Is Nothing Then
      If Session("F_ChallanID_Display") <> String.Empty Then
        oF_ChallanID_Display.Text = Session("F_ChallanID_Display")
      End If
    End If
    Dim oF_ChallanID As TextBox  = FVspmtDCDetails.FindControl("F_ChallanID")
    oF_ChallanID.Enabled = True
    oF_ChallanID.Text = String.Empty
    If Not Session("F_ChallanID") Is Nothing Then
      If Session("F_ChallanID") <> String.Empty Then
        oF_ChallanID.Text = Session("F_ChallanID")
      End If
    End If
    Dim oF_HSNSACCode_Display As Label  = FVspmtDCDetails.FindControl("F_HSNSACCode_Display")
    Dim oF_HSNSACCode As TextBox  = FVspmtDCDetails.FindControl("F_HSNSACCode")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtDCDetails.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCDetails") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCDetails", mStr)
    End If
    If Request.QueryString("ChallanID") IsNot Nothing Then
      CType(FVspmtDCDetails.FindControl("F_ChallanID"), TextBox).Text = Request.QueryString("ChallanID")
      CType(FVspmtDCDetails.FindControl("F_ChallanID"), TextBox).Enabled = False
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVspmtDCDetails.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVspmtDCDetails.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtDCHeader.SelectspmtDCHeaderAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCDetails_ChallanID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ChallanID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtDCHeader = SIS.SPMT.spmtDCHeader.spmtDCHeaderGetByID(ChallanID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCDetails_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BillTypeID As String = CType(aVal(1), Int32)
    Dim HSNSACCode As String = CType(aVal(2),String)
    If BillTypeID = "" Then BillTypeID = 0
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillTypeID, HSNSACCode)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetHSNSACCodeFromERP(BillTypeID, HSNSACCode)
      oVar = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillTypeID, HSNSACCode)
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

End Class
