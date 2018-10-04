Partial Class EF_spmtPAStatus
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
  Protected Sub ODSspmtPAStatus_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtPAStatus.Selected
    Dim tmp As SIS.SPMT.spmtPAStatus = CType(e.ReturnValue, SIS.SPMT.spmtPAStatus)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtPAStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPAStatus.Init
    DataClassName = "EspmtPAStatus"
    SetFormView = FVspmtPAStatus
  End Sub
  Protected Sub TBLspmtPAStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPAStatus.Init
    SetToolBar = TBLspmtPAStatus
  End Sub
  Protected Sub FVspmtPAStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPAStatus.PreRender
    TBLspmtPAStatus.EnableSave = Editable
    TBLspmtPAStatus.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtPAStatus.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtPAStatus") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtPAStatus", mStr)
    End If
  End Sub

End Class
