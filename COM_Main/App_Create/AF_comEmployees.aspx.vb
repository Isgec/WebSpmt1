Partial Class AF_comEmployees
	Inherits SIS.SYS.InsertBase

	Protected Sub FormView1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.Init
		DataClassName = "AcomEmployees"
		SetFormView = FormView1
	End Sub
	Protected Sub FormView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.PreRender
		Dim oF_C_OfficeID As LC_comOffices = FormView1.FindControl("F_C_OfficeID")
		oF_C_OfficeID.Enabled = True
		oF_C_OfficeID.SelectedValue = String.Empty
		If Not Session("F_C_OfficeID") Is Nothing Then
			If Session("F_C_OfficeID") <> String.Empty Then
				oF_C_OfficeID.SelectedValue = Session("F_C_OfficeID")
			End If
		End If
		Dim oF_C_DepartmentID As LC_comDepartments = FormView1.FindControl("F_C_DepartmentID")
		oF_C_DepartmentID.Enabled = True
		oF_C_DepartmentID.SelectedValue = String.Empty
		If Not Session("F_C_DepartmentID") Is Nothing Then
			If Session("F_C_DepartmentID") <> String.Empty Then
				oF_C_DepartmentID.SelectedValue = Session("F_C_DepartmentID")
			End If
		End If
		Dim oF_C_DesignationID As LC_comDesignations = FormView1.FindControl("F_C_DesignationID")
		oF_C_DesignationID.Enabled = True
		oF_C_DesignationID.SelectedValue = String.Empty
		If Not Session("F_C_DesignationID") Is Nothing Then
			If Session("F_C_DesignationID") <> String.Empty Then
				oF_C_DesignationID.SelectedValue = Session("F_C_DesignationID")
			End If
		End If
	End Sub

	Protected Sub ToolBar0_1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar0_1.Init
		SetToolBar = ToolBar0_1
	End Sub
End Class
