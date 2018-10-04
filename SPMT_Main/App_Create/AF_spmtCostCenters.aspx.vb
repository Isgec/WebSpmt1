Partial Class AF_spmtCostCenters
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtCostCenters_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtCostCenters.Init
    DataClassName = "AspmtCostCenters"
    SetFormView = FVspmtCostCenters
  End Sub
  Protected Sub TBLspmtCostCenters_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtCostCenters.Init
    SetToolBar = TBLspmtCostCenters
  End Sub
  Protected Sub FVspmtCostCenters_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtCostCenters.DataBound
    SIS.SPMT.spmtCostCenters.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtCostCenters_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtCostCenters.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtCostCenters.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtCostCenters") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtCostCenters", mStr)
    End If
    If Request.QueryString("CostCenterID") IsNot Nothing Then
      CType(FVspmtCostCenters.FindControl("F_CostCenterID"), TextBox).Text = Request.QueryString("CostCenterID")
      CType(FVspmtCostCenters.FindControl("F_CostCenterID"), TextBox).Enabled = False
    End If
  End Sub

End Class
