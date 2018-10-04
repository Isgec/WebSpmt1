Partial Class AF_spmtBPGSTIN
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBPGSTIN.Init
    DataClassName = "AspmtBPGSTIN"
    SetFormView = FVspmtBPGSTIN
  End Sub
  Protected Sub TBLspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBPGSTIN.Init
    SetToolBar = TBLspmtBPGSTIN
  End Sub
  Protected Sub FVspmtBPGSTIN_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBPGSTIN.DataBound
    SIS.SPMT.spmtBPGSTIN.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtBPGSTIN_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBPGSTIN.PreRender
    Dim oF_BPID_Display As Label  = FVspmtBPGSTIN.FindControl("F_BPID_Display")
    oF_BPID_Display.Text = String.Empty
    If Not Session("F_BPID_Display") Is Nothing Then
      If Session("F_BPID_Display") <> String.Empty Then
        oF_BPID_Display.Text = Session("F_BPID_Display")
      End If
    End If
    Dim oF_BPID As TextBox  = FVspmtBPGSTIN.FindControl("F_BPID")
    oF_BPID.Enabled = True
    oF_BPID.Text = String.Empty
    If Not Session("F_BPID") Is Nothing Then
      If Session("F_BPID") <> String.Empty Then
        oF_BPID.Text = Session("F_BPID")
      End If
    End If
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtBPGSTIN.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBPGSTIN") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBPGSTIN", mStr)
    End If
    If Request.QueryString("BPID") IsNot Nothing Then
      CType(FVspmtBPGSTIN.FindControl("F_BPID"), TextBox).Text = Request.QueryString("BPID")
      CType(FVspmtBPGSTIN.FindControl("F_BPID"), TextBox).Enabled = False
    End If
    If Request.QueryString("GSTIN") IsNot Nothing Then
      CType(FVspmtBPGSTIN.FindControl("F_GSTIN"), TextBox).Text = Request.QueryString("GSTIN")
      CType(FVspmtBPGSTIN.FindControl("F_GSTIN"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_VR_BPGSTIN_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function

End Class
