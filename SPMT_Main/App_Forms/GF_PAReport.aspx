<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_PAReport.aspx.vb" Inherits="GF_PAReport" title="CR Report" %>
<asp:Content ID="CPHlgDMisg" ContentPlaceHolderID="cph1" ClientIDMode="Static" runat="Server">
  <div class="ui-widget-content page">
    <div class="caption">
      <asp:Label ID="LabellgDMisg" runat="server" Text="&nbsp;Payment Advice Report"></asp:Label>
    </div>
    <div class="pagedata">
      <asp:UpdatePanel ID="UPNLlgDMisg" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="TBLPAReport"
            ToolType="lgNReport"
            runat="server" />
          <div class="ui-widget-content minipage" style="min-height: 300px;">
            <asp:UpdateProgress ID="UPGSlgDMisg" runat="server" AssociatedUpdatePanelID="UPNLlgDMisg" DisplayAfter="100">
              <ProgressTemplate>
                <span style="color: #ff0033">Loading...</span>
              </ProgressTemplate>
            </asp:UpdateProgress>
            <br />
            <br />
            <table>
              <tr>
                <td class="alignright">
                  <b>
                    <asp:Label ID="Label1" runat="server" Text="From IRN :" /></b>
                </td>
                <td>
                  <asp:TextBox ID="F_FIRN"
                    Text=""
                    Width="70px"
                    CssClass="mytxt"
                    onfocus="return this.select();"
                    runat="server" />
                </td>
                <td class="alignright">
                  <b>
                    <asp:Label ID="Label2" runat="server" Text="To IRN :" /></b>
                </td>
                <td>
                  <asp:TextBox ID="F_TIRN"
                    Text=""
                    Width="70px"
                    CssClass="mytxt"
                    onfocus="return this.select();"
                    runat="server" />
                </td>
              </tr>


              <tr>
                <td class="alignright">
                  <b>
                    <asp:Label ID="L_FromDate" runat="server" Text="From Date :" /></b>
                </td>
                <td>
                  <asp:TextBox ID="F_FromDate"
                    Text='<%# Bind("FromDate") %>'
                    Width="70px"
                    CssClass="mytxt"
                    onfocus="return this.select();"
                    runat="server" />
                  <AJX:CalendarExtender
                    ID="CEFromDate"
                    TargetControlID="F_FromDate"
                    Format="dd/MM/yyyy"
                    runat="server" CssClass="MyCalendar" PopupButtonID="ImageButtonFromDate" />
                  <AJX:MaskedEditExtender
                    ID="MEEFromDate"
                    runat="server"
                    Mask="99/99/9999"
                    MaskType="Date"
                    CultureName="en-GB"
                    MessageValidatorTip="true"
                    InputDirection="LeftToRight"
                    ErrorTooltipEnabled="true"
                    TargetControlID="F_FromDate" />
                  <asp:Image ID="ImageButtonFromDate" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer; vertical-align: bottom" ImageUrl="~/Images/cal.png" />
                  <AJX:MaskedEditValidator
                    ID="MEVFromDate"
                    runat="server"
                    ControlToValidate="F_FromDate"
                    ControlExtender="MEEFromDate"
                    InvalidValueMessage="Invalid Date."
                    EmptyValueMessage="Required."
                    EmptyValueBlurredText="[Required!]"
                    Display="Dynamic"
                    TooltipMessage="From IRN Date."
                    EnableClientScript="true"
                    IsValidEmpty="true"
                    SetFocusOnError="true" />
                </td>
                <td class="alignright">
                  <b>
                    <asp:Label ID="L_ToDate" runat="server" Text="To Date :" /></b>
                </td>
                <td>
                  <asp:TextBox ID="F_ToDate"
                    Text='<%# Bind("ToDate") %>'
                    Width="70px"
                    CssClass="mytxt"
                    onfocus="return this.select();"
                    runat="server" />
                  <AJX:CalendarExtender
                    ID="CEToDate"
                    TargetControlID="F_ToDate"
                    Format="dd/MM/yyyy"
                    runat="server" CssClass="MyCalendar" PopupButtonID="ImageButtonToDate" />
                  <AJX:MaskedEditExtender
                    ID="MEEToDate"
                    runat="server"
                    Mask="99/99/9999"
                    MaskType="Date"
                    CultureName="en-GB"
                    MessageValidatorTip="true"
                    InputDirection="LeftToRight"
                    ErrorTooltipEnabled="true"
                    TargetControlID="F_ToDate" />
                  <asp:Image ID="ImageButtonToDate" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer; vertical-align: bottom" ImageUrl="~/Images/cal.png" />
                  <AJX:MaskedEditValidator
                    ID="MEVToDate"
                    runat="server"
                    ControlToValidate="F_ToDate"
                    ControlExtender="MEEToDate"
                    InvalidValueMessage="Invalid Date."
                    EmptyValueMessage="Required."
                    EmptyValueBlurredText="[Required!]"
                    Display="Dynamic"
                    TooltipMessage="To IRN Date."
                    EnableClientScript="true"
                    IsValidEmpty="true"
                    SetFocusOnError="true" />
                </td>
              </tr>

              <tr>
                <td class="alignright">
                  <b>
                    <asp:Label ID="Label3" runat="server" Text="From Advice No :" /></b>
                </td>
                <td>
                  <asp:TextBox ID="F_FADN"
                    Text=""
                    Width="70px"
                    CssClass="mytxt"
                    onfocus="return this.select();"
                    runat="server" />
                </td>
                <td class="alignright">
                  <b>
                    <asp:Label ID="Label4" runat="server" Text="To Advice No :" /></b>
                </td>
                <td>
                  <asp:TextBox ID="F_TADN"
                    Text=""
                    Width="70px"
                    CssClass="mytxt"
                    onfocus="return this.select();"
                    runat="server" />
                </td>
              </tr>
              <tr>
                <td class="alignright">
                  <b>
                    <asp:Label ID="Label5" runat="server" Text="Status :" /></b>
                </td>
                <td>
                  <LGM:LC_spmtPAStatus
                    ID="F_StatusID"
                    SelectedValue=""
                    OrderBy="Reports"
                    DataTextField="Description"
                    DataValueField="AdviceStatusID"
                    IncludeDefault="true"
                    DefaultText="-- Select --"
                    Width="200px"
                    AutoPostBack="false"
                    RequiredFieldErrorMessage=""
                    CssClass="myddl"
                    Runat="Server" />
                </td>
                <td class="alignright">
                  <b>
                    <asp:Label ID="Label6" runat="server" Text="" /></b>
                </td>
                <td></td>
              </tr>
              <tr>
                <td colspan="4" style="text-align: center; padding: 4px;">
                  <input type="button" runat="server" id="cmdDownload" data-xid='<%# F_StatusID.LCClientID %>' onclick='script_download(this);' value=" Download " />
                </td>
              </tr>
            </table>
          </div>
        </ContentTemplate>
      </asp:UpdatePanel>
    </div>
  </div>
  <script>
    var pcnt = 0;
    function script_download(x) {
      if ($get('F_FromDate').value == '' || $get('F_ToDate').value == '') {
        alert('From Date and To Date is Requited.');
        return false;
      }
      pcnt = pcnt + 1;
      var nam = 'wdwd' + pcnt;
      var url = self.location.href.replace('App_Forms/GF_PAReport.aspx', 'App_Downloads/PAReport.aspx');
      url = url + '?val=' + $get('F_FIRN').value + '|' + $get('F_TIRN').value + '|' + $get('F_FromDate').value + '|' + $get('F_ToDate').value + '|' + $get('F_FADN').value + '|' + $get('F_TADN').value + '|' + $get(x.dataset.xid).value;
      window.open(url, nam, 'left=20,top=20,width=100,height=100,toolbar=1,resizable=1,scrollbars=1');
      return false;
      }
  </script>

</asp:Content>
