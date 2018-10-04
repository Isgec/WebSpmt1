<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtAirTicketStatus.aspx.vb" Inherits="AF_spmtAirTicketStatus" title="Add: Air Ticket Status" %>
<asp:Content ID="CPHspmtAirTicketStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtAirTicketStatus" runat="server" Text="&nbsp;Add: Air Ticket Status"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtAirTicketStatus" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtAirTicketStatus"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtAirTicketStatus"
    runat = "server" />
<asp:FormView ID="FVspmtAirTicketStatus"
  runat = "server"
  DataKeyNames = "StatusID"
  DataSourceID = "ODSspmtAirTicketStatus"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtAirTicketStatus" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_StatusID" ForeColor="#CC6633" runat="server" Text="StatusID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_StatusID" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Descriptionn" runat="server" Text="Descriptionn :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Descriptionn"
            Text='<%# Bind("Descriptionn") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtAirTicketStatus"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Descriptionn."
            MaxLength="50"
            Width="408px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescriptionn"
            runat = "server"
            ControlToValidate = "F_Descriptionn"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtAirTicketStatus"
            SetFocusOnError="true" />
        </td>
      </tr>
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtAirTicketStatus"
  DataObjectTypeName = "SIS.SPMT.spmtAirTicketStatus"
  InsertMethod="spmtAirTicketStatusInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtAirTicketStatus"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
