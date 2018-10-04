Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtUnlinkedSupplierBill
    Inherits SIS.SPMT.spmtSupplierBill
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtUnlinkedSupplierBillGetNewRecord() As SIS.SPMT.spmtUnlinkedSupplierBill
      Return New SIS.SPMT.spmtUnlinkedSupplierBill()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtUnlinkedSupplierBillSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String) As List(Of SIS.SPMT.spmtUnlinkedSupplierBill)
      Dim Results As List(Of SIS.SPMT.spmtUnlinkedSupplierBill) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtUnlinkedSupplierBillSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtUnlinkedSupplierBillSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
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
    Public Shared Function spmtUnlinkedSupplierBillSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String) As Integer
      Return RecordCount
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtUnlinkedSupplierBillGetByID(ByVal IRNo As Int32) As SIS.SPMT.spmtUnlinkedSupplierBill
      Dim Results As SIS.SPMT.spmtUnlinkedSupplierBill = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,IRNo.ToString.Length, IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtUnlinkedSupplierBill(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtUnlinkedSupplierBillGetByID(ByVal IRNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_BPID As String) As SIS.SPMT.spmtUnlinkedSupplierBill
      Dim Results As SIS.SPMT.spmtUnlinkedSupplierBill = SIS.SPMT.spmtUnlinkedSupplierBill.spmtUnlinkedSupplierBillGetByID(IRNo)
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtUnlinkedSupplierBillUpdate(ByVal Record As SIS.SPMT.spmtUnlinkedSupplierBill) As SIS.SPMT.spmtUnlinkedSupplierBill
      Dim _Rec As SIS.SPMT.spmtUnlinkedSupplierBill = SIS.SPMT.spmtUnlinkedSupplierBill.spmtUnlinkedSupplierBillGetByID(Record.IRNo)
      With _Rec
        .TranTypeID = Record.TranTypeID
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .BillRemarks = Record.BillRemarks
        .IsgecGSTIN = Record.IsgecGSTIN
        .BPID = Record.BPID
        .SupplierGSTIN = Record.SupplierGSTIN
        .BillType = Record.BillType
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .ShipToState = Record.ShipToState
        .Quantity = Record.Quantity
        .AssessableValue = Record.AssessableValue
        .TaxAmount = Record.TaxAmount
        .CessRate = Record.CessRate
        .CessAmount = Record.CessAmount
        .TotalGST = Record.TotalGST
        .TotalAmount = Record.TotalAmount
        .RemarksGST = Record.RemarksGST
        .Currency = Record.Currency
        .ConversionFactorINR = Record.ConversionFactorINR
        .TotalAmountINR = Record.TotalAmountINR
        .PurchaseType = Record.PurchaseType
        .IGSTRate = Record.IGSTRate
        .IGSTAmount = Record.IGSTAmount
        .SGSTRate = Record.SGSTRate
        .SGSTAmount = Record.SGSTAmount
        .CGSTRate = Record.CGSTRate
        .CGSTAmount = Record.CGSTAmount
      End With
      Return SIS.SPMT.spmtUnlinkedSupplierBill.UpdateData(_Rec)
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      MyBase.New(Reader)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
