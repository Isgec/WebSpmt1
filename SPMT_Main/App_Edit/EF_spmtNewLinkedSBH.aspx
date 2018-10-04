<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_spmtNewLinkedSBH.aspx.vb" Inherits="EF_spmtNewLinkedSBH" title="Edit: *Linked Supplier Bill" %>
<asp:Content ID="CPHspmtNewLinkedSBH" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtNewLinkedSBH" runat="server" Text="&nbsp;Edit: *Linked Supplier Bill"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLspmtNewLinkedSBH" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLspmtNewLinkedSBH"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnableDelete = "False"
    ValidationGroup = "spmtNewLinkedSBH"
    runat = "server" />
<asp:FormView ID="FVspmtNewLinkedSBH"
  runat = "server"
  DataKeyNames = "IRNo"
  DataSourceID = "ODSspmtNewLinkedSBH"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_IRNo" runat="server" ForeColor="#CC6633" Text="IR No :" />&nbsp;</b>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_IRNo"
            Text='<%# Bind("IRNo") %>'
            ToolTip="Value of IR No."
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
          <asp:Label ID="L_PurchaseType" runat="server" Text="Purchase Type :" />&nbsp;
        </td>
        <td>
          <asp:DropDownList
            ID="F_PurchaseType"
            SelectedValue='<%# Bind("PurchaseType") %>'
            Width="200px"
            Enabled = "False"
            CssClass = "dmyddl"
            Runat="Server" >
            <asp:ListItem Value=" ">---Select---</asp:ListItem>
            <asp:ListItem Value="Purchase from Registered Dealer">Purchase from Registered Dealer</asp:ListItem>
            <asp:ListItem Value="Purchase from Composition Dealer">Purchase from Composition Dealer</asp:ListItem>
            <asp:ListItem Value=" Purchase from Unregistered Dealer"> Purchase from Unregistered Dealer</asp:ListItem>
            <asp:ListItem Value="Non GST expenses bill">Non GST expenses bill</asp:ListItem>
          </asp:DropDownList>
         </td>
        <td class="alignright">
          <asp:Label ID="L_TranTypeID" runat="server" Text="Tran Type :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_TranTypeID"
            Width="32px"
            Text='<%# Bind("TranTypeID") %>'
            Enabled = "False"
            ToolTip="Value of Tran Type."
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
          <asp:Label ID="L_IsgecGSTIN" runat="server" Text="Isgec GSTIN :" />&nbsp;
        </td>
        <td colspan="3">
          <asp:TextBox
            ID = "F_IsgecGSTIN"
            Width="88px"
            Text='<%# Bind("IsgecGSTIN") %>'
            Enabled = "False"
            ToolTip="Value of Isgec GSTIN."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_IsgecGSTIN_Display"
            Text='<%# Eval("SPMT_IsgecGSTIN8_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BPID" runat="server" Text="BP ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_BPID"
            Width="80px"
            Text='<%# Bind("BPID") %>'
            Enabled = "False"
            ToolTip="Value of BP ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_BPID_Display"
            Text='<%# Eval("VR_BusinessPartner12_BPName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SupplierGSTIN" runat="server" Text="Supplier GSTIN :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_SupplierGSTIN"
            Width="88px"
            Text='<%# Bind("SupplierGSTIN") %>'
            Enabled = "False"
            ToolTip="Value of Supplier GSTIN."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_SupplierGSTIN_Display"
            Text='<%# Eval("VR_BPGSTIN11_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SupplierName" runat="server" Text="Supplier Name :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SupplierName"
            Text='<%# Bind("SupplierName") %>'
            ToolTip="Value of Supplier Name."
            Enabled = "False"
            Width="350px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_SupplierGSTINNumber" runat="server" Text="Supplier GSTIN Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_SupplierGSTINNumber"
            Text='<%# Bind("SupplierGSTINNumber") %>'
            ToolTip="Value of Supplier GSTIN Number."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ShipToState" runat="server" Text="Ship To State :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ShipToState"
            Width="24px"
            Text='<%# Bind("ShipToState") %>'
            Enabled = "False"
            ToolTip="Value of Ship To State."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ShipToState_Display"
            Text='<%# Eval("SPMT_ERPStates7_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillNumber" runat="server" Text="Supplier Bill Number :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BillNumber"
            Text='<%# Bind("BillNumber") %>'
            ToolTip="Value of Supplier Bill Number."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_BillDate" runat="server" Text="Supplier Bill Date :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BillDate"
            Text='<%# Bind("BillDate") %>'
            ToolTip="Value of Supplier Bill Date."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_BillRemarks" runat="server" Text="Bill Remarks :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_BillRemarks"
            Text='<%# Bind("BillRemarks") %>'
            ToolTip="Value of Bill Remarks."
            Enabled = "False"
            Width="350px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ProjectID"
            Width="56px"
            Text='<%# Bind("ProjectID") %>'
            Enabled = "False"
            ToolTip="Value of Project ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ProjectID_Display"
            Text='<%# Eval("IDM_Projects4_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ElementID" runat="server" Text="Element ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_ElementID"
            Width="72px"
            Text='<%# Bind("ElementID") %>'
            Enabled = "False"
            ToolTip="Value of Element ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_ElementID_Display"
            Text='<%# Eval("IDM_WBS5_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_DepartmentID" runat="server" Text="Department ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_DepartmentID"
            Width="56px"
            Text='<%# Bind("DepartmentID") %>'
            Enabled = "False"
            ToolTip="Value of Department ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_DepartmentID_Display"
            Text='<%# Eval("HRM_Departments2_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CostCenterID" runat="server" Text="Cost Center ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_CostCenterID"
            Width="56px"
            Text='<%# Bind("CostCenterID") %>'
            Enabled = "False"
            ToolTip="Value of Cost Center ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_CostCenterID_Display"
            Text='<%# Eval("SPMT_CostCenters6_Description") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_EmployeeID" runat="server" Text="Employee ID :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_EmployeeID"
            Width="72px"
            Text='<%# Bind("EmployeeID") %>'
            Enabled = "False"
            ToolTip="Value of Employee ID."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_EmployeeID_Display"
            Text='<%# Eval("HRM_Employees3_EmployeeName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_IRReceivedOn" runat="server" Text="IR Received On :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_IRReceivedOn"
            Text='<%# Bind("IRReceivedOn") %>'
            ToolTip="Value of IR Received On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_AdviceNo" runat="server" Text="AdviceNo :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_AdviceNo"
            Width="88px"
            Text='<%# Bind("AdviceNo") %>'
            Enabled = "False"
            ToolTip="Value of AdviceNo."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_AdviceNo_Display"
            Text='<%# Eval("SPMT_newPA9_BPID") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_CreatedBy" runat="server" Text="Created By :" />&nbsp;
        </td>
        <td>
          <asp:TextBox
            ID = "F_CreatedBy"
            Width="72px"
            Text='<%# Bind("CreatedBy") %>'
            Enabled = "False"
            ToolTip="Value of Created By."
            CssClass = "dmyfktxt"
            Runat="Server" />
          <asp:Label
            ID = "F_CreatedBy_Display"
            Text='<%# Eval("aspnet_users1_UserFullName") %>'
            CssClass="myLbl"
            Runat="Server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_CreatedOn" runat="server" Text="Created On :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_CreatedOn"
            Text='<%# Bind("CreatedOn") %>'
            ToolTip="Value of Created On."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_TotalBillAmount" runat="server" Text="Total Bill Amount :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_TotalBillAmount"
            Text='<%# Bind("TotalBillAmount") %>'
            ToolTip="Value of Total Bill Amount."
            Enabled = "False"
            Width="168px"
            CssClass = "dmytxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_UploadBatchNo" runat="server" Text="Upload Batch No :" />&nbsp;
        </td>
        <td>
          <asp:TextBox ID="F_UploadBatchNo"
            Text='<%# Bind("UploadBatchNo") %>'
            ToolTip="Value of Upload Batch No."
            Enabled = "False"
            Width="408px"
            CssClass = "dmytxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
  </div>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelspmtNewDispSBD" runat="server" Text="&nbsp;List: *Supplier Bill Items"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtNewDispSBD" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtNewDispSBD"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtNewDispSBD.aspx"
      EnableAdd = "False"
      EnableExit = "false"
      ValidationGroup = "spmtNewDispSBD"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtNewDispSBD" runat="server" AssociatedUpdatePanelID="UPNLspmtNewDispSBD" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtNewDispSBD" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtNewDispSBD" DataKeyNames="IRNo,SerialNo">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Serial No" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Item Description" SortExpression="ItemDescription">
          <ItemTemplate>
            <asp:Label ID="LabelItemDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemDescription") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UOM" SortExpression="SPMT_ERPUnits7_Description">
          <ItemTemplate>
             <asp:Label ID="L_UOM" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UOM") %>' Text='<%# Eval("SPMT_ERPUnits7_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Assessable Value" SortExpression="AssessableValue">
          <ItemTemplate>
            <asp:Label ID="LabelAssessableValue" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AssessableValue") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total GST [INR]" SortExpression="TotalGSTINR">
          <ItemTemplate>
            <asp:Label ID="LabelTotalGSTINR" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalGSTINR") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount [INR]" SortExpression="TotalAmountINR">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmountINR" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmountINR") %>'></asp:Label>
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
      ID = "ODSspmtNewDispSBD"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtNewDispSBD"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtNewDispSBDSelectList"
      TypeName = "SIS.SPMT.spmtNewDispSBD"
      SelectCountMethod = "spmtNewDispSBDSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_IRNo" PropertyName="Text" Name="IRNo" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtNewDispSBD" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSspmtNewLinkedSBH"
  DataObjectTypeName = "SIS.SPMT.spmtNewLinkedSBH"
  SelectMethod = "spmtNewLinkedSBHGetByID"
  UpdateMethod="UZ_spmtNewLinkedSBHUpdate"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.SPMT.spmtNewLinkedSBH"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="IRNo" Name="IRNo" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
