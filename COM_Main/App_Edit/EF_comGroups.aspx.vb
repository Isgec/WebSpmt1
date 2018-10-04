Partial Class EF_comGroups
  Inherits SIS.SYS.UpdateBase
  Public Property Editable() As Boolean
    Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Editable", value)
    End Set
  End Property
  Public Property Deleteable() As Boolean
    Get
      If ViewState("Deleteable") IsNot Nothing Then
        Return CType(ViewState("Deleteable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Deleteable", value)
    End Set
  End Property
  Public Property PrimaryKey() As String
    Get
      If ViewState("PrimaryKey") IsNot Nothing Then
        Return CType(ViewState("PrimaryKey"), String)
      End If
      Return True
    End Get
    Set(ByVal value As String)
      ViewState.Add("PrimaryKey", value)
    End Set
  End Property
  Protected Sub ODScomGroups_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODScomGroups.Selected
    Dim tmp As SIS.COM.comGroups = CType(e.ReturnValue, SIS.COM.comGroups)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVcomGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroups.Init
    DataClassName = "EcomGroups"
    SetFormView = FVcomGroups
  End Sub
  Protected Sub TBLcomGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomGroups.Init
    SetToolBar = TBLcomGroups
  End Sub
  Protected Sub FVcomGroups_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroups.PreRender
    TBLcomGroups.EnableSave = Editable
    TBLcomGroups.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/COM_Main/App_Edit") & "/EF_comGroups.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptcomGroups") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptcomGroups", mStr)
    End If
  End Sub

End Class
