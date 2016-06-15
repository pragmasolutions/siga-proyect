<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidos
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.cmsPedidos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReclToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BgsPedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.txtDetalle = New System.Windows.Forms.RichTextBox()
        Me.colPedReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_movil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPedidos.SuspendLayout()
        CType(Me.BgsPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSize = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dgvPedidos)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1137, 429)
        Me.Panel3.TabIndex = 16
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AllowUserToResizeRows = False
        Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.AutoGenerateColumns = False
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPedReclamo, Me.fecha, Me.Domicilio, Me.nro_movil, Me.Asignado, Me.Completado, Me.Cancelado, Me.Observacion, Me.Chofer})
        Me.dgvPedidos.ContextMenuStrip = Me.cmsPedidos
        Me.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dgvPedidos.DataSource = Me.BgsPedido
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPedidos.Location = New System.Drawing.Point(16, 34)
        Me.dgvPedidos.MultiSelect = False
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(1073, 348)
        Me.dgvPedidos.TabIndex = 2
        '
        'cmsPedidos
        '
        Me.cmsPedidos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReclToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.cmsPedidos.Name = "cmsPedidos"
        Me.cmsPedidos.Size = New System.Drawing.Size(121, 48)
        '
        'ReclToolStripMenuItem
        '
        Me.ReclToolStripMenuItem.Name = "ReclToolStripMenuItem"
        Me.ReclToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ReclToolStripMenuItem.Text = "Reclamo"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(10, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PEDIDOS DEL CLIENTE"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.txtDetalle)
        Me.gbxDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxDetalle.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxDetalle.Location = New System.Drawing.Point(0, 374)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(1115, 111)
        Me.gbxDetalle.TabIndex = 17
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "DETALLE"
        '
        'txtDetalle
        '
        Me.txtDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetalle.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.White
        Me.txtDetalle.Location = New System.Drawing.Point(9, 24)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDetalle.Size = New System.Drawing.Size(1099, 81)
        Me.txtDetalle.TabIndex = 7
        Me.txtDetalle.TabStop = False
        Me.txtDetalle.Text = "(Detalle)"
        '
        'colPedReclamo
        '
        Me.colPedReclamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedReclamo.HeaderText = ""
        Me.colPedReclamo.Name = "colPedReclamo"
        Me.colPedReclamo.ReadOnly = True
        Me.colPedReclamo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPedReclamo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPedReclamo.Width = 20
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "v_hora_viaje"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'Domicilio
        '
        Me.Domicilio.DataPropertyName = "v_domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        '
        'nro_movil
        '
        Me.nro_movil.DataPropertyName = "v_nroMovil"
        Me.nro_movil.HeaderText = "Movil"
        Me.nro_movil.Name = "nro_movil"
        Me.nro_movil.ReadOnly = True
        '
        'Asignado
        '
        Me.Asignado.DataPropertyName = "v_hora_asignado2"
        Me.Asignado.HeaderText = "Asignado"
        Me.Asignado.Name = "Asignado"
        Me.Asignado.ReadOnly = True
        '
        'Completado
        '
        Me.Completado.DataPropertyName = "v_hora_completado2"
        Me.Completado.HeaderText = "Completado"
        Me.Completado.Name = "Completado"
        Me.Completado.ReadOnly = True
        '
        'Cancelado
        '
        Me.Cancelado.DataPropertyName = "v_hora_cancelado"
        Me.Cancelado.HeaderText = "Cancelado"
        Me.Cancelado.Name = "Cancelado"
        Me.Cancelado.ReadOnly = True
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "observacion"
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        '
        'Chofer
        '
        Me.Chofer.DataPropertyName = "v_choferAyN"
        Me.Chofer.HeaderText = "Chofer"
        Me.Chofer.Name = "Chofer"
        Me.Chofer.ReadOnly = True
        '
        'FrmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 485)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmPedidos"
        Me.Text = "Pedidos"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPedidos.ResumeLayout(False)
        CType(Me.BgsPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents cmsPedidos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BgsPedido As System.Windows.Forms.BindingSource
    Friend WithEvents ReclToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colPedReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_movil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancelado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chofer As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
