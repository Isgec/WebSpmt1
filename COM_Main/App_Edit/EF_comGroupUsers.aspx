<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_comGroupUsers.aspx.vb" Inherits="EF_comGroupUsers" title="Edit: Group Users" %>
<asp:Content ID="CPHcomGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelcomGroupUsers" runat="server" Text="&nbsp;Edit: Group Users"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLcomGroupUsers" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLcomGroupUsers"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "comGroupUsers"
    runat = "server" />
<asp:FormView ID="FVcomGroupUsers"
  runat = "server"
  DataKeyNames = "GroupID,LoginID"
  DataSourceID = "ODScomGroupUsers"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GroupID" runat="server" ForeColor="#CC6633" Text="Group ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_GroupID"
            Width="56px"
            Text='<%# Bind("GroupID") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Group ID."
            Runat="Server" />
          <asp:Label
            ID = "F_GroupID_Display"
            Text='<%# Eval("SYS_Groups2_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_LoginID" runat="server" ForeColor="#CC6633" Text="Login ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_LoginID"
            Width="72px"
            Text='<%# Bind("LoginID") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Login ID."
            Runat="Server" />
          <asp:Label
            ID = "F_LoginID_Display"
            Text='<%# Eval("aspnet_Users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Active" runat="server" Text="Active :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:CheckBox ID="F_Active"
            Checked='<%# Bind("Active") %>'
            CssClass = "mychk"
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
  ID = "ODScomGroupUsers"
  DataObjectTypeName = "SIS.COM.comGroupUsers"
  SelectMethod = "comGroupUsersGetByID"
  UpdateMethod="comGroupUsersUpdate"
  DeleteMethod="comGroupUsersDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.COM.comGroupUsers"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GroupID" Name="GroupID" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="LoginID" Name="LoginID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
