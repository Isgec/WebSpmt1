Partial Class RP_spmtBTADetails
  Inherits System.Web.UI.Page
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtBTADetails.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?SerialNo=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim aVal() As String = Request.QueryString("pk").Split("|".ToCharArray)
    Dim SerialNo As Int32 = CType(aVal(0),Int32)
    Dim oVar As SIS.SPMT.spmtBTADetails = SIS.SPMT.spmtBTADetails.spmtBTADetailsGetByID(SerialNo)
    Dim oTblspmtBTADetails As New Table
    oTblspmtBTADetails.Width = 1000
    oTblspmtBTADetails.GridLines = GridLines.Both
    oTblspmtBTADetails.Style.Add("margin-top", "15px")
    oTblspmtBTADetails.Style.Add("margin-left", "10px")
    Dim oColspmtBTADetails As TableCell = Nothing
    Dim oRowspmtBTADetails As TableRow = Nothing
    oRowspmtBTADetails = New TableRow
    oColspmtBTADetails = New TableCell
    oColspmtBTADetails.Text = "SerialNo"
    oColspmtBTADetails.Font.Bold = True
    oRowspmtBTADetails.Cells.Add(oColspmtBTADetails)
    oColspmtBTADetails = New TableCell
    oColspmtBTADetails.Text = oVar.SerialNo
      oColspmtBTADetails.Style.Add("text-align","right")
    oColspmtBTADetails.ColumnSpan = "2"
    oRowspmtBTADetails.Cells.Add(oColspmtBTADetails)
    oColspmtBTADetails = New TableCell
    oColspmtBTADetails.Text = "CORP_2"
    oColspmtBTADetails.Font.Bold = True
    oRowspmtBTADetails.Cells.Add(oColspmtBTADetails)
    oColspmtBTADetails = New TableCell
    oColspmtBTADetails.Text = oVar.CORP_2
      oColspmtBTADetails.Style.Add("text-align","left")
    oColspmtBTADetails.ColumnSpan = "2"
    oRowspmtBTADetails.Cells.Add(oColspmtBTADetails)
    oTblspmtBTADetails.Rows.Add(oRowspmtBTADetails)
    form1.Controls.Add(oTblspmtBTADetails)
  End Sub
End Class
