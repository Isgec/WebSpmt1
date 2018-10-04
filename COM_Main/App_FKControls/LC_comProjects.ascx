<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comProjects.ascx.vb" Inherits="LC_comProjects" %>
<asp:DropDownList 
  ID = "DDLcomProjects"
  DataSourceID = "OdsDdlcomProjects"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomProjects"
  Runat = "server" 
  ControlToValidate = "DDLcomProjects"
  Text = "Projects is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomProjects"
  runat = "server"
  TargetControlID = "DDLcomProjects"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomProjects"
  TypeName = "SIS.COM.comProjects"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
