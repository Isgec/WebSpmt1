Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtNewPA
    Private Shared _RecordCount As Integer
    Private _AdviceNo As Int32 = 0
    Private _TranTypeID As String = ""
    Private _BPID As String = ""
    Private _SupplierName As String = ""
    Private _ConcernedHOD As String = ""
    Private _Remarks As String = ""
    Private _AdvanceRate As String = "0.00"
    Private _AdvanceAmount As String = "0.00"
    Private _RetensionRate As String = "0.00"
    Private _RetensionAmount As String = "0.00"
    Private _AccountsRemarks As String = ""
    Private _StatusID As String = ""
    Private _ReceivedInACBy As String = ""
    Private _TotalAdviceAmount As String = "0.00"
    Private _ReceivedInACOn As String = ""
    Private _CreatedOn As String = ""
    Private _PostedInACBy As String = ""
    Private _ERPCompany As String = ""
    Private _LockedInACBy As String = ""
    Private _UploadBatchNo As String = ""
    Private _PostedInACOn As String = ""
    Private _VoucherNo As String = ""
    Private _CreatedBy As String = ""
    Private _VoucherType As String = ""
    Private _LockedInACOn As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _aspnet_Users2_UserFullName As String = ""
    Private _aspnet_Users3_UserFullName As String = ""
    Private _aspnet_Users4_UserFullName As String = ""
    Private _HRM_Employees5_EmployeeName As String = ""
    Private _SPMT_PAStatus6_Description As String = ""
    Private _SPMT_TranTypes7_Description As String = ""
    Private _VR_BusinessPartner8_BPName As String = ""
    Private _FK_SPMT_newPA_CreatedOn As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_newPA_ReceivedInACBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_newPA_PostedInACBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_newPA_LockedInACBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_newPA_ConcernedHOD As SIS.COM.comEmployees = Nothing
    Private _FK_SPMT_newPA_StatusID As SIS.SPMT.spmtPAStatus = Nothing
    Private _FK_SPMT_newPA_TranTypeID As SIS.SPMT.spmtTranTypes = Nothing
    Private _FK_SPMT_newPA_BPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Public Property OldAdviceNo As String = ""
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
         If Convert.IsDBNull(Value) Then
           _TranTypeID = ""
         Else
           _TranTypeID = value
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
    Public Property AdvanceRate() As String
      Get
        Return _AdvanceRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AdvanceRate = "0.00"
         Else
           _AdvanceRate = value
         End If
      End Set
    End Property
    Public Property AdvanceAmount() As String
      Get
        Return _AdvanceAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AdvanceAmount = "0.00"
         Else
           _AdvanceAmount = value
         End If
      End Set
    End Property
    Public Property RetensionRate() As String
      Get
        Return _RetensionRate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RetensionRate = "0.00"
         Else
           _RetensionRate = value
         End If
      End Set
    End Property
    Public Property RetensionAmount() As String
      Get
        Return _RetensionAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RetensionAmount = "0.00"
         Else
           _RetensionAmount = value
         End If
      End Set
    End Property
    Public Property AccountsRemarks() As String
      Get
        Return _AccountsRemarks
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AccountsRemarks = ""
         Else
           _AccountsRemarks = value
         End If
      End Set
    End Property
    Public Property StatusID() As String
      Get
        Return _StatusID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _StatusID = ""
         Else
           _StatusID = value
         End If
      End Set
    End Property
    Public Property ReceivedInACBy() As String
      Get
        Return _ReceivedInACBy
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ReceivedInACBy = ""
         Else
           _ReceivedInACBy = value
         End If
      End Set
    End Property
    Public Property TotalAdviceAmount() As String
      Get
        Return _TotalAdviceAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TotalAdviceAmount = "0.00"
         Else
           _TotalAdviceAmount = value
         End If
      End Set
    End Property
    Public Property ReceivedInACOn() As String
      Get
        If Not _ReceivedInACOn = String.Empty Then
          Return Convert.ToDateTime(_ReceivedInACOn).ToString("dd/MM/yyyy")
        End If
        Return _ReceivedInACOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ReceivedInACOn = ""
         Else
           _ReceivedInACOn = value
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
    Public Property PostedInACBy() As String
      Get
        Return _PostedInACBy
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PostedInACBy = ""
         Else
           _PostedInACBy = value
         End If
      End Set
    End Property
    Public Property ERPCompany() As String
      Get
        Return _ERPCompany
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ERPCompany = ""
         Else
           _ERPCompany = value
         End If
      End Set
    End Property
    Public Property LockedInACBy() As String
      Get
        Return _LockedInACBy
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _LockedInACBy = ""
         Else
           _LockedInACBy = value
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
    Public Property PostedInACOn() As String
      Get
        If Not _PostedInACOn = String.Empty Then
          Return Convert.ToDateTime(_PostedInACOn).ToString("dd/MM/yyyy")
        End If
        Return _PostedInACOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PostedInACOn = ""
         Else
           _PostedInACOn = value
         End If
      End Set
    End Property
    Public Property VoucherNo() As String
      Get
        Return _VoucherNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VoucherNo = ""
         Else
           _VoucherNo = value
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
    Public Property VoucherType() As String
      Get
        Return _VoucherType
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VoucherType = ""
         Else
           _VoucherType = value
         End If
      End Set
    End Property
    Public Property LockedInACOn() As String
      Get
        If Not _LockedInACOn = String.Empty Then
          Return Convert.ToDateTime(_LockedInACOn).ToString("dd/MM/yyyy")
        End If
        Return _LockedInACOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _LockedInACOn = ""
         Else
           _LockedInACOn = value
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
    Public Property aspnet_Users4_UserFullName() As String
      Get
        Return _aspnet_Users4_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users4_UserFullName = value
      End Set
    End Property
    Public Property HRM_Employees5_EmployeeName() As String
      Get
        Return _HRM_Employees5_EmployeeName
      End Get
      Set(ByVal value As String)
        _HRM_Employees5_EmployeeName = value
      End Set
    End Property
    Public Property SPMT_PAStatus6_Description() As String
      Get
        Return _SPMT_PAStatus6_Description
      End Get
      Set(ByVal value As String)
        _SPMT_PAStatus6_Description = value
      End Set
    End Property
    Public Property SPMT_TranTypes7_Description() As String
      Get
        Return _SPMT_TranTypes7_Description
      End Get
      Set(ByVal value As String)
        _SPMT_TranTypes7_Description = value
      End Set
    End Property
    Public Property VR_BusinessPartner8_BPName() As String
      Get
        Return _VR_BusinessPartner8_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner8_BPName = value
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
    Public Class PKspmtNewPA
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
    Public ReadOnly Property FK_SPMT_newPA_CreatedOn() As SIS.COM.comUsers
      Get
        If _FK_SPMT_newPA_CreatedOn Is Nothing Then
          _FK_SPMT_newPA_CreatedOn = SIS.COM.comUsers.comUsersGetByID(_CreatedBy)
        End If
        Return _FK_SPMT_newPA_CreatedOn
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_ReceivedInACBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_newPA_ReceivedInACBy Is Nothing Then
          _FK_SPMT_newPA_ReceivedInACBy = SIS.COM.comUsers.comUsersGetByID(_ReceivedInACBy)
        End If
        Return _FK_SPMT_newPA_ReceivedInACBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_PostedInACBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_newPA_PostedInACBy Is Nothing Then
          _FK_SPMT_newPA_PostedInACBy = SIS.COM.comUsers.comUsersGetByID(_PostedInACBy)
        End If
        Return _FK_SPMT_newPA_PostedInACBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_LockedInACBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_newPA_LockedInACBy Is Nothing Then
          _FK_SPMT_newPA_LockedInACBy = SIS.COM.comUsers.comUsersGetByID(_LockedInACBy)
        End If
        Return _FK_SPMT_newPA_LockedInACBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_ConcernedHOD() As SIS.COM.comEmployees
      Get
        If _FK_SPMT_newPA_ConcernedHOD Is Nothing Then
          _FK_SPMT_newPA_ConcernedHOD = SIS.COM.comEmployees.comEmployeesGetByID(_ConcernedHOD)
        End If
        Return _FK_SPMT_newPA_ConcernedHOD
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_StatusID() As SIS.SPMT.spmtPAStatus
      Get
        If _FK_SPMT_newPA_StatusID Is Nothing Then
          _FK_SPMT_newPA_StatusID = SIS.SPMT.spmtPAStatus.spmtPAStatusGetByID(_StatusID)
        End If
        Return _FK_SPMT_newPA_StatusID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_TranTypeID() As SIS.SPMT.spmtTranTypes
      Get
        If _FK_SPMT_newPA_TranTypeID Is Nothing Then
          _FK_SPMT_newPA_TranTypeID = SIS.SPMT.spmtTranTypes.spmtTranTypesGetByID(_TranTypeID)
        End If
        Return _FK_SPMT_newPA_TranTypeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_newPA_BPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_newPA_BPID Is Nothing Then
          _FK_SPMT_newPA_BPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_BPID)
        End If
        Return _FK_SPMT_newPA_BPID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewPASelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtNewPA)
      Dim Results As List(Of SIS.SPMT.spmtNewPA) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewPASelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewPA)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewPA(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewPAGetNewRecord() As SIS.SPMT.spmtNewPA
      Return New SIS.SPMT.spmtNewPA()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewPAGetByID(ByVal AdviceNo As Int32) As SIS.SPMT.spmtNewPA
      Dim Results As SIS.SPMT.spmtNewPA = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewPASelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,AdviceNo.ToString.Length, AdviceNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtNewPA(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewPASelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal CreatedBy As String) As List(Of SIS.SPMT.spmtNewPA)
      Dim Results As List(Of SIS.SPMT.spmtNewPA) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtNewPASelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtNewPASelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CreatedBy",SqlDbType.NVarChar,8, IIf(CreatedBy Is Nothing, String.Empty,CreatedBy))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewPA)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewPA(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtNewPASelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal CreatedBy As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtNewPAGetByID(ByVal AdviceNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_BPID As String, ByVal Filter_CreatedBy As String) As SIS.SPMT.spmtNewPA
      Return spmtNewPAGetByID(AdviceNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtNewPAInsert(ByVal Record As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      Dim _Rec As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetNewRecord()
      With _Rec
        .TranTypeID = Record.TranTypeID
        .BPID = Record.BPID
        .SupplierName = Record.SupplierName
        .ConcernedHOD = Record.ConcernedHOD
        .Remarks = Record.Remarks
        .AdvanceRate = Record.AdvanceRate
        .AdvanceAmount = Record.AdvanceAmount
        .RetensionRate = Record.RetensionRate
        .RetensionAmount = Record.RetensionAmount
        .StatusID = spmtPAStates.Free
        .TotalAdviceAmount = Record.TotalAdviceAmount
        .CreatedOn = Now
        .CreatedBy =  Global.System.Web.HttpContext.Current.Session("LoginID")
      End With
      Return SIS.SPMT.spmtNewPA.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewPAInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Iif(Record.TranTypeID= "" ,Convert.DBNull, Record.TranTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName",SqlDbType.NVarChar,101, Iif(Record.SupplierName= "" ,Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConcernedHOD",SqlDbType.NVarChar,9, Iif(Record.ConcernedHOD= "" ,Convert.DBNull, Record.ConcernedHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,501, Iif(Record.Remarks= "" ,Convert.DBNull, Record.Remarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceRate",SqlDbType.Decimal,21, Iif(Record.AdvanceRate= "" ,Convert.DBNull, Record.AdvanceRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceAmount",SqlDbType.Decimal,21, Iif(Record.AdvanceAmount= "" ,Convert.DBNull, Record.AdvanceAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionRate",SqlDbType.Decimal,21, Iif(Record.RetensionRate= "" ,Convert.DBNull, Record.RetensionRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionAmount",SqlDbType.Decimal,21, Iif(Record.RetensionAmount= "" ,Convert.DBNull, Record.RetensionAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AccountsRemarks",SqlDbType.NVarChar,101, Iif(Record.AccountsRemarks= "" ,Convert.DBNull, Record.AccountsRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedInACBy",SqlDbType.NVarChar,9, Iif(Record.ReceivedInACBy= "" ,Convert.DBNull, Record.ReceivedInACBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAdviceAmount",SqlDbType.Decimal,21, Iif(Record.TotalAdviceAmount= "" ,Convert.DBNull, Record.TotalAdviceAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedInACOn",SqlDbType.DateTime,21, Iif(Record.ReceivedInACOn= "" ,Convert.DBNull, Record.ReceivedInACOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PostedInACBy",SqlDbType.NVarChar,9, Iif(Record.PostedInACBy= "" ,Convert.DBNull, Record.PostedInACBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ERPCompany",SqlDbType.NVarChar,4, Iif(Record.ERPCompany= "" ,Convert.DBNull, Record.ERPCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LockedInACBy",SqlDbType.NVarChar,9, Iif(Record.LockedInACBy= "" ,Convert.DBNull, Record.LockedInACBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo",SqlDbType.NVarChar,51, Iif(Record.UploadBatchNo= "" ,Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PostedInACOn",SqlDbType.DateTime,21, Iif(Record.PostedInACOn= "" ,Convert.DBNull, Record.PostedInACOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherNo",SqlDbType.NVarChar,11, Iif(Record.VoucherNo= "" ,Convert.DBNull, Record.VoucherNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherType",SqlDbType.NVarChar,4, Iif(Record.VoucherType= "" ,Convert.DBNull, Record.VoucherType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LockedInACOn",SqlDbType.DateTime,21, Iif(Record.LockedInACOn= "" ,Convert.DBNull, Record.LockedInACOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OldAdviceNo", SqlDbType.Int, 11, IIf(Record.OldAdviceNo = "", Convert.DBNull, Record.OldAdviceNo))
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
    Public Shared Function spmtNewPAUpdate(ByVal Record As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      Dim _Rec As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(Record.AdviceNo)
      With _Rec
        .TranTypeID = Record.TranTypeID
        .BPID = Record.BPID
        .SupplierName = Record.SupplierName
        .ConcernedHOD = Record.ConcernedHOD
        .Remarks = Record.Remarks
        .AdvanceRate = Record.AdvanceRate
        .AdvanceAmount = Record.AdvanceAmount
        .RetensionRate = Record.RetensionRate
        .RetensionAmount = Record.RetensionAmount
        .AccountsRemarks = Record.AccountsRemarks
        .TotalAdviceAmount = Record.TotalAdviceAmount
        .CreatedOn = Now
        .VoucherNo = Record.VoucherNo
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .VoucherType = Record.VoucherType
        .LockedInACOn = Record.LockedInACOn
      End With
      Return SIS.SPMT.spmtNewPA.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtNewPA) As SIS.SPMT.spmtNewPA
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewPAUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_AdviceNo",SqlDbType.Int,11, Record.AdviceNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Iif(Record.TranTypeID= "" ,Convert.DBNull, Record.TranTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName",SqlDbType.NVarChar,101, Iif(Record.SupplierName= "" ,Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConcernedHOD",SqlDbType.NVarChar,9, Iif(Record.ConcernedHOD= "" ,Convert.DBNull, Record.ConcernedHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,501, Iif(Record.Remarks= "" ,Convert.DBNull, Record.Remarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceRate",SqlDbType.Decimal,21, Iif(Record.AdvanceRate= "" ,Convert.DBNull, Record.AdvanceRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdvanceAmount",SqlDbType.Decimal,21, Iif(Record.AdvanceAmount= "" ,Convert.DBNull, Record.AdvanceAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionRate",SqlDbType.Decimal,21, Iif(Record.RetensionRate= "" ,Convert.DBNull, Record.RetensionRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RetensionAmount",SqlDbType.Decimal,21, Iif(Record.RetensionAmount= "" ,Convert.DBNull, Record.RetensionAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AccountsRemarks",SqlDbType.NVarChar,101, Iif(Record.AccountsRemarks= "" ,Convert.DBNull, Record.AccountsRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedInACBy",SqlDbType.NVarChar,9, Iif(Record.ReceivedInACBy= "" ,Convert.DBNull, Record.ReceivedInACBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAdviceAmount",SqlDbType.Decimal,21, Iif(Record.TotalAdviceAmount= "" ,Convert.DBNull, Record.TotalAdviceAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedInACOn",SqlDbType.DateTime,21, Iif(Record.ReceivedInACOn= "" ,Convert.DBNull, Record.ReceivedInACOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PostedInACBy",SqlDbType.NVarChar,9, Iif(Record.PostedInACBy= "" ,Convert.DBNull, Record.PostedInACBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ERPCompany",SqlDbType.NVarChar,4, Iif(Record.ERPCompany= "" ,Convert.DBNull, Record.ERPCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LockedInACBy",SqlDbType.NVarChar,9, Iif(Record.LockedInACBy= "" ,Convert.DBNull, Record.LockedInACBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo",SqlDbType.NVarChar,51, Iif(Record.UploadBatchNo= "" ,Convert.DBNull, Record.UploadBatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PostedInACOn",SqlDbType.DateTime,21, Iif(Record.PostedInACOn= "" ,Convert.DBNull, Record.PostedInACOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherNo",SqlDbType.NVarChar,11, Iif(Record.VoucherNo= "" ,Convert.DBNull, Record.VoucherNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherType",SqlDbType.NVarChar,4, Iif(Record.VoucherType= "" ,Convert.DBNull, Record.VoucherType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LockedInACOn",SqlDbType.DateTime,21, Iif(Record.LockedInACOn= "" ,Convert.DBNull, Record.LockedInACOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OldAdviceNo", SqlDbType.Int, 11, IIf(Record.OldAdviceNo = "", Convert.DBNull, Record.OldAdviceNo))
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
    Public Shared Function spmtNewPADelete(ByVal Record As SIS.SPMT.spmtNewPA) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewPADelete"
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
    Public Shared Function SelectspmtNewPAAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtNewPAAutoCompleteList"
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
            Dim Tmp As SIS.SPMT.spmtNewPA = New SIS.SPMT.spmtNewPA(Reader)
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
