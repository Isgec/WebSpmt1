<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtDCHeader.aspx.vb" Inherits="EF_spmtDCHeader" title="Edit: Delivery Challan" %>
<asp:Content ID="CPHspmtDCHeader" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtDCHeader" runat="server" Text="&nbsp;Edit: Delivery Challan"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtDCHeader" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtDCHeader"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnablePrint = "True"
    PrintUrl = "../App_Print/RP_spmtDCHeader.aspx?pk="
    ValidationGroup = "spmtDCHeader"
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
<asp:FormView ID="FVspmtDCHeader"
  runat = "server"
  DataKeyNames = "ChallanID"
  DataSourceID = "ODSspmtDCHeader"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ChallanID" runat="server" ForeColor="#CC6633" Text="Challan ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ChallanID"
            Text='<%# Bind("ChallanID") %>'
            ToolTip="Value of Challan ID."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="168px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ChallanDate" runat="server" Text="Challan Date :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ChallanDate"
            Text='<%# Bind("ChallanDate") %>'
            Width="80px"
            CssClass = "mytxt"
            ValidationGroup="spmtDCHeader"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonChallanDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEChallanDate"
            TargetControlID="F_ChallanDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonChallanDate" />
          <AJX:MaskedEditExtender 
            ID = "MEEChallanDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_ChallanDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVChallanDate"
            runat = "server"
            ControlToValidate = "F_ChallanDate"
            ControlExtender = "MEEChallanDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtDCHeader"
            IsValidEmpty = "false"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr><td colspan="4" class="groupHeader" >Delivery Challan Issuer</td></tr>
      <tr><td colspan="4" ><b><i>Select ISGEC GSTIN or Enter Issuer Details</i></b></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IssuerID" runat="server" Text="ISGEC GSTIN :" />
        </td>
        <td>
          <LGM:LC_spmtIsgecGSTIN
            ID="F_IssuerID"
            SelectedValue='<%# Bind("IssuerID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            RequiredFieldErrorMessage = ""
            Runat="Server" />
            <asp:Button ID="cmdIssuerIsgec" runat="server" CommandName="IssuerIsgec" Text=". . ." />
          </td>
        <td class="alignright">
          <asp:Label ID="L_IssuerCompanyName" runat="server" Text="Issuer Company Name :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IssuerCompanyName"
            Text='<%# Bind("IssuerCompanyName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Issuer Company Name."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IssuerAddress1Line" runat="server" Text="Issuer Address Line [1] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IssuerAddress1Line"
            Text='<%# Bind("IssuerAddress1Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Issuer Address Line [1]."
            MaxLength="200"
            Width="350px" 
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_IssuerAddress2Line" runat="server" Text="Issuer Address Line [2] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IssuerAddress2Line"
            Text='<%# Bind("IssuerAddress2Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Issuer Address Line [2]."
            MaxLength="200"
            Width="350px" 
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IssuerPAN" runat="server" Text="Issuer PAN :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IssuerPAN"
            Text='<%# Bind("IssuerPAN") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Issuer PAN."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_IssuerCIN" runat="server" Text="Issuer CIN :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IssuerCIN"
            Text='<%# Bind("IssuerCIN") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Issuer CIN."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="Project :" />
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "myfktxt"
            Width="56px"
            Text='<%# Bind("ProjectID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Project."
            ValidationGroup = "spmtDCHeader"
            onblur= "script_spmtDCHeader.validate_ProjectID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects3_Description") %>'
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
            OnClientItemSelected="script_spmtDCHeader.ACEProjectID_Selected"
            OnClientPopulating="script_spmtDCHeader.ACEProjectID_Populating"
            OnClientPopulated="script_spmtDCHeader.ACEProjectID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_UnitID" runat="server" Text="Unit :" />&nbsp;
        </td>
        <td>
          <LGM:LC_comCompanies
            ID="F_UnitID"
            SelectedValue='<%# Bind("UnitID") %>'
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
          <asp:Label ID="L_PONo" runat="server" Text="PO Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_PONo"
            Text='<%# Bind("PONo") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Purchase Order Number."
            MaxLength="9"
            Width="80px"
            runat="server" />
        </td>
      <td></td><td></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_PlaceOfSupply" runat="server" Text="Place Of Supply :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_PlaceOfSupply"
            SelectedValue='<%# Bind("PlaceOfSupply") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtDCHeader"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_PlaceOfDelivery" runat="server" Text="Place Of Delivery :" /><span style="color:red">*</span>
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_PlaceOfDelivery"
            SelectedValue='<%# Bind("PlaceOfDelivery") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtDCHeader"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr id="taBH_0"><td colspan="2" class="groupHeader" >Consigner</td><td colspan="2" class="groupHeader" >Consignee</td></tr>
      <tr id="taBH_1"><td colspan="4" ><b><i>Select Either ISGEC or Business Parter [Supplier/Customer] as Consigner and Consignee</i></b></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerIsgecID" runat="server" Text="ISGEC GSTIN :" />
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
            RequiredFieldErrorMessage = ""
            Runat="Server" />
            <asp:Button ID="cmdConsignerIsgec" runat="server" CommandName="ConsignerIsgec" Text=". . ." />
          </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeIsgecID" runat="server" Text="ISGEC GSTIN :" />
        </td>
        <td>
          <LGM:LC_spmtIsgecGSTIN
            ID="F_ConsigneeIsgecID"
            SelectedValue='<%# Bind("ConsigneeIsgecID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            RequiredFieldErrorMessage = ""
            Runat="Server" />
            <asp:Button ID="cmdConsineeIsgec" runat="server" CommandName="ConsigneeIsgec" Text=". . ." />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerBPID" runat="server" Text="BP :" />
        </td>
        <td>
          <asp:TextBox
            ID = "F_ConsignerBPID"
            CssClass = "myfktxt"
            Width="80px"
            Text='<%# Bind("ConsignerBPID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Consigner BP ID."
            ValidationGroup = "spmtDCHeader"
            onblur= "script_spmtDCHeader.validate_ConsignerBPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ConsignerBPID_Display"
            Text='<%# Eval("VR_BusinessPartner15_BPName") %>'
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
            OnClientItemSelected="script_spmtDCHeader.ACEConsignerBPID_Selected"
            OnClientPopulating="script_spmtDCHeader.ACEConsignerBPID_Populating"
            OnClientPopulated="script_spmtDCHeader.ACEConsignerBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeBPID" runat="server" Text="BP :" />
        </td>
        <td>
          <asp:TextBox
            ID = "F_ConsigneeBPID"
            CssClass = "myfktxt"
            Width="80px"
            Text='<%# Bind("ConsigneeBPID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Consignee BP ID."
            ValidationGroup = "spmtDCHeader"
            onblur= "script_spmtDCHeader.validate_ConsigneeBPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ConsigneeBPID_Display"
            Text='<%# Eval("VR_BusinessPartner17_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEConsigneeBPID"
            BehaviorID="B_ACEConsigneeBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ConsigneeBPIDCompletionList"
            TargetControlID="F_ConsigneeBPID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtDCHeader.ACEConsigneeBPID_Selected"
            OnClientPopulating="script_spmtDCHeader.ACEConsigneeBPID_Populating"
            OnClientPopulated="script_spmtDCHeader.ACEConsigneeBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerGSTIN" runat="server" Text="BP GSTIN :" />
        </td>
        <td>
          <asp:TextBox
            ID = "F_ConsignerGSTIN"
            CssClass = "myfktxt"
            Width="88px"
            Text='<%# Bind("ConsignerGSTIN") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Consigner GSTIN."
            ValidationGroup = "spmtDCHeader"
            onblur= "script_spmtDCHeader.validate_ConsignerGSTIN(this);"
            Runat="Server" />
            <asp:Button ID="cmdConsignerBPGstin" runat="server" CommandName="ConsignerBPGstin" Text=". . ." />
          <asp:Label
            ID = "F_ConsignerGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN13_Description") %>'
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
            OnClientItemSelected="script_spmtDCHeader.ACEConsignerGSTIN_Selected"
            OnClientPopulating="script_spmtDCHeader.ACEConsignerGSTIN_Populating"
            OnClientPopulated="script_spmtDCHeader.ACEConsignerGSTIN_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeGSTIN" runat="server" Text="BP GSTIN :" />
        </td>
        <td>
          <asp:TextBox
            ID = "F_ConsigneeGSTIN"
            CssClass = "myfktxt"
            Width="88px"
            Text='<%# Bind("ConsigneeGSTIN") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Consignee GSTIN."
            ValidationGroup = "spmtDCHeader"
            onblur= "script_spmtDCHeader.validate_ConsigneeGSTIN(this);"
            Runat="Server" />
            <asp:Button ID="cmdConsigneeBPGstin" runat="server" CommandName="ConsigneeBPGstin" Text=". . ." />
          <asp:Label
            ID = "F_ConsigneeGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN14_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEConsigneeGSTIN"
            BehaviorID="B_ACEConsigneeGSTIN"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ConsigneeGSTINCompletionList"
            TargetControlID="F_ConsigneeGSTIN"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtDCHeader.ACEConsigneeGSTIN_Selected"
            OnClientPopulating="script_spmtDCHeader.ACEConsigneeGSTIN_Populating"
            OnClientPopulated="script_spmtDCHeader.ACEConsigneeGSTIN_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr id="taBH_3"><td colspan="4" ><b><i>If Consigner OR Consignee NOT found in above list, then, Enter Details.</i></b></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerName" runat="server" Text="Name :" />
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerName"
            Text='<%# Bind("ConsignerName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consigner Name."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeName" runat="server" Text="Name :" />
        </td>
        <td>
          <asp:TextBox ID="F_ConsigneeName"
            Text='<%# Bind("ConsigneeName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consignee Name."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerGSTINNo" runat="server" Text="GSTIN :" />
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerGSTINNo"
            Text='<%# Bind("ConsignerGSTINNo") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consigner GSTIN No."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeGSTINNo" runat="server" Text="GSTIN :" />
        </td>
        <td>
          <asp:TextBox ID="F_ConsigneeGSTINNo"
            Text='<%# Bind("ConsigneeGSTINNo") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consignee GSTIN No."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerAddress1Line" runat="server" Text="Address Line [1] :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerAddress1Line"
            Text='<%# Bind("ConsignerAddress1Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consigner Address Line [1]."
            MaxLength="100"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConsignerAddress1Line"
            runat = "server"
            ControlToValidate = "F_ConsignerAddress1Line"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtDCHeader"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeAddress1Line" runat="server" Text="Address Line [1] :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ConsigneeAddress1Line"
            Text='<%# Bind("ConsigneeAddress1Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consignee Address Line [1]."
            MaxLength="100"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVConsigneeAddress1Line"
            runat = "server"
            ControlToValidate = "F_ConsigneeAddress1Line"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtDCHeader"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerAddress2Line" runat="server" Text="Address Line [2] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerAddress2Line"
            Text='<%# Bind("ConsignerAddress2Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consigner Address Line [2]."
            MaxLength="100"
            Width="350px" 
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeAddress2Line" runat="server" Text="Address Line [2] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ConsigneeAddress2Line"
            Text='<%# Bind("ConsigneeAddress2Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consignee Address Line [2]."
            MaxLength="100"
            Width="350px" 
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerAddress3Line" runat="server" Text="Address Line [3] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerAddress3Line"
            Text='<%# Bind("ConsignerAddress3Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consigner Address Line [3]."
            MaxLength="100"
            Width="350px" 
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeAddress3Line" runat="server" Text="Address Line [3] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ConsigneeAddress3Line"
            Text='<%# Bind("ConsigneeAddress3Line") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Consignee Address Line [3]."
            MaxLength="100"
            Width="350px" 
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerStateID" runat="server" Text="Consigner State :" />&nbsp;
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
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_ConsigneeStateID" runat="server" Text="Consignee State :" />&nbsp;
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_ConsigneeStateID"
            SelectedValue='<%# Bind("ConsigneeStateID") %>'
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
      <tr id="taBH_0"><td colspan="4" class="groupHeader" >Other Details</td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Purpose" runat="server" Text="Purpose of Sending Materials: :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Purpose"
            Text='<%# Bind("Purpose") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtDCHeader"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Purpose of Sending Materials:."
            MaxLength="250"
            Width="350px" Height="40px" TextMode="MultiLine"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVPurpose"
            runat = "server"
            ControlToValidate = "F_Purpose"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtDCHeader"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ExpectedReturnDate" runat="server" Text="Expected Date of Return / Outward Movement :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ExpectedReturnDate"
            Text='<%# Bind("ExpectedReturnDate") %>'
            Width="80px"
            CssClass = "mytxt"
            ValidationGroup="spmtDCHeader"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonExpectedReturnDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEExpectedReturnDate"
            TargetControlID="F_ExpectedReturnDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonExpectedReturnDate" />
          <AJX:MaskedEditExtender 
            ID = "MEEExpectedReturnDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_ExpectedReturnDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVExpectedReturnDate"
            runat = "server"
            ControlToValidate = "F_ExpectedReturnDate"
            ControlExtender = "MEEExpectedReturnDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtDCHeader"
            IsValidEmpty = "false"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ModeOfTransportID" runat="server" Text="Mode Of Transport :" />&nbsp;
        </td>
        <td>
          <LGM:LC_spmtModeOfTransport
            ID="F_ModeOfTransportID"
            SelectedValue='<%# Bind("ModeOfTransportID") %>'
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
          <asp:Label ID="L_VehicleNo" runat="server" Text="Vehicle Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_VehicleNo"
            Text='<%# Bind("VehicleNo") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Vehicle Number."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_GRNo" runat="server" Text="GR Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_GRNo"
            Text='<%# Bind("GRNo") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for GR Number."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_GRDate" runat="server" Text="GR Date :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_GRDate"
            Text='<%# Bind("GRDate") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonGRDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEGRDate"
            TargetControlID="F_GRDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonGRDate" />
          <AJX:MaskedEditExtender 
            ID = "MEEGRDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_GRDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVGRDate"
            runat = "server"
            ControlToValidate = "F_GRDate"
            ControlExtender = "MEEGRDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TransporterID" runat="server" Text="Transporter :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_TransporterID"
            CssClass = "myfktxt"
            Width="80px"
            Text='<%# Bind("TransporterID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Transporter."
            onblur= "script_spmtDCHeader.validate_TransporterID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_TransporterID_Display"
            Text='<%# Eval("VR_BusinessPartner16_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACETransporterID"
            BehaviorID="B_ACETransporterID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="TransporterIDCompletionList"
            TargetControlID="F_TransporterID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtDCHeader.ACETransporterID_Selected"
            OnClientPopulating="script_spmtDCHeader.ACETransporterID_Populating"
            OnClientPopulated="script_spmtDCHeader.ACETransporterID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TransporterName" runat="server" Text="Transporter Name :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TransporterName"
            Text='<%# Bind("TransporterName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Transporter Name."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_FromPlace" runat="server" Text="From Place :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_FromPlace"
            Text='<%# Bind("FromPlace") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for From Place."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ToPlace" runat="server" Text="To Place :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ToPlace"
            Text='<%# Bind("ToPlace") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for To Place."
            MaxLength="50"
            Width="408px"
            runat="server" />
        </td>
      </tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtDCDetails" runat="server" Text="&nbsp;List: Delivery Challan Items"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtDCDetails" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtDCDetails"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtDCDetails.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtDCDetails.aspx"
      AddPostBack = "True"
      EnableExit = "false"
      ValidationGroup = "spmtDCDetails"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtDCDetails" runat="server" AssociatedUpdatePanelID="UPNLspmtDCDetails" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtDCDetails" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtDCDetails" DataKeyNames="ChallanID,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Serial No" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description of Goods" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits3_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits3_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Taxable Value of goods/Service (After discount or abatement)" SortExpression="AssessableValue">
          <ItemTemplate>
            <asp:Label ID="LabelAssessableValue" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AssessableValue") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total GST" SortExpression="TotalGST">
          <ItemTemplate>
            <asp:Label ID="LabelTotalGST" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalGST") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount" SortExpression="TotalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtDCDetails"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtDCDetails"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtDCDetailsSelectList"
      TypeName = "SIS.SPMT.spmtDCDetails"
      SelectCountMethod = "spmtDCDetailsSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_ChallanID" PropertyName="Text" Name="ChallanID" Type="String" Size="20" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtDCDetails" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtDCHeader"
  DataObjectTypeName = "SIS.SPMT.spmtDCHeader"
  SelectMethod = "spmtDCHeaderGetByID"
  UpdateMethod="UZ_spmtDCHeaderUpdate"
  DeleteMethod="UZ_spmtDCHeaderDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtDCHeader"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ChallanID" Name="ChallanID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
