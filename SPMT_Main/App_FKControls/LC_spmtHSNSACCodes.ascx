<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtHSNSACCodes.ascx.vb" Inherits="LC_spmtHSNSACCodes" %>
<asp:DropDownList 
  ID = "DDLspmtHSNSACCodes"
  DataSourceID = "OdsDdlspmtHSNSACCodes"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtHSNSACCodes"
  Runat = "server" 
  ControlToValidate = "DDLspmtHSNSACCodes"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtHSNSACCodes"
  TypeName = "SIS.SPMT.spmtHSNSACCodes"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtHSNSACCodesSelectList"
  Runat="server" />
