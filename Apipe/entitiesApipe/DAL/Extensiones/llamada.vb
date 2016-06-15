Imports MySql.Data.MySqlClient
Public Class llamada
#Region "Miembros"
    Private _id As Integer
    Private _fechahora As DateTime
    Private _telefono_id As Integer
    Private _usuario_id As Integer
    Private _numero As String

    'Definicion de Entidades

    Private _Telefono As telefono
    Private _Usuario As usuario
#End Region

#Region "Propiedades"
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property fechaHora() As DateTime
        Get
            Return _fechahora
        End Get
        Set(ByVal value As DateTime)
            _fechahora = value
        End Set
    End Property

    Public Property telefono_id() As Integer
        Get
            Return _telefono_id
        End Get
        Set(ByVal value As Integer)
            _telefono_id = value
        End Set
    End Property

    Public Property usuario_id() As Integer
        Get
            Return _usuario_id
        End Get
        Set(ByVal value As Integer)
            _usuario_id = value
        End Set
    End Property

    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    'Encapsulamiento de Entidades
    Public Property Telefono As telefono
        Get
            If Me._Telefono Is Nothing Then
                _Telefono = New telefono
                If Me.telefono_id > 0 Then
                    _Telefono.FillById(Me._telefono_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Telefono
        End Get
        Set(ByVal Value As telefono)
            _Telefono = Value
        End Set
    End Property

    Public Property Usuario As usuario
        Get
            If Me._Usuario Is Nothing Then
                _Usuario = New usuario
                If Me.usuario_id > 0 Then
                    _Usuario.StoreFillByentidad(Me._usuario_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Usuario
        End Get
        Set(ByVal Value As usuario)
            _Usuario = Value
        End Set
    End Property
#End Region
End Class
