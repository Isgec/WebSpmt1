Partial Class EF_spmtNewDispSBD
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
  Protected Sub ODSspmtNewDispSBD_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewDispSBD.Selected
    Dim tmp As SIS.SPMT.spmtNewDispSBD = CType(e.ReturnValue, SIS.SPMT.spmtNewDispSBD)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtNewDispSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewDispSBD.Init
    DataClassName = "EspmtNewDispSBD"
    SetFormView = FVspmtNewDispSBD
  End Sub
  Protected Sub TBLspmtNewDispSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewDispSBD.Init
    SetToolBar = TBLspmtNewDispSBD
  End Sub
  Protected Sub FVspmtNewDispSBD_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewDispSBD.PreRender
    TBLspmtNewDispSBD.EnableSave = Editable
    TBLspmtNewDispSBD.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtNewDispSBD.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewDispSBD") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewDispSBD", mStr)
    End If
  End Sub

End Class
