<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtIsgecGSTIN.aspx.vb" Inherits="AF_spmtIsgecGSTIN" title="Add: Isgec GSTIN" %>
<asp:Content ID="CPHspmtIsgecGSTIN" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtIsgecGSTIN" runat="server" Text="&nbsp;Add: Isgec GSTIN"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtIsgecGSTIN" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtIsgecGSTIN"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtIsgecGSTIN"
    runat = "server" />
<asp:FormView ID="FVspmtIsgecGSTIN"
  runat = "server"
  DataKeyNames = "GSTID"
  DataSourceID = "ODSspmtIsgecGSTIN"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtIsgecGSTIN" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GSTID" ForeColor="#CC6633" runat="server" Text="GST ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_GSTID"
            Text='<%# Bind("GSTID") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mypktxt"
            ValidationGroup="spmtIsgecGSTIN"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEGSTID"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_GSTID" />
          <AJX:MaskedEditValidator 
            ID = "MEVGSTID"
            runat = "server"
            ControlToValidate = "F_GSTID"
            ControlExtender = "MEEGSTID"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtIsgecGSTIN"
            IsValidEmpty = "false"
            MinimumValue = "1"
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
            ValidationGroup="spmtIsgecGSTIN"
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
            ValidationGroup = "spmtIsgecGSTIN"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_State" runat="server" Text="State :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_State"
            Text='<%# Bind("State") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtIsgecGSTIN"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for State."
            MaxLength="50"
            Width="408px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVState"
            runat = "server"
            ControlToValidate = "F_State"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtIsgecGSTIN"
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
  ID = "ODSspmtIsgecGSTIN"
  DataObjectTypeName = "SIS.SPMT.spmtIsgecGSTIN"
  InsertMethod="spmtIsgecGSTINInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtIsgecGSTIN"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
