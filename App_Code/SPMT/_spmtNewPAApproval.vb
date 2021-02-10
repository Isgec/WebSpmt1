Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()>
  Partial Public Class spmtNewPAApproval
    Private Shared _RecordCount As Integer
    Public Property AdviceNo As Int32 = 0
    Public Property TranTypeID As String = ""
    Public Property BPID As String = ""
    Public Property SupplierName As String = ""
    Public Property ConcernedHOD As String = ""
    Public Property Remarks As String = ""
    Public Property AdvanceRate As String = "0.00"
    Public Property AdvanceAmount As String = "0.00"
    Public Property RetensionRate As String = "0.00"
    Public Property RetensionAmount As String = "0.00"
    Public Property AccountsRemarks As String = ""
    Public Property StatusID As String = ""
    Public Property ReceivedInACBy As String = ""
    Public Property TotalAdviceAmount As String = "0.00"
    Public Property ReceivedInACOn As String = ""
    Private _CreatedOn As String = ""
    Public Property PostedInACBy As String = ""
    Public Property ERPCompany As String = ""
    Public Property LockedInACBy As String = ""
    Public Property UploadBatchNo As String = ""
    Public Property PostedInACOn As String = ""
    Public Property VoucherNo As String = ""
    Public Property CreatedBy As String = ""
    Public Property VoucherType As String = ""
    Public Property LockedInACOn As String = ""
    Public Property aspnet_Users1_UserFullName As String = ""
    Public Property aspnet_Users2_UserFullName As String = ""
    Public Property aspnet_Users3_UserFullName As String = ""
    Public Property aspnet_Users4_UserFullName As String = ""
    Public Property HRM_Employees5_EmployeeName As String = ""
    Public Property SPMT_PAStatus6_Description As String = ""
    Public Property SPMT_TranTypes7_Description As String = ""
    Public Property VR_BusinessPartner8_BPName As String = ""
    Private _FK_SPMT_newPA_CreatedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_newPA_ConcernedHOD As SIS.COM.comEmployees = Nothing
    Private _FK_SPMT_newPA_StatusID As SIS.SPMT.spmtPAStatus = Nothing
    Private _FK_SPMT_newPA_TranTypeID As SIS.SPMT.spmtTranTypes = Nothing
    Private _FK_SPMT_newPA_BPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property CreatedOn() As String
      Get
        If Not _CreatedOn = String.Empty Then
          Return Convert.ToDateTime(_CreatedOn).ToString("dd/MM/yyyy")
        End If
        Return _CreatedOn
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _CreatedOn = ""
        Else
          _CreatedOn = value
        End If
      End Set
    End Property
    Public ReadOnly Property PrimaryKey() As String
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
    Public ReadOnly Property FK_SPMT_newPA_CreatedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_newPA_CreatedBy Is Nothing Then
          _FK_SPMT_newPA_CreatedBy = SIS.COM.comUsers.comUsersGetByID(_CreatedBy)
        End If
        Return _FK_SPMT_newPA_CreatedBy
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
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function UnderApprovalSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal BPID As String, ByVal CreatedBy As String) As List(Of SIS.SPMT.spmtNewPAApproval)
      Dim Results As List(Of SIS.SPMT.spmtNewPAApproval) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_UnderApprovalSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_UnderApprovalSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CreatedBy", SqlDbType.NVarChar, 8, IIf(CreatedBy Is Nothing, String.Empty, CreatedBy))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtNewPAApproval)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtNewPAApproval(Reader))
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
    Public Sub New(ByVal Reader As SqlDataReader)
      SIS.SYS.SQLDatabase.DBCommon.NewObj(Me, Reader)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
