Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtAirTicket
    Private Shared _RecordCount As Integer
    Private _SerialNo As Int32 = 0
    Private _TranTypeID As String = ""
    Private _AgentsIsgecGSTIN As String = ""
    Private _AgentsStateID As String = ""
    Private _AgentsBillNumber As String = ""
    Private _AgentsBillDate As String = ""
    Private _AgentsItemName As String = ""
    Private _AgentsBPID As String = ""
    Private _AgentsGSTIN As String = ""
    Private _AgentsName As String = ""
    Private _AgentsGSTINNumber As String = ""
    Private _AgentsBillType As String = ""
    Private _AgentsHSNSACCode As String = ""
    Private _AgentsBasicValue As Decimal = 0
    Private _AgentsIGSTRate As Decimal = 0
    Private _AgentsIGSTAmount As Decimal = 0
    Private _AgentsSGSTRate As Decimal = 0
    Private _AgentsSGSTAmount As Decimal = 0
    Private _AgentsCGSTRate As Decimal = 0
    Private _AgentsCGSTAmount As Decimal = 0
    Private _AgentsCessRate As Decimal = 0
    Private _AgentsCessAmount As Decimal = 0
    Private _AgentsTotalGST As Decimal = 0
    Private _AgentsTotalAmount As Decimal = 0
    Private _AgentsRCMApplicable As Boolean = False
    Private _AgencyIsgecGSTIN As String = ""
    Private _AgencyStateID As String = ""
    Private _AgencyBillNumber As String = ""
    Private _AgencyBillDate As String = ""
    Private _AgencyItemName As String = ""
    Private _AgencyBPID As String = ""
    Private _AgencyGSTIN As String = ""
    Private _AgencyName As String = ""
    Private _AgencyGSTINNumber As String = ""
    Private _AgencyBillType As String = ""
    Private _AgencyHSNSACCode As String = ""
    Private _AgencyBasicValue As Decimal = 0
    Private _AgencyIGSTRate As Decimal = 0
    Private _AgencyIGSTAmount As Decimal = 0
    Private _AgencySGSTRate As Decimal = 0
    Private _AgencySGSTAmount As Decimal = 0
    Private _AgencyCGSTRate As Decimal = 0
    Private _AgencyCGSTAmount As Decimal = 0
    Private _AgencyCessRate As Decimal = 0
    Private _AgencyCessAmount As Decimal = 0
    Private _AgencyTotalGST As Decimal = 0
    Private _AgencyTotalAmount As Decimal = 0
    Private _AgencyRCMApplicable As Boolean = False
    Private _NonGST1TaxRate As Decimal = 0
    Private _NonGST1TaxAmount As Decimal = 0
    Private _NonGST2TaxRate As Decimal = 0
    Private _NonGST2TaxAmount As Decimal = 0
    Private _TotalPayableToAgent As Decimal = 0
    Private _PaxName As String = ""
    Private _Sector As String = ""
    Private _TravelDate As String = ""
    Private _ReferrenceNumber As String = ""
    Private _EmployeeID As String = ""
    Private _ProjectID As String = ""
    Private _ISGECUnit As String = ""
    Private _Geography As String = ""
    Private _Data1Flag As Boolean = False
    Private _Data2Flag As Boolean = False
    Private _StatusID As String = ""
    Private _AdviceNo As String = ""
    Private _AgentsIRNo As String = ""
    Private _AgencyIRNo As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _IDM_Projects2_Description As String = ""
    Private _SPMT_BillTypes3_Description As String = ""
    Private _SPMT_BillTypes4_Description As String = ""
    Private _SPMT_ERPStates5_Description As String = ""
    Private _SPMT_ERPStates6_Description As String = ""
    Private _SPMT_HSNSACCodes7_HSNSACCode As String = ""
    Private _SPMT_HSNSACCodes8_HSNSACCode As String = ""
    Private _SPMT_IsgecGSTIN9_Description As String = ""
    Private _SPMT_IsgecGSTIN10_Description As String = ""
    Private _SPMT_PaymentAdvice11_BPID As String = ""
    Private _SPMT_TranTypes12_Description As String = ""
    Private _VR_BPGSTIN13_Description As String = ""
    Private _VR_BPGSTIN14_Description As String = ""
    Private _VR_BusinessPartner15_BPName As String = ""
    Private _VR_BusinessPartner16_BPName As String = ""
    Private _SPMT_AirTicketStatus17_Descriptionn As String = ""
    Private _SPMT_SupplierBill18_BillNumber As String = ""
    Private _SPMT_SupplierBill19_BillNumber As String = ""
    Private _FK_SPMT_AirTicket_EmployeeID As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_AirTicket_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_AirTicket_AgencyBillType As SIS.SPMT.spmtBillTypes = Nothing
    Private _FK_SPMT_AirTicket_AgentsBillType As SIS.SPMT.spmtBillTypes = Nothing
    Private _FK_SPMT_AirTicket_AgentsStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_AirTicket_AgencyStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_AirTicket_AgencyHSNSACCode As SIS.SPMT.spmtHSNSACCodes = Nothing
    Private _FK_SPMT_AirTicket_AgentsHSNSACCode As SIS.SPMT.spmtHSNSACCodes = Nothing
    Private _FK_SPMT_AirTicket_AgencyIsgecGSTIN As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_AirTicket_AgentsIsgecGSTIN As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_AirTicket_AdviceNo As SIS.SPMT.spmtPaymentAdvice = Nothing
    Private _FK_SPMT_AirTicket_TranTypeID As SIS.SPMT.spmtTranTypes = Nothing
    Private _FK_SPMT_AirTicket_AgencyGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_AirTicket_AgentsGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_AirTicket_AgencyBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_AirTicket_AgentsBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_AirTicket_StatusID As SIS.SPMT.spmtAirTicketStatus = Nothing
    Private _FK_SPMT_AirTicket_AgentsIRNo As SIS.SPMT.spmtSupplierBill = Nothing
    Private _FK_SPMT_AirTicket_AgencyIRNo As SIS.SPMT.spmtSupplierBill = Nothing
    Public Property UploadBatchNo As String = ""
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
    Public Property AgentsIsgecGSTIN() As String
      Get
        Return _AgentsIsgecGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsIsgecGSTIN = ""
         Else
           _AgentsIsgecGSTIN = value
         End If
      End Set
    End Property
    Public Property AgentsStateID() As String
      Get
        Return _AgentsStateID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsStateID = ""
         Else
           _AgentsStateID = value
         End If
      End Set
    End Property
    Public Property AgentsBillNumber() As String
      Get
        Return _AgentsBillNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsBillNumber = ""
         Else
           _AgentsBillNumber = value
         End If
      End Set
    End Property
    Public Property AgentsBillDate() As String
      Get
        If Not _AgentsBillDate = String.Empty Then
          Return Convert.ToDateTime(_AgentsBillDate).ToString("dd/MM/yyyy")
        End If
        Return _AgentsBillDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsBillDate = ""
         Else
           _AgentsBillDate = value
         End If
      End Set
    End Property
    Public Property AgentsItemName() As String
      Get
        Return _AgentsItemName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsItemName = ""
         Else
           _AgentsItemName = value
         End If
      End Set
    End Property
    Public Property AgentsBPID() As String
      Get
        Return _AgentsBPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsBPID = ""
         Else
           _AgentsBPID = value
         End If
      End Set
    End Property
    Public Property AgentsGSTIN() As String
      Get
        Return _AgentsGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsGSTIN = ""
         Else
           _AgentsGSTIN = value
         End If
      End Set
    End Property
    Public Property AgentsName() As String
      Get
        Return _AgentsName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsName = ""
         Else
           _AgentsName = value
         End If
      End Set
    End Property
    Public Property AgentsGSTINNumber() As String
      Get
        Return _AgentsGSTINNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsGSTINNumber = ""
         Else
           _AgentsGSTINNumber = value
         End If
      End Set
    End Property
    Public Property AgentsBillType() As String
      Get
        Return _AgentsBillType
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsBillType = ""
         Else
           _AgentsBillType = value
         End If
      End Set
    End Property
    Public Property AgentsHSNSACCode() As String
      Get
        Return _AgentsHSNSACCode
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsHSNSACCode = ""
         Else
           _AgentsHSNSACCode = value
         End If
      End Set
    End Property
    Public Property AgentsBasicValue() As Decimal
      Get
        Return _AgentsBasicValue
      End Get
      Set(ByVal value As Decimal)
        _AgentsBasicValue = value
      End Set
    End Property
    Public Property AgentsIGSTRate() As Decimal
      Get
        Return _AgentsIGSTRate
      End Get
      Set(ByVal value As Decimal)
        _AgentsIGSTRate = value
      End Set
    End Property
    Public Property AgentsIGSTAmount() As Decimal
      Get
        Return _AgentsIGSTAmount
      End Get
      Set(ByVal value As Decimal)
        _AgentsIGSTAmount = value
      End Set
    End Property
    Public Property AgentsSGSTRate() As Decimal
      Get
        Return _AgentsSGSTRate
      End Get
      Set(ByVal value As Decimal)
        _AgentsSGSTRate = value
      End Set
    End Property
    Public Property AgentsSGSTAmount() As Decimal
      Get
        Return _AgentsSGSTAmount
      End Get
      Set(ByVal value As Decimal)
        _AgentsSGSTAmount = value
      End Set
    End Property
    Public Property AgentsCGSTRate() As Decimal
      Get
        Return _AgentsCGSTRate
      End Get
      Set(ByVal value As Decimal)
        _AgentsCGSTRate = value
      End Set
    End Property
    Public Property AgentsCGSTAmount() As Decimal
      Get
        Return _AgentsCGSTAmount
      End Get
      Set(ByVal value As Decimal)
        _AgentsCGSTAmount = value
      End Set
    End Property
    Public Property AgentsCessRate() As Decimal
      Get
        Return _AgentsCessRate
      End Get
      Set(ByVal value As Decimal)
        _AgentsCessRate = value
      End Set
    End Property
    Public Property AgentsCessAmount() As Decimal
      Get
        Return _AgentsCessAmount
      End Get
      Set(ByVal value As Decimal)
        _AgentsCessAmount = value
      End Set
    End Property
    Public Property AgentsTotalGST() As Decimal
      Get
        Return _AgentsTotalGST
      End Get
      Set(ByVal value As Decimal)
        _AgentsTotalGST = value
      End Set
    End Property
    Public Property AgentsTotalAmount() As Decimal
      Get
        Return _AgentsTotalAmount
      End Get
      Set(ByVal value As Decimal)
        _AgentsTotalAmount = value
      End Set
    End Property
    Public Property AgentsRCMApplicable() As Boolean
      Get
        Return _AgentsRCMApplicable
      End Get
      Set(ByVal value As Boolean)
        _AgentsRCMApplicable = value
      End Set
    End Property
    Public Property AgencyIsgecGSTIN() As String
      Get
        Return _AgencyIsgecGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyIsgecGSTIN = ""
         Else
           _AgencyIsgecGSTIN = value
         End If
      End Set
    End Property
    Public Property AgencyStateID() As String
      Get
        Return _AgencyStateID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyStateID = ""
         Else
           _AgencyStateID = value
         End If
      End Set
    End Property
    Public Property AgencyBillNumber() As String
      Get
        Return _AgencyBillNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyBillNumber = ""
         Else
           _AgencyBillNumber = value
         End If
      End Set
    End Property
    Public Property AgencyBillDate() As String
      Get
        If Not _AgencyBillDate = String.Empty Then
          Return Convert.ToDateTime(_AgencyBillDate).ToString("dd/MM/yyyy")
        End If
        Return _AgencyBillDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyBillDate = ""
         Else
           _AgencyBillDate = value
         End If
      End Set
    End Property
    Public Property AgencyItemName() As String
      Get
        Return _AgencyItemName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyItemName = ""
         Else
           _AgencyItemName = value
         End If
      End Set
    End Property
    Public Property AgencyBPID() As String
      Get
        Return _AgencyBPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyBPID = ""
         Else
           _AgencyBPID = value
         End If
      End Set
    End Property
    Public Property AgencyGSTIN() As String
      Get
        Return _AgencyGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyGSTIN = ""
         Else
           _AgencyGSTIN = value
         End If
      End Set
    End Property
    Public Property AgencyName() As String
      Get
        Return _AgencyName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyName = ""
         Else
           _AgencyName = value
         End If
      End Set
    End Property
    Public Property AgencyGSTINNumber() As String
      Get
        Return _AgencyGSTINNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyGSTINNumber = ""
         Else
           _AgencyGSTINNumber = value
         End If
      End Set
    End Property
    Public Property AgencyBillType() As String
      Get
        Return _AgencyBillType
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyBillType = ""
         Else
           _AgencyBillType = value
         End If
      End Set
    End Property
    Public Property AgencyHSNSACCode() As String
      Get
        Return _AgencyHSNSACCode
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyHSNSACCode = ""
         Else
           _AgencyHSNSACCode = value
         End If
      End Set
    End Property
    Public Property AgencyBasicValue() As Decimal
      Get
        Return _AgencyBasicValue
      End Get
      Set(ByVal value As Decimal)
        _AgencyBasicValue = value
      End Set
    End Property
    Public Property AgencyIGSTRate() As Decimal
      Get
        Return _AgencyIGSTRate
      End Get
      Set(ByVal value As Decimal)
        _AgencyIGSTRate = value
      End Set
    End Property
    Public Property AgencyIGSTAmount() As Decimal
      Get
        Return _AgencyIGSTAmount
      End Get
      Set(ByVal value As Decimal)
        _AgencyIGSTAmount = value
      End Set
    End Property
    Public Property AgencySGSTRate() As Decimal
      Get
        Return _AgencySGSTRate
      End Get
      Set(ByVal value As Decimal)
        _AgencySGSTRate = value
      End Set
    End Property
    Public Property AgencySGSTAmount() As Decimal
      Get
        Return _AgencySGSTAmount
      End Get
      Set(ByVal value As Decimal)
        _AgencySGSTAmount = value
      End Set
    End Property
    Public Property AgencyCGSTRate() As Decimal
      Get
        Return _AgencyCGSTRate
      End Get
      Set(ByVal value As Decimal)
        _AgencyCGSTRate = value
      End Set
    End Property
    Public Property AgencyCGSTAmount() As Decimal
      Get
        Return _AgencyCGSTAmount
      End Get
      Set(ByVal value As Decimal)
        _AgencyCGSTAmount = value
      End Set
    End Property
    Public Property AgencyCessRate() As Decimal
      Get
        Return _AgencyCessRate
      End Get
      Set(ByVal value As Decimal)
        _AgencyCessRate = value
      End Set
    End Property
    Public Property AgencyCessAmount() As Decimal
      Get
        Return _AgencyCessAmount
      End Get
      Set(ByVal value As Decimal)
        _AgencyCessAmount = value
      End Set
    End Property
    Public Property AgencyTotalGST() As Decimal
      Get
        Return _AgencyTotalGST
      End Get
      Set(ByVal value As Decimal)
        _AgencyTotalGST = value
      End Set
    End Property
    Public Property AgencyTotalAmount() As Decimal
      Get
        Return _AgencyTotalAmount
      End Get
      Set(ByVal value As Decimal)
        _AgencyTotalAmount = value
      End Set
    End Property
    Public Property AgencyRCMApplicable() As Boolean
      Get
        Return _AgencyRCMApplicable
      End Get
      Set(ByVal value As Boolean)
        _AgencyRCMApplicable = value
      End Set
    End Property
    Public Property NonGST1TaxRate() As Decimal
      Get
        Return _NonGST1TaxRate
      End Get
      Set(ByVal value As Decimal)
        _NonGST1TaxRate = value
      End Set
    End Property
    Public Property NonGST1TaxAmount() As Decimal
      Get
        Return _NonGST1TaxAmount
      End Get
      Set(ByVal value As Decimal)
        _NonGST1TaxAmount = value
      End Set
    End Property
    Public Property NonGST2TaxRate() As Decimal
      Get
        Return _NonGST2TaxRate
      End Get
      Set(ByVal value As Decimal)
        _NonGST2TaxRate = value
      End Set
    End Property
    Public Property NonGST2TaxAmount() As Decimal
      Get
        Return _NonGST2TaxAmount
      End Get
      Set(ByVal value As Decimal)
        _NonGST2TaxAmount = value
      End Set
    End Property
    Public Property TotalPayableToAgent() As Decimal
      Get
        Return _TotalPayableToAgent
      End Get
      Set(ByVal value As Decimal)
        _TotalPayableToAgent = value
      End Set
    End Property
    Public Property PaxName() As String
      Get
        Return _PaxName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PaxName = ""
         Else
           _PaxName = value
         End If
      End Set
    End Property
    Public Property Sector() As String
      Get
        Return _Sector
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Sector = ""
         Else
           _Sector = value
         End If
      End Set
    End Property
    Public Property TravelDate() As String
      Get
        If Not _TravelDate = String.Empty Then
          Return Convert.ToDateTime(_TravelDate).ToString("dd/MM/yyyy")
        End If
        Return _TravelDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TravelDate = ""
         Else
           _TravelDate = value
         End If
      End Set
    End Property
    Public Property ReferrenceNumber() As String
      Get
        Return _ReferrenceNumber
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ReferrenceNumber = ""
         Else
           _ReferrenceNumber = value
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
    Public Property ISGECUnit() As String
      Get
        Return _ISGECUnit
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ISGECUnit = ""
         Else
           _ISGECUnit = value
         End If
      End Set
    End Property
    Public Property Geography() As String
      Get
        Return _Geography
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Geography = ""
         Else
           _Geography = value
         End If
      End Set
    End Property
    Public Property Data1Flag() As Boolean
      Get
        Return _Data1Flag
      End Get
      Set(ByVal value As Boolean)
        _Data1Flag = value
      End Set
    End Property
    Public Property Data2Flag() As Boolean
      Get
        Return _Data2Flag
      End Get
      Set(ByVal value As Boolean)
        _Data2Flag = value
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
    Public Property AgentsIRNo() As String
      Get
        Return _AgentsIRNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgentsIRNo = ""
         Else
           _AgentsIRNo = value
         End If
      End Set
    End Property
    Public Property AgencyIRNo() As String
      Get
        Return _AgencyIRNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _AgencyIRNo = ""
         Else
           _AgencyIRNo = value
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
    Public Property IDM_Projects2_Description() As String
      Get
        Return _IDM_Projects2_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects2_Description = value
      End Set
    End Property
    Public Property SPMT_BillTypes3_Description() As String
      Get
        Return _SPMT_BillTypes3_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_BillTypes3_Description = ""
         Else
           _SPMT_BillTypes3_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_BillTypes4_Description() As String
      Get
        Return _SPMT_BillTypes4_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_BillTypes4_Description = ""
         Else
           _SPMT_BillTypes4_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates5_Description() As String
      Get
        Return _SPMT_ERPStates5_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates5_Description = ""
         Else
           _SPMT_ERPStates5_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates6_Description() As String
      Get
        Return _SPMT_ERPStates6_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates6_Description = ""
         Else
           _SPMT_ERPStates6_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_HSNSACCodes7_HSNSACCode() As String
      Get
        Return _SPMT_HSNSACCodes7_HSNSACCode
      End Get
      Set(ByVal value As String)
        _SPMT_HSNSACCodes7_HSNSACCode = value
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
    Public Property SPMT_IsgecGSTIN9_Description() As String
      Get
        Return _SPMT_IsgecGSTIN9_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN9_Description = ""
         Else
           _SPMT_IsgecGSTIN9_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN10_Description() As String
      Get
        Return _SPMT_IsgecGSTIN10_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN10_Description = ""
         Else
           _SPMT_IsgecGSTIN10_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_PaymentAdvice11_BPID() As String
      Get
        Return _SPMT_PaymentAdvice11_BPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_PaymentAdvice11_BPID = ""
         Else
           _SPMT_PaymentAdvice11_BPID = value
         End If
      End Set
    End Property
    Public Property SPMT_TranTypes12_Description() As String
      Get
        Return _SPMT_TranTypes12_Description
      End Get
      Set(ByVal value As String)
        _SPMT_TranTypes12_Description = value
      End Set
    End Property
    Public Property VR_BPGSTIN13_Description() As String
      Get
        Return _VR_BPGSTIN13_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN13_Description = ""
         Else
           _VR_BPGSTIN13_Description = value
         End If
      End Set
    End Property
    Public Property VR_BPGSTIN14_Description() As String
      Get
        Return _VR_BPGSTIN14_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN14_Description = ""
         Else
           _VR_BPGSTIN14_Description = value
         End If
      End Set
    End Property
    Public Property VR_BusinessPartner15_BPName() As String
      Get
        Return _VR_BusinessPartner15_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner15_BPName = value
      End Set
    End Property
    Public Property VR_BusinessPartner16_BPName() As String
      Get
        Return _VR_BusinessPartner16_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner16_BPName = value
      End Set
    End Property
    Public Property SPMT_AirTicketStatus17_Descriptionn() As String
      Get
        Return _SPMT_AirTicketStatus17_Descriptionn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_AirTicketStatus17_Descriptionn = ""
         Else
           _SPMT_AirTicketStatus17_Descriptionn = value
         End If
      End Set
    End Property
    Public Property SPMT_SupplierBill18_BillNumber() As String
      Get
        Return _SPMT_SupplierBill18_BillNumber
      End Get
      Set(ByVal value As String)
        _SPMT_SupplierBill18_BillNumber = value
      End Set
    End Property
    Public Property SPMT_SupplierBill19_BillNumber() As String
      Get
        Return _SPMT_SupplierBill19_BillNumber
      End Get
      Set(ByVal value As String)
        _SPMT_SupplierBill19_BillNumber = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _AgentsBillNumber.ToString.PadRight(50, " ")
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
    Public Class PKspmtAirTicket
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
    Public ReadOnly Property FK_SPMT_AirTicket_EmployeeID() As SIS.COM.comUsers
      Get
        If _FK_SPMT_AirTicket_EmployeeID Is Nothing Then
          _FK_SPMT_AirTicket_EmployeeID = SIS.COM.comUsers.comUsersGetByID(_EmployeeID)
        End If
        Return _FK_SPMT_AirTicket_EmployeeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_AirTicket_ProjectID Is Nothing Then
          _FK_SPMT_AirTicket_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_AirTicket_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyBillType() As SIS.SPMT.spmtBillTypes
      Get
        If _FK_SPMT_AirTicket_AgencyBillType Is Nothing Then
          _FK_SPMT_AirTicket_AgencyBillType = SIS.SPMT.spmtBillTypes.spmtBillTypesGetByID(_AgencyBillType)
        End If
        Return _FK_SPMT_AirTicket_AgencyBillType
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsBillType() As SIS.SPMT.spmtBillTypes
      Get
        If _FK_SPMT_AirTicket_AgentsBillType Is Nothing Then
          _FK_SPMT_AirTicket_AgentsBillType = SIS.SPMT.spmtBillTypes.spmtBillTypesGetByID(_AgentsBillType)
        End If
        Return _FK_SPMT_AirTicket_AgentsBillType
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_AirTicket_AgentsStateID Is Nothing Then
          _FK_SPMT_AirTicket_AgentsStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_AgentsStateID)
        End If
        Return _FK_SPMT_AirTicket_AgentsStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_AirTicket_AgencyStateID Is Nothing Then
          _FK_SPMT_AirTicket_AgencyStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_AgencyStateID)
        End If
        Return _FK_SPMT_AirTicket_AgencyStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyHSNSACCode() As SIS.SPMT.spmtHSNSACCodes
      Get
        If _FK_SPMT_AirTicket_AgencyHSNSACCode Is Nothing Then
          _FK_SPMT_AirTicket_AgencyHSNSACCode = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(_AgencyBillType, _AgencyHSNSACCode)
        End If
        Return _FK_SPMT_AirTicket_AgencyHSNSACCode
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsHSNSACCode() As SIS.SPMT.spmtHSNSACCodes
      Get
        If _FK_SPMT_AirTicket_AgentsHSNSACCode Is Nothing Then
          _FK_SPMT_AirTicket_AgentsHSNSACCode = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(_AgentsBillType, _AgentsHSNSACCode)
        End If
        Return _FK_SPMT_AirTicket_AgentsHSNSACCode
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyIsgecGSTIN() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_AirTicket_AgencyIsgecGSTIN Is Nothing Then
          _FK_SPMT_AirTicket_AgencyIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_AgencyIsgecGSTIN)
        End If
        Return _FK_SPMT_AirTicket_AgencyIsgecGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsIsgecGSTIN() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_AirTicket_AgentsIsgecGSTIN Is Nothing Then
          _FK_SPMT_AirTicket_AgentsIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_AgentsIsgecGSTIN)
        End If
        Return _FK_SPMT_AirTicket_AgentsIsgecGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AdviceNo() As SIS.SPMT.spmtPaymentAdvice
      Get
        If _FK_SPMT_AirTicket_AdviceNo Is Nothing Then
          _FK_SPMT_AirTicket_AdviceNo = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(_AdviceNo)
        End If
        Return _FK_SPMT_AirTicket_AdviceNo
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_TranTypeID() As SIS.SPMT.spmtTranTypes
      Get
        If _FK_SPMT_AirTicket_TranTypeID Is Nothing Then
          _FK_SPMT_AirTicket_TranTypeID = SIS.SPMT.spmtTranTypes.spmtTranTypesGetByID(_TranTypeID)
        End If
        Return _FK_SPMT_AirTicket_TranTypeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_AirTicket_AgencyGSTIN Is Nothing Then
          _FK_SPMT_AirTicket_AgencyGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_AgencyBPID, _AgencyGSTIN)
        End If
        Return _FK_SPMT_AirTicket_AgencyGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_AirTicket_AgentsGSTIN Is Nothing Then
          _FK_SPMT_AirTicket_AgentsGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_AgentsBPID, _AgentsGSTIN)
        End If
        Return _FK_SPMT_AirTicket_AgentsGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_AirTicket_AgencyBPID Is Nothing Then
          _FK_SPMT_AirTicket_AgencyBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_AgencyBPID)
        End If
        Return _FK_SPMT_AirTicket_AgencyBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_AirTicket_AgentsBPID Is Nothing Then
          _FK_SPMT_AirTicket_AgentsBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_AgentsBPID)
        End If
        Return _FK_SPMT_AirTicket_AgentsBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_StatusID() As SIS.SPMT.spmtAirTicketStatus
      Get
        If _FK_SPMT_AirTicket_StatusID Is Nothing Then
          _FK_SPMT_AirTicket_StatusID = SIS.SPMT.spmtAirTicketStatus.spmtAirTicketStatusGetByID(_StatusID)
        End If
        Return _FK_SPMT_AirTicket_StatusID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgentsIRNo() As SIS.SPMT.spmtSupplierBill
      Get
        If _FK_SPMT_AirTicket_AgentsIRNo Is Nothing Then
          _FK_SPMT_AirTicket_AgentsIRNo = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(_AgentsIRNo)
        End If
        Return _FK_SPMT_AirTicket_AgentsIRNo
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_AirTicket_AgencyIRNo() As SIS.SPMT.spmtSupplierBill
      Get
        If _FK_SPMT_AirTicket_AgencyIRNo Is Nothing Then
          _FK_SPMT_AirTicket_AgencyIRNo = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(_AgencyIRNo)
        End If
        Return _FK_SPMT_AirTicket_AgencyIRNo
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtAirTicketSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtAirTicket)
      Dim Results As List(Of SIS.SPMT.spmtAirTicket) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtAirTicketSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtAirTicket)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtAirTicket(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtAirTicketGetNewRecord() As SIS.SPMT.spmtAirTicket
      Return New SIS.SPMT.spmtAirTicket()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtAirTicketGetByID(ByVal SerialNo As Int32) As SIS.SPMT.spmtAirTicket
      Dim Results As SIS.SPMT.spmtAirTicket = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtAirTicketSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtAirTicket(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtAirTicketSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal AgentsBPID As String, ByVal AgencyBPID As String, ByVal EmployeeID As String, ByVal ProjectID As String, ByVal ISGECUnit As String, ByVal Geography As String, ByVal StatusID As Int32, ByVal AdviceNo As Int32) As List(Of SIS.SPMT.spmtAirTicket)
      Dim Results As List(Of SIS.SPMT.spmtAirTicket) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtAirTicketSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtAirTicketSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AgentsBPID",SqlDbType.NVarChar,9, IIf(AgentsBPID Is Nothing, String.Empty,AgentsBPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AgencyBPID",SqlDbType.NVarChar,9, IIf(AgencyBPID Is Nothing, String.Empty,AgencyBPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_EmployeeID",SqlDbType.NVarChar,8, IIf(EmployeeID Is Nothing, String.Empty,EmployeeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID",SqlDbType.NVarChar,6, IIf(ProjectID Is Nothing, String.Empty,ProjectID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ISGECUnit",SqlDbType.NVarChar,10, IIf(ISGECUnit Is Nothing, String.Empty,ISGECUnit))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_Geography", SqlDbType.NVarChar, 20, IIf(Geography Is Nothing, String.Empty, Geography))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_StatusID",SqlDbType.Int,10, IIf(StatusID = Nothing, 0,StatusID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo",SqlDbType.Int,10, IIf(AdviceNo = Nothing, 0,AdviceNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtAirTicket)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtAirTicket(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtAirTicketSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal AgentsBPID As String, ByVal AgencyBPID As String, ByVal EmployeeID As String, ByVal ProjectID As String, ByVal ISGECUnit As String, ByVal Geography As String, ByVal StatusID As Int32, ByVal AdviceNo As Int32) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtAirTicketGetByID(ByVal SerialNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_AgentsBPID As String, ByVal Filter_AgencyBPID As String, ByVal Filter_EmployeeID As String, ByVal Filter_ProjectID As String, ByVal Filter_ISGECUnit As String, ByVal Filter_Geography As String, ByVal Filter_StatusID As Int32, ByVal Filter_AdviceNo As Int32) As SIS.SPMT.spmtAirTicket
      Return spmtAirTicketGetByID(SerialNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtAirTicketInsert(ByVal Record As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
      Dim _Rec As SIS.SPMT.spmtAirTicket = SIS.SPMT.spmtAirTicket.spmtAirTicketGetNewRecord()
      With _Rec
        .TranTypeID = Record.TranTypeID
        .AgentsIsgecGSTIN = Record.AgentsIsgecGSTIN
        .AgentsStateID = Record.AgentsStateID
        .AgentsBillNumber = Record.AgentsBillNumber
        .AgentsBillDate = Record.AgentsBillDate
        .AgentsItemName = Record.AgentsItemName
        .AgentsBPID = Record.AgentsBPID
        .AgentsGSTIN = Record.AgentsGSTIN
        .AgentsName = Record.AgentsName
        .AgentsGSTINNumber = Record.AgentsGSTINNumber
        .AgentsBillType = Record.AgentsBillType
        .AgentsHSNSACCode = Record.AgentsHSNSACCode
        .AgentsBasicValue = Record.AgentsBasicValue
        .AgentsIGSTRate = Record.AgentsIGSTRate
        .AgentsIGSTAmount = Record.AgentsIGSTAmount
        .AgentsSGSTRate = Record.AgentsSGSTRate
        .AgentsSGSTAmount = Record.AgentsSGSTAmount
        .AgentsCGSTRate = Record.AgentsCGSTRate
        .AgentsCGSTAmount = Record.AgentsCGSTAmount
        .AgentsCessRate = Record.AgentsCessRate
        .AgentsCessAmount = Record.AgentsCessAmount
        .AgentsTotalGST = Record.AgentsTotalGST
        .AgentsTotalAmount = Record.AgentsTotalAmount
        .AgentsRCMApplicable = Record.AgentsRCMApplicable
        .AgencyIsgecGSTIN = Record.AgencyIsgecGSTIN
        .AgencyStateID = Record.AgencyStateID
        .AgencyBillNumber = Record.AgencyBillNumber
        .AgencyBillDate = Record.AgencyBillDate
        .AgencyItemName = Record.AgencyItemName
        .AgencyBPID = Record.AgencyBPID
        .AgencyGSTIN = Record.AgencyGSTIN
        .AgencyName = Record.AgencyName
        .AgencyGSTINNumber = Record.AgencyGSTINNumber
        .AgencyBillType = Record.AgencyBillType
        .AgencyHSNSACCode = Record.AgencyHSNSACCode
        .AgencyBasicValue = Record.AgencyBasicValue
        .AgencyIGSTRate = Record.AgencyIGSTRate
        .AgencyIGSTAmount = Record.AgencyIGSTAmount
        .AgencySGSTRate = Record.AgencySGSTRate
        .AgencySGSTAmount = Record.AgencySGSTAmount
        .AgencyCGSTRate = Record.AgencyCGSTRate
        .AgencyCGSTAmount = Record.AgencyCGSTAmount
        .AgencyCessRate = Record.AgencyCessRate
        .AgencyCessAmount = Record.AgencyCessAmount
        .AgencyTotalGST = Record.AgencyTotalGST
        .AgencyTotalAmount = Record.AgencyTotalAmount
        .AgencyRCMApplicable = Record.AgencyRCMApplicable
        .NonGST1TaxRate = Record.NonGST1TaxRate
        .NonGST1TaxAmount = Record.NonGST1TaxAmount
        .NonGST2TaxRate = Record.NonGST2TaxRate
        .NonGST2TaxAmount = Record.NonGST2TaxAmount
        .TotalPayableToAgent = Record.TotalPayableToAgent
        .PaxName = Record.PaxName
        .Sector = Record.Sector
        .TravelDate = Record.TravelDate
        .ReferrenceNumber = Record.ReferrenceNumber
        .EmployeeID = Record.EmployeeID
        .ProjectID = Record.ProjectID
        .ISGECUnit = Record.ISGECUnit
        .Geography = Record.Geography
        .Data1Flag = Record.Data1Flag
        .Data2Flag = Record.Data2Flag
        .StatusID = 2
        .AdviceNo = Record.AdviceNo
        .AgentsIRNo = Record.AgentsIRNo
        .AgencyIRNo = Record.AgencyIRNo
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtAirTicket.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtAirTicketInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Iif(Record.TranTypeID= "" ,Convert.DBNull, Record.TranTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIsgecGSTIN",SqlDbType.Int,11, Iif(Record.AgentsIsgecGSTIN= "" ,Convert.DBNull, Record.AgentsIsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsStateID",SqlDbType.NVarChar,3, Iif(Record.AgentsStateID= "" ,Convert.DBNull, Record.AgentsStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBillNumber",SqlDbType.NVarChar,51, Iif(Record.AgentsBillNumber= "" ,Convert.DBNull, Record.AgentsBillNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBillDate",SqlDbType.DateTime,21, Iif(Record.AgentsBillDate= "" ,Convert.DBNull, Record.AgentsBillDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsItemName",SqlDbType.NVarChar,51, Iif(Record.AgentsItemName= "" ,Convert.DBNull, Record.AgentsItemName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBPID",SqlDbType.NVarChar,10, Iif(Record.AgentsBPID= "" ,Convert.DBNull, Record.AgentsBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsGSTIN",SqlDbType.Int,11, Iif(Record.AgentsGSTIN= "" ,Convert.DBNull, Record.AgentsGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsName",SqlDbType.NVarChar,51, Iif(Record.AgentsName= "" ,Convert.DBNull, Record.AgentsName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsGSTINNumber",SqlDbType.NVarChar,51, Iif(Record.AgentsGSTINNumber= "" ,Convert.DBNull, Record.AgentsGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBillType",SqlDbType.Int,11, Iif(Record.AgentsBillType= "" ,Convert.DBNull, Record.AgentsBillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsHSNSACCode",SqlDbType.NVarChar,21, Iif(Record.AgentsHSNSACCode= "" ,Convert.DBNull, Record.AgentsHSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBasicValue",SqlDbType.Decimal,21, Record.AgentsBasicValue)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIGSTRate",SqlDbType.Decimal,21, Record.AgentsIGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIGSTAmount",SqlDbType.Decimal,21, Record.AgentsIGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsSGSTRate",SqlDbType.Decimal,21, Record.AgentsSGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsSGSTAmount",SqlDbType.Decimal,21, Record.AgentsSGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCGSTRate",SqlDbType.Decimal,21, Record.AgentsCGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCGSTAmount",SqlDbType.Decimal,21, Record.AgentsCGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCessRate",SqlDbType.Decimal,21, Record.AgentsCessRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCessAmount",SqlDbType.Decimal,21, Record.AgentsCessAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsTotalGST",SqlDbType.Decimal,21, Record.AgentsTotalGST)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsTotalAmount",SqlDbType.Decimal,21, Record.AgentsTotalAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsRCMApplicable",SqlDbType.Bit,3, Record.AgentsRCMApplicable)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIsgecGSTIN",SqlDbType.Int,11, Iif(Record.AgencyIsgecGSTIN= "" ,Convert.DBNull, Record.AgencyIsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyStateID",SqlDbType.NVarChar,3, Iif(Record.AgencyStateID= "" ,Convert.DBNull, Record.AgencyStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBillNumber",SqlDbType.NVarChar,51, Iif(Record.AgencyBillNumber= "" ,Convert.DBNull, Record.AgencyBillNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBillDate",SqlDbType.DateTime,21, Iif(Record.AgencyBillDate= "" ,Convert.DBNull, Record.AgencyBillDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyItemName",SqlDbType.NVarChar,51, Iif(Record.AgencyItemName= "" ,Convert.DBNull, Record.AgencyItemName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBPID",SqlDbType.NVarChar,10, Iif(Record.AgencyBPID= "" ,Convert.DBNull, Record.AgencyBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyGSTIN",SqlDbType.Int,11, Iif(Record.AgencyGSTIN= "" ,Convert.DBNull, Record.AgencyGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyName",SqlDbType.NVarChar,51, Iif(Record.AgencyName= "" ,Convert.DBNull, Record.AgencyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyGSTINNumber",SqlDbType.NVarChar,51, Iif(Record.AgencyGSTINNumber= "" ,Convert.DBNull, Record.AgencyGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBillType",SqlDbType.Int,11, Iif(Record.AgencyBillType= "" ,Convert.DBNull, Record.AgencyBillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyHSNSACCode",SqlDbType.NVarChar,21, Iif(Record.AgencyHSNSACCode= "" ,Convert.DBNull, Record.AgencyHSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBasicValue",SqlDbType.Decimal,21, Record.AgencyBasicValue)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIGSTRate",SqlDbType.Decimal,21, Record.AgencyIGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIGSTAmount",SqlDbType.Decimal,21, Record.AgencyIGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencySGSTRate",SqlDbType.Decimal,21, Record.AgencySGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencySGSTAmount",SqlDbType.Decimal,21, Record.AgencySGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCGSTRate",SqlDbType.Decimal,21, Record.AgencyCGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCGSTAmount",SqlDbType.Decimal,21, Record.AgencyCGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCessRate",SqlDbType.Decimal,21, Record.AgencyCessRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCessAmount",SqlDbType.Decimal,21, Record.AgencyCessAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyTotalGST",SqlDbType.Decimal,21, Record.AgencyTotalGST)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyTotalAmount",SqlDbType.Decimal,21, Record.AgencyTotalAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyRCMApplicable",SqlDbType.Bit,3, Record.AgencyRCMApplicable)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST1TaxRate",SqlDbType.Decimal,21, Record.NonGST1TaxRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST1TaxAmount",SqlDbType.Decimal,21, Record.NonGST1TaxAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST2TaxRate",SqlDbType.Decimal,21, Record.NonGST2TaxRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST2TaxAmount",SqlDbType.Decimal,21, Record.NonGST2TaxAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalPayableToAgent",SqlDbType.Decimal,21, Record.TotalPayableToAgent)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PaxName",SqlDbType.NVarChar,51, Iif(Record.PaxName= "" ,Convert.DBNull, Record.PaxName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Sector",SqlDbType.NVarChar,51, Iif(Record.Sector= "" ,Convert.DBNull, Record.Sector))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TravelDate",SqlDbType.DateTime,21, Iif(Record.TravelDate= "" ,Convert.DBNull, Record.TravelDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReferrenceNumber",SqlDbType.NVarChar,51, Iif(Record.ReferrenceNumber= "" ,Convert.DBNull, Record.ReferrenceNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ISGECUnit",SqlDbType.NVarChar,11, Iif(Record.ISGECUnit= "" ,Convert.DBNull, Record.ISGECUnit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Geography", SqlDbType.NVarChar, 21, IIf(Record.Geography = "", Convert.DBNull, Record.Geography))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Data1Flag",SqlDbType.Bit,3, Record.Data1Flag)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Data2Flag",SqlDbType.Bit,3, Record.Data2Flag)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,11, Iif(Record.AdviceNo= "" ,Convert.DBNull, Record.AdviceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIRNo",SqlDbType.Int,11, Iif(Record.AgentsIRNo= "" ,Convert.DBNull, Record.AgentsIRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIRNo",SqlDbType.Int,11, Iif(Record.AgencyIRNo= "" ,Convert.DBNull, Record.AgencyIRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo", SqlDbType.NVarChar, 50, IIf(Record.UploadBatchNo = "", Convert.DBNull, Record.UploadBatchNo))
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
    Public Shared Function spmtAirTicketUpdate(ByVal Record As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
      Dim _Rec As SIS.SPMT.spmtAirTicket = SIS.SPMT.spmtAirTicket.spmtAirTicketGetByID(Record.SerialNo)
      With _Rec
        .TranTypeID = Record.TranTypeID
        .AgentsIsgecGSTIN = Record.AgentsIsgecGSTIN
        .AgentsStateID = Record.AgentsStateID
        .AgentsBillNumber = Record.AgentsBillNumber
        .AgentsBillDate = Record.AgentsBillDate
        .AgentsItemName = Record.AgentsItemName
        .AgentsBPID = Record.AgentsBPID
        .AgentsGSTIN = Record.AgentsGSTIN
        .AgentsName = Record.AgentsName
        .AgentsGSTINNumber = Record.AgentsGSTINNumber
        .AgentsBillType = Record.AgentsBillType
        .AgentsHSNSACCode = Record.AgentsHSNSACCode
        .AgentsBasicValue = Record.AgentsBasicValue
        .AgentsIGSTRate = Record.AgentsIGSTRate
        .AgentsIGSTAmount = Record.AgentsIGSTAmount
        .AgentsSGSTRate = Record.AgentsSGSTRate
        .AgentsSGSTAmount = Record.AgentsSGSTAmount
        .AgentsCGSTRate = Record.AgentsCGSTRate
        .AgentsCGSTAmount = Record.AgentsCGSTAmount
        .AgentsCessRate = Record.AgentsCessRate
        .AgentsCessAmount = Record.AgentsCessAmount
        .AgentsTotalGST = Record.AgentsTotalGST
        .AgentsTotalAmount = Record.AgentsTotalAmount
        .AgentsRCMApplicable = Record.AgentsRCMApplicable
        .AgencyIsgecGSTIN = Record.AgencyIsgecGSTIN
        .AgencyStateID = Record.AgencyStateID
        .AgencyBillNumber = Record.AgencyBillNumber
        .AgencyBillDate = Record.AgencyBillDate
        .AgencyItemName = Record.AgencyItemName
        .AgencyBPID = Record.AgencyBPID
        .AgencyGSTIN = Record.AgencyGSTIN
        .AgencyName = Record.AgencyName
        .AgencyGSTINNumber = Record.AgencyGSTINNumber
        .AgencyBillType = Record.AgencyBillType
        .AgencyHSNSACCode = Record.AgencyHSNSACCode
        .AgencyBasicValue = Record.AgencyBasicValue
        .AgencyIGSTRate = Record.AgencyIGSTRate
        .AgencyIGSTAmount = Record.AgencyIGSTAmount
        .AgencySGSTRate = Record.AgencySGSTRate
        .AgencySGSTAmount = Record.AgencySGSTAmount
        .AgencyCGSTRate = Record.AgencyCGSTRate
        .AgencyCGSTAmount = Record.AgencyCGSTAmount
        .AgencyCessRate = Record.AgencyCessRate
        .AgencyCessAmount = Record.AgencyCessAmount
        .AgencyTotalGST = Record.AgencyTotalGST
        .AgencyTotalAmount = Record.AgencyTotalAmount
        .AgencyRCMApplicable = Record.AgencyRCMApplicable
        .NonGST1TaxRate = Record.NonGST1TaxRate
        .NonGST1TaxAmount = Record.NonGST1TaxAmount
        .NonGST2TaxRate = Record.NonGST2TaxRate
        .NonGST2TaxAmount = Record.NonGST2TaxAmount
        .TotalPayableToAgent = Record.TotalPayableToAgent
        .PaxName = Record.PaxName
        .Sector = Record.Sector
        .TravelDate = Record.TravelDate
        .ReferrenceNumber = Record.ReferrenceNumber
        .EmployeeID = Record.EmployeeID
        .ProjectID = Record.ProjectID
        .ISGECUnit = Record.ISGECUnit
        .Geography = Record.Geography
        .Data1Flag = Record.Data1Flag
        .Data2Flag = Record.Data2Flag
        .StatusID = Record.StatusID
        .AdviceNo = Record.AdviceNo
        .AgentsIRNo = Record.AgentsIRNo
        .AgencyIRNo = Record.AgencyIRNo
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtAirTicket.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtAirTicketUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo",SqlDbType.Int,11, Record.SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Iif(Record.TranTypeID= "" ,Convert.DBNull, Record.TranTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIsgecGSTIN",SqlDbType.Int,11, Iif(Record.AgentsIsgecGSTIN= "" ,Convert.DBNull, Record.AgentsIsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsStateID",SqlDbType.NVarChar,3, Iif(Record.AgentsStateID= "" ,Convert.DBNull, Record.AgentsStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBillNumber",SqlDbType.NVarChar,51, Iif(Record.AgentsBillNumber= "" ,Convert.DBNull, Record.AgentsBillNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBillDate",SqlDbType.DateTime,21, Iif(Record.AgentsBillDate= "" ,Convert.DBNull, Record.AgentsBillDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsItemName",SqlDbType.NVarChar,51, Iif(Record.AgentsItemName= "" ,Convert.DBNull, Record.AgentsItemName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBPID",SqlDbType.NVarChar,10, Iif(Record.AgentsBPID= "" ,Convert.DBNull, Record.AgentsBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsGSTIN",SqlDbType.Int,11, Iif(Record.AgentsGSTIN= "" ,Convert.DBNull, Record.AgentsGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsName",SqlDbType.NVarChar,51, Iif(Record.AgentsName= "" ,Convert.DBNull, Record.AgentsName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsGSTINNumber",SqlDbType.NVarChar,51, Iif(Record.AgentsGSTINNumber= "" ,Convert.DBNull, Record.AgentsGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBillType",SqlDbType.Int,11, Iif(Record.AgentsBillType= "" ,Convert.DBNull, Record.AgentsBillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsHSNSACCode",SqlDbType.NVarChar,21, Iif(Record.AgentsHSNSACCode= "" ,Convert.DBNull, Record.AgentsHSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsBasicValue",SqlDbType.Decimal,21, Record.AgentsBasicValue)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIGSTRate",SqlDbType.Decimal,21, Record.AgentsIGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIGSTAmount",SqlDbType.Decimal,21, Record.AgentsIGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsSGSTRate",SqlDbType.Decimal,21, Record.AgentsSGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsSGSTAmount",SqlDbType.Decimal,21, Record.AgentsSGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCGSTRate",SqlDbType.Decimal,21, Record.AgentsCGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCGSTAmount",SqlDbType.Decimal,21, Record.AgentsCGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCessRate",SqlDbType.Decimal,21, Record.AgentsCessRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsCessAmount",SqlDbType.Decimal,21, Record.AgentsCessAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsTotalGST",SqlDbType.Decimal,21, Record.AgentsTotalGST)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsTotalAmount",SqlDbType.Decimal,21, Record.AgentsTotalAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsRCMApplicable",SqlDbType.Bit,3, Record.AgentsRCMApplicable)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIsgecGSTIN",SqlDbType.Int,11, Iif(Record.AgencyIsgecGSTIN= "" ,Convert.DBNull, Record.AgencyIsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyStateID",SqlDbType.NVarChar,3, Iif(Record.AgencyStateID= "" ,Convert.DBNull, Record.AgencyStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBillNumber",SqlDbType.NVarChar,51, Iif(Record.AgencyBillNumber= "" ,Convert.DBNull, Record.AgencyBillNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBillDate",SqlDbType.DateTime,21, Iif(Record.AgencyBillDate= "" ,Convert.DBNull, Record.AgencyBillDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyItemName",SqlDbType.NVarChar,51, Iif(Record.AgencyItemName= "" ,Convert.DBNull, Record.AgencyItemName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBPID",SqlDbType.NVarChar,10, Iif(Record.AgencyBPID= "" ,Convert.DBNull, Record.AgencyBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyGSTIN",SqlDbType.Int,11, Iif(Record.AgencyGSTIN= "" ,Convert.DBNull, Record.AgencyGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyName",SqlDbType.NVarChar,51, Iif(Record.AgencyName= "" ,Convert.DBNull, Record.AgencyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyGSTINNumber",SqlDbType.NVarChar,51, Iif(Record.AgencyGSTINNumber= "" ,Convert.DBNull, Record.AgencyGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBillType",SqlDbType.Int,11, Iif(Record.AgencyBillType= "" ,Convert.DBNull, Record.AgencyBillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyHSNSACCode",SqlDbType.NVarChar,21, Iif(Record.AgencyHSNSACCode= "" ,Convert.DBNull, Record.AgencyHSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyBasicValue",SqlDbType.Decimal,21, Record.AgencyBasicValue)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIGSTRate",SqlDbType.Decimal,21, Record.AgencyIGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIGSTAmount",SqlDbType.Decimal,21, Record.AgencyIGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencySGSTRate",SqlDbType.Decimal,21, Record.AgencySGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencySGSTAmount",SqlDbType.Decimal,21, Record.AgencySGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCGSTRate",SqlDbType.Decimal,21, Record.AgencyCGSTRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCGSTAmount",SqlDbType.Decimal,21, Record.AgencyCGSTAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCessRate",SqlDbType.Decimal,21, Record.AgencyCessRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyCessAmount",SqlDbType.Decimal,21, Record.AgencyCessAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyTotalGST",SqlDbType.Decimal,21, Record.AgencyTotalGST)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyTotalAmount",SqlDbType.Decimal,21, Record.AgencyTotalAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyRCMApplicable",SqlDbType.Bit,3, Record.AgencyRCMApplicable)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST1TaxRate",SqlDbType.Decimal,21, Record.NonGST1TaxRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST1TaxAmount",SqlDbType.Decimal,21, Record.NonGST1TaxAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST2TaxRate",SqlDbType.Decimal,21, Record.NonGST2TaxRate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@NonGST2TaxAmount",SqlDbType.Decimal,21, Record.NonGST2TaxAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalPayableToAgent",SqlDbType.Decimal,21, Record.TotalPayableToAgent)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PaxName",SqlDbType.NVarChar,51, Iif(Record.PaxName= "" ,Convert.DBNull, Record.PaxName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Sector",SqlDbType.NVarChar,51, Iif(Record.Sector= "" ,Convert.DBNull, Record.Sector))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TravelDate",SqlDbType.DateTime,21, Iif(Record.TravelDate= "" ,Convert.DBNull, Record.TravelDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReferrenceNumber",SqlDbType.NVarChar,51, Iif(Record.ReferrenceNumber= "" ,Convert.DBNull, Record.ReferrenceNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ISGECUnit",SqlDbType.NVarChar,11, Iif(Record.ISGECUnit= "" ,Convert.DBNull, Record.ISGECUnit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Geography", SqlDbType.NVarChar, 21, IIf(Record.Geography = "", Convert.DBNull, Record.Geography))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Data1Flag",SqlDbType.Bit,3, Record.Data1Flag)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Data2Flag",SqlDbType.Bit,3, Record.Data2Flag)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,11, Iif(Record.AdviceNo= "" ,Convert.DBNull, Record.AdviceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgentsIRNo",SqlDbType.Int,11, Iif(Record.AgentsIRNo= "" ,Convert.DBNull, Record.AgentsIRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AgencyIRNo",SqlDbType.Int,11, Iif(Record.AgencyIRNo= "" ,Convert.DBNull, Record.AgencyIRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo", SqlDbType.NVarChar, 50, IIf(Record.UploadBatchNo = "", Convert.DBNull, Record.UploadBatchNo))
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
    Public Shared Function spmtAirTicketDelete(ByVal Record As SIS.SPMT.spmtAirTicket) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtAirTicketDelete"
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
    Public Shared Function SelectspmtAirTicketAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtAirTicketAutoCompleteList"
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
            Dim Tmp As SIS.SPMT.spmtAirTicket = New SIS.SPMT.spmtAirTicket(Reader)
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
