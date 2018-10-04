<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtDCLastNumber.ascx.vb" Inherits="LC_spmtDCLastNumber" %>
<asp:DropDownList 
  ID = "DDLspmtDCLastNumber"
  DataSourceID = "OdsDdlspmtDCLastNumber"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtDCLastNumber"
  Runat = "server" 
  ControlToValidate = "DDLspmtDCLastNumber"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtDCLastNumber"
  TypeName = "SIS.SPMT.spmtDCLastNumber"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtDCLastNumberSelectList"
  Runat="server" />
