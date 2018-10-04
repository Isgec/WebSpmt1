Partial Class GF_comGroups
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/COM_Main/App_Display/DF_comGroups.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?GroupID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVcomGroups_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVcomGroups.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim GroupID As String = GVcomGroups.DataKeys(e.CommandArgument).Values("GroupID")  
        Dim RedirectUrl As String = TBLcomGroups.EditUrl & "?GroupID=" & GroupID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVcomGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVcomGroups.Init
    DataClassName = "GcomGroups"
    SetGridView = GVcomGroups
  End Sub
  Protected Sub TBLcomGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomGroups.Init
    SetToolBar = TBLcomGroups
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
