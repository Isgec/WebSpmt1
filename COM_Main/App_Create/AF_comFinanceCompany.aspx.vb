Partial Class AF_comFinanceCompany
  Inherits SIS.SYS.InsertBase
  Protected Sub FVcomFinanceCompany_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomFinanceCompany.Init
    DataClassName = "AcomFinanceCompany"
    SetFormView = FVcomFinanceCompany
  End Sub
  Protected Sub TBLcomFinanceCompany_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomFinanceCompany.Init
    SetToolBar = TBLcomFinanceCompany
  End Sub
  Protected Sub FVcomFinanceCompany_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomFinanceCompany.DataBound
    SIS.COM.comFinanceCompany.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVcomFinanceCompany_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomFinanceCompany.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/COM_Main/App_Create") & "/AF_comFinanceCompany.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptcomFinanceCompany") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptcomFinanceCompany", mStr)
    End If
    If Request.QueryString("FinanceCompany") IsNot Nothing Then
      CType(FVcomFinanceCompany.FindControl("F_FinanceCompany"), TextBox).Text = Request.QueryString("FinanceCompany")
      CType(FVcomFinanceCompany.FindControl("F_FinanceCompany"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validatePK_comFinanceCompany(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim FinanceCompany As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comFinanceCompany = SIS.COM.comFinanceCompany.comFinanceCompanyGetByID(FinanceCompany)
    If Not oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record allready exists." 
    End If
    Return mRet
  End Function

End Class
