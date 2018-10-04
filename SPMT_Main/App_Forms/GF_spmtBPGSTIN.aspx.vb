Partial Class GF_spmtBPGSTIN
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtBPGSTIN.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?BPID=" & aVal(0) & "&GSTIN=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtBPGSTIN_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtBPGSTIN.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BPID As String = GVspmtBPGSTIN.DataKeys(e.CommandArgument).Values("BPID")  
        Dim GSTIN As Int32 = GVspmtBPGSTIN.DataKeys(e.CommandArgument).Values("GSTIN")  
        Dim RedirectUrl As String = TBLspmtBPGSTIN.EditUrl & "?BPID=" & BPID & "&GSTIN=" & GSTIN
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtBPGSTIN.Init
    DataClassName = "GspmtBPGSTIN"
    SetGridView = GVspmtBPGSTIN
  End Sub
  Protected Sub TBLspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBPGSTIN.Init
    SetToolBar = TBLspmtBPGSTIN
  End Sub
  Protected Sub F_BPID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_BPID.TextChanged
    Session("F_BPID") = F_BPID.Text
    Session("F_BPID_Display") = F_BPID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_BPID_Display.Text = String.Empty
    If Not Session("F_BPID_Display") Is Nothing Then
      If Session("F_BPID_Display") <> String.Empty Then
        F_BPID_Display.Text = Session("F_BPID_Display")
      End If
    End If
    F_BPID.Text = String.Empty
    If Not Session("F_BPID") Is Nothing Then
      If Session("F_BPID") <> String.Empty Then
        F_BPID.Text = Session("F_BPID")
      End If
    End If
    Dim strScriptBPID As String = "<script type=""text/javascript""> " & _
      "function ACEBPID_Selected(sender, e) {" & _
      "  var F_BPID = $get('" & F_BPID.ClientID & "');" & _
      "  var F_BPID_Display = $get('" & F_BPID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_BPID.value = p[0];" & _
      "  F_BPID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BPID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BPID", strScriptBPID)
      End If
    Dim strScriptPopulatingBPID As String = "<script type=""text/javascript""> " & _
      "function ACEBPID_Populating(o,e) {" & _
      "  var p = $get('" & F_BPID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEBPID_Populated(o,e) {" & _
      "  var p = $get('" & F_BPID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BPIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BPIDPopulating", strScriptPopulatingBPID)
      End If
    Dim validateScriptBPID As String = "<script type=""text/javascript"">" & _
      "  function validate_BPID(o) {" & _
      "    validated_FK_VR_BPGSTIN_BPID_main = true;" & _
      "    validate_FK_VR_BPGSTIN_BPID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateBPID", validateScriptBPID)
    End If
    Dim validateScriptFK_VR_BPGSTIN_BPID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_VR_BPGSTIN_BPID(o) {" & _
      "    var value = o.id;" & _
      "    var BPID = $get('" & F_BPID.ClientID & "');" & _
      "    try{" & _
      "    if(BPID.value==''){" & _
      "      if(validated_FK_VR_BPGSTIN_BPID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + BPID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_VR_BPGSTIN_BPID(value, validated_FK_VR_BPGSTIN_BPID);" & _
      "  }" & _
      "  validated_FK_VR_BPGSTIN_BPID_main = false;" & _
      "  function validated_FK_VR_BPGSTIN_BPID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_VR_BPGSTIN_BPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_VR_BPGSTIN_BPID", validateScriptFK_VR_BPGSTIN_BPID)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_VR_BPGSTIN_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
