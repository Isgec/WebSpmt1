<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtCostCenters.aspx.vb" Inherits="GF_spmtCostCenters" title="Maintain List: Cost Centers" %>
<asp:Content ID="CPHspmtCostCenters" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtCostCenters" runat="server" Text="&nbsp;List: Cost Centers"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtCostCenters" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtCostCenters"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtCostCenters.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtCostCenters.aspx"
      ValidationGroup = "spmtCostCenters"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtCostCenters" runat="server" AssociatedUpdatePanelID="UPNLspmtCostCenters" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtCostCenters" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtCostCenters" DataKeyNames="CostCenterID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Cost Center ID" SortExpression="CostCenterID">
          <ItemTemplate>
            <asp:Label ID="LabelCostCenterID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CostCenterID") %>'></asp:Label>
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
        <asp:TemplateField HeaderText="BaaN Company" SortExpression="BaaNCompany">
          <ItemTemplate>
            <asp:Label ID="LabelBaaNCompany" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaaNCompany") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BaaN Ledger" SortExpression="BaaNLedger">
          <ItemTemplate>
            <asp:Label ID="LabelBaaNLedger" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaaNLedger") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Location" SortExpression="Location">
          <ItemTemplate>
            <asp:Label ID="LabelLocation" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Location") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtCostCenters"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtCostCenters"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtCostCentersSelectList"
      TypeName = "SIS.SPMT.spmtCostCenters"
      SelectCountMethod = "spmtCostCentersSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtCostCenters" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
