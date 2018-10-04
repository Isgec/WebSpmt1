Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Partial Class AF_spmtDCHeader
  Inherits SIS.SYS.InsertBase
  Protected Sub FVspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCHeader.Init
    DataClassName = "AspmtDCHeader"
    SetFormView = FVspmtDCHeader
  End Sub
  Protected Sub TBLspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCHeader.Init
    SetToolBar = TBLspmtDCHeader
  End Sub
  Protected Sub ODSspmtDCHeader_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtDCHeader.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.SPMT.spmtDCHeader = CType(e.ReturnValue, SIS.SPMT.spmtDCHeader)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&ChallanID=" & oDC.ChallanID
      TBLspmtDCHeader.AfterInsertURL &= tmpURL
    End If
  End Sub
  Protected Sub FVspmtDCHeader_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCHeader.DataBound
    SIS.SPMT.spmtDCHeader.SetDefaultValues(sender, e)
  End Sub
  Protected Sub FVspmtDCHeader_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCHeader.PreRender
    Dim oF_ProjectID_Display As Label = FVspmtDCHeader.FindControl("F_ProjectID_Display")
    Dim oF_ProjectID As TextBox = FVspmtDCHeader.FindControl("F_ProjectID")
    Dim oF_ConsignerBPID_Display As Label = FVspmtDCHeader.FindControl("F_ConsignerBPID_Display")
    Dim oF_ConsignerBPID As TextBox = FVspmtDCHeader.FindControl("F_ConsignerBPID")
    Dim oF_ConsigneeBPID_Display As Label = FVspmtDCHeader.FindControl("F_ConsigneeBPID_Display")
    Dim oF_ConsigneeBPID As TextBox = FVspmtDCHeader.FindControl("F_ConsigneeBPID")
    Dim oF_ConsignerGSTIN_Display As Label = FVspmtDCHeader.FindControl("F_ConsignerGSTIN_Display")
    Dim oF_ConsignerGSTIN As TextBox = FVspmtDCHeader.FindControl("F_ConsignerGSTIN")
    Dim oF_ConsigneeGSTIN_Display As Label = FVspmtDCHeader.FindControl("F_ConsigneeGSTIN_Display")
    Dim oF_ConsigneeGSTIN As TextBox = FVspmtDCHeader.FindControl("F_ConsigneeGSTIN")
    Dim oF_TransporterID_Display As Label = FVspmtDCHeader.FindControl("F_TransporterID_Display")
    Dim oF_TransporterID As TextBox = FVspmtDCHeader.FindControl("F_TransporterID")
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Create") & "/AF_spmtDCHeader.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCHeader") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCHeader", mStr)
    End If
    If Request.QueryString("ChallanID") IsNot Nothing Then
      CType(FVspmtDCHeader.FindControl("F_ChallanID"), TextBox).Text = Request.QueryString("ChallanID")
      CType(FVspmtDCHeader.FindControl("F_ChallanID"), TextBox).Enabled = False
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comProjects.SelectcomProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsignerBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsigneeBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsignerGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ConsigneeGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function TransporterIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_DCHeader_ProjectID(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_DCHeader_ConsignerGSTIN(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_DCHeader_ConsigneeGISTIN(ByVal value As String) As String
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
  Public Shared Function validate_FK_SPMT_DCHeader_ConsignerBPID(ByVal value As String) As String
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
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_DCHeader_TransporterID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim TransporterID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(TransporterID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_DCHeader_ConsigneeBPID(ByVal value As String) As String
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

  Private Sub FVspmtDCHeader_ItemCommand(sender As Object, e As FormViewCommandEventArgs) Handles FVspmtDCHeader.ItemCommand
    Select Case e.CommandName
      Case "IssuerIsgec"
        Dim x As LC_spmtIsgecGSTIN = CType(FVspmtDCHeader.FindControl("F_IssuerID"), LC_spmtIsgecGSTIN)
        Dim IsgecGSTINID As Integer = x.SelectedValue
        Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(IsgecGSTINID)
        With FVspmtDCHeader
          CType(.FindControl("F_IssuerCompanyName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_IssuerAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_IssuerAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_IssuerPAN"), TextBox).Text = oTmp.PAN
          CType(.FindControl("F_IssuerCIN"), TextBox).Text = oTmp.CIN
        End With
      Case "ConsignerIsgec"
        Dim x As LC_spmtIsgecGSTIN = CType(FVspmtDCHeader.FindControl("F_ConsignerIsgecID"), LC_spmtIsgecGSTIN)
        Dim IsgecGSTINID As Integer = x.SelectedValue
        Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(IsgecGSTINID)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsignerName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsignerAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsignerAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsignerAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerStateID"), LC_spmtERPStates).SelectedValue = oTmp.Description.Substring(0, 2)
        End With
      Case "ConsigneeIsgec"
        Dim x As LC_spmtIsgecGSTIN = CType(FVspmtDCHeader.FindControl("F_ConsigneeIsgecID"), LC_spmtIsgecGSTIN)
        Dim IsgecGSTINID As Integer = x.SelectedValue
        Dim oTmp As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(IsgecGSTINID)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsigneeName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsigneeAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsigneeAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsigneeAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeStateID"), LC_spmtERPStates).SelectedValue = oTmp.Description.Substring(0, 2)
        End With
      Case "ConsignerBPGstin"
        Dim BPID As String = CType(FVspmtDCHeader.FindControl("F_ConsignerBPID"), TextBox).Text
        Dim GSTIN As String = CType(FVspmtDCHeader.FindControl("F_ConsignerGSTIN"), TextBox).Text
        Dim oTmp As SIS.SPMT.BPAddress = SIS.SPMT.BPAddress.GetBPAddress(BPID, GSTIN)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsignerName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsignerGSTINNo"), TextBox).Text = oTmp.GSTIN
          CType(.FindControl("F_ConsignerAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsignerAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsignerAddress3Line"), TextBox).Text = oTmp.Address3Line
          CType(.FindControl("F_ConsignerStateID"), LC_spmtERPStates).SelectedValue = oTmp.StateID
        End With
      Case "ConsigneeBPGstin"
        Dim BPID As String = CType(FVspmtDCHeader.FindControl("F_ConsigneeBPID"), TextBox).Text
        Dim GSTIN As String = CType(FVspmtDCHeader.FindControl("F_ConsigneeGSTIN"), TextBox).Text
        Dim oTmp As SIS.SPMT.BPAddress = SIS.SPMT.BPAddress.GetBPAddress(BPID, GSTIN)
        With FVspmtDCHeader
          CType(.FindControl("F_ConsigneeName"), TextBox).Text = oTmp.CompanyName
          CType(.FindControl("F_ConsigneeGSTINNo"), TextBox).Text = oTmp.GSTIN
          CType(.FindControl("F_ConsigneeAddress1Line"), TextBox).Text = oTmp.Address1Line
          CType(.FindControl("F_ConsigneeAddress2Line"), TextBox).Text = oTmp.Address2Line
          CType(.FindControl("F_ConsigneeAddress3Line"), TextBox).Text = oTmp.Address3Line
          CType(.FindControl("F_ConsigneeStateID"), LC_spmtERPStates).SelectedValue = oTmp.StateID
        End With

    End Select
  End Sub

End Class
