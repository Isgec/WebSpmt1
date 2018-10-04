<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_comEmployees.aspx.vb" Inherits="EF_comEmployees" title="Edit: Employees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="page">
<asp:UpdatePanel ID="UpdatePanel1" runat="server" >
<ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMEdit"
      EnableDelete = "False"
      ValidationGroup = "comEmployees"
      runat = "server" />
    <hr />
<asp:FormView ID="FormView1"
	runat = "server"
	DataKeyNames = "CardNo"
	DataSourceID = "ObjectDataSource1"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <asp:Label ID="LabelcomEmployees" runat="server" Text="Edit Employees" CssClass="sis_formheading"></asp:Label>
    <hr />
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_CardNo" runat="server" ForeColor="#CC6633" Text="Card No :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_CardNo"
						Text='<%# Bind("CardNo") %>'
            ToolTip="Value of Card No."
            Enabled = "False"
						CssClass = "mypktxt"
            Width="56px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_EmployeeName" runat="server" Text="Employee Name :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_EmployeeName"
						Text='<%# Bind("EmployeeName") %>'
            Width="350px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="comEmployees"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Employee Name."
						MaxLength="50"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVEmployeeName"
						runat = "server"
						ControlToValidate = "F_EmployeeName"
						Text = "Employee Name is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "comEmployees"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_C_DateOfJoining" runat="server" Text="Joining Date :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_C_DateOfJoining"
						Text='<%# Bind("C_DateOfJoining") %>'
            Width="70px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="comEmployees"
						runat="server" />
					<asp:Image ID="ImageButtonC_DateOfJoining" runat="server" ToolTip="Click to open calendar" style="cursor: pointer" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEC_DateOfJoining"
            TargetControlID="F_C_DateOfJoining"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonC_DateOfJoining" />
					<AJX:MaskedEditExtender 
						ID = "MEEC_DateOfJoining"
						runat = "server"
						mask = "99/99/9999"
						MaskType="Date"
            CultureName = "en-GB"
						MessageValidatorTip="true"
						InputDirection="LeftToRight"
						ErrorTooltipEnabled="true"
						TargetControlID="F_C_DateOfJoining" />
					<AJX:MaskedEditValidator 
						ID = "MEVC_DateOfJoining"
						runat = "server"
						ControlToValidate = "F_C_DateOfJoining"
						ControlExtender = "MEEC_DateOfJoining"
						InvalidValueMessage = "Invalid value for Joining Date."
						EmptyValueMessage = "Joining Date is required."
						EmptyValueBlurredText = "[Required!]"
						Display = "Dynamic"
						TooltipMessage = "Enter value for Joining Date."
						EnableClientScript = "true"
						ValidationGroup = "comEmployees"
						IsValidEmpty = "false"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_C_OfficeID" runat="server" Text="Location :" /></b>
				</td>
        <td>
          <LGM:LC_comOffices
            ID="F_C_OfficeID"
            SelectedValue='<%# Bind("C_OfficeID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
						ValidationGroup = "comEmployees"
            RequiredFieldErrorMessage = "Location is required."
            Runat="Server" />
          </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_C_DepartmentID" runat="server" Text="Department :" /></b>
				</td>
        <td>
          <LGM:LC_comDepartments
            ID="F_C_DepartmentID"
            SelectedValue='<%# Bind("C_DepartmentID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
						ValidationGroup = "comEmployees"
            RequiredFieldErrorMessage = "Department is required."
            Runat="Server" />
          </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_C_DesignationID" runat="server" Text="Designation :" /></b>
				</td>
        <td>
          <LGM:LC_comDesignations
            ID="F_C_DesignationID"
            SelectedValue='<%# Bind("C_DesignationID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
						ValidationGroup = "comEmployees"
            RequiredFieldErrorMessage = "Designation is required."
            Runat="Server" />
          </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ActiveState" runat="server" Text="Active State :" /></b>
				</td>
				<td>
          <asp:CheckBox ID="F_ActiveState"
					  Checked='<%# Bind("ActiveState") %>'
            runat="server" />
				</td>
			</tr>
		</table>
		<table>
		</table>
	</EditItemTemplate>
</asp:FormView>
</ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ObjectDataSource1"
  DataObjectTypeName = "SIS.COM.comEmployees"
  SelectMethod = "GetByID"
  UpdateMethod="Update"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.COM.comEmployees"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="CardNo" Name="CardNo" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</asp:Content>
