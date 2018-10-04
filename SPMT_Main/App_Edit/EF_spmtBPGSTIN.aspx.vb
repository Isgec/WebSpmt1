Partial Class EF_spmtBPGSTIN
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
  Protected Sub ODSspmtBPGSTIN_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtBPGSTIN.Selected
    Dim tmp As SIS.SPMT.spmtBPGSTIN = CType(e.ReturnValue, SIS.SPMT.spmtBPGSTIN)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBPGSTIN.Init
    DataClassName = "EspmtBPGSTIN"
    SetFormView = FVspmtBPGSTIN
  End Sub
  Protected Sub TBLspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBPGSTIN.Init
    SetToolBar = TBLspmtBPGSTIN
  End Sub
  Protected Sub FVspmtBPGSTIN_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBPGSTIN.PreRender
    TBLspmtBPGSTIN.EnableSave = Editable
    TBLspmtBPGSTIN.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtBPGSTIN.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBPGSTIN") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBPGSTIN", mStr)
    End If
  End Sub

End Class
