Partial Class EF_spmtBillTypes
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
  Protected Sub ODSspmtBillTypes_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtBillTypes.Selected
    Dim tmp As SIS.SPMT.spmtBillTypes = CType(e.ReturnValue, SIS.SPMT.spmtBillTypes)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtBillTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillTypes.Init
    DataClassName = "EspmtBillTypes"
    SetFormView = FVspmtBillTypes
  End Sub
  Protected Sub TBLspmtBillTypes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBillTypes.Init
    SetToolBar = TBLspmtBillTypes
  End Sub
  Protected Sub FVspmtBillTypes_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBillTypes.PreRender
    TBLspmtBillTypes.EnableSave = Editable
    TBLspmtBillTypes.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtBillTypes.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBillTypes") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBillTypes", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtHSNSACCodesCC As New gvBase
  Protected Sub GVspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtHSNSACCodes.Init
    gvspmtHSNSACCodesCC.DataClassName = "GspmtHSNSACCodes"
    gvspmtHSNSACCodesCC.SetGridView = GVspmtHSNSACCodes
  End Sub
  Protected Sub TBLspmtHSNSACCodes_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtHSNSACCodes.Init
    gvspmtHSNSACCodesCC.SetToolBar = TBLspmtHSNSACCodes
  End Sub
  Protected Sub GVspmtHSNSACCodes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtHSNSACCodes.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BillType As Int32 = GVspmtHSNSACCodes.DataKeys(e.CommandArgument).Values("BillType")  
        Dim HSNSACCode As String = GVspmtHSNSACCodes.DataKeys(e.CommandArgument).Values("HSNSACCode")  
        Dim RedirectUrl As String = TBLspmtHSNSACCodes.EditUrl & "?BillType=" & BillType & "&HSNSACCode=" & HSNSACCode
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub TBLspmtHSNSACCodes_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLspmtHSNSACCodes.AddClicked
    Dim BillType As Int32 = CType(FVspmtBillTypes.FindControl("F_BillType"),TextBox).Text
    TBLspmtHSNSACCodes.AddUrl &= "?BillType=" & BillType
  End Sub

End Class
