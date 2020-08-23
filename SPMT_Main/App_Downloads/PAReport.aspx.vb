Imports System.Data
Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports System.Drawing

Partial Class PAReport
  Inherits System.Web.UI.Page
  Private fIrn As String = ""
  Private tIrn As String = ""
  Private fDt As String = ""
  Private tDt As String = ""
  Private fAdn As String = ""
  Private tAdn As String = ""
  Private sts As String = ""

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim mLastScriptTimeout As Integer = HttpContext.Current.Server.ScriptTimeout
    HttpContext.Current.Server.ScriptTimeout = 1200
    Dim aVal() As String
    Try
      aVal = Request.QueryString("val").Split("|".ToCharArray)
      fIrn = aVal(0)
      tIrn = aVal(1)
      fDt = aVal(2)
      tDt = aVal(3)
      fAdn = aVal(4)
      tAdn = aVal(5)
      sts = aVal(6)
    Catch ex As Exception
    End Try
    Dim DWFile As String = "PaymentAdviceList"
    Dim FilePath As String = CreateFile()
    HttpContext.Current.Server.ScriptTimeout = mLastScriptTimeout
    Response.ClearContent()
    Response.AppendHeader("content-disposition", "attachment; filename=" & DWFile & ".xlsx")
    Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(IO.Path.GetFileName(FilePath))
    Response.WriteFile(FilePath)
    Response.End()
  End Sub
  Private Function CreateFile() As String
    Dim FileName As String = Server.MapPath("~/..") & "App_Temp\" & Guid.NewGuid().ToString()
    IO.File.Copy(Server.MapPath("~/App_Templates") & "\PATemplate.xlsx", FileName)
    Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)
    Dim xlPk As ExcelPackage = New ExcelPackage(FileInfo)

    Dim xlWS As ExcelWorksheet = xlPk.Workbook.Worksheets("Report")
    Dim oDocs As List(Of PAReportClass) = PAReportClass.GetReport(fIrn, tIrn, fDt, tDt, fAdn, tAdn, sts)
    Dim r As Integer = 6
    Dim c As Integer = 2
    Dim s As Integer = 1
    xlWS.Cells(1, 3).Value = fIrn
    xlWS.Cells(1, 4).Value = tIrn
    xlWS.Cells(2, 3).Value = fDt
    xlWS.Cells(2, 4).Value = tDt
    xlWS.Cells(3, 3).Value = fAdn
    xlWS.Cells(3, 4).Value = tAdn
    xlWS.Cells(4, 3).Value = sts
    With xlWS
      For Each x As PAReportClass In oDocs
        If r > 6 Then
          xlWS.InsertRow(r, 1, r + 1)
        End If
        c = 2

        .Cells(r, c).Value = x.IRNo
        c = c + 1
        .Cells(r, c).Value = x.IRReceivedOn
        c = c + 1
        .Cells(r, c).Value = x.PurchaseType
        c = c + 1
        .Cells(r, c).Value = x.AdviceNo
        c = c + 1
        .Cells(r, c).Value = x.TranType
        c = c + 1
        .Cells(r, c).Value = x.ISGECGstin
        c = c + 1
        If x.SupplierName <> "" Then
          .Cells(r, c).Value = x.SupplierName
        Else
          .Cells(r, c).Value = x.BPName
        End If
        c = c + 1
        If x.SupplierGSTINNumber <> "" Then
          .Cells(r, c).Value = x.SupplierGSTINNumber
        Else
          .Cells(r, c).Value = x.BPGstin
        End If
        c = c + 1
        .Cells(r, c).Value = x.BillType
        c = c + 1
        .Cells(r, c).Value = x.HSNSACCode
        c = c + 1
        .Cells(r, c).Value = x.ShipToState
        c = c + 1
        .Cells(r, c).Value = x.BillNumber
        c = c + 1
        .Cells(r, c).Value = x.BillDate
        c = c + 1
        .Cells(r, c).Value = x.ItemDescription
        c = c + 1
        .Cells(r, c).Value = x.BasicValue
        c = c + 1
        .Cells(r, c).Value = x.IGSTRate
        c = c + 1
        .Cells(r, c).Value = x.IGSTAmount
        c = c + 1
        .Cells(r, c).Value = x.CGSTRate
        c = c + 1
        .Cells(r, c).Value = x.CGSTAmount
        c = c + 1
        .Cells(r, c).Value = x.SGSTRate
        c = c + 1
        .Cells(r, c).Value = x.SGSTAmount
        c = c + 1
        .Cells(r, c).Value = x.CessRate
        c = c + 1
        .Cells(r, c).Value = x.CessAmount
        c = c + 1
        .Cells(r, c).Value = x.TotalGST
        c = c + 1
        .Cells(r, c).Value = x.TotalAmount
        c = c + 1
        .Cells(r, c).Value = x.BillCreatedBy
        c = c + 1
        .Cells(r, c).Value = x.AdviceStatus
        c = c + 1
        .Cells(r, c).Value = x.RemarksAC
        c = c + 1
        .Cells(r, c).Value = x.VoucherType
        c = c + 1
        .Cells(r, c).Value = x.VoucherNo
        c = c + 1
        .Cells(r, c).Value = x.ERPCo
        c = c + 1
        .Cells(r, c).Value = x.AdviceUser
        c = c + 1
        .Cells(r, c).Value = x.LockBy
        c = c + 1

        r += 1

      Next
    End With
    xlPk.Save()
    xlPk.Dispose()
    Return FileName
  End Function
  Private Function RemoveChars(ByVal mstr As String) As String
    Return mstr.Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "").Replace(vbNewLine, "")
  End Function
End Class
Public Class PAReportClass

  Public Property IRNo As String = ""
  Public Property BillDate As String = ""
  Public Property PurchaseType As String = ""
  Public Property AdviceNo As String = ""
  Public Property TranType As String = ""
  Public Property ISGECGstin As String = ""
  Public Property SupplierName As String = ""
  Public Property BPName As String = ""
  Public Property BPGstin As String = ""
  Public Property SupplierGSTINNumber As String = ""
  Public Property BillType As String = ""
  Public Property HSNSACCode As String = ""
  Public Property ShipToState As String = ""
  Public Property ItemDescription As String = ""
  Public Property BillNumber As String = ""
  Public Property IRReceivedOn As String = ""
  Public Property BasicValue As String = ""
  Public Property CessRate As String = ""
  Public Property CessAmount As String = ""
  Public Property IGSTRate As String = ""
  Public Property IGSTAmount As String = ""
  Public Property SGSTRate As String = ""
  Public Property SGSTAmount As String = ""
  Public Property CGSTRate As String = ""
  Public Property CGSTAmount As String = ""
  Public Property TotalGST As String = ""
  Public Property TotalAmount As String = ""
  Public Property VoucherType As String = ""
  Public Property VoucherNo As String = ""
  Public Property ERPCo As String = ""
  Public Property LockBy As String = ""
  Public Property RemarksAC As String = ""
  Public Property AdviceStatus As String = ""
  Public Property AdviceStatusID As String = ""
  Public Property BillCreatedBy As String = ""
  Public Property AdviceUser As String = ""

  Public Shared Function GetReport(fIrn As String, tIrn As String, fDt As String, tDt As String, fAdn As String, tAdn As String, sts As String) As List(Of PAReportClass)
    Dim Results As List(Of PAReportClass) = Nothing
    Dim Sql As String = ""
    Sql &= " select * from spmt_vPAReport "
    Sql &= " where 1= 1"
    If fIrn <> "" Then
      Sql &= " and irno >=" & fIrn
    End If
    If tIrn <> "" Then
      Sql &= " and irno <=" & tIrn
    End If
    If fDt <> "" Then
      Sql &= " and IRReceivedOn >=convert(datetime,'" & fDt & "',103) "
    End If
    If tDt <> "" Then
      Sql &= " and IRReceivedOn <=convert(datetime,'" & tDt & "',103) "
    End If
    If fAdn <> "" Then
      Sql &= " and adviceno >=" & fAdn
    End If
    If tIrn <> "" Then
      Sql &= " and adviceno <=" & tAdn
    End If
    If sts <> "" Then
      Sql &= " and advicestatusid =" & sts
    End If
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Sql
        Cmd.CommandTimeout = 1200
        Results = New List(Of PAReportClass)
        Con.Open()
        Dim Reader As SqlDataReader = Cmd.ExecuteReader()
        While (Reader.Read())
          Results.Add(New PAReportClass(Reader))
        End While
        Reader.Close()
      End Using
    End Using
    Return Results
  End Function

  Public Sub New(ByVal Reader As SqlDataReader)
    Try
      For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
        If pi.MemberType = Reflection.MemberTypes.Property Then
          Try
            Dim Found As Boolean = False
            For I As Integer = 0 To Reader.FieldCount - 1
              If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                Found = True
                Exit For
              End If
            Next
            If Found Then
              If Convert.IsDBNull(Reader(pi.Name)) Then
                Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                  Case "decimal"
                    CallByName(Me, pi.Name, CallType.Let, "0.00")
                  Case "bit"
                    CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                  Case Else
                    CallByName(Me, pi.Name, CallType.Let, String.Empty)
                End Select
              Else
                CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
              End If
            End If
          Catch ex As Exception
          End Try
        End If
      Next
    Catch ex As Exception
    End Try
  End Sub
  Public Sub New()
  End Sub

End Class
