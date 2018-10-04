<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comDesignations.ascx.vb" Inherits="LC_comDesignations" %>
<asp:DropDownList 
  ID = "DDLcomDesignations"
  DataSourceID = "OdsDdlcomDesignations"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomDesignations"
  Runat = "server" 
  ControlToValidate = "DDLcomDesignations"
  Text = "Designations is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEcomDesignations"
  runat = "server"
  TargetControlID = "DDLcomDesignations"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlcomDesignations"
  TypeName = "SIS.COM.comDesignations"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
