Imports System.Web.Script.Serialization
Partial Class GF_SPMTerpDCH_M
  Inherits SIS.SYS.GridBase
  Protected Sub GVSPMTerpDCH_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVSPMTerpDCH.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCH.DataKeys(e.CommandArgument).Values("ChallanID")
        Dim RedirectUrl As String = TBLSPMTerpDCH.EditUrl & "?ChallanID=" & ChallanID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "initiatewf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCH.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.SPMTerpDCH.InitiateWF(ChallanID)
        GVSPMTerpDCH.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "approvewf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCH.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.SPMTerpDCH.ApproveWF(ChallanID)
        GVSPMTerpDCH.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "rejectwf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCH.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.SPMTerpDCH.RejectWF(ChallanID)
        GVSPMTerpDCH.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "completewf".ToLower Then
      Try
        Dim ChallanID As String = GVSPMTerpDCH.DataKeys(e.CommandArgument).Values("ChallanID")
        SIS.SPMT.SPMTerpDCH.CompleteWF(ChallanID)
        GVSPMTerpDCH.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub GVSPMTerpDCH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSPMTerpDCH.Init
    DataClassName = "GSPMTerpDCH"
    SetGridView = GVSPMTerpDCH
  End Sub
  Protected Sub TBLSPMTerpDCH_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLSPMTerpDCH.Init
    SetToolBar = TBLSPMTerpDCH
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub

  Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click
    If I_ChallanID.Text = "" Then Exit Sub
    ''Dim aChl() As String = {"2009J0224", "2009J0225", "2009J0226", "2009J0227", "2009J0228", "2009J0229", "2009J0230", "2009J0231", "2009J0232", "2009J0233", "2009J0234", "2009J0235", "2009J0237", "2009J0238", "2009J0239", "2009J0240", "2009J0241", "2009J0242", "2009J0243", "2009J0244", "2009J0245", "2009J0246", "2009J0247", "2009J0248", "2009J0249", "2009J0250", "2009J0251", "2009J0252", "2009J0253", "2009J0254", "2009J0255", "2009J0256", "2009J0257", "2009J0258", "2009J0259", "2009J0260", "2009J0261", "2009J0262", "2009J0263", "2009J0264", "2009J0265", "2009J0266", "2018J0015", "2018J0016", "2018J0017", "2018J0018", "2018J0019", "2018J0020", "2018J0021", "2018J0022", "2018J0023", "2018J0024", "2021J0134", "2021J0135", "2021J0150", "2021J0151", "2021J0152", "2021J0153", "2021J0154", "2021J0155", "2021J0156", "2021J0157", "2021J0158", "2021J0159", "2021J0160", "2021J0161", "2021J0162", "2021J0163", "2021J0165", "2021J0166", "2021J0167", "2021J0168", "2021J0169", "2021J0170", "2021J0171", "2021J0172", "2021J0173", "2021J0174", "2021J0175", "2021J0176", "2021J0177", "2021J0178", "2021J0179", "2021J0180", "2021J0181", "2021J0185", "2021J0186", "2021J0187", "2021J0188", "2021J0189", "2021J0190", "2021J0191", "2021J0192", "2021J0193", "2021J0194", "2021J0195", "2021J0196", "2021J0197", "2021J0198", "2021J0199", "2021J0200", "2021J0201", "2021J0202", "2021J0203", "2021J0204", "2021J0205", "2021J0206", "2021J0207", "2021J0208", "2021J0209", "2021J0210", "2021J0211", "2021J0212", "2021J0213", "2021J0214", "2021J0215", "2021J0216", "2021J0217", "2021J0218", "2021J0219", "2021J0220", "2021J0221", "2021J0222", "2021J0223", "2021J0224", "2021J0225", "2021J0226", "2021J0227", "2021J0228", "2021J0229", "2021J0230", "2021J0231", "2021J0232", "2021J0233", "2021J0234", "2021J0235", "2021J0236", "2021J0237", "2021J0238", "2021J0239", "2021J0240", "2021J0241", "2021J0242", "2021J0243", "2021J0244", "2021J0245", "2021J0246", "2021J0247", "2021J0248", "2021J0249", "2021J0250", "2021J0251", "2021J0252", "2021J0253", "2021J0254", "2021J0255", "2021J0256", "2021J0257", "2021J0258", "2021J0259", "2021J0260", "2021J0261", "2021J0262", "2021J0263", "2021J0264", "2021J0265", "2021J0266", "2021J0267", "2021J0268", "2021J0269", "2021J0270", "2021J0271", "2021J0272", "2021J0273", "2021J0274", "2023J0009", "2023J0010", "2023J0011", "2023J0012", "2023J0013", "2023J0014", "2023J0015", "2023J0016", "2023J0017", "2024J0001", "2027J0014", "20290001", "2029J0026", "2029J0027", "2029J0028", "2029J0029", "2029J0030", "2029J0031", "2029J0032", "2029J0033", "2029J0034", "2029J0035", "2029J0036", "2029J0037", "2029J0038", "2029J0039", "2029J0040", "2029J0041", "2029J0042", "2029J0043", "2029J0044", "2029J0045", "2029J0046", "2029J0047", "2029J0048", "2029J0049", "2029J0050", "2029J0051", "2029J0052", "2029J0053", "20J0012", "20J0013", "20J0014"}
    'Dim aChl() As String = {"20J0012", "20J0013", "20J0014"}
    'For Each str As String In aChl
    '  Try
    '    SIS.SPMT.SPMTerpDCH.ImportDC(str, "200")
    '  Catch ex As Exception
    '    ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
    '  End Try
    'Next
    Try
      SIS.SPMT.SPMTerpDCH.ImportDC(I_ChallanID.Text.ToUpper, HttpContext.Current.Session("FinanceCompany"))
      GVSPMTerpDCH.DataBind()
    Catch ex As Exception
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
    End Try
  End Sub

  Private Sub cmdxImport_Click(sender As Object, e As EventArgs) Handles cmdxImport.Click
    If F_FromDate.Text = "" OrElse F_ToDate.Text = "" Then Exit Sub
    Dim Errs As New List(Of SIS.SPMT.erpDCHList)
    Dim Challans As List(Of SIS.SPMT.erpDCHList) = SIS.SPMT.SPMTerpDCH.ChallanListFromERP(F_FromDate.Text, F_ToDate.Text, HttpContext.Current.Session("FinanceCompany"))
    For Each str As SIS.SPMT.erpDCHList In Challans
      Try
        SIS.SPMT.SPMTerpDCH.ImportDC(str.ChallanID.ToUpper, HttpContext.Current.Session("FinanceCompany"))
      Catch ex As Exception
        str.ErrMsg = ex.Message
        Errs.Add(str)
      End Try
    Next
    GVSPMTerpDCH.DataBind()
    Dim eStr As String = ""
    If Errs.Count > 0 Then
      eStr = "Import Process Completed" & vbCrLf
      For Each x As SIS.SPMT.erpDCHList In Errs
        eStr &= "Project:" & x.ProjectID & " " & x.ErrMsg & vbCrLf
      Next
      eStr &= Challans.Count - Errs.Count & " Challans Imported Successfully."
    Else
      eStr = Challans.Count & " Challans Imported Successfully."
    End If
    ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(eStr) & "');", True)
  End Sub
End Class
