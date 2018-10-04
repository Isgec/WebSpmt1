<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtUnlinkedSupplierBill.aspx.vb" Inherits="EF_spmtUnlinkedSupplierBill" title="Edit: Pending Bills" %>
<asp:Content ID="CPHspmtUnlinkedSupplierBill" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtUnlinkedSupplierBill" runat="server" Text="&nbsp;Edit: Pending Bills"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtUnlinkedSupplierBill" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtUnlinkedSupplierBill"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnableDelete = "False"
    ValidationGroup = "spmtUnlinkedSupplierBill"
    runat = "server" />
<asp:FormView ID="FVspmtUnlinkedSupplierBill"
  runat = "server"
  DataKeyNames = "IRNo"
  DataSourceID = "ODSspmtUnlinkedSupplierBill"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <asp:Label ID="L_PurchaseType" runat="server" Text="Purchase Type :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:DropDownList
            ID="F_PurchaseType"
            SelectedValue='<%# Bind("PurchaseType") %>'
            Width="200px"
            Enabled = "False"
            CssClass = "dmyddl"
            Runat="Server" >
            <asp:ListItem Value=" ">---Select---</asp:ListItem>
            <asp:ListItem Value="Purchase from Registered Dealer">Purchase from Registered Dealer</asp:ListItem>
            <asp:ListItem Value="Purchase from Composition Dealer">Purchase from Composition Dealer</asp:ListItem>
            <asp:ListItem Value=" Purchase from Unregistered Dealer"> Purchase from Unregistered Dealer</asp:ListItem>
            <asp:ListItem Value="Non GST expenses bill">Non GST expenses bill</asp:ListItem>
          </asp:DropDownList>
         </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_IRNo" runat="server" ForeColor="#CC6633" Text="IR No :" />&nbsp;</b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_IRNo"
            Text='<%# Bind("IRNo") %>'
            ToolTip="Value of IR No."
            Enabled = "False"
            Width="88px"
            CssClass = "dmypktxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TranTypeID" runat="server" Text="Tran.Type :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_TranTypeID"
            Width="32px"
            Text='<%# Bind("TranTypeID") %>'
            Enabled = "False"
            ToolTip="Value of Tran.Type."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_TranTypeID_Display"
            Text='<%# Eval("SPMT_TranTypes16_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IsgecGSTIN" runat="server" Text="Isgec GSTIN :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_IsgecGSTIN"
            Width="88px"
            Text='<%# Bind("IsgecGSTIN") %>'
            Enabled = "False"
            ToolTip="Value of Isgec GSTIN."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_IsgecGSTIN_Display"
            Text='<%# Eval("SPMT_IsgecGSTIN13_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="Supplier :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            Enabled = "False"
            ToolTip="Value of Supplier."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner18_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SupplierGSTIN" runat="server" Text="Supplier GSTIN :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_SupplierGSTIN"
            Width="88px"
            Text='<%# Bind("SupplierGSTIN") %>'
            Enabled = "False"
            ToolTip="Value of Supplier GSTIN."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_SupplierGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN17_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillType" runat="server" Text="Bil Type :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BillType"
            Width="88px"
            Text='<%# Bind("BillType") %>'
            Enabled = "False"
            ToolTip="Value of Bil Type."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_BillType_Display"
            Text='<%# Eval("SPMT_BillTypes8_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_HSNSACCode" runat="server" Text="HSN / SAC Code :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_HSNSACCode"
            Width="168px"
            Text='<%# Bind("HSNSACCode") %>'
            Enabled = "False"
            ToolTip="Value of HSN / SAC Code."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_HSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes12_HSNSACCode") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ShipToState" runat="server" Text="Ship To State :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ShipToState"
            Width="24px"
            Text='<%# Bind("ShipToState") %>'
            Enabled = "False"
            ToolTip="Value of Ship To State."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ShipToState_Display"
            Text='<%# Eval("SPMT_ERPStates10_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillNumber" runat="server" Text="Bill Number :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BillNumber"
            Text='<%# Bind("BillNumber") %>'
            ToolTip="Value of Bill Number."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillDate" runat="server" Text="Bill Date :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BillDate"
            Text='<%# Bind("BillDate") %>'
            ToolTip="Value of Bill Date."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillRemarks" runat="server" Text="Item Description :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BillRemarks"
            Text='<%# Bind("BillRemarks") %>'
            ToolTip="Value of Item Description."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_UOM" runat="server" Text="UOM :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_UOM"
            Width="32px"
            Text='<%# Bind("UOM") %>'
            Enabled = "False"
            ToolTip="Value of UOM."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_UOM_Display"
            Text='<%# Eval("SPMT_ERPUnits11_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            ToolTip="Value of Quantity."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Currency" runat="server" Text="Currency :" />&nbsp;
        </td>
        <td>
          <asp:DropDownList
            ID="F_Currency"
            SelectedValue='<%# Bind("Currency") %>'
            Width="200px"
            Enabled = "False"
            CssClass = "dmyddl"
            Runat="Server" >
            <asp:ListItem Value=" ">---Select---</asp:ListItem>
            <asp:ListItem Value="USD">USD</asp:ListItem>
            <asp:ListItem Value="EURO">EURO</asp:ListItem>
            <asp:ListItem Value="INR">INR</asp:ListItem>
          </asp:DropDownList>
         </td>
        <td class="alignright">
          <asp:Label ID="L_ConversionFactorINR" runat="server" Text="Conversion Factor INR :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ConversionFactorINR"
            Text='<%# Bind("ConversionFactorINR") %>'
            ToolTip="Value of Conversion Factor INR."
            Enabled = "False"
            Width="200px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AssessableValue" runat="server" Text="Basic / Assessable Value :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_AssessableValue"
            Text='<%# Bind("AssessableValue") %>'
            ToolTip="Value of Basic / Assessable Value."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IGSTRate" runat="server" Text="IGST Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IGSTRate"
            Text='<%# Bind("IGSTRate") %>'
            ToolTip="Value of IGST Rate."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_IGSTAmount" runat="server" Text="IGST Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IGSTAmount"
            Text='<%# Bind("IGSTAmount") %>'
            ToolTip="Value of IGST Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CGSTRate" runat="server" Text="CGST Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CGSTRate"
            Text='<%# Bind("CGSTRate") %>'
            ToolTip="Value of CGST Rate."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CGSTAmount" runat="server" Text="CGST Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CGSTAmount"
            Text='<%# Bind("CGSTAmount") %>'
            ToolTip="Value of CGST Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SGSTRate" runat="server" Text="SGST Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SGSTRate"
            Text='<%# Bind("SGSTRate") %>'
            ToolTip="Value of SGST Rate."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SGSTAmount" runat="server" Text="SGST Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SGSTAmount"
            Text='<%# Bind("SGSTAmount") %>'
            ToolTip="Value of SGST Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CessRate" runat="server" Text="Cess Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CessRate"
            Text='<%# Bind("CessRate") %>'
            ToolTip="Value of Cess Rate."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CessAmount" runat="server" Text="Cess Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CessAmount"
            Text='<%# Bind("CessAmount") %>'
            ToolTip="Value of Cess Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalGST" runat="server" Text="Total GST :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalGST"
            Text='<%# Bind("TotalGST") %>'
            ToolTip="Value of Total GST."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TaxAmount" runat="server" Text="Total GST [INR] :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TaxAmount"
            Text='<%# Bind("TaxAmount") %>'
            ToolTip="Value of Total GST [INR]."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalAmount" runat="server" Text="Total Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalAmount"
            Text='<%# Bind("TotalAmount") %>'
            ToolTip="Value of Total Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TotalAmountINR" runat="server" Text="Total Amount INR :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalAmountINR"
            Text='<%# Bind("TotalAmountINR") %>'
            ToolTip="Value of Total Amount INR."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_RemarksGST" runat="server" Text="Remarks GST :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_RemarksGST"
            Text='<%# Bind("RemarksGST") %>'
            ToolTip="Value of Remarks GST."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IRReceivedOn" runat="server" Text="IR Received On :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_IRReceivedOn"
            Text='<%# Bind("IRReceivedOn") %>'
            ToolTip="Value of IR Received On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
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
  ID = "ODSspmtUnlinkedSupplierBill"
  DataObjectTypeName = "SIS.SPMT.spmtUnlinkedSupplierBill"
  SelectMethod = "spmtUnlinkedSupplierBillGetByID"
  UpdateMethod="UZ_spmtUnlinkedSupplierBillUpdate"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtUnlinkedSupplierBill"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="IRNo" Name="IRNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
