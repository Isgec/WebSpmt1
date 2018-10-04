<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtERPStates.aspx.vb" Inherits="AF_spmtERPStates" title="Add: Indian States" %>
<asp:Content ID="CPHspmtERPStates" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtERPStates" runat="server" Text="&nbsp;Add: Indian States"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtERPStates" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtERPStates"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtERPStates"
    runat = "server" />
<asp:FormView ID="FVspmtERPStates"
  runat = "server"
  DataKeyNames = "StateID"
  DataSourceID = "ODSspmtERPStates"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtERPStates" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_StateID" ForeColor="#CC6633" runat="server" Text="State ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_StateID"
            Text='<%# Bind("StateID") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtERPStates"
            onblur= "script_spmtERPStates.validate_StateID(this);"
            ToolTip="Enter value for State ID."
            MaxLength="2"
            Width="24px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVStateID"
            runat = "server"
            ControlToValidate = "F_StateID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtERPStates"
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
            ValidationGroup="spmtERPStates"
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
            ValidationGroup = "spmtERPStates"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ISGECCentralGSTGL" runat="server" Text="ISGEC Central GST GL :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ISGECCentralGSTGL"
            Text='<%# Bind("ISGECCentralGSTGL") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ISGEC Central GST GL."
            MaxLength="7"
            Width="100px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ISGECStateGSTGL" runat="server" Text="ISGEC State GST GL :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ISGECStateGSTGL"
            Text='<%# Bind("ISGECStateGSTGL") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ISGEC State GST GL."
            MaxLength="7"
            Width="100px"
            runat="server" />
        </td>
      </tr>
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtERPStates"
  DataObjectTypeName = "SIS.SPMT.spmtERPStates"
  InsertMethod="spmtERPStatesInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtERPStates"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
