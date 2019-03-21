Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class SPMTerpDCIPending

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
    Public ReadOnly Property ApproveWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
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
    'Called from EF_DCH
    Public Shared Function ApproveWF(ByVal ChallanID As String, ByVal SerialNo As Int32, ByVal NewChallanID As String) As SIS.SPMT.SPMTerpDCIPending
      '1. Get the Stock Item
      Dim StockItem As SIS.SPMT.SPMTerpDCIPending = SIS.SPMT.SPMTerpDCIPending.SPMTerpDCIPendingGetByID(ChallanID, SerialNo)
      '2. Get New Challan
      Dim NewDCH As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(NewChallanID)
      '3. Create New Line 
      Dim DCItem As New SIS.SPMT.SPMTerpDCD
      '4. Update Values from selected Stock Item
      DCItem = SIS.SYS.Utilities.SessionManager.GetObj(StockItem, DCItem)
      '5.Assign Slecific values
      With DCItem
        .LineType = spmtLineTypes.DirectInventory
        .ChallanID = NewChallanID
        .SerialNo = 0
        .BaseRate = StockItem.FinalRate
        .Quantity = StockItem.QuantityBalance
        .t_rcno = NewDCH.t_rcno
        .t_srpo = NewDCH.t_srpo
        .t_srpl = NewDCH.t_srpl
        .Price = 0
        .AssessableValue = 0
        .IGSTRate = 0
        .IGSTAmount = 0
        .CGSTRate = 0
        .CGSTAmount = 0
        .SGSTRate = 0
        .SGSTAmount = 0
        .CessRate = 0
        .CessAmount = 0
        .TotalGST = 0
        .TotalAmount = 0
        .FinalAmount = .BaseRate * StockItem.QuantityBalance
        .FinalRate = .BaseRate
      End With
      '6. Insert DC Line
      DCItem = SIS.SPMT.SPMTerpDCD.InsertData(DCItem)
      '7. Create New Source
      Dim DCItemSource As New SIS.SPMT.SPMTerpDCDS
      '8. Update values from New Line Item
      DCItemSource = SIS.SYS.Utilities.SessionManager.GetObj(DCItem, DCItemSource)
      '9. Assign specific values
      With DCItemSource
        .SourceNo = 0
        .S_ChallanID = StockItem.ChallanID
        .S_SerialNo = StockItem.SerialNo
      End With
      '10. Insert Item Source
      DCItemSource = SIS.SPMT.SPMTerpDCDS.InsertData(DCItemSource)
      '11. Unpdate Stock Quantity
      With StockItem
        .QuantityUsed = .Quantity
      End With
      '12. Update Stock
      StockItem = SIS.SPMT.SPMTerpDCIPending.UpdateData(StockItem)
      '13. Refresh Both Grid.
      Return StockItem
    End Function
    'Called from EF_DCD
    Public Shared Function ApproveWF(ByVal ChallanID As String, ByVal SerialNo As Int32, ByVal NewChallanID As String, ByVal NewSerialNo As Integer) As SIS.SPMT.SPMTerpDCIPending
      Dim StockItem As SIS.SPMT.SPMTerpDCIPending = SIS.SPMT.SPMTerpDCIPending.SPMTerpDCIPendingGetByID(ChallanID, SerialNo)
      Dim NewDCH As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(NewChallanID)
      Dim DCItem As SIS.SPMT.SPMTerpDCD = SIS.SPMT.SPMTerpDCD.SPMTerpDCDGetByID(NewChallanID, NewSerialNo)
      Dim DCItemSource As New SIS.SPMT.SPMTerpDCDS
      DCItemSource = SIS.SYS.Utilities.SessionManager.GetObj(StockItem, DCItemSource)
      With DCItemSource
        .ChallanID = DCItem.ChallanID
        .SerialNo = DCItem.SerialNo
        .SourceNo = 0
        .Quantity = StockItem.QuantityBalance
        .S_ChallanID = StockItem.ChallanID
        .S_SerialNo = StockItem.SerialNo
      End With
      DCItemSource = SIS.SPMT.SPMTerpDCDS.InsertData(DCItemSource)
      With StockItem
        .QuantityUsed = .Quantity
      End With
      StockItem = SIS.SPMT.SPMTerpDCIPending.UpdateData(StockItem)
      With DCItem
        .LineType = spmtLineTypes.CompositInventory
        .BaseRate = CalcDCItemBaseRate(DCItem.ChallanID, DCItem.SerialNo)
        .FinalAmount = .TotalAmount + .BaseRate
        .FinalRate = .FinalAmount / .Quantity
      End With
      DCItem = SIS.SPMT.SPMTerpDCD.UpdateData(DCItem)
      Return StockItem
    End Function
    Public Shared Function CalcDCItemBaseRate(ByVal ChallanID As String, ByVal SerialNo As Integer) As Decimal
      Dim mRet As Decimal = 0.0000
      Dim SourceItems As List(Of SIS.SPMT.SPMTerpDCDS) = SIS.SPMT.SPMTerpDCDS.UZ_SPMTerpDCDSSelectList(0, 99999, "", False, "", ChallanID, SerialNo)
      For Each sItm As SIS.SPMT.SPMTerpDCDS In SourceItems
        Dim StockItem As SIS.SPMT.SPMTerpDCIPending = SIS.SPMT.SPMTerpDCIPending.SPMTerpDCIPendingGetByID(sItm.S_ChallanID, sItm.S_SerialNo)
        mRet += (StockItem.FinalRate * sItm.Quantity)
      Next
      Return mRet
    End Function
    Public Shared Function UZ_SPMTerpDCIPendingSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ChallanID As String) As List(Of SIS.SPMT.SPMTerpDCIPending)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCIPending) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_SPMTerpDCIPendingSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_SPMTerpDCIPendingSelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ChallanID", SqlDbType.NVarChar, 20, IIf(ChallanID Is Nothing, String.Empty, ChallanID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
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
  End Class
End Namespace
