<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtModeOfTransport.aspx.vb" Inherits="AF_spmtModeOfTransport" title="Add: SPMT_ModeOfTransport" %>
<asp:Content ID="CPHspmtModeOfTransport" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtModeOfTransport" runat="server" Text="&nbsp;Add: SPMT_ModeOfTransport"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtModeOfTransport" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtModeOfTransport"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtModeOfTransport"
    runat = "server" />
<asp:FormView ID="FVspmtModeOfTransport"
  runat = "server"
  DataKeyNames = "ModeID"
  DataSourceID = "ODSspmtModeOfTransport"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtModeOfTransport" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ModeID" ForeColor="#CC6633" runat="server" Text="Mode ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ModeID" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Description" runat="server" Text="Description :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Description"
            Text='<%# Bind("Description") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtModeOfTransport"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="50"
            Width="408px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescription"
            runat = "server"
            ControlToValidate = "F_Description"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtModeOfTransport"
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
  ID = "ODSspmtModeOfTransport"
  DataObjectTypeName = "SIS.SPMT.spmtModeOfTransport"
  InsertMethod="spmtModeOfTransportInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtModeOfTransport"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
