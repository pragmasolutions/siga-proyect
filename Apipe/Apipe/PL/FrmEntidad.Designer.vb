<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntidad
    Inherits Telerik.WinControls.UI.RadForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntidad))
        Me.cmsMails = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnAgregarMail = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuitarMail = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTelefonos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnAgregarTel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModificarTel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuitarTel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.colTipoTelDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodAreaDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNroTelDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHManDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHTarDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObservTelDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.chkFechaNac = New System.Windows.Forms.CheckBox()
        Me.cbxTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxIva = New System.Windows.Forms.ComboBox()
        Me.txtCuil = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvEmails = New System.Windows.Forms.DataGridView()
        Me.colEmailDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactoDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkBaja = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.cmsMails.SuspendLayout()
        Me.cmsTelefonos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsMails
        '
        Me.cmsMails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarMail, Me.btnQuitarMail})
        Me.cmsMails.Name = "ContextMenuStrip1"
        Me.cmsMails.Size = New System.Drawing.Size(121, 48)
        '
        'btnAgregarMail
        '
        Me.btnAgregarMail.Name = "btnAgregarMail"
        Me.btnAgregarMail.Size = New System.Drawing.Size(120, 22)
        Me.btnAgregarMail.Text = "Agregrar"
        '
        'btnQuitarMail
        '
        Me.btnQuitarMail.Name = "btnQuitarMail"
        Me.btnQuitarMail.Size = New System.Drawing.Size(120, 22)
        Me.btnQuitarMail.Text = "Quitar"
        '
        'cmsTelefonos
        '
        Me.cmsTelefonos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarTel, Me.btnModificarTel, Me.btnQuitarTel})
        Me.cmsTelefonos.Name = "ContextMenuStrip1"
        Me.cmsTelefonos.Size = New System.Drawing.Size(126, 70)
        '
        'btnAgregarTel
        '
        Me.btnAgregarTel.Name = "btnAgregarTel"
        Me.btnAgregarTel.Size = New System.Drawing.Size(125, 22)
        Me.btnAgregarTel.Text = "Agregrar"
        '
        'btnModificarTel
        '
        Me.btnModificarTel.Name = "btnModificarTel"
        Me.btnModificarTel.Size = New System.Drawing.Size(125, 22)
        Me.btnModificarTel.Text = "Modificar"
        '
        'btnQuitarTel
        '
        Me.btnQuitarTel.Name = "btnQuitarTel"
        Me.btnQuitarTel.Size = New System.Drawing.Size(125, 22)
        Me.btnQuitarTel.Text = "Quitar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(705, 494)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(624, 494)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AllowUserToAddRows = False
        Me.dgvTelefonos.AllowUserToDeleteRows = False
        Me.dgvTelefonos.AllowUserToOrderColumns = True
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTipoTelDgv, Me.colCodAreaDgv, Me.colNroTelDgv, Me.colHManDgv, Me.colHTarDgv, Me.colObservTelDgv})
        Me.dgvTelefonos.ContextMenuStrip = Me.cmsTelefonos
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTelefonos.Location = New System.Drawing.Point(2, 273)
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.ReadOnly = True
        Me.dgvTelefonos.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTelefonos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(399, 137)
        Me.dgvTelefonos.TabIndex = 15
        '
        'colTipoTelDgv
        '
        Me.colTipoTelDgv.DataPropertyName = "tipo"
        Me.colTipoTelDgv.HeaderText = "Tipo"
        Me.colTipoTelDgv.Name = "colTipoTelDgv"
        Me.colTipoTelDgv.ReadOnly = True
        Me.colTipoTelDgv.Width = 90
        '
        'colCodAreaDgv
        '
        Me.colCodAreaDgv.DataPropertyName = "cod_area"
        Me.colCodAreaDgv.HeaderText = "Cod. Area"
        Me.colCodAreaDgv.Name = "colCodAreaDgv"
        Me.colCodAreaDgv.ReadOnly = True
        Me.colCodAreaDgv.Width = 90
        '
        'colNroTelDgv
        '
        Me.colNroTelDgv.DataPropertyName = "numero"
        Me.colNroTelDgv.HeaderText = "Número"
        Me.colNroTelDgv.Name = "colNroTelDgv"
        Me.colNroTelDgv.ReadOnly = True
        '
        'colHManDgv
        '
        Me.colHManDgv.DataPropertyName = "horario_manana"
        Me.colHManDgv.HeaderText = "Horario Mañana"
        Me.colHManDgv.Name = "colHManDgv"
        Me.colHManDgv.ReadOnly = True
        Me.colHManDgv.Width = 150
        '
        'colHTarDgv
        '
        Me.colHTarDgv.DataPropertyName = "horario_tarde"
        Me.colHTarDgv.HeaderText = "Horario Tarde"
        Me.colHTarDgv.Name = "colHTarDgv"
        Me.colHTarDgv.ReadOnly = True
        Me.colHTarDgv.Width = 150
        '
        'colObservTelDgv
        '
        Me.colObservTelDgv.DataPropertyName = "observaciones"
        Me.colObservTelDgv.HeaderText = "Observaciones"
        Me.colObservTelDgv.Name = "colObservTelDgv"
        Me.colObservTelDgv.ReadOnly = True
        '
        'cbxEstadoCivil
        '
        Me.cbxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEstadoCivil.FormattingEnabled = True
        Me.cbxEstadoCivil.Location = New System.Drawing.Point(288, 90)
        Me.cbxEstadoCivil.Name = "cbxEstadoCivil"
        Me.cbxEstadoCivil.Size = New System.Drawing.Size(113, 21)
        Me.cbxEstadoCivil.TabIndex = 5
        '
        'chkFechaNac
        '
        Me.chkFechaNac.AutoSize = True
        Me.chkFechaNac.Location = New System.Drawing.Point(194, 122)
        Me.chkFechaNac.Name = "chkFechaNac"
        Me.chkFechaNac.Size = New System.Drawing.Size(15, 14)
        Me.chkFechaNac.TabIndex = 145
        Me.chkFechaNac.UseVisualStyleBackColor = True
        '
        'cbxTipoDoc
        '
        Me.cbxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDoc.FormattingEnabled = True
        Me.cbxTipoDoc.Location = New System.Drawing.Point(89, 63)
        Me.cbxTipoDoc.Name = "cbxTipoDoc"
        Me.cbxTipoDoc.Size = New System.Drawing.Size(119, 21)
        Me.cbxTipoDoc.TabIndex = 2
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(251, 63)
        Me.txtNroDoc.MaxLength = 11
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(150, 20)
        Me.txtNroDoc.TabIndex = 3
        Me.txtNroDoc.Text = "0"
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Location = New System.Drawing.Point(89, 6)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(312, 20)
        Me.txtApellido.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(89, 36)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(312, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(230, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "E.Civil.:"
        '
        'cbxSexo
        '
        Me.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Location = New System.Drawing.Point(89, 90)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(135, 21)
        Me.cbxSexo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Apellido/s:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(214, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Nro:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Nacimiento:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Enabled = False
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(89, 117)
        Me.dtpFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaNacimiento.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Documento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Nombre/s:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Sexo:"
        '
        'cbxIva
        '
        Me.cbxIva.DropDownWidth = 150
        Me.cbxIva.FormattingEnabled = True
        Me.cbxIva.Items.AddRange(New Object() {"CONSUMIDOR FINAL", "EXENTO", "EXTRANJERO", "RESPONSABLE INSCRIPTO", "MONOTRIBUTISTA", "RESPONSABLE NO INSCRIPTO", "SUJETO NO CATEGORIZADO"})
        Me.cbxIva.Location = New System.Drawing.Point(89, 145)
        Me.cbxIva.Name = "cbxIva"
        Me.cbxIva.Size = New System.Drawing.Size(155, 21)
        Me.cbxIva.TabIndex = 12
        '
        'txtCuil
        '
        Me.txtCuil.Location = New System.Drawing.Point(296, 145)
        Me.txtCuil.Mask = "##-########-#"
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(105, 20)
        Me.txtCuil.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(250, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = "CUIL:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(38, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "I.V.A.:"
        '
        'dgvEmails
        '
        Me.dgvEmails.AllowUserToAddRows = False
        Me.dgvEmails.AllowUserToDeleteRows = False
        Me.dgvEmails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dgvEmails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmailDgv, Me.colContactoDgv})
        Me.dgvEmails.ContextMenuStrip = Me.cmsMails
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmails.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmails.Location = New System.Drawing.Point(2, 172)
        Me.dgvEmails.Name = "dgvEmails"
        Me.dgvEmails.ReadOnly = True
        Me.dgvEmails.RowHeadersVisible = False
        Me.dgvEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmails.Size = New System.Drawing.Size(399, 95)
        Me.dgvEmails.TabIndex = 14
        '
        'colEmailDgv
        '
        Me.colEmailDgv.DataPropertyName = "v_email"
        Me.colEmailDgv.HeaderText = "Email"
        Me.colEmailDgv.Name = "colEmailDgv"
        Me.colEmailDgv.ReadOnly = True
        Me.colEmailDgv.Width = 200
        '
        'colContactoDgv
        '
        Me.colContactoDgv.DataPropertyName = "contacto"
        Me.colContactoDgv.HeaderText = "Contacto"
        Me.colContactoDgv.Name = "colContactoDgv"
        Me.colContactoDgv.ReadOnly = True
        '
        'chkBaja
        '
        Me.chkBaja.AutoSize = True
        Me.chkBaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBaja.Location = New System.Drawing.Point(343, 122)
        Me.chkBaja.Name = "chkBaja"
        Me.chkBaja.Size = New System.Drawing.Size(58, 17)
        Me.chkBaja.TabIndex = 7
        Me.chkBaja.Text = "Baja?"
        Me.chkBaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkBaja.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(15, 413)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 193
        Me.Label18.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(9, 429)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(399, 55)
        Me.txtObservaciones.TabIndex = 16
        '
        'FrmEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 522)
        Me.Controls.Add(Me.cbxIva)
        Me.Controls.Add(Me.cbxTipoDoc)
        Me.Controls.Add(Me.dgvEmails)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.chkBaja)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.txtCuil)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.dgvTelefonos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkFechaNac)
        Me.Controls.Add(Me.cbxEstadoCivil)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmEntidad"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(800, 600)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.cmsMails.ResumeLayout(False)
        Me.cmsTelefonos.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Protected WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnModificarTel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnQuitarTel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmsMails As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnAgregarMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnQuitarMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsTelefonos As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkBaja As System.Windows.Forms.CheckBox
    Friend WithEvents dgvEmails As System.Windows.Forms.DataGridView
    Friend WithEvents cbxIva As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvTelefonos As System.Windows.Forms.DataGridView
    Friend WithEvents cbxEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents chkFechaNac As System.Windows.Forms.CheckBox
    Friend WithEvents cbxTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents colEmailDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContactoDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoTelDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodAreaDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNroTelDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHManDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHTarDgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservTelDgv As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
