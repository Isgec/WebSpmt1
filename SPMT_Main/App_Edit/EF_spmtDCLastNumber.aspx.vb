Partial Class EF_spmtDCLastNumber
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
  Protected Sub ODSspmtDCLastNumber_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtDCLastNumber.Selected
    Dim tmp As SIS.SPMT.spmtDCLastNumber = CType(e.ReturnValue, SIS.SPMT.spmtDCLastNumber)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtDCLastNumber_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCLastNumber.Init
    DataClassName = "EspmtDCLastNumber"
    SetFormView = FVspmtDCLastNumber
  End Sub
  Protected Sub TBLspmtDCLastNumber_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCLastNumber.Init
    SetToolBar = TBLspmtDCLastNumber
  End Sub
  Protected Sub FVspmtDCLastNumber_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCLastNumber.PreRender
    TBLspmtDCLastNumber.EnableSave = Editable
    TBLspmtDCLastNumber.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtDCLastNumber.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCLastNumber") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCLastNumber", mStr)
    End If
  End Sub

End Class
