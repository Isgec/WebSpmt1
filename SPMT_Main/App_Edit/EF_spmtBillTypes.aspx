<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtBillTypes.aspx.vb" Inherits="EF_spmtBillTypes" title="Edit: Bill Types" %>
<asp:Content ID="CPHspmtBillTypes" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtBillTypes" runat="server" Text="&nbsp;Edit: Bill Types"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBillTypes" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtBillTypes"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtBillTypes"
    runat = "server" />
<asp:FormView ID="FVspmtBillTypes"
  runat = "server"
  DataKeyNames = "BillType"
  DataSourceID = "ODSspmtBillTypes"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BillType" runat="server" ForeColor="#CC6633" Text="Bill Type :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BillType"
            Text='<%# Bind("BillType") %>'
            ToolTip="Value of Bill Type."
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
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtBillTypes"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
            MaxLength="50"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVDescription"
            runat = "server"
            ControlToValidate = "F_Description"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBillTypes"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtHSNSACCodes" runat="server" Text="&nbsp;List: HSN / SAC Code"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtHSNSACCodes" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtHSNSACCodes"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtHSNSACCodes.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtHSNSACCodes.aspx"
      AddPostBack = "True"
      EnableExit = "false"
      ValidationGroup = "spmtHSNSACCodes"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtHSNSACCodes" runat="server" AssociatedUpdatePanelID="UPNLspmtHSNSACCodes" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtHSNSACCodes" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtHSNSACCodes" DataKeyNames="BillType,HSNSACCode">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Type" SortExpression="SPMT_BillTypes1_Description">
          <ItemTemplate>
             <asp:Label ID="L_BillType" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BillType") %>' Text='<%# Eval("SPMT_BillTypes1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="HSN / SAC Code" SortExpression="HSNSACCode">
          <ItemTemplate>
            <asp:Label ID="LabelHSNSACCode" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("HSNSACCode") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tax Rate" SortExpression="TaxRate">
          <ItemTemplate>
            <asp:Label ID="LabelTaxRate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TaxRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtHSNSACCodes"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtHSNSACCodes"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtHSNSACCodesSelectList"
      TypeName = "SIS.SPMT.spmtHSNSACCodes"
      SelectCountMethod = "spmtHSNSACCodesSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_BillType" PropertyName="Text" Name="BillType" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtHSNSACCodes" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtBillTypes"
  DataObjectTypeName = "SIS.SPMT.spmtBillTypes"
  SelectMethod = "spmtBillTypesGetByID"
  UpdateMethod="spmtBillTypesUpdate"
  DeleteMethod="spmtBillTypesDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtBillTypes"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="BillType" Name="BillType" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
