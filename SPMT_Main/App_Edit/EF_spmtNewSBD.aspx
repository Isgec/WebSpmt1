<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtNewSBD.aspx.vb" Inherits="EF_spmtNewSBD" title="Edit: *Supplier Bill Items" %>
<asp:Content ID="CPHspmtNewSBD" ContentPlaceHolderID="cph1" runat="Server">
  <script type="text/javascript">
    function validate_tots(o) {
      o.value = o.value.replace(new RegExp('_', 'g'), '');
      var aVal = o.id.split('_F_');
      var Prefix = aVal[0] + '_F_';
      var AssessableValue = $get(Prefix + 'AssessableValue');
      var CessRate = $get(Prefix + 'CessRate');
      var CessAmount = $get(Prefix + 'CessAmount');
      var TotalGST = $get(Prefix + 'TotalGST');
      var TotalGSTINR = $get(Prefix + 'TotalGSTINR');
      var TotalAmount = $get(Prefix + 'TotalAmount');
      var ConversionFactorINR = $get(Prefix + 'ConversionFactorINR');
      var TotalAmountINR = $get(Prefix + 'TotalAmountINR');
      var IGSTRate = $get(Prefix + 'IGSTRate');
      var IGSTAmount = $get(Prefix + 'IGSTAmount');
      var SGSTRate = $get(Prefix + 'SGSTRate');
      var SGSTAmount = $get(Prefix + 'SGSTAmount');
      var CGSTRate = $get(Prefix + 'CGSTRate');
      var CGSTAmount = $get(Prefix + 'CGSTAmount');
      var TCSRate = $get(Prefix + 'TCSRate');
      var TCSAmount = $get(Prefix + 'TCSAmount');
      try {
        if (parseFloat(CessRate.value) > 0)
          CessAmount.value = (parseFloat(CessRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
        if (parseFloat(IGSTRate.value) > 0)
          IGSTAmount.value = (parseFloat(IGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
        if (parseFloat(SGSTRate.value) > 0)
          SGSTAmount.value = (parseFloat(SGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
        if (parseFloat(CGSTRate.value) > 0)
          CGSTAmount.value = (parseFloat(CGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
        TotalGST.value = (parseFloat(CessAmount.value) + parseFloat(IGSTAmount.value) + parseFloat(SGSTAmount.value) + parseFloat(CGSTAmount.value)).toFixed(2);
        TotalGSTINR.value = (parseFloat(TotalGST.value) * parseFloat(ConversionFactorINR.value)).toFixed(2);

        if (parseFloat(TCSRate.value) != NaN)
          TCSAmount.value = (parseFloat(TCSRate.value) * (parseFloat(AssessableValue.value) + parseFloat(TotalGST.value)) * 0.01).toFixed(2);

        TotalAmount.value = (parseFloat(AssessableValue.value) + parseFloat(TotalGST.value) + parseFloat(TCSAmount.value)).toFixed(2);
        TotalAmountINR.value = (parseFloat(TotalAmount.value) * parseFloat(ConversionFactorINR.value)).toFixed(2);
      } catch (e) { }
    }
  </script>
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabelspmtNewSBD" runat="server" Text="&nbsp;Edit: *Supplier Bill Items"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLspmtNewSBD" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="TBLspmtNewSBD"
            ToolType="lgNMEdit"
            UpdateAndStay="False"
            ValidationGroup="spmtNewSBD"
            runat="server" />
          <asp:FormView ID="FVspmtNewSBD"
            runat="server"
            DataKeyNames="IRNo,SerialNo"
            DataSourceID="ODSspmtNewSBD"
            DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table style="margin: auto; border: solid 1pt lightgrey">
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_IRNo" runat="server" ForeColor="#CC6633" Text="IR No :" /><span style="color: red">*</span></b>
                    </td>
                    <td>
                      <asp:TextBox
                        ID="F_IRNo"
                        Width="88px"
                        Text='<%# Bind("IRNo") %>'
                        CssClass="mypktxt"
                        Enabled="False"
                        ToolTip="Value of IR No."
                        runat="Server" />
                      <asp:Label
                        ID="F_IRNo_Display"
                        Text='<%# Eval("SPMT_newSBH9_BillNumber") %>'
                        CssClass="myLbl"
                        runat="Server" />
                    </td>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_SerialNo" runat="server" ForeColor="#CC6633" Text="Serial No :" /><span style="color: red">*</span></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_SerialNo"
                        Text='<%# Bind("SerialNo") %>'
                        ToolTip="Value of Serial No."
                        Enabled="False"
                        CssClass="mypktxt"
                        Width="88px"
                        Style="text-align: right"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_ItemDescription" runat="server" Text="Item Description :" /><span style="color: red">*</span>
                    </td>
                    <td colspan="3">
                      <asp:TextBox ID="F_ItemDescription"
                        Text='<%# Bind("ItemDescription") %>'
                        Width="350px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="spmtNewSBD"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Item Description."
                        MaxLength="100"
                        runat="server" />
                      <asp:RequiredFieldValidator
                        ID="RFVItemDescription"
                        runat="server"
                        ControlToValidate="F_ItemDescription"
                        ErrorMessage="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="spmtNewSBD"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_BillType" runat="server" Text="Bill Type :" />&nbsp;
                    </td>
                    <td>
                      <LGM:LC_spmtBillTypes
                        ID="F_BillType"
                        SelectedValue='<%# Bind("BillType") %>'
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
                      <asp:Label ID="L_HSNSACCode" runat="server" Text="HSN / SAC Code :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox
                        ID="F_HSNSACCode"
                        CssClass="myfktxt"
                        Text='<%# Bind("HSNSACCode") %>'
                        AutoCompleteType="None"
                        Width="168px"
                        onfocus="return this.select();"
                        ToolTip="Enter value for HSN / SAC Code."
                        onblur="script_spmtNewSBD.validate_HSNSACCode(this);"
                        runat="Server" />
                      <asp:Label
                        ID="F_HSNSACCode_Display"
                        Text='<%# Eval("SPMT_HSNSACCodes8_HSNSACCode") %>'
                        CssClass="myLbl"
                        runat="Server" />
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
                        OnClientItemSelected="script_spmtNewSBD.ACEHSNSACCode_Selected"
                        OnClientPopulating="script_spmtNewSBD.ACEHSNSACCode_Populating"
                        OnClientPopulated="script_spmtNewSBD.ACEHSNSACCode_Populated"
                        CompletionSetCount="10"
                        CompletionListCssClass="autocomplete_completionListElement"
                        CompletionListItemCssClass="autocomplete_listItem"
                        CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_UOM" runat="server" Text="UOM :" /><span style="color: red">*</span>
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
                        ValidationGroup="spmtNewSBD"
                        RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
                        Runat="Server" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color: red">*</span>
                    </td>
                    <td>
                      <asp:TextBox ID="F_Quantity"
                        Text='<%# Bind("Quantity") %>'
                        Style="text-align: right"
                        Width="168px"
                        CssClass="mytxt"
                        ValidationGroup="spmtNewSBD"
                        MaxLength="20"
                        onfocus="return this.select();"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEEQuantity"
                        runat="server"
                        Mask="999999999999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_Quantity" />
                      <AJX:MaskedEditValidator
                        ID="MEVQuantity"
                        runat="server"
                        ControlToValidate="F_Quantity"
                        ControlExtender="MEEQuantity"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="spmtNewSBD"
                        IsValidEmpty="false"
                        MinimumValue="0.01"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_Currency" runat="server" Text="Currency :" /><span style="color: red">*</span>
                    </td>
                    <td>
                      <asp:DropDownList
                        ID="F_Currency"
                        SelectedValue='<%# Bind("Currency") %>'
                        CssClass="myddl"
                        Width="200px"
                        ValidationGroup="spmtNewSBD"
                        runat="Server">
                        <asp:ListItem Value=" ">---Select---</asp:ListItem>
                        <asp:ListItem Value="USD">USD</asp:ListItem>
                        <asp:ListItem Value="EURO">EURO</asp:ListItem>
                        <asp:ListItem Value="INR">INR</asp:ListItem>
                        <asp:ListItem Value="PES">PES</asp:ListItem>
                        <asp:ListItem Value="GBP">GBP</asp:ListItem>
                        <asp:ListItem Value="SGD">SGD</asp:ListItem>
                      </asp:DropDownList>
                      <asp:RequiredFieldValidator
                        ID="RFVCurrency"
                        runat="server"
                        ControlToValidate="F_Currency"
                        ErrorMessage="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="spmtNewSBD"
                        SetFocusOnError="true" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_ConversionFactorINR" runat="server" Text="Conversion Factor [INR] :" /><span style="color: red">*</span>
                    </td>
                    <td>
                      <asp:TextBox ID="F_ConversionFactorINR"
                        Text='<%# Bind("ConversionFactorINR") %>'
                        Width="200px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        ValidationGroup="spmtNewSBD"
                        MaxLength="17"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEEConversionFactorINR"
                        runat="server"
                        Mask="9999999999.999999"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_ConversionFactorINR" />
                      <AJX:MaskedEditValidator
                        ID="MEVConversionFactorINR"
                        runat="server"
                        ControlToValidate="F_ConversionFactorINR"
                        ControlExtender="MEEConversionFactorINR"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="spmtNewSBD"
                        IsValidEmpty="false"
                        MinimumValue="0.01"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_AssessableValue" runat="server" Text="Assessable Value :" /><span style="color: red">*</span>
                    </td>
                    <td colspan="3">
                      <asp:TextBox ID="F_AssessableValue"
                        Text='<%# Bind("AssessableValue") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        ValidationGroup="spmtNewSBD"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEEAssessableValue"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_AssessableValue" />
                      <AJX:MaskedEditValidator
                        ID="MEVAssessableValue"
                        runat="server"
                        ControlToValidate="F_AssessableValue"
                        ControlExtender="MEEAssessableValue"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="spmtNewSBD"
                        IsValidEmpty="false"
                        MinimumValue="0.01"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_IGSTRate" runat="server" Text="IGST Rate :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_IGSTRate"
                        Text='<%# Bind("IGSTRate") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEEIGSTRate"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_IGSTRate" />
                      <AJX:MaskedEditValidator
                        ID="MEVIGSTRate"
                        runat="server"
                        ControlToValidate="F_IGSTRate"
                        ControlExtender="MEEIGSTRate"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_IGSTAmount" runat="server" Text="IGST Amount :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_IGSTAmount"
                        Text='<%# Bind("IGSTAmount") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEEIGSTAmount"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_IGSTAmount" />
                      <AJX:MaskedEditValidator
                        ID="MEVIGSTAmount"
                        runat="server"
                        ControlToValidate="F_IGSTAmount"
                        ControlExtender="MEEIGSTAmount"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_SGSTRate" runat="server" Text="SGST Rate :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_SGSTRate"
                        Text='<%# Bind("SGSTRate") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEESGSTRate"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_SGSTRate" />
                      <AJX:MaskedEditValidator
                        ID="MEVSGSTRate"
                        runat="server"
                        ControlToValidate="F_SGSTRate"
                        ControlExtender="MEESGSTRate"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_SGSTAmount" runat="server" Text="SGST Amount :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_SGSTAmount"
                        Text='<%# Bind("SGSTAmount") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEESGSTAmount"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_SGSTAmount" />
                      <AJX:MaskedEditValidator
                        ID="MEVSGSTAmount"
                        runat="server"
                        ControlToValidate="F_SGSTAmount"
                        ControlExtender="MEESGSTAmount"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_CGSTRate" runat="server" Text="CGST Rate :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_CGSTRate"
                        Text='<%# Bind("CGSTRate") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEECGSTRate"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_CGSTRate" />
                      <AJX:MaskedEditValidator
                        ID="MEVCGSTRate"
                        runat="server"
                        ControlToValidate="F_CGSTRate"
                        ControlExtender="MEECGSTRate"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_CGSTAmount" runat="server" Text="CGST Amount :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_CGSTAmount"
                        Text='<%# Bind("CGSTAmount") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEECGSTAmount"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_CGSTAmount" />
                      <AJX:MaskedEditValidator
                        ID="MEVCGSTAmount"
                        runat="server"
                        ControlToValidate="F_CGSTAmount"
                        ControlExtender="MEECGSTAmount"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_CessRate" runat="server" Text="Cess Rate :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_CessRate"
                        Text='<%# Bind("CessRate") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEECessRate"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_CessRate" />
                      <AJX:MaskedEditValidator
                        ID="MEVCessRate"
                        runat="server"
                        ControlToValidate="F_CessRate"
                        ControlExtender="MEECessRate"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_CessAmount" runat="server" Text="Cess Amount :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_CessAmount"
                        Text='<%# Bind("CessAmount") %>'
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: Right"
                        MaxLength="13"
                        onfocus="return this.select();"
                        onblur="validate_tots(this);"
                        runat="server" />
                      <AJX:MaskedEditExtender
                        ID="MEECessAmount"
                        runat="server"
                        Mask="9999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_CessAmount" />
                      <AJX:MaskedEditValidator
                        ID="MEVCessAmount"
                        runat="server"
                        ControlToValidate="F_CessAmount"
                        ControlExtender="MEECessAmount"
                        EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                        Display="Dynamic"
                        EnableClientScript="true"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_TotalGST" runat="server" Text="Total GST :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_TotalGST"
                        Text='<%# Bind("TotalGST") %>'
                        Enabled="False"
                        ToolTip="Value of Total GST."
                        Width="168px"
                        CssClass="dmytxt"
                        Style="text-align: Right"
                        runat="server" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_TotalGSTINR" runat="server" Text="Total GST [INR] :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_TotalGSTINR"
                        Text='<%# Bind("TotalGSTINR") %>'
                        Enabled="False"
                        ToolTip="Value of Total GST [INR]."
                        Width="168px"
                        CssClass="dmytxt"
                        Style="text-align: Right"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_TCSRate" runat="server" Font-Bold="true" ForeColor="#cc0000" Text="TCS Rate :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_TCSRate"
                        Text='<%# Bind("TCSRate") %>'
                        ToolTip="Enter TCS Rate. (if applicable)"
                        Width="168px"
                        CssClass="mytxt"
                        Style="text-align: right"
                        onfocus="return this.select();"
                        onblur="dc(this,4);validate_tots(this);"
                        runat="server" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_TCSAmount" runat="server" Text="TCS Amount :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_TCSAmount"
                        Text='<%# Bind("TCSAmount") %>'
                        Enabled="False"
                        ToolTip="TCS Amount."
                        Width="168px"
                        CssClass="dmytxt"
                        Style="text-align: right"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_TotalAmount" runat="server" Text="Total Amount :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_TotalAmount"
                        Text='<%# Bind("TotalAmount") %>'
                        Enabled="False"
                        ToolTip="Value of Total Amount."
                        Width="168px"
                        CssClass="dmytxt"
                        Style="text-align: Right"
                        runat="server" />
                    </td>
                    <td class="alignright">
                      <asp:Label ID="L_TotalAmountINR" runat="server" Text="Total Amount [INR] :" />&nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="F_TotalAmountINR"
                        Text='<%# Bind("TotalAmountINR") %>'
                        Enabled="False"
                        ToolTip="Value of Total Amount [INR]."
                        Width="168px"
                        CssClass="dmytxt"
                        Style="text-align: Right"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <asp:Label ID="L_DepartmentID" runat="server" Text="Department ID :" />&nbsp;
                    </td>
                    <td colspan="3">
                      <LGM:LC_comDepartments
                        ID="F_DepartmentID"
                        SelectedValue='<%# Bind("DepartmentID") %>'
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
                    <td colspan="4" style="border-top: solid 1pt LightGrey"></td>
                  </tr>
                </table>
              </div>
            </EditItemTemplate>
          </asp:FormView>
        </ContentTemplate>
      </asp:UpdatePanel>
      <asp:ObjectDataSource
        ID="ODSspmtNewSBD"
        DataObjectTypeName="SIS.SPMT.spmtNewSBD"
        SelectMethod="spmtNewSBDGetByID"
        UpdateMethod="UZ_spmtNewSBDUpdate"
        DeleteMethod="UZ_spmtNewSBDDelete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.SPMT.spmtNewSBD"
        runat="server">
        <SelectParameters>
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="IRNo" Name="IRNo" Type="Int32" />
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
        </SelectParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
