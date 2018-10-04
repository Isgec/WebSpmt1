<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtTranTypes.aspx.vb" Inherits="AF_spmtTranTypes" title="Add: Tran. Types" %>
<asp:Content ID="CPHspmtTranTypes" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtTranTypes" runat="server" Text="&nbsp;Add: Tran. Types"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtTranTypes" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtTranTypes"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtTranTypes"
    runat = "server" />
<asp:FormView ID="FVspmtTranTypes"
  runat = "server"
  DataKeyNames = "TranTypeID"
  DataSourceID = "ODSspmtTranTypes"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtTranTypes" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_TranTypeID" ForeColor="#CC6633" runat="server" Text="Tran. Type :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_TranTypeID"
            Text='<%# Bind("TranTypeID") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtTranTypes"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Tran. Type."
            MaxLength="3"
            Width="32px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVTranTypeID"
            runat = "server"
            ControlToValidate = "F_TranTypeID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtTranTypes"
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
            ValidationGroup="spmtTranTypes"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="30"
            Width="248px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescription"
            runat = "server"
            ControlToValidate = "F_Description"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtTranTypes"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_GroupID" runat="server" Text="Group  :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <LGM:LC_comGroups
            ID="F_GroupID"
            SelectedValue='<%# Bind("GroupID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtTranTypes"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
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
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtTranTypes"
  DataObjectTypeName = "SIS.SPMT.spmtTranTypes"
  InsertMethod="spmtTranTypesInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtTranTypes"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
