Partial Class AF_SPMTerpDCInventory
  Inherits SIS.SYS.InsertBase
  Protected Sub FVSPMTerpDCInventory_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCInventory.Init
    DataClassName = "ASPMTerpDCInventory"
    SetFormView = FVSPMTerpDCInventory
  End Sub
  Protected Sub TBLSPMTerpDCInventory_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCInventory.Init
    SetToolBar = TBLSPMTerpDCInventory
  End Sub
  Protected Sub FVSPMTerpDCInventory_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCInventory.DataBound
    SIS.SPMT.SPMTerpDCInventory.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVSPMTerpDCInventory_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCInventory.PreRender
    Dim oF_ChallanID_Display As Label  = FVSPMTerpDCInventory.FindControl("F_ChallanID_Display")
    Dim oF_ChallanID As TextBox  = FVSPMTerpDCInventory.FindControl("F_ChallanID")
    Dim oF_SerialNo_Display As Label  = FVSPMTerpDCInventory.FindControl("F_SerialNo_Display")
    Dim oF_SerialNo As TextBox  = FVSPMTerpDCInventory.FindControl("F_SerialNo")
    Dim oF_HSNSACCode_Display As Label  = FVSPMTerpDCInventory.FindControl("F_HSNSACCode_Display")
    Dim oF_HSNSACCode As TextBox  = FVSPMTerpDCInventory.FindControl("F_HSNSACCode")
    Dim oF_ConsignerBPID_Display As Label  = FVSPMTerpDCInventory.FindControl("F_ConsignerBPID_Display")
    Dim oF_ConsignerBPID As TextBox  = FVSPMTerpDCInventory.FindControl("F_ConsignerBPID")
    Dim oF_ConsignerGSTIN_Display As Label  = FVSPMTerpDCInventory.FindControl("F_ConsignerGSTIN_Display")
    Dim oF_ConsignerGSTIN As TextBox  = FVSPMTerpDCInventory.FindControl("F_ConsignerGSTIN")
    Dim oF_ProjectID_Display As Label  = FVSPMTerpDCInventory.FindControl("F_ProjectID_Display")
    Dim oF_ProjectID As TextBox  = FVSPMTerpDCInventory.FindControl("F_ProjectID")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_SPMTerpDCInventory.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCInventory") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCInventory", mStr)
    End If
    If Request.QueryString("ChallanID") IsNot Nothing Then
      CType(FVSPMTerpDCInventory.FindControl("F_ChallanID"), TextBox).Text = Request.QueryString("ChallanID")
      CType(FVSPMTerpDCInventory.FindControl("F_ChallanID"), TextBox).Enabled = False
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVSPMTerpDCInventory.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVSPMTerpDCInventory.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.SPMTerpDCH.SelectSPMTerpDCHAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function SerialNoCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.SPMTerpDCD.SelectSPMTerpDCDAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
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
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCInventory_ProjectID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_erpDCInventory_ChallanID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ChallanID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(ChallanID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCInventory_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BillTypeID As Int32 = CType(aVal(1),Int32)
    Dim HSNSACCode As String = CType(aVal(2),String)
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillTypeID,HSNSACCode)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCInventory_ConsignerGSTIN(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_erpDCInventory_ConsignerBPID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_erpDCInventory_SerialNo(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ChallanID As String = CType(aVal(1),String)
    Dim SerialNo As Int32 = CType(aVal(2),Int32)
    Dim oVar As SIS.SPMT.SPMTerpDCD = SIS.SPMT.SPMTerpDCD.SPMTerpDCDGetByID(ChallanID,SerialNo)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function

End Class
