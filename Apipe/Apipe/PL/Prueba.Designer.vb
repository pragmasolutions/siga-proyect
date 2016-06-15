<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prueba
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.spcCol123 = New System.Windows.Forms.SplitContainer()
        Me.spcIzq = New System.Windows.Forms.SplitContainer()
        Me.gbxPedido = New System.Windows.Forms.GroupBox()
        Me.btnBloqueaPedido = New System.Windows.Forms.Button()
        Me.btnEntraPedido = New System.Windows.Forms.Button()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.txtDirTel = New System.Windows.Forms.TextBox()
        Me.txtObservPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvACompletar = New System.Windows.Forms.DataGridView()
        Me.colACompAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompChofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spcCol2y3 = New System.Windows.Forms.SplitContainer()
        Me.spcCentro = New System.Windows.Forms.SplitContainer()
        Me.lblTituloPedidos = New System.Windows.Forms.Label()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.colPedHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedHoraViaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spcDcha = New System.Windows.Forms.SplitContainer()
        Me.gbxMovil = New System.Windows.Forms.GroupBox()
        Me.lklCancelarAsignacion = New System.Windows.Forms.LinkLabel()
        Me.lblBaul = New System.Windows.Forms.Label()
        Me.chkAire = New System.Windows.Forms.CheckBox()
        Me.txtChoferMovil = New System.Windows.Forms.TextBox()
        Me.txtObservMovil = New System.Windows.Forms.TextBox()
        Me.dgvMoviles = New System.Windows.Forms.DataGridView()
        Me.colMovNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovChofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovCantPedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovUltPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompCompletar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colPedAsignar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colMovAsignar = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.spcCol123, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcCol123.Panel1.SuspendLayout()
        Me.spcCol123.Panel2.SuspendLayout()
        Me.spcCol123.SuspendLayout()
        CType(Me.spcIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcIzq.Panel1.SuspendLayout()
        Me.spcIzq.Panel2.SuspendLayout()
        Me.spcIzq.SuspendLayout()
        Me.gbxPedido.SuspendLayout()
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcCol2y3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcCol2y3.Panel1.SuspendLayout()
        Me.spcCol2y3.Panel2.SuspendLayout()
        Me.spcCol2y3.SuspendLayout()
        CType(Me.spcCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcCentro.Panel1.SuspendLayout()
        Me.spcCentro.Panel2.SuspendLayout()
        Me.spcCentro.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcDcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcDcha.Panel1.SuspendLayout()
        Me.spcDcha.Panel2.SuspendLayout()
        Me.spcDcha.SuspendLayout()
        Me.gbxMovil.SuspendLayout()
        CType(Me.dgvMoviles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcCol123
        '
        Me.spcCol123.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcCol123.Location = New System.Drawing.Point(0, 0)
        Me.spcCol123.Name = "spcCol123"
        '
        'spcCol123.Panel1
        '
        Me.spcCol123.Panel1.Controls.Add(Me.spcIzq)
        '
        'spcCol123.Panel2
        '
        Me.spcCol123.Panel2.Controls.Add(Me.spcCol2y3)
        Me.spcCol123.Size = New System.Drawing.Size(1032, 501)
        Me.spcCol123.SplitterDistance = 285
        Me.spcCol123.SplitterWidth = 5
        Me.spcCol123.TabIndex = 0
        '
        'spcIzq
        '
        Me.spcIzq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcIzq.Location = New System.Drawing.Point(0, 0)
        Me.spcIzq.Name = "spcIzq"
        Me.spcIzq.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcIzq.Panel1
        '
        Me.spcIzq.Panel1.Controls.Add(Me.gbxPedido)
        '
        'spcIzq.Panel2
        '
        Me.spcIzq.Panel2.Controls.Add(Me.Label1)
        Me.spcIzq.Panel2.Controls.Add(Me.dgvACompletar)
        Me.spcIzq.Size = New System.Drawing.Size(285, 501)
        Me.spcIzq.SplitterDistance = 182
        Me.spcIzq.TabIndex = 0
        '
        'gbxPedido
        '
        Me.gbxPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPedido.Controls.Add(Me.btnBloqueaPedido)
        Me.gbxPedido.Controls.Add(Me.btnEntraPedido)
        Me.gbxPedido.Controls.Add(Me.txtPedido)
        Me.gbxPedido.Controls.Add(Me.txtDirTel)
        Me.gbxPedido.Controls.Add(Me.txtObservPedido)
        Me.gbxPedido.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxPedido.Location = New System.Drawing.Point(3, 3)
        Me.gbxPedido.Name = "gbxPedido"
        Me.gbxPedido.Size = New System.Drawing.Size(279, 176)
        Me.gbxPedido.TabIndex = 0
        Me.gbxPedido.TabStop = False
        Me.gbxPedido.Text = "PEDIDO"
        '
        'btnBloqueaPedido
        '
        Me.btnBloqueaPedido.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBloqueaPedido.Location = New System.Drawing.Point(47, 147)
        Me.btnBloqueaPedido.Name = "btnBloqueaPedido"
        Me.btnBloqueaPedido.Size = New System.Drawing.Size(110, 23)
        Me.btnBloqueaPedido.TabIndex = 7
        Me.btnBloqueaPedido.Text = "BloqueaPedido"
        Me.btnBloqueaPedido.UseVisualStyleBackColor = True
        '
        'btnEntraPedido
        '
        Me.btnEntraPedido.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntraPedido.Location = New System.Drawing.Point(163, 147)
        Me.btnEntraPedido.Name = "btnEntraPedido"
        Me.btnEntraPedido.Size = New System.Drawing.Size(110, 23)
        Me.btnEntraPedido.TabIndex = 7
        Me.btnEntraPedido.Text = "EntraPedido"
        Me.btnEntraPedido.UseVisualStyleBackColor = True
        '
        'txtPedido
        '
        Me.txtPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPedido.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.ForeColor = System.Drawing.Color.White
        Me.txtPedido.Location = New System.Drawing.Point(9, 78)
        Me.txtPedido.Multiline = True
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.ReadOnly = True
        Me.txtPedido.Size = New System.Drawing.Size(264, 30)
        Me.txtPedido.TabIndex = 4
        Me.txtPedido.Text = "Categoría XX " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Viaje: 19:23    Pedido: 19:15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDirTel
        '
        Me.txtDirTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtDirTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDirTel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirTel.ForeColor = System.Drawing.Color.LightBlue
        Me.txtDirTel.Location = New System.Drawing.Point(9, 30)
        Me.txtDirTel.Multiline = True
        Me.txtDirTel.Name = "txtDirTel"
        Me.txtDirTel.ReadOnly = True
        Me.txtDirTel.Size = New System.Drawing.Size(264, 46)
        Me.txtDirTel.TabIndex = 5
        Me.txtDirTel.Text = "Jujuy 450 casa 6 PB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "431701 Ana Laura Bubenik"
        '
        'txtObservPedido
        '
        Me.txtObservPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtObservPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservPedido.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservPedido.ForeColor = System.Drawing.Color.White
        Me.txtObservPedido.Location = New System.Drawing.Point(9, 114)
        Me.txtObservPedido.Multiline = True
        Me.txtObservPedido.Name = "txtObservPedido"
        Me.txtObservPedido.ReadOnly = True
        Me.txtObservPedido.Size = New System.Drawing.Size(264, 56)
        Me.txtObservPedido.TabIndex = 6
        Me.txtObservPedido.Text = "Con cambio de 100. Tocar bocina cuando llegue."
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PEDIDOS A COMPLETAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvACompletar
        '
        Me.dgvACompletar.AllowUserToAddRows = False
        Me.dgvACompletar.AllowUserToDeleteRows = False
        Me.dgvACompletar.AllowUserToResizeRows = False
        Me.dgvACompletar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvACompletar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvACompletar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvACompletar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colACompAsignado, Me.colACompDomicilio, Me.colACompCompletar, Me.colACompCliente, Me.colACompMovil, Me.colACompChofer})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvACompletar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvACompletar.Location = New System.Drawing.Point(0, 39)
        Me.dgvACompletar.Name = "dgvACompletar"
        Me.dgvACompletar.ReadOnly = True
        Me.dgvACompletar.RowHeadersVisible = False
        Me.dgvACompletar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvACompletar.Size = New System.Drawing.Size(285, 276)
        Me.dgvACompletar.TabIndex = 0
        '
        'colACompAsignado
        '
        Me.colACompAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colACompAsignado.DataPropertyName = "v_hora_asignado"
        Me.colACompAsignado.HeaderText = "Hora"
        Me.colACompAsignado.Name = "colACompAsignado"
        Me.colACompAsignado.ReadOnly = True
        Me.colACompAsignado.Width = 59
        '
        'colACompDomicilio
        '
        Me.colACompDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompDomicilio.DataPropertyName = "v_domicilio"
        Me.colACompDomicilio.HeaderText = "Domicilio"
        Me.colACompDomicilio.Name = "colACompDomicilio"
        Me.colACompDomicilio.ReadOnly = True
        '
        'colACompCliente
        '
        Me.colACompCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCliente.DataPropertyName = "cliente"
        Me.colACompCliente.HeaderText = "Cliente"
        Me.colACompCliente.Name = "colACompCliente"
        Me.colACompCliente.ReadOnly = True
        '
        'colACompMovil
        '
        Me.colACompMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompMovil.DataPropertyName = "v_modeloChapa"
        Me.colACompMovil.HeaderText = "Movil"
        Me.colACompMovil.Name = "colACompMovil"
        Me.colACompMovil.ReadOnly = True
        '
        'colACompChofer
        '
        Me.colACompChofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompChofer.DataPropertyName = "v_choferAyN"
        Me.colACompChofer.HeaderText = "Chofer"
        Me.colACompChofer.Name = "colACompChofer"
        Me.colACompChofer.ReadOnly = True
        '
        'spcCol2y3
        '
        Me.spcCol2y3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcCol2y3.Location = New System.Drawing.Point(0, 0)
        Me.spcCol2y3.Name = "spcCol2y3"
        '
        'spcCol2y3.Panel1
        '
        Me.spcCol2y3.Panel1.Controls.Add(Me.spcCentro)
        '
        'spcCol2y3.Panel2
        '
        Me.spcCol2y3.Panel2.Controls.Add(Me.spcDcha)
        Me.spcCol2y3.Size = New System.Drawing.Size(742, 501)
        Me.spcCol2y3.SplitterDistance = 434
        Me.spcCol2y3.SplitterWidth = 5
        Me.spcCol2y3.TabIndex = 0
        '
        'spcCentro
        '
        Me.spcCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcCentro.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spcCentro.Location = New System.Drawing.Point(0, 0)
        Me.spcCentro.Name = "spcCentro"
        Me.spcCentro.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcCentro.Panel1
        '
        Me.spcCentro.Panel1.Controls.Add(Me.lblTituloPedidos)
        '
        'spcCentro.Panel2
        '
        Me.spcCentro.Panel2.Controls.Add(Me.dgvPedidos)
        Me.spcCentro.Size = New System.Drawing.Size(434, 501)
        Me.spcCentro.SplitterDistance = 36
        Me.spcCentro.TabIndex = 0
        '
        'lblTituloPedidos
        '
        Me.lblTituloPedidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTituloPedidos.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPedidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblTituloPedidos.Location = New System.Drawing.Point(98, 9)
        Me.lblTituloPedidos.Name = "lblTituloPedidos"
        Me.lblTituloPedidos.Size = New System.Drawing.Size(242, 24)
        Me.lblTituloPedidos.TabIndex = 0
        Me.lblTituloPedidos.Text = "PEDIDOS PENDIENTES"
        Me.lblTituloPedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AllowUserToResizeRows = False
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPedHora, Me.colPedHoraViaje, Me.colPedDomicilio, Me.colPedAsignar, Me.colPedCliente, Me.colPedObservacion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPedidos.Location = New System.Drawing.Point(0, 0)
        Me.dgvPedidos.MultiSelect = False
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(434, 461)
        Me.dgvPedidos.TabIndex = 0
        '
        'colPedHora
        '
        Me.colPedHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colPedHora.DataPropertyName = "v_hora"
        Me.colPedHora.HeaderText = "Hora"
        Me.colPedHora.Name = "colPedHora"
        Me.colPedHora.ReadOnly = True
        Me.colPedHora.Width = 59
        '
        'colPedHoraViaje
        '
        Me.colPedHoraViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colPedHoraViaje.DataPropertyName = "v_hora_viaje"
        Me.colPedHoraViaje.HeaderText = "Hora Viaje"
        Me.colPedHoraViaje.Name = "colPedHoraViaje"
        Me.colPedHoraViaje.ReadOnly = True
        Me.colPedHoraViaje.Width = 92
        '
        'colPedDomicilio
        '
        Me.colPedDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedDomicilio.DataPropertyName = "v_domicilio"
        Me.colPedDomicilio.HeaderText = "Domicilio"
        Me.colPedDomicilio.Name = "colPedDomicilio"
        Me.colPedDomicilio.ReadOnly = True
        Me.colPedDomicilio.Width = 140
        '
        'colPedCliente
        '
        Me.colPedCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedCliente.DataPropertyName = "cliente"
        Me.colPedCliente.HeaderText = "Cliente"
        Me.colPedCliente.Name = "colPedCliente"
        Me.colPedCliente.ReadOnly = True
        Me.colPedCliente.Width = 120
        '
        'colPedObservacion
        '
        Me.colPedObservacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedObservacion.DataPropertyName = "observacion"
        Me.colPedObservacion.HeaderText = "Observaciones"
        Me.colPedObservacion.Name = "colPedObservacion"
        Me.colPedObservacion.ReadOnly = True
        '
        'spcDcha
        '
        Me.spcDcha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcDcha.Location = New System.Drawing.Point(0, 0)
        Me.spcDcha.Name = "spcDcha"
        Me.spcDcha.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcDcha.Panel1
        '
        Me.spcDcha.Panel1.Controls.Add(Me.gbxMovil)
        '
        'spcDcha.Panel2
        '
        Me.spcDcha.Panel2.Controls.Add(Me.dgvMoviles)
        Me.spcDcha.Size = New System.Drawing.Size(303, 501)
        Me.spcDcha.SplitterDistance = 173
        Me.spcDcha.TabIndex = 0
        '
        'gbxMovil
        '
        Me.gbxMovil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxMovil.Controls.Add(Me.lklCancelarAsignacion)
        Me.gbxMovil.Controls.Add(Me.lblBaul)
        Me.gbxMovil.Controls.Add(Me.chkAire)
        Me.gbxMovil.Controls.Add(Me.txtChoferMovil)
        Me.gbxMovil.Controls.Add(Me.txtObservMovil)
        Me.gbxMovil.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMovil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxMovil.Location = New System.Drawing.Point(3, 3)
        Me.gbxMovil.Name = "gbxMovil"
        Me.gbxMovil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbxMovil.Size = New System.Drawing.Size(297, 167)
        Me.gbxMovil.TabIndex = 0
        Me.gbxMovil.TabStop = False
        Me.gbxMovil.Text = "MÓVIL 13"
        '
        'lklCancelarAsignacion
        '
        Me.lklCancelarAsignacion.AutoSize = True
        Me.lklCancelarAsignacion.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancelarAsignacion.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lklCancelarAsignacion.Location = New System.Drawing.Point(7, 0)
        Me.lklCancelarAsignacion.Name = "lklCancelarAsignacion"
        Me.lklCancelarAsignacion.Size = New System.Drawing.Size(81, 19)
        Me.lklCancelarAsignacion.TabIndex = 10
        Me.lklCancelarAsignacion.TabStop = True
        Me.lklCancelarAsignacion.Text = "Cancelar"
        '
        'lblBaul
        '
        Me.lblBaul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBaul.AutoSize = True
        Me.lblBaul.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaul.Location = New System.Drawing.Point(78, 65)
        Me.lblBaul.Name = "lblBaul"
        Me.lblBaul.Size = New System.Drawing.Size(76, 13)
        Me.lblBaul.TabIndex = 9
        Me.lblBaul.Text = "Baúl grande"
        '
        'chkAire
        '
        Me.chkAire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAire.AutoSize = True
        Me.chkAire.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAire.Location = New System.Drawing.Point(6, 64)
        Me.chkAire.Name = "chkAire"
        Me.chkAire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAire.Size = New System.Drawing.Size(49, 17)
        Me.chkAire.TabIndex = 8
        Me.chkAire.Text = "Aire"
        Me.chkAire.UseVisualStyleBackColor = True
        '
        'txtChoferMovil
        '
        Me.txtChoferMovil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChoferMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtChoferMovil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChoferMovil.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoferMovil.ForeColor = System.Drawing.Color.LightBlue
        Me.txtChoferMovil.Location = New System.Drawing.Point(6, 27)
        Me.txtChoferMovil.Multiline = True
        Me.txtChoferMovil.Name = "txtChoferMovil"
        Me.txtChoferMovil.ReadOnly = True
        Me.txtChoferMovil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChoferMovil.Size = New System.Drawing.Size(285, 39)
        Me.txtChoferMovil.TabIndex = 6
        Me.txtChoferMovil.Text = "Juan Almada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chevrolet Corsa Azul DCS-813"
        '
        'txtObservMovil
        '
        Me.txtObservMovil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtObservMovil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservMovil.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservMovil.ForeColor = System.Drawing.Color.White
        Me.txtObservMovil.Location = New System.Drawing.Point(6, 87)
        Me.txtObservMovil.Multiline = True
        Me.txtObservMovil.Name = "txtObservMovil"
        Me.txtObservMovil.ReadOnly = True
        Me.txtObservMovil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservMovil.Size = New System.Drawing.Size(285, 74)
        Me.txtObservMovil.TabIndex = 7
        Me.txtObservMovil.Text = "----" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Otras observaciones.."
        '
        'dgvMoviles
        '
        Me.dgvMoviles.AllowUserToAddRows = False
        Me.dgvMoviles.AllowUserToDeleteRows = False
        Me.dgvMoviles.AllowUserToResizeRows = False
        Me.dgvMoviles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvMoviles.ColumnHeadersHeight = 24
        Me.dgvMoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMoviles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMovNro, Me.colMovChofer, Me.colMovModelo, Me.colMovCantPedidos, Me.colMovUltPed, Me.colMovAsignar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMoviles.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMoviles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMoviles.Location = New System.Drawing.Point(0, 0)
        Me.dgvMoviles.MultiSelect = False
        Me.dgvMoviles.Name = "dgvMoviles"
        Me.dgvMoviles.ReadOnly = True
        Me.dgvMoviles.RowHeadersVisible = False
        Me.dgvMoviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMoviles.Size = New System.Drawing.Size(303, 324)
        Me.dgvMoviles.TabIndex = 0
        '
        'colMovNro
        '
        Me.colMovNro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colMovNro.DataPropertyName = "v_nroMovil"
        Me.colMovNro.HeaderText = "Movil"
        Me.colMovNro.Name = "colMovNro"
        Me.colMovNro.ReadOnly = True
        Me.colMovNro.Width = 61
        '
        'colMovChofer
        '
        Me.colMovChofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovChofer.DataPropertyName = "v_chofer_AyN"
        Me.colMovChofer.HeaderText = "Chofer"
        Me.colMovChofer.Name = "colMovChofer"
        Me.colMovChofer.ReadOnly = True
        Me.colMovChofer.Width = 120
        '
        'colMovModelo
        '
        Me.colMovModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovModelo.DataPropertyName = "v_modelo"
        Me.colMovModelo.HeaderText = "Modelo"
        Me.colMovModelo.Name = "colMovModelo"
        Me.colMovModelo.ReadOnly = True
        '
        'colMovCantPedidos
        '
        Me.colMovCantPedidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colMovCantPedidos.DataPropertyName = "v_cantidadPedidosTurno"
        Me.colMovCantPedidos.HeaderText = "# Ped"
        Me.colMovCantPedidos.Name = "colMovCantPedidos"
        Me.colMovCantPedidos.ReadOnly = True
        Me.colMovCantPedidos.Width = 66
        '
        'colMovUltPed
        '
        Me.colMovUltPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colMovUltPed.DataPropertyName = "v_UltimoPedido"
        Me.colMovUltPed.HeaderText = "Último"
        Me.colMovUltPed.Name = "colMovUltPed"
        Me.colMovUltPed.ReadOnly = True
        Me.colMovUltPed.Width = 68
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.FillWeight = 120.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 20
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.FillWeight = 120.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.ToolTipText = "Asignar un móvil"
        Me.DataGridViewImageColumn2.Width = 20
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ToolTipText = "Asignar al pedido"
        Me.DataGridViewImageColumn3.Width = 30
        '
        'colACompCompletar
        '
        Me.colACompCompletar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCompletar.HeaderText = ""
        Me.colACompCompletar.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.colACompCompletar.Name = "colACompCompletar"
        Me.colACompCompletar.ReadOnly = True
        Me.colACompCompletar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colACompCompletar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colACompCompletar.Width = 20
        '
        'colPedAsignar
        '
        Me.colPedAsignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedAsignar.FillWeight = 120.0!
        Me.colPedAsignar.HeaderText = ""
        Me.colPedAsignar.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.colPedAsignar.Name = "colPedAsignar"
        Me.colPedAsignar.ReadOnly = True
        Me.colPedAsignar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPedAsignar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPedAsignar.ToolTipText = "Asignar un móvil"
        Me.colPedAsignar.Width = 20
        '
        'colMovAsignar
        '
        Me.colMovAsignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovAsignar.HeaderText = ""
        Me.colMovAsignar.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.colMovAsignar.Name = "colMovAsignar"
        Me.colMovAsignar.ReadOnly = True
        Me.colMovAsignar.ToolTipText = "Asignar al pedido"
        Me.colMovAsignar.Width = 30
        '
        'Prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 501)
        Me.Controls.Add(Me.spcCol123)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Prueba"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prueba"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.spcCol123.Panel1.ResumeLayout(False)
        Me.spcCol123.Panel2.ResumeLayout(False)
        CType(Me.spcCol123, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcCol123.ResumeLayout(False)
        Me.spcIzq.Panel1.ResumeLayout(False)
        Me.spcIzq.Panel2.ResumeLayout(False)
        CType(Me.spcIzq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcIzq.ResumeLayout(False)
        Me.gbxPedido.ResumeLayout(False)
        Me.gbxPedido.PerformLayout()
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcCol2y3.Panel1.ResumeLayout(False)
        Me.spcCol2y3.Panel2.ResumeLayout(False)
        CType(Me.spcCol2y3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcCol2y3.ResumeLayout(False)
        Me.spcCentro.Panel1.ResumeLayout(False)
        Me.spcCentro.Panel2.ResumeLayout(False)
        CType(Me.spcCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcCentro.ResumeLayout(False)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDcha.Panel1.ResumeLayout(False)
        Me.spcDcha.Panel2.ResumeLayout(False)
        CType(Me.spcDcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDcha.ResumeLayout(False)
        Me.gbxMovil.ResumeLayout(False)
        Me.gbxMovil.PerformLayout()
        CType(Me.dgvMoviles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcCol123 As System.Windows.Forms.SplitContainer
    Friend WithEvents spcCol2y3 As System.Windows.Forms.SplitContainer
    Friend WithEvents spcIzq As System.Windows.Forms.SplitContainer
    Friend WithEvents spcCentro As System.Windows.Forms.SplitContainer
    Friend WithEvents spcDcha As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvACompletar As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMoviles As System.Windows.Forms.DataGridView
    Friend WithEvents lblTituloPedidos As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents gbxPedido As System.Windows.Forms.GroupBox
    Friend WithEvents txtPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtDirTel As System.Windows.Forms.TextBox
    Friend WithEvents txtObservPedido As System.Windows.Forms.TextBox
    Friend WithEvents gbxMovil As System.Windows.Forms.GroupBox
    Friend WithEvents chkAire As System.Windows.Forms.CheckBox
    Friend WithEvents txtChoferMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtObservMovil As System.Windows.Forms.TextBox
    Friend WithEvents lblBaul As System.Windows.Forms.Label
    Friend WithEvents colMovNro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovChofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovModelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovCantPedidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovUltPed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovAsignar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnEntraPedido As System.Windows.Forms.Button
    Friend WithEvents lklCancelarAsignacion As System.Windows.Forms.LinkLabel
    Friend WithEvents btnBloqueaPedido As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colACompAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCompletar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompChofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedHoraViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedAsignar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPedCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedObservacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
End Class
