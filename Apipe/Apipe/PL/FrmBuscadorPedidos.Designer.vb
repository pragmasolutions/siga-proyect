<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscadorPedidos
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
        Me.dgvBuscadorPedidos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCategoriaPedido = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.cmsPedidos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReclamoPorTardanzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReclamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDiferidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caracteristica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechahora_viaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Movil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reclamos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBuscadorPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.cmsPedidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBuscadorPedidos
        '
        Me.dgvBuscadorPedidos.AllowUserToAddRows = False
        Me.dgvBuscadorPedidos.AllowUserToDeleteRows = False
        Me.dgvBuscadorPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBuscadorPedidos.BackgroundColor = System.Drawing.Color.White
        Me.dgvBuscadorPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBuscadorPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBuscadorPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscadorPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente, Me.domicilio, Me.Observaciones, Me.Caracteristica, Me.telefono, Me.fechahora_viaje, Me.Telefonista, Me.Operador, Me.Movil, Me.reclamos, Me.asignado, Me.completado, Me.cancelado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBuscadorPedidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBuscadorPedidos.GridColor = System.Drawing.Color.DimGray
        Me.dgvBuscadorPedidos.Location = New System.Drawing.Point(12, 148)
        Me.dgvBuscadorPedidos.Name = "dgvBuscadorPedidos"
        Me.dgvBuscadorPedidos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBuscadorPedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBuscadorPedidos.RowHeadersVisible = False
        Me.dgvBuscadorPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscadorPedidos.Size = New System.Drawing.Size(911, 294)
        Me.dgvBuscadorPedidos.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbCategoriaPedido)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpHasta)
        Me.Panel1.Controls.Add(Me.dtpDesde)
        Me.Panel1.Font = New System.Drawing.Font("Consolas", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 126)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo: "
        '
        'cbCategoriaPedido
        '
        Me.cbCategoriaPedido.FormattingEnabled = True
        Me.cbCategoriaPedido.Location = New System.Drawing.Point(79, 64)
        Me.cbCategoriaPedido.Name = "cbCategoriaPedido"
        Me.cbCategoriaPedido.Size = New System.Drawing.Size(200, 22)
        Me.cbCategoriaPedido.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(303, 78)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 34)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde: "
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(79, 36)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpHasta.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(79, 3)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpDesde.TabIndex = 0
        '
        'cmsPedidos
        '
        Me.cmsPedidos.BackColor = System.Drawing.Color.Black
        Me.cmsPedidos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmsPedidos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReclamoPorTardanzaToolStripMenuItem, Me.ReclamoToolStripMenuItem, Me.CancelarPedidoToolStripMenuItem, Me.ModificarDiferidoToolStripMenuItem})
        Me.cmsPedidos.Name = "cmsPedidos"
        Me.cmsPedidos.Size = New System.Drawing.Size(215, 92)
        '
        'ReclamoPorTardanzaToolStripMenuItem
        '
        Me.ReclamoPorTardanzaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ReclamoPorTardanzaToolStripMenuItem.Name = "ReclamoPorTardanzaToolStripMenuItem"
        Me.ReclamoPorTardanzaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ReclamoPorTardanzaToolStripMenuItem.Text = "Reclamo por tardanza"
        '
        'ReclamoToolStripMenuItem
        '
        Me.ReclamoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ReclamoToolStripMenuItem.Name = "ReclamoToolStripMenuItem"
        Me.ReclamoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ReclamoToolStripMenuItem.Text = "Otro reclamo"
        '
        'CancelarPedidoToolStripMenuItem
        '
        Me.CancelarPedidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.CancelarPedidoToolStripMenuItem.Name = "CancelarPedidoToolStripMenuItem"
        Me.CancelarPedidoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CancelarPedidoToolStripMenuItem.Text = "Cancelar Pedido"
        '
        'ModificarDiferidoToolStripMenuItem
        '
        Me.ModificarDiferidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ModificarDiferidoToolStripMenuItem.Name = "ModificarDiferidoToolStripMenuItem"
        Me.ModificarDiferidoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ModificarDiferidoToolStripMenuItem.Text = "Modificar Diferido"
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "v_clienteayn"
        Me.cliente.FillWeight = 59.78568!
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 150
        '
        'domicilio
        '
        Me.domicilio.DataPropertyName = "v_domicilio"
        Me.domicilio.FillWeight = 59.78568!
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Width = 300
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "observacion"
        Me.Observaciones.FillWeight = 59.78568!
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 150
        '
        'Caracteristica
        '
        Me.Caracteristica.DataPropertyName = "v_cod_area"
        Me.Caracteristica.HeaderText = "Caracteristica"
        Me.Caracteristica.Name = "Caracteristica"
        Me.Caracteristica.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "v_telefono"
        Me.telefono.FillWeight = 59.78568!
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 80
        '
        'fechahora_viaje
        '
        Me.fechahora_viaje.DataPropertyName = "v_hora_viaje"
        Me.fechahora_viaje.FillWeight = 461.929!
        Me.fechahora_viaje.HeaderText = "Fecha y Hora"
        Me.fechahora_viaje.Name = "fechahora_viaje"
        Me.fechahora_viaje.ReadOnly = True
        Me.fechahora_viaje.Width = 150
        '
        'Telefonista
        '
        Me.Telefonista.DataPropertyName = "v_Telefonista"
        Me.Telefonista.HeaderText = "Telefonista"
        Me.Telefonista.Name = "Telefonista"
        Me.Telefonista.ReadOnly = True
        '
        'Operador
        '
        Me.Operador.DataPropertyName = "v_Operador"
        Me.Operador.HeaderText = "Operador"
        Me.Operador.Name = "Operador"
        Me.Operador.ReadOnly = True
        '
        'Movil
        '
        Me.Movil.DataPropertyName = "v_Nromovil"
        Me.Movil.FillWeight = 59.78568!
        Me.Movil.HeaderText = "Movil"
        Me.Movil.Name = "Movil"
        Me.Movil.ReadOnly = True
        Me.Movil.Width = 80
        '
        'reclamos
        '
        Me.reclamos.DataPropertyName = "v_reclamos"
        Me.reclamos.FillWeight = 59.78568!
        Me.reclamos.HeaderText = "Reclamos"
        Me.reclamos.Name = "reclamos"
        Me.reclamos.ReadOnly = True
        Me.reclamos.Width = 150
        '
        'asignado
        '
        Me.asignado.DataPropertyName = "v_hora_asignado"
        Me.asignado.FillWeight = 59.78568!
        Me.asignado.HeaderText = "Asignado"
        Me.asignado.Name = "asignado"
        Me.asignado.ReadOnly = True
        Me.asignado.Width = 150
        '
        'completado
        '
        Me.completado.DataPropertyName = "v_hora_completado"
        Me.completado.FillWeight = 59.78568!
        Me.completado.HeaderText = "Completado"
        Me.completado.Name = "completado"
        Me.completado.ReadOnly = True
        Me.completado.Width = 150
        '
        'cancelado
        '
        Me.cancelado.DataPropertyName = "v_hora_cancelado"
        Me.cancelado.FillWeight = 59.78568!
        Me.cancelado.HeaderText = "Cancelado"
        Me.cancelado.Name = "cancelado"
        Me.cancelado.ReadOnly = True
        Me.cancelado.Width = 150
        '
        'FrmBuscadorPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(935, 454)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvBuscadorPedidos)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FrmBuscadorPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador de Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBuscadorPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cmsPedidos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBuscadorPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents cbCategoriaPedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmsPedidos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReclamoPorTardanzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReclamoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarDiferidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caracteristica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechahora_viaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reclamos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cancelado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
