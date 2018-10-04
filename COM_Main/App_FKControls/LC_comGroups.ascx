<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comGroups.ascx.vb" Inherits="LC_comGroups" %>
<asp:DropDownList 
  ID = "DDLcomGroups"
  DataSourceID = "OdsDdlcomGroups"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomGroups"
  Runat = "server" 
  ControlToValidate = "DDLcomGroups"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlcomGroups"
  TypeName = "SIS.COM.comGroups"
  SortParameterName = "OrderBy"
  SelectMethod = "comGroupsSelectList"
  Runat="server" />
