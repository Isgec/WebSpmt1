Partial Class EF_spmtNewPA
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
  Protected Sub ODSspmtNewPA_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSspmtNewPA.Selected
    Dim tmp As SIS.SPMT.spmtNewPA = CType(e.ReturnValue, SIS.SPMT.spmtNewPA)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
  End Sub
  Protected Sub FVspmtNewPA_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewPA.Init
    DataClassName = "EspmtNewPA"
    SetFormView = FVspmtNewPA
  End Sub
  Protected Sub TBLspmtNewPA_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewPA.Init
    SetToolBar = TBLspmtNewPA
  End Sub
  Protected Sub FVspmtNewPA_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVspmtNewPA.PreRender
    TBLspmtNewPA.EnableSave = Editable
    TBLspmtNewPA.EnableDelete = Deleteable
    TBLspmtNewPA.PrintUrl &= Request.QueryString("AdviceNo") & "|"
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/SPMT_Main/App_Edit") & "/EF_spmtNewPA.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptspmtNewPA") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptspmtNewPA", mStr)
    End If
  End Sub
  Partial Class gvBase
    Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvspmtNewLinkedSBHCC As New gvBase
  Protected Sub GVspmtNewLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtNewLinkedSBH.Init
    gvspmtNewLinkedSBHCC.DataClassName = "GspmtNewLinkedSBH"
    gvspmtNewLinkedSBHCC.SetGridView = GVspmtNewLinkedSBH
  End Sub
  Protected Sub TBLspmtNewLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewLinkedSBH.Init
    gvspmtNewLinkedSBHCC.SetToolBar = TBLspmtNewLinkedSBH
  End Sub
  Protected Sub GVspmtNewLinkedSBH_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtNewLinkedSBH.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewLinkedSBH.DataKeys(e.CommandArgument).Values("IRNo")  
        Dim RedirectUrl As String = TBLspmtNewLinkedSBH.EditUrl & "?IRNo=" & IRNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Deletewf".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewLinkedSBH.DataKeys(e.CommandArgument).Values("IRNo")  
        SIS.SPMT.spmtNewLinkedSBH.DeleteWF(IRNo)
        GVspmtNewLinkedSBH.DataBind()
        GVspmtNewUnLinkedSBH.DataBind()
        FVspmtNewPA.DataBind()
      Catch ex As Exception
      End Try
    End If
  End Sub
  Private WithEvents gvspmtNewUnLinkedSBHCC As New gvBase
  Protected Sub GVspmtNewUnLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtNewUnLinkedSBH.Init
    gvspmtNewUnLinkedSBHCC.DataClassName = "GspmtNewUnLinkedSBH"
    gvspmtNewUnLinkedSBHCC.SetGridView = GVspmtNewUnLinkedSBH
  End Sub
  Protected Sub TBLspmtNewUnLinkedSBH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtNewUnLinkedSBH.Init
    gvspmtNewUnLinkedSBHCC.SetToolBar = TBLspmtNewUnLinkedSBH
  End Sub
  Protected Sub GVspmtNewUnLinkedSBH_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtNewUnLinkedSBH.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewUnLinkedSBH.DataKeys(e.CommandArgument).Values("IRNo")  
        Dim RedirectUrl As String = TBLspmtNewUnLinkedSBH.EditUrl & "?IRNo=" & IRNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "Selectwf".ToLower Then
      Try
        Dim IRNo As Int32 = GVspmtNewUnLinkedSBH.DataKeys(e.CommandArgument).Values("IRNo")
        SIS.SPMT.spmtNewUnLinkedSBH.SelectWF(IRNo, PrimaryKey)
        GVspmtNewUnLinkedSBH.DataBind()
        GVspmtNewLinkedSBH.DataBind()
        FVspmtNewPA.DataBind()
      Catch ex As Exception
      End Try
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function BPIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.SPMT.spmtBusinessPartner.SelectspmtBusinessPartnerAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ConcernedHODCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.COM.comEmployees.SelectcomEmployeesAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_newPA_ConcernedHOD(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim ConcernedHOD As String = CType(aVal(1),String)
    Dim oVar As SIS.COM.comEmployees = SIS.COM.comEmployees.comEmployeesGetByID(ConcernedHOD)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_SPMT_newPA_BPID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BPID As String = CType(aVal(1),String)
    Dim oVar As SIS.SPMT.spmtBusinessPartner = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(BPID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function

End Class
