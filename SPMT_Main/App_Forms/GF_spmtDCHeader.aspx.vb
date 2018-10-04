
Imports System.Web.Script.Serialization
Partial Class GF_spmtDCHeader
  Inherits SIS.SYS.GridBase
  Protected Sub GVspmtDCHeader_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtDCHeader.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim RedirectUrl As String = TBLspmtDCHeader.EditUrl & "?ChallanID=" & ChallanID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "completewf".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.spmtDCHeader.CompleteWF(ChallanID)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Receiptwf".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.spmtDCHeader.ReceiptWF(ChallanID)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "CancelReceipt".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.spmtDCHeader.CancelReceipt(ChallanID)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "SaveReceipt".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim ReceivedDate As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_ReceivedDate"), TextBox).Text
        Dim Status As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_Status"), DropDownList).SelectedValue
        Dim ReceivedRemarks As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_ReceivedRemarks"), TextBox).Text
        SIS.SPMT.spmtDCHeader.SaveReceipt(ChallanID, ReceivedDate, Status, ReceivedRemarks)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Closurewf".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.spmtDCHeader.ClosureWF(ChallanID)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "CancelClosure".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.spmtDCHeader.CancelClosure(ChallanID)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "SaveClosure".ToLower Then
      Try
        Dim LinkedChallanID As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_LinkedChallanID"), TextBox).Text
        Dim DestinationIsgecID As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationIsgecID"), LC_spmtIsgecGSTIN).SelectedValue
        Dim DestinationBPID As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationBPID"), TextBox).Text
        Dim DestinationGSTIN As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationGSTIN"), TextBox).Text
        Dim DestinationName As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationName"), TextBox).Text
        Dim DestinationGSTINNo As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationGSTINNo"), TextBox).Text
        Dim DestinationAddress1Line As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationAddress1Line"), TextBox).Text
        Dim DestinationAddress2Line As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationAddress2Line"), TextBox).Text
        Dim DestinationAddress3Line As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationAddress3Line"), TextBox).Text
        Dim DestinationStateID As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_DestinationStateID"), LC_spmtERPStates).SelectedValue
        Dim ClosureRemarks As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_ClosureRemarks"), TextBox).Text
        Dim ClosureDate As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_ClosureDate"), TextBox).Text
        Dim SelectedStatus As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_CStatus"), DropDownList).SelectedValue
        Dim IsgecInvoiceNo As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_IsgecInvoiceNo"), TextBox).Text
        Dim IsgecInvoiceDate As String = CType(GVspmtDCHeader.Rows(e.CommandArgument).FindControl("F_IsgecInvoiceDate"), TextBox).Text
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.spmtDCHeader.SaveClosure(ChallanID, LinkedChallanID, DestinationIsgecID, DestinationBPID, DestinationGSTIN, DestinationName, DestinationGSTINNo, DestinationAddress1Line, DestinationAddress2Line, DestinationAddress3Line, DestinationStateID, ClosureRemarks, ClosureDate, SelectedStatus, IsgecInvoiceNo, IsgecInvoiceDate)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
        Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      End Try
    End If
  End Sub
  Protected Sub GVspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtDCHeader.Init
    DataClassName = "GspmtDCHeader"
    SetGridView = GVspmtDCHeader
  End Sub
  Protected Sub TBLspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCHeader.Init
    SetToolBar = TBLspmtDCHeader
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function LinkedChallanIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtDCHeader.SelectspmtDCHeaderAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_DCHeader_LinkedChallanID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim LinkedChallanID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtDCHeader = SIS.SPMT.spmtDCHeader.spmtDCHeaderGetByID(LinkedChallanID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function


  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function DestinationBPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_DCHeader_DestinationBPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim DestinationBPID As String = CType(aVal(1), String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(DestinationBPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function DestinationGSTINCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBPGSTIN.SelectspmtBPGSTINAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_DCHeader_DestinationGSTIN(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim DestinationBPID As String = CType(aVal(1), String)
    Dim DestinationGSTIN As Int32 = CType(aVal(2), Int32)
    Dim oVar As SIS.SPMT.spmtBPGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(DestinationBPID, DestinationGSTIN)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
End Class
