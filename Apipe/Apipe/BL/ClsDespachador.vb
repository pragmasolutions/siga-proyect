Public Class ClsDespachador
    Inherits ClsMain

    Private _contador As contador
    Public Property contador() As contador
        Get
            If _contador Is Nothing Then
                _contador = New contador
            End If
            Return _contador
        End Get
        Set(ByVal value As contador)
            _contador = value
        End Set
    End Property

    Public Sub FillUltimo()
        contador.FillUltimoContador(getConn)
    End Sub

    Public Sub NuevoContador(ByVal fechainicio As DateTime)
        contador.Nuevo(fechainicio, getConn)
    End Sub

    Public Sub ActualizarContador(ByVal id As Integer)
        contador.Actualizar(id,getConn)
    End Sub

     Public Sub CerrarContador(ByVal id As Integer)
        contador.Cerrar(id,getConn)
    End Sub
End Class
