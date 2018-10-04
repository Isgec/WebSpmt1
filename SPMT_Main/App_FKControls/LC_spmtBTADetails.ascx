<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtBTADetails.ascx.vb" Inherits="LC_spmtBTADetails" %>
<asp:DropDownList 
  ID = "DDLspmtBTADetails"
  DataSourceID = "OdsDdlspmtBTADetails"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtBTADetails"
  Runat = "server" 
  ControlToValidate = "DDLspmtBTADetails"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtBTADetails"
  TypeName = "SIS.SPMT.spmtBTADetails"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtBTADetailsSelectList"
  Runat="server" />
