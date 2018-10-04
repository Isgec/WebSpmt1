Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtAirTicket
    Public Property Err As Boolean = False
    Public Property ErrMsg As List(Of String) = New List(Of String)
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Blue
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEnable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEditable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If StatusID = 2 Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function InitiateWF(ByVal SerialNo As Int32) As SIS.SPMT.spmtAirTicket
      Dim Record As SIS.SPMT.spmtAirTicket = spmtAirTicketGetByID(SerialNo)
      'Dim oSB As New SIS.SPMT.spmtSupplierBill
      'With oSB
      '  .DocNo = "AIRT"
      '  .DocLine = Record.SerialNo
      '  .TranTypeID = 1 ' 
      '  .BillStatusID = 4
      '  .BillStatusDate = Now
      '  .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
      '  .BillAmount = Record.TotalAmount
      '  .IRReceivedOn = Now
      '  .BPID = Record.SupplierID
      '  .BillNumber = Record.SupplierBillNumber
      '  .BillDate = Record.SupplierBillDate
      '  .Quantity = 1
      '  .UOM = "nos"
      '  .Currency = "INR"
      '  .BillRemarks = Record.ItemDescription
      '  .SupplierGSTIN = Record.SupplierGSTIN
      '  .IsgecGSTIN = Record.IsgecGSTIN
      '  .ShipToState = Record.StateID
      '  .HSNSACCode = Record.HSNSACCode
      '  .BillType = Record.BillType
      '  .ConversionFactorINR = 1
      '  .TotalGST = Record.TotalGST
      '  .CessAmount = Record.CessAmount
      '  .CessRate = Record.CessRate
      '  .TaxAmount = Record.TotalGST
      '  .RemarksGST = "Agent Record"
      '  .TotalAmountINR = Record.TotalAmount
      '  .TotalAmount = Record.TotalAmount
      '  .IGSTAmount = Record.IGSTAmount
      '  .IGSTRate = Record.IGSTRate
      '  .AssessableValue = Record.AssessableValue
      '  .CGSTRate = Record.CGSTRate
      '  .SGSTAmount = Record.SGSTAmount
      '  .SGSTRate = Record.SGSTRate
      '  .CGSTAmount = Record.CGSTAmount
      '  .PurchaseType = "Purchase from Registered Dealer"
      'End With
      'oSB = SIS.SPMT.spmtSupplierBill.InsertData(oSB)
      'oSB = New SIS.SPMT.spmtSupplierBill
      'With oSB
      '  .DocNo = "AIRT"
      '  .DocLine = Record.SerialNo
      '  .TranTypeID = 1 ' 
      '  .BillStatusID = 4
      '  .BillStatusDate = Now
      '  .BillStatusUser = Global.System.Web.HttpContext.Current.Session("LoginID")
      '  .BillAmount = Record.TotalFare
      '  .IRReceivedOn = Now
      '  .BPID = Record.AirlineID
      '  .BillNumber = Record.TicketNumber
      '  .BillDate = Record.BookedOn
      '  .Quantity = 1
      '  .UOM = "nos"
      '  .Currency = "INR"
      '  .BillRemarks = Record.ItemDescription
      '  .SupplierGSTIN = Record.AirlineGSTIN
      '  .IsgecGSTIN = Record.IsgecGSTIN
      '  .ShipToState = Record.StateID
      '  .HSNSACCode = Record.AirLineHSNSACCode
      '  .BillType = Record.AirLineBillType
      '  .ConversionFactorINR = 1
      '  .TotalGST = Record.TotalGST
      '  .CessAmount = 0
      '  .CessRate = 0
      '  .TaxAmount = Record.TotalGST
      '  .RemarksGST = "Airline Record"
      '  .TotalAmountINR = Record.TotalFare
      '  .TotalAmount = Record.TotalFare
      '  .IGSTAmount = 0
      '  .IGSTRate = 0
      '  .AssessableValue = Record.BasicFare
      '  .CGSTRate = 0
      '  .CGSTAmount = Record.YQTax
      '  .SGSTAmount = Record.AllOtherTaxes
      '  .SGSTRate = 0
      '  .PurchaseType = "Purchase from Registered Dealer"
      'End With
      'oSB = SIS.SPMT.spmtSupplierBill.InsertData(oSB)

      'With Record
      '  .StatusID = 3  'Bill/PA Created
      'End With
      'Record = SIS.SPMT.spmtAirTicket.UpdateData(Record)
      Return Record
    End Function
    Public Shared Function UZ_spmtAirTicketSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal TranTypeID As String, ByVal AgentsBPID As String, ByVal AgencyBPID As String, ByVal EmployeeID As String, ByVal ProjectID As String, ByVal ISGECUnit As String, ByVal Geography As String, ByVal StatusID As Int32, ByVal AdviceNo As Int32) As List(Of SIS.SPMT.spmtAirTicket)
      Dim Results As List(Of SIS.SPMT.spmtAirTicket) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "SerialNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_AirTicketSelectListSearch"
            Cmd.CommandText = "spspmtAirTicketSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_AirTicketSelectListFilteres"
            Cmd.CommandText = "spspmtAirTicketSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AgentsBPID", SqlDbType.NVarChar, 9, IIf(AgentsBPID Is Nothing, String.Empty, AgentsBPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AgencyBPID", SqlDbType.NVarChar, 9, IIf(AgencyBPID Is Nothing, String.Empty, AgencyBPID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_EmployeeID", SqlDbType.NVarChar, 8, IIf(EmployeeID Is Nothing, String.Empty, EmployeeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID", SqlDbType.NVarChar, 6, IIf(ProjectID Is Nothing, String.Empty, ProjectID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ISGECUnit", SqlDbType.NVarChar, 10, IIf(ISGECUnit Is Nothing, String.Empty, ISGECUnit))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_Geography", SqlDbType.NVarChar, 20, IIf(Geography Is Nothing, String.Empty, Geography))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_StatusID", SqlDbType.Int, 10, IIf(StatusID = Nothing, 0, StatusID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo", SqlDbType.Int, 10, IIf(AdviceNo = Nothing, 0, AdviceNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
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
    Public Shared Function UZ_spmtAirTicketInsert(ByVal Record As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
      Dim _Result As SIS.SPMT.spmtAirTicket = spmtAirTicketInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtAirTicketUpdate(ByVal Record As SIS.SPMT.spmtAirTicket) As SIS.SPMT.spmtAirTicket
      Dim _Result As SIS.SPMT.spmtAirTicket = spmtAirTicketUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtAirTicketDelete(ByVal Record As SIS.SPMT.spmtAirTicket) As Integer
      Dim _Result As Integer = spmtAirTicketDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_SerialNo"), TextBox).Text = ""
          CType(.FindControl("F_TranTypeID"), Object).SelectedValue = ""
          CType(.FindControl("F_AgentsIsgecGSTIN"), Object).SelectedValue = ""
          CType(.FindControl("F_AgentsStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_AgentsBillNumber"), TextBox).Text = ""
          CType(.FindControl("F_AgentsBillDate"), TextBox).Text = ""
          CType(.FindControl("F_AgentsItemName"), TextBox).Text = ""
          CType(.FindControl("F_AgentsBPID"), TextBox).Text = ""
          CType(.FindControl("F_AgentsBPID_Display"), Label).Text = ""
          CType(.FindControl("F_AgentsGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_AgentsGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_AgentsName"), TextBox).Text = ""
          CType(.FindControl("F_AgentsGSTINNumber"), TextBox).Text = ""
          CType(.FindControl("F_AgentsBillType"), Object).SelectedValue = ""
          CType(.FindControl("F_AgentsHSNSACCode"), TextBox).Text = ""
          CType(.FindControl("F_AgentsHSNSACCode_Display"), Label).Text = ""
          CType(.FindControl("F_AgentsBasicValue"), TextBox).Text = 0
          CType(.FindControl("F_AgentsIGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_AgentsIGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgentsSGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_AgentsSGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgentsCGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_AgentsCGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgentsCessRate"), TextBox).Text = 0
          CType(.FindControl("F_AgentsCessAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgentsTotalGST"), TextBox).Text = 0
          CType(.FindControl("F_AgentsTotalAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgentsRCMApplicable"), CheckBox).Checked = False
          CType(.FindControl("F_AgencyIsgecGSTIN"), Object).SelectedValue = ""
          CType(.FindControl("F_AgencyStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_AgencyBillNumber"), TextBox).Text = ""
          CType(.FindControl("F_AgencyBillDate"), TextBox).Text = ""
          CType(.FindControl("F_AgencyItemName"), TextBox).Text = ""
          CType(.FindControl("F_AgencyBPID"), TextBox).Text = ""
          CType(.FindControl("F_AgencyBPID_Display"), Label).Text = ""
          CType(.FindControl("F_AgencyGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_AgencyGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_AgencyName"), TextBox).Text = ""
          CType(.FindControl("F_AgencyGSTINNumber"), TextBox).Text = ""
          CType(.FindControl("F_AgencyBillType"), Object).SelectedValue = ""
          CType(.FindControl("F_AgencyHSNSACCode"), TextBox).Text = ""
          CType(.FindControl("F_AgencyHSNSACCode_Display"), Label).Text = ""
          CType(.FindControl("F_AgencyBasicValue"), TextBox).Text = 0
          CType(.FindControl("F_AgencyIGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_AgencyIGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgencySGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_AgencySGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgencyCGSTRate"), TextBox).Text = 0
          CType(.FindControl("F_AgencyCGSTAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgencyCessRate"), TextBox).Text = 0
          CType(.FindControl("F_AgencyCessAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgencyTotalGST"), TextBox).Text = 0
          CType(.FindControl("F_AgencyTotalAmount"), TextBox).Text = 0
          CType(.FindControl("F_AgencyRCMApplicable"), CheckBox).Checked = False
          CType(.FindControl("F_NonGST1TaxRate"), TextBox).Text = 0
          CType(.FindControl("F_NonGST1TaxAmount"), TextBox).Text = 0
          CType(.FindControl("F_NonGST2TaxRate"), TextBox).Text = 0
          CType(.FindControl("F_NonGST2TaxAmount"), TextBox).Text = 0
          CType(.FindControl("F_TotalPayableToAgent"), TextBox).Text = 0
          CType(.FindControl("F_PaxName"), TextBox).Text = ""
          CType(.FindControl("F_Sector"), TextBox).Text = ""
          CType(.FindControl("F_TravelDate"), TextBox).Text = ""
          CType(.FindControl("F_ReferrenceNumber"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeID"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeID_Display"), Label).Text = ""
          CType(.FindControl("F_ProjectID"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID_Display"), Label).Text = ""
          CType(.FindControl("F_ISGECUnit"), DropDownList).SelectedValue = ""
          CType(.FindControl("F_Geography"), TextBox).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
    Public Shared Function spmtAirTicketGetBySupplierGSTINInvoice(ByVal SupplierGSTINNo As String, ByVal InvoiceNo As String) As SIS.SPMT.spmtAirTicket
      Dim Results As SIS.SPMT.spmtAirTicket = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmt_LG_AirTicketSelectBySupplierGSTINInvoice"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierGSTINNo", SqlDbType.NVarChar, SupplierGSTINNo.Length, IIf(SupplierGSTINNo = "", Convert.DBNull, SupplierGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InvoiceNo", SqlDbType.NVarChar, InvoiceNo.Length, InvoiceNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
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
  End Class
End Namespace
