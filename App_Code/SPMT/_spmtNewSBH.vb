Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtNewSBH
    Private Shared _RecordCount As Integer
    Private _IRNo As Int32 = 0
    Private _TranTypeID As String = ""
    Private _SupplierName As String = ""
    Private _BillNumber As String = ""
    Private _BillDate As String = ""
    Private _CreatedBy As String = ""
    Private _TotalBillAmount As String = "0.00"
    Private _AdviceNo As String = ""
    Private _IRReceivedOn As String = ""
    Private _UploadBatchNo As String = ""
    Private _EmployeeID As String = ""
    Private _CostCenterID As String = ""
    Private _DepartmentID As String = ""
    Private _BillRemarks As String = ""
    Private _ProjectID As String = ""
    Private _ShipToState As String = ""
    Private _SupplierGSTINNumber As String = ""
    Private _SupplierGSTIN As String = ""
    Private _BPID As String = ""
    Private _IsgecGSTIN As String = ""
    Private _PurchaseType As String = ""
    Private _ElementID As String = ""
    Private _CreatedOn As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _HRM_Departments2_Description As String = ""
    Private _HRM_Employees3_EmployeeName As String = ""
    Private _IDM_Projects4_Description As String = ""
    Private _IDM_WBS5_Description As String = ""
    Private _SPMT_CostCenters6_Description As String = ""
    Private _SPMT_ERPStates7_Description As String = ""
    Private _SPMT_IsgecGSTIN8_Description As String = ""
    Private _SPMT_newPA9_BPID As String = ""
    Private _SPMT_TranTypes10_Description As String = ""
    Private _VR_BPGSTIN11_Description As String = ""
    Private _VR_BusinessPartner12_BPName As String = ""
    Private _FK_SPMT_newSBH_CreatedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_newSBH_DepartmentID As SIS.COM.comDepartments = Nothing
    Private _FK_SPMT_newSBH_EmployeeID As SIS.COM.comEmployees = Nothing
    Private _FK_SPMT_newSBH_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_newSBH_ElementID As SIS.COM.comElements = Nothing
    Private _FK_SPMT_newSBH_CostCenterID As SIS.SPMT.spmtCostCenters = Nothing
    Private _FK_SPMT_newSBH_ShipToState As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_newSBH_IsgecGSTIN As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_newSBH_AdviceNo As SIS.SPMT.spmtNewPA = Nothing
    Private _FK_SPMT_newSBH_TranTypeID As SIS.SPMT.spmtTranTypes = Nothing
    Private _FK_SPMT_newSBH_SupplierGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_newSBH_BPID As SIS.SPMT.spmtBusinessPartner = Nothing
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
    Public Property TranTypeID() As String
      Get
        Return _TranTypeID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TranTypeID = ""
         Else
           _TranTypeID = value
         End If
      End Set
    End Property
    Public Property SupplierName() As String
      Get
        Return _SupplierName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SupplierName = ""
         Else
           _SupplierName = value
         End If
      End Set
    End Property
    Public Property BillNumber() As String
      Get
        Return _BillNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BillNumber = ""
         Else
           _BillNumber = value
         End If
      End Set
    End Property
    Public Property BillDate() As String
      Get
        If Not _BillDate = String.Empty Then
          Return Convert.ToDateTime(_BillDate).ToString("dd/MM/yyyy")
        End If
        Return _BillDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BillDate = ""
         Else
           _BillDate = value
         End If
      End Set
    End Property
    Public Property CreatedBy() As String
      Get
        Return _CreatedBy
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CreatedBy = ""
         Else
           _CreatedBy = value
         End If
      End Set
    End Property
    Public Property TotalBillAmount() As String
      Get
        Return _TotalBillAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TotalBillAmount = "0.00"
         Else
           _TotalBillAmount = value
         End If
      End Set
    End Property
    Public Property AdviceNo() As String
      Get
        Return _AdviceNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AdviceNo = ""
         Else
           _AdviceNo = value
         End If
      End Set
    End Property
    Public Property IRReceivedOn() As String
      Get
        If Not _IRReceivedOn = String.Empty Then
          Return Convert.ToDateTime(_IRReceivedOn).ToString("dd/MM/yyyy")
        End If
        Return _IRReceivedOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IRReceivedOn = ""
         Else
           _IRReceivedOn = value
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
    Public Property BillRemarks() As String
      Get
        Return _BillRemarks
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BillRemarks = ""
         Else
           _BillRemarks = value
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
    Public Property ShipToState() As String
      Get
        Return _ShipToState
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ShipToState = ""
         Else
           _ShipToState = value
         End If
      End Set
    End Property
    Public Property SupplierGSTINNumber() As String
      Get
        Return _SupplierGSTINNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SupplierGSTINNumber = ""
         Else
           _SupplierGSTINNumber = value
         End If
      End Set
    End Property
    Public Property SupplierGSTIN() As String
      Get
        Return _SupplierGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SupplierGSTIN = ""
         Else
           _SupplierGSTIN = value
         End If
      End Set
    End Property
    Public Property BPID() As String
      Get
        Return _BPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BPID = ""
         Else
           _BPID = value
         End If
      End Set
    End Property
    Public Property IsgecGSTIN() As String
      Get
        Return _IsgecGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IsgecGSTIN = ""
         Else
           _IsgecGSTIN = value
         End If
      End Set
    End Property
    Public Property PurchaseType() As String
      Get
        Return _PurchaseType
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PurchaseType = ""
         Else
           _PurchaseType = value
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
    Public Property CreatedOn() As String
      Get
        If Not _CreatedOn = String.Empty Then
          Return Convert.ToDateTime(_CreatedOn).ToString("dd/MM/yyyy")
        End If
        Return _CreatedOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CreatedOn = ""
         Else
           _CreatedOn = value
         End If
      End Set
    End Property
    Public Property aspnet_Users1_UserFullName() As String
      Get
        Return _aspnet_Users1_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users1_UserFullName = value
      End Set
    End Property
    Public Property HRM_Departments2_Description() As String
      Get
        Return _HRM_Departments2_Description
      End Get
      Set(ByVal value As String)
        _HRM_Departments2_Description = value
      End Set
    End Property
    Public Property HRM_Employees3_EmployeeName() As String
      Get
        Return _HRM_Employees3_EmployeeName
      End Get
      Set(ByVal value As String)
        _HRM_Employees3_EmployeeName = value
      End Set
    End Property
    Public Property IDM_Projects4_Description() As String
      Get
        Return _IDM_Projects4_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects4_Description = value
      End Set
    End Property
    Public Property IDM_WBS5_Description() As String
      Get
        Return _IDM_WBS5_Description
      End Get
      Set(ByVal value As String)
        _IDM_WBS5_Description = value
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
    Public Property SPMT_ERPStates7_Description() As String
      Get
        Return _SPMT_ERPStates7_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates7_Description = ""
         Else
           _SPMT_ERPStates7_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN8_Description() As String
      Get
        Return _SPMT_IsgecGSTIN8_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN8_Description = ""
         Else
           _SPMT_IsgecGSTIN8_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_newPA9_BPID() As String
      Get
        Return _SPMT_newPA9_BPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_newPA9_BPID = ""
         Else
           _SPMT_newPA9_BPID = value
         End If
      End Set
    End Property
    Public Property SPMT_TranTypes10_Description() As String
      Get
        Return _SPMT_TranTypes10_Description
      End Get
      Set(ByVal value As String)
        _SPMT_TranTypes10_Description = value
      End Set
    End Property
    Public Property VR_BPGSTIN11_Description() As String
      Get
        Return _VR_BPGSTIN11_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN11_Description = ""
         Else
           _VR_BPGSTIN11_Description = value
         End If
      End Set
    End Property
    Public Property VR_BusinessPartner12_BPName() As String
      Get
        Return _VR_BusinessPartner12_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner12_BPName = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _BillNumber.ToString.PadRight(50, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _IRNo
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
    Public Class PKspmtNewSBH
      Private _IRNo As Int32 = 0
      Public Property IRNo() As Int32
        Get
          Return _IRNo
        End Get
        Set(ByVal value As Int32)
          _IRNo = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_SPMT_newSBH_CreatedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_newSBH_CreatedBy Is Nothing Then
          _FK_SPMT_newSBH_CreatedBy = SIS.COM.comUsers.comUsersGetByID(_CreatedBy)
        End If
        Return _FK_SPMT_newSBH_CreatedBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_DepartmentID() As SIS.COM.comDepartments
      Get
        If _FK_SPMT_newSBH_DepartmentID Is Nothing Then
          _FK_SPMT_newSBH_DepartmentID = SIS.COM.comDepartments.comDepartmentsGetByID(_DepartmentID)
        End If
        Return _FK_SPMT_newSBH_DepartmentID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_EmployeeID() As SIS.COM.comEmployees
      Get
        If _FK_SPMT_newSBH_EmployeeID Is Nothing Then
          _FK_SPMT_newSBH_EmployeeID = SIS.COM.comEmployees.comEmployeesGetByID(_EmployeeID)
        End If
        Return _FK_SPMT_newSBH_EmployeeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_newSBH_ProjectID Is Nothing Then
          _FK_SPMT_newSBH_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_newSBH_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_ElementID() As SIS.COM.comElements
      Get
        If _FK_SPMT_newSBH_ElementID Is Nothing Then
          _FK_SPMT_newSBH_ElementID = SIS.COM.comElements.comElementsGetByID(_ElementID)
        End If
        Return _FK_SPMT_newSBH_ElementID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_CostCenterID() As SIS.SPMT.spmtCostCenters
      Get
        If _FK_SPMT_newSBH_CostCenterID Is Nothing Then
          _FK_SPMT_newSBH_CostCenterID = SIS.SPMT.spmtCostCenters.spmtCostCentersGetByID(_CostCenterID)
        End If
        Return _FK_SPMT_newSBH_CostCenterID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_ShipToState() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_newSBH_ShipToState Is Nothing Then
          _FK_SPMT_newSBH_ShipToState = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ShipToState)
        End If
        Return _FK_SPMT_newSBH_ShipToState
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_IsgecGSTIN() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_newSBH_IsgecGSTIN Is Nothing Then
          _FK_SPMT_newSBH_IsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_IsgecGSTIN)
        End If
        Return _FK_SPMT_newSBH_IsgecGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_AdviceNo() As SIS.SPMT.spmtNewPA
      Get
        If _FK_SPMT_newSBH_AdviceNo Is Nothing Then
          _FK_SPMT_newSBH_AdviceNo = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(_AdviceNo)
        End If
        Return _FK_SPMT_newSBH_AdviceNo
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_TranTypeID() As SIS.SPMT.spmtTranTypes
      Get
        If _FK_SPMT_newSBH_TranTypeID Is Nothing Then
          _FK_SPMT_newSBH_TranTypeID = SIS.SPMT.spmtTranTypes.spmtTranTypesGetByID(_TranTypeID)
        End If
        Return _FK_SPMT_newSBH_TranTypeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_SupplierGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_newSBH_SupplierGSTIN Is Nothing Then
          _FK_SPMT_newSBH_SupplierGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_BPID, _SupplierGSTIN)
        End If
        Return _FK_SPMT_newSBH_SupplierGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newSBH_BPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_newSBH_BPID Is Nothing Then
          _FK_SPMT_newSBH_BPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_BPID)
        End If
        Return _FK_SPMT_newSBH_BPID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBHSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtNewSBH)
      Dim Results As List(Of SIS.SPMT.spmtNewSBH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewSBH)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewSBH(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBHGetNewRecord() As SIS.SPMT.spmtNewSBH
      Return New SIS.SPMT.spmtNewSBH()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBHGetByID(ByVal IRNo As Int32) As SIS.SPMT.spmtNewSBH
      Dim Results As SIS.SPMT.spmtNewSBH = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,IRNo.ToString.Length, IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtNewSBH(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBHSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal IsgecGSTIN As Int32, ByVal PurchaseType As String) As List(Of SIS.SPMT.spmtNewSBH)
      Dim Results As List(Of SIS.SPMT.spmtNewSBH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtNewSBHSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtNewSBHSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IsgecGSTIN",SqlDbType.Int,10, IIf(IsgecGSTIN = Nothing, 0,IsgecGSTIN))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_PurchaseType",SqlDbType.NVarChar,50, IIf(PurchaseType Is Nothing, String.Empty,PurchaseType))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewSBH)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewSBH(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtNewSBHSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal IsgecGSTIN As Int32, ByVal PurchaseType As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewSBHGetByID(ByVal IRNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_BPID As String, ByVal Filter_IsgecGSTIN As Int32, ByVal Filter_PurchaseType As String) As SIS.SPMT.spmtNewSBH
      Return spmtNewSBHGetByID(IRNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtNewSBHInsert(ByVal Record As SIS.SPMT.spmtNewSBH) As SIS.SPMT.spmtNewSBH
      Dim _Rec As SIS.SPMT.spmtNewSBH = SIS.SPMT.spmtNewSBH.spmtNewSBHGetNewRecord()
      With _Rec
        .TranTypeID = Record.TranTypeID
        .SupplierName = Record.SupplierName
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .CreatedBy =  Global.System.Web.HttpContext.Current.Session("LoginID")
        .IRReceivedOn = Now
        .EmployeeID = Record.EmployeeID
        .CostCenterID = Record.CostCenterID
        .DepartmentID = Record.DepartmentID
        .BillRemarks = Record.BillRemarks
        .ProjectID = Record.ProjectID
        .ShipToState = Record.ShipToState
        .SupplierGSTINNumber = Record.SupplierGSTINNumber
        .SupplierGSTIN = Record.SupplierGSTIN
        .BPID = Record.BPID
        .IsgecGSTIN = Record.IsgecGSTIN
        .PurchaseType = Record.PurchaseType
        .ElementID = Record.ElementID
        .CreatedOn = Now
      End With
      Return SIS.SPMT.spmtNewSBH.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtNewSBH) As SIS.SPMT.spmtNewSBH
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Iif(Record.TranTypeID= "" ,Convert.DBNull, Record.TranTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName",SqlDbType.NVarChar,101, Iif(Record.SupplierName= "" ,Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillNumber",SqlDbType.NVarChar,51, Iif(Record.BillNumber= "" ,Convert.DBNull, Record.BillNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillDate",SqlDbType.DateTime,21, Iif(Record.BillDate= "" ,Convert.DBNull, Record.BillDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalBillAmount",SqlDbType.Decimal,21, Iif(Record.TotalBillAmount= "" ,Convert.DBNull, Record.TotalBillAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,11, Iif(Record.AdviceNo= "" ,Convert.DBNull, Record.AdviceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRReceivedOn",SqlDbType.DateTime,21, Iif(Record.IRReceivedOn= "" ,Convert.DBNull, Record.IRReceivedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo",SqlDbType.NVarChar,51, Iif(Record.UploadBatchNo= "" ,Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillRemarks",SqlDbType.NVarChar,501, Iif(Record.BillRemarks= "" ,Convert.DBNull, Record.BillRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ShipToState",SqlDbType.NVarChar,3, Iif(Record.ShipToState= "" ,Convert.DBNull, Record.ShipToState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTINNumber",SqlDbType.NVarChar,51, Iif(Record.SupplierGSTINNumber= "" ,Convert.DBNull, Record.SupplierGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTIN",SqlDbType.Int,11, Iif(Record.SupplierGSTIN= "" ,Convert.DBNull, Record.SupplierGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecGSTIN",SqlDbType.Int,11, Iif(Record.IsgecGSTIN= "" ,Convert.DBNull, Record.IsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PurchaseType",SqlDbType.NVarChar,51, Iif(Record.PurchaseType= "" ,Convert.DBNull, Record.PurchaseType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          Cmd.Parameters.Add("@Return_IRNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_IRNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.IRNo = Cmd.Parameters("@Return_IRNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtNewSBHUpdate(ByVal Record As SIS.SPMT.spmtNewSBH) As SIS.SPMT.spmtNewSBH
      Dim _Rec As SIS.SPMT.spmtNewSBH = SIS.SPMT.spmtNewSBH.spmtNewSBHGetByID(Record.IRNo)
      With _Rec
        .TranTypeID = Record.TranTypeID
        .SupplierName = Record.SupplierName
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .TotalBillAmount = Record.TotalBillAmount
        .EmployeeID = Record.EmployeeID
        .CostCenterID = Record.CostCenterID
        .DepartmentID = Record.DepartmentID
        .BillRemarks = Record.BillRemarks
        .ProjectID = Record.ProjectID
        .ShipToState = Record.ShipToState
        .SupplierGSTINNumber = Record.SupplierGSTINNumber
        .SupplierGSTIN = Record.SupplierGSTIN
        .BPID = Record.BPID
        .IsgecGSTIN = Record.IsgecGSTIN
        .PurchaseType = Record.PurchaseType
        .ElementID = Record.ElementID
        .CreatedOn = Now
      End With
      Return SIS.SPMT.spmtNewSBH.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtNewSBH) As SIS.SPMT.spmtNewSBH
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_IRNo",SqlDbType.Int,11, Record.IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Iif(Record.TranTypeID= "" ,Convert.DBNull, Record.TranTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName",SqlDbType.NVarChar,101, Iif(Record.SupplierName= "" ,Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillNumber",SqlDbType.NVarChar,51, Iif(Record.BillNumber= "" ,Convert.DBNull, Record.BillNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillDate",SqlDbType.DateTime,21, Iif(Record.BillDate= "" ,Convert.DBNull, Record.BillDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalBillAmount",SqlDbType.Decimal,21, Iif(Record.TotalBillAmount= "" ,Convert.DBNull, Record.TotalBillAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,11, Iif(Record.AdviceNo= "" ,Convert.DBNull, Record.AdviceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRReceivedOn",SqlDbType.DateTime,21, Iif(Record.IRReceivedOn= "" ,Convert.DBNull, Record.IRReceivedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo",SqlDbType.NVarChar,51, Iif(Record.UploadBatchNo= "" ,Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillRemarks",SqlDbType.NVarChar,501, Iif(Record.BillRemarks= "" ,Convert.DBNull, Record.BillRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ShipToState",SqlDbType.NVarChar,3, Iif(Record.ShipToState= "" ,Convert.DBNull, Record.ShipToState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTINNumber",SqlDbType.NVarChar,51, Iif(Record.SupplierGSTINNumber= "" ,Convert.DBNull, Record.SupplierGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTIN",SqlDbType.Int,11, Iif(Record.SupplierGSTIN= "" ,Convert.DBNull, Record.SupplierGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecGSTIN",SqlDbType.Int,11, Iif(Record.IsgecGSTIN= "" ,Convert.DBNull, Record.IsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PurchaseType",SqlDbType.NVarChar,51, Iif(Record.PurchaseType= "" ,Convert.DBNull, Record.PurchaseType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
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
    Public Shared Function spmtNewSBHDelete(ByVal Record As SIS.SPMT.spmtNewSBH) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_IRNo",SqlDbType.Int,Record.IRNo.ToString.Length, Record.IRNo)
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
    Public Shared Function SelectspmtNewSBHAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewSBHAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, 1))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.SPMT.spmtNewSBH = New SIS.SPMT.spmtNewSBH(Reader)
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
