<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comOffices.ascx.vb" Inherits="LC_comOffices" %>
<asp:DropDownList 
  ID = "DDLcomOffices"
  DataSourceID = "OdsDdlcomOffices"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomOffices"
  Runat = "server" 
  ControlToValidate = "DDLcomOffices"
  Text = "Office is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomOffices"
  runat = "server"
  TargetControlID = "DDLcomOffices"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomOffices"
  TypeName = "SIS.COM.comOffices"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
