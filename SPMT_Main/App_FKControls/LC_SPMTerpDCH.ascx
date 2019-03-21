<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_SPMTerpDCH.ascx.vb" Inherits="LC_SPMTerpDCH" %>
<asp:DropDownList 
  ID = "DDLSPMTerpDCH"
  DataSourceID = "OdsDdlSPMTerpDCH"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorSPMTerpDCH"
  Runat = "server" 
  ControlToValidate = "DDLSPMTerpDCH"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlSPMTerpDCH"
  TypeName = "SIS.SPMT.SPMTerpDCH"
  SortParameterName = "OrderBy"
  SelectMethod = "SPMTerpDCHSelectList"
  Runat="server" />
