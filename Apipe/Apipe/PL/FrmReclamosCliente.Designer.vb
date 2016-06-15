<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReclamosCliente
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvReclamos = New System.Windows.Forms.DataGridView()
        Me.colCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAsunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgsReclamos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvLineaReclamo = New System.Windows.Forms.DataGridView()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsLineaReclamo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReclamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgsLineaReclamo = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnCancela = New System.Windows.Forms.Button()
        CType(Me.dgvReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgsReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLineaReclamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsLineaReclamo.SuspendLayout()
        CType(Me.bgsLineaReclamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReclamos
        '
        Me.dgvReclamos.AllowUserToAddRows = False
        Me.dgvReclamos.AllowUserToDeleteRows = False
        Me.dgvReclamos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReclamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 10.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReclamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReclamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCategoria, Me.colFechaHora, Me.colAsunto, Me.colEstado})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReclamos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvReclamos.Location = New System.Drawing.Point(12, 63)
        Me.dgvReclamos.Name = "dgvReclamos"
        Me.dgvReclamos.ReadOnly = True
        Me.dgvReclamos.RowHeadersVisible = False
        Me.dgvReclamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReclamos.Size = New System.Drawing.Size(674, 203)
        Me.dgvReclamos.TabIndex = 0
        '
        'colCategoria
        '
        Me.colCategoria.DataPropertyName = "v_categoria"
        Me.colCategoria.HeaderText = "Categoria"
        Me.colCategoria.Name = "colCategoria"
        Me.colCategoria.ReadOnly = True
        '
        'colFechaHora
        '
        Me.colFechaHora.DataPropertyName = "fechahora"
        DataGridViewCellStyle7.Format = "g"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colFechaHora.DefaultCellStyle = DataGridViewCellStyle7
        Me.colFechaHora.HeaderText = "Fecha"
        Me.colFechaHora.Name = "colFechaHora"
        Me.colFechaHora.ReadOnly = True
        '
        'colAsunto
        '
        Me.colAsunto.DataPropertyName = "asunto"
        Me.colAsunto.HeaderText = "Asunto"
        Me.colAsunto.Name = "colAsunto"
        Me.colAsunto.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.DataPropertyName = "finalizo"
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        '
        'dgvLineaReclamo
        '
        Me.dgvLineaReclamo.AllowUserToAddRows = False
        Me.dgvLineaReclamo.AllowUserToDeleteRows = False
        Me.dgvLineaReclamo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLineaReclamo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvLineaReclamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineaReclamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colDescripcion})
        Me.dgvLineaReclamo.ContextMenuStrip = Me.cmsLineaReclamo
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLineaReclamo.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLineaReclamo.Location = New System.Drawing.Point(12, 284)
        Me.dgvLineaReclamo.Name = "dgvLineaReclamo"
        Me.dgvLineaReclamo.ReadOnly = True
        Me.dgvLineaReclamo.RowHeadersVisible = False
        Me.dgvLineaReclamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLineaReclamo.Size = New System.Drawing.Size(674, 209)
        Me.dgvLineaReclamo.TabIndex = 1
        '
        'colFecha
        '
        Me.colFecha.DataPropertyName = "fechahora"
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "comentario"
        Me.colDescripcion.HeaderText = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        Me.colDescripcion.Width = 500
        '
        'cmsLineaReclamo
        '
        Me.cmsLineaReclamo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReclamoToolStripMenuItem})
        Me.cmsLineaReclamo.Name = "cmsLineaReclamo"
        Me.cmsLineaReclamo.Size = New System.Drawing.Size(153, 48)
        '
        'ReclamoToolStripMenuItem
        '
        Me.ReclamoToolStripMenuItem.Name = "ReclamoToolStripMenuItem"
        Me.ReclamoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReclamoToolStripMenuItem.Text = "Reclamo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(78, 21)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'btnCancela
        '
        Me.btnCancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancela.ForeColor = System.Drawing.Color.Black
        Me.btnCancela.Location = New System.Drawing.Point(597, 499)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(89, 30)
        Me.btnCancela.TabIndex = 23
        Me.btnCancela.Text = "Cancelar"
        Me.btnCancela.UseVisualStyleBackColor = False
        '
        'FrmReclamosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(698, 541)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReclamos)
        Me.Controls.Add(Me.dgvLineaReclamo)
        Me.Name = "FrmReclamosCliente"
        Me.Text = "Historial de Reclamos del Cliente"
        CType(Me.dgvReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgsReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLineaReclamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsLineaReclamo.ResumeLayout(False)
        CType(Me.bgsLineaReclamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReclamos As System.Windows.Forms.DataGridView
    Friend WithEvents bgsReclamos As System.Windows.Forms.BindingSource
    Friend WithEvents colCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAsunto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLineaReclamo As System.Windows.Forms.DataGridView
    Friend WithEvents bgsLineaReclamo As System.Windows.Forms.BindingSource
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents cmsLineaReclamo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReclamoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancela As System.Windows.Forms.Button
End Class
