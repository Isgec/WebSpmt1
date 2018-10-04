Partial Class EF_spmtERPStates
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
  Protected Sub ODSspmtERPStates_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtERPStates.Selected
    Dim tmp As SIS.SPMT.spmtERPStates = CType(e.ReturnValue, SIS.SPMT.spmtERPStates)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtERPStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPStates.Init
    DataClassName = "EspmtERPStates"
    SetFormView = FVspmtERPStates
  End Sub
  Protected Sub TBLspmtERPStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtERPStates.Init
    SetToolBar = TBLspmtERPStates
  End Sub
  Protected Sub FVspmtERPStates_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPStates.PreRender
    TBLspmtERPStates.EnableSave = Editable
    TBLspmtERPStates.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtERPStates.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtERPStates") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtERPStates", mStr)
    End If
  End Sub

End Class
