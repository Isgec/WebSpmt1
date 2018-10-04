Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtDCHeader
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
    Public ReadOnly Property CompleteWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If StatusID = spmtDHStates.Created Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property CompleteWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function CompleteWF(ByVal ChallanID As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = spmtDHStates.Issued
        .CreatedBy = HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function
    Public ReadOnly Property ReceiptPanelVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If StatusID = spmtDHStates.UnderReceiptEntry Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ReceiptWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If StatusID = spmtDHStates.Issued Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ReceiptWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function CancelReceipt(ByVal ChallanID As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = spmtDHStates.Issued
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function

    Public Shared Function SaveReceipt(ByVal ChallanID As String, ReceivedDate As String, Status As String, ReceivedRemarks As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = Status
        .ReceivedDate = ReceivedDate
        .ReceivedRemarks = ReceivedRemarks
        .ReceivedOn = Now
        .ReceivedBy = HttpContext.Current.Session("LoginID")
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function ReceiptWF(ByVal ChallanID As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = spmtDHStates.UnderReceiptEntry
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function
    Public ReadOnly Property ClosureWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If StatusID = spmtDHStates.Received Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ClosureWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ClosurePanelVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If StatusID = spmtDHStates.UnderClosureEntry Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function ClosureWF(ByVal ChallanID As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = spmtDHStates.UnderClosureEntry
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function CancelClosure(ByVal ChallanID As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = spmtDHStates.Received
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function SaveClosure(ByVal ChallanID As String, ByVal LinkedChallanID As String, ByVal DestinationIsgecID As String, ByVal DestinationBPID As String, ByVal DestinationGSTIN As String, ByVal DestinationName As String, ByVal DestinationGSTINNo As String, ByVal DestinationAddress1Line As String, ByVal DestinationAddress2Line As String, ByVal DestinationAddress3Line As String, ByVal DestinationStateID As String, ByVal ClosureRemarks As String, ByVal ClosureDate As String, ByVal CStatus As String, ByVal IsgecInvoiceNo As String, ByVal IsgecInvoiceDate As String) As SIS.SPMT.spmtDCHeader
      If Convert.ToInt32(CStatus) = spmtDHStates.SentToCustomerSite Then
        If IsgecInvoiceDate = String.Empty Or IsgecInvoiceNo = String.Empty Then
          Throw New Exception("When sent to Customer Site, then Isgec Invoice No and Invoice Date are Mandatory.")
        End If
      End If
      Dim Results As SIS.SPMT.spmtDCHeader = spmtDCHeaderGetByID(ChallanID)
      With Results
        .StatusID = CStatus
        .LinkedChallanID = LinkedChallanID
        .DestinationAddress1Line = DestinationAddress1Line
        .DestinationAddress2Line = DestinationAddress2Line
        .DestinationAddress3Line = DestinationAddress3Line
        .DestinationBPID = DestinationBPID
        .DestinationGSTIN = DestinationGSTIN
        .DestinationGSTINNo = DestinationGSTINNo
        .DestinationIsgecID = DestinationIsgecID
        .DestinationName = DestinationName
        .DestinationStateID = DestinationStateID
        .ClosureDate = ClosureDate
        .ClosureRemarks = ClosureRemarks
        .IsgecInvoiceDate = IsgecInvoiceDate
        .IsgecInvoiceNo = IsgecInvoiceNo
        .ClosedBy = HttpContext.Current.Session("LoginID")
        .ClosedOn = Now
      End With
      Results = SIS.SPMT.spmtDCHeader.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function UZ_spmtDCHeaderSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.spmtDCHeader)
      Dim Results As List(Of SIS.SPMT.spmtDCHeader) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "ChallanID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_DCHeaderSelectListSearch"
            Cmd.CommandText = "spspmtDCHeaderSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_DCHeaderSelectListFilteres"
            Cmd.CommandText = "spspmtDCHeaderSelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtDCHeader)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtDCHeader(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_spmtDCHeaderInsert(ByVal Record As SIS.SPMT.spmtDCHeader) As SIS.SPMT.spmtDCHeader
      Dim DCNo As String = SIS.SPMT.spmtDCLastNumber.GetNextDCNo()
      Record.ChallanID = DCNo
      Dim _Result As SIS.SPMT.spmtDCHeader = spmtDCHeaderInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtDCHeaderUpdate(ByVal Record As SIS.SPMT.spmtDCHeader) As SIS.SPMT.spmtDCHeader
      Dim _Result As SIS.SPMT.spmtDCHeader = spmtDCHeaderUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtDCHeaderDelete(ByVal Record As SIS.SPMT.spmtDCHeader) As Integer
      Dim _Result as Integer = spmtDCHeaderDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_ChallanID"), TextBox).Text = ""
          CType(.FindControl("F_ChallanDate"), TextBox).Text = ""
          CType(.FindControl("F_IssuerID"), Object).SelectedValue = ""
          CType(.FindControl("F_IssuerCompanyName"), TextBox).Text = ""
          CType(.FindControl("F_IssuerAddress1Line"), TextBox).Text = ""
          CType(.FindControl("F_IssuerAddress2Line"), TextBox).Text = ""
          CType(.FindControl("F_IssuerPAN"), TextBox).Text = ""
          CType(.FindControl("F_IssuerCIN"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID_Display"), Label).Text = ""
          CType(.FindControl("F_UnitID"), Object).SelectedValue = ""
          CType(.FindControl("F_PONo"), TextBox).Text = ""
          CType(.FindControl("F_PlaceOfSupply"), Object).SelectedValue = ""
          CType(.FindControl("F_PlaceOfDelivery"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsignerIsgecID"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsigneeIsgecID"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsignerBPID"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerBPID_Display"), Label).Text = ""
          CType(.FindControl("F_ConsigneeBPID"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeBPID_Display"), Label).Text = ""
          CType(.FindControl("F_ConsignerGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_ConsigneeGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_ConsignerName"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeName"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerGSTINNo"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeGSTINNo"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerAddress1Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeAddress1Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerAddress2Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeAddress2Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsigneeStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_Purpose"), TextBox).Text = ""
          CType(.FindControl("F_ExpectedReturnDate"), TextBox).Text = ""
          CType(.FindControl("F_ModeOfTransportID"), Object).SelectedValue = ""
          CType(.FindControl("F_VehicleNo"), TextBox).Text = ""
          CType(.FindControl("F_GRNo"), TextBox).Text = ""
          CType(.FindControl("F_GRDate"), TextBox).Text = ""
          CType(.FindControl("F_TransporterID"), TextBox).Text = ""
          CType(.FindControl("F_TransporterID_Display"), Label).Text = ""
          CType(.FindControl("F_TransporterName"), TextBox).Text = ""
          CType(.FindControl("F_FromPlace"), TextBox).Text = ""
          CType(.FindControl("F_ToPlace"), TextBox).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
    Public Shared Sub Validate(ByVal ChallanID As String)
      Dim tmp As SIS.SPMT.spmtDCHeader = SIS.SPMT.spmtDCHeader.spmtDCHeaderGetByID(ChallanID)
      Dim TotalAmount As Decimal = 0.00
      Dim tmpD As List(Of SIS.SPMT.spmtDCDetails) = SIS.SPMT.spmtDCDetails.spmtDCDetailsSelectList(0, 9999, "", False, "", ChallanID)
      For Each tm As SIS.SPMT.spmtDCDetails In tmpD
        Try
          TotalAmount += tm.TotalAmount
        Catch ex As Exception
        End Try
      Next
      tmp.TotalAmount = TotalAmount
      tmp.TotalAmountInWords = SpellNumber(TotalAmount)
      SIS.SPMT.spmtDCHeader.UpdateData(tmp)
    End Sub
#Region "   Spell Number "
    Public Shared Function SpellNumber(ByVal MyNumber As String) As String
      Dim Dollars, Cents, Temp As String
      Dim DecimalPlace, Count As Integer
      Dim Place(9) As String
      Place(2) = " Thousand "
      Place(3) = " Million "
      Place(4) = " Billion "
      Place(5) = " Trillion "
      Dollars = ""
      Cents = ""
      Temp = ""
      ' String representation of amount.
      MyNumber = Trim(Str(MyNumber))
      ' Position of decimal place 0 if none.
      DecimalPlace = InStr(MyNumber, ".")
      ' Convert cents and set MyNumber to dollar amount.
      If DecimalPlace > 0 Then
        Cents = GetTens(Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2))
        MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
      End If
      Count = 1
      Do While MyNumber <> ""
        Temp = GetHundreds(Right(MyNumber, 3))
        If Temp <> "" Then Dollars = Temp & Place(Count) & Dollars
        If Len(MyNumber) > 3 Then
          MyNumber = Left(MyNumber, Len(MyNumber) - 3)
        Else
          MyNumber = ""
        End If
        Count = Count + 1
      Loop
      Select Case Dollars
        Case ""
          Dollars = "No Rs."
        Case "One"
          Dollars = "One Rs."
        Case Else
          Dollars = Dollars & " Rs."
      End Select
      Select Case Cents
        Case ""
          Cents = " and No Paisa"
        Case "One"
          Cents = " and One Paisa"
        Case Else
          Cents = " and " & Cents & " Paisa"
      End Select
      SpellNumber = Dollars & Cents
    End Function

    ' Converts a number from 100-999 into text 
    Shared Function GetHundreds(ByVal MyNumber As String) As String
      Dim Result As String = ""
      If Val(MyNumber) = 0 Then Return ""
      MyNumber = Right("000" & MyNumber, 3)
      ' Convert the hundreds place.
      If Mid(MyNumber, 1, 1) <> "0" Then
        Result = GetDigit(Mid(MyNumber, 1, 1)) & " Hundred "
      End If
      ' Convert the tens and ones place.
      If Mid(MyNumber, 2, 1) <> "0" Then
        Result = Result & GetTens(Mid(MyNumber, 2))
      Else
        Result = Result & GetDigit(Mid(MyNumber, 3))
      End If
      GetHundreds = Result
    End Function

    ' Converts a number from 10 to 99 into text. 
    Shared Function GetTens(ByVal TensText As Integer) As String
      Dim Result As String
      Result = ""           ' Null out the temporary function value.
      If Val(Left(TensText, 1)) = 1 Then   ' If value between 10-19...
        Select Case Val(TensText)
          Case 10 : Result = "Ten"
          Case 11 : Result = "Eleven"
          Case 12 : Result = "Twelve"
          Case 13 : Result = "Thirteen"
          Case 14 : Result = "Fourteen"
          Case 15 : Result = "Fifteen"
          Case 16 : Result = "Sixteen"
          Case 17 : Result = "Seventeen"
          Case 18 : Result = "Eighteen"
          Case 19 : Result = "Nineteen"
          Case Else
        End Select
      Else                                 ' If value between 20-99...
        Select Case Val(Left(TensText, 1))
          Case 2 : Result = "Twenty "
          Case 3 : Result = "Thirty "
          Case 4 : Result = "Forty "
          Case 5 : Result = "Fifty "
          Case 6 : Result = "Sixty "
          Case 7 : Result = "Seventy "
          Case 8 : Result = "Eighty "
          Case 9 : Result = "Ninety "
          Case Else
        End Select
        Result = Result & GetDigit(Right(TensText, 1))  ' Retrieve ones place.
      End If
      GetTens = Result
    End Function

    ' Converts a number from 1 to 9 into text. 
    Shared Function GetDigit(ByVal Digit As Integer) As String
      Select Case Val(Digit)
        Case 1 : GetDigit = "One"
        Case 2 : GetDigit = "Two"
        Case 3 : GetDigit = "Three"
        Case 4 : GetDigit = "Four"
        Case 5 : GetDigit = "Five"
        Case 6 : GetDigit = "Six"
        Case 7 : GetDigit = "Seven"
        Case 8 : GetDigit = "Eight"
        Case 9 : GetDigit = "Nine"
        Case Else : GetDigit = ""
      End Select
    End Function

#End Region

  End Class
  Public Class BPAddress
    Public Property CompanyName As String = ""
    Public Property Address1Line As String = ""
    Public Property Address2Line As String = ""
    Public Property Address3Line As String = ""
    Public Property StateID As String = ""
    Public Property GSTIN As String = ""
    Public Shared Function GetBPAddress(ByVal BPID As String, ByVal GSTIN As String) As BPAddress
      Dim mRet As BPAddress = Nothing
      Dim Sql As String = ""
      Sql &= "select                                                                                "
      Sql &= "ltrim(t_nama)+ ' ' + ltrim(t_namb) as CompanyName,                                    "
      Sql &= "ltrim(t_namc)+ ' ' + ltrim(t_namd) as Address1Line,                                   "
      Sql &= "ltrim(t_namf) as Address2Line,                                                        "
      Sql &= "ltrim(stt.t_dsca)+ ', ' + ltrim(cnt.t_dsca) as Address3Line,                          "
      Sql &= "ltrim(t_ogst) as GSTIN                                                                "
      Sql &= "from ttcisg103200 as gst                                                              "
      Sql &= "inner join ttccom130200 as adr on gst.t_cadr = adr.t_cadr                             "
      Sql &= "inner join ttcmcs010200 as cnt on adr.t_ccty = cnt.t_ccty                             "
      Sql &= "inner join ttcmcs143200 as stt on adr.t_ccty = stt.t_ccty and adr.t_cste = stt.t_cste "
      Sql &= "where gst.t_bpid = '" & BPID & "' and gst.t_seqn_l='" & GSTIN & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If (Reader.Read()) Then
            mRet = New BPAddress(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      mRet.StateID = mRet.GSTIN.Substring(0, 2)
      Return mRet
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
    Sub New()
      'dummy
    End Sub
  End Class
End Namespace
