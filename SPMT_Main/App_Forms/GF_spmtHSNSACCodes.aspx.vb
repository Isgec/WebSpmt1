Partial Class GF_spmtHSNSACCodes
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtHSNSACCodes.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?BillType=" & aVal(0) & "&HSNSACCode=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtHSNSACCodes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtHSNSACCodes.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BillType As Int32 = GVspmtHSNSACCodes.DataKeys(e.CommandArgument).Values("BillType")  
        Dim HSNSACCode As String = GVspmtHSNSACCodes.DataKeys(e.CommandArgument).Values("HSNSACCode")  
        Dim RedirectUrl As String = TBLspmtHSNSACCodes.EditUrl & "?BillType=" & BillType & "&HSNSACCode=" & HSNSACCode
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtHSNSACCodes.Init
    DataClassName = "GspmtHSNSACCodes"
    SetGridView = GVspmtHSNSACCodes
  End Sub
  Protected Sub TBLspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtHSNSACCodes.Init
    SetToolBar = TBLspmtHSNSACCodes
  End Sub
  Protected Sub F_BillType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_BillType.SelectedIndexChanged
    Session("F_BillType") = F_BillType.SelectedValue
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_BillType.SelectedValue = String.Empty
    If Not Session("F_BillType") Is Nothing Then
      If Session("F_BillType") <> String.Empty Then
        F_BillType.SelectedValue = Session("F_BillType")
      End If
    End If
  End Sub
End Class
