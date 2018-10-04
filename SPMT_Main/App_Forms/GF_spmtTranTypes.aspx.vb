Partial Class GF_spmtTranTypes
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtTranTypes.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?TranTypeID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtTranTypes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtTranTypes.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim TranTypeID As String = GVspmtTranTypes.DataKeys(e.CommandArgument).Values("TranTypeID")  
        Dim RedirectUrl As String = TBLspmtTranTypes.EditUrl & "?TranTypeID=" & TranTypeID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtTranTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtTranTypes.Init
    DataClassName = "GspmtTranTypes"
    SetGridView = GVspmtTranTypes
  End Sub
  Protected Sub TBLspmtTranTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtTranTypes.Init
    SetToolBar = TBLspmtTranTypes
  End Sub
  Protected Sub F_GroupID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_GroupID.SelectedIndexChanged
    Session("F_GroupID") = F_GroupID.SelectedValue
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_GroupID.SelectedValue = String.Empty
    If Not Session("F_GroupID") Is Nothing Then
      If Session("F_GroupID") <> String.Empty Then
        F_GroupID.SelectedValue = Session("F_GroupID")
      End If
    End If
  End Sub
End Class
