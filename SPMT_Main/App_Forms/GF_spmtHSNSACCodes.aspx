<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtHSNSACCodes.aspx.vb" Inherits="GF_spmtHSNSACCodes" title="Maintain List: HSN / SAC Code" %>
<asp:Content ID="CPHspmtHSNSACCodes" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtHSNSACCodes" runat="server" Text="&nbsp;List: HSN / SAC Code"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtHSNSACCodes" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtHSNSACCodes"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtHSNSACCodes.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtHSNSACCodes.aspx"
      AddPostBack = "True"
      ValidationGroup = "spmtHSNSACCodes"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtHSNSACCodes" runat="server" AssociatedUpdatePanelID="UPNLspmtHSNSACCodes" DisplayAfter="100">
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
          <b><asp:Label ID="L_BillType" runat="server" Text="Bill Type :" /></b>
        </td>
        <td>
          <LGM:LC_spmtBillTypes
            ID="F_BillType"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="BillType"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            AutoPostBack="true"
            RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
            CssClass="myddl"
            Runat="Server" />
          </td>
      </tr>
    </table>
    </asp:Panel>
    <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    <asp:GridView ID="GVspmtHSNSACCodes" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtHSNSACCodes" DataKeyNames="BillType,HSNSACCode">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Type" SortExpression="SPMT_BillTypes1_Description">
          <ItemTemplate>
             <asp:Label ID="L_BillType" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BillType") %>' Text='<%# Eval("SPMT_BillTypes1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="HSN / SAC Code" SortExpression="HSNSACCode">
          <ItemTemplate>
            <asp:Label ID="LabelHSNSACCode" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("HSNSACCode") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tax Rate" SortExpression="TaxRate">
          <ItemTemplate>
            <asp:Label ID="LabelTaxRate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TaxRate") %>'></asp:Label>
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
      ID = "ODSspmtHSNSACCodes"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtHSNSACCodes"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtHSNSACCodesSelectList"
      TypeName = "SIS.SPMT.spmtHSNSACCodes"
      SelectCountMethod = "spmtHSNSACCodesSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_BillType" PropertyName="SelectedValue" Name="BillType" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtHSNSACCodes" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_BillType" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
