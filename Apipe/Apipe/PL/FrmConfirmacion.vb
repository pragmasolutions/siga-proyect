Public Class FrmConfirmacion

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
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Return
    End Sub
    Private Sub lklCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklCancelar.LinkClicked
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Return
    End Sub

    Private Sub FrmConfirmacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            lklConfirmar_LinkClicked(Nothing, Nothing)
        ElseIf e.KeyChar = Chr(Keys.Escape) Then
            lklCancelar_LinkClicked(Nothing, Nothing)
        End If
    End Sub

    Private Sub FrmConfirmacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lklConfirmar.Focus()
    End Sub

    Private Sub FrmConfirmacion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Enter Then
            lklConfirmar_LinkClicked(Nothing, Nothing)

        ElseIf e.KeyValue = Keys.Escape Then
            lklCancelar_LinkClicked(Nothing, Nothing)
        End If
    End Sub
End Class