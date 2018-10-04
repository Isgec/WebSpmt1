Partial Class AF_spmtHSNSACCodes
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtHSNSACCodes.Init
    DataClassName = "AspmtHSNSACCodes"
    SetFormView = FVspmtHSNSACCodes
  End Sub
  Protected Sub TBLspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtHSNSACCodes.Init
    SetToolBar = TBLspmtHSNSACCodes
  End Sub
  Protected Sub FVspmtHSNSACCodes_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtHSNSACCodes.DataBound
    SIS.SPMT.spmtHSNSACCodes.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtHSNSACCodes_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtHSNSACCodes.PreRender
    Dim oF_BillType As LC_spmtBillTypes = FVspmtHSNSACCodes.FindControl("F_BillType")
    oF_BillType.Enabled = True
    oF_BillType.SelectedValue = String.Empty
    If Not Session("F_BillType") Is Nothing Then
      If Session("F_BillType") <> String.Empty Then
        oF_BillType.SelectedValue = Session("F_BillType")
      End If
    End If
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtHSNSACCodes.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtHSNSACCodes") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtHSNSACCodes", mStr)
    End If
    If Request.QueryString("BillType") IsNot Nothing Then
      CType(FVspmtHSNSACCodes.FindControl("F_BillType"), TextBox).Text = Request.QueryString("BillType")
      CType(FVspmtHSNSACCodes.FindControl("F_BillType"), TextBox).Enabled = False
    End If
    If Request.QueryString("HSNSACCode") IsNot Nothing Then
      CType(FVspmtHSNSACCodes.FindControl("F_HSNSACCode"), TextBox).Text = Request.QueryString("HSNSACCode")
      CType(FVspmtHSNSACCodes.FindControl("F_HSNSACCode"), TextBox).Enabled = False
    End If
  End Sub

End Class
