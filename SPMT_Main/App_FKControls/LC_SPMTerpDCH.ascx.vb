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
Partial Class LC_SPMTerpDCH
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public ReadOnly Property LCClientID() As String
    Get
      Return DDLSPMTerpDCH.ClientID
    End Get
  End Property
  Public Property AddAttributes() As String
    Get
      Return DDLSPMTerpDCH.Attributes.ToString
    End Get
    Set(ByVal value As String)
      Try
        Dim aVal() As String = value.Split(",".ToCharArray)
        DDLSPMTerpDCH.Attributes.Add(aVal(0), aVal(1))
      Catch ex As Exception
      End Try
    End Set
  End Property
  Public Property CssClass() As String
    Get
      Return DDLSPMTerpDCH.CssClass
    End Get
    Set(ByVal value As String)
      DDLSPMTerpDCH.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLSPMTerpDCH.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLSPMTerpDCH.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorSPMTerpDCH.Text
    End Get
    Set(ByVal value As String)
      If value = String.Empty Then
        RequiredFieldValidatorSPMTerpDCH.Enabled = False
      Else
        RequiredFieldValidatorSPMTerpDCH.Text = value
      End If
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorSPMTerpDCH.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorSPMTerpDCH.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLSPMTerpDCH.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLSPMTerpDCH.Enabled = value
      RequiredFieldValidatorSPMTerpDCH.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLSPMTerpDCH.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLSPMTerpDCH.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLSPMTerpDCH.DataTextField
    End Get
    Set(ByVal value As String)
      DDLSPMTerpDCH.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLSPMTerpDCH.DataValueField
    End Get
    Set(ByVal value As String)
      DDLSPMTerpDCH.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLSPMTerpDCH.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLSPMTerpDCH.SelectedValue = String.Empty
      Else
        DDLSPMTerpDCH.SelectedValue = value
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
  Protected Sub OdsDdlSPMTerpDCH_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlSPMTerpDCH.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLSPMTerpDCH_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLSPMTerpDCH.DataBinding
    If _IncludeDefault Then
      DDLSPMTerpDCH.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLSPMTerpDCH_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLSPMTerpDCH.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class
