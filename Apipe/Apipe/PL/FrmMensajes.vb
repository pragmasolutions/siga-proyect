Public Class FrmMensajes

    Public Sub New(ByVal mensaje As String, Optional ByVal posicion As System.Drawing.Point = Nothing)
        InitializeComponent()
        lblMensaje.Text = mensaje
        If posicion <> Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            'Me.Location = posicion
            Dim izq As Integer = 0
            If Me.Parent IsNot Nothing Then izq = Me.Parent.Left
            Me.Left = IIf(izq > posicion.X - Me.Width, izq, posicion.X - Me.Width)
            Me.Top = posicion.Y
        Else
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
    End Sub
    Private Sub lklConfirmar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklConfirmar.LinkClicked
        'Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        Return
    End Sub
    Private Sub FrmConfirmacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            lklConfirmar_LinkClicked(Nothing, Nothing)
        End If
    End Sub
End Class