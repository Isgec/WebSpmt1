<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtBusinessPartner.ascx.vb" Inherits="LC_spmtBusinessPartner" %>
<asp:DropDownList 
  ID = "DDLspmtBusinessPartner"
  DataSourceID = "OdsDdlspmtBusinessPartner"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtBusinessPartner"
  Runat = "server" 
  ControlToValidate = "DDLspmtBusinessPartner"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtBusinessPartner"
  TypeName = "SIS.SPMT.spmtBusinessPartner"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtBusinessPartnerSelectList"
  Runat="server" />
