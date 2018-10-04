Partial Class AF_spmtIsgecGSTIN
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtIsgecGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtIsgecGSTIN.Init
    DataClassName = "AspmtIsgecGSTIN"
    SetFormView = FVspmtIsgecGSTIN
  End Sub
  Protected Sub TBLspmtIsgecGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtIsgecGSTIN.Init
    SetToolBar = TBLspmtIsgecGSTIN
  End Sub
  Protected Sub FVspmtIsgecGSTIN_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtIsgecGSTIN.DataBound
    SIS.SPMT.spmtIsgecGSTIN.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtIsgecGSTIN_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtIsgecGSTIN.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtIsgecGSTIN.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtIsgecGSTIN") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtIsgecGSTIN", mStr)
    End If
    If Request.QueryString("GSTID") IsNot Nothing Then
      CType(FVspmtIsgecGSTIN.FindControl("F_GSTID"), TextBox).Text = Request.QueryString("GSTID")
      CType(FVspmtIsgecGSTIN.FindControl("F_GSTID"), TextBox).Enabled = False
    End If
  End Sub

End Class
