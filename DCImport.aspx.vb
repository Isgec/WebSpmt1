Imports System.Web.Script.Serialization

Partial Class DCImport
  Inherits System.Web.UI.Page

  Private Sub DCImport_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim PrimaryKey As String = ""
    Dim Comp As String = "200"
    If Request.QueryString("ChallanID") IsNot Nothing Then
      PrimaryKey = Request.QueryString("ChallanID")
      If Request.QueryString("Comp") IsNot Nothing Then
        Comp = Request.QueryString("Comp")
      Else
        Comp = "200"
      End If
      Dim tmp As String = SIS.SPMT.SPMTerpDCH.ImportDC(PrimaryKey, Comp)
      If tmp = "" Then
        Response.Redirect("~/SPMT_Main/App_Edit/EF_SPMTerpDCH_M.aspx?ChallanID=" & PrimaryKey)
      End If
      'Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
      '  Dim script As String = String.Format("alert({0});", message)
      '  ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
    End If

  End Sub
End Class
