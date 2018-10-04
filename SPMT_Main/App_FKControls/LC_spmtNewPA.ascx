<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtNewPA.ascx.vb" Inherits="LC_spmtNewPA" %>
<asp:DropDownList 
  ID = "DDLspmtNewPA"
  DataSourceID = "OdsDdlspmtNewPA"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtNewPA"
  Runat = "server" 
  ControlToValidate = "DDLspmtNewPA"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtNewPA"
  TypeName = "SIS.SPMT.spmtNewPA"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtNewPASelectList"
  Runat="server" />
