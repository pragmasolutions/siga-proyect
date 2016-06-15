Public Class FrmErrorPermisos
    Public Sub New(ByVal nombreForm As String)
        InitializeComponent()
        If nombreForm.Trim.Length > 0 Then
            txtNombreFormulario.Text = "Formulario: " + nombreForm.Trim
        Else : txtNombreFormulario.Text = ""
        End If
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

End Class
