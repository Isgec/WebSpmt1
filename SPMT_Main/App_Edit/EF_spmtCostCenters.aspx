<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtCostCenters.aspx.vb" Inherits="EF_spmtCostCenters" title="Edit: Cost Centers" %>
<asp:Content ID="CPHspmtCostCenters" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtCostCenters" runat="server" Text="&nbsp;Edit: Cost Centers"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtCostCenters" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtCostCenters"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtCostCenters"
    runat = "server" />
<asp:FormView ID="FVspmtCostCenters"
  runat = "server"
  DataKeyNames = "CostCenterID"
  DataSourceID = "ODSspmtCostCenters"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_CostCenterID" runat="server" ForeColor="#CC6633" Text="Cost Center ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_CostCenterID"
            Text='<%# Bind("CostCenterID") %>'
            ToolTip="Value of Cost Center ID."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="56px"
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
            ValidationGroup="spmtCostCenters"
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
            ValidationGroup = "spmtCostCenters"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaaNCompany" runat="server" Text="BaaN Company :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaaNCompany"
            Text='<%# Bind("BaaNCompany") %>'
            Width="88px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for BaaN Company."
            MaxLength="10"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaaNLedger" runat="server" Text="BaaN Ledger :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaaNLedger"
            Text='<%# Bind("BaaNLedger") %>'
            Width="168px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for BaaN Ledger."
            MaxLength="20"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Location" runat="server" Text="Location :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Location"
            Text='<%# Bind("Location") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Location."
            MaxLength="50"
            runat="server" />
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
  ID = "ODSspmtCostCenters"
  DataObjectTypeName = "SIS.SPMT.spmtCostCenters"
  SelectMethod = "spmtCostCentersGetByID"
  UpdateMethod="spmtCostCentersUpdate"
  DeleteMethod="spmtCostCentersDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtCostCenters"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="CostCenterID" Name="CostCenterID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
