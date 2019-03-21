Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtNewUnLinkedSBH
    Inherits SIS.SPMT.spmtNewSBH
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewUnLinkedSBHGetNewRecord() As SIS.SPMT.spmtNewUnLinkedSBH
      Return New SIS.SPMT.spmtNewUnLinkedSBH()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewUnLinkedSBHSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal SupplierName As String) As List(Of SIS.SPMT.spmtNewUnLinkedSBH)
      Dim Results As List(Of SIS.SPMT.spmtNewUnLinkedSBH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtNewUnLinkedSBHSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtNewUnLinkedSBHSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_SupplierName",SqlDbType.NVarChar,100, IIf(SupplierName Is Nothing, String.Empty,SupplierName))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
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
    Public Shared Function spmtNewUnLinkedSBHSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal SupplierName As String) As Integer
      Return RecordCount
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewUnLinkedSBHGetByID(ByVal IRNo As Int32) As SIS.SPMT.spmtNewUnLinkedSBH
      Dim Results As SIS.SPMT.spmtNewUnLinkedSBH = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,IRNo.ToString.Length, IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtNewUnLinkedSBH(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewUnLinkedSBHGetByID(ByVal IRNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_BPID As String, ByVal Filter_SupplierName As String) As SIS.SPMT.spmtNewUnLinkedSBH
      Dim Results As SIS.SPMT.spmtNewUnLinkedSBH = SIS.SPMT.spmtNewUnLinkedSBH.spmtNewUnLinkedSBHGetByID(IRNo)
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtNewUnLinkedSBHUpdate(ByVal Record As SIS.SPMT.spmtNewUnLinkedSBH) As SIS.SPMT.spmtNewUnLinkedSBH
      Dim _Rec As SIS.SPMT.spmtNewUnLinkedSBH = SIS.SPMT.spmtNewUnLinkedSBH.spmtNewUnLinkedSBHGetByID(Record.IRNo)
      With _Rec
        .PurchaseType = Record.PurchaseType
        .TranTypeID = Record.TranTypeID
        .IsgecGSTIN = Record.IsgecGSTIN
        .BPID = Record.BPID
        .SupplierGSTIN = Record.SupplierGSTIN
        .SupplierName = Record.SupplierName
        .SupplierGSTINNumber = Record.SupplierGSTINNumber
        .ShipToState = Record.ShipToState
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .BillRemarks = Record.BillRemarks
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
        .ProjectID = Record.ProjectID
        .ElementID = Record.ElementID
        .EmployeeID = Record.EmployeeID
        .DepartmentID = Record.DepartmentID
        .CostCenterID = Record.CostCenterID
        .TotalBillAmount = Record.TotalBillAmount
      End With
      Return SIS.SPMT.spmtNewUnLinkedSBH.UpdateData(_Rec)
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      MyBase.New(Reader)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
