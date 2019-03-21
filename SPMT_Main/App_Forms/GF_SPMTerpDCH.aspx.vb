Imports System.Web.Script.Serialization
Partial Class GF_SPMTerpDCH
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_SPMTerpDCH.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ChallanID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
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
End Class
