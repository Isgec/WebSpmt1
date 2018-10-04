<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtBPGSTIN.aspx.vb" Inherits="AF_spmtBPGSTIN" title="Add: BP GSTIN" %>
<asp:Content ID="CPHspmtBPGSTIN" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtBPGSTIN" runat="server" Text="&nbsp;Add: BP GSTIN"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBPGSTIN" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtBPGSTIN"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtBPGSTIN"
    runat = "server" />
<asp:FormView ID="FVspmtBPGSTIN"
  runat = "server"
  DataKeyNames = "BPID,GSTIN"
  DataSourceID = "ODSspmtBPGSTIN"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtBPGSTIN" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_BPID" ForeColor="#CC6633" runat="server" Text="BP ID :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "mypktxt"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for BP ID."
            ValidationGroup = "spmtBPGSTIN"
            onblur= "script_spmtBPGSTIN.validate_BPID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVBPID"
            runat = "server"
            ControlToValidate = "F_BPID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBPGSTIN"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner1_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEBPID"
            BehaviorID="B_ACEBPID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="BPIDCompletionList"
            TargetControlID="F_BPID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtBPGSTIN.ACEBPID_Selected"
            OnClientPopulating="script_spmtBPGSTIN.ACEBPID_Populating"
            OnClientPopulated="script_spmtBPGSTIN.ACEBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_GSTIN" ForeColor="#CC6633" runat="server" Text="GSTIN :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_GSTIN"
            Text='<%# Bind("GSTIN") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mypktxt"
            ValidationGroup="spmtBPGSTIN"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEGSTIN"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_GSTIN" />
          <AJX:MaskedEditValidator 
            ID = "MEVGSTIN"
            runat = "server"
            ControlToValidate = "F_GSTIN"
            ControlExtender = "MEEGSTIN"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBPGSTIN"
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
            ValidationGroup="spmtBPGSTIN"
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
            ValidationGroup = "spmtBPGSTIN"
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
  ID = "ODSspmtBPGSTIN"
  DataObjectTypeName = "SIS.SPMT.spmtBPGSTIN"
  InsertMethod="spmtBPGSTINInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtBPGSTIN"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
