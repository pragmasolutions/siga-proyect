Imports System.Windows.Forms

Public Class ClsSettings
    Private Shared _getSettings As ClsSettings
    Private _UserId As Integer
    Private _UserName As String
    Private _OpenForms As FormCollection
    Private _Forms_Permitidos As List(Of String)
    Public Property Forms_Permitidos As List(Of String)
        Get
            If _Forms_Permitidos Is Nothing Then
                _Forms_Permitidos = New List(Of String)
            End If
            Return _Forms_Permitidos
        End Get
        Set(ByVal value As List(Of String))
            _Forms_Permitidos = value
        End Set
    End Property

    Public Shared ReadOnly Property getSettings As ClsSettings
        Get
            If _getSettings Is Nothing Then
                _getSettings = New ClsSettings
            End If
            Return _getSettings
        End Get
    End Property
    Public Property OpenForms As FormCollection
        Get
            Return _OpenForms
        End Get
        Set(ByVal value As FormCollection)
            _OpenForms = value
        End Set
    End Property
End Class
