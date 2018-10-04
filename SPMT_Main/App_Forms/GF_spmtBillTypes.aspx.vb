Partial Class GF_spmtBillTypes
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtBillTypes.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?BillType=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtBillTypes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtBillTypes.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BillType As Int32 = GVspmtBillTypes.DataKeys(e.CommandArgument).Values("BillType")  
        Dim RedirectUrl As String = TBLspmtBillTypes.EditUrl & "?BillType=" & BillType
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtBillTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtBillTypes.Init
    DataClassName = "GspmtBillTypes"
    SetGridView = GVspmtBillTypes
  End Sub
  Protected Sub TBLspmtBillTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBillTypes.Init
    SetToolBar = TBLspmtBillTypes
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
