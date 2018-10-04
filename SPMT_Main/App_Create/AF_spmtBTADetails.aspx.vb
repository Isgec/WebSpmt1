Partial Class AF_spmtBTADetails
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtBTADetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBTADetails.Init
    DataClassName = "AspmtBTADetails"
    SetFormView = FVspmtBTADetails
  End Sub
  Protected Sub TBLspmtBTADetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBTADetails.Init
    SetToolBar = TBLspmtBTADetails
  End Sub
  Protected Sub FVspmtBTADetails_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBTADetails.DataBound
    SIS.SPMT.spmtBTADetails.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtBTADetails_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBTADetails.PreRender
    Dim oF_StatusID_Display As Label  = FVspmtBTADetails.FindControl("F_StatusID_Display")
    Dim oF_StatusID As TextBox  = FVspmtBTADetails.FindControl("F_StatusID")
    Dim oF_CreatedBy_Display As Label  = FVspmtBTADetails.FindControl("F_CreatedBy_Display")
    Dim oF_CreatedBy As TextBox  = FVspmtBTADetails.FindControl("F_CreatedBy")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtBTADetails.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBTADetails") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBTADetails", mStr)
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVspmtBTADetails.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVspmtBTADetails.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function StatusIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBTAStatus.SelectspmtBTAStatusAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function CreatedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_BTADetails_CreatedBy(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_BTADetails_StatusID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim StatusID As Int32 = CType(aVal(1),Int32)
    Dim oVar As SIS.SPMT.spmtBTAStatus = SIS.SPMT.spmtBTAStatus.spmtBTAStatusGetByID(StatusID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function

End Class
