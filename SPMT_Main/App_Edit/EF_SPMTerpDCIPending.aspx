<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_SPMTerpDCIPending.aspx.vb" Inherits="EF_SPMTerpDCIPending" title="Edit: ERP DC Balance Inventory" %>
<asp:Content ID="CPHSPMTerpDCIPending" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCIPending" runat="server" Text="&nbsp;Edit: ERP DC Balance Inventory"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCIPending" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCIPending"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "SPMTerpDCIPending"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCIPending"
  runat = "server"
  DataKeyNames = "ChallanID,SerialNo"
  DataSourceID = "ODSSPMTerpDCIPending"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ChallanID" runat="server" ForeColor="#CC6633" Text="Challan ID :" /></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ChallanID"
            Width="168px"
            Text='<%# Bind("ChallanID") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of ChallanID."
            Runat="Server" />
          <asp:Label
            ID = "F_ChallanID_Display"
            Text='<%# Eval("SPMT_erpDCH3_PlaceOfDelivery") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" runat="server" ForeColor="#CC6633" Text="Serial No :" /></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_SerialNo"
            Width="88px"
            Text='<%# Bind("SerialNo") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of SerialNo."
            Runat="Server" />
          <asp:Label
            ID = "F_SerialNo_Display"
            Text='<%# Eval("SPMT_erpDCD10_ItemDescription") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ItemDescription" runat="server" Text="Item Description :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ItemDescription"
            Text='<%# Bind("ItemDescription") %>'
            Width="500px"
            CssClass = "dmytxt"
            Enabled="false"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaseRate" runat="server" Text="Base Rate :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaseRate"
            Text='<%# Bind("BaseRate") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "dmytxt"
            Enabled="false"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillTypeID" runat="server" Text="Bill Type :" />
        </td>
        <td>
          <LGM:LC_spmtBillTypes
            ID="F_BillTypeID"
            SelectedValue='<%# Bind("BillTypeID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="dmytxt"
            Enabled="false"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_HSNSACCode" runat="server" Text="HSN-SAC Code :" />
        </td>
        <td>
          <asp:TextBox
            ID = "F_HSNSACCode"
            CssClass = "dmyfktxt"
            Text='<%# Bind("HSNSACCode") %>'
            AutoCompleteType = "None"
            Width="168px"
            Enabled="false"
            Runat="Server" />
          <asp:Label
            ID = "F_HSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes6_HSNSACCode") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_UOM" runat="server" Text="UOM :" />
        </td>
        <td colspan="3">
          <LGM:LC_spmtERPUnits
            ID="F_UOM"
            SelectedValue='<%# Bind("UOM") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="dmytxt"
            Enabled="false"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "dmytxt"
            Enabled="false"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_QuantityUsed" runat="server" Font-Bold="true" Text="Balance Quantity :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_QuantityUsed"
            Text='<%# Eval("QuantityBalance") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "dmytxt"
            Enabled="false"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerIsgecID" runat="server" Text="Consigner Isgec ID :" />
        </td>
        <td colspan="3">
          <LGM:LC_spmtIsgecGSTIN
            ID="F_ConsignerIsgecID"
            SelectedValue='<%# Bind("ConsignerIsgecID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="400px"
            CssClass="dmytxt"
            Enabled="false"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerBPID" runat="server" Text="Consigner BPID :" />
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ConsignerBPID"
            CssClass = "dmyfktxt"
            Text='<%# Bind("ConsignerBPID") %>'
            AutoCompleteType = "None"
            Width="80px"
            Enabled="false"
            Runat="Server" />
          <asp:Label
            ID = "F_ConsignerBPID_Display"
            Text='<%# Eval("VR_BusinessPartner9_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerGSTIN" runat="server" Text="Consigner GSTIN :" />
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ConsignerGSTIN"
            CssClass = "dmyfktxt"
            Text='<%# Bind("ConsignerGSTIN") %>'
            AutoCompleteType = "None"
            Width="88px"
            Enabled="false"
            Runat="Server" />
          <asp:Label
            ID = "F_ConsignerGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN8_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerName" runat="server" Text="Consigner Name :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ConsignerName"
            Text='<%# Bind("ConsignerName") %>'
            Width="408px"
            CssClass = "dmytxt"
            Enabled="false"
            MaxLength="50"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConsignerGSTINNo" runat="server" Text="Consigner GSTIN No :" />
        </td>
        <td>
          <asp:TextBox ID="F_ConsignerGSTINNo"
            Text='<%# Bind("ConsignerGSTINNo") %>'
            Width="408px"
            CssClass = "dmytxt"
            Enabled="false"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ConsignerStateID" runat="server" Text="Consigner State ID :" />
        </td>
        <td>
          <LGM:LC_spmtERPStates
            ID="F_ConsignerStateID"
            SelectedValue='<%# Bind("ConsignerStateID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="dmytxt"
            Enabled="false"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" />
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ProjectID"
            CssClass = "dmyfktxt"
            Text='<%# Bind("ProjectID") %>'
            AutoCompleteType = "None"
            Width="56px"
            Enabled="false"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects1_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
    </table>
  </div>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSSPMTerpDCIPending"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCIPending"
  SelectMethod = "SPMTerpDCIPendingGetByID"
  UpdateMethod="SPMTerpDCIPendingUpdate"
  DeleteMethod="SPMTerpDCIPendingDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCIPending"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ChallanID" Name="ChallanID" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
