<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtPaymentAdvice.ascx.vb" Inherits="LC_spmtPaymentAdvice" %>
<asp:DropDownList 
  ID = "DDLspmtPaymentAdvice"
  DataSourceID = "OdsDdlspmtPaymentAdvice"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtPaymentAdvice"
  Runat = "server" 
  ControlToValidate = "DDLspmtPaymentAdvice"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtPaymentAdvice"
  TypeName = "SIS.SPMT.spmtPaymentAdvice"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtPaymentAdviceSelectList"
  Runat="server" />
