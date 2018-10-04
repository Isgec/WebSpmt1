Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml
Imports System.Web.Script.Serialization
Partial Class GF_spmtAirTicket
  Inherits SIS.SYS.GridBase
  Protected Sub GVspmtAirTicket_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtAirTicket.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim SerialNo As Int32 = GVspmtAirTicket.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim RedirectUrl As String = TBLspmtAirTicket.EditUrl & "?SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "initiatewf".ToLower Then
      Try
        Dim SerialNo As Int32 = GVspmtAirTicket.DataKeys(e.CommandArgument).Values("SerialNo")
        SIS.SPMT.spmtAirTicket.InitiateWF(SerialNo)
        GVspmtAirTicket.DataBind()
      Catch ex As Exception
        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message.ToString())
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      End Try
    End If
  End Sub
  Protected Sub GVspmtAirTicket_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtAirTicket.Init
    DataClassName = "GspmtAirTicket"
    SetGridView = GVspmtAirTicket
  End Sub
  Protected Sub TBLspmtAirTicket_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtAirTicket.Init
    SetToolBar = TBLspmtAirTicket
  End Sub
  Protected Sub F_TranTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_TranTypeID.SelectedIndexChanged
    Session("F_TranTypeID") = F_TranTypeID.SelectedValue
    InitGridPage()
  End Sub
  Protected Sub F_StatusID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_StatusID.TextChanged
    Session("F_StatusID") = F_StatusID.Text
    Session("F_StatusID_Display") = F_StatusID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function StatusIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtAirTicketStatus.SelectspmtAirTicketStatusAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_AdviceNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AdviceNo.TextChanged
    Session("F_AdviceNo") = F_AdviceNo.Text
    Session("F_AdviceNo_Display") = F_AdviceNo_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AdviceNoCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtPaymentAdvice.SelectspmtPaymentAdviceAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_Geography_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_Geography.TextChanged
    Session("F_Geography") = F_Geography.Text
    InitGridPage()
  End Sub
  Protected Sub F_ISGECUnit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_ISGECUnit.TextChanged
    Session("F_ISGECUnit") = F_ISGECUnit.Text
    InitGridPage()
  End Sub
  Protected Sub F_ProjectID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_ProjectID.TextChanged
    Session("F_ProjectID") = F_ProjectID.Text
    Session("F_ProjectID_Display") = F_ProjectID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_EmployeeID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EmployeeID.TextChanged
    Session("F_EmployeeID") = F_EmployeeID.Text
    Session("F_EmployeeID_Display") = F_EmployeeID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function EmployeeIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_AgencyBPID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AgencyBPID.TextChanged
    Session("F_AgencyBPID") = F_AgencyBPID.Text
    Session("F_AgencyBPID_Display") = F_AgencyBPID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgencyBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_AgentsBPID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AgentsBPID.TextChanged
    Session("F_AgentsBPID") = F_AgentsBPID.Text
    Session("F_AgentsBPID_Display") = F_AgentsBPID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgentsBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        F_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    F_StatusID_Display.Text = String.Empty
    If Not Session("F_StatusID_Display") Is Nothing Then
      If Session("F_StatusID_Display") <> String.Empty Then
        F_StatusID_Display.Text = Session("F_StatusID_Display")
      End If
    End If
    F_StatusID.Text = String.Empty
    If Not Session("F_StatusID") Is Nothing Then
      If Session("F_StatusID") <> String.Empty Then
        F_StatusID.Text = Session("F_StatusID")
      End If
    End If
    Dim strScriptStatusID As String = "<script type=""text/javascript""> " & _
      "function ACEStatusID_Selected(sender, e) {" & _
      "  var F_StatusID = $get('" & F_StatusID.ClientID & "');" & _
      "  var F_StatusID_Display = $get('" & F_StatusID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_StatusID.value = p[0];" & _
      "  F_StatusID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_StatusID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_StatusID", strScriptStatusID)
      End If
    Dim strScriptPopulatingStatusID As String = "<script type=""text/javascript""> " & _
      "function ACEStatusID_Populating(o,e) {" & _
      "  var p = $get('" & F_StatusID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEStatusID_Populated(o,e) {" & _
      "  var p = $get('" & F_StatusID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_StatusIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_StatusIDPopulating", strScriptPopulatingStatusID)
      End If
    F_AdviceNo_Display.Text = String.Empty
    If Not Session("F_AdviceNo_Display") Is Nothing Then
      If Session("F_AdviceNo_Display") <> String.Empty Then
        F_AdviceNo_Display.Text = Session("F_AdviceNo_Display")
      End If
    End If
    F_AdviceNo.Text = String.Empty
    If Not Session("F_AdviceNo") Is Nothing Then
      If Session("F_AdviceNo") <> String.Empty Then
        F_AdviceNo.Text = Session("F_AdviceNo")
      End If
    End If
    Dim strScriptAdviceNo As String = "<script type=""text/javascript""> " & _
      "function ACEAdviceNo_Selected(sender, e) {" & _
      "  var F_AdviceNo = $get('" & F_AdviceNo.ClientID & "');" & _
      "  var F_AdviceNo_Display = $get('" & F_AdviceNo_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_AdviceNo.value = p[0];" & _
      "  F_AdviceNo_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AdviceNo") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AdviceNo", strScriptAdviceNo)
      End If
    Dim strScriptPopulatingAdviceNo As String = "<script type=""text/javascript""> " & _
      "function ACEAdviceNo_Populating(o,e) {" & _
      "  var p = $get('" & F_AdviceNo.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEAdviceNo_Populated(o,e) {" & _
      "  var p = $get('" & F_AdviceNo.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AdviceNoPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AdviceNoPopulating", strScriptPopulatingAdviceNo)
      End If
    F_ProjectID_Display.Text = String.Empty
    If Not Session("F_ProjectID_Display") Is Nothing Then
      If Session("F_ProjectID_Display") <> String.Empty Then
        F_ProjectID_Display.Text = Session("F_ProjectID_Display")
      End If
    End If
    F_ProjectID.Text = String.Empty
    If Not Session("F_ProjectID") Is Nothing Then
      If Session("F_ProjectID") <> String.Empty Then
        F_ProjectID.Text = Session("F_ProjectID")
      End If
    End If
    Dim strScriptProjectID As String = "<script type=""text/javascript""> " & _
      "function ACEProjectID_Selected(sender, e) {" & _
      "  var F_ProjectID = $get('" & F_ProjectID.ClientID & "');" & _
      "  var F_ProjectID_Display = $get('" & F_ProjectID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_ProjectID.value = p[0];" & _
      "  F_ProjectID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_ProjectID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_ProjectID", strScriptProjectID)
      End If
    Dim strScriptPopulatingProjectID As String = "<script type=""text/javascript""> " & _
      "function ACEProjectID_Populating(o,e) {" & _
      "  var p = $get('" & F_ProjectID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEProjectID_Populated(o,e) {" & _
      "  var p = $get('" & F_ProjectID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_ProjectIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_ProjectIDPopulating", strScriptPopulatingProjectID)
      End If
    F_EmployeeID_Display.Text = String.Empty
    If Not Session("F_EmployeeID_Display") Is Nothing Then
      If Session("F_EmployeeID_Display") <> String.Empty Then
        F_EmployeeID_Display.Text = Session("F_EmployeeID_Display")
      End If
    End If
    F_EmployeeID.Text = String.Empty
    If Not Session("F_EmployeeID") Is Nothing Then
      If Session("F_EmployeeID") <> String.Empty Then
        F_EmployeeID.Text = Session("F_EmployeeID")
      End If
    End If
    Dim strScriptEmployeeID As String = "<script type=""text/javascript""> " & _
      "function ACEEmployeeID_Selected(sender, e) {" & _
      "  var F_EmployeeID = $get('" & F_EmployeeID.ClientID & "');" & _
      "  var F_EmployeeID_Display = $get('" & F_EmployeeID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_EmployeeID.value = p[0];" & _
      "  F_EmployeeID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_EmployeeID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_EmployeeID", strScriptEmployeeID)
      End If
    Dim strScriptPopulatingEmployeeID As String = "<script type=""text/javascript""> " & _
      "function ACEEmployeeID_Populating(o,e) {" & _
      "  var p = $get('" & F_EmployeeID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEEmployeeID_Populated(o,e) {" & _
      "  var p = $get('" & F_EmployeeID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_EmployeeIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_EmployeeIDPopulating", strScriptPopulatingEmployeeID)
      End If
    F_AgencyBPID_Display.Text = String.Empty
    If Not Session("F_AgencyBPID_Display") Is Nothing Then
      If Session("F_AgencyBPID_Display") <> String.Empty Then
        F_AgencyBPID_Display.Text = Session("F_AgencyBPID_Display")
      End If
    End If
    F_AgencyBPID.Text = String.Empty
    If Not Session("F_AgencyBPID") Is Nothing Then
      If Session("F_AgencyBPID") <> String.Empty Then
        F_AgencyBPID.Text = Session("F_AgencyBPID")
      End If
    End If
    Dim strScriptAgencyBPID As String = "<script type=""text/javascript""> " & _
      "function ACEAgencyBPID_Selected(sender, e) {" & _
      "  var F_AgencyBPID = $get('" & F_AgencyBPID.ClientID & "');" & _
      "  var F_AgencyBPID_Display = $get('" & F_AgencyBPID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_AgencyBPID.value = p[0];" & _
      "  F_AgencyBPID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AgencyBPID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AgencyBPID", strScriptAgencyBPID)
      End If
    Dim strScriptPopulatingAgencyBPID As String = "<script type=""text/javascript""> " & _
      "function ACEAgencyBPID_Populating(o,e) {" & _
      "  var p = $get('" & F_AgencyBPID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEAgencyBPID_Populated(o,e) {" & _
      "  var p = $get('" & F_AgencyBPID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AgencyBPIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AgencyBPIDPopulating", strScriptPopulatingAgencyBPID)
      End If
    F_AgentsBPID_Display.Text = String.Empty
    If Not Session("F_AgentsBPID_Display") Is Nothing Then
      If Session("F_AgentsBPID_Display") <> String.Empty Then
        F_AgentsBPID_Display.Text = Session("F_AgentsBPID_Display")
      End If
    End If
    F_AgentsBPID.Text = String.Empty
    If Not Session("F_AgentsBPID") Is Nothing Then
      If Session("F_AgentsBPID") <> String.Empty Then
        F_AgentsBPID.Text = Session("F_AgentsBPID")
      End If
    End If
    Dim strScriptAgentsBPID As String = "<script type=""text/javascript""> " & _
      "function ACEAgentsBPID_Selected(sender, e) {" & _
      "  var F_AgentsBPID = $get('" & F_AgentsBPID.ClientID & "');" & _
      "  var F_AgentsBPID_Display = $get('" & F_AgentsBPID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_AgentsBPID.value = p[0];" & _
      "  F_AgentsBPID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AgentsBPID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AgentsBPID", strScriptAgentsBPID)
      End If
    Dim strScriptPopulatingAgentsBPID As String = "<script type=""text/javascript""> " & _
      "function ACEAgentsBPID_Populating(o,e) {" & _
      "  var p = $get('" & F_AgentsBPID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEAgentsBPID_Populated(o,e) {" & _
      "  var p = $get('" & F_AgentsBPID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AgentsBPIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AgentsBPIDPopulating", strScriptPopulatingAgentsBPID)
      End If
    Dim validateScriptStatusID As String = "<script type=""text/javascript"">" & _
      "  function validate_StatusID(o) {" & _
      "    validated_FK_SPMT_AirTicket_StatusID_main = true;" & _
      "    validate_FK_SPMT_AirTicket_StatusID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateStatusID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateStatusID", validateScriptStatusID)
    End If
    Dim validateScriptAdviceNo As String = "<script type=""text/javascript"">" & _
      "  function validate_AdviceNo(o) {" & _
      "    validated_FK_SPMT_AirTicket_AdviceNo_main = true;" & _
      "    validate_FK_SPMT_AirTicket_AdviceNo(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateAdviceNo") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateAdviceNo", validateScriptAdviceNo)
    End If
    Dim validateScriptProjectID As String = "<script type=""text/javascript"">" & _
      "  function validate_ProjectID(o) {" & _
      "    validated_FK_SPMT_AirTicket_ProjectID_main = true;" & _
      "    validate_FK_SPMT_AirTicket_ProjectID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateProjectID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateProjectID", validateScriptProjectID)
    End If
    Dim validateScriptEmployeeID As String = "<script type=""text/javascript"">" & _
      "  function validate_EmployeeID(o) {" & _
      "    validated_FK_SPMT_AirTicket_EmployeeID_main = true;" & _
      "    validate_FK_SPMT_AirTicket_EmployeeID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateEmployeeID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateEmployeeID", validateScriptEmployeeID)
    End If
    Dim validateScriptAgencyBPID As String = "<script type=""text/javascript"">" & _
      "  function validate_AgencyBPID(o) {" & _
      "    validated_FK_SPMT_AirTicket_AgencyBPID_main = true;" & _
      "    validate_FK_SPMT_AirTicket_AgencyBPID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateAgencyBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateAgencyBPID", validateScriptAgencyBPID)
    End If
    Dim validateScriptAgentsBPID As String = "<script type=""text/javascript"">" & _
      "  function validate_AgentsBPID(o) {" & _
      "    validated_FK_SPMT_AirTicket_AgentsBPID_main = true;" & _
      "    validate_FK_SPMT_AirTicket_AgentsBPID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateAgentsBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateAgentsBPID", validateScriptAgentsBPID)
    End If
    Dim validateScriptFK_SPMT_AirTicket_EmployeeID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_AirTicket_EmployeeID(o) {" & _
      "    var value = o.id;" & _
      "    var EmployeeID = $get('" & F_EmployeeID.ClientID & "');" & _
      "    try{" & _
      "    if(EmployeeID.value==''){" & _
      "      if(validated_FK_SPMT_AirTicket_EmployeeID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + EmployeeID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_AirTicket_EmployeeID(value, validated_FK_SPMT_AirTicket_EmployeeID);" & _
      "  }" & _
      "  validated_FK_SPMT_AirTicket_EmployeeID_main = false;" & _
      "  function validated_FK_SPMT_AirTicket_EmployeeID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_AirTicket_EmployeeID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_AirTicket_EmployeeID", validateScriptFK_SPMT_AirTicket_EmployeeID)
    End If
    Dim validateScriptFK_SPMT_AirTicket_ProjectID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_AirTicket_ProjectID(o) {" & _
      "    var value = o.id;" & _
      "    var ProjectID = $get('" & F_ProjectID.ClientID & "');" & _
      "    try{" & _
      "    if(ProjectID.value==''){" & _
      "      if(validated_FK_SPMT_AirTicket_ProjectID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + ProjectID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_AirTicket_ProjectID(value, validated_FK_SPMT_AirTicket_ProjectID);" & _
      "  }" & _
      "  validated_FK_SPMT_AirTicket_ProjectID_main = false;" & _
      "  function validated_FK_SPMT_AirTicket_ProjectID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_AirTicket_ProjectID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_AirTicket_ProjectID", validateScriptFK_SPMT_AirTicket_ProjectID)
    End If
    Dim validateScriptFK_SPMT_AirTicket_AdviceNo As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_AirTicket_AdviceNo(o) {" & _
      "    var value = o.id;" & _
      "    var AdviceNo = $get('" & F_AdviceNo.ClientID & "');" & _
      "    try{" & _
      "    if(AdviceNo.value==''){" & _
      "      if(validated_FK_SPMT_AirTicket_AdviceNo.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + AdviceNo.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_AirTicket_AdviceNo(value, validated_FK_SPMT_AirTicket_AdviceNo);" & _
      "  }" & _
      "  validated_FK_SPMT_AirTicket_AdviceNo_main = false;" & _
      "  function validated_FK_SPMT_AirTicket_AdviceNo(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_AirTicket_AdviceNo") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_AirTicket_AdviceNo", validateScriptFK_SPMT_AirTicket_AdviceNo)
    End If
    Dim validateScriptFK_SPMT_AirTicket_AgencyBPID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_AirTicket_AgencyBPID(o) {" & _
      "    var value = o.id;" & _
      "    var AgencyBPID = $get('" & F_AgencyBPID.ClientID & "');" & _
      "    try{" & _
      "    if(AgencyBPID.value==''){" & _
      "      if(validated_FK_SPMT_AirTicket_AgencyBPID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + AgencyBPID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_AirTicket_AgencyBPID(value, validated_FK_SPMT_AirTicket_AgencyBPID);" & _
      "  }" & _
      "  validated_FK_SPMT_AirTicket_AgencyBPID_main = false;" & _
      "  function validated_FK_SPMT_AirTicket_AgencyBPID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_AirTicket_AgencyBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_AirTicket_AgencyBPID", validateScriptFK_SPMT_AirTicket_AgencyBPID)
    End If
    Dim validateScriptFK_SPMT_AirTicket_AgentsBPID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_AirTicket_AgentsBPID(o) {" & _
      "    var value = o.id;" & _
      "    var AgentsBPID = $get('" & F_AgentsBPID.ClientID & "');" & _
      "    try{" & _
      "    if(AgentsBPID.value==''){" & _
      "      if(validated_FK_SPMT_AirTicket_AgentsBPID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + AgentsBPID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_AirTicket_AgentsBPID(value, validated_FK_SPMT_AirTicket_AgentsBPID);" & _
      "  }" & _
      "  validated_FK_SPMT_AirTicket_AgentsBPID_main = false;" & _
      "  function validated_FK_SPMT_AirTicket_AgentsBPID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_AirTicket_AgentsBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_AirTicket_AgentsBPID", validateScriptFK_SPMT_AirTicket_AgentsBPID)
    End If
    Dim validateScriptFK_SPMT_AirTicket_StatusID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_AirTicket_StatusID(o) {" & _
      "    var value = o.id;" & _
      "    var StatusID = $get('" & F_StatusID.ClientID & "');" & _
      "    try{" & _
      "    if(StatusID.value==''){" & _
      "      if(validated_FK_SPMT_AirTicket_StatusID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + StatusID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_AirTicket_StatusID(value, validated_FK_SPMT_AirTicket_StatusID);" & _
      "  }" & _
      "  validated_FK_SPMT_AirTicket_StatusID_main = false;" & _
      "  function validated_FK_SPMT_AirTicket_StatusID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_AirTicket_StatusID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_AirTicket_StatusID", validateScriptFK_SPMT_AirTicket_StatusID)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_EmployeeID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim EmployeeID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(EmployeeID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_ProjectID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ProjectID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comProjects = SIS.COM.comProjects.comProjectsGetByID(ProjectID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AdviceNo(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AdviceNo As Int32 = CType(aVal(1),Int32)
    Dim oVar As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(AdviceNo)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgencyBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgencyBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(AgencyBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgentsBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgentsBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(AgentsBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_StatusID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim StatusID As Int32 = CType(aVal(1),Int32)
    Dim oVar As SIS.SPMT.spmtAirTicketStatus = SIS.SPMT.spmtAirTicketStatus.spmtAirTicketStatusGetByID(StatusID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  Protected Sub cmdDownload_Click(sender As Object, e As System.EventArgs) Handles cmdDownload.Click
    Dim st As Long = HttpContext.Current.Server.ScriptTimeout
    HttpContext.Current.Server.ScriptTimeout = Integer.MaxValue
    Dim TemplateName As String = "AirTicket_Template.xlsx"
    Dim tmpFile As String = Server.MapPath("~/App_Templates/" & TemplateName)
    If IO.File.Exists(tmpFile) Then
      Dim FileName As String = Server.MapPath("~/..") & "App_Temp/" & Guid.NewGuid().ToString()
      IO.File.Copy(tmpFile, FileName)
      Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)

      Response.Clear()
      Response.AppendHeader("content-disposition", "attachment; filename=AirTicket_" & Now.Year & "_" & Now.Month & ".xlsx")
      Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(TemplateName)
      Response.WriteFile(FileName)
      HttpContext.Current.Server.ScriptTimeout = st
      Response.End()
    End If
  End Sub
  Private Sub cmdFileUpload_Click(sender As Object, e As EventArgs) Handles cmdFileUpload.Click
    Dim st As Long = HttpContext.Current.Server.ScriptTimeout
    HttpContext.Current.Server.ScriptTimeout = Integer.MaxValue
    Try
      With F_FileUpload
        If .HasFile Then
          Dim tmpPath As String = Server.MapPath("~/../App_Temp")
          Dim tmpName As String = IO.Path.GetRandomFileName()
          Dim tmpFile As String = tmpPath & "\\" & tmpName
          .SaveAs(tmpFile)
          Dim fi As FileInfo = New FileInfo(tmpFile)
          Using xlP As ExcelPackage = New ExcelPackage(fi)
            Dim wsD As ExcelWorksheet = Nothing
            Dim r As Integer = 0
            Try
              wsD = xlP.Workbook.Worksheets("AirTicket_Data")
              If wsD Is Nothing Then
                Dim message As String = New JavaScriptSerializer().Serialize("invalis EXCEL File.")
                Dim script As String = String.Format("alert({0});", message)
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
                GoTo CloseExcel
              End If
              Dim lgTs As List(Of lgTickets) = lgTickets.GetlgTicketsFromXL(wsD)
              r = 4
              Dim xlAir As SIS.SPMT.spmtAirTicket = GetAirTicketFromXL(wsD, r)
              Try
                Do While xlAir.AgentsBillNumber <> String.Empty
                  If xlAir.Err Then
                    GoTo NextTicket
                  End If
                  If xlAir.StatusID = 4 Then 'Advice Locked
                    wsD.Cells(r, 3).Value = "Payment Advice Locked, can Not Update."
                    GoTo NextTicket
                  End If
                  xlAir = CreateSupplierBill(xlAir)
                  wsD.Cells(r, 4).Value = xlAir.AgentsIRNo
                  wsD.Cells(r, 5).Value = xlAir.AgencyIRNo
                  'Advice
                  Dim tmpRef As String = wsD.Cells(r, 29).Text
                  Dim otmpAdv As lgTickets = Nothing
                  For Each tmp As lgTickets In lgTs
                    If tmp.RefNo = tmpRef Then
                      otmpAdv = tmp
                      Exit For
                    End If
                  Next
                  If otmpAdv.AdviceNo = String.Empty Then
                    Dim oPA As New SIS.SPMT.spmtPaymentAdvice
                    With oPA
                      .UploadBatchNo = xlAir.UploadBatchNo
                      .TranTypeID = xlAir.TranTypeID
                      .BPID = xlAir.AgentsBPID
                      .SupplierName = xlAir.AgentsName
                      .CostCenter = "0.00"
                      .AdviceStatusID = 3
                      .AdviceStatusOn = Now
                      .AdviceStatusUser = HttpContext.Current.Session("LoginID")
                      .Remarks = "Uploaded Batch No.: " & xlAir.UploadBatchNo
                    End With
                    Try
                      oPA = SIS.SPMT.spmtPaymentAdvice.InsertData(oPA)
                      otmpAdv.AdviceNo = oPA.AdviceNo
                    Catch ex As Exception
                      wsD.Cells(r, 3).Value = "PA-I=>" & ex.Message
                      GoTo CloseExcel
                    End Try
                  End If
                  wsD.Cells(r, 1).Value = otmpAdv.AdviceNo
                  Try
                    '1.Agents
                    Dim tSB As SIS.SPMT.spmtSupplierBill = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(xlAir.AgentsIRNo)
                    tSB.AdviceNo = otmpAdv.AdviceNo
                    tSB.BillStatusID = 6
                    tSB.LogisticLinked = True
                    tSB = SIS.SPMT.spmtSupplierBill.UpdateData(tSB)
                    '2.Agency
                    tSB = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(xlAir.AgencyIRNo)
                    tSB.AdviceNo = otmpAdv.AdviceNo
                    tSB.BillStatusID = 6
                    tSB.LogisticLinked = True
                    tSB = SIS.SPMT.spmtSupplierBill.UpdateData(tSB)
                  Catch ex As Exception
                    wsD.Cells(r, 3).Value = "SB-PANo-U=>" & ex.Message
                    GoTo CloseExcel
                  End Try
                  'XLAir
                  xlAir.AdviceNo = otmpAdv.AdviceNo
                  If xlAir.StatusID = 1 Then
                    xlAir.StatusID = 3
                    Try
                      xlAir = SIS.SPMT.spmtAirTicket.InsertData(xlAir)
                      wsD.Cells(r, 2).Value = xlAir.SerialNo
                    Catch ex As Exception
                      wsD.Cells(r, 3).Value = "xlAir-I=>" & ex.Message
                    End Try
                  Else
                    Try
                      xlAir = SIS.SPMT.spmtAirTicket.UpdateData(xlAir)
                    Catch ex As Exception
                      wsD.Cells(r, 3).Value = "xlAir-U=>" & ex.Message
                    End Try
                  End If
NextTicket:
                  r += 1
                  xlAir = GetAirTicketFromXL(wsD, r)
                Loop
                For Each tmp As lgTickets In lgTs
                  SIS.SPMT.spmtPaymentAdvice.ValidateAdvice(tmp.AdviceNo)
                Next
              Catch enx As Exception
                wsD.Cells(r, 3).Value = "xlAir-U=>" & enx.Message
                GoTo CloseExcel
              End Try
            Catch en As Exception
              wsD.Cells(r, 3).Value = "xlAir-U=>" & en.Message
              GoTo CloseExcel
            End Try
CloseExcel:
            xlP.Save()
            xlP.Dispose()
          End Using
          Dim FileNameForUser As String = F_FileUpload.FileName
          If IO.File.Exists(tmpFile) Then
            Response.Clear()
            Response.AppendHeader("content-disposition", "attachment; filename=" & FileNameForUser)
            Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(FileNameForUser)
            Response.WriteFile(tmpFile)
            HttpContext.Current.Server.ScriptTimeout = st
            Response.End()
          End If
        End If
      End With
    Catch ex As Exception
      HttpContext.Current.Server.ScriptTimeout = st
      Dim message As String = New JavaScriptSerializer().Serialize(ex.Message.ToString())
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
    End Try
over:
  End Sub
  Public Function CreateSupplierBill(ByVal xlAir As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
    Dim tmpSB As SIS.SPMT.spmtSupplierBill = Nothing
    '1. Agents
    If xlAir.AgentsIRNo <> "" Then
      tmpSB = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(xlAir.AgentsIRNo)
    Else
      tmpSB = New SIS.SPMT.spmtSupplierBill
    End If
    With tmpSB
      .UploadBatchNo = xlAir.UploadBatchNo
      .AdviceNo = xlAir.AdviceNo
      .TranTypeID = xlAir.TranTypeID
      .BillStatusID = 4
      .BillStatusDate = Now
      .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
      .DocNo = "AIRT"
      .BillAmount = xlAir.TotalPayableToAgent
      .IRReceivedOn = Now
      .BPID = xlAir.AgentsBPID
      .BillNumber = xlAir.AgentsBillNumber
      .BillDate = xlAir.AgentsBillDate
      .Quantity = 1
      .UOM = "nos"
      .Currency = "INR"
      .BillRemarks = "Agents : " & xlAir.AgentsName  'xlAir.AgentsItemName
      .SupplierGSTIN = xlAir.AgentsGSTIN
      .IsgecGSTIN = xlAir.AgentsIsgecGSTIN
      .ShipToState = xlAir.AgentsStateID
      .HSNSACCode = xlAir.AgentsHSNSACCode
      .BillType = xlAir.AgentsBillType
      .ConversionFactorINR = "1.000000"
      .TotalGST = xlAir.AgentsTotalGST
      .CessAmount = xlAir.AgentsCessAmount
      .CessRate = xlAir.AgentsCessRate
      .TaxAmount = xlAir.AgentsTotalGST
      .RemarksGST = ""
      .TotalAmountINR = xlAir.AgentsTotalAmount
      .TotalAmount = xlAir.AgentsTotalAmount
      .IGSTAmount = xlAir.AgentsIGSTAmount
      .IGSTRate = xlAir.AgentsIGSTRate
      .AssessableValue = xlAir.AgentsBasicValue
      .CGSTRate = xlAir.AgentsCGSTRate
      .SGSTAmount = xlAir.AgentsSGSTAmount
      .SGSTRate = xlAir.AgentsSGSTRate
      .CGSTAmount = xlAir.AgentsCGSTAmount
      .PurchaseType = "Purchase from Registered Dealer"
      .SupplierName = xlAir.AgentsName
      .SupplierGSTINNumber = xlAir.AgentsGSTINNumber
    End With
    If xlAir.AgentsIRNo = "" Then
      tmpSB = SIS.SPMT.spmtSupplierBill.InsertData(tmpSB)
      xlAir.AgentsIRNo = tmpSB.IRNo
    Else
      tmpSB = SIS.SPMT.spmtSupplierBill.UpdateData(tmpSB)
    End If
    '2. Agency
    If xlAir.AgencyIRNo <> "" Then
      tmpSB = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(xlAir.AgencyIRNo)
    Else
      tmpSB = New SIS.SPMT.spmtSupplierBill
    End If
    With tmpSB
      .UploadBatchNo = xlAir.UploadBatchNo
      .AdviceNo = xlAir.AdviceNo
      .TranTypeID = xlAir.TranTypeID
      .BillStatusID = 4
      .BillStatusDate = Now
      .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
      .DocNo = "AIRY"
      .BillAmount = "0.00"
      .IRReceivedOn = Now
      .BPID = xlAir.AgencyBPID
      .BillNumber = xlAir.AgencyBillNumber
      .BillDate = xlAir.AgencyBillDate
      .Quantity = 1
      .UOM = "nos"
      .Currency = "INR"
      .BillRemarks = "Agency : " & xlAir.AgencyName  'xlAir.AgencyItemName
      .SupplierGSTIN = xlAir.AgencyGSTIN
      .IsgecGSTIN = xlAir.AgencyIsgecGSTIN
      .ShipToState = xlAir.AgencyStateID
      .HSNSACCode = xlAir.AgencyHSNSACCode
      .BillType = xlAir.AgencyBillType
      .ConversionFactorINR = "1.000000"
      .TotalGST = xlAir.AgencyTotalGST
      .CessAmount = xlAir.AgencyCessAmount
      .CessRate = xlAir.AgencyCessRate
      .TaxAmount = xlAir.AgencyTotalGST
      .RemarksGST = ""
      .TotalAmountINR = xlAir.AgencyTotalAmount
      .TotalAmount = xlAir.AgencyTotalAmount
      .IGSTAmount = xlAir.AgencyIGSTAmount
      .IGSTRate = xlAir.AgencyIGSTRate
      .AssessableValue = xlAir.AgencyBasicValue
      .CGSTRate = xlAir.AgencyCGSTRate
      .SGSTAmount = xlAir.AgencySGSTAmount
      .SGSTRate = xlAir.AgencySGSTRate
      .CGSTAmount = xlAir.AgencyCGSTAmount
      .PurchaseType = "Purchase from Registered Dealer"
      .SupplierName = xlAir.AgencyName
      .SupplierGSTINNumber = xlAir.AgencyGSTINNumber
    End With
    If xlAir.AgencyIRNo = "" Then
      tmpSB = SIS.SPMT.spmtSupplierBill.InsertData(tmpSB)
      xlAir.AgencyIRNo = tmpSB.IRNo
    Else
      tmpSB = SIS.SPMT.spmtSupplierBill.UpdateData(tmpSB)
    End If
    Return xlAir
  End Function
  Public Class lgTickets
    Public Property RefNo As String = ""
    Public Property AdviceNo As String = ""
    Public Property TotalAmount As Decimal = 0
    Public Shared Function GetAdviceNoForRefNo(ByVal Ref As String, ByVal lgTs As List(Of lgTickets)) As String
      Dim mRet As String = ""
      'Dim tmpTs As List(Of lgTickets) = From tmp1 As lgTickets In lgTs Where Ref = tmp1.RefNo
      For Each tmp As lgTickets In lgTs
        If tmp.RefNo = Ref Then
          If tmp.AdviceNo <> String.Empty Then
            mRet = tmp.AdviceNo
            Exit For
          End If
        End If
      Next
      Return mRet
    End Function
    Public Shared Function GetlgTicketsFromXL(ByVal wsD As ExcelWorksheet) As List(Of lgTickets)
      Dim tmpS As New List(Of lgTickets)
      Dim r As Integer = 4
      Dim tmpUBN As New SIS.SPMT.spmtUploadBatch
      tmpUBN = SIS.SPMT.spmtUploadBatch.spmtUploadBatchInsert(tmpUBN)
      Dim AgentsBillNumber As String = wsD.Cells(r, 15).Text
      Do While AgentsBillNumber <> ""
        Dim tmpRef As String = wsD.Cells(r, 29).Text
        Dim tmpAdv As String = wsD.Cells(r, 1).Text
        wsD.Cells(r, 6).Value = tmpUBN.UploadBatchNo
        Dim FoundTmp As lgTickets = Nothing
        For Each tmp As lgTickets In tmpS
          If tmp.RefNo = tmpRef Then
            FoundTmp = tmp
            Exit For
          End If
        Next
        If FoundTmp Is Nothing Then
          FoundTmp = New lgTickets
          FoundTmp.RefNo = tmpRef
          FoundTmp.AdviceNo = tmpAdv
          tmpS.Add(FoundTmp)
        Else
          If FoundTmp.AdviceNo = "" Then
            FoundTmp.AdviceNo = tmpAdv
          End If
        End If
        r += 1
        AgentsBillNumber = wsD.Cells(r, 15).Text
      Loop
      tmpS.Sort(Function(x, y) x.RefNo.CompareTo(y.RefNo))
      Return tmpS
    End Function
    Sub New()
      'dummy
    End Sub
  End Class
  Private Function GetAirTicketFromXL(ByVal wsD As ExcelWorksheet, ByVal r As Integer) As SIS.SPMT.spmtAirTicket
    Dim tmpAir As New SIS.SPMT.spmtAirTicket
    With tmpAir
      Dim tmp As String = ""
      .AdviceNo = wsD.Cells(r, 1).Text
      .SerialNo = IIf(wsD.Cells(r, 2).Text = "", 0, wsD.Cells(r, 2).Text)
      .AgentsIRNo = wsD.Cells(r, 4).Text
      .AgencyIRNo = wsD.Cells(r, 5).Text
      .UploadBatchNo = wsD.Cells(r, 6).Text
      .ISGECUnit = wsD.Cells(r, 7).Text
      .Geography = wsD.Cells(r, 8).Text
      tmp = wsD.Cells(r, 9).Text
      If tmp <> "" Then
        Dim tmpPrj As SIS.COM.comProjects = SIS.COM.comProjects.comProjectsGetByID(tmp)
        If tmpPrj IsNot Nothing Then
          .ProjectID = tmp
        Else
          .Err = True
          .ErrMsg.Add("Invalid Project ID")
        End If
      End If
      tmp = wsD.Cells(r, 10).Text
      Dim ttID As String = ""
      Try
        ttID = tmp.Split("-".ToCharArray)(1)
      Catch ex As Exception
      End Try
      If ttID <> "" Then
        Dim oTT As SIS.SPMT.spmtTranTypes = SIS.SPMT.spmtTranTypes.spmtTranTypesGetByID(ttID)
        If oTT Is Nothing Then
          .Err = True
          .ErrMsg.Add("Invalid Tran. Type Not Found")
        Else
          .TranTypeID = ttID
        End If
      Else
        .Err = True
        .ErrMsg.Add("Invalid Tran. Type")
      End If
      tmp = wsD.Cells(r, 11).Text
      If tmp <> "" Then
        Dim tmpEmp As SIS.COM.comEmployees = SIS.COM.comEmployees.GetByID(tmp)
        If tmpEmp IsNot Nothing Then
          .EmployeeID = tmp
        Else
          .Err = True
          .ErrMsg.Add("Invalid Employee ID")
        End If
      End If
      tmp = wsD.Cells(r, 12).Text
      Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByGSTIN(tmp)
      If oTmp IsNot Nothing Then
        .AgentsIsgecGSTIN = oTmp.GSTID
        .AgencyIsgecGSTIN = oTmp.GSTID
      Else
        .Err = True
        .ErrMsg.Add("Invalid ISGEC GSTIN")
      End If
      .AgentsName = wsD.Cells(r, 13).Text
      .AgentsGSTINNumber = wsD.Cells(r, 14).Text
      .AgentsBillNumber = wsD.Cells(r, 15).Text
      If IsDate(wsD.Cells(r, 16).Text) Then
        .AgentsBillDate = wsD.Cells(r, 16).Text
      Else
        .Err = True
        .ErrMsg.Add("Invalid Agents Bill Date.")
      End If
      .PaxName = wsD.Cells(r, 17).Text
      .Sector = wsD.Cells(r, 18).Text
      .AgencyName = wsD.Cells(r, 19).Text
      If Not wsD.Cells(r, 20).Text = "" Then
        If IsDate(wsD.Cells(r, 20).Text) Then
          .TravelDate = wsD.Cells(r, 20).Text
        Else
          .Err = True
          .ErrMsg.Add("Invalid Travel Date")
        End If
      End If
      .AgencyBillNumber = wsD.Cells(r, 21).Text
      If IsDate(wsD.Cells(r, 22).Text) Then
        .AgencyBillDate = wsD.Cells(r, 22).Text
      Else
        .Err = True
        .ErrMsg.Add("Invalid Booked On Date")
      End If
      tmp = wsD.Cells(r, 23).Text
      .AgentsBasicValue = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 24).Text
      .AgentsIGSTAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 25).Text
      .AgentsSGSTAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 26).Text
      .AgentsCGSTAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 27).Text
      .AgentsTotalAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 28).Text
      .AgencyTotalAmount = IIf(tmp = "", "0.00", tmp)
      .ReferrenceNumber = wsD.Cells(r, 29).Text
      tmp = wsD.Cells(r, 30).Text
      If tmp <> "" Then
        Dim tmpState As SIS.SPMT.spmtERPStates = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(tmp)
        If tmpState IsNot Nothing Then
          .AgentsStateID = tmp
          .AgencyStateID = tmp
        Else
          .Err = True
          .ErrMsg.Add("Invalid State ID")
        End If
      End If
      .AgentsRCMApplicable = IIf(wsD.Cells(r, 31).Text = "YES", True, False)
      .AgencyRCMApplicable = IIf(wsD.Cells(r, 31).Text = "YES", True, False)
      .AgentsItemName = wsD.Cells(r, 32).Text
      .AgencyGSTINNumber = wsD.Cells(r, 33).Text
      tmp = wsD.Cells(r, 37).Text
      .AgencyBasicValue = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 38).Text
      .NonGST1TaxAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 39).Text
      .AgencyIGSTAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 40).Text
      .AgencySGSTAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 41).Text
      .AgencyCGSTAmount = IIf(tmp = "", "0.00", tmp)
      tmp = wsD.Cells(r, 42).Text
      .NonGST2TaxAmount = IIf(tmp = "", "0.00", tmp)
      '===================
      .AgentsBPID = ""
      .AgentsGSTIN = ""
      .AgentsBillType = "2"
      .AgentsHSNSACCode = ""
      .AgentsIGSTRate = "0.00"
      .AgentsSGSTRate = "0.00"
      .AgentsCGSTRate = "0.00"
      .AgentsCessRate = "0.00"
      .AgentsCessAmount = "0.00"
      .AgentsTotalGST = .AgentsIGSTAmount + .AgentsSGSTAmount + .AgentsCGSTAmount + .AgentsCessAmount
      .AgencyItemName = ""
      .AgencyBPID = ""
      .AgencyGSTIN = ""
      .AgencyBillType = "2"
      .AgencyHSNSACCode = ""
      .AgencyIGSTRate = "0.00"
      .AgencySGSTRate = "0.00"
      .AgencyCGSTRate = "0.00"
      .AgencyCessRate = "0.00"
      .AgencyCessAmount = "0.00"
      .AgencyTotalGST = .AgencyIGSTAmount + .AgencySGSTAmount + .AgencyCGSTAmount + .AgencyCessAmount
      .NonGST1TaxRate = "0.00"
      .NonGST2TaxRate = "0.00"
      .TotalPayableToAgent = .AgentsTotalAmount + .AgencyTotalAmount
      .Data1Flag = False
      .Data2Flag = False
      If .AdviceNo = String.Empty Then
        If .SerialNo = 0 Then
          .StatusID = 1 'Not Created
        Else
          .StatusID = 2 'Free
        End If
      Else
        Select Case .FK_SPMT_AirTicket_AdviceNo.AdviceStatusID
          Case 2, 3 'Returned, Free
            .StatusID = 3 'Linked
          Case Else
            .StatusID = 4 'Locked
        End Select
      End If
    End With
    If tmpAir.Err Then
      wsD.Cells(r, 3).Value = "Errors"
      For Each tmpStr As String In tmpAir.ErrMsg
        wsD.Cells(r, 3).Value &= ", " & tmpStr
      Next
    End If
    Return tmpAir
  End Function
End Class
