<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_spmtAirTicketStatus.ascx.vb" Inherits="LC_spmtAirTicketStatus" %>
<asp:DropDownList 
  ID = "DDLspmtAirTicketStatus"
  DataSourceID = "OdsDdlspmtAirTicketStatus"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorspmtAirTicketStatus"
  Runat = "server" 
  ControlToValidate = "DDLspmtAirTicketStatus"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlspmtAirTicketStatus"
  TypeName = "SIS.SPMT.spmtAirTicketStatus"
  SortParameterName = "OrderBy"
  SelectMethod = "spmtAirTicketStatusSelectList"
  Runat="server" />
