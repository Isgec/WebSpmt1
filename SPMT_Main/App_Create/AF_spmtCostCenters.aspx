<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtCostCenters.aspx.vb" Inherits="AF_spmtCostCenters" title="Add: Cost Centers" %>
<asp:Content ID="CPHspmtCostCenters" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtCostCenters" runat="server" Text="&nbsp;Add: Cost Centers"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtCostCenters" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtCostCenters"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtCostCenters"
    runat = "server" />
<asp:FormView ID="FVspmtCostCenters"
  runat = "server"
  DataKeyNames = "CostCenterID"
  DataSourceID = "ODSspmtCostCenters"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtCostCenters" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_CostCenterID" ForeColor="#CC6633" runat="server" Text="Cost Center ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_CostCenterID"
            Text='<%# Bind("CostCenterID") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtCostCenters"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Cost Center ID."
            MaxLength="6"
            Width="56px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVCostCenterID"
            runat = "server"
            ControlToValidate = "F_CostCenterID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtCostCenters"
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
            ValidationGroup="spmtCostCenters"
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
            ValidationGroup = "spmtCostCenters"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaaNCompany" runat="server" Text="BaaN Company :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaaNCompany"
            Text='<%# Bind("BaaNCompany") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for BaaN Company."
            MaxLength="10"
            Width="88px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaaNLedger" runat="server" Text="BaaN Ledger :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaaNLedger"
            Text='<%# Bind("BaaNLedger") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for BaaN Ledger."
            MaxLength="20"
            Width="168px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Location" runat="server" Text="Location :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Location"
            Text='<%# Bind("Location") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Location."
            MaxLength="50"
            Width="408px"
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
  ID = "ODSspmtCostCenters"
  DataObjectTypeName = "SIS.SPMT.spmtCostCenters"
  InsertMethod="spmtCostCentersInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtCostCenters"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
