<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="RP_spmtOrderToStock.aspx.vb" Inherits="RP_spmtOrderToStock" title="Print: Delivery Challan" %>
<asp:Content ID="CPHspmtDCHeader" ContentPlaceHolderID="cph1" Runat="Server">
<div style="width:600px;height:400px" class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtDCHeader" runat="server" Text="&nbsp;Print: Delivery Challan"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtDCHeader" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "TBLspmtDCHeader"
      ToolType="lgNDEdit"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtDCHeader" runat="server" AssociatedUpdatePanelID="UPNLspmtDCHeader" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <div id="frmdiv" class="ui-widget-content minipage">
      <table>
        <tr>
          <td>
            <asp:Label ID="label1" runat="server" Text="From DC Date :" />
          </td>
          <td>
            <asp:TextBox ID="F_sDt"
              Width="80px"
              CssClass = "mytxt"
              onfocus = "return this.select();"
              runat="server" />
            <asp:Image ID="ImageButtonReceivedDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
            <AJX:CalendarExtender 
              ID = "CEReceivedDate"
              TargetControlID="F_sDt"
              Format="dd/MM/yyyy"
              runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonReceivedDate" />
            <AJX:MaskedEditExtender 
              ID = "MEEReceivedDate"
              runat = "server"
              mask = "99/99/9999"
              MaskType="Date"
              CultureName = "en-GB"
              MessageValidatorTip="true"
              InputDirection="LeftToRight"
              ErrorTooltipEnabled="true"
              TargetControlID="F_sDt" />
          </td>
        </tr>
        <tr>
          <td>
            <asp:Label ID="label2" runat="server" Text="Till DC Date :" />
          </td>
          <td>
            <asp:TextBox ID="F_tDt"
              Width="80px"
              CssClass = "mytxt"
              onfocus = "return this.select();"
              runat="server" />
            <asp:Image ID="Image1" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
            <AJX:CalendarExtender 
              ID = "CalendarExtender1"
              TargetControlID="F_tDt"
              Format="dd/MM/yyyy"
              runat = "server" CssClass="MyCalendar" PopupButtonID="Image1" />
            <AJX:MaskedEditExtender 
              ID = "MaskedEditExtender1"
              runat = "server"
              mask = "99/99/9999"
              MaskType="Date"
              CultureName = "en-GB"
              MessageValidatorTip="true"
              InputDirection="LeftToRight"
              ErrorTooltipEnabled="true"
              TargetControlID="F_tDt" />
          </td>
        </tr>
        <tr>
          <td></td>
          <td class="alignCenter">
            <asp:Button ID="cmdReport" runat="server" Text="Print" />
          </td>
        </tr>
      </table>
      </div>
  </ContentTemplate>
  <Triggers>
    <asp:PostBackTrigger ControlID="cmdReport" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
