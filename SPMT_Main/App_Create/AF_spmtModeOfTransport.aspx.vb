Partial Class AF_spmtModeOfTransport
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtModeOfTransport_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtModeOfTransport.Init
    DataClassName = "AspmtModeOfTransport"
    SetFormView = FVspmtModeOfTransport
  End Sub
  Protected Sub TBLspmtModeOfTransport_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtModeOfTransport.Init
    SetToolBar = TBLspmtModeOfTransport
  End Sub
  Protected Sub FVspmtModeOfTransport_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtModeOfTransport.DataBound
    SIS.SPMT.spmtModeOfTransport.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtModeOfTransport_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtModeOfTransport.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtModeOfTransport.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtModeOfTransport") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtModeOfTransport", mStr)
    End If
    If Request.QueryString("ModeID") IsNot Nothing Then
      CType(FVspmtModeOfTransport.FindControl("F_ModeID"), TextBox).Text = Request.QueryString("ModeID")
      CType(FVspmtModeOfTransport.FindControl("F_ModeID"), TextBox).Enabled = False
    End If
  End Sub

End Class
