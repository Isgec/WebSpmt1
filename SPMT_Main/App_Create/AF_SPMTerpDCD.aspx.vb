Partial Class AF_SPMTerpDCD
  Inherits SIS.SYS.InsertBase
  Protected Sub FVSPMTerpDCD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCD.Init
    DataClassName = "ASPMTerpDCD"
    SetFormView = FVSPMTerpDCD
  End Sub
  Protected Sub TBLSPMTerpDCD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCD.Init
    SetToolBar = TBLSPMTerpDCD
  End Sub
  Protected Sub ODSSPMTerpDCD_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSSPMTerpDCD.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.SPMTerpDCD = CType(e.ReturnValue,SIS.SPMT.SPMTerpDCD)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&ChallanID=" & oDC.ChallanID
      tmpURL &= "&SerialNo=" & oDC.SerialNo
      TBLSPMTerpDCD.AfterInsertURL &= tmpURL 
    End If
  End Sub
  Protected Sub FVSPMTerpDCD_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCD.DataBound
    SIS.SPMT.SPMTerpDCD.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVSPMTerpDCD_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCD.PreRender
    Dim oF_ChallanID_Display As Label  = FVSPMTerpDCD.FindControl("F_ChallanID_Display")
    oF_ChallanID_Display.Text = String.Empty
    If Not Session("F_ChallanID_Display") Is Nothing Then
      If Session("F_ChallanID_Display") <> String.Empty Then
        oF_ChallanID_Display.Text = Session("F_ChallanID_Display")
      End If
    End If
    Dim oF_ChallanID As TextBox  = FVSPMTerpDCD.FindControl("F_ChallanID")
    oF_ChallanID.Enabled = True
    oF_ChallanID.Text = String.Empty
    If Not Session("F_ChallanID") Is Nothing Then
      If Session("F_ChallanID") <> String.Empty Then
        oF_ChallanID.Text = Session("F_ChallanID")
      End If
    End If
    Dim oF_HSNSACCode_Display As Label  = FVSPMTerpDCD.FindControl("F_HSNSACCode_Display")
    Dim oF_HSNSACCode As TextBox  = FVSPMTerpDCD.FindControl("F_HSNSACCode")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_SPMTerpDCD.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCD") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCD", mStr)
    End If
    If Request.QueryString("ChallanID") IsNot Nothing Then
      CType(FVSPMTerpDCD.FindControl("F_ChallanID"), TextBox).Text = Request.QueryString("ChallanID")
      CType(FVSPMTerpDCD.FindControl("F_ChallanID"), TextBox).Enabled = False
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVSPMTerpDCD.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVSPMTerpDCD.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.SPMTerpDCH.SelectSPMTerpDCHAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCD_ChallanID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_erpDCD_HSNSACCode(ByVal value As String) As String
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
