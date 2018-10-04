<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtAirTicket.aspx.vb" Inherits="EF_spmtAirTicket" title="Edit: Services" %>
<asp:Content ID="CPHspmtAirTicket" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtAirTicket" runat="server" Text="&nbsp;Edit: Services"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtAirTicket" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtAirTicket"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtAirTicket"
    runat = "server" />
<asp:FormView ID="FVspmtAirTicket"
  runat = "server"
  DataKeyNames = "SerialNo"
  DataSourceID = "ODSspmtAirTicket"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" runat="server" ForeColor="#CC6633" Text="Serial No :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_SerialNo"
            Text='<%# Bind("SerialNo") %>'
            ToolTip="Value of Serial No."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtTranTypes
            ID="F_TranTypeID"
            SelectedValue='<%# Bind("TranTypeID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtAirTicket"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsIsgecGSTIN" runat="server" Text="Agents Isgec GSTIN :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtIsgecGSTIN
            ID="F_AgentsIsgecGSTIN"
            SelectedValue='<%# Bind("AgentsIsgecGSTIN") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtAirTicket"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsStateID" runat="server" Text="Agents State :" />&nbsp;
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_AgentsStateID"
            SelectedValue='<%# Bind("AgentsStateID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsBillNumber" runat="server" Text="Agents Bill Number :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsBillNumber"
            Text='<%# Bind("AgentsBillNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agents Bill Number."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgentsBillNumber"
            runat = "server"
            ControlToValidate = "F_AgentsBillNumber"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsBillDate" runat="server" Text="Agents Bill Date :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsBillDate"
            Text='<%# Bind("AgentsBillDate") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            runat="server" />
          <asp:Image ID="ImageButtonAgentsBillDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEAgentsBillDate"
            TargetControlID="F_AgentsBillDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonAgentsBillDate" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsBillDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsBillDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsBillDate"
            runat = "server"
            ControlToValidate = "F_AgentsBillDate"
            ControlExtender = "MEEAgentsBillDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsItemName" runat="server" Text="Agents Item Name :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgentsItemName"
            Text='<%# Bind("AgentsItemName") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agents Item Name."
            MaxLength="50"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsBPID" runat="server" Text="Agents BP ID :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgentsBPID"
            CssClass = "myfktxt"
            Text='<%# Bind("AgentsBPID") %>'
            AutoCompleteType = "None"
            Width="80px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Agents BP ID."
            ValidationGroup = "spmtAirTicket"
            onblur= "script_spmtAirTicket.validate_AgentsBPID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgentsBPID"
            runat = "server"
            ControlToValidate = "F_AgentsBPID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_AgentsBPID_Display"
            Text='<%# Eval("VR_BusinessPartner16_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgentsBPID"
            BehaviorID="B_ACEAgentsBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgentsBPIDCompletionList"
            TargetControlID="F_AgentsBPID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEAgentsBPID_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEAgentsBPID_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEAgentsBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsGSTIN" runat="server" Text="Agents GSTIN :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgentsGSTIN"
            CssClass = "myfktxt"
            Text='<%# Bind("AgentsGSTIN") %>'
            AutoCompleteType = "None"
            Width="88px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Agents GSTIN."
            ValidationGroup = "spmtAirTicket"
            onblur= "script_spmtAirTicket.validate_AgentsGSTIN(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgentsGSTIN"
            runat = "server"
            ControlToValidate = "F_AgentsGSTIN"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_AgentsGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN14_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgentsGSTIN"
            BehaviorID="B_ACEAgentsGSTIN"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgentsGSTINCompletionList"
            TargetControlID="F_AgentsGSTIN"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEAgentsGSTIN_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEAgentsGSTIN_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEAgentsGSTIN_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsName" runat="server" Text="Agents Name :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsName"
            Text='<%# Bind("AgentsName") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agents Name."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgentsName"
            runat = "server"
            ControlToValidate = "F_AgentsName"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsGSTINNumber" runat="server" Text="Agents GSTIN Number :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsGSTINNumber"
            Text='<%# Bind("AgentsGSTINNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agents GSTIN Number."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgentsGSTINNumber"
            runat = "server"
            ControlToValidate = "F_AgentsGSTINNumber"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsBillType" runat="server" Text="Agents Bill Type :" />&nbsp;
        </td>
        <td>
          <LGM:LC_spmtBillTypes
            ID="F_AgentsBillType"
            SelectedValue='<%# Bind("AgentsBillType") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsHSNSACCode" runat="server" Text="Agents HSN / SAC Code :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgentsHSNSACCode"
            CssClass = "myfktxt"
            Text='<%# Bind("AgentsHSNSACCode") %>'
            AutoCompleteType = "None"
            Width="168px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Agents HSN / SAC Code."
            onblur= "script_spmtAirTicket.validate_AgentsHSNSACCode(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_AgentsHSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes8_HSNSACCode") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgentsHSNSACCode"
            BehaviorID="B_ACEAgentsHSNSACCode"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgentsHSNSACCodeCompletionList"
            TargetControlID="F_AgentsHSNSACCode"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEAgentsHSNSACCode_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEAgentsHSNSACCode_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEAgentsHSNSACCode_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsBasicValue" runat="server" Text="Agents Basic / Assessable Value :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsBasicValue"
            Text='<%# Bind("AgentsBasicValue") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsBasicValue"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsBasicValue" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsBasicValue"
            runat = "server"
            ControlToValidate = "F_AgentsBasicValue"
            ControlExtender = "MEEAgentsBasicValue"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsIGSTRate" runat="server" Text="Agents IGST Rate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsIGSTRate"
            Text='<%# Bind("AgentsIGSTRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsIGSTRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsIGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsIGSTRate"
            runat = "server"
            ControlToValidate = "F_AgentsIGSTRate"
            ControlExtender = "MEEAgentsIGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsIGSTAmount" runat="server" Text="Agents IGST Amount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsIGSTAmount"
            Text='<%# Bind("AgentsIGSTAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsIGSTAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsIGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsIGSTAmount"
            runat = "server"
            ControlToValidate = "F_AgentsIGSTAmount"
            ControlExtender = "MEEAgentsIGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsSGSTRate" runat="server" Text="Agents SGST Rate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsSGSTRate"
            Text='<%# Bind("AgentsSGSTRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsSGSTRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsSGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsSGSTRate"
            runat = "server"
            ControlToValidate = "F_AgentsSGSTRate"
            ControlExtender = "MEEAgentsSGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsSGSTAmount" runat="server" Text="Agents SGST Amount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsSGSTAmount"
            Text='<%# Bind("AgentsSGSTAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsSGSTAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsSGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsSGSTAmount"
            runat = "server"
            ControlToValidate = "F_AgentsSGSTAmount"
            ControlExtender = "MEEAgentsSGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsCGSTRate" runat="server" Text="Agents CGST Rate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsCGSTRate"
            Text='<%# Bind("AgentsCGSTRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsCGSTRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsCGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsCGSTRate"
            runat = "server"
            ControlToValidate = "F_AgentsCGSTRate"
            ControlExtender = "MEEAgentsCGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsCGSTAmount" runat="server" Text="Agents CGST Amount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgentsCGSTAmount"
            Text='<%# Bind("AgentsCGSTAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsCGSTAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsCGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsCGSTAmount"
            runat = "server"
            ControlToValidate = "F_AgentsCGSTAmount"
            ControlExtender = "MEEAgentsCGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsCessRate" runat="server" Text="Agents Cess Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgentsCessRate"
            Text='<%# Bind("AgentsCessRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsCessRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsCessRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsCessRate"
            runat = "server"
            ControlToValidate = "F_AgentsCessRate"
            ControlExtender = "MEEAgentsCessRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsCessAmount" runat="server" Text="Agents Cess Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgentsCessAmount"
            Text='<%# Bind("AgentsCessAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgentsCessAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgentsCessAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgentsCessAmount"
            runat = "server"
            ControlToValidate = "F_AgentsCessAmount"
            ControlExtender = "MEEAgentsCessAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsTotalGST" runat="server" Text="Agents Total GST :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgentsTotalGST"
            Text='<%# Bind("AgentsTotalGST") %>'
            ToolTip="Value of Agents Total GST."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsTotalAmount" runat="server" Text="Agents Total Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgentsTotalAmount"
            Text='<%# Bind("AgentsTotalAmount") %>'
            ToolTip="Value of Agents Total Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgentsRCMApplicable" runat="server" Text="Agents RCM Applicable :" />&nbsp;
        </td>
        <td>
          <asp:CheckBox ID="F_AgentsRCMApplicable"
            Checked='<%# Bind("AgentsRCMApplicable") %>'
            CssClass = "mychk"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyIsgecGSTIN" runat="server" Text="Agency Isgec GSTIN :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtIsgecGSTIN
            ID="F_AgencyIsgecGSTIN"
            SelectedValue='<%# Bind("AgencyIsgecGSTIN") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtAirTicket"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyStateID" runat="server" Text="Agency State :" />&nbsp;
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_AgencyStateID"
            SelectedValue='<%# Bind("AgencyStateID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyBillNumber" runat="server" Text="Agency Bill Number :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyBillNumber"
            Text='<%# Bind("AgencyBillNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agency Bill Number."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyBillNumber"
            runat = "server"
            ControlToValidate = "F_AgencyBillNumber"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyBillDate" runat="server" Text="Agency Bill Date :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyBillDate"
            Text='<%# Bind("AgencyBillDate") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            runat="server" />
          <asp:Image ID="ImageButtonAgencyBillDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEAgencyBillDate"
            TargetControlID="F_AgencyBillDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonAgencyBillDate" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyBillDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyBillDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyBillDate"
            runat = "server"
            ControlToValidate = "F_AgencyBillDate"
            ControlExtender = "MEEAgencyBillDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyItemName" runat="server" Text="Agency Item Name :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyItemName"
            Text='<%# Bind("AgencyItemName") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agency Item Name."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyItemName"
            runat = "server"
            ControlToValidate = "F_AgencyItemName"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyBPID" runat="server" Text="Agency BPID :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgencyBPID"
            CssClass = "myfktxt"
            Text='<%# Bind("AgencyBPID") %>'
            AutoCompleteType = "None"
            Width="80px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Agency BPID."
            ValidationGroup = "spmtAirTicket"
            onblur= "script_spmtAirTicket.validate_AgencyBPID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyBPID"
            runat = "server"
            ControlToValidate = "F_AgencyBPID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_AgencyBPID_Display"
            Text='<%# Eval("VR_BusinessPartner15_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgencyBPID"
            BehaviorID="B_ACEAgencyBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgencyBPIDCompletionList"
            TargetControlID="F_AgencyBPID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEAgencyBPID_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEAgencyBPID_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEAgencyBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyGSTIN" runat="server" Text="Agency GSTIN :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgencyGSTIN"
            CssClass = "myfktxt"
            Text='<%# Bind("AgencyGSTIN") %>'
            AutoCompleteType = "None"
            Width="88px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Agency GSTIN."
            ValidationGroup = "spmtAirTicket"
            onblur= "script_spmtAirTicket.validate_AgencyGSTIN(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyGSTIN"
            runat = "server"
            ControlToValidate = "F_AgencyGSTIN"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_AgencyGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN13_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgencyGSTIN"
            BehaviorID="B_ACEAgencyGSTIN"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgencyGSTINCompletionList"
            TargetControlID="F_AgencyGSTIN"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEAgencyGSTIN_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEAgencyGSTIN_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEAgencyGSTIN_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyName" runat="server" Text="Agency Name :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyName"
            Text='<%# Bind("AgencyName") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agency Name."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyName"
            runat = "server"
            ControlToValidate = "F_AgencyName"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyGSTINNumber" runat="server" Text="Agency GSTIN Number :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyGSTINNumber"
            Text='<%# Bind("AgencyGSTINNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicket"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Agency GSTIN Number."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyGSTINNumber"
            runat = "server"
            ControlToValidate = "F_AgencyGSTINNumber"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyBillType" runat="server" Text="Agency Bill Type :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtBillTypes
            ID="F_AgencyBillType"
            SelectedValue='<%# Bind("AgencyBillType") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtAirTicket"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyHSNSACCode" runat="server" Text="Agency HSN / SAC Code :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgencyHSNSACCode"
            CssClass = "myfktxt"
            Text='<%# Bind("AgencyHSNSACCode") %>'
            AutoCompleteType = "None"
            Width="168px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Agency HSN / SAC Code."
            ValidationGroup = "spmtAirTicket"
            onblur= "script_spmtAirTicket.validate_AgencyHSNSACCode(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVAgencyHSNSACCode"
            runat = "server"
            ControlToValidate = "F_AgencyHSNSACCode"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_AgencyHSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes7_HSNSACCode") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgencyHSNSACCode"
            BehaviorID="B_ACEAgencyHSNSACCode"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgencyHSNSACCodeCompletionList"
            TargetControlID="F_AgencyHSNSACCode"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEAgencyHSNSACCode_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEAgencyHSNSACCode_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEAgencyHSNSACCode_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyBasicValue" runat="server" Text="Agency Basic / Assessable Value :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyBasicValue"
            Text='<%# Bind("AgencyBasicValue") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyBasicValue"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyBasicValue" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyBasicValue"
            runat = "server"
            ControlToValidate = "F_AgencyBasicValue"
            ControlExtender = "MEEAgencyBasicValue"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyIGSTRate" runat="server" Text="Agency IGST Rate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyIGSTRate"
            Text='<%# Bind("AgencyIGSTRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyIGSTRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyIGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyIGSTRate"
            runat = "server"
            ControlToValidate = "F_AgencyIGSTRate"
            ControlExtender = "MEEAgencyIGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyIGSTAmount" runat="server" Text="Agency IGST Amount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyIGSTAmount"
            Text='<%# Bind("AgencyIGSTAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyIGSTAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyIGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyIGSTAmount"
            runat = "server"
            ControlToValidate = "F_AgencyIGSTAmount"
            ControlExtender = "MEEAgencyIGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencySGSTRate" runat="server" Text="Agency SGST Rate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencySGSTRate"
            Text='<%# Bind("AgencySGSTRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencySGSTRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencySGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencySGSTRate"
            runat = "server"
            ControlToValidate = "F_AgencySGSTRate"
            ControlExtender = "MEEAgencySGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencySGSTAmount" runat="server" Text="Agency SGST Amount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencySGSTAmount"
            Text='<%# Bind("AgencySGSTAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencySGSTAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencySGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencySGSTAmount"
            runat = "server"
            ControlToValidate = "F_AgencySGSTAmount"
            ControlExtender = "MEEAgencySGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyCGSTRate" runat="server" Text="Agency CGST Rate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyCGSTRate"
            Text='<%# Bind("AgencyCGSTRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyCGSTRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyCGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyCGSTRate"
            runat = "server"
            ControlToValidate = "F_AgencyCGSTRate"
            ControlExtender = "MEEAgencyCGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyCGSTAmount" runat="server" Text="Agency CGST Amount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AgencyCGSTAmount"
            Text='<%# Bind("AgencyCGSTAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            ValidationGroup= "spmtAirTicket"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyCGSTAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyCGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyCGSTAmount"
            runat = "server"
            ControlToValidate = "F_AgencyCGSTAmount"
            ControlExtender = "MEEAgencyCGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicket"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyCessRate" runat="server" Text="Agency Cess Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgencyCessRate"
            Text='<%# Bind("AgencyCessRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyCessRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyCessRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyCessRate"
            runat = "server"
            ControlToValidate = "F_AgencyCessRate"
            ControlExtender = "MEEAgencyCessRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyCessAmount" runat="server" Text="Agency Cess Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgencyCessAmount"
            Text='<%# Bind("AgencyCessAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAgencyCessAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AgencyCessAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAgencyCessAmount"
            runat = "server"
            ControlToValidate = "F_AgencyCessAmount"
            ControlExtender = "MEEAgencyCessAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyTotalGST" runat="server" Text="Agency Total GST :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgencyTotalGST"
            Text='<%# Bind("AgencyTotalGST") %>'
            ToolTip="Value of Agency Total GST."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyTotalAmount" runat="server" Text="Agency Total Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AgencyTotalAmount"
            Text='<%# Bind("AgencyTotalAmount") %>'
            ToolTip="Value of Agency Total Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgencyRCMApplicable" runat="server" Text="Agency RCM Applicable :" />&nbsp;
        </td>
        <td>
          <asp:CheckBox ID="F_AgencyRCMApplicable"
            Checked='<%# Bind("AgencyRCMApplicable") %>'
            CssClass = "mychk"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_NonGST1TaxRate" runat="server" Text="YQ Tax Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_NonGST1TaxRate"
            Text='<%# Bind("NonGST1TaxRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEENonGST1TaxRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_NonGST1TaxRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVNonGST1TaxRate"
            runat = "server"
            ControlToValidate = "F_NonGST1TaxRate"
            ControlExtender = "MEENonGST1TaxRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_NonGST1TaxAmount" runat="server" Text="YQ Tax Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_NonGST1TaxAmount"
            Text='<%# Bind("NonGST1TaxAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEENonGST1TaxAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_NonGST1TaxAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVNonGST1TaxAmount"
            runat = "server"
            ControlToValidate = "F_NonGST1TaxAmount"
            ControlExtender = "MEENonGST1TaxAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_NonGST2TaxRate" runat="server" Text="Other Tax Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_NonGST2TaxRate"
            Text='<%# Bind("NonGST2TaxRate") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEENonGST2TaxRate"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_NonGST2TaxRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVNonGST2TaxRate"
            runat = "server"
            ControlToValidate = "F_NonGST2TaxRate"
            ControlExtender = "MEENonGST2TaxRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_NonGST2TaxAmount" runat="server" Text="Other Tax Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_NonGST2TaxAmount"
            Text='<%# Bind("NonGST2TaxAmount") %>'
            style="text-align: right"
            Width="168px"
            CssClass = "mytxt"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEENonGST2TaxAmount"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_NonGST2TaxAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVNonGST2TaxAmount"
            runat = "server"
            ControlToValidate = "F_NonGST2TaxAmount"
            ControlExtender = "MEENonGST2TaxAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalPayableToAgent" runat="server" Text="Total Payable To Agent :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalPayableToAgent"
            Text='<%# Bind("TotalPayableToAgent") %>'
            ToolTip="Value of Total Payable To Agent."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_PaxName" runat="server" Text="Pax Name :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_PaxName"
            Text='<%# Bind("PaxName") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Pax Name."
            MaxLength="50"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Sector" runat="server" Text="Sector :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_Sector"
            Text='<%# Bind("Sector") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Sector."
            MaxLength="50"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TravelDate" runat="server" Text="Travel Date :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TravelDate"
            Text='<%# Bind("TravelDate") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonTravelDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CETravelDate"
            TargetControlID="F_TravelDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonTravelDate" />
          <AJX:MaskedEditExtender 
            ID = "MEETravelDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_TravelDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVTravelDate"
            runat = "server"
            ControlToValidate = "F_TravelDate"
            ControlExtender = "MEETravelDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ReferrenceNumber" runat="server" Text="Referrence Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ReferrenceNumber"
            Text='<%# Bind("ReferrenceNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Referrence Number."
            MaxLength="50"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_EmployeeID" runat="server" Text="Employee :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_EmployeeID"
            CssClass = "myfktxt"
            Text='<%# Bind("EmployeeID") %>'
            AutoCompleteType = "None"
            Width="72px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Employee."
            onblur= "script_spmtAirTicket.validate_EmployeeID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_EmployeeID_Display"
            Text='<%# Eval("aspnet_users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEEmployeeID"
            BehaviorID="B_ACEEmployeeID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="EmployeeIDCompletionList"
            TargetControlID="F_EmployeeID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEEmployeeID_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEEmployeeID_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEEmployeeID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="Project :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "myfktxt"
            Text='<%# Bind("ProjectID") %>'
            AutoCompleteType = "None"
            Width="56px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Project."
            onblur= "script_spmtAirTicket.validate_ProjectID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects2_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEProjectID"
            BehaviorID="B_ACEProjectID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ProjectIDCompletionList"
            TargetControlID="F_ProjectID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtAirTicket.ACEProjectID_Selected"
            OnClientPopulating="script_spmtAirTicket.ACEProjectID_Populating"
            OnClientPopulated="script_spmtAirTicket.ACEProjectID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ISGECUnit" runat="server" Text="ISGEC Unit :" />&nbsp;
        </td>
        <td>
          <asp:DropDownList
            ID="F_ISGECUnit"
            SelectedValue='<%# Bind("ISGECUnit") %>'
            CssClass = "myddl"
            Width="200px"
            Runat="Server" >
            <asp:ListItem Value="">---Select---</asp:ListItem>
            <asp:ListItem Value="HO">HO</asp:ListItem>
            <asp:ListItem Value="NON-HO">NON-HO</asp:ListItem>
          </asp:DropDownList>
         </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Geography" runat="server" Text="Geography :" />&nbsp;
        </td>
        <td>
          <asp:DropDownList
            ID="F_Geography"
            SelectedValue='<%# Bind("Geography") %>'
            CssClass = "myddl"
            Width="200px"
            Runat="Server" >
            <asp:ListItem Value="">---Select---</asp:ListItem>
            <asp:ListItem Value="Domestic">Domestic</asp:ListItem>
            <asp:ListItem Value="International">International</asp:ListItem>
          </asp:DropDownList>
         </td>
        <td class="alignright">
          <asp:Label ID="L_StatusID" runat="server" Text="Status :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_StatusID"
            Width="88px"
            Text='<%# Bind("StatusID") %>'
            Enabled = "False"
            ToolTip="Value of Status."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_StatusID_Display"
            Text='<%# Eval("SPMT_AirTicketStatus17_Descriptionn") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdviceNo" runat="server" Text="Advice No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceNo"
            Width="88px"
            Text='<%# Bind("AdviceNo") %>'
            Enabled = "False"
            ToolTip="Value of Advice No."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceNo_Display"
            Text='<%# Eval("SPMT_PaymentAdvice11_BPID") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AgentsIRNo" runat="server" Text="Agents IR No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgentsIRNo"
            Width="88px"
            Text='<%# Bind("AgentsIRNo") %>'
            Enabled = "False"
            ToolTip="Value of Agents IR No."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AgentsIRNo_Display"
            Text='<%# Eval("SPMT_SupplierBill18_BillNumber") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AgencyIRNo" runat="server" Text="Agency IR No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgencyIRNo"
            Width="88px"
            Text='<%# Bind("AgencyIRNo") %>'
            Enabled = "False"
            ToolTip="Value of Agency IR No."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AgencyIRNo_Display"
            Text='<%# Eval("SPMT_SupplierBill19_BillNumber") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
  </div>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtAirTicket"
  DataObjectTypeName = "SIS.SPMT.spmtAirTicket"
  SelectMethod = "spmtAirTicketGetByID"
  UpdateMethod="UZ_spmtAirTicketUpdate"
  DeleteMethod="UZ_spmtAirTicketDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtAirTicket"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
