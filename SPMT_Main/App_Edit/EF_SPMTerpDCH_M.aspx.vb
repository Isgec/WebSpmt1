Imports System.Web.Script.Serialization
Partial Class EF_SPMTerpDCH_M
  Inherits SIS.SYS.UpdateBase
  Public Property LaunchedFromERP As Boolean
    Get
      If ViewState("LaunchedFromERP") IsNot Nothing Then
        Return CType(ViewState("LaunchedFromERP"), Boolean)
      End If
      Return False
    End Get
    Set(value As Boolean)
      ViewState.Add("LaunchedfromERP", value)
    End Set
  End Property
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
  Public Property Comp() As String
    Get
      If ViewState("Comp") IsNot Nothing Then
        Return CType(ViewState("Comp"), String)
      End If
      Return "200"
    End Get
    Set(ByVal value As String)
      ViewState.Add("Comp", value)
    End Set
  End Property
  Public Property PrimaryKey() As String
    Get
      If ViewState("PrimaryKey") IsNot Nothing Then
        Return CType(ViewState("PrimaryKey"), String)
      End If
      Return ""
    End Get
    Set(ByVal value As String)
      ViewState.Add("PrimaryKey", value)
    End Set
  End Property
  Protected Sub ODSSPMTerpDCH_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSSPMTerpDCH.Selected
    Dim tmp As SIS.SPMT.SPMTerpDCH = CType(e.ReturnValue, SIS.SPMT.SPMTerpDCH)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVSPMTerpDCH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCH.Init
    DataClassName = "ESPMTerpDCH"
    SetFormView = FVSPMTerpDCH
  End Sub
  Protected Sub TBLSPMTerpDCH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCH.Init
    SetToolBar = TBLSPMTerpDCH
  End Sub
  Protected Sub FVSPMTerpDCH_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCH.PreRender
    TBLSPMTerpDCH.EnableSave = Editable
    TBLSPMTerpDCH.EnableDelete = Deleteable
    TBLSPMTerpDCD.EnableAdd = Editable
    TBLSPMTerpDCH.PrintUrl &= Request.QueryString("ChallanID") & "|"
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_SPMTerpDCH.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCH") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCH", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvSPMTerpDCDCC As New gvBase
  Protected Sub GVSPMTerpDCD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSPMTerpDCD.Init
    gvSPMTerpDCDCC.DataClassName = "GSPMTerpDCD"
    gvSPMTerpDCDCC.SetGridView = GVSPMTerpDCD
  End Sub
  Protected Sub TBLSPMTerpDCD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCD.Init
    gvSPMTerpDCDCC.SetToolBar = TBLSPMTerpDCD
  End Sub
  Protected Sub GVSPMTerpDCD_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVSPMTerpDCD.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCD.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim SerialNo As Int32 = GVSPMTerpDCD.DataKeys(e.CommandArgument).Values("SerialNo")
        Dim RedirectUrl As String = TBLSPMTerpDCD.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "rejectwf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCD.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim SerialNo As Int32 = GVSPMTerpDCD.DataKeys(e.CommandArgument).Values("SerialNo")
        SIS.SPMT.SPMTerpDCD.RejectWF(ChallanID, SerialNo)
        GVSPMTerpDCIPending.DataBind()
        GVSPMTerpDCD.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub TBLSPMTerpDCD_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLSPMTerpDCD.AddClicked
    Dim ChallanID As String = CType(FVSPMTerpDCH.FindControl("F_ChallanID"), TextBox).Text
    TBLSPMTerpDCD.AddUrl &= "&ChallanID=" & ChallanID
  End Sub
  Private WithEvents gvSPMTerpDCIPendingCC As New gvBase
  Protected Sub GVSPMTerpDCIPending_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSPMTerpDCIPending.Init
    gvSPMTerpDCIPendingCC.DataClassName = "GSPMTerpDCIPending"
    gvSPMTerpDCIPendingCC.SetGridView = GVSPMTerpDCIPending
  End Sub
  Protected Sub TBLSPMTerpDCIPending_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCIPending.Init
    gvSPMTerpDCIPendingCC.SetToolBar = TBLSPMTerpDCIPending
  End Sub
  Protected Sub GVSPMTerpDCIPending_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVSPMTerpDCIPending.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim SerialNo As Int32 = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("SerialNo")
        Dim RedirectUrl As String = TBLSPMTerpDCIPending.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "approvewf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim SerialNo As Int32 = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("SerialNo")
        Dim NewChallanID As String = FVSPMTerpDCH.DataKey.Values("ChallanID")
        SIS.SPMT.SPMTerpDCIPending.ApproveWF(ChallanID, SerialNo, NewChallanID)
        GVSPMTerpDCD.DataBind()
        GVSPMTerpDCIPending.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function CreatedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsigneeBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsigneeGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsignerBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsignerGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function TransporterIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function LinkedChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.SPMTerpDCH.SelectSPMTerpDCHAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function DestinationBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function DestinationGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ReceivedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ClosedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ClosedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ClosedBy As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(ClosedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_CreatedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim CreatedBy As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(CreatedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ReceivedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ReceivedBy As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(ReceivedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ProjectID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ProjectID As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comProjects = SIS.COM.comProjects.comProjectsGetByID(ProjectID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_LinkedChallanID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim LinkedChallanID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(LinkedChallanID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_DestinationGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim DestinationBPID As String = CType(aVal(1), String)
    Dim DestinationGSTIN As Int32 = CType(aVal(2), Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(DestinationBPID, DestinationGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ConsigneeGISTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ConsigneeBPID As String = CType(aVal(1), String)
    Dim ConsigneeGSTIN As Int32 = CType(aVal(2), Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(ConsigneeBPID, ConsigneeGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ConsignerGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ConsignerBPID As String = CType(aVal(1), String)
    Dim ConsignerGSTIN As Int32 = CType(aVal(2), Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(ConsignerBPID, ConsignerGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_DestinationBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim DestinationBPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(DestinationBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ConsigneeBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ConsigneeBPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(ConsigneeBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_ConsignerBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ConsignerBPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(ConsignerBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_erpDCH_TransporterID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim TransporterID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(TransporterID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  'Private Sub EF_SPMTerpDCH_M_Init(sender As Object, e As EventArgs) Handles Me.Init
  '  If Request.QueryString("ChallanID") IsNot Nothing Then
  '    Me.LaunchedFromERP = True
  '    Me.PrimaryKey = Request.QueryString("ChallanID")
  '    If Request.QueryString("Comp") IsNot Nothing Then
  '      Me.Comp = Request.QueryString("Comp")
  '    Else
  '      Me.Comp = "200"
  '    End If
  '    Dim tmp As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(PrimaryKey)
  '    If tmp Is Nothing Then
  '      tmp = SIS.SPMT.SPMTerpDCH.erpDCHGetFromERP(PrimaryKey, Comp)
  '      '====================
  '      tmp.CreatedBy = "0340"
  '      tmp.StatusID = spmtDHStates.Created
  '      '====================
  '      Dim oVar As SIS.SPMT.spmtBusinessPartner = Nothing
  '      '1.
  '      If tmp.ConsigneeBPID <> "" Then
  '        oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(tmp.ConsigneeBPID)
  '        'If oVar Is Nothing Then
  '        Try
  '          SIS.SPMT.spmtSupplierBill.GetBPFromERP(tmp.ConsigneeBPID, Comp)
  '        Catch ex As Exception
  '        End Try
  '        'End If
  '      End If
  '      '2.
  '      If tmp.ConsignerBPID <> "" Then
  '        oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(tmp.ConsignerBPID)
  '        'If oVar Is Nothing Then
  '        Try
  '          SIS.SPMT.spmtSupplierBill.GetBPFromERP(tmp.ConsignerBPID, Comp)
  '        Catch ex As Exception
  '        End Try
  '        'End If
  '      End If
  '      '3.
  '      If tmp.ProjectID <> "" Then
  '        Try
  '          SIS.COM.comProjects.GetProjectFromERP(tmp.ProjectID, Comp)
  '        Catch ex As Exception
  '        End Try
  '      End If
  '      '4.
  '      If tmp.TransporterID <> "" Then
  '        oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(tmp.TransporterID)
  '        'If oVar Is Nothing Then
  '        Try
  '          SIS.SPMT.spmtSupplierBill.GetBPFromERP(tmp.TransporterID, Comp)
  '        Catch ex As Exception
  '        End Try
  '        'End If
  '      End If
  '      '5. Misc
  '      tmp.ConsigneeStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.ConsigneeStateID)
  '      tmp.ConsignerStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.ConsignerStateID)
  '      'tmp.DestinationStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.DestinationStateID)
  '      tmp.PlaceOfDelivery = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.PlaceOfDelivery)
  '      tmp.PlaceOfSupply = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.PlaceOfSupply)
  '      tmp.ConsigneeGSTIN = SIS.SPMT.spmtBPGSTIN.spmtGSTINByDescription(tmp.ConsigneeGSTIN)
  '      tmp.ConsignerGSTIN = SIS.SPMT.spmtBPGSTIN.spmtGSTINByDescription(tmp.ConsignerGSTIN)
  '      '6. Insert Challan
  '      Try
  '        SIS.SPMT.SPMTerpDCH.InsertData(tmp)
  '      Catch ex As Exception
  '        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
  '        Dim script As String = String.Format("alert({0});", message)
  '        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
  '      End Try
  '    End If
  '  End If
  'End Sub

End Class
