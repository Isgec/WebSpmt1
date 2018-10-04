<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtNewUnLinkedSBH.aspx.vb" Inherits="GF_spmtNewUnLinkedSBH" title="Maintain List: *Pending Supplier Bill" %>
<asp:Content ID="CPHspmtNewUnLinkedSBH" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtNewUnLinkedSBH" runat="server" Text="&nbsp;List: *Pending Supplier Bill"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtNewUnLinkedSBH" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtNewUnLinkedSBH"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtNewUnLinkedSBH.aspx"
      EnableAdd = "False"
      ValidationGroup = "spmtNewUnLinkedSBH"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtNewUnLinkedSBH" runat="server" AssociatedUpdatePanelID="UPNLspmtNewUnLinkedSBH" DisplayAfter="100">
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
          <b><asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type :" /></b>
        </td>
        <td>
          <LGM:LC_spmtTranTypes
            ID="F_TranTypeID"
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
          <b><asp:Label ID="L_BPID" runat="server" Text="BP ID :" /></b>
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
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_SupplierName" runat="server" Text="Supplier Name :" /></b>
        </td>
        <td>
          <asp:TextBox ID="F_SupplierName"
            Text=""
            CssClass = "mytxt"
            onfocus = "return this.select();"
            MaxLength="100"
            Width="350px"
            runat="server" />
        </td>
      </tr>
    </table>
    </asp:Panel>
    <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    <asp:GridView ID="GVspmtNewUnLinkedSBH" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtNewUnLinkedSBH" DataKeyNames="IRNo">
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
        <asp:TemplateField HeaderText="Tran Type" SortExpression="SPMT_TranTypes10_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes10_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier Name" SortExpression="SupplierName">
          <ItemTemplate>
            <asp:Label ID="LabelSupplierName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SupplierName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier Bill Number" SortExpression="BillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelBillNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier Bill Date" SortExpression="BillDate">
          <ItemTemplate>
            <asp:Label ID="LabelBillDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Created By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_CreatedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CreatedBy") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Bill Amount" SortExpression="TotalBillAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalBillAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalBillAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="AdviceNo" SortExpression="SPMT_newPA9_BPID">
          <ItemTemplate>
             <asp:Label ID="L_AdviceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceNo") %>' Text='<%# Eval("SPMT_newPA9_BPID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Select">
          <ItemTemplate>
            <asp:ImageButton ID="cmdSelect" ValidationGroup='<%# "Select" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("SelectWFVisible") %>' Enabled='<%# EVal("SelectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Select" SkinID="Select" OnClientClick='<%# "return Page_ClientValidate(""Select" & Container.DataItemIndex & """) && confirm(""Select record ?"");" %>' CommandName="SelectWF" CommandArgument='<%# Container.DataItemIndex %>' />
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
      ID = "ODSspmtNewUnLinkedSBH"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtNewUnLinkedSBH"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtNewUnLinkedSBHSelectList"
      TypeName = "SIS.SPMT.spmtNewUnLinkedSBH"
      SelectCountMethod = "spmtNewUnLinkedSBHSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
        <asp:ControlParameter ControlID="F_SupplierName" PropertyName="Text" Name="SupplierName" Type="String" Size="100" />
        <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtNewUnLinkedSBH" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_TranTypeID" />
    <asp:AsyncPostBackTrigger ControlID="F_SupplierName" />
    <asp:AsyncPostBackTrigger ControlID="F_BPID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
