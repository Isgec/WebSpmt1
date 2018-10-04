Partial Class GF_spmtIsgecGSTIN
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtIsgecGSTIN.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?GSTID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtIsgecGSTIN_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtIsgecGSTIN.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim GSTID As Int32 = GVspmtIsgecGSTIN.DataKeys(e.CommandArgument).Values("GSTID")  
        Dim RedirectUrl As String = TBLspmtIsgecGSTIN.EditUrl & "?GSTID=" & GSTID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtIsgecGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtIsgecGSTIN.Init
    DataClassName = "GspmtIsgecGSTIN"
    SetGridView = GVspmtIsgecGSTIN
  End Sub
  Protected Sub TBLspmtIsgecGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtIsgecGSTIN.Init
    SetToolBar = TBLspmtIsgecGSTIN
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
