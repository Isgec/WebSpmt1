<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_SPMTerpDCInventory.aspx.vb" Inherits="GF_SPMTerpDCInventory" title="Maintain List: ERP DC Inventory" %>
<asp:Content ID="CPHSPMTerpDCInventory" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelSPMTerpDCInventory" runat="server" Text="&nbsp;List: ERP DC Inventory"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCInventory" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLSPMTerpDCInventory"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_SPMTerpDCInventory.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_SPMTerpDCInventory.aspx"
      ValidationGroup = "SPMTerpDCInventory"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSSPMTerpDCInventory" runat="server" AssociatedUpdatePanelID="UPNLSPMTerpDCInventory" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVSPMTerpDCInventory" SkinID="gv_silver" runat="server" DataSourceID="ODSSPMTerpDCInventory" DataKeyNames="ChallanID,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ChallanID" SortExpression="SPMT_erpDCH3_PlaceOfDelivery">
          <ItemTemplate>
             <asp:Label ID="L_ChallanID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ChallanID") %>' Text='<%# Eval("SPMT_erpDCH3_PlaceOfDelivery") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SerialNo" SortExpression="SPMT_erpDCD10_ItemDescription">
          <ItemTemplate>
             <asp:Label ID="L_SerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SerialNo") %>' Text='<%# Eval("SPMT_erpDCD10_ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ItemDescription" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BaseRate" SortExpression="BaseRate">
          <ItemTemplate>
            <asp:Label ID="LabelBaseRate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaseRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits5_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits5_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Price" SortExpression="Price">
          <ItemTemplate>
            <asp:Label ID="LabelPrice" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Price") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FinalRate" SortExpression="FinalRate">
          <ItemTemplate>
            <asp:Label ID="LabelFinalRate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FinalRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FinalAmount" SortExpression="FinalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelFinalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FinalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ProjectID" SortExpression="IDM_Projects1_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSSPMTerpDCInventory"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.SPMTerpDCInventory"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_SPMTerpDCInventorySelectList"
      TypeName = "SIS.SPMT.SPMTerpDCInventory"
      SelectCountMethod = "SPMTerpDCInventorySelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVSPMTerpDCInventory" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
