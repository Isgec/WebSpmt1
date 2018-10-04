Partial Class EF_spmtCostCenters
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
  Protected Sub ODSspmtCostCenters_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtCostCenters.Selected
    Dim tmp As SIS.SPMT.spmtCostCenters = CType(e.ReturnValue, SIS.SPMT.spmtCostCenters)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtCostCenters_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtCostCenters.Init
    DataClassName = "EspmtCostCenters"
    SetFormView = FVspmtCostCenters
  End Sub
  Protected Sub TBLspmtCostCenters_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtCostCenters.Init
    SetToolBar = TBLspmtCostCenters
  End Sub
  Protected Sub FVspmtCostCenters_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtCostCenters.PreRender
    TBLspmtCostCenters.EnableSave = Editable
    TBLspmtCostCenters.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtCostCenters.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtCostCenters") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtCostCenters", mStr)
    End If
  End Sub

End Class
