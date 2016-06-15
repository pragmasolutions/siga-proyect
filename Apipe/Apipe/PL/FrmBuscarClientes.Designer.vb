<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarClientes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bgsCliente = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.txtTelefono = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnBorrarTodo = New System.Windows.Forms.ToolStripButton()
        Me.DgvEntidades = New System.Windows.Forms.DataGridView()
        Me.ColDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.telid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teltipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telcod_area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telnumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.bgsEntidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDom = New System.Windows.Forms.DataGridView()
        Me.domCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domtelCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domnumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domtelNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teldomDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domInterseccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldomtelInterseccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldomtelObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldomtelTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgsDom = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlBuscarNro = New System.Windows.Forms.Panel()
        Me.txtBuscarNro = New System.Windows.Forms.TextBox()
        CType(Me.bgsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DgvEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBusqueda.SuspendLayout()
        CType(Me.bgsEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgsDom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscarNro.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.txtTelefono, Me.btnBuscar, Me.btnBorrarTodo})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1165, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripLabel5.Text = "Ingrese el nro de telefono, apellido o calle"
        '
        'txtTelefono
        '
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 25)
        Me.txtTelefono.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Apipe.My.Resources.Resources.buscar
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Image = Global.Apipe.My.Resources.Resources.transferir
        Me.btnBorrarTodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(87, 22)
        Me.btnBorrarTodo.Text = "Borrar todo"
        '
        'DgvEntidades
        '
        Me.DgvEntidades.AllowUserToAddRows = False
        Me.DgvEntidades.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.DgvEntidades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEntidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEntidades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEntidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDomicilio})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEntidades.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEntidades.Location = New System.Drawing.Point(585, 23)
        Me.DgvEntidades.Name = "DgvEntidades"
        Me.DgvEntidades.ReadOnly = True
        Me.DgvEntidades.RowHeadersVisible = False
        Me.DgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEntidades.Size = New System.Drawing.Size(550, 351)
        Me.DgvEntidades.TabIndex = 4
        '
        'ColDomicilio
        '
        Me.ColDomicilio.DataPropertyName = "v_AyN"
        Me.ColDomicilio.FillWeight = 116.3452!
        Me.ColDomicilio.HeaderText = "Cliente"
        Me.ColDomicilio.Name = "ColDomicilio"
        Me.ColDomicilio.ReadOnly = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.telid, Me.telcliente, Me.teltipo, Me.telcod_area, Me.telnumero})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvClientes.Location = New System.Drawing.Point(12, 23)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(550, 351)
        Me.dgvClientes.TabIndex = 3
        '
        'telid
        '
        Me.telid.DataPropertyName = "id"
        Me.telid.HeaderText = "id"
        Me.telid.Name = "telid"
        Me.telid.Visible = False
        '
        'telcliente
        '
        Me.telcliente.DataPropertyName = "v_AyNom"
        Me.telcliente.HeaderText = "Cliente"
        Me.telcliente.Name = "telcliente"
        '
        'teltipo
        '
        Me.teltipo.DataPropertyName = "tipo"
        Me.teltipo.HeaderText = "Tipo"
        Me.teltipo.Name = "teltipo"
        '
        'telcod_area
        '
        Me.telcod_area.DataPropertyName = "cod_area"
        Me.telcod_area.HeaderText = "Caracteristica"
        Me.telcod_area.Name = "telcod_area"
        '
        'telnumero
        '
        Me.telnumero.DataPropertyName = "numero"
        Me.telnumero.HeaderText = "Numero"
        Me.telnumero.Name = "telnumero"
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.dgvClientes)
        Me.pnlBusqueda.Controls.Add(Me.DgvEntidades)
        Me.pnlBusqueda.Location = New System.Drawing.Point(0, 53)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(1153, 392)
        Me.pnlBusqueda.TabIndex = 6
        '
        'dgvDom
        '
        Me.dgvDom.AllowUserToAddRows = False
        Me.dgvDom.AllowUserToDeleteRows = False
        Me.dgvDom.AllowUserToResizeColumns = False
        Me.dgvDom.AllowUserToResizeRows = False
        Me.dgvDom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDom.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.domCalle, Me.domtelCalle, Me.domnumero, Me.domtelNumero, Me.domDescripcion, Me.teldomDescripcion, Me.domInterseccion, Me.coldomtelInterseccion, Me.domObservaciones, Me.coldomtelObservacion, Me.domTipo, Me.coldomtelTipo})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDom.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDom.Location = New System.Drawing.Point(12, 463)
        Me.dgvDom.Name = "dgvDom"
        Me.dgvDom.ReadOnly = True
        Me.dgvDom.RowHeadersVisible = False
        Me.dgvDom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDom.Size = New System.Drawing.Size(1123, 215)
        Me.dgvDom.TabIndex = 7
        '
        'domCalle
        '
        Me.domCalle.DataPropertyName = "calle"
        Me.domCalle.HeaderText = "Calle"
        Me.domCalle.Name = "domCalle"
        Me.domCalle.ReadOnly = True
        '
        'domtelCalle
        '
        Me.domtelCalle.DataPropertyName = "v_calle"
        Me.domtelCalle.HeaderText = "Calle"
        Me.domtelCalle.Name = "domtelCalle"
        Me.domtelCalle.ReadOnly = True
        Me.domtelCalle.Visible = False
        '
        'domnumero
        '
        Me.domnumero.DataPropertyName = "numero"
        Me.domnumero.HeaderText = "Numero"
        Me.domnumero.Name = "domnumero"
        Me.domnumero.ReadOnly = True
        '
        'domtelNumero
        '
        Me.domtelNumero.DataPropertyName = "v_nro"
        Me.domtelNumero.HeaderText = "Numero"
        Me.domtelNumero.Name = "domtelNumero"
        Me.domtelNumero.ReadOnly = True
        Me.domtelNumero.Visible = False
        '
        'domDescripcion
        '
        Me.domDescripcion.DataPropertyName = "descripcion"
        Me.domDescripcion.HeaderText = "Descripcion"
        Me.domDescripcion.Name = "domDescripcion"
        Me.domDescripcion.ReadOnly = True
        '
        'teldomDescripcion
        '
        Me.teldomDescripcion.DataPropertyName = "v_descripcion"
        Me.teldomDescripcion.HeaderText = "Descripcion"
        Me.teldomDescripcion.Name = "teldomDescripcion"
        Me.teldomDescripcion.ReadOnly = True
        Me.teldomDescripcion.Visible = False
        '
        'domInterseccion
        '
        Me.domInterseccion.DataPropertyName = "interseccion"
        Me.domInterseccion.HeaderText = "Interseccion"
        Me.domInterseccion.Name = "domInterseccion"
        Me.domInterseccion.ReadOnly = True
        '
        'coldomtelInterseccion
        '
        Me.coldomtelInterseccion.DataPropertyName = "v_interseccion"
        Me.coldomtelInterseccion.HeaderText = "Interseccion"
        Me.coldomtelInterseccion.Name = "coldomtelInterseccion"
        Me.coldomtelInterseccion.ReadOnly = True
        Me.coldomtelInterseccion.Visible = False
        '
        'domObservaciones
        '
        Me.domObservaciones.DataPropertyName = "observaciones"
        Me.domObservaciones.HeaderText = "Observaciones"
        Me.domObservaciones.Name = "domObservaciones"
        Me.domObservaciones.ReadOnly = True
        '
        'coldomtelObservacion
        '
        Me.coldomtelObservacion.DataPropertyName = "v_observacion"
        Me.coldomtelObservacion.HeaderText = "Obsevaciones"
        Me.coldomtelObservacion.Name = "coldomtelObservacion"
        Me.coldomtelObservacion.ReadOnly = True
        Me.coldomtelObservacion.Visible = False
        '
        'domTipo
        '
        Me.domTipo.DataPropertyName = "tipo"
        Me.domTipo.HeaderText = "Tipo"
        Me.domTipo.Name = "domTipo"
        Me.domTipo.ReadOnly = True
        '
        'coldomtelTipo
        '
        Me.coldomtelTipo.DataPropertyName = "v_tipo"
        Me.coldomtelTipo.HeaderText = "Tipo"
        Me.coldomtelTipo.Name = "coldomtelTipo"
        Me.coldomtelTipo.ReadOnly = True
        Me.coldomtelTipo.Visible = False
        '
        'pnlBuscarNro
        '
        Me.pnlBuscarNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlBuscarNro.Controls.Add(Me.txtBuscarNro)
        Me.pnlBuscarNro.Location = New System.Drawing.Point(309, 463)
        Me.pnlBuscarNro.Name = "pnlBuscarNro"
        Me.pnlBuscarNro.Size = New System.Drawing.Size(87, 40)
        Me.pnlBuscarNro.TabIndex = 13
        Me.pnlBuscarNro.Visible = False
        '
        'txtBuscarNro
        '
        Me.txtBuscarNro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarNro.Location = New System.Drawing.Point(11, 8)
        Me.txtBuscarNro.Name = "txtBuscarNro"
        Me.txtBuscarNro.Size = New System.Drawing.Size(65, 20)
        Me.txtBuscarNro.TabIndex = 0
        '
        'FrmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1165, 736)
        Me.Controls.Add(Me.pnlBuscarNro)
        Me.Controls.Add(Me.dgvDom)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "FrmBuscarClientes"
        Me.Text = "Buscar Clientes"
        CType(Me.bgsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DgvEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBusqueda.ResumeLayout(False)
        CType(Me.bgsEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgsDom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscarNro.ResumeLayout(False)
        Me.pnlBuscarNro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bgsCliente As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtTelefono As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DgvEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents telid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teltipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telcod_area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telnumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
    Friend WithEvents bgsEntidades As System.Windows.Forms.BindingSource
    Friend WithEvents dgvDom As System.Windows.Forms.DataGridView
    Friend WithEvents bgsDom As System.Windows.Forms.BindingSource
    Friend WithEvents ColDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBuscarNro As System.Windows.Forms.Panel
    Friend WithEvents txtBuscarNro As System.Windows.Forms.TextBox
    Friend WithEvents domCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domtelCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domnumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domtelNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teldomDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domInterseccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldomtelInterseccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldomtelObservacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldomtelTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBorrarTodo As System.Windows.Forms.ToolStripButton
End Class
