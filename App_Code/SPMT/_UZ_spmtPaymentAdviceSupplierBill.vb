Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtPaymentAdviceSupplierBill
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
    Public ReadOnly Property RejectWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          mRet = Me.FK_SPMT_SupplierBill_AdviceNo.BillSelectable
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property RejectWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function RejectWF(ByVal IRNo As Int32, ByVal AdviceNo As Integer) As SIS.SPMT.spmtPaymentAdviceSupplierBill
      Dim Results As SIS.SPMT.spmtPaymentAdviceSupplierBill = spmtPaymentAdviceSupplierBillGetByID(IRNo)
      With Results
        .AdviceNo = ""
        .BillStatusID = 4
        .LogisticLinked = False
      End With
      SIS.SPMT.spmtPaymentAdviceSupplierBill.UpdateData(Results)
      SIS.SPMT.spmtPaymentAdvice.ValidateAdvice(AdviceNo)
      Return Results
    End Function
    Public Shared Function UZ_spmtPaymentAdviceSupplierBillSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32) As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill)
      Dim Results As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_PaymentAdviceSupplierBillSelectListSearch"
            'Cmd.CommandText = "spspmtPaymentAdviceSupplierBillSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_PaymentAdviceSupplierBillSelectListFilteres"
            'Cmd.CommandText = "spspmtPaymentAdviceSupplierBillSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo",SqlDbType.Int,10, IIf(AdviceNo = Nothing, 0,AdviceNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtPaymentAdviceSupplierBill(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtPaymentAdviceSupplierBillUpdate(ByVal Record As SIS.SPMT.spmtPaymentAdviceSupplierBill) As SIS.SPMT.spmtPaymentAdviceSupplierBill
      Dim _Result As SIS.SPMT.spmtPaymentAdviceSupplierBill = spmtPaymentAdviceSupplierBillUpdate(Record)
      Return _Result
    End Function
  End Class
End Namespace
