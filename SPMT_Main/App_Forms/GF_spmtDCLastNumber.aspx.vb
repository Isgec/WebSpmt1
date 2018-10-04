Partial Class GF_spmtDCLastNumber
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtDCLastNumber.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?NumberID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtDCLastNumber_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtDCLastNumber.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim NumberID As Int32 = GVspmtDCLastNumber.DataKeys(e.CommandArgument).Values("NumberID")  
        Dim RedirectUrl As String = TBLspmtDCLastNumber.EditUrl & "?NumberID=" & NumberID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtDCLastNumber_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtDCLastNumber.Init
    DataClassName = "GspmtDCLastNumber"
    SetGridView = GVspmtDCLastNumber
  End Sub
  Protected Sub TBLspmtDCLastNumber_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCLastNumber.Init
    SetToolBar = TBLspmtDCLastNumber
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
