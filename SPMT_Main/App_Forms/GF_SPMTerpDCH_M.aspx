<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_SPMTerpDCH_M.aspx.vb" Inherits="GF_SPMTerpDCH_M" title="Maintain List: ERP Delivery Challan" %>
<asp:Content ID="CPHSPMTerpDCH" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelSPMTerpDCH" runat="server" Text="&nbsp;List: ERP Delivery Challan"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCH" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLSPMTerpDCH"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_SPMTerpDCH_M.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_SPMTerpDCH.aspx?skip=1"
      ValidationGroup = "SPMTerpDCH"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSSPMTerpDCH" runat="server" AssociatedUpdatePanelID="UPNLSPMTerpDCH" DisplayAfter="100">
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
      <div style="display:flex; flex-direction:row; align-content:space-around;">
        <div>
          <asp:Label ID="i_label1" runat="server" Font-Bold="true" Text="Challan ID:"></asp:Label>
          <asp:TextBox ID="I_ChallanID" runat="server" Width="80px" CssClass="mypktxt"></asp:TextBox>
          <asp:Button ID="cmdImport" CssClass="nt-but-danger" runat="server" Text="Import Challan ID" />
        </div>
        <div style="padding-left:100px;">
          <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Delivery Challan Date Range:"></asp:Label>
					  <asp:TextBox ID="F_FromDate"
              Width="70px"
						  CssClass = "mytxt"
						  onfocus = "return this.select();"
						  runat="server" />
            <AJX:CalendarExtender 
              ID = "CEFromDate"
              TargetControlID="F_FromDate"
              Format="dd/MM/yyyy"
              runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonFromDate" />
					  <AJX:MaskedEditExtender 
						  ID = "MEEFromDate"
						  runat = "server"
						  mask = "99/99/9999"
						  MaskType="Date"
              CultureName = "en-GB"
						  MessageValidatorTip="true"
						  InputDirection="LeftToRight"
						  ErrorTooltipEnabled="true"
						  TargetControlID="F_FromDate" />
					  <asp:Image ID="ImageButtonFromDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
					  <AJX:MaskedEditValidator 
						  ID = "MEVFromDate"
						  runat = "server"
						  ControlToValidate = "F_FromDate"
						  ControlExtender = "MEEFromDate"
						  InvalidValueMessage = "Invalid From Date."
						  EmptyValueMessage = "Required."
						  EmptyValueBlurredText = "[Required!]"
						  Display = "Dynamic"
						  TooltipMessage = "Enter From Date."
						  EnableClientScript = "true"
						  IsValidEmpty = "true"
						  SetFocusOnError="true" />
					  <asp:TextBox ID="F_ToDate"
              Width="70px"
						  CssClass = "mytxt"
						  onfocus = "return this.select();"
						  runat="server" />
            <AJX:CalendarExtender 
              ID = "CEToDate"
              TargetControlID="F_ToDate"
              Format="dd/MM/yyyy"
              runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonToDate" />
					  <AJX:MaskedEditExtender 
						  ID = "MEEToDate"
						  runat = "server"
						  mask = "99/99/9999"
						  MaskType="Date"
              CultureName = "en-GB"
						  MessageValidatorTip="true"
						  InputDirection="LeftToRight"
						  ErrorTooltipEnabled="true"
						  TargetControlID="F_ToDate" />
					  <asp:Image ID="ImageButtonToDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
					  <AJX:MaskedEditValidator 
						  ID = "MEVToDate"
						  runat = "server"
						  ControlToValidate = "F_ToDate"
						  ControlExtender = "MEEToDate"
						  InvalidValueMessage = "Invalid To Date."
						  EmptyValueMessage = "Required."
						  EmptyValueBlurredText = "[Required!]"
						  Display = "Dynamic"
						  TooltipMessage = "Enter To Date."
						  EnableClientScript = "true"
						  IsValidEmpty = "true"
						  SetFocusOnError="true" />
			
          <asp:Button ID="cmdxImport" CssClass="nt-but-success" runat="server" Text="Import Challan for Date Range" />

        </div>
      </div>
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
    <asp:GridView ID="GVSPMTerpDCH" SkinID="gv_silver" runat="server" DataSourceID="ODSSPMTerpDCH" DataKeyNames="ChallanID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PRINT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_report(this);" />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Challan ID" SortExpression="ChallanID">
          <ItemTemplate>
            <asp:Label ID="LabelChallanID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ChallanID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Challan Date" SortExpression="ChallanDate">
          <ItemTemplate>
            <asp:Label ID="LabelChallanDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ChallanDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Issuer" SortExpression="SPMT_IsgecGSTIN11_Description">
          <ItemTemplate>
             <asp:Label ID="L_IssuerID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("IssuerID") %>' Text='<%# Eval("SPMT_IsgecGSTIN11_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Unit" SortExpression="HRM_Companies2_Description">
          <ItemTemplate>
             <asp:Label ID="L_UnitID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UnitID") %>' Text='<%# Eval("HRM_Companies2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Place Of Supply" SortExpression="SPMT_ERPStates5_Description">
          <ItemTemplate>
             <asp:Label ID="L_PlaceOfSupply" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("PlaceOfSupply") %>' Text='<%# Eval("SPMT_ERPStates5_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Place Of Delivery" SortExpression="SPMT_ERPStates6_Description">
          <ItemTemplate>
             <asp:Label ID="L_PlaceOfDelivery" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("PlaceOfDelivery") %>' Text='<%# Eval("SPMT_ERPStates6_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount" SortExpression="TotalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Created By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_CreatedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CreatedBy") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status" SortExpression="SPMT_DCStates4_Description">
          <ItemTemplate>
             <asp:Label ID="L_StatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("StatusID") %>' Text='<%# Eval("SPMT_DCStates4_Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle Width="100px" CssClass="alignCenter" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Issue">
          <ItemTemplate>
            <asp:ImageButton ID="cmdInitiateWF" ValidationGroup='<%# "Initiate" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("InitiateWFVisible") %>' Enabled='<%# EVal("InitiateWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Forward" SkinID="forward" OnClientClick='<%# "return Page_ClientValidate(""Initiate" & Container.DataItemIndex & """) && confirm(""Issue record ?"");" %>' CommandName="InitiateWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
<%--        <asp:TemplateField HeaderText="Receive">
          <ItemTemplate>
            <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ApproveWFVisible") %>' Enabled='<%# EVal("ApproveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Approve" SkinID="approve" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Receive record ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Close">
          <ItemTemplate>
            <asp:ImageButton ID="cmdCompleteWF" ValidationGroup='<%# "Complete" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("CompleteWFVisible") %>' Enabled='<%# EVal("CompleteWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Complete" SkinID="complete" OnClientClick='<%# "return Page_ClientValidate(""Complete" & Container.DataItemIndex & """) && confirm(""Close record ?"");" %>' CommandName="CompleteWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>--%>
        <asp:TemplateField HeaderText="Revert">
          <ItemTemplate>
            <asp:ImageButton ID="cmdRejectWF" ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("RejectWFVisible") %>' Enabled='<%# EVal("RejectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Reject" SkinID="reject" OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Revert to Created ?"");" %>' CommandName="RejectWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSSPMTerpDCH"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.SPMTerpDCH"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_SPMTerpDCHSelectList"
      TypeName = "SIS.SPMT.SPMTerpDCH"
      SelectCountMethod = "SPMTerpDCHSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVSPMTerpDCH" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
