Partial Class AF_spmtERPStates
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtERPStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPStates.Init
    DataClassName = "AspmtERPStates"
    SetFormView = FVspmtERPStates
  End Sub
  Protected Sub TBLspmtERPStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtERPStates.Init
    SetToolBar = TBLspmtERPStates
  End Sub
  Protected Sub FVspmtERPStates_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPStates.DataBound
    SIS.SPMT.spmtERPStates.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtERPStates_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPStates.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtERPStates.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtERPStates") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtERPStates", mStr)
    End If
    If Request.QueryString("StateID") IsNot Nothing Then
      CType(FVspmtERPStates.FindControl("F_StateID"), TextBox).Text = Request.QueryString("StateID")
      CType(FVspmtERPStates.FindControl("F_StateID"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validatePK_spmtERPStates(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim StateID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtERPStates = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(StateID)
    If Not oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record allready exists." 
    End If
    Return mRet
  End Function

End Class
