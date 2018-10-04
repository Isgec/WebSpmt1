Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Web.Script.Serialization
Partial Class EF_spmtPaymentAdvice
  Inherits SIS.SYS.UpdateBase
  Public Property Editable() As Boolean
    Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Editable", value)
    End Set
  End Property
  Public Property Deleteable() As Boolean
    Get
      If ViewState("Deleteable") IsNot Nothing Then
        Return CType(ViewState("Deleteable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Deleteable", value)
    End Set
  End Property
  Public Property BillSelectable() As Boolean
    Get
      If ViewState("BillSelectable") IsNot Nothing Then
        Return CType(ViewState("BillSelectable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("BillSelectable", value)
    End Set
  End Property

  Public Property InitiateWFVisible() As Boolean
    Get
      If ViewState("InitiateWFVisible") IsNot Nothing Then
        Return CType(ViewState("InitiateWFVisible"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("InitiateWFVisible", value)
    End Set
  End Property
  Public Property PrimaryKey() As String
    Get
      If ViewState("PrimaryKey") IsNot Nothing Then
        Return CType(ViewState("PrimaryKey"), String)
      End If
      Return True
    End Get
    Set(ByVal value As String)
      ViewState.Add("PrimaryKey", value)
    End Set
  End Property
  Protected Sub ODSspmtPaymentAdvice_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtPaymentAdvice.Selected
    Dim tmp As SIS.SPMT.spmtPaymentAdvice = CType(e.ReturnValue, SIS.SPMT.spmtPaymentAdvice)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
    InitiateWFVisible = tmp.InitiateWFVisible
    BillSelectable = tmp.BillSelectable
  End Sub
  Protected Sub FVspmtPaymentAdvice_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdvice.Init
    DataClassName = "EspmtPaymentAdvice"
    SetFormView = FVspmtPaymentAdvice
  End Sub
  Protected Sub TBLspmtPaymentAdvice_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPaymentAdvice.Init
    SetToolBar = TBLspmtPaymentAdvice
  End Sub
  Protected Sub FVspmtPaymentAdvice_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtPaymentAdvice.PreRender
    TBLspmtPaymentAdvice.EnableSave = Editable
    TBLspmtPaymentAdvice.EnableDelete = Deleteable
    TBLspmtPaymentAdvice.PrintUrl &= Request.QueryString("AdviceNo") & "|"
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtPaymentAdvice.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtPaymentAdvice") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtPaymentAdvice", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtPaymentAdviceSupplierBillCC As New gvBase
  Protected Sub GVspmtPaymentAdviceSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtPaymentAdviceSupplierBill.Init
    gvspmtPaymentAdviceSupplierBillCC.DataClassName = "GspmtPaymentAdviceSupplierBill"
    gvspmtPaymentAdviceSupplierBillCC.SetGridView = GVspmtPaymentAdviceSupplierBill
  End Sub
  Protected Sub TBLspmtPaymentAdviceSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtPaymentAdviceSupplierBill.Init
    gvspmtPaymentAdviceSupplierBillCC.SetToolBar = TBLspmtPaymentAdviceSupplierBill
  End Sub
  Protected Sub GVspmtPaymentAdviceSupplierBill_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtPaymentAdviceSupplierBill.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtPaymentAdviceSupplierBill.DataKeys(e.CommandArgument).Values("IRNo")
        Dim RedirectUrl As String = TBLspmtPaymentAdviceSupplierBill.EditUrl & "?IRNo=" & IRNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "rejectwf".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtPaymentAdviceSupplierBill.DataKeys(e.CommandArgument).Values("IRNo")
        SIS.SPMT.spmtPaymentAdviceSupplierBill.RejectWF(IRNo, PrimaryKey)
        GVspmtPaymentAdviceSupplierBill.DataBind()
        GVspmtUnlinkedSupplierBill.DataBind()
        FVspmtPaymentAdvice.DataBind()
      Catch ex As Exception
        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      End Try
    End If
  End Sub
  Private WithEvents gvspmtUnlinkedSupplierBillCC As New gvBase
  Protected Sub GVspmtUnlinkedSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtUnlinkedSupplierBill.Init
    gvspmtUnlinkedSupplierBillCC.DataClassName = "GspmtUnlinkedSupplierBill"
    gvspmtUnlinkedSupplierBillCC.SetGridView = GVspmtUnlinkedSupplierBill
  End Sub
  Protected Sub TBLspmtUnlinkedSupplierBill_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtUnlinkedSupplierBill.Init
    gvspmtUnlinkedSupplierBillCC.SetToolBar = TBLspmtUnlinkedSupplierBill
  End Sub
  Protected Sub GVspmtUnlinkedSupplierBill_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtUnlinkedSupplierBill.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtUnlinkedSupplierBill.DataKeys(e.CommandArgument).Values("IRNo")
        Dim RedirectUrl As String = TBLspmtUnlinkedSupplierBill.EditUrl & "?IRNo=" & IRNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "approvewf".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtUnlinkedSupplierBill.DataKeys(e.CommandArgument).Values("IRNo")
        SIS.SPMT.spmtUnlinkedSupplierBill.ApproveWF(IRNo, PrimaryKey)
        GVspmtUnlinkedSupplierBill.DataBind()
        GVspmtPaymentAdviceSupplierBill.DataBind()
        FVspmtPaymentAdvice.DataBind()
      Catch ex As Exception
        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      End Try
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

  Private Sub FVspmtPaymentAdvice_ItemUpdating(sender As Object, e As FormViewUpdateEventArgs) Handles FVspmtPaymentAdvice.ItemUpdating
    Dim Err As Boolean = False
    Dim msg As String = ""
    Dim BPID As String = e.NewValues("BPID")
    Dim SupplierName As String = e.NewValues("SupplierName")
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
