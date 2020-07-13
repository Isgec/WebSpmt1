Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtACProcessed
    Public ReadOnly Property AttachVisible() As Boolean
      Get
        Return SIS.SYS.Utilities.ApplicationSpacific.IsAttached(AdviceNo, SIS.SPMT.spmtPaymentAdvice.AthHandle)
      End Get
    End Property

    Public ReadOnly Property SaveWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property SaveWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function SaveWF(ByVal AdviceNo As Int32, ByVal value As String) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      Dim oEmp As SIS.COM.comUsers = SIS.COM.comUsers.GetByID(HttpContext.Current.User.Identity.Name)
      If Results.AdviceStatusID = spmtPAStates.Returning Then
        With Results
          .AdviceStatusID = spmtPAStates.Returned
          .RemarksHOD = oEmp.LoginID & "-" & oEmp.UserFullName & " " & Now.ToString("dd/MM/yyyy")
          .RemarksAC = value
        End With
        SIS.SPMT.spmtACProcessed.UpdateData(Results)
        'Removes copied attachment to advice from bill
        ejiVault.EJI.ediAFile.DeleteDataByHandleIndex(SIS.SPMT.spmtPaymentAdvice.AthHandle, Results.AdviceNo)
        '==============New PA====================='
        If Results.VoucherNo <> "" Then
          'Payment advice is auto created from new session
          Dim tmpBills As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.UZ_spmtPaymentAdviceSupplierBillSelectList(0, 99999, "", False, "", Results.AdviceNo)
          For Each tmpB As SIS.SPMT.spmtPaymentAdviceSupplierBill In tmpBills
            'Delete only metadata
            ejiVault.EJI.ediAFile.DeleteDataByHandleIndex(SIS.SPMT.spmtSupplierBill.AthHandle, tmpB.IRNo)
            SIS.SPMT.spmtPaymentAdviceSupplierBill.UZ_spmtSupplierBillDelete(tmpB)
          Next
          'Deletes Auto created Payment advice
          SIS.SPMT.spmtPaymentAdvice.UZ_spmtPaymentAdviceDelete(Results)
          'then changes status of newPA
          Dim nPA As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(Results.VoucherNo)
          If Not nPA Is Nothing Then
            With nPA
              .StatusID = spmtPAStates.Returned
              .AccountsRemarks = value
              .ReceivedInACBy = oEmp.LoginID
              .ReceivedInACOn = Now
            End With
            nPA = SIS.SPMT.spmtNewPA.UpdateData(nPA)
            'Removes copied attachments to PA from Bill
            ejiVault.EJI.ediAFile.DeleteDataByHandleIndex(SIS.SPMT.spmtNewPA.AthHandle, nPA.AdviceNo)
          End If
        End If
        '=================New PA Returned==============='
      End If
      If Results.AdviceStatusID = spmtPAStates.UpdatingVoucher Then
        Dim aVal() As String = value.Split("|".ToCharArray)
        With Results
          .AdviceStatusID = spmtPAStates.VoucherUpdated
          .RemarksHOD = oEmp.LoginID & "-" & oEmp.UserFullName & " " & Now.ToString("dd/MM/yyyy")
          .DocumentNo = aVal(0)
          .BaaNCompany = aVal(1)
          .BaaNLedger = aVal(2)
        End With
        SIS.SPMT.spmtACProcessed.UpdateData(Results)
        '==============New PA====================='
        If Results.VoucherNo <> "" Then
          Dim nPA As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(Results.VoucherNo)
          If Not nPA Is Nothing Then
            With nPA
              .StatusID = spmtPAStates.VoucherUpdated
              .ReceivedInACBy = oEmp.LoginID
              .ReceivedInACOn = Now
              .VoucherType = aVal(0)
              .VoucherNo = aVal(1)
              .ERPCompany = aVal(2)
            End With
            nPA = SIS.SPMT.spmtNewPA.UpdateData(nPA)
          End If
        End If
        '=================New PA Voucher Updated==============='
      End If
      Return Results
    End Function
    Public ReadOnly Property CancelWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property CancelWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function CancelWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      If Results.AdviceStatusID = spmtPAStates.Returning Then
        With Results
          .AdviceStatusID = spmtPAStates.ReceivedInAC
        End With
        SIS.SPMT.spmtACProcessed.UpdateData(Results)
      End If
      If Results.AdviceStatusID = spmtPAStates.UpdatingVoucher Then
        With Results
          .AdviceStatusID = spmtPAStates.ReceivedInAC
        End With
        SIS.SPMT.spmtACProcessed.UpdateData(Results)
      End If
      Return Results
    End Function
    Public ReadOnly Property LockWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If AdviceStatusID = 11 Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property LockWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function LockWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      With Results
        Dim oEmp As SIS.COM.comUsers = SIS.COM.comUsers.GetByID(HttpContext.Current.User.Identity.Name)
        .AdviceStatusID = spmtPAStates.Locked
        .RemarksHR = oEmp.LoginID & "-" & oEmp.UserFullName & " " & Now.ToString("dd/MM/yyyy")
      End With
      SIS.SPMT.spmtACProcessed.UpdateData(Results)
      '==============New PA====================='
      If Results.VoucherNo <> "" Then
        Dim nPA As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(Results.VoucherNo)
        If Not nPA Is Nothing Then
          With nPA
            .StatusID = spmtPAStates.Locked
            .LockedInACBy = HttpContext.Current.Session("LoginID")
            .LockedInACOn = Now
          End With
          nPA = SIS.SPMT.spmtNewPA.UpdateData(nPA)
        End If
      End If
      '=================New PA Locked==============='
      'Update In ERP
      Dim oIRs As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(0, 9999, "", False, "", Results.AdviceNo)
      For Each tmp As SIS.SPMT.spmtPaymentAdviceSupplierBill In oIRs
        If tmp.DocNo = "AIRY" Then Continue For
        Dim Found As Boolean = False
        Dim oUpd As SIS.SPMT.spmtUPDInERP = SIS.SPMT.spmtUPDInERP.spmtUPDInERPGetByID(tmp.DocNo, tmp.IRNo)
        If oUpd Is Nothing Then
          Dim oERP As New SIS.SPMT.spmtERPSupplierBill
          oERP = SIS.SPMT.spmtERPSupplierBill.GetERPBill(Results, oERP)
          oERP = SIS.SPMT.spmtERPSupplierBill.GetERPBill(tmp, oERP)
          With oERP
            .UploadedBy = HttpContext.Current.Session("LoginID")
            .UploadedOn = Now
          End With
          oUpd = New SIS.SPMT.spmtUPDInERP
          oUpd = SIS.SPMT.spmtERPSupplierBill.GetUPDInERP(oERP)
          SIS.SPMT.spmtUPDInERP.InsertData(oUpd)
        Else
          Dim oERP As New SIS.SPMT.spmtERPSupplierBill
          oERP = SIS.SPMT.spmtERPSupplierBill.GetERPBill(Results, oERP)
          oERP = SIS.SPMT.spmtERPSupplierBill.GetERPBill(tmp, oERP)
          With oERP
            .UploadedBy = HttpContext.Current.Session("LoginID")
            .UploadedOn = Now
          End With
          oUpd = SIS.SPMT.spmtERPSupplierBill.GetUPDInERP(oERP)
          SIS.SPMT.spmtUPDInERP.UpdateData(oUpd)
        End If
      Next
      Return Results
    End Function
    Public Shadows ReadOnly Property InitiateWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If AdviceStatusID = 8 Or AdviceStatusID = 11 Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shadows ReadOnly Property InitiateWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    'Receive In Accounts
    Public ReadOnly Property ApproveWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If AdviceStatusID = 7 Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ReceivedByVisible As Boolean
      Get
        Dim mRet As Boolean = True
        If AdviceStatusID = 7 Then
          mRet = False
        End If
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ApproveWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property RejectWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If AdviceStatusID = 8 Then
            mRet = True
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ReturnEntryVisible As Boolean
      Get
        Dim mRet As Boolean = False
        If AdviceStatusID = 9 Then
          mRet = True
        End If
        Return mRet
      End Get
    End Property
    Public ReadOnly Property UpdateEntryVisible As Boolean
      Get
        Dim mRet As Boolean = False
        If AdviceStatusID = 10 Then
          mRet = True
        End If
        Return mRet
      End Get
    End Property
    Public ReadOnly Property RejectWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property CompleteWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
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
    Public Shared Shadows Function InitiateWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      With Results
        .AdviceStatusID = spmtPAStates.UpdatingVoucher
      End With
      SIS.SPMT.spmtACProcessed.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function ApproveWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      With Results
        Dim oEmp As SIS.COM.comUsers = SIS.COM.comUsers.GetByID(HttpContext.Current.User.Identity.Name)
        .AdviceStatusID = spmtPAStates.ReceivedInAC
        .RemarksHOD = oEmp.LoginID & "-" & oEmp.UserFullName & " " & Now.ToString("dd/MM/yyyy")
      End With
      SIS.SPMT.spmtACProcessed.UpdateData(Results)
      '==============New PA====================='
      If Results.VoucherNo <> "" Then
        Dim nPA As SIS.SPMT.spmtNewPA = SIS.SPMT.spmtNewPA.spmtNewPAGetByID(Results.VoucherNo)
        If Not nPA Is Nothing Then
          With nPA
            .StatusID = spmtPAStates.ReceivedInAC
            .ReceivedInACBy = HttpContext.Current.Session("LoginID")
            .ReceivedInACOn = Now
          End With
          nPA = SIS.SPMT.spmtNewPA.UpdateData(nPA)
        End If
      End If
      '=================New PA Received==============='
      Return Results
    End Function
    Public Shared Function RejectWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      DirectDeleteAttachment(AdviceNo)
      With Results
        .AdviceStatusID = spmtPAStates.Returning
      End With
      SIS.SPMT.spmtACProcessed.UpdateData(Results)
      Return Results
    End Function
    Public Shared Sub DirectDeleteAttachment(ByVal AdviceNo As String)
      Dim Sql As String = ""
      Sql &= " delete "
      Sql &= " ttcisg132200"
      Sql &= " where t_hndl='" & SIS.SPMT.spmtPaymentAdvice.AthHandle & "' "
      Sql &= " and t_indx=" & AdviceNo
      Sql &= ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Cmd.ExecuteNonQuery()
        End Using
      End Using
    End Sub

    Public Shared Function CompleteWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtACProcessed
      Dim Results As SIS.SPMT.spmtACProcessed = spmtACProcessedGetByID(AdviceNo)
      Return Results
    End Function
    Public Shared Function UZ_spmtACProcessedSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32, ByVal TranTypeID As String, ByVal BPID As String, ByVal AdviceStatusID As String) As List(Of SIS.SPMT.spmtACProcessed)
      Dim Results As List(Of SIS.SPMT.spmtACProcessed) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_ACProcessedSelectListSearch"
            Cmd.CommandText = "spspmtACProcessedSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_ACProcessedSelectListFilteres"
            Cmd.CommandText = "spspmtACProcessedSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo", SqlDbType.Int, 10, IIf(AdviceNo = Nothing, 0, AdviceNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceStatusID", SqlDbType.NVarChar, 3, IIf(AdviceStatusID Is Nothing, String.Empty, AdviceStatusID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtACProcessed)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtACProcessed(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtACProcessedSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32, ByVal TranTypeID As String, ByVal BPID As String, ByVal AdviceStatusID As String) As Integer
      Return RecordCount
    End Function

  End Class
End Namespace
