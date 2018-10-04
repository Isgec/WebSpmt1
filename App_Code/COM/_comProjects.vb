Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.COM
  <DataObject()> _
  Partial Public Class comProjects
    Private Shared _RecordCount As Integer
    Private _ProjectID As String = ""
    Private _Description As String = ""

    Private _CustomerOrderReference As String = ""
    Private _ContactPerson As String = ""
    Private _EmailID As String = ""
    Private _ContactNo As String = ""
    Private _Address1 As String = ""
    Private _Address2 As String = ""
    Private _Address3 As String = ""
    Private _Address4 As String = ""
    Private _ToEMailID As String = ""
    Private _CCEmailID As String = ""
    Private _ProjectSiteEMailID As String = ""
    Private _ProjectSiteEMailPassword As String = ""
    Private _LastNumber As String = ""
    Private _LogisticCompany As String = ""
    Private _FinanceCompany As String = ""

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
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
        _ProjectID = value
      End Set
    End Property
    Public Property Description() As String
      Get
        Return _Description
      End Get
      Set(ByVal value As String)
        _Description = value
      End Set
    End Property
    Public Property CustomerOrderReference() As String
      Get
        Return _CustomerOrderReference
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _CustomerOrderReference = ""
        Else
          _CustomerOrderReference = value
        End If
      End Set
    End Property
    Public Property ContactPerson() As String
      Get
        Return _ContactPerson
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ContactPerson = ""
        Else
          _ContactPerson = value
        End If
      End Set
    End Property
    Public Property EmailID() As String
      Get
        Return _EmailID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _EmailID = ""
        Else
          _EmailID = value
        End If
      End Set
    End Property
    Public Property ContactNo() As String
      Get
        Return _ContactNo
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ContactNo = ""
        Else
          _ContactNo = value
        End If
      End Set
    End Property
    Public Property Address1() As String
      Get
        Return _Address1
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Address1 = ""
        Else
          _Address1 = value
        End If
      End Set
    End Property
    Public Property Address2() As String
      Get
        Return _Address2
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Address2 = ""
        Else
          _Address2 = value
        End If
      End Set
    End Property
    Public Property Address3() As String
      Get
        Return _Address3
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Address3 = ""
        Else
          _Address3 = value
        End If
      End Set
    End Property
    Public Property Address4() As String
      Get
        Return _Address4
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _Address4 = ""
        Else
          _Address4 = value
        End If
      End Set
    End Property
    Public Property ToEMailID() As String
      Get
        Return _ToEMailID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ToEMailID = ""
        Else
          _ToEMailID = value
        End If
      End Set
    End Property
    Public Property CCEmailID() As String
      Get
        Return _CCEmailID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _CCEmailID = ""
        Else
          _CCEmailID = value
        End If
      End Set
    End Property
    Public Property ProjectSiteEMailID() As String
      Get
        Return _ProjectSiteEMailID
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ProjectSiteEMailID = ""
        Else
          _ProjectSiteEMailID = value
        End If
      End Set
    End Property
    Public Property ProjectSiteEMailPassword() As String
      Get
        Return _ProjectSiteEMailPassword
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _ProjectSiteEMailPassword = ""
        Else
          _ProjectSiteEMailPassword = value
        End If
      End Set
    End Property
    Public Property LastNumber() As String
      Get
        Return _LastNumber
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _LastNumber = ""
        Else
          _LastNumber = value
        End If
      End Set
    End Property
    Public Property LogisticCompany() As String
      Get
        Return _LogisticCompany
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _LogisticCompany = ""
        Else
          _LogisticCompany = value
        End If
      End Set
    End Property
    Public Property FinanceCompany() As String
      Get
        Return _FinanceCompany
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _FinanceCompany = ""
        Else
          _FinanceCompany = value
        End If
      End Set
    End Property
    Public Property DisplayField() As String
      Get
        Return "" & _Description.ToString.PadRight(50, " ")
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Property PrimaryKey() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal orderBy As String) As List(Of SIS.COM.comProjects)
      Dim Results As List(Of SIS.COM.comProjects) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomProjectsSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, 10, HttpContext.Current.Session("FinanceCompany"))
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.COM.comProjects)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.COM.comProjects(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function GetNewRecord() As SIS.COM.comProjects
      Return New SIS.COM.comProjects()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function comProjectsGetByID(ByVal ProjectID As String) As SIS.COM.comProjects
      Return GetByID(ProjectID)
    End Function
    Public Shared Function GetByID(ByVal ProjectID As String) As SIS.COM.comProjects
      Dim Results As SIS.COM.comProjects = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spcomProjectsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,ProjectID.ToString.Length, ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, 10, HttpContext.Current.Session("FinanceCompany"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.COM.comProjects(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.COM.comProjects)
      Dim Results As List(Of SIS.COM.comProjects) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spcomProjectsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spcomProjectsSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, 10, HttpContext.Current.Session("FinanceCompany"))
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.COM.comProjects)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.COM.comProjects(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID 
    'Autocomplete Method
    Public Shared Function SelectcomProjectsAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spcomProjectsAutoCompleteList"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FinanceCompany", SqlDbType.NVarChar, 10, HttpContext.Current.Session("FinanceCompany"))
          Results = New List(Of String)()
          Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Not Reader.HasRows Then
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),""))
					End If
					While (Reader.Read())
            Dim Tmp As SIS.COM.comProjects = New SIS.COM.comProjects(Reader)
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
