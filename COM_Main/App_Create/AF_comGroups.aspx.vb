Partial Class AF_comGroups
  Inherits SIS.SYS.InsertBase
  Protected Sub FVcomGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroups.Init
    DataClassName = "AcomGroups"
    SetFormView = FVcomGroups
  End Sub
  Protected Sub TBLcomGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomGroups.Init
    SetToolBar = TBLcomGroups
  End Sub
  Protected Sub FVcomGroups_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroups.DataBound
    SIS.COM.comGroups.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVcomGroups_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroups.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/COM_Main/App_Create") & "/AF_comGroups.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptcomGroups") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptcomGroups", mStr)
    End If
    If Request.QueryString("GroupID") IsNot Nothing Then
      CType(FVcomGroups.FindControl("F_GroupID"), TextBox).Text = Request.QueryString("GroupID")
      CType(FVcomGroups.FindControl("F_GroupID"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validatePK_comGroups(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim GroupID As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comGroups = SIS.COM.comGroups.comGroupsGetByID(GroupID)
    If Not oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record allready exists." 
    End If
    Return mRet
  End Function

End Class
