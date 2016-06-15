Public Class ClsStores
    Inherits ClsMain

#Region "Propiedades"
    Private _lstCalle As List(Of String)
    Public Property LstCalle() As List(Of String)
        Get
            Return _lstCalle
        End Get
        Set(ByVal value As List(Of String))
            _lstCalle = value
        End Set
    End Property

    Private _domiclio As domicilio
    Public Property Domicilio() As domicilio
        Get
            Return _domiclio
        End Get
        Set(ByVal value As domicilio)
            _domiclio = value
        End Set
    End Property

    Private _pedido As pedido
    Public Property Pedido() As pedido
        Get
            Return _pedido
        End Get
        Set(ByVal value As pedido)
            _pedido = value
        End Set
    End Property

#End Region
 
#Region "Métodos"
    Public Sub FillCalles()
        LstCalle = Domicilio.FillListCalles(getConn)
    End Sub

    Public Function StoreCorreccionCalle(ByVal aCorregir As String, ByVal Correccion As String) As Boolean
        If Domicilio.StoreCorreccionCalle(getConn, aCorregir, Correccion) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function StoreDomicilioZona(ByVal domicilio As Integer, zona As Integer)
        If Pedido.StoreDomicilioZona(getConn, domicilio, zona) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
End Class
