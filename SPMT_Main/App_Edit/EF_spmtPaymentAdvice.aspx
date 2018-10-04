<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtPaymentAdvice.aspx.vb" Inherits="EF_spmtPaymentAdvice" title="Edit: Payment Advice" %>
<asp:Content ID="CPHspmtPaymentAdvice" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtPaymentAdvice" runat="server" Text="&nbsp;Edit: Payment Advice"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPaymentAdvice" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtPaymentAdvice"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnablePrint = "True"
    PrintUrl = "../App_Print/RP_spmtPaymentAdvice.aspx?pk="
    ValidationGroup = "spmtPaymentAdvice"
    runat = "server" />
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        url = o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
<asp:FormView ID="FVspmtPaymentAdvice"
  runat = "server"
  DataKeyNames = "AdviceNo"
  DataSourceID = "ODSspmtPaymentAdvice"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
      <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AdviceNo" runat="server" ForeColor="#CC6633" Text="Advice No :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_AdviceNo"
            Text='<%# Bind("AdviceNo") %>'
            ToolTip="Value of Advice No."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
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
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="Supplier :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "myfktxt"
            Text='<%# Bind("BPID") %>'
            AutoCompleteType = "None"
            Width="80px"
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
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConcernedHOD" runat="server" Text="Concerned HOD :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ConcernedHOD"
            CssClass = "myfktxt"
            Text='<%# Bind("ConcernedHOD") %>'
            AutoCompleteType = "None"
            Width="72px"
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
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
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
        <td class="alignright">
          <asp:Label ID="L_ElementID" runat="server" Text="Element :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ElementID"
            CssClass = "myfktxt"
            Text='<%# Bind("ElementID") %>'
            AutoCompleteType = "None"
            Width="72px"
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
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_EmployeeID" runat="server" Text="Employee :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_EmployeeID"
            CssClass = "myfktxt"
            Text='<%# Bind("EmployeeID") %>'
            AutoCompleteType = "None"
            Width="72px"
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
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Remarks" runat="server" Text="Remarks :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_Remarks"
            Text='<%# Bind("Remarks") %>'
            Width="350px" Height="40px" TextMode="MultiLine"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Remarks."
            MaxLength="500"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_RemarksAC" runat="server" Text="Accounts Remarks :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RemarksAC"
            Text='<%# Bind("RemarksAC") %>'
            ToolTip="Value of Accounts Remarks."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdviceStatusUser" runat="server" Text="Created By :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceStatusUser"
            Width="72px"
            Text='<%# Bind("AdviceStatusUser") %>'
            Enabled = "False"
            ToolTip="Value of Created By."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceStatusUser_Display"
            Text='<%# Eval("aspnet_users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AdviceStatusOn" runat="server" Text="Created On :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AdviceStatusOn"
            Text='<%# Bind("AdviceStatusOn") %>'
            ToolTip="Value of Created On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdviceStatusID" runat="server" Text="Advice Status :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceStatusID"
            Width="88px"
            Text='<%# Bind("AdviceStatusID") %>'
            Enabled = "False"
            ToolTip="Value of Advice Status."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceStatusID_Display"
            Text='<%# Eval("SPMT_PAStatus9_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CostCenter" runat="server" Text="Total Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CostCenter"
            Text='<%# Bind("CostCenter") %>'
            ToolTip="Value of Total Amount."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_DocumentNo" runat="server" Text="Voucher Type :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_DocumentNo"
            Text='<%# Bind("DocumentNo") %>'
            ToolTip="Value of Voucher Type."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BaaNCompany" runat="server" Text="Voucher No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BaaNCompany"
            Text='<%# Bind("BaaNCompany") %>'
            ToolTip="Value of Voucher No."
            Enabled = "False"
            Width="88px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaaNLedger" runat="server" Text="BaaN Company :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaaNLedger"
            Text='<%# Bind("BaaNLedger") %>'
            ToolTip="Value of BaaN Company."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
<%--        <td class="alignright">
          <asp:Label ID="Label1" runat="server" Text="View Documents Attched with Bills :" />&nbsp;
        </td>
        <td>
          <asp:Button ID="cmdAttach" runat="server" Text="Click to View Documents" ForeColor="red" OnClientClick='<%# Eval("GetAttachLink") %>' />
        </td>--%>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
    </div>
    <fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtPaymentAdviceSupplierBill" runat="server" Text="&nbsp;List: Selected Bills"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPaymentAdviceSupplierBill" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtPaymentAdviceSupplierBill"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtSupplierBill.aspx"
      EnableAdd = "False"
      EnableExit = "false"
      ValidationGroup = "spmtPaymentAdviceSupplierBill"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtPaymentAdviceSupplierBill" runat="server" AssociatedUpdatePanelID="UPNLspmtPaymentAdviceSupplierBill" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtPaymentAdviceSupplierBill" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtPaymentAdviceSupplierBill" DataKeyNames="IRNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="IR No" SortExpression="IRNo">
          <ItemTemplate>
            <asp:Label ID="LabelIRNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("IRNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran.Type" SortExpression="SPMT_TranTypes16_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes16_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier" SortExpression="VR_BusinessPartner18_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner18_BPName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Number" SortExpression="BillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelBillNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Date" SortExpression="BillDate">
          <ItemTemplate>
            <asp:Label ID="LabelBillDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Amount" SortExpression="BillAmount">
          <ItemTemplate>
            <asp:Label ID="LabelBillAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Attatched Documents">
          <ItemTemplate>
            <asp:ImageButton ID="cmdAttach" runat="server" AlternateText='<%# Eval("PrimaryKey") %>' ToolTip="View Attached documents." SkinID="attach" OnClientClick='<%# Eval("GetAttachLink") %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="REMOVE">
          <ItemTemplate>
            <asp:ImageButton ID="cmdRejectWF" ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("RejectWFVisible") %>' Enabled='<%# EVal("RejectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Remove from payment advice" SkinID="reject" OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Remove record ?"");" %>' CommandName="RejectWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtPaymentAdviceSupplierBill"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtPaymentAdviceSupplierBill"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtPaymentAdviceSupplierBillSelectList"
      TypeName = "SIS.SPMT.spmtPaymentAdviceSupplierBill"
      SelectCountMethod = "spmtPaymentAdviceSupplierBillSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_AdviceNo" PropertyName="Text" Name="AdviceNo" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtPaymentAdviceSupplierBill" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
    <asp:Panel ID="pnlPending" runat="server" Visible='<%# BillSelectable %>'>
      <fieldset class="ui-widget-content page" >
<legend>
    <asp:Label ID="LabelspmtUnlinkedSupplierBill" runat="server" Text="&nbsp;List: Pending Bills"></asp:Label>
</legend>
<div class="pagedata" >
<asp:UpdatePanel ID="UPNLspmtUnlinkedSupplierBill" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtUnlinkedSupplierBill"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtUnlinkedSupplierBill.aspx"
      EnableAdd = "False"
      EnableExit = "false"
      ValidationGroup = "spmtUnlinkedSupplierBill"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtUnlinkedSupplierBill" runat="server" AssociatedUpdatePanelID="UPNLspmtUnlinkedSupplierBill" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtUnlinkedSupplierBill" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtUnlinkedSupplierBill" DataKeyNames="IRNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="IR No" SortExpression="IRNo">
          <ItemTemplate>
            <asp:Label ID="LabelIRNo" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("IRNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran.Type" SortExpression="SPMT_TranTypes16_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes16_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier" SortExpression="VR_BusinessPartner18_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner18_BPName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Number" SortExpression="BillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelBillNumber" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("BillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Date" SortExpression="BillDate">
          <ItemTemplate>
            <asp:Label ID="LabelBillDate" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("BillDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Amount" SortExpression="BillAmount">
          <ItemTemplate>
            <asp:Label ID="LabelBillAmount" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("BillAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Attatched Documents">
          <ItemTemplate>
            <asp:ImageButton ID="cmdAttach" runat="server" AlternateText='<%# Eval("PrimaryKey") %>' ToolTip="View Attached documents." SkinID="attach" OnClientClick='<%# Eval("GetAttachLink") %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SELECT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server"  Enabled='<%# EVal("ApproveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Select in payment advice" SkinID="approve" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Select record ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtUnlinkedSupplierBill"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtUnlinkedSupplierBill"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtUnlinkedSupplierBillSelectList"
      TypeName = "SIS.SPMT.spmtUnlinkedSupplierBill"
      SelectCountMethod = "spmtUnlinkedSupplierBillSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
        <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
        <asp:ControlParameter ControlID="F_SupplierName" PropertyName="Text" Name="SupplierName" Type="String" Size="100" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtUnlinkedSupplierBill" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
    </asp:Panel>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtPaymentAdvice"
  DataObjectTypeName = "SIS.SPMT.spmtPaymentAdvice"
  SelectMethod = "spmtPaymentAdviceGetByID"
  UpdateMethod="UZ_spmtPaymentAdviceUpdate"
  DeleteMethod="UZ_spmtPaymentAdviceDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtPaymentAdvice"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="AdviceNo" Name="AdviceNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
