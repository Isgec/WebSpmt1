<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtPAStatus.aspx.vb" Inherits="EF_spmtPAStatus" title="Edit: PA States" %>
<asp:Content ID="CPHspmtPAStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtPAStatus" runat="server" Text="&nbsp;Edit: PA States"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPAStatus" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtPAStatus"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtPAStatus"
    runat = "server" />
<asp:FormView ID="FVspmtPAStatus"
  runat = "server"
  DataKeyNames = "AdviceStatusID"
  DataSourceID = "ODSspmtPAStatus"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AdviceStatusID" runat="server" ForeColor="#CC6633" Text="PA Status ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_AdviceStatusID"
            Text='<%# Bind("AdviceStatusID") %>'
            ToolTip="Value of PA Status ID."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            style="text-align: right"
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
            Width="248px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtPAStatus"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="30"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescription"
            runat = "server"
            ControlToValidate = "F_Description"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtPAStatus"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_NextStatusID" runat="server" Text="Next Status ID :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_NextStatusID"
            Text='<%# Bind("NextStatusID") %>'
            style="text-align: right"
            Width="88px"
            CssClass = "mytxt"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEENextStatusID"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_NextStatusID" />
          <AJX:MaskedEditValidator 
            ID = "MEVNextStatusID"
            runat = "server"
            ControlToValidate = "F_NextStatusID"
            ControlExtender = "MEENextStatusID"
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
  ID = "ODSspmtPAStatus"
  DataObjectTypeName = "SIS.SPMT.spmtPAStatus"
  SelectMethod = "spmtPAStatusGetByID"
  UpdateMethod="spmtPAStatusUpdate"
  DeleteMethod="spmtPAStatusDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtPAStatus"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="AdviceStatusID" Name="AdviceStatusID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
