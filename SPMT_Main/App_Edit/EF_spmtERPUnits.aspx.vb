Partial Class EF_spmtERPUnits
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
  Protected Sub ODSspmtERPUnits_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtERPUnits.Selected
    Dim tmp As SIS.SPMT.spmtERPUnits = CType(e.ReturnValue, SIS.SPMT.spmtERPUnits)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtERPUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPUnits.Init
    DataClassName = "EspmtERPUnits"
    SetFormView = FVspmtERPUnits
  End Sub
  Protected Sub TBLspmtERPUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtERPUnits.Init
    SetToolBar = TBLspmtERPUnits
  End Sub
  Protected Sub FVspmtERPUnits_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtERPUnits.PreRender
    TBLspmtERPUnits.EnableSave = Editable
    TBLspmtERPUnits.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtERPUnits.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtERPUnits") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtERPUnits", mStr)
    End If
  End Sub

End Class
