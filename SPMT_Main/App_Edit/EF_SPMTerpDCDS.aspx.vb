Imports System.Web.Script.Serialization
Partial Class EF_SPMTerpDCDS
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
  Public Property LineType As Integer
    Get
      If ViewState("LineType") IsNot Nothing Then
        Return CType(ViewState("LineType"), Integer)
      End If
      Return 0
    End Get
    Set(value As Integer)
      ViewState.Add("LineType", value)
    End Set
  End Property
  Protected Sub ODSSPMTerpDCDS_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSSPMTerpDCDS.Selected
    Dim tmp As SIS.SPMT.SPMTerpDCDS = CType(e.ReturnValue, SIS.SPMT.SPMTerpDCDS)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
    LineType = tmp.FK_SPMT_erpDCDS_SerialNo.LineType
  End Sub
  Protected Sub FVSPMTerpDCDS_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCDS.Init
    DataClassName = "ESPMTerpDCDS"
    SetFormView = FVSPMTerpDCDS
  End Sub
  Protected Sub TBLSPMTerpDCDS_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCDS.Init
    SetToolBar = TBLSPMTerpDCDS
  End Sub
  Protected Sub FVSPMTerpDCDS_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCDS.PreRender
    TBLSPMTerpDCDS.EnableSave = Editable
    TBLSPMTerpDCDS.EnableDelete = Deleteable
    Select Case LineType
      Case spmtLineTypes.DirectInventory
        Dim o As TextBox = FVSPMTerpDCDS.FindControl("F_Quantity")
        With o
          .CssClass = "dmytxt"
          .Enabled = False
        End With
        TBLSPMTerpDCDS.EnableSave = False
    End Select
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_SPMTerpDCDS.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCDS") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCDS", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCDS_HSNSACCode(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BillTypeID As Int32 = CType(aVal(1),Int32)
    Dim HSNSACCode As String = CType(aVal(2),String)
    Dim oVar As SIS.SPMT.spmtHSNSACCodes = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(BillTypeID,HSNSACCode)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function

End Class
