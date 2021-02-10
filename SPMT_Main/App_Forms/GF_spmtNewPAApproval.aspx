<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtNewPAApproval.aspx.vb" Inherits="GF_spmtNewPAApproval" title="Approval List: *Payment Advice" %>
<asp:Content ID="CPHspmtNewPA" ContentPlaceHolderID="cph1" Runat="Server">
<asp:UpdatePanel ID="UPNLspmtNewPA" runat="server">
  <ContentTemplate>
      <div style="width:100%" class="sis_formview">
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
              <b><asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type :" /></b>
            </td>
            <td>
              <LGM:LC_spmtTranTypes
                ID="F_TranTypeID"
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
              <b><asp:Label ID="L_CreatedBy" runat="server" Text="Created By :" /></b>
            </td>
            <td>
              <asp:TextBox
                ID = "F_CreatedBy"
                CssClass = "myfktxt"
                Width="72px"
                Text=""
                onfocus = "return this.select();"
                AutoCompleteType = "None"
                onblur= "validate_CreatedBy(this);"
                Runat="Server" />
              <asp:Label
                ID = "F_CreatedBy_Display"
                Text=""
                Runat="Server" />
              <AJX:AutoCompleteExtender
                ID="ACECreatedBy"
                BehaviorID="B_ACECreatedBy"
                ContextKey=""
                UseContextKey="true"
                ServiceMethod="CreatedByCompletionList"
                TargetControlID="F_CreatedBy"
                CompletionInterval="100"
                FirstRowSelected="true"
                MinimumPrefixLength="1"
                OnClientItemSelected="ACECreatedBy_Selected"
                OnClientPopulating="ACECreatedBy_Populating"
                OnClientPopulated="ACECreatedBy_Populated"
                CompletionSetCount="10"
                CompletionListCssClass = "autocomplete_completionListElement"
                CompletionListItemCssClass = "autocomplete_listItem"
                CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
                Runat="Server" />
            </td>
          </tr>
          <tr>
            <td class="alignright">
              <b><asp:Label ID="L_BPID" runat="server" Text="BP ID :" /></b>
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
          <tr>
            <td class="alignright">
              <b><asp:Label ID="Label1" runat="server" Text="Pending to Approve :" /></b>
            </td>
            <td>
              <asp:CheckBox
                ID="F_Pending"
                CssClass="mychk"
                AutoPostBack="true"
                runat="server" />
            </td>
          </tr>
        </table>
        </asp:Panel>
        <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
      </div>
      <asp:UpdateProgress ID="UPGSspmtNewPA" runat="server" AssociatedUpdatePanelID="UPNLspmtNewPA" DisplayAfter="100">
        <ProgressTemplate>
          <span style="color: #ff0033">Loading...</span>
        </ProgressTemplate>
      </asp:UpdateProgress>
    <div class="ui-widget-content page">
    <div class="caption">
        <asp:Label ID="LabelspmtNewPA" runat="server" Text="&nbsp;Approve: Payment Advice [List 1]"></asp:Label>
    </div>
    <div class="pagedata">
      <table width="100%"><tr><td class="sis_formview"> 
      <LGM:ToolBar0 
        ID = "TBLspmtNewPA"
        ToolType = "lgNMGrid"
        ValidationGroup = "spmtNewPA"
        SearchValidationGroup="spmtNewPASearch"
        EnableAdd="false"
        runat = "server" />
      <script type="text/javascript">
        var pcnt = 0;
        function print_nPAreport(o) {
          pcnt = pcnt + 1;
          var nam = 'wTask' + pcnt;
          var url = self.location.href.replace('App_Forms/GF_spmtNewPAApproval', 'App_Print/RP_spmtNewPA');
          url = url + '?pk=' + o.alt;
          window.open(url, nam, 'left=20,top=20,width=1080,height=650,toolbar=1,resizable=1,scrollbars=1');
          return false;
        }
        function print_oldreport(o) {
          pcnt = pcnt + 1;
          var nam = 'wTask' + pcnt;
          var url = self.location.href.replace('App_Forms/GF_spmtNewPAApproval', 'App_Print/RP_spmtPaymentAdvice');
          url = url + '?pk=' + o.alt;
          window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
          return false;
        }
      </script>
      <asp:GridView ID="GVspmtNewPA" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtNewPA" DataKeyNames="AdviceNo">
        <Columns>
  <%--        <asp:TemplateField HeaderText="EDIT">
            <ItemTemplate>
              <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
          </asp:TemplateField>--%>
          <asp:TemplateField HeaderText="VIEW">
            <ItemTemplate>
              <asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_nPAreport(this);" />
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
          </asp:TemplateField>
  <%--        <asp:TemplateField HeaderText="OLD PRINT">
            <ItemTemplate>
              <asp:ImageButton ID="cmdPrintOldPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("OldAdviceNo") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_oldreport(this);" />
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
          </asp:TemplateField>--%>
          <asp:TemplateField HeaderText="Bills">
            <ItemTemplate>
              <asp:ImageButton ID="cmdAttach" runat="server" AlternateText='<%# Eval("AdviceNo") %>' Visible='<%# Eval("AttatchVisible") %>' ToolTip="View Attached documents in Bills." SkinID="attach" OnClientClick='<%# Eval("GetAttachLink") %>' />
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Advice No" SortExpression="AdviceNo">
            <ItemTemplate>
              <asp:Label ID="LabelAdviceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AdviceNo") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle CssClass="alignCenter" Width="40px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Tran Type" SortExpression="SPMT_TranTypes7_Description">
            <ItemTemplate>
               <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes7_Description") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle Width="200px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Supplier Name" SortExpression="SupplierName">
            <ItemTemplate>
              <asp:Label ID="LabelSupplierName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# eval("dSupplierName") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="" />
          <HeaderStyle CssClass="" Width="200px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Total Amount" SortExpression="TotalAdviceAmount">
            <ItemTemplate>
              <asp:Label ID="LabelTotalAdviceAmount" runat="server" Font-Bold="true" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("TotalAdviceAmount") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="alignright" />
            <HeaderStyle CssClass="alignright" Width="80px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Created By" SortExpression="aspnet_users1_UserFullName">
            <ItemTemplate>
               <asp:Label ID="L_CreatedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CreatedBy") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
            </ItemTemplate>
          <ItemStyle CssClass="alignright" />
        <HeaderStyle CssClass="alignright" Width="100px" />
          </asp:TemplateField>
  <%--        <asp:TemplateField HeaderText="Status" SortExpression="SPMT_PAStatus6_Description">
            <ItemTemplate>
               <asp:Label ID="L_StatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("StatusID") %>' Text='<%# Eval("SPMT_PAStatus6_Description") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle Width="100px" />
          </asp:TemplateField>--%>
          <asp:TemplateField HeaderText="Remarks" SortExpression="ApprovalRemarks">
            <ItemTemplate>
              <asp:TextBox ID="F_ApprovalRemarks" ValidationGroup='<%# "Return" & Container.DataItemIndex %>' Width="150px" runat="server" ForeColor='<%# EVal("ForeColor") %>' CssClass="mytxt" MaxLength="250" Text='<%# Bind("ApprovalRemarks") %>'></asp:TextBox>
              <asp:RequiredFieldValidator 
                ID = "RFVApprovalRemarks"
                runat = "server"
                ControlToValidate = "F_ApprovalRemarks"
                ErrorMessage = "<div class='errorLG'>Required!</div>"
                Display = "Dynamic"
                EnableClientScript = "true"
                ValidationGroup='<%# "Return" & Container.DataItemIndex %>'
                SetFocusOnError="true" />
            </ItemTemplate>
            <ItemStyle CssClass="" />
          <HeaderStyle CssClass="" Width="100px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Approve">
            <ItemTemplate>
              <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ApproveWFVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Approve" SkinID="forward" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Approve record ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Return">
            <ItemTemplate>
              <asp:ImageButton ID="cmdReturnWF" ValidationGroup='<%# "Return" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ReturnWFVisible") %>'  AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Return" SkinID="return" OnClientClick='<%# "return Page_ClientValidate(""Return" & Container.DataItemIndex & """) && confirm(""Return record ?"");" %>' CommandName="ReturnWF" CommandArgument='<%# Container.DataItemIndex %>' />
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
        ID = "ODSspmtNewPA"
        runat = "server"
        DataObjectTypeName = "SIS.SPMT.spmtNewPA"
        OldValuesParameterFormatString = "original_{0}"
        SelectMethod = "UnderApprovalSelectList"
        TypeName = "SIS.SPMT.spmtNewPA"
        SelectCountMethod = "spmtNewPASelectCount"
        SortParameterName="OrderBy" EnablePaging="True">
        <SelectParameters >
          <asp:ControlParameter ControlID="F_AdviceNo" PropertyName="Text" Name="AdviceNo" Type="Int32" Size="10" />
          <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
          <asp:ControlParameter ControlID="F_CreatedBy" PropertyName="Text" Name="CreatedBy" Type="String" Size="8" />
          <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
          <asp:ControlParameter ControlID="F_Pending" PropertyName="Checked" Name="Pending" Type="Boolean" DefaultValue="true" />
          <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
          <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
        </SelectParameters>
      </asp:ObjectDataSource>
    </td></tr></table>
    </div>
    </div>
    <div class="ui-widget-content page">
    <div class="caption">
        <asp:Label ID="LabelspmtPaymentAdvice" runat="server" Text="&nbsp;Approve: Payment Advice [List 2]"></asp:Label>
    </div>
    <div class="pagedata">
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtPaymentAdvice"
      ToolType = "lgNMGrid"
      EnableAdd="false"
      ValidationGroup = "spmtPaymentAdvice"
      SearchValidationGroup = "spmtPaymentAdviceSearch"
      runat = "server" />
    <script type="text/javascript">
      var pcnt = 0;
      function print_oPAreport(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_spmtNewPAApproval', 'App_Print/RP_spmtPaymentAdvice');
        url = url + '?pk=' + o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
    <asp:GridView ID="GVspmtPaymentAdvice" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtPaymentAdvice" DataKeyNames="AdviceNo">
      <Columns>
<%--        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>--%>
        <asp:TemplateField HeaderText="VIEW">
          <ItemTemplate>
            <asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_oPAreport(this);" />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bills">
          <ItemTemplate>
            <asp:ImageButton ID="cmdAttach" runat="server" AlternateText='<%# Eval("PrimaryKey") %>' Visible='<%# Eval("AttatchVisible") %>' ToolTip="View Attached documents in Bills." SkinID="attach" OnClientClick='<%# Eval("GetAttachLink") %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Advice No" SortExpression="AdviceNo">
          <ItemTemplate>
            <asp:Label ID="LabelAdviceNo" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("AdviceNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran Type ID" SortExpression="SPMT_TranTypes10_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes10_Description") %>'></asp:Label>
          </ItemTemplate>
            <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier Name" SortExpression="VR_BusinessPartner11_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner11_BPName") %>'></asp:Label>
          </ItemTemplate>
            <ItemStyle CssClass="" />
          <HeaderStyle CssClass="" Width="200px" />
        </asp:TemplateField>
        <%--Total Amount is Stored in CostCenter Field--%>
        <asp:TemplateField HeaderText="Total Amount" SortExpression="CostCenter">
          <ItemTemplate>
            <asp:Label ID="LabelCostCenter" runat="server" ForeColor='<%# Eval("ForeColor") %>' Font-Bold="true" Text='<%# Bind("CostCenter") %>'></asp:Label>
          </ItemTemplate>
            <ItemStyle CssClass="alignright" />
            <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Created By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_AdviceStatusUser" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("AdviceStatusUser") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
        <HeaderStyle CssClass="alignright" Width="100px" />
        </asp:TemplateField>
<%--        <asp:TemplateField HeaderText="Advice Status" SortExpression="SPMT_PAStatus9_Description">
          <ItemTemplate>
             <asp:Label ID="L_AdviceStatusID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("AdviceStatusID") %>' Text='<%# Eval("SPMT_PAStatus9_Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="100px" />
        </asp:TemplateField>--%>
          <asp:TemplateField HeaderText="Remarks" SortExpression="ApprovalRemarks">
            <ItemTemplate>
              <asp:TextBox ID="F_ApprovalRemarks" ValidationGroup='<%# "Return" & Container.DataItemIndex %>' Width="150px" runat="server" ForeColor='<%# EVal("ForeColor") %>' CssClass="mytxt" MaxLength="250" Text='<%# Bind("ApprovalRemarks") %>'></asp:TextBox>
              <asp:RequiredFieldValidator 
                ID = "RFVApprovalRemarks"
                runat = "server"
                ControlToValidate = "F_ApprovalRemarks"
                ErrorMessage = "<div class='errorLG'>Required!</div>"
                Display = "Dynamic"
                EnableClientScript = "true"
                ValidationGroup='<%# "Return" & Container.DataItemIndex %>'
                SetFocusOnError="true" />
            </ItemTemplate>
            <ItemStyle CssClass="" />
          <HeaderStyle CssClass="" Width="100px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Approve">
            <ItemTemplate>
              <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ApproveWFVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Approve" SkinID="forward" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Approve record ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
            </ItemTemplate>
            <ItemStyle CssClass="alignCenter" />
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Return">
            <ItemTemplate>
              <asp:ImageButton ID="cmdReturnWF" ValidationGroup='<%# "Return" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ReturnWFVisible") %>'  AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Return" SkinID="return" OnClientClick='<%# "return Page_ClientValidate(""Return" & Container.DataItemIndex & """) && confirm(""Return record ?"");" %>' CommandName="ReturnWF" CommandArgument='<%# Container.DataItemIndex %>' />
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
      SelectMethod = "UnderApprovalSelectList"
      TypeName = "SIS.SPMT.spmtPaymentAdvice"
      SelectCountMethod = "spmtPaymentAdviceSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_AdviceNo" PropertyName="Text" Name="AdviceNo" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
        <asp:ControlParameter ControlID="F_CreatedBy" PropertyName="Text" Name="CreatedBy" Type="String" Size="8" />
        <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
        <asp:ControlParameter ControlID="F_Pending" PropertyName="Checked" Name="Pending" Type="Boolean" DefaultValue="true" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
  </td></tr></table>
    </div>
    </div>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtNewPA" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="GVspmtPaymentAdvice" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_AdviceNo" />
    <asp:AsyncPostBackTrigger ControlID="F_TranTypeID" />
    <asp:AsyncPostBackTrigger ControlID="F_CreatedBy" />
    <asp:AsyncPostBackTrigger ControlID="F_BPID" />
    <asp:AsyncPostBackTrigger ControlID="F_Pending" />
  </Triggers>
</asp:UpdatePanel>
</asp:Content>
