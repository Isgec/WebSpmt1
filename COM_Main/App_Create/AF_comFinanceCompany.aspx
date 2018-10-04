<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_comFinanceCompany.aspx.vb" Inherits="AF_comFinanceCompany" title="Add: Finance Company" %>
<asp:Content ID="CPHcomFinanceCompany" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelcomFinanceCompany" runat="server" Text="&nbsp;Add: Finance Company"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLcomFinanceCompany" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLcomFinanceCompany"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "comFinanceCompany"
    runat = "server" />
<asp:FormView ID="FVcomFinanceCompany"
  runat = "server"
  DataKeyNames = "FinanceCompany"
  DataSourceID = "ODScomFinanceCompany"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgcomFinanceCompany" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_FinanceCompany" ForeColor="#CC6633" runat="server" Text="Finance Company :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_FinanceCompany"
            Text='<%# Bind("FinanceCompany") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="comFinanceCompany"
            onblur= "script_comFinanceCompany.validate_FinanceCompany(this);"
            ToolTip="Enter value for Finance Company."
            MaxLength="10"
            Width="88px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVFinanceCompany"
            runat = "server"
            ControlToValidate = "F_FinanceCompany"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "comFinanceCompany"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CompanyName" runat="server" Text="Company Name :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_CompanyName"
            Text='<%# Bind("CompanyName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="comFinanceCompany"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Company Name."
            MaxLength="100"
            Width="350px"
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
      <tr>
        <td class="alignright">
          <asp:Label ID="L_LogisticCompany" runat="server" Text="Logistic Company :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_LogisticCompany"
            Text='<%# Bind("LogisticCompany") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="comFinanceCompany"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Logistic Company."
            MaxLength="10"
            Width="88px"
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
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODScomFinanceCompany"
  DataObjectTypeName = "SIS.COM.comFinanceCompany"
  InsertMethod="comFinanceCompanyInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.COM.comFinanceCompany"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
