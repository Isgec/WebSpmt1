<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_SPMTerpDCInventory.aspx.vb" Inherits="EF_SPMTerpDCInventory" title="Edit: ERP DC Inventory" %>
<asp:Content ID="CPHSPMTerpDCInventory" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCInventory" runat="server" Text="&nbsp;Edit: ERP DC Inventory"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCInventory" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCInventory"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "SPMTerpDCInventory"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCInventory"
  runat = "server"
  DataKeyNames = "ChallanID,SerialNo"
  DataSourceID = "ODSSPMTerpDCInventory"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ChallanID" runat="server" ForeColor="#CC6633" Text="ChallanID :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ChallanID"
            Width="168px"
            Text='<%# Bind("ChallanID") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of ChallanID."
            Runat="Server" />
          <asp:Label
            ID = "F_ChallanID_Display"
            Text='<%# Eval("SPMT_erpDCH3_PlaceOfDelivery") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" runat="server" ForeColor="#CC6633" Text="SerialNo :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_SerialNo"
            Width="88px"
            Text='<%# Bind("SerialNo") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of SerialNo."
            Runat="Server" />
          <asp:Label
            ID = "F_SerialNo_Display"
            Text='<%# Eval("SPMT_erpDCD10_ItemDescription") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ItemDescription" runat="server" Text="ItemDescription :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ItemDescription"
            Text='<%# Bind("ItemDescription") %>'
            Width="350px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="SPMTerpDCInventory"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ItemDescription."
            MaxLength="250"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVItemDescription"
            runat = "server"
            ControlToValidate = "F_ItemDescription"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BaseRate" runat="server" Text="BaseRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_BaseRate"
            Text='<%# Bind("BaseRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
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
            ValidationGroup = "SPMTerpDCInventory"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_HSNSACCode" runat="server" Text="HSNSACCode :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_HSNSACCode"
            CssClass = "myfktxt"
            Text='<%# Bind("HSNSACCode") %>'
            AutoCompleteType = "None"
            Width="168px"
            onfocus = "return this.select();"
            ToolTip="Enter value for HSNSACCode."
            ValidationGroup = "SPMTerpDCInventory"
            onblur= "script_SPMTerpDCInventory.validate_HSNSACCode(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVHSNSACCode"
            runat = "server"
            ControlToValidate = "F_HSNSACCode"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_HSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes6_HSNSACCode") %>'
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
            OnClientItemSelected="script_SPMTerpDCInventory.ACEHSNSACCode_Selected"
            OnClientPopulating="script_SPMTerpDCInventory.ACEHSNSACCode_Populating"
            OnClientPopulated="script_SPMTerpDCInventory.ACEHSNSACCode_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
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
            ValidationGroup = "SPMTerpDCInventory"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Price" runat="server" Text="Price :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Price"
            Text='<%# Bind("Price") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AssessableValue" runat="server" Text="AssessableValue :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_AssessableValue"
            Text='<%# Bind("AssessableValue") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IGSTRate" runat="server" Text="IGSTRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_IGSTRate"
            Text='<%# Bind("IGSTRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_IGSTAmount" runat="server" Text="IGSTAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_IGSTAmount"
            Text='<%# Bind("IGSTAmount") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SGSTRate" runat="server" Text="SGSTRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_SGSTRate"
            Text='<%# Bind("SGSTRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SGSTAmount" runat="server" Text="SGSTAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_SGSTAmount"
            Text='<%# Bind("SGSTAmount") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CGSTRate" runat="server" Text="CGSTRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CGSTRate"
            Text='<%# Bind("CGSTRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CGSTAmount" runat="server" Text="CGSTAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CGSTAmount"
            Text='<%# Bind("CGSTAmount") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CessRate" runat="server" Text="CessRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CessRate"
            Text='<%# Bind("CessRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CessAmount" runat="server" Text="CessAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CessAmount"
            Text='<%# Bind("CessAmount") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalGST" runat="server" Text="TotalGST :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_TotalGST"
            Text='<%# Bind("TotalGST") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TotalAmount" runat="server" Text="TotalAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_TotalAmount"
            Text='<%# Bind("TotalAmount") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_FinalRate" runat="server" Text="FinalRate :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_FinalRate"
            Text='<%# Bind("FinalRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_FinalAmount" runat="server" Text="FinalAmount :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_FinalAmount"
            Text='<%# Bind("FinalAmount") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCInventory"
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
            ValidationGroup = "SPMTerpDCInventory"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerIsgecID" runat="server" Text="ConsignerIsgecID :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtIsgecGSTIN
            ID="F_ConsignerIsgecID"
            SelectedValue='<%# Bind("ConsignerIsgecID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "SPMTerpDCInventory"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_ConsignerBPID" runat="server" Text="ConsignerBPID :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ConsignerBPID"
            CssClass = "myfktxt"
            Text='<%# Bind("ConsignerBPID") %>'
            AutoCompleteType = "None"
            Width="80px"
            onfocus = "return this.select();"
            ToolTip="Enter value for ConsignerBPID."
            ValidationGroup = "SPMTerpDCInventory"
            onblur= "script_SPMTerpDCInventory.validate_ConsignerBPID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConsignerBPID"
            runat = "server"
            ControlToValidate = "F_ConsignerBPID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_ConsignerBPID_Display"
            Text='<%# Eval("VR_BusinessPartner9_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEConsignerBPID"
            BehaviorID="B_ACEConsignerBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ConsignerBPIDCompletionList"
            TargetControlID="F_ConsignerBPID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_SPMTerpDCInventory.ACEConsignerBPID_Selected"
            OnClientPopulating="script_SPMTerpDCInventory.ACEConsignerBPID_Populating"
            OnClientPopulated="script_SPMTerpDCInventory.ACEConsignerBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerGSTIN" runat="server" Text="ConsignerGSTIN :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ConsignerGSTIN"
            CssClass = "myfktxt"
            Text='<%# Bind("ConsignerGSTIN") %>'
            AutoCompleteType = "None"
            Width="88px"
            onfocus = "return this.select();"
            ToolTip="Enter value for ConsignerGSTIN."
            ValidationGroup = "SPMTerpDCInventory"
            onblur= "script_SPMTerpDCInventory.validate_ConsignerGSTIN(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConsignerGSTIN"
            runat = "server"
            ControlToValidate = "F_ConsignerGSTIN"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_ConsignerGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN8_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEConsignerGSTIN"
            BehaviorID="B_ACEConsignerGSTIN"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ConsignerGSTINCompletionList"
            TargetControlID="F_ConsignerGSTIN"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_SPMTerpDCInventory.ACEConsignerGSTIN_Selected"
            OnClientPopulating="script_SPMTerpDCInventory.ACEConsignerGSTIN_Populating"
            OnClientPopulated="script_SPMTerpDCInventory.ACEConsignerGSTIN_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsignerName" runat="server" Text="ConsignerName :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerName"
            Text='<%# Bind("ConsignerName") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="SPMTerpDCInventory"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ConsignerName."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConsignerName"
            runat = "server"
            ControlToValidate = "F_ConsignerName"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerGSTINNo" runat="server" Text="ConsignerGSTINNo :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerGSTINNo"
            Text='<%# Bind("ConsignerGSTINNo") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="SPMTerpDCInventory"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ConsignerGSTINNo."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConsignerGSTINNo"
            runat = "server"
            ControlToValidate = "F_ConsignerGSTINNo"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsignerStateID" runat="server" Text="ConsignerStateID :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_ConsignerStateID"
            SelectedValue='<%# Bind("ConsignerStateID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "SPMTerpDCInventory"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="ProjectID :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "myfktxt"
            Text='<%# Bind("ProjectID") %>'
            AutoCompleteType = "None"
            Width="56px"
            onfocus = "return this.select();"
            ToolTip="Enter value for ProjectID."
            ValidationGroup = "SPMTerpDCInventory"
            onblur= "script_SPMTerpDCInventory.validate_ProjectID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVProjectID"
            runat = "server"
            ControlToValidate = "F_ProjectID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCInventory"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects1_Description") %>'
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
            OnClientItemSelected="script_SPMTerpDCInventory.ACEProjectID_Selected"
            OnClientPopulating="script_SPMTerpDCInventory.ACEProjectID_Populating"
            OnClientPopulated="script_SPMTerpDCInventory.ACEProjectID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
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
  ID = "ODSSPMTerpDCInventory"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCInventory"
  SelectMethod = "SPMTerpDCInventoryGetByID"
  UpdateMethod="SPMTerpDCInventoryUpdate"
  DeleteMethod="SPMTerpDCInventoryDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCInventory"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ChallanID" Name="ChallanID" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
