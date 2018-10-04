<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_comFinanceCompany.aspx.vb" Inherits="GF_comFinanceCompany" title="Maintain List: Finance Company" %>
<asp:Content ID="CPHcomFinanceCompany" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelcomFinanceCompany" runat="server" Text="&nbsp;List: Finance Company"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLcomFinanceCompany" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLcomFinanceCompany"
      ToolType = "lgNMGrid"
      EditUrl = "~/COM_Main/App_Edit/EF_comFinanceCompany.aspx"
      AddUrl = "~/COM_Main/App_Create/AF_comFinanceCompany.aspx"
      ValidationGroup = "comFinanceCompany"
      runat = "server" />
    <asp:UpdateProgress ID="UPGScomFinanceCompany" runat="server" AssociatedUpdatePanelID="UPNLcomFinanceCompany" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVcomFinanceCompany" SkinID="gv_silver" runat="server" DataSourceID="ODScomFinanceCompany" DataKeyNames="FinanceCompany">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Finance Company" SortExpression="FinanceCompany">
          <ItemTemplate>
            <asp:Label ID="LabelFinanceCompany" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FinanceCompany") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Company Name" SortExpression="CompanyName">
          <ItemTemplate>
            <asp:Label ID="LabelCompanyName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CompanyName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Logistic Company" SortExpression="LogisticCompany">
          <ItemTemplate>
            <asp:Label ID="LabelLogisticCompany" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("LogisticCompany") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODScomFinanceCompany"
      runat = "server"
      DataObjectTypeName = "SIS.COM.comFinanceCompany"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "comFinanceCompanySelectList"
      TypeName = "SIS.COM.comFinanceCompany"
      SelectCountMethod = "comFinanceCompanySelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVcomFinanceCompany" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
