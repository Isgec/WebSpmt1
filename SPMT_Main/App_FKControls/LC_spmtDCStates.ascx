<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtDCStates.ascx.vb" Inherits="LC_spmtDCStates" %>
<asp:DropDownList 
  ID = "DDLspmtDCStates"
  DataSourceID = "OdsDdlspmtDCStates"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtDCStates"
  Runat = "server" 
  ControlToValidate = "DDLspmtDCStates"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtDCStates"
  TypeName = "SIS.SPMT.spmtDCStates"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtDCStatesSelectList"
  Runat="server" />
