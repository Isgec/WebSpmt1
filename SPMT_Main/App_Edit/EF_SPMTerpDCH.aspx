<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_SPMTerpDCH.aspx.vb" Inherits="EF_SPMTerpDCH" title="Edit: ERP Delivery Challan" %>
<asp:Content ID="CPHSPMTerpDCH" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCH" runat="server" Text="&nbsp;Edit: ERP Delivery Challan"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCH" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCH"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "SPMTerpDCH"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCH"
  runat = "server"
  DataKeyNames = "ChallanID"
  DataSourceID = "ODSSPMTerpDCH"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ChallanID" runat="server" ForeColor="#CC6633" Text="Challan ID :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_ChallanID"
            Text='<%# Bind("ChallanID") %>'
            ToolTip="Value of Challan ID."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="168px"
            runat="server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="Label1" ForeColor="#CC6633" runat="server" Text="Challan Type :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:DropDownList
            ID="F_DCType"
            SelectedValue='<%# Bind("DCType") %>'
            ValidationGroup="spmtDCHeader"
            CssClass = "mypktxt"
            Width="200px"
            Enabled="false"
            runat="server">
            <asp:ListItem Selected="True" Value="J" Text="Jobwork"></asp:ListItem>
            <asp:ListItem Value="S" Text="Supply/Site Transfer"></asp:ListItem>
          </asp:DropDownList>
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
            onblur= "script_SPMTerpDCH.validate_ProjectID(this);"
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
            OnClientItemSelected="script_SPMTerpDCH.ACEProjectID_Selected"
            OnClientPopulating="script_SPMTerpDCH.ACEProjectID_Populating"
            OnClientPopulated="script_SPMTerpDCH.ACEProjectID_Populated"
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
            onblur= "script_SPMTerpDCH.validate_ConsignerBPID(this);"
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
            OnClientItemSelected="script_SPMTerpDCH.ACEConsignerBPID_Selected"
            OnClientPopulating="script_SPMTerpDCH.ACEConsignerBPID_Populating"
            OnClientPopulated="script_SPMTerpDCH.ACEConsignerBPID_Populated"
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
            onblur= "script_SPMTerpDCH.validate_ConsigneeBPID(this);"
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
            OnClientItemSelected="script_SPMTerpDCH.ACEConsigneeBPID_Selected"
            OnClientPopulating="script_SPMTerpDCH.ACEConsigneeBPID_Populating"
            OnClientPopulated="script_SPMTerpDCH.ACEConsigneeBPID_Populated"
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
            onblur= "script_SPMTerpDCH.validate_ConsignerGSTIN(this);"
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
            OnClientItemSelected="script_SPMTerpDCH.ACEConsignerGSTIN_Selected"
            OnClientPopulating="script_SPMTerpDCH.ACEConsignerGSTIN_Populating"
            OnClientPopulated="script_SPMTerpDCH.ACEConsignerGSTIN_Populated"
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
            onblur= "script_SPMTerpDCH.validate_ConsigneeGSTIN(this);"
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
            OnClientItemSelected="script_SPMTerpDCH.ACEConsigneeGSTIN_Selected"
            OnClientPopulating="script_SPMTerpDCH.ACEConsigneeGSTIN_Populating"
            OnClientPopulated="script_SPMTerpDCH.ACEConsigneeGSTIN_Populated"
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
            onblur= "script_SPMTerpDCH.validate_TransporterID(this);"
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
            OnClientItemSelected="script_SPMTerpDCH.ACETransporterID_Selected"
            OnClientPopulating="script_SPMTerpDCH.ACETransporterID_Populating"
            OnClientPopulated="script_SPMTerpDCH.ACETransporterID_Populated"
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
    <asp:Label ID="LabelSPMTerpDCD" runat="server" Text="&nbsp;Delivery Challan Item(s)"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCD" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLSPMTerpDCD"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_SPMTerpDCD.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_SPMTerpDCD.aspx?skip=1"
      AddPostBack = "True"
      EnableExit = "false"
      ValidationGroup = "SPMTerpDCD"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSSPMTerpDCD" runat="server" AssociatedUpdatePanelID="UPNLSPMTerpDCD" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVSPMTerpDCD" SkinID="gv_silver" runat="server" DataSourceID="ODSSPMTerpDCD" DataKeyNames="ChallanID,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SerialNo" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ItemDescription" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
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
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="AssessableValue" SortExpression="AssessableValue">
          <ItemTemplate>
            <asp:Label ID="LabelAssessableValue" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AssessableValue") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TotalGST" SortExpression="TotalGST">
          <ItemTemplate>
            <asp:Label ID="LabelTotalGST" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalGST") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TotalAmount" SortExpression="TotalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Delete">
          <ItemTemplate>
            <asp:ImageButton ID="cmdRejectWF" ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("RejectWFVisible") %>' Enabled='<%# EVal("RejectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Reject" SkinID="delete" OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Delete from Delivery Challan ?"");" %>' CommandName="RejectWF" CommandArgument='<%# Container.DataItemIndex %>' />
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
      ID = "ODSSPMTerpDCD"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.SPMTerpDCD"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_SPMTerpDCDSelectList"
      TypeName = "SIS.SPMT.SPMTerpDCD"
      SelectCountMethod = "SPMTerpDCDSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVSPMTerpDCD" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
<fieldset class="ui-widget-content page" runat="server" visible='<%# Editable %>' >
<legend>
    <asp:Label ID="LabelSPMTerpDCIPending" runat="server" Text="&nbsp;Select Items from Suppplier's Stock"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCIPending" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLSPMTerpDCIPending"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_SPMTerpDCIPending.aspx"
      EnableAdd="false"
      EnableExit = "false"
      ValidationGroup = "SPMTerpDCIPending"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSSPMTerpDCIPending" runat="server" AssociatedUpdatePanelID="UPNLSPMTerpDCIPending" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVSPMTerpDCIPending" SkinID="gv_silver" runat="server" DataSourceID="ODSSPMTerpDCIPending" DataKeyNames="ChallanID,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="VIEW">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="info" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ChallanID" SortExpression="ChallanID">
          <ItemTemplate>
             <asp:Label ID="L_ChallanID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ChallanID") %>' Text='<%# Eval("ChallanID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="60px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SerialNo" SortExpression="SerialNo">
          <ItemTemplate>
             <asp:Label ID="L_SerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SerialNo") %>' Text='<%# Eval("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="60px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ItemDescription" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BaseRate" SortExpression="BaseRate">
          <ItemTemplate>
            <asp:Label ID="LabelBaseRate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaseRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits5_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits5_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Price" SortExpression="Price">
          <ItemTemplate>
            <asp:Label ID="LabelPrice" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Price") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FinalRate" SortExpression="FinalRate">
          <ItemTemplate>
            <asp:Label ID="LabelFinalRate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FinalRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FinalAmount" SortExpression="FinalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelFinalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FinalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ProjectID" SortExpression="IDM_Projects1_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Select">
          <ItemTemplate>
            <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ApproveWFVisible") %>' Enabled='<%# EVal("ApproveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Select" SkinID="complete" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Add in Delivery Challan ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
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
      ID = "ODSSPMTerpDCIPending"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.SPMTerpDCIPending"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_SPMTerpDCIPendingSelectList"
      TypeName = "SIS.SPMT.SPMTerpDCIPending"
      SelectCountMethod = "SPMTerpDCIPendingSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVSPMTerpDCIPending" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSSPMTerpDCH"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCH"
  SelectMethod = "SPMTerpDCHGetByID"
  UpdateMethod="UZ_SPMTerpDCHUpdate"
  DeleteMethod="UZ_SPMTerpDCHDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCH"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ChallanID" Name="ChallanID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
