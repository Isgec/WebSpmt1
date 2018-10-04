Partial Class GF_spmtUploadBatch
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtUploadBatch.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?UploadBatchNo=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtUploadBatch_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtUploadBatch.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim UploadBatchNo As Int32 = GVspmtUploadBatch.DataKeys(e.CommandArgument).Values("UploadBatchNo")  
        Dim RedirectUrl As String = TBLspmtUploadBatch.EditUrl & "?UploadBatchNo=" & UploadBatchNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Deletewf".ToLower Then
      Try
        Dim UploadBatchNo As Int32 = GVspmtUploadBatch.DataKeys(e.CommandArgument).Values("UploadBatchNo")  
        SIS.SPMT.spmtUploadBatch.DeleteWF(UploadBatchNo)
        GVspmtUploadBatch.DataBind()
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtUploadBatch_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtUploadBatch.Init
    DataClassName = "GspmtUploadBatch"
    SetGridView = GVspmtUploadBatch
  End Sub
  Protected Sub TBLspmtUploadBatch_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtUploadBatch.Init
    SetToolBar = TBLspmtUploadBatch
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
