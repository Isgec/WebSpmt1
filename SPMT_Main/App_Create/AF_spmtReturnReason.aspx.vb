Partial Class AF_spmtReturnReason
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtReturnReason_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtReturnReason.Init
    DataClassName = "AspmtReturnReason"
    SetFormView = FVspmtReturnReason
  End Sub
  Protected Sub TBLspmtReturnReason_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtReturnReason.Init
    SetToolBar = TBLspmtReturnReason
  End Sub
  Protected Sub FVspmtReturnReason_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtReturnReason.DataBound
    SIS.SPMT.spmtReturnReason.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtReturnReason_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtReturnReason.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtReturnReason.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtReturnReason") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtReturnReason", mStr)
    End If
    If Request.QueryString("ReasonID") IsNot Nothing Then
      CType(FVspmtReturnReason.FindControl("F_ReasonID"), TextBox).Text = Request.QueryString("ReasonID")
      CType(FVspmtReturnReason.FindControl("F_ReasonID"), TextBox).Enabled = False
    End If
  End Sub

End Class
