Partial Class AF_spmtDCStates
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtDCStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCStates.Init
    DataClassName = "AspmtDCStates"
    SetFormView = FVspmtDCStates
  End Sub
  Protected Sub TBLspmtDCStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCStates.Init
    SetToolBar = TBLspmtDCStates
  End Sub
  Protected Sub FVspmtDCStates_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCStates.DataBound
    SIS.SPMT.spmtDCStates.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtDCStates_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCStates.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtDCStates.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCStates") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCStates", mStr)
    End If
    If Request.QueryString("StatusID") IsNot Nothing Then
      CType(FVspmtDCStates.FindControl("F_StatusID"), TextBox).Text = Request.QueryString("StatusID")
      CType(FVspmtDCStates.FindControl("F_StatusID"), TextBox).Enabled = False
    End If
  End Sub

End Class
