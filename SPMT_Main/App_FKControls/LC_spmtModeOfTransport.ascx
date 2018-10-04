<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtModeOfTransport.ascx.vb" Inherits="LC_spmtModeOfTransport" %>
<asp:DropDownList 
  ID = "DDLspmtModeOfTransport"
  DataSourceID = "OdsDdlspmtModeOfTransport"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtModeOfTransport"
  Runat = "server" 
  ControlToValidate = "DDLspmtModeOfTransport"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtModeOfTransport"
  TypeName = "SIS.SPMT.spmtModeOfTransport"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtModeOfTransportSelectList"
  Runat="server" />
