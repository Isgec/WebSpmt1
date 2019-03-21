Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()>
  Partial Public Class SPMTerpDCH
    Public Property DCType As String = ""
    Private Shared _RecordCount As Integer
    Private _ChallanDate As String = ""
    Private _ChallanID As String = ""
    Private _CreatedBy As String = ""
    Private _CreatedOn As String = ""
    Private _StatusID As String = ""
    Private _IssuerID As String = ""
    Private _IssuerCompanyName As String = ""
    Private _IssuerAddress1Line As String = ""
    Private _IssuerAddress2Line As String = ""
    Private _IssuerPAN As String = ""
    Private _IssuerCIN As String = ""
    Private _ProjectID As String = ""
    Private _UnitID As String = ""
    Private _PONo As String = ""
    Private _PlaceOfSupply As String = ""
    Private _PlaceOfDelivery As String = ""
    Private _ConsigneeIsgecID As String = ""
    Private _ConsigneeBPID As String = ""
    Private _ConsigneeGSTIN As String = ""
    Private _ConsigneeName As String = ""
    Private _ConsigneeGSTINNo As String = ""
    Private _ConsigneeAddress1Line As String = ""
    Private _ConsigneeAddress2Line As String = ""
    Private _ConsigneeAddress3Line As String = ""
    Private _ConsigneeStateID As String = ""
    Private _ConsignerIsgecID As String = ""
    Private _ConsignerBPID As String = ""
    Private _ConsignerGSTIN As String = ""
    Private _ConsignerName As String = ""
    Private _ConsignerGSTINNo As String = ""
    Private _ConsignerAddress1Line As String = ""
    Private _ConsignerAddress2Line As String = ""
    Private _ConsignerAddress3Line As String = ""
    Private _ConsignerStateID As String = ""
    Private _Purpose As String = ""
    Private _ExpectedReturnDate As String = ""
    Private _TotalAmount As String = "0.00"
    Private _TotalAmountInWords As String = ""
    Private _ModeOfTransportID As String = ""
    Private _VehicleNo As String = ""
    Private _GRNo As String = ""
    Private _GRDate As String = ""
    Private _TransporterID As String = ""
    Private _TransporterName As String = ""
    Private _FromPlace As String = ""
    Private _ToPlace As String = ""
    Private _Declaration1Line As String = ""
    Private _Declaration2Line As String = ""
    Private _Declaration3Line As String = ""
    Private _Declaration4Line As String = ""
    Private _LinkedChallanID As String = ""
    Private _DestinationIsgecID As String = ""
    Private _DestinationBPID As String = ""
    Private _DestinationGSTIN As String = ""
    Private _DestinationName As String = ""
    Private _DestinationGSTINNo As String = ""
    Private _DestinationAddress1Line As String = ""
    Private _DestinationAddress2Line As String = ""
    Private _DestinationAddress3Line As String = ""
    Private _DestinationStateID As String = ""
    Private _ReceivedDate As String = ""
    Private _ReceivedRemarks As String = ""
    Private _ReceivedOn As String = ""
    Private _ReceivedBy As String = ""
    Private _ClosureRemarks As String = ""
    Private _ClosureDate As String = ""
    Private _ClosedBy As String = ""
    Private _ClosedOn As String = ""
    Private _IsgecInvoiceNo As String = ""
    Private _IsgecInvoiceDate As String = ""
    Private _t_rcno As String = ""
    Private _t_srpo As String = ""
    Private _t_srpl As String = ""
    Private _aspnet_Users19_UserFullName As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _aspnet_Users18_UserFullName As String = ""
    Private _HRM_Companies2_Description As String = ""
    Private _IDM_Projects3_Description As String = ""
    Private _SPMT_DCStates4_Description As String = ""
    Private _SPMT_erpDCH20_PlaceOfDelivery As String = ""
    Private _SPMT_ERPStates6_Description As String = ""
    Private _SPMT_ERPStates5_Description As String = ""
    Private _SPMT_ERPStates7_Description As String = ""
    Private _SPMT_ERPStates21_Description As String = ""
    Private _SPMT_ERPStates8_Description As String = ""
    Private _SPMT_IsgecGSTIN10_Description As String = ""
    Private _SPMT_IsgecGSTIN11_Description As String = ""
    Private _SPMT_IsgecGSTIN9_Description As String = ""
    Private _SPMT_IsgecGSTIN22_Description As String = ""
    Private _SPMT_ModeOfTransport12_Description As String = ""
    Private _VR_BPGSTIN23_Description As String = ""
    Private _VR_BPGSTIN14_Description As String = ""
    Private _VR_BPGSTIN13_Description As String = ""
    Private _VR_BusinessPartner24_BPName As String = ""
    Private _VR_BusinessPartner17_BPName As String = ""
    Private _VR_BusinessPartner15_BPName As String = ""
    Private _VR_BusinessPartner16_BPName As String = ""
    Private _FK_SPMT_erpDCH_ClosedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_erpDCH_CreatedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_erpDCH_ReceivedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_erpDCH_UnitID As SIS.COM.comCompanies = Nothing
    Private _FK_SPMT_erpDCH_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_erpDCH_StatusID As SIS.SPMT.spmtDCStates = Nothing
    Private _FK_SPMT_erpDCH_LinkedChallanID As SIS.SPMT.SPMTerpDCH = Nothing
    Private _FK_SPMT_erpDCH_PlaceOfDelivery As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_erpDCH_PlaceOfSupply As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_erpDCH_consignerStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_erpDCH_DestinationStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_erpDCH_ConsigneeStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_erpDCH_CongigneeIsgecID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_erpDCH_IssuerID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_erpDCH_ConsignerIsgecID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_erpDCH_DestinationIsgecID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_erpDCH_ModeOfTransportID As SIS.SPMT.spmtModeOfTransport = Nothing
    Private _FK_SPMT_erpDCH_DestinationGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_erpDCH_ConsigneeGISTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_erpDCH_ConsignerGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_erpDCH_DestinationBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_erpDCH_ConsigneeBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_erpDCH_ConsignerBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_erpDCH_TransporterID As SIS.SPMT.spmtBusinessPartner = Nothing
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
    Public Property ChallanDate() As String
      Get
        If Not _ChallanDate = String.Empty Then
          Return Convert.ToDateTime(_ChallanDate).ToString("dd/MM/yyyy")
        End If
        Return _ChallanDate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ChallanDate = ""
        Else
          _ChallanDate = value
        End If
      End Set
    End Property
    Public Property ChallanID() As String
      Get
        Return _ChallanID
      End Get
      Set(ByVal value As String)
        _ChallanID = value
      End Set
    End Property
    Public Property CreatedBy() As String
      Get
        Return _CreatedBy
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
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
        If Convert.IsDBNull(value) Then
          _CreatedOn = ""
        Else
          _CreatedOn = value
        End If
      End Set
    End Property
    Public Property StatusID() As String
      Get
        Return _StatusID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _StatusID = ""
        Else
          _StatusID = value
        End If
      End Set
    End Property
    Public Property IssuerID() As String
      Get
        Return _IssuerID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuerID = ""
        Else
          _IssuerID = value
        End If
      End Set
    End Property
    Public Property IssuerCompanyName() As String
      Get
        Return _IssuerCompanyName
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuerCompanyName = ""
        Else
          _IssuerCompanyName = value
        End If
      End Set
    End Property
    Public Property IssuerAddress1Line() As String
      Get
        Return _IssuerAddress1Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuerAddress1Line = ""
        Else
          _IssuerAddress1Line = value
        End If
      End Set
    End Property
    Public Property IssuerAddress2Line() As String
      Get
        Return _IssuerAddress2Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuerAddress2Line = ""
        Else
          _IssuerAddress2Line = value
        End If
      End Set
    End Property
    Public Property IssuerPAN() As String
      Get
        Return _IssuerPAN
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuerPAN = ""
        Else
          _IssuerPAN = value
        End If
      End Set
    End Property
    Public Property IssuerCIN() As String
      Get
        Return _IssuerCIN
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IssuerCIN = ""
        Else
          _IssuerCIN = value
        End If
      End Set
    End Property
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
    Public Property UnitID() As String
      Get
        Return _UnitID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _UnitID = ""
        Else
          _UnitID = value
        End If
      End Set
    End Property
    Public Property PONo() As String
      Get
        Return _PONo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PONo = ""
        Else
          _PONo = value
        End If
      End Set
    End Property
    Public Property PlaceOfSupply() As String
      Get
        Return _PlaceOfSupply
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PlaceOfSupply = ""
        Else
          _PlaceOfSupply = value
        End If
      End Set
    End Property
    Public Property PlaceOfDelivery() As String
      Get
        Return _PlaceOfDelivery
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _PlaceOfDelivery = ""
        Else
          _PlaceOfDelivery = value
        End If
      End Set
    End Property
    Public Property ConsigneeIsgecID() As String
      Get
        Return _ConsigneeIsgecID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeIsgecID = ""
        Else
          _ConsigneeIsgecID = value
        End If
      End Set
    End Property
    Public Property ConsigneeBPID() As String
      Get
        Return _ConsigneeBPID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeBPID = ""
        Else
          _ConsigneeBPID = value
        End If
      End Set
    End Property
    Public Property ConsigneeGSTIN() As String
      Get
        Return _ConsigneeGSTIN
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeGSTIN = ""
        Else
          _ConsigneeGSTIN = value
        End If
      End Set
    End Property
    Public Property ConsigneeName() As String
      Get
        Return _ConsigneeName
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeName = ""
        Else
          _ConsigneeName = value
        End If
      End Set
    End Property
    Public Property ConsigneeGSTINNo() As String
      Get
        Return _ConsigneeGSTINNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeGSTINNo = ""
        Else
          _ConsigneeGSTINNo = value
        End If
      End Set
    End Property
    Public Property ConsigneeAddress1Line() As String
      Get
        Return _ConsigneeAddress1Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeAddress1Line = ""
        Else
          _ConsigneeAddress1Line = value
        End If
      End Set
    End Property
    Public Property ConsigneeAddress2Line() As String
      Get
        Return _ConsigneeAddress2Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeAddress2Line = ""
        Else
          _ConsigneeAddress2Line = value
        End If
      End Set
    End Property
    Public Property ConsigneeAddress3Line() As String
      Get
        Return _ConsigneeAddress3Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeAddress3Line = ""
        Else
          _ConsigneeAddress3Line = value
        End If
      End Set
    End Property
    Public Property ConsigneeStateID() As String
      Get
        Return _ConsigneeStateID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsigneeStateID = ""
        Else
          _ConsigneeStateID = value
        End If
      End Set
    End Property
    Public Property ConsignerIsgecID() As String
      Get
        Return _ConsignerIsgecID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
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
        If Convert.IsDBNull(value) Then
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
        If Convert.IsDBNull(value) Then
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
        If Convert.IsDBNull(value) Then
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
        If Convert.IsDBNull(value) Then
          _ConsignerGSTINNo = ""
        Else
          _ConsignerGSTINNo = value
        End If
      End Set
    End Property
    Public Property ConsignerAddress1Line() As String
      Get
        Return _ConsignerAddress1Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsignerAddress1Line = ""
        Else
          _ConsignerAddress1Line = value
        End If
      End Set
    End Property
    Public Property ConsignerAddress2Line() As String
      Get
        Return _ConsignerAddress2Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsignerAddress2Line = ""
        Else
          _ConsignerAddress2Line = value
        End If
      End Set
    End Property
    Public Property ConsignerAddress3Line() As String
      Get
        Return _ConsignerAddress3Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsignerAddress3Line = ""
        Else
          _ConsignerAddress3Line = value
        End If
      End Set
    End Property
    Public Property ConsignerStateID() As String
      Get
        Return _ConsignerStateID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ConsignerStateID = ""
        Else
          _ConsignerStateID = value
        End If
      End Set
    End Property
    Public Property Purpose() As String
      Get
        Return _Purpose
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Purpose = ""
        Else
          _Purpose = value
        End If
      End Set
    End Property
    Public Property ExpectedReturnDate() As String
      Get
        If Not _ExpectedReturnDate = String.Empty Then
          Return Convert.ToDateTime(_ExpectedReturnDate).ToString("dd/MM/yyyy")
        End If
        Return _ExpectedReturnDate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ExpectedReturnDate = ""
        Else
          _ExpectedReturnDate = value
        End If
      End Set
    End Property
    Public Property TotalAmount() As String
      Get
        Return _TotalAmount
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _TotalAmount = "0.00"
        Else
          _TotalAmount = value
        End If
      End Set
    End Property
    Public Property TotalAmountInWords() As String
      Get
        Return _TotalAmountInWords
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _TotalAmountInWords = ""
        Else
          _TotalAmountInWords = value
        End If
      End Set
    End Property
    Public Property ModeOfTransportID() As String
      Get
        Return _ModeOfTransportID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ModeOfTransportID = ""
        Else
          _ModeOfTransportID = value
        End If
      End Set
    End Property
    Public Property VehicleNo() As String
      Get
        Return _VehicleNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _VehicleNo = ""
        Else
          _VehicleNo = value
        End If
      End Set
    End Property
    Public Property GRNo() As String
      Get
        Return _GRNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _GRNo = ""
        Else
          _GRNo = value
        End If
      End Set
    End Property
    Public Property GRDate() As String
      Get
        If Not _GRDate = String.Empty Then
          Return Convert.ToDateTime(_GRDate).ToString("dd/MM/yyyy")
        End If
        Return _GRDate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _GRDate = ""
        Else
          _GRDate = value
        End If
      End Set
    End Property
    Public Property TransporterID() As String
      Get
        Return _TransporterID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _TransporterID = ""
        Else
          _TransporterID = value
        End If
      End Set
    End Property
    Public Property TransporterName() As String
      Get
        Return _TransporterName
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _TransporterName = ""
        Else
          _TransporterName = value
        End If
      End Set
    End Property
    Public Property FromPlace() As String
      Get
        Return _FromPlace
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _FromPlace = ""
        Else
          _FromPlace = value
        End If
      End Set
    End Property
    Public Property ToPlace() As String
      Get
        Return _ToPlace
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ToPlace = ""
        Else
          _ToPlace = value
        End If
      End Set
    End Property
    Public Property Declaration1Line() As String
      Get
        Return _Declaration1Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Declaration1Line = ""
        Else
          _Declaration1Line = value
        End If
      End Set
    End Property
    Public Property Declaration2Line() As String
      Get
        Return _Declaration2Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Declaration2Line = ""
        Else
          _Declaration2Line = value
        End If
      End Set
    End Property
    Public Property Declaration3Line() As String
      Get
        Return _Declaration3Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Declaration3Line = ""
        Else
          _Declaration3Line = value
        End If
      End Set
    End Property
    Public Property Declaration4Line() As String
      Get
        Return _Declaration4Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Declaration4Line = ""
        Else
          _Declaration4Line = value
        End If
      End Set
    End Property
    Public Property LinkedChallanID() As String
      Get
        Return _LinkedChallanID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _LinkedChallanID = ""
        Else
          _LinkedChallanID = value
        End If
      End Set
    End Property
    Public Property DestinationIsgecID() As String
      Get
        Return _DestinationIsgecID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationIsgecID = ""
        Else
          _DestinationIsgecID = value
        End If
      End Set
    End Property
    Public Property DestinationBPID() As String
      Get
        Return _DestinationBPID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationBPID = ""
        Else
          _DestinationBPID = value
        End If
      End Set
    End Property
    Public Property DestinationGSTIN() As String
      Get
        Return _DestinationGSTIN
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationGSTIN = ""
        Else
          _DestinationGSTIN = value
        End If
      End Set
    End Property
    Public Property DestinationName() As String
      Get
        Return _DestinationName
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationName = ""
        Else
          _DestinationName = value
        End If
      End Set
    End Property
    Public Property DestinationGSTINNo() As String
      Get
        Return _DestinationGSTINNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationGSTINNo = ""
        Else
          _DestinationGSTINNo = value
        End If
      End Set
    End Property
    Public Property DestinationAddress1Line() As String
      Get
        Return _DestinationAddress1Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationAddress1Line = ""
        Else
          _DestinationAddress1Line = value
        End If
      End Set
    End Property
    Public Property DestinationAddress2Line() As String
      Get
        Return _DestinationAddress2Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationAddress2Line = ""
        Else
          _DestinationAddress2Line = value
        End If
      End Set
    End Property
    Public Property DestinationAddress3Line() As String
      Get
        Return _DestinationAddress3Line
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationAddress3Line = ""
        Else
          _DestinationAddress3Line = value
        End If
      End Set
    End Property
    Public Property DestinationStateID() As String
      Get
        Return _DestinationStateID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _DestinationStateID = ""
        Else
          _DestinationStateID = value
        End If
      End Set
    End Property
    Public Property ReceivedDate() As String
      Get
        If Not _ReceivedDate = String.Empty Then
          Return Convert.ToDateTime(_ReceivedDate).ToString("dd/MM/yyyy")
        End If
        Return _ReceivedDate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ReceivedDate = ""
        Else
          _ReceivedDate = value
        End If
      End Set
    End Property
    Public Property ReceivedRemarks() As String
      Get
        Return _ReceivedRemarks
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ReceivedRemarks = ""
        Else
          _ReceivedRemarks = value
        End If
      End Set
    End Property
    Public Property ReceivedOn() As String
      Get
        If Not _ReceivedOn = String.Empty Then
          Return Convert.ToDateTime(_ReceivedOn).ToString("dd/MM/yyyy")
        End If
        Return _ReceivedOn
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ReceivedOn = ""
        Else
          _ReceivedOn = value
        End If
      End Set
    End Property
    Public Property ReceivedBy() As String
      Get
        Return _ReceivedBy
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ReceivedBy = ""
        Else
          _ReceivedBy = value
        End If
      End Set
    End Property
    Public Property ClosureRemarks() As String
      Get
        Return _ClosureRemarks
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ClosureRemarks = ""
        Else
          _ClosureRemarks = value
        End If
      End Set
    End Property
    Public Property ClosureDate() As String
      Get
        If Not _ClosureDate = String.Empty Then
          Return Convert.ToDateTime(_ClosureDate).ToString("dd/MM/yyyy")
        End If
        Return _ClosureDate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ClosureDate = ""
        Else
          _ClosureDate = value
        End If
      End Set
    End Property
    Public Property ClosedBy() As String
      Get
        Return _ClosedBy
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ClosedBy = ""
        Else
          _ClosedBy = value
        End If
      End Set
    End Property
    Public Property ClosedOn() As String
      Get
        If Not _ClosedOn = String.Empty Then
          Return Convert.ToDateTime(_ClosedOn).ToString("dd/MM/yyyy")
        End If
        Return _ClosedOn
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ClosedOn = ""
        Else
          _ClosedOn = value
        End If
      End Set
    End Property
    Public Property IsgecInvoiceNo() As String
      Get
        Return _IsgecInvoiceNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IsgecInvoiceNo = ""
        Else
          _IsgecInvoiceNo = value
        End If
      End Set
    End Property
    Public Property IsgecInvoiceDate() As String
      Get
        If Not _IsgecInvoiceDate = String.Empty Then
          Return Convert.ToDateTime(_IsgecInvoiceDate).ToString("dd/MM/yyyy")
        End If
        Return _IsgecInvoiceDate
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _IsgecInvoiceDate = ""
        Else
          _IsgecInvoiceDate = value
        End If
      End Set
    End Property
    Public Property t_rcno() As String
      Get
        Return _t_rcno
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _t_rcno = ""
        Else
          _t_rcno = value
        End If
      End Set
    End Property
    Public Property t_srpo() As String
      Get
        Return _t_srpo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _t_srpo = ""
        Else
          _t_srpo = value
        End If
      End Set
    End Property
    Public Property t_srpl() As String
      Get
        Return _t_srpl
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _t_srpl = ""
        Else
          _t_srpl = value
        End If
      End Set
    End Property
    Public Property aspnet_Users19_UserFullName() As String
      Get
        Return _aspnet_Users19_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users19_UserFullName = value
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
    Public Property aspnet_Users18_UserFullName() As String
      Get
        Return _aspnet_Users18_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users18_UserFullName = value
      End Set
    End Property
    Public Property HRM_Companies2_Description() As String
      Get
        Return _HRM_Companies2_Description
      End Get
      Set(ByVal value As String)
        _HRM_Companies2_Description = value
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
    Public Property SPMT_DCStates4_Description() As String
      Get
        Return _SPMT_DCStates4_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_DCStates4_Description = ""
        Else
          _SPMT_DCStates4_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_erpDCH20_PlaceOfDelivery() As String
      Get
        Return _SPMT_erpDCH20_PlaceOfDelivery
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_erpDCH20_PlaceOfDelivery = ""
        Else
          _SPMT_erpDCH20_PlaceOfDelivery = value
        End If
      End Set
    End Property
    Public Property SPMT_ERPStates6_Description() As String
      Get
        Return _SPMT_ERPStates6_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_ERPStates6_Description = ""
        Else
          _SPMT_ERPStates6_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_ERPStates5_Description() As String
      Get
        Return _SPMT_ERPStates5_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_ERPStates5_Description = ""
        Else
          _SPMT_ERPStates5_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_ERPStates7_Description() As String
      Get
        Return _SPMT_ERPStates7_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_ERPStates7_Description = ""
        Else
          _SPMT_ERPStates7_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_ERPStates21_Description() As String
      Get
        Return _SPMT_ERPStates21_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_ERPStates21_Description = ""
        Else
          _SPMT_ERPStates21_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_ERPStates8_Description() As String
      Get
        Return _SPMT_ERPStates8_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_ERPStates8_Description = ""
        Else
          _SPMT_ERPStates8_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN10_Description() As String
      Get
        Return _SPMT_IsgecGSTIN10_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_IsgecGSTIN10_Description = ""
        Else
          _SPMT_IsgecGSTIN10_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN11_Description() As String
      Get
        Return _SPMT_IsgecGSTIN11_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_IsgecGSTIN11_Description = ""
        Else
          _SPMT_IsgecGSTIN11_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN9_Description() As String
      Get
        Return _SPMT_IsgecGSTIN9_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_IsgecGSTIN9_Description = ""
        Else
          _SPMT_IsgecGSTIN9_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN22_Description() As String
      Get
        Return _SPMT_IsgecGSTIN22_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_IsgecGSTIN22_Description = ""
        Else
          _SPMT_IsgecGSTIN22_Description = value
        End If
      End Set
    End Property
    Public Property SPMT_ModeOfTransport12_Description() As String
      Get
        Return _SPMT_ModeOfTransport12_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _SPMT_ModeOfTransport12_Description = ""
        Else
          _SPMT_ModeOfTransport12_Description = value
        End If
      End Set
    End Property
    Public Property VR_BPGSTIN23_Description() As String
      Get
        Return _VR_BPGSTIN23_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _VR_BPGSTIN23_Description = ""
        Else
          _VR_BPGSTIN23_Description = value
        End If
      End Set
    End Property
    Public Property VR_BPGSTIN14_Description() As String
      Get
        Return _VR_BPGSTIN14_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _VR_BPGSTIN14_Description = ""
        Else
          _VR_BPGSTIN14_Description = value
        End If
      End Set
    End Property
    Public Property VR_BPGSTIN13_Description() As String
      Get
        Return _VR_BPGSTIN13_Description
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _VR_BPGSTIN13_Description = ""
        Else
          _VR_BPGSTIN13_Description = value
        End If
      End Set
    End Property
    Public Property VR_BusinessPartner24_BPName() As String
      Get
        Return _VR_BusinessPartner24_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner24_BPName = value
      End Set
    End Property
    Public Property VR_BusinessPartner17_BPName() As String
      Get
        Return _VR_BusinessPartner17_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner17_BPName = value
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
    Public ReadOnly Property DisplayField() As String
      Get
        Return "" & _PlaceOfDelivery.ToString.PadRight(2, " ")
      End Get
    End Property
    Public ReadOnly Property PrimaryKey() As String
      Get
        Return _ChallanID
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
    Public Class PKSPMTerpDCH
      Private _ChallanID As String = ""
      Public Property ChallanID() As String
        Get
          Return _ChallanID
        End Get
        Set(ByVal value As String)
          _ChallanID = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_SPMT_erpDCH_ClosedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_erpDCH_ClosedBy Is Nothing Then
          _FK_SPMT_erpDCH_ClosedBy = SIS.COM.comUsers.comUsersGetByID(_ClosedBy)
        End If
        Return _FK_SPMT_erpDCH_ClosedBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_CreatedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_erpDCH_CreatedBy Is Nothing Then
          _FK_SPMT_erpDCH_CreatedBy = SIS.COM.comUsers.comUsersGetByID(_CreatedBy)
        End If
        Return _FK_SPMT_erpDCH_CreatedBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ReceivedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_erpDCH_ReceivedBy Is Nothing Then
          _FK_SPMT_erpDCH_ReceivedBy = SIS.COM.comUsers.comUsersGetByID(_ReceivedBy)
        End If
        Return _FK_SPMT_erpDCH_ReceivedBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_UnitID() As SIS.COM.comCompanies
      Get
        If _FK_SPMT_erpDCH_UnitID Is Nothing Then
          _FK_SPMT_erpDCH_UnitID = SIS.COM.comCompanies.comCompaniesGetByID(_UnitID)
        End If
        Return _FK_SPMT_erpDCH_UnitID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_erpDCH_ProjectID Is Nothing Then
          _FK_SPMT_erpDCH_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_erpDCH_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_StatusID() As SIS.SPMT.spmtDCStates
      Get
        If _FK_SPMT_erpDCH_StatusID Is Nothing Then
          _FK_SPMT_erpDCH_StatusID = SIS.SPMT.spmtDCStates.spmtDCStatesGetByID(_StatusID)
        End If
        Return _FK_SPMT_erpDCH_StatusID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_LinkedChallanID() As SIS.SPMT.SPMTerpDCH
      Get
        If _FK_SPMT_erpDCH_LinkedChallanID Is Nothing Then
          _FK_SPMT_erpDCH_LinkedChallanID = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(_LinkedChallanID)
        End If
        Return _FK_SPMT_erpDCH_LinkedChallanID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_PlaceOfDelivery() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_erpDCH_PlaceOfDelivery Is Nothing Then
          _FK_SPMT_erpDCH_PlaceOfDelivery = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_PlaceOfDelivery)
        End If
        Return _FK_SPMT_erpDCH_PlaceOfDelivery
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_PlaceOfSupply() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_erpDCH_PlaceOfSupply Is Nothing Then
          _FK_SPMT_erpDCH_PlaceOfSupply = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_PlaceOfSupply)
        End If
        Return _FK_SPMT_erpDCH_PlaceOfSupply
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_consignerStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_erpDCH_consignerStateID Is Nothing Then
          _FK_SPMT_erpDCH_consignerStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ConsignerStateID)
        End If
        Return _FK_SPMT_erpDCH_consignerStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_DestinationStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_erpDCH_DestinationStateID Is Nothing Then
          _FK_SPMT_erpDCH_DestinationStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_DestinationStateID)
        End If
        Return _FK_SPMT_erpDCH_DestinationStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ConsigneeStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_erpDCH_ConsigneeStateID Is Nothing Then
          _FK_SPMT_erpDCH_ConsigneeStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ConsigneeStateID)
        End If
        Return _FK_SPMT_erpDCH_ConsigneeStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_CongigneeIsgecID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_erpDCH_CongigneeIsgecID Is Nothing Then
          _FK_SPMT_erpDCH_CongigneeIsgecID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_ConsigneeIsgecID)
        End If
        Return _FK_SPMT_erpDCH_CongigneeIsgecID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_IssuerID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_erpDCH_IssuerID Is Nothing Then
          _FK_SPMT_erpDCH_IssuerID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_IssuerID)
        End If
        Return _FK_SPMT_erpDCH_IssuerID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ConsignerIsgecID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_erpDCH_ConsignerIsgecID Is Nothing Then
          _FK_SPMT_erpDCH_ConsignerIsgecID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_ConsignerIsgecID)
        End If
        Return _FK_SPMT_erpDCH_ConsignerIsgecID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_DestinationIsgecID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_erpDCH_DestinationIsgecID Is Nothing Then
          _FK_SPMT_erpDCH_DestinationIsgecID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_DestinationIsgecID)
        End If
        Return _FK_SPMT_erpDCH_DestinationIsgecID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ModeOfTransportID() As SIS.SPMT.spmtModeOfTransport
      Get
        If _FK_SPMT_erpDCH_ModeOfTransportID Is Nothing Then
          _FK_SPMT_erpDCH_ModeOfTransportID = SIS.SPMT.spmtModeOfTransport.spmtModeOfTransportGetByID(_ModeOfTransportID)
        End If
        Return _FK_SPMT_erpDCH_ModeOfTransportID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_DestinationGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_erpDCH_DestinationGSTIN Is Nothing Then
          _FK_SPMT_erpDCH_DestinationGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_DestinationBPID, _DestinationGSTIN)
        End If
        Return _FK_SPMT_erpDCH_DestinationGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ConsigneeGISTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_erpDCH_ConsigneeGISTIN Is Nothing Then
          _FK_SPMT_erpDCH_ConsigneeGISTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_ConsigneeBPID, _ConsigneeGSTIN)
        End If
        Return _FK_SPMT_erpDCH_ConsigneeGISTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ConsignerGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_erpDCH_ConsignerGSTIN Is Nothing Then
          _FK_SPMT_erpDCH_ConsignerGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_ConsignerBPID, _ConsignerGSTIN)
        End If
        Return _FK_SPMT_erpDCH_ConsignerGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_DestinationBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_erpDCH_DestinationBPID Is Nothing Then
          _FK_SPMT_erpDCH_DestinationBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_DestinationBPID)
        End If
        Return _FK_SPMT_erpDCH_DestinationBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ConsigneeBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_erpDCH_ConsigneeBPID Is Nothing Then
          _FK_SPMT_erpDCH_ConsigneeBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_ConsigneeBPID)
        End If
        Return _FK_SPMT_erpDCH_ConsigneeBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_ConsignerBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_erpDCH_ConsignerBPID Is Nothing Then
          _FK_SPMT_erpDCH_ConsignerBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_ConsignerBPID)
        End If
        Return _FK_SPMT_erpDCH_ConsignerBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_erpDCH_TransporterID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_erpDCH_TransporterID Is Nothing Then
          _FK_SPMT_erpDCH_TransporterID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_TransporterID)
        End If
        Return _FK_SPMT_erpDCH_TransporterID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function SPMTerpDCHSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.SPMTerpDCH)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "ChallanID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCHSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCH)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCH(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function SPMTerpDCHGetNewRecord() As SIS.SPMT.SPMTerpDCH
      Return New SIS.SPMT.SPMTerpDCH()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function SPMTerpDCHGetByID(ByVal ChallanID As String) As SIS.SPMT.SPMTerpDCH
      Dim Results As SIS.SPMT.SPMTerpDCH = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCHSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID", SqlDbType.NVarChar, ChallanID.ToString.Length, ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.SPMTerpDCH(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function SPMTerpDCHSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.SPMTerpDCH)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "ChallanID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spSPMTerpDCHSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spSPMTerpDCHSelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.SPMTerpDCH)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.SPMTerpDCH(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SPMTerpDCHSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)>
    Public Shared Function SPMTerpDCHInsert(ByVal Record As SIS.SPMT.SPMTerpDCH) As SIS.SPMT.SPMTerpDCH
      Dim _Rec As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetNewRecord()
      With _Rec
        .ChallanDate = Record.ChallanDate
        .ChallanID = Record.ChallanID
        .ClosedBy = Record.ClosedBy
        .ClosedOn = Record.ClosedOn
        .ClosureDate = Record.ClosureDate
        .ClosureRemarks = Record.ClosureRemarks
        .ConsigneeAddress1Line = Record.ConsigneeAddress1Line
        .ConsigneeAddress2Line = Record.ConsigneeAddress2Line
        .ConsigneeAddress3Line = Record.ConsigneeAddress3Line
        .ConsigneeBPID = Record.ConsigneeBPID
        .ConsigneeGSTIN = Record.ConsigneeGSTIN
        .ConsigneeGSTINNo = Record.ConsigneeGSTINNo
        .ConsigneeIsgecID = Record.ConsigneeIsgecID
        .ConsigneeName = Record.ConsigneeName
        .ConsigneeStateID = Record.ConsigneeStateID
        .ConsignerAddress1Line = Record.ConsignerAddress1Line
        .ConsignerAddress2Line = Record.ConsignerAddress2Line
        .ConsignerAddress3Line = Record.ConsignerAddress3Line
        .ConsignerBPID = Record.ConsignerBPID
        .ConsignerGSTIN = Record.ConsignerGSTIN
        .ConsignerGSTINNo = Record.ConsignerGSTINNo
        .ConsignerIsgecID = Record.ConsignerIsgecID
        .ConsignerName = Record.ConsignerName
        .ConsignerStateID = Record.ConsignerStateID
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
        .Declaration1Line = Record.Declaration1Line
        .Declaration2Line = Record.Declaration2Line
        .Declaration3Line = Record.Declaration3Line
        .Declaration4Line = Record.Declaration4Line
        .DestinationAddress1Line = Record.DestinationAddress1Line
        .DestinationAddress2Line = Record.DestinationAddress2Line
        .DestinationAddress3Line = Record.DestinationAddress3Line
        .DestinationBPID = Record.DestinationBPID
        .DestinationGSTIN = Record.DestinationGSTIN
        .DestinationGSTINNo = Record.DestinationGSTINNo
        .DestinationIsgecID = Record.DestinationIsgecID
        .DestinationName = Record.DestinationName
        .DestinationStateID = Record.DestinationStateID
        .ExpectedReturnDate = Record.ExpectedReturnDate
        .FromPlace = Record.FromPlace
        .GRDate = Record.GRDate
        .GRNo = Record.GRNo
        .IsgecInvoiceDate = Record.IsgecInvoiceDate
        .IsgecInvoiceNo = Record.IsgecInvoiceNo
        .IssuerAddress1Line = Record.IssuerAddress1Line
        .IssuerAddress2Line = Record.IssuerAddress2Line
        .IssuerCIN = Record.IssuerCIN
        .IssuerCompanyName = Record.IssuerCompanyName
        .IssuerID = Record.IssuerID
        .IssuerPAN = Record.IssuerPAN
        .LinkedChallanID = Record.LinkedChallanID
        .ModeOfTransportID = Record.ModeOfTransportID
        .PlaceOfDelivery = Record.PlaceOfDelivery
        .PlaceOfSupply = Record.PlaceOfSupply
        .PONo = Record.PONo
        .ProjectID = Record.ProjectID
        .Purpose = Record.Purpose
        .ReceivedBy = Record.ReceivedBy
        .ReceivedDate = Record.ReceivedDate
        .ReceivedOn = Record.ReceivedOn
        .ReceivedRemarks = Record.ReceivedRemarks
        .StatusID = 1
        .t_rcno = Record.t_rcno
        .t_srpl = Record.t_srpl
        .t_srpo = Record.t_srpo
        .ToPlace = Record.ToPlace
        .TotalAmount = Record.TotalAmount
        .TransporterID = Record.TransporterID
        .TransporterName = Record.TransporterName
        .UnitID = Record.UnitID
        .VehicleNo = Record.VehicleNo
        .DCType = Record.DCType
      End With
      Return SIS.SPMT.SPMTerpDCH.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.SPMTerpDCH) As SIS.SPMT.SPMTerpDCH
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCHInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanDate", SqlDbType.DateTime, 21, IIf(Record.ChallanDate = "", Convert.DBNull, Record.ChallanDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID", SqlDbType.NVarChar, 21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy", SqlDbType.NVarChar, 9, IIf(Record.CreatedBy = "", Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn", SqlDbType.DateTime, 21, IIf(Record.CreatedOn = "", Convert.DBNull, Record.CreatedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID", SqlDbType.Int, 11, IIf(Record.StatusID = "", Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerID", SqlDbType.Int, 11, IIf(Record.IssuerID = "", Convert.DBNull, Record.IssuerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCompanyName", SqlDbType.NVarChar, 51, IIf(Record.IssuerCompanyName = "", Convert.DBNull, Record.IssuerCompanyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress1Line", SqlDbType.NVarChar, 201, IIf(Record.IssuerAddress1Line = "", Convert.DBNull, Record.IssuerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress2Line", SqlDbType.NVarChar, 201, IIf(Record.IssuerAddress2Line = "", Convert.DBNull, Record.IssuerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerPAN", SqlDbType.NVarChar, 51, IIf(Record.IssuerPAN = "", Convert.DBNull, Record.IssuerPAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCIN", SqlDbType.NVarChar, 51, IIf(Record.IssuerCIN = "", Convert.DBNull, Record.IssuerCIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID", SqlDbType.NVarChar, 7, IIf(Record.ProjectID = "", Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UnitID", SqlDbType.NVarChar, 7, IIf(Record.UnitID = "", Convert.DBNull, Record.UnitID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONo", SqlDbType.NVarChar, 10, IIf(Record.PONo = "", Convert.DBNull, Record.PONo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfSupply", SqlDbType.NVarChar, 3, IIf(Record.PlaceOfSupply = "", Convert.DBNull, Record.PlaceOfSupply))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfDelivery", SqlDbType.NVarChar, 3, IIf(Record.PlaceOfDelivery = "", Convert.DBNull, Record.PlaceOfDelivery))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeIsgecID", SqlDbType.Int, 11, IIf(Record.ConsigneeIsgecID = "", Convert.DBNull, Record.ConsigneeIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeBPID", SqlDbType.NVarChar, 10, IIf(Record.ConsigneeBPID = "", Convert.DBNull, Record.ConsigneeBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTIN", SqlDbType.Int, 11, IIf(Record.ConsigneeGSTIN = "", Convert.DBNull, Record.ConsigneeGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeName", SqlDbType.NVarChar, 51, IIf(Record.ConsigneeName = "", Convert.DBNull, Record.ConsigneeName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTINNo", SqlDbType.NVarChar, 51, IIf(Record.ConsigneeGSTINNo = "", Convert.DBNull, Record.ConsigneeGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress1Line", SqlDbType.NVarChar, 101, IIf(Record.ConsigneeAddress1Line = "", Convert.DBNull, Record.ConsigneeAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress2Line", SqlDbType.NVarChar, 101, IIf(Record.ConsigneeAddress2Line = "", Convert.DBNull, Record.ConsigneeAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress3Line", SqlDbType.NVarChar, 101, IIf(Record.ConsigneeAddress3Line = "", Convert.DBNull, Record.ConsigneeAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeStateID", SqlDbType.NVarChar, 3, IIf(Record.ConsigneeStateID = "", Convert.DBNull, Record.ConsigneeStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerIsgecID", SqlDbType.Int, 11, IIf(Record.ConsignerIsgecID = "", Convert.DBNull, Record.ConsignerIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerBPID", SqlDbType.NVarChar, 10, IIf(Record.ConsignerBPID = "", Convert.DBNull, Record.ConsignerBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTIN", SqlDbType.Int, 11, IIf(Record.ConsignerGSTIN = "", Convert.DBNull, Record.ConsignerGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerName", SqlDbType.NVarChar, 51, IIf(Record.ConsignerName = "", Convert.DBNull, Record.ConsignerName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTINNo", SqlDbType.NVarChar, 51, IIf(Record.ConsignerGSTINNo = "", Convert.DBNull, Record.ConsignerGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress1Line", SqlDbType.NVarChar, 101, IIf(Record.ConsignerAddress1Line = "", Convert.DBNull, Record.ConsignerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress2Line", SqlDbType.NVarChar, 101, IIf(Record.ConsignerAddress2Line = "", Convert.DBNull, Record.ConsignerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress3Line", SqlDbType.NVarChar, 101, IIf(Record.ConsignerAddress3Line = "", Convert.DBNull, Record.ConsignerAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerStateID", SqlDbType.NVarChar, 3, IIf(Record.ConsignerStateID = "", Convert.DBNull, Record.ConsignerStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Purpose", SqlDbType.NVarChar, 251, IIf(Record.Purpose = "", Convert.DBNull, Record.Purpose))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ExpectedReturnDate", SqlDbType.DateTime, 21, IIf(Record.ExpectedReturnDate = "", Convert.DBNull, Record.ExpectedReturnDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount", SqlDbType.Decimal, 21, IIf(Record.TotalAmount = "", Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountInWords", SqlDbType.NVarChar, 501, IIf(Record.TotalAmountInWords = "", Convert.DBNull, Record.TotalAmountInWords))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModeOfTransportID", SqlDbType.Int, 11, IIf(Record.ModeOfTransportID = "", Convert.DBNull, Record.ModeOfTransportID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleNo", SqlDbType.NVarChar, 51, IIf(Record.VehicleNo = "", Convert.DBNull, Record.VehicleNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRNo", SqlDbType.NVarChar, 51, IIf(Record.GRNo = "", Convert.DBNull, Record.GRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRDate", SqlDbType.DateTime, 21, IIf(Record.GRDate = "", Convert.DBNull, Record.GRDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterID", SqlDbType.NVarChar, 10, IIf(Record.TransporterID = "", Convert.DBNull, Record.TransporterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterName", SqlDbType.NVarChar, 51, IIf(Record.TransporterName = "", Convert.DBNull, Record.TransporterName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FromPlace", SqlDbType.NVarChar, 51, IIf(Record.FromPlace = "", Convert.DBNull, Record.FromPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToPlace", SqlDbType.NVarChar, 51, IIf(Record.ToPlace = "", Convert.DBNull, Record.ToPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration1Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration1Line = "", Convert.DBNull, Record.Declaration1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration2Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration2Line = "", Convert.DBNull, Record.Declaration2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration3Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration3Line = "", Convert.DBNull, Record.Declaration3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration4Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration4Line = "", Convert.DBNull, Record.Declaration4Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LinkedChallanID", SqlDbType.NVarChar, 21, IIf(Record.LinkedChallanID = "", Convert.DBNull, Record.LinkedChallanID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationIsgecID", SqlDbType.Int, 11, IIf(Record.DestinationIsgecID = "", Convert.DBNull, Record.DestinationIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationBPID", SqlDbType.NVarChar, 10, IIf(Record.DestinationBPID = "", Convert.DBNull, Record.DestinationBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationGSTIN", SqlDbType.Int, 11, IIf(Record.DestinationGSTIN = "", Convert.DBNull, Record.DestinationGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationName", SqlDbType.NVarChar, 51, IIf(Record.DestinationName = "", Convert.DBNull, Record.DestinationName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationGSTINNo", SqlDbType.NVarChar, 51, IIf(Record.DestinationGSTINNo = "", Convert.DBNull, Record.DestinationGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationAddress1Line", SqlDbType.NVarChar, 101, IIf(Record.DestinationAddress1Line = "", Convert.DBNull, Record.DestinationAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationAddress2Line", SqlDbType.NVarChar, 101, IIf(Record.DestinationAddress2Line = "", Convert.DBNull, Record.DestinationAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationAddress3Line", SqlDbType.NVarChar, 101, IIf(Record.DestinationAddress3Line = "", Convert.DBNull, Record.DestinationAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationStateID", SqlDbType.NVarChar, 3, IIf(Record.DestinationStateID = "", Convert.DBNull, Record.DestinationStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedDate", SqlDbType.DateTime, 21, IIf(Record.ReceivedDate = "", Convert.DBNull, Record.ReceivedDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedRemarks", SqlDbType.NVarChar, 501, IIf(Record.ReceivedRemarks = "", Convert.DBNull, Record.ReceivedRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedOn", SqlDbType.DateTime, 21, IIf(Record.ReceivedOn = "", Convert.DBNull, Record.ReceivedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedBy", SqlDbType.NVarChar, 9, IIf(Record.ReceivedBy = "", Convert.DBNull, Record.ReceivedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosureRemarks", SqlDbType.NVarChar, 501, IIf(Record.ClosureRemarks = "", Convert.DBNull, Record.ClosureRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosureDate", SqlDbType.DateTime, 21, IIf(Record.ClosureDate = "", Convert.DBNull, Record.ClosureDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosedBy", SqlDbType.NVarChar, 9, IIf(Record.ClosedBy = "", Convert.DBNull, Record.ClosedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosedOn", SqlDbType.DateTime, 21, IIf(Record.ClosedOn = "", Convert.DBNull, Record.ClosedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecInvoiceNo", SqlDbType.NVarChar, 51, IIf(Record.IsgecInvoiceNo = "", Convert.DBNull, Record.IsgecInvoiceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecInvoiceDate", SqlDbType.DateTime, 21, IIf(Record.IsgecInvoiceDate = "", Convert.DBNull, Record.IsgecInvoiceDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rcno", SqlDbType.NVarChar, 10, IIf(Record.t_rcno = "", Convert.DBNull, Record.t_rcno))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srpo", SqlDbType.NVarChar, 10, IIf(Record.t_srpo = "", Convert.DBNull, Record.t_srpo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srpl", SqlDbType.Int, 11, IIf(Record.t_srpl = "", Convert.DBNull, Record.t_srpl))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DCType", SqlDbType.NVarChar, 11, Record.DCType)
          Cmd.Parameters.Add("@Return_ChallanID", SqlDbType.NVarChar, 21)
          Cmd.Parameters("@Return_ChallanID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.ChallanID = Cmd.Parameters("@Return_ChallanID").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function SPMTerpDCHUpdate(ByVal Record As SIS.SPMT.SPMTerpDCH) As SIS.SPMT.SPMTerpDCH
      Dim _Rec As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(Record.ChallanID)
      With _Rec
        .ChallanDate = Record.ChallanDate
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
        .IssuerID = Record.IssuerID
        .IssuerCompanyName = Record.IssuerCompanyName
        .IssuerAddress1Line = Record.IssuerAddress1Line
        .IssuerAddress2Line = Record.IssuerAddress2Line
        .IssuerPAN = Record.IssuerPAN
        .IssuerCIN = Record.IssuerCIN
        .ProjectID = Record.ProjectID
        .UnitID = Record.UnitID
        .PONo = Record.PONo
        .PlaceOfSupply = Record.PlaceOfSupply
        .PlaceOfDelivery = Record.PlaceOfDelivery
        .ConsigneeIsgecID = Record.ConsigneeIsgecID
        .ConsigneeBPID = Record.ConsigneeBPID
        .ConsigneeGSTIN = Record.ConsigneeGSTIN
        .ConsigneeName = Record.ConsigneeName
        .ConsigneeGSTINNo = Record.ConsigneeGSTINNo
        .ConsigneeAddress1Line = Record.ConsigneeAddress1Line
        .ConsigneeAddress2Line = Record.ConsigneeAddress2Line
        .ConsigneeAddress3Line = Record.ConsigneeAddress3Line
        .ConsigneeStateID = Record.ConsigneeStateID
        .ConsignerIsgecID = Record.ConsignerIsgecID
        .ConsignerBPID = Record.ConsignerBPID
        .ConsignerGSTIN = Record.ConsignerGSTIN
        .ConsignerName = Record.ConsignerName
        .ConsignerGSTINNo = Record.ConsignerGSTINNo
        .ConsignerAddress1Line = Record.ConsignerAddress1Line
        .ConsignerAddress2Line = Record.ConsignerAddress2Line
        .ConsignerAddress3Line = Record.ConsignerAddress3Line
        .ConsignerStateID = Record.ConsignerStateID
        .Purpose = Record.Purpose
        .ExpectedReturnDate = Record.ExpectedReturnDate
        .TotalAmount = Record.TotalAmount
        .ModeOfTransportID = Record.ModeOfTransportID
        .VehicleNo = Record.VehicleNo
        .GRNo = Record.GRNo
        .GRDate = Record.GRDate
        .TransporterID = Record.TransporterID
        .TransporterName = Record.TransporterName
        .FromPlace = Record.FromPlace
        .ToPlace = Record.ToPlace
        .Declaration1Line = Record.Declaration1Line
        .Declaration2Line = Record.Declaration2Line
        .Declaration3Line = Record.Declaration3Line
        .Declaration4Line = Record.Declaration4Line
        .LinkedChallanID = Record.LinkedChallanID
        .DestinationIsgecID = Record.DestinationIsgecID
        .DestinationBPID = Record.DestinationBPID
        .DestinationGSTIN = Record.DestinationGSTIN
        .DestinationName = Record.DestinationName
        .DestinationGSTINNo = Record.DestinationGSTINNo
        .DestinationAddress1Line = Record.DestinationAddress1Line
        .DestinationAddress2Line = Record.DestinationAddress2Line
        .DestinationAddress3Line = Record.DestinationAddress3Line
        .DestinationStateID = Record.DestinationStateID
        .IsgecInvoiceNo = Record.IsgecInvoiceNo
        .IsgecInvoiceDate = Record.IsgecInvoiceDate
      End With
      Return SIS.SPMT.SPMTerpDCH.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.SPMTerpDCH) As SIS.SPMT.SPMTerpDCH
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCHUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ChallanID", SqlDbType.NVarChar, 21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanDate", SqlDbType.DateTime, 21, IIf(Record.ChallanDate = "", Convert.DBNull, Record.ChallanDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID", SqlDbType.NVarChar, 21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy", SqlDbType.NVarChar, 9, IIf(Record.CreatedBy = "", Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn", SqlDbType.DateTime, 21, IIf(Record.CreatedOn = "", Convert.DBNull, Record.CreatedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID", SqlDbType.Int, 11, IIf(Record.StatusID = "", Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerID", SqlDbType.Int, 11, IIf(Record.IssuerID = "", Convert.DBNull, Record.IssuerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCompanyName", SqlDbType.NVarChar, 51, IIf(Record.IssuerCompanyName = "", Convert.DBNull, Record.IssuerCompanyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress1Line", SqlDbType.NVarChar, 201, IIf(Record.IssuerAddress1Line = "", Convert.DBNull, Record.IssuerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress2Line", SqlDbType.NVarChar, 201, IIf(Record.IssuerAddress2Line = "", Convert.DBNull, Record.IssuerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerPAN", SqlDbType.NVarChar, 51, IIf(Record.IssuerPAN = "", Convert.DBNull, Record.IssuerPAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCIN", SqlDbType.NVarChar, 51, IIf(Record.IssuerCIN = "", Convert.DBNull, Record.IssuerCIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID", SqlDbType.NVarChar, 7, IIf(Record.ProjectID = "", Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UnitID", SqlDbType.NVarChar, 7, IIf(Record.UnitID = "", Convert.DBNull, Record.UnitID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONo", SqlDbType.NVarChar, 10, IIf(Record.PONo = "", Convert.DBNull, Record.PONo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfSupply", SqlDbType.NVarChar, 3, IIf(Record.PlaceOfSupply = "", Convert.DBNull, Record.PlaceOfSupply))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfDelivery", SqlDbType.NVarChar, 3, IIf(Record.PlaceOfDelivery = "", Convert.DBNull, Record.PlaceOfDelivery))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeIsgecID", SqlDbType.Int, 11, IIf(Record.ConsigneeIsgecID = "", Convert.DBNull, Record.ConsigneeIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeBPID", SqlDbType.NVarChar, 10, IIf(Record.ConsigneeBPID = "", Convert.DBNull, Record.ConsigneeBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTIN", SqlDbType.Int, 11, IIf(Record.ConsigneeGSTIN = "", Convert.DBNull, Record.ConsigneeGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeName", SqlDbType.NVarChar, 51, IIf(Record.ConsigneeName = "", Convert.DBNull, Record.ConsigneeName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTINNo", SqlDbType.NVarChar, 51, IIf(Record.ConsigneeGSTINNo = "", Convert.DBNull, Record.ConsigneeGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress1Line", SqlDbType.NVarChar, 101, IIf(Record.ConsigneeAddress1Line = "", Convert.DBNull, Record.ConsigneeAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress2Line", SqlDbType.NVarChar, 101, IIf(Record.ConsigneeAddress2Line = "", Convert.DBNull, Record.ConsigneeAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress3Line", SqlDbType.NVarChar, 101, IIf(Record.ConsigneeAddress3Line = "", Convert.DBNull, Record.ConsigneeAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeStateID", SqlDbType.NVarChar, 3, IIf(Record.ConsigneeStateID = "", Convert.DBNull, Record.ConsigneeStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerIsgecID", SqlDbType.Int, 11, IIf(Record.ConsignerIsgecID = "", Convert.DBNull, Record.ConsignerIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerBPID", SqlDbType.NVarChar, 10, IIf(Record.ConsignerBPID = "", Convert.DBNull, Record.ConsignerBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTIN", SqlDbType.Int, 11, IIf(Record.ConsignerGSTIN = "", Convert.DBNull, Record.ConsignerGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerName", SqlDbType.NVarChar, 51, IIf(Record.ConsignerName = "", Convert.DBNull, Record.ConsignerName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTINNo", SqlDbType.NVarChar, 51, IIf(Record.ConsignerGSTINNo = "", Convert.DBNull, Record.ConsignerGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress1Line", SqlDbType.NVarChar, 101, IIf(Record.ConsignerAddress1Line = "", Convert.DBNull, Record.ConsignerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress2Line", SqlDbType.NVarChar, 101, IIf(Record.ConsignerAddress2Line = "", Convert.DBNull, Record.ConsignerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress3Line", SqlDbType.NVarChar, 101, IIf(Record.ConsignerAddress3Line = "", Convert.DBNull, Record.ConsignerAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerStateID", SqlDbType.NVarChar, 3, IIf(Record.ConsignerStateID = "", Convert.DBNull, Record.ConsignerStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Purpose", SqlDbType.NVarChar, 251, IIf(Record.Purpose = "", Convert.DBNull, Record.Purpose))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ExpectedReturnDate", SqlDbType.DateTime, 21, IIf(Record.ExpectedReturnDate = "", Convert.DBNull, Record.ExpectedReturnDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount", SqlDbType.Decimal, 21, IIf(Record.TotalAmount = "", Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountInWords", SqlDbType.NVarChar, 501, IIf(Record.TotalAmountInWords = "", Convert.DBNull, Record.TotalAmountInWords))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModeOfTransportID", SqlDbType.Int, 11, IIf(Record.ModeOfTransportID = "", Convert.DBNull, Record.ModeOfTransportID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleNo", SqlDbType.NVarChar, 51, IIf(Record.VehicleNo = "", Convert.DBNull, Record.VehicleNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRNo", SqlDbType.NVarChar, 51, IIf(Record.GRNo = "", Convert.DBNull, Record.GRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRDate", SqlDbType.DateTime, 21, IIf(Record.GRDate = "", Convert.DBNull, Record.GRDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterID", SqlDbType.NVarChar, 10, IIf(Record.TransporterID = "", Convert.DBNull, Record.TransporterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterName", SqlDbType.NVarChar, 51, IIf(Record.TransporterName = "", Convert.DBNull, Record.TransporterName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FromPlace", SqlDbType.NVarChar, 51, IIf(Record.FromPlace = "", Convert.DBNull, Record.FromPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToPlace", SqlDbType.NVarChar, 51, IIf(Record.ToPlace = "", Convert.DBNull, Record.ToPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration1Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration1Line = "", Convert.DBNull, Record.Declaration1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration2Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration2Line = "", Convert.DBNull, Record.Declaration2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration3Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration3Line = "", Convert.DBNull, Record.Declaration3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration4Line", SqlDbType.NVarChar, 251, IIf(Record.Declaration4Line = "", Convert.DBNull, Record.Declaration4Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LinkedChallanID", SqlDbType.NVarChar, 21, IIf(Record.LinkedChallanID = "", Convert.DBNull, Record.LinkedChallanID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationIsgecID", SqlDbType.Int, 11, IIf(Record.DestinationIsgecID = "", Convert.DBNull, Record.DestinationIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationBPID", SqlDbType.NVarChar, 10, IIf(Record.DestinationBPID = "", Convert.DBNull, Record.DestinationBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationGSTIN", SqlDbType.Int, 11, IIf(Record.DestinationGSTIN = "", Convert.DBNull, Record.DestinationGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationName", SqlDbType.NVarChar, 51, IIf(Record.DestinationName = "", Convert.DBNull, Record.DestinationName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationGSTINNo", SqlDbType.NVarChar, 51, IIf(Record.DestinationGSTINNo = "", Convert.DBNull, Record.DestinationGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationAddress1Line", SqlDbType.NVarChar, 101, IIf(Record.DestinationAddress1Line = "", Convert.DBNull, Record.DestinationAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationAddress2Line", SqlDbType.NVarChar, 101, IIf(Record.DestinationAddress2Line = "", Convert.DBNull, Record.DestinationAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationAddress3Line", SqlDbType.NVarChar, 101, IIf(Record.DestinationAddress3Line = "", Convert.DBNull, Record.DestinationAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DestinationStateID", SqlDbType.NVarChar, 3, IIf(Record.DestinationStateID = "", Convert.DBNull, Record.DestinationStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedDate", SqlDbType.DateTime, 21, IIf(Record.ReceivedDate = "", Convert.DBNull, Record.ReceivedDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedRemarks", SqlDbType.NVarChar, 501, IIf(Record.ReceivedRemarks = "", Convert.DBNull, Record.ReceivedRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedOn", SqlDbType.DateTime, 21, IIf(Record.ReceivedOn = "", Convert.DBNull, Record.ReceivedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReceivedBy", SqlDbType.NVarChar, 9, IIf(Record.ReceivedBy = "", Convert.DBNull, Record.ReceivedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosureRemarks", SqlDbType.NVarChar, 501, IIf(Record.ClosureRemarks = "", Convert.DBNull, Record.ClosureRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosureDate", SqlDbType.DateTime, 21, IIf(Record.ClosureDate = "", Convert.DBNull, Record.ClosureDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosedBy", SqlDbType.NVarChar, 9, IIf(Record.ClosedBy = "", Convert.DBNull, Record.ClosedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClosedOn", SqlDbType.DateTime, 21, IIf(Record.ClosedOn = "", Convert.DBNull, Record.ClosedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecInvoiceNo", SqlDbType.NVarChar, 51, IIf(Record.IsgecInvoiceNo = "", Convert.DBNull, Record.IsgecInvoiceNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsgecInvoiceDate", SqlDbType.DateTime, 21, IIf(Record.IsgecInvoiceDate = "", Convert.DBNull, Record.IsgecInvoiceDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rcno", SqlDbType.NVarChar, 10, IIf(Record.t_rcno = "", Convert.DBNull, Record.t_rcno))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srpo", SqlDbType.NVarChar, 10, IIf(Record.t_srpo = "", Convert.DBNull, Record.t_srpo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srpl", SqlDbType.Int, 11, IIf(Record.t_srpl = "", Convert.DBNull, Record.t_srpl))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DCType", SqlDbType.NVarChar, 11, Record.DCType)
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
    <DataObjectMethod(DataObjectMethodType.Delete, True)>
    Public Shared Function SPMTerpDCHDelete(ByVal Record As SIS.SPMT.SPMTerpDCH) As Int32
      Dim _Result As Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCHDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ChallanID", SqlDbType.NVarChar, Record.ChallanID.ToString.Length, Record.ChallanID)
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
    Public Shared Function SelectSPMTerpDCHAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spSPMTerpDCHAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, IIf(Prefix.ToLower = Prefix, 0, 1)))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(2, " "), ""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.SPMT.SPMTerpDCH = New SIS.SPMT.SPMTerpDCH(Reader)
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
