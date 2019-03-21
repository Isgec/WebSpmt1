Partial Class AF_SPMTerpDCH
  Inherits SIS.SYS.InsertBase
  Protected Sub FVSPMTerpDCH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCH.Init
    DataClassName = "ASPMTerpDCH"
    SetFormView = FVSPMTerpDCH
  End Sub
  Protected Sub TBLSPMTerpDCH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCH.Init
    SetToolBar = TBLSPMTerpDCH
  End Sub
  Protected Sub ODSSPMTerpDCH_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSSPMTerpDCH.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.SPMTerpDCH = CType(e.ReturnValue,SIS.SPMT.SPMTerpDCH)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&ChallanID=" & oDC.ChallanID
      TBLSPMTerpDCH.AfterInsertURL &= tmpURL 
    End If
  End Sub
  Protected Sub FVSPMTerpDCH_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCH.DataBound
    SIS.SPMT.SPMTerpDCH.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVSPMTerpDCH_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCH.PreRender
    Dim oF_CreatedBy_Display As Label  = FVSPMTerpDCH.FindControl("F_CreatedBy_Display")
    Dim oF_CreatedBy As TextBox  = FVSPMTerpDCH.FindControl("F_CreatedBy")
    Dim oF_ProjectID_Display As Label  = FVSPMTerpDCH.FindControl("F_ProjectID_Display")
    Dim oF_ProjectID As TextBox  = FVSPMTerpDCH.FindControl("F_ProjectID")
    Dim oF_ConsigneeBPID_Display As Label  = FVSPMTerpDCH.FindControl("F_ConsigneeBPID_Display")
    Dim oF_ConsigneeBPID As TextBox  = FVSPMTerpDCH.FindControl("F_ConsigneeBPID")
    Dim oF_ConsigneeGSTIN_Display As Label  = FVSPMTerpDCH.FindControl("F_ConsigneeGSTIN_Display")
    Dim oF_ConsigneeGSTIN As TextBox  = FVSPMTerpDCH.FindControl("F_ConsigneeGSTIN")
    Dim oF_ConsignerBPID_Display As Label  = FVSPMTerpDCH.FindControl("F_ConsignerBPID_Display")
    Dim oF_ConsignerBPID As TextBox  = FVSPMTerpDCH.FindControl("F_ConsignerBPID")
    Dim oF_ConsignerGSTIN_Display As Label  = FVSPMTerpDCH.FindControl("F_ConsignerGSTIN_Display")
    Dim oF_ConsignerGSTIN As TextBox  = FVSPMTerpDCH.FindControl("F_ConsignerGSTIN")
    Dim oF_TransporterID_Display As Label  = FVSPMTerpDCH.FindControl("F_TransporterID_Display")
    Dim oF_TransporterID As TextBox  = FVSPMTerpDCH.FindControl("F_TransporterID")
    Dim oF_LinkedChallanID_Display As Label  = FVSPMTerpDCH.FindControl("F_LinkedChallanID_Display")
    Dim oF_LinkedChallanID As TextBox  = FVSPMTerpDCH.FindControl("F_LinkedChallanID")
    Dim oF_DestinationBPID_Display As Label  = FVSPMTerpDCH.FindControl("F_DestinationBPID_Display")
    Dim oF_DestinationBPID As TextBox  = FVSPMTerpDCH.FindControl("F_DestinationBPID")
    Dim oF_DestinationGSTIN_Display As Label  = FVSPMTerpDCH.FindControl("F_DestinationGSTIN_Display")
    Dim oF_DestinationGSTIN As TextBox  = FVSPMTerpDCH.FindControl("F_DestinationGSTIN")
    Dim oF_ReceivedBy_Display As Label  = FVSPMTerpDCH.FindControl("F_ReceivedBy_Display")
    Dim oF_ReceivedBy As TextBox  = FVSPMTerpDCH.FindControl("F_ReceivedBy")
    Dim oF_ClosedBy_Display As Label  = FVSPMTerpDCH.FindControl("F_ClosedBy_Display")
    Dim oF_ClosedBy As TextBox  = FVSPMTerpDCH.FindControl("F_ClosedBy")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_SPMTerpDCH.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCH") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCH", mStr)
    End If
    If Request.QueryString("ChallanID") IsNot Nothing Then
      CType(FVSPMTerpDCH.FindControl("F_ChallanID"), TextBox).Text = Request.QueryString("ChallanID")
      CType(FVSPMTerpDCH.FindControl("F_ChallanID"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function CreatedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsigneeBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsigneeGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsignerBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConsignerGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function TransporterIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function LinkedChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.SPMTerpDCH.SelectSPMTerpDCHAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function DestinationBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function DestinationGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ReceivedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ClosedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ClosedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ClosedBy As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(ClosedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_CreatedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim CreatedBy As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(CreatedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ReceivedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ReceivedBy As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(ReceivedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ProjectID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_erpDCH_LinkedChallanID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim LinkedChallanID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(LinkedChallanID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_DestinationGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim DestinationBPID As String = CType(aVal(1),String)
    Dim DestinationGSTIN As Int32 = CType(aVal(2),Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(DestinationBPID,DestinationGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ConsigneeGISTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ConsigneeBPID As String = CType(aVal(1),String)
    Dim ConsigneeGSTIN As Int32 = CType(aVal(2),Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(ConsigneeBPID,ConsigneeGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ConsignerGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ConsignerBPID As String = CType(aVal(1),String)
    Dim ConsignerGSTIN As Int32 = CType(aVal(2),Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(ConsignerBPID,ConsignerGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_DestinationBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim DestinationBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(DestinationBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ConsigneeBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ConsigneeBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(ConsigneeBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_ConsignerBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ConsignerBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(ConsignerBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCH_TransporterID(ByVal value As String) As String
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

End Class
