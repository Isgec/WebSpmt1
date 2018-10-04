Partial Class AF_spmtPAStatus
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtPAStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPAStatus.Init
    DataClassName = "AspmtPAStatus"
    SetFormView = FVspmtPAStatus
  End Sub
  Protected Sub TBLspmtPAStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPAStatus.Init
    SetToolBar = TBLspmtPAStatus
  End Sub
  Protected Sub FVspmtPAStatus_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPAStatus.DataBound
    SIS.SPMT.spmtPAStatus.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtPAStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPAStatus.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtPAStatus.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtPAStatus") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtPAStatus", mStr)
    End If
    If Request.QueryString("AdviceStatusID") IsNot Nothing Then
      CType(FVspmtPAStatus.FindControl("F_AdviceStatusID"), TextBox).Text = Request.QueryString("AdviceStatusID")
      CType(FVspmtPAStatus.FindControl("F_AdviceStatusID"), TextBox).Enabled = False
    End If
  End Sub

End Class
