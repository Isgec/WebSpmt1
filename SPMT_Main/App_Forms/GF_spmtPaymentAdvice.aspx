<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtPaymentAdvice.aspx.vb" Inherits="GF_spmtPaymentAdvice" title="Maintain List: Payment Advice" %>
<asp:Content ID="CPHspmtPaymentAdvice" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtPaymentAdvice" runat="server" Text="&nbsp;List: Payment Advice"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPaymentAdvice" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtPaymentAdvice"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtPaymentAdvice.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtPaymentAdvice.aspx?skip=1"
      ValidationGroup = "spmtPaymentAdvice"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtPaymentAdvice" runat="server" AssociatedUpdatePanelID="UPNLspmtPaymentAdvice" DisplayAfter="100">
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
          <b><asp:Label ID="L_AdviceNo" runat="server" Text="Advice No :" /></b>
        </td>
        <td>
          <asp:TextBox ID="F_AdviceNo"
            Text=""
            Width="88px"
            style="text-align: right"
            CssClass = "mytxt"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAdviceNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AdviceNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVAdviceNo"
            runat = "server"
            ControlToValidate = "F_AdviceNo"
            ControlExtender = "MEEAdviceNo"
            InvalidValueMessage = "*"
            EmptyValueMessage = ""
            EmptyValueBlurredText = ""
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type ID :" /></b>
        </td>
        <td>
          <LGM:LC_spmtTranTypes
            ID="F_TranTypeID"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="TranTypeID"
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
          <b><asp:Label ID="L_BPID" runat="server" Text="Supplier :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "myfktxt"
            Width="80px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_BPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEBPID"
            BehaviorID="B_ACEBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="BPIDCompletionList"
            TargetControlID="F_BPID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEBPID_Selected"
            OnClientPopulating="ACEBPID_Populating"
            OnClientPopulated="ACEBPID_Populated"
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
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
    <asp:GridView ID="GVspmtPaymentAdvice" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtPaymentAdvice" DataKeyNames="AdviceNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PRINT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_report(this);" />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Advice No" SortExpression="AdviceNo">
          <ItemTemplate>
            <asp:Label ID="LabelAdviceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AdviceNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="60px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran Type ID" SortExpression="SPMT_TranTypes10_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes10_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier" SortExpression="VR_BusinessPartner11_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner11_BPName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Concerned HOD" SortExpression="aspnet_users2_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_ConcernedHOD" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ConcernedHOD") %>' Text='<%# Eval("aspnet_users2_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount" SortExpression="CostCenter">
          <ItemTemplate>
            <asp:Label ID="LabelCostCenter" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CostCenter") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
        <HeaderStyle CssClass="alignright" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Created By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_AdviceStatusUser" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceStatusUser") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
        <HeaderStyle CssClass="alignright" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Advice Status" SortExpression="SPMT_PAStatus9_Description">
          <ItemTemplate>
             <asp:Label ID="L_AdviceStatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceStatusID") %>' Text='<%# Eval("SPMT_PAStatus9_Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Accounts Remarks" SortExpression="RemarksAC">
          <ItemTemplate>
            <asp:Label ID="LabelRemarksAC" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RemarksAC") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Forward">
          <ItemTemplate>
            <asp:ImageButton ID="cmdInitiateWF" ValidationGroup='<%# "Initiate" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("InitiateWFVisible") %>' Enabled='<%# EVal("InitiateWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Forward" SkinID="forward" OnClientClick='<%# "return Page_ClientValidate(""Initiate" & Container.DataItemIndex & """) && confirm(""Forward record ?"");" %>' CommandName="InitiateWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Attatched Documents">
          <ItemTemplate>
            <asp:ImageButton ID="cmdAttach" runat="server" AlternateText='<%# Eval("PrimaryKey") %>' Visible='<%# Eval("AttatchVisible") %>' ToolTip="View Attached documents in Bills." SkinID="attach" OnClientClick='<%# Eval("GetAttachLink") %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtPaymentAdvice"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtPaymentAdvice"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtPaymentAdviceSelectList"
      TypeName = "SIS.SPMT.spmtPaymentAdvice"
      SelectCountMethod = "spmtPaymentAdviceSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_AdviceNo" PropertyName="Text" Name="AdviceNo" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
        <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtPaymentAdvice" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_AdviceNo" />
    <asp:AsyncPostBackTrigger ControlID="F_TranTypeID" />
    <asp:AsyncPostBackTrigger ControlID="F_BPID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
