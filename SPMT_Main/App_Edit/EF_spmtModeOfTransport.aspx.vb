Partial Class EF_spmtModeOfTransport
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
  Protected Sub ODSspmtModeOfTransport_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtModeOfTransport.Selected
    Dim tmp As SIS.SPMT.spmtModeOfTransport = CType(e.ReturnValue, SIS.SPMT.spmtModeOfTransport)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtModeOfTransport_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtModeOfTransport.Init
    DataClassName = "EspmtModeOfTransport"
    SetFormView = FVspmtModeOfTransport
  End Sub
  Protected Sub TBLspmtModeOfTransport_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtModeOfTransport.Init
    SetToolBar = TBLspmtModeOfTransport
  End Sub
  Protected Sub FVspmtModeOfTransport_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtModeOfTransport.PreRender
    TBLspmtModeOfTransport.EnableSave = Editable
    TBLspmtModeOfTransport.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtModeOfTransport.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtModeOfTransport") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtModeOfTransport", mStr)
    End If
  End Sub

End Class
