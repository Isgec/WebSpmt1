<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtDCHeader.ascx.vb" Inherits="LC_spmtDCHeader" %>
<asp:DropDownList 
  ID = "DDLspmtDCHeader"
  DataSourceID = "OdsDdlspmtDCHeader"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtDCHeader"
  Runat = "server" 
  ControlToValidate = "DDLspmtDCHeader"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtDCHeader"
  TypeName = "SIS.SPMT.spmtDCHeader"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtDCHeaderSelectList"
  Runat="server" />
