Partial Class RP_spmtPaymentAdvice
  Inherits System.Web.UI.Page

  Private Sub RP_spmtPaymentAdvice_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim aVal() As String = Request.QueryString("pk").Split("|".ToCharArray)
    Dim AdviceNo As Int32 = CType(aVal(0), Int32)
    Dim tmp As New RPT_spmtPaymentAdvice
    tmp.AdviceNo = AdviceNo
    Dim str As String = tmp.ProcessReport
    rep.InnerHtml = str
  End Sub
  'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

  '  Dim aVal() As String = Request.QueryString("pk").Split("|".ToCharArray)
  '  Dim AdviceNo As Int32 = CType(aVal(0), Int32)


  '  Dim oVar As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(AdviceNo)
  '  Dim oTblspmtPaymentAdvice As New Table
  '  oTblspmtPaymentAdvice.Width = 1000
  '  oTblspmtPaymentAdvice.GridLines = GridLines.Both
  '  oTblspmtPaymentAdvice.Style.Add("margin-top", "15px")
  '  oTblspmtPaymentAdvice.Style.Add("margin-left", "10px")
  '  Dim oColspmtPaymentAdvice As TableCell = Nothing
  '  Dim oRowspmtPaymentAdvice As TableRow = Nothing
  '  oRowspmtPaymentAdvice = New TableRow
  '  oColspmtPaymentAdvice = New TableCell
  '  oColspmtPaymentAdvice.Text = "Advice No"
  '  oColspmtPaymentAdvice.Font.Bold = True
  '  oRowspmtPaymentAdvice.Cells.Add(oColspmtPaymentAdvice)
  '  oColspmtPaymentAdvice = New TableCell
  '  oColspmtPaymentAdvice.Text = oVar.AdviceNo
  '  oColspmtPaymentAdvice.Style.Add("text-align", "right")
  '  oColspmtPaymentAdvice.ColumnSpan = "2"
  '  oRowspmtPaymentAdvice.Cells.Add(oColspmtPaymentAdvice)
  '  oColspmtPaymentAdvice = New TableCell
  '  oColspmtPaymentAdvice.Text = "Tran Type ID"
  '  oColspmtPaymentAdvice.Font.Bold = True
  '  oRowspmtPaymentAdvice.Cells.Add(oColspmtPaymentAdvice)
  '  oColspmtPaymentAdvice = New TableCell
  '  oColspmtPaymentAdvice.Text = oVar.TranTypeID
  '  oColspmtPaymentAdvice.Style.Add("text-align", "left")
  '  oRowspmtPaymentAdvice.Cells.Add(oColspmtPaymentAdvice)
  '  oColspmtPaymentAdvice = New TableCell
  '  oColspmtPaymentAdvice.Text = oVar.SPMT_TranTypes10_Description
  '  oColspmtPaymentAdvice.Style.Add("text-align", "left")
  '  oRowspmtPaymentAdvice.Cells.Add(oColspmtPaymentAdvice)
  '  oTblspmtPaymentAdvice.Rows.Add(oRowspmtPaymentAdvice)
  '  form1.Controls.Add(oTblspmtPaymentAdvice)
  '  Dim oTblspmtPaymentAdviceSupplierBill As Table = Nothing
  '  Dim oRowspmtPaymentAdviceSupplierBill As TableRow = Nothing
  '  Dim oColspmtPaymentAdviceSupplierBill As TableCell = Nothing
  '  Dim ospmtPaymentAdviceSupplierBills As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.UZ_spmtPaymentAdviceSupplierBillSelectList(0, 999, "", False, "", oVar.AdviceNo)
  '  If ospmtPaymentAdviceSupplierBills.Count > 0 Then
  '    Dim oTblhspmtPaymentAdviceSupplierBill As Table = New Table
  '    oTblhspmtPaymentAdviceSupplierBill.Width = 1000
  '    oTblhspmtPaymentAdviceSupplierBill.Style.Add("margin-top", "15px")
  '    oTblhspmtPaymentAdviceSupplierBill.Style.Add("margin-left", "10px")
  '    oTblhspmtPaymentAdviceSupplierBill.Style.Add("margin-right", "10px")
  '    Dim oRowhspmtPaymentAdviceSupplierBill As TableRow = New TableRow
  '    Dim oColhspmtPaymentAdviceSupplierBill As TableCell = New TableCell
  '    oColhspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColhspmtPaymentAdviceSupplierBill.Font.Underline = True
  '    oColhspmtPaymentAdviceSupplierBill.Font.Size = 10
  '    oColhspmtPaymentAdviceSupplierBill.CssClass = "grpHD"
  '    oColhspmtPaymentAdviceSupplierBill.Text = "Selected Bills"
  '    oRowhspmtPaymentAdviceSupplierBill.Cells.Add(oColhspmtPaymentAdviceSupplierBill)
  '    oTblhspmtPaymentAdviceSupplierBill.Rows.Add(oRowhspmtPaymentAdviceSupplierBill)
  '    form1.Controls.Add(oTblhspmtPaymentAdviceSupplierBill)
  '    oTblspmtPaymentAdviceSupplierBill = New Table
  '    oTblspmtPaymentAdviceSupplierBill.Width = 1000
  '    oTblspmtPaymentAdviceSupplierBill.GridLines = GridLines.Both
  '    oTblspmtPaymentAdviceSupplierBill.Style.Add("margin-left", "10px")
  '    oTblspmtPaymentAdviceSupplierBill.Style.Add("margin-right", "10px")
  '    oRowspmtPaymentAdviceSupplierBill = New TableRow
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "IR No"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Tran.Type"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "IR Received On"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "VendorID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Bill Number"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Bill Date"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Bill Amount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Item Description"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BillStatusID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BillStatusDate"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BillStatusUser"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "LogisticLinked"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ApprovedAmount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Remarks"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "PassedAmount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "RemarksAC"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ReturnedByAC"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ReasonID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "AdviceNo"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ConcernedHOD"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "CostCenter"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ProjectID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ElementID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "EmployeeID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "DepartmentID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "CostCenterID"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "VoucherNo"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "DocumentNo"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "DocumentLine"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BaaNCompany"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BaaNLedger"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Isgec GSTIN"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Supplier"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Supplier GSTIN"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Bill Type"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "HSN / SAC Code"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "UOM"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Ship To State"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Quantity"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BasicValue"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Discount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "ServiceCharge"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Basic / Assessable Value"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "TaxRate"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Total GST [INR]"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Cess Rate"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Cess Amount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Total GST"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Total Amount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Remarks GST"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Currency"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Conversion Factor INR"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Total Amount INR"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "Purchase Type"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "IGST Rate"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "IGST Amount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "SGST Rate"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "SGST Amount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "CGST Rate"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "CGST Amount"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "BatchNo"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "DocNo"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oColspmtPaymentAdviceSupplierBill = New TableCell
  '    oColspmtPaymentAdviceSupplierBill.Text = "DocLine"
  '    oColspmtPaymentAdviceSupplierBill.Font.Bold = True
  '    oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
  '    oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '    oTblspmtPaymentAdviceSupplierBill.Rows.Add(oRowspmtPaymentAdviceSupplierBill)
  '    For Each ospmtPaymentAdviceSupplierBill As SIS.SPMT.spmtPaymentAdviceSupplierBill In ospmtPaymentAdviceSupplierBills
  '      oRowspmtPaymentAdviceSupplierBill = New TableRow
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IRNo
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_TranTypes16_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IRReceivedOn
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.VendorID
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillNumber
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillDate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillRemarks
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_BillStatus7_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillStatusDate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.aspnet_Users1_UserFullName
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = IIf(ospmtPaymentAdviceSupplierBill.LogisticLinked, "YES", "NO")
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.ApprovedAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.Remarks
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.PassedAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.RemarksAC
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = IIf(ospmtPaymentAdviceSupplierBill.ReturnedByAC, "YES", "NO")
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_ReturnReason15_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_PaymentAdvice14_BPID
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.aspnet_Users2_UserFullName
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CostCenter
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IDM_Projects5_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IDM_WBS6_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.aspnet_Users3_UserFullName
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.HRM_Departments4_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_CostCenters9_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.VoucherNo
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.DocumentNo
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.DocumentLine
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BaaNCompany
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BaaNLedger
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_IsgecGSTIN13_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.VR_BusinessPartner18_BPName
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.VR_BPGSTIN17_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_BillTypes8_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_HSNSACCodes12_HSNSACCode
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_ERPUnits11_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_ERPStates10_Description
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.Quantity
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BasicValue
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.Discount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.ServiceCharge
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.AssessableValue
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TaxRate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TaxAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CessRate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CessAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TotalGST
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TotalAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.RemarksGST
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.Currency
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.ConversionFactorINR
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TotalAmountINR
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.PurchaseType
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IGSTRate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IGSTAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SGSTRate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SGSTAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CGSTRate
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CGSTAmount
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BatchNo
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.DocNo
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oColspmtPaymentAdviceSupplierBill = New TableCell
  '      oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
  '      oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.DocLine
  '      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
  '      oTblspmtPaymentAdviceSupplierBill.Rows.Add(oRowspmtPaymentAdviceSupplierBill)
  '    Next
  '    form1.Controls.Add(oTblspmtPaymentAdviceSupplierBill)
  '  End If
  '  Dim oTblspmtUnlinkedSupplierBill As Table = Nothing
  '  Dim oRowspmtUnlinkedSupplierBill As TableRow = Nothing
  '  Dim oColspmtUnlinkedSupplierBill As TableCell = Nothing
  '  Dim ospmtUnlinkedSupplierBills As List(Of SIS.SPMT.spmtUnlinkedSupplierBill) = SIS.SPMT.spmtUnlinkedSupplierBill.UZ_spmtUnlinkedSupplierBillSelectList(0, 999, "", False, "", oVar.AdviceNo, "")
  '  If ospmtUnlinkedSupplierBills.Count > 0 Then
  '    Dim oTblhspmtUnlinkedSupplierBill As Table = New Table
  '    oTblhspmtUnlinkedSupplierBill.Width = 1000
  '    oTblhspmtUnlinkedSupplierBill.Style.Add("margin-top", "15px")
  '    oTblhspmtUnlinkedSupplierBill.Style.Add("margin-left", "10px")
  '    oTblhspmtUnlinkedSupplierBill.Style.Add("margin-right", "10px")
  '    Dim oRowhspmtUnlinkedSupplierBill As TableRow = New TableRow
  '    Dim oColhspmtUnlinkedSupplierBill As TableCell = New TableCell
  '    oColhspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColhspmtUnlinkedSupplierBill.Font.Underline = True
  '    oColhspmtUnlinkedSupplierBill.Font.Size = 10
  '    oColhspmtUnlinkedSupplierBill.CssClass = "grpHD"
  '    oColhspmtUnlinkedSupplierBill.Text = "Pending Bills"
  '    oRowhspmtUnlinkedSupplierBill.Cells.Add(oColhspmtUnlinkedSupplierBill)
  '    oTblhspmtUnlinkedSupplierBill.Rows.Add(oRowhspmtUnlinkedSupplierBill)
  '    form1.Controls.Add(oTblhspmtUnlinkedSupplierBill)
  '    oTblspmtUnlinkedSupplierBill = New Table
  '    oTblspmtUnlinkedSupplierBill.Width = 1000
  '    oTblspmtUnlinkedSupplierBill.GridLines = GridLines.Both
  '    oTblspmtUnlinkedSupplierBill.Style.Add("margin-left", "10px")
  '    oTblspmtUnlinkedSupplierBill.Style.Add("margin-right", "10px")
  '    oRowspmtUnlinkedSupplierBill = New TableRow
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "IR No"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Tran.Type"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "IR Received On"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "VendorID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Bill Number"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Bill Date"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Bill Amount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Item Description"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BillStatusID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BillStatusDate"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BillStatusUser"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "LogisticLinked"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ApprovedAmount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Remarks"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "PassedAmount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "RemarksAC"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ReturnedByAC"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ReasonID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "AdviceNo"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ConcernedHOD"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "CostCenter"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ProjectID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ElementID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "EmployeeID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "DepartmentID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "CostCenterID"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "VoucherNo"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "DocumentNo"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "DocumentLine"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BaaNCompany"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BaaNLedger"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Isgec GSTIN"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Supplier"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Supplier GSTIN"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Bil Type"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "HSN / SAC Code"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "UOM"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Ship To State"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Quantity"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BasicValue"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Discount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "ServiceCharge"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Basic / Assessable Value"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "TaxRate"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Total GST [INR]"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Cess Rate"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Cess Amount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Total GST"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Total Amount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Remarks GST"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Currency"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Conversion Factor INR"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Total Amount INR"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "Purchase Type"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "IGST Rate"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "IGST Amount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "SGST Rate"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "SGST Amount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "CGST Rate"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "CGST Amount"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "BatchNo"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "DocNo"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oColspmtUnlinkedSupplierBill = New TableCell
  '    oColspmtUnlinkedSupplierBill.Text = "DocLine"
  '    oColspmtUnlinkedSupplierBill.Font.Bold = True
  '    oColspmtUnlinkedSupplierBill.CssClass = "colHD"
  '    oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '    oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '    oTblspmtUnlinkedSupplierBill.Rows.Add(oRowspmtUnlinkedSupplierBill)
  '    For Each ospmtUnlinkedSupplierBill As SIS.SPMT.spmtUnlinkedSupplierBill In ospmtUnlinkedSupplierBills
  '      oRowspmtUnlinkedSupplierBill = New TableRow
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IRNo
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_TranTypes16_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IRReceivedOn
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VendorID
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillNumber
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillDate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillRemarks
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_BillStatus7_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillStatusDate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.aspnet_Users1_UserFullName
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = IIf(ospmtUnlinkedSupplierBill.LogisticLinked, "YES", "NO")
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.ApprovedAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Remarks
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.PassedAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.RemarksAC
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = IIf(ospmtUnlinkedSupplierBill.ReturnedByAC, "YES", "NO")
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "center")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_ReturnReason15_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_PaymentAdvice14_BPID
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.aspnet_Users2_UserFullName
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CostCenter
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IDM_Projects5_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IDM_WBS6_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.aspnet_Users3_UserFullName
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.HRM_Departments4_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_CostCenters9_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VoucherNo
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocumentNo
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocumentLine
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BaaNCompany
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BaaNLedger
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_IsgecGSTIN13_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VR_BusinessPartner18_BPName
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VR_BPGSTIN17_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_BillTypes8_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_HSNSACCodes12_HSNSACCode
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_ERPUnits11_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_ERPStates10_Description
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Quantity
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BasicValue
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Discount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.ServiceCharge
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.AssessableValue
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TaxRate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TaxAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CessRate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CessAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TotalGST
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TotalAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.RemarksGST
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Currency
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.ConversionFactorINR
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TotalAmountINR
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.PurchaseType
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IGSTRate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IGSTAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SGSTRate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SGSTAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CGSTRate
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CGSTAmount
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "right")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BatchNo
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocNo
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oColspmtUnlinkedSupplierBill = New TableCell
  '      oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
  '      oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocLine
  '      oColspmtUnlinkedSupplierBill.Style.Add("text-align", "left")
  '      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
  '      oTblspmtUnlinkedSupplierBill.Rows.Add(oRowspmtUnlinkedSupplierBill)
  '    Next
  '    form1.Controls.Add(oTblspmtUnlinkedSupplierBill)
  '  End If
  'End Sub
End Class
Public Class RPT_spmtPaymentAdvice
  Private ReportWidth As Integer = 1000
  Public Property AdviceNo As Integer = 0
  Public Property Report As String = ""
  Public Sub Print(ByVal pStr As String)
    Report &= pStr
  End Sub

  Public Function ProcessReport() As String
    Report = ""
    Dim Hdr As String = "PAYMENT ADVICE"

    Dim oPA As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(AdviceNo)
    If oPA.AdviceStatusID <= 5 Then
      Hdr = "PROVISIONAL " & Hdr
    End If

    Dim tmp As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(0, 1, "", False, "", oPA.AdviceNo)


    Print("<table width=""" & ReportWidth & "px""><tr><td style=""text-align:center;font-size: 14px;font-weight:bold;border:none""><u>" & Hdr & "</u></td></tr></table>")
    Print("<table width=""" & ReportWidth & "px""><tr><td style=""text-align:center;font-size: 12px;font-weight:bold;border:none""><u>" & oPA.SPMT_TranTypes10_Description & "</u></td></tr></table>")

    Print("</br>")

    Print("<table width=""" & ReportWidth & "px"">")
    Print("<tr>")
    Print("<td style=""font-size:10px;font-weight:bold;width:15%;text-align:left;vertical-align:top"">Advice No:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;width:30%;text-align:left;vertical-align:top"">" & oPA.AdviceNo & "</td>")
    Print("<td style=""font-size:10px;font-weight:bold;width:30%;text-align:right;vertical-align:top"">Date:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;width:25%;text-align:right;vertical-align:top"">" & oPA.AdviceStatusOn & "</td>")
    Print("</tr>")
    Print("<tr>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">Supplier:</td>")
    If oPA.SupplierName = "" Then
      Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">" & oPA.VR_BusinessPartner11_BPName & "</td>")
    Else
      Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">" & oPA.SupplierName & "</td>")
    End If
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">Status:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">" & oPA.SPMT_PAStatus9_Description & "</td>")
    Print("</tr>")
    Print("<tr>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">Supplier GSTIN:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">" & tmp(0).VR_BPGSTIN17_Description & "</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">Purchase Type:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">" & tmp(0).PurchaseType & "</td>")
    Print("</tr>")
    Print("<tr>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">Isgec GSTIN:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">" & tmp(0).SPMT_IsgecGSTIN13_Description & "</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">Project:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">" & oPA.ProjectID & "-" & oPA.IDM_Projects5_Description & "</td>")
    Print("</tr>")
    Print("<tr>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">Department:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:left;vertical-align:top"">" & oPA.HRM_Departments4_Description & "</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">Cost Center:</td>")
    Print("<td style=""font-size:10px;font-weight:bold;text-align:right;vertical-align:top"">" & oPA.SPMT_CostCenters8_Description & "</td>")
    Print("</tr>")

    Print("</table>")

    Print("</br>")

    Print("<table width=""" & ReportWidth & "px"">")
    Print("<tr>")
    Print("<td style=""font-size:10px;font-weight:bold;width:15%;text-align:left;vertical-align:top"">Remarks:</td>")
    Print("<td style=""font-size:10px;width:85%;text-align:left;vertical-align:top"">" & oPA.Remarks & "</td>")
    Print("</tr>")
    If oPA.RemarksHOD <> String.Empty Then
      Print("<tr>")
      Print("<td style=""font-size:10px;font-weight:bold;width:15%;text-align:left;vertical-align:top"">Remarks [HOD]:</td>")
      Print("<td style=""font-size:10px;width:85%;text-align:left;vertical-align:top"">" & oPA.RemarksHOD & "</td>")
      Print("</tr>")
    End If
    If oPA.RemarksHR <> String.Empty Then
      Print("<tr>")
      Print("<td style=""font-size:10px;font-weight:bold;width:15%;text-align:left;vertical-align:top"">Remarks [HR]:</td>")
      Print("<td style=""font-size:10px;width:85%;text-align:left;vertical-align:top"">" & oPA.RemarksHR & "</td>")
      Print("</tr>")
    End If
    If oPA.RemarksAC <> String.Empty Then
      Print("<tr>")
      Print("<td style=""font-size:10px;font-weight:bold;width:15%;text-align:left;vertical-align:top"">Remarks [AC]:</td>")
      Print("<td style=""font-size:10px;width:85%;text-align:left;vertical-align:top"">" & oPA.RemarksAC & "</td>")
      Print("</tr>")
    End If
    Print("</table>")

    Print("</br>")

    Dim sn As Integer = 0
    Dim pagelength As Integer = 30
    Dim FCM As Boolean = False

    Select Case oPA.TranTypeID
      Case "AIR", "TRN"
        If oPA.UploadBatchNo <> String.Empty Then
          FCM = True
        End If
    End Select

    ColumnHeader(FCM)


    Dim dbPage As Integer = 0
    Dim dbSize As Integer = 10
    Dim dbOrder As String = ""
    Dim oIRs As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = Nothing
    Dim LastValue As String = ""
    Dim MinLines As Integer = 15
    Dim MinCnt As Integer = 0
    Dim TotalBillAmt As Decimal = 0
    Dim TotalAssAmt As Decimal = 0
    Dim TotalIgstAmt As Decimal = 0
    Dim TotalCgstAmt As Decimal = 0
    Dim TotalSgstAmt As Decimal = 0
    Dim TotalCessAmt As Decimal = 0
    Dim TotalTaxAmt As Decimal = 0
    Dim YTotalTaxAmt As Decimal = 0
    Dim YTotalBillAmt As Decimal = 0
    Dim YTotalAssAmt As Decimal = 0
    Dim YTotalIgstAmt As Decimal = 0
    Dim YTotalCgstAmt As Decimal = 0
    Dim YTotalSgstAmt As Decimal = 0
    Dim YTotalCessAmt As Decimal = 0

    Dim TotalAmountINR As Decimal = 0

    Dim TravelAdvice As Boolean = False

    Do While True
      oIRs = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(dbPage * dbSize, dbSize, dbOrder, False, "", oPA.AdviceNo)
      If oIRs.Count <= 0 Then
        Exit Do
      End If
      dbPage += 1

      For Each det As SIS.SPMT.spmtPaymentAdviceSupplierBill In oIRs
        If FCM Then
          If det.DocNo = "AIRY" Then
            Continue For
          End If
        End If
        sn += 1
        MinCnt += 1

        Print("<tr>")
        If FCM Then
          Print("<td rowspan=""2"" style=""font-size:12px;text-align:right"">" & sn.ToString & "</td>")
          Print("<td rowspan=""2"" style=""font-size:12px;text-align:left"">" & det.IRNo & "</td>")
          Print("<td rowspan=""2"" style=""font-size:12px;text-align:left"">" & det.BillNumber & "</td>")
          Print("<td rowspan=""2"" style=""font-size:12px;text-align:left"">" & det.BillDate & "</td>")
        Else
          Print("<td style=""font-size:12px;text-align:right"">" & sn.ToString & "</td>")
          Print("<td style=""font-size:12px;text-align:left"">" & det.IRNo & "</td>")
          Print("<td style=""font-size:12px;text-align:left"">" & det.BillNumber & "</td>")
          Print("<td style=""font-size:12px;text-align:left"">" & det.BillDate & "</td>")
        End If
        Print("<td style=""font-size:12px;text-align:left"">" & det.HSNSACCode & "</td>")
        Print("<td style=""font-size:12px;text-align:left"">" & det.HRM_Departments4_Description & "</td>")
        If det.Currency = "INR" Then
          Print("<td style=""font-size:12px;text-align:left"">" & det.BillRemarks & "</td>")
        Else
          Print("<td style=""font-size:12px;text-align:left"">" & det.BillRemarks & "<hr/>")
          Print("<b>Invoice Currency : </b>" & det.Currency & "<br/>")
          Print("<b>Conversion Factor : </b>" & det.ConversionFactorINR & "<br/>")
          Print("<b>Invoice Value : </b>" & det.AssessableValue)
          Print("</td>")
        End If
        If FCM Then
          Print("<td style=""font-size:12px;text-align:right"">" & det.BillAmount - det.TotalAmountINR & "</td>")
        Else
          Print("<td style=""font-size:12px;text-align:right"">" & det.Quantity & "</td>")
        End If
        Print("<td style=""font-size:12px;text-align:right"">" & (det.AssessableValue * det.ConversionFactorINR).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right"">" & (det.IGSTAmount * det.ConversionFactorINR).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right"">" & (det.CGSTAmount * det.ConversionFactorINR).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right"">" & (det.SGSTAmount * det.ConversionFactorINR).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right"">" & (det.CessAmount * det.ConversionFactorINR).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right"">" & (det.TaxAmount * det.ConversionFactorINR).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right"">" & (det.BillAmount).ToString("n") & "</td>")
        Print("</tr>")
        If FCM Then
          Dim airY As SIS.SPMT.spmtSupplierBill = SIS.SPMT.spmtSupplierBill.getByAirTIRNo(det.IRNo)
          Print("<tr>")
          'Print("<td></td>")
          'Print("<td></td>")
          Print("<td colspan=""14"" style=""font-size:11px"">")
          Print("<b>Ticket No.: </b>" & airY.BillNumber)
          Print("<b>, Travel Dt.: </b>" & airY.BillDate)
          Print("<b>, Agency : </b>" & airY.BillRemarks.Replace("Agency : ", ""))
          Print("<b>, Total GST: </b>" & airY.TaxAmount)
          Print("<b>, Bill Amount: </b>" & airY.TotalAmountINR)
          Print("</td>")
          Print("</tr>")
        End If
        TotalAmountINR += det.TotalAmountINR
        Select Case det.DocNo
          Case "AIRT", "AIRY"
            TravelAdvice = True
            If det.DocNo = "AIRT" Then
              TotalBillAmt += det.BillAmount
              TotalAssAmt += det.AssessableValue
              TotalCessAmt += det.CessAmount
              TotalCgstAmt += det.CGSTAmount
              TotalIgstAmt += det.IGSTAmount
              TotalSgstAmt += det.SGSTAmount
              TotalTaxAmt += det.TaxAmount
            Else
              YTotalBillAmt += det.BillAmount
              YTotalAssAmt += det.AssessableValue
              YTotalCessAmt += det.CessAmount
              YTotalCgstAmt += det.CGSTAmount
              YTotalIgstAmt += det.IGSTAmount
              YTotalSgstAmt += det.SGSTAmount
              YTotalTaxAmt += det.TaxAmount
            End If
          Case Else
            TotalBillAmt += det.BillAmount
            TotalAssAmt += det.AssessableValue * det.ConversionFactorINR
            TotalCessAmt += det.CessAmount * det.ConversionFactorINR
            TotalCgstAmt += det.CGSTAmount * det.ConversionFactorINR
            TotalIgstAmt += det.IGSTAmount * det.ConversionFactorINR
            TotalSgstAmt += det.SGSTAmount * det.ConversionFactorINR
            TotalTaxAmt += det.TaxAmount * det.ConversionFactorINR
        End Select

      Next
    Loop
    'Print Minimum Blank Lines
    If MinCnt < MinLines Then
      For MinCnt = MinCnt To MinLines
        Print("<tr>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        'If FCM Then
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        'End If
        Print("</tr>")
      Next
    End If
    'Print Total
    If FCM Then
      Print("<tr>")
      Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
      Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
      Print("<td style=""font-size:12px;text-align:left"">&nbsp;</td>")
      Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
      Print("<td colspan=""3"" style=""font-size:12px;text-align:center;font-weight:bold"">TOTAL AMOUNT [INR]</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalBillAmt - TotalAmountINR).ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalAssAmt.ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalIgstAmt.ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalCgstAmt.ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalSgstAmt.ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalCessAmt.ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalTaxAmt.ToString("n") & "</td>")
      Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalBillAmt.ToString("n") & "</td>")
      Print("</tr>")
    Else
      If TravelAdvice Then
        Print("<tr>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td colspan=""3"" style=""font-size:12px;text-align:center;font-weight:bold"">AGENTs TOTAL AMOUNT [INR]</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalAssAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalIgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalCgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalSgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalCessAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalTaxAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalBillAmt.ToString("n") & "</td>")
        Print("</tr>")

        Print("<tr>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td colspan=""3"" style=""font-size:12px;text-align:center;font-weight:bold"">AGENCY TOTAL AMOUNT [INR]</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalAssAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalIgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalCgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalSgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalCessAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalTaxAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & YTotalBillAmt.ToString("n") & "</td>")
        Print("</tr>")

        Print("<tr>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td colspan=""3"" style=""font-size:12px;text-align:center;font-weight:bold"">GRAND TOTAL AMOUNT [INR]</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalAssAmt + YTotalAssAmt).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalIgstAmt + YTotalIgstAmt).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalCgstAmt + YTotalCgstAmt).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalSgstAmt + YTotalSgstAmt).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalCessAmt + YTotalCessAmt).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalTaxAmt + YTotalTaxAmt).ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalBillAmt + YTotalBillAmt).ToString("n") & "</td>")
        Print("</tr>")
      Else
        Print("<tr>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td style=""font-size:9px;text-align:right"">&nbsp;</td>")
        Print("<td colspan=""3"" style=""font-size:12px;text-align:center;font-weight:bold"">TOTAL AMOUNT [INR]</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalAssAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalIgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalCgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalSgstAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalCessAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalTaxAmt.ToString("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & TotalBillAmt.ToString("n") & "</td>")
        Print("</tr>")
      End If

    End If

    Try
      If Convert.ToDecimal(oPA.AdvanceAmount) > 0 Then
        Print("<tr>")
        Print("<td colspan=""9"" style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td colspan=""4"" style=""font-size:12px;text-align:Left;font-weight:bold"">(-) Less Advance @" & oPA.AdvanceRate("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & oPA.AdvanceAmount("n") & "</td>")
        Print("</tr>")
      End If
    Catch ex As Exception

    End Try

    Try
      If Convert.ToDecimal(oPA.RetensionAmount) > 0 Then
        Print("<tr>")
        Print("<td colspan=""9"" style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td colspan=""4"" style=""font-size:12px;text-align:Left;font-weight:bold"">(-) Less Retension @" & oPA.RetensionRate("n") & "</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & oPA.RetensionAmount("n") & "</td>")
        Print("</tr>")
      End If
    Catch ex As Exception

    End Try

    Try
      If Convert.ToDecimal(oPA.RetensionAmount) > 0 Or Convert.ToDecimal(oPA.AdvanceAmount) > 0 Then
        Print("<tr>")
        Print("<td colspan=""9"" style=""font-size:12px;text-align:left"">&nbsp;</td>")
        Print("<td colspan=""4"" style=""font-size:12px;text-align:Left;font-weight:bold"">Net Payable Amount</td>")
        Print("<td style=""font-size:12px;text-align:right;font-weight:bold"">" & (TotalBillAmt - Convert.ToDecimal(oPA.RetensionAmount) - Convert.ToDecimal(oPA.AdvanceAmount)).ToString("n") & "</td>")
        Print("</tr>")
      End If
    Catch ex As Exception

    End Try

    Print("</table>")

    Print("</br>")
    Print("<table width=""" & ReportWidth & "px"">")
    Print("<tr>")
    Print("<td style=""font-size:12px;text-align:left;vertical-align:top"">a) Please pay cash or issue a cheque in favour of ____________________________________________________</td>")
    Print("</tr>")
    Print("<tr>")
    Print("<td style=""font-size:12px;text-align:left;vertical-align:top;padding-top:12px"">b) Please credit the same to the imprest A/c of _______________________________________________________</td>")
    Print("</tr>")
    Print("</table>")


    Print("</br>")
    Print("</br>")
    Print("</br>")
    Print("</br>")

    Print("<table width=""" & ReportWidth & "px"">")
    Print("<tr>")
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top"">Prepared By</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top"">Claimant's Signature</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top"">Supervisor's Signature</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:right;vertical-align:top"">Sanctioning Authority</td>")
    Print("</tr>")
    Print("<tr>")
    Dim StrToPrint As String = ""
    Try
      StrToPrint = oPA.FK_SPMT_PaymentAdvice_AdviceStatusUser.UserFullName & " [" & oPA.AdviceStatusUser & "]"
    Catch ex As Exception
      StrToPrint = ""
    End Try
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top""><br/><br/>" & StrToPrint & "</td>")
    StrToPrint = ""
    If Not oPA.EmployeeID = "" Then
      Try
        StrToPrint = oPA.FK_SPMT_PaymentAdvice_EmployeeID.UserFullName & " [" & oPA.EmployeeID & "]"
      Catch ex As Exception
        StrToPrint = ""
      End Try
      Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top""><br/><br/>" & StrToPrint & "</td>")
    Else
      Try
        'StrToPrint = oPA.FK_SPMT_PaymentAdvice_AdviceStatusUser.UserFullName & " [" & oPA.AdviceStatusUser & "]"
      Catch ex As Exception
        StrToPrint = ""
      End Try
      Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top""><br/><br/>" & StrToPrint & "</td>")
    End If
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:left;vertical-align:top""><br/>&nbsp;</td>")
    Try
      StrToPrint = oPA.FK_SPMT_PaymentAdvice_ConcernedHOD.UserFullName & " [" & oPA.ConcernedHOD & "]"
    Catch ex As Exception
      StrToPrint = ""
    End Try
    Print("<td style=""font-size:12px;font-weight:bold;width:25%;text-align:right;vertical-align:top""><br/><br/>" & StrToPrint & "</td>")
    Print("</tr>")
    Print("</table>")
    Return Report
  End Function
  Private Sub ColumnHeader(ByVal FCM As Boolean)

    Print("</br>")
    Print("<table border=""1pt"" width=""" & ReportWidth & "px"">")

    Print("<tr>")
    Print("<td colspan=""7""></td>")
    If FCM Then
      Print("<td colspan=""8"" style=""font-size:12px;font-weight:bold;width:60px;text-align:center;vertical-align:top"">AMOUNTS IN INR</td>")
    Else
      Print("<td colspan=""8"" style=""font-size:12px;font-weight:bold;width:60px;text-align:center;vertical-align:top"">AMOUNTS IN INR</td>")
    End If
    Print("</tr>")

    Print("<tr>")
    Print("<td style=""font-size:12px;font-weight:bold;width:30px;text-align:right;vertical-align:top"">S.N.</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:80px;vertical-align:top"">IR No</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:80px;vertical-align:top"">BILL NUMBER</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:60px;vertical-align:top"">BILL DATE</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:60px;vertical-align:top"">HSN/SAC</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:60px;vertical-align:top"">DEPTT.</td>")
    If FCM Then
      Print("<td style=""font-size:12px;font-weight:bold;width:210px;vertical-align:top"">ITEM DESCRIPTION</td>")
      Print("<td style=""font-size:12px;font-weight:bold;width:60px;text-align:right;vertical-align:top"">BILL AMT</td>")
      Print("<td style=""font-size:12px;font-weight:bold;width:60px;text-align:right;vertical-align:top"">SERVICE CHG.</td>")
    Else
      Print("<td style=""font-size:12px;font-weight:bold;width:260px;vertical-align:top"">ITEM DESCRIPTION</td>")
      Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">QTY.</td>")
      Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">BILL AMT</td>")
    End If
    Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">IGST</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">CGST</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">SGST</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">CESS</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">TOT.GST</td>")
    Print("<td style=""font-size:12px;font-weight:bold;width:70px;text-align:right;vertical-align:top"">GROSS AMT</td>")
    Print("</tr>")

  End Sub
  Sub New()
    'dummy
  End Sub
End Class
