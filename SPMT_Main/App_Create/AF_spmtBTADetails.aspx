<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_spmtBTADetails.aspx.vb" Inherits="AF_spmtBTADetails" title="Add: BTA Details" %>
<asp:Content ID="CPHspmtBTADetails" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtBTADetails" runat="server" Text="&nbsp;Add: BTA Details"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBTADetails" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtBTADetails"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "spmtBTADetails"
    runat = "server" />
<asp:FormView ID="FVspmtBTADetails"
  runat = "server"
  DataKeyNames = "SerialNo"
  DataSourceID = "ODSspmtBTADetails"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgspmtBTADetails" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" ForeColor="#CC6633" runat="server" Text="SerialNo :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_SerialNo" Enabled="False" CssClass="mypktxt" Width="88px" runat="server" Text="0" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CORP_2" runat="server" Text="CORP_2 :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CORP_2"
            Text='<%# Bind("CORP_2") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for CORP_2."
            MaxLength="15"
            Width="128px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CORP_1" runat="server" Text="CORP_1 :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CORP_1"
            Text='<%# Bind("CORP_1") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for CORP_1."
            MaxLength="15"
            Width="128px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BTA_ACCT" runat="server" Text="BTA_ACCT :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BTA_ACCT"
            Text='<%# Bind("BTA_ACCT") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for BTA_ACCT."
            MaxLength="15"
            Width="128px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_STMT_DT" runat="server" Text="STMT_DT :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_STMT_DT"
            Text='<%# Bind("STMT_DT") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonSTMT_DT" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CESTMT_DT"
            TargetControlID="F_STMT_DT"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonSTMT_DT" />
          <AJX:MaskedEditExtender 
            ID = "MEESTMT_DT"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_STMT_DT" />
          <AJX:MaskedEditValidator 
            ID = "MEVSTMT_DT"
            runat = "server"
            ControlToValidate = "F_STMT_DT"
            ControlExtender = "MEESTMT_DT"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_STMT_REF_NO" runat="server" Text="STMT_REF_NO :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_STMT_REF_NO"
            Text='<%# Bind("STMT_REF_NO") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for STMT_REF_NO."
            MaxLength="15"
            Width="128px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CUST_REF" runat="server" Text="CUST_REF :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CUST_REF"
            Text='<%# Bind("CUST_REF") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for CUST_REF."
            MaxLength="20"
            Width="168px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TRIP_REQ" runat="server" Text="TRIP_REQ :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TRIP_REQ"
            Text='<%# Bind("TRIP_REQ") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for TRIP_REQ."
            MaxLength="20"
            Width="168px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_JOB_NO" runat="server" Text="JOB_NO :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_JOB_NO"
            Text='<%# Bind("JOB_NO") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for JOB_NO."
            MaxLength="20"
            Width="168px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_PAX_NM" runat="server" Text="PAX_NM :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_PAX_NM"
            Text='<%# Bind("PAX_NM") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for PAX_NM."
            MaxLength="30"
            Width="248px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AMOUNT_EX_GST" runat="server" Text="AMOUNT_EX_GST :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AMOUNT_EX_GST"
            Text='<%# Bind("AMOUNT_EX_GST") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEAMOUNT_EX_GST"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_AMOUNT_EX_GST" />
          <AJX:MaskedEditValidator 
            ID = "MEVAMOUNT_EX_GST"
            runat = "server"
            ControlToValidate = "F_AMOUNT_EX_GST"
            ControlExtender = "MEEAMOUNT_EX_GST"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_GST" runat="server" Text="GST :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_GST"
            Text='<%# Bind("GST") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEGST"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_GST" />
          <AJX:MaskedEditValidator 
            ID = "MEVGST"
            runat = "server"
            ControlToValidate = "F_GST"
            ControlExtender = "MEEGST"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_UNPAID_AMT" runat="server" Text="UNPAID_AMT :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_UNPAID_AMT"
            Text='<%# Bind("UNPAID_AMT") %>'
            Width="168px"
            CssClass = "mytxt"
            style="text-align: Right"
            MaxLength="20"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEUNPAID_AMT"
            runat = "server"
            mask = "999999999999999999.99"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_UNPAID_AMT" />
          <AJX:MaskedEditValidator 
            ID = "MEVUNPAID_AMT"
            runat = "server"
            ControlToValidate = "F_UNPAID_AMT"
            ControlExtender = "MEEUNPAID_AMT"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CHARGE_DTE" runat="server" Text="CHARGE_DTE :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CHARGE_DTE"
            Text='<%# Bind("CHARGE_DTE") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonCHARGE_DTE" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CECHARGE_DTE"
            TargetControlID="F_CHARGE_DTE"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonCHARGE_DTE" />
          <AJX:MaskedEditExtender 
            ID = "MEECHARGE_DTE"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_CHARGE_DTE" />
          <AJX:MaskedEditValidator 
            ID = "MEVCHARGE_DTE"
            runat = "server"
            ControlToValidate = "F_CHARGE_DTE"
            ControlExtender = "MEECHARGE_DTE"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BKNG_DATE" runat="server" Text="BKNG_DATE :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BKNG_DATE"
            Text='<%# Bind("BKNG_DATE") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonBKNG_DATE" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEBKNG_DATE"
            TargetControlID="F_BKNG_DATE"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonBKNG_DATE" />
          <AJX:MaskedEditExtender 
            ID = "MEEBKNG_DATE"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_BKNG_DATE" />
          <AJX:MaskedEditValidator 
            ID = "MEVBKNG_DATE"
            runat = "server"
            ControlToValidate = "F_BKNG_DATE"
            ControlExtender = "MEEBKNG_DATE"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_DEPT_DATE" runat="server" Text="DEPT_DATE :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_DEPT_DATE"
            Text='<%# Bind("DEPT_DATE") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonDEPT_DATE" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEDEPT_DATE"
            TargetControlID="F_DEPT_DATE"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonDEPT_DATE" />
          <AJX:MaskedEditExtender 
            ID = "MEEDEPT_DATE"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_DEPT_DATE" />
          <AJX:MaskedEditValidator 
            ID = "MEVDEPT_DATE"
            runat = "server"
            ControlToValidate = "F_DEPT_DATE"
            ControlExtender = "MEEDEPT_DATE"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TICKET_NO" runat="server" Text="TICKET_NO :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TICKET_NO"
            Text='<%# Bind("TICKET_NO") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for TICKET_NO."
            MaxLength="10"
            Width="88px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CARRIER" runat="server" Text="CARRIER :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CARRIER"
            Text='<%# Bind("CARRIER") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for CARRIER."
            MaxLength="30"
            Width="248px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CLASS" runat="server" Text="CLASS :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CLASS"
            Text='<%# Bind("CLASS") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for CLASS."
            MaxLength="10"
            Width="88px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_DI" runat="server" Text="DI :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_DI"
            Text='<%# Bind("DI") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for DI."
            MaxLength="2"
            Width="24px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ROUTING" runat="server" Text="ROUTING :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_ROUTING"
            Text='<%# Bind("ROUTING") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for ROUTING."
            MaxLength="80"
            Width="350px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_TXN_DATE" runat="server" Text="TXN_DATE :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TXN_DATE"
            Text='<%# Bind("TXN_DATE") %>'
            Width="80px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonTXN_DATE" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CETXN_DATE"
            TargetControlID="F_TXN_DATE"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonTXN_DATE" />
          <AJX:MaskedEditExtender 
            ID = "MEETXN_DATE"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_TXN_DATE" />
          <AJX:MaskedEditValidator 
            ID = "MEVTXN_DATE"
            runat = "server"
            ControlToValidate = "F_TXN_DATE"
            ControlExtender = "MEETXN_DATE"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            IsValidEmpty = "True"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Merchant_ABN" runat="server" Text="Merchant_ABN :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_Merchant_ABN"
            Text='<%# Bind("Merchant_ABN") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Merchant_ABN."
            MaxLength="16"
            Width="136px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_Book_Ref" runat="server" Text="Book_Ref :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_Book_Ref"
            Text='<%# Bind("Book_Ref") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Book_Ref."
            MaxLength="9"
            Width="80px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_COMMENT1" runat="server" Text="COMMENT1 :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_COMMENT1"
            Text='<%# Bind("COMMENT1") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for COMMENT1."
            MaxLength="45"
            Width="368px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_COMMENT2" runat="server" Text="COMMENT2 :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_COMMENT2"
            Text='<%# Bind("COMMENT2") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for COMMENT2."
            MaxLength="45"
            Width="368px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_COMMENT3" runat="server" Text="COMMENT3 :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_COMMENT3"
            Text='<%# Bind("COMMENT3") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for COMMENT3."
            MaxLength="450"
            Width="350px"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_MERCHANT_NAME" runat="server" Text="MERCHANT_NAME :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_MERCHANT_NAME"
            Text='<%# Bind("MERCHANT_NAME") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for MERCHANT_NAME."
            MaxLength="31"
            Width="256px"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BatchNo" runat="server" Text="BatchNo :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_BatchNo"
            Text='<%# Bind("BatchNo") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mytxt"
            ValidationGroup="spmtBTADetails"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEBatchNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_BatchNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVBatchNo"
            runat = "server"
            ControlToValidate = "F_BatchNo"
            ControlExtender = "MEEBatchNo"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBTADetails"
            IsValidEmpty = "false"
            MinimumValue = "1"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_StatusID" runat="server" Text="StatusID :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_StatusID"
            CssClass = "myfktxt"
            Width="88px"
            Text='<%# Bind("StatusID") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for StatusID."
            ValidationGroup = "spmtBTADetails"
            onblur= "script_spmtBTADetails.validate_StatusID(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVStatusID"
            runat = "server"
            ControlToValidate = "F_StatusID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBTADetails"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_StatusID_Display"
            Text='<%# Eval("SPMT_BTAStatus2_Descriptions") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEStatusID"
            BehaviorID="B_ACEStatusID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="StatusIDCompletionList"
            TargetControlID="F_StatusID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtBTADetails.ACEStatusID_Selected"
            OnClientPopulating="script_spmtBTADetails.ACEStatusID_Populating"
            OnClientPopulated="script_spmtBTADetails.ACEStatusID_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CreatedBy" runat="server" Text="CreatedBy :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox
            ID = "F_CreatedBy"
            CssClass = "myfktxt"
            Width="72px"
            Text='<%# Bind("CreatedBy") %>'
            AutoCompleteType = "None"
            onfocus = "return this.select();"
            ToolTip="Enter value for CreatedBy."
            ValidationGroup = "spmtBTADetails"
            onblur= "script_spmtBTADetails.validate_CreatedBy(this);"
            Runat="Server" />
          <asp:RequiredFieldValidator 
            ID = "RFVCreatedBy"
            runat = "server"
            ControlToValidate = "F_CreatedBy"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBTADetails"
            SetFocusOnError="true" />
          <asp:Label
            ID = "F_CreatedBy_Display"
            Text='<%# Eval("aspnet_users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACECreatedBy"
            BehaviorID="B_ACECreatedBy"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="CreatedByCompletionList"
            TargetControlID="F_CreatedBy"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_spmtBTADetails.ACECreatedBy_Selected"
            OnClientPopulating="script_spmtBTADetails.ACECreatedBy_Populating"
            OnClientPopulated="script_spmtBTADetails.ACECreatedBy_Populated"
            CompletionSetCount="10"
            CompletionListCssClass = "autocomplete_completionListElement"
            CompletionListItemCssClass = "autocomplete_listItem"
            CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CreatedOn" runat="server" Text="CreatedOn :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_CreatedOn"
            Text='<%# Bind("CreatedOn") %>'
            Width="80px"
            CssClass = "mytxt"
            ValidationGroup="spmtBTADetails"
            onfocus = "return this.select();"
            runat="server" />
          <asp:Image ID="ImageButtonCreatedOn" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:bottom" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CECreatedOn"
            TargetControlID="F_CreatedOn"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonCreatedOn" />
          <AJX:MaskedEditExtender 
            ID = "MEECreatedOn"
            runat = "server"
            mask = "99/99/9999"
            MaskType="Date"
            CultureName = "en-GB"
            MessageValidatorTip="true"
            InputDirection="LeftToRight"
            ErrorTooltipEnabled="true"
            TargetControlID="F_CreatedOn" />
          <AJX:MaskedEditValidator 
            ID = "MEVCreatedOn"
            runat = "server"
            ControlToValidate = "F_CreatedOn"
            ControlExtender = "MEECreatedOn"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "spmtBTADetails"
            IsValidEmpty = "false"
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
  ID = "ODSspmtBTADetails"
  DataObjectTypeName = "SIS.SPMT.spmtBTADetails"
  InsertMethod="UZ_spmtBTADetailsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtBTADetails"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
