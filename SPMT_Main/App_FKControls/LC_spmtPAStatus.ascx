<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtPAStatus.ascx.vb" Inherits="LC_spmtPAStatus" %>
<asp:DropDownList 
  ID = "DDLspmtPAStatus"
  DataSourceID = "OdsDdlspmtPAStatus"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtPAStatus"
  Runat = "server" 
  ControlToValidate = "DDLspmtPAStatus"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtPAStatus"
  TypeName = "SIS.SPMT.spmtPAStatus"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtPAStatusSelectList"
  Runat="server" />
