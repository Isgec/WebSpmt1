Partial Class GF_spmtERPStates
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtERPStates.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?StateID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtERPStates_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtERPStates.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim StateID As String = GVspmtERPStates.DataKeys(e.CommandArgument).Values("StateID")  
        Dim RedirectUrl As String = TBLspmtERPStates.EditUrl & "?StateID=" & StateID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtERPStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtERPStates.Init
    DataClassName = "GspmtERPStates"
    SetGridView = GVspmtERPStates
  End Sub
  Protected Sub TBLspmtERPStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtERPStates.Init
    SetToolBar = TBLspmtERPStates
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
