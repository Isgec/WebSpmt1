Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtNewUnLinkedSBH
    Public Shadows Function GetEditable() As Boolean
      Dim mRet As Boolean = False
      Return mRet
    End Function
    Public Shadows Function GetDeleteable() As Boolean
      Dim mRet As Boolean = False
      Return mRet
    End Function
    Public Shadows ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shadows ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property SelectWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property SelectWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function SelectWF(ByVal IRNo As Int32, ByVal PrimaryKey As String) As SIS.SPMT.spmtNewUnLinkedSBH
      Dim aVal() As String = PrimaryKey.Split("|".ToCharArray)
      Dim AdviceNo As Integer = aVal(0)
      If Not BillAttached(IRNo, "J_SPMTNEWSB") Then
        Throw New Exception("Bill is NOT attached, First attach Bill in Supplier Bill.")
      End If
      Dim Results As SIS.SPMT.spmtNewUnLinkedSBH = spmtNewUnLinkedSBHGetByID(IRNo)
      With Results
        .AdviceNo = AdviceNo
      End With
      SIS.SPMT.spmtNewUnLinkedSBH.UpdateData(Results)
      SIS.SPMT.spmtNewPA.ValidateAdvice(AdviceNo)
      Return Results
    End Function
    Public Shared Function BillAttached(ByVal Index As String, ByVal Handle As String) As Boolean
      Dim mRet As Boolean = False
      Dim cnt As Integer = 0
      Dim Sql As String = ""
      Sql &= " select isnull(count(t_indx),0) "
      Sql &= " from ttcisg132200"
      Sql &= " where t_hndl='" & Handle & "' "
      Sql &= " and t_indx='" & Index & "'"
      Sql &= ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          cnt = Cmd.ExecuteScalar
        End Using
      End Using
      If cnt > 0 Then mRet = True
      Return mRet
    End Function
    Public Shared Function UZ_spmtNewUnLinkedSBHSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal SupplierName As String) As List(Of SIS.SPMT.spmtNewUnLinkedSBH)
      Dim Results As List(Of SIS.SPMT.spmtNewUnLinkedSBH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_NewUnLinkedSBHSelectListSearch"
            Cmd.CommandText = "spspmtNewUnLinkedSBHSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_NewUnLinkedSBHSelectListFilteres"
            Cmd.CommandText = "spspmtNewUnLinkedSBHSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_SupplierName", SqlDbType.NVarChar, 100, IIf(SupplierName Is Nothing, String.Empty, SupplierName))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewUnLinkedSBH)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewUnLinkedSBH(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtNewUnLinkedSBHUpdate(ByVal Record As SIS.SPMT.spmtNewUnLinkedSBH) As SIS.SPMT.spmtNewUnLinkedSBH
      Dim _Result As SIS.SPMT.spmtNewUnLinkedSBH = spmtNewUnLinkedSBHUpdate(Record)
      Return _Result
    End Function
  End Class
End Namespace
