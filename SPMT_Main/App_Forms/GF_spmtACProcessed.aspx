<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtACProcessed.aspx.vb" Inherits="GF_spmtACProcessed" title="Maintain List: PA Processing by AC" %>
<asp:Content ID="CPHspmtACProcessed" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtACProcessed" runat="server" Text="&nbsp;List: PA Processing by AC"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtACProcessed" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtACProcessed"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtACProcessed.aspx"
      EnableAdd = "False"
      ValidationGroup = "spmtACProcessed"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtACProcessed" runat="server" AssociatedUpdatePanelID="UPNLspmtACProcessed" DisplayAfter="100">
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
    <asp:GridView ID="GVspmtACProcessed" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtACProcessed" DataKeyNames="AdviceNo">
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
        <asp:TemplateField HeaderText="Atch">
          <ItemTemplate>
            <asp:ImageButton ID="cmdAttach" runat="server" AlternateText='<%# Eval("PrimaryKey") %>' ToolTip="View Attached documents." SkinID="attach" OnClientClick='<%# Eval("GetAttachLink") %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Advice No" SortExpression="AdviceNo">
          <ItemTemplate>
            <asp:Label ID="LabelAdviceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AdviceNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="50px" />
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
        <asp:TemplateField HeaderText="Total Amount" SortExpression="CostCenter">
          <ItemTemplate>
            <asp:Label ID="LabelCostCenter" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CostCenter") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle HorizontalAlign="Right" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Created By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_AdviceStatusUser" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceStatusUser") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Advice Status" SortExpression="SPMT_PAStatus9_Description">
          <ItemTemplate>
             <asp:Label ID="L_AdviceStatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceStatusID") %>' Text='<%# Eval("SPMT_PAStatus9_Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="A/C Remarks" SortExpression="RemarksAC">
          <ItemTemplate>
            <asp:Label ID="LabelRemarksAC" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RemarksAC") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="VCH TYPE" SortExpression="DocumentNo">
          <ItemTemplate>
            <asp:Label ID="LabelDocumentNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("DocumentNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="VCH No" SortExpression="BaaNCompany">
          <ItemTemplate>
            <asp:Label ID="LabelBaaNCompany" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("BaaNCompany") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="60px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ERP Co." SortExpression="BaaNLedger">
          <ItemTemplate>
            <asp:Label ID="LabelBaaNLedger" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BaaNLedger") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="RECEIVE" SortExpression="RemarksHOD">
          <ItemTemplate>
            <asp:Label ID="LabelRemarksHOD" runat="server" Visible='<%# Eval("ReceivedByVisible") %>' ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RemarksHOD") %>'></asp:Label>
            <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ApproveWFVisible") %>' Enabled='<%# EVal("ApproveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Click to Receive" SkinID="approve" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Receive record ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="RET">
          <ItemTemplate>
            <asp:Panel runat="server" ID="ReturnPnl" Visible='<%# Eval("ReturnEntryVisible") %>' style="width:200px;background-color:antiquewhite" >
              <table style="margin:auto">
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_Remarks" runat="server" Text="Remarks :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_RemarksAC"
                      Text='<%# Bind("RemarksAC") %>'
                      Width="100px" 
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      MaxLength="250"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      runat="server" />
                    <asp:RequiredFieldValidator 
                      ID = "RFVRemarksAC"
                      runat = "server"
                      ControlToValidate = "F_RemarksAC"
                      ErrorMessage = "<div class='errorLG'>Required!</div>"
                      Display = "Dynamic"
                      EnableClientScript = "true"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      SetFocusOnError="true" />
                  </td>
                  <td>
                    <asp:ImageButton ID="cmdSave" ValidationGroup='<%# "Save" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("SaveWFVisible") %>' Enabled='<%# EVal("SaveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Save" SkinID="Save" OnClientClick='<%# "return Page_ClientValidate(""Save" & Container.DataItemIndex & """) && confirm(""Update record ?"");" %>' CommandName="SaveWF" CommandArgument='<%# Container.DataItemIndex %>' />
                  </td>
                  <td>
                    <asp:ImageButton ID="cmdCancel" ValidationGroup='<%# "Cancel" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("CancelWFVisible") %>' Enabled='<%# EVal("CancelWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Cancel" SkinID="Cancel" OnClientClick='<%# "return Page_ClientValidate(""Cancel" & Container.DataItemIndex & """) && confirm(""Cancel record ?"");" %>' CommandName="CancelWF" CommandArgument='<%# Container.DataItemIndex %>' />
                  </td>
                </tr>
              </table>
            </asp:Panel>
            <asp:ImageButton ID="cmdRejectWF" ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("RejectWFVisible") %>' Enabled='<%# EVal("RejectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Reject" SkinID="reject" OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Return record ?"");" %>' CommandName="RejectWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UPD">
          <ItemTemplate>
            <asp:Panel runat="server" ID="UpdatePnl" Visible='<%# Eval("UpdateEntryVisible") %>' style="width:200px;background-color:antiquewhite;border:solid 1pt pink" >
              <table>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_DocumentNo" runat="server" Text="Voucher Type :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox
                      ID="F_DocumentNo"
                      Text='<%# Bind("DocumentNo") %>'
                      Width="60px" 
                      CssClass = "mytxt"
                      MaxLength="3"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      runat="server" />
                    <asp:RequiredFieldValidator 
                      ID = "RFVDocumentNo"
                      runat = "server"
                      ControlToValidate = "F_DocumentNo"
                      ErrorMessage = "<div class='errorLG'>Required!</div>"
                      Display = "Dynamic"
                      EnableClientScript = "true"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      SetFocusOnError="true" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_BaaNCompany" runat="server" Text="Voucher No. :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_BaaNCompany"
                      Text='<%# Bind("BaaNCompany") %>'
                      Width="80px" 
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      MaxLength="8"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      runat="server" />
                    <asp:RequiredFieldValidator 
                      ID = "RFVBaaNCompany"
                      runat = "server"
                      ControlToValidate = "F_BaaNCompany"
                      ErrorMessage = "<div class='errorLG'>Required!</div>"
                      Display = "Dynamic"
                      EnableClientScript = "true"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      ValidationExpression="\d+"
                      SetFocusOnError="true" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_BaaNLedger" runat="server" Text="ERP Company :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:DropDownList 
                      ID="F_BaaNLedger"
                      SelectedValue='<%# Bind("BaaNLedger") %>'
                      Width="40px" 
                      CssClass = "mytxt"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      runat="server">
                      <asp:ListItem Selected="True" Value="" Text="---Select---"></asp:ListItem>
                      <asp:ListItem Value="200" Text="200"></asp:ListItem>
                      <asp:ListItem Value="210" Text="210"></asp:ListItem>
                      <asp:ListItem Value="220" Text="220"></asp:ListItem>
                      <asp:ListItem Value="230" Text="230"></asp:ListItem>
                      <asp:ListItem Value="240" Text="240"></asp:ListItem>
                      <asp:ListItem Value="250" Text="250"></asp:ListItem>
                      <asp:ListItem Value="290" Text="290"></asp:ListItem>
                      <asp:ListItem Value="400" Text="400"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator 
                      ID = "RFVBaaNLedger"
                      runat = "server"
                      ControlToValidate = "F_BaaNLedger"
                      ErrorMessage = "<div class='errorLG'>Required!</div>"
                      Display = "Dynamic"
                      EnableClientScript = "true"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      SetFocusOnError="true" />
                  </td>
                </tr>
                <tr>
                  <td class="alignCenter">
                    <asp:ImageButton ID="ucmdCancel" ValidationGroup='<%# "Cancel" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("CancelWFVisible") %>' Enabled='<%# EVal("CancelWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Cancel" SkinID="Cancel" OnClientClick='<%# "return Page_ClientValidate(""Cancel" & Container.DataItemIndex & """) && confirm(""Cancel record ?"");" %>' CommandName="CancelWF" CommandArgument='<%# Container.DataItemIndex %>' />
                  </td>
                  <td class="alignCenter">
                    <asp:ImageButton ID="ucmdSave" ValidationGroup='<%# "Save" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("SaveWFVisible") %>' Enabled='<%# EVal("SaveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Save" SkinID="Save" OnClientClick='<%# "return Page_ClientValidate(""Save" & Container.DataItemIndex & """) && confirm(""Update record ?"");" %>' CommandName="SaveWF" CommandArgument='<%# Container.DataItemIndex %>' />
                  </td>
                  </tr>
              </table>
            </asp:Panel>
            <asp:ImageButton ID="cmdInitiateWF" ValidationGroup='<%# "Initiate" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("InitiateWFVisible") %>' Enabled='<%# EVal("InitiateWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Update Voucher Entry" SkinID="forward" OnClientClick='<%# "return Page_ClientValidate(""Initiate" & Container.DataItemIndex & """) && confirm(""Update record ?"");" %>' CommandName="InitiateWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="LOCK" SortExpression="RemarksHR">
          <ItemTemplate>
            <asp:Label ID="LabelRemarksHR" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("RemarksHR") %>'></asp:Label>
            <asp:ImageButton ID="cmdLock" ValidationGroup='<%# "Lock" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("LockWFVisible") %>' Enabled='<%# EVal("LockWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Lock" SkinID="Hold" OnClientClick='<%# "return Page_ClientValidate(""Lock" & Container.DataItemIndex & """) && confirm(""Lock record ?"");" %>' CommandName="LockWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtACProcessed"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtACProcessed"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtACProcessedSelectList"
      TypeName = "SIS.SPMT.spmtACProcessed"
      SelectCountMethod = "spmtACProcessedSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtACProcessed" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_AdviceNo" />
    <asp:AsyncPostBackTrigger ControlID="F_TranTypeID" />
    <asp:AsyncPostBackTrigger ControlID="F_BPID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
