<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtDCHeader.aspx.vb" Inherits="GF_spmtDCHeader" title="Maintain List: Delivery Challan" %>
<asp:Content ID="CPHspmtDCHeader" ContentPlaceHolderID="cph1" Runat="Server">
<div style="height:500px" class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtDCHeader" runat="server" Text="&nbsp;List: Delivery Challan"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtDCHeader" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtDCHeader"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtDCHeader.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtDCHeader.aspx?skip=1"
      ValidationGroup = "spmtDCHeader"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtDCHeader" runat="server" AssociatedUpdatePanelID="UPNLspmtDCHeader" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
    <script type="text/javascript"> 
   var script_LinkedChallanID = {
    ACELinkedChallanID_Selected: function(sender, e) {
      var F_LinkedChallanID = $get(sender._element.id);
      var F_LinkedChallanID_Display = $get(sender._element.id.replace('LinkedChallanID', 'LinkedChallanID_Display'));
      var retval = e.get_value();
      var p = retval.split('|');
      F_LinkedChallanID.value = p[0];
      F_LinkedChallanID_Display.innerHTML = e.get_text();
    },
    ACELinkedChallanID_Populating: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACELinkedChallanID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_LinkedChallanID: function(sender) {
      var Prefix = sender.id;
      this.validated_FK_SPMT_DCHeader_LinkedChallanID_main = true;
      this.validate_FK_SPMT_DCHeader_LinkedChallanID(sender,Prefix);
      },
    validate_FK_SPMT_DCHeader_LinkedChallanID: function(o,Prefix) {
      var value = o.id;
      var LinkedChallanID = $get(o.id);
      if(LinkedChallanID.value==''){
        if(this.validated_FK_SPMT_DCHeader_LinkedChallanID_main){
          var o_d = $get(o.id.replace('LinkedChallanID', 'LinkedChallanID_Display'));
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + LinkedChallanID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_LinkedChallanID(value, this.validated_FK_SPMT_DCHeader_LinkedChallanID);
      },
    validated_FK_SPMT_DCHeader_LinkedChallanID_main: false,
    validated_FK_SPMT_DCHeader_LinkedChallanID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_LinkedChallanID.validated_FK_SPMT_DCHeader_LinkedChallanID_main){
        var o_d = $get(p[1].replace('LinkedChallanID', 'LinkedChallanID_Display'));
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
    </script>
    <script type="text/javascript"> 
   var script_DestinationBPID = {
    ACEDestinationBPID_Selected: function(sender, e) {
      var F_DestinationBPID = $get(sender._element.id);
      var F_DestinationBPID_Display = $get(sender._element.id.replace('DestinationBPID', 'DestinationBPID_Display'));
      var retval = e.get_value();
      var p = retval.split('|');
      F_DestinationBPID.value = p[0];
      F_DestinationBPID_Display.innerHTML = e.get_text();
    },
    ACEDestinationBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEDestinationBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_DestinationBPID: function(sender) {
      var Prefix = sender.id.replace('DestinationBPID','');
      this.validated_FK_SPMT_DCHeader_DestinationBPID_main = true;
      this.validate_FK_SPMT_DCHeader_DestinationBPID(sender,Prefix);
      },
    validate_FK_SPMT_DCHeader_DestinationBPID: function(o,Prefix) {
      var value = o.id;
      var DestinationBPID = $get(o.id);
      if(DestinationBPID.value==''){
        if(this.validated_FK_SPMT_DCHeader_DestinationBPID_main){
          var o_d = $get(o.id.replace('DestinationBPID', 'DestinationBPID_Display'));
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + DestinationBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_DestinationBPID(value, this.validated_FK_SPMT_DCHeader_DestinationBPID);
      },
    validated_FK_SPMT_DCHeader_DestinationBPID_main: false,
    validated_FK_SPMT_DCHeader_DestinationBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_DestinationBPID.validated_FK_SPMT_DCHeader_DestinationBPID_main){
        var o_d = $get(p[1].replace('DestinationBPID', 'DestinationBPID_Display'));
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
    </script>

    <script type="text/javascript"> 
   var script_DestinationGSTIN = {
    ACEDestinationGSTIN_Selected: function(sender, e) {
      var F_DestinationGSTIN = $get(sender._element.id);
      var F_DestinationGSTIN_Display = $get(sender._element.id.replace('DestinationGSTIN', 'DestinationGSTIN_Display'));
      var retval = e.get_value();
      var p = retval.split('|');
      F_DestinationGSTIN.value = p[1];
      F_DestinationGSTIN_Display.innerHTML = e.get_text();
    },
    ACEDestinationGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_DestinationBPID = $get(sender._element.id.replace('DestinationGSTIN', 'DestinationBPID'));
      sender._contextKey = F_DestinationBPID.value;
    },
    ACEDestinationGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_DestinationGSTIN: function(sender) {
      var Prefix = sender.id.replace('DestinationGSTIN','');
      this.validated_FK_SPMT_DCHeader_DestinationGSTIN_main = true;
      this.validate_FK_SPMT_DCHeader_DestinationGSTIN(sender,Prefix);
      },
    validate_FK_SPMT_DCHeader_DestinationGSTIN: function(o,Prefix) {
      var value = o.id;
      var DestinationBPID = $get(o.id.replace('DestinationGSTIN', 'DestinationBPID'));
      if(DestinationBPID.value==''){
        if(this.validated_FK_SPMT_DCHeader_DestinationGSTIN_main){
          var o_d = $get(o.id.replace('DestinationGSTIN', 'DestinationGSTIN_Display'));
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + DestinationBPID.value ;
      var DestinationGSTIN = $get(o.id);
      if(DestinationGSTIN.value==''){
        if(this.validated_FK_SPMT_DCHeader_DestinationGSTIN_main){
          var o_d = $get(o.id.replace('DestinationGSTIN', 'DestinationGSTIN_Display'));
          try { o_d.innerHTML = ''; } catch (ex) { }
        }
        return true;
      }
      value = value + ',' + DestinationGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_DestinationGSTIN(value, this.validated_FK_SPMT_DCHeader_DestinationGSTIN);
      },
    validated_FK_SPMT_DCHeader_DestinationGSTIN_main: false,
    validated_FK_SPMT_DCHeader_DestinationGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_DestinationGSTIN.validated_FK_SPMT_DCHeader_DestinationGSTIN_main){
        var o_d = $get(p[1].replace('DestinationGSTIN', 'DestinationGSTIN_Display'));
        try { o_d.innerHTML = p[2]; } catch (ex) { }
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
    </script>
    <asp:GridView ID="GVspmtDCHeader" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtDCHeader" DataKeyNames="ChallanID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PRINT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_report(this);" />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Challan ID" SortExpression="ChallanID">
          <ItemTemplate>
            <asp:Label ID="LabelChallanID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ChallanID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Challan Date" SortExpression="ChallanDate">
          <ItemTemplate>
            <asp:Label ID="LabelChallanDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ChallanDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Issuer" SortExpression="SPMT_IsgecGSTIN11_Description">
          <ItemTemplate>
             <asp:Label ID="L_IssuerID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("IssuerID") %>' Text='<%# Eval("SPMT_IsgecGSTIN11_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Unit" SortExpression="HRM_Companies2_Description">
          <ItemTemplate>
             <asp:Label ID="L_UnitID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UnitID") %>' Text='<%# Eval("HRM_Companies2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Place Of Supply" SortExpression="SPMT_ERPStates5_Description">
          <ItemTemplate>
             <asp:Label ID="L_PlaceOfSupply" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("PlaceOfSupply") %>' Text='<%# Eval("SPMT_ERPStates5_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Place Of Delivery" SortExpression="SPMT_ERPStates6_Description">
          <ItemTemplate>
             <asp:Label ID="L_PlaceOfDelivery" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("PlaceOfDelivery") %>' Text='<%# Eval("SPMT_ERPStates6_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount" SortExpression="TotalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Prepared By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_CreatedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CreatedBy") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status" SortExpression="SPMT_DCStates4_Description">
          <ItemTemplate>
             <asp:Label ID="L_StatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("StatusID") %>' Text='<%# Eval("SPMT_DCStates4_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Issued">
          <ItemTemplate>
            <asp:ImageButton ID="cmdCompleteWF" ValidationGroup='<%# "Complete" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("CompleteWFVisible") %>' Enabled='<%# EVal("CompleteWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Complete" SkinID="complete" OnClientClick='<%# "return Page_ClientValidate(""Complete" & Container.DataItemIndex & """) && confirm(""Delivery Challan Issued ?"");" %>' CommandName="CompleteWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Receipt">
          <ItemTemplate>
            <asp:Panel runat="server" ID="tmpPnl" Visible='<%# Eval("ReceiptPanelVisible") %>' style="width:250px;background-color:antiquewhite;border:solid 1pt pink" >
              <table>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_ReceivedDate" runat="server" Text="Received On :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_ReceivedDate"
                      Width="80px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      runat="server" />
                    <asp:Image ID="ImageButtonReceivedDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
                    <AJX:CalendarExtender 
                      ID = "CEReceivedDate"
                      TargetControlID="F_ReceivedDate"
                      Format="dd/MM/yyyy"
                      runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonReceivedDate" />
                    <AJX:MaskedEditExtender 
                      ID = "MEEReceivedDate"
                      runat = "server"
                      mask = "99/99/9999"
                      MaskType="Date"
                      CultureName = "en-GB"
                      MessageValidatorTip="true"
                      InputDirection="LeftToRight"
                      ErrorTooltipEnabled="true"
                      TargetControlID="F_ReceivedDate" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_ReceivedState" runat="server" Text="Status :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:DropDownList 
                      ID="F_Status"
                      Width="110px" 
                      CssClass = "mytxt"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      runat="server">
                      <asp:ListItem Value="3" Text="Received"></asp:ListItem>
                      <asp:ListItem Value="4" Text="Not Delivered"></asp:ListItem>
                      <asp:ListItem Value="5" Text="Cancelled"></asp:ListItem>
                    </asp:DropDownList>
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_ReceiptRemarks" runat="server" Text="Remarks :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_ReceivedRemarks"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter Received Remarks."
                      MaxLength="500"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignCenter">
                    <asp:ImageButton ID="rcmdCancel" ValidationGroup='<%# "Cancel" & Container.DataItemIndex %>' CausesValidation="true" runat="server" AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Cancel" SkinID="Cancel" OnClientClick='<%# "return Page_ClientValidate(""Cancel" & Container.DataItemIndex & """) && confirm(""Cancel record ?"");" %>' CommandName="CancelReceipt" CommandArgument='<%# Container.DataItemIndex %>' />
                  </td>
                  <td class="alignCenter">
                    <asp:ImageButton ID="rcmdSave" ValidationGroup='<%# "Save" & Container.DataItemIndex %>' CausesValidation="true" runat="server" AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Save" SkinID="Save" OnClientClick='<%# "return Page_ClientValidate(""Save" & Container.DataItemIndex & """) && confirm(""Update record ?"");" %>' CommandName="SaveReceipt" CommandArgument='<%# Container.DataItemIndex %>'  />
                  </td>
                </tr>
              </table>
            </asp:Panel>
            <asp:ImageButton ID="cmdReceipt" ValidationGroup='<%# "Receipt" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ReceiptWFVisible") %>' Enabled='<%# EVal("ReceiptWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Receipt" SkinID="approve" OnClientClick='<%# "return Page_ClientValidate(""Receipt" & Container.DataItemIndex & """) && confirm(""Receipt record ?"");" %>' CommandName="ReceiptWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Closure">
          <ItemTemplate>
            <asp:Panel class="ui-widget-content page" runat="server" ID="tmpCPnl" Visible='<%# Eval("ClosurePanelVisible") %>' style="position:absolute;z-index:92000;left:600px;top:4px;  width:350px;background-color:antiquewhite;border:solid 1pt pink" >
              <div class="caption">
                  <asp:Label ID="LabelspmtDCHeader" runat="server" Text="&nbsp;Closure Entry"></asp:Label>
              </div>
              <table style="width:100%">
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="L_LinkedChallanID" runat="server" Text="Linked Challan :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox
                    ID = "F_LinkedChallanID"
                    CssClass = "myfktxt"
                    AutoCompleteType = "None"
                    Width="168px"
                    onfocus = "return this.select();"
                    ToolTip="Enter value for Linked Challan."
                    ValidationGroup = '<%# "spmtDCHeader" & Container.DataItemIndex %>'
                    onblur= "script_LinkedChallanID.validate_LinkedChallanID(this);"
                    Runat="Server" />
                  <asp:Label
                    ID = "F_LinkedChallanID_Display"
                    Text='<%# Eval("SPMT_DCHeader20_Purpose") %>'
                    CssClass="myLbl"
                    Runat="Server" />
                  <AJX:AutoCompleteExtender
                    ID="ACELinkedChallanID"
                    BehaviorID="B_ACELinkedChallanID"
                    ContextKey=""
                    UseContextKey="true"
                    ServiceMethod="LinkedChallanIDCompletionList"
                    TargetControlID="F_LinkedChallanID"
                    EnableCaching="false"
                    CompletionInterval="100"
                    FirstRowSelected="true"
                    MinimumPrefixLength="1"
                    OnClientItemSelected="script_LinkedChallanID.ACELinkedChallanID_Selected"
                    OnClientPopulating="script_LinkedChallanID.ACELinkedChallanID_Populating"
                    OnClientPopulated="script_LinkedChallanID.ACELinkedChallanID_Populated"
                    CompletionSetCount="10"
                    CompletionListCssClass = "autocomplete_completionListElement"
                    CompletionListItemCssClass = "autocomplete_listItem"
                    CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
                    Runat="Server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label1" runat="server" Text="Isgec GSTIN :" />&nbsp;</b>
                  </td>
                  <td>
                  <LGM:LC_spmtIsgecGSTIN
                    ID="F_DestinationIsgecID"
                    OrderBy="DisplayField"
                    DataTextField="DisplayField"
                    DataValueField="PrimaryKey"
                    IncludeDefault="true"
                    DefaultText="-- Select --"
                    Width="200px"
                    CssClass="myddl"
                    ValidationGroup = '<%# "spmtDCHeader" & Container.DataItemIndex %>'
                    Runat="Server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label2" runat="server" Text="BP ID :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox
                      ID = "F_DestinationBPID"
                      CssClass = "myfktxt"
                      AutoCompleteType = "None"
                      Width="80px"
                      onfocus = "return this.select();"
                      ToolTip="Enter value for Destination BPID."
                      ValidationGroup = '<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "script_DestinationBPID.validate_DestinationBPID(this);"
                      Runat="Server" />
                    <asp:Label
                      ID = "F_DestinationBPID_Display"
                      Text='<%# Eval("VR_BusinessPartner24_BPName") %>'
                      CssClass="myLbl"
                      Runat="Server" />
                    <AJX:AutoCompleteExtender
                      ID="ACEDestinationBPID"
                      BehaviorID="B_ACEDestinationBPID"
                      ContextKey=""
                      UseContextKey="true"
                      ServiceMethod="DestinationBPIDCompletionList"
                      TargetControlID="F_DestinationBPID"
                      EnableCaching="false"
                      CompletionInterval="100"
                      FirstRowSelected="true"
                      MinimumPrefixLength="1"
                      OnClientItemSelected="script_DestinationBPID.ACEDestinationBPID_Selected"
                      OnClientPopulating="script_DestinationBPID.ACEDestinationBPID_Populating"
                      OnClientPopulated="script_DestinationBPID.ACEDestinationBPID_Populated"
                      CompletionSetCount="10"
                      CompletionListCssClass = "autocomplete_completionListElement"
                      CompletionListItemCssClass = "autocomplete_listItem"
                      CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
                      Runat="Server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label3" runat="server" Text="BP GSTIN :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox
                      ID = "F_DestinationGSTIN"
                      CssClass = "myfktxt"
                      AutoCompleteType = "None"
                      Width="88px"
                      onfocus = "return this.select();"
                      ToolTip="Enter value for Destination GSTIN."
                      ValidationGroup = '<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "script_DestinationGSTIN.validate_DestinationGSTIN(this);"
                      Runat="Server" />
                    <asp:Label
                      ID = "F_DestinationGSTIN_Display"
                      Text='<%# Eval("VR_BPGSTIN23_Description") %>'
                      CssClass="myLbl"
                      Runat="Server" />
                    <AJX:AutoCompleteExtender
                      ID="ACEDestinationGSTIN"
                      BehaviorID="B_ACEDestinationGSTIN"
                      ContextKey=""
                      UseContextKey="true"
                      ServiceMethod="DestinationGSTINCompletionList"
                      TargetControlID="F_DestinationGSTIN"
                      EnableCaching="false"
                      CompletionInterval="100"
                      FirstRowSelected="true"
                      MinimumPrefixLength="1"
                      OnClientItemSelected="script_DestinationGSTIN.ACEDestinationGSTIN_Selected"
                      OnClientPopulating="script_DestinationGSTIN.ACEDestinationGSTIN_Populating"
                      OnClientPopulated="script_DestinationGSTIN.ACEDestinationGSTIN_Populated"
                      CompletionSetCount="10"
                      CompletionListCssClass = "autocomplete_completionListElement"
                      CompletionListItemCssClass = "autocomplete_listItem"
                      CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
                      Runat="Server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label4" runat="server" Text="BP Name :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_DestinationName"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter Destination Name."
                      MaxLength="50"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label5" runat="server" Text="BP GST No. :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_DestinationGSTINNo"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter value for Destination GSTIN No."
                      MaxLength="50"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label6" runat="server" Text="Address Line [1] :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_DestinationAddress1Line"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter value for Destination Address Line [1]."
                      MaxLength="100"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label7" runat="server" Text="Address Line [2] :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_DestinationAddress2Line"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter value for Destination Address Line [2]."
                      MaxLength="100"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label8" runat="server" Text="Address Line [3] :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_DestinationAddress3Line"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter value for Destination Address Line [3]."
                      MaxLength="100"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label9" runat="server" Text="State :" />&nbsp;</b>
                  </td>
                  <td>
                    <LGM:LC_spmtERPStates
                      ID="F_DestinationStateID"
                      OrderBy="DisplayField"
                      DataTextField="DisplayField"
                      DataValueField="PrimaryKey"
                      IncludeDefault="true"
                      DefaultText="-- Select --"
                      Width="150px"
                      CssClass="myddl"
                      ValidationGroup = '<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      Runat="Server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label10" runat="server" Text="Closed On :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_ClosureDate"
                      Width="80px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      runat="server" />
                    <asp:Image ID="ImageButtonClosureDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
                    <AJX:CalendarExtender 
                      ID = "CEClosureDate"
                      TargetControlID="F_ClosureDate"
                      Format="dd/MM/yyyy"
                      runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonClosureDate" />
                    <AJX:MaskedEditExtender 
                      ID = "MEEClosureDate"
                      runat = "server"
                      mask = "99/99/9999"
                      MaskType="Date"
                      CultureName = "en-GB"
                      MessageValidatorTip="true"
                      InputDirection="LeftToRight"
                      ErrorTooltipEnabled="true"
                      TargetControlID="F_ClosureDate" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label11" runat="server" Text="Closing Status :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:DropDownList 
                      ID="F_CStatus"
                      Width="150px" 
                      CssClass = "mytxt"
                      ValidationGroup='<%# "Save" & Container.DataItemIndex %>'
                      runat="server">
                      <asp:ListItem Value="6" Text="Returned Back to Consigner"></asp:ListItem>
                      <asp:ListItem Value="7" Text="Returned Back to Isgec"></asp:ListItem>
                      <asp:ListItem Value="8" Text="Sent to Customer Site"></asp:ListItem>
                      <asp:ListItem Value="9" Text="Sent to another Vendor"></asp:ListItem>
                    </asp:DropDownList>
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label14" runat="server" Text="Isgec Invoice No. :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_IsgecInvoiceNo"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter Isgec Invoice No."
                      MaxLength="9"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label13" runat="server" Text="Invoice Date :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_IsgecInvoiceDate"
                      Width="80px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      runat="server" />
                    <asp:Image ID="ImageButtonIsgecInvoiceDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
                    <AJX:CalendarExtender 
                      ID = "CEIsgecInvoiceDate"
                      TargetControlID="F_IsgecInvoiceDate"
                      Format="dd/MM/yyyy"
                      runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonIsgecInvoiceDate" />
                    <AJX:MaskedEditExtender 
                      ID = "MEEIsgecInvoiceDate"
                      runat = "server"
                      mask = "99/99/9999"
                      MaskType="Date"
                      CultureName = "en-GB"
                      MessageValidatorTip="true"
                      InputDirection="LeftToRight"
                      ErrorTooltipEnabled="true"
                      TargetControlID="F_IsgecInvoiceDate" />
                  </td>
                </tr>
                <tr>
                  <td class="alignright">
                    <b><asp:Label ID="Label12" runat="server" Text="Closing Remarks :" />&nbsp;</b>
                  </td>
                  <td>
                    <asp:TextBox ID="F_ClosureRemarks"
                      Width="150px"
                      CssClass = "mytxt"
                      onfocus = "return this.select();"
                      ValidationGroup='<%# "spmtDCHeader" & Container.DataItemIndex %>'
                      onblur= "this.value=this.value.replace(/\'/g,'');"
                      ToolTip="Enter value for Closure Remarks."
                      MaxLength="500"
                      runat="server" />
                  </td>
                </tr>
                <tr>
                  <td class="alignCenter">
                    <asp:ImageButton ID="ccmdCancel" ValidationGroup='<%# "Cancel" & Container.DataItemIndex %>' CausesValidation="true" runat="server" AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Cancel" SkinID="Cancel" OnClientClick='<%# "return Page_ClientValidate(""Cancel" & Container.DataItemIndex & """) && confirm(""Cancel record ?"");" %>' CommandName="CancelClosure" CommandArgument='<%# Container.DataItemIndex %>' />
                  </td>
                  <td class="alignCenter">
                    <asp:ImageButton ID="ccmdSave" ValidationGroup='<%# "Save" & Container.DataItemIndex %>' CausesValidation="true" runat="server" AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Save" SkinID="Save" OnClientClick='<%# "return Page_ClientValidate(""Save" & Container.DataItemIndex & """) && confirm(""Update record ?"");" %>' CommandName="SaveClosure" CommandArgument='<%# Container.DataItemIndex %>'  />
                  </td>
                </tr>
              </table>
            </asp:Panel>
            <asp:ImageButton ID="cmdClosure" ValidationGroup='<%# "Closure" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("ClosureWFVisible") %>' Enabled='<%# EVal("ClosureWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Closure" SkinID="hold" OnClientClick='<%# "return Page_ClientValidate(""Closure" & Container.DataItemIndex & """) && confirm(""Closure record ?"");" %>' CommandName="ClosureWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtDCHeader"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtDCHeader"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtDCHeaderSelectList"
      TypeName = "SIS.SPMT.spmtDCHeader"
      SelectCountMethod = "spmtDCHeaderSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtDCHeader" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
