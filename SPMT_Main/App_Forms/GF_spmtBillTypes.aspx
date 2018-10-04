<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtBillTypes.aspx.vb" Inherits="GF_spmtBillTypes" title="Maintain List: Bill Types" %>
<asp:Content ID="CPHspmtBillTypes" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtBillTypes" runat="server" Text="&nbsp;List: Bill Types"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBillTypes" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtBillTypes"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtBillTypes.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtBillTypes.aspx?skip=1"
      ValidationGroup = "spmtBillTypes"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtBillTypes" runat="server" AssociatedUpdatePanelID="UPNLspmtBillTypes" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtBillTypes" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtBillTypes" DataKeyNames="BillType">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Type" SortExpression="BillType">
          <ItemTemplate>
            <asp:Label ID="LabelBillType" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillType") %>'></asp:Label>
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
      ID = "ODSspmtBillTypes"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtBillTypes"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtBillTypesSelectList"
      TypeName = "SIS.SPMT.spmtBillTypes"
      SelectCountMethod = "spmtBillTypesSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtBillTypes" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
