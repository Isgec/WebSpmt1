<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtERPUnits.aspx.vb" Inherits="GF_spmtERPUnits" title="Maintain List: Unit Of Measurement" %>
<asp:Content ID="CPHspmtERPUnits" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtERPUnits" runat="server" Text="&nbsp;List: Unit Of Measurement"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtERPUnits" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtERPUnits"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtERPUnits.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtERPUnits.aspx"
      ValidationGroup = "spmtERPUnits"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtERPUnits" runat="server" AssociatedUpdatePanelID="UPNLspmtERPUnits" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtERPUnits" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtERPUnits" DataKeyNames="UOM">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="UOM">
          <ItemTemplate>
            <asp:Label ID="LabelUOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("UOM") %>'></asp:Label>
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
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtERPUnits"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtERPUnits"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtERPUnitsSelectList"
      TypeName = "SIS.SPMT.spmtERPUnits"
      SelectCountMethod = "spmtERPUnitsSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtERPUnits" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
