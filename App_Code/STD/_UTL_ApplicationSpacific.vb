Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports Microsoft.VisualBasic
Imports System
Namespace SIS.SYS.Utilities
	Public Class ApplicationSpacific
    Public Shared Sub Initialize()
      With HttpContext.Current
        .Session("ApplicationID") = 15
        .Session("ApplicationDefaultPage") = "~/Default.aspx"
        .Session("FinanceCompany") = "200"
        'User Groups
        'Dim uGrp As String = String.Empty
        'Dim uGroups As List(Of SIS.COM.comGroupUsers) = SIS.COM.comGroupUsers.GetByLoginID(HttpContext.Current.Session("LoginID"), "")
        'For Each ug As SIS.COM.comGroupUsers In uGroups
        '  If ug.Active Then
        '    If uGrp = String.Empty Then
        '      uGrp = ug.GroupID
        '    Else
        '      uGrp &= "','" & ug.GroupID
        '    End If
        '  End If
        'Next
        '.Session("UserGroups") = uGrp
        'End of User Groups
      End With
    End Sub
    Public Shared Sub ApplicationReports(ByVal Context As HttpContext)
      If Not Context.Request.QueryString("ReportName") Is Nothing Then
        Select Case (Context.Request.QueryString("ReportName").ToLower)
          'Case "paymentadvice"
          '  Dim oRep As RPT_spmtPaymentAdvice = New RPT_spmtPaymentAdvice(Context)
          '  oRep.GenerateReport()
          '    Case "bc_bookings"
          '      Dim oRep As RPT_spmtBC = New RPT_spmtBC(Context)
          '      oRep.GenerateReport()
          '    Case "fe_bookings"
          '      Dim oRep As RPT_spmtFE = New RPT_spmtFE(Context)
          '      oRep.GenerateReport()
          '      'Case "complaintregister"
          '      '	Dim oRep As RPT_admITRegisterComplaint = New RPT_admITRegisterComplaint(Context)
          '      '	oRep.GenerateReport()
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