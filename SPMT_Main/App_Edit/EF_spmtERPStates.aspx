<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtERPStates.aspx.vb" Inherits="EF_spmtERPStates" title="Edit: Indian States" %>
<asp:Content ID="CPHspmtERPStates" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtERPStates" runat="server" Text="&nbsp;Edit: Indian States"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtERPStates" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtERPStates"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtERPStates"
    runat = "server" />
<asp:FormView ID="FVspmtERPStates"
  runat = "server"
  DataKeyNames = "StateID"
  DataSourceID = "ODSspmtERPStates"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_StateID" runat="server" ForeColor="#CC6633" Text="State ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_StateID"
            Text='<%# Bind("StateID") %>'
            ToolTip="Value of State ID."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="24px"
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
            ValidationGroup="spmtERPStates"
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
            ValidationGroup = "spmtERPStates"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
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
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtERPStates"
  DataObjectTypeName = "SIS.SPMT.spmtERPStates"
  SelectMethod = "spmtERPStatesGetByID"
  UpdateMethod="spmtERPStatesUpdate"
  DeleteMethod="spmtERPStatesDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtERPStates"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="StateID" Name="StateID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
