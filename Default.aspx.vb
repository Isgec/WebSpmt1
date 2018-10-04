Imports System.IO
Imports OfficeOpenXml
Imports System.Web.Script.Serialization
Partial Class LGDefault
  Inherits System.Web.UI.Page

  Private Sub LGDefault_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
    div1.Visible = False
    If HttpContext.Current.User.Identity.IsAuthenticated Then
      'div1.Visible = True
    End If
    Dim ts As IO.StreamReader = New IO.StreamReader(Server.MapPath("~/App_Templates/BTAFormat.txt"))
    Dim mstr As String = ts.ReadToEnd
    mstr = mstr.Replace(Chr(10), "")
    ts.Close()
    Dim aFields() As String = mstr.Split({Chr(13)})
  End Sub
End Class
