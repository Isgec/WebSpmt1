Partial Class GF_PAReport
  Inherits SIS.SYS.GridBase

  Private Sub GF_PAReport_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
    cmdDownload.Attributes.Add("data-xid", F_StatusID.LCClientID)
  End Sub

  Private Sub TBLPAReport_Init(sender As Object, e As EventArgs) Handles TBLPAReport.Init
    SetToolBar = TBLPAReport
  End Sub
End Class
