<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_comFinanceCompany.aspx.vb" Inherits="EF_comFinanceCompany" title="Edit: Finance Company" %>
<asp:Content ID="CPHcomFinanceCompany" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelcomFinanceCompany" runat="server" Text="&nbsp;Edit: Finance Company"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLcomFinanceCompany" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLcomFinanceCompany"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "comFinanceCompany"
    runat = "server" />
<asp:FormView ID="FVcomFinanceCompany"
  runat = "server"
  DataKeyNames = "FinanceCompany"
  DataSourceID = "ODScomFinanceCompany"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_FinanceCompany" runat="server" ForeColor="#CC6633" Text="Finance Company :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_FinanceCompany"
            Text='<%# Bind("FinanceCompany") %>'
            ToolTip="Value of Finance Company."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CompanyName" runat="server" Text="Company Name :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_CompanyName"
            Text='<%# Bind("CompanyName") %>'
            Width="350px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="comFinanceCompany"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Company Name."
            MaxLength="100"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVCompanyName"
            runat = "server"
            ControlToValidate = "F_CompanyName"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "comFinanceCompany"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_LogisticCompany" runat="server" Text="Logistic Company :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_LogisticCompany"
            Text='<%# Bind("LogisticCompany") %>'
            Width="88px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="comFinanceCompany"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Logistic Company."
            MaxLength="10"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVLogisticCompany"
            runat = "server"
            ControlToValidate = "F_LogisticCompany"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "comFinanceCompany"
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
  ID = "ODScomFinanceCompany"
  DataObjectTypeName = "SIS.COM.comFinanceCompany"
  SelectMethod = "comFinanceCompanyGetByID"
  UpdateMethod="comFinanceCompanyUpdate"
  DeleteMethod="comFinanceCompanyDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.COM.comFinanceCompany"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="FinanceCompany" Name="FinanceCompany" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
