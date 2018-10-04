Partial Class GF_spmtDCDetails
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtDCDetails.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ChallanID=" & aVal(0) & "&SerialNo=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtDCDetails_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtDCDetails.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCDetails.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim SerialNo As Int32 = GVspmtDCDetails.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim RedirectUrl As String = TBLspmtDCDetails.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtDCDetails.Init
    DataClassName = "GspmtDCDetails"
    SetGridView = GVspmtDCDetails
  End Sub
  Protected Sub TBLspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCDetails.Init
    SetToolBar = TBLspmtDCDetails
  End Sub
  Protected Sub F_ChallanID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_ChallanID.TextChanged
    Session("F_ChallanID") = F_ChallanID.Text
    Session("F_ChallanID_Display") = F_ChallanID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtDCHeader.SelectspmtDCHeaderAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_ChallanID_Display.Text = String.Empty
    If Not Session("F_ChallanID_Display") Is Nothing Then
      If Session("F_ChallanID_Display") <> String.Empty Then
        F_ChallanID_Display.Text = Session("F_ChallanID_Display")
      End If
    End If
    F_ChallanID.Text = String.Empty
    If Not Session("F_ChallanID") Is Nothing Then
      If Session("F_ChallanID") <> String.Empty Then
        F_ChallanID.Text = Session("F_ChallanID")
      End If
    End If
    Dim strScriptChallanID As String = "<script type=""text/javascript""> " & _
      "function ACEChallanID_Selected(sender, e) {" & _
      "  var F_ChallanID = $get('" & F_ChallanID.ClientID & "');" & _
      "  var F_ChallanID_Display = $get('" & F_ChallanID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_ChallanID.value = p[0];" & _
      "  F_ChallanID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_ChallanID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_ChallanID", strScriptChallanID)
      End If
    Dim strScriptPopulatingChallanID As String = "<script type=""text/javascript""> " & _
      "function ACEChallanID_Populating(o,e) {" & _
      "  var p = $get('" & F_ChallanID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEChallanID_Populated(o,e) {" & _
      "  var p = $get('" & F_ChallanID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_ChallanIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_ChallanIDPopulating", strScriptPopulatingChallanID)
      End If
    Dim validateScriptChallanID As String = "<script type=""text/javascript"">" & _
      "  function validate_ChallanID(o) {" & _
      "    validated_FK_SPMT_DCDetails_ChallanID_main = true;" & _
      "    validate_FK_SPMT_DCDetails_ChallanID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateChallanID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateChallanID", validateScriptChallanID)
    End If
    Dim validateScriptFK_SPMT_DCDetails_ChallanID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_DCDetails_ChallanID(o) {" & _
      "    var value = o.id;" & _
      "    var ChallanID = $get('" & F_ChallanID.ClientID & "');" & _
      "    try{" & _
      "    if(ChallanID.value==''){" & _
      "      if(validated_FK_SPMT_DCDetails_ChallanID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + ChallanID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_DCDetails_ChallanID(value, validated_FK_SPMT_DCDetails_ChallanID);" & _
      "  }" & _
      "  validated_FK_SPMT_DCDetails_ChallanID_main = false;" & _
      "  function validated_FK_SPMT_DCDetails_ChallanID(result) {" & _
      "    var p = result.split('|');" & _
      "    var o = $get(p[1]);" & _
      "    var o_d = $get(p[1]+'_Display');" & _
      "    try{o_d.innerHTML = p[2];}catch(ex){}" & _
      "    o.style.backgroundImage  = 'none';" & _
      "    if(p[0]=='1'){" & _
      "      o.value='';" & _
      "      try{o_d.innerHTML = '';}catch(ex){}" & _
      "      __doPostBack(o.id, o.value);" & _
      "    }" & _
      "    else" & _
      "      __doPostBack(o.id, o.value);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_DCDetails_ChallanID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_DCDetails_ChallanID", validateScriptFK_SPMT_DCDetails_ChallanID)
    End If
  End Sub
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
End Class
