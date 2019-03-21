Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtNewSBD
    Private Shared _RecordCount As Integer
    Private _IRNo As Int32 = 0
    Private _SerialNo As Int32 = 0
    Private _ItemDescription As String = ""
    Private _BillType As String = ""
    Private _HSNSACCode As String = ""
    Private _UOM As String = ""
    Private _Quantity As String = "0.00"
    Private _Currency As String = ""
    Private _ConversionFactorINR As String = "0.00"
    Private _AssessableValue As String = "0.00"
    Private _IGSTRate As String = "0.00"
    Private _IGSTAmount As String = "0.00"
    Private _SGSTRate As String = "0.00"
    Private _SGSTAmount As String = "0.00"
    Private _CGSTRate As String = "0.00"
    Private _CGSTAmount As String = "0.00"
    Private _CessRate As String = "0.00"
    Private _CessAmount As String = "0.00"
    Private _TotalGST As String = "0.00"
    Private _TotalAmount As String = "0.00"
    Private _TotalGSTINR As String = "0.00"
    Private _TotalAmountINR As String = "0.00"
    Private _DepartmentID As String = ""
    Private _EmployeeID As String = ""
    Private _ElementID As String = ""
    Private _Discount As String = "0.00"
    Private _ProjectID As String = ""
    Private _BasicValue As String = "0.00"
    Private _ServiceCharge As String = "0.00"
    Private _UploadBatchNo As String = ""
    Private _CostCenterID As String = ""
    Private _HRM_Departments1_Description As String = ""
    Private _HRM_Employees2_EmployeeName As String = ""
    Private _IDM_Projects3_Description As String = ""
    Private _IDM_WBS4_Description As String = ""
    Private _SPMT_BillTypes5_Description As String = ""
    Private _SPMT_CostCenters6_Description As String = ""
    Private _SPMT_ERPUnits7_Description As String = ""
    Private _SPMT_HSNSACCodes8_HSNSACCode As String = ""
    Private _SPMT_newSBH9_BillNumber As String = ""
    Private _FK_SPMT_newSBD_DepartmentID As SIS.COM.comDepartments = Nothing
    Private _FK_SPMT_newSBD_EmployeeID As SIS.COM.comEmployees = Nothing
    Private _FK_SPMT_newSBD_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_newSBD_ElementID As SIS.COM.comElements = Nothing
    Private _FK_SPMT_newSBD_BillType As SIS.SPMT.spmtBillTypes = Nothing
    Private _FK_SPMT_newSBD_CostCenterID As SIS.SPMT.spmtCostCenters = Nothing
    Private _FK_SPMT_newSBD_UOM As SIS.SPMT.spmtERPUnits = Nothing
    Private _FK_SPMT_newSBD_HSNSACCode As SIS.SPMT.spmtHSNSACCodes = Nothing
    Private _FK_SPMT_newSBD_IRNo As SIS.SPMT.spmtNewSBH = Nothing
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
    Public Property IRNo() As Int32
      Get
        Return _IRNo
      End Get
      Set(ByVal value As Int32)
        _IRNo = value
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
    Public Property BillType() As String
      Get
        Return _BillType
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BillType = ""
         Else
           _BillType = value
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
         If Convert.IsDBNull(Value) Then
           _Quantity = "0.00"
         Else
           _Quantity = value
         End If
      End Set
    End Property
    Public Property Currency() As String
      Get
        Return _Currency
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Currency = ""
         Else
           _Currency = value
         End If
      End Set
    End Property
    Public Property ConversionFactorINR() As String
      Get
        Return _ConversionFactorINR
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConversionFactorINR = "0.00"
         Else
           _ConversionFactorINR = value
         End If
      End Set
    End Property
    Public Property AssessableValue() As String
      Get
        Return _AssessableValue
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AssessableValue = "0.00"
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
           _IGSTRate = "0.00"
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
           _IGSTAmount = "0.00"
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
           _SGSTRate = "0.00"
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
           _SGSTAmount = "0.00"
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
           _CGSTRate = "0.00"
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
           _CGSTAmount = "0.00"
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
           _CessRate = "0.00"
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
           _CessAmount = "0.00"
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
           _TotalGST = "0.00"
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
           _TotalAmount = "0.00"
         Else
           _TotalAmount = value
         End If
      End Set
    End Property
    Public Property TotalGSTINR() As String
      Get
        Return _TotalGSTINR
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TotalGSTINR = "0.00"
         Else
           _TotalGSTINR = value
         End If
      End Set
    End Property
    Public Property TotalAmountINR() As String
      Get
        Return _TotalAmountINR
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TotalAmountINR = "0.00"
         Else
           _TotalAmountINR = value
         End If
      End Set
    End Property
    Public Property DepartmentID() As String
      Get
        Return _DepartmentID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _DepartmentID = ""
         Else
           _DepartmentID = value
         End If
      End Set
    End Property
    Public Property EmployeeID() As String
      Get
        Return _EmployeeID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _EmployeeID = ""
         Else
           _EmployeeID = value
         End If
      End Set
    End Property
    Public Property ElementID() As String
      Get
        Return _ElementID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ElementID = ""
         Else
           _ElementID = value
         End If
      End Set
    End Property
    Public Property Discount() As String
      Get
        Return _Discount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Discount = "0.00"
         Else
           _Discount = value
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
    Public Property BasicValue() As String
      Get
        Return _BasicValue
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BasicValue = "0.00"
         Else
           _BasicValue = value
         End If
      End Set
    End Property
    Public Property ServiceCharge() As String
      Get
        Return _ServiceCharge
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ServiceCharge = "0.00"
         Else
           _ServiceCharge = value
         End If
      End Set
    End Property
    Public Property UploadBatchNo() As String
      Get
        Return _UploadBatchNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _UploadBatchNo = ""
         Else
           _UploadBatchNo = value
         End If
      End Set
    End Property
    Public Property CostCenterID() As String
      Get
        Return _CostCenterID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CostCenterID = ""
         Else
           _CostCenterID = value
         End If
      End Set
    End Property
    Public Property HRM_Departments1_Description() As String
      Get
        Return _HRM_Departments1_Description
      End Get
      Set(ByVal value As String)
        _HRM_Departments1_Description = value
      End Set
    End Property
    Public Property HRM_Employees2_EmployeeName() As String
      Get
        Return _HRM_Employees2_EmployeeName
      End Get
      Set(ByVal value As String)
        _HRM_Employees2_EmployeeName = value
      End Set
    End Property
    Public Property IDM_Projects3_Description() As String
      Get
        Return _IDM_Projects3_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects3_Description = value
      End Set
    End Property
    Public Property IDM_WBS4_Description() As String
      Get
        Return _IDM_WBS4_Description
      End Get
      Set(ByVal value As String)
        _IDM_WBS4_Description = value
      End Set
    End Property
    Public Property SPMT_BillTypes5_Description() As String
      Get
        Return _SPMT_BillTypes5_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_BillTypes5_Description = ""
         Else
           _SPMT_BillTypes5_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_CostCenters6_Description() As String
      Get
        Return _SPMT_CostCenters6_Description
      End Get
      Set(ByVal value As String)
        _SPMT_CostCenters6_Description = value
      End Set
    End Property
    Public Property SPMT_ERPUnits7_Description() As String
      Get
        Return _SPMT_ERPUnits7_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPUnits7_Description = ""
         Else
           _SPMT_ERPUnits7_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_HSNSACCodes8_HSNSACCode() As String
      Get
        Return _SPMT_HSNSACCodes8_HSNSACCode
      End Get
      Set(ByVal value As String)
        _SPMT_HSNSACCodes8_HSNSACCode = value
      End Set
    End Property
    Public Property SPMT_newSBH9_BillNumber() As String
      Get
        Return _SPMT_newSBH9_BillNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_newSBH9_BillNumber = ""
         Else
           _SPMT_newSBH9_BillNumber = value
         End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _ItemDescription.ToString.PadRight(100, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _IRNo & "|" & _SerialNo
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
    Public Class PKspmtNewSBD
      Private _IRNo As Int32 = 0
      Private _SerialNo As Int32 = 0
      Public Property IRNo() As Int32
        Get
          Return _IRNo
        End Get
        Set(ByVal value As Int32)
          _IRNo = value
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
    Public ReadOnly Property FK_SPMT_newSBD_DepartmentID() As SIS.COM.comDepartments
      Get
        If _FK_SPMT_newSBD_DepartmentID Is Nothing Then
          _FK_SPMT_newSBD_DepartmentID = SIS.COM.comDepartments.comDepartmentsGetByID(_DepartmentID)
        End If
        Return _FK_SPMT_newSBD_DepartmentID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_EmployeeID() As SIS.COM.comEmployees
      Get
        If _FK_SPMT_newSBD_EmployeeID Is Nothing Then
          _FK_SPMT_newSBD_EmployeeID = SIS.COM.comEmployees.comEmployeesGetByID(_EmployeeID)
        End If
        Return _FK_SPMT_newSBD_EmployeeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_newSBD_ProjectID Is Nothing Then
          _FK_SPMT_newSBD_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_newSBD_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_ElementID() As SIS.COM.comElements
      Get
        If _FK_SPMT_newSBD_ElementID Is Nothing Then
          _FK_SPMT_newSBD_ElementID = SIS.COM.comElements.comElementsGetByID(_ElementID)
        End If
        Return _FK_SPMT_newSBD_ElementID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_BillType() As SIS.SPMT.spmtBillTypes
      Get
        If _FK_SPMT_newSBD_BillType Is Nothing Then
          _FK_SPMT_newSBD_BillType = SIS.SPMT.spmtBillTypes.spmtBillTypesGetByID(_BillType)
        End If
        Return _FK_SPMT_newSBD_BillType
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_CostCenterID() As SIS.SPMT.spmtCostCenters
      Get
        If _FK_SPMT_newSBD_CostCenterID Is Nothing Then
          _FK_SPMT_newSBD_CostCenterID = SIS.SPMT.spmtCostCenters.spmtCostCentersGetByID(_CostCenterID)
        End If
        Return _FK_SPMT_newSBD_CostCenterID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_UOM() As SIS.SPMT.spmtERPUnits
      Get
        If _FK_SPMT_newSBD_UOM Is Nothing Then
          _FK_SPMT_newSBD_UOM = SIS.SPMT.spmtERPUnits.spmtERPUnitsGetByID(_UOM)
        End If
        Return _FK_SPMT_newSBD_UOM
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_HSNSACCode() As SIS.SPMT.spmtHSNSACCodes
      Get
        If _FK_SPMT_newSBD_HSNSACCode Is Nothing Then
          _FK_SPMT_newSBD_HSNSACCode = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(_BillType, _HSNSACCode)
        End If
        Return _FK_SPMT_newSBD_HSNSACCode
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBD_IRNo() As SIS.SPMT.spmtNewSBH
      Get
        If _FK_SPMT_newSBD_IRNo Is Nothing Then
          _FK_SPMT_newSBD_IRNo = SIS.SPMT.spmtNewSBH.spmtNewSBHGetByID(_IRNo)
        End If
        Return _FK_SPMT_newSBD_IRNo
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBDSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtNewSBD)
      Dim Results As List(Of SIS.SPMT.spmtNewSBD) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBDSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewSBD)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewSBD(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBDGetNewRecord() As SIS.SPMT.spmtNewSBD
      Return New SIS.SPMT.spmtNewSBD()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBDGetByID(ByVal IRNo As Int32, ByVal SerialNo As Int32) As SIS.SPMT.spmtNewSBD
      Dim Results As SIS.SPMT.spmtNewSBD = Nothing
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
            Results = New SIS.SPMT.spmtNewSBD(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBDSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32) As List(Of SIS.SPMT.spmtNewSBD)
      Dim Results As List(Of SIS.SPMT.spmtNewSBD) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtNewSBDSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtNewSBDSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IRNo",SqlDbType.Int,10, IIf(IRNo = Nothing, 0,IRNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewSBD)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewSBD(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtNewSBDSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBDGetByID(ByVal IRNo As Int32, ByVal SerialNo As Int32, ByVal Filter_IRNo As Int32) As SIS.SPMT.spmtNewSBD
      Return spmtNewSBDGetByID(IRNo, SerialNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtNewSBDInsert(ByVal Record As SIS.SPMT.spmtNewSBD) As SIS.SPMT.spmtNewSBD
      Dim _Rec As SIS.SPMT.spmtNewSBD = SIS.SPMT.spmtNewSBD.spmtNewSBDGetNewRecord()
      With _Rec
        .IRNo = Record.IRNo
        .ItemDescription = Record.ItemDescription
        .BillType = Record.BillType
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .Quantity = Record.Quantity
        .Currency = Record.Currency
        .ConversionFactorINR = Record.ConversionFactorINR
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
        .TotalGSTINR = Record.TotalGSTINR
        .TotalAmountINR = Record.TotalAmountINR
        .DepartmentID = Record.DepartmentID
        .EmployeeID = Record.EmployeeID
        .ElementID = Record.ElementID
        .Discount = Record.Discount
        .ProjectID = Record.ProjectID
        .CostCenterID = Record.CostCenterID
      End With
      Return SIS.SPMT.spmtNewSBD.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtNewSBD) As SIS.SPMT.spmtNewSBD
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBDInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,11, Record.IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemDescription",SqlDbType.NVarChar,101, Iif(Record.ItemDescription= "" ,Convert.DBNull, Record.ItemDescription))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillType",SqlDbType.Int,11, Iif(Record.BillType= "" ,Convert.DBNull, Record.BillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@HSNSACCode",SqlDbType.NVarChar,21, Iif(Record.HSNSACCode= "" ,Convert.DBNull, Record.HSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM",SqlDbType.NVarChar,4, Iif(Record.UOM= "" ,Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,21, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Currency",SqlDbType.NVarChar,51, Iif(Record.Currency= "" ,Convert.DBNull, Record.Currency))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConversionFactorINR",SqlDbType.Decimal,25, Iif(Record.ConversionFactorINR= "" ,Convert.DBNull, Record.ConversionFactorINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AssessableValue",SqlDbType.Decimal,21, Iif(Record.AssessableValue= "" ,Convert.DBNull, Record.AssessableValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTRate",SqlDbType.Decimal,21, Iif(Record.IGSTRate= "" ,Convert.DBNull, Record.IGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTAmount",SqlDbType.Decimal,21, Iif(Record.IGSTAmount= "" ,Convert.DBNull, Record.IGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTRate",SqlDbType.Decimal,21, Iif(Record.SGSTRate= "" ,Convert.DBNull, Record.SGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTAmount",SqlDbType.Decimal,21, Iif(Record.SGSTAmount= "" ,Convert.DBNull, Record.SGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTRate",SqlDbType.Decimal,21, Iif(Record.CGSTRate= "" ,Convert.DBNull, Record.CGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTAmount",SqlDbType.Decimal,21, Iif(Record.CGSTAmount= "" ,Convert.DBNull, Record.CGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessRate",SqlDbType.Decimal,21, Iif(Record.CessRate= "" ,Convert.DBNull, Record.CessRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessAmount",SqlDbType.Decimal,21, Iif(Record.CessAmount= "" ,Convert.DBNull, Record.CessAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGST",SqlDbType.Decimal,21, Iif(Record.TotalGST= "" ,Convert.DBNull, Record.TotalGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,21, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGSTINR",SqlDbType.Decimal,21, Iif(Record.TotalGSTINR= "" ,Convert.DBNull, Record.TotalGSTINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountINR",SqlDbType.Decimal,21, Iif(Record.TotalAmountINR= "" ,Convert.DBNull, Record.TotalAmountINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Discount",SqlDbType.Decimal,21, Iif(Record.Discount= "" ,Convert.DBNull, Record.Discount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BasicValue",SqlDbType.Decimal,21, Iif(Record.BasicValue= "" ,Convert.DBNull, Record.BasicValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ServiceCharge",SqlDbType.Decimal,21, Iif(Record.ServiceCharge= "" ,Convert.DBNull, Record.ServiceCharge))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo",SqlDbType.NVarChar,51, Iif(Record.UploadBatchNo= "" ,Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          Cmd.Parameters.Add("@Return_IRNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_IRNo").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_SerialNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_SerialNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.IRNo = Cmd.Parameters("@Return_IRNo").Value
          Record.SerialNo = Cmd.Parameters("@Return_SerialNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtNewSBDUpdate(ByVal Record As SIS.SPMT.spmtNewSBD) As SIS.SPMT.spmtNewSBD
      Dim _Rec As SIS.SPMT.spmtNewSBD = SIS.SPMT.spmtNewSBD.spmtNewSBDGetByID(Record.IRNo, Record.SerialNo)
      With _Rec
        .ItemDescription = Record.ItemDescription
        .BillType = Record.BillType
        .HSNSACCode = Record.HSNSACCode
        .UOM = Record.UOM
        .Quantity = Record.Quantity
        .Currency = Record.Currency
        .ConversionFactorINR = Record.ConversionFactorINR
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
        .TotalGSTINR = Record.TotalGSTINR
        .TotalAmountINR = Record.TotalAmountINR
        .DepartmentID = Record.DepartmentID
        .EmployeeID = Record.EmployeeID
        .ElementID = Record.ElementID
        .Discount = Record.Discount
        .ProjectID = Record.ProjectID
        .CostCenterID = Record.CostCenterID
      End With
      Return SIS.SPMT.spmtNewSBD.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtNewSBD) As SIS.SPMT.spmtNewSBD
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBDUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_IRNo",SqlDbType.Int,11, Record.IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,11, Record.IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ItemDescription",SqlDbType.NVarChar,101, Iif(Record.ItemDescription= "" ,Convert.DBNull, Record.ItemDescription))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillType",SqlDbType.Int,11, Iif(Record.BillType= "" ,Convert.DBNull, Record.BillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@HSNSACCode",SqlDbType.NVarChar,21, Iif(Record.HSNSACCode= "" ,Convert.DBNull, Record.HSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM",SqlDbType.NVarChar,4, Iif(Record.UOM= "" ,Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,21, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Currency",SqlDbType.NVarChar,51, Iif(Record.Currency= "" ,Convert.DBNull, Record.Currency))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConversionFactorINR",SqlDbType.Decimal,25, Iif(Record.ConversionFactorINR= "" ,Convert.DBNull, Record.ConversionFactorINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AssessableValue",SqlDbType.Decimal,21, Iif(Record.AssessableValue= "" ,Convert.DBNull, Record.AssessableValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTRate",SqlDbType.Decimal,21, Iif(Record.IGSTRate= "" ,Convert.DBNull, Record.IGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTAmount",SqlDbType.Decimal,21, Iif(Record.IGSTAmount= "" ,Convert.DBNull, Record.IGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTRate",SqlDbType.Decimal,21, Iif(Record.SGSTRate= "" ,Convert.DBNull, Record.SGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTAmount",SqlDbType.Decimal,21, Iif(Record.SGSTAmount= "" ,Convert.DBNull, Record.SGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTRate",SqlDbType.Decimal,21, Iif(Record.CGSTRate= "" ,Convert.DBNull, Record.CGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTAmount",SqlDbType.Decimal,21, Iif(Record.CGSTAmount= "" ,Convert.DBNull, Record.CGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessRate",SqlDbType.Decimal,21, Iif(Record.CessRate= "" ,Convert.DBNull, Record.CessRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessAmount",SqlDbType.Decimal,21, Iif(Record.CessAmount= "" ,Convert.DBNull, Record.CessAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGST",SqlDbType.Decimal,21, Iif(Record.TotalGST= "" ,Convert.DBNull, Record.TotalGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,21, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGSTINR",SqlDbType.Decimal,21, Iif(Record.TotalGSTINR= "" ,Convert.DBNull, Record.TotalGSTINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountINR",SqlDbType.Decimal,21, Iif(Record.TotalAmountINR= "" ,Convert.DBNull, Record.TotalAmountINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Discount",SqlDbType.Decimal,21, Iif(Record.Discount= "" ,Convert.DBNull, Record.Discount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BasicValue",SqlDbType.Decimal,21, Iif(Record.BasicValue= "" ,Convert.DBNull, Record.BasicValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ServiceCharge",SqlDbType.Decimal,21, Iif(Record.ServiceCharge= "" ,Convert.DBNull, Record.ServiceCharge))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo",SqlDbType.NVarChar,51, Iif(Record.UploadBatchNo= "" ,Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
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
    Public Shared Function spmtNewSBDDelete(ByVal Record As SIS.SPMT.spmtNewSBD) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBDDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_IRNo",SqlDbType.Int,Record.IRNo.ToString.Length, Record.IRNo)
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
'    Autocomplete Method
    Public Shared Function SelectspmtNewSBDAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBDAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, 1))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(100, " "),"" & "|" & ""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.SPMT.spmtNewSBD = New SIS.SPMT.spmtNewSBD(Reader)
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results.ToArray
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              If Convert.IsDBNull(Reader(pi.Name)) Then
                CallByName(Me, pi.Name, CallType.Let, String.Empty)
              Else
                CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
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
