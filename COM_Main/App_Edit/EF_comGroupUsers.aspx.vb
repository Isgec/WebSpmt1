Partial Class EF_comGroupUsers
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
  Protected Sub ODScomGroupUsers_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODScomGroupUsers.Selected
    Dim tmp As SIS.COM.comGroupUsers = CType(e.ReturnValue, SIS.COM.comGroupUsers)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVcomGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroupUsers.Init
    DataClassName = "EcomGroupUsers"
    SetFormView = FVcomGroupUsers
  End Sub
  Protected Sub TBLcomGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLcomGroupUsers.Init
    SetToolBar = TBLcomGroupUsers
  End Sub
  Protected Sub FVcomGroupUsers_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVcomGroupUsers.PreRender
    TBLcomGroupUsers.EnableSave = Editable
    TBLcomGroupUsers.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/COM_Main/App_Edit") & "/EF_comGroupUsers.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptcomGroupUsers") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptcomGroupUsers", mStr)
    End If
  End Sub

End Class
