Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtUnlinkedSupplierBill
    Public Shadows ReadOnly Property Editable As Boolean
      Get
        Return False
      End Get
    End Property
    Public Shadows ReadOnly Property Deleteable As Boolean
      Get
        Return False
      End Get
    End Property
    Public ReadOnly Property ApproveWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          mRet = Me.FK_SPMT_SupplierBill_AdviceNo.BillSelectable
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ApproveWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function ApproveWF(ByVal IRNo As Int32, ByVal AdviceNo As Integer) As SIS.SPMT.spmtUnlinkedSupplierBill
      Dim Results As SIS.SPMT.spmtUnlinkedSupplierBill = spmtUnlinkedSupplierBillGetByID(IRNo)
      With Results
        .AdviceNo = AdviceNo
        .LogisticLinked = True
        .BillStatusID = 6
      End With
      SIS.SPMT.spmtUnlinkedSupplierBill.UpdateData(Results)
      SIS.SPMT.spmtPaymentAdvice.ValidateAdvice(AdviceNo)
      Return Results
    End Function
    Public Shared Function UZ_spmtUnlinkedSupplierBillSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal SupplierName As String) As List(Of SIS.SPMT.spmtUnlinkedSupplierBill)
      Dim Results As List(Of SIS.SPMT.spmtUnlinkedSupplierBill) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_UnlinkedSupplierBillSelectListSearch"
            Cmd.CommandText = "spspmtUnlinkedSupplierBillSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_UnlinkedSupplierBillSelectListFilteres"
            Cmd.CommandText = "spspmtUnlinkedSupplierBillSelectListFilteres"
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
          Results = New List(Of SIS.SPMT.spmtUnlinkedSupplierBill)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtUnlinkedSupplierBill(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtUnlinkedSupplierBillSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal SupplierName As String) As Integer
      Return RecordCount
    End Function
    Public Shared Function UZ_spmtUnlinkedSupplierBillUpdate(ByVal Record As SIS.SPMT.spmtUnlinkedSupplierBill) As SIS.SPMT.spmtUnlinkedSupplierBill
      Dim _Result As SIS.SPMT.spmtUnlinkedSupplierBill = spmtUnlinkedSupplierBillUpdate(Record)
      Return _Result
    End Function
  End Class
End Namespace
