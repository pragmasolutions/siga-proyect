<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChoferMovil
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChoferMovil))
        Me.spcTodo = New System.Windows.Forms.SplitContainer()
        Me.chkSoloVigentes = New System.Windows.Forms.CheckBox()
        Me.dgvChoferMovil = New System.Windows.Forms.DataGridView()
        Me.colChofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsFiltros = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbxActivos = New System.Windows.Forms.ToolStripComboBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.gbxChoferMovil = New System.Windows.Forms.GroupBox()
        Me.chkFin = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnSelMovil = New System.Windows.Forms.Button()
        Me.btnSelChofer = New System.Windows.Forms.Button()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.lblChofer = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTodo.Panel1.SuspendLayout()
        Me.spcTodo.Panel2.SuspendLayout()
        Me.spcTodo.SuspendLayout()
        CType(Me.dgvChoferMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsFiltros.SuspendLayout()
        Me.gbxChoferMovil.SuspendLayout()
        Me.t.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcTodo
        '
        Me.spcTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcTodo.Location = New System.Drawing.Point(0, 0)
        Me.spcTodo.Name = "spcTodo"
        Me.spcTodo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcTodo.Panel1
        '
        Me.spcTodo.Panel1.Controls.Add(Me.chkSoloVigentes)
        Me.spcTodo.Panel1.Controls.Add(Me.dgvChoferMovil)
        Me.spcTodo.Panel1.Controls.Add(Me.tsFiltros)
        '
        'spcTodo.Panel2
        '
        Me.spcTodo.Panel2.Controls.Add(Me.gbxChoferMovil)
        Me.spcTodo.Panel2.Controls.Add(Me.t)
        Me.spcTodo.Size = New System.Drawing.Size(559, 402)
        Me.spcTodo.SplitterDistance = 229
        Me.spcTodo.TabIndex = 0
        '
        'chkSoloVigentes
        '
        Me.chkSoloVigentes.AutoSize = True
        Me.chkSoloVigentes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkSoloVigentes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSoloVigentes.Location = New System.Drawing.Point(17, 4)
        Me.chkSoloVigentes.Name = "chkSoloVigentes"
        Me.chkSoloVigentes.Size = New System.Drawing.Size(123, 17)
        Me.chkSoloVigentes.TabIndex = 4
        Me.chkSoloVigentes.Text = "Sólo los vigentes"
        Me.chkSoloVigentes.UseVisualStyleBackColor = False
        '
        'dgvChoferMovil
        '
        Me.dgvChoferMovil.AllowUserToAddRows = False
        Me.dgvChoferMovil.AllowUserToDeleteRows = False
        Me.dgvChoferMovil.AllowUserToResizeRows = False
        Me.dgvChoferMovil.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvChoferMovil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvChoferMovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChoferMovil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colChofer, Me.colMovil, Me.colInicio, Me.colFin, Me.colObservaciones})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChoferMovil.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvChoferMovil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvChoferMovil.Location = New System.Drawing.Point(0, 25)
        Me.dgvChoferMovil.Name = "dgvChoferMovil"
        Me.dgvChoferMovil.ReadOnly = True
        Me.dgvChoferMovil.RowHeadersVisible = False
        Me.dgvChoferMovil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChoferMovil.Size = New System.Drawing.Size(559, 204)
        Me.dgvChoferMovil.TabIndex = 3
        '
        'colChofer
        '
        Me.colChofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colChofer.DataPropertyName = "v_chofer_AyN"
        Me.colChofer.HeaderText = "Chofer"
        Me.colChofer.Name = "colChofer"
        Me.colChofer.ReadOnly = True
        Me.colChofer.Width = 150
        '
        'colMovil
        '
        Me.colMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovil.DataPropertyName = "v_movil"
        Me.colMovil.HeaderText = "Móvil"
        Me.colMovil.Name = "colMovil"
        Me.colMovil.ReadOnly = True
        Me.colMovil.Width = 150
        '
        'colInicio
        '
        Me.colInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colInicio.DataPropertyName = "inicio"
        Me.colInicio.HeaderText = "Inicio"
        Me.colInicio.Name = "colInicio"
        Me.colInicio.ReadOnly = True
        Me.colInicio.Width = 63
        '
        'colFin
        '
        Me.colFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFin.DataPropertyName = "fin"
        Me.colFin.HeaderText = "Fin"
        Me.colFin.Name = "colFin"
        Me.colFin.ReadOnly = True
        Me.colFin.Width = 48
        '
        'colObservaciones
        '
        Me.colObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colObservaciones.DataPropertyName = "observacion"
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.ReadOnly = True
        Me.colObservaciones.Width = 260
        '
        'tsFiltros
        '
        Me.tsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cbxActivos, Me.btnBuscar})
        Me.tsFiltros.Location = New System.Drawing.Point(0, 0)
        Me.tsFiltros.Name = "tsFiltros"
        Me.tsFiltros.Size = New System.Drawing.Size(559, 25)
        Me.tsFiltros.TabIndex = 2
        Me.tsFiltros.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(140, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel1.Text = "Mostrar:"
        '
        'cbxActivos
        '
        Me.cbxActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActivos.Items.AddRange(New Object() {"Todos", "Activos", "Inactivos"})
        Me.cbxActivos.Name = "cbxActivos"
        Me.cbxActivos.Size = New System.Drawing.Size(121, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Image = Global.Apipe.My.Resources.Resources.buscar
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 1, 0, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscar.Text = "ToolStripButton1"
        '
        'gbxChoferMovil
        '
        Me.gbxChoferMovil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxChoferMovil.Controls.Add(Me.chkFin)
        Me.gbxChoferMovil.Controls.Add(Me.txtObservaciones)
        Me.gbxChoferMovil.Controls.Add(Me.dtpFin)
        Me.gbxChoferMovil.Controls.Add(Me.dtpInicio)
        Me.gbxChoferMovil.Controls.Add(Me.btnSelMovil)
        Me.gbxChoferMovil.Controls.Add(Me.btnSelChofer)
        Me.gbxChoferMovil.Controls.Add(Me.lblMovil)
        Me.gbxChoferMovil.Controls.Add(Me.lblChofer)
        Me.gbxChoferMovil.Controls.Add(Me.Label5)
        Me.gbxChoferMovil.Controls.Add(Me.Label3)
        Me.gbxChoferMovil.Controls.Add(Me.Label2)
        Me.gbxChoferMovil.Controls.Add(Me.Label1)
        Me.gbxChoferMovil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxChoferMovil.Location = New System.Drawing.Point(12, 28)
        Me.gbxChoferMovil.Name = "gbxChoferMovil"
        Me.gbxChoferMovil.Size = New System.Drawing.Size(535, 133)
        Me.gbxChoferMovil.TabIndex = 1
        Me.gbxChoferMovil.TabStop = False
        Me.gbxChoferMovil.Text = "Chofer de Móvil"
        '
        'chkFin
        '
        Me.chkFin.AutoSize = True
        Me.chkFin.ForeColor = System.Drawing.Color.White
        Me.chkFin.Location = New System.Drawing.Point(191, 45)
        Me.chkFin.Name = "chkFin"
        Me.chkFin.Size = New System.Drawing.Size(43, 17)
        Me.chkFin.TabIndex = 4
        Me.chkFin.Text = "Fin:"
        Me.chkFin.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 74)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(418, 49)
        Me.txtObservaciones.TabIndex = 3
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(241, 43)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(130, 21)
        Me.dtpFin.TabIndex = 2
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(55, 43)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(130, 21)
        Me.dtpInicio.TabIndex = 2
        '
        'btnSelMovil
        '
        Me.btnSelMovil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelMovil.Image = Global.Apipe.My.Resources.Resources.buscar
        Me.btnSelMovil.Location = New System.Drawing.Point(495, 16)
        Me.btnSelMovil.Name = "btnSelMovil"
        Me.btnSelMovil.Size = New System.Drawing.Size(31, 23)
        Me.btnSelMovil.TabIndex = 1
        Me.btnSelMovil.UseVisualStyleBackColor = True
        '
        'btnSelChofer
        '
        Me.btnSelChofer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelChofer.Image = Global.Apipe.My.Resources.Resources.buscar
        Me.btnSelChofer.Location = New System.Drawing.Point(241, 16)
        Me.btnSelChofer.Name = "btnSelChofer"
        Me.btnSelChofer.Size = New System.Drawing.Size(31, 23)
        Me.btnSelChofer.TabIndex = 1
        Me.btnSelChofer.UseVisualStyleBackColor = True
        '
        'lblMovil
        '
        Me.lblMovil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMovil.AutoEllipsis = True
        Me.lblMovil.ForeColor = System.Drawing.Color.White
        Me.lblMovil.Location = New System.Drawing.Point(326, 21)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(163, 13)
        Me.lblMovil.TabIndex = 0
        Me.lblMovil.Text = "(Seleccione un móvil...)"
        '
        'lblChofer
        '
        Me.lblChofer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChofer.AutoEllipsis = True
        Me.lblChofer.ForeColor = System.Drawing.Color.White
        Me.lblChofer.Location = New System.Drawing.Point(63, 21)
        Me.lblChofer.Name = "lblChofer"
        Me.lblChofer.Size = New System.Drawing.Size(172, 13)
        Me.lblChofer.TabIndex = 0
        Me.lblChofer.Text = "(Seleccione un chofer...)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Observaciones:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inicio:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(279, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Móvil:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chofer:"
        '
        't
        '
        Me.t.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
        Me.t.Location = New System.Drawing.Point(0, 0)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(559, 25)
        Me.t.TabIndex = 0
        Me.t.Text = "ToolStrip2"
        '
        'btnNuevo
        '
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNuevo.Image = Global.Apipe.My.Resources.Resources.add1
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnModificar
        '
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Image = Global.Apipe.My.Resources.Resources.modif
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuardar.Image = Global.Apipe.My.Resources.Resources.disk
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Image = Global.Apipe.My.Resources.Resources.cerrar
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmChoferMovil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(559, 402)
        Me.Controls.Add(Me.spcTodo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmChoferMovil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Choferes de Móviles"
        Me.spcTodo.Panel1.ResumeLayout(False)
        Me.spcTodo.Panel1.PerformLayout()
        Me.spcTodo.Panel2.ResumeLayout(False)
        Me.spcTodo.Panel2.PerformLayout()
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTodo.ResumeLayout(False)
        CType(Me.dgvChoferMovil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsFiltros.ResumeLayout(False)
        Me.tsFiltros.PerformLayout()
        Me.gbxChoferMovil.ResumeLayout(False)
        Me.gbxChoferMovil.PerformLayout()
        Me.t.ResumeLayout(False)
        Me.t.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcTodo As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvChoferMovil As System.Windows.Forms.DataGridView
    Friend WithEvents tsFiltros As System.Windows.Forms.ToolStrip
    Friend WithEvents gbxChoferMovil As System.Windows.Forms.GroupBox
    Friend WithEvents t As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSelChofer As System.Windows.Forms.Button
    Friend WithEvents lblChofer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelMovil As System.Windows.Forms.Button
    Friend WithEvents lblMovil As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkFin As System.Windows.Forms.CheckBox
    Friend WithEvents chkSoloVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cbxActivos As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents colChofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
