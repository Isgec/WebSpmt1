Partial Class RP_spmtDCHeader
  Inherits System.Web.UI.Page
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtDCHeader.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ChallanID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim aVal() As String = Request.QueryString("pk").Split("|".ToCharArray)
    Dim ChallanID As String = CType(aVal(0), String)
    Dim oVar As SIS.SPMT.spmtDCHeader = SIS.SPMT.spmtDCHeader.spmtDCHeaderGetByID(ChallanID)
    Dim Tbl As New Table
    With Tbl
      .Width = 1000
      .GridLines = GridLines.None
      .Style.Add("margin-top", "15px")
      .Style.Add("margin-left", "10px")
    End With
    Dim Row As TableRow = Nothing
    Dim Col As TableCell = Nothing

    Row = New TableRow
    Col = New TableCell
    With Col
      .ColumnSpan = 5
      .Font.Bold = True
      .Font.Size = FontUnit.Point(11)
      .CssClass = "alignCenter"
      .Text = "DELIVERY CHALLAN"
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    Row = New TableRow
    Col = New TableCell
    With Col
      .ColumnSpan = 5
      .Font.Bold = True
      .Font.Size = FontUnit.Point(14)
      .CssClass = "alignCenter"
      .Text = oVar.IssuerCompanyName
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    Row = New TableRow
    Col = New TableCell
    With Col
      .ColumnSpan = 5
      .Font.Bold = True
      .Font.Size = FontUnit.Point(10)
      .CssClass = "alignCenter"
      .Text = oVar.IssuerAddress1Line
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    Row = New TableRow
    Col = New TableCell
    With Col
      .ColumnSpan = 5
      .Font.Bold = True
      .Font.Size = FontUnit.Point(10)
      .CssClass = "alignCenter"
      .Text = oVar.IssuerAddress2Line
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    If oVar.IssuerID <> "" Then
      Row = New TableRow
      Col = New TableCell
      With Col
        .ColumnSpan = 5
        .Font.Bold = True
        .Font.Size = FontUnit.Point(11)
        .CssClass = "alignCenter"
        .Text = "GSTIN: " & oVar.FK_SPMT_DCHeader_IssuerID.Description
      End With
      Row.Cells.Add(Col)
      Tbl.Rows.Add(Row)
    End If
    Row = New TableRow
    Col = New TableCell
    With Col
      .Font.Bold = True
      .Font.Size = FontUnit.Point(8)
      .Text = "PAN"
    End With
    Row.Cells.Add(Col)
    Col = New TableCell
    With Col
      .Font.Size = FontUnit.Point(8)
      .Text = oVar.IssuerPAN
    End With
    Row.Cells.Add(Col)
    Col = New TableCell
    With Col
      .Font.Bold = True
      .Font.Size = FontUnit.Point(8)
      .Text = "&nbsp;"
    End With
    Row.Cells.Add(Col)
    Col = New TableCell
    With Col
      .Font.Bold = True
      .Font.Size = FontUnit.Point(8)
      .CssClass = "alignright"
      .Text = "CIN"
    End With
    Row.Cells.Add(Col)
    Col = New TableCell
    With Col
      .Font.Size = FontUnit.Point(8)
      .CssClass = "alignright"
      .Text = oVar.IssuerCIN
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    form1.Controls.Add(Tbl)

    Dim oTbl As New Table
    With oTbl
      .Width = 1000
      .GridLines = GridLines.Both
      .Style.Add("margin-top", "15px")
      .Style.Add("margin-left", "10px")
    End With
    Dim oCol As TableCell = Nothing
    Dim oRow As TableRow = Nothing
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Challan ID"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ChallanID
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Challan Date"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ChallanDate
    oCol.Style.Add("text-align", "center")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Project"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ProjectID
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.IDM_Projects3_Description
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Unit"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.UnitID
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.HRM_Companies2_Description
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Purchase Order Number"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.PONo
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "5"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Place Of Supply"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.PlaceOfSupply
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.SPMT_ERPStates5_Description
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Place Of Delivery"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.PlaceOfDelivery
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.SPMT_ERPStates6_Description
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    form1.Controls.Add(oTbl)

    oTbl = New Table
    With oTbl
      .Width = 1000
      '.GridLines = GridLines.Both
      .Style.Add("margin-top", "15px")
      .Style.Add("margin-left", "10px")
    End With


    oRow = New TableRow
    oRow.BorderStyle = BorderStyle.Solid
    oRow.BorderWidth = Unit.Point(1)
    oCol = New TableCell
    oCol.Text = "Details of Consigner"
    oCol.Font.Bold = True
    oCol.ColumnSpan = 3
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Details of Consignee"
    oCol.Font.Bold = True
    oCol.ColumnSpan = 3
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)

    'oRow = New TableRow
    'oCol = New TableCell
    'oCol.Text = "Consigner Isgec"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.ConsignerIsgecID
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.SPMT_IsgecGSTIN9_Description
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = "Consignee Isgec"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.ConsigneeIsgecID
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.SPMT_IsgecGSTIN10_Description
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oTbl.Rows.Add(oRow)
    'oRow = New TableRow
    'oCol = New TableCell
    'oCol.Text = "Consigner BP ID"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.ConsignerBPID
    'oCol.Style.Add("text-align", "left")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.VR_BusinessPartner15_BPName
    'oCol.Style.Add("text-align", "left")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = "Consignee BP ID"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.ConsigneeBPID
    'oCol.Style.Add("text-align", "left")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.VR_BusinessPartner17_BPName
    'oCol.Style.Add("text-align", "left")
    'oRow.Cells.Add(oCol)
    'oTbl.Rows.Add(oRow)
    'oRow = New TableRow
    'oCol = New TableCell
    'oCol.Text = "Consigner GSTIN"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.ConsignerGSTIN
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.VR_BPGSTIN13_Description
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = "Consignee GSTIN"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.ConsigneeGSTIN
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.VR_BPGSTIN14_Description
    'oCol.Style.Add("text-align", "right")
    'oRow.Cells.Add(oCol)
    'oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Name : "
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsignerName
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Name : "
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsigneeName
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "GSTIN : "
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsignerGSTINNo
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "GSTIN : "
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsigneeGSTINNo
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Address Line [1]"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsignerAddress1Line
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Address Line [1]"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsigneeAddress1Line
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Address Line [2]"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsignerAddress2Line
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Address Line [2]"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsigneeAddress2Line
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Address Line [3]"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsignerAddress3Line
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Address Line [3]"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsigneeAddress3Line
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Consigner State"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsignerStateID
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.SPMT_ERPStates7_Description
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Consignee State"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ConsigneeStateID
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.SPMT_ERPStates8_Description
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)

    form1.Controls.Add(oTbl)

    Dim ospmtDCDetailss As List(Of SIS.SPMT.spmtDCDetails) = SIS.SPMT.spmtDCDetails.UZ_spmtDCDetailsSelectList(0, 999, "", False, "", oVar.ChallanID)
    If ospmtDCDetailss.Count > 0 Then

      oTbl = New Table
      With oTbl
        .Width = 1000
        .GridLines = GridLines.Both
        .Style.Add("margin-top", "15px")
        .Style.Add("margin-left", "10px")
      End With
      oRow = New TableRow
      oCol = New TableCell
      oCol.Text = "S.N."
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Description of Goods"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "left")
      oRow.Cells.Add(oCol)
      'oCol = New TableCell
      'oCol.Text = "Bill Type"
      'oCol.Font.Bold = True
      'oCol.CssClass = "colHD"
      'oCol.Style.Add("text-align", "right")
      'oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "HSN / SAC Code"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "left")
      oRow.Cells.Add(oCol)
      'oCol = New TableCell
      'oCol.Text = "UOM"
      'oCol.Font.Bold = True
      'oCol.CssClass = "colHD"
      'oCol.Style.Add("text-align", "left")
      'oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Quantity UOM/UQC"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Rate"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Taxable Value of goods/Service (After discount or abatement)"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      'oCol = New TableCell
      'oCol.Text = "IGST Rate"
      'oCol.Font.Bold = True
      'oCol.CssClass = "colHD"
      'oCol.Style.Add("text-align", "right")
      'oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "IGST Amount / Rate"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      'oCol = New TableCell
      'oCol.Text = "SGST Rate"
      'oCol.Font.Bold = True
      'oCol.CssClass = "colHD"
      'oCol.Style.Add("text-align", "right")
      'oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "SGST Amount / Rate"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      'oCol = New TableCell
      'oCol.Text = "CGST Rate"
      'oCol.Font.Bold = True
      'oCol.CssClass = "colHD"
      'oCol.Style.Add("text-align", "right")
      'oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "CGST Amount / Rate"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      'oCol = New TableCell
      'oCol.Text = "Cess Rate"
      'oCol.Font.Bold = True
      'oCol.CssClass = "colHD"
      'oCol.Style.Add("text-align", "right")
      'oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Cess Amount / Rate"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Total GST"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      oCol.Text = "Total Amount"
      oCol.Font.Bold = True
      oCol.CssClass = "colHD"
      oCol.Style.Add("text-align", "right")
      oRow.Cells.Add(oCol)
      oTbl.Rows.Add(oRow)
      For Each ospmtDCDetails As SIS.SPMT.spmtDCDetails In ospmtDCDetailss
        oRow = New TableRow
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.SerialNo
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.ItemDescription
        oCol.Style.Add("text-align", "left")
        oRow.Cells.Add(oCol)
        'oCol = New TableCell
        'oCol.Text = ospmtDCDetails.SPMT_BillTypes1_Description
        'oCol.CssClass = "rowHD"
        'oCol.Style.Add("text-align", "right")
        'oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.Text = ospmtDCDetails.SPMT_HSNSACCodes4_HSNSACCode
        oCol.CssClass = "rowHD"
        oCol.Style.Add("text-align", "left")
        oRow.Cells.Add(oCol)
        'oCol = New TableCell
        'oCol.Text = ospmtDCDetails.SPMT_ERPUnits3_Description
        'oCol.CssClass = "rowHD"
        'oCol.Style.Add("text-align", "left")
        'oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.Quantity & "<br/>" & ospmtDCDetails.SPMT_ERPUnits3_Description
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.Price
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.AssessableValue
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        'oCol = New TableCell
        'oCol.CssClass = "rowHD"
        'oCol.Text = ospmtDCDetails.IGSTRate
        'oCol.Style.Add("text-align", "right")
        'oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.IGSTAmount
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        'oCol = New TableCell
        'oCol.CssClass = "rowHD"
        'oCol.Text = ospmtDCDetails.SGSTRate
        'oCol.Style.Add("text-align", "right")
        'oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.SGSTAmount
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        'oCol = New TableCell
        'oCol.CssClass = "rowHD"
        'oCol.Text = ospmtDCDetails.CGSTRate
        'oCol.Style.Add("text-align", "right")
        'oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.CGSTAmount
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        'oCol = New TableCell
        'oCol.CssClass = "rowHD"
        'oCol.Text = ospmtDCDetails.CessRate
        'oCol.Style.Add("text-align", "right")
        'oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.CessAmount
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.TotalGST
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        oCol = New TableCell
        oCol.CssClass = "rowHD"
        oCol.Text = ospmtDCDetails.TotalAmount
        oCol.Style.Add("text-align", "right")
        oRow.Cells.Add(oCol)
        oTbl.Rows.Add(oRow)
      Next
      form1.Controls.Add(oTbl)
    End If

    oTbl = New Table
    With oTbl
      .Width = 1000
      .GridLines = GridLines.Both
      .Style.Add("margin-top", "15px")
      .Style.Add("margin-left", "10px")
    End With

    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Purpose of Sending Materials:"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.Purpose
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Total Amount"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.TotalAmount
    oCol.Style.Add("text-align", "right")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Expected Date of Return / Outward Movement"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ExpectedReturnDate
    oCol.Style.Add("text-align", "center")
    oCol.ColumnSpan = "5"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    'oRow = New TableRow
    'oCol = New TableCell
    'oCol.Text = "Total Amount In Words"
    'oCol.Font.Bold = True
    'oRow.Cells.Add(oCol)
    'oCol = New TableCell
    'oCol.Text = oVar.TotalAmountInWords
    'oCol.Style.Add("text-align", "left")
    'oCol.ColumnSpan = "5"
    'oRow.Cells.Add(oCol)
    'oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Mode Of Transport"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ModeOfTransportID
    oCol.Style.Add("text-align", "right")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.SPMT_ModeOfTransport12_Description
    oCol.Style.Add("text-align", "right")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Vehicle Number"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.VehicleNo
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "GR Number"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.GRNo
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "GR Date"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.GRDate
    oCol.Style.Add("text-align", "center")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Transporter"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.TransporterID
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.VR_BusinessPartner16_BPName
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "Transporter Name"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.TransporterName
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "From Place"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.FromPlace
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = "To Place"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.ToPlace
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "2"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    oRow = New TableRow
    oCol = New TableCell
    oCol.Text = "Prepared By"
    oCol.Font.Bold = True
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.CreatedBy
    oCol.Style.Add("text-align", "left")
    oRow.Cells.Add(oCol)
    oCol = New TableCell
    oCol.Text = oVar.aspnet_Users1_UserFullName
    oCol.Style.Add("text-align", "left")
    oCol.ColumnSpan = "4"
    oRow.Cells.Add(oCol)
    oTbl.Rows.Add(oRow)
    form1.Controls.Add(oTbl)

    Tbl = New Table
    With Tbl
      .Width = 1000
      .GridLines = GridLines.None
      .Style.Add("margin-top", "15px")
      .Style.Add("margin-left", "10px")
    End With
    Row = New TableRow
    Col = New TableCell
    With Col
      .Font.Bold = True
      .Font.Size = FontUnit.Point(9)
      .Style.Add("text-align", "right")
      .Text = "For " & oVar.IssuerCompanyName
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    Row = New TableRow
    Col = New TableCell
    With Col
      .Font.Size = FontUnit.Point(8)
      .Style.Add("text-align", "left")
      .Text = "Declaration: This Delivery Challan is not falling under Reverse Charges."
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)
    Row = New TableRow
    Col = New TableCell
    With Col
      .Font.Size = FontUnit.Point(8)
      .Style.Add("text-align", "left")
      .Text = "This delivery challan is issued by " & oVar.IssuerCompanyName & " for it's material movement. "
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    Row = New TableRow
    Col = New TableCell
    With Col
      .Font.Bold = True
      .Font.Size = FontUnit.Point(9)
      .Style.Add("text-align", "right")
      .Style.Add("padding-top", "50px")
      .Text = "Authorized Signatory"
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)
    form1.Controls.Add(Tbl)


  End Sub
End Class
