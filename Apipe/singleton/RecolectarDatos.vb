Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class RecolectarDatos

    Private Shared datos As RecolectarDatos

    Private Sub New()
    End Sub

    Public Shared Function Instance() As RecolectarDatos

        If datos Is Nothing Then
            datos = New RecolectarDatos()
        End If

        Return datos

    End Function

    Public Property NroTel() As String
        Get
            Return m_NroTel
        End Get
        Set(ByVal value As String)
            m_NroTel = value
        End Set
    End Property
    Private m_NroTel As String

    Public Property Cliente() As Integer
        Get
            Return m_Cliente
        End Get
        Set(ByVal value As Integer)
            m_Cliente = value
        End Set
    End Property
    Private m_Cliente As Integer

    Public Property Domicilio() As Integer
        Get
            Return m_Domicilio
        End Get
        Set(ByVal value As Integer)
            m_Domicilio = value
        End Set
    End Property
    Private m_Domicilio As Integer

    Public Property TelefonoId() As Integer
        Get
            Return m_TelefonoId
        End Get
        Set(ByVal value As Integer)
            m_TelefonoId = value
        End Set
    End Property
    Private m_TelefonoId As Integer

    Public Property Dato5() As Integer
        Get
            Return m_Dato5
        End Get
        Set(ByVal value As Integer)
            m_Dato5 = Value
        End Set
    End Property
    Private m_Dato5 As Integer

End Class
