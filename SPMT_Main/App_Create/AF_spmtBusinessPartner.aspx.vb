Partial Class AF_spmtBusinessPartner
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtBusinessPartner_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBusinessPartner.Init
    DataClassName = "AspmtBusinessPartner"
    SetFormView = FVspmtBusinessPartner
  End Sub
  Protected Sub TBLspmtBusinessPartner_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBusinessPartner.Init
    SetToolBar = TBLspmtBusinessPartner
  End Sub
  Protected Sub ODSspmtBusinessPartner_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtBusinessPartner.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.spmtBusinessPartner = CType(e.ReturnValue,SIS.SPMT.spmtBusinessPartner)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&BPID=" & oDC.BPID
      TBLspmtBusinessPartner.AfterInsertURL &= tmpURL 
    End If
  End Sub
  Protected Sub FVspmtBusinessPartner_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBusinessPartner.DataBound
    SIS.SPMT.spmtBusinessPartner.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtBusinessPartner_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBusinessPartner.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtBusinessPartner.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBusinessPartner") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBusinessPartner", mStr)
    End If
    If Request.QueryString("BPID") IsNot Nothing Then
      CType(FVspmtBusinessPartner.FindControl("F_BPID"), TextBox).Text = Request.QueryString("BPID")
      CType(FVspmtBusinessPartner.FindControl("F_BPID"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validatePK_spmtBusinessPartner(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If Not oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record allready exists." 
    End If
    Return mRet
  End Function

End Class
