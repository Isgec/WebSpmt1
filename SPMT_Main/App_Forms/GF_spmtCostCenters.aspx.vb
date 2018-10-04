Partial Class GF_spmtCostCenters
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtCostCenters.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?CostCenterID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtCostCenters_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtCostCenters.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim CostCenterID As String = GVspmtCostCenters.DataKeys(e.CommandArgument).Values("CostCenterID")  
        Dim RedirectUrl As String = TBLspmtCostCenters.EditUrl & "?CostCenterID=" & CostCenterID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtCostCenters_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtCostCenters.Init
    DataClassName = "GspmtCostCenters"
    SetGridView = GVspmtCostCenters
  End Sub
  Protected Sub TBLspmtCostCenters_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtCostCenters.Init
    SetToolBar = TBLspmtCostCenters
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
