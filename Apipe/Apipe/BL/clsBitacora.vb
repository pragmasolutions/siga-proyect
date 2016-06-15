Public Class clsBitacora
    Inherits ClsMain

#Region "Propiedades"

    Private _bitacora As bitacora
    Public Property Bitacora() As bitacora
        Get
            If _bitacora Is Nothing Then
                _bitacora = New bitacora
            End If
            Return _bitacora
        End Get
        Set(ByVal value As bitacora)
            _bitacora = value
        End Set
    End Property

    Private _lstBitacora As List(Of bitacora)
    Public Property lstbitacora() As List(Of bitacora)
        Get
            If _lstBitacora Is Nothing Then
                _lstBitacora = New List(Of bitacora)
            End If
            Return _lstBitacora
        End Get
        Set(ByVal value As List(Of bitacora))
            _lstBitacora = value
        End Set
    End Property

    Private _operacion As Operacion
    Public Property Operacion() As Operacion
        Get
            If _operacion Is Nothing Then
                _operacion = New Operacion
            End If
            Return _operacion
        End Get
        Set(ByVal value As Operacion)
            _operacion = value
        End Set
    End Property

    Private _lstOperacion As List(Of Operacion)
    Public Property lstOperacion() As List(Of Operacion)
        Get
            If _lstOperacion Is Nothing Then
                _lstOperacion = New List(Of Operacion)
            End If
            Return _lstOperacion
        End Get
        Set(ByVal value As List(Of Operacion))
            _lstOperacion = value
        End Set
    End Property

    Private _pedidoBitacora As pedidoBitacora
    Public Property PedidoBitacora() As pedidoBitacora
        Get
            If _pedidoBitacora Is Nothing Then
                _pedidoBitacora = New pedidoBitacora
            End If
            Return _pedidoBitacora
        End Get
        Set(ByVal value As pedidoBitacora)
            _pedidoBitacora = value
        End Set
    End Property

    Private _lstPedidoBitacora As List(Of pedidoBitacora)
    Public Property LstPedidoBitacora() As List(Of pedidoBitacora)
        Get
            If _lstPedidoBitacora Is Nothing Then
                _lstPedidoBitacora = New List(Of pedidoBitacora)
            End If
            Return _lstPedidoBitacora
        End Get
        Set(ByVal value As List(Of pedidoBitacora))
            _lstPedidoBitacora = value
        End Set
    End Property

    Private _domicilioBitacora As domicilioBitacora
    Public Property DomicilioBitacora() As domicilioBitacora
        Get
            If _domicilioBitacora Is Nothing Then
                _domicilioBitacora = New domicilioBitacora
            End If
            Return _domicilioBitacora
        End Get
        Set(ByVal value As domicilioBitacora)
            _domicilioBitacora = value
        End Set
    End Property

    Private _lstDomicilioBitacora As List(Of domicilioBitacora)
    Public Property LstDomicilioBitacora() As List(Of domicilioBitacora)
        Get
            If _lstDomicilioBitacora Is Nothing Then
                _lstDomicilioBitacora = New List(Of domicilioBitacora)
            End If
            Return _lstDomicilioBitacora
        End Get
        Set(ByVal value As List(Of domicilioBitacora))
            _lstDomicilioBitacora = value
        End Set
    End Property
#End Region

#Region "Funciones"

    Public Sub InsertarBitacora()
        Bitacora.Insert(getConn, gettrn)
    End Sub

    Public Sub InsertarDomicilioBitacora()
        DomicilioBitacora.Insert(getConn, gettrn)
    End Sub

    Public Sub InsertarPedidoBitacora()
        PedidoBitacora.Insert(getConn, gettrn)
    End Sub

#End Region
End Class
