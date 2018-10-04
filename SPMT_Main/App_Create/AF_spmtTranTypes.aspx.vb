Partial Class AF_spmtTranTypes
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtTranTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtTranTypes.Init
    DataClassName = "AspmtTranTypes"
    SetFormView = FVspmtTranTypes
  End Sub
  Protected Sub TBLspmtTranTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtTranTypes.Init
    SetToolBar = TBLspmtTranTypes
  End Sub
  Protected Sub FVspmtTranTypes_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtTranTypes.DataBound
    SIS.SPMT.spmtTranTypes.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtTranTypes_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtTranTypes.PreRender
    Dim oF_GroupID As LC_comGroups = FVspmtTranTypes.FindControl("F_GroupID")
    oF_GroupID.Enabled = True
    oF_GroupID.SelectedValue = String.Empty
    If Not Session("F_GroupID") Is Nothing Then
      If Session("F_GroupID") <> String.Empty Then
        oF_GroupID.SelectedValue = Session("F_GroupID")
      End If
    End If
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtTranTypes.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtTranTypes") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtTranTypes", mStr)
    End If
    If Request.QueryString("TranTypeID") IsNot Nothing Then
      CType(FVspmtTranTypes.FindControl("F_TranTypeID"), TextBox).Text = Request.QueryString("TranTypeID")
      CType(FVspmtTranTypes.FindControl("F_TranTypeID"), TextBox).Enabled = False
    End If
  End Sub

End Class
