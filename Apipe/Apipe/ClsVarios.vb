Public Class ClsVarios
    Inherits ClsMain
#Region "Objetos"
    Private _PedidoCategoria As pedido_categoria
    Public Property PedidoCategoria() As pedido_categoria
        Get
            If _PedidoCategoria Is Nothing Then
                _PedidoCategoria = New pedido_categoria
            End If
            Return _PedidoCategoria
        End Get
        Set(ByVal value As pedido_categoria)
            _PedidoCategoria = value
        End Set
    End Property
    Private _ReclamoCategoria As reclamo_categoria
    Public Property ReclamoCategoria() As reclamo_categoria
        Get
            If _ReclamoCategoria Is Nothing Then
                _ReclamoCategoria = New reclamo_categoria
            End If
            Return _ReclamoCategoria
        End Get
        Set(ByVal value As reclamo_categoria)
            _ReclamoCategoria = value
        End Set
    End Property
#End Region
#Region "Funciones"
    Public Function PreservarPedidoCategoria() As Boolean
        Try
            If PedidoCategoria.EstadoFila = "N" Then
                PedidoCategoria.Insert(getConn)
            ElseIf PedidoCategoria.EstadoFila = "U" Then
                PedidoCategoria.Update(getConn)
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function PreservarReclamoCategoria() As Boolean
        Try
            If ReclamoCategoria.EstadoFila = "N" Then
                ReclamoCategoria.Insert(getConn)
            ElseIf PedidoCategoria.EstadoFila = "U" Then
                ReclamoCategoria.Update(getConn)
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region


End Class
