<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPanelContTelefonistas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPanelContTelefonistas))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.colPedAsignar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colPedReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colPedHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedHoraViaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvACompletar = New System.Windows.Forms.DataGridView()
        Me.colACompAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acTelefonista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBases = New System.Windows.Forms.Panel()
        Me.dgvCompletados = New System.Windows.Forms.DataGridView()
        Me.colComVolver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colComReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvZT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout
        CType(Me.dgvPedidos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        CType(Me.dgvACompletar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlBases.SuspendLayout
        CType(Me.dgvCompletados,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvZT,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(29,Byte),Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvPedidos)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 655)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pedidos Pendientes"
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = false
        Me.dgvPedidos.AllowUserToDeleteRows = false
        Me.dgvPedidos.AllowUserToResizeRows = false
        Me.dgvPedidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPedAsignar, Me.colPedReclamo, Me.colPedHora, Me.colPedHoraViaje, Me.colPedObservaciones, Me.colPedDomicilio, Me.Telefonista, Me.Telefono})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(29,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidos.Location = New System.Drawing.Point(19, 27)
        Me.dgvPedidos.MultiSelect = false
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = true
        Me.dgvPedidos.RowHeadersVisible = false
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(559, 610)
        Me.dgvPedidos.StandardTab = true
        Me.dgvPedidos.TabIndex = 1
        '
        'colPedAsignar
        '
        Me.colPedAsignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedAsignar.FillWeight = 120!
        Me.colPedAsignar.HeaderText = ""
        Me.colPedAsignar.Image = CType(resources.GetObject("colPedAsignar.Image"),System.Drawing.Image)
        Me.colPedAsignar.Name = "colPedAsignar"
        Me.colPedAsignar.ReadOnly = true
        Me.colPedAsignar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPedAsignar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPedAsignar.ToolTipText = "Asignar un móvil"
        Me.colPedAsignar.Visible = false
        Me.colPedAsignar.Width = 20
        '
        'colPedReclamo
        '
        Me.colPedReclamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedReclamo.HeaderText = ""
        Me.colPedReclamo.Name = "colPedReclamo"
        Me.colPedReclamo.ReadOnly = true
        Me.colPedReclamo.Visible = false
        Me.colPedReclamo.Width = 20
        '
        'colPedHora
        '
        Me.colPedHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedHora.DataPropertyName = "v_hora"
        Me.colPedHora.HeaderText = "Pedido"
        Me.colPedHora.Name = "colPedHora"
        Me.colPedHora.ReadOnly = true
        Me.colPedHora.Visible = false
        Me.colPedHora.Width = 80
        '
        'colPedHoraViaje
        '
        Me.colPedHoraViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedHoraViaje.DataPropertyName = "v_hora_viaje"
        Me.colPedHoraViaje.HeaderText = "Viaje"
        Me.colPedHoraViaje.Name = "colPedHoraViaje"
        Me.colPedHoraViaje.ReadOnly = true
        Me.colPedHoraViaje.Width = 80
        '
        'colPedObservaciones
        '
        Me.colPedObservaciones.DataPropertyName = "observacion"
        Me.colPedObservaciones.HeaderText = "Observaciones"
        Me.colPedObservaciones.Name = "colPedObservaciones"
        Me.colPedObservaciones.ReadOnly = true
        '
        'colPedDomicilio
        '
        Me.colPedDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedDomicilio.DataPropertyName = "v_domicilio"
        Me.colPedDomicilio.HeaderText = "Domicilio"
        Me.colPedDomicilio.Name = "colPedDomicilio"
        Me.colPedDomicilio.ReadOnly = true
        Me.colPedDomicilio.Width = 220
        '
        'Telefonista
        '
        Me.Telefonista.DataPropertyName = "v_Telefonista"
        Me.Telefonista.HeaderText = "Telefonista"
        Me.Telefonista.Name = "Telefonista"
        Me.Telefonista.ReadOnly = true
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "v_tel_completo"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = true
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = true
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dgvACompletar)
        Me.Panel2.Location = New System.Drawing.Point(596, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 336)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pedidos a Completar"
        '
        'dgvACompletar
        '
        Me.dgvACompletar.AllowUserToAddRows = false
        Me.dgvACompletar.AllowUserToDeleteRows = false
        Me.dgvACompletar.AllowUserToResizeRows = false
        Me.dgvACompletar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvACompletar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvACompletar.BackgroundColor = System.Drawing.Color.White
        Me.dgvACompletar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvACompletar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvACompletar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colACompAsignado, Me.colACompMovil, Me.colACompDomicilio, Me.colACompCliente, Me.acTelefonista, Me.acTelefono})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(29,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvACompletar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvACompletar.GridColor = System.Drawing.Color.DimGray
        Me.dgvACompletar.Location = New System.Drawing.Point(14, 27)
        Me.dgvACompletar.MultiSelect = false
        Me.dgvACompletar.Name = "dgvACompletar"
        Me.dgvACompletar.ReadOnly = true
        Me.dgvACompletar.RowHeadersVisible = false
        Me.dgvACompletar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvACompletar.Size = New System.Drawing.Size(634, 293)
        Me.dgvACompletar.StandardTab = true
        Me.dgvACompletar.TabIndex = 3
        '
        'colACompAsignado
        '
        Me.colACompAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompAsignado.DataPropertyName = "v_hora_asignado"
        Me.colACompAsignado.HeaderText = "Asignado"
        Me.colACompAsignado.Name = "colACompAsignado"
        Me.colACompAsignado.ReadOnly = true
        Me.colACompAsignado.Width = 80
        '
        'colACompMovil
        '
        Me.colACompMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompMovil.DataPropertyName = "v_nroMovil"
        Me.colACompMovil.HeaderText = "Movil"
        Me.colACompMovil.Name = "colACompMovil"
        Me.colACompMovil.ReadOnly = true
        Me.colACompMovil.Width = 50
        '
        'colACompDomicilio
        '
        Me.colACompDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompDomicilio.DataPropertyName = "v_domicilio"
        Me.colACompDomicilio.HeaderText = "Domicilio"
        Me.colACompDomicilio.Name = "colACompDomicilio"
        Me.colACompDomicilio.ReadOnly = true
        Me.colACompDomicilio.Width = 200
        '
        'colACompCliente
        '
        Me.colACompCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCliente.DataPropertyName = "cliente"
        Me.colACompCliente.HeaderText = "Cliente"
        Me.colACompCliente.Name = "colACompCliente"
        Me.colACompCliente.ReadOnly = true
        Me.colACompCliente.Width = 150
        '
        'acTelefonista
        '
        Me.acTelefonista.DataPropertyName = "v_telefonista"
        Me.acTelefonista.HeaderText = "Telefonista"
        Me.acTelefonista.Name = "acTelefonista"
        Me.acTelefonista.ReadOnly = true
        '
        'acTelefono
        '
        Me.acTelefono.DataPropertyName = "v_tel_completo"
        Me.acTelefono.HeaderText = "Telefono"
        Me.acTelefono.Name = "acTelefono"
        Me.acTelefono.ReadOnly = true
        '
        'pnlBases
        '
        Me.pnlBases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.pnlBases.AutoSize = true
        Me.pnlBases.BackColor = System.Drawing.Color.Orange
        Me.pnlBases.Controls.Add(Me.dgvCompletados)
        Me.pnlBases.Controls.Add(Me.Label3)
        Me.pnlBases.Controls.Add(Me.dgvZT)
        Me.pnlBases.Location = New System.Drawing.Point(596, 339)
        Me.pnlBases.Name = "pnlBases"
        Me.pnlBases.Size = New System.Drawing.Size(1031, 318)
        Me.pnlBases.TabIndex = 5
        '
        'dgvCompletados
        '
        Me.dgvCompletados.AllowUserToAddRows = false
        Me.dgvCompletados.AllowUserToDeleteRows = false
        Me.dgvCompletados.AllowUserToResizeRows = false
        Me.dgvCompletados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvCompletados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCompletados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.dgvCompletados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompletados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colComVolver, Me.colComReclamo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(29,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompletados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCompletados.Location = New System.Drawing.Point(17, 23)
        Me.dgvCompletados.MultiSelect = false
        Me.dgvCompletados.Name = "dgvCompletados"
        Me.dgvCompletados.ReadOnly = true
        Me.dgvCompletados.RowHeadersVisible = false
        Me.dgvCompletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompletados.Size = New System.Drawing.Size(632, 284)
        Me.dgvCompletados.StandardTab = true
        Me.dgvCompletados.TabIndex = 15
        '
        'colComVolver
        '
        Me.colComVolver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colComVolver.HeaderText = ""
        Me.colComVolver.Image = CType(resources.GetObject("colComVolver.Image"),System.Drawing.Image)
        Me.colComVolver.Name = "colComVolver"
        Me.colComVolver.ReadOnly = true
        Me.colComVolver.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colComVolver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colComVolver.Visible = false
        Me.colComVolver.Width = 20
        '
        'colComReclamo
        '
        Me.colComReclamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colComReclamo.HeaderText = ""
        Me.colComReclamo.Name = "colComReclamo"
        Me.colComReclamo.ReadOnly = true
        Me.colComReclamo.Visible = false
        Me.colComReclamo.Width = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "v_hora_asignado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Asignado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = true
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Movil"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = true
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "v_domicilio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = true
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = true
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Completados"
        '
        'dgvZT
        '
        Me.dgvZT.AllowUserToAddRows = false
        Me.dgvZT.AllowUserToDeleteRows = false
        Me.dgvZT.AllowUserToResizeRows = false
        Me.dgvZT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.dgvZT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvZT.BackgroundColor = System.Drawing.Color.White
        Me.dgvZT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvZT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn45})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(29,Byte),Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(9,Byte),Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZT.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvZT.Location = New System.Drawing.Point(773, 33)
        Me.dgvZT.MultiSelect = false
        Me.dgvZT.Name = "dgvZT"
        Me.dgvZT.ReadOnly = true
        Me.dgvZT.RowHeadersVisible = false
        Me.dgvZT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZT.Size = New System.Drawing.Size(49, 268)
        Me.dgvZT.StandardTab = true
        Me.dgvZT.TabIndex = 13
        Me.dgvZT.TabStop = false
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Ter"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = true
        Me.DataGridViewTextBoxColumn45.Width = 35
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.FillWeight = 120!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"),System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.ToolTipText = "Asignar un móvil"
        Me.DataGridViewImageColumn1.Visible = false
        Me.DataGridViewImageColumn1.Width = 20
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"),System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.ToolTipText = "Completar"
        Me.DataGridViewImageColumn2.Visible = false
        Me.DataGridViewImageColumn2.Width = 20
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"),System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Visible = false
        Me.DataGridViewImageColumn3.Width = 5
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn4.HeaderText = ""
        Me.DataGridViewImageColumn4.Image = CType(resources.GetObject("DataGridViewImageColumn4.Image"),System.Drawing.Image)
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ToolTipText = "Cambiar móvil"
        Me.DataGridViewImageColumn4.Visible = false
        Me.DataGridViewImageColumn4.Width = 20
        '
        'FormPanelContTelefonistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 781)
        Me.Controls.Add(Me.pnlBases)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Name = "FormPanelContTelefonistas"
        Me.Text = "Panel de Control"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.dgvPedidos,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.dgvACompletar,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlBases.ResumeLayout(false)
        Me.pnlBases.PerformLayout
        CType(Me.dgvCompletados,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvZT,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvACompletar As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBases As System.Windows.Forms.Panel
    Friend WithEvents dgvZT As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPedAsignar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPedReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPedHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedHoraViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acTelefonista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCompletados As System.Windows.Forms.DataGridView
    Friend WithEvents colComVolver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colComReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
