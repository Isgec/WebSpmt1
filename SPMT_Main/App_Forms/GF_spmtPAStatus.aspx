<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtPAStatus.aspx.vb" Inherits="GF_spmtPAStatus" title="Maintain List: PA States" %>
<asp:Content ID="CPHspmtPAStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtPAStatus" runat="server" Text="&nbsp;List: PA States"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPAStatus" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtPAStatus"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtPAStatus.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtPAStatus.aspx"
      ValidationGroup = "spmtPAStatus"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtPAStatus" runat="server" AssociatedUpdatePanelID="UPNLspmtPAStatus" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtPAStatus" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtPAStatus" DataKeyNames="AdviceStatusID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PA Status ID" SortExpression="AdviceStatusID">
          <ItemTemplate>
            <asp:Label ID="LabelAdviceStatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AdviceStatusID") %>'></asp:Label>
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
        <asp:TemplateField HeaderText="Next Status ID" SortExpression="NextStatusID">
          <ItemTemplate>
            <asp:Label ID="LabelNextStatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("NextStatusID") %>'></asp:Label>
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
      ID = "ODSspmtPAStatus"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtPAStatus"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtPAStatusSelectList"
      TypeName = "SIS.SPMT.spmtPAStatus"
      SelectCountMethod = "spmtPAStatusSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtPAStatus" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
