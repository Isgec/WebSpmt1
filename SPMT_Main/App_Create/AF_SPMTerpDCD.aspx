<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_SPMTerpDCD.aspx.vb" Inherits="AF_SPMTerpDCD" title="Add: ERP DC Items" %>
<asp:Content ID="CPHSPMTerpDCD" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelSPMTerpDCD" runat="server" Text="&nbsp;Add: ERP DC Items"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLSPMTerpDCD" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLSPMTerpDCD"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/SPMT_Main/App_Edit/EF_SPMTerpDCD.aspx"
    ValidationGroup = "SPMTerpDCD"
    runat = "server" />
<asp:FormView ID="FVSPMTerpDCD"
  runat = "server"
  DataKeyNames = "ChallanID,SerialNo"
  DataSourceID = "ODSSPMTerpDCD"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgSPMTerpDCD" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
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
	          AssessableValue.value = (parseFloat(Quantity.value) * parseFloat(Price.value) ).toFixed(4);
	        if (parseFloat(CessRate.value)>0)
	          CessAmount.value = (parseFloat(CessRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
	        if (parseFloat(IGSTRate.value)>0)
	          IGSTAmount.value = (parseFloat(IGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
	        if (parseFloat(SGSTRate.value)>0)
	          SGSTAmount.value = (parseFloat(SGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
	        if (parseFloat(CGSTRate.value)>0)
	          CGSTAmount.value = (parseFloat(CGSTRate.value) * parseFloat(AssessableValue.value) * 0.01).toFixed(4);
	        TotalGST.value = (parseFloat(CessAmount.value) + parseFloat(IGSTAmount.value) + parseFloat(SGSTAmount.value) + parseFloat(CGSTAmount.value)).toFixed(4);
	        TotalAmount.value = ((parseFloat(Quantity.value) * parseFloat(Price.value)) + parseFloat(TotalGST.value)).toFixed(4);
	        if (LineTypeName.value == 'CompositInventory') {
	          FinalAmount.value = (parseFloat(TotalAmount.value) + parseFloat(BaseRate.value)).toFixed(4);
	        } else {
	          FinalAmount.value = (parseFloat(TotalAmount.value) + (parseFloat(BaseRate.value) * parseFloat(Quantity.value))).toFixed(4);
	        }


	        FinalAmount.value = (parseFloat(TotalAmount.value) + parseFloat(BaseRate.value)).toFixed(4);
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
          <b><asp:Label ID="L_ChallanID" ForeColor="#CC6633" runat="server" Text="Challan :" /></b>
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
          <b><asp:Label ID="L_SerialNo" ForeColor="#CC6633" runat="server" Text="Serial No :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_SerialNo" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
          <asp:TextBox ID="F_LineTypeName"
            Text='<%# Eval("LineTypeName") %>'
            Enabled = "False"
            CssClass = "mypktxt"
            Width="100px"
            style="display:none;"
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
      <tr style="display:none;">
        <td class="alignright">
          <asp:Label ID="L_BaseRate" runat="server" Text="Base Amount :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_BaseRate"
            Text='<%# Eval("BaseRate") %>'
            Width="168px"
            CssClass = "dmytxt"
            Enabled="false"
            style="text-align: Right"
            ValidationGroup="SPMTerpDCD"
            MaxLength="22"
            onfocus = "return this.select();"
      			onblur = "return validate_tots(this);"
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
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Price" runat="server" Text="Bill Amount [Basic] :" />&nbsp;
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
          <asp:Label ID="Label3" runat="server" Font-Italic="true" Font-Bold="true" Text="Total Amount = (Quantity * Bill Amount [Basic]) + Total GST" />
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
          <asp:Label ID="Label2" runat="server" Font-Italic="true" Font-Bold="true" Text="Final Amount = Total Amount" />
        </td>
      </tr>
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSSPMTerpDCD"
  DataObjectTypeName = "SIS.SPMT.SPMTerpDCD"
  InsertMethod="SPMTerpDCDInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.SPMTerpDCD"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
