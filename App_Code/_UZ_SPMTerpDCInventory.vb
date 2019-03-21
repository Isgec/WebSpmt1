Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class SPMTerpDCInventory
    Public ReadOnly Property QuantityBalance As Decimal
      Get
        Return Quantity - QuantityUsed
      End Get
    End Property
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Blue
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEnable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEditable() As Boolean
      Dim mRet As Boolean = False
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = False
      Return mRet
    End Function
    Public ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function UZ_SPMTerpDCInventorySelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.SPMTerpDCInventory)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCInventory) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_SPMTerpDCInventorySelectListSearch"
            Cmd.CommandText = "spSPMTerpDCInventorySelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_SPMTerpDCInventorySelectListFilteres"
            Cmd.CommandText = "spSPMTerpDCInventorySelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCInventory)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCInventory(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function GetChallanInventory(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ChallanID As String) As List(Of SIS.SPMT.SPMTerpDCInventory)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCInventory) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmt_LG_GetChallanInventory"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ChallanID", SqlDbType.NVarChar, 20, IIf(ChallanID Is Nothing, String.Empty, ChallanID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCInventory)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCInventory(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      On Error Resume Next
      With sender
        CType(.FindControl("F_ChallanID"), TextBox).Text = ""
        CType(.FindControl("F_ChallanID_Display"), Label).Text = ""
        CType(.FindControl("F_SerialNo"), TextBox).Text = ""
        CType(.FindControl("F_ItemDescription"), TextBox).Text = ""
        CType(.FindControl("F_BaseRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_BillTypeID"), Object).SelectedValue = ""
        CType(.FindControl("F_HSNSACCode"), TextBox).Text = ""
        CType(.FindControl("F_HSNSACCode_Display"), Label).Text = ""
        CType(.FindControl("F_UOM"), Object).SelectedValue = ""
        CType(.FindControl("F_Quantity"), TextBox).Text = "0.0000"
        CType(.FindControl("F_Price"), TextBox).Text = "0.0000"
        CType(.FindControl("F_AssessableValue"), TextBox).Text = "0.0000"
        CType(.FindControl("F_IGSTRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_IGSTAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_SGSTRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_SGSTAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CGSTRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CGSTAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CessRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CessAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_TotalGST"), TextBox).Text = "0.0000"
        CType(.FindControl("F_TotalAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_FinalRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_FinalAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_ConsignerIsgecID"), Object).SelectedValue = ""
        CType(.FindControl("F_ConsignerBPID"), TextBox).Text = ""
        CType(.FindControl("F_ConsignerBPID_Display"), Label).Text = ""
        CType(.FindControl("F_ConsignerGSTIN"), TextBox).Text = ""
        CType(.FindControl("F_ConsignerGSTIN_Display"), Label).Text = ""
        CType(.FindControl("F_ConsignerName"), TextBox).Text = ""
        CType(.FindControl("F_ConsignerGSTINNo"), TextBox).Text = ""
        CType(.FindControl("F_ConsignerStateID"), Object).SelectedValue = ""
        CType(.FindControl("F_ProjectID"), TextBox).Text = ""
        CType(.FindControl("F_ProjectID_Display"), Label).Text = ""
      End With
      Return sender
    End Function
  End Class
End Namespace
