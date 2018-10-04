<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtBPGSTIN.aspx.vb" Inherits="EF_spmtBPGSTIN" title="Edit: BP GSTIN" %>
<asp:Content ID="CPHspmtBPGSTIN" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtBPGSTIN" runat="server" Text="&nbsp;Edit: BP GSTIN"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBPGSTIN" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtBPGSTIN"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtBPGSTIN"
    runat = "server" />
<asp:FormView ID="FVspmtBPGSTIN"
  runat = "server"
  DataKeyNames = "BPID,GSTIN"
  DataSourceID = "ODSspmtBPGSTIN"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BPID" runat="server" ForeColor="#CC6633" Text="BP ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of BP ID."
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner1_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GSTIN" runat="server" ForeColor="#CC6633" Text="GSTIN :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_GSTIN"
            Text='<%# Bind("GSTIN") %>'
            ToolTip="Value of GSTIN."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Description" runat="server" Text="Description :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Description"
            Text='<%# Bind("Description") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtBPGSTIN"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescription"
            runat = "server"
            ControlToValidate = "F_Description"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBPGSTIN"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
  </div>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtBPGSTIN"
  DataObjectTypeName = "SIS.SPMT.spmtBPGSTIN"
  SelectMethod = "spmtBPGSTINGetByID"
  UpdateMethod="spmtBPGSTINUpdate"
  DeleteMethod="spmtBPGSTINDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtBPGSTIN"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="BPID" Name="BPID" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GSTIN" Name="GSTIN" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
