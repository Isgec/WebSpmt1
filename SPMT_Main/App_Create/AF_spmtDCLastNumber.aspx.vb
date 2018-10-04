Partial Class AF_spmtDCLastNumber
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtDCLastNumber_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCLastNumber.Init
    DataClassName = "AspmtDCLastNumber"
    SetFormView = FVspmtDCLastNumber
  End Sub
  Protected Sub TBLspmtDCLastNumber_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCLastNumber.Init
    SetToolBar = TBLspmtDCLastNumber
  End Sub
  Protected Sub FVspmtDCLastNumber_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCLastNumber.DataBound
    SIS.SPMT.spmtDCLastNumber.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtDCLastNumber_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCLastNumber.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtDCLastNumber.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCLastNumber") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCLastNumber", mStr)
    End If
    If Request.QueryString("NumberID") IsNot Nothing Then
      CType(FVspmtDCLastNumber.FindControl("F_NumberID"), TextBox).Text = Request.QueryString("NumberID")
      CType(FVspmtDCLastNumber.FindControl("F_NumberID"), TextBox).Enabled = False
    End If
  End Sub

End Class
