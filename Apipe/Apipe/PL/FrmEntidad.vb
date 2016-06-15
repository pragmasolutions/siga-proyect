Public Class FrmEntidad
    Protected bgsTelefono, bgsEmail As New BindingSource
    Protected Cls As New ClsEntidades

#Region "Inicializar"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByVal Enti As entidad)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.Entidad = Enti
    End Sub
    Private Sub FrmEntidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvTelefonos.AutoGenerateColumns = False
        dgvEmails.AutoGenerateColumns = False

        cbxTipoDoc.DataSource = ClsEnumerados.Instancia.lst_Tipo_Doc
        cbxSexo.DataSource = ClsEnumerados.Instancia.lst_Sexo
        cbxEstadoCivil.DataSource = ClsEnumerados.Instancia.lst_Estado_Civil
        cbxTipoDoc.SelectedIndex = 0
        cbxSexo.SelectedIndex = 0
        cbxEstadoCivil.SelectedIndex = 0

        bgsEmail.DataSource = Cls.Entidad.lst_Mail
        dgvEmails.DataSource = bgsEmail
        bgsTelefono.DataSource = Cls.Entidad.lst_Telefono
        dgvTelefonos.DataSource = bgsTelefono
        If Cls.Entidad.id > 0 Then
            CargarEntidad()
        End If
        Me.txtApellido.Focus()
    End Sub
#End Region
#Region "Navegacion"
    Private Sub chkFechaNac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaNac.CheckedChanged
        dtpFechaNacimiento.Enabled = chkFechaNac.Checked
    End Sub
    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        e.KeyChar = modFunciones.FuncUtiles.contDecimal(txtNroDoc, e.KeyChar, True)
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub FrmEntidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Busqueda"
    Private Sub txtNombre_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        If Cls.NoFrmHijo AndAlso (Cls.Entidad.EstadoFila = "N" AndAlso (txtApellido.Text.Trim.Count > 2 Or txtNombre.Text.Trim.Count > 2 Or txtNroDoc.Text.Trim.Count > 2)) Then
            Cls.BuscarEntidadesRelacionadas(IIf(txtApellido.Text.Length > 0, txtApellido.Text.Trim, ""), _
                                IIf(txtNombre.Text.Length > 0, txtNombre.Text.Trim, ""), _
                                IIf(txtNroDoc.Text.Length > 0, txtNroDoc.Text.Trim, 0), "entidad")
            If Cls.Entidad.EstadoFila = "U" Then
                CargarEntidad()
            End If
        End If
    End Sub
    Private Sub txtNroDoc_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc.LostFocus
        If Cls.NoFrmHijo AndAlso (Cls.Entidad.EstadoFila = "N" AndAlso (txtApellido.Text.Trim.Count > 2 Or txtNombre.Text.Trim.Count > 2 Or txtNroDoc.Text.Trim.Count > 2)) Then
            Cls.BuscarEntidadesRelacionadas("", "", IIf(txtNroDoc.Text.Length > 0, CInt(txtNroDoc.Text.Trim), 0), "entidad")
            If Cls.Entidad.EstadoFila = "U" Then
                CargarEntidad()
            End If
        End If
    End Sub
#End Region

#Region "Validaciones"
    Private Sub txtApellido_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApellido.Validating
        If txtApellido.Text.Length = 0 Then
            ErrorProvider1.SetError(txtApellido, "Debe ingresar el Apellido")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(txtApellido, Nothing)
        End If
    End Sub
    Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text.Length = 0 Then
            ErrorProvider1.SetError(txtNombre, "Debe ingresar el Nombre")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(txtNombre, Nothing)
        End If
    End Sub
#End Region

#Region "Telefonos"
    Private Sub btnAgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTel.Click
        If Cls.NoFrmHijo Then
            Dim Dlg As New FrmTelefono(Cls.Entidad.id)
            With Dlg
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Cls.Entidad.lst_Telefono.Add(CType(.Tag, telefono))
                    bgsTelefono.DataSource = (From te As telefono In Cls.Entidad.lst_Telefono Where te.EstadoFila <> "D").ToList
                    bgsTelefono.ResetBindings(False)
                End If
            End With
        End If
    End Sub
    Private Sub btnQuitarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTel.Click
        If Cls.NoFrmHijo Then
            If MessageBox.Show("¿Esta seguro que desea eliminar el telefono?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim T As telefono
                T = TelSeleccionado()
                T.EstadoFila = "D"
                bgsTelefono.DataSource = (From te As telefono In Cls.Entidad.lst_Telefono Where te.EstadoFila <> "D").ToList
                bgsTelefono.ResetBindings(False)
            End If
        End If
    End Sub
    Private Sub cmsTelefonos_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsTelefonos.Opening
        For Each Ctrl As ToolStripItem In cmsTelefonos.Items
            Ctrl.Enabled = False
        Next
        If TelSeleccionado() IsNot Nothing Then
            btnQuitarTel.Enabled = True
            btnModificarTel.Enabled = True
        End If
        btnAgregarTel.Enabled = True
    End Sub
    Public Function TelSeleccionado() As telefono
        If bgsTelefono.Position <> -1 Then
            Return bgsTelefono.Item(bgsTelefono.Position)
        Else : Return Nothing
        End If
    End Function
#End Region

#Region "Mails"
    Private Sub btnAgregarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMail.Click
        If Cls.NoFrmHijo Then
            Dim frm As New FrmMail()
            If frm.ShowDialog = DialogResult.OK Then
                Cls.Mail = frm.Tag
                Cls.Entidad.lst_Mail.Add(Cls.Mail)
                bgsEmail.DataSource = (From m As mail In Cls.Entidad.lst_Mail Where m.EstadoFila <> "D").ToList
                bgsEmail.ResetBindings(False)
            End If
        End If

    End Sub
    Private Sub btnQuitarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarMail.Click
        If Cls.NoFrmHijo Then
            If MessageBox.Show("¿Esta seguro que desea eliminar el mail?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Cls.Mail = MailSeleccionado()
                Cls.Mail.EstadoFila = "D"
                bgsEmail.DataSource = (From m As mail In Cls.Entidad.lst_Mail Where m.EstadoFila <> "D").ToList
                bgsEmail.ResetBindings(False)
            End If
        End If
    End Sub
    Public Function MailSeleccionado() As mail
        If bgsEmail.Position <> -1 Then
            Return bgsEmail.Item(bgsEmail.Position)
        Else : Return Nothing
        End If
    End Function
    Private Sub cmsMails_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsMails.Opening
        For Each Ctrl As ToolStripItem In cmsMails.Items
            Ctrl.Enabled = False
        Next
        If MailSeleccionado() IsNot Nothing Then
            btnQuitarMail.Enabled = True
        End If
        btnAgregarMail.Enabled = True
    End Sub
#End Region

#Region "Entidad"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Cls.NoFrmHijo Then
            If Me.ValidateChildren() Then
                Cls.IniciarTrn()
                With Cls.Entidad
                    .apellido = txtApellido.Text
                    .nombre = txtNombre.Text
                    .tipo_documento = cbxTipoDoc.Text
                    If IsNumeric(txtNroDoc.Text) Then .nro_documento = txtNroDoc.Text
                    .sexo = cbxSexo.Text
                    .cuil = txtCuil.Text
                    .fecha_nacimiento = dtpFechaNacimiento.Value
                    .iva = cbxIva.Text
                    .estado_civil = cbxEstadoCivil.SelectedValue
                    .baja = chkBaja.Checked
                    .observacion = txtObservaciones.Text
                End With
            End If
        End If
    End Sub
    Protected Sub CargarEntidad()
        With Cls.Entidad
            txtApellido.Text = .apellido
            txtNombre.Text = .nombre
            cbxTipoDoc.Text = .tipo_documento
            txtNroDoc.Text = .nro_documento
            cbxSexo.Text = .sexo
            txtCuil.Text = .cuil
            dtpFechaNacimiento.Value = .fecha_nacimiento
            cbxIva.SelectedText = .iva
            cbxEstadoCivil.Text = .estado_civil
            txtObservaciones.Text = .observacion
            bgsTelefono.DataSource = (From te As telefono In Cls.Entidad.lst_Telefono Where te.EstadoFila <> "D").ToList
            bgsTelefono.ResetBindings(False)
            bgsEmail.DataSource = (From m As mail In Cls.Entidad.lst_Mail Where m.EstadoFila <> "D").ToList
            bgsEmail.ResetBindings(False)
            chkBaja.Checked = .baja
        End With
    End Sub
#End Region

   
  
End Class