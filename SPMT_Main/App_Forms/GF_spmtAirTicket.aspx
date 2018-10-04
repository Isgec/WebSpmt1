<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtAirTicket.aspx.vb" Inherits="GF_spmtAirTicket" title="Maintain List: Services" %>
<asp:Content ID="CPHspmtAirTicket" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtAirTicket" runat="server" Text="&nbsp;List: Services"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtAirTicket" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtAirTicket"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtAirTicket.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtAirTicket.aspx"
      ValidationGroup = "spmtAirTicket"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtAirTicket" runat="server" AssociatedUpdatePanelID="UPNLspmtAirTicket" DisplayAfter="100">
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
        <td></td>
        <td></td>
        <td rowspan="7" style="padding-left:50px">
            <div id="F_Upload" runat="server" style="width: 90%; margin: 10px 10px 10px 10px; padding: 10px 10px 10px 10px" class="file_upload">
              <table>
                <tr>
                  <td style="vertical-align:top">
                    <b>
                      1.
                    </b>
                  </td>
                  <td style="column-span:all">
                    <b>
                      Download EXCEL Template 
                    </b>
                  </td>
                  <td>
                    <asp:Button ID="cmdDownload" CssClass="file_upload_button" Text="Download" runat="server" ToolTip="Click to download template file." CommandName="Download" CommandArgument="" />
                  </td>
                </tr>
                <tr>
                  <td style="vertical-align:top">
                    <b>
                      2.
                    </b>
                  </td>
                  <td>
                    <b>
                      Upload 
                    </b>
                  </td>
                  <td>
                    <input type="text" id="fileName" style="width: 185px" class="file_input_textbox" readonly="readonly">
                  </td>
                  <td>
                    <div class="file_input_div">
                      <input type="button" value="Search" class="file_input_button" />
                      <asp:FileUpload ID="F_FileUpload" runat="server" Width="80px" class="file_input_hidden" onchange="document.getElementById('fileName').value = this.value;" ToolTip="Upload Item Template" />
                    </div>
                  </td>
                  <td>
                    <asp:Button ID="cmdFileUpload" CssClass="file_upload_button" OnClientClick="return this.style.display='none';true;" Text="Upload" runat="server" ToolTip="Click to upload & process template file." CommandName="Upload" CommandArgument="" />
                  </td>
                </tr>
              </table>
            </div>
            <asp:Label runat="server" ID="errMsg" ForeColor="Red" Text="" />
        </td>
      </tr> 
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type :" /></b>
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
          <b><asp:Label ID="L_AgentsBPID" runat="server" Text="Agents BP ID :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgentsBPID"
            CssClass = "myfktxt"
            Width="80px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_AgentsBPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_AgentsBPID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgentsBPID"
            BehaviorID="B_ACEAgentsBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgentsBPIDCompletionList"
            TargetControlID="F_AgentsBPID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEAgentsBPID_Selected"
            OnClientPopulating="ACEAgentsBPID_Populating"
            OnClientPopulated="ACEAgentsBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AgencyBPID" runat="server" Text="Agency BPID :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AgencyBPID"
            CssClass = "myfktxt"
            Width="80px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_AgencyBPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_AgencyBPID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAgencyBPID"
            BehaviorID="B_ACEAgencyBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AgencyBPIDCompletionList"
            TargetControlID="F_AgencyBPID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEAgencyBPID_Selected"
            OnClientPopulating="ACEAgencyBPID_Populating"
            OnClientPopulated="ACEAgencyBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_EmployeeID" runat="server" Text="Employee :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_EmployeeID"
            CssClass = "myfktxt"
            Width="72px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_EmployeeID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_EmployeeID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEEmployeeID"
            BehaviorID="B_ACEEmployeeID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="EmployeeIDCompletionList"
            TargetControlID="F_EmployeeID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEEmployeeID_Selected"
            OnClientPopulating="ACEEmployeeID_Populating"
            OnClientPopulated="ACEEmployeeID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ProjectID" runat="server" Text="Project :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "myfktxt"
            Width="56px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_ProjectID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEProjectID"
            BehaviorID="B_ACEProjectID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ProjectIDCompletionList"
            TargetControlID="F_ProjectID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEProjectID_Selected"
            OnClientPopulating="ACEProjectID_Populating"
            OnClientPopulated="ACEProjectID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ISGECUnit" runat="server" Text="ISGEC Unit :" /></b>
        </td>
        <td>
          <asp:DropDownList
            ID="F_ISGECUnit"
            Width="200px"
            Runat="Server" >
            <asp:ListItem Value="">---Select---</asp:ListItem>
            <asp:ListItem Value="HO">HO</asp:ListItem>
            <asp:ListItem Value="NON-HO">NON-HO</asp:ListItem>
          </asp:DropDownList>
         </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_Geography" runat="server" Text="Geography :" /></b>
        </td>
        <td>
          <asp:DropDownList
            ID="F_Geography"
            Width="200px"
            Runat="Server" >
            <asp:ListItem Value="">---Select---</asp:ListItem>
            <asp:ListItem Value="Domestic">Domestic</asp:ListItem>
            <asp:ListItem Value="International">International</asp:ListItem>
          </asp:DropDownList>
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_StatusID" runat="server" Text="Status :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_StatusID"
            CssClass = "myfktxt"
            Width="88px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_StatusID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_StatusID_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEStatusID"
            BehaviorID="B_ACEStatusID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="StatusIDCompletionList"
            TargetControlID="F_StatusID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEStatusID_Selected"
            OnClientPopulating="ACEStatusID_Populating"
            OnClientPopulated="ACEStatusID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AdviceNo" runat="server" Text="Advice No :" /></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceNo"
            CssClass = "myfktxt"
            Width="88px"
            Text=""
            onfocus = "return this.select();"
            AutoCompleteType = "None"
            onblur= "validate_AdviceNo(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceNo_Display"
            Text=""
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEAdviceNo"
            BehaviorID="B_ACEAdviceNo"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="AdviceNoCompletionList"
            TargetControlID="F_AdviceNo"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEAdviceNo_Selected"
            OnClientPopulating="ACEAdviceNo_Populating"
            OnClientPopulated="ACEAdviceNo_Populated"
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
    <asp:GridView ID="GVspmtAirTicket" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtAirTicket" DataKeyNames="SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Serial No" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran Type" SortExpression="SPMT_TranTypes12_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes12_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Agents Bill Number" SortExpression="AgentsBillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelAgentsBillNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AgentsBillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Agency Bill Number" SortExpression="AgencyBillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelAgencyBillNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AgencyBillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Payable To Agent" SortExpression="TotalPayableToAgent">
          <ItemTemplate>
            <asp:Label ID="LabelTotalPayableToAgent" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalPayableToAgent") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Pax Name" SortExpression="PaxName">
          <ItemTemplate>
            <asp:Label ID="LabelPaxName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PaxName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status" SortExpression="SPMT_AirTicketStatus17_Descriptionn">
          <ItemTemplate>
             <asp:Label ID="L_StatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("StatusID") %>' Text='<%# Eval("SPMT_AirTicketStatus17_Descriptionn") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Advice No" SortExpression="SPMT_PaymentAdvice11_BPID">
          <ItemTemplate>
             <asp:Label ID="L_AdviceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AdviceNo") %>' Text='<%# Eval("SPMT_PaymentAdvice11_BPID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtAirTicket"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtAirTicket"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtAirTicketSelectList"
      TypeName = "SIS.SPMT.spmtAirTicket"
      SelectCountMethod = "spmtAirTicketSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_TranTypeID" PropertyName="SelectedValue" Name="TranTypeID" Type="String" Size="3" />
        <asp:ControlParameter ControlID="F_StatusID" PropertyName="Text" Name="StatusID" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_AdviceNo" PropertyName="Text" Name="AdviceNo" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_Geography" PropertyName="Text" Name="Geography" Type="String" Size="10" />
        <asp:ControlParameter ControlID="F_ISGECUnit" PropertyName="Text" Name="ISGECUnit" Type="String" Size="10" />
        <asp:ControlParameter ControlID="F_ProjectID" PropertyName="Text" Name="ProjectID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_EmployeeID" PropertyName="Text" Name="EmployeeID" Type="String" Size="8" />
        <asp:ControlParameter ControlID="F_AgencyBPID" PropertyName="Text" Name="AgencyBPID" Type="String" Size="9" />
        <asp:ControlParameter ControlID="F_AgentsBPID" PropertyName="Text" Name="AgentsBPID" Type="String" Size="9" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtAirTicket" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_TranTypeID" />
    <asp:AsyncPostBackTrigger ControlID="F_StatusID" />
    <asp:AsyncPostBackTrigger ControlID="F_AdviceNo" />
    <asp:AsyncPostBackTrigger ControlID="F_Geography" />
    <asp:AsyncPostBackTrigger ControlID="F_ISGECUnit" />
    <asp:AsyncPostBackTrigger ControlID="F_ProjectID" />
    <asp:AsyncPostBackTrigger ControlID="F_EmployeeID" />
    <asp:AsyncPostBackTrigger ControlID="F_AgencyBPID" />
    <asp:AsyncPostBackTrigger ControlID="F_AgentsBPID" />
    <asp:PostBackTrigger ControlID="cmdFileUpload" />
    <asp:PostBackTrigger ControlID="cmdDownload" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
