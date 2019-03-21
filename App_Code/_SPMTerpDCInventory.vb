Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class SPMTerpDCInventory
    Private Shared _RecordCount As Integer
    Private _ChallanID As String = ""
    Private _SerialNo As Int32 = 0
    Private _ItemDescription As String = ""
    Private _BaseRate As Decimal = 0
    Private _BillTypeID As String = ""
    Private _HSNSACCode As String = ""
    Private _UOM As String = ""
    Private _Quantity As String = "0.0000"
    Private _QuantityUsed As String = "0.0000"
    Private _Price As String = "0.0000"
    Private _AssessableValue As String = "0.0000"
    Private _IGSTRate As String = "0.0000"
    Private _IGSTAmount As String = "0.0000"
    Private _SGSTRate As String = "0.0000"
    Private _SGSTAmount As String = "0.0000"
    Private _CGSTRate As String = "0.0000"
    Private _CGSTAmount As String = "0.0000"
    Private _CessRate As String = "0.0000"
    Private _CessAmount As String = "0.0000"
    Private _TotalGST As String = "0.0000"
    Private _TotalAmount As String = "0.0000"
    Private _FinalRate As String = "0.0000"
    Private _FinalAmount As String = "0.0000"
    Private _ConsignerIsgecID As String = ""
    Private _ConsignerBPID As String = ""
    Private _ConsignerGSTIN As String = ""
    Private _ConsignerName As String = ""
    Private _ConsignerGSTINNo As String = ""
    Private _ConsignerStateID As String = ""
    Private _ProjectID As String = ""
    Private _IDM_Projects1_Description As String = ""
    Private _SPMT_BillTypes2_Description As String = ""
    Private _SPMT_erpDCH3_PlaceOfDelivery As String = ""
    Private _SPMT_ERPStates4_Description As String = ""
    Private _SPMT_ERPUnits5_Description As String = ""
    Private _SPMT_HSNSACCodes6_HSNSACCode As String = ""
    Private _SPMT_IsgecGSTIN7_Description As String = ""
    Private _VR_BPGSTIN8_Description As String = ""
    Private _VR_BusinessPartner9_BPName As String = ""
    Private _SPMT_erpDCD10_ItemDescription As String = ""
    Private _FK_SPMT_erpDCInventory_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_erpDCInventory_BillTypeID As SIS.SPMT.spmtBillTypes = Nothing
    Private _FK_SPMT_erpDCInventory_ChallanID As SIS.SPMT.SPMTerpDCH = Nothing
    Private _FK_SPMT_erpDCInventory_consignerStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_erpDCInventory_UOM As SIS.SPMT.spmtERPUnits = Nothing
    Private _FK_SPMT_erpDCInventory_HSNSACCode As SIS.SPMT.spmtHSNSACCodes = Nothing
    Private _FK_SPMT_erpDCInventory_ConsignerIsgecID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_erpDCInventory_ConsignerGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_erpDCInventory_ConsignerBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_erpDCInventory_SerialNo As SIS.SPMT.SPMTerpDCD = Nothing
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
          mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property ChallanID() As String
      Get
        Return _ChallanID
      End Get
      Set(ByVal value As String)
        _ChallanID = value
      End Set
    End Property
    Public Property SerialNo() As Int32
      Get
        Return _SerialNo
      End Get
      Set(ByVal value As Int32)
        _SerialNo = value
      End Set
    End Property
    Public Property ItemDescription() As String
      Get
        Return _ItemDescription
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ItemDescription = ""
         Else
           _ItemDescription = value
         End If
      End Set
    End Property
    Public Property BaseRate() As Decimal
      Get
        Return _BaseRate
      End Get
      Set(ByVal value As Decimal)
        _BaseRate = value
      End Set
    End Property
    Public Property BillTypeID() As String
      Get
        Return _BillTypeID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BillTypeID = ""
         Else
           _BillTypeID = value
         End If
      End Set
    End Property
    Public Property HSNSACCode() As String
      Get
        Return _HSNSACCode
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _HSNSACCode = ""
         Else
           _HSNSACCode = value
         End If
      End Set
    End Property
    Public Property UOM() As String
      Get
        Return _UOM
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _UOM = ""
         Else
           _UOM = value
         End If
      End Set
    End Property
    Public Property Quantity() As String
      Get
        Return _Quantity
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Quantity = "0.0000"
        Else
          _Quantity = value
        End If
      End Set
    End Property
    Public Property QuantityUsed() As String
      Get
        Return _QuantityUsed
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _QuantityUsed = "0.0000"
        Else
          _QuantityUsed = value
        End If
      End Set
    End Property
    Public Property Price() As String
      Get
        Return _Price
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Price = "0.0000"
        Else
          _Price = value
        End If
      End Set
    End Property
    Public Property AssessableValue() As String
      Get
        Return _AssessableValue
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _AssessableValue = "0.0000"
        Else
           _AssessableValue = value
         End If
      End Set
    End Property
    Public Property IGSTRate() As String
      Get
        Return _IGSTRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _IGSTRate = "0.0000"
        Else
           _IGSTRate = value
         End If
      End Set
    End Property
    Public Property IGSTAmount() As String
      Get
        Return _IGSTAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _IGSTAmount = "0.0000"
        Else
           _IGSTAmount = value
         End If
      End Set
    End Property
    Public Property SGSTRate() As String
      Get
        Return _SGSTRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _SGSTRate = "0.0000"
        Else
           _SGSTRate = value
         End If
      End Set
    End Property
    Public Property SGSTAmount() As String
      Get
        Return _SGSTAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _SGSTAmount = "0.0000"
        Else
           _SGSTAmount = value
         End If
      End Set
    End Property
    Public Property CGSTRate() As String
      Get
        Return _CGSTRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _CGSTRate = "0.0000"
        Else
           _CGSTRate = value
         End If
      End Set
    End Property
    Public Property CGSTAmount() As String
      Get
        Return _CGSTAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _CGSTAmount = "0.0000"
        Else
           _CGSTAmount = value
         End If
      End Set
    End Property
    Public Property CessRate() As String
      Get
        Return _CessRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _CessRate = "0.0000"
        Else
           _CessRate = value
         End If
      End Set
    End Property
    Public Property CessAmount() As String
      Get
        Return _CessAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _CessAmount = "0.0000"
        Else
           _CessAmount = value
         End If
      End Set
    End Property
    Public Property TotalGST() As String
      Get
        Return _TotalGST
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _TotalGST = "0.0000"
        Else
           _TotalGST = value
         End If
      End Set
    End Property
    Public Property TotalAmount() As String
      Get
        Return _TotalAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _TotalAmount = "0.0000"
        Else
           _TotalAmount = value
         End If
      End Set
    End Property
    Public Property FinalRate() As String
      Get
        Return _FinalRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _FinalRate = "0.0000"
        Else
           _FinalRate = value
         End If
      End Set
    End Property
    Public Property FinalAmount() As String
      Get
        Return _FinalAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
          _FinalAmount = "0.0000"
        Else
           _FinalAmount = value
         End If
      End Set
    End Property
    Public Property ConsignerIsgecID() As String
      Get
        Return _ConsignerIsgecID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerIsgecID = ""
         Else
           _ConsignerIsgecID = value
         End If
      End Set
    End Property
    Public Property ConsignerBPID() As String
      Get
        Return _ConsignerBPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerBPID = ""
         Else
           _ConsignerBPID = value
         End If
      End Set
    End Property
    Public Property ConsignerGSTIN() As String
      Get
        Return _ConsignerGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerGSTIN = ""
         Else
           _ConsignerGSTIN = value
         End If
      End Set
    End Property
    Public Property ConsignerName() As String
      Get
        Return _ConsignerName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerName = ""
         Else
           _ConsignerName = value
         End If
      End Set
    End Property
    Public Property ConsignerGSTINNo() As String
      Get
        Return _ConsignerGSTINNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerGSTINNo = ""
         Else
           _ConsignerGSTINNo = value
         End If
      End Set
    End Property
    Public Property ConsignerStateID() As String
      Get
        Return _ConsignerStateID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerStateID = ""
         Else
           _ConsignerStateID = value
         End If
      End Set
    End Property
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ProjectID = ""
         Else
           _ProjectID = value
         End If
      End Set
    End Property
    Public Property IDM_Projects1_Description() As String
      Get
        Return _IDM_Projects1_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects1_Description = value
      End Set
    End Property
    Public Property SPMT_BillTypes2_Description() As String
      Get
        Return _SPMT_BillTypes2_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_BillTypes2_Description = ""
         Else
           _SPMT_BillTypes2_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_erpDCH3_PlaceOfDelivery() As String
      Get
        Return _SPMT_erpDCH3_PlaceOfDelivery
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_erpDCH3_PlaceOfDelivery = ""
         Else
           _SPMT_erpDCH3_PlaceOfDelivery = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates4_Description() As String
      Get
        Return _SPMT_ERPStates4_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates4_Description = ""
         Else
           _SPMT_ERPStates4_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPUnits5_Description() As String
      Get
        Return _SPMT_ERPUnits5_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPUnits5_Description = ""
         Else
           _SPMT_ERPUnits5_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_HSNSACCodes6_HSNSACCode() As String
      Get
        Return _SPMT_HSNSACCodes6_HSNSACCode
      End Get
      Set(ByVal value As String)
        _SPMT_HSNSACCodes6_HSNSACCode = value
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN7_Description() As String
      Get
        Return _SPMT_IsgecGSTIN7_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN7_Description = ""
         Else
           _SPMT_IsgecGSTIN7_Description = value
         End If
      End Set
    End Property
    Public Property VR_BPGSTIN8_Description() As String
      Get
        Return _VR_BPGSTIN8_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN8_Description = ""
         Else
           _VR_BPGSTIN8_Description = value
         End If
      End Set
    End Property
    Public Property VR_BusinessPartner9_BPName() As String
      Get
        Return _VR_BusinessPartner9_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner9_BPName = value
      End Set
    End Property
    Public Property SPMT_erpDCD10_ItemDescription() As String
      Get
        Return _SPMT_erpDCD10_ItemDescription
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_erpDCD10_ItemDescription = ""
         Else
           _SPMT_erpDCD10_ItemDescription = value
         End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _ChallanID & "|" & _SerialNo
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKSPMTerpDCInventory
      Private _ChallanID As String = ""
      Private _SerialNo As Int32 = 0
      Public Property ChallanID() As String
        Get
          Return _ChallanID
        End Get
        Set(ByVal value As String)
          _ChallanID = value
        End Set
      End Property
      Public Property SerialNo() As Int32
        Get
          Return _SerialNo
        End Get
        Set(ByVal value As Int32)
          _SerialNo = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_SPMT_erpDCInventory_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_erpDCInventory_ProjectID Is Nothing Then
          _FK_SPMT_erpDCInventory_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_erpDCInventory_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_BillTypeID() As SIS.SPMT.spmtBillTypes
      Get
        If _FK_SPMT_erpDCInventory_BillTypeID Is Nothing Then
          _FK_SPMT_erpDCInventory_BillTypeID = SIS.SPMT.spmtBillTypes.spmtBillTypesGetByID(_BillTypeID)
        End If
        Return _FK_SPMT_erpDCInventory_BillTypeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_ChallanID() As SIS.SPMT.SPMTerpDCH
      Get
        If _FK_SPMT_erpDCInventory_ChallanID Is Nothing Then
          _FK_SPMT_erpDCInventory_ChallanID = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(_ChallanID)
        End If
        Return _FK_SPMT_erpDCInventory_ChallanID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_consignerStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_erpDCInventory_consignerStateID Is Nothing Then
          _FK_SPMT_erpDCInventory_consignerStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ConsignerStateID)
        End If
        Return _FK_SPMT_erpDCInventory_consignerStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_UOM() As SIS.SPMT.spmtERPUnits
      Get
        If _FK_SPMT_erpDCInventory_UOM Is Nothing Then
          _FK_SPMT_erpDCInventory_UOM = SIS.SPMT.spmtERPUnits.spmtERPUnitsGetByID(_UOM)
        End If
        Return _FK_SPMT_erpDCInventory_UOM
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_HSNSACCode() As SIS.SPMT.spmtHSNSACCodes
      Get
        If _FK_SPMT_erpDCInventory_HSNSACCode Is Nothing Then
          _FK_SPMT_erpDCInventory_HSNSACCode = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(_BillTypeID, _HSNSACCode)
        End If
        Return _FK_SPMT_erpDCInventory_HSNSACCode
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_ConsignerIsgecID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_erpDCInventory_ConsignerIsgecID Is Nothing Then
          _FK_SPMT_erpDCInventory_ConsignerIsgecID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_ConsignerIsgecID)
        End If
        Return _FK_SPMT_erpDCInventory_ConsignerIsgecID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_ConsignerGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_erpDCInventory_ConsignerGSTIN Is Nothing Then
          _FK_SPMT_erpDCInventory_ConsignerGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_ConsignerBPID, _ConsignerGSTIN)
        End If
        Return _FK_SPMT_erpDCInventory_ConsignerGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_ConsignerBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_erpDCInventory_ConsignerBPID Is Nothing Then
          _FK_SPMT_erpDCInventory_ConsignerBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_ConsignerBPID)
        End If
        Return _FK_SPMT_erpDCInventory_ConsignerBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCInventory_SerialNo() As SIS.SPMT.SPMTerpDCD
      Get
        If _FK_SPMT_erpDCInventory_SerialNo Is Nothing Then
          _FK_SPMT_erpDCInventory_SerialNo = SIS.SPMT.SPMTerpDCD.SPMTerpDCDGetByID(_ChallanID, _SerialNo)
        End If
        Return _FK_SPMT_erpDCInventory_SerialNo
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCInventoryGetNewRecord() As SIS.SPMT.SPMTerpDCInventory
      Return New SIS.SPMT.SPMTerpDCInventory()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCInventoryGetByID(ByVal ChallanID As String, ByVal SerialNo As Int32) As SIS.SPMT.SPMTerpDCInventory
      Dim Results As SIS.SPMT.SPMTerpDCInventory = Nothing
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
            Results = New SIS.SPMT.SPMTerpDCInventory(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SPMTerpDCInventorySelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.SPMTerpDCInventory)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCInventory) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spSPMTerpDCInventorySelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spSPMTerpDCInventorySelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCInventory)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCInventory(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SPMTerpDCInventorySelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function SPMTerpDCInventoryInsert(ByVal Record As SIS.SPMT.SPMTerpDCInventory) As SIS.SPMT.SPMTerpDCInventory
      Dim _Rec As SIS.SPMT.SPMTerpDCInventory = SIS.SPMT.SPMTerpDCInventory.SPMTerpDCInventoryGetNewRecord()
      With _Rec
        .ChallanID = Record.ChallanID
        .SerialNo = Record.SerialNo
        .ItemDescription = Record.ItemDescription
        .BaseRate = Record.BaseRate
        .BillTypeID = Record.BillTypeID
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .Quantity = Record.Quantity
        .QuantityUsed = Record.QuantityUsed
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
      End With
      Return SIS.SPMT.SPMTerpDCInventory.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.SPMTerpDCInventory) As SIS.SPMT.SPMTerpDCInventory
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCInventoryInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID",SqlDbType.NVarChar,21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo", SqlDbType.Int, 11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemDescription", SqlDbType.NVarChar, 251, IIf(Record.ItemDescription = "", Convert.DBNull, Record.ItemDescription))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaseRate",SqlDbType.Decimal,23, Record.BaseRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillTypeID",SqlDbType.Int,11, Iif(Record.BillTypeID= "" ,Convert.DBNull, Record.BillTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@HSNSACCode",SqlDbType.NVarChar,21, Iif(Record.HSNSACCode= "" ,Convert.DBNull, Record.HSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM",SqlDbType.NVarChar,4, Iif(Record.UOM= "" ,Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity", SqlDbType.Decimal, 23, IIf(Record.Quantity = "", Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QuantityUsed", SqlDbType.Decimal, 23, IIf(Record.QuantityUsed = "", Convert.DBNull, Record.QuantityUsed))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Price", SqlDbType.Decimal, 23, IIf(Record.Price = "", Convert.DBNull, Record.Price))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AssessableValue",SqlDbType.Decimal,23, Iif(Record.AssessableValue= "" ,Convert.DBNull, Record.AssessableValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTRate",SqlDbType.Decimal,23, Iif(Record.IGSTRate= "" ,Convert.DBNull, Record.IGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTAmount",SqlDbType.Decimal,23, Iif(Record.IGSTAmount= "" ,Convert.DBNull, Record.IGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTRate",SqlDbType.Decimal,23, Iif(Record.SGSTRate= "" ,Convert.DBNull, Record.SGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTAmount",SqlDbType.Decimal,23, Iif(Record.SGSTAmount= "" ,Convert.DBNull, Record.SGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTRate",SqlDbType.Decimal,23, Iif(Record.CGSTRate= "" ,Convert.DBNull, Record.CGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTAmount",SqlDbType.Decimal,23, Iif(Record.CGSTAmount= "" ,Convert.DBNull, Record.CGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessRate",SqlDbType.Decimal,23, Iif(Record.CessRate= "" ,Convert.DBNull, Record.CessRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessAmount",SqlDbType.Decimal,23, Iif(Record.CessAmount= "" ,Convert.DBNull, Record.CessAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGST",SqlDbType.Decimal,23, Iif(Record.TotalGST= "" ,Convert.DBNull, Record.TotalGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,23, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinalRate",SqlDbType.Decimal,23, Iif(Record.FinalRate= "" ,Convert.DBNull, Record.FinalRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinalAmount",SqlDbType.Decimal,23, Iif(Record.FinalAmount= "" ,Convert.DBNull, Record.FinalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerIsgecID",SqlDbType.Int,11, Iif(Record.ConsignerIsgecID= "" ,Convert.DBNull, Record.ConsignerIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerBPID",SqlDbType.NVarChar,10, Iif(Record.ConsignerBPID= "" ,Convert.DBNull, Record.ConsignerBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTIN",SqlDbType.Int,11, Iif(Record.ConsignerGSTIN= "" ,Convert.DBNull, Record.ConsignerGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerName",SqlDbType.NVarChar,51, Iif(Record.ConsignerName= "" ,Convert.DBNull, Record.ConsignerName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTINNo",SqlDbType.NVarChar,51, Iif(Record.ConsignerGSTINNo= "" ,Convert.DBNull, Record.ConsignerGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerStateID",SqlDbType.NVarChar,3, Iif(Record.ConsignerStateID= "" ,Convert.DBNull, Record.ConsignerStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          Cmd.Parameters.Add("@Return_ChallanID", SqlDbType.NVarChar, 21)
          Cmd.Parameters("@Return_ChallanID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_SerialNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_SerialNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.ChallanID = Cmd.Parameters("@Return_ChallanID").Value
          Record.SerialNo = Cmd.Parameters("@Return_SerialNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function SPMTerpDCInventoryUpdate(ByVal Record As SIS.SPMT.SPMTerpDCInventory) As SIS.SPMT.SPMTerpDCInventory
      Dim _Rec As SIS.SPMT.SPMTerpDCInventory = SIS.SPMT.SPMTerpDCInventory.SPMTerpDCInventoryGetByID(Record.ChallanID, Record.SerialNo)
      With _Rec
        .ItemDescription = Record.ItemDescription
        .BaseRate = Record.BaseRate
        .BillTypeID = Record.BillTypeID
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .Quantity = Record.Quantity
        .QuantityUsed = Record.QuantityUsed
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
      End With
      Return SIS.SPMT.SPMTerpDCInventory.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.SPMTerpDCInventory) As SIS.SPMT.SPMTerpDCInventory
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCInventoryUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ChallanID",SqlDbType.NVarChar,21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID",SqlDbType.NVarChar,21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemDescription",SqlDbType.NVarChar,251, Iif(Record.ItemDescription= "" ,Convert.DBNull, Record.ItemDescription))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaseRate",SqlDbType.Decimal,23, Record.BaseRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillTypeID",SqlDbType.Int,11, Iif(Record.BillTypeID= "" ,Convert.DBNull, Record.BillTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@HSNSACCode",SqlDbType.NVarChar,21, Iif(Record.HSNSACCode= "" ,Convert.DBNull, Record.HSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM",SqlDbType.NVarChar,4, Iif(Record.UOM= "" ,Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,23, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QuantityUsed", SqlDbType.Decimal, 23, IIf(Record.QuantityUsed = "", Convert.DBNull, Record.QuantityUsed))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Price", SqlDbType.Decimal, 23, IIf(Record.Price = "", Convert.DBNull, Record.Price))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AssessableValue",SqlDbType.Decimal,23, Iif(Record.AssessableValue= "" ,Convert.DBNull, Record.AssessableValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTRate",SqlDbType.Decimal,23, Iif(Record.IGSTRate= "" ,Convert.DBNull, Record.IGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTAmount",SqlDbType.Decimal,23, Iif(Record.IGSTAmount= "" ,Convert.DBNull, Record.IGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTRate",SqlDbType.Decimal,23, Iif(Record.SGSTRate= "" ,Convert.DBNull, Record.SGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTAmount",SqlDbType.Decimal,23, Iif(Record.SGSTAmount= "" ,Convert.DBNull, Record.SGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTRate",SqlDbType.Decimal,23, Iif(Record.CGSTRate= "" ,Convert.DBNull, Record.CGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTAmount",SqlDbType.Decimal,23, Iif(Record.CGSTAmount= "" ,Convert.DBNull, Record.CGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessRate",SqlDbType.Decimal,23, Iif(Record.CessRate= "" ,Convert.DBNull, Record.CessRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessAmount",SqlDbType.Decimal,23, Iif(Record.CessAmount= "" ,Convert.DBNull, Record.CessAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGST",SqlDbType.Decimal,23, Iif(Record.TotalGST= "" ,Convert.DBNull, Record.TotalGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,23, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinalRate",SqlDbType.Decimal,23, Iif(Record.FinalRate= "" ,Convert.DBNull, Record.FinalRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinalAmount",SqlDbType.Decimal,23, Iif(Record.FinalAmount= "" ,Convert.DBNull, Record.FinalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerIsgecID",SqlDbType.Int,11, Iif(Record.ConsignerIsgecID= "" ,Convert.DBNull, Record.ConsignerIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerBPID",SqlDbType.NVarChar,10, Iif(Record.ConsignerBPID= "" ,Convert.DBNull, Record.ConsignerBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTIN",SqlDbType.Int,11, Iif(Record.ConsignerGSTIN= "" ,Convert.DBNull, Record.ConsignerGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerName",SqlDbType.NVarChar,51, Iif(Record.ConsignerName= "" ,Convert.DBNull, Record.ConsignerName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTINNo",SqlDbType.NVarChar,51, Iif(Record.ConsignerGSTINNo= "" ,Convert.DBNull, Record.ConsignerGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerStateID",SqlDbType.NVarChar,3, Iif(Record.ConsignerStateID= "" ,Convert.DBNull, Record.ConsignerStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function SPMTerpDCInventoryDelete(ByVal Record As SIS.SPMT.SPMTerpDCInventory) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCInventoryDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ChallanID",SqlDbType.NVarChar,Record.ChallanID.ToString.Length, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,Record.SerialNo.ToString.Length, Record.SerialNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.0000")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
