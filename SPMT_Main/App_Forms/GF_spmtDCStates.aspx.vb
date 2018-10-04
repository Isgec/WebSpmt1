Partial Class GF_spmtDCStates
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtDCStates.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?StatusID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtDCStates_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtDCStates.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim StatusID As Int32 = GVspmtDCStates.DataKeys(e.CommandArgument).Values("StatusID")  
        Dim RedirectUrl As String = TBLspmtDCStates.EditUrl & "?StatusID=" & StatusID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtDCStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtDCStates.Init
    DataClassName = "GspmtDCStates"
    SetGridView = GVspmtDCStates
  End Sub
  Protected Sub TBLspmtDCStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCStates.Init
    SetToolBar = TBLspmtDCStates
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
