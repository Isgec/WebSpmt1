Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports OfficeOpenXml
Imports System.Web.Script.Serialization
Partial Class GF_spmtACProcessed
  Inherits SIS.SYS.GridBase
  Protected Sub GVspmtACProcessed_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtACProcessed.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        Dim RedirectUrl As String = TBLspmtACProcessed.EditUrl & "?AdviceNo=" & AdviceNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Savewf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        Dim tmpPA As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(AdviceNo)
        Dim tmpValue As String = ""
        If tmpPA.AdviceStatusID = 9 Then
          tmpValue = CType(GVspmtACProcessed.Rows(e.CommandArgument).FindControl("F_RemarksAC"), TextBox).Text
        End If
        If tmpPA.AdviceStatusID = 10 Then
          tmpValue = CType(GVspmtACProcessed.Rows(e.CommandArgument).FindControl("F_DocumentNo"), TextBox).Text
          tmpValue &= "|" & CType(GVspmtACProcessed.Rows(e.CommandArgument).FindControl("F_BaaNCompany"), TextBox).Text
          tmpValue &= "|" & CType(GVspmtACProcessed.Rows(e.CommandArgument).FindControl("F_BaaNLedger"), DropDownList).SelectedValue
        End If
        SIS.SPMT.spmtACProcessed.SaveWF(AdviceNo, tmpValue)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Cancelwf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtACProcessed.CancelWF(AdviceNo)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Lockwf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtACProcessed.LockWF(AdviceNo)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      End Try
    End If
    If e.CommandName.ToLower = "initiatewf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtACProcessed.InitiateWF(AdviceNo)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "approvewf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtACProcessed.ApproveWF(AdviceNo)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "rejectwf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtACProcessed.RejectWF(AdviceNo)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "completewf".ToLower Then
      Try
        Dim AdviceNo As Int32 = GVspmtACProcessed.DataKeys(e.CommandArgument).Values("AdviceNo")
        SIS.SPMT.spmtACProcessed.CompleteWF(AdviceNo)
        GVspmtACProcessed.DataBind()
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtACProcessed_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtACProcessed.Init
    DataClassName = "GspmtACProcessed"
    SetGridView = GVspmtACProcessed
  End Sub
  Protected Sub TBLspmtACProcessed_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtACProcessed.Init
    SetToolBar = TBLspmtACProcessed
  End Sub
  Protected Sub F_AdviceNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AdviceNo.TextChanged
    Session("F_AdviceNo") = F_AdviceNo.Text
    InitGridPage()
  End Sub
  Protected Sub F_TranTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_TranTypeID.SelectedIndexChanged
    Session("F_TranTypeID") = F_TranTypeID.SelectedValue
    InitGridPage()
  End Sub
  Protected Sub F_BPID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_BPID.TextChanged
    Session("F_BPID") = F_BPID.Text
    Session("F_BPID_Display") = F_BPID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_TranTypeID.SelectedValue = String.Empty
    If Not Session("F_TranTypeID") Is Nothing Then
      If Session("F_TranTypeID") <> String.Empty Then
        F_TranTypeID.SelectedValue = Session("F_TranTypeID")
      End If
    End If
    F_BPID_Display.Text = String.Empty
    If Not Session("F_BPID_Display") Is Nothing Then
      If Session("F_BPID_Display") <> String.Empty Then
        F_BPID_Display.Text = Session("F_BPID_Display")
      End If
    End If
    F_BPID.Text = String.Empty
    If Not Session("F_BPID") Is Nothing Then
      If Session("F_BPID") <> String.Empty Then
        F_BPID.Text = Session("F_BPID")
      End If
    End If
    Dim strScriptBPID As String = "<script type=""text/javascript""> " &
      "function ACEBPID_Selected(sender, e) {" &
      "  var F_BPID = $get('" & F_BPID.ClientID & "');" &
      "  var F_BPID_Display = $get('" & F_BPID_Display.ClientID & "');" &
      "  var retval = e.get_value();" &
      "  var p = retval.split('|');" &
      "  F_BPID.value = p[0];" &
      "  F_BPID_Display.innerHTML = e.get_text();" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BPID", strScriptBPID)
    End If
    Dim strScriptPopulatingBPID As String = "<script type=""text/javascript""> " &
      "function ACEBPID_Populating(o,e) {" &
      "  var p = $get('" & F_BPID.ClientID & "');" &
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" &
      "  p.style.backgroundRepeat= 'no-repeat';" &
      "  p.style.backgroundPosition = 'right';" &
      "  o._contextKey = '';" &
      "}" &
      "function ACEBPID_Populated(o,e) {" &
      "  var p = $get('" & F_BPID.ClientID & "');" &
      "  p.style.backgroundImage  = 'none';" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BPIDPopulating") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BPIDPopulating", strScriptPopulatingBPID)
    End If
    Dim validateScriptBPID As String = "<script type=""text/javascript"">" &
      "  function validate_BPID(o) {" &
      "    validated_FK_SPMT_PaymentAdvice_BPID_main = true;" &
      "    validate_FK_SPMT_PaymentAdvice_BPID(o);" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateBPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateBPID", validateScriptBPID)
    End If
    Dim validateScriptFK_SPMT_PaymentAdvice_BPID As String = "<script type=""text/javascript"">" &
      "  function validate_FK_SPMT_PaymentAdvice_BPID(o) {" &
      "    var value = o.id;" &
      "    var BPID = $get('" & F_BPID.ClientID & "');" &
      "    try{" &
      "    if(BPID.value==''){" &
      "      if(validated_FK_SPMT_PaymentAdvice_BPID.main){" &
      "        var o_d = $get(o.id +'_Display');" &
      "        try{o_d.innerHTML = '';}catch(ex){}" &
      "      }" &
      "    }" &
      "    value = value + ',' + BPID.value ;" &
      "    }catch(ex){}" &
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" &
      "    o.style.backgroundRepeat= 'no-repeat';" &
      "    o.style.backgroundPosition = 'right';" &
      "    PageMethods.validate_FK_SPMT_PaymentAdvice_BPID(value, validated_FK_SPMT_PaymentAdvice_BPID);" &
      "  }" &
      "  validated_FK_SPMT_PaymentAdvice_BPID_main = false;" &
      "  function validated_FK_SPMT_PaymentAdvice_BPID(result) {" &
      "    var p = result.split('|');" &
      "    var o = $get(p[1]);" &
      "    var o_d = $get(p[1]+'_Display');" &
      "    try{o_d.innerHTML = p[2];}catch(ex){}" &
      "    o.style.backgroundImage  = 'none';" &
      "    if(p[0]=='1'){" &
      "      o.value='';" &
      "      try{o_d.innerHTML = '';}catch(ex){}" &
      "      __doPostBack(o.id, o.value);" &
      "    }" &
      "    else" &
      "      __doPostBack(o.id, o.value);" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_SPMT_PaymentAdvice_BPID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_SPMT_PaymentAdvice_BPID", validateScriptFK_SPMT_PaymentAdvice_BPID)
    End If
  End Sub
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
End Class
