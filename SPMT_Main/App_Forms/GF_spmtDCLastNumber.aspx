<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtDCLastNumber.aspx.vb" Inherits="GF_spmtDCLastNumber" title="Maintain List: SPMT_DCLastNumber" %>
<asp:Content ID="CPHspmtDCLastNumber" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtDCLastNumber" runat="server" Text="&nbsp;List: SPMT_DCLastNumber"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtDCLastNumber" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtDCLastNumber"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtDCLastNumber.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtDCLastNumber.aspx"
      ValidationGroup = "spmtDCLastNumber"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtDCLastNumber" runat="server" AssociatedUpdatePanelID="UPNLspmtDCLastNumber" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtDCLastNumber" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtDCLastNumber" DataKeyNames="NumberID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Number ID" SortExpression="NumberID">
          <ItemTemplate>
            <asp:Label ID="LabelNumberID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("NumberID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Last Number" SortExpression="LastNumber">
          <ItemTemplate>
            <asp:Label ID="LabelLastNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("LastNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Year" SortExpression="Year">
          <ItemTemplate>
            <asp:Label ID="LabelYear" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Year") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Active" SortExpression="Active">
          <ItemTemplate>
            <asp:Label ID="LabelActive" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Active") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtDCLastNumber"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtDCLastNumber"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtDCLastNumberSelectList"
      TypeName = "SIS.SPMT.spmtDCLastNumber"
      SelectCountMethod = "spmtDCLastNumberSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtDCLastNumber" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
