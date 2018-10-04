<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtBPGSTIN.ascx.vb" Inherits="LC_spmtBPGSTIN" %>
<asp:DropDownList 
  ID = "DDLspmtBPGSTIN"
  DataSourceID = "OdsDdlspmtBPGSTIN"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtBPGSTIN"
  Runat = "server" 
  ControlToValidate = "DDLspmtBPGSTIN"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtBPGSTIN"
  TypeName = "SIS.SPMT.spmtBPGSTIN"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtBPGSTINSelectList"
  Runat="server" />
