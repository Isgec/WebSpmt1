Partial Class AF_comGroupUsers
  Inherits SIS.SYS.InsertBase
  Protected Sub FVcomGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroupUsers.Init
    DataClassName = "AcomGroupUsers"
    SetFormView = FVcomGroupUsers
  End Sub
  Protected Sub TBLcomGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomGroupUsers.Init
    SetToolBar = TBLcomGroupUsers
  End Sub
  Protected Sub FVcomGroupUsers_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroupUsers.DataBound
    SIS.COM.comGroupUsers.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVcomGroupUsers_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroupUsers.PreRender
    Dim oF_GroupID As LC_comGroups = FVcomGroupUsers.FindControl("F_GroupID")
    oF_GroupID.Enabled = True
    oF_GroupID.SelectedValue = String.Empty
    If Not Session("F_GroupID") Is Nothing Then
      If Session("F_GroupID") <> String.Empty Then
        oF_GroupID.SelectedValue = Session("F_GroupID")
      End If
    End If
    Dim oF_LoginID_Display As Label  = FVcomGroupUsers.FindControl("F_LoginID_Display")
    oF_LoginID_Display.Text = String.Empty
    If Not Session("F_LoginID_Display") Is Nothing Then
      If Session("F_LoginID_Display") <> String.Empty Then
        oF_LoginID_Display.Text = Session("F_LoginID_Display")
      End If
    End If
    Dim oF_LoginID As TextBox  = FVcomGroupUsers.FindControl("F_LoginID")
    oF_LoginID.Enabled = True
    oF_LoginID.Text = String.Empty
    If Not Session("F_LoginID") Is Nothing Then
      If Session("F_LoginID") <> String.Empty Then
        oF_LoginID.Text = Session("F_LoginID")
      End If
    End If
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/COM_Main/App_Create") & "/AF_comGroupUsers.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptcomGroupUsers") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptcomGroupUsers", mStr)
    End If
    If Request.QueryString("GroupID") IsNot Nothing Then
      CType(FVcomGroupUsers.FindControl("F_GroupID"), TextBox).Text = Request.QueryString("GroupID")
      CType(FVcomGroupUsers.FindControl("F_GroupID"), TextBox).Enabled = False
    End If
    If Request.QueryString("LoginID") IsNot Nothing Then
      CType(FVcomGroupUsers.FindControl("F_LoginID"), TextBox).Text = Request.QueryString("LoginID")
      CType(FVcomGroupUsers.FindControl("F_LoginID"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function LoginIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
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

End Class
