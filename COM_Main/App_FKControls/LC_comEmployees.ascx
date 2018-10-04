<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comEmployees.ascx.vb" Inherits="LC_comEmployees" %>
<asp:DropDownList 
  ID = "DDLcomEmployees"
  DataSourceID = "OdsDdlcomEmployees"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomEmployees"
  Runat = "server" 
  ControlToValidate = "DDLcomEmployees"
  Text = "Employees is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomEmployees"
  runat = "server"
  TargetControlID = "DDLcomEmployees"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomEmployees"
  TypeName = "SIS.COM.comEmployees"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
