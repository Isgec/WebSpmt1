Partial Class AF_spmtAirTicket
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtAirTicket_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicket.Init
    DataClassName = "AspmtAirTicket"
    SetFormView = FVspmtAirTicket
  End Sub
  Protected Sub TBLspmtAirTicket_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtAirTicket.Init
    SetToolBar = TBLspmtAirTicket
  End Sub
  Protected Sub FVspmtAirTicket_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicket.DataBound
    SIS.SPMT.spmtAirTicket.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtAirTicket_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicket.PreRender
    Dim oF_TranTypeID As LC_spmtTranTypes = FVspmtAirTicket.FindControl("F_TranTypeID")
    oF_TranTypeID.Enabled = True
    oF_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        oF_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    Dim oF_AgentsBPID_Display As Label  = FVspmtAirTicket.FindControl("F_AgentsBPID_Display")
    oF_AgentsBPID_Display.Text = String.Empty
    If Not Session("F_AgentsBPID_Display") Is Nothing Then
      If Session("F_AgentsBPID_Display") <> String.Empty Then
        oF_AgentsBPID_Display.Text = Session("F_AgentsBPID_Display")
      End If
    End If
    Dim oF_AgentsBPID As TextBox  = FVspmtAirTicket.FindControl("F_AgentsBPID")
    oF_AgentsBPID.Enabled = True
    oF_AgentsBPID.Text = String.Empty
    If Not Session("F_AgentsBPID") Is Nothing Then
      If Session("F_AgentsBPID") <> String.Empty Then
        oF_AgentsBPID.Text = Session("F_AgentsBPID")
      End If
    End If
    Dim oF_AgentsGSTIN_Display As Label  = FVspmtAirTicket.FindControl("F_AgentsGSTIN_Display")
    Dim oF_AgentsGSTIN As TextBox  = FVspmtAirTicket.FindControl("F_AgentsGSTIN")
    Dim oF_AgentsHSNSACCode_Display As Label  = FVspmtAirTicket.FindControl("F_AgentsHSNSACCode_Display")
    Dim oF_AgentsHSNSACCode As TextBox  = FVspmtAirTicket.FindControl("F_AgentsHSNSACCode")
    Dim oF_AgencyBPID_Display As Label  = FVspmtAirTicket.FindControl("F_AgencyBPID_Display")
    oF_AgencyBPID_Display.Text = String.Empty
    If Not Session("F_AgencyBPID_Display") Is Nothing Then
      If Session("F_AgencyBPID_Display") <> String.Empty Then
        oF_AgencyBPID_Display.Text = Session("F_AgencyBPID_Display")
      End If
    End If
    Dim oF_AgencyBPID As TextBox  = FVspmtAirTicket.FindControl("F_AgencyBPID")
    oF_AgencyBPID.Enabled = True
    oF_AgencyBPID.Text = String.Empty
    If Not Session("F_AgencyBPID") Is Nothing Then
      If Session("F_AgencyBPID") <> String.Empty Then
        oF_AgencyBPID.Text = Session("F_AgencyBPID")
      End If
    End If
    Dim oF_AgencyGSTIN_Display As Label  = FVspmtAirTicket.FindControl("F_AgencyGSTIN_Display")
    Dim oF_AgencyGSTIN As TextBox  = FVspmtAirTicket.FindControl("F_AgencyGSTIN")
    Dim oF_AgencyHSNSACCode_Display As Label  = FVspmtAirTicket.FindControl("F_AgencyHSNSACCode_Display")
    Dim oF_AgencyHSNSACCode As TextBox  = FVspmtAirTicket.FindControl("F_AgencyHSNSACCode")
    Dim oF_EmployeeID_Display As Label  = FVspmtAirTicket.FindControl("F_EmployeeID_Display")
    oF_EmployeeID_Display.Text = String.Empty
    If Not Session("F_EmployeeID_Display") Is Nothing Then
      If Session("F_EmployeeID_Display") <> String.Empty Then
        oF_EmployeeID_Display.Text = Session("F_EmployeeID_Display")
      End If
    End If
    Dim oF_EmployeeID As TextBox  = FVspmtAirTicket.FindControl("F_EmployeeID")
    oF_EmployeeID.Enabled = True
    oF_EmployeeID.Text = String.Empty
    If Not Session("F_EmployeeID") Is Nothing Then
      If Session("F_EmployeeID") <> String.Empty Then
        oF_EmployeeID.Text = Session("F_EmployeeID")
      End If
    End If
    Dim oF_ProjectID_Display As Label  = FVspmtAirTicket.FindControl("F_ProjectID_Display")
    oF_ProjectID_Display.Text = String.Empty
    If Not Session("F_ProjectID_Display") Is Nothing Then
      If Session("F_ProjectID_Display") <> String.Empty Then
        oF_ProjectID_Display.Text = Session("F_ProjectID_Display")
      End If
    End If
    Dim oF_ProjectID As TextBox  = FVspmtAirTicket.FindControl("F_ProjectID")
    oF_ProjectID.Enabled = True
    oF_ProjectID.Text = String.Empty
    If Not Session("F_ProjectID") Is Nothing Then
      If Session("F_ProjectID") <> String.Empty Then
        oF_ProjectID.Text = Session("F_ProjectID")
      End If
    End If
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtAirTicket.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtAirTicket") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtAirTicket", mStr)
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVspmtAirTicket.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVspmtAirTicket.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgentsBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgentsGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgentsHSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgencyBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgencyGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AgencyHSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function EmployeeIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_EmployeeID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim EmployeeID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(EmployeeID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_ProjectID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_AirTicket_AgencyHSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgencyBillType As Int32 = CType(aVal(1),Int32)
    Dim AgencyHSNSACCode As String = CType(aVal(2),String)
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(AgencyBillType,AgencyHSNSACCode)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgentsHSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgentsBillType As Int32 = CType(aVal(1),Int32)
    Dim AgentsHSNSACCode As String = CType(aVal(2),String)
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(AgentsBillType,AgentsHSNSACCode)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgencyGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgencyBPID As String = CType(aVal(1),String)
    Dim AgencyGSTIN As Int32 = CType(aVal(2),Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(AgencyBPID,AgencyGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgentsGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgentsBPID As String = CType(aVal(1),String)
    Dim AgentsGSTIN As Int32 = CType(aVal(2),Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(AgentsBPID,AgentsGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgencyBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgencyBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(AgencyBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_AirTicket_AgentsBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim AgentsBPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(AgentsBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function

End Class
