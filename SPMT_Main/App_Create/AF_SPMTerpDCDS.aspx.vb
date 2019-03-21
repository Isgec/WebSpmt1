Partial Class AF_SPMTerpDCDS
  Inherits SIS.SYS.InsertBase
  Protected Sub FVSPMTerpDCDS_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCDS.Init
    DataClassName = "ASPMTerpDCDS"
    SetFormView = FVSPMTerpDCDS
  End Sub
  Protected Sub TBLSPMTerpDCDS_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCDS.Init
    SetToolBar = TBLSPMTerpDCDS
  End Sub
  Protected Sub FVSPMTerpDCDS_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCDS.DataBound
    SIS.SPMT.SPMTerpDCDS.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVSPMTerpDCDS_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCDS.PreRender
    Dim oF_ChallanID_Display As Label  = FVSPMTerpDCDS.FindControl("F_ChallanID_Display")
    oF_ChallanID_Display.Text = String.Empty
    If Not Session("F_ChallanID_Display") Is Nothing Then
      If Session("F_ChallanID_Display") <> String.Empty Then
        oF_ChallanID_Display.Text = Session("F_ChallanID_Display")
      End If
    End If
    Dim oF_ChallanID As TextBox  = FVSPMTerpDCDS.FindControl("F_ChallanID")
    oF_ChallanID.Enabled = True
    oF_ChallanID.Text = String.Empty
    If Not Session("F_ChallanID") Is Nothing Then
      If Session("F_ChallanID") <> String.Empty Then
        oF_ChallanID.Text = Session("F_ChallanID")
      End If
    End If
    Dim oF_SerialNo_Display As Label  = FVSPMTerpDCDS.FindControl("F_SerialNo_Display")
    oF_SerialNo_Display.Text = String.Empty
    If Not Session("F_SerialNo_Display") Is Nothing Then
      If Session("F_SerialNo_Display") <> String.Empty Then
        oF_SerialNo_Display.Text = Session("F_SerialNo_Display")
      End If
    End If
    Dim oF_SerialNo As TextBox  = FVSPMTerpDCDS.FindControl("F_SerialNo")
    oF_SerialNo.Enabled = True
    oF_SerialNo.Text = String.Empty
    If Not Session("F_SerialNo") Is Nothing Then
      If Session("F_SerialNo") <> String.Empty Then
        oF_SerialNo.Text = Session("F_SerialNo")
      End If
    End If
    Dim oF_HSNSACCode_Display As Label  = FVSPMTerpDCDS.FindControl("F_HSNSACCode_Display")
    Dim oF_HSNSACCode As TextBox  = FVSPMTerpDCDS.FindControl("F_HSNSACCode")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_SPMTerpDCDS.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCDS") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCDS", mStr)
    End If
    If Request.QueryString("ChallanID") IsNot Nothing Then
      CType(FVSPMTerpDCDS.FindControl("F_ChallanID"), TextBox).Text = Request.QueryString("ChallanID")
      CType(FVSPMTerpDCDS.FindControl("F_ChallanID"), TextBox).Enabled = False
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVSPMTerpDCDS.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVSPMTerpDCDS.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
    If Request.QueryString("SourceNo") IsNot Nothing Then
      CType(FVSPMTerpDCDS.FindControl("F_SourceNo"), TextBox).Text = Request.QueryString("SourceNo")
      CType(FVSPMTerpDCDS.FindControl("F_SourceNo"), TextBox).Enabled = False
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
  Public Shared Function validate_FK_SPMT_erpDCDS_SerialNo(ByVal value As String) As String
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
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCDS_ChallanID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_erpDCDS_HSNSACCode(ByVal value As String) As String
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

End Class
