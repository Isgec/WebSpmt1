<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comDepartments.ascx.vb" Inherits="LC_comDepartments" %>
<asp:DropDownList 
  ID = "DDLcomDepartments"
  DataSourceID = "OdsDdlcomDepartments"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomDepartments"
  Runat = "server" 
  ControlToValidate = "DDLcomDepartments"
  Text = "Departments is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomDepartments"
  runat = "server"
  TargetControlID = "DDLcomDepartments"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomDepartments"
  TypeName = "SIS.COM.comDepartments"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
