Partial Class EF_spmtPaymentAdviceSupplierBill
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
  Protected Sub ODSspmtPaymentAdviceSupplierBill_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtPaymentAdviceSupplierBill.Selected
    Dim tmp As SIS.SPMT.spmtPaymentAdviceSupplierBill = CType(e.ReturnValue, SIS.SPMT.spmtPaymentAdviceSupplierBill)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtPaymentAdviceSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdviceSupplierBill.Init
    DataClassName = "EspmtPaymentAdviceSupplierBill"
    SetFormView = FVspmtPaymentAdviceSupplierBill
  End Sub
  Protected Sub TBLspmtPaymentAdviceSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPaymentAdviceSupplierBill.Init
    SetToolBar = TBLspmtPaymentAdviceSupplierBill
  End Sub
  Protected Sub FVspmtPaymentAdviceSupplierBill_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdviceSupplierBill.PreRender
    TBLspmtPaymentAdviceSupplierBill.EnableSave = Editable
    TBLspmtPaymentAdviceSupplierBill.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtPaymentAdviceSupplierBill.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtPaymentAdviceSupplierBill") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtPaymentAdviceSupplierBill", mStr)
    End If
  End Sub

End Class
