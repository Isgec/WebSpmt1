<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtERPUnits.aspx.vb" Inherits="AF_spmtERPUnits" title="Add: Unit Of Measurement" %>
<asp:Content ID="CPHspmtERPUnits" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtERPUnits" runat="server" Text="&nbsp;Add: Unit Of Measurement"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtERPUnits" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtERPUnits"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtERPUnits"
    runat = "server" />
<asp:FormView ID="FVspmtERPUnits"
  runat = "server"
  DataKeyNames = "UOM"
  DataSourceID = "ODSspmtERPUnits"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtERPUnits" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_UOM" ForeColor="#CC6633" runat="server" Text="UOM :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_UOM"
            Text='<%# Bind("UOM") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtERPUnits"
            onblur= "script_spmtERPUnits.validate_UOM(this);"
            ToolTip="Enter value for UOM."
            MaxLength="3"
            Width="32px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVUOM"
            runat = "server"
            ControlToValidate = "F_UOM"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtERPUnits"
            SetFocusOnError="true" />
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
            ValidationGroup="spmtERPUnits"
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
            ValidationGroup = "spmtERPUnits"
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
  ID = "ODSspmtERPUnits"
  DataObjectTypeName = "SIS.SPMT.spmtERPUnits"
  InsertMethod="spmtERPUnitsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtERPUnits"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
