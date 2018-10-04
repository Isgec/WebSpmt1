Partial Class AF_spmtBillStatus
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtBillStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillStatus.Init
    DataClassName = "AspmtBillStatus"
    SetFormView = FVspmtBillStatus
  End Sub
  Protected Sub TBLspmtBillStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBillStatus.Init
    SetToolBar = TBLspmtBillStatus
  End Sub
  Protected Sub FVspmtBillStatus_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillStatus.DataBound
    SIS.SPMT.spmtBillStatus.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtBillStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillStatus.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtBillStatus.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBillStatus") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBillStatus", mStr)
    End If
    If Request.QueryString("BillStatusID") IsNot Nothing Then
      CType(FVspmtBillStatus.FindControl("F_BillStatusID"), TextBox).Text = Request.QueryString("BillStatusID")
      CType(FVspmtBillStatus.FindControl("F_BillStatusID"), TextBox).Enabled = False
    End If
  End Sub

End Class
