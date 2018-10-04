<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtBillStatus.ascx.vb" Inherits="LC_spmtBillStatus" %>
<asp:DropDownList 
  ID = "DDLspmtBillStatus"
  DataSourceID = "OdsDdlspmtBillStatus"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtBillStatus"
  Runat = "server" 
  ControlToValidate = "DDLspmtBillStatus"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtBillStatus"
  TypeName = "SIS.SPMT.spmtBillStatus"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtBillStatusSelectList"
  Runat="server" />
