<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtIsgecGSTIN.aspx.vb" Inherits="GF_spmtIsgecGSTIN" title="Maintain List: Isgec GSTIN" %>
<asp:Content ID="CPHspmtIsgecGSTIN" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtIsgecGSTIN" runat="server" Text="&nbsp;List: Isgec GSTIN"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtIsgecGSTIN" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtIsgecGSTIN"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtIsgecGSTIN.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtIsgecGSTIN.aspx"
      ValidationGroup = "spmtIsgecGSTIN"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtIsgecGSTIN" runat="server" AssociatedUpdatePanelID="UPNLspmtIsgecGSTIN" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtIsgecGSTIN" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtIsgecGSTIN" DataKeyNames="GSTID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="GST ID" SortExpression="GSTID">
          <ItemTemplate>
            <asp:Label ID="LabelGSTID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("GSTID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State" SortExpression="State">
          <ItemTemplate>
            <asp:Label ID="LabelState" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("State") %>'></asp:Label>
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
      ID = "ODSspmtIsgecGSTIN"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtIsgecGSTIN"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtIsgecGSTINSelectList"
      TypeName = "SIS.SPMT.spmtIsgecGSTIN"
      SelectCountMethod = "spmtIsgecGSTINSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtIsgecGSTIN" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
