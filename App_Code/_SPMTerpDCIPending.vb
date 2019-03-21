Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class SPMTerpDCIPending
    Inherits SIS.SPMT.SPMTerpDCInventory
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCIPendingGetNewRecord() As SIS.SPMT.SPMTerpDCIPending
      Return New SIS.SPMT.SPMTerpDCIPending()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCIPendingSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ChallanID As String) As List(Of SIS.SPMT.SPMTerpDCIPending)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCIPending) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spSPMTerpDCIPendingSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spSPMTerpDCIPendingSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ChallanID",SqlDbType.NVarChar,20, IIf(ChallanID Is Nothing, String.Empty,ChallanID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCIPending)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCIPending(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SPMTerpDCIPendingSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ChallanID As String) As Integer
      Return RecordCount
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCIPendingGetByID(ByVal ChallanID As String, ByVal SerialNo As Int32) As SIS.SPMT.SPMTerpDCIPending
      Dim Results As SIS.SPMT.SPMTerpDCIPending = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCInventorySelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID",SqlDbType.NVarChar,ChallanID.ToString.Length, ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.SPMTerpDCIPending(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCIPendingGetByID(ByVal ChallanID As String, ByVal SerialNo As Int32, ByVal Filter_ChallanID As String) As SIS.SPMT.SPMTerpDCIPending
      Dim Results As SIS.SPMT.SPMTerpDCIPending = SIS.SPMT.SPMTerpDCIPending.SPMTerpDCIPendingGetByID(ChallanID, SerialNo)
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function SPMTerpDCIPendingInsert(ByVal Record As SIS.SPMT.SPMTerpDCIPending) As SIS.SPMT.SPMTerpDCIPending
      Dim _Rec As SIS.SPMT.SPMTerpDCIPending = SIS.SPMT.SPMTerpDCIPending.SPMTerpDCIPendingGetNewRecord()
      With _Rec
        .ChallanID = Record.ChallanID
        .ItemDescription = Record.ItemDescription
        .BaseRate = Record.BaseRate
        .BillTypeID = Record.BillTypeID
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .Quantity = Record.Quantity
        .Price = Record.Price
        .AssessableValue = Record.AssessableValue
        .IGSTRate = Record.IGSTRate
        .IGSTAmount = Record.IGSTAmount
        .SGSTRate = Record.SGSTRate
        .SGSTAmount = Record.SGSTAmount
        .CGSTRate = Record.CGSTRate
        .CGSTAmount = Record.CGSTAmount
        .CessRate = Record.CessRate
        .CessAmount = Record.CessAmount
        .TotalGST = Record.TotalGST
        .TotalAmount = Record.TotalAmount
        .FinalRate = Record.FinalRate
        .FinalAmount = Record.FinalAmount
        .ConsignerIsgecID = Record.ConsignerIsgecID
        .ConsignerBPID = Record.ConsignerBPID
        .ConsignerGSTIN = Record.ConsignerGSTIN
        .ConsignerName = Record.ConsignerName
        .ConsignerGSTINNo = Record.ConsignerGSTINNo
        .ConsignerStateID = Record.ConsignerStateID
        .ProjectID = Record.ProjectID
        .QuantityUsed = Record.QuantityUsed
      End With
      Return SIS.SPMT.SPMTerpDCIPending.InsertData(_Rec)
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function SPMTerpDCIPendingUpdate(ByVal Record As SIS.SPMT.SPMTerpDCIPending) As SIS.SPMT.SPMTerpDCIPending
      Dim _Rec As SIS.SPMT.SPMTerpDCIPending = SIS.SPMT.SPMTerpDCIPending.SPMTerpDCIPendingGetByID(Record.ChallanID, Record.SerialNo)
      With _Rec
        .ItemDescription = Record.ItemDescription
        .BaseRate = Record.BaseRate
        .BillTypeID = Record.BillTypeID
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .Quantity = Record.Quantity
        .Price = Record.Price
        .AssessableValue = Record.AssessableValue
        .IGSTRate = Record.IGSTRate
        .IGSTAmount = Record.IGSTAmount
        .SGSTRate = Record.SGSTRate
        .SGSTAmount = Record.SGSTAmount
        .CGSTRate = Record.CGSTRate
        .CGSTAmount = Record.CGSTAmount
        .CessRate = Record.CessRate
        .CessAmount = Record.CessAmount
        .TotalGST = Record.TotalGST
        .TotalAmount = Record.TotalAmount
        .FinalRate = Record.FinalRate
        .FinalAmount = Record.FinalAmount
        .ConsignerIsgecID = Record.ConsignerIsgecID
        .ConsignerBPID = Record.ConsignerBPID
        .ConsignerGSTIN = Record.ConsignerGSTIN
        .ConsignerName = Record.ConsignerName
        .ConsignerGSTINNo = Record.ConsignerGSTINNo
        .ConsignerStateID = Record.ConsignerStateID
        .ProjectID = Record.ProjectID
        .QuantityUsed = Record.QuantityUsed
      End With
      Return SIS.SPMT.SPMTerpDCIPending.UpdateData(_Rec)
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      MyBase.New(Reader)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
