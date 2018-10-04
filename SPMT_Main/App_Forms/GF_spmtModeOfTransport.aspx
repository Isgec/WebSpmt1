<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtModeOfTransport.aspx.vb" Inherits="GF_spmtModeOfTransport" title="Maintain List: SPMT_ModeOfTransport" %>
<asp:Content ID="CPHspmtModeOfTransport" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtModeOfTransport" runat="server" Text="&nbsp;List: SPMT_ModeOfTransport"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtModeOfTransport" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtModeOfTransport"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtModeOfTransport.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtModeOfTransport.aspx"
      ValidationGroup = "spmtModeOfTransport"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtModeOfTransport" runat="server" AssociatedUpdatePanelID="UPNLspmtModeOfTransport" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtModeOfTransport" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtModeOfTransport" DataKeyNames="ModeID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Mode ID" SortExpression="ModeID">
          <ItemTemplate>
            <asp:Label ID="LabelModeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ModeID") %>'></asp:Label>
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
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtModeOfTransport"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtModeOfTransport"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtModeOfTransportSelectList"
      TypeName = "SIS.SPMT.spmtModeOfTransport"
      SelectCountMethod = "spmtModeOfTransportSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtModeOfTransport" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
