Partial Class EF_spmtDCDetails
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
  Protected Sub ODSspmtDCDetails_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtDCDetails.Selected
    Dim tmp As SIS.SPMT.spmtDCDetails = CType(e.ReturnValue, SIS.SPMT.spmtDCDetails)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCDetails.Init
    DataClassName = "EspmtDCDetails"
    SetFormView = FVspmtDCDetails
  End Sub
  Protected Sub TBLspmtDCDetails_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCDetails.Init
    SetToolBar = TBLspmtDCDetails
  End Sub
  Protected Sub FVspmtDCDetails_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtDCDetails.PreRender
    TBLspmtDCDetails.EnableSave = Editable
    TBLspmtDCDetails.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtDCDetails.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtDCDetails") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtDCDetails", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_DCDetails_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BillTypeID As String = CType(aVal(1), Int32)
    Dim HSNSACCode As String = CType(aVal(2),String)
    If BillTypeID = "" Then BillTypeID = 0
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillTypeID, HSNSACCode)
    If oVar Is Nothing Then
      SIS.SPMT.spmtSupplierBill.GetHSNSACCodeFromERP(BillTypeID, HSNSACCode)
      oVar = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillTypeID, HSNSACCode)
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

End Class
