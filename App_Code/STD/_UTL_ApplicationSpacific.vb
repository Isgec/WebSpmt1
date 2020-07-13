Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports Microsoft.VisualBasic
Imports System
Imports ejiVault
Namespace SIS.SYS.Utilities
  Public Class ApplicationSpacific
    Public Shared Function IsAttached(ByVal Index As String, ByVal Handle As String) As Boolean
      Dim mRet As Boolean = False
      Dim cnt As Integer = 0
      Dim Sql As String = ""
      Sql &= " select isnull(count(t_indx),0) "
      Sql &= " from ttcisg132200"
      Sql &= " where t_hndl='" & Handle & "' "
      Sql &= " and t_indx='" & Index & "'"
      Sql &= ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          cnt = Cmd.ExecuteScalar
        End Using
      End Using
      If cnt > 0 Then mRet = True
      Return mRet
    End Function

    Public Shared Sub Initialize()
      With HttpContext.Current
        .Session("ApplicationID") = 15
        .Session("ApplicationDefaultPage") = "~/Default.aspx"
        .Session("FinanceCompany") = "200"
      End With
      EJI.DBCommon.BaaNLive = Convert.ToBoolean(ConfigurationManager.AppSettings("BaaNLive"))
      EJI.DBCommon.JoomlaLive = Convert.ToBoolean(ConfigurationManager.AppSettings("JoomlaLive"))
      EJI.DBCommon.ERPCompany = ConfigurationManager.AppSettings("ERPCompany")
      EJI.DBCommon.IsLocalISGECVault = Convert.ToBoolean(ConfigurationManager.AppSettings("IsLocalISGECVault"))
      EJI.DBCommon.ISGECVaultIP = ConfigurationManager.AppSettings("ISGECVaultIP")
    End Sub
    Public Shared Sub ApplicationReports(ByVal Context As HttpContext)
      If Not Context.Request.QueryString("ReportName") Is Nothing Then
        Select Case (Context.Request.QueryString("ReportName").ToLower)
        End Select
      End If
    End Sub
    Public Shared Function ContentType(ByVal FileName As String) As String
      Dim mRet As String = "application/octet-stream"
      Dim Extn As String = IO.Path.GetExtension(FileName).ToLower.Replace(".", "")
      Select Case Extn
        Case "pdf", "rtf"
          mRet = "application/" & Extn
        Case "doc", "docx"
          mRet = "application/vnd.ms-works"
        Case "xls", "xlsx"
          mRet = "application/vnd.ms-excel"
        Case "gif", "jpg", "jpeg", "png", "tif", "bmp"
          mRet = "image/" & Extn
        Case "pot", "ppt", "pps", "pptx", "ppsx"
          mRet = "application/vnd.ms-powerpoint"
        Case "htm", "html"
          mRet = "text/HTML"
        Case "txt"
          mRet = "text/plain"
        Case "zip"
          mRet = "application/zip"
        Case "rar", "tar", "tgz"
          mRet = "application/x-compressed"
        Case Else
          mRet = "application/octet-stream"
      End Select
      Return mRet
    End Function
  End Class
End Namespace