<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_SPMTerpDCD.aspx.vb" Inherits="EF_SPMTerpDCD" title="Edit: ERP DC Items" %>
<asp:Content ID="CPHSPMTerpDCD" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCD" runat="server" Text="&nbsp;Edit: ERP DC Items"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCD" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCD"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnableDelete="false"
    ValidationGroup = "SPMTerpDCD"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCD"
  runat = "server"
  DataKeyNames = "ChallanID,SerialNo"
  DataSourceID = "ODSSPMTerpDCD"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <script type="text/javascript">
      function validate_tots(o) {
        o.value = o.value.replace(new RegExp('_', 'g'), '');
        dc(o, 4);
        var aVal = o.id.split('_F_');
        var Prefix = aVal[0] + '_F_';
        var LineTypeName = $get(Prefix + 'LineTypeName');
        var Quantity = $get(Prefix + 'Quantity');
        var Price = $get(Prefix + 'Price');
        var BaseRate = $get(Prefix + 'BaseRate');
        var FinalAmount = $get(Prefix + 'FinalAmount');
        var FinalRate = $get(Prefix + 'FinalRate');
        var AssessableValue = $get(Prefix + 'AssessableValue');
        var CessRate = $get(Prefix + 'CessRate');
        var CessAmount = $get(Prefix + 'CessAmount');
        var TotalGST = $get(Prefix + 'TotalGST');
        var TotalAmount = $get(Prefix + 'TotalAmount');
        var IGSTRate = $get(Prefix + 'IGSTRate');
        var IGSTAmount = $get(Prefix + 'IGSTAmount');
        var SGSTRate = $get(Prefix + 'SGSTRate');
        var SGSTAmount = $get(Prefix + 'SGSTAmount');
        var CGSTRate = $get(Prefix + 'CGSTRate');
        var CGSTAmount = $get(Prefix + 'CGSTAmount');
        try {
          if (o.id.indexOf('F_Quantity') >= 0) {
            if (parseFloat(Quantity.value) <= 0) {
              alert('Quantity is required.');
              Quantity.focus();
              return false;
            }
          }
          if (parseFloat(AssessableValue.value) <= 0)
            AssessableValue.value = (parseFloat(Quantity.value) * parseFloat(Price.value)).toFixed(4);
          if (parseFloat(CessRate.value) > 0)
            CessAmount.value = (parseFloat(CessRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
          if (parseFloat(IGSTRate.value) > 0)
            IGSTAmount.value = (parseFloat(IGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
          if (parseFloat(SGSTRate.value) > 0)
            SGSTAmount.value = (parseFloat(SGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
          if (parseFloat(CGSTRate.value) > 0)
            CGSTAmount.value = (parseFloat(CGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
          TotalGST.value = (parseFloat(CessAmount.value) + parseFloat(IGSTAmount.value) + parseFloat(SGSTAmount.value) + parseFloat(CGSTAmount.value)).toFixed(4);
          TotalAmount.value = ((parseFloat(Quantity.value) * parseFloat(Price.value)) + parseFloat(TotalGST.value)).toFixed(4);
          if (LineTypeName.value == 'CompositInventory') {
            FinalAmount.value = (parseFloat(TotalAmount.value) + parseFloat(BaseRate.value)).toFixed(4);
          } else {
            FinalAmount.value = (parseFloat(TotalAmount.value) + (parseFloat(BaseRate.value) * parseFloat(Quantity.value))).toFixed(4);
          }
          if (parseFloat(Quantity.value) > 0)
            FinalRate.value = (parseFloat(FinalAmount.value) / parseFloat(Quantity.value)).toFixed(4);
          else
            FinalRate.value = '0.0000';
        } catch (e) { }
      }
    </script>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ChallanID" runat="server" ForeColor="#CC6633" Text="ChallanID :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox
            ID = "F_ChallanID"
            Width="168px"
            Text='<%# Bind("ChallanID") %>'
            CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of ChallanID."
            Runat="Server" />
          <asp:Label
            ID = "F_ChallanID_Display"
            Text='<%# Eval("SPMT_erpDCH2_PlaceOfDelivery") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" runat="server" ForeColor="#CC6633" Text="SerialNo :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_SerialNo"
            Text='<%# Bind("SerialNo") %>'
            ToolTip="Value of SerialNo."
            Enabled = "False"
            CssClass = "mypktxt"
            Width="88px"
            style="text-align: right"
            runat="server" />
          <asp:TextBox ID="F_LineTypeName"
            Text='<%# Eval("LineTypeName") %>'
            Enabled = "False"
            CssClass = "mypktxt"
            Width="100px"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ItemDescription" runat="server" Text="Description of Goods :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ItemDescription"
            Text='<%# Bind("ItemDescription") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup = "SPMTerpDCD"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            MaxLength="250"
            Width="512px" 
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVItemDescription"
            runat = "server"
            ControlToValidate = "F_ItemDescription"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "SPMTerpDCD"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr id="rowBaseRate" runat="server">
        <td class="alignright">
          <asp:Label ID="L_BaseRate" runat="server" Text="Base Amount :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaseRate"
            Text='<%# Bind("BaseRate") %>'
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCD"
            MaxLength="22"
            Enabled="false"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_UOM" runat="server" Text="UOM :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <LGM:LC_spmtERPUnits
            ID="F_UOM"
            SelectedValue='<%# Bind("UOM") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "SPMTerpDCD"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillTypeID" runat="server" Text="Bill Type :" />&nbsp;
        </td>
        <td>
          <LGM:LC_spmtBillTypes
            ID="F_BillTypeID"
            SelectedValue='<%# Bind("BillTypeID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            Runat="Server" />
          </td>
        <td class="alignright">
          <asp:Label ID="L_HSNSACCode" runat="server" Text="HSN / SAC Code :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_HSNSACCode"
            CssClass = "myfktxt"
            Width="168px"
            Text='<%# Bind("HSNSACCode") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for HSN / SAC Code."
            onblur= "script_SPMTerpDCD.validate_HSNSACCode(this);"
            Runat="Server" />
          <asp:Label
            ID = "F_HSNSACCode_Display"
            Text='<%# Eval("SPMT_HSNSACCodes4_HSNSACCode") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEHSNSACCode"
            BehaviorID="B_ACEHSNSACCode"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="HSNSACCodeCompletionList"
            TargetControlID="F_HSNSACCode"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_SPMTerpDCD.ACEHSNSACCode_Selected"
            OnClientPopulating="script_SPMTerpDCD.ACEHSNSACCode_Populating"
            OnClientPopulated="script_SPMTerpDCD.ACEHSNSACCode_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup = "SPMTerpDCD"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Price" runat="server" Text="Value Add / Rate :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_Price"
            Text='<%# Bind("Price") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AssessableValue" runat="server" Text="Taxable Value :" />
        </td>
        <td>
          <asp:TextBox ID="F_AssessableValue"
            Text='<%# Bind("AssessableValue") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="spmtDCDetails"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
        <td colspan="2">
          <asp:Label ID="Label1" runat="server" Font-Italic="true" Font-Bold="true" Text="[Taxable Value of goods/Service (After discount or abatement)]" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IGSTRate" runat="server" Text="IGST Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IGSTRate"
            Text='<%# Bind("IGSTRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_IGSTAmount" runat="server" Text="IGST Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IGSTAmount"
            Text='<%# Bind("IGSTAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SGSTRate" runat="server" Text="SGST Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SGSTRate"
            Text='<%# Bind("SGSTRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SGSTAmount" runat="server" Text="SGST Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SGSTAmount"
            Text='<%# Bind("SGSTAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CGSTRate" runat="server" Text="CGST Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CGSTRate"
            Text='<%# Bind("CGSTRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CGSTAmount" runat="server" Text="CGST Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CGSTAmount"
            Text='<%# Bind("CGSTAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CessRate" runat="server" Text="Cess Rate :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CessRate"
            Text='<%# Bind("CessRate") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CessAmount" runat="server" Text="Cess Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CessAmount"
            Text='<%# Bind("CessAmount") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalGST" runat="server" Text="Total GST :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalGST"
            Text='<%# Bind("TotalGST") %>'
            Enabled = "False"
            ToolTip="Value of Total GST."
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td colspan="2">
          <asp:Label ID="Label4" runat="server" Font-Italic="true" Font-Bold="true" Text="Total GST = GST Rates calculated on Taxable Amount" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalAmount" runat="server" Text="Total Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalAmount"
            Text='<%# Bind("TotalAmount") %>'
            Enabled = "False"
            ToolTip="Value of Total Amount."
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td colspan="2">
          <asp:Label ID="L_TotalAmountFormula" runat="server" Font-Italic="true" Font-Bold="true" Text="Total Amount = (Quantity * Bill Amount [Basic]) + Total GST" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_FinalRate" runat="server" Text="Final Rate For DC :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_FinalRate"
            Text='<%# Bind("FinalRate") %>'
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td colspan="2">
          <asp:Label ID="Label5" runat="server" Font-Italic="true" Font-Bold="true" Text="Final Rate = Final Amount / Quantity" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_FinalAmount" runat="server" Text="Final Amount for DC :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_FinalAmount"
            Text='<%# Bind("FinalAmount") %>'
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td colspan="2">
          <asp:Label ID="L_FinalAmountFormula" runat="server" Font-Italic="true" Font-Bold="true" Text="Final Amount = Total Amount" />
        </td>
      </tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelSPMTerpDCDS" runat="server" Text="&nbsp;Delivery Challan Item Used Following Items from stock"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCDS" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLSPMTerpDCDS"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_SPMTerpDCDS.aspx"
      AddPostBack = "True"
      EnableAdd="false"
      EnableExit = "false"
      ValidationGroup = "SPMTerpDCDS"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSSPMTerpDCDS" runat="server" AssociatedUpdatePanelID="UPNLSPMTerpDCDS" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVSPMTerpDCDS" SkinID="gv_silver" runat="server" DataSourceID="ODSSPMTerpDCDS" DataKeyNames="ChallanID,SerialNo,SourceNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SourceNo" SortExpression="SourceNo">
          <ItemTemplate>
            <asp:Label ID="LabelSourceNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SourceNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ItemDescription" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits4_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits4_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="AssessableValue" SortExpression="AssessableValue">
          <ItemTemplate>
            <asp:Label ID="LabelAssessableValue" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AssessableValue") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TotalGST" SortExpression="TotalGST">
          <ItemTemplate>
            <asp:Label ID="LabelTotalGST" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalGST") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TotalAmount" SortExpression="TotalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="S_ChallanID" SortExpression="S_ChallanID">
          <ItemTemplate>
            <asp:Label ID="LabelS_ChallanID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("S_ChallanID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="S_SerialNo" SortExpression="S_SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelS_SerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("S_SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Delete">
          <ItemTemplate>
            <asp:ImageButton ID="cmdRejectWF" ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("RejectWFVisible") %>' Enabled='<%# EVal("RejectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Reject" SkinID="delete" OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Delete Used Inventory Item ?"");" %>' CommandName="RejectWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSSPMTerpDCDS"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.SPMTerpDCDS"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_SPMTerpDCDSSelectList"
      TypeName = "SIS.SPMT.SPMTerpDCDS"
      SelectCountMethod = "SPMTerpDCDSSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_ChallanID" PropertyName="Text" Name="ChallanID" Type="String" Size="20" />
        <asp:ControlParameter ControlID="F_SerialNo" PropertyName="Text" Name="SerialNo" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVSPMTerpDCDS" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
<fieldset class="ui-widget-content page" runat="server" visible='<%# Editable %>'>
<legend>
    <asp:Label ID="LabelSPMTerpDCIPending" runat="server" Text="&nbsp;Select Items from Suppplier's Stock"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCIPending" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLSPMTerpDCIPending"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_SPMTerpDCIPending.aspx"
      EnableAdd="false"
      EnableExit = "false"
      ValidationGroup = "SPMTerpDCIPending"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSSPMTerpDCIPending" runat="server" AssociatedUpdatePanelID="UPNLSPMTerpDCIPending" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVSPMTerpDCIPending" SkinID="gv_silver" runat="server" DataSourceID="ODSSPMTerpDCIPending" DataKeyNames="ChallanID,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="VIEW">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# Eval("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="info" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ChallanID" SortExpression="ChallanID">
          <ItemTemplate>
             <asp:Label ID="L_ChallanID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("ChallanID") %>' Text='<%# Eval("ChallanID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="60px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SerialNo" SortExpression="SerialNo">
          <ItemTemplate>
             <asp:Label ID="L_SerialNo" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("SerialNo") %>' Text='<%# Eval("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="60px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ItemDescription" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Base Rate" SortExpression="BaseRate">
          <ItemTemplate>
            <asp:Label ID="LabelBaseRate" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("BaseRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits5_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits5_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Price" SortExpression="Price">
          <ItemTemplate>
            <asp:Label ID="LabelPrice" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("Price") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FinalRate" SortExpression="FinalRate">
          <ItemTemplate>
            <asp:Label ID="LabelFinalRate" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("FinalRate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FinalAmount" SortExpression="FinalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelFinalAmount" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("FinalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ProjectID" SortExpression="IDM_Projects1_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Select">
          <ItemTemplate>
            <asp:ImageButton ID="cmdApproveWF" ValidationGroup='<%# "Approve" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ApproveWFVisible") %>' Enabled='<%# EVal("ApproveWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Approve" SkinID="complete" OnClientClick='<%# "return Page_ClientValidate(""Approve" & Container.DataItemIndex & """) && confirm(""Add in source Item list ?"");" %>' CommandName="ApproveWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSSPMTerpDCIPending"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.SPMTerpDCIPending"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_SPMTerpDCIPendingSelectList"
      TypeName = "SIS.SPMT.SPMTerpDCIPending"
      SelectCountMethod = "SPMTerpDCIPendingSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_ChallanID" PropertyName="Text" Name="ChallanID" Type="String" Size="20" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVSPMTerpDCIPending" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSSPMTerpDCD"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCD"
  SelectMethod = "SPMTerpDCDGetByID"
  UpdateMethod="UZ_SPMTerpDCDUpdate"
  DeleteMethod="SPMTerpDCDDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCD"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ChallanID" Name="ChallanID" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
