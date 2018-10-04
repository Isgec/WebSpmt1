Partial Class RP_spmtACProcessed
  Inherits System.Web.UI.Page
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtACProcessed.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl & "?AdviceNo=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim aVal() As String = Request.QueryString("pk").Split("|".ToCharArray)
    Dim AdviceNo As Int32 = CType(aVal(0),Int32)
    Dim oVar As SIS.SPMT.spmtACProcessed = SIS.SPMT.spmtACProcessed.spmtACProcessedGetByID(AdviceNo)
    Dim oTblspmtACProcessed As New Table
    oTblspmtACProcessed.Width = 1000
    oTblspmtACProcessed.GridLines = GridLines.Both
    oTblspmtACProcessed.Style.Add("margin-top", "15px")
    oTblspmtACProcessed.Style.Add("margin-left", "10px")
    Dim oColspmtACProcessed As TableCell = Nothing
    Dim oRowspmtACProcessed As TableRow = Nothing
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Advice No"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.AdviceNo
      oColspmtACProcessed.Style.Add("text-align","right")
    oColspmtACProcessed.ColumnSpan = "2"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Tran Type ID"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.TranTypeID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.SPMT_TranTypes10_Description
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Supplier"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.BPID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    If oVar.SupplierName = "" Then
      oColspmtACProcessed.Text = oVar.VR_BusinessPartner11_BPName
    Else
      oColspmtACProcessed.Text = oVar.SupplierName
    End If
    oColspmtACProcessed.Style.Add("text-align", "left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Concerned HOD"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.ConcernedHOD
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.aspnet_users2_UserFullName
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Project"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.ProjectID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.IDM_Projects5_Description
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Element"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.ElementID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.IDM_WBS6_Description
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Cost Center"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.CostCenterID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.SPMT_CostCenters8_Description
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Department"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.DepartmentID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.HRM_Departments4_Description
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Employee"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.EmployeeID
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.aspnet_users3_UserFullName
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "4"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Remarks"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.Remarks
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "5"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Created By"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.AdviceStatusUser
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.aspnet_users1_UserFullName
      oColspmtACProcessed.Style.Add("text-align","left")
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Created On"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.AdviceStatusOn
      oColspmtACProcessed.Style.Add("text-align","center")
    oColspmtACProcessed.ColumnSpan = "2"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Total Amount"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.CostCenter
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "5"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Recd./Rtnd."
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.RemarksHOD
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "2"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Locked By"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.RemarksHR
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "2"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Voucher Type"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.DocumentNo
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "2"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "Voucher No"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.BaaNCompany
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "2"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "BaaN Company"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.BaaNLedger
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "5"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    oRowspmtACProcessed = New TableRow
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = "A/C Remarks"
    oColspmtACProcessed.Font.Bold = True
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oColspmtACProcessed = New TableCell
    oColspmtACProcessed.Text = oVar.RemarksAC
      oColspmtACProcessed.Style.Add("text-align","left")
    oColspmtACProcessed.ColumnSpan = "5"
    oRowspmtACProcessed.Cells.Add(oColspmtACProcessed)
    oTblspmtACProcessed.Rows.Add(oRowspmtACProcessed)
    form1.Controls.Add(oTblspmtACProcessed)
      Dim oTblspmtPaymentAdviceSupplierBill As Table = Nothing
      Dim oRowspmtPaymentAdviceSupplierBill As TableRow = Nothing
      Dim oColspmtPaymentAdviceSupplierBill As TableCell = Nothing
    Dim ospmtPaymentAdviceSupplierBills As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.UZ_spmtPaymentAdviceSupplierBillSelectList(0, 999, "", False, "", oVar.AdviceNo)
    If ospmtPaymentAdviceSupplierBills.Count > 0 Then
      Dim oTblhspmtPaymentAdviceSupplierBill As Table = New Table
      oTblhspmtPaymentAdviceSupplierBill.Width = 1000
      oTblhspmtPaymentAdviceSupplierBill.Style.Add("margin-top", "15px")
      oTblhspmtPaymentAdviceSupplierBill.Style.Add("margin-left", "10px")
      oTblhspmtPaymentAdviceSupplierBill.Style.Add("margin-right", "10px")
      Dim oRowhspmtPaymentAdviceSupplierBill As TableRow = New TableRow
      Dim oColhspmtPaymentAdviceSupplierBill As TableCell = New TableCell
      oColhspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColhspmtPaymentAdviceSupplierBill.Font.UnderLine = True
      oColhspmtPaymentAdviceSupplierBill.Font.Size = 10
      oColhspmtPaymentAdviceSupplierBill.CssClass = "grpHD"
      oColhspmtPaymentAdviceSupplierBill.Text = "Selected Bills"
      oRowhspmtPaymentAdviceSupplierBill.Cells.Add(oColhspmtPaymentAdviceSupplierBill)
      oTblhspmtPaymentAdviceSupplierBill.Rows.Add(oRowhspmtPaymentAdviceSupplierBill)
      form1.Controls.Add(oTblhspmtPaymentAdviceSupplierBill)
      oTblspmtPaymentAdviceSupplierBill = New Table
      oTblspmtPaymentAdviceSupplierBill.Width = 1000
      oTblspmtPaymentAdviceSupplierBill.GridLines = GridLines.Both
      oTblspmtPaymentAdviceSupplierBill.Style.Add("margin-left", "10px")
      oTblspmtPaymentAdviceSupplierBill.Style.Add("margin-right", "10px")
      oRowspmtPaymentAdviceSupplierBill = New TableRow
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "IR No"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Purchase Type"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Tran.Type"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Isgec GSTIN"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Supplier"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Supplier GSTIN"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Bill Type"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "HSN / SAC Code"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Ship To State"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Bill Number"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Bill Date"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","center")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Item Description"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Basic / Assessable Value"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "IGST Rate"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "IGST Amount"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "CGST Rate"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "CGST Amount"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "SGST Rate"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "SGST Amount"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Cess Rate"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Cess Amount"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Total GST [INR]"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oColspmtPaymentAdviceSupplierBill = New TableCell
      oColspmtPaymentAdviceSupplierBill.Text = "Total Amount INR"
      oColspmtPaymentAdviceSupplierBill.Font.Bold = True
      oColspmtPaymentAdviceSupplierBill.CssClass = "colHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
      oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
      oTblspmtPaymentAdviceSupplierBill.Rows.Add(oRowspmtPaymentAdviceSupplierBill)
      For Each ospmtPaymentAdviceSupplierBill As SIS.SPMT.spmtPaymentAdviceSupplierBill In ospmtPaymentAdviceSupplierBills
        oRowspmtPaymentAdviceSupplierBill = New TableRow
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IRNo
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.PurchaseType
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_TranTypes16_Description
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_IsgecGSTIN13_Description
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.VR_BusinessPartner18_BPName
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.VR_BPGSTIN17_Description
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_BillTypes8_Description
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_HSNSACCodes12_HSNSACCode
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SPMT_ERPStates10_Description
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillNumber
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillDate
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","center")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.BillRemarks
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","left")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.AssessableValue
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IGSTRate
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.IGSTAmount
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CGSTRate
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CGSTAmount
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SGSTRate
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.SGSTAmount
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CessRate
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.CessAmount
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TaxAmount
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oColspmtPaymentAdviceSupplierBill = New TableCell
        oColspmtPaymentAdviceSupplierBill.CssClass = "rowHD"
        oColspmtPaymentAdviceSupplierBill.Text = ospmtPaymentAdviceSupplierBill.TotalAmountINR
      oColspmtPaymentAdviceSupplierBill.Style.Add("text-align","right")
        oRowspmtPaymentAdviceSupplierBill.Cells.Add(oColspmtPaymentAdviceSupplierBill)
        oTblspmtPaymentAdviceSupplierBill.Rows.Add(oRowspmtPaymentAdviceSupplierBill)
      Next
      form1.Controls.Add(oTblspmtPaymentAdviceSupplierBill)
    End If
      Dim oTblspmtUnlinkedSupplierBill As Table = Nothing
      Dim oRowspmtUnlinkedSupplierBill As TableRow = Nothing
      Dim oColspmtUnlinkedSupplierBill As TableCell = Nothing
    Dim ospmtUnlinkedSupplierBills As List(Of SIS.SPMT.spmtUnlinkedSupplierBill) = SIS.SPMT.spmtUnlinkedSupplierBill.UZ_spmtUnlinkedSupplierBillSelectList(0, 999, "", False, "", oVar.AdviceNo, "", "")
    If ospmtUnlinkedSupplierBills.Count > 0 Then
      Dim oTblhspmtUnlinkedSupplierBill As Table = New Table
      oTblhspmtUnlinkedSupplierBill.Width = 1000
      oTblhspmtUnlinkedSupplierBill.Style.Add("margin-top", "15px")
      oTblhspmtUnlinkedSupplierBill.Style.Add("margin-left", "10px")
      oTblhspmtUnlinkedSupplierBill.Style.Add("margin-right", "10px")
      Dim oRowhspmtUnlinkedSupplierBill As TableRow = New TableRow
      Dim oColhspmtUnlinkedSupplierBill As TableCell = New TableCell
      oColhspmtUnlinkedSupplierBill.Font.Bold = True
      oColhspmtUnlinkedSupplierBill.Font.UnderLine = True
      oColhspmtUnlinkedSupplierBill.Font.Size = 10
      oColhspmtUnlinkedSupplierBill.CssClass = "grpHD"
      oColhspmtUnlinkedSupplierBill.Text = "Pending Bills"
      oRowhspmtUnlinkedSupplierBill.Cells.Add(oColhspmtUnlinkedSupplierBill)
      oTblhspmtUnlinkedSupplierBill.Rows.Add(oRowhspmtUnlinkedSupplierBill)
      form1.Controls.Add(oTblhspmtUnlinkedSupplierBill)
      oTblspmtUnlinkedSupplierBill = New Table
      oTblspmtUnlinkedSupplierBill.Width = 1000
      oTblspmtUnlinkedSupplierBill.GridLines = GridLines.Both
      oTblspmtUnlinkedSupplierBill.Style.Add("margin-left", "10px")
      oTblspmtUnlinkedSupplierBill.Style.Add("margin-right", "10px")
      oRowspmtUnlinkedSupplierBill = New TableRow
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "IR No"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Tran.Type"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "IR Received On"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "VendorID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Bill Number"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Bill Date"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Bill Amount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Item Description"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BillStatusID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BillStatusDate"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BillStatusUser"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "LogisticLinked"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ApprovedAmount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Remarks"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "PassedAmount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "RemarksAC"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ReturnedByAC"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ReasonID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "AdviceNo"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ConcernedHOD"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "CostCenter"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ProjectID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ElementID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "EmployeeID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "DepartmentID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "CostCenterID"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "VoucherNo"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "DocumentNo"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "DocumentLine"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BaaNCompany"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BaaNLedger"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Isgec GSTIN"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Supplier"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Supplier GSTIN"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Bil Type"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "HSN / SAC Code"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "UOM"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Ship To State"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Quantity"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BasicValue"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Discount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "ServiceCharge"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Basic / Assessable Value"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "TaxRate"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Total GST [INR]"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Cess Rate"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Cess Amount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Total GST"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Total Amount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Remarks GST"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Currency"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Conversion Factor INR"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Total Amount INR"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "Purchase Type"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "IGST Rate"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "IGST Amount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "SGST Rate"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "SGST Amount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "CGST Rate"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "CGST Amount"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "BatchNo"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "DocNo"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oColspmtUnlinkedSupplierBill = New TableCell
      oColspmtUnlinkedSupplierBill.Text = "DocLine"
      oColspmtUnlinkedSupplierBill.Font.Bold = True
      oColspmtUnlinkedSupplierBill.CssClass = "colHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
      oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
      oTblspmtUnlinkedSupplierBill.Rows.Add(oRowspmtUnlinkedSupplierBill)
      For Each ospmtUnlinkedSupplierBill As SIS.SPMT.spmtUnlinkedSupplierBill In ospmtUnlinkedSupplierBills
        oRowspmtUnlinkedSupplierBill = New TableRow
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IRNo
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_TranTypes16_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IRReceivedOn
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VendorID
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillNumber
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillDate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillRemarks
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_BillStatus7_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BillStatusDate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.aspnet_users1_UserFullName
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = IIf(ospmtUnlinkedSupplierBill.LogisticLinked, "YES", "NO")
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.ApprovedAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Remarks
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.PassedAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.RemarksAC
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = IIf(ospmtUnlinkedSupplierBill.ReturnedByAC, "YES", "NO")
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","center")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_ReturnReason15_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_PaymentAdvice14_BPID
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.aspnet_users2_UserFullName
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CostCenter
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IDM_Projects5_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IDM_WBS6_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.aspnet_users3_UserFullName
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.HRM_Departments4_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_CostCenters9_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VoucherNo
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocumentNo
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocumentLine
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BaaNCompany
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BaaNLedger
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_IsgecGSTIN13_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VR_BusinessPartner18_BPName
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.VR_BPGSTIN17_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_BillTypes8_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_HSNSACCodes12_HSNSACCode
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_ERPUnits11_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SPMT_ERPStates10_Description
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Quantity
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BasicValue
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Discount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.ServiceCharge
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.AssessableValue
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TaxRate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TaxAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CessRate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CessAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TotalGST
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TotalAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.RemarksGST
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.Currency
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.ConversionFactorINR
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.TotalAmountINR
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.PurchaseType
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IGSTRate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.IGSTAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SGSTRate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.SGSTAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CGSTRate
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.CGSTAmount
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","right")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.BatchNo
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocNo
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oColspmtUnlinkedSupplierBill = New TableCell
        oColspmtUnlinkedSupplierBill.CssClass = "rowHD"
        oColspmtUnlinkedSupplierBill.Text = ospmtUnlinkedSupplierBill.DocLine
      oColspmtUnlinkedSupplierBill.Style.Add("text-align","left")
        oRowspmtUnlinkedSupplierBill.Cells.Add(oColspmtUnlinkedSupplierBill)
        oTblspmtUnlinkedSupplierBill.Rows.Add(oRowspmtUnlinkedSupplierBill)
      Next
      form1.Controls.Add(oTblspmtUnlinkedSupplierBill)
    End If
  End Sub
End Class
