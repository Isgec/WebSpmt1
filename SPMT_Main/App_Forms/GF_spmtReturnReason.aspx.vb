Partial Class GF_spmtReturnReason
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtReturnReason.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ReasonID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtReturnReason_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtReturnReason.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ReasonID As Int32 = GVspmtReturnReason.DataKeys(e.CommandArgument).Values("ReasonID")  
        Dim RedirectUrl As String = TBLspmtReturnReason.EditUrl & "?ReasonID=" & ReasonID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtReturnReason_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtReturnReason.Init
    DataClassName = "GspmtReturnReason"
    SetGridView = GVspmtReturnReason
  End Sub
  Protected Sub TBLspmtReturnReason_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtReturnReason.Init
    SetToolBar = TBLspmtReturnReason
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
