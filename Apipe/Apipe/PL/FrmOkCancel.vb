Public Class FrmOkCancel

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

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Return
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Return
    End Sub
End Class