<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtHSNSACCodes.aspx.vb" Inherits="AF_spmtHSNSACCodes" title="Add: HSN / SAC Code" %>
<asp:Content ID="CPHspmtHSNSACCodes" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtHSNSACCodes" runat="server" Text="&nbsp;Add: HSN / SAC Code"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtHSNSACCodes" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtHSNSACCodes"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtHSNSACCodes"
    runat = "server" />
<asp:FormView ID="FVspmtHSNSACCodes"
  runat = "server"
  DataKeyNames = "BillType,HSNSACCode"
  DataSourceID = "ODSspmtHSNSACCodes"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtHSNSACCodes" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BillType" ForeColor="#CC6633" runat="server" Text="Bill Type :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <LGM:LC_spmtBillTypes
            ID="F_BillType"
            SelectedValue='<%# Bind("BillType") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtHSNSACCodes"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_HSNSACCode" ForeColor="#CC6633" runat="server" Text="HSN / SAC Code :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_HSNSACCode"
            Text='<%# Bind("HSNSACCode") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtHSNSACCodes"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for HSN / SAC Code."
            MaxLength="20"
            Width="168px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVHSNSACCode"
            runat = "server"
            ControlToValidate = "F_HSNSACCode"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtHSNSACCodes"
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
            ValidationGroup="spmtHSNSACCodes"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="500"
            Width="350px" Height="40px" TextMode="MultiLine"
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
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TaxRate" runat="server" Text="Tax Rate :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_TaxRate"
            Text='<%# Bind("TaxRate") %>'
            Width="200px"
            CssClass = "mytxt"
            style="text-align: Right"
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
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtHSNSACCodes"
  DataObjectTypeName = "SIS.SPMT.spmtHSNSACCodes"
  InsertMethod="spmtHSNSACCodesInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtHSNSACCodes"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
