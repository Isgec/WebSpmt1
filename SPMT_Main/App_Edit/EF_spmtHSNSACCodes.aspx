<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtHSNSACCodes.aspx.vb" Inherits="EF_spmtHSNSACCodes" title="Edit: HSN / SAC Code" %>
<asp:Content ID="CPHspmtHSNSACCodes" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtHSNSACCodes" runat="server" Text="&nbsp;Edit: HSN / SAC Code"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtHSNSACCodes" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtHSNSACCodes"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtHSNSACCodes"
    runat = "server" />
<asp:FormView ID="FVspmtHSNSACCodes"
  runat = "server"
  DataKeyNames = "BillType,HSNSACCode"
  DataSourceID = "ODSspmtHSNSACCodes"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BillType" runat="server" ForeColor="#CC6633" Text="Bill Type :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BillType"
            Width="88px"
            Text='<%# Bind("BillType") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Bill Type."
            Runat="Server" />
          <asp:Label
            ID = "F_BillType_Display"
            Text='<%# Eval("SPMT_BillTypes1_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_HSNSACCode" runat="server" ForeColor="#CC6633" Text="HSN / SAC Code :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_HSNSACCode"
            Text='<%# Bind("HSNSACCode") %>'
            ToolTip="Value of HSN / SAC Code."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="168px"
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
            Width="350px" Height="40px" TextMode="MultiLine"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtHSNSACCodes"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="500"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescription"
            runat = "server"
            ControlToValidate = "F_Description"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtHSNSACCodes"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TaxRate" runat="server" Text="Tax Rate :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_TaxRate"
            Text='<%# Bind("TaxRate") %>'
            style="text-align: right"
            Width="200px"
            CssClass = "mytxt"
            MaxLength="24"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEETaxRate"
            runat = "server"
            mask = "999999999999999999.999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_TaxRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVTaxRate"
            runat = "server"
            ControlToValidate = "F_TaxRate"
            ControlExtender = "MEETaxRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
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
  ID = "ODSspmtHSNSACCodes"
  DataObjectTypeName = "SIS.SPMT.spmtHSNSACCodes"
  SelectMethod = "spmtHSNSACCodesGetByID"
  UpdateMethod="spmtHSNSACCodesUpdate"
  DeleteMethod="spmtHSNSACCodesDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtHSNSACCodes"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="BillType" Name="BillType" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="HSNSACCode" Name="HSNSACCode" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
