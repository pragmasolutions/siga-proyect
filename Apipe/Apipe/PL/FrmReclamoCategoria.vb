Public Class FrmReclamoCategoria
    Dim Cls As New ClsVarios
    Private Sub FrmPedidoCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvCategorias.AutoGenerateColumns = False
        dgvCategorias.DataSource = ClsEnumerados.Instancia.lstReclamoCategoria
        pnlNombre.Enabled = False
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
    End Sub
    Private Sub dgvCategorias_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCategorias.SelectionChanged
        If dgvCategorias.SelectedRows.Count = 1 Then
            Cls.ReclamoCategoria = CType(dgvCategorias.CurrentRow.DataBoundItem, reclamo_categoria)
            txtNombre.Text = Cls.ReclamoCategoria.nombre
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Cls.ReclamoCategoria.EstadoFila = "N"
        pnlNombre.Enabled = True
        txtNombre.Text = ""
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnCancelar.Enabled = True
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Cls.ReclamoCategoria.EstadoFila = "U"
        pnlNombre.Enabled = True
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        pnlNombre.Enabled = False
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Cls.ReclamoCategoria.nombre = txtNombre.Text
        If Cls.PreservarReclamoCategoria Then
            pnlNombre.Enabled = False
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            MessageBox.Show("Los datos se actualizaron correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Ocurrio un error al intentar guardar en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.TextLength = 0 Then
            ErrorProvider1.SetError(txtNombre, "Ingrese el nombre")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(txtNombre, Nothing)
        End If
    End Sub
End Class