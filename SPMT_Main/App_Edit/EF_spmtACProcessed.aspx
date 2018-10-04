<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtACProcessed.aspx.vb" Inherits="EF_spmtACProcessed" title="Edit: PA Processing by AC" %>
<asp:Content ID="CPHspmtACProcessed" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtACProcessed" runat="server" Text="&nbsp;Edit: PA Processing by AC"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtACProcessed" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtACProcessed"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnableDelete = "False"
    EnablePrint = "True"
    PrintUrl = "../App_Print/RP_spmtACProcessed.aspx?pk="
    ValidationGroup = "spmtACProcessed"
    runat = "server" />
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        url = o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
<asp:FormView ID="FVspmtACProcessed"
  runat = "server"
  DataKeyNames = "AdviceNo"
  DataSourceID = "ODSspmtACProcessed"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_AdviceNo" runat="server" ForeColor="#CC6633" Text="Advice No :" />&nbsp;</b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_AdviceNo"
            Text='<%# Bind("AdviceNo") %>'
            ToolTip="Value of Advice No."
            Enabled = "False"
            Width="88px"
            CssClass = "dmypktxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type ID :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_TranTypeID"
            Width="32px"
            Text='<%# Bind("TranTypeID") %>'
            Enabled = "False"
            ToolTip="Value of Tran Type ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_TranTypeID_Display"
            Text='<%# Eval("SPMT_TranTypes10_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="Supplier :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_BPID"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            Enabled = "False"
            ToolTip="Value of Supplier."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner11_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ConcernedHOD" runat="server" Text="Concerned HOD :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_ConcernedHOD"
            Width="72px"
            Text='<%# Bind("ConcernedHOD") %>'
            Enabled = "False"
            ToolTip="Value of Concerned HOD."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ConcernedHOD_Display"
            Text='<%# Eval("aspnet_users2_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="Project :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            Width="56px"
            Text='<%# Bind("ProjectID") %>'
            Enabled = "False"
            ToolTip="Value of Project."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects5_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ElementID" runat="server" Text="Element :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ElementID"
            Width="72px"
            Text='<%# Bind("ElementID") %>'
            Enabled = "False"
            ToolTip="Value of Element."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ElementID_Display"
            Text='<%# Eval("IDM_WBS6_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CostCenterID" runat="server" Text="Cost Center :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_CostCenterID"
            Width="56px"
            Text='<%# Bind("CostCenterID") %>'
            Enabled = "False"
            ToolTip="Value of Cost Center."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_CostCenterID_Display"
            Text='<%# Eval("SPMT_CostCenters8_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_DepartmentID" runat="server" Text="Department :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_DepartmentID"
            Width="56px"
            Text='<%# Bind("DepartmentID") %>'
            Enabled = "False"
            ToolTip="Value of Department."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_DepartmentID_Display"
            Text='<%# Eval("HRM_Departments4_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_EmployeeID" runat="server" Text="Employee :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_EmployeeID"
            Width="72px"
            Text='<%# Bind("EmployeeID") %>'
            Enabled = "False"
            ToolTip="Value of Employee."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_EmployeeID_Display"
            Text='<%# Eval("aspnet_users3_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Remarks" runat="server" Text="Remarks :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_Remarks"
            Text='<%# Bind("Remarks") %>'
            ToolTip="Value of Remarks."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_RemarksAC" runat="server" Text="A/C Remarks :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RemarksAC"
            Text='<%# Bind("RemarksAC") %>'
            ToolTip="Value of A/C Remarks."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdviceStatusUser" runat="server" Text="Created By :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceStatusUser"
            Width="72px"
            Text='<%# Bind("AdviceStatusUser") %>'
            Enabled = "False"
            ToolTip="Value of Created By."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceStatusUser_Display"
            Text='<%# Eval("aspnet_users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AdviceStatusOn" runat="server" Text="Created On :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_AdviceStatusOn"
            Text='<%# Bind("AdviceStatusOn") %>'
            ToolTip="Value of Created On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_AdviceStatusID" runat="server" Text="Advice Status :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceStatusID"
            Width="88px"
            Text='<%# Bind("AdviceStatusID") %>'
            Enabled = "False"
            ToolTip="Value of Advice Status."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceStatusID_Display"
            Text='<%# Eval("SPMT_PAStatus9_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CostCenter" runat="server" Text="Total Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CostCenter"
            Text='<%# Bind("CostCenter") %>'
            ToolTip="Value of Total Amount."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_DocumentNo" runat="server" Text="Voucher Type :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_DocumentNo"
            Text='<%# Bind("DocumentNo") %>'
            ToolTip="Value of Voucher Type."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BaaNCompany" runat="server" Text="Voucher No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BaaNCompany"
            Text='<%# Bind("BaaNCompany") %>'
            ToolTip="Value of Voucher No."
            Enabled = "False"
            Width="88px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BaaNLedger" runat="server" Text="BaaN Company :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BaaNLedger"
            Text='<%# Bind("BaaNLedger") %>'
            ToolTip="Value of BaaN Company."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_RemarksHOD" runat="server" Text="Recd./Rtnd. :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RemarksHOD"
            Text='<%# Bind("RemarksHOD") %>'
            ToolTip="Value of Recd./Rtnd.."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_RemarksHR" runat="server" Text="Locked By :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_RemarksHR"
            Text='<%# Bind("RemarksHR") %>'
            ToolTip="Value of Locked By."
            Enabled = "False"
            Width="350px" Height="40px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtPaymentAdviceSupplierBill" runat="server" Text="&nbsp;List: Selected Bills"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtPaymentAdviceSupplierBill" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtPaymentAdviceSupplierBill"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtPaymentAdviceSupplierBill.aspx"
      EnableAdd = "False"
      EnableExit = "false"
      ValidationGroup = "spmtPaymentAdviceSupplierBill"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtPaymentAdviceSupplierBill" runat="server" AssociatedUpdatePanelID="UPNLspmtPaymentAdviceSupplierBill" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtPaymentAdviceSupplierBill" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtPaymentAdviceSupplierBill" DataKeyNames="IRNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="IR No" SortExpression="IRNo">
          <ItemTemplate>
            <asp:Label ID="LabelIRNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("IRNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tran.Type" SortExpression="SPMT_TranTypes16_Description">
          <ItemTemplate>
             <asp:Label ID="L_TranTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("TranTypeID") %>' Text='<%# Eval("SPMT_TranTypes16_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier" SortExpression="VR_BusinessPartner18_BPName">
          <ItemTemplate>
             <asp:Label ID="L_BPID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("BPID") %>' Text='<%# Eval("VR_BusinessPartner18_BPName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Number" SortExpression="BillNumber">
          <ItemTemplate>
            <asp:Label ID="LabelBillNumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillNumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Date" SortExpression="BillDate">
          <ItemTemplate>
            <asp:Label ID="LabelBillDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Bill Amount" SortExpression="BillAmount">
          <ItemTemplate>
            <asp:Label ID="LabelBillAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BillAmount") %>'></asp:Label>
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
      ID = "ODSspmtPaymentAdviceSupplierBill"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtPaymentAdviceSupplierBill"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtPaymentAdviceSupplierBillSelectList"
      TypeName = "SIS.SPMT.spmtPaymentAdviceSupplierBill"
      SelectCountMethod = "spmtPaymentAdviceSupplierBillSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_AdviceNo" PropertyName="Text" Name="AdviceNo" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtPaymentAdviceSupplierBill" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtACProcessed"
  DataObjectTypeName = "SIS.SPMT.spmtACProcessed"
  SelectMethod = "spmtACProcessedGetByID"
  UpdateMethod="spmtACProcessedUpdate"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtACProcessed"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="AdviceNo" Name="AdviceNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
