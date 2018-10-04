Partial Class EF_spmtHSNSACCodes
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
  Protected Sub ODSspmtHSNSACCodes_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtHSNSACCodes.Selected
    Dim tmp As SIS.SPMT.spmtHSNSACCodes = CType(e.ReturnValue, SIS.SPMT.spmtHSNSACCodes)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtHSNSACCodes.Init
    DataClassName = "EspmtHSNSACCodes"
    SetFormView = FVspmtHSNSACCodes
  End Sub
  Protected Sub TBLspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtHSNSACCodes.Init
    SetToolBar = TBLspmtHSNSACCodes
  End Sub
  Protected Sub FVspmtHSNSACCodes_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtHSNSACCodes.PreRender
    TBLspmtHSNSACCodes.EnableSave = Editable
    TBLspmtHSNSACCodes.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtHSNSACCodes.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtHSNSACCodes") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtHSNSACCodes", mStr)
    End If
  End Sub

End Class
