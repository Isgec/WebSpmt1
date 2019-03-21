Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtNewDispSBD
    Inherits SIS.SPMT.spmtNewSBD
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewDispSBDGetNewRecord() As SIS.SPMT.spmtNewDispSBD
      Return New SIS.SPMT.spmtNewDispSBD()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewDispSBDSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32) As List(Of SIS.SPMT.spmtNewDispSBD)
      Dim Results As List(Of SIS.SPMT.spmtNewDispSBD) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtNewDispSBDSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtNewDispSBDSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IRNo",SqlDbType.Int,10, IIf(IRNo = Nothing, 0,IRNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewDispSBD)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewDispSBD(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtNewDispSBDSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32) As Integer
      Return RecordCount
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewDispSBDGetByID(ByVal IRNo As Int32, ByVal SerialNo As Int32) As SIS.SPMT.spmtNewDispSBD
      Dim Results As SIS.SPMT.spmtNewDispSBD = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBDSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,IRNo.ToString.Length, IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtNewDispSBD(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewDispSBDGetByID(ByVal IRNo As Int32, ByVal SerialNo As Int32, ByVal Filter_IRNo As Int32) As SIS.SPMT.spmtNewDispSBD
      Dim Results As SIS.SPMT.spmtNewDispSBD = SIS.SPMT.spmtNewDispSBD.spmtNewDispSBDGetByID(IRNo, SerialNo)
      Return Results
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      MyBase.New(Reader)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
