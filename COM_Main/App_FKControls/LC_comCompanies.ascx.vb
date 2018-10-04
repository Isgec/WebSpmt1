Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

<ValidationProperty("SelectedValue")> _
Partial Class LC_comCompanies
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public ReadOnly Property LCClientID() As String
    Get
      Return DDLcomCompanies.ClientID
    End Get
  End Property
  Public Property AddAttributes() As String
    Get
      Return DDLcomCompanies.Attributes.ToString
    End Get
    Set(ByVal value As String)
      Try
        Dim aVal() As String = value.Split(",".ToCharArray)
        DDLcomCompanies.Attributes.Add(aVal(0), aVal(1))
      Catch ex As Exception
      End Try
    End Set
  End Property
  Public Property CssClass() As String
    Get
      Return DDLcomCompanies.CssClass
    End Get
    Set(ByVal value As String)
      DDLcomCompanies.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLcomCompanies.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLcomCompanies.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorcomCompanies.Text
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorcomCompanies.Text = value
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorcomCompanies.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorcomCompanies.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLcomCompanies.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLcomCompanies.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLcomCompanies.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLcomCompanies.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLcomCompanies.DataTextField
    End Get
    Set(ByVal value As String)
      DDLcomCompanies.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLcomCompanies.DataValueField
    End Get
    Set(ByVal value As String)
      DDLcomCompanies.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLcomCompanies.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLcomCompanies.SelectedValue = String.Empty
      Else
        DDLcomCompanies.SelectedValue = value
      End If
    End Set
  End Property
  Public Property OrderBy() As String
    Get
      Return _OrderBy
    End Get
    Set(ByVal value As String)
      _OrderBy = value
    End Set
  End Property
  Public Property IncludeDefault() As Boolean
    Get
      Return _IncludeDefault
    End Get
    Set(ByVal value As Boolean)
      _IncludeDefault = value
    End Set
  End Property
  Public Property DefaultText() As String
    Get
      Return _DefaultText
    End Get
    Set(ByVal value As String)
      _DefaultText = value
    End Set
  End Property
  Public Property DefaultValue() As String
    Get
      Return _DefaultValue
    End Get
    Set(ByVal value As String)
      _DefaultValue = value
    End Set
  End Property
  Protected Sub OdsDdlcomCompanies_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlcomCompanies.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLcomCompanies_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLcomCompanies.DataBinding
    If _IncludeDefault Then
      DDLcomCompanies.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLcomCompanies_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLcomCompanies.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class
