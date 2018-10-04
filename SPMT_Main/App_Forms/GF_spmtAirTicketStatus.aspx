<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtAirTicketStatus.aspx.vb" Inherits="GF_spmtAirTicketStatus" title="Maintain List: Air Ticket Status" %>
<asp:Content ID="CPHspmtAirTicketStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtAirTicketStatus" runat="server" Text="&nbsp;List: Air Ticket Status"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtAirTicketStatus" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtAirTicketStatus"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtAirTicketStatus.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtAirTicketStatus.aspx"
      ValidationGroup = "spmtAirTicketStatus"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtAirTicketStatus" runat="server" AssociatedUpdatePanelID="UPNLspmtAirTicketStatus" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtAirTicketStatus" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtAirTicketStatus" DataKeyNames="StatusID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="StatusID" SortExpression="StatusID">
          <ItemTemplate>
            <asp:Label ID="LabelStatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("StatusID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Descriptionn" SortExpression="Descriptionn">
          <ItemTemplate>
            <asp:Label ID="LabelDescriptionn" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Descriptionn") %>'></asp:Label>
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
      ID = "ODSspmtAirTicketStatus"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtAirTicketStatus"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtAirTicketStatusSelectList"
      TypeName = "SIS.SPMT.spmtAirTicketStatus"
      SelectCountMethod = "spmtAirTicketStatusSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtAirTicketStatus" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
