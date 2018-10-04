Partial Class EF_spmtNewLinkedSBH
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
  Protected Sub ODSspmtNewLinkedSBH_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewLinkedSBH.Selected
    Dim tmp As SIS.SPMT.spmtNewLinkedSBH = CType(e.ReturnValue, SIS.SPMT.spmtNewLinkedSBH)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtNewLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewLinkedSBH.Init
    DataClassName = "EspmtNewLinkedSBH"
    SetFormView = FVspmtNewLinkedSBH
  End Sub
  Protected Sub TBLspmtNewLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewLinkedSBH.Init
    SetToolBar = TBLspmtNewLinkedSBH
  End Sub
  Protected Sub FVspmtNewLinkedSBH_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewLinkedSBH.PreRender
    TBLspmtNewLinkedSBH.EnableSave = Editable
    TBLspmtNewLinkedSBH.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtNewLinkedSBH.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewLinkedSBH") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewLinkedSBH", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtNewDispSBDCC As New gvBase
  Protected Sub GVspmtNewDispSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtNewDispSBD.Init
    gvspmtNewDispSBDCC.DataClassName = "GspmtNewDispSBD"
    gvspmtNewDispSBDCC.SetGridView = GVspmtNewDispSBD
  End Sub
  Protected Sub TBLspmtNewDispSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewDispSBD.Init
    gvspmtNewDispSBDCC.SetToolBar = TBLspmtNewDispSBD
  End Sub
  Protected Sub GVspmtNewDispSBD_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtNewDispSBD.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewDispSBD.DataKeys(e.CommandArgument).Values("IRNo")  
        Dim SerialNo As Int32 = GVspmtNewDispSBD.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim RedirectUrl As String = TBLspmtNewDispSBD.EditUrl & "?IRNo=" & IRNo & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub

End Class
