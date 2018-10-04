<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtPaymentAdvice.aspx.vb" Inherits="AF_spmtPaymentAdvice" title="Add: Payment Advice" %>
<asp:Content ID="CPHspmtPaymentAdvice" ContentPlaceHolderID="cph1" Runat="Server">
<%--<script type="text/javascript">
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
	    if (parseFloat(CessRate.value)>0)
	      CessAmount.value = (parseFloat(CessRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
	    if (parseFloat(IGSTRate.value)>0)
	      IGSTAmount.value = (parseFloat(IGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
	    if (parseFloat(SGSTRate.value)>0)
	      SGSTAmount.value = (parseFloat(SGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
	    if (parseFloat(CGSTRate.value)>0)
	      CGSTAmount.value = (parseFloat(CGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(2);
	    TotalGST.value = (parseFloat(CessAmount.value) + parseFloat(IGSTAmount.value) + parseFloat(SGSTAmount.value) + parseFloat(CGSTAmount.value)).toFixed(2);
			TotalGSTINR.value = (parseFloat(TotalGST.value) * parseFloat(ConversionFactorINR.value)).toFixed(2);
			TotalAmount.value = (parseFloat(AssessableValue.value) + parseFloat(TotalGST.value)).toFixed(2);
			TotalAmountINR.value = (parseFloat(TotalAmount.value) * parseFloat(ConversionFactorINR.value)).toFixed(2);
		} catch (e) { }
	}
</script>--%>
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtPaymentAdvice" runat="server" Text="&nbsp;Add: Payment Advice"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPaymentAdvice" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtPaymentAdvice"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/SPMT_Main/App_Edit/EF_spmtPaymentAdvice.aspx"
    ValidationGroup = "spmtPaymentAdvice"
    runat = "server" />
<asp:FormView ID="FVspmtPaymentAdvice"
  runat = "server"
  DataKeyNames = "AdviceNo"
  DataSourceID = "ODSspmtPaymentAdvice"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtPaymentAdvice" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AdviceNo" ForeColor="#CC6633" runat="server" Text="Advice No :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_AdviceNo" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type ID :" /><span style="color:red">*</span>
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
            ValidationGroup = "spmtPaymentAdvice"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="Supplier :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "myfktxt"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Supplier."
            ValidationGroup = "spmtPaymentAdvice"
            onblur= "script_spmtPaymentAdvice.validate_BPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner11_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
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
            OnClientItemSelected="script_spmtPaymentAdvice.ACEBPID_Selected"
            OnClientPopulating="script_spmtPaymentAdvice.ACEBPID_Populating"
            OnClientPopulated="script_spmtPaymentAdvice.ACEBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SupplierName" runat="server" Text="Supplier Name :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_SupplierName"
            Text='<%# Bind("SupplierName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtSupplierBill"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            MaxLength="100"
            Width="350px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConcernedHOD" runat="server" Text="Concerned HOD :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ConcernedHOD"
            CssClass = "myfktxt"
            Width="72px"
            Text='<%# Bind("ConcernedHOD") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Concerned HOD."
            ValidationGroup = "spmtPaymentAdvice"
            onblur= "script_spmtPaymentAdvice.validate_ConcernedHOD(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConcernedHOD"
            runat = "server"
            ControlToValidate = "F_ConcernedHOD"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtPaymentAdvice"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_ConcernedHOD_Display"
            Text='<%# Eval("aspnet_users2_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEConcernedHOD"
            BehaviorID="B_ACEConcernedHOD"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ConcernedHODCompletionList"
            TargetControlID="F_ConcernedHOD"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtPaymentAdvice.ACEConcernedHOD_Selected"
            OnClientPopulating="script_spmtPaymentAdvice.ACEConcernedHOD_Populating"
            OnClientPopulated="script_spmtPaymentAdvice.ACEConcernedHOD_Populated"
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
        <td colspan="3">
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "myfktxt"
            Width="56px"
            Text='<%# Bind("ProjectID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Project."
            onblur= "script_spmtPaymentAdvice.validate_ProjectID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects5_Description") %>'
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
            OnClientItemSelected="script_spmtPaymentAdvice.ACEProjectID_Selected"
            OnClientPopulating="script_spmtPaymentAdvice.ACEProjectID_Populating"
            OnClientPopulated="script_spmtPaymentAdvice.ACEProjectID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ElementID" runat="server" Text="Element :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ElementID"
            CssClass = "myfktxt"
            Width="72px"
            Text='<%# Bind("ElementID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Element."
            onblur= "script_spmtPaymentAdvice.validate_ElementID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ElementID_Display"
            Text='<%# Eval("IDM_WBS6_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEElementID"
            BehaviorID="B_ACEElementID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ElementIDCompletionList"
            TargetControlID="F_ElementID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtPaymentAdvice.ACEElementID_Selected"
            OnClientPopulating="script_spmtPaymentAdvice.ACEElementID_Populating"
            OnClientPopulated="script_spmtPaymentAdvice.ACEElementID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CostCenterID" runat="server" Text="Cost Center :" />&nbsp;
        </td>
        <td colspan="3">
          <LGM:LC_spmtCostCenters
            ID="F_CostCenterID"
            SelectedValue='<%# Bind("CostCenterID") %>'
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
          <asp:Label ID="L_EmployeeID" runat="server" Text="Employee :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_EmployeeID"
            CssClass = "myfktxt"
            Width="72px"
            Text='<%# Bind("EmployeeID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Employee."
            onblur= "script_spmtPaymentAdvice.validate_EmployeeID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_EmployeeID_Display"
            Text='<%# Eval("aspnet_users3_UserFullName") %>'
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
            OnClientItemSelected="script_spmtPaymentAdvice.ACEEmployeeID_Selected"
            OnClientPopulating="script_spmtPaymentAdvice.ACEEmployeeID_Populating"
            OnClientPopulated="script_spmtPaymentAdvice.ACEEmployeeID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdvanceRate" runat="server" Text="Advance Rate :" />
        </td>
        <td>
          <asp:TextBox ID="F_AdvanceRate"
            Text='<%# Bind("AdvanceRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup = "spmtPaymentAdvice"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAdvanceRate"
            runat = "server"
            mask = "999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AdvanceRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAdvanceRate"
            runat = "server"
            ControlToValidate = "F_AdvanceRate"
            ControlExtender = "MEEAdvanceRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtPaymentAdvice"
            IsValidEmpty = "true"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AdvanceAmount" runat="server" Text="Advance Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AdvanceAmount"
            Text='<%# Bind("AdvanceAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: right"
            ValidationGroup = "spmtPaymentAdvice"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAdvanceAmount"
            runat = "server"
            mask = "999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AdvanceAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAdvanceAmount"
            runat = "server"
            ControlToValidate = "F_AdvanceAmount"
            ControlExtender = "MEEAdvanceAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtPaymentAdvice"
            IsValidEmpty = "true"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_RetensionRate" runat="server" Text="Retension Rate :" />
        </td>
        <td>
          <asp:TextBox ID="F_RetensionRate"
            Text='<%# Bind("RetensionRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup = "spmtPaymentAdvice"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEERetensionRate"
            runat = "server"
            mask = "999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_RetensionRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVRetensionRate"
            runat = "server"
            ControlToValidate = "F_RetensionRate"
            ControlExtender = "MEERetensionRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtPaymentAdvice"
            IsValidEmpty = "true"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_RetensionAmount" runat="server" Text="Retension Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RetensionAmount"
            Text='<%# Bind("RetensionAmount") %>'
            ValidationGroup = "spmtPaymentAdvice"
            MaxLength="20"
            onfocus = "return this.select();"
            Width="168px"
            CssClass = "mytxt"
            style="text-align: right"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEERetensionAmount"
            runat = "server"
            mask = "999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_RetensionAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVRetensionAmount"
            runat = "server"
            ControlToValidate = "F_RetensionAmount"
            ControlExtender = "MEERetensionAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtPaymentAdvice"
            IsValidEmpty = "true"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Remarks" runat="server" Text="Remarks :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Remarks"
            Text='<%# Bind("Remarks") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Remarks."
            MaxLength="500"
            Width="350px" Height="40px" TextMode="MultiLine"
            runat="server" />
        </td>
      </tr>
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtPaymentAdvice"
  DataObjectTypeName = "SIS.SPMT.spmtPaymentAdvice"
  InsertMethod="UZ_spmtPaymentAdviceInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtPaymentAdvice"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
