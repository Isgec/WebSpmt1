<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtSupplierBill.aspx.vb" Inherits="GF_spmtSupplierBill" title="Maintain List: Supplier Bill" %>
<asp:Content ID="CPHspmtSupplierBill" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtSupplierBill" runat="server" Text="&nbsp;List: Supplier Bill"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtSupplierBill" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtSupplierBill"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtSupplierBill.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtSupplierBill.aspx"
      ValidationGroup = "spmtSupplierBill"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtSupplierBill" runat="server" AssociatedUpdatePanelID="UPNLspmtSupplierBill" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:Panel ID="pnlH" runat="server" CssClass="cph_filter">
      <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
        <div style="float: left;">Filter Records </div>
        <div style="float: left; margin-left: 20px;">
          <asp:Label ID="lblH" runat="server">(Show Filters...)</asp:Label>
        </div>
        <div style="float: right; vertical-align: middle;">
          <asp:ImageButton ID="imgH" runat="server" ImageUrl="~/images/ua.png" AlternateText="(Show Filters...)" />
        </div>
      </div>
    </asp:Panel>
    <asp:Panel ID="pnlD" runat="server" CssClass="cp_filter" Height="0">
    <table>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_PurchaseType" runat="server" Text="Purchase Type :" /></b>
        </td>
        <td>
          <asp:DropDownList
            ID="F_PurchaseType"
            Width="200px"
            Runat="Server" >
            <asp:ListItem Value=" ">---Select---</asp:ListItem>
            <asp:ListItem Value="Purchase from Registered Dealer">Purchase from Registered Dealer</asp:ListItem>
            <asp:ListItem Value="Purchase from Composition Dealer">Purchase from Composition Dealer</asp:ListItem>
            <asp:ListItem Value=" Purchase from Unregistered Dealer"> Purchase from Unregistered Dealer</asp:ListItem>
            <asp:ListItem Value="Non GST expenses bill">Non GST expenses bill</asp:ListItem>
          </asp:DropDownList>
         </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_IRNo" runat="server" Text="IR No :" /></b>
        </td>
        <td>
          <asp:TextBox ID="F_IRNo"
            Text=""
            Width="88px"
            style="text-align: right"
            CssClass = "mytxt"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEIRNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_IRNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVIRNo"
            runat = "server"
            ControlToValidate = "F_IRNo"
            ControlExtender = "MEEIRNo"
            InvalidValueMessage = "*"
            EmptyValueMessage = ""
            EmptyValueBlurredText = ""
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_TranTypeID" runat="server" Text="Tran.Type :" /></b>
        </td>
        <td>
          <LGM:LC_spmtTranTypes
            ID="F_TranTypeID"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="TranTypeID"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            AutoPostBack="true"
            RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
            CssClass="myddl"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BPID" runat="server" Text="Supplier :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "myfktxt"
            Width="80px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_BPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEBPID"
            BehaviorID="B_ACEBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="BPIDCompletionList"
            TargetControlID="F_BPID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEBPID_Selected"
            OnClientPopulating="ACEBPID_Populating"
            OnClientPopulated="ACEBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
    </table>
    </asp:Panel>
    <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    <asp:GridView ID="GVspmtSupplierBill" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtSupplierBill" DataKeyNames="IRNo">
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
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran.Type" SortExpression="SPMT_TranTypes16_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes16_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier" SortExpression="VR_BusinessPartner18_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner18_BPName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Number" SortExpression="BillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelBillNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Date" SortExpression="BillDate">
          <ItemTemplate>
            <asp:Label ID="LabelBillDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Amount" SortExpression="BillAmount">
          <ItemTemplate>
            <asp:Label ID="LabelBillAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="AdviceNo" SortExpression="AdviceNo">
          <ItemTemplate>
             <asp:Label ID="L_AdviceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceNo") %>' Text='<%# Eval("AdviceNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="80px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtSupplierBill"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtSupplierBill"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtSupplierBillSelectList"
      TypeName = "SIS.SPMT.spmtSupplierBill"
      SelectCountMethod = "spmtSupplierBillSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_IRNo" PropertyName="Text" Name="IRNo" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
        <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
        <asp:ControlParameter ControlID="F_PurchaseType" PropertyName="SelectedValue" Name="PurchaseType" Type="String" Size="50" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtSupplierBill" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_IRNo" />
    <asp:AsyncPostBackTrigger ControlID="F_TranTypeID" />
    <asp:AsyncPostBackTrigger ControlID="F_BPID" />
    <asp:AsyncPostBackTrigger ControlID="F_PurchaseType" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
