Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class SPMTerpDCDS
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Black
      Select Case FK_SPMT_erpDCDS_SerialNo.LineType
        Case spmtLineTypes.DirectInventory
          mRet = Drawing.Color.DarkGoldenrod
        Case spmtLineTypes.CompositInventory
          mRet = Drawing.Color.Purple
        Case spmtLineTypes.LockedNewRecord, spmtLineTypes.LockedDirectInventory, spmtLineTypes.LockedCompositInventory
          mRet = Drawing.Color.Green
      End Select
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
      Select Case FK_SPMT_erpDCDS_ChallanID.StatusID
        Case spmtDHStates.Cancelled, spmtDHStates.Created, spmtDHStates.ReturnedBackToConsigner, spmtDHStates.ReturnedBackToIsgec
          mRet = True
      End Select
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = False
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
    Public ReadOnly Property RejectWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
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
    Public Shared Function RejectWF(ByVal ChallanID As String, ByVal SerialNo As Int32, ByVal SourceNo As Int32) As SIS.SPMT.SPMTerpDCDS
      Dim DCH As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(ChallanID)
      Dim DCItem As SIS.SPMT.SPMTerpDCD = SIS.SPMT.SPMTerpDCD.SPMTerpDCDGetByID(ChallanID, SerialNo)
      Dim DCItemSource As SIS.SPMT.SPMTerpDCDS = SPMTerpDCDSGetByID(ChallanID, SerialNo, SourceNo)
      Select Case DCItem.LineType
        Case spmtLineTypes.NewRecord
          'NewRecord will not have any Source
        Case spmtLineTypes.DirectInventory
          '============Common Part====================
          Dim StockItem As SIS.SPMT.SPMTerpDCInventory = SIS.SPMT.SPMTerpDCInventory.SPMTerpDCInventoryGetByID(DCItemSource.S_ChallanID, DCItemSource.S_SerialNo)
          If StockItem Is Nothing Then
            StockItem = New SIS.SPMT.SPMTerpDCInventory
            StockItem = SIS.SYS.Utilities.SessionManager.GetObj(DCItemSource, StockItem)
            With StockItem
              .ChallanID = DCItemSource.S_ChallanID
              .SerialNo = DCItemSource.S_SerialNo
              .ProjectID = DCH.ProjectID
              .ConsignerBPID = DCH.ConsignerBPID
              .ConsignerGSTIN = DCH.ConsignerGSTIN
              .ConsignerGSTINNo = DCH.ConsignerGSTINNo
              .ConsignerIsgecID = DCH.ConsignerIsgecID
              .ConsignerName = DCH.ConsignerName
              .ConsignerStateID = DCH.ConsignerStateID
            End With
            StockItem = SIS.SPMT.SPMTerpDCInventory.InsertData(StockItem)
          Else
            With StockItem
              .QuantityUsed = .QuantityUsed - DCItemSource.Quantity
            End With
            StockItem = SIS.SPMT.SPMTerpDCInventory.UpdateData(StockItem)
          End If
          SIS.SPMT.SPMTerpDCDS.SPMTerpDCDSDelete(DCItemSource)
          '=============End Common====================
          DCItem.LineType = spmtLineTypes.NewRecord
          DCItem.BaseRate = 0.0000
          DCItem.FinalAmount = DCItem.TotalAmount + DCItem.BaseRate
          DCItem.FinalRate = DCItem.FinalAmount / DCItem.Quantity

          SIS.SPMT.SPMTerpDCD.UpdateData(DCItem)
        Case spmtLineTypes.CompositInventory
          '============Common Part====================
          Dim StockItem As SIS.SPMT.SPMTerpDCInventory = SIS.SPMT.SPMTerpDCInventory.SPMTerpDCInventoryGetByID(DCItemSource.S_ChallanID, DCItemSource.S_SerialNo)
          If StockItem Is Nothing Then
            StockItem = New SIS.SPMT.SPMTerpDCInventory
            StockItem = SIS.SYS.Utilities.SessionManager.GetObj(DCItemSource, StockItem)
            With StockItem
              .ChallanID = DCItemSource.S_ChallanID
              .SerialNo = DCItemSource.S_SerialNo
              .ProjectID = DCH.ProjectID
              .ConsignerBPID = DCH.ConsignerBPID
              .ConsignerGSTIN = DCH.ConsignerGSTIN
              .ConsignerGSTINNo = DCH.ConsignerGSTINNo
              .ConsignerIsgecID = DCH.ConsignerIsgecID
              .ConsignerName = DCH.ConsignerName
              .ConsignerStateID = DCH.ConsignerStateID
            End With
            StockItem = SIS.SPMT.SPMTerpDCInventory.InsertData(StockItem)
          Else
            With StockItem
              .QuantityUsed = .QuantityUsed - DCItemSource.Quantity
            End With
            StockItem = SIS.SPMT.SPMTerpDCInventory.UpdateData(StockItem)
          End If
          SIS.SPMT.SPMTerpDCDS.SPMTerpDCDSDelete(DCItemSource)
          '=============End Common====================
          Dim DCItemSources As List(Of SIS.SPMT.SPMTerpDCDS) = SIS.SPMT.SPMTerpDCDS.UZ_SPMTerpDCDSSelectList(0, 99999, "", False, "", DCItem.ChallanID, DCItem.SerialNo)
          If DCItemSources.Count = 0 Then
            DCItem.LineType = spmtLineTypes.NewRecord
          End If
          '3. Update BaseRate [Amount]
          DCItem.BaseRate = SIS.SPMT.SPMTerpDCIPending.CalcDCItemBaseRate(DCItem.ChallanID, DCItem.SerialNo)
          DCItem.FinalAmount = DCItem.TotalAmount + DCItem.BaseRate
          DCItem.FinalRate = DCItem.FinalAmount / DCItem.Quantity
          DCItem = SIS.SPMT.SPMTerpDCD.UpdateData(DCItem)
      End Select
      Return DCItemSource
    End Function
    Public Shared Function UZ_SPMTerpDCDSSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ChallanID As String, ByVal SerialNo As Int32) As List(Of SIS.SPMT.SPMTerpDCDS)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCDS) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_SPMTerpDCDSSelectListSearch"
            Cmd.CommandText = "spSPMTerpDCDSSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_SPMTerpDCDSSelectListFilteres"
            Cmd.CommandText = "spSPMTerpDCDSSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ChallanID", SqlDbType.NVarChar, 20, IIf(ChallanID Is Nothing, String.Empty, ChallanID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_SerialNo", SqlDbType.Int, 10, IIf(SerialNo = Nothing, 0, SerialNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCDS)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCDS(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function UZ_SPMTerpDCDSUpdate(ByVal Record As SIS.SPMT.SPMTerpDCDS) As SIS.SPMT.SPMTerpDCDS
      Dim Rec As SIS.SPMT.SPMTerpDCDS = SIS.SPMT.SPMTerpDCDS.SPMTerpDCDSGetByID(Record.ChallanID, Record.SerialNo, Record.SourceNo)
      '1. Update Stock
      Dim StockItem As SIS.SPMT.SPMTerpDCInventory = SIS.SPMT.SPMTerpDCInventory.SPMTerpDCInventoryGetByID(Rec.S_ChallanID, Rec.S_SerialNo)
      If StockItem IsNot Nothing Then
        If (StockItem.QuantityUsed - Rec.Quantity + Record.Quantity) > StockItem.Quantity Then
          Throw New Exception("Quantity CAN NOT Exceede balance quantity")
        End If
        StockItem.QuantityUsed = StockItem.QuantityUsed - Rec.Quantity + Record.Quantity
        SIS.SPMT.SPMTerpDCInventory.UpdateData(StockItem)
      End If
      '2. Update Qty
      Rec.Quantity = Record.Quantity
      Rec = SIS.SPMT.SPMTerpDCDS.UpdateData(Rec)
      '3. Update BaseRate [Amount]
      Dim DCItem As SIS.SPMT.SPMTerpDCD = SIS.SPMT.SPMTerpDCD.SPMTerpDCDGetByID(Rec.ChallanID, Rec.SerialNo)
      DCItem.BaseRate = SIS.SPMT.SPMTerpDCIPending.CalcDCItemBaseRate(DCItem.ChallanID, DCItem.SerialNo)
      DCItem = SIS.SPMT.SPMTerpDCD.UpdateData(DCItem)

      Return Rec
    End Function

    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      On Error Resume Next
      With sender
        CType(.FindControl("F_SourceNo"), TextBox).Text = ""
        CType(.FindControl("F_ItemDescription"), TextBox).Text = ""
        CType(.FindControl("F_UOM"), Object).SelectedValue = ""
        CType(.FindControl("F_Quantity"), TextBox).Text = "0.0000"
        CType(.FindControl("F_QuantityUsed"), TextBox).Text = "0.0000"
        CType(.FindControl("F_AssessableValue"), TextBox).Text = "0.0000"
        CType(.FindControl("F_TotalGST"), TextBox).Text = "0.0000"
        CType(.FindControl("F_TotalAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_S_ChallanID"), TextBox).Text = ""
        CType(.FindControl("F_S_SerialNo"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CessAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CessRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_CGSTAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_FinalRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_FinalAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_ChallanID"), TextBox).Text = ""
        CType(.FindControl("F_ChallanID_Display"), Label).Text = ""
        CType(.FindControl("F_CGSTRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_BillTypeID"), Object).SelectedValue = ""
        CType(.FindControl("F_HSNSACCode"), TextBox).Text = ""
        CType(.FindControl("F_HSNSACCode_Display"), Label).Text = ""
        CType(.FindControl("F_SerialNo"), TextBox).Text = ""
        CType(.FindControl("F_SerialNo_Display"), Label).Text = ""
        CType(.FindControl("F_BaseRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_Price"), TextBox).Text = "0.0000"
        CType(.FindControl("F_SGSTRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_SGSTAmount"), TextBox).Text = "0.0000"
        CType(.FindControl("F_IGSTRate"), TextBox).Text = "0.0000"
        CType(.FindControl("F_IGSTAmount"), TextBox).Text = "0.0000"
      End With
      Return sender
    End Function
  End Class
End Namespace
