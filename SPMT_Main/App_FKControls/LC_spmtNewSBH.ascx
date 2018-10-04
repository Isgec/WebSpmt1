<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtNewSBH.ascx.vb" Inherits="LC_spmtNewSBH" %>
<asp:DropDownList 
  ID = "DDLspmtNewSBH"
  DataSourceID = "OdsDdlspmtNewSBH"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtNewSBH"
  Runat = "server" 
  ControlToValidate = "DDLspmtNewSBH"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtNewSBH"
  TypeName = "SIS.SPMT.spmtNewSBH"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtNewSBHSelectList"
  Runat="server" />
