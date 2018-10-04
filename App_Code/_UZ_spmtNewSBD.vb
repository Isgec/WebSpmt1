Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtNewSBD
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
      If FK_SPMT_newSBD_IRNo.AdviceNo = "" Then
        mRet = True
      End If
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = False
      If FK_SPMT_newSBD_IRNo.AdviceNo = "" Then
        mRet = True
      End If
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
    Public Shared Function UZ_spmtNewSBDSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32) As List(Of SIS.SPMT.spmtNewSBD)
      Dim Results As List(Of SIS.SPMT.spmtNewSBD) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_NewSBDSelectListSearch"
            Cmd.CommandText = "spspmtNewSBDSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_NewSBDSelectListFilteres"
            Cmd.CommandText = "spspmtNewSBDSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IRNo",SqlDbType.Int,10, IIf(IRNo = Nothing, 0,IRNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewSBD)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewSBD(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtNewSBDInsert(ByVal Record As SIS.SPMT.spmtNewSBD) As SIS.SPMT.spmtNewSBD
      Dim _Result As SIS.SPMT.spmtNewSBD = spmtNewSBDInsert(Record)
      SIS.SPMT.spmtNewSBH.ValidateSBH(Record.IRNo)
      Return _Result
    End Function
    Public Shared Function UZ_spmtNewSBDUpdate(ByVal Record As SIS.SPMT.spmtNewSBD) As SIS.SPMT.spmtNewSBD
      Dim _Result As SIS.SPMT.spmtNewSBD = spmtNewSBDUpdate(Record)
      SIS.SPMT.spmtNewSBH.ValidateSBH(Record.IRNo)
      Return _Result
    End Function
    Public Shared Function UZ_spmtNewSBDDelete(ByVal Record As SIS.SPMT.spmtNewSBD) As Integer
      Dim _Result as Integer = spmtNewSBDDelete(Record)
      SIS.SPMT.spmtNewSBH.ValidateSBH(Record.IRNo)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      On Error Resume Next
      With sender
        CType(.FindControl("F_IRNo"), TextBox).Text = ""
        CType(.FindControl("F_IRNo_Display"), Label).Text = ""
        CType(.FindControl("F_SerialNo"), TextBox).Text = ""
        CType(.FindControl("F_ItemDescription"), TextBox).Text = ""
        CType(.FindControl("F_BillType"), Object).SelectedValue = ""
        CType(.FindControl("F_HSNSACCode"), TextBox).Text = ""
        CType(.FindControl("F_HSNSACCode_Display"), Label).Text = ""
        CType(.FindControl("F_UOM"), Object).SelectedValue = "nos"
        CType(.FindControl("F_Quantity"), TextBox).Text = "1.00"
        CType(.FindControl("F_Currency"), DropDownList).SelectedValue = "INR"
        CType(.FindControl("F_ConversionFactorINR"), TextBox).Text = "1.000000"
        CType(.FindControl("F_AssessableValue"), TextBox).Text = "0.00"
        CType(.FindControl("F_IGSTRate"), TextBox).Text = "0.00"
        CType(.FindControl("F_IGSTAmount"), TextBox).Text = "0.00"
        CType(.FindControl("F_SGSTRate"), TextBox).Text = "0.00"
        CType(.FindControl("F_SGSTAmount"), TextBox).Text = "0.00"
        CType(.FindControl("F_CGSTRate"), TextBox).Text = "0.00"
        CType(.FindControl("F_CGSTAmount"), TextBox).Text = "0.00"
        CType(.FindControl("F_CessRate"), TextBox).Text = "0.00"
        CType(.FindControl("F_CessAmount"), TextBox).Text = "0.00"
        CType(.FindControl("F_TotalGST"), TextBox).Text = "0.00"
        CType(.FindControl("F_TotalAmount"), TextBox).Text = "0.00"
        CType(.FindControl("F_TotalGSTINR"), TextBox).Text = "0.00"
        CType(.FindControl("F_TotalAmountINR"), TextBox).Text = "0.00"
        CType(.FindControl("F_DepartmentID"), Object).SelectedValue = ""
      End With
      Return sender
    End Function
  End Class
End Namespace
