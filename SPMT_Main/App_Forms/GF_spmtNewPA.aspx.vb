Imports System.Web.Script.Serialization
Partial Class GF_spmtNewPA
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtNewPA.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl & "?AdviceNo=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtNewPA_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtNewPA.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtNewPA.DataKeys(e.CommandArgument).Values("AdviceNo")
        Dim RedirectUrl As String = TBLspmtNewPA.EditUrl & "?AdviceNo=" & AdviceNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "initiatewf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtNewPA.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtNewPA.InitiateWF(AdviceNo)
        GVspmtNewPA.DataBind()
      Catch ex As Exception
        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      End Try
    End If
  End Sub
  Protected Sub GVspmtNewPA_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtNewPA.Init
    DataClassName = "GspmtNewPA"
    SetGridView = GVspmtNewPA
  End Sub
  Protected Sub TBLspmtNewPA_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewPA.Init
    SetToolBar = TBLspmtNewPA
  End Sub
  Protected Sub F_TranTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_TranTypeID.SelectedIndexChanged
    Session("F_TranTypeID") = F_TranTypeID.SelectedValue
    InitGridPage()
  End Sub
  Protected Sub F_CreatedBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_CreatedBy.TextChanged
    Session("F_CreatedBy") = F_CreatedBy.Text
    Session("F_CreatedBy_Display") = F_CreatedBy_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function CreatedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_BPID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_BPID.TextChanged
    Session("F_BPID") = F_BPID.Text
    Session("F_BPID_Display") = F_BPID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        F_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    F_CreatedBy_Display.Text = String.Empty
    If Not Session("F_CreatedBy_Display") Is Nothing Then
      If Session("F_CreatedBy_Display") <> String.Empty Then
        F_CreatedBy_Display.Text = Session("F_CreatedBy_Display")
      End If
    End If
    F_CreatedBy.Text = String.Empty
    If Not Session("F_CreatedBy") Is Nothing Then
      If Session("F_CreatedBy") <> String.Empty Then
        F_CreatedBy.Text = Session("F_CreatedBy")
      End If
    End If
    Dim strScriptCreatedBy As String = "<script type=""text/javascript""> " &
      "function ACECreatedBy_Selected(sender, e) {" &
      "  var F_CreatedBy = $get('" & F_CreatedBy.ClientID & "');" &
      "  var F_CreatedBy_Display = $get('" & F_CreatedBy_Display.ClientID & "');" &
      "  var retval = e.get_value();" &
      "  var p = retval.split('|');" &
      "  F_CreatedBy.value = p[0];" &
      "  F_CreatedBy_Display.innerHTML = e.get_text();" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("F_CreatedBy") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_CreatedBy", strScriptCreatedBy)
    End If
    Dim strScriptPopulatingCreatedBy As String = "<script type=""text/javascript""> " &
      "function ACECreatedBy_Populating(o,e) {" &
      "  var p = $get('" & F_CreatedBy.ClientID & "');" &
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" &
      "  p.style.backgroundRepeat= 'no-repeat';" &
      "  p.style.backgroundPosition = 'right';" &
      "  o._contextKey = '';" &
      "}" &
      "function ACECreatedBy_Populated(o,e) {" &
      "  var p = $get('" & F_CreatedBy.ClientID & "');" &
      "  p.style.backgroundImage  = 'none';" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("F_CreatedByPopulating") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_CreatedByPopulating", strScriptPopulatingCreatedBy)
    End If
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
    Dim strScriptBPID As String = "<script type=""text/javascript""> " &
      "function ACEBPID_Selected(sender, e) {" &
      "  var F_BPID = $get('" & F_BPID.ClientID & "');" &
      "  var F_BPID_Display = $get('" & F_BPID_Display.ClientID & "');" &
      "  var retval = e.get_value();" &
      "  var p = retval.split('|');" &
      "  F_BPID.value = p[0];" &
      "  F_BPID_Display.innerHTML = e.get_text();" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BPID", strScriptBPID)
    End If
    Dim strScriptPopulatingBPID As String = "<script type=""text/javascript""> " &
      "function ACEBPID_Populating(o,e) {" &
      "  var p = $get('" & F_BPID.ClientID & "');" &
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" &
      "  p.style.backgroundRepeat= 'no-repeat';" &
      "  p.style.backgroundPosition = 'right';" &
      "  o._contextKey = '';" &
      "}" &
      "function ACEBPID_Populated(o,e) {" &
      "  var p = $get('" & F_BPID.ClientID & "');" &
      "  p.style.backgroundImage  = 'none';" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BPIDPopulating") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BPIDPopulating", strScriptPopulatingBPID)
    End If
    Dim validateScriptCreatedBy As String = "<script type=""text/javascript"">" &
      "  function validate_CreatedBy(o) {" &
      "    validated_FK_SPMT_newPA_CreatedOn_main = true;" &
      "    validate_FK_SPMT_newPA_CreatedOn(o);" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateCreatedBy") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateCreatedBy", validateScriptCreatedBy)
    End If
    Dim validateScriptBPID As String = "<script type=""text/javascript"">" &
      "  function validate_BPID(o) {" &
      "    validated_FK_SPMT_newPA_BPID_main = true;" &
      "    validate_FK_SPMT_newPA_BPID(o);" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateBPID", validateScriptBPID)
    End If
    Dim validateScriptFK_SPMT_newPA_CreatedOn As String = "<script type=""text/javascript"">" &
      "  function validate_FK_SPMT_newPA_CreatedOn(o) {" &
      "    var value = o.id;" &
      "    var CreatedBy = $get('" & F_CreatedBy.ClientID & "');" &
      "    try{" &
      "    if(CreatedBy.value==''){" &
      "      if(validated_FK_SPMT_newPA_CreatedOn.main){" &
      "        var o_d = $get(o.id +'_Display');" &
      "        try{o_d.innerHTML = '';}catch(ex){}" &
      "      }" &
      "    }" &
      "    value = value + ',' + CreatedBy.value ;" &
      "    }catch(ex){}" &
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" &
      "    o.style.backgroundRepeat= 'no-repeat';" &
      "    o.style.backgroundPosition = 'right';" &
      "    PageMethods.validate_FK_SPMT_newPA_CreatedOn(value, validated_FK_SPMT_newPA_CreatedOn);" &
      "  }" &
      "  validated_FK_SPMT_newPA_CreatedOn_main = false;" &
      "  function validated_FK_SPMT_newPA_CreatedOn(result) {" &
      "    var p = result.split('|');" &
      "    var o = $get(p[1]);" &
      "    var o_d = $get(p[1]+'_Display');" &
      "    try{o_d.innerHTML = p[2];}catch(ex){}" &
      "    o.style.backgroundImage  = 'none';" &
      "    if(p[0]=='1'){" &
      "      o.value='';" &
      "      try{o_d.innerHTML = '';}catch(ex){}" &
      "      __doPostBack(o.id, o.value);" &
      "    }" &
      "    else" &
      "      __doPostBack(o.id, o.value);" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_newPA_CreatedOn") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_newPA_CreatedOn", validateScriptFK_SPMT_newPA_CreatedOn)
    End If
    Dim validateScriptFK_SPMT_newPA_BPID As String = "<script type=""text/javascript"">" &
      "  function validate_FK_SPMT_newPA_BPID(o) {" &
      "    var value = o.id;" &
      "    var BPID = $get('" & F_BPID.ClientID & "');" &
      "    try{" &
      "    if(BPID.value==''){" &
      "      if(validated_FK_SPMT_newPA_BPID.main){" &
      "        var o_d = $get(o.id +'_Display');" &
      "        try{o_d.innerHTML = '';}catch(ex){}" &
      "      }" &
      "    }" &
      "    value = value + ',' + BPID.value ;" &
      "    }catch(ex){}" &
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" &
      "    o.style.backgroundRepeat= 'no-repeat';" &
      "    o.style.backgroundPosition = 'right';" &
      "    PageMethods.validate_FK_SPMT_newPA_BPID(value, validated_FK_SPMT_newPA_BPID);" &
      "  }" &
      "  validated_FK_SPMT_newPA_BPID_main = false;" &
      "  function validated_FK_SPMT_newPA_BPID(result) {" &
      "    var p = result.split('|');" &
      "    var o = $get(p[1]);" &
      "    var o_d = $get(p[1]+'_Display');" &
      "    try{o_d.innerHTML = p[2];}catch(ex){}" &
      "    o.style.backgroundImage  = 'none';" &
      "    if(p[0]=='1'){" &
      "      o.value='';" &
      "      try{o_d.innerHTML = '';}catch(ex){}" &
      "      __doPostBack(o.id, o.value);" &
      "    }" &
      "    else" &
      "      __doPostBack(o.id, o.value);" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_newPA_BPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_newPA_BPID", validateScriptFK_SPMT_newPA_BPID)
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newPA_CreatedOn(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim CreatedBy As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(CreatedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newPA_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
End Class
