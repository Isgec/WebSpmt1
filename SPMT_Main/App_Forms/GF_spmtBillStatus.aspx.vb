Partial Class GF_spmtBillStatus
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtBillStatus.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?BillStatusID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtBillStatus_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtBillStatus.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BillStatusID As Int32 = GVspmtBillStatus.DataKeys(e.CommandArgument).Values("BillStatusID")  
        Dim RedirectUrl As String = TBLspmtBillStatus.EditUrl & "?BillStatusID=" & BillStatusID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtBillStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtBillStatus.Init
    DataClassName = "GspmtBillStatus"
    SetGridView = GVspmtBillStatus
  End Sub
  Protected Sub TBLspmtBillStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBillStatus.Init
    SetToolBar = TBLspmtBillStatus
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
