Partial Class EF_spmtTranTypes
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
  Protected Sub ODSspmtTranTypes_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtTranTypes.Selected
    Dim tmp As SIS.SPMT.spmtTranTypes = CType(e.ReturnValue, SIS.SPMT.spmtTranTypes)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtTranTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtTranTypes.Init
    DataClassName = "EspmtTranTypes"
    SetFormView = FVspmtTranTypes
  End Sub
  Protected Sub TBLspmtTranTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtTranTypes.Init
    SetToolBar = TBLspmtTranTypes
  End Sub
  Protected Sub FVspmtTranTypes_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtTranTypes.PreRender
    TBLspmtTranTypes.EnableSave = Editable
    TBLspmtTranTypes.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtTranTypes.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtTranTypes") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtTranTypes", mStr)
    End If
  End Sub

End Class
