<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtSupplierBill.aspx.vb" Inherits="EF_spmtSupplierBill" title="Edit: Supplier Bill" %>
<asp:Content ID="CPHspmtSupplierBill" ContentPlaceHolderID="cph1" runat="Server">
  <script type="text/javascript">
    function validate_tots(o) {
      o.value = o.value.replace(new RegExp('_', 'g'), '');
      var aVal = o.id.split('_F_');
      var Prefix = aVal[0] + '_F_';
      var AssessableValue = $get(Prefix + 'AssessableValue');
      var CessRate = $get(Prefix + 'CessRate');
      var CessAmount = $get(Prefix + 'CessAmount');
      var TotalGST = $get(Prefix + 'TotalGST');
      var TotalGSTINR = $get(Prefix + 'TaxAmount');
      var TotalAmount = $get(Prefix + 'TotalAmount');
      var ConversionFactorINR = $get(Prefix + 'ConversionFactorINR');
      var TotalAmountINR = $get(Prefix + 'TotalAmountINR');
      var IGSTRate = $get(Prefix + 'IGSTRate');
      var IGSTAmount = $get(Prefix + 'IGSTAmount');
      var SGSTRate = $get(Prefix + 'SGSTRate');
      var SGSTAmount = $get(Prefix + 'SGSTAmount');
      var CGSTRate = $get(Prefix + 'CGSTRate');
      var CGSTAmount = $get(Prefix + 'CGSTAmount');
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
        TotalAmount.value = (parseFloat(AssessableValue.value) + parseFloat(TotalGST.value)).toFixed(2);
        TotalAmountINR.value = (parseFloat(TotalAmount.value) * parseFloat(ConversionFactorINR.value)).toFixed(2);
      } catch (e) { }
    }
  </script>
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabelspmtSupplierBill" runat="server" Text="&nbsp;Edit: Supplier Bill"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLspmtSupplierBill" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="TBLspmtSupplierBill"
            ToolType="lgNMEdit"
            UpdateAndStay="False"
            ValidationGroup="spmtSupplierBill"
            runat="server" />
          <asp:FormView ID="FVspmtSupplierBill"
            runat="server"
            DataKeyNames="IRNo"
            DataSourceID="ODSspmtSupplierBill"
            DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table style="margin: auto; border: solid 1pt lightgrey">
                  <tr>
                    <td>
                      <table>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_PurchaseType" runat="server" Text="Purchase Type :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:DropDownList
                              ID="F_PurchaseType"
                              SelectedValue='<%# Bind("PurchaseType") %>'
                              Width="200px"
                              ValidationGroup="spmtSupplierBill"
                              CssClass="myddl"
                              AutoPostBack="true"
                              OnSelectedIndexChanged="PurchaseType_SelectedIndexChanged"
                              runat="Server">
                              <asp:ListItem Value="Purchase from Registered Dealer">Registered Dealer-ITC</asp:ListItem>
                              <asp:ListItem Value="Purchase from Registered Dealer-No ITC">Registered Dealer-No ITC</asp:ListItem>
                              <asp:ListItem Value="Purchase from Composition Dealer">Composition Dealer</asp:ListItem>
                              <asp:ListItem Value="Purchase from Unregistered Dealer">Unregistered Dealer</asp:ListItem>
                              <asp:ListItem Value="Non GST expenses bill">Non GST expenses bill</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator
                              ID="RFVPurchaseType"
                              runat="server"
                              ControlToValidate="F_PurchaseType"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_IRNo" ForeColor="#CC6633" runat="server" Text="IR No :" /><span style="color: red">*</span></b>
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_IRNo" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text='<%# Bind("IRNo") %>' />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_TranTypeID" runat="server" Text="Tran.Type :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
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
                              ValidationGroup="spmtSupplierBill"
                              RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
                              Runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_IsgecGSTIN" runat="server" Text="Isgec GSTIN :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <LGM:LC_spmtIsgecGSTIN
                              ID="F_IsgecGSTIN"
                              SelectedValue='<%# Bind("IsgecGSTIN") %>'
                              OrderBy="DisplayField"
                              DataTextField="DisplayField"
                              DataValueField="PrimaryKey"
                              IncludeDefault="true"
                              DefaultText="-- Select --"
                              Width="200px"
                              CssClass="myddl"
                              ValidationGroup="spmtSupplierBill"
                              RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
                              Runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_BPID" runat="server" Text="Supplier :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox
                              ID="F_BPID"
                              CssClass="myfktxt"
                              Width="80px"
                              Text='<%# Bind("BPID") %>'
                              AutoCompleteType="None"
                              onfocus="return this.select();"
                              ToolTip="Enter value for Supplier."
                              ValidationGroup="spmtSupplierBill"
                              onblur="script_spmtSupplierBill.validate_BPID(this);"
                              runat="Server" />
                            <asp:RequiredFieldValidator
                              ID="RFVBPID"
                              runat="server"
                              ControlToValidate="F_BPID"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                            <asp:Label
                              ID="F_BPID_Display"
                              Text='<%# Eval("VR_BusinessPartner18_BPName") %>'
                              CssClass="myLbl"
                              runat="Server" />
                            <AJX:AutoCompleteExtender
                              ID="ACEBPID"
                              BehaviorID="B_ACEBPID"
                              ContextKey=""
                              UseContextKey="true"
                              ServiceMethod="BPIDCompletionList"
                              TargetControlID="F_BPID"
                              EnableCaching="false"
                              CompletionInterval="100"
                              FirstRowSelected="true"
                              MinimumPrefixLength="1"
                              OnClientItemSelected="script_spmtSupplierBill.ACEBPID_Selected"
                              OnClientPopulating="script_spmtSupplierBill.ACEBPID_Populating"
                              OnClientPopulated="script_spmtSupplierBill.ACEBPID_Populated"
                              CompletionSetCount="10"
                              CompletionListCssClass="autocomplete_completionListElement"
                              CompletionListItemCssClass="autocomplete_listItem"
                              CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                              runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_SupplierGSTIN" runat="server" Text="Supplier GSTIN :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox
                              ID="F_SupplierGSTIN"
                              CssClass="myfktxt"
                              Width="88px"
                              Text='<%# Bind("SupplierGSTIN") %>'
                              AutoCompleteType="None"
                              onfocus="return this.select();"
                              ToolTip="Enter value for Supplier GSTIN."
                              ValidationGroup="spmtSupplierBill"
                              onblur="script_spmtSupplierBill.validate_SupplierGSTIN(this);"
                              runat="Server" />
                            <asp:RequiredFieldValidator
                              ID="RFVSupplierGSTIN"
                              runat="server"
                              ControlToValidate="F_SupplierGSTIN"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                            <asp:Label
                              ID="F_SupplierGSTIN_Display"
                              Text='<%# Eval("VR_BPGSTIN17_Description") %>'
                              CssClass="myLbl"
                              runat="Server" />
                            <AJX:AutoCompleteExtender
                              ID="ACESupplierGSTIN"
                              BehaviorID="B_ACESupplierGSTIN"
                              ContextKey=""
                              UseContextKey="true"
                              ServiceMethod="SupplierGSTINCompletionList"
                              TargetControlID="F_SupplierGSTIN"
                              EnableCaching="false"
                              CompletionInterval="100"
                              FirstRowSelected="true"
                              MinimumPrefixLength="1"
                              OnClientItemSelected="script_spmtSupplierBill.ACESupplierGSTIN_Selected"
                              OnClientPopulating="script_spmtSupplierBill.ACESupplierGSTIN_Populating"
                              OnClientPopulated="script_spmtSupplierBill.ACESupplierGSTIN_Populated"
                              CompletionSetCount="10"
                              CompletionListCssClass="autocomplete_completionListElement"
                              CompletionListItemCssClass="autocomplete_listItem"
                              CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                              runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_SupplierName" runat="server" Text="Supplier Name :" />
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_SupplierName"
                              Text='<%# Bind("SupplierName") %>'
                              CssClass="dmytxt"
                              onfocus="return this.select();"
                              ValidationGroup="spmtSupplierBill"
                              onblur="this.value=this.value.replace(/\'/g,'');"
                              MaxLength="100"
                              Enabled="false"
                              Width="350px"
                              runat="server" />
                            <asp:RequiredFieldValidator
                              ID="RFVSupplierName"
                              runat="server"
                              ControlToValidate="F_SupplierName"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              Enabled="false"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_SupplierGSTINNumber" runat="server" Text="Supplier GSTIN :" />
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_SupplierGSTINNumber"
                              Text='<%# Bind("SupplierGSTINNumber") %>'
                              CssClass="dmytxt"
                              onfocus="return this.select();"
                              ValidationGroup="spmtSupplierBill"
                              onblur="this.value=this.value.replace(/\'/g,'');"
                              MaxLength="50"
                              Width="350px"
                              Enabled="false"
                              runat="server" />
                            <asp:RequiredFieldValidator
                              ID="RFVSupplierGSTINNumber"
                              runat="server"
                              ControlToValidate="F_SupplierGSTINNumber"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              Enabled="false"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_BillType" runat="server" Text="Bill Type :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
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
                              ValidationGroup="spmtSupplierBill"
                              RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
                              Runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_HSNSACCode" runat="server" Text="HSN / SAC Code :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox
                              ID="F_HSNSACCode"
                              CssClass="myfktxt"
                              Width="168px"
                              Text='<%# Bind("HSNSACCode") %>'
                              AutoCompleteType="None"
                              onfocus="return this.select();"
                              ToolTip="Enter value for HSN / SAC Code."
                              ValidationGroup="spmtSupplierBill"
                              onblur="script_spmtSupplierBill.validate_HSNSACCode(this);"
                              runat="Server" />
                            <asp:RequiredFieldValidator
                              ID="RFVHSNSACCode"
                              runat="server"
                              ControlToValidate="F_HSNSACCode"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                            <asp:Label
                              ID="F_HSNSACCode_Display"
                              Text='<%# Eval("SPMT_HSNSACCodes12_HSNSACCode") %>'
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
                              OnClientItemSelected="script_spmtSupplierBill.ACEHSNSACCode_Selected"
                              OnClientPopulating="script_spmtSupplierBill.ACEHSNSACCode_Populating"
                              OnClientPopulated="script_spmtSupplierBill.ACEHSNSACCode_Populated"
                              CompletionSetCount="10"
                              CompletionListCssClass="autocomplete_completionListElement"
                              CompletionListItemCssClass="autocomplete_listItem"
                              CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                              runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_ShipToState" runat="server" Text="Place of Supply :" />
                          </td>
                          <td colspan="3">
                            <LGM:LC_spmtERPStates
                              ID="F_ShipToState"
                              SelectedValue='<%# Bind("ShipToState") %>'
                              OrderBy="DisplayField"
                              DataTextField="DisplayField"
                              DataValueField="PrimaryKey"
                              IncludeDefault="true"
                              DefaultText="-- Select --"
                              Width="200px"
                              CssClass="myddl"
                              ValidationGroup="spmtSupplierBill"
                              RequiredFieldErrorMessage=""
                              Runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_BillNumber" runat="server" Text="Bill Number :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_BillNumber"
                              Text='<%# Bind("BillNumber") %>'
                              CssClass="mytxt"
                              onfocus="return this.select();"
                              ValidationGroup="spmtSupplierBill"
                              onblur="this.value=this.value.replace(/\'/g,'');"
                              ToolTip="Enter value for Bill Number."
                              MaxLength="50"
                              Width="350px"
                              runat="server" />
                            <asp:RequiredFieldValidator
                              ID="RFVBillNumber"
                              runat="server"
                              ControlToValidate="F_BillNumber"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_BillDate" runat="server" Text="Bill Date :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_BillDate"
                              Text='<%# Bind("BillDate") %>'
                              Width="80px"
                              CssClass="mytxt"
                              ValidationGroup="spmtSupplierBill"
                              onfocus="return this.select();"
                              runat="server" />
                            <asp:Image ID="ImageButtonBillDate" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer; vertical-align: bottom" ImageUrl="~/Images/cal.png" />
                            <AJX:CalendarExtender
                              ID="CEBillDate"
                              TargetControlID="F_BillDate"
                              Format="dd/MM/yyyy"
                              runat="server" CssClass="MyCalendar" PopupButtonID="ImageButtonBillDate" />
                            <AJX:MaskedEditExtender
                              ID="MEEBillDate"
                              runat="server"
                              Mask="99/99/9999"
                              MaskType="Date"
                              CultureName="en-GB"
                              MessageValidatorTip="true"
                              InputDirection="LeftToRight"
                              ErrorTooltipEnabled="true"
                              TargetControlID="F_BillDate" />
                            <AJX:MaskedEditValidator
                              ID="MEVBillDate"
                              runat="server"
                              ControlToValidate="F_BillDate"
                              ControlExtender="MEEBillDate"
                              EmptyValueBlurredText="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="false"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_BillRemarks" runat="server" Text="Item Description :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_BillRemarks"
                              Text='<%# Bind("BillRemarks") %>'
                              CssClass="mytxt"
                              onfocus="return this.select();"
                              ValidationGroup="spmtSupplierBill"
                              onblur="this.value=this.value.replace(/\'/g,'');"
                              ToolTip="Enter value for Item Description."
                              MaxLength="500"
                              Width="350px" Height="40px" TextMode="MultiLine"
                              runat="server" />
                            <asp:RequiredFieldValidator
                              ID="RFVBillRemarks"
                              runat="server"
                              ControlToValidate="F_BillRemarks"
                              ErrorMessage="<div class='errorLG'>Required!</div>"
                              Display="Dynamic"
                              EnableClientScript="true"
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_DepartmentID" runat="server" Text="Department :" />&nbsp;
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
                      </table>
                    </td>
                    <td>
                      <table>
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
                              ValidationGroup="spmtSupplierBill"
                              RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
                              Runat="Server" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color: red">*</span>
                          </td>
                          <td>
                            <asp:TextBox ID="F_Quantity"
                              Text='<%# Bind("Quantity") %>'
                              Width="168px"
                              CssClass="mytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEEQuantity"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
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
                              Width="200px"
                              ValidationGroup="spmtSupplierBill"
                              CssClass="myddl"
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
                              ValidationGroup="spmtSupplierBill"
                              SetFocusOnError="true" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_ConversionFactorINR" runat="server" Text="Conversion Factor INR :" /><span style="color: red">*</span>
                          </td>
                          <td>
                            <asp:TextBox ID="F_ConversionFactorINR"
                              Text='<%# Bind("ConversionFactorINR") %>'
                              Width="200px"
                              CssClass="mytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="24"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEEConversionFactorINR"
                              runat="server"
                              Mask="999999.999999"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="false"
                              MinimumValue="0.01"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_AssessableValue" runat="server" Text="Basic / Assessable Value :" /><span style="color: red">*</span>
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_AssessableValue"
                              Text='<%# Bind("AssessableValue") %>'
                              Width="168px"
                              CssClass="mytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEEAssessableValue"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="false"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_IGSTRate" runat="server" Text="IGST Rate :" />
                          </td>
                          <td>
                            <asp:TextBox ID="F_IGSTRate"
                              Text='<%# Bind("IGSTRate") %>'
                              Width="168px"
                              CssClass="dmytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Enabled="false"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEEIGSTRate"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
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
                              Style="text-align: right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEEIGSTAmount"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_CGSTRate" runat="server" Text="CGST Rate :" />
                          </td>
                          <td>
                            <asp:TextBox ID="F_CGSTRate"
                              Text='<%# Bind("CGSTRate") %>'
                              Width="168px"
                              CssClass="dmytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Enabled="false"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEECGSTRate"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_CGSTAmount" runat="server" Text="CGST Amount :" />&nbsp;
                          </td>
                          <td>
                            <asp:TextBox ID="F_CGSTAmount"
                              Text='<%# Bind("CGSTAmount") %>'
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Width="168px"
                              CssClass="mytxt"
                              Style="text-align: right"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEECGSTAmount"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_SGSTRate" runat="server" Text="SGST Rate :" />
                          </td>
                          <td>
                            <asp:TextBox ID="F_SGSTRate"
                              Text='<%# Bind("SGSTRate") %>'
                              Width="168px"
                              CssClass="dmytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Enabled="false"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEESGSTRate"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_SGSTAmount" runat="server" Text="SGST Amount :" />&nbsp;
                          </td>
                          <td>
                            <asp:TextBox ID="F_SGSTAmount"
                              Text='<%# Bind("SGSTAmount") %>'
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Width="168px"
                              CssClass="mytxt"
                              Style="text-align: right"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEESGSTAmount"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_CessRate" runat="server" Text="Cess Rate :" />
                          </td>
                          <td>
                            <asp:TextBox ID="F_CessRate"
                              Text='<%# Bind("CessRate") %>'
                              Width="168px"
                              CssClass="dmytxt"
                              Style="text-align: Right"
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Enabled="false"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEECessRate"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_CessAmount" runat="server" Text="Cess Amount :" />&nbsp;
                          </td>
                          <td>
                            <asp:TextBox ID="F_CessAmount"
                              Text='<%# Bind("CessAmount") %>'
                              ValidationGroup="spmtSupplierBill"
                              MaxLength="20"
                              onfocus="return this.select();"
                              onblur="return validate_tots(this);"
                              Width="168px"
                              CssClass="mytxt"
                              Style="text-align: right"
                              runat="server" />
                            <AJX:MaskedEditExtender
                              ID="MEECessAmount"
                              runat="server"
                              Mask="999999999999.99"
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
                              ValidationGroup="spmtSupplierBill"
                              IsValidEmpty="true"
                              SetFocusOnError="true" />
                          </td>
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
                              Style="text-align: right"
                              runat="server" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_TaxAmount" runat="server" Text="Total GST [INR] :" />&nbsp;
                          </td>
                          <td>
                            <asp:TextBox ID="F_TaxAmount"
                              Text='<%# Bind("TaxAmount") %>'
                              Enabled="False"
                              ToolTip="Value of Total GST [INR]."
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
                              Style="text-align: right"
                              runat="server" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="L_TotalAmountINR" runat="server" Text="Total Amount INR :" />&nbsp;
                          </td>
                          <td>
                            <asp:TextBox ID="F_TotalAmountINR"
                              Text='<%# Bind("TotalAmountINR") %>'
                              Enabled="False"
                              ToolTip="Value of Total Amount INR."
                              Width="168px"
                              CssClass="dmytxt"
                              Style="text-align: right"
                              runat="server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_RemarksGST" runat="server" Text="Remarks GST :" />&nbsp;
                          </td>
                          <td colspan="3">
                            <asp:TextBox ID="F_RemarksGST"
                              Text='<%# Bind("RemarksGST") %>'
                              CssClass="mytxt"
                              onfocus="return this.select();"
                              onblur="this.value=this.value.replace(/\'/g,'');"
                              ToolTip="Enter value for Remarks GST."
                              MaxLength="250"
                              Width="350px" Height="40px" TextMode="MultiLine"
                              runat="server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <asp:Label ID="L_IRReceivedOn" runat="server" Text="IR Received On :" />&nbsp;
                          </td>
                          <td>
                            <asp:TextBox ID="F_IRReceivedOn"
                              Text='<%# Bind("IRReceivedOn") %>'
                              ToolTip="Value of IR Received On."
                              Enabled="False"
                              Width="168px"
                              CssClass="dmytxt"
                              runat="server" />
                          </td>
                          <td class="alignright">
                            <asp:Label ID="Label1" runat="server" Text="Attach / View Document :" />&nbsp;
                          </td>
                          <td>
                            <asp:Button ID="cmdAttach" runat="server" Text="Click to Attach/View" ForeColor="red" OnClientClick='<%# Eval("GetAttachLink") %>' />
                          </td>
                        </tr>
                      </table>
                    </td>
                  </tr>
                </table>
              </div>
            </EditItemTemplate>
          </asp:FormView>
        </ContentTemplate>
      </asp:UpdatePanel>
      <asp:ObjectDataSource
        ID="ODSspmtSupplierBill"
        DataObjectTypeName="SIS.SPMT.spmtSupplierBill"
        SelectMethod="spmtSupplierBillGetByID"
        UpdateMethod="UZ_spmtSupplierBillUpdate"
        DeleteMethod="UZ_spmtSupplierBillDelete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.SPMT.spmtSupplierBill"
        runat="server">
        <SelectParameters>
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="IRNo" Name="IRNo" Type="Int32" />
        </SelectParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
