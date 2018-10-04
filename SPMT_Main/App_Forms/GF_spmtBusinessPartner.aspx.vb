Partial Class GF_spmtBusinessPartner
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtBusinessPartner.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?BPID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtBusinessPartner_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtBusinessPartner.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BPID As String = GVspmtBusinessPartner.DataKeys(e.CommandArgument).Values("BPID")  
        Dim RedirectUrl As String = TBLspmtBusinessPartner.EditUrl & "?BPID=" & BPID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtBusinessPartner_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtBusinessPartner.Init
    DataClassName = "GspmtBusinessPartner"
    SetGridView = GVspmtBusinessPartner
  End Sub
  Protected Sub TBLspmtBusinessPartner_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBusinessPartner.Init
    SetToolBar = TBLspmtBusinessPartner
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
