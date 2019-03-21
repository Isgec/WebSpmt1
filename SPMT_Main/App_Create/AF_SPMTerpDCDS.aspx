<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_SPMTerpDCDS.aspx.vb" Inherits="AF_SPMTerpDCDS" title="Add: ERP DC Item Source" %>
<asp:Content ID="CPHSPMTerpDCDS" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCDS" runat="server" Text="&nbsp;Add: ERP DC Item Source"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCDS" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCDS"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "SPMTerpDCDS"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCDS"
  runat = "server"
  DataKeyNames = "ChallanID,SerialNo,SourceNo"
  DataSourceID = "ODSSPMTerpDCDS"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgSPMTerpDCDS" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ChallanID" ForeColor="#CC6633" runat="server" Text="ChallanID :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ChallanID"
            CssClass = "mypktxt"
            Width="168px"
            Text='<%# Bind("ChallanID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for ChallanID."
            ValidationGroup = "SPMTerpDCDS"
            onblur= "script_SPMTerpDCDS.validate_ChallanID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVChallanID"
            runat = "server"
            ControlToValidate = "F_ChallanID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_ChallanID_Display"
            Text='<%# Eval("SPMT_erpDCH3_PlaceOfDelivery") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEChallanID"
            BehaviorID="B_ACEChallanID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ChallanIDCompletionList"
            TargetControlID="F_ChallanID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_SPMTerpDCDS.ACEChallanID_Selected"
            OnClientPopulating="script_SPMTerpDCDS.ACEChallanID_Populating"
            OnClientPopulated="script_SPMTerpDCDS.ACEChallanID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" ForeColor="#CC6633" runat="server" Text="SerialNo :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_SerialNo"
            CssClass = "mypktxt"
            Width="88px"
            Text='<%# Bind("SerialNo") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for SerialNo."
            ValidationGroup = "SPMTerpDCDS"
            onblur= "script_SPMTerpDCDS.validate_SerialNo(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVSerialNo"
            runat = "server"
            ControlToValidate = "F_SerialNo"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_SerialNo_Display"
            Text='<%# Eval("SPMT_erpDCD2_ItemDescription") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACESerialNo"
            BehaviorID="B_ACESerialNo"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="SerialNoCompletionList"
            TargetControlID="F_SerialNo"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_SPMTerpDCDS.ACESerialNo_Selected"
            OnClientPopulating="script_SPMTerpDCDS.ACESerialNo_Populating"
            OnClientPopulated="script_SPMTerpDCDS.ACESerialNo_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_SourceNo" ForeColor="#CC6633" runat="server" Text="SourceNo :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_SourceNo" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ItemDescription" runat="server" Text="ItemDescription :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ItemDescription"
            Text='<%# Bind("ItemDescription") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="SPMTerpDCDS"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ItemDescription."
            MaxLength="250"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVItemDescription"
            runat = "server"
            ControlToValidate = "F_ItemDescription"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaseRate" runat="server" Text="BaseRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_BaseRate"
            Text='<%# Bind("BaseRate") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEBaseRate"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_BaseRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVBaseRate"
            runat = "server"
            ControlToValidate = "F_BaseRate"
            ControlExtender = "MEEBaseRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BillTypeID" runat="server" Text="BillTypeID :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtBillTypes
            ID="F_BillTypeID"
            SelectedValue='<%# Bind("BillTypeID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "SPMTerpDCDS"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_HSNSACCode" runat="server" Text="HSNSACCode :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_HSNSACCode"
            CssClass = "myfktxt"
            Width="168px"
            Text='<%# Bind("HSNSACCode") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for HSNSACCode."
            ValidationGroup = "SPMTerpDCDS"
            onblur= "script_SPMTerpDCDS.validate_HSNSACCode(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVHSNSACCode"
            runat = "server"
            ControlToValidate = "F_HSNSACCode"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_HSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes5_HSNSACCode") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEHSNSACCode"
            BehaviorID="B_ACEHSNSACCode"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="HSNSACCodeCompletionList"
            TargetControlID="F_HSNSACCode"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_SPMTerpDCDS.ACEHSNSACCode_Selected"
            OnClientPopulating="script_SPMTerpDCDS.ACEHSNSACCode_Populating"
            OnClientPopulated="script_SPMTerpDCDS.ACEHSNSACCode_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_UOM" runat="server" Text="UOM :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtERPUnits
            ID="F_UOM"
            SelectedValue='<%# Bind("UOM") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "SPMTerpDCDS"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEQuantity"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_Quantity" />
          <AJX:MaskedEditValidator 
            ID = "MEVQuantity"
            runat = "server"
            ControlToValidate = "F_Quantity"
            ControlExtender = "MEEQuantity"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_Price" runat="server" Text="Price :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Price"
            Text='<%# Bind("Price") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEPrice"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_Price" />
          <AJX:MaskedEditValidator 
            ID = "MEVPrice"
            runat = "server"
            ControlToValidate = "F_Price"
            ControlExtender = "MEEPrice"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AssessableValue" runat="server" Text="AssessableValue :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AssessableValue"
            Text='<%# Bind("AssessableValue") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAssessableValue"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AssessableValue" />
          <AJX:MaskedEditValidator 
            ID = "MEVAssessableValue"
            runat = "server"
            ControlToValidate = "F_AssessableValue"
            ControlExtender = "MEEAssessableValue"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_IGSTRate" runat="server" Text="IGSTRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_IGSTRate"
            Text='<%# Bind("IGSTRate") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEIGSTRate"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_IGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVIGSTRate"
            runat = "server"
            ControlToValidate = "F_IGSTRate"
            ControlExtender = "MEEIGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IGSTAmount" runat="server" Text="IGSTAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_IGSTAmount"
            Text='<%# Bind("IGSTAmount") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEIGSTAmount"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_IGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVIGSTAmount"
            runat = "server"
            ControlToValidate = "F_IGSTAmount"
            ControlExtender = "MEEIGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SGSTRate" runat="server" Text="SGSTRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_SGSTRate"
            Text='<%# Bind("SGSTRate") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEESGSTRate"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_SGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVSGSTRate"
            runat = "server"
            ControlToValidate = "F_SGSTRate"
            ControlExtender = "MEESGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SGSTAmount" runat="server" Text="SGSTAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_SGSTAmount"
            Text='<%# Bind("SGSTAmount") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEESGSTAmount"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_SGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVSGSTAmount"
            runat = "server"
            ControlToValidate = "F_SGSTAmount"
            ControlExtender = "MEESGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CGSTRate" runat="server" Text="CGSTRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CGSTRate"
            Text='<%# Bind("CGSTRate") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEECGSTRate"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_CGSTRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVCGSTRate"
            runat = "server"
            ControlToValidate = "F_CGSTRate"
            ControlExtender = "MEECGSTRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CGSTAmount" runat="server" Text="CGSTAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CGSTAmount"
            Text='<%# Bind("CGSTAmount") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEECGSTAmount"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_CGSTAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVCGSTAmount"
            runat = "server"
            ControlToValidate = "F_CGSTAmount"
            ControlExtender = "MEECGSTAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CessRate" runat="server" Text="CessRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CessRate"
            Text='<%# Bind("CessRate") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEECessRate"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_CessRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVCessRate"
            runat = "server"
            ControlToValidate = "F_CessRate"
            ControlExtender = "MEECessRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CessAmount" runat="server" Text="CessAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CessAmount"
            Text='<%# Bind("CessAmount") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEECessAmount"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_CessAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVCessAmount"
            runat = "server"
            ControlToValidate = "F_CessAmount"
            ControlExtender = "MEECessAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TotalGST" runat="server" Text="TotalGST :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_TotalGST"
            Text='<%# Bind("TotalGST") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEETotalGST"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_TotalGST" />
          <AJX:MaskedEditValidator 
            ID = "MEVTotalGST"
            runat = "server"
            ControlToValidate = "F_TotalGST"
            ControlExtender = "MEETotalGST"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalAmount" runat="server" Text="TotalAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_TotalAmount"
            Text='<%# Bind("TotalAmount") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEETotalAmount"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_TotalAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVTotalAmount"
            runat = "server"
            ControlToValidate = "F_TotalAmount"
            ControlExtender = "MEETotalAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_FinalRate" runat="server" Text="FinalRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_FinalRate"
            Text='<%# Bind("FinalRate") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEFinalRate"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_FinalRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVFinalRate"
            runat = "server"
            ControlToValidate = "F_FinalRate"
            ControlExtender = "MEEFinalRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_FinalAmount" runat="server" Text="FinalAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_FinalAmount"
            Text='<%# Bind("FinalAmount") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEFinalAmount"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_FinalAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVFinalAmount"
            runat = "server"
            ControlToValidate = "F_FinalAmount"
            ControlExtender = "MEEFinalAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_S_ChallanID" runat="server" Text="S_ChallanID :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_S_ChallanID"
            Text='<%# Bind("S_ChallanID") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="SPMTerpDCDS"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for S_ChallanID."
            MaxLength="20"
            Width="168px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVS_ChallanID"
            runat = "server"
            ControlToValidate = "F_S_ChallanID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_S_SerialNo" runat="server" Text="S_SerialNo :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_S_SerialNo"
            Text='<%# Bind("S_SerialNo") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mytxt"
            ValidationGroup="SPMTerpDCDS"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEES_SerialNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_S_SerialNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVS_SerialNo"
            runat = "server"
            ControlToValidate = "F_S_SerialNo"
            ControlExtender = "MEES_SerialNo"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "1"
            SetFocusOnError="true" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSSPMTerpDCDS"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCDS"
  InsertMethod="SPMTerpDCDSInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCDS"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
