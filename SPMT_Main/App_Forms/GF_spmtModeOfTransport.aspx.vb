Partial Class GF_spmtModeOfTransport
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtModeOfTransport.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ModeID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtModeOfTransport_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtModeOfTransport.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ModeID As Int32 = GVspmtModeOfTransport.DataKeys(e.CommandArgument).Values("ModeID")  
        Dim RedirectUrl As String = TBLspmtModeOfTransport.EditUrl & "?ModeID=" & ModeID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtModeOfTransport_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtModeOfTransport.Init
    DataClassName = "GspmtModeOfTransport"
    SetGridView = GVspmtModeOfTransport
  End Sub
  Protected Sub TBLspmtModeOfTransport_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtModeOfTransport.Init
    SetToolBar = TBLspmtModeOfTransport
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
