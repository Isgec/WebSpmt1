Partial Class EF_spmtACProcessed
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
  Protected Sub ODSspmtACProcessed_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtACProcessed.Selected
    Dim tmp As SIS.SPMT.spmtACProcessed = CType(e.ReturnValue, SIS.SPMT.spmtACProcessed)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtACProcessed_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtACProcessed.Init
    DataClassName = "EspmtACProcessed"
    SetFormView = FVspmtACProcessed
  End Sub
  Protected Sub TBLspmtACProcessed_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtACProcessed.Init
    SetToolBar = TBLspmtACProcessed
  End Sub
  Protected Sub FVspmtACProcessed_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtACProcessed.PreRender
    TBLspmtACProcessed.EnableSave = Editable
    TBLspmtACProcessed.EnableDelete = Deleteable
    TBLspmtACProcessed.PrintUrl &= Request.QueryString("AdviceNo") & "|"
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtACProcessed.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtACProcessed") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtACProcessed", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtPaymentAdviceSupplierBillCC As New gvBase
  Protected Sub GVspmtPaymentAdviceSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtPaymentAdviceSupplierBill.Init
    gvspmtPaymentAdviceSupplierBillCC.DataClassName = "GspmtPaymentAdviceSupplierBill"
    gvspmtPaymentAdviceSupplierBillCC.SetGridView = GVspmtPaymentAdviceSupplierBill
  End Sub
  Protected Sub TBLspmtPaymentAdviceSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPaymentAdviceSupplierBill.Init
    gvspmtPaymentAdviceSupplierBillCC.SetToolBar = TBLspmtPaymentAdviceSupplierBill
  End Sub
  Protected Sub GVspmtPaymentAdviceSupplierBill_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtPaymentAdviceSupplierBill.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtPaymentAdviceSupplierBill.DataKeys(e.CommandArgument).Values("IRNo")  
        Dim RedirectUrl As String = TBLspmtPaymentAdviceSupplierBill.EditUrl & "?IRNo=" & IRNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub

End Class
