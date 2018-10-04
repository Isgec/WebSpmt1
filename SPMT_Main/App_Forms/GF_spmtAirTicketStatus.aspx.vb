Partial Class GF_spmtAirTicketStatus
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtAirTicketStatus.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?StatusID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtAirTicketStatus_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtAirTicketStatus.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim StatusID As Int32 = GVspmtAirTicketStatus.DataKeys(e.CommandArgument).Values("StatusID")  
        Dim RedirectUrl As String = TBLspmtAirTicketStatus.EditUrl & "?StatusID=" & StatusID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtAirTicketStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtAirTicketStatus.Init
    DataClassName = "GspmtAirTicketStatus"
    SetGridView = GVspmtAirTicketStatus
  End Sub
  Protected Sub TBLspmtAirTicketStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtAirTicketStatus.Init
    SetToolBar = TBLspmtAirTicketStatus
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
