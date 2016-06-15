
Public Class FrmTelefono
    Dim Telefono As New telefono

    Public Sub New(ByVal idEntidad As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Telefono.entidad_id = idEntidad
        Telefono.EstadoFila = "N"
    End Sub
    Public Sub New(ByVal tel As telefono)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Telefono = tel
        Telefono.EstadoFila = "U"
    End Sub
    Private Sub BtoCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub BtoAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            With Telefono
                .cod_area = txtCodArea.Text
                .numero = txtNumero.Text
                .tipo = CbxTipo.Text
                .horario_manana = dtpHorarioMananaD.Text & " - " & dtpHorarioMananaH.Text
                .horario_tarde = dtpHorarioTardeD.Text & " - " & dtpHorarioTardeH.Text
                .observaciones = txtObservaciones.Text
            End With
            Me.Tag = Telefono
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmTelefono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtpHorarioMananaD.CustomFormat = "HH':'mm"
        If Telefono.EstadoFila = "N" Then
            dtpHorarioMananaD.Value = DateTime.Parse("8:00")
            dtpHorarioMananaH.Value = DateTime.Parse("12:00")
            dtpHorarioTardeD.Value = DateTime.Parse("16:00")
            dtpHorarioTardeH.Value = DateTime.Parse("20:00")
            CbxTipo.SelectedIndex = 0
        ElseIf Telefono.EstadoFila = "U" Then
            With Telefono
                txtCodArea.Text = .cod_area
                txtNumero.Text = .numero
                CbxTipo.Text = .tipo
                If .horario_manana <> "" Then
                    dtpHorarioMananaD.Value = DateTime.Parse(.horario_manana.Split("-")(0))
                    dtpHorarioMananaH.Value = DateTime.Parse(.horario_manana.Split("-")(1))
                Else
                    dtpHorarioMananaD.Value = DateTime.Parse("8:00")
                    dtpHorarioMananaH.Value = DateTime.Parse("12:00")
                End If
                If .horario_tarde <> "" Then
                    dtpHorarioTardeD.Value = DateTime.Parse(.horario_tarde.Split("-")(0))
                    dtpHorarioTardeH.Value = DateTime.Parse(.horario_tarde.Split("-")(1))
                Else
                    dtpHorarioTardeD.Value = DateTime.Parse("16:00")
                    dtpHorarioTardeH.Value = DateTime.Parse("20:00")
                End If
                txtObservaciones.Text = .observaciones
            End With
        End If
        Me.txtCodArea.Select()
    End Sub
    Private Sub txtCodArea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodArea.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.KeyChar = ""
        End If
    End Sub
End Class