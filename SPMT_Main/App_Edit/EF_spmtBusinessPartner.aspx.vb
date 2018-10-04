Partial Class EF_spmtBusinessPartner
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
  Protected Sub ODSspmtBusinessPartner_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtBusinessPartner.Selected
    Dim tmp As SIS.SPMT.spmtBusinessPartner = CType(e.ReturnValue, SIS.SPMT.spmtBusinessPartner)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtBusinessPartner_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBusinessPartner.Init
    DataClassName = "EspmtBusinessPartner"
    SetFormView = FVspmtBusinessPartner
  End Sub
  Protected Sub TBLspmtBusinessPartner_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBusinessPartner.Init
    SetToolBar = TBLspmtBusinessPartner
  End Sub
  Protected Sub FVspmtBusinessPartner_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtBusinessPartner.PreRender
    TBLspmtBusinessPartner.EnableSave = Editable
    TBLspmtBusinessPartner.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtBusinessPartner.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtBusinessPartner") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtBusinessPartner", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtBPGSTINCC As New gvBase
  Protected Sub GVspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtBPGSTIN.Init
    gvspmtBPGSTINCC.DataClassName = "GspmtBPGSTIN"
    gvspmtBPGSTINCC.SetGridView = GVspmtBPGSTIN
  End Sub
  Protected Sub TBLspmtBPGSTIN_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtBPGSTIN.Init
    gvspmtBPGSTINCC.SetToolBar = TBLspmtBPGSTIN
  End Sub
  Protected Sub GVspmtBPGSTIN_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtBPGSTIN.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim BPID As String = GVspmtBPGSTIN.DataKeys(e.CommandArgument).Values("BPID")  
        Dim GSTIN As Int32 = GVspmtBPGSTIN.DataKeys(e.CommandArgument).Values("GSTIN")  
        Dim RedirectUrl As String = TBLspmtBPGSTIN.EditUrl & "?BPID=" & BPID & "&GSTIN=" & GSTIN
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub TBLspmtBPGSTIN_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLspmtBPGSTIN.AddClicked
    Dim BPID As String = CType(FVspmtBusinessPartner.FindControl("F_BPID"),TextBox).Text
    TBLspmtBPGSTIN.AddUrl &= "?BPID=" & BPID
  End Sub

End Class
