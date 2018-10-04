<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comCompanies.ascx.vb" Inherits="LC_comCompanies" %>
<asp:DropDownList 
  ID = "DDLcomCompanies"
  DataSourceID = "OdsDdlcomCompanies"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomCompanies"
  Runat = "server" 
  ControlToValidate = "DDLcomCompanies"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlcomCompanies"
  TypeName = "SIS.COM.comCompanies"
  SortParameterName = "OrderBy"
  SelectMethod = "comCompaniesSelectList"
  Runat="server" />
