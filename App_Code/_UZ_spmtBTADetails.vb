Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtBTADetails
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
    Public Function GetDeleteable() As Boolean
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
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFVisible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
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
    Public Shared Function InitiateWF(ByVal SerialNo As Int32) As SIS.SPMT.spmtBTADetails
      Dim Results As SIS.SPMT.spmtBTADetails = spmtBTADetailsGetByID(SerialNo)
      Return Results
    End Function
    Public Shared Function UZ_spmtBTADetailsSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.spmtBTADetails)
      Dim Results As List(Of SIS.SPMT.spmtBTADetails) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_BTADetailsSelectListSearch"
            Cmd.CommandText = "spspmtBTADetailsSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_BTADetailsSelectListFilteres"
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
    Public Shared Function UZ_spmtBTADetailsInsert(ByVal Record As SIS.SPMT.spmtBTADetails) As SIS.SPMT.spmtBTADetails
      Dim _Result As SIS.SPMT.spmtBTADetails = spmtBTADetailsInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtBTADetailsUpdate(ByVal Record As SIS.SPMT.spmtBTADetails) As SIS.SPMT.spmtBTADetails
      Dim _Result As SIS.SPMT.spmtBTADetails = spmtBTADetailsUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtBTADetailsDelete(ByVal Record As SIS.SPMT.spmtBTADetails) As Integer
      Dim _Result as Integer = spmtBTADetailsDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
        CType(.FindControl("F_SerialNo"), TextBox).Text = ""
        CType(.FindControl("F_CORP_2"), TextBox).Text = ""
        CType(.FindControl("F_CORP_1"), TextBox).Text = ""
        CType(.FindControl("F_BTA_ACCT"), TextBox).Text = ""
        CType(.FindControl("F_STMT_DT"), TextBox).Text = ""
        CType(.FindControl("F_STMT_REF_NO"), TextBox).Text = ""
        CType(.FindControl("F_CUST_REF"), TextBox).Text = ""
        CType(.FindControl("F_TRIP_REQ"), TextBox).Text = ""
        CType(.FindControl("F_JOB_NO"), TextBox).Text = ""
        CType(.FindControl("F_PAX_NM"), TextBox).Text = ""
        CType(.FindControl("F_AMOUNT_EX_GST"), TextBox).Text = 0
        CType(.FindControl("F_GST"), TextBox).Text = 0
        CType(.FindControl("F_UNPAID_AMT"), TextBox).Text = 0
        CType(.FindControl("F_CHARGE_DTE"), TextBox).Text = ""
        CType(.FindControl("F_BKNG_DATE"), TextBox).Text = ""
        CType(.FindControl("F_DEPT_DATE"), TextBox).Text = ""
        CType(.FindControl("F_TICKET_NO"), TextBox).Text = ""
        CType(.FindControl("F_CARRIER"), TextBox).Text = ""
        CType(.FindControl("F_CLASS"), TextBox).Text = ""
        CType(.FindControl("F_DI"), TextBox).Text = ""
        CType(.FindControl("F_ROUTING"), TextBox).Text = ""
        CType(.FindControl("F_TXN_DATE"), TextBox).Text = ""
        CType(.FindControl("F_Merchant_ABN"), TextBox).Text = ""
        CType(.FindControl("F_Book_Ref"), TextBox).Text = ""
        CType(.FindControl("F_COMMENT1"), TextBox).Text = ""
        CType(.FindControl("F_COMMENT2"), TextBox).Text = ""
        CType(.FindControl("F_COMMENT3"), TextBox).Text = ""
        CType(.FindControl("F_MERCHANT_NAME"), TextBox).Text = ""
        CType(.FindControl("F_BatchNo"), TextBox).Text = 0
        CType(.FindControl("F_StatusID"), TextBox).Text = ""
        CType(.FindControl("F_StatusID_Display"), Label).Text = ""
        CType(.FindControl("F_CreatedBy"), TextBox).Text = ""
        CType(.FindControl("F_CreatedBy_Display"), Label).Text = ""
        CType(.FindControl("F_CreatedOn"), TextBox).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
