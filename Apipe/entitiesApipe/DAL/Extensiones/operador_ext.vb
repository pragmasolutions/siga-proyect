
Partial Public Class operador
#Region "Propiedades para la Vista"
    Public ReadOnly Property v_AyN As String
        Get
            If Me.entidad_id > 0 Then
                Return Me.Entidad.v_AyN
            End If
            Return ""
        End Get
    End Property
    Private _v_CantACompletar As Integer
    Public Property v_CantACompletar As Integer
        Get
            Return _v_CantACompletar
        End Get
        Set(ByVal value As Integer)
            _v_CantACompletar = value
        End Set
    End Property
#End Region

End Class
