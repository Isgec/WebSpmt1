<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_comGroupUsers.aspx.vb" Inherits="AF_comGroupUsers" title="Add: Group Users" %>
<asp:Content ID="CPHcomGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelcomGroupUsers" runat="server" Text="&nbsp;Add: Group Users"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLcomGroupUsers" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLcomGroupUsers"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "comGroupUsers"
    runat = "server" />
<asp:FormView ID="FVcomGroupUsers"
  runat = "server"
  DataKeyNames = "GroupID,LoginID"
  DataSourceID = "ODScomGroupUsers"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgcomGroupUsers" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GroupID" ForeColor="#CC6633" runat="server" Text="Group ID :" /><span style="color:red">*</span></b>
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
            ValidationGroup = "comGroupUsers"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            onblur= "script_comGroupUsers.validate_GroupID(this);"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_LoginID" ForeColor="#CC6633" runat="server" Text="Login ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_LoginID"
            CssClass = "mypktxt"
            Width="72px"
            Text='<%# Bind("LoginID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Login ID."
            ValidationGroup = "comGroupUsers"
            onblur= "script_comGroupUsers.validate_LoginID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVLoginID"
            runat = "server"
            ControlToValidate = "F_LoginID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "comGroupUsers"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_LoginID_Display"
            Text='<%# Eval("aspnet_Users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACELoginID"
            BehaviorID="B_ACELoginID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="LoginIDCompletionList"
            TargetControlID="F_LoginID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_comGroupUsers.ACELoginID_Selected"
            OnClientPopulating="script_comGroupUsers.ACELoginID_Populating"
            OnClientPopulated="script_comGroupUsers.ACELoginID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
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
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODScomGroupUsers"
  DataObjectTypeName = "SIS.COM.comGroupUsers"
  InsertMethod="comGroupUsersInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.COM.comGroupUsers"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
