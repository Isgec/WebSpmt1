Imports System.Web.Script.Serialization
Partial Class GF_comFinanceCompany
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/COM_Main/App_Display/DF_comFinanceCompany.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?FinanceCompany=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVcomFinanceCompany_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVcomFinanceCompany.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim FinanceCompany As String = GVcomFinanceCompany.DataKeys(e.CommandArgument).Values("FinanceCompany")  
        Dim RedirectUrl As String = TBLcomFinanceCompany.EditUrl & "?FinanceCompany=" & FinanceCompany
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub GVcomFinanceCompany_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVcomFinanceCompany.Init
    DataClassName = "GcomFinanceCompany"
    SetGridView = GVcomFinanceCompany
  End Sub
  Protected Sub TBLcomFinanceCompany_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomFinanceCompany.Init
    SetToolBar = TBLcomFinanceCompany
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
