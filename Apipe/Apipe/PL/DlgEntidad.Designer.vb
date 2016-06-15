<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgEntidad
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgEntidad))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvEntidad = New System.Windows.Forms.DataGridView()
        Me.apellidoDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilioDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civilDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimientoDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_documentoDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_documentoDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mailDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnNueva = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtApellido = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNombre = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDNI = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAceptar, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(514, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(88, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgvEntidad
        '
        Me.dgvEntidad.AllowUserToAddRows = False
        Me.dgvEntidad.AllowUserToDeleteRows = False
        Me.dgvEntidad.AllowUserToOrderColumns = True
        Me.dgvEntidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEntidad.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dgvEntidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellidoDataGridView, Me.nombreDataGridView, Me.domicilioDataGridView, Me.estado_civilDataGridView, Me.fecha_nacimientoDataGridView, Me.tipo_documentoDataGridView, Me.nro_documentoDataGridView, Me.mailDataGridView})
        Me.dgvEntidad.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntidad.Location = New System.Drawing.Point(0, 28)
        Me.dgvEntidad.Name = "dgvEntidad"
        Me.dgvEntidad.ReadOnly = True
        Me.dgvEntidad.RowHeadersVisible = False
        Me.dgvEntidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntidad.Size = New System.Drawing.Size(699, 240)
        Me.dgvEntidad.TabIndex = 0
        '
        'apellidoDataGridView
        '
        Me.apellidoDataGridView.DataPropertyName = "apellido"
        Me.apellidoDataGridView.HeaderText = "Apellido"
        Me.apellidoDataGridView.Name = "apellidoDataGridView"
        Me.apellidoDataGridView.ReadOnly = True
        Me.apellidoDataGridView.Width = 150
        '
        'nombreDataGridView
        '
        Me.nombreDataGridView.DataPropertyName = "nombre"
        Me.nombreDataGridView.HeaderText = "Nombre"
        Me.nombreDataGridView.Name = "nombreDataGridView"
        Me.nombreDataGridView.ReadOnly = True
        Me.nombreDataGridView.Width = 150
        '
        'domicilioDataGridView
        '
        Me.domicilioDataGridView.DataPropertyName = "domicilio"
        Me.domicilioDataGridView.HeaderText = "Domicilio"
        Me.domicilioDataGridView.Name = "domicilioDataGridView"
        Me.domicilioDataGridView.ReadOnly = True
        Me.domicilioDataGridView.Width = 150
        '
        'estado_civilDataGridView
        '
        Me.estado_civilDataGridView.DataPropertyName = "estado_civil"
        Me.estado_civilDataGridView.HeaderText = "Estado Civil"
        Me.estado_civilDataGridView.Name = "estado_civilDataGridView"
        Me.estado_civilDataGridView.ReadOnly = True
        '
        'fecha_nacimientoDataGridView
        '
        Me.fecha_nacimientoDataGridView.DataPropertyName = "fecha_nacimiento"
        Me.fecha_nacimientoDataGridView.HeaderText = "Fecha Nac."
        Me.fecha_nacimientoDataGridView.Name = "fecha_nacimientoDataGridView"
        Me.fecha_nacimientoDataGridView.ReadOnly = True
        '
        'tipo_documentoDataGridView
        '
        Me.tipo_documentoDataGridView.DataPropertyName = "tipo_documento"
        Me.tipo_documentoDataGridView.HeaderText = "Tipo Doc."
        Me.tipo_documentoDataGridView.Name = "tipo_documentoDataGridView"
        Me.tipo_documentoDataGridView.ReadOnly = True
        Me.tipo_documentoDataGridView.Width = 50
        '
        'nro_documentoDataGridView
        '
        Me.nro_documentoDataGridView.DataPropertyName = "nro_documento"
        Me.nro_documentoDataGridView.HeaderText = "Nro. Doc."
        Me.nro_documentoDataGridView.Name = "nro_documentoDataGridView"
        Me.nro_documentoDataGridView.ReadOnly = True
        '
        'mailDataGridView
        '
        Me.mailDataGridView.DataPropertyName = "v_emails"
        Me.mailDataGridView.HeaderText = "Mail"
        Me.mailDataGridView.Name = "mailDataGridView"
        Me.mailDataGridView.ReadOnly = True
        Me.mailDataGridView.Width = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNueva, Me.btnModificar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'btnNueva
        '
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(152, 22)
        Me.btnNueva.Text = "Nueva"
        '
        'btnModificar
        '
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar como"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtApellido, Me.ToolStripLabel2, Me.txtNombre, Me.ToolStripLabel3, Me.txtDNI, Me.btnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(699, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel1.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(116, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(116, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel3.Text = "Nro. Doc. :"
        '
        'txtDNI
        '
        Me.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(116, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Apipe.My.Resources.Resources.buscar
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'DlgEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(699, 315)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvEntidad)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(705, 343)
        Me.Name = "DlgEntidad"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvEntidad As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtApellido As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNombre As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDNI As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents apellidoDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilioDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_civilDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimientoDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_documentoDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_documentoDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mailDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnNueva As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem

End Class
