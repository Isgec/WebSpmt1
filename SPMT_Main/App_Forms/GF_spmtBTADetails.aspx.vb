Imports OfficeOpenXml
Imports System.Web.Script.Serialization
Imports System.IO
Partial Class GF_spmtBTADetails
  Inherits SIS.SYS.GridBase
  Protected Sub GVspmtBTADetails_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtBTADetails.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim SerialNo As Int32 = GVspmtBTADetails.DataKeys(e.CommandArgument).Values("SerialNo")
        Dim RedirectUrl As String = TBLspmtBTADetails.EditUrl & "?SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "initiatewf".ToLower Then
      Try
        Dim SerialNo As Int32 = GVspmtBTADetails.DataKeys(e.CommandArgument).Values("SerialNo")
        SIS.SPMT.spmtBTADetails.InitiateWF(SerialNo)
        GVspmtBTADetails.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub GVspmtBTADetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtBTADetails.Init
    DataClassName = "GspmtBTADetails"
    SetGridView = GVspmtBTADetails
  End Sub
  Protected Sub TBLspmtBTADetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBTADetails.Init
    SetToolBar = TBLspmtBTADetails
  End Sub
  Private st As Long = HttpContext.Current.Server.ScriptTimeout

  Private Sub cmdTmplUpload_Command(sender As Object, e As CommandEventArgs) Handles cmdTmplUpload.Command
    If e.CommandName.ToLower <> "tmplUpload".ToLower Then Exit Sub
    If IsUploaded.Value <> "YES" Then Exit Sub
    IsUploaded.Value = ""

    HttpContext.Current.Server.ScriptTimeout = Integer.MaxValue
    Try
      With F_FileUpload
        If .HasFile Then
          Dim tmpPath As String = Server.MapPath("~/../App_Temp")
          Dim tmpName As String = IO.Path.GetRandomFileName()
          Dim tmpFile As String = tmpPath & "\\" & tmpName
          .SaveAs(tmpFile)
          'First Read Field Position From Template
          'Dim aFields()
          Dim ts As IO.StreamReader = New IO.StreamReader(Server.MapPath("~/App_Templates/BTAFormat.txt"))
          Dim mStr As String = ts.ReadToEnd
          mStr = mStr.Replace(Chr(10), "")
          Dim aFields() As String = mStr.Split({Chr(13)})
          ts.Close()
          For Each str As String In aFields
            str = str.Trim
          Next
          'Open data file
          ts = New IO.StreamReader(tmpFile)
          Dim IsError As Boolean = False
          Dim ErrMsg As String = ""
          Dim BatchNo As Integer = 1 ''GetNextBatch
          mStr = ts.ReadLine
          Do While mStr IsNot Nothing
            Dim tmpVal() As String = mStr.Split("{".ToCharArray)
            Dim tmpBTA As New SIS.SPMT.spmtBTADetails
            For I As Integer = 0 To aFields.Length - 1
              CallByName(tmpBTA, aFields(I), CallType.Set, tmpVal(I))
            Next
            tmpBTA.BatchNo = BatchNo
            tmpBTA.StatusID = 1 'Free
            tmpBTA.CreatedBy = HttpContext.Current.Session("LoginID")
            tmpBTA.CreatedOn = Now
            SIS.SPMT.spmtBTADetails.InsertData(tmpBTA)

            mStr = ts.ReadLine
          Loop
          ts.Close()
          'close data file
        End If
      End With
    Catch ex As Exception
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
    End Try
    HttpContext.Current.Server.ScriptTimeout = st

  End Sub
End Class
