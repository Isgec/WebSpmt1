Imports System.Web.Script.Serialization
Partial Class AF_spmtNewPA
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtNewPA_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewPA.Init
    DataClassName = "AspmtNewPA"
    SetFormView = FVspmtNewPA
  End Sub
  Protected Sub TBLspmtNewPA_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewPA.Init
    SetToolBar = TBLspmtNewPA
  End Sub
  Protected Sub ODSspmtNewPA_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewPA.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.spmtNewPA = CType(e.ReturnValue, SIS.SPMT.spmtNewPA)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&AdviceNo=" & oDC.AdviceNo
      TBLspmtNewPA.AfterInsertURL &= tmpURL
    End If
  End Sub
  Protected Sub FVspmtNewPA_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewPA.DataBound
    SIS.SPMT.spmtNewPA.SetDefaultValues(sender, e)
  End Sub
  Protected Sub FVspmtNewPA_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewPA.PreRender
    Dim oF_TranTypeID As LC_spmtTranTypes = FVspmtNewPA.FindControl("F_TranTypeID")
    oF_TranTypeID.Enabled = True
    oF_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        oF_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    Dim oF_BPID_Display As Label = FVspmtNewPA.FindControl("F_BPID_Display")
    oF_BPID_Display.Text = String.Empty
    If Not Session("F_BPID_Display") Is Nothing Then
      If Session("F_BPID_Display") <> String.Empty Then
        oF_BPID_Display.Text = Session("F_BPID_Display")
      End If
    End If
    Dim oF_BPID As TextBox = FVspmtNewPA.FindControl("F_BPID")
    oF_BPID.Enabled = True
    oF_BPID.Text = String.Empty
    If Not Session("F_BPID") Is Nothing Then
      If Session("F_BPID") <> String.Empty Then
        oF_BPID.Text = Session("F_BPID")
      End If
    End If
    Dim oF_ConcernedHOD_Display As Label = FVspmtNewPA.FindControl("F_ConcernedHOD_Display")
    Dim oF_ConcernedHOD As TextBox = FVspmtNewPA.FindControl("F_ConcernedHOD")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtNewPA.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewPA") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewPA", mStr)
    End If
    If Request.QueryString("AdviceNo") IsNot Nothing Then
      CType(FVspmtNewPA.FindControl("F_AdviceNo"), TextBox).Text = Request.QueryString("AdviceNo")
      CType(FVspmtNewPA.FindControl("F_AdviceNo"), TextBox).Enabled = False
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
    Return SIS.COM.comEmployees.SelectcomEmployeesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newPA_ConcernedHOD(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ConcernedHOD As String = CType(aVal(1), String)
    Dim oVar As SIS.COM.comEmployees = SIS.COM.comEmployees.comEmployeesGetByID(ConcernedHOD)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newPA_BPID(ByVal value As String) As String
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

  Private Sub FVspmtNewPA_ItemInserting(sender As Object, e As FormViewInsertEventArgs) Handles FVspmtNewPA.ItemInserting
    If e.Values("BPID").ToString = String.Empty And e.Values("SupplierName").ToString = String.Empty Then
      Dim message As String = New JavaScriptSerializer().Serialize("Enter Supplier ID or Supplier Name.")
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End If
  End Sub
End Class
