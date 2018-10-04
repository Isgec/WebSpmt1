Partial Class GF_spmtPAStatus
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtPAStatus.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?AdviceStatusID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtPAStatus_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtPAStatus.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim AdviceStatusID As Int32 = GVspmtPAStatus.DataKeys(e.CommandArgument).Values("AdviceStatusID")  
        Dim RedirectUrl As String = TBLspmtPAStatus.EditUrl & "?AdviceStatusID=" & AdviceStatusID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtPAStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtPAStatus.Init
    DataClassName = "GspmtPAStatus"
    SetGridView = GVspmtPAStatus
  End Sub
  Protected Sub TBLspmtPAStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPAStatus.Init
    SetToolBar = TBLspmtPAStatus
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
