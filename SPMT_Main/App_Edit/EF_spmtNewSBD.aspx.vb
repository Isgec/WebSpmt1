Imports System.Web.Script.Serialization
Partial Class EF_spmtNewSBD
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
  Protected Sub ODSspmtNewSBD_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewSBD.Selected
    Dim tmp As SIS.SPMT.spmtNewSBD = CType(e.ReturnValue, SIS.SPMT.spmtNewSBD)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtNewSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBD.Init
    DataClassName = "EspmtNewSBD"
    SetFormView = FVspmtNewSBD
  End Sub
  Protected Sub TBLspmtNewSBD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewSBD.Init
    SetToolBar = TBLspmtNewSBD
  End Sub
  Protected Sub FVspmtNewSBD_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewSBD.PreRender
    TBLspmtNewSBD.EnableSave = Editable
    TBLspmtNewSBD.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtNewSBD.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewSBD") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewSBD", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_SPMT_newSBD_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim BillType As String = CType(aVal(1), String)
    Dim HSNSACCode As String = CType(aVal(2), String)
    If BillType = "" Then BillType = 0
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillType, HSNSACCode)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetHSNSACCodeFromERP(BillType, HSNSACCode)
      oVar = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillType, HSNSACCode)
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

  Private Sub FVspmtNewSBD_ItemUpdating(sender As Object, e As FormViewUpdateEventArgs) Handles FVspmtNewSBD.ItemUpdating
    Dim Err As Boolean = False
    Dim msg As String = ""
    Try
      Dim IRNo As String = e.NewValues("IRNo")
      Dim oIR As SIS.SPMT.spmtNewSBH = SIS.SPMT.spmtNewSBH.spmtNewSBHGetByID(IRNo)
      Dim PurchaseType As String = oIR.PurchaseType
      Dim IGSTAmount As Decimal = e.NewValues("IGSTAmount")
      Dim SGSTAmount As Decimal = e.NewValues("SGSTAmount")
      Dim CGSTAmount As Decimal = e.NewValues("CGSTAmount")
      Dim BillType As String = e.NewValues("BillType")
      Dim HSNSACCode As String = e.NewValues("HSNSACCode")
      Select Case PurchaseType
        Case "Purchase from Registered Dealer", "Purchase from Composition Dealer"
          If IGSTAmount <= 0 Then
            If SGSTAmount = 0 Or CGSTAmount = 0 Then
              Err = True
              msg = "If IGST Amount is Zero then SGST Amount and CGST Amount both should be entered."
            End If
          Else
            If SGSTAmount > 0 Or CGSTAmount > 0 Then
              Err = True
              msg = "If IGST Amount is entered then SGST Amount and CGST Amount both should be zero."
            End If
          End If
          If BillType = "" Then
            Err = True
            msg = "Bill Type is Mandatory."
          End If
          If HSNSACCode = "" Then
            Err = True
            msg = "HSN / SAC Code is Mandatory."
          End If
        Case "Purchase from Unregistered Dealer"
          If BillType = "" Then
            Err = True
            msg = "Bill Type is Mandatory."
          End If
          If HSNSACCode = "" Then
            Err = True
            msg = "HSN / SAC Code is Mandatory."
          End If
        Case "Non GST expenses bill"
      End Select
    Catch ex As Exception
      Dim message As String = New JavaScriptSerializer().Serialize(ex.Message)
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End Try
    If Err Then
      Dim message As String = New JavaScriptSerializer().Serialize(msg)
      Dim script As String = String.Format("alert({0});", message)
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
      e.Cancel = True
    End If
  End Sub
End Class
