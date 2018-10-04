<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comUsers.ascx.vb" Inherits="LC_comUsers" %>
<asp:DropDownList 
  ID = "DDLcomUsers"
  DataSourceID = "OdsDdlcomUsers"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomUsers"
  Runat = "server" 
  ControlToValidate = "DDLcomUsers"
  Text = "User is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomUsers"
  runat = "server"
  TargetControlID = "DDLcomUsers"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomUsers"
  TypeName = "SIS.COM.comUsers"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
