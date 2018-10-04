Partial Class RP_spmtNewPA
  Inherits System.Web.UI.Page
  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim aVal() As String = Request.QueryString("pk").Split("|".ToCharArray)
    Dim AdviceNo As Int32 = CType(aVal(0), Int32)
    Dim oVar As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(AdviceNo)
    Dim SBHs As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.UZ_spmtNewLinkedSBHSelectList(0, 999, "", False, "", oVar.AdviceNo)
    If SBHs.Count <= 0 Then
      Exit Sub
    End If


    Dim Hdr As String = "PAYMENT ADVICE"

    If oVar.StatusID <= spmtPAStates.UnderHODFeedback Then
      Hdr = "PROVISIONAL " & Hdr
    End If


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
      .Font.Size = FontUnit.Point(12)
      .CssClass = "alignCenter"
      .Text = Hdr
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
      .Text = oVar.SPMT_TranTypes7_Description
    End With
    Row.Cells.Add(Col)
    Tbl.Rows.Add(Row)

    form1.Controls.Add(Tbl)


    Dim tblPA As New Table
    tblPA.Width = 1000
    tblPA.GridLines = GridLines.None
    tblPA.Style.Add("margin-top", "15px")
    tblPA.Style.Add("margin-left", "10px")
    Dim colPA As TableCell = Nothing
    Dim rowPA As TableRow = Nothing

    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      .Text = "Advice No.:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.AdviceNo & " / " & oVar.OldAdviceNo
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = "Date:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.CreatedOn
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)

    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      .Text = "Supplier Name:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      If SBHs(0).BPID <> String.Empty Then
        .Text = SBHs(0).FK_SPMT_newSBH_BPID.BPName
      Else
        .Text = SBHs(0).SupplierName
      End If
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = "Status:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.SPMT_PAStatus6_Description
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)


    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      .Text = "Supplier GSTIN:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      If SBHs(0).BPID <> String.Empty Then
        If SBHs(0).SupplierGSTIN <> String.Empty Then
          .Text = SBHs(0).FK_SPMT_newSBH_SupplierGSTIN.Description.ToUpper
        Else
          .Text = SBHs(0).SupplierGSTINNumber.ToUpper
        End If
      Else
        .Text = SBHs(0).SupplierGSTINNumber.ToUpper
      End If
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = "Purchase Type:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = SBHs(0).PurchaseType
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)


    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      .Text = "Isgec GSTIN:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = SBHs(0).SPMT_IsgecGSTIN8_Description
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = ""
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = ""
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)


    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      colPA.Text = "Advance Rate:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.AdvanceRate
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = "Advance Amount:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.AdvanceAmount
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)

    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      colPA.Text = "Retension Rate:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.RetensionRate
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = "Retension Amount:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = oVar.RetensionAmount
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)


    rowPA = New TableRow
    colPA = New TableCell
    With colPA
      .Text = "Department:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = SBHs(0).HRM_Departments2_Description
      .Style.Add("text-align", "left")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = "Cost Center:"
      .Font.Bold = True
    End With
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    With colPA
      .Text = SBHs(0).SPMT_CostCenters6_Description
      .Style.Add("text-align", "right")
      .ColumnSpan = "2"
    End With
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)


    rowPA = New TableRow
    colPA = New TableCell
    colPA.Text = "Total Advice Amount:"
    colPA.Font.Bold = True
    rowPA.Cells.Add(colPA)
    colPA = New TableCell
    colPA.Text = oVar.TotalAdviceAmount
    colPA.Style.Add("text-align", "right")
    colPA.ColumnSpan = "5"
    rowPA.Cells.Add(colPA)
    tblPA.Rows.Add(rowPA)

    form1.Controls.Add(tblPA)

    Dim tblSBH As Table = Nothing
    Dim rowSBH As TableRow = Nothing
    Dim colSBH As TableCell = Nothing
    ' Dim SBHs As List(Of SIS.SPMT.spmtNewLinkedSBH) = SIS.SPMT.spmtNewLinkedSBH.UZ_spmtNewLinkedSBHSelectList(0, 999, "", False, "", oVar.AdviceNo)
    If SBHs.Count > 0 Then
      tblSBH = New Table
      tblSBH.Width = 1000
      tblSBH.Style.Add("margin-top", "15px")
      tblSBH.Style.Add("margin-left", "10px")
      tblSBH.Style.Add("margin-right", "10px")
      rowSBH = New TableRow
      colSBH = New TableCell
      colSBH.Font.Bold = True
      colSBH.Font.Underline = True
      colSBH.Font.Size = 10
      colSBH.Text = "Supplier Bills"
      rowSBH.Cells.Add(colSBH)
      tblSBH.Rows.Add(rowSBH)
      form1.Controls.Add(tblSBH)

      tblSBH = New Table
      tblSBH.Width = 1000
      tblSBH.GridLines = GridLines.Both
      tblSBH.Style.Add("margin-left", "10px")
      tblSBH.Style.Add("margin-right", "10px")
      rowSBH = New TableRow
      colSBH = New TableCell
      colSBH.Text = "Purchase Type"
      colSBH.Font.Bold = True
      colSBH.Style.Add("text-align", "left")
      rowSBH.Cells.Add(colSBH)
      colSBH = New TableCell
      colSBH.Text = "Supplier Bill Number"
      colSBH.Font.Bold = True
      colSBH.Style.Add("text-align", "left")
      rowSBH.Cells.Add(colSBH)
      colSBH = New TableCell
      colSBH.Text = "Supplier Bill Date"
      colSBH.Font.Bold = True
      colSBH.Style.Add("text-align", "center")
      rowSBH.Cells.Add(colSBH)
      colSBH = New TableCell
      colSBH.Text = "Department"
      colSBH.Font.Bold = True
      colSBH.Style.Add("text-align", "left")
      rowSBH.Cells.Add(colSBH)
      colSBH = New TableCell
      colSBH.Text = "Cost Center"
      colSBH.Font.Bold = True
      colSBH.Style.Add("text-align", "left")
      rowSBH.Cells.Add(colSBH)
      colSBH = New TableCell
      colSBH.Text = "Total Bill Amount"
      colSBH.Font.Bold = True
      colSBH.Style.Add("text-align", "right")
      rowSBH.Cells.Add(colSBH)
      tblSBH.Rows.Add(rowSBH)
      For Each ospmtNewLinkedSBH As SIS.SPMT.spmtNewLinkedSBH In SBHs
        rowSBH = New TableRow
        colSBH = New TableCell
        colSBH.CssClass = "rowHD"
        colSBH.Text = ospmtNewLinkedSBH.PurchaseType
        colSBH.Style.Add("text-align", "left")
        rowSBH.Cells.Add(colSBH)
        colSBH = New TableCell
        colSBH.CssClass = "rowHD"
        colSBH.Text = ospmtNewLinkedSBH.BillNumber
        colSBH.Style.Add("text-align", "left")
        rowSBH.Cells.Add(colSBH)
        colSBH = New TableCell
        colSBH.CssClass = "rowHD"
        colSBH.Text = ospmtNewLinkedSBH.BillDate
        colSBH.Style.Add("text-align", "center")
        rowSBH.Cells.Add(colSBH)
        colSBH = New TableCell
        colSBH.Text = ospmtNewLinkedSBH.HRM_Departments2_Description
        colSBH.CssClass = "rowHD"
        colSBH.Style.Add("text-align", "left")
        rowSBH.Cells.Add(colSBH)
        colSBH = New TableCell
        colSBH.Text = ospmtNewLinkedSBH.SPMT_CostCenters6_Description
        colSBH.CssClass = "rowHD"
        colSBH.Style.Add("text-align", "left")
        rowSBH.Cells.Add(colSBH)
        colSBH = New TableCell
        colSBH.CssClass = "rowHD"
        colSBH.Text = ospmtNewLinkedSBH.TotalBillAmount
        colSBH.Style.Add("text-align", "right")
        rowSBH.Cells.Add(colSBH)
        tblSBH.Rows.Add(rowSBH)
        rowSBH = New TableRow
        colSBH = New TableCell
        colSBH.ColumnSpan = tblSBH.Rows(0).Cells.Count
        rowSBH.Cells.Add(colSBH)
        Dim tblSBD As Table = Nothing
        Dim rowSBD As TableRow = Nothing
        Dim colSBD As TableCell = Nothing
        Dim oSBDs As List(Of SIS.SPMT.spmtNewSBD) = SIS.SPMT.spmtNewSBD.UZ_spmtNewSBDSelectList(0, 999, "", False, "", ospmtNewLinkedSBH.IRNo)
        If oSBDs.Count > 0 Then
          tblSBD = New Table
          tblSBD.Width = 960
          tblSBD.Style.Add("margin-top", "15px")
          tblSBD.Style.Add("margin-left", "10px")
          tblSBD.Style.Add("margin-right", "10px")
          rowSBD = New TableRow
          colSBD = New TableCell
          colSBD.Font.Bold = True
          colSBD.Font.Underline = True
          colSBD.Font.Size = 10
          colSBD.Text = "Bill Items"
          rowSBD.Cells.Add(colSBD)
          tblSBD.Rows.Add(rowSBD)
          colSBH.Controls.Add(tblSBD)

          tblSBD = New Table
          tblSBD.Width = 960
          tblSBD.GridLines = GridLines.Both
          tblSBD.Style.Add("margin-left", "10px")
          tblSBD.Style.Add("margin-right", "10px")
          rowSBD = New TableRow

          colSBD = New TableCell
          colSBD.Text = "S.N."
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "center")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Item Description"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "left")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Bill Type"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "HSN / SAC Code"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "left")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "UOM"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "left")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Quantity"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "Currency"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "left")
          'rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "Conversion Factor [INR]"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Assessable Value"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "IGST Rate"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "IGST Amount"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "SGST Rate"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "SGST Amount"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "CGST Rate"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "CGST Amount"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "Cess Rate"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Cess Amount"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Total GST"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Total Amount"
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "Total GST [INR]"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          'colSBD = New TableCell
          'colSBD.Text = "Total Amount [INR]"
          'colSBD.Font.Bold = True
          'colSBD.Style.Add("text-align", "right")
          'rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.Text = "Deptt."
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "left")
          rowSBD.Cells.Add(colSBD)

          tblSBD.Rows.Add(rowSBD)

          Dim totA As Decimal = 0
          Dim totI As Decimal = 0
          Dim totC As Decimal = 0
          Dim totS As Decimal = 0
          Dim totE As Decimal = 0
          Dim totG As Decimal = 0
          Dim totM As Decimal = 0


          For Each ospmtNewSBD As SIS.SPMT.spmtNewSBD In oSBDs
            rowSBD = New TableRow
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.SerialNo
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.ItemDescription
            colSBD.Style.Add("text-align", "left")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.Text = ospmtNewSBD.SPMT_BillTypes5_Description
            colSBD.CssClass = "rowHD"
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.Text = ospmtNewSBD.SPMT_HSNSACCodes8_HSNSACCode
            colSBD.CssClass = "rowHD"
            colSBD.Style.Add("text-align", "left")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.Text = ospmtNewSBD.SPMT_ERPUnits7_Description
            colSBD.CssClass = "rowHD"
            colSBD.Style.Add("text-align", "left")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.Quantity
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.Currency
            'colSBD.Style.Add("text-align", "left")
            'rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.ConversionFactorINR
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.AssessableValue
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.IGSTRate
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.IGSTAmount
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.SGSTRate
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.SGSTAmount
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.CGSTRate
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.CGSTAmount
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.CessRate
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.CessAmount
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.TotalGST
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.CssClass = "rowHD"
            colSBD.Text = ospmtNewSBD.TotalAmount
            colSBD.Style.Add("text-align", "right")
            rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.TotalGSTINR
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            'colSBD = New TableCell
            'colSBD.CssClass = "rowHD"
            'colSBD.Text = ospmtNewSBD.TotalAmountINR
            'colSBD.Style.Add("text-align", "right")
            'rowSBD.Cells.Add(colSBD)
            colSBD = New TableCell
            colSBD.Text = ospmtNewSBD.HRM_Departments1_Description
            colSBD.CssClass = "rowHD"
            colSBD.Style.Add("text-align", "left")
            rowSBD.Cells.Add(colSBD)
            tblSBD.Rows.Add(rowSBD)

            totA += ospmtNewSBD.AssessableValue
            totI += ospmtNewSBD.IGSTAmount
            totC += ospmtNewSBD.CGSTAmount
            totS += ospmtNewSBD.SGSTAmount
            totE += ospmtNewSBD.CessAmount
            totG += ospmtNewSBD.TotalGST
            totM += ospmtNewSBD.TotalAmount
          Next
          'Total Amount Row
          rowSBD = New TableRow

          colSBD = New TableCell
          colSBD.Text = "TOTAL"
          colSBD.Font.Bold = True
          colSBD.ColumnSpan = "6"
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totA.ToString("n")
          colSBD.Style.Add("text-align", "right")
          colSBD.Font.Bold = True
          rowSBD.Cells.Add(colSBD)
          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totI.ToString("n")
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)
          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totS.ToString("n")
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)
          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totC.ToString("n")
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)
          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totE.ToString("n")
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)
          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totG.ToString("n")
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)
          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = totM.ToString("n")
          colSBD.Font.Bold = True
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)

          colSBD = New TableCell
          colSBD.CssClass = "rowHD"
          colSBD.Text = "&nbsp;"
          colSBD.Style.Add("text-align", "right")
          rowSBD.Cells.Add(colSBD)


          tblSBD.Rows.Add(rowSBD)

          colSBH.Controls.Add(tblSBD)
          tblSBH.Rows.Add(rowSBH)
        End If
      Next
      form1.Controls.Add(tblSBH)

      Dim oTbl As Table = Nothing
      Dim oRow As TableRow = Nothing
      Dim oCol As TableCell = Nothing

      oTbl = New Table
      With oTbl
        .Width = 1000
        .GridLines = GridLines.None
        .Style.Add("margin-left", "10px")
        .Style.Add("margin-top", "20px")
      End With

      oRow = New TableRow

      oCol = New TableCell
      With oCol
        .Text = "a) Please pay cash or issue a cheque in favour of ____________________________________________________"
        '.Font.Bold = True
        .Style.Add("text-align", "left")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)
      oTbl.Rows.Add(oRow)

      oRow = New TableRow
      oCol = New TableCell
      With oCol
        .Text = "b) Please credit the same to the imprest A/c of _______________________________________________________"
        '.Font.Bold = True
        .Style.Add("text-align", "left")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)

      oTbl.Rows.Add(oRow)

      form1.Controls.Add(oTbl)


      oTbl = New Table
      With oTbl
        .Width = 1000
        .GridLines = GridLines.None
        .Style.Add("margin-left", "10px")
        .Style.Add("margin-top", "60px")
      End With

      oRow = New TableRow

      oCol = New TableCell
      With oCol
        .Text = "Claimant`s Signature"
        .Style.Add("text-align", "left")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      With oCol
        .Text = "Supervisor`s Signature"
        .Style.Add("text-align", "center")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      With oCol
        .Text = "Sanctioning Authority"
        .Style.Add("text-align", "right")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)

      oTbl.Rows.Add(oRow)

      oRow = New TableRow

      oCol = New TableCell
      With oCol
        .Text = "<br/>" & oVar.FK_SPMT_newPA_CreatedOn.UserFullName & " [" & oVar.CreatedBy & "]"
        .Style.Add("text-align", "left")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      With oCol
        .Text = " "
        .Style.Add("text-align", "center")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)
      oCol = New TableCell
      With oCol
        .Text = "<br/>" & oVar.FK_SPMT_newPA_ConcernedHOD.EmployeeName & " [" & oVar.ConcernedHOD & "]"
        .Style.Add("text-align", "right")
        .Font.Size = FontUnit.Point(10)
      End With
      oRow.Cells.Add(oCol)

      oTbl.Rows.Add(oRow)


      form1.Controls.Add(oTbl)

    End If
  End Sub
End Class
