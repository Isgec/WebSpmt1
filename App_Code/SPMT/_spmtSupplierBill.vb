Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtSupplierBill
    Private Shared _RecordCount As Integer
    Private _IRNo As Int32 = 0
    Private _TranTypeID As String = ""
    Private _BPID As String = ""
    Private _BillNumber As String = ""
    Private _BillDate As String = ""
    Private _BillAmount As Decimal = 0
    Private _AdviceNo As String = ""
    Private _Quantity As String = "0.00"
    Private _UOM As String = ""
    Private _Currency As String = ""
    Private _BillRemarks As String = ""
    Private _SupplierGSTIN As String = ""
    Private _IsgecGSTIN As String = ""
    Private _IRReceivedOn As String = ""
    Private _ShipToState As String = ""
    Private _HSNSACCode As String = ""
    Private _BillType As String = ""
    Private _ConversionFactorINR As String = "0.00"
    Private _TotalGST As String = "0.00"
    Private _CessAmount As String = "0.00"
    Private _CessRate As String = "0.00"
    Private _TaxAmount As String = "0.00"
    Private _RemarksGST As String = ""
    Private _TotalAmountINR As String = "0.00"
    Private _TotalAmount As String = "0.00"
    Private _IGSTAmount As String = "0.00"
    Private _IGSTRate As String = "0.00"
    Private _AssessableValue As String = "0.00"
    Private _CGSTRate As String = "0.00"
    Private _SGSTAmount As String = "0.00"
    Private _SGSTRate As String = "0.00"
    Private _CGSTAmount As String = "0.00"
    Private _DocLine As String = ""
    Private _ReturnedByAC As Boolean = False
    Private _RemarksAC As String = ""
    Private _PassedAmount As String = "0.00"
    Private _ReasonID As String = ""
    Private _ProjectID As String = ""
    Private _CostCenter As String = ""
    Private _ConcernedHOD As String = ""
    Private _Remarks As String = ""
    Private _BillStatusID As Int32 = 0
    Private _VendorID As String = ""
    Private _PurchaseType As String = ""
    Private _BillStatusDate As String = ""
    Private _ApprovedAmount As String = "0.00"
    Private _LogisticLinked As Boolean = False
    Private _BillStatusUser As String = ""
    Private _Discount As String = "0.00"
    Private _BasicValue As String = "0.00"
    Private _BaaNLedger As String = ""
    Private _ServiceCharge As String = "0.00"
    Private _DocNo As String = ""
    Private _BatchNo As String = ""
    Private _TaxRate As String = "0.00"
    Private _BaaNCompany As String = ""
    Private _DepartmentID As String = ""
    Private _EmployeeID As String = ""
    Private _ElementID As String = ""
    Private _CostCenterID As String = ""
    Private _DocumentLine As String = ""
    Private _DocumentNo As String = ""
    Private _VoucherNo As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _aspnet_Users2_UserFullName As String = ""
    Private _aspnet_Users3_UserFullName As String = ""
    Private _HRM_Departments4_Description As String = ""
    Private _IDM_Projects5_Description As String = ""
    Private _IDM_WBS6_Description As String = ""
    Private _SPMT_BillStatus7_Description As String = ""
    Private _SPMT_BillTypes8_Description As String = ""
    Private _SPMT_CostCenters9_Description As String = ""
    Private _SPMT_ERPStates10_Description As String = ""
    Private _SPMT_ERPUnits11_Description As String = ""
    Private _SPMT_HSNSACCodes12_HSNSACCode As String = ""
    Private _SPMT_IsgecGSTIN13_Description As String = ""
    Private _SPMT_PaymentAdvice14_BPID As String = ""
    Private _SPMT_ReturnReason15_Description As String = ""
    Private _SPMT_TranTypes16_Description As String = ""
    Private _VR_BPGSTIN17_Description As String = ""
    Private _VR_BusinessPartner18_BPName As String = ""
    Private _FK_SPMT_SupplierBill_BillStatusUser As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_SupplierBill_ConcernedHOD As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_SupplierBill_EmployeeID As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_SupplierBill_DepartmentID As SIS.COM.comDepartments = Nothing
    Private _FK_SPMT_SupplierBill_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_SupplierBill_ElementID As SIS.COM.comElements = Nothing
    Private _FK_SPMT_SupplierBill_BillStatusID As SIS.SPMT.spmtBillStatus = Nothing
    Private _FK_SPMT_SupplierBill_BillType As SIS.SPMT.spmtBillTypes = Nothing
    Private _FK_SPMT_SupplierBill_CostCenterID As SIS.SPMT.spmtCostCenters = Nothing
    Private _FK_SPMT_SupplierBill_ShipToState As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_SupplierBill_UOM As SIS.SPMT.spmtERPUnits = Nothing
    Private _FK_SPMT_SupplierBill_HSNSACCode As SIS.SPMT.spmtHSNSACCodes = Nothing
    Private _FK_SPMT_SupplierBill_IsgecGSTIN As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_SupplierBill_AdviceNo As SIS.SPMT.spmtPaymentAdvice = Nothing
    Private _FK_SPMT_SupplierBill_ReasonID As SIS.SPMT.spmtReturnReason = Nothing
    Private _FK_SPMT_SupplierBill_TranTypeID As SIS.SPMT.spmtTranTypes = Nothing
    Private _FK_SPMT_SupplierBill_SupplierGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_SupplierBill_BPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Public Property SupplierName As String = ""
    Public Property SupplierGSTINNumber As String = ""
    Public Property UploadBatchNo As String = ""
    Public ReadOnly Property temp_ShipToState As String
      Get
        Try
          If TranTypeID <> "HTL" Then
            Return SPMT_IsgecGSTIN13_Description.Substring(0, 2)
          Else
            If VR_BPGSTIN17_Description <> "" Then
              Return VR_BPGSTIN17_Description.Substring(0, 2)
            Else
              Return SupplierGSTINNumber.Substring(0, 2)
            End If
          End If
        Catch ex As Exception
        End Try
        Return ""
      End Get
    End Property

    <SYS.Utilities.lgSkip()>
    Public Property ServiceCharge() As String
      Get
        Return _ServiceCharge
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ServiceCharge = "0.00"
        Else
          _ServiceCharge = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property BatchNo() As String
      Get
        Return _BatchNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _BatchNo = ""
        Else
          _BatchNo = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property TaxRate() As String
      Get
        Return _TaxRate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _TaxRate = "0.00"
        Else
          _TaxRate = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property BaaNCompany() As String
      Get
        Return _BaaNCompany
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _BaaNCompany = ""
        Else
          _BaaNCompany = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property EmployeeID() As String
      Get
        Return _EmployeeID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _EmployeeID = ""
        Else
          _EmployeeID = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property ElementID() As String
      Get
        Return _ElementID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ElementID = ""
        Else
          _ElementID = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property ReturnedByAC() As Boolean
      Get
        Return _ReturnedByAC
      End Get
      Set(ByVal value As Boolean)
        _ReturnedByAC = value
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property RemarksAC() As String
      Get
        Return _RemarksAC
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _RemarksAC = ""
        Else
          _RemarksAC = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property PassedAmount() As String
      Get
        Return _PassedAmount
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PassedAmount = "0.00"
        Else
          _PassedAmount = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property ReasonID() As String
      Get
        Return _ReasonID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ReasonID = ""
        Else
          _ReasonID = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ProjectID = ""
        Else
          _ProjectID = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property CostCenter() As String
      Get
        Return _CostCenter
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _CostCenter = ""
        Else
          _CostCenter = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property ConcernedHOD() As String
      Get
        Return _ConcernedHOD
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConcernedHOD = ""
        Else
          _ConcernedHOD = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property Remarks() As String
      Get
        Return _Remarks
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Remarks = ""
        Else
          _Remarks = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property BaaNLedger() As String
      Get
        Return _BaaNLedger
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _BaaNLedger = ""
        Else
          _BaaNLedger = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property CostCenterID() As String
      Get
        Return _CostCenterID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _CostCenterID = ""
        Else
          _CostCenterID = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property DocumentLine() As String
      Get
        Return _DocumentLine
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DocumentLine = ""
        Else
          _DocumentLine = value
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
    <SYS.Utilities.lgSkip()>
    Public Property ApprovedAmount() As String
      Get
        Return _ApprovedAmount
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ApprovedAmount = "0.00"
        Else
          _ApprovedAmount = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property Discount() As String
      Get
        Return _Discount
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Discount = "0.00"
        Else
          _Discount = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property BasicValue() As String
      Get
        Return _BasicValue
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _BasicValue = "0.00"
        Else
          _BasicValue = value
        End If
      End Set
    End Property
    <SYS.Utilities.lgSkip()>
    Public Property DocumentNo() As String
      Get
        Return _DocumentNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DocumentNo = ""
        Else
          _DocumentNo = value
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
    Public Property BillNumber() As String
      Get
        Return _BillNumber
      End Get
      Set(ByVal value As String)
        _BillNumber = value
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
         _BillDate = value
      End Set
    End Property
    Public Property BillAmount() As Decimal
      Get
        Return _BillAmount
      End Get
      Set(ByVal value As Decimal)
        _BillAmount = value
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
    Public Property TaxAmount() As String
      Get
        Return _TaxAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TaxAmount = "0.00"
         Else
           _TaxAmount = value
         End If
      End Set
    End Property
    Public Property RemarksGST() As String
      Get
        Return _RemarksGST
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RemarksGST = ""
         Else
           _RemarksGST = value
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

    Public Property BillStatusID() As Int32
      Get
        Return _BillStatusID
      End Get
      Set(ByVal value As Int32)
        _BillStatusID = value
      End Set
    End Property
    Public Property PurchaseType() As String
      Get
        Return _PurchaseType
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PurchaseType = ""
        Else
          _PurchaseType = value
        End If
      End Set
    End Property
    Public Property BillStatusDate() As String
      Get
        If Not _BillStatusDate = String.Empty Then
          Return Convert.ToDateTime(_BillStatusDate).ToString("dd/MM/yyyy")
        End If
        Return _BillStatusDate
      End Get
      Set(ByVal value As String)
         _BillStatusDate = value
      End Set
    End Property
    Public Property LogisticLinked() As Boolean
      Get
        Return _LogisticLinked
      End Get
      Set(ByVal value As Boolean)
        _LogisticLinked = value
      End Set
    End Property
    Public Property BillStatusUser() As String
      Get
        Return _BillStatusUser
      End Get
      Set(ByVal value As String)
        _BillStatusUser = value
      End Set
    End Property
    Public Property DocNo() As String
      Get
        If _DocNo = "" Then
          _DocNo = "SPMT"
        End If
        Return _DocNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DocNo = "SPMT"
        Else
          _DocNo = value
        End If
      End Set
    End Property
    Public Property DocLine() As String
      Get
        Return _DocLine
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DocLine = ""
        Else
          _DocLine = value
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
    Public Property SPMT_BillStatus7_Description() As String
      Get
        Return _SPMT_BillStatus7_Description
      End Get
      Set(ByVal value As String)
        _SPMT_BillStatus7_Description = value
      End Set
    End Property
    Public Property SPMT_BillTypes8_Description() As String
      Get
        Return _SPMT_BillTypes8_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_BillTypes8_Description = ""
         Else
           _SPMT_BillTypes8_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_CostCenters9_Description() As String
      Get
        Return _SPMT_CostCenters9_Description
      End Get
      Set(ByVal value As String)
        _SPMT_CostCenters9_Description = value
      End Set
    End Property
    Public Property SPMT_ERPStates10_Description() As String
      Get
        Return _SPMT_ERPStates10_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates10_Description = ""
         Else
           _SPMT_ERPStates10_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPUnits11_Description() As String
      Get
        Return _SPMT_ERPUnits11_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPUnits11_Description = ""
         Else
           _SPMT_ERPUnits11_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_HSNSACCodes12_HSNSACCode() As String
      Get
        Return _SPMT_HSNSACCodes12_HSNSACCode
      End Get
      Set(ByVal value As String)
        _SPMT_HSNSACCodes12_HSNSACCode = value
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN13_Description() As String
      Get
        Return _SPMT_IsgecGSTIN13_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN13_Description = ""
         Else
           _SPMT_IsgecGSTIN13_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_PaymentAdvice14_BPID() As String
      Get
        Return _SPMT_PaymentAdvice14_BPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_PaymentAdvice14_BPID = ""
         Else
           _SPMT_PaymentAdvice14_BPID = value
         End If
      End Set
    End Property
    Public Property SPMT_ReturnReason15_Description() As String
      Get
        Return _SPMT_ReturnReason15_Description
      End Get
      Set(ByVal value As String)
        _SPMT_ReturnReason15_Description = value
      End Set
    End Property
    Public Property SPMT_TranTypes16_Description() As String
      Get
        Return _SPMT_TranTypes16_Description
      End Get
      Set(ByVal value As String)
        _SPMT_TranTypes16_Description = value
      End Set
    End Property
    Public Property VR_BPGSTIN17_Description() As String
      Get
        Return _VR_BPGSTIN17_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN17_Description = ""
         Else
           _VR_BPGSTIN17_Description = value
         End If
      End Set
    End Property
    Public Property VR_BusinessPartner18_BPName() As String
      Get
        Return _VR_BusinessPartner18_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner18_BPName = value
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
    Public Class PKspmtSupplierBill
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
    Public ReadOnly Property FK_SPMT_SupplierBill_BillStatusUser() As SIS.COM.comUsers
      Get
        If _FK_SPMT_SupplierBill_BillStatusUser Is Nothing Then
          _FK_SPMT_SupplierBill_BillStatusUser = SIS.COM.comUsers.comUsersGetByID(_BillStatusUser)
        End If
        Return _FK_SPMT_SupplierBill_BillStatusUser
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_ConcernedHOD() As SIS.COM.comUsers
      Get
        If _FK_SPMT_SupplierBill_ConcernedHOD Is Nothing Then
          _FK_SPMT_SupplierBill_ConcernedHOD = SIS.COM.comUsers.comUsersGetByID(_ConcernedHOD)
        End If
        Return _FK_SPMT_SupplierBill_ConcernedHOD
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_EmployeeID() As SIS.COM.comUsers
      Get
        If _FK_SPMT_SupplierBill_EmployeeID Is Nothing Then
          _FK_SPMT_SupplierBill_EmployeeID = SIS.COM.comUsers.comUsersGetByID(_EmployeeID)
        End If
        Return _FK_SPMT_SupplierBill_EmployeeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_DepartmentID() As SIS.COM.comDepartments
      Get
        If _FK_SPMT_SupplierBill_DepartmentID Is Nothing Then
          _FK_SPMT_SupplierBill_DepartmentID = SIS.COM.comDepartments.comDepartmentsGetByID(_DepartmentID)
        End If
        Return _FK_SPMT_SupplierBill_DepartmentID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_SupplierBill_ProjectID Is Nothing Then
          _FK_SPMT_SupplierBill_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_SupplierBill_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_ElementID() As SIS.COM.comElements
      Get
        If _FK_SPMT_SupplierBill_ElementID Is Nothing Then
          _FK_SPMT_SupplierBill_ElementID = SIS.COM.comElements.comElementsGetByID(_ElementID)
        End If
        Return _FK_SPMT_SupplierBill_ElementID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_BillStatusID() As SIS.SPMT.spmtBillStatus
      Get
        If _FK_SPMT_SupplierBill_BillStatusID Is Nothing Then
          _FK_SPMT_SupplierBill_BillStatusID = SIS.SPMT.spmtBillStatus.spmtBillStatusGetByID(_BillStatusID)
        End If
        Return _FK_SPMT_SupplierBill_BillStatusID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_BillType() As SIS.SPMT.spmtBillTypes
      Get
        If _FK_SPMT_SupplierBill_BillType Is Nothing Then
          _FK_SPMT_SupplierBill_BillType = SIS.SPMT.spmtBillTypes.spmtBillTypesGetByID(_BillType)
        End If
        Return _FK_SPMT_SupplierBill_BillType
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_CostCenterID() As SIS.SPMT.spmtCostCenters
      Get
        If _FK_SPMT_SupplierBill_CostCenterID Is Nothing Then
          _FK_SPMT_SupplierBill_CostCenterID = SIS.SPMT.spmtCostCenters.spmtCostCentersGetByID(_CostCenterID)
        End If
        Return _FK_SPMT_SupplierBill_CostCenterID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_ShipToState() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_SupplierBill_ShipToState Is Nothing Then
          _FK_SPMT_SupplierBill_ShipToState = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ShipToState)
        End If
        Return _FK_SPMT_SupplierBill_ShipToState
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_UOM() As SIS.SPMT.spmtERPUnits
      Get
        If _FK_SPMT_SupplierBill_UOM Is Nothing Then
          _FK_SPMT_SupplierBill_UOM = SIS.SPMT.spmtERPUnits.spmtERPUnitsGetByID(_UOM)
        End If
        Return _FK_SPMT_SupplierBill_UOM
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_HSNSACCode() As SIS.SPMT.spmtHSNSACCodes
      Get
        If _FK_SPMT_SupplierBill_HSNSACCode Is Nothing Then
          _FK_SPMT_SupplierBill_HSNSACCode = SIS.SPMT.spmtHSNSACCodes.spmtHSNSACCodesGetByID(_BillType, _HSNSACCode)
        End If
        Return _FK_SPMT_SupplierBill_HSNSACCode
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_IsgecGSTIN() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_SupplierBill_IsgecGSTIN Is Nothing Then
          _FK_SPMT_SupplierBill_IsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_IsgecGSTIN)
        End If
        Return _FK_SPMT_SupplierBill_IsgecGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_AdviceNo() As SIS.SPMT.spmtPaymentAdvice
      Get
        If _FK_SPMT_SupplierBill_AdviceNo Is Nothing Then
          _FK_SPMT_SupplierBill_AdviceNo = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(_AdviceNo)
        End If
        Return _FK_SPMT_SupplierBill_AdviceNo
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_ReasonID() As SIS.SPMT.spmtReturnReason
      Get
        If _FK_SPMT_SupplierBill_ReasonID Is Nothing Then
          _FK_SPMT_SupplierBill_ReasonID = SIS.SPMT.spmtReturnReason.spmtReturnReasonGetByID(_ReasonID)
        End If
        Return _FK_SPMT_SupplierBill_ReasonID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_TranTypeID() As SIS.SPMT.spmtTranTypes
      Get
        If _FK_SPMT_SupplierBill_TranTypeID Is Nothing Then
          _FK_SPMT_SupplierBill_TranTypeID = SIS.SPMT.spmtTranTypes.spmtTranTypesGetByID(_TranTypeID)
        End If
        Return _FK_SPMT_SupplierBill_TranTypeID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_SupplierGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_SupplierBill_SupplierGSTIN Is Nothing Then
          _FK_SPMT_SupplierBill_SupplierGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_BPID, _SupplierGSTIN)
        End If
        Return _FK_SPMT_SupplierBill_SupplierGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_SupplierBill_BPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_SupplierBill_BPID Is Nothing Then
          _FK_SPMT_SupplierBill_BPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_BPID)
        End If
        Return _FK_SPMT_SupplierBill_BPID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtSupplierBillSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtSupplierBill)
      Dim Results As List(Of SIS.SPMT.spmtSupplierBill) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtSupplierBill)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtSupplierBill(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtSupplierBillGetNewRecord() As SIS.SPMT.spmtSupplierBill
      Return New SIS.SPMT.spmtSupplierBill()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtSupplierBillGetByID(ByVal IRNo As Int32) As SIS.SPMT.spmtSupplierBill
      Dim Results As SIS.SPMT.spmtSupplierBill = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRNo",SqlDbType.Int,IRNo.ToString.Length, IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtSupplierBill(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtSupplierBillSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32, ByVal TranTypeID As String, ByVal BPID As String, ByVal PurchaseType As String) As List(Of SIS.SPMT.spmtSupplierBill)
      Dim Results As List(Of SIS.SPMT.spmtSupplierBill) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "IRNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtSupplierBillSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtSupplierBillSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_IRNo",SqlDbType.Int,10, IIf(IRNo = Nothing, 0,IRNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID",SqlDbType.NVarChar,3, IIf(TranTypeID Is Nothing, String.Empty,TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID",SqlDbType.NVarChar,9, IIf(BPID Is Nothing, String.Empty,BPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_PurchaseType",SqlDbType.NVarChar,50, IIf(PurchaseType Is Nothing, String.Empty,PurchaseType))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtSupplierBill)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtSupplierBill(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtSupplierBillSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal IRNo As Int32, ByVal TranTypeID As String, ByVal BPID As String, ByVal PurchaseType As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtSupplierBillGetByID(ByVal IRNo As Int32, ByVal Filter_IRNo As Int32, ByVal Filter_TranTypeID As String, ByVal Filter_BPID As String, ByVal Filter_PurchaseType As String) As SIS.SPMT.spmtSupplierBill
      Return spmtSupplierBillGetByID(IRNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtSupplierBillInsert(ByVal Record As SIS.SPMT.spmtSupplierBill) As SIS.SPMT.spmtSupplierBill
      Dim _Rec As SIS.SPMT.spmtSupplierBill = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetNewRecord()
      With _Rec
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .BillStatusID = 4
        .BillStatusDate = Now
        .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
        .DocNo = "SPMT"
        .BillAmount = Record.TotalAmountINR
        .IRReceivedOn = Now
        .BPID = Record.BPID
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .Quantity = Record.Quantity
        .UOM = Record.UOM
        .Currency = Record.Currency
        .BillRemarks = Record.BillRemarks
        .SupplierGSTIN = Record.SupplierGSTIN
        .IsgecGSTIN = Record.IsgecGSTIN
        .ShipToState = Record.ShipToState
        .HSNSACCode = Record.HSNSACCode
        .BillType = Record.BillType
        .ConversionFactorINR = Record.ConversionFactorINR
        .TotalGST = Record.TotalGST
        .CessAmount = Record.CessAmount
        .CessRate = Record.CessRate
        .TaxAmount = Record.TaxAmount
        .RemarksGST = Record.RemarksGST
        .TotalAmountINR = Record.TotalAmountINR
        .TotalAmount = Record.TotalAmount
        .IGSTAmount = Record.IGSTAmount
        .IGSTRate = Record.IGSTRate
        .AssessableValue = Record.AssessableValue
        .CGSTRate = Record.CGSTRate
        .SGSTAmount = Record.SGSTAmount
        .SGSTRate = Record.SGSTRate
        .CGSTAmount = Record.CGSTAmount
        .PurchaseType = Record.PurchaseType
        .SupplierName = Record.SupplierName
        .SupplierGSTINNumber = Record.SupplierGSTINNumber
        .DepartmentID = Record.DepartmentID
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtSupplierBill.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtSupplierBill) As SIS.SPMT.spmtSupplierBill
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Record.TranTypeID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillNumber",SqlDbType.NVarChar,51, Record.BillNumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillDate",SqlDbType.DateTime,21, Record.BillDate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillAmount",SqlDbType.Decimal,13, Record.BillAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,11, Iif(Record.AdviceNo= "" ,Convert.DBNull, Record.AdviceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,21, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM",SqlDbType.NVarChar,4, Iif(Record.UOM= "" ,Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Currency",SqlDbType.NVarChar,51, Iif(Record.Currency= "" ,Convert.DBNull, Record.Currency))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillRemarks",SqlDbType.NVarChar,501, Iif(Record.BillRemarks= "" ,Convert.DBNull, Record.BillRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTIN",SqlDbType.Int,11, Iif(Record.SupplierGSTIN= "" ,Convert.DBNull, Record.SupplierGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecGSTIN",SqlDbType.Int,11, Iif(Record.IsgecGSTIN= "" ,Convert.DBNull, Record.IsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRReceivedOn",SqlDbType.DateTime,21, Iif(Record.IRReceivedOn= "" ,Convert.DBNull, Record.IRReceivedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ShipToState",SqlDbType.NVarChar,3, Iif(Record.ShipToState= "" ,Convert.DBNull, Record.ShipToState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@HSNSACCode",SqlDbType.NVarChar,21, Iif(Record.HSNSACCode= "" ,Convert.DBNull, Record.HSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillType",SqlDbType.Int,11, Iif(Record.BillType= "" ,Convert.DBNull, Record.BillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConversionFactorINR",SqlDbType.Decimal,25, Iif(Record.ConversionFactorINR= "" ,Convert.DBNull, Record.ConversionFactorINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGST",SqlDbType.Decimal,21, Iif(Record.TotalGST= "" ,Convert.DBNull, Record.TotalGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessAmount",SqlDbType.Decimal,21, Iif(Record.CessAmount= "" ,Convert.DBNull, Record.CessAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessRate",SqlDbType.Decimal,21, Iif(Record.CessRate= "" ,Convert.DBNull, Record.CessRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TaxAmount",SqlDbType.Decimal,21, Iif(Record.TaxAmount= "" ,Convert.DBNull, Record.TaxAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksGST",SqlDbType.NVarChar,251, Iif(Record.RemarksGST= "" ,Convert.DBNull, Record.RemarksGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountINR",SqlDbType.Decimal,21, Iif(Record.TotalAmountINR= "" ,Convert.DBNull, Record.TotalAmountINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,21, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTAmount",SqlDbType.Decimal,21, Iif(Record.IGSTAmount= "" ,Convert.DBNull, Record.IGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTRate",SqlDbType.Decimal,21, Iif(Record.IGSTRate= "" ,Convert.DBNull, Record.IGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AssessableValue",SqlDbType.Decimal,21, Iif(Record.AssessableValue= "" ,Convert.DBNull, Record.AssessableValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTRate",SqlDbType.Decimal,21, Iif(Record.CGSTRate= "" ,Convert.DBNull, Record.CGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTAmount",SqlDbType.Decimal,21, Iif(Record.SGSTAmount= "" ,Convert.DBNull, Record.SGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTRate",SqlDbType.Decimal,21, Iif(Record.SGSTRate= "" ,Convert.DBNull, Record.SGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTAmount",SqlDbType.Decimal,21, Iif(Record.CGSTAmount= "" ,Convert.DBNull, Record.CGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocLine",SqlDbType.NVarChar,11, Iif(Record.DocLine= "" ,Convert.DBNull, Record.DocLine))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReturnedByAC",SqlDbType.Bit,3, Record.ReturnedByAC)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksAC",SqlDbType.NVarChar,501, Iif(Record.RemarksAC= "" ,Convert.DBNull, Record.RemarksAC))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PassedAmount",SqlDbType.Decimal,13, Iif(Record.PassedAmount= "" ,Convert.DBNull, Record.PassedAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReasonID",SqlDbType.Int,11, Iif(Record.ReasonID= "" ,Convert.DBNull, Record.ReasonID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenter",SqlDbType.NVarChar,51, Iif(Record.CostCenter= "" ,Convert.DBNull, Record.CostCenter))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConcernedHOD",SqlDbType.NVarChar,9, Iif(Record.ConcernedHOD= "" ,Convert.DBNull, Record.ConcernedHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,501, Iif(Record.Remarks= "" ,Convert.DBNull, Record.Remarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillStatusID",SqlDbType.Int,11, Record.BillStatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID",SqlDbType.NVarChar,7, Iif(Record.VendorID= "" ,Convert.DBNull, Record.VendorID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PurchaseType",SqlDbType.NVarChar,51, Iif(Record.PurchaseType= "" ,Convert.DBNull, Record.PurchaseType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillStatusDate",SqlDbType.DateTime,21, Record.BillStatusDate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovedAmount",SqlDbType.Decimal,13, Iif(Record.ApprovedAmount= "" ,Convert.DBNull, Record.ApprovedAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LogisticLinked",SqlDbType.Bit,3, Record.LogisticLinked)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillStatusUser",SqlDbType.NVarChar,9, Record.BillStatusUser)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Discount",SqlDbType.Decimal,21, Iif(Record.Discount= "" ,Convert.DBNull, Record.Discount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BasicValue",SqlDbType.Decimal,21, Iif(Record.BasicValue= "" ,Convert.DBNull, Record.BasicValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNLedger",SqlDbType.NVarChar,21, Iif(Record.BaaNLedger= "" ,Convert.DBNull, Record.BaaNLedger))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ServiceCharge",SqlDbType.Decimal,21, Iif(Record.ServiceCharge= "" ,Convert.DBNull, Record.ServiceCharge))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocNo",SqlDbType.NVarChar,11, Iif(Record.DocNo= "" ,Convert.DBNull, Record.DocNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BatchNo",SqlDbType.NVarChar,11, Iif(Record.BatchNo= "" ,Convert.DBNull, Record.BatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TaxRate",SqlDbType.Decimal,21, Iif(Record.TaxRate= "" ,Convert.DBNull, Record.TaxRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNCompany",SqlDbType.NVarChar,11, Iif(Record.BaaNCompany= "" ,Convert.DBNull, Record.BaaNCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentLine",SqlDbType.NVarChar,51, Iif(Record.DocumentLine= "" ,Convert.DBNull, Record.DocumentLine))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentNo",SqlDbType.NVarChar,51, Iif(Record.DocumentNo= "" ,Convert.DBNull, Record.DocumentNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherNo",SqlDbType.Int,11, Iif(Record.VoucherNo= "" ,Convert.DBNull, Record.VoucherNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName", SqlDbType.NVarChar, 101, IIf(Record.SupplierName = "", Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTINNumber", SqlDbType.NVarChar, 51, IIf(Record.SupplierGSTINNumber = "", Convert.DBNull, Record.SupplierGSTINNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UploadBatchNo", SqlDbType.NVarChar, 50, IIf(Record.UploadBatchNo = "", Convert.DBNull, Record.UploadBatchNo))
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
    Public Shared Function spmtSupplierBillUpdate(ByVal Record As SIS.SPMT.spmtSupplierBill) As SIS.SPMT.spmtSupplierBill
      Dim _Rec As SIS.SPMT.spmtSupplierBill = SIS.SPMT.spmtSupplierBill.spmtSupplierBillGetByID(Record.IRNo)
      With _Rec
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .BillStatusID = 4
        .BillStatusDate = Now
        .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
        .BillAmount = Record.TotalAmountINR
        .IRReceivedOn = Now
        .BPID = Record.BPID
        .BillNumber = Record.BillNumber
        .BillDate = Record.BillDate
        .Quantity = Record.Quantity
        .UOM = Record.UOM
        .Currency = Record.Currency
        .BillRemarks = Record.BillRemarks
        .SupplierGSTIN = Record.SupplierGSTIN
        .IsgecGSTIN = Record.IsgecGSTIN
        .ShipToState = Record.ShipToState
        .HSNSACCode = Record.HSNSACCode
        .BillType = Record.BillType
        .ConversionFactorINR = Record.ConversionFactorINR
        .TotalGST = Record.TotalGST
        .CessAmount = Record.CessAmount
        .CessRate = Record.CessRate
        .TaxAmount = Record.TaxAmount
        .RemarksGST = Record.RemarksGST
        .TotalAmountINR = Record.TotalAmountINR
        .TotalAmount = Record.TotalAmount
        .IGSTAmount = Record.IGSTAmount
        .IGSTRate = Record.IGSTRate
        .AssessableValue = Record.AssessableValue
        .CGSTRate = Record.CGSTRate
        .SGSTAmount = Record.SGSTAmount
        .SGSTRate = Record.SGSTRate
        .CGSTAmount = Record.CGSTAmount
        .PurchaseType = Record.PurchaseType
        .SupplierName = Record.SupplierName
        .SupplierGSTINNumber = Record.SupplierGSTINNumber
        .DepartmentID = Record.DepartmentID
        .UploadBatchNo = Record.UploadBatchNo
      End With
      Return SIS.SPMT.spmtSupplierBill.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtSupplierBill) As SIS.SPMT.spmtSupplierBill
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_IRNo",SqlDbType.Int,11, Record.IRNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TranTypeID",SqlDbType.NVarChar,4, Record.TranTypeID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BPID",SqlDbType.NVarChar,10, Iif(Record.BPID= "" ,Convert.DBNull, Record.BPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillNumber",SqlDbType.NVarChar,51, Record.BillNumber)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillDate",SqlDbType.DateTime,21, Record.BillDate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillAmount",SqlDbType.Decimal,13, Record.BillAmount)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AdviceNo",SqlDbType.Int,11, Iif(Record.AdviceNo= "" ,Convert.DBNull, Record.AdviceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Quantity",SqlDbType.Decimal,21, Iif(Record.Quantity= "" ,Convert.DBNull, Record.Quantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM",SqlDbType.NVarChar,4, Iif(Record.UOM= "" ,Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Currency",SqlDbType.NVarChar,51, Iif(Record.Currency= "" ,Convert.DBNull, Record.Currency))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillRemarks",SqlDbType.NVarChar,501, Iif(Record.BillRemarks= "" ,Convert.DBNull, Record.BillRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTIN",SqlDbType.Int,11, Iif(Record.SupplierGSTIN= "" ,Convert.DBNull, Record.SupplierGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecGSTIN",SqlDbType.Int,11, Iif(Record.IsgecGSTIN= "" ,Convert.DBNull, Record.IsgecGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IRReceivedOn",SqlDbType.DateTime,21, Iif(Record.IRReceivedOn= "" ,Convert.DBNull, Record.IRReceivedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ShipToState",SqlDbType.NVarChar,3, Iif(Record.ShipToState= "" ,Convert.DBNull, Record.ShipToState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@HSNSACCode",SqlDbType.NVarChar,21, Iif(Record.HSNSACCode= "" ,Convert.DBNull, Record.HSNSACCode))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillType",SqlDbType.Int,11, Iif(Record.BillType= "" ,Convert.DBNull, Record.BillType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConversionFactorINR",SqlDbType.Decimal,25, Iif(Record.ConversionFactorINR= "" ,Convert.DBNull, Record.ConversionFactorINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalGST",SqlDbType.Decimal,21, Iif(Record.TotalGST= "" ,Convert.DBNull, Record.TotalGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessAmount",SqlDbType.Decimal,21, Iif(Record.CessAmount= "" ,Convert.DBNull, Record.CessAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CessRate",SqlDbType.Decimal,21, Iif(Record.CessRate= "" ,Convert.DBNull, Record.CessRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TaxAmount",SqlDbType.Decimal,21, Iif(Record.TaxAmount= "" ,Convert.DBNull, Record.TaxAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksGST",SqlDbType.NVarChar,251, Iif(Record.RemarksGST= "" ,Convert.DBNull, Record.RemarksGST))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountINR",SqlDbType.Decimal,21, Iif(Record.TotalAmountINR= "" ,Convert.DBNull, Record.TotalAmountINR))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,21, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTAmount",SqlDbType.Decimal,21, Iif(Record.IGSTAmount= "" ,Convert.DBNull, Record.IGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IGSTRate",SqlDbType.Decimal,21, Iif(Record.IGSTRate= "" ,Convert.DBNull, Record.IGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AssessableValue",SqlDbType.Decimal,21, Iif(Record.AssessableValue= "" ,Convert.DBNull, Record.AssessableValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTRate",SqlDbType.Decimal,21, Iif(Record.CGSTRate= "" ,Convert.DBNull, Record.CGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTAmount",SqlDbType.Decimal,21, Iif(Record.SGSTAmount= "" ,Convert.DBNull, Record.SGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SGSTRate",SqlDbType.Decimal,21, Iif(Record.SGSTRate= "" ,Convert.DBNull, Record.SGSTRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CGSTAmount",SqlDbType.Decimal,21, Iif(Record.CGSTAmount= "" ,Convert.DBNull, Record.CGSTAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocLine",SqlDbType.NVarChar,11, Iif(Record.DocLine= "" ,Convert.DBNull, Record.DocLine))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReturnedByAC",SqlDbType.Bit,3, Record.ReturnedByAC)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksAC",SqlDbType.NVarChar,501, Iif(Record.RemarksAC= "" ,Convert.DBNull, Record.RemarksAC))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PassedAmount",SqlDbType.Decimal,13, Iif(Record.PassedAmount= "" ,Convert.DBNull, Record.PassedAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReasonID",SqlDbType.Int,11, Iif(Record.ReasonID= "" ,Convert.DBNull, Record.ReasonID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenter",SqlDbType.NVarChar,51, Iif(Record.CostCenter= "" ,Convert.DBNull, Record.CostCenter))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConcernedHOD",SqlDbType.NVarChar,9, Iif(Record.ConcernedHOD= "" ,Convert.DBNull, Record.ConcernedHOD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,501, Iif(Record.Remarks= "" ,Convert.DBNull, Record.Remarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillStatusID",SqlDbType.Int,11, Record.BillStatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VendorID",SqlDbType.NVarChar,7, Iif(Record.VendorID= "" ,Convert.DBNull, Record.VendorID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PurchaseType",SqlDbType.NVarChar,51, Iif(Record.PurchaseType= "" ,Convert.DBNull, Record.PurchaseType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillStatusDate",SqlDbType.DateTime,21, Record.BillStatusDate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovedAmount",SqlDbType.Decimal,13, Iif(Record.ApprovedAmount= "" ,Convert.DBNull, Record.ApprovedAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LogisticLinked",SqlDbType.Bit,3, Record.LogisticLinked)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BillStatusUser",SqlDbType.NVarChar,9, Record.BillStatusUser)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Discount",SqlDbType.Decimal,21, Iif(Record.Discount= "" ,Convert.DBNull, Record.Discount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BasicValue",SqlDbType.Decimal,21, Iif(Record.BasicValue= "" ,Convert.DBNull, Record.BasicValue))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNLedger",SqlDbType.NVarChar,21, Iif(Record.BaaNLedger= "" ,Convert.DBNull, Record.BaaNLedger))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ServiceCharge",SqlDbType.Decimal,21, Iif(Record.ServiceCharge= "" ,Convert.DBNull, Record.ServiceCharge))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocNo",SqlDbType.NVarChar,11, Iif(Record.DocNo= "" ,Convert.DBNull, Record.DocNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BatchNo",SqlDbType.NVarChar,11, Iif(Record.BatchNo= "" ,Convert.DBNull, Record.BatchNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TaxRate",SqlDbType.Decimal,21, Iif(Record.TaxRate= "" ,Convert.DBNull, Record.TaxRate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BaaNCompany",SqlDbType.NVarChar,11, Iif(Record.BaaNCompany= "" ,Convert.DBNull, Record.BaaNCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DepartmentID",SqlDbType.NVarChar,7, Iif(Record.DepartmentID= "" ,Convert.DBNull, Record.DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeID",SqlDbType.NVarChar,9, Iif(Record.EmployeeID= "" ,Convert.DBNull, Record.EmployeeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ElementID",SqlDbType.NVarChar,9, Iif(Record.ElementID= "" ,Convert.DBNull, Record.ElementID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CostCenterID",SqlDbType.NVarChar,7, Iif(Record.CostCenterID= "" ,Convert.DBNull, Record.CostCenterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentLine",SqlDbType.NVarChar,51, Iif(Record.DocumentLine= "" ,Convert.DBNull, Record.DocumentLine))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentNo",SqlDbType.NVarChar,51, Iif(Record.DocumentNo= "" ,Convert.DBNull, Record.DocumentNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VoucherNo",SqlDbType.Int,11, Iif(Record.VoucherNo= "" ,Convert.DBNull, Record.VoucherNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierName", SqlDbType.NVarChar, 101, IIf(Record.SupplierName = "", Convert.DBNull, Record.SupplierName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTINNumber", SqlDbType.NVarChar, 51, IIf(Record.SupplierGSTINNumber = "", Convert.DBNull, Record.SupplierGSTINNumber))
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
    Public Shared Function spmtSupplierBillDelete(ByVal Record As SIS.SPMT.spmtSupplierBill) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillDelete"
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
    Public Shared Function SelectspmtSupplierBillAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtSupplierBillAutoCompleteList"
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
            Dim Tmp As SIS.SPMT.spmtSupplierBill = New SIS.SPMT.spmtSupplierBill(Reader)
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
