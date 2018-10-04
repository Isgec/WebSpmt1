<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtNewSBD.ascx.vb" Inherits="LC_spmtNewSBD" %>
<asp:DropDownList 
  ID = "DDLspmtNewSBD"
  DataSourceID = "OdsDdlspmtNewSBD"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtNewSBD"
  Runat = "server" 
  ControlToValidate = "DDLspmtNewSBD"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtNewSBD"
  TypeName = "SIS.SPMT.spmtNewSBD"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtNewSBDSelectList"
  Runat="server" />
