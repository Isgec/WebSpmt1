Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtPaymentAdvice
    Private Shared _RecordCount As Integer
    Private _AdviceNo As Int32 = 0
    Private _TranTypeID As String = ""
    Private _BPID As String = ""
    Private _ConcernedHOD As String = ""
    Private _CostCenter As String = ""
    Private _AdviceStatusUser As String = ""
    Private _AdviceStatusID As Int32 = 0
    Private _RemarksAC As String = ""
    Private _VendorID As String = ""
    Private _AdviceStatusOn As String = ""
    Private _Remarks As String = ""
    Private _RemarksHOD As String = ""
    Private _RemarksHR As String = ""
    Private _Returned As String = ""
    Private _Forward As String = ""
    Private _ProjectID As String = ""
    Private _ElementID As String = ""
    Private _CostCenterID As String = ""
    Private _EmployeeID As String = ""
    Private _DepartmentID As String = ""
    Private _VoucherNo As String = ""
    Private _DocumentNo As String = ""
    Private _BaaNCompany As String = ""
    Private _BaaNLedger As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _aspnet_Users2_UserFullName As String = ""
    Private _aspnet_Users3_UserFullName As String = ""
    Private _HRM_Departments4_Description As String = ""
    Private _IDM_Projects5_Description As String = ""
    Private _IDM_WBS6_Description As String = ""
    Private _SPMT_CostCenters8_Description As String = ""
    Private _SPMT_PAStatus9_Description As String = ""
    Private _SPMT_TranTypes10_Description As String = ""
    Private _VR_BusinessPartner11_BPName As String = ""
    Private _FK_SPMT_PaymentAdvice_AdviceStatusUser As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_PaymentAdvice_ConcernedHOD As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_PaymentAdvice_EmployeeID As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_PaymentAdvice_DepartmentsID As SIS.COM.comDepartments = Nothing
    Private _FK_SPMT_PaymentAdvice_ProjectsID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_PaymentAdvice_WBS As SIS.COM.comElements = Nothing
    Private _FK_SPMT_PaymentAdvice_CostCenterID As SIS.SPMT.spmtCostCenters = Nothing
    Private _FK_SPMT_PaymentAdvice_PAStatus As SIS.SPMT.spmtPAStatus = Nothing
    Private _FK_SPMT_PaymentAdvice_TranTypeID As SIS.SPMT.spmtTranTypes = Nothing
    Private _FK_SPMT_PaymentAdvice_BPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Public Property SupplierName As String = ""
    Public Property AdvanceRate As String = "0.00"
    Public Property AdvanceAmount As String = "0.00"
    Public Property RetensionRate As String = "0.00"
    Public Property RetensionAmount As String = "0.00"
    Public Property UploadBatchNo As String = ""
    Public Property ApprovalRemarks As String = ""
    Private Property _ApprovedOn As String = ""
    Public Property ApprovedOn() As String
      Get
        If Not _ApprovedOn = String.Empty Then
          Return Convert.ToDateTime(_ApprovedOn).ToString("dd/MM/yyyy")
        End If
        Return _ApprovedOn
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ApprovedOn = ""
        Else
          _ApprovedOn = value
        End If
      End Set
    End Property

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
    Public Property AdviceNo() As Int32
      Get
        Return _AdviceNo
      End Get
      Set(ByVal value As Int32)
        _AdviceNo = value
      End Set
    End Property
    Public Property TranTypeID() As String
      Get
        Return _TranTypeID
      End Get
      Set(ByVal value As String)
        _TranTypeID = value
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
    Public Property ConcernedHOD() As String
      Get
        Return _ConcernedHOD
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConcernedHOD = ""
         Else
           _ConcernedHOD = value
         End If
      End Set
    End Property
    Public Property CostCenter() As String
      Get
        Return _CostCenter
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CostCenter = ""
         Else
           _CostCenter = value
         End If
      End Set
    End Property
    Public Property AdviceStatusUser() As String
      Get
        Return _AdviceStatusUser
      End Get
      Set(ByVal value As String)
        _AdviceStatusUser = value
      End Set
    End Property
    Public Property AdviceStatusID() As Int32
      Get
        Return _AdviceStatusID
      End Get
      Set(ByVal value As Int32)
        _AdviceStatusID = value
      End Set
    End Property
    Public Property RemarksAC() As String
      Get
        Return _RemarksAC
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RemarksAC = ""
         Else
           _RemarksAC = value
         End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property VendorID() As String
      Get
        Return _VendorID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _VendorID = ""
        Else
          _VendorID = value
        End If
      End Set
    End Property
    Public Property AdviceStatusOn() As String
      Get
        If Not _AdviceStatusOn = String.Empty Then
          Return Convert.ToDateTime(_AdviceStatusOn).ToString("dd/MM/yyyy")
        End If
        Return _AdviceStatusOn
      End Get
      Set(ByVal value As String)
         _AdviceStatusOn = value
      End Set
    End Property
    Public Property Remarks() As String
      Get
        Return _Remarks
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Remarks = ""
         Else
           _Remarks = value
         End If
      End Set
    End Property
    Public Property RemarksHOD() As String
      Get
        Return _RemarksHOD
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RemarksHOD = ""
         Else
           _RemarksHOD = value
         End If
      End Set
    End Property
    Public Property RemarksHR() As String
      Get
        Return _RemarksHR
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RemarksHR = ""
         Else
           _RemarksHR = value
         End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property Returned() As String
      Get
        Return _Returned
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Returned = ""
        Else
          _Returned = value
        End If
      End Set
    End Property
    Public Property Forward() As String
      Get
        Return _Forward
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Forward = ""
         Else
           _Forward = value
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
    <SYS.Utilities.lgSkip()>
    Public Property DepartmentID() As String
      Get
        Return _DepartmentID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DepartmentID = ""
        Else
          _DepartmentID = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property VoucherNo() As String
      Get
        Return _VoucherNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _VoucherNo = ""
        Else
          _VoucherNo = value
        End If
      End Set
    End Property
    Public Property DocumentNo() As String
      Get
        Return _DocumentNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _DocumentNo = ""
         Else
           _DocumentNo = value
         End If
      End Set
    End Property
    Public Property BaaNCompany() As String
      Get
        Return _BaaNCompany
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BaaNCompany = ""
         Else
           _BaaNCompany = value
         End If
      End Set
    End Property
    Public Property BaaNLedger() As String
      Get
        Return _BaaNLedger
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BaaNLedger = ""
         Else
           _BaaNLedger = value
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
    Public Property aspnet_Users2_UserFullName() As String
      Get
        Return _aspnet_Users2_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users2_UserFullName = value
      End Set
    End Property
    Public Property aspnet_Users3_UserFullName() As String
      Get
        Return _aspnet_Users3_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users3_UserFullName = value
      End Set
    End Property
    Public Property HRM_Departments4_Description() As String
      Get
        Return _HRM_Departments4_Description
      End Get
      Set(ByVal value As String)
        _HRM_Departments4_Description = value
      End Set
    End Property
    Public Property IDM_Projects5_Description() As String
      Get
        Return _IDM_Projects5_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects5_Description = value
      End Set
    End Property
    Public Property IDM_WBS6_Description() As String
      Get
        Return _IDM_WBS6_Description
      End Get
      Set(ByVal value As String)
        _IDM_WBS6_Description = value
      End Set
    End Property
    Public Property SPMT_CostCenters8_Description() As String
      Get
        Return _SPMT_CostCenters8_Description
      End Get
      Set(ByVal value As String)
        _SPMT_CostCenters8_Description = value
      End Set
    End Property
    Public Property SPMT_PAStatus9_Description() As String
      Get
        Return _SPMT_PAStatus9_Description
      End Get
      Set(ByVal value As String)
        _SPMT_PAStatus9_Description = value
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
    Public Property VR_BusinessPartner11_BPName() As String
      Get
        Return _VR_BusinessPartner11_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner11_BPName = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _BPID.ToString.PadRight(9, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _AdviceNo
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
    Public Class PKspmtPaymentAdvice
      Private _AdviceNo As Int32 = 0
      Public Property AdviceNo() As Int32
        Get
          Return _AdviceNo
        End Get
        Set(ByVal value As Int32)
          _AdviceNo = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_SPMT_PaymentAdvice_AdviceStatusUser() As SIS.COM.comUsers
      Get
        If _FK_SPMT_PaymentAdvice_AdviceStatusUser Is Nothing Then
          _FK_SPMT_PaymentAdvice_AdviceStatusUser = SIS.COM.comUsers.comUsersGetByID(_AdviceStatusUser)
        End If
        Return _FK_SPMT_PaymentAdvice_AdviceStatusUser
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_ConcernedHOD() As SIS.COM.comUsers
      Get
        If _FK_SPMT_PaymentAdvice_ConcernedHOD Is Nothing Then
          _FK_SPMT_PaymentAdvice_ConcernedHOD = SIS.COM.comUsers.comUsersGetByID(_ConcernedHOD)
        End If
        Return _FK_SPMT_PaymentAdvice_ConcernedHOD
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_EmployeeID() As SIS.COM.comUsers
      Get
        If _FK_SPMT_PaymentAdvice_EmployeeID Is Nothing Then
          _FK_SPMT_PaymentAdvice_EmployeeID = SIS.COM.comUsers.comUsersGetByID(_EmployeeID)
        End If
        Return _FK_SPMT_PaymentAdvice_EmployeeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_DepartmentsID() As SIS.COM.comDepartments
      Get
        If _FK_SPMT_PaymentAdvice_DepartmentsID Is Nothing Then
          _FK_SPMT_PaymentAdvice_DepartmentsID = SIS.COM.comDepartments.comDepartmentsGetByID(_DepartmentID)
        End If
        Return _FK_SPMT_PaymentAdvice_DepartmentsID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_ProjectsID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_PaymentAdvice_ProjectsID Is Nothing Then
          _FK_SPMT_PaymentAdvice_ProjectsID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_PaymentAdvice_ProjectsID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_WBS() As SIS.COM.comElements
      Get
        If _FK_SPMT_PaymentAdvice_WBS Is Nothing Then
          _FK_SPMT_PaymentAdvice_WBS = SIS.COM.comElements.comElementsGetByID(_ElementID)
        End If
        Return _FK_SPMT_PaymentAdvice_WBS
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_CostCenterID() As SIS.SPMT.spmtCostCenters
      Get
        If _FK_SPMT_PaymentAdvice_CostCenterID Is Nothing Then
          _FK_SPMT_PaymentAdvice_CostCenterID = SIS.SPMT.spmtCostCenters.spmtCostCentersGetByID(_CostCenterID)
        End If
        Return _FK_SPMT_PaymentAdvice_CostCenterID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_PAStatus() As SIS.SPMT.spmtPAStatus
      Get
        If _FK_SPMT_PaymentAdvice_PAStatus Is Nothing Then
          _FK_SPMT_PaymentAdvice_PAStatus = SIS.SPMT.spmtPAStatus.spmtPAStatusGetByID(_AdviceStatusID)
        End If
        Return _FK_SPMT_PaymentAdvice_PAStatus
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_TranTypeID() As SIS.SPMT.spmtTranTypes
      Get
        If _FK_SPMT_PaymentAdvice_TranTypeID Is Nothing Then
          _FK_SPMT_PaymentAdvice_TranTypeID = SIS.SPMT.spmtTranTypes.spmtTranTypesGetByID(_TranTypeID)
        End If
        Return _FK_SPMT_PaymentAdvice_TranTypeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_PaymentAdvice_BPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_PaymentAdvice_BPID Is Nothing Then
          _FK_SPMT_PaymentAdvice_BPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_BPID)
        End If
        Return _FK_SPMT_PaymentAdvice_BPID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtPaymentAdviceSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtPaymentAdvice)
      Dim Results As List(Of SIS.SPMT.spmtPaymentAdvice) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtPaymentAdviceSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtPaymentAdvice)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtPaymentAdvice(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtPaymentAdviceGetNewRecord() As SIS.SPMT.spmtPaymentAdvice
      Return New SIS.SPMT.spmtPaymentAdvice()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtPaymentAdviceGetByID(ByVal AdviceNo As Int32) As SIS.SPMT.spmtPaymentAdvice
      Dim Results As SIS.SPMT.spmtPaymentAdvice = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtPaymentAdviceSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,AdviceNo.ToString.Length, AdviceNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtPaymentAdvice(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtPaymentAdviceSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32, ByVal TranTypeID As String, ByVal BPID As String) As List(Of SIS.SPMT.spmtPaymentAdvice)
      Dim Results As List(Of SIS.SPMT.spmtPaymentAdvice) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtPaymentAdviceSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtPaymentAdviceSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo",SqlDbType.Int,10, IIf(AdviceNo = Nothing, 0,AdviceNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtPaymentAdvice)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtPaymentAdvice(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtPaymentAdviceSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32, ByVal TranTypeID As String, ByVal BPID As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtPaymentAdviceGetByID(ByVal AdviceNo As Int32, ByVal Filter_AdviceNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_BPID As String) As SIS.SPMT.spmtPaymentAdvice
      Return spmtPaymentAdviceGetByID(AdviceNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtPaymentAdviceInsert(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      Dim _Rec As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetNewRecord()
      With _Rec
        .TranTypeID = Record.TranTypeID
        .BPID = Record.BPID
        .ConcernedHOD = Record.ConcernedHOD
        .AdviceStatusUser = Record.AdviceStatusUser
        .AdviceStatusID = Record.AdviceStatusID
        .AdviceStatusOn = Record.AdviceStatusOn
        .Remarks = Record.Remarks
        .ProjectID = Record.ProjectID
        .ElementID = Record.ElementID
        .CostCenterID = Record.CostCenterID
        .EmployeeID = Record.EmployeeID
        .DepartmentID = Record.DepartmentID
        .SupplierName = Record.SupplierName
        .AdvanceRate = Record.AdvanceRate
        .AdvanceAmount = Record.AdvanceAmount
        .RetensionRate = Record.RetensionRate
        .RetensionAmount = Record.RetensionAmount
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtPaymentAdvice.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtPaymentAdviceInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Record.TranTypeID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConcernedHOD",SqlDbType.NVarChar,9, Iif(Record.ConcernedHOD= "" ,Convert.DBNull, Record.ConcernedHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenter",SqlDbType.NVarChar,51, Iif(Record.CostCenter= "" ,Convert.DBNull, Record.CostCenter))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceStatusUser",SqlDbType.NVarChar,9, Record.AdviceStatusUser)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceStatusID",SqlDbType.Int,11, Record.AdviceStatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksAC",SqlDbType.NVarChar,501, Iif(Record.RemarksAC= "" ,Convert.DBNull, Record.RemarksAC))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID",SqlDbType.NVarChar,7, Iif(Record.VendorID= "" ,Convert.DBNull, Record.VendorID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceStatusOn",SqlDbType.DateTime,21, Record.AdviceStatusOn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,501, Iif(Record.Remarks= "" ,Convert.DBNull, Record.Remarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksHOD",SqlDbType.NVarChar,501, Iif(Record.RemarksHOD= "" ,Convert.DBNull, Record.RemarksHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksHR",SqlDbType.NVarChar,501, Iif(Record.RemarksHR= "" ,Convert.DBNull, Record.RemarksHR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Returned",SqlDbType.Bit,3, Iif(Record.Returned= "" ,Convert.DBNull, Record.Returned))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Forward",SqlDbType.Bit,3, Iif(Record.Forward= "" ,Convert.DBNull, Record.Forward))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherNo",SqlDbType.Int,11, Iif(Record.VoucherNo= "" ,Convert.DBNull, Record.VoucherNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentNo",SqlDbType.NVarChar,51, Iif(Record.DocumentNo= "" ,Convert.DBNull, Record.DocumentNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNCompany",SqlDbType.NVarChar,11, Iif(Record.BaaNCompany= "" ,Convert.DBNull, Record.BaaNCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNLedger",SqlDbType.NVarChar,21, Iif(Record.BaaNLedger= "" ,Convert.DBNull, Record.BaaNLedger))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName", SqlDbType.NVarChar, 101, IIf(Record.SupplierName = "", Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionRate", SqlDbType.Decimal, 21, IIf(Record.RetensionRate = "", Convert.DBNull, Record.RetensionRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceAmount", SqlDbType.Decimal, 21, IIf(Record.AdvanceAmount = "", Convert.DBNull, Record.AdvanceAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceRate", SqlDbType.Decimal, 21, IIf(Record.AdvanceRate = "", Convert.DBNull, Record.AdvanceRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionAmount", SqlDbType.Decimal, 21, IIf(Record.RetensionAmount = "", Convert.DBNull, Record.RetensionAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo", SqlDbType.NVarChar, 50, IIf(Record.UploadBatchNo = "", Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovedOn", SqlDbType.DateTime, 21, IIf(Record.ApprovedOn = "", Convert.DBNull, Record.ApprovedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovalRemarks", SqlDbType.NVarChar, 251, IIf(Record.ApprovalRemarks = "", Convert.DBNull, Record.ApprovalRemarks))
          Cmd.Parameters.Add("@Return_AdviceNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_AdviceNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.AdviceNo = Cmd.Parameters("@Return_AdviceNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtPaymentAdviceUpdate(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      Dim _Rec As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(Record.AdviceNo)
      With _Rec
        .TranTypeID = Record.TranTypeID
        .BPID = Record.BPID
        .ConcernedHOD = Record.ConcernedHOD
        .AdviceStatusUser = Record.AdviceStatusUser
        .AdviceStatusID = Record.AdviceStatusID
        .RemarksAC = Record.RemarksAC
        .AdviceStatusOn = Record.AdviceStatusOn
        .Remarks = Record.Remarks
        .ProjectID = Record.ProjectID
        .ElementID = Record.ElementID
        .CostCenterID = Record.CostCenterID
        .EmployeeID = Record.EmployeeID
        .DepartmentID = Record.DepartmentID
        .SupplierName = Record.SupplierName
        .AdvanceRate = Record.AdvanceRate
        .AdvanceAmount = Record.AdvanceAmount
        .RetensionRate = Record.RetensionRate
        .RetensionAmount = Record.RetensionAmount
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtPaymentAdvice.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtPaymentAdviceUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_AdviceNo",SqlDbType.Int,11, Record.AdviceNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Record.TranTypeID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConcernedHOD",SqlDbType.NVarChar,9, Iif(Record.ConcernedHOD= "" ,Convert.DBNull, Record.ConcernedHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenter",SqlDbType.NVarChar,51, Iif(Record.CostCenter= "" ,Convert.DBNull, Record.CostCenter))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceStatusUser",SqlDbType.NVarChar,9, Record.AdviceStatusUser)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceStatusID",SqlDbType.Int,11, Record.AdviceStatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksAC",SqlDbType.NVarChar,501, Iif(Record.RemarksAC= "" ,Convert.DBNull, Record.RemarksAC))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID",SqlDbType.NVarChar,7, Iif(Record.VendorID= "" ,Convert.DBNull, Record.VendorID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceStatusOn",SqlDbType.DateTime,21, Record.AdviceStatusOn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,501, Iif(Record.Remarks= "" ,Convert.DBNull, Record.Remarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksHOD",SqlDbType.NVarChar,501, Iif(Record.RemarksHOD= "" ,Convert.DBNull, Record.RemarksHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksHR",SqlDbType.NVarChar,501, Iif(Record.RemarksHR= "" ,Convert.DBNull, Record.RemarksHR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Returned",SqlDbType.Bit,3, Iif(Record.Returned= "" ,Convert.DBNull, Record.Returned))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Forward",SqlDbType.Bit,3, Iif(Record.Forward= "" ,Convert.DBNull, Record.Forward))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherNo",SqlDbType.Int,11, Iif(Record.VoucherNo= "" ,Convert.DBNull, Record.VoucherNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentNo",SqlDbType.NVarChar,51, Iif(Record.DocumentNo= "" ,Convert.DBNull, Record.DocumentNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNCompany",SqlDbType.NVarChar,11, Iif(Record.BaaNCompany= "" ,Convert.DBNull, Record.BaaNCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNLedger",SqlDbType.NVarChar,21, Iif(Record.BaaNLedger= "" ,Convert.DBNull, Record.BaaNLedger))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName", SqlDbType.NVarChar, 101, IIf(Record.SupplierName = "", Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionRate", SqlDbType.Decimal, 21, IIf(Record.RetensionRate = "", Convert.DBNull, Record.RetensionRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceAmount", SqlDbType.Decimal, 21, IIf(Record.AdvanceAmount = "", Convert.DBNull, Record.AdvanceAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceRate", SqlDbType.Decimal, 21, IIf(Record.AdvanceRate = "", Convert.DBNull, Record.AdvanceRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionAmount", SqlDbType.Decimal, 21, IIf(Record.RetensionAmount = "", Convert.DBNull, Record.RetensionAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo", SqlDbType.NVarChar, 50, IIf(Record.UploadBatchNo = "", Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovedOn", SqlDbType.DateTime, 21, IIf(Record.ApprovedOn = "", Convert.DBNull, Record.ApprovedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovalRemarks", SqlDbType.NVarChar, 251, IIf(Record.ApprovalRemarks = "", Convert.DBNull, Record.ApprovalRemarks))
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
    Public Shared Function spmtPaymentAdviceDelete(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtPaymentAdviceDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_AdviceNo",SqlDbType.Int,Record.AdviceNo.ToString.Length, Record.AdviceNo)
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
    Public Shared Function SelectspmtPaymentAdviceAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtPaymentAdviceAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, 1))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(9, " "),""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.SPMT.spmtPaymentAdvice = New SIS.SPMT.spmtPaymentAdvice(Reader)
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
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
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
