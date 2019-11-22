Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class SPMTerpDCH
    'Additional Properties
    Public Property Remarks As String = ""
    Public Property ERPUnitID As String = ""
    Public Property IsgecGSTIN As String = ""
    Public Property ConsignerPO As String = ""
    Public Property ConsigneePO As String = ""
    Public Property ConsignerStateName As String = ""
    Public Property ConsigneeStateName As String = ""
    Public Property IRNumber As String = ""
    Public Property IRDate As String = ""
    Public Property SupplierBill As String = ""
    Public Property SupplierBillDate As String = ""
    Public Property PlaceOfSupplyName As String = ""
    Public Property PlaceOfDeliveryName As String = ""


    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Black
      Select Case StatusID
        Case spmtDHStates.Cancelled
          mRet = Drawing.Color.Red
        Case spmtDHStates.Issued
          mRet = Drawing.Color.Purple
        Case spmtDHStates.Received
          mRet = Drawing.Color.Green
      End Select
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
      Dim mRet As Boolean = False
      Select Case StatusID
        Case spmtDHStates.Created
          mRet = True
      End Select
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = True
      Try
        mRet = GetEditable()
        If mRet Then
          Dim DCHDL As List(Of SIS.SPMT.SPMTerpDCD) = SIS.SPMT.SPMTerpDCD.UZ_SPMTerpDCDSelectList(0, 99999, "", False, "", ChallanID)
          If DCHDL.Count > 0 Then
            mRet = False
          End If
        End If
      Catch ex As Exception
      End Try
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
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          mRet = GetEditable()
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
    Public ReadOnly Property ApproveWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          Select Case StatusID
            Case spmtDHStates.Issued
              mRet = True
          End Select
        Catch ex As Exception
        End Try
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
          If StatusID <> spmtDHStates.Created Then
            If Convert.ToBoolean(HttpContext.Current.Session("IsAdmin")) = True Then
              mRet = True
            End If
          End If
        Catch ex As Exception
        End Try
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
        Dim mRet As Boolean = False
        Try
          Select Case StatusID
            Case spmtDHStates.Received
              mRet = True
          End Select
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
    Public Shared Function InitiateWF(ByVal ChallanID As String) As SIS.SPMT.SPMTerpDCH
      Dim DCH As SIS.SPMT.SPMTerpDCH = SPMTerpDCHGetByID(ChallanID)
      With DCH
        .StatusID = spmtDHStates.Issued
        .CreatedBy = HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
      End With
      Dim DCHDL As List(Of SIS.SPMT.SPMTerpDCD) = SIS.SPMT.SPMTerpDCD.UZ_SPMTerpDCDSelectList(0, 99999, "", False, "", DCH.ChallanID)
      If DCHDL.Count <= 0 Then
        Throw New Exception("No Items in Delivery challan, cannot be Issued.")
      End If
      For Each dchd As SIS.SPMT.SPMTerpDCD In DCHDL
        Dim StockItem As New SIS.SPMT.SPMTerpDCInventory
        StockItem = SIS.SYS.Utilities.SessionManager.GetObj(dchd, StockItem)
        With StockItem
          .QuantityUsed = 0
          .BaseRate = dchd.FinalRate
          .ConsignerBPID = DCH.ConsigneeBPID
          .ConsignerGSTIN = DCH.ConsigneeGSTIN
          .ConsignerGSTINNo = DCH.ConsigneeGSTINNo
          .ConsignerIsgecID = DCH.ConsigneeIsgecID
          .ConsignerName = DCH.ConsigneeName
          .ConsignerStateID = DCH.ConsigneeStateID
          .ProjectID = DCH.ProjectID
        End With
        StockItem = SIS.SPMT.SPMTerpDCInventory.InsertData(StockItem)
        Select Case dchd.LineType
          Case spmtLineTypes.NewRecord
            dchd.LineType = spmtLineTypes.LockedNewRecord
          Case spmtLineTypes.DirectInventory
            dchd.LineType = spmtLineTypes.LockedDirectInventory
          Case spmtLineTypes.CompositInventory
            dchd.LineType = spmtLineTypes.LockedCompositInventory
        End Select
        dchd = SIS.SPMT.SPMTerpDCD.UpdateData(dchd)
      Next
      DCH = SIS.SPMT.SPMTerpDCH.UpdateData(DCH)
      Return DCH
    End Function
    Public Shared Function ApproveWF(ByVal ChallanID As String) As SIS.SPMT.SPMTerpDCH
      Dim Results As SIS.SPMT.SPMTerpDCH = SPMTerpDCHGetByID(ChallanID)
      Return Results
    End Function
    Public Shared Function RejectWF(ByVal ChallanID As String) As SIS.SPMT.SPMTerpDCH
      Dim DCH As SIS.SPMT.SPMTerpDCH = SPMTerpDCHGetByID(ChallanID)
      With DCH
        .StatusID = spmtDHStates.Created
        .CreatedBy = HttpContext.Current.Session("LoginID")
        .CreatedOn = Now
      End With
      Dim StockItems As List(Of SIS.SPMT.SPMTerpDCInventory) = SIS.SPMT.SPMTerpDCInventory.GetChallanInventory(0, 99999, "", False, "", DCH.ChallanID)
      For Each sti As SIS.SPMT.SPMTerpDCInventory In StockItems
        If sti.QuantityUsed > 0 Then
          Throw New Exception("Issued Inventory Item is used, cannot revert.")
        End If
      Next
      For Each sti As SIS.SPMT.SPMTerpDCInventory In StockItems
        SIS.SPMT.SPMTerpDCInventory.SPMTerpDCInventoryDelete(sti)
      Next
      Dim DCHDL As List(Of SIS.SPMT.SPMTerpDCD) = SIS.SPMT.SPMTerpDCD.UZ_SPMTerpDCDSelectList(0, 99999, "", False, "", DCH.ChallanID)
      For Each dchd As SIS.SPMT.SPMTerpDCD In DCHDL
        Select Case dchd.LineType
          Case spmtLineTypes.LockedNewRecord
            dchd.LineType = spmtLineTypes.NewRecord
          Case spmtLineTypes.LockedDirectInventory
            dchd.LineType = spmtLineTypes.DirectInventory
          Case spmtLineTypes.LockedCompositInventory
            dchd.LineType = spmtLineTypes.CompositInventory
        End Select
        dchd = SIS.SPMT.SPMTerpDCD.UpdateData(dchd)
      Next
      DCH = SIS.SPMT.SPMTerpDCH.UpdateData(DCH)
      Return DCH
    End Function
    Public Shared Function CompleteWF(ByVal ChallanID As String) As SIS.SPMT.SPMTerpDCH
      Dim Results As SIS.SPMT.SPMTerpDCH = SPMTerpDCHGetByID(ChallanID)
      Return Results
    End Function
    Public Shared Function UZ_SPMTerpDCHSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.SPMTerpDCH)
      Dim Results As List(Of SIS.SPMT.SPMTerpDCH) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "ChallanID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_SPMTerpDCHSelectListSearch"
            Cmd.CommandText = "spSPMTerpDCHSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_SPMTerpDCHSelectListFilteres"
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
    Public Shared Function UZ_SPMTerpDCHInsert(ByVal Record As SIS.SPMT.SPMTerpDCH) As SIS.SPMT.SPMTerpDCH
      Dim DCNo As String = SIS.SPMT.spmtDCLastNumber.GetNextDCNo(Record.DCType, Record.FK_SPMT_erpDCH_IssuerID.Description)
      Record.ChallanID = DCNo
      Dim _Result As SIS.SPMT.SPMTerpDCH = SPMTerpDCHInsert(Record)
      Return _Result
    End Function
    Public Shared Function ImportDC(ByVal ChallanID As String, ByVal Comp As String) As String
      Dim mRet As String = ""
      Dim tmp As SIS.SPMT.SPMTerpDCH = SIS.SPMT.SPMTerpDCH.SPMTerpDCHGetByID(ChallanID)
      If tmp Is Nothing Then
        tmp = SIS.SPMT.SPMTerpDCH.erpDCHGetFromERP(ChallanID, Comp)
        '====================

        tmp.CreatedBy = HttpContext.Current.Session("LoginID")
        tmp.StatusID = spmtDHStates.Created
        '====================
        Dim oVar As SIS.SPMT.spmtBusinessPartner = Nothing
        '1.
        If tmp.ConsigneeBPID <> "" Then
          oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(tmp.ConsigneeBPID)
          'If oVar Is Nothing Then
          Try
            SIS.SPMT.spmtSupplierBill.GetBPFromERP(tmp.ConsigneeBPID, Comp)
          Catch ex As Exception
          End Try
          'End If
        End If
        '2.
        If tmp.ConsignerBPID <> "" Then
          oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(tmp.ConsignerBPID)
          'If oVar Is Nothing Then
          Try
            SIS.SPMT.spmtSupplierBill.GetBPFromERP(tmp.ConsignerBPID, Comp)
          Catch ex As Exception
          End Try
          'End If
        End If
        '3.
        If tmp.ProjectID <> "" Then
          Try
            SIS.COM.comProjects.GetProjectFromERP(tmp.ProjectID, Comp)
          Catch ex As Exception
          End Try
        End If
        '4.
        If tmp.TransporterID <> "" Then
          oVar = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(tmp.TransporterID)
          'If oVar Is Nothing Then
          Try
            SIS.SPMT.spmtSupplierBill.GetBPFromERP(tmp.TransporterID, Comp)
          Catch ex As Exception
          End Try
          'End If
        End If
        '5. Misc
        tmp.ConsigneeStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.ConsigneeStateID)
        tmp.ConsignerStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.ConsignerStateID)
        'tmp.DestinationStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.DestinationStateID)
        tmp.PlaceOfDelivery = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.PlaceOfDelivery)
        tmp.PlaceOfSupply = SIS.SPMT.spmtERPStates.spmtERPStatesGetIDByCode(tmp.PlaceOfSupply)
        tmp.ConsigneeGSTIN = SIS.SPMT.spmtBPGSTIN.spmtGSTINByDescription(tmp.ConsigneeBPID, tmp.ConsigneeGSTIN)
        Try
          tmp.ConsignerGSTIN = SIS.SPMT.spmtBPGSTIN.spmtGSTINByDescription(tmp.ConsignerBPID, tmp.ConsignerGSTIN)
        Catch ex As Exception
          tmp.ConsignerGSTIN = ""
        End Try
        '6. Insert Challan
        SIS.SPMT.SPMTerpDCH.InsertData(tmp)
        'Try
        'Catch ex As Exception
        '  mRet = ex.Message
        'End Try
      End If
      Return mRet
    End Function
    Public Shared Function erpDCHGetFromERP(ByVal ChallanID As String, ByVal Comp As String) As SIS.SPMT.SPMTerpDCH
      If Comp = "" Then Comp = "200"

      Dim Results As New SIS.SPMT.SPMTerpDCH
      Dim Sql As String = ""
      Sql &= " select top 1  "
      Sql &= "   dch.t_dech as ChallanID "
      Sql &= "  ,dch.t_date as ChallanDate "
      Sql &= "  ,dch.t_proj as ProjectID "
      Sql &= "  ,dch.t_crby as CreatedBy "
      Sql &= "  ,dch.t_crdt as CreatedOn "
      Sql &= "  ,tdisg029.t_dsca as Purpose "
      Sql &= "  ,dch.t_remk as Remarks "
      Sql &= "  ,dateadd(n,330,dch.t_edat) as ExpectedReturnDate "
      Sql &= "  ,dch.t_divs as ERPUnitID "
      Sql &= "  ,dcl.t_srpo as PONo "
      Sql &= "  ,dcl.t_srpo as ConsignerPO "
      Sql &= "  ,dcl.t_foco as ConsigneePO "
      Sql &= "  ,cr_tdpur400.t_otbp as ConsignerBPID "
      Sql &= "  ,ce_tdpur400.t_otbp as ConsigneeBPID "
      Sql &= "  ,cr_tccom100.t_nama as ConsignerName "
      Sql &= "  ,cr_tctax400.t_fovn as ConsignerGSTIN "
      Sql &= "  ,cr_tccom130.t_namc as ConsignerAddress1line "
      Sql &= "  ,cr_tccom130.t_namd as ConsignerAddress2line "
      Sql &= "  ,cr_tccom130.t_namf as ConsignerAddress3line "
      Sql &= "  ,cr_tccom130.t_cste as ConsignerStateID "
      Sql &= "  ,cr_tcmcs143.t_dsca as ConsignerStateName "
      Sql &= "  ,ce_tccom100.t_nama as ConsigneeName "
      Sql &= "  ,ce_tctax400.t_fovn as ConsigneeGSTIN "
      Sql &= "  ,ce_tccom130.t_namc as ConsigneeAddress1line "
      Sql &= "  ,ce_tccom130.t_namd as ConsigneeAddress2line "
      Sql &= "  ,ce_tccom130.t_namf as ConsigneeAddress3line "
      Sql &= "  ,ce_tccom130.t_cste as ConsigneeStateID "
      Sql &= "  ,ce_tcmcs143.t_dsca as ConsigneeStateName "
      Sql &= "  ,tfacp100.t_ninv as IRNumber "
      Sql &= "  ,tfacp100.t_cdf_irdt as IRDate "
      Sql &= "  ,tfacp100.t_isup as SupplierBill "
      Sql &= "  ,tfacp100.t_invd as SupplierBillDate "
      Sql &= "  ,ps_tcmcs143.t_cste as PlaceOfSupply "
      Sql &= "  ,ps_tcmcs143.t_dsca as PlaceOfSupplyName "
      Sql &= "  ,pd_tcmcs143.t_cste as PlaceOfDelivery "
      Sql &= "  ,pd_tcmcs143.t_dsca as PlaceOfDeliveryName "
      Sql &= "  ,(case pd_tfisg003.t_tmod when 1 then 4 when 2 then 1 when 3 then 2 when 4 then 3 when 5 then 5 else 6 end) As ModeOfTransportID "
      Sql &= "  ,pd_tfisg003.t_bpid as TransporterID "
      Sql &= "  ,tr_tccom100.t_nama as ERPTransporterName "
      Sql &= "  ,pd_tfisg003.t_bpnm as TransporterName "
      Sql &= "  ,pd_tfisg003.t_vhno as VehicleNo "
      Sql &= "  ,pd_tfisg003.t_grno as GRNo "
      Sql &= "  ,pd_tfisg003.t_grdt as GRDate "
      Sql &= "  ,ltrim(fp_tccom139.t_dsca)+' ('+ pd_tfisg003.t_plcf+')' as FromPlace "
      Sql &= "  ,ltrim(tp_tccom139.t_dsca)+' ('+ pd_tfisg003.t_plct+')' as ToPlace "
      Sql &= "  from ttdisg026" & Comp & " as dch  "
      Sql &= "  inner join ttdisg027200 as dcl on dch.t_dech=dcl.t_dech "
      Sql &= "  /*Pick IR No and Date*/ "
      Sql &= "  left outer join twhinh310" & Comp & " as whinh310 on dcl.t_rcno=whinh310.t_rcno "
      Sql &= "  left outer join ttfacp100" & Comp & " as tfacp100 on convert(int,whinh310.t_dino)=tfacp100.t_ninv "
      Sql &= "  /*Pick Consigner/Consignee ID*/ "
      Sql &= "  left outer join ttdpur400" & Comp & " as cr_tdpur400 on dcl.t_srpo=cr_tdpur400.t_orno "
      Sql &= "  left outer join ttdpur400" & Comp & " as ce_tdpur400 on dcl.t_foco=ce_tdpur400.t_orno "
      Sql &= "  /*Pick Consigner Name*/ "
      Sql &= "  left outer join ttccom100" & Comp & " as cr_tccom100 on cr_tdpur400.t_otbp=cr_tccom100.t_bpid "
      Sql &= "  /*Pick Consigner GST*/ "
      Sql &= "  left outer join ttfisg405" & Comp & " as cr_tfisg405 on tfacp100.t_ninv=cr_tfisg405.t_ninv "
      Sql &= "  left outer join ttctax400" & Comp & " as cr_tctax400 on cr_tdpur400.t_otbp=cr_tctax400.t_bpid and cr_tfisg405.t_gstn_b=cr_tctax400.t_seqn_l "
      Sql &= "  /*Pick Consigner Address*/ "
      Sql &= "  left outer join ttccom130" & Comp & " as cr_tccom130 on cr_tctax400.t_cadr_l=cr_tccom130.t_cadr "
      Sql &= "  /*Pick Consigner State*/ "
      Sql &= "  left outer join ttcmcs143" & Comp & " as cr_tcmcs143 on cr_tccom130.t_cste=cr_tcmcs143.t_cste "
      Sql &= "  /*Pick Consignee Name*/ "
      Sql &= "  left outer join ttccom100" & Comp & " as ce_tccom100 on ce_tdpur400.t_otbp=ce_tccom100.t_bpid "
      Sql &= "  /*Pick Consignee GST*/ "
      Sql &= "  left outer join ttdpur401" & Comp & " as ce_tdpur401 on ce_tdpur400.t_orno=ce_tdpur401.t_orno "
      Sql &= "  left outer join ttctax400" & Comp & " as ce_tctax400 on ce_tdpur400.t_otbp=ce_tctax400.t_bpid and ce_tdpur401.t_rnsb_l=ce_tctax400.t_seqn_l "
      Sql &= "  /*Pick Consigner Address*/ "
      Sql &= "  left outer join ttccom130" & Comp & " as ce_tccom130 on ce_tctax400.t_cadr_l=ce_tccom130.t_cadr "
      Sql &= "  /*Pick Consigner State*/ "
      Sql &= "  left outer join ttcmcs143" & Comp & " as ce_tcmcs143 on ce_tccom130.t_cste=ce_tcmcs143.t_cste "
      Sql &= "  /*Pick State of Supply [From Supplier Bill] and Delivery*/ "
      Sql &= "  left outer join ttcmcs143" & Comp & " as ps_tcmcs143 on cr_tfisg405.t_posu=ps_tcmcs143.t_cdf_scod "
      Sql &= "  left outer join ttfisg003" & Comp & " as pd_tfisg003 on tfacp100.t_ninv=pd_tfisg003.t_irno  "
      Sql &= "  left outer join ttcmcs143" & Comp & " as pd_tcmcs143 on pd_tfisg003.t_plct=pd_tcmcs143.t_cste "
      Sql &= "  /*Pick Transporter Name*/ "
      Sql &= "  left outer join ttccom100" & Comp & " as tr_tccom100 on pd_tfisg003.t_bpid=tr_tccom100.t_bpid "
      Sql &= "  /*Pick FromPlace*/ "
      Sql &= "  left outer join ttccom139" & Comp & " as fp_tccom139 on pd_tfisg003.t_citf=fp_tccom139.t_city "
      Sql &= "  /*Pick ToPlace*/ "
      Sql &= "  left outer join ttccom139" & Comp & " as tp_tccom139 on pd_tfisg003.t_citt=tp_tccom139.t_city "
      Sql &= "  /*Pick Purpose*/ "
      Sql &= "  left outer join ttdisg029" & Comp & " as tdisg029 on dch.t_purp=tdisg029.t_code "
      Sql &= "  Where dch.t_dech='" & ChallanID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results = New SIS.SPMT.SPMTerpDCH(Reader)
            With Results
              .DCType = "S"
              'Issuer is Fixed 
              'What if REDECAM ????
              Select Case Comp
                Case "200", "700"
                  .UnitID = "ISGEC."
                  .IssuerID = 15
                  .IssuerCompanyName = "ISGEC Heavy Engineering Limited"
                  .IssuerAddress1Line = "A-4, Sector 24, Noida, Uttar Pradesh"
                  .IssuerAddress2Line = ""
                  .IssuerPAN = "AAACT5540K"
                  .IssuerCIN = "L23423HR1933 PLC000097"
              End Select
            End With
          End While
          Reader.Close()
        End Using
      End Using
      Dim IsgecGSTIN As String = ""
      Sql = ""
      Sql &= " select distinct isnull(ttctax940" & Comp & ".t_regn,'') "
      Sql &= " from ttdisg027" & Comp & ", twhinh312" & Comp & ", ttdpur401" & Comp & ", ttctax940" & Comp & " "
      Sql &= " where ttdisg027" & Comp & ".t_rcno = twhinh312" & Comp & ".t_rcno "
      Sql &= " and twhinh312" & Comp & ".t_orno = ttdpur401" & Comp & ".t_orno "
      Sql &= " and ttdpur401" & Comp & ".t_rnso_l = ttctax940" & Comp & ".t_seqn "
      Sql &= " and t_dech = '" & ChallanID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          IsgecGSTIN = Cmd.ExecuteScalar
        End Using
      End Using
      If IsgecGSTIN <> "" Then
        Dim tmpISG As SIS.SPMT.spmtIsgecGSTIN = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByGSTIN(IsgecGSTIN)
        With Results
          .DCType = "S"
          .UnitID = "ISGEC."
          .IssuerID = tmpISG.GSTID
          .IssuerCompanyName = tmpISG.CompanyName
          .IssuerAddress1Line = tmpISG.Address1Line
          .IssuerAddress2Line = tmpISG.Address2Line
          'PAN and CIN is same for all ISGEC REgs.
          '.IssuerPAN = tmpISG.PAN
          '.IssuerCIN = tmpISG.CIN
        End With
      End If
      Return Results
    End Function
    ' select top 1 
    '   dch.t_dech as ChallanID
    '  ,dch.t_date as ChallanDate
    '  ,dch.t_proj as ProjectID
    '  ,dch.t_crby as CreatedBy
    '  ,dch.t_crdt as CreatedOn
    '  ,dch.t_purp as Purpose
    '  ,dch.t_remk as Remarks
    '  ,dch.t_edat as ExpectedReturnDate
    '  ,dch.t_divs as ERPUnitID
    '  ,'15' as IsgecGSTIN
    '  ,'ISGEC Heavy Engineering Limited' as IssuerCompanyName
    '  ,'A-4, Sector 24, Noida, Uttar Pradesh' as IssuerAddress1Line
    '  ,'' as IssuerAddress2Line
    '  ,'AAACT5540K' as IssuerPAN 
    '  ,'L23423HR1933 PLC000097' as IssuerCIN
    '  ,dcl.t_srpo as PONo
    '  ,dcl.t_srpo as ConsignerPO
    '  ,dcl.t_foco as ConsigneePO
    '  ,cr_tdpur400.t_otbp as ConsignerBPID
    '  ,ce_tdpur400.t_otbp as ConsigneeBPID
    '  ,cr_tccom100.t_nama as ConsignerName
    '  ,cr_tctax400.t_fovn as ConsignerGSTIN
    '  ,cr_tccom130.t_namc as ConsignerAddress1line
    '  ,cr_tccom130.t_namd as ConsignerAddress2line
    '  ,cr_tccom130.t_namf as ConsignerAddress3line
    '  ,cr_tccom130.t_cste as ConsignerStateID
    '  ,cr_tcmcs143.t_dsca as ConsignerStateName
    '  ,ce_tccom100.t_nama as ConsigneeName
    '  ,ce_tctax400.t_fovn as ConsigneeGSTIN
    '  ,ce_tccom130.t_namc as ConsigneeAddress1line
    '  ,ce_tccom130.t_namd as ConsigneeAddress2line
    '  ,ce_tccom130.t_namf as ConsigneeAddress3line
    '  ,ce_tccom130.t_cste as ConsigneeStateID
    '  ,ce_tcmcs143.t_dsca as ConsigneeStateName
    '  ,tfacp100.t_ninv as IRNumber
    '  ,tfacp100.t_cdf_irdt as IRDate
    '  ,tfacp100.t_isup as SupplierBill
    '  ,tfacp100.t_invd as SupplierBillDate
    '  ,ps_tcmcs143.t_cste as PlaceOfSupply
    '  ,ps_tcmcs143.t_dsca as PlaceOfSupplyName
    '  ,pd_tcmcs143.t_cste as PlaceOfDelivery
    '  ,pd_tcmcs143.t_dsca as PlaceOfDeliveryName
    '  from ttdisg026200 as dch 
    '  inner join ttdisg027200 as dcl on dch.t_dech=dcl.t_dech
    '  /*Pick IR No and Date*/
    '  left outer join twhinh310200 as whinh310 on dcl.t_rcno=whinh310.t_rcno
    '  left outer join ttfacp100200 as tfacp100 on convert(int,whinh310.t_dino)=tfacp100.t_ninv
    '  /*Pick Consigner/Consignee ID*/
    '  left outer join ttdpur400200 as cr_tdpur400 on dcl.t_srpo=cr_tdpur400.t_orno
    '  left outer join ttdpur400200 as ce_tdpur400 on dcl.t_foco=ce_tdpur400.t_orno
    '  /*Pick Consigner Name*/
    '  left outer join ttccom100200 as cr_tccom100 on cr_tdpur400.t_otbp=cr_tccom100.t_bpid
    '  /*Pick Consigner GST*/
    '  left outer join ttfisg405200 as cr_tfisg405 on tfacp100.t_ninv=cr_tfisg405.t_ninv
    '  left outer join ttctax400200 as cr_tctax400 on cr_tdpur400.t_otbp=cr_tctax400.t_bpid and cr_tfisg405.t_gstn_b=cr_tctax400.t_seqn_l
    '  /*Pick Consigner Address*/
    '  left outer join ttccom130200 as cr_tccom130 on cr_tctax400.t_cadr_l=cr_tccom130.t_cadr
    '  /*Pick Consigner State*/
    '  left outer join ttcmcs143200 as cr_tcmcs143 on cr_tccom130.t_cste=cr_tcmcs143.t_cste
    '  /*Pick Consignee Name*/
    '  left outer join ttccom100200 as ce_tccom100 on ce_tdpur400.t_otbp=ce_tccom100.t_bpid
    '  /*Pick Consignee GST*/
    '  left outer join ttdpur401200 as ce_tdpur401 on ce_tdpur400.t_orno=ce_tdpur401.t_orno
    '  left outer join ttctax400200 as ce_tctax400 on ce_tdpur400.t_otbp=ce_tctax400.t_bpid and ce_tdpur401.t_rnsb_l=ce_tctax400.t_seqn_l
    '  /*Pick Consigner Address*/
    '  left outer join ttccom130200 as ce_tccom130 on ce_tctax400.t_cadr_l=ce_tccom130.t_cadr
    '  /*Pick Consigner State*/
    '  left outer join ttcmcs143200 as ce_tcmcs143 on ce_tccom130.t_cste=ce_tcmcs143.t_cste
    '  /*Pick State of Supply [From Supplier Bill] and Delivery*/
    '  left outer join ttcmcs143200 as ps_tcmcs143 on cr_tfisg405.t_posu=ps_tcmcs143.t_cdf_scod
    '  left outer join ttfisg003200 as pd_tfisg003 on tfacp100.t_ninv=pd_tfisg003.t_irno 
    '  left outer join ttcmcs143200 as pd_tcmcs143 on pd_tfisg003.t_plct=pd_tcmcs143.t_cste

    Public Shared Function UZ_SPMTerpDCHUpdate(ByVal Record As SIS.SPMT.SPMTerpDCH) As SIS.SPMT.SPMTerpDCH
      Dim _Result As SIS.SPMT.SPMTerpDCH = SPMTerpDCHUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_SPMTerpDCHDelete(ByVal Record As SIS.SPMT.SPMTerpDCH) As Integer
      Dim _Result As Integer = SPMTerpDCHDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_ChallanDate"), TextBox).Text = ""
          CType(.FindControl("F_ChallanID"), TextBox).Text = ""
          CType(.FindControl("F_CreatedBy"), TextBox).Text = ""
          CType(.FindControl("F_CreatedBy_Display"), Label).Text = ""
          CType(.FindControl("F_CreatedOn"), TextBox).Text = ""
          CType(.FindControl("F_StatusID"), Object).SelectedValue = ""
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
          CType(.FindControl("F_ConsigneeIsgecID"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsigneeBPID"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeBPID_Display"), Label).Text = ""
          CType(.FindControl("F_ConsigneeGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_ConsigneeName"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeGSTINNo"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeAddress1Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeAddress2Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsigneeStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsignerIsgecID"), Object).SelectedValue = ""
          CType(.FindControl("F_ConsignerBPID"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerBPID_Display"), Label).Text = ""
          CType(.FindControl("F_ConsignerGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_ConsignerName"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerGSTINNo"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerAddress1Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerAddress2Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_ConsignerStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_Purpose"), TextBox).Text = ""
          CType(.FindControl("F_ExpectedReturnDate"), TextBox).Text = ""
          CType(.FindControl("F_TotalAmount"), TextBox).Text = 0
          CType(.FindControl("F_TotalAmountInWords"), TextBox).Text = ""
          CType(.FindControl("F_ModeOfTransportID"), Object).SelectedValue = ""
          CType(.FindControl("F_VehicleNo"), TextBox).Text = ""
          CType(.FindControl("F_GRNo"), TextBox).Text = ""
          CType(.FindControl("F_GRDate"), TextBox).Text = ""
          CType(.FindControl("F_TransporterID"), TextBox).Text = ""
          CType(.FindControl("F_TransporterID_Display"), Label).Text = ""
          CType(.FindControl("F_TransporterName"), TextBox).Text = ""
          CType(.FindControl("F_FromPlace"), TextBox).Text = ""
          CType(.FindControl("F_ToPlace"), TextBox).Text = ""
          CType(.FindControl("F_Declaration1Line"), TextBox).Text = ""
          CType(.FindControl("F_Declaration2Line"), TextBox).Text = ""
          CType(.FindControl("F_Declaration3Line"), TextBox).Text = ""
          CType(.FindControl("F_Declaration4Line"), TextBox).Text = ""
          CType(.FindControl("F_LinkedChallanID"), TextBox).Text = ""
          CType(.FindControl("F_LinkedChallanID_Display"), Label).Text = ""
          CType(.FindControl("F_DestinationIsgecID"), Object).SelectedValue = ""
          CType(.FindControl("F_DestinationBPID"), TextBox).Text = ""
          CType(.FindControl("F_DestinationBPID_Display"), Label).Text = ""
          CType(.FindControl("F_DestinationGSTIN"), TextBox).Text = ""
          CType(.FindControl("F_DestinationGSTIN_Display"), Label).Text = ""
          CType(.FindControl("F_DestinationName"), TextBox).Text = ""
          CType(.FindControl("F_DestinationGSTINNo"), TextBox).Text = ""
          CType(.FindControl("F_DestinationAddress1Line"), TextBox).Text = ""
          CType(.FindControl("F_DestinationAddress2Line"), TextBox).Text = ""
          CType(.FindControl("F_DestinationAddress3Line"), TextBox).Text = ""
          CType(.FindControl("F_DestinationStateID"), Object).SelectedValue = ""
          CType(.FindControl("F_ReceivedDate"), TextBox).Text = ""
          CType(.FindControl("F_ReceivedRemarks"), TextBox).Text = ""
          CType(.FindControl("F_ReceivedOn"), TextBox).Text = ""
          CType(.FindControl("F_ReceivedBy"), TextBox).Text = ""
          CType(.FindControl("F_ReceivedBy_Display"), Label).Text = ""
          CType(.FindControl("F_ClosureRemarks"), TextBox).Text = ""
          CType(.FindControl("F_ClosureDate"), TextBox).Text = ""
          CType(.FindControl("F_ClosedBy"), TextBox).Text = ""
          CType(.FindControl("F_ClosedBy_Display"), Label).Text = ""
          CType(.FindControl("F_ClosedOn"), TextBox).Text = ""
          CType(.FindControl("F_IsgecInvoiceNo"), TextBox).Text = ""
          CType(.FindControl("F_IsgecInvoiceDate"), TextBox).Text = ""
          CType(.FindControl("F_t_rcno"), TextBox).Text = ""
          CType(.FindControl("F_t_srpo"), TextBox).Text = ""
          CType(.FindControl("F_t_srpl"), TextBox).Text = 0
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
