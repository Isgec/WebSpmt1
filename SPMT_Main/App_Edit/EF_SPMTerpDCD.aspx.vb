Imports System.Web.Script.Serialization
Partial Class EF_SPMTerpDCD
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
  Protected Sub ODSSPMTerpDCD_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSSPMTerpDCD.Selected
    Dim tmp As SIS.SPMT.SPMTerpDCD = CType(e.ReturnValue, SIS.SPMT.SPMTerpDCD)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
    LineType = tmp.LineType
  End Sub
  Protected Sub FVSPMTerpDCD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCD.Init
    DataClassName = "ESPMTerpDCD"
    SetFormView = FVSPMTerpDCD
  End Sub
  Protected Sub TBLSPMTerpDCD_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCD.Init
    SetToolBar = TBLSPMTerpDCD
  End Sub
  Protected Sub FVSPMTerpDCD_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVSPMTerpDCD.PreRender
    TBLSPMTerpDCD.EnableSave = Editable
    TBLSPMTerpDCD.EnableDelete = Deleteable
    Dim o As TextBox = Nothing
    Dim L As Label = Nothing
    Dim r As HtmlTableRow = Nothing
    Select Case LineType
      Case spmtLineTypes.NewRecord, spmtLineTypes.LockedNewRecord
        r = FVSPMTerpDCD.FindControl("rowBaseRate")
        r.Style.Add(HtmlTextWriterStyle.Display, "none")
        L = FVSPMTerpDCD.FindControl("L_Price")
        L.Text = "Bill Amount [Basic] : "
      Case spmtLineTypes.DirectInventory, spmtLineTypes.LockedDirectInventory
        L = FVSPMTerpDCD.FindControl("L_ItemDescription")
        L.Text = "Inventory Item : "
        L = FVSPMTerpDCD.FindControl("L_BaseRate")
        L.Text = "Base Rate : "
        L = FVSPMTerpDCD.FindControl("L_TotalAmountFormula")
        L.Text = "Total Amount = (Value Add Rate * Quantity) + Total GST"
        L = FVSPMTerpDCD.FindControl("L_FinalAmountFormula")
        L.Text = "Final Amount = Total Amount + (Base Rate * Quantity)"

        o = FVSPMTerpDCD.FindControl("F_ItemDescription")
        With o
          .CssClass = "dmytxt"
          .Enabled = False
        End With
        Dim x As LC_spmtERPUnits = FVSPMTerpDCD.FindControl("F_UOM")
        With x
          .CssClass = "dmytxt"
          .Enabled = False
        End With
      Case spmtLineTypes.CompositInventory, spmtLineTypes.LockedCompositInventory
        L = FVSPMTerpDCD.FindControl("L_TotalAmountFormula")
        L.Text = "Total Amount = (Value Add Rate * Quantity) + Total GST"
        L = FVSPMTerpDCD.FindControl("L_FinalAmountFormula")
        L.Text = "Final Amount = Total Amount + Base Amount"
    End Select

    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_SPMTerpDCD.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptSPMTerpDCD") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptSPMTerpDCD", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvSPMTerpDCDSCC As New gvBase
  Protected Sub GVSPMTerpDCDS_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSPMTerpDCDS.Init
    gvSPMTerpDCDSCC.DataClassName = "GSPMTerpDCDS"
    gvSPMTerpDCDSCC.SetGridView = GVSPMTerpDCDS
  End Sub
  Protected Sub TBLSPMTerpDCDS_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCDS.Init
    gvSPMTerpDCDSCC.SetToolBar = TBLSPMTerpDCDS
  End Sub
  Protected Sub GVSPMTerpDCDS_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVSPMTerpDCDS.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCDS.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim SerialNo As Int32 = GVSPMTerpDCDS.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim SourceNo As Int32 = GVSPMTerpDCDS.DataKeys(e.CommandArgument).Values("SourceNo")  
        Dim RedirectUrl As String = TBLSPMTerpDCDS.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo & "&SourceNo=" & SourceNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "rejectwf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCDS.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim SerialNo As Int32 = GVSPMTerpDCDS.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim SourceNo As Int32 = GVSPMTerpDCDS.DataKeys(e.CommandArgument).Values("SourceNo")
        SIS.SPMT.SPMTerpDCDS.RejectWF(ChallanID, SerialNo, SourceNo)
        FVSPMTerpDCD.DataBind()
        GVSPMTerpDCDS.DataBind()
        GVSPMTerpDCIPending.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub TBLSPMTerpDCDS_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLSPMTerpDCDS.AddClicked
    Dim ChallanID As String = CType(FVSPMTerpDCD.FindControl("F_ChallanID"),TextBox).Text
    Dim SerialNo As Int32 = CType(FVSPMTerpDCD.FindControl("F_SerialNo"),TextBox).Text
    TBLSPMTerpDCDS.AddUrl &= "?ChallanID=" & ChallanID
    TBLSPMTerpDCDS.AddUrl &= "&SerialNo=" & SerialNo
  End Sub
  Private WithEvents gvSPMTerpDCIPendingCC As New gvBase
  Protected Sub GVSPMTerpDCIPending_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSPMTerpDCIPending.Init
    gvSPMTerpDCIPendingCC.DataClassName = "GSPMTerpDCIPending"
    gvSPMTerpDCIPendingCC.SetGridView = GVSPMTerpDCIPending
  End Sub
  Protected Sub TBLSPMTerpDCIPending_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCIPending.Init
    gvSPMTerpDCIPendingCC.SetToolBar = TBLSPMTerpDCIPending
  End Sub
  Protected Sub GVSPMTerpDCIPending_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVSPMTerpDCIPending.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim SerialNo As Int32 = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim RedirectUrl As String = TBLSPMTerpDCIPending.EditUrl & "?ChallanID=" & ChallanID & "&SerialNo=" & SerialNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "approvewf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim SerialNo As Int32 = GVSPMTerpDCIPending.DataKeys(e.CommandArgument).Values("SerialNo")
        Dim NewChallanID As String = FVSPMTerpDCD.DataKey("ChallanID")
        Dim NewSerialNo As Integer = FVSPMTerpDCD.DataKey("SerialNo")
        SIS.SPMT.SPMTerpDCIPending.ApproveWF(ChallanID, SerialNo, NewChallanID, NewSerialNo)
        GVSPMTerpDCDS.DataBind()
        GVSPMTerpDCIPending.DataBind()
        FVSPMTerpDCD.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function HSNSACCodeCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtHSNSACCodes.SelectspmtHSNSACCodesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_erpDCD_HSNSACCode(ByVal value As String) As String
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
