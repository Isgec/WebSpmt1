<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtIsgecGSTIN.aspx.vb" Inherits="EF_spmtIsgecGSTIN" title="Edit: Isgec GSTIN" %>
<asp:Content ID="CPHspmtIsgecGSTIN" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtIsgecGSTIN" runat="server" Text="&nbsp;Edit: Isgec GSTIN"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtIsgecGSTIN" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtIsgecGSTIN"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtIsgecGSTIN"
    runat = "server" />
<asp:FormView ID="FVspmtIsgecGSTIN"
  runat = "server"
  DataKeyNames = "GSTID"
  DataSourceID = "ODSspmtIsgecGSTIN"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GSTID" runat="server" ForeColor="#CC6633" Text="GST ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_GSTID"
            Text='<%# Bind("GSTID") %>'
            ToolTip="Value of GST ID."
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
            ValidationGroup="spmtIsgecGSTIN"
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
            ValidationGroup = "spmtIsgecGSTIN"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_State" runat="server" Text="State :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_State"
            Text='<%# Bind("State") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtIsgecGSTIN"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for State."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVState"
            runat = "server"
            ControlToValidate = "F_State"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtIsgecGSTIN"
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
  ID = "ODSspmtIsgecGSTIN"
  DataObjectTypeName = "SIS.SPMT.spmtIsgecGSTIN"
  SelectMethod = "spmtIsgecGSTINGetByID"
  UpdateMethod="spmtIsgecGSTINUpdate"
  DeleteMethod="spmtIsgecGSTINDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtIsgecGSTIN"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GSTID" Name="GSTID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
