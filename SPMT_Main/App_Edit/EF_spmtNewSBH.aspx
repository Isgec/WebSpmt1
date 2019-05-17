<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtNewSBH.aspx.vb" Inherits="EF_spmtNewSBH" title="Edit: *Supplier Bill" %>
<asp:Content ID="CPHspmtNewSBH" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtNewSBH" runat="server" Text="&nbsp;Edit: *Supplier Bill"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtNewSBH" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtNewSBH"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtNewSBH"
    runat = "server" />
<asp:FormView ID="FVspmtNewSBH"
  runat = "server"
  DataKeyNames = "IRNo"
  DataSourceID = "ODSspmtNewSBH"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_IRNo" runat="server" ForeColor="#CC6633" Text="IR No :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_IRNo"
            Text='<%# Bind("IRNo") %>'
            ToolTip="Value of IR No."
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
          <asp:Label ID="L_PurchaseType" runat="server" Text="Purchase Type :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:DropDownList
            ID="F_PurchaseType"
            SelectedValue='<%# Bind("PurchaseType") %>'
            CssClass = "myddl"
            Width="200px"
            ValidationGroup = "spmtNewSBH"
            Runat="Server" >
            <asp:ListItem Value=" ">---Select---</asp:ListItem>
            <asp:ListItem Value="Purchase from Registered Dealer">Registered Dealer-ITC</asp:ListItem>
            <asp:ListItem Value="Purchase from Registered Dealer-No ITC">Registered Dealer-No ITC</asp:ListItem>
            <asp:ListItem Value="Purchase from Composition Dealer">Composition Dealer</asp:ListItem>
            <asp:ListItem Value="Purchase from Unregistered Dealer">Unregistered Dealer</asp:ListItem>
            <asp:ListItem Value="Non GST expenses bill">Non GST expenses bill</asp:ListItem>
          </asp:DropDownList>
          <asp:RequiredFieldValidator 
            ID = "RFVPurchaseType"
            runat = "server"
            ControlToValidate = "F_PurchaseType"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtNewSBH"
            SetFocusOnError="true" />
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
            ValidationGroup = "spmtNewSBH"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IsgecGSTIN" runat="server" Text="Isgec GSTIN :" /><span style="color:red">*</span>
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
            ValidationGroup = "spmtNewSBH"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="BP ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "myfktxt"
            Text='<%# Bind("BPID") %>'
            AutoCompleteType = "None"
            Width="80px"
            onfocus = "return this.select();"
            ToolTip="Enter value for BP ID."
            onblur= "script_spmtNewSBH.validate_BPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner12_BPName") %>'
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
            OnClientItemSelected="script_spmtNewSBH.ACEBPID_Selected"
            OnClientPopulating="script_spmtNewSBH.ACEBPID_Populating"
            OnClientPopulated="script_spmtNewSBH.ACEBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SupplierGSTIN" runat="server" Text="Supplier GSTIN :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_SupplierGSTIN"
            CssClass = "myfktxt"
            Text='<%# Bind("SupplierGSTIN") %>'
            AutoCompleteType = "None"
            Width="88px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Supplier GSTIN."
            onblur= "script_spmtNewSBH.validate_SupplierGSTIN(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_SupplierGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN11_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
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
            OnClientItemSelected="script_spmtNewSBH.ACESupplierGSTIN_Selected"
            OnClientPopulating="script_spmtNewSBH.ACESupplierGSTIN_Populating"
            OnClientPopulated="script_spmtNewSBH.ACESupplierGSTIN_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SupplierName" runat="server" Text="Supplier Name :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SupplierName"
            Text='<%# Bind("SupplierName") %>'
            Width="350px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Supplier Name."
            MaxLength="100"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SupplierGSTINNumber" runat="server" Text="Supplier GSTIN Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SupplierGSTINNumber"
            Text='<%# Bind("SupplierGSTINNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Supplier GSTIN Number."
            MaxLength="50"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ShipToState" runat="server" Text="Ship To State :" />&nbsp;
        </td>
        <td>
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
            Runat="Server" />
          </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillNumber" runat="server" Text="Supplier Bill Number :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_BillNumber"
            Text='<%# Bind("BillNumber") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtNewSBH"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Supplier Bill Number."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVBillNumber"
            runat = "server"
            ControlToValidate = "F_BillNumber"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtNewSBH"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BillDate" runat="server" Text="Supplier Bill Date :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_BillDate"
            Text='<%# Bind("BillDate") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtNewSBH"
            runat="server" />
          <asp:Image ID="ImageButtonBillDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEBillDate"
            TargetControlID="F_BillDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonBillDate" />
          <AJX:MaskedEditExtender 
            ID = "MEEBillDate"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_BillDate" />
          <AJX:MaskedEditValidator 
            ID = "MEVBillDate"
            runat = "server"
            ControlToValidate = "F_BillDate"
            ControlExtender = "MEEBillDate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtNewSBH"
            IsValidEmpty = "false"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillRemarks" runat="server" Text="Bill Remarks :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BillRemarks"
            Text='<%# Bind("BillRemarks") %>'
            Width="350px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Bill Remarks."
            MaxLength="500"
            runat="server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "myfktxt"
            Text='<%# Bind("ProjectID") %>'
            AutoCompleteType = "None"
            Width="56px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Project ID."
            onblur= "script_spmtNewSBH.validate_ProjectID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects4_Description") %>'
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
            OnClientItemSelected="script_spmtNewSBH.ACEProjectID_Selected"
            OnClientPopulating="script_spmtNewSBH.ACEProjectID_Populating"
            OnClientPopulated="script_spmtNewSBH.ACEProjectID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ElementID" runat="server" Text="Element ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ElementID"
            CssClass = "myfktxt"
            Text='<%# Bind("ElementID") %>'
            AutoCompleteType = "None"
            Width="72px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Element ID."
            onblur= "script_spmtNewSBH.validate_ElementID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ElementID_Display"
            Text='<%# Eval("IDM_WBS5_Description") %>'
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
            OnClientItemSelected="script_spmtNewSBH.ACEElementID_Selected"
            OnClientPopulating="script_spmtNewSBH.ACEElementID_Populating"
            OnClientPopulated="script_spmtNewSBH.ACEElementID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_DepartmentID" runat="server" Text="Department ID :" />&nbsp;
        </td>
        <td>
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
        <td class="alignright">
          <asp:Label ID="L_CostCenterID" runat="server" Text="Cost Center ID :" />&nbsp;
        </td>
        <td>
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
          <asp:Label ID="L_EmployeeID" runat="server" Text="Employee ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_EmployeeID"
            CssClass = "myfktxt"
            Text='<%# Bind("EmployeeID") %>'
            AutoCompleteType = "None"
            Width="72px"
            onfocus = "return this.select();"
            ToolTip="Enter value for Employee ID."
            onblur= "script_spmtNewSBH.validate_EmployeeID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_EmployeeID_Display"
            Text='<%# Eval("HRM_Employees3_EmployeeName") %>'
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
            OnClientItemSelected="script_spmtNewSBH.ACEEmployeeID_Selected"
            OnClientPopulating="script_spmtNewSBH.ACEEmployeeID_Populating"
            OnClientPopulated="script_spmtNewSBH.ACEEmployeeID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IRReceivedOn" runat="server" Text="IR Received On :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IRReceivedOn"
            Text='<%# Bind("IRReceivedOn") %>'
            ToolTip="Value of IR Received On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AdviceNo" runat="server" Text="AdviceNo :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceNo"
            Width="88px"
            Text='<%# Bind("AdviceNo") %>'
            Enabled = "False"
            ToolTip="Value of AdviceNo."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceNo_Display"
            Text='<%# Eval("SPMT_newPA9_BPID") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CreatedBy" runat="server" Text="Created By :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_CreatedBy"
            Width="72px"
            Text='<%# Bind("CreatedBy") %>'
            Enabled = "False"
            ToolTip="Value of Created By."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_CreatedBy_Display"
            Text='<%# Eval("aspnet_users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CreatedOn" runat="server" Text="Created On :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CreatedOn"
            Text='<%# Bind("CreatedOn") %>'
            ToolTip="Value of Created On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalBillAmount" runat="server" Text="Total Bill Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalBillAmount"
            Text='<%# Bind("TotalBillAmount") %>'
            ToolTip="Value of Total Bill Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_UploadBatchNo" runat="server" Text="Upload Batch No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_UploadBatchNo"
            Text='<%# Bind("UploadBatchNo") %>'
            ToolTip="Value of Upload Batch No."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="Label1" runat="server" Text="Attach / View Document :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:Button ID="cmdAttach" runat="server" Text="Click to Attach/View" ForeColor="red" OnClientClick='<%# Eval("GetAttachLink") %>' />
        </td>

      </tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtNewSBD" runat="server" Text="&nbsp;List: *Supplier Bill Items"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtNewSBD" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtNewSBD"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtNewSBD.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtNewSBD.aspx"
      AddPostBack = "True"
      EnableExit = "false"
      ValidationGroup = "spmtNewSBD"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtNewSBD" runat="server" AssociatedUpdatePanelID="UPNLspmtNewSBD" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtNewSBD" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtNewSBD" DataKeyNames="IRNo,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Serial No" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Item Description" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits7_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits7_Description") %>'></asp:Label>
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
        <asp:TemplateField HeaderText="Assessable Value" SortExpression="AssessableValue">
          <ItemTemplate>
            <asp:Label ID="LabelAssessableValue" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AssessableValue") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total GST [INR]" SortExpression="TotalGSTINR">
          <ItemTemplate>
            <asp:Label ID="LabelTotalGSTINR" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalGSTINR") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount [INR]" SortExpression="TotalAmountINR">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmountINR" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmountINR") %>'></asp:Label>
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
      ID = "ODSspmtNewSBD"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtNewSBD"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtNewSBDSelectList"
      TypeName = "SIS.SPMT.spmtNewSBD"
      SelectCountMethod = "spmtNewSBDSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_IRNo" PropertyName="Text" Name="IRNo" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtNewSBD" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtNewSBH"
  DataObjectTypeName = "SIS.SPMT.spmtNewSBH"
  SelectMethod = "spmtNewSBHGetByID"
  UpdateMethod="UZ_spmtNewSBHUpdate"
  DeleteMethod="UZ_spmtNewSBHDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtNewSBH"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="IRNo" Name="IRNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
