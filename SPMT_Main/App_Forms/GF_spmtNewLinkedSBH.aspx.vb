Partial Class GF_spmtNewLinkedSBH
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtNewLinkedSBH.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?IRNo=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtNewLinkedSBH_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtNewLinkedSBH.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewLinkedSBH.DataKeys(e.CommandArgument).Values("IRNo")  
        Dim RedirectUrl As String = TBLspmtNewLinkedSBH.EditUrl & "?IRNo=" & IRNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Deletewf".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewLinkedSBH.DataKeys(e.CommandArgument).Values("IRNo")  
        SIS.SPMT.spmtNewLinkedSBH.DeleteWF(IRNo)
        GVspmtNewLinkedSBH.DataBind()
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtNewLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtNewLinkedSBH.Init
    DataClassName = "GspmtNewLinkedSBH"
    SetGridView = GVspmtNewLinkedSBH
  End Sub
  Protected Sub TBLspmtNewLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewLinkedSBH.Init
    SetToolBar = TBLspmtNewLinkedSBH
  End Sub
  Protected Sub F_AdviceNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AdviceNo.TextChanged
    Session("F_AdviceNo") = F_AdviceNo.Text
    Session("F_AdviceNo_Display") = F_AdviceNo_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AdviceNoCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtNewPA.SelectspmtNewPAAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
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
    Dim validateScriptAdviceNo As String = "<script type=""text/javascript"">" & _
      "  function validate_AdviceNo(o) {" & _
      "    validated_FK_SPMT_newSBH_AdviceNo_main = true;" & _
      "    validate_FK_SPMT_newSBH_AdviceNo(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateAdviceNo") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateAdviceNo", validateScriptAdviceNo)
    End If
    Dim validateScriptFK_SPMT_newSBH_AdviceNo As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_SPMT_newSBH_AdviceNo(o) {" & _
      "    var value = o.id;" & _
      "    var AdviceNo = $get('" & F_AdviceNo.ClientID & "');" & _
      "    try{" & _
      "    if(AdviceNo.value==''){" & _
      "      if(validated_FK_SPMT_newSBH_AdviceNo.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + AdviceNo.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_SPMT_newSBH_AdviceNo(value, validated_FK_SPMT_newSBH_AdviceNo);" & _
      "  }" & _
      "  validated_FK_SPMT_newSBH_AdviceNo_main = false;" & _
      "  function validated_FK_SPMT_newSBH_AdviceNo(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_newSBH_AdviceNo") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_newSBH_AdviceNo", validateScriptFK_SPMT_newSBH_AdviceNo)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_newSBH_AdviceNo(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AdviceNo As Int32 = CType(aVal(1),Int32)
    Dim oVar As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(AdviceNo)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
