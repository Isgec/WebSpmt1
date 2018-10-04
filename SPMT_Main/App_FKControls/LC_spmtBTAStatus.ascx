<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtBTAStatus.ascx.vb" Inherits="LC_spmtBTAStatus" %>
<asp:DropDownList 
  ID = "DDLspmtBTAStatus"
  DataSourceID = "OdsDdlspmtBTAStatus"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtBTAStatus"
  Runat = "server" 
  ControlToValidate = "DDLspmtBTAStatus"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtBTAStatus"
  TypeName = "SIS.SPMT.spmtBTAStatus"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtBTAStatusSelectList"
  Runat="server" />
