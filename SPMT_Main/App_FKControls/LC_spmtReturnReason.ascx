<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtReturnReason.ascx.vb" Inherits="LC_spmtReturnReason" %>
<asp:DropDownList 
  ID = "DDLspmtReturnReason"
  DataSourceID = "OdsDdlspmtReturnReason"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtReturnReason"
  Runat = "server" 
  ControlToValidate = "DDLspmtReturnReason"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtReturnReason"
  TypeName = "SIS.SPMT.spmtReturnReason"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtReturnReasonSelectList"
  Runat="server" />
