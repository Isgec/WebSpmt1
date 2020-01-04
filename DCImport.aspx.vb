Imports System.Web.Script.Serialization

Partial Class DCImport
  Inherits System.Web.UI.Page

  Private Sub DCImport_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim PrimaryKey As String = ""
    Dim Comp As String = "200"
    Dim UserID As String = ""
    If Request.QueryString("ChallanID") IsNot Nothing Then
      PrimaryKey = Request.QueryString("ChallanID")
      If Request.QueryString("Comp") IsNot Nothing Then
        Comp = Request.QueryString("Comp")
        Select Case Comp
          Case "700"
          Case "651"
          Case Else
            Comp = "200"
        End Select
      Else
        Comp = "200"
      End If
      HttpContext.Current.Session("FinanceCompany") = Comp
      If Request.QueryString("UserID") IsNot Nothing Then
        UserID = Request.QueryString("UserID")
        If UserID <> "" Then
          SIS.SYS.Utilities.SessionManager.DoLogin(UserID)
        End If
      End If
      HttpContext.Current.Session("LoginID") = UserID
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
