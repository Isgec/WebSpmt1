<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtBTADetails.aspx.vb" Inherits="GF_spmtBTADetails" title="Maintain List: BTA Details" %>
<asp:Content ID="CPHspmtBTADetails" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtBTADetails" runat="server" Text="&nbsp;List: BTA Details"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBTADetails" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <table>
      <tr>
        <td>
          <asp:Label runat="server" Font-Bold="true" ForeColor="BlueViolet" style="margin: 10px 10px auto 10px" Text="Upload BTA EXCEL" ></asp:Label>
        </td>
      </tr>
      <tr>
        <td style="text-align:center">
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
              <asp:HiddenField ID="IsUploaded" runat="server" ClientIDMode="Static" ></asp:HiddenField>
              <asp:FileUpload ID="F_FileUpload" runat="server" Width="250px" ToolTip="Browse QC List Template" />
              <asp:Button ID="cmdTmplUpload" Text="Upload" OnClientClick="$get('IsUploaded').value='YES';" runat="server" ToolTip="Click to upload file." CommandName="tmplUpload" CommandArgument='<%# Eval("PrimaryKey") %>' />
            </ContentTemplate>
            <Triggers>
              <asp:PostBackTrigger ControlID="cmdTmplUpload" />
            </Triggers>
          </asp:UpdatePanel>
        </td>
      </tr>
    </table>

    <LGM:ToolBar0 
      ID = "TBLspmtBTADetails"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtBTADetails.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtBTADetails.aspx"
      ValidationGroup = "spmtBTADetails"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtBTADetails" runat="server" AssociatedUpdatePanelID="UPNLspmtBTADetails" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
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
    <asp:GridView ID="GVspmtBTADetails" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtBTADetails" DataKeyNames="SerialNo">
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
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SerialNo" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PAX_NM" SortExpression="PAX_NM">
          <ItemTemplate>
            <asp:Label ID="LabelPAX_NM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PAX_NM") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CHARGE_DTE" SortExpression="CHARGE_DTE">
          <ItemTemplate>
            <asp:Label ID="LabelCHARGE_DTE" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CHARGE_DTE") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BKNG_DATE" SortExpression="BKNG_DATE">
          <ItemTemplate>
            <asp:Label ID="LabelBKNG_DATE" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BKNG_DATE") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="DEPT_DATE" SortExpression="DEPT_DATE">
          <ItemTemplate>
            <asp:Label ID="LabelDEPT_DATE" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("DEPT_DATE") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TICKET_NO" SortExpression="TICKET_NO">
          <ItemTemplate>
            <asp:Label ID="LabelTICKET_NO" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TICKET_NO") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CARRIER" SortExpression="CARRIER">
          <ItemTemplate>
            <asp:Label ID="LabelCARRIER" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CARRIER") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BatchNo" SortExpression="BatchNo">
          <ItemTemplate>
            <asp:Label ID="LabelBatchNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BatchNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="StatusID" SortExpression="SPMT_BTAStatus2_Descriptions">
          <ItemTemplate>
             <asp:Label ID="L_StatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("StatusID") %>' Text='<%# Eval("SPMT_BTAStatus2_Descriptions") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Forward">
          <ItemTemplate>
            <asp:ImageButton ID="cmdInitiateWF" ValidationGroup='<%# "Initiate" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("InitiateWFVisible") %>' Enabled='<%# EVal("InitiateWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Forward" SkinID="forward" OnClientClick='<%# "return Page_ClientValidate(""Initiate" & Container.DataItemIndex & """) && confirm(""Forward record ?"");" %>' CommandName="InitiateWF" CommandArgument='<%# Container.DataItemIndex %>' />
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
      ID = "ODSspmtBTADetails"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtBTADetails"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtBTADetailsSelectList"
      TypeName = "SIS.SPMT.spmtBTADetails"
      SelectCountMethod = "spmtBTADetailsSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtBTADetails" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
