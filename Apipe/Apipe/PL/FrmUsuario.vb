
Public Class FrmUsuario
#Region "Inicializar"
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.Usuario.EstadoFila = "N"
        Cls.NoFrmHijo = False
    End Sub
    Public Sub New(ByVal Usr As usuario)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.Usuario = Usr
        Cls.Usuario.entidad_id = Usr.entidad_id
        Cls.Usuario.EstadoFila_usuario = "U" 'GUARDAR SIN CONTRASEÑAS
        Cls.NoFrmHijo = False
    End Sub
    Public Sub New(ByVal ent As entidad)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.cargarEntidadEnUsuario(ent)
        Cls.NoFrmHijo = False

    End Sub
    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        bgsTelefono.DataSource = Cls.Usuario.lst_Telefono
        dgvTelefonos.DataSource = bgsTelefono
        bgsEmail.DataSource = Cls.Usuario.lst_Mail
        dgvEmails.DataSource = bgsEmail
        If Cls.Usuario.entidad_id > 0 Then
            CargarUsuario()
            CargarPass()
            Me.Text = "Modificar datos del Usuario " & Cls.Usuario.v_AyN
            btnSetearClave.Enabled = True
        Else
            Me.Text = "Nuevo Usuario"
        End If
        Me.txtApellido.Focus()
    End Sub
#End Region

#Region "Navegacion"
    Private Sub btnSetearClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetearClave.Click
        If MessageBox.Show("Esta seguro que desea resetear la clave??", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.OK Then
            Cls.Usuario.password = ("cambiame")
            MessageBox.Show("La clave para " & Cls.Usuario.usuario & " sera ""cambiame """, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "Busqueda"
    Private Sub txtNombre_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Cls.Usuario.EstadoFila = "N" Then
            If txtApellido.Text.Trim.Count > 2 Or txtNombre.Text.Trim.Count > 2 Or txtNroDoc.Text.Trim.Count > 2 Then
                Cls.BuscarEntidadesRelacionadas(IIf(txtApellido.Text.Length > 0, txtApellido.Text.Trim, ""), _
                                    IIf(txtNombre.Text.Length > 0, txtNombre.Text.Trim, ""), _
                                    IIf(txtNroDoc.Text.Length > 0, txtNroDoc.Text.Trim, 0), "usuario")
                If Cls.Usuario.EstadoFila = "U" Then
                    CargarUsuario()
                End If
            End If
        End If
    End Sub
    Private Sub txtNroDoc_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Cls.Usuario.EstadoFila = "N" And IsNumeric(txtNroDoc.Text) Then
            If txtApellido.Text.Trim.Count > 2 Or txtNombre.Text.Trim.Count > 2 Or txtNroDoc.Text.Trim.Count > 2 Then
                Cls.BuscarEntidadesRelacionadas(IIf(txtApellido.Text.Length > 0, txtApellido.Text.Trim, ""), _
                                    IIf(txtNombre.Text.Length > 0, txtNombre.Text.Trim, ""), _
                                    IIf(txtNroDoc.Text.Length > 0, CInt(txtNroDoc.Text.Trim), 0), "usuario")
                If Cls.Usuario.EstadoFila = "U" Then
                    CargarUsuario()
                End If
            End If
        End If
    End Sub
#End Region

#Region "Validacion"
    Private Sub txtClave_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If sender.Text.Length = 0 Then
            ErrorProvider1.SetError(sender, "Por favor ingrese un Valor")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
#End Region

#Region "Telefonos"
    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTel.Click
        Dim Dlg As New FrmTelefono(Cls.Usuario.entidad_id)
        With Dlg
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Cls.Usuario.lst_Telefono.Add(CType(.Tag, telefono))
                bgsTelefono.ResetBindings(False)
            End If
        End With
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarTel.Click
        If dgvTelefonos.CurrentRow IsNot Nothing Then
            Dim Dlg As New FrmTelefono(CType(bgsTelefono.Item(bgsTelefono.Position), telefono))
            With Dlg
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    bgsTelefono.ResetBindings(False)
                End If
            End With
        End If
    End Sub
    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTel.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar el telefono?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            With CType(bgsTelefono.Item(bgsTelefono.Position), telefono)
                .EstadoFila = "D"
                Cls.Usuario.lst_Telefono.Item(bgsTelefono.Position).EstadoFila = "D"
                Dim i As Integer = bgsTelefono.Position
                dgvTelefonos.DataSource.suspendbinding()
                dgvTelefonos.Rows(i).Visible = False
                dgvTelefonos.DataSource.resumebinding()
            End With
        End If
    End Sub
#End Region

#Region "Mail"
    Private Sub btnAgregarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMail.Click
        Dim Dlg As New FrmMail
        If Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cls.Usuario.lst_Mail.Add(Dlg.Tag)
            bgsEmail.DataSource = (From em As mail In Cls.Usuario.lst_Mail Where em.EstadoFila = "N").ToList
            bgsEmail.ResetBindings(False)
        End If
    End Sub
    Private Sub btnQuitarMaill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarMail.Click
        If dgvEmails.SelectedRows.Count = 1 Then
            Cls.Mail = MailSeleccionado()
            If Cls.Mail.id > 0 Then
                Cls.Mail.EstadoFila = "D"
                bgsEmail.DataSource = (From em As mail In Cls.Usuario.lst_Mail Where em.EstadoFila = "N").ToList
            Else
                Cls.Usuario.lst_Mail.Remove(MailSeleccionado)
            End If
            bgsEmail.ResetBindings(False)
        End If
    End Sub
#End Region

#Region "Usuario"
    Private Sub AceptarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.ValidateChildren() Then
            Cls.IniciarTrn()
            With Cls.Usuario
                .usuario = txtUsuario.Text
                .activo = chkUsuarioActivo.Checked
                If .password.Length = 0 Then
                    .password = ("cambiame")
                End If
                If txtCuil.Text <> "" Then .cuil = txtCuil.Text
                If cbxEstadoCivil.Text <> "" Then .estado_civil = cbxEstadoCivil.Text
                If txtNroDoc.Text <> "" Then .nro_documento = txtNroDoc.Text
                .apellido = txtApellido.Text
                .nombre = txtNombre.Text
                .sexo = cbxSexo.Text
                .tipo_documento = cbxTipoDoc.Text
                .observacion = txtObservaciones.Text
            End With
            Try
                If Cls.SaveUsuario() Then
                    MessageBox.Show("Los datos se actualizaron correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
                Cls.gettrn.Commit()
                Me.Close()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show("Erro en la actualización", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Private Sub CargarUsuario()
        With Cls.Usuario
            txtCuil.Text = .cuil
            txtApellido.Text = .apellido
            txtNombre.Text = .nombre
            cbxEstadoCivil.Text = .estado_civil
            cbxSexo.Text = .sexo
            dtpFechaNacimiento.Value = .fecha_nacimiento
            cbxTipoDoc.Text = .tipo_documento
            txtNroDoc.Text = .nro_documento
            txtObservaciones.Text = .observacion
            bgsEmail.DataSource = .lst_Mail
            dgvEmails.DataSource = bgsEmail
            bgsTelefono.DataSource = .lst_Telefono
            dgvTelefonos.DataSource = bgsTelefono
        End With
    End Sub
    Private Sub CargarPass()
        With Cls.Usuario
            txtUsuario.Text = .usuario
            chkUsuarioActivo.Checked = .activo
        End With
    End Sub
#End Region
End Class
