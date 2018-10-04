Imports System.Web.Script.Serialization
Partial Class AF_spmtNewSBH
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtNewSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBH.Init
    DataClassName = "AspmtNewSBH"
    SetFormView = FVspmtNewSBH
  End Sub
  Protected Sub TBLspmtNewSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewSBH.Init
    SetToolBar = TBLspmtNewSBH
  End Sub
  Protected Sub ODSspmtNewSBH_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewSBH.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.spmtNewSBH = CType(e.ReturnValue, SIS.SPMT.spmtNewSBH)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&IRNo=" & oDC.IRNo
      TBLspmtNewSBH.AfterInsertURL &= tmpURL
    End If
  End Sub
  Protected Sub FVspmtNewSBH_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBH.DataBound
    SIS.SPMT.spmtNewSBH.SetDefaultValues(sender, e)
  End Sub
  Protected Sub FVspmtNewSBH_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBH.PreRender
    Dim oF_TranTypeID As LC_spmtTranTypes = FVspmtNewSBH.FindControl("F_TranTypeID")
    oF_TranTypeID.Enabled = True
    oF_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        oF_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    Dim oF_IsgecGSTIN As LC_spmtIsgecGSTIN = FVspmtNewSBH.FindControl("F_IsgecGSTIN")
    oF_IsgecGSTIN.Enabled = True
    oF_IsgecGSTIN.SelectedValue = String.Empty
    If Not Session("F_IsgecGSTIN") Is Nothing Then
      If Session("F_IsgecGSTIN") <> String.Empty Then
        oF_IsgecGSTIN.SelectedValue = Session("F_IsgecGSTIN")
      End If
    End If
    Dim oF_BPID_Display As Label = FVspmtNewSBH.FindControl("F_BPID_Display")
    oF_BPID_Display.Text = String.Empty
    If Not Session("F_BPID_Display") Is Nothing Then
      If Session("F_BPID_Display") <> String.Empty Then
        oF_BPID_Display.Text = Session("F_BPID_Display")
      End If
    End If
    Dim oF_BPID As TextBox = FVspmtNewSBH.FindControl("F_BPID")
    oF_BPID.Enabled = True
    oF_BPID.Text = String.Empty
    If Not Session("F_BPID") Is Nothing Then
      If Session("F_BPID") <> String.Empty Then
        oF_BPID.Text = Session("F_BPID")
      End If
    End If
    Dim oF_SupplierGSTIN_Display As Label = FVspmtNewSBH.FindControl("F_SupplierGSTIN_Display")
    Dim oF_SupplierGSTIN As TextBox = FVspmtNewSBH.FindControl("F_SupplierGSTIN")
    Dim oF_ProjectID_Display As Label = FVspmtNewSBH.FindControl("F_ProjectID_Display")
    Dim oF_ProjectID As TextBox = FVspmtNewSBH.FindControl("F_ProjectID")
    Dim oF_ElementID_Display As Label = FVspmtNewSBH.FindControl("F_ElementID_Display")
    Dim oF_ElementID As TextBox = FVspmtNewSBH.FindControl("F_ElementID")
    Dim oF_EmployeeID_Display As Label = FVspmtNewSBH.FindControl("F_EmployeeID_Display")
    Dim oF_EmployeeID As TextBox = FVspmtNewSBH.FindControl("F_EmployeeID")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtNewSBH.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewSBH") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewSBH", mStr)
    End If
    If Request.QueryString("IRNo") IsNot Nothing Then
      CType(FVspmtNewSBH.FindControl("F_IRNo"), TextBox).Text = Request.QueryString("IRNo")
      CType(FVspmtNewSBH.FindControl("F_IRNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function SupplierGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ElementIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comElements.SelectcomElementsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function EmployeeIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comEmployees.SelectcomEmployeesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBH_EmployeeID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim EmployeeID As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comEmployees = SIS.COM.comEmployees.comEmployeesGetByID(EmployeeID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBH_ProjectID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ProjectID As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comProjects = SIS.COM.comProjects.comProjectsGetByID(ProjectID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBH_ElementID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ElementID As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comElements = SIS.COM.comElements.comElementsGetByID(ElementID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBH_SupplierGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim SupplierGSTIN As String = CType(aVal(2), String)
    Dim sGst As Integer = 0
    If IsNumeric(SupplierGSTIN) Then
      sGst = Convert.ToInt32(SupplierGSTIN)
    End If
    Dim oVar As SIS.SPMT.spmtBPGSTIN = Nothing
    If sGst > 0 Then
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
    Else
      oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
    End If
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID)
      If sGst > 0 Then
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, sGst)
      Else
        oVar = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(BPID, SupplierGSTIN)
      End If
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found in ERP."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBH_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetBPFromERP(BPID)
      oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      SIS.SPMT.spmtSupplierBill.GetBPGSTINFromERP(BPID, 0)
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  Private Sub FVspmtNewSBH_ItemInserting(sender As Object, e As FormViewInsertEventArgs) Handles FVspmtNewSBH.ItemInserting
    Dim Err As Boolean = False
    Dim msg As String = ""
    Dim PurchaseType As String = e.Values("PurchaseType")
    Dim BPID As String = e.Values("BPID")
    Dim SupplierGSTIN As String = e.Values("SupplierGSTIN")
    Dim SupplierName As String = e.Values("SupplierName")
    Dim SupplierGSTINNumber As String = e.Values("SupplierGSTINNumber")
    Select Case PurchaseType
      Case "Purchase from Registered Dealer", "Purchase from Composition Dealer"
        If BPID = "" Then
          Err = True
          msg = "Supplier ID is mandatory."
        End If
        If SupplierGSTIN = "" Then
          Err = True
          msg = "Supplier GSTIN is mandatory."
        End If
      Case "Purchase from Unregistered Dealer", "Non GST expenses bill", "Purchase from Registered Dealer-No ITC"
        If SupplierName = "" And BPID = "" Then
          Err = True
          msg = "Either Supplier ID or Supplier Name is Mandatory."
        End If
    End Select
    If Err Then
      Dim message As String = New JavaScriptSerializer().Serialize(msg)
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End If
  End Sub
End Class
