<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_comGroupUsers.aspx.vb" Inherits="GF_comGroupUsers" title="Maintain List: Group Users" %>
<asp:Content ID="CPHcomGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelcomGroupUsers" runat="server" Text="&nbsp;List: Group Users"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLcomGroupUsers" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLcomGroupUsers"
      ToolType = "lgNMGrid"
      EditUrl = "~/COM_Main/App_Edit/EF_comGroupUsers.aspx"
      AddUrl = "~/COM_Main/App_Create/AF_comGroupUsers.aspx"
      ValidationGroup = "comGroupUsers"
      runat = "server" />
    <asp:UpdateProgress ID="UPGScomGroupUsers" runat="server" AssociatedUpdatePanelID="UPNLcomGroupUsers" DisplayAfter="100">
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
          <b><asp:Label ID="L_GroupID" runat="server" Text="Group ID :" /></b>
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
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_LoginID" runat="server" Text="Login ID :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_LoginID"
            CssClass = "mypktxt"
            Width="72px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_LoginID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_LoginID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACELoginID"
            BehaviorID="B_ACELoginID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="LoginIDCompletionList"
            TargetControlID="F_LoginID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACELoginID_Selected"
            OnClientPopulating="ACELoginID_Populating"
            OnClientPopulated="ACELoginID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
    </table>
    </asp:Panel>
    <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    <asp:GridView ID="GVcomGroupUsers" SkinID="gv_silver" runat="server" DataSourceID="ODScomGroupUsers" DataKeyNames="GroupID,LoginID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Group ID" SortExpression="SYS_Groups2_Description">
          <ItemTemplate>
             <asp:Label ID="L_GroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("GroupID") %>' Text='<%# Eval("SYS_Groups2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Login ID" SortExpression="aspnet_Users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_LoginID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("LoginID") %>' Text='<%# Eval("aspnet_Users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Active" SortExpression="Active">
          <ItemTemplate>
            <asp:Label ID="LabelActive" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Active") %>'></asp:Label>
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
      ID = "ODScomGroupUsers"
      runat = "server"
      DataObjectTypeName = "SIS.COM.comGroupUsers"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "comGroupUsersSelectList"
      TypeName = "SIS.COM.comGroupUsers"
      SelectCountMethod = "comGroupUsersSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_GroupID" PropertyName="SelectedValue" Name="GroupID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_LoginID" PropertyName="Text" Name="LoginID" Type="String" Size="8" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVcomGroupUsers" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_GroupID" />
    <asp:AsyncPostBackTrigger ControlID="F_LoginID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
