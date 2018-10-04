Partial Class AF_spmtERPUnits
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtERPUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPUnits.Init
    DataClassName = "AspmtERPUnits"
    SetFormView = FVspmtERPUnits
  End Sub
  Protected Sub TBLspmtERPUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtERPUnits.Init
    SetToolBar = TBLspmtERPUnits
  End Sub
  Protected Sub FVspmtERPUnits_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPUnits.DataBound
    SIS.SPMT.spmtERPUnits.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtERPUnits_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPUnits.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtERPUnits.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtERPUnits") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtERPUnits", mStr)
    End If
    If Request.QueryString("UOM") IsNot Nothing Then
      CType(FVspmtERPUnits.FindControl("F_UOM"), TextBox).Text = Request.QueryString("UOM")
      CType(FVspmtERPUnits.FindControl("F_UOM"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validatePK_spmtERPUnits(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim UOM As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtERPUnits = SIS.SPMT.spmtERPUnits.spmtERPUnitsGetByID(UOM)
    If Not oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record allready exists." 
    End If
    Return mRet
  End Function

End Class
