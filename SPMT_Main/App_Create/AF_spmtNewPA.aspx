<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtNewPA.aspx.vb" Inherits="AF_spmtNewPA" title="Add: *Payment Advice" %>
<asp:Content ID="CPHspmtNewPA" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtNewPA" runat="server" Text="&nbsp;Add: *Payment Advice"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtNewPA" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtNewPA"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/SPMT_Main/App_Edit/EF_spmtNewPA.aspx"
    ValidationGroup = "spmtNewPA"
    runat = "server" />
<asp:FormView ID="FVspmtNewPA"
  runat = "server"
  DataKeyNames = "AdviceNo"
  DataSourceID = "ODSspmtNewPA"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtNewPA" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AdviceNo" ForeColor="#CC6633" runat="server" Text="Advice No :" /><span style="color:red">*</span></b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_AdviceNo" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <LGM:LC_spmtTranTypes
            ID="F_TranTypeID"
            SelectedValue='<%# Bind("TranTypeID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "spmtNewPA"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="BP ID :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            CssClass = "myfktxt"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for BP ID."
            onblur= "script_spmtNewPA.validate_BPID(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner8_BPName") %>'
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
            OnClientItemSelected="script_spmtNewPA.ACEBPID_Selected"
            OnClientPopulating="script_spmtNewPA.ACEBPID_Populating"
            OnClientPopulated="script_spmtNewPA.ACEBPID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SupplierName" runat="server" Text="Supplier Name :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_SupplierName"
            Text='<%# Bind("SupplierName") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Supplier Name."
            MaxLength="100"
            Width="350px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConcernedHOD" runat="server" Text="Concerned HOD :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ConcernedHOD"
            CssClass = "myfktxt"
            Width="72px"
            Text='<%# Bind("ConcernedHOD") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for Concerned HOD."
            onblur= "script_spmtNewPA.validate_ConcernedHOD(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_ConcernedHOD_Display"
            Text='<%# Eval("HRM_Employees5_EmployeeName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEConcernedHOD"
            BehaviorID="B_ACEConcernedHOD"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ConcernedHODCompletionList"
            TargetControlID="F_ConcernedHOD"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtNewPA.ACEConcernedHOD_Selected"
            OnClientPopulating="script_spmtNewPA.ACEConcernedHOD_Populating"
            OnClientPopulated="script_spmtNewPA.ACEConcernedHOD_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Remarks" runat="server" Text="Remarks :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Remarks"
            Text='<%# Bind("Remarks") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="spmtNewPA"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Remarks."
            MaxLength="500"
            Width="350px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdvanceRate" runat="server" Text="Advance Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AdvanceRate"
            Text='<%# Bind("AdvanceRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="13"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAdvanceRate"
            runat = "server"
            mask = "9999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AdvanceRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVAdvanceRate"
            runat = "server"
            ControlToValidate = "F_AdvanceRate"
            ControlExtender = "MEEAdvanceRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AdvanceAmount" runat="server" Text="Advance Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AdvanceAmount"
            Text='<%# Bind("AdvanceAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="13"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAdvanceAmount"
            runat = "server"
            mask = "9999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AdvanceAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVAdvanceAmount"
            runat = "server"
            ControlToValidate = "F_AdvanceAmount"
            ControlExtender = "MEEAdvanceAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_RetensionRate" runat="server" Text="Retension Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RetensionRate"
            Text='<%# Bind("RetensionRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="13"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEERetensionRate"
            runat = "server"
            mask = "9999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_RetensionRate" />
          <AJX:MaskedEditValidator 
            ID = "MEVRetensionRate"
            runat = "server"
            ControlToValidate = "F_RetensionRate"
            ControlExtender = "MEERetensionRate"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_RetensionAmount" runat="server" Text="Retension Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RetensionAmount"
            Text='<%# Bind("RetensionAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="13"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEERetensionAmount"
            runat = "server"
            mask = "9999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_RetensionAmount" />
          <AJX:MaskedEditValidator 
            ID = "MEVRetensionAmount"
            runat = "server"
            ControlToValidate = "F_RetensionAmount"
            ControlExtender = "MEERetensionAmount"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
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
  ID = "ODSspmtNewPA"
  DataObjectTypeName = "SIS.SPMT.spmtNewPA"
  InsertMethod="UZ_spmtNewPAInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtNewPA"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
