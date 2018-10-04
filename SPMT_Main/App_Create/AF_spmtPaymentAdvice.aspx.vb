Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Web.Script.Serialization
Partial Class AF_spmtPaymentAdvice
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtPaymentAdvice_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdvice.Init
    DataClassName = "AspmtPaymentAdvice"
    SetFormView = FVspmtPaymentAdvice
  End Sub
  Protected Sub TBLspmtPaymentAdvice_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPaymentAdvice.Init
    SetToolBar = TBLspmtPaymentAdvice
  End Sub
  Protected Sub ODSspmtPaymentAdvice_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtPaymentAdvice.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.spmtPaymentAdvice = CType(e.ReturnValue, SIS.SPMT.spmtPaymentAdvice)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&AdviceNo=" & oDC.AdviceNo
      TBLspmtPaymentAdvice.AfterInsertURL &= tmpURL
    End If
  End Sub
  Protected Sub FVspmtPaymentAdvice_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdvice.DataBound
    CType(FVspmtPaymentAdvice.FindControl("F_AdvanceRate"), TextBox).Text = "0.00"
    CType(FVspmtPaymentAdvice.FindControl("F_AdvanceAmount"), TextBox).Text = "0.00"
    CType(FVspmtPaymentAdvice.FindControl("F_RetensionRate"), TextBox).Text = "0.00"
    CType(FVspmtPaymentAdvice.FindControl("F_RetensionAmount"), TextBox).Text = "0.00"

    'SIS.SPMT.spmtPaymentAdvice.SetDefaultValues(sender, e)
  End Sub
  Protected Sub FVspmtPaymentAdvice_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdvice.PreRender
    Dim oF_TranTypeID As LC_spmtTranTypes = FVspmtPaymentAdvice.FindControl("F_TranTypeID")
    oF_TranTypeID.Enabled = True
    oF_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        oF_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    Dim oF_BPID_Display As Label = FVspmtPaymentAdvice.FindControl("F_BPID_Display")
    oF_BPID_Display.Text = String.Empty
    If Not Session("F_BPID_Display") Is Nothing Then
      If Session("F_BPID_Display") <> String.Empty Then
        oF_BPID_Display.Text = Session("F_BPID_Display")
      End If
    End If
    Dim oF_BPID As TextBox = FVspmtPaymentAdvice.FindControl("F_BPID")
    oF_BPID.Enabled = True
    oF_BPID.Text = String.Empty
    If Not Session("F_BPID") Is Nothing Then
      If Session("F_BPID") <> String.Empty Then
        oF_BPID.Text = Session("F_BPID")
      End If
    End If
    Dim oF_ConcernedHOD_Display As Label = FVspmtPaymentAdvice.FindControl("F_ConcernedHOD_Display")
    Dim oF_ConcernedHOD As TextBox = FVspmtPaymentAdvice.FindControl("F_ConcernedHOD")
    Dim oF_ProjectID_Display As Label = FVspmtPaymentAdvice.FindControl("F_ProjectID_Display")
    Dim oF_ProjectID As TextBox = FVspmtPaymentAdvice.FindControl("F_ProjectID")
    Dim oF_ElementID_Display As Label = FVspmtPaymentAdvice.FindControl("F_ElementID_Display")
    Dim oF_ElementID As TextBox = FVspmtPaymentAdvice.FindControl("F_ElementID")
    Dim oF_EmployeeID_Display As Label = FVspmtPaymentAdvice.FindControl("F_EmployeeID_Display")
    Dim oF_EmployeeID As TextBox = FVspmtPaymentAdvice.FindControl("F_EmployeeID")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtPaymentAdvice.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtPaymentAdvice") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtPaymentAdvice", mStr)
    End If
    If Request.QueryString("AdviceNo") IsNot Nothing Then
      CType(FVspmtPaymentAdvice.FindControl("F_AdviceNo"), TextBox).Text = Request.QueryString("AdviceNo")
      CType(FVspmtPaymentAdvice.FindControl("F_AdviceNo"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConcernedHODCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
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
    Return SIS.COM.comUsers.SelectcomUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_PaymentAdvice_ConcernedHOD(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ConcernedHOD As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(ConcernedHOD)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_PaymentAdvice_EmployeeID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim EmployeeID As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comUsers = SIS.COM.comUsers.comUsersGetByID(EmployeeID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_PaymentAdvice_ProjectsID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_PaymentAdvice_WBS(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_PaymentAdvice_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  Private Sub FVspmtPaymentAdvice_ItemInserting(sender As Object, e As FormViewInsertEventArgs) Handles FVspmtPaymentAdvice.ItemInserting
    Dim Err As Boolean = False
    Dim msg As String = ""
    Dim BPID As String = e.Values("BPID")
    Dim SupplierName As String = e.Values("SupplierName")
    If BPID = "" And SupplierName = "" Then
      Err = True
      msg = "Enter Supplier ID or Supplier Name, both can not be empty"
    End If
    If Err Then
      Dim message As String = New JavaScriptSerializer().Serialize(msg)
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End If
  End Sub
End Class
