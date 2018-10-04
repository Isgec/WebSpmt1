<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtTranTypes.aspx.vb" Inherits="GF_spmtTranTypes" title="Maintain List: Tran. Types" %>
<asp:Content ID="CPHspmtTranTypes" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtTranTypes" runat="server" Text="&nbsp;List: Tran. Types"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtTranTypes" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtTranTypes"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtTranTypes.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtTranTypes.aspx"
      ValidationGroup = "spmtTranTypes"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtTranTypes" runat="server" AssociatedUpdatePanelID="UPNLspmtTranTypes" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:Panel ID="pnlH" runat="server" CssClass="cph_filter">
      <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
        <div style="float: left;">Filter Records </div>
        <div style="float: left; margin-left: 20px;">
          <asp:Label ID="lblH" runat="server">(Show Filters...)</asp:Label>
        </div>
        <div style="float: right; vertical-align: middle;">
          <asp:ImageButton ID="imgH" runat="server" ImageUrl="~/images/ua.png" AlternateText="(Show Filters...)" />
        </div>
      </div>
    </asp:Panel>
    <asp:Panel ID="pnlD" runat="server" CssClass="cp_filter" Height="0">
    <table>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GroupID" runat="server" Text="Group  :" /></b>
        </td>
        <td>
          <LGM:LC_comGroups
            ID="F_GroupID"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="GroupID"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            AutoPostBack="true"
            RequiredFieldErrorMessage="<div class='errorLG'>Required!</div>"
            CssClass="myddl"
            Runat="Server" />
          </td>
      </tr>
    </table>
    </asp:Panel>
    <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    <asp:GridView ID="GVspmtTranTypes" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtTranTypes" DataKeyNames="TranTypeID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran. Type" SortExpression="TranTypeID">
          <ItemTemplate>
            <asp:Label ID="LabelTranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TranTypeID") %>'></asp:Label>
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
        <asp:TemplateField HeaderText="Group " SortExpression="SYS_Groups1_Description">
          <ItemTemplate>
             <asp:Label ID="L_GroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("GroupID") %>' Text='<%# Eval("SYS_Groups1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BaaN Company" SortExpression="BaaNCompany">
          <ItemTemplate>
            <asp:Label ID="LabelBaaNCompany" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaaNCompany") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BaaN Ledger" SortExpression="BaaNLedger">
          <ItemTemplate>
            <asp:Label ID="LabelBaaNLedger" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaaNLedger") %>'></asp:Label>
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
      ID = "ODSspmtTranTypes"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtTranTypes"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtTranTypesSelectList"
      TypeName = "SIS.SPMT.spmtTranTypes"
      SelectCountMethod = "spmtTranTypesSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_GroupID" PropertyName="SelectedValue" Name="GroupID" Type="String" Size="6" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtTranTypes" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_GroupID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
