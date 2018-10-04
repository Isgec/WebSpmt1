Partial Class EF_spmtBillStatus
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
  Protected Sub ODSspmtBillStatus_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtBillStatus.Selected
    Dim tmp As SIS.SPMT.spmtBillStatus = CType(e.ReturnValue, SIS.SPMT.spmtBillStatus)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtBillStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillStatus.Init
    DataClassName = "EspmtBillStatus"
    SetFormView = FVspmtBillStatus
  End Sub
  Protected Sub TBLspmtBillStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBillStatus.Init
    SetToolBar = TBLspmtBillStatus
  End Sub
  Protected Sub FVspmtBillStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillStatus.PreRender
    TBLspmtBillStatus.EnableSave = Editable
    TBLspmtBillStatus.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtBillStatus.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBillStatus") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBillStatus", mStr)
    End If
  End Sub

End Class
