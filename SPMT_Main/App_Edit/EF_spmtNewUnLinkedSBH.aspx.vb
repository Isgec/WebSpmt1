Partial Class EF_spmtNewUnLinkedSBH
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
  Protected Sub ODSspmtNewUnLinkedSBH_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewUnLinkedSBH.Selected
    Dim tmp As SIS.SPMT.spmtNewUnLinkedSBH = CType(e.ReturnValue, SIS.SPMT.spmtNewUnLinkedSBH)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtNewUnLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewUnLinkedSBH.Init
    DataClassName = "EspmtNewUnLinkedSBH"
    SetFormView = FVspmtNewUnLinkedSBH
  End Sub
  Protected Sub TBLspmtNewUnLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewUnLinkedSBH.Init
    SetToolBar = TBLspmtNewUnLinkedSBH
  End Sub
  Protected Sub FVspmtNewUnLinkedSBH_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewUnLinkedSBH.PreRender
    TBLspmtNewUnLinkedSBH.EnableSave = Editable
    TBLspmtNewUnLinkedSBH.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtNewUnLinkedSBH.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewUnLinkedSBH") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewUnLinkedSBH", mStr)
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
