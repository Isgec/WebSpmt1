Imports System.Web.Script.Serialization
Partial Class GF_SPMTerpDCInventory
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_SPMTerpDCInventory.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ChallanID=" & aVal(0) & "&SerialNo=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVSPMTerpDCInventory_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVSPMTerpDCInventory.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCInventory.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim SerialNo As Int32 = GVSPMTerpDCInventory.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim RedirectUrl As String = TBLSPMTerpDCInventory.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub GVSPMTerpDCInventory_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSPMTerpDCInventory.Init
    DataClassName = "GSPMTerpDCInventory"
    SetGridView = GVSPMTerpDCInventory
  End Sub
  Protected Sub TBLSPMTerpDCInventory_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCInventory.Init
    SetToolBar = TBLSPMTerpDCInventory
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
