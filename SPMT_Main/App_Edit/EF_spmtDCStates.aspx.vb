Partial Class EF_spmtDCStates
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
  Protected Sub ODSspmtDCStates_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtDCStates.Selected
    Dim tmp As SIS.SPMT.spmtDCStates = CType(e.ReturnValue, SIS.SPMT.spmtDCStates)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtDCStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCStates.Init
    DataClassName = "EspmtDCStates"
    SetFormView = FVspmtDCStates
  End Sub
  Protected Sub TBLspmtDCStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCStates.Init
    SetToolBar = TBLspmtDCStates
  End Sub
  Protected Sub FVspmtDCStates_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCStates.PreRender
    TBLspmtDCStates.EnableSave = Editable
    TBLspmtDCStates.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtDCStates.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCStates") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCStates", mStr)
    End If
  End Sub

End Class
