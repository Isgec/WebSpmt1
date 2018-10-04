<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtAirTicket.ascx.vb" Inherits="LC_spmtAirTicket" %>
<asp:DropDownList 
  ID = "DDLspmtAirTicket"
  DataSourceID = "OdsDdlspmtAirTicket"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtAirTicket"
  Runat = "server" 
  ControlToValidate = "DDLspmtAirTicket"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtAirTicket"
  TypeName = "SIS.SPMT.spmtAirTicket"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtAirTicketSelectList"
  Runat="server" />
