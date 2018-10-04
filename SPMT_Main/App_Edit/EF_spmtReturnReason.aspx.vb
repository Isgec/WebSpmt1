Partial Class EF_spmtReturnReason
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
  Protected Sub ODSspmtReturnReason_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtReturnReason.Selected
    Dim tmp As SIS.SPMT.spmtReturnReason = CType(e.ReturnValue, SIS.SPMT.spmtReturnReason)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtReturnReason_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtReturnReason.Init
    DataClassName = "EspmtReturnReason"
    SetFormView = FVspmtReturnReason
  End Sub
  Protected Sub TBLspmtReturnReason_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtReturnReason.Init
    SetToolBar = TBLspmtReturnReason
  End Sub
  Protected Sub FVspmtReturnReason_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtReturnReason.PreRender
    TBLspmtReturnReason.EnableSave = Editable
    TBLspmtReturnReason.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtReturnReason.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtReturnReason") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtReturnReason", mStr)
    End If
  End Sub

End Class
