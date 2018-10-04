Partial Class EF_spmtDCHeader
  Inherits SIS.SYS.UpdateBase
  Public Property Editable() As Boolean
    Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Editable", value)
    End Set
  End Property
  Public Property Deleteable() As Boolean
    Get
      If ViewState("Deleteable") IsNot Nothing Then
        Return CType(ViewState("Deleteable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Deleteable", value)
    End Set
  End Property
  Public Property PrimaryKey() As String
    Get
      If ViewState("PrimaryKey") IsNot Nothing Then
        Return CType(ViewState("PrimaryKey"), String)
      End If
      Return True
    End Get
    Set(ByVal value As String)
      ViewState.Add("PrimaryKey", value)
    End Set
  End Property
  Protected Sub ODSspmtDCHeader_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtDCHeader.Selected
    Dim tmp As SIS.SPMT.spmtDCHeader = CType(e.ReturnValue, SIS.SPMT.spmtDCHeader)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCHeader.Init
    DataClassName = "EspmtDCHeader"
    SetFormView = FVspmtDCHeader
  End Sub
  Protected Sub TBLspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCHeader.Init
    SetToolBar = TBLspmtDCHeader
  End Sub
  Protected Sub FVspmtDCHeader_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCHeader.PreRender
    TBLspmtDCHeader.EnableSave = Editable
    TBLspmtDCHeader.EnableDelete = Deleteable
    TBLspmtDCHeader.PrintUrl &= Request.QueryString("ChallanID") & "|"
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtDCHeader.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCHeader") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCHeader", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtDCDetailsCC As New gvBase
  Protected Sub GVspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtDCDetails.Init
    gvspmtDCDetailsCC.DataClassName = "GspmtDCDetails"
    gvspmtDCDetailsCC.SetGridView = GVspmtDCDetails
  End Sub
  Protected Sub TBLspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCDetails.Init
    gvspmtDCDetailsCC.SetToolBar = TBLspmtDCDetails
  End Sub
  Protected Sub GVspmtDCDetails_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtDCDetails.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCDetails.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim SerialNo As Int32 = GVspmtDCDetails.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim RedirectUrl As String = TBLspmtDCDetails.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub TBLspmtDCDetails_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLspmtDCDetails.AddClicked
    Dim ChallanID As String = CType(FVspmtDCHeader.FindControl("F_ChallanID"),TextBox).Text
    TBLspmtDCDetails.AddUrl &= "?ChallanID=" & ChallanID
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsignerBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsigneeBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsignerGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsigneeGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function TransporterIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCHeader_ProjectID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ProjectID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comProjects = SIS.COM.comProjects.comProjectsGetByID(ProjectID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCHeader_ConsignerGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim SupplierGSTIN As String = CType(aVal(2), String)
    Dim sGst As Integer = 0
    If IsNumeric(SupplierGSTIN) Then
      sGst = Convert.ToInt32(SupplierGSTIN)
    End If
    Dim oVar As SIS.SPMT.spmtBPGSTIN = Nothing
    If sGst > 0 Then
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
    Else
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
    End If
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID)
      If sGst > 0 Then
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
      Else
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
      End If
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found in ERP."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCHeader_ConsigneeGISTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim SupplierGSTIN As String = CType(aVal(2), String)
    Dim sGst As Integer = 0
    If IsNumeric(SupplierGSTIN) Then
      sGst = Convert.ToInt32(SupplierGSTIN)
    End If
    Dim oVar As SIS.SPMT.spmtBPGSTIN = Nothing
    If sGst > 0 Then
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
    Else
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
    End If
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID)
      If sGst > 0 Then
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
      Else
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
      End If
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found in ERP."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCHeader_ConsignerBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPFromERP(BPID)
      oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID, 0)
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCHeader_TransporterID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim TransporterID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(TransporterID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCHeader_ConsigneeBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPFromERP(BPID)
      oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID, 0)
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  Private Sub FVspmtDCHeader_ItemCommand(sender As Object, e As FormViewCommandEventArgs) Handles FVspmtDCHeader.ItemCommand
    Select Case e.CommandName
      Case "IssuerIsgec"
        Dim x As LC_spmtIsgecGSTIN = CType(FVspmtDCHeader.FindControl("F_IssuerID"), LC_spmtIsgecGSTIN)
        Dim IsgecGSTINID As Integer = x.SelectedValue
        Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(IsgecGSTINID)
        With FVspmtDCHeader
          CType(.FindControl("F_IssuerCompanyName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_IssuerAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_IssuerAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_IssuerPAN"), TextBox).Text = oTmp.PAN
          CType(.FindControl("F_IssuerCIN"), TextBox).Text = oTmp.CIN
        End With
      Case "ConsignerIsgec"
        Dim x As LC_spmtIsgecGSTIN = CType(FVspmtDCHeader.FindControl("F_ConsignerIsgecID"), LC_spmtIsgecGSTIN)
        Dim IsgecGSTINID As Integer = x.SelectedValue
        Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(IsgecGSTINID)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsignerName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsignerAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsignerAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsignerAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerStateID"), LC_spmtERPStates).SelectedValue = oTmp.Description.Substring(0, 2)
        End With
      Case "ConsigneeIsgec"
        Dim x As LC_spmtIsgecGSTIN = CType(FVspmtDCHeader.FindControl("F_ConsigneeIsgecID"), LC_spmtIsgecGSTIN)
        Dim IsgecGSTINID As Integer = x.SelectedValue
        Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(IsgecGSTINID)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsigneeName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsigneeAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsigneeAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsigneeAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeStateID"), LC_spmtERPStates).SelectedValue = oTmp.Description.Substring(0, 2)
        End With
      Case "ConsignerBPGstin"
        Dim BPID As String = CType(FVspmtDCHeader.FindControl("F_ConsignerBPID"), TextBox).Text
        Dim GSTIN As String = CType(FVspmtDCHeader.FindControl("F_ConsignerGSTIN"), TextBox).Text
        Dim oTmp As SIS.SPMT.BPAddress = SIS.SPMT.BPAddress.GetBPAddress(BPID, GSTIN)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsignerName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsignerGSTINNo"), TextBox).Text = oTmp.GSTIN
          CType(.FindControl("F_ConsignerAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsignerAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsignerAddress3Line"), TextBox).Text = oTmp.Address3Line
          CType(.FindControl("F_ConsignerStateID"), LC_spmtERPStates).SelectedValue = oTmp.StateID
        End With
      Case "ConsigneeBPGstin"
        Dim BPID As String = CType(FVspmtDCHeader.FindControl("F_ConsigneeBPID"), TextBox).Text
        Dim GSTIN As String = CType(FVspmtDCHeader.FindControl("F_ConsigneeGSTIN"), TextBox).Text
        Dim oTmp As SIS.SPMT.BPAddress = SIS.SPMT.BPAddress.GetBPAddress(BPID, GSTIN)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsigneeName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsigneeGSTINNo"), TextBox).Text = oTmp.GSTIN
          CType(.FindControl("F_ConsigneeAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsigneeAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsigneeAddress3Line"), TextBox).Text = oTmp.Address3Line
          CType(.FindControl("F_ConsigneeStateID"), LC_spmtERPStates).SelectedValue = oTmp.StateID
        End With

    End Select
  End Sub

End Class
