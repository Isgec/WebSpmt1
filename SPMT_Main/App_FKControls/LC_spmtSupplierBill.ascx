<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtSupplierBill.ascx.vb" Inherits="LC_spmtSupplierBill" %>
<asp:DropDownList 
  ID = "DDLspmtSupplierBill"
  DataSourceID = "OdsDdlspmtSupplierBill"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtSupplierBill"
  Runat = "server" 
  ControlToValidate = "DDLspmtSupplierBill"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtSupplierBill"
  TypeName = "SIS.SPMT.spmtSupplierBill"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtSupplierBillSelectList"
  Runat="server" />
