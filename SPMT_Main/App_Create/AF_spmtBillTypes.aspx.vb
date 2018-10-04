Partial Class AF_spmtBillTypes
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtBillTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillTypes.Init
    DataClassName = "AspmtBillTypes"
    SetFormView = FVspmtBillTypes
  End Sub
  Protected Sub TBLspmtBillTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBillTypes.Init
    SetToolBar = TBLspmtBillTypes
  End Sub
  Protected Sub ODSspmtBillTypes_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtBillTypes.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.spmtBillTypes = CType(e.ReturnValue,SIS.SPMT.spmtBillTypes)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&BillType=" & oDC.BillType
      TBLspmtBillTypes.AfterInsertURL &= tmpURL 
    End If
  End Sub
  Protected Sub FVspmtBillTypes_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillTypes.DataBound
    SIS.SPMT.spmtBillTypes.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtBillTypes_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillTypes.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtBillTypes.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBillTypes") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBillTypes", mStr)
    End If
    If Request.QueryString("BillType") IsNot Nothing Then
      CType(FVspmtBillTypes.FindControl("F_BillType"), TextBox).Text = Request.QueryString("BillType")
      CType(FVspmtBillTypes.FindControl("F_BillType"), TextBox).Enabled = False
    End If
  End Sub

End Class
