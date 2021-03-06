Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtDCLastNumber
    Public Property JobWorkPrefix As String = ""
    Public Property SupplyPrefix As String = ""
    Public Property ERPVoucherSeries As String = ""
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
      Dim mRet As Boolean = True
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
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function GetNextDCNo(ByVal DCType As String, ByVal IssuerGSTIN As String) As String
      Dim mRet As String = ""
      Dim Results As SIS.SPMT.spmtDCLastNumber = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select top 1 * from spmt_dclastnumber where active = 1"
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtDCLastNumber(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Select Case DCType
        Case "J"
          mRet = Results.JobWorkPrefix
        Case "S"
          mRet = Results.SupplyPrefix
      End Select
      mRet &= Results.ERPVoucherSeries
      mRet &= IssuerGSTIN.Substring(0, 2)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select right(isnull(max(challanid),'0000000000'),5) FROM SPMT_DCHeader where left(challanid,5)='" & mRet & "'"
          Dim tmp As String = Cmd.ExecuteScalar
          mRet &= (Convert.ToInt32(tmp) + 1).ToString.PadLeft(5, "0")
        End Using
      End Using
      Return mRet
    End Function
    'GetNextDCNo Discontinued on 12-02-2019
    Public Shared Function GetNextDCNo() As String
      Dim mRet As String = ""
      Dim Results As SIS.SPMT.spmtDCLastNumber = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select top 1 * from spmt_dclastnumber where active = 1"
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtDCLastNumber(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Results.LastNumber = Convert.ToInt32(Results.LastNumber) + 1
      Results = SIS.SPMT.spmtDCLastNumber.UpdateData(Results)
      mRet = "DC" & Right(Results.Year, 2) & Convert.ToInt32(Results.LastNumber).ToString.PadLeft(5, "0")
      Return mRet
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_NumberID"), TextBox).Text = ""
          CType(.FindControl("F_Description"), TextBox).Text = ""
          CType(.FindControl("F_LastNumber"), TextBox).Text = 0
          CType(.FindControl("F_Year"), TextBox).Text = 0
          CType(.FindControl("F_Active"), CheckBox).Checked = False
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
