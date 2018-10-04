Partial Class EF_spmtAirTicketStatus
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
  Protected Sub ODSspmtAirTicketStatus_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtAirTicketStatus.Selected
    Dim tmp As SIS.SPMT.spmtAirTicketStatus = CType(e.ReturnValue, SIS.SPMT.spmtAirTicketStatus)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtAirTicketStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicketStatus.Init
    DataClassName = "EspmtAirTicketStatus"
    SetFormView = FVspmtAirTicketStatus
  End Sub
  Protected Sub TBLspmtAirTicketStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtAirTicketStatus.Init
    SetToolBar = TBLspmtAirTicketStatus
  End Sub
  Protected Sub FVspmtAirTicketStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicketStatus.PreRender
    TBLspmtAirTicketStatus.EnableSave = Editable
    TBLspmtAirTicketStatus.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtAirTicketStatus.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtAirTicketStatus") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtAirTicketStatus", mStr)
    End If
  End Sub

End Class
