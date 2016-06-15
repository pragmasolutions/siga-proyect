Partial Public Class formulario
    Public ReadOnly Property v_nombre_form As String
        Get
            If Me.detalle.Length > 0 Then
                Return Me.detalle
            Else
                Return Me.nombre_form
            End If
        End Get
    End Property
End Class
