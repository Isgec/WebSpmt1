<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtBusinessPartner.aspx.vb" Inherits="EF_spmtBusinessPartner" title="Edit: Business Partner" %>
<asp:Content ID="CPHspmtBusinessPartner" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtBusinessPartner" runat="server" Text="&nbsp;Edit: Business Partner"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBusinessPartner" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtBusinessPartner"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "spmtBusinessPartner"
    runat = "server" />
<asp:FormView ID="FVspmtBusinessPartner"
  runat = "server"
  DataKeyNames = "BPID"
  DataSourceID = "ODSspmtBusinessPartner"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BPID" runat="server" ForeColor="#CC6633" Text="BP ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BPID"
            Text='<%# Bind("BPID") %>'
            ToolTip="Value of BP ID."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="80px"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPName" runat="server" Text="BP Name :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BPName"
            Text='<%# Bind("BPName") %>'
            Width="350px" Height="40px" TextMode="MultiLine"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtBusinessPartner"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for BP Name."
            MaxLength="100"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVBPName"
            runat = "server"
            ControlToValidate = "F_BPName"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBusinessPartner"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Address1Line" runat="server" Text="Address Line [1] :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Address1Line"
            Text='<%# Bind("Address1Line") %>'
            Width="350px" Height="40px" TextMode="MultiLine"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Address Line [1]."
            MaxLength="100"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Address2Line" runat="server" Text="Address Line [2] :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Address2Line"
            Text='<%# Bind("Address2Line") %>'
            Width="350px" Height="40px" TextMode="MultiLine"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Address Line [2]."
            MaxLength="100"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_City" runat="server" Text="City :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_City"
            Text='<%# Bind("City") %>'
            Width="408px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for City."
            MaxLength="50"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_EMailID" runat="server" Text="E-Mail ID :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_EMailID"
            Text='<%# Bind("EMailID") %>'
            Width="350px" Height="40px" TextMode="MultiLine"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for E-Mail ID."
            MaxLength="200"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtBPGSTIN" runat="server" Text="&nbsp;List: BP GSTIN"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBPGSTIN" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtBPGSTIN"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtBPGSTIN.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtBPGSTIN.aspx"
      AddPostBack = "True"
      EnableExit = "false"
      ValidationGroup = "spmtBPGSTIN"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtBPGSTIN" runat="server" AssociatedUpdatePanelID="UPNLspmtBPGSTIN" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtBPGSTIN" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtBPGSTIN" DataKeyNames="BPID,GSTIN">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BP ID" SortExpression="VR_BusinessPartner1_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner1_BPName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="GSTIN" SortExpression="GSTIN">
          <ItemTemplate>
            <asp:Label ID="LabelGSTIN" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("GSTIN") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtBPGSTIN"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtBPGSTIN"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtBPGSTINSelectList"
      TypeName = "SIS.SPMT.spmtBPGSTIN"
      SelectCountMethod = "spmtBPGSTINSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_BPID" PropertyName="Text" Name="BPID" Type="String" Size="9" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtBPGSTIN" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtBusinessPartner"
  DataObjectTypeName = "SIS.SPMT.spmtBusinessPartner"
  SelectMethod = "spmtBusinessPartnerGetByID"
  UpdateMethod="spmtBusinessPartnerUpdate"
  DeleteMethod="spmtBusinessPartnerDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtBusinessPartner"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="BPID" Name="BPID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
