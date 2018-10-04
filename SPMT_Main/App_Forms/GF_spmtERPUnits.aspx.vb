Partial Class GF_spmtERPUnits
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtERPUnits.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?UOM=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtERPUnits_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtERPUnits.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim UOM As String = GVspmtERPUnits.DataKeys(e.CommandArgument).Values("UOM")  
        Dim RedirectUrl As String = TBLspmtERPUnits.EditUrl & "?UOM=" & UOM
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtERPUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtERPUnits.Init
    DataClassName = "GspmtERPUnits"
    SetGridView = GVspmtERPUnits
  End Sub
  Protected Sub TBLspmtERPUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtERPUnits.Init
    SetToolBar = TBLspmtERPUnits
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
