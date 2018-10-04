<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtERPStates.aspx.vb" Inherits="GF_spmtERPStates" title="Maintain List: Indian States" %>
<asp:Content ID="CPHspmtERPStates" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtERPStates" runat="server" Text="&nbsp;List: Indian States"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtERPStates" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtERPStates"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtERPStates.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtERPStates.aspx"
      ValidationGroup = "spmtERPStates"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtERPStates" runat="server" AssociatedUpdatePanelID="UPNLspmtERPStates" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtERPStates" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtERPStates" DataKeyNames="StateID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State ID" SortExpression="StateID">
          <ItemTemplate>
            <asp:Label ID="LabelStateID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("StateID") %>'></asp:Label>
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
        <asp:TemplateField HeaderText="Central GST GL" SortExpression="ISGECCentralGSTGL">
          <ItemTemplate>
            <asp:Label ID="LabelISGECCentralGSTGL" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ISGECCentralGSTGL") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State GST GL" SortExpression="ISGECStateGSTGL">
          <ItemTemplate>
            <asp:Label ID="LabelISGECStateGSTGL" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ISGECStateGSTGL") %>'></asp:Label>
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
      ID = "ODSspmtERPStates"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtERPStates"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtERPStatesSelectList"
      TypeName = "SIS.SPMT.spmtERPStates"
      SelectCountMethod = "spmtERPStatesSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtERPStates" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
