Imports OfficeOpenXml
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Script.Serialization
Partial Class RP_spmtOrderToStock
  Inherits SIS.SYS.GridBase
  Protected Sub TBLspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCHeader.Init
    SetToolBar = TBLspmtDCHeader
  End Sub

  Private Function CreateReport(ByVal sDt As String, ByVal tDt As String) As String
    Dim FileName As String = Server.MapPath("~/..") & "App_Temp\" & Guid.NewGuid().ToString()
    IO.File.Copy(Server.MapPath("~/App_Templates") & "\OrderToStock_Template.xlsx", FileName)
    Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)
    Dim xlPk As ExcelPackage = New ExcelPackage(FileInfo)
    Dim xlWS As ExcelWorksheet = xlPk.Workbook.Worksheets("Report")

    Dim r As Integer = 5
    Dim c As Integer = 1

    Dim aFld() As String
    ReDim aFld(0)
    Do While xlWS.Cells(r, c).Text <> String.Empty
      ReDim Preserve aFld(c - 1)
      aFld(c - 1) = xlWS.Cells(r, c).Text
      c += 1
    Loop
    Dim oDocs As List(Of rp_doc) = GetData(sDt, tDt)
    With xlWS
      .Cells(2, 2).Value = sDt
      .Cells(2, 4).Value = tDt

      For Each doc As rp_doc In oDocs
        If r > 5 Then xlWS.InsertRow(r, 1, r + 1)
        For c = 0 To aFld.Length
          Try
            Dim aTmp() As String = aFld(c).Trim.Split(".".ToCharArray)
            If aTmp.Length > 1 Then
              Dim oBj As Object = CallByName(doc, aTmp(0), CallType.Get)
              .Cells(r, c + 1).Value = CallByName(oBj, aTmp(1), CallType.Get)
            Else
              .Cells(r, c + 1).Value = CallByName(doc, aFld(c).Trim, CallType.Get)
            End If
          Catch ex As Exception
          End Try
        Next
        r += 1
      Next
    End With
    xlPk.Save()
    xlPk.Dispose()
    Return FileName
  End Function

  Private Function GetData(ByVal sDt As String, ByVal tDt As String) As List(Of rp_doc)

    Dim Results As List(Of rp_doc) = Nothing
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "spspmt_LG_OrderToStockByDateRange"
        Cmd.CommandText = "spspmt_LG_vOrderToStockByDateRange"
        SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@sDt", SqlDbType.DateTime, 21, sDt)
        SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@tDt", SqlDbType.DateTime, 21, tDt)
        Results = New List(Of rp_doc)()
        Con.Open()
        Dim Reader As SqlDataReader = Cmd.ExecuteReader()
        While (Reader.Read())
          Results.Add(New rp_doc(Reader))
        End While
        Reader.Close()
      End Using
    End Using
    Return Results
  End Function

  Private Sub cmdReport_Click(sender As Object, e As EventArgs) Handles cmdReport.Click
    Dim sDt As String = F_sDt.Text
    Dim tDt As String = F_tDt.Text
    Dim DWFile As String = "DC_" & Now.Minute & "_" & Now.Second
    Dim FilePath As String = CreateReport(sDt, tDt)
    Response.ClearContent()
    Response.AppendHeader("content-disposition", "attachment; filename=" & DWFile & ".xlsx")
    Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(IO.Path.GetFileName(FilePath))
    Response.WriteFile(FilePath)
    Response.End()

  End Sub
End Class
Public Class rp_doc
  Public Property ChallanID As String = ""
  Public Property ChallanDate As String = ""
  Public Property Status As String = ""
  Public Property ConsignerBPID As String = ""
  Public Property ConsignerName As String = ""
  Public Property BPName As String = ""
  Public Property ConsignerGSTIN As String = ""
  Public Property JobworkEstate As String = ""
  Public Property ItemDescription As String = ""
  Public Property BaseRate As String = ""
  Public Property Quantity As String = ""
  Public Property HSNCodeItem As String = ""
  Public Property UOM As String = ""
  Public Property AssessableValue As String = ""
  Public Property IGSTRate As String = ""
  Public Property IGSTAmount As String = ""
  Public Property ISGEC_GSTIN As String = ""
  Public Property ConsigneeBPID As String = ""
  Public Property ConsigneeName As String = ""
  Public Property ConsigneeBPName As String = ""
  Public Property ConsigneeGSTIN As String = ""
  Public Property SGSTRate As String = ""
  Public Property SGSTAmount As String = ""
  Public Property CGSTRate As String = ""
  Public Property CGSTAmount As String = ""
  Public Property Purpose As String = ""
  Public Property UserFullName As String = ""
  Public Property CreatedOn As String = ""
  Public Property PONo As String = ""
  Public Property ProjectID As String = ""
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
                    CallByName(Me, pi.Name, CallType.Let, "0.0000")
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
