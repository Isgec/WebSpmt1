<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comElements.ascx.vb" Inherits="LC_comElements" %>
<asp:DropDownList 
  ID = "DDLcomElements"
  DataSourceID = "OdsDdlcomElements"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomElements"
  Runat = "server" 
  ControlToValidate = "DDLcomElements"
  Text = "Elements is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomElements"
  runat = "server"
  TargetControlID = "DDLcomElements"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomElements"
  TypeName = "SIS.COM.comElements"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
