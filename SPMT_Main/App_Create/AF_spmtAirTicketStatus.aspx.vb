Partial Class AF_spmtAirTicketStatus
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtAirTicketStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicketStatus.Init
    DataClassName = "AspmtAirTicketStatus"
    SetFormView = FVspmtAirTicketStatus
  End Sub
  Protected Sub TBLspmtAirTicketStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtAirTicketStatus.Init
    SetToolBar = TBLspmtAirTicketStatus
  End Sub
  Protected Sub FVspmtAirTicketStatus_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicketStatus.DataBound
    SIS.SPMT.spmtAirTicketStatus.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVspmtAirTicketStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtAirTicketStatus.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtAirTicketStatus.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtAirTicketStatus") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtAirTicketStatus", mStr)
    End If
    If Request.QueryString("StatusID") IsNot Nothing Then
      CType(FVspmtAirTicketStatus.FindControl("F_StatusID"), TextBox).Text = Request.QueryString("StatusID")
      CType(FVspmtAirTicketStatus.FindControl("F_StatusID"), TextBox).Enabled = False
    End If
  End Sub

End Class
