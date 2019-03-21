Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtBTADetails
    Private Shared _RecordCount As Integer
    Private _SerialNo As Int32 = 0
    Private _CORP_2 As String = ""
    Private _CORP_1 As String = ""
    Private _BTA_ACCT As String = ""
    Private _STMT_DT As String = ""
    Private _STMT_REF_NO As String = ""
    Private _CUST_REF As String = ""
    Private _TRIP_REQ As String = ""
    Private _JOB_NO As String = ""
    Private _PAX_NM As String = ""
    Private _AMOUNT_EX_GST As String = "0.00"
    Private _GST As String = "0.00"
    Private _UNPAID_AMT As String = "0.00"
    Private _CHARGE_DTE As String = ""
    Private _BKNG_DATE As String = ""
    Private _DEPT_DATE As String = ""
    Private _TICKET_NO As String = ""
    Private _CARRIER As String = ""
    Private _CLASS As String = ""
    Private _DI As String = ""
    Private _ROUTING As String = ""
    Private _TXN_DATE As String = ""
    Private _Merchant_ABN As String = ""
    Private _Book_Ref As String = ""
    Private _COMMENT1 As String = ""
    Private _COMMENT2 As String = ""
    Private _COMMENT3 As String = ""
    Private _MERCHANT_NAME As String = ""
    Private _BatchNo As String = ""
    Private _StatusID As String = ""
    Private _CreatedBy As String = ""
    Private _CreatedOn As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _SPMT_BTAStatus2_Descriptions As String = ""
    Private _FK_SPMT_BTADetails_CreatedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_BTADetails_StatusID As SIS.SPMT.spmtBTAStatus = Nothing
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
    Public Property SerialNo() As Int32
      Get
        Return _SerialNo
      End Get
      Set(ByVal value As Int32)
        _SerialNo = value
      End Set
    End Property
    Public Property CORP_2() As String
      Get
        Return _CORP_2
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CORP_2 = ""
         Else
           _CORP_2 = value
         End If
      End Set
    End Property
    Public Property CORP_1() As String
      Get
        Return _CORP_1
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CORP_1 = ""
         Else
           _CORP_1 = value
         End If
      End Set
    End Property
    Public Property BTA_ACCT() As String
      Get
        Return _BTA_ACCT
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BTA_ACCT = ""
         Else
           _BTA_ACCT = value
         End If
      End Set
    End Property
    Public Property STMT_DT() As String
      Get
        If Not _STMT_DT = String.Empty Then
          Return Convert.ToDateTime(_STMT_DT).ToString("dd/MM/yyyy")
        End If
        Return _STMT_DT
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _STMT_DT = ""
         Else
           _STMT_DT = value
         End If
      End Set
    End Property
    Public Property STMT_REF_NO() As String
      Get
        Return _STMT_REF_NO
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _STMT_REF_NO = ""
         Else
           _STMT_REF_NO = value
         End If
      End Set
    End Property
    Public Property CUST_REF() As String
      Get
        Return _CUST_REF
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CUST_REF = ""
         Else
           _CUST_REF = value
         End If
      End Set
    End Property
    Public Property TRIP_REQ() As String
      Get
        Return _TRIP_REQ
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TRIP_REQ = ""
         Else
           _TRIP_REQ = value
         End If
      End Set
    End Property
    Public Property JOB_NO() As String
      Get
        Return _JOB_NO
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _JOB_NO = ""
         Else
           _JOB_NO = value
         End If
      End Set
    End Property
    Public Property PAX_NM() As String
      Get
        Return _PAX_NM
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PAX_NM = ""
         Else
           _PAX_NM = value
         End If
      End Set
    End Property
    Public Property AMOUNT_EX_GST() As String
      Get
        Return _AMOUNT_EX_GST
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AMOUNT_EX_GST = "0.00"
         Else
           _AMOUNT_EX_GST = value
         End If
      End Set
    End Property
    Public Property GST() As String
      Get
        Return _GST
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _GST = "0.00"
         Else
           _GST = value
         End If
      End Set
    End Property
    Public Property UNPAID_AMT() As String
      Get
        Return _UNPAID_AMT
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _UNPAID_AMT = "0.00"
         Else
           _UNPAID_AMT = value
         End If
      End Set
    End Property
    Public Property CHARGE_DTE() As String
      Get
        If Not _CHARGE_DTE = String.Empty Then
          Return Convert.ToDateTime(_CHARGE_DTE).ToString("dd/MM/yyyy")
        End If
        Return _CHARGE_DTE
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CHARGE_DTE = ""
         Else
           _CHARGE_DTE = value
         End If
      End Set
    End Property
    Public Property BKNG_DATE() As String
      Get
        If Not _BKNG_DATE = String.Empty Then
          Return Convert.ToDateTime(_BKNG_DATE).ToString("dd/MM/yyyy")
        End If
        Return _BKNG_DATE
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BKNG_DATE = ""
         Else
           _BKNG_DATE = value
         End If
      End Set
    End Property
    Public Property DEPT_DATE() As String
      Get
        If Not _DEPT_DATE = String.Empty Then
          Return Convert.ToDateTime(_DEPT_DATE).ToString("dd/MM/yyyy")
        End If
        Return _DEPT_DATE
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _DEPT_DATE = ""
         Else
           _DEPT_DATE = value
         End If
      End Set
    End Property
    Public Property TICKET_NO() As String
      Get
        Return _TICKET_NO
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TICKET_NO = ""
         Else
           _TICKET_NO = value
         End If
      End Set
    End Property
    Public Property CARRIER() As String
      Get
        Return _CARRIER
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CARRIER = ""
         Else
           _CARRIER = value
         End If
      End Set
    End Property
    Public Property CLAS() As String
      Get
        Return _CLASS
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _CLASS = ""
        Else
          _CLASS = value
        End If
      End Set
    End Property
    Public Property DI() As String
      Get
        Return _DI
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _DI = ""
         Else
           _DI = value
         End If
      End Set
    End Property
    Public Property ROUTING() As String
      Get
        Return _ROUTING
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ROUTING = ""
         Else
           _ROUTING = value
         End If
      End Set
    End Property
    Public Property TXN_DATE() As String
      Get
        If Not _TXN_DATE = String.Empty Then
          Return Convert.ToDateTime(_TXN_DATE).ToString("dd/MM/yyyy")
        End If
        Return _TXN_DATE
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TXN_DATE = ""
         Else
           _TXN_DATE = value
         End If
      End Set
    End Property
    Public Property Merchant_ABN() As String
      Get
        Return _Merchant_ABN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Merchant_ABN = ""
         Else
           _Merchant_ABN = value
         End If
      End Set
    End Property
    Public Property Book_Ref() As String
      Get
        Return _Book_Ref
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Book_Ref = ""
         Else
           _Book_Ref = value
         End If
      End Set
    End Property
    Public Property COMMENT1() As String
      Get
        Return _COMMENT1
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _COMMENT1 = ""
         Else
           _COMMENT1 = value
         End If
      End Set
    End Property
    Public Property COMMENT2() As String
      Get
        Return _COMMENT2
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _COMMENT2 = ""
         Else
           _COMMENT2 = value
         End If
      End Set
    End Property
    Public Property COMMENT3() As String
      Get
        Return _COMMENT3
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _COMMENT3 = ""
         Else
           _COMMENT3 = value
         End If
      End Set
    End Property
    Public Property MERCHANT_NAME() As String
      Get
        Return _MERCHANT_NAME
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _MERCHANT_NAME = ""
         Else
           _MERCHANT_NAME = value
         End If
      End Set
    End Property
    Public Property BatchNo() As String
      Get
        Return _BatchNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _BatchNo = ""
         Else
           _BatchNo = value
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
    Public Property SPMT_BTAStatus2_Descriptions() As String
      Get
        Return _SPMT_BTAStatus2_Descriptions
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_BTAStatus2_Descriptions = ""
         Else
           _SPMT_BTAStatus2_Descriptions = value
         End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _TICKET_NO.ToString.PadRight(10, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _SerialNo
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
    Public Class PKspmtBTADetails
      Private _SerialNo As Int32 = 0
      Public Property SerialNo() As Int32
        Get
          Return _SerialNo
        End Get
        Set(ByVal value As Int32)
          _SerialNo = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_SPMT_BTADetails_CreatedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_BTADetails_CreatedBy Is Nothing Then
          _FK_SPMT_BTADetails_CreatedBy = SIS.COM.comUsers.comUsersGetByID(_CreatedBy)
        End If
        Return _FK_SPMT_BTADetails_CreatedBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_BTADetails_StatusID() As SIS.SPMT.spmtBTAStatus
      Get
        If _FK_SPMT_BTADetails_StatusID Is Nothing Then
          _FK_SPMT_BTADetails_StatusID = SIS.SPMT.spmtBTAStatus.spmtBTAStatusGetByID(_StatusID)
        End If
        Return _FK_SPMT_BTADetails_StatusID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtBTADetailsSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtBTADetails)
      Dim Results As List(Of SIS.SPMT.spmtBTADetails) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtBTADetailsSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtBTADetails)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtBTADetails(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtBTADetailsGetNewRecord() As SIS.SPMT.spmtBTADetails
      Return New SIS.SPMT.spmtBTADetails()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtBTADetailsGetByID(ByVal SerialNo As Int32) As SIS.SPMT.spmtBTADetails
      Dim Results As SIS.SPMT.spmtBTADetails = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtBTADetailsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtBTADetails(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtBTADetailsSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.spmtBTADetails)
      Dim Results As List(Of SIS.SPMT.spmtBTADetails) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtBTADetailsSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtBTADetailsSelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtBTADetails)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtBTADetails(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtBTADetailsSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtBTADetailsInsert(ByVal Record As SIS.SPMT.spmtBTADetails) As SIS.SPMT.spmtBTADetails
      Dim _Rec As SIS.SPMT.spmtBTADetails = SIS.SPMT.spmtBTADetails.spmtBTADetailsGetNewRecord()
      With _Rec
        .CORP_2 = Record.CORP_2
        .CORP_1 = Record.CORP_1
        .BTA_ACCT = Record.BTA_ACCT
        .STMT_DT = Record.STMT_DT
        .STMT_REF_NO = Record.STMT_REF_NO
        .CUST_REF = Record.CUST_REF
        .TRIP_REQ = Record.TRIP_REQ
        .JOB_NO = Record.JOB_NO
        .PAX_NM = Record.PAX_NM
        .AMOUNT_EX_GST = Record.AMOUNT_EX_GST
        .GST = Record.GST
        .UNPAID_AMT = Record.UNPAID_AMT
        .CHARGE_DTE = Record.CHARGE_DTE
        .BKNG_DATE = Record.BKNG_DATE
        .DEPT_DATE = Record.DEPT_DATE
        .TICKET_NO = Record.TICKET_NO
        .CARRIER = Record.CARRIER
        .CLAS = Record.CLAS
        .DI = Record.DI
        .ROUTING = Record.ROUTING
        .TXN_DATE = Record.TXN_DATE
        .Merchant_ABN = Record.Merchant_ABN
        .Book_Ref = Record.Book_Ref
        .COMMENT1 = Record.COMMENT1
        .COMMENT2 = Record.COMMENT2
        .COMMENT3 = Record.COMMENT3
        .MERCHANT_NAME = Record.MERCHANT_NAME
        .BatchNo = Record.BatchNo
        .StatusID = Record.StatusID
        .CreatedBy =  Global.System.Web.HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
      End With
      Return SIS.SPMT.spmtBTADetails.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtBTADetails) As SIS.SPMT.spmtBTADetails
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtBTADetailsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CORP_2",SqlDbType.NVarChar,16, Iif(Record.CORP_2= "" ,Convert.DBNull, Record.CORP_2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CORP_1",SqlDbType.NVarChar,16, Iif(Record.CORP_1= "" ,Convert.DBNull, Record.CORP_1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BTA_ACCT",SqlDbType.NVarChar,16, Iif(Record.BTA_ACCT= "" ,Convert.DBNull, Record.BTA_ACCT))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@STMT_DT",SqlDbType.DateTime,21, Iif(Record.STMT_DT= "" ,Convert.DBNull, Record.STMT_DT))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@STMT_REF_NO",SqlDbType.NVarChar,16, Iif(Record.STMT_REF_NO= "" ,Convert.DBNull, Record.STMT_REF_NO))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CUST_REF",SqlDbType.NVarChar,21, Iif(Record.CUST_REF= "" ,Convert.DBNull, Record.CUST_REF))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TRIP_REQ",SqlDbType.NVarChar,21, Iif(Record.TRIP_REQ= "" ,Convert.DBNull, Record.TRIP_REQ))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@JOB_NO",SqlDbType.NVarChar,21, Iif(Record.JOB_NO= "" ,Convert.DBNull, Record.JOB_NO))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PAX_NM",SqlDbType.NVarChar,31, Iif(Record.PAX_NM= "" ,Convert.DBNull, Record.PAX_NM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AMOUNT_EX_GST",SqlDbType.Decimal,21, Iif(Record.AMOUNT_EX_GST= "" ,Convert.DBNull, Record.AMOUNT_EX_GST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GST",SqlDbType.Decimal,21, Iif(Record.GST= "" ,Convert.DBNull, Record.GST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UNPAID_AMT",SqlDbType.Decimal,21, Iif(Record.UNPAID_AMT= "" ,Convert.DBNull, Record.UNPAID_AMT))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CHARGE_DTE",SqlDbType.DateTime,21, Iif(Record.CHARGE_DTE= "" ,Convert.DBNull, Record.CHARGE_DTE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BKNG_DATE",SqlDbType.DateTime,21, Iif(Record.BKNG_DATE= "" ,Convert.DBNull, Record.BKNG_DATE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DEPT_DATE",SqlDbType.DateTime,21, Iif(Record.DEPT_DATE= "" ,Convert.DBNull, Record.DEPT_DATE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TICKET_NO",SqlDbType.NVarChar,11, Iif(Record.TICKET_NO= "" ,Convert.DBNull, Record.TICKET_NO))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CARRIER",SqlDbType.NVarChar,31, Iif(Record.CARRIER= "" ,Convert.DBNull, Record.CARRIER))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CLASS", SqlDbType.NVarChar, 11, IIf(Record.CLAS = "", Convert.DBNull, Record.CLAS))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DI",SqlDbType.NVarChar,3, Iif(Record.DI= "" ,Convert.DBNull, Record.DI))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ROUTING",SqlDbType.NVarChar,81, Iif(Record.ROUTING= "" ,Convert.DBNull, Record.ROUTING))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TXN_DATE",SqlDbType.DateTime,21, Iif(Record.TXN_DATE= "" ,Convert.DBNull, Record.TXN_DATE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Merchant_ABN",SqlDbType.NVarChar,17, Iif(Record.Merchant_ABN= "" ,Convert.DBNull, Record.Merchant_ABN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Book_Ref",SqlDbType.NVarChar,10, Iif(Record.Book_Ref= "" ,Convert.DBNull, Record.Book_Ref))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@COMMENT1",SqlDbType.NVarChar,46, Iif(Record.COMMENT1= "" ,Convert.DBNull, Record.COMMENT1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@COMMENT2",SqlDbType.NVarChar,46, Iif(Record.COMMENT2= "" ,Convert.DBNull, Record.COMMENT2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@COMMENT3",SqlDbType.NVarChar,451, Iif(Record.COMMENT3= "" ,Convert.DBNull, Record.COMMENT3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MERCHANT_NAME",SqlDbType.NVarChar,32, Iif(Record.MERCHANT_NAME= "" ,Convert.DBNull, Record.MERCHANT_NAME))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BatchNo",SqlDbType.Int,11, Iif(Record.BatchNo= "" ,Convert.DBNull, Record.BatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          Cmd.Parameters.Add("@Return_SerialNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_SerialNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.SerialNo = Cmd.Parameters("@Return_SerialNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtBTADetailsUpdate(ByVal Record As SIS.SPMT.spmtBTADetails) As SIS.SPMT.spmtBTADetails
      Dim _Rec As SIS.SPMT.spmtBTADetails = SIS.SPMT.spmtBTADetails.spmtBTADetailsGetByID(Record.SerialNo)
      With _Rec
        .CORP_2 = Record.CORP_2
        .CORP_1 = Record.CORP_1
        .BTA_ACCT = Record.BTA_ACCT
        .STMT_DT = Record.STMT_DT
        .STMT_REF_NO = Record.STMT_REF_NO
        .CUST_REF = Record.CUST_REF
        .TRIP_REQ = Record.TRIP_REQ
        .JOB_NO = Record.JOB_NO
        .PAX_NM = Record.PAX_NM
        .AMOUNT_EX_GST = Record.AMOUNT_EX_GST
        .GST = Record.GST
        .UNPAID_AMT = Record.UNPAID_AMT
        .CHARGE_DTE = Record.CHARGE_DTE
        .BKNG_DATE = Record.BKNG_DATE
        .DEPT_DATE = Record.DEPT_DATE
        .TICKET_NO = Record.TICKET_NO
        .CARRIER = Record.CARRIER
        .CLAS = Record.CLAS
        .DI = Record.DI
        .ROUTING = Record.ROUTING
        .TXN_DATE = Record.TXN_DATE
        .Merchant_ABN = Record.Merchant_ABN
        .Book_Ref = Record.Book_Ref
        .COMMENT1 = Record.COMMENT1
        .COMMENT2 = Record.COMMENT2
        .COMMENT3 = Record.COMMENT3
        .MERCHANT_NAME = Record.MERCHANT_NAME
        .BatchNo = Record.BatchNo
        .StatusID = Record.StatusID
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
      End With
      Return SIS.SPMT.spmtBTADetails.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtBTADetails) As SIS.SPMT.spmtBTADetails
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtBTADetailsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CORP_2",SqlDbType.NVarChar,16, Iif(Record.CORP_2= "" ,Convert.DBNull, Record.CORP_2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CORP_1",SqlDbType.NVarChar,16, Iif(Record.CORP_1= "" ,Convert.DBNull, Record.CORP_1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BTA_ACCT",SqlDbType.NVarChar,16, Iif(Record.BTA_ACCT= "" ,Convert.DBNull, Record.BTA_ACCT))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@STMT_DT",SqlDbType.DateTime,21, Iif(Record.STMT_DT= "" ,Convert.DBNull, Record.STMT_DT))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@STMT_REF_NO",SqlDbType.NVarChar,16, Iif(Record.STMT_REF_NO= "" ,Convert.DBNull, Record.STMT_REF_NO))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CUST_REF",SqlDbType.NVarChar,21, Iif(Record.CUST_REF= "" ,Convert.DBNull, Record.CUST_REF))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TRIP_REQ",SqlDbType.NVarChar,21, Iif(Record.TRIP_REQ= "" ,Convert.DBNull, Record.TRIP_REQ))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@JOB_NO",SqlDbType.NVarChar,21, Iif(Record.JOB_NO= "" ,Convert.DBNull, Record.JOB_NO))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PAX_NM",SqlDbType.NVarChar,31, Iif(Record.PAX_NM= "" ,Convert.DBNull, Record.PAX_NM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AMOUNT_EX_GST",SqlDbType.Decimal,21, Iif(Record.AMOUNT_EX_GST= "" ,Convert.DBNull, Record.AMOUNT_EX_GST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GST",SqlDbType.Decimal,21, Iif(Record.GST= "" ,Convert.DBNull, Record.GST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UNPAID_AMT",SqlDbType.Decimal,21, Iif(Record.UNPAID_AMT= "" ,Convert.DBNull, Record.UNPAID_AMT))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CHARGE_DTE",SqlDbType.DateTime,21, Iif(Record.CHARGE_DTE= "" ,Convert.DBNull, Record.CHARGE_DTE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BKNG_DATE",SqlDbType.DateTime,21, Iif(Record.BKNG_DATE= "" ,Convert.DBNull, Record.BKNG_DATE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DEPT_DATE",SqlDbType.DateTime,21, Iif(Record.DEPT_DATE= "" ,Convert.DBNull, Record.DEPT_DATE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TICKET_NO",SqlDbType.NVarChar,11, Iif(Record.TICKET_NO= "" ,Convert.DBNull, Record.TICKET_NO))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CARRIER",SqlDbType.NVarChar,31, Iif(Record.CARRIER= "" ,Convert.DBNull, Record.CARRIER))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CLASS", SqlDbType.NVarChar, 11, IIf(Record.CLAS = "", Convert.DBNull, Record.CLAS))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DI",SqlDbType.NVarChar,3, Iif(Record.DI= "" ,Convert.DBNull, Record.DI))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ROUTING",SqlDbType.NVarChar,81, Iif(Record.ROUTING= "" ,Convert.DBNull, Record.ROUTING))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TXN_DATE",SqlDbType.DateTime,21, Iif(Record.TXN_DATE= "" ,Convert.DBNull, Record.TXN_DATE))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Merchant_ABN",SqlDbType.NVarChar,17, Iif(Record.Merchant_ABN= "" ,Convert.DBNull, Record.Merchant_ABN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Book_Ref",SqlDbType.NVarChar,10, Iif(Record.Book_Ref= "" ,Convert.DBNull, Record.Book_Ref))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@COMMENT1",SqlDbType.NVarChar,46, Iif(Record.COMMENT1= "" ,Convert.DBNull, Record.COMMENT1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@COMMENT2",SqlDbType.NVarChar,46, Iif(Record.COMMENT2= "" ,Convert.DBNull, Record.COMMENT2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@COMMENT3",SqlDbType.NVarChar,451, Iif(Record.COMMENT3= "" ,Convert.DBNull, Record.COMMENT3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MERCHANT_NAME",SqlDbType.NVarChar,32, Iif(Record.MERCHANT_NAME= "" ,Convert.DBNull, Record.MERCHANT_NAME))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BatchNo",SqlDbType.Int,11, Iif(Record.BatchNo= "" ,Convert.DBNull, Record.BatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
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
    Public Shared Function spmtBTADetailsDelete(ByVal Record As SIS.SPMT.spmtBTADetails) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtBTADetailsDelete"
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
    Public Shared Function SelectspmtBTADetailsAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtBTADetailsAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, 1))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(10, " "),""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.SPMT.spmtBTADetails = New SIS.SPMT.spmtBTADetails(Reader)
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
                      If pi.Name = "CLAS" Then CLAS = ""
                  End Select
                Else
                  If pi.Name = "CLAS" Then
                    CallByName(Me, pi.Name, CallType.Let, Reader("CLASS"))
                  Else
                    CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                  End If
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
