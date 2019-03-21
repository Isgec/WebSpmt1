<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_SPMTerpDCD.ascx.vb" Inherits="LC_SPMTerpDCD" %>
<asp:DropDownList 
  ID = "DDLSPMTerpDCD"
  DataSourceID = "OdsDdlSPMTerpDCD"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorSPMTerpDCD"
  Runat = "server" 
  ControlToValidate = "DDLSPMTerpDCD"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlSPMTerpDCD"
  TypeName = "SIS.SPMT.SPMTerpDCD"
  SortParameterName = "OrderBy"
  SelectMethod = "SPMTerpDCDSelectList"
  Runat="server" />
