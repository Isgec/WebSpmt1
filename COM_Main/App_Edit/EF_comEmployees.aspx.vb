Partial Class EF_comEmployees
  Inherits SIS.SYS.UpdateBase

	Protected Sub FormView1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.Init
		DataClassName = "EcomEmployees"
		SetFormView = FormView1
	End Sub
	Protected Sub ToolBar0_1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar0_1.Init
		SetToolBar = ToolBar0_1
	End Sub
End Class
