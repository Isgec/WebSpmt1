Partial Class GF_comGroupUsers
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/COM_Main/App_Display/DF_comGroupUsers.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?GroupID=" & aVal(0) & "&LoginID=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVcomGroupUsers_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVcomGroupUsers.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim GroupID As String = GVcomGroupUsers.DataKeys(e.CommandArgument).Values("GroupID")  
        Dim LoginID As String = GVcomGroupUsers.DataKeys(e.CommandArgument).Values("LoginID")  
        Dim RedirectUrl As String = TBLcomGroupUsers.EditUrl & "?GroupID=" & GroupID & "&LoginID=" & LoginID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVcomGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVcomGroupUsers.Init
    DataClassName = "GcomGroupUsers"
    SetGridView = GVcomGroupUsers
  End Sub
  Protected Sub TBLcomGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomGroupUsers.Init
    SetToolBar = TBLcomGroupUsers
  End Sub
  Protected Sub F_GroupID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_GroupID.SelectedIndexChanged
    Session("F_GroupID") = F_GroupID.SelectedValue
    InitGridPage()
  End Sub
  Protected Sub F_LoginID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LoginID.TextChanged
    Session("F_LoginID") = F_LoginID.Text
    Session("F_LoginID_Display") = F_LoginID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function LoginIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_GroupID.SelectedValue = String.Empty
    If Not Session("F_GroupID") Is Nothing Then
      If Session("F_GroupID") <> String.Empty Then
        F_GroupID.SelectedValue = Session("F_GroupID")
      End If
    End If
    F_LoginID_Display.Text = String.Empty
    If Not Session("F_LoginID_Display") Is Nothing Then
      If Session("F_LoginID_Display") <> String.Empty Then
        F_LoginID_Display.Text = Session("F_LoginID_Display")
      End If
    End If
    F_LoginID.Text = String.Empty
    If Not Session("F_LoginID") Is Nothing Then
      If Session("F_LoginID") <> String.Empty Then
        F_LoginID.Text = Session("F_LoginID")
      End If
    End If
    Dim strScriptLoginID As String = "<script type=""text/javascript""> " & _
      "function ACELoginID_Selected(sender, e) {" & _
      "  var F_LoginID = $get('" & F_LoginID.ClientID & "');" & _
      "  var F_LoginID_Display = $get('" & F_LoginID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_LoginID.value = p[0];" & _
      "  F_LoginID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_LoginID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_LoginID", strScriptLoginID)
      End If
    Dim strScriptPopulatingLoginID As String = "<script type=""text/javascript""> " & _
      "function ACELoginID_Populating(o,e) {" & _
      "  var p = $get('" & F_LoginID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACELoginID_Populated(o,e) {" & _
      "  var p = $get('" & F_LoginID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_LoginIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_LoginIDPopulating", strScriptPopulatingLoginID)
      End If
    Dim validateScriptGroupID As String = "<script type=""text/javascript"">" & _
      "  function validate_GroupID(o) {" & _
      "    validated_FK_SYS_GroupLogins_SYS_Groups_main = true;" & _
      "    validate_FK_SYS_GroupLogins_SYS_Groups(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateGroupID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateGroupID", validateScriptGroupID)
    End If
    Dim validateScriptLoginID As String = "<script type=""text/javascript"">" & _
      "  function validate_LoginID(o) {" & _
      "    validated_FK_SYS_GroupLogins_aspnet_Users_main = true;" & _
      "    validate_FK_SYS_GroupLogins_aspnet_Users(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateLoginID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateLoginID", validateScriptLoginID)
    End If
    Dim validateScriptFK_SYS_GroupLogins_aspnet_Users As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SYS_GroupLogins_aspnet_Users(o) {" & _
      "    var value = o.id;" & _
      "    var LoginID = $get('" & F_LoginID.ClientID & "');" & _
      "    try{" & _
      "    if(LoginID.value==''){" & _
      "      if(validated_FK_SYS_GroupLogins_aspnet_Users.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + LoginID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SYS_GroupLogins_aspnet_Users(value, validated_FK_SYS_GroupLogins_aspnet_Users);" & _
      "  }" & _
      "  validated_FK_SYS_GroupLogins_aspnet_Users_main = false;" & _
      "  function validated_FK_SYS_GroupLogins_aspnet_Users(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SYS_GroupLogins_aspnet_Users") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SYS_GroupLogins_aspnet_Users", validateScriptFK_SYS_GroupLogins_aspnet_Users)
    End If
    Dim validateScriptFK_SYS_GroupLogins_SYS_Groups As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SYS_GroupLogins_SYS_Groups(o) {" & _
      "    var value = o.id;" & _
      "    var GroupID = $get('" & F_GroupID.ClientID & "');" & _
      "    try{" & _
      "    if(GroupID.value==''){" & _
      "      if(validated_FK_SYS_GroupLogins_SYS_Groups.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + GroupID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SYS_GroupLogins_SYS_Groups(value, validated_FK_SYS_GroupLogins_SYS_Groups);" & _
      "  }" & _
      "  validated_FK_SYS_GroupLogins_SYS_Groups_main = false;" & _
      "  function validated_FK_SYS_GroupLogins_SYS_Groups(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SYS_GroupLogins_SYS_Groups") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SYS_GroupLogins_SYS_Groups", validateScriptFK_SYS_GroupLogins_SYS_Groups)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SYS_GroupLogins_aspnet_Users(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim LoginID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(LoginID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SYS_GroupLogins_SYS_Groups(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim GroupID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comGroups = SIS.COM.comGroups.comGroupsGetByID(GroupID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
