<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_SPMTerpDCDS.aspx.vb" Inherits="EF_SPMTerpDCDS" title="Edit: ERP DC Item Source" %>
<asp:Content ID="CPHSPMTerpDCDS" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCDS" runat="server" Text="&nbsp;Edit: ERP DC Item Source"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCDS" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCDS"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "SPMTerpDCDS"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCDS"
  runat = "server"
  DataKeyNames = "ChallanID,SerialNo,SourceNo"
  DataSourceID = "ODSSPMTerpDCDS"
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
            Runat="Server" />
          <asp:Label
            ID = "F_SerialNo_Display"
            Text='<%# Eval("SPMT_erpDCD2_ItemDescription") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_SourceNo" runat="server" ForeColor="#CC6633" Text="Source No :" /></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_SourceNo"
            Text='<%# Bind("SourceNo") %>'
            ToolTip="Value of SourceNo."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            style="text-align: right"
            runat="server" />
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
            Enabled="False"
            Runat="Server" />
          </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "SPMTerpDCDS"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEQuantity"
            runat = "server"
            mask = "9999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_Quantity" />
          <AJX:MaskedEditValidator 
            ID = "MEVQuantity"
            runat = "server"
            ControlToValidate = "F_Quantity"
            ControlExtender = "MEEQuantity"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCDS"
            IsValidEmpty = "false"
            MinimumValue = "0.0001"
            SetFocusOnError="true" />
        </td>
      </tr>
    </table>
  </div>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSSPMTerpDCDS"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCDS"
  SelectMethod = "SPMTerpDCDSGetByID"
  UpdateMethod="UZ_SPMTerpDCDSUpdate"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCDS"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ChallanID" Name="ChallanID" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SourceNo" Name="SourceNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
