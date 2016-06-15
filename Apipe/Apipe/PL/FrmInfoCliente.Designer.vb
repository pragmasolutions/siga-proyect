<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfoCliente
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfoCliente))
        Me.cmsCliente = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlDiferido = New System.Windows.Forms.Panel()
        Me.btnCancelarPedido = New System.Windows.Forms.Button()
        Me.btnDiferido = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpDiferido = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDomicilios = New System.Windows.Forms.DataGridView()
        Me.colBtn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInterseccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsDomicilios = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btbPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoDiferidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModificarDom = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoDomicilioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDomicilioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.colPedReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_movil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsPedidos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReclamoPorTardanzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReclamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDiferidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarModificarObservacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panMain = New System.Windows.Forms.Panel()
        Me.progressLevelOutput = New System.Windows.Forms.ProgressBar()
        Me.progressLevelInput = New System.Windows.Forms.ProgressBar()
        Me.panDial = New System.Windows.Forms.Panel()
        Me.txtDial = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.panCommands = New System.Windows.Forms.Panel()
        Me.cmdTransfer = New System.Windows.Forms.Button()
        Me.cmdCall = New System.Windows.Forms.Button()
        Me.panLine1 = New System.Windows.Forms.Panel()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.lblCallDirection1 = New System.Windows.Forms.Label()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.cmdHangup = New System.Windows.Forms.Button()
        Me.cmdLine1 = New System.Windows.Forms.Button()
        Me.cmdPickUp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCallDirection2 = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.cmdDigit0 = New System.Windows.Forms.Button()
        Me.cmdLine2 = New System.Windows.Forms.Button()
        Me.cmdDigitSharp = New System.Windows.Forms.Button()
        Me.cmdDigit1 = New System.Windows.Forms.Button()
        Me.cmdDigitAsterisk = New System.Windows.Forms.Button()
        Me.cmdDigit3 = New System.Windows.Forms.Button()
        Me.cmdDigit8 = New System.Windows.Forms.Button()
        Me.cmdDigit2 = New System.Windows.Forms.Button()
        Me.cmdDigit9 = New System.Windows.Forms.Button()
        Me.cmdDigit4 = New System.Windows.Forms.Button()
        Me.cmdDigit7 = New System.Windows.Forms.Button()
        Me.cmdDigit6 = New System.Windows.Forms.Button()
        Me.cmdDigit5 = New System.Windows.Forms.Button()
        Me.cmdConfig = New System.Windows.Forms.Button()
        Me.panLcd = New System.Windows.Forms.Panel()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.txtDetalle = New System.Windows.Forms.RichTextBox()
        Me.notifyMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.timTime = New System.Windows.Forms.Timer(Me.components)
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.btnReclamos = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnModCte = New System.Windows.Forms.Button()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAdd50 = New System.Windows.Forms.Button()
        Me.pnlObservacion = New System.Windows.Forms.Panel()
        Me.BtnCancelarObservaciones = New System.Windows.Forms.Button()
        Me.btnObservaciones = New System.Windows.Forms.Button()
        Me.txtObserPedido = New System.Windows.Forms.TextBox()
        Me.cmsCliente.SuspendLayout()
        Me.pnlDiferido.SuspendLayout()
        CType(Me.DgvDomicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDomicilios.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPedidos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panMain.SuspendLayout()
        Me.panDial.SuspendLayout()
        Me.panCommands.SuspendLayout()
        Me.panLine1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlObservacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsCliente
        '
        Me.cmsCliente.BackColor = System.Drawing.Color.Black
        Me.cmsCliente.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.cmsCliente.Name = "cmsCliente"
        Me.cmsCliente.Size = New System.Drawing.Size(138, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'pnlDiferido
        '
        Me.pnlDiferido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlDiferido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDiferido.Controls.Add(Me.btnCancelarPedido)
        Me.pnlDiferido.Controls.Add(Me.btnDiferido)
        Me.pnlDiferido.Controls.Add(Me.Label3)
        Me.pnlDiferido.Controls.Add(Me.dtpHora)
        Me.pnlDiferido.Controls.Add(Me.dtpDiferido)
        Me.pnlDiferido.Controls.Add(Me.Label2)
        Me.pnlDiferido.Controls.Add(Me.Label1)
        Me.pnlDiferido.Location = New System.Drawing.Point(207, 84)
        Me.pnlDiferido.Name = "pnlDiferido"
        Me.pnlDiferido.Size = New System.Drawing.Size(729, 39)
        Me.pnlDiferido.TabIndex = 25
        Me.pnlDiferido.Tag = ""
        Me.pnlDiferido.Visible = False
        '
        'btnCancelarPedido
        '
        Me.btnCancelarPedido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelarPedido.BackColor = System.Drawing.Color.Black
        Me.btnCancelarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnCancelarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarPedido.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnCancelarPedido.Location = New System.Drawing.Point(631, 4)
        Me.btnCancelarPedido.Name = "btnCancelarPedido"
        Me.btnCancelarPedido.Size = New System.Drawing.Size(85, 24)
        Me.btnCancelarPedido.TabIndex = 27
        Me.btnCancelarPedido.Text = "Cancelar"
        Me.btnCancelarPedido.UseVisualStyleBackColor = False
        '
        'btnDiferido
        '
        Me.btnDiferido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDiferido.BackColor = System.Drawing.Color.Black
        Me.btnDiferido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDiferido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnDiferido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDiferido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDiferido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiferido.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiferido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnDiferido.Location = New System.Drawing.Point(538, 5)
        Me.btnDiferido.Name = "btnDiferido"
        Me.btnDiferido.Size = New System.Drawing.Size(85, 24)
        Me.btnDiferido.TabIndex = 26
        Me.btnDiferido.Text = "Diferido"
        Me.btnDiferido.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Ingrese la fecha y hora del pedido"
        '
        'dtpHora
        '
        Me.dtpHora.CalendarFont = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpHora.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(445, 5)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(71, 23)
        Me.dtpHora.TabIndex = 24
        '
        'dtpDiferido
        '
        Me.dtpDiferido.CalendarFont = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiferido.CustomFormat = "dd/mm/yyyy hh:mm:ss"
        Me.dtpDiferido.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiferido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiferido.Location = New System.Drawing.Point(287, 5)
        Me.dtpDiferido.Name = "dtpDiferido"
        Me.dtpDiferido.Size = New System.Drawing.Size(99, 23)
        Me.dtpDiferido.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(406, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Hora:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(244, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha:"
        '
        'DgvDomicilios
        '
        Me.DgvDomicilios.AllowUserToAddRows = False
        Me.DgvDomicilios.AllowUserToDeleteRows = False
        Me.DgvDomicilios.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.DgvDomicilios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvDomicilios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDomicilios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDomicilios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDomicilios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBtn, Me.ColDomicilio, Me.ColTipo, Me.ColDescripcion, Me.ColInterseccion, Me.ColObservaciones})
        Me.DgvDomicilios.ContextMenuStrip = Me.cmsDomicilios
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDomicilios.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvDomicilios.Location = New System.Drawing.Point(20, 16)
        Me.DgvDomicilios.MultiSelect = False
        Me.DgvDomicilios.Name = "DgvDomicilios"
        Me.DgvDomicilios.ReadOnly = True
        Me.DgvDomicilios.RowHeadersVisible = False
        Me.DgvDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDomicilios.Size = New System.Drawing.Size(1106, 165)
        Me.DgvDomicilios.TabIndex = 0
        '
        'colBtn
        '
        Me.colBtn.FillWeight = 18.27411!
        Me.colBtn.HeaderText = ""
        Me.colBtn.Image = Global.Apipe.My.Resources.Resources.page_edit1
        Me.colBtn.Name = "colBtn"
        Me.colBtn.ReadOnly = True
        Me.colBtn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colBtn.ToolTipText = "Generar Pedido"
        '
        'ColDomicilio
        '
        Me.ColDomicilio.DataPropertyName = "v_domicilio"
        Me.ColDomicilio.FillWeight = 116.3452!
        Me.ColDomicilio.HeaderText = "Domicilio"
        Me.ColDomicilio.Name = "ColDomicilio"
        Me.ColDomicilio.ReadOnly = True
        '
        'ColTipo
        '
        Me.ColTipo.DataPropertyName = "v_tipo"
        Me.ColTipo.FillWeight = 116.3452!
        Me.ColTipo.HeaderText = "Tipo"
        Me.ColTipo.Name = "ColTipo"
        Me.ColTipo.ReadOnly = True
        '
        'ColDescripcion
        '
        Me.ColDescripcion.DataPropertyName = "v_descripcion"
        Me.ColDescripcion.FillWeight = 116.3452!
        Me.ColDescripcion.HeaderText = "Descripción"
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        '
        'ColInterseccion
        '
        Me.ColInterseccion.DataPropertyName = "v_interseccion"
        Me.ColInterseccion.FillWeight = 116.3452!
        Me.ColInterseccion.HeaderText = "Interseccion"
        Me.ColInterseccion.Name = "ColInterseccion"
        Me.ColInterseccion.ReadOnly = True
        '
        'ColObservaciones
        '
        Me.ColObservaciones.DataPropertyName = "v_observacion"
        Me.ColObservaciones.FillWeight = 116.3452!
        Me.ColObservaciones.HeaderText = "Observaciones"
        Me.ColObservaciones.Name = "ColObservaciones"
        Me.ColObservaciones.ReadOnly = True
        '
        'cmsDomicilios
        '
        Me.cmsDomicilios.BackColor = System.Drawing.Color.Black
        Me.cmsDomicilios.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsDomicilios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btbPedido, Me.PedidoDiferidoToolStripMenuItem, Me.btnModificarDom, Me.NuevoDomicilioToolStripMenuItem, Me.EliminarDomicilioToolStripMenuItem})
        Me.cmsDomicilios.Name = "cmsDomicilios"
        Me.cmsDomicilios.Size = New System.Drawing.Size(208, 114)
        '
        'btbPedido
        '
        Me.btbPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btbPedido.Name = "btbPedido"
        Me.btbPedido.Size = New System.Drawing.Size(207, 22)
        Me.btbPedido.Text = "Pedido"
        '
        'PedidoDiferidoToolStripMenuItem
        '
        Me.PedidoDiferidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.PedidoDiferidoToolStripMenuItem.Name = "PedidoDiferidoToolStripMenuItem"
        Me.PedidoDiferidoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PedidoDiferidoToolStripMenuItem.Text = "Pedido Diferido"
        '
        'btnModificarDom
        '
        Me.btnModificarDom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnModificarDom.Name = "btnModificarDom"
        Me.btnModificarDom.Size = New System.Drawing.Size(207, 22)
        Me.btnModificarDom.Text = "Modificar Domicilio"
        '
        'NuevoDomicilioToolStripMenuItem
        '
        Me.NuevoDomicilioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.NuevoDomicilioToolStripMenuItem.Name = "NuevoDomicilioToolStripMenuItem"
        Me.NuevoDomicilioToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NuevoDomicilioToolStripMenuItem.Text = "Nuevo Domicilio"
        '
        'EliminarDomicilioToolStripMenuItem
        '
        Me.EliminarDomicilioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.EliminarDomicilioToolStripMenuItem.Name = "EliminarDomicilioToolStripMenuItem"
        Me.EliminarDomicilioToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EliminarDomicilioToolStripMenuItem.Text = "Eliminar Domicilio"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.TxtObservacion)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.cbxCategoria)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(9, 175)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1117, 43)
        Me.Panel4.TabIndex = 16
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(189, 3)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(607, 20)
        Me.TxtObservacion.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(848, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tipo de Pedido"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(959, 2)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(145, 23)
        Me.cbxCategoria.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Observaciones del Pedido"
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AllowUserToResizeRows = False
        Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPedReclamo, Me.fecha, Me.Domicilio, Me.nro_movil, Me.Asignado, Me.Completado, Me.Cancelado, Me.Observacion, Me.Telefonista, Me.Operador, Me.Chofer})
        Me.dgvPedidos.ContextMenuStrip = Me.cmsPedidos
        Me.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidos.Location = New System.Drawing.Point(6, 38)
        Me.dgvPedidos.MultiSelect = False
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(1121, 145)
        Me.dgvPedidos.TabIndex = 2
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
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecha.DataPropertyName = "v_hora_viaje"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 67
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
        Me.nro_movil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nro_movil.DataPropertyName = "v_nroMovil"
        Me.nro_movil.HeaderText = "Movil"
        Me.nro_movil.Name = "nro_movil"
        Me.nro_movil.ReadOnly = True
        Me.nro_movil.Width = 67
        '
        'Asignado
        '
        Me.Asignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Asignado.DataPropertyName = "v_hora_asignado2"
        Me.Asignado.HeaderText = "Asignado"
        Me.Asignado.Name = "Asignado"
        Me.Asignado.ReadOnly = True
        Me.Asignado.Width = 88
        '
        'Completado
        '
        Me.Completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Completado.DataPropertyName = "v_hora_completado2"
        Me.Completado.HeaderText = "Completado"
        Me.Completado.Name = "Completado"
        Me.Completado.ReadOnly = True
        Me.Completado.Width = 102
        '
        'Cancelado
        '
        Me.Cancelado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cancelado.DataPropertyName = "v_hora_cancelado"
        Me.Cancelado.HeaderText = "Cancelado"
        Me.Cancelado.Name = "Cancelado"
        Me.Cancelado.ReadOnly = True
        Me.Cancelado.Width = 95
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "observacion"
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
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
        'Chofer
        '
        Me.Chofer.DataPropertyName = "v_choferAyN"
        Me.Chofer.HeaderText = "Chofer"
        Me.Chofer.Name = "Chofer"
        Me.Chofer.ReadOnly = True
        '
        'cmsPedidos
        '
        Me.cmsPedidos.BackColor = System.Drawing.Color.Black
        Me.cmsPedidos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmsPedidos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReclamoPorTardanzaToolStripMenuItem, Me.ReclamoToolStripMenuItem, Me.CancelarPedidoToolStripMenuItem, Me.ModificarDiferidoToolStripMenuItem, Me.AgregarModificarObservacionesToolStripMenuItem})
        Me.cmsPedidos.Name = "cmsPedidos"
        Me.cmsPedidos.Size = New System.Drawing.Size(292, 114)
        '
        'ReclamoPorTardanzaToolStripMenuItem
        '
        Me.ReclamoPorTardanzaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ReclamoPorTardanzaToolStripMenuItem.Name = "ReclamoPorTardanzaToolStripMenuItem"
        Me.ReclamoPorTardanzaToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.ReclamoPorTardanzaToolStripMenuItem.Text = "Reclamo por tardanza"
        '
        'ReclamoToolStripMenuItem
        '
        Me.ReclamoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ReclamoToolStripMenuItem.Name = "ReclamoToolStripMenuItem"
        Me.ReclamoToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.ReclamoToolStripMenuItem.Text = "Otro reclamo"
        '
        'CancelarPedidoToolStripMenuItem
        '
        Me.CancelarPedidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.CancelarPedidoToolStripMenuItem.Name = "CancelarPedidoToolStripMenuItem"
        Me.CancelarPedidoToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.CancelarPedidoToolStripMenuItem.Text = "Cancelar Pedido"
        '
        'ModificarDiferidoToolStripMenuItem
        '
        Me.ModificarDiferidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ModificarDiferidoToolStripMenuItem.Name = "ModificarDiferidoToolStripMenuItem"
        Me.ModificarDiferidoToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.ModificarDiferidoToolStripMenuItem.Text = "Modificar Diferido"
        '
        'AgregarModificarObservacionesToolStripMenuItem
        '
        Me.AgregarModificarObservacionesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.AgregarModificarObservacionesToolStripMenuItem.Name = "AgregarModificarObservacionesToolStripMenuItem"
        Me.AgregarModificarObservacionesToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.AgregarModificarObservacionesToolStripMenuItem.Text = "Agregar/Modificar Observaciones"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.panMain)
        Me.Panel2.Controls.Add(Me.panCommands)
        Me.Panel2.Controls.Add(Me.cmdConfig)
        Me.Panel2.Controls.Add(Me.panLcd)
        Me.Panel2.Location = New System.Drawing.Point(588, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 161)
        Me.Panel2.TabIndex = 9
        '
        'panMain
        '
        Me.panMain.BackColor = System.Drawing.Color.Transparent
        Me.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panMain.Controls.Add(Me.progressLevelOutput)
        Me.panMain.Controls.Add(Me.progressLevelInput)
        Me.panMain.Controls.Add(Me.panDial)
        Me.panMain.Controls.Add(Me.txtStatus)
        Me.panMain.Controls.Add(Me.lblTime)
        Me.panMain.Controls.Add(Me.lblUser)
        Me.panMain.Location = New System.Drawing.Point(23, 11)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(133, 116)
        Me.panMain.TabIndex = 0
        '
        'progressLevelOutput
        '
        Me.progressLevelOutput.Location = New System.Drawing.Point(65, 102)
        Me.progressLevelOutput.Name = "progressLevelOutput"
        Me.progressLevelOutput.Size = New System.Drawing.Size(63, 10)
        Me.progressLevelOutput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressLevelOutput.TabIndex = 16
        '
        'progressLevelInput
        '
        Me.progressLevelInput.Location = New System.Drawing.Point(1, 102)
        Me.progressLevelInput.Name = "progressLevelInput"
        Me.progressLevelInput.Size = New System.Drawing.Size(65, 10)
        Me.progressLevelInput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressLevelInput.TabIndex = 15
        '
        'panDial
        '
        Me.panDial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panDial.Controls.Add(Me.txtDial)
        Me.panDial.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.panDial.Location = New System.Drawing.Point(-1, 32)
        Me.panDial.Name = "panDial"
        Me.panDial.Size = New System.Drawing.Size(129, 27)
        Me.panDial.TabIndex = 1
        '
        'txtDial
        '
        Me.txtDial.BackColor = System.Drawing.Color.Black
        Me.txtDial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDial.Enabled = False
        Me.txtDial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDial.ForeColor = System.Drawing.Color.White
        Me.txtDial.Location = New System.Drawing.Point(3, 4)
        Me.txtDial.Name = "txtDial"
        Me.txtDial.Size = New System.Drawing.Size(121, 16)
        Me.txtDial.TabIndex = 0
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Black
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.Location = New System.Drawing.Point(3, 61)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(129, 39)
        Me.txtStatus.TabIndex = 14
        Me.txtStatus.TabStop = False
        Me.txtStatus.Text = "Espere..."
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(61, 4)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(71, 23)
        Me.lblTime.TabIndex = 13
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(3, 4)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(61, 23)
        Me.lblUser.TabIndex = 10
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panCommands
        '
        Me.panCommands.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panCommands.Controls.Add(Me.cmdTransfer)
        Me.panCommands.Controls.Add(Me.cmdCall)
        Me.panCommands.Controls.Add(Me.panLine1)
        Me.panCommands.Controls.Add(Me.cmdHangup)
        Me.panCommands.Controls.Add(Me.cmdLine1)
        Me.panCommands.Controls.Add(Me.cmdPickUp)
        Me.panCommands.Controls.Add(Me.Panel1)
        Me.panCommands.Controls.Add(Me.cmdDigit0)
        Me.panCommands.Controls.Add(Me.cmdLine2)
        Me.panCommands.Controls.Add(Me.cmdDigitSharp)
        Me.panCommands.Controls.Add(Me.cmdDigit1)
        Me.panCommands.Controls.Add(Me.cmdDigitAsterisk)
        Me.panCommands.Controls.Add(Me.cmdDigit3)
        Me.panCommands.Controls.Add(Me.cmdDigit8)
        Me.panCommands.Controls.Add(Me.cmdDigit2)
        Me.panCommands.Controls.Add(Me.cmdDigit9)
        Me.panCommands.Controls.Add(Me.cmdDigit4)
        Me.panCommands.Controls.Add(Me.cmdDigit7)
        Me.panCommands.Controls.Add(Me.cmdDigit6)
        Me.panCommands.Controls.Add(Me.cmdDigit5)
        Me.panCommands.Enabled = False
        Me.panCommands.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panCommands.Location = New System.Drawing.Point(170, 7)
        Me.panCommands.Name = "panCommands"
        Me.panCommands.Size = New System.Drawing.Size(391, 145)
        Me.panCommands.TabIndex = 24
        '
        'cmdTransfer
        '
        Me.cmdTransfer.BackColor = System.Drawing.Color.Gray
        Me.cmdTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTransfer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTransfer.ForeColor = System.Drawing.Color.White
        Me.cmdTransfer.Location = New System.Drawing.Point(162, 120)
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.Size = New System.Drawing.Size(78, 23)
        Me.cmdTransfer.TabIndex = 68
        Me.cmdTransfer.Text = "Transferir"
        Me.cmdTransfer.UseVisualStyleBackColor = False
        '
        'cmdCall
        '
        Me.cmdCall.BackColor = System.Drawing.Color.Gray
        Me.cmdCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCall.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCall.ForeColor = System.Drawing.Color.White
        Me.cmdCall.Location = New System.Drawing.Point(84, 94)
        Me.cmdCall.Name = "cmdCall"
        Me.cmdCall.Size = New System.Drawing.Size(78, 23)
        Me.cmdCall.TabIndex = 67
        Me.cmdCall.Text = "Llamar"
        Me.cmdCall.UseVisualStyleBackColor = False
        '
        'panLine1
        '
        Me.panLine1.BackColor = System.Drawing.Color.Transparent
        Me.panLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panLine1.Controls.Add(Me.lblTime1)
        Me.panLine1.Controls.Add(Me.lblCallDirection1)
        Me.panLine1.Controls.Add(Me.lblNumber1)
        Me.panLine1.Controls.Add(Me.lblStatus1)
        Me.panLine1.Location = New System.Drawing.Point(22, 7)
        Me.panLine1.Name = "panLine1"
        Me.panLine1.Size = New System.Drawing.Size(218, 39)
        Me.panLine1.TabIndex = 49
        '
        'lblTime1
        '
        Me.lblTime1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.ForeColor = System.Drawing.Color.White
        Me.lblTime1.Location = New System.Drawing.Point(160, 3)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(46, 13)
        Me.lblTime1.TabIndex = 3
        Me.lblTime1.Text = "00:00"
        Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCallDirection1
        '
        Me.lblCallDirection1.AutoSize = True
        Me.lblCallDirection1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCallDirection1.Location = New System.Drawing.Point(9, 20)
        Me.lblCallDirection1.Name = "lblCallDirection1"
        Me.lblCallDirection1.Size = New System.Drawing.Size(0, 13)
        Me.lblCallDirection1.TabIndex = 23
        '
        'lblNumber1
        '
        Me.lblNumber1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.ForeColor = System.Drawing.Color.White
        Me.lblNumber1.Location = New System.Drawing.Point(9, 3)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(88, 13)
        Me.lblNumber1.TabIndex = 1
        Me.lblNumber1.Text = "0"
        Me.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus1
        '
        Me.lblStatus1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.ForeColor = System.Drawing.Color.White
        Me.lblStatus1.Location = New System.Drawing.Point(127, 21)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(79, 13)
        Me.lblStatus1.TabIndex = 0
        Me.lblStatus1.Text = "Libre"
        Me.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdHangup
        '
        Me.cmdHangup.BackColor = System.Drawing.Color.Gray
        Me.cmdHangup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdHangup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHangup.ForeColor = System.Drawing.Color.White
        Me.cmdHangup.Location = New System.Drawing.Point(162, 94)
        Me.cmdHangup.Name = "cmdHangup"
        Me.cmdHangup.Size = New System.Drawing.Size(78, 23)
        Me.cmdHangup.TabIndex = 66
        Me.cmdHangup.Text = "Cortar"
        Me.cmdHangup.UseVisualStyleBackColor = False
        '
        'cmdLine1
        '
        Me.cmdLine1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLine1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.cmdLine1.Location = New System.Drawing.Point(5, 7)
        Me.cmdLine1.Name = "cmdLine1"
        Me.cmdLine1.Size = New System.Drawing.Size(16, 39)
        Me.cmdLine1.TabIndex = 50
        Me.cmdLine1.Tag = "0"
        Me.cmdLine1.Text = "L1"
        Me.cmdLine1.UseVisualStyleBackColor = True
        '
        'cmdPickUp
        '
        Me.cmdPickUp.BackColor = System.Drawing.Color.Gray
        Me.cmdPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPickUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPickUp.ForeColor = System.Drawing.Color.White
        Me.cmdPickUp.Location = New System.Drawing.Point(84, 120)
        Me.cmdPickUp.Name = "cmdPickUp"
        Me.cmdPickUp.Size = New System.Drawing.Size(78, 23)
        Me.cmdPickUp.TabIndex = 65
        Me.cmdPickUp.Text = "Atender"
        Me.cmdPickUp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblCallDirection2)
        Me.Panel1.Controls.Add(Me.lblTime2)
        Me.Panel1.Controls.Add(Me.lblNumber2)
        Me.Panel1.Controls.Add(Me.lblStatus2)
        Me.Panel1.Location = New System.Drawing.Point(22, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 41)
        Me.Panel1.TabIndex = 51
        '
        'lblCallDirection2
        '
        Me.lblCallDirection2.AutoSize = True
        Me.lblCallDirection2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCallDirection2.Location = New System.Drawing.Point(3, 21)
        Me.lblCallDirection2.Name = "lblCallDirection2"
        Me.lblCallDirection2.Size = New System.Drawing.Size(0, 13)
        Me.lblCallDirection2.TabIndex = 24
        '
        'lblTime2
        '
        Me.lblTime2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.ForeColor = System.Drawing.Color.White
        Me.lblTime2.Location = New System.Drawing.Point(159, 3)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(46, 13)
        Me.lblTime2.TabIndex = 4
        Me.lblTime2.Text = "00:00"
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumber2
        '
        Me.lblNumber2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.ForeColor = System.Drawing.Color.White
        Me.lblNumber2.Location = New System.Drawing.Point(3, 3)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(88, 13)
        Me.lblNumber2.TabIndex = 1
        Me.lblNumber2.Text = "0"
        Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus2
        '
        Me.lblStatus2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.ForeColor = System.Drawing.Color.White
        Me.lblStatus2.Location = New System.Drawing.Point(126, 20)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(79, 13)
        Me.lblStatus2.TabIndex = 0
        Me.lblStatus2.Text = "Libre"
        Me.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDigit0
        '
        Me.cmdDigit0.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit0.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit0.ForeColor = System.Drawing.Color.White
        Me.cmdDigit0.Location = New System.Drawing.Point(291, 94)
        Me.cmdDigit0.Name = "cmdDigit0"
        Me.cmdDigit0.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit0.TabIndex = 64
        Me.cmdDigit0.Text = "0"
        Me.cmdDigit0.UseVisualStyleBackColor = False
        '
        'cmdLine2
        '
        Me.cmdLine2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLine2.ForeColor = System.Drawing.Color.White
        Me.cmdLine2.Location = New System.Drawing.Point(5, 47)
        Me.cmdLine2.Name = "cmdLine2"
        Me.cmdLine2.Size = New System.Drawing.Size(16, 38)
        Me.cmdLine2.TabIndex = 52
        Me.cmdLine2.Tag = "1"
        Me.cmdLine2.Text = "L2"
        Me.cmdLine2.UseVisualStyleBackColor = True
        '
        'cmdDigitSharp
        '
        Me.cmdDigitSharp.BackColor = System.Drawing.Color.Gray
        Me.cmdDigitSharp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigitSharp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigitSharp.ForeColor = System.Drawing.Color.White
        Me.cmdDigitSharp.Location = New System.Drawing.Point(336, 94)
        Me.cmdDigitSharp.Name = "cmdDigitSharp"
        Me.cmdDigitSharp.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigitSharp.TabIndex = 63
        Me.cmdDigitSharp.Text = "#"
        Me.cmdDigitSharp.UseVisualStyleBackColor = False
        '
        'cmdDigit1
        '
        Me.cmdDigit1.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit1.ForeColor = System.Drawing.Color.White
        Me.cmdDigit1.Location = New System.Drawing.Point(246, 13)
        Me.cmdDigit1.Name = "cmdDigit1"
        Me.cmdDigit1.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit1.TabIndex = 53
        Me.cmdDigit1.Text = "1"
        Me.cmdDigit1.UseVisualStyleBackColor = False
        '
        'cmdDigitAsterisk
        '
        Me.cmdDigitAsterisk.BackColor = System.Drawing.Color.Gray
        Me.cmdDigitAsterisk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigitAsterisk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigitAsterisk.ForeColor = System.Drawing.Color.White
        Me.cmdDigitAsterisk.Location = New System.Drawing.Point(246, 94)
        Me.cmdDigitAsterisk.Name = "cmdDigitAsterisk"
        Me.cmdDigitAsterisk.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigitAsterisk.TabIndex = 62
        Me.cmdDigitAsterisk.Text = "*"
        Me.cmdDigitAsterisk.UseVisualStyleBackColor = False
        '
        'cmdDigit3
        '
        Me.cmdDigit3.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit3.ForeColor = System.Drawing.Color.White
        Me.cmdDigit3.Location = New System.Drawing.Point(336, 13)
        Me.cmdDigit3.Name = "cmdDigit3"
        Me.cmdDigit3.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit3.TabIndex = 54
        Me.cmdDigit3.Text = "3"
        Me.cmdDigit3.UseVisualStyleBackColor = False
        '
        'cmdDigit8
        '
        Me.cmdDigit8.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit8.ForeColor = System.Drawing.Color.White
        Me.cmdDigit8.Location = New System.Drawing.Point(291, 67)
        Me.cmdDigit8.Name = "cmdDigit8"
        Me.cmdDigit8.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit8.TabIndex = 61
        Me.cmdDigit8.Text = "8"
        Me.cmdDigit8.UseVisualStyleBackColor = False
        '
        'cmdDigit2
        '
        Me.cmdDigit2.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit2.ForeColor = System.Drawing.Color.White
        Me.cmdDigit2.Location = New System.Drawing.Point(291, 13)
        Me.cmdDigit2.Name = "cmdDigit2"
        Me.cmdDigit2.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit2.TabIndex = 55
        Me.cmdDigit2.Text = "2"
        Me.cmdDigit2.UseVisualStyleBackColor = False
        '
        'cmdDigit9
        '
        Me.cmdDigit9.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit9.ForeColor = System.Drawing.Color.White
        Me.cmdDigit9.Location = New System.Drawing.Point(336, 67)
        Me.cmdDigit9.Name = "cmdDigit9"
        Me.cmdDigit9.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit9.TabIndex = 60
        Me.cmdDigit9.Text = "9"
        Me.cmdDigit9.UseVisualStyleBackColor = False
        '
        'cmdDigit4
        '
        Me.cmdDigit4.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit4.ForeColor = System.Drawing.Color.White
        Me.cmdDigit4.Location = New System.Drawing.Point(246, 40)
        Me.cmdDigit4.Name = "cmdDigit4"
        Me.cmdDigit4.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit4.TabIndex = 56
        Me.cmdDigit4.Text = "4"
        Me.cmdDigit4.UseVisualStyleBackColor = False
        '
        'cmdDigit7
        '
        Me.cmdDigit7.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit7.ForeColor = System.Drawing.Color.White
        Me.cmdDigit7.Location = New System.Drawing.Point(246, 67)
        Me.cmdDigit7.Name = "cmdDigit7"
        Me.cmdDigit7.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit7.TabIndex = 59
        Me.cmdDigit7.Text = "7"
        Me.cmdDigit7.UseVisualStyleBackColor = False
        '
        'cmdDigit6
        '
        Me.cmdDigit6.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit6.ForeColor = System.Drawing.Color.White
        Me.cmdDigit6.Location = New System.Drawing.Point(336, 40)
        Me.cmdDigit6.Name = "cmdDigit6"
        Me.cmdDigit6.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit6.TabIndex = 57
        Me.cmdDigit6.Text = "6"
        Me.cmdDigit6.UseVisualStyleBackColor = False
        '
        'cmdDigit5
        '
        Me.cmdDigit5.BackColor = System.Drawing.Color.Gray
        Me.cmdDigit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigit5.ForeColor = System.Drawing.Color.White
        Me.cmdDigit5.Location = New System.Drawing.Point(291, 40)
        Me.cmdDigit5.Name = "cmdDigit5"
        Me.cmdDigit5.Size = New System.Drawing.Size(44, 23)
        Me.cmdDigit5.TabIndex = 58
        Me.cmdDigit5.Text = "5"
        Me.cmdDigit5.UseVisualStyleBackColor = False
        '
        'cmdConfig
        '
        Me.cmdConfig.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfig.ForeColor = System.Drawing.Color.White
        Me.cmdConfig.Location = New System.Drawing.Point(2, 8)
        Me.cmdConfig.Name = "cmdConfig"
        Me.cmdConfig.Size = New System.Drawing.Size(14, 124)
        Me.cmdConfig.TabIndex = 23
        Me.cmdConfig.Text = "Configl"
        Me.cmdConfig.UseVisualStyleBackColor = True
        Me.cmdConfig.Visible = False
        '
        'panLcd
        '
        Me.panLcd.BackColor = System.Drawing.Color.Transparent
        Me.panLcd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panLcd.Location = New System.Drawing.Point(18, 10)
        Me.panLcd.Name = "panLcd"
        Me.panLcd.Size = New System.Drawing.Size(145, 124)
        Me.panLcd.TabIndex = 22
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.AutoSize = True
        Me.gbxDetalle.Controls.Add(Me.txtDetalle)
        Me.gbxDetalle.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 3)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(1138, 111)
        Me.gbxDetalle.TabIndex = 0
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
        Me.txtDetalle.Size = New System.Drawing.Size(1117, 81)
        Me.txtDetalle.TabIndex = 0
        Me.txtDetalle.TabStop = False
        Me.txtDetalle.Text = "(Detalle)"
        '
        'notifyMain
        '
        Me.notifyMain.Icon = CType(resources.GetObject("notifyMain.Icon"), System.Drawing.Icon)
        Me.notifyMain.Text = "IAXClient"
        Me.notifyMain.Visible = True
        '
        'timTime
        '
        Me.timTime.Interval = 1000
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TxtTelefono.ForeColor = System.Drawing.Color.Black
        Me.TxtTelefono.Location = New System.Drawing.Point(182, 26)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(141, 23)
        Me.TxtTelefono.TabIndex = 1
        '
        'btnReclamos
        '
        Me.btnReclamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReclamos.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReclamos.ForeColor = System.Drawing.Color.Black
        Me.btnReclamos.Location = New System.Drawing.Point(443, 24)
        Me.btnReclamos.Name = "btnReclamos"
        Me.btnReclamos.Size = New System.Drawing.Size(121, 30)
        Me.btnReclamos.TabIndex = 21
        Me.btnReclamos.Text = "&Ver Reclamos"
        Me.btnReclamos.UseVisualStyleBackColor = False
        Me.btnReclamos.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Número de teléfono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(97, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Apellido:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(113, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(41, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Tipo de Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.btnModCte)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnReclamos)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'btnModCte
        '
        Me.btnModCte.BackColor = System.Drawing.Color.Black
        Me.btnModCte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnModCte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModCte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModCte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModCte.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModCte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnModCte.Location = New System.Drawing.Point(443, 106)
        Me.btnModCte.Name = "btnModCte"
        Me.btnModCte.Size = New System.Drawing.Size(121, 30)
        Me.btnModCte.TabIndex = 29
        Me.btnModCte.Text = "&Modificar"
        Me.btnModCte.UseVisualStyleBackColor = False
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(179, 56)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(72, 17)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(179, 106)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(128, 17)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo de Cliente"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(179, 82)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.pnlDiferido)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.DgvDomicilios)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1138, 227)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilios del Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.BtnAdd50)
        Me.GroupBox3.Controls.Add(Me.pnlObservacion)
        Me.GroupBox3.Controls.Add(Me.dgvPedidos)
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 506)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1138, 186)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de Pedidos del cliente"
        '
        'BtnAdd50
        '
        Me.BtnAdd50.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnAdd50.FlatAppearance.BorderSize = 0
        Me.BtnAdd50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd50.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd50.Location = New System.Drawing.Point(253, 9)
        Me.BtnAdd50.Name = "BtnAdd50"
        Me.BtnAdd50.Size = New System.Drawing.Size(70, 23)
        Me.BtnAdd50.TabIndex = 4
        Me.BtnAdd50.Text = "50 +"
        Me.BtnAdd50.UseVisualStyleBackColor = False
        '
        'pnlObservacion
        '
        Me.pnlObservacion.Controls.Add(Me.BtnCancelarObservaciones)
        Me.pnlObservacion.Controls.Add(Me.btnObservaciones)
        Me.pnlObservacion.Controls.Add(Me.txtObserPedido)
        Me.pnlObservacion.Location = New System.Drawing.Point(44, 52)
        Me.pnlObservacion.Name = "pnlObservacion"
        Me.pnlObservacion.Size = New System.Drawing.Size(967, 100)
        Me.pnlObservacion.TabIndex = 3
        Me.pnlObservacion.Visible = False
        '
        'BtnCancelarObservaciones
        '
        Me.BtnCancelarObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancelarObservaciones.BackColor = System.Drawing.Color.Black
        Me.BtnCancelarObservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelarObservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnCancelarObservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelarObservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelarObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarObservaciones.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnCancelarObservaciones.Location = New System.Drawing.Point(843, 42)
        Me.BtnCancelarObservaciones.Name = "BtnCancelarObservaciones"
        Me.BtnCancelarObservaciones.Size = New System.Drawing.Size(85, 24)
        Me.BtnCancelarObservaciones.TabIndex = 28
        Me.BtnCancelarObservaciones.Text = "Cancelar"
        Me.BtnCancelarObservaciones.UseVisualStyleBackColor = False
        '
        'btnObservaciones
        '
        Me.btnObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnObservaciones.BackColor = System.Drawing.Color.Black
        Me.btnObservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnObservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnObservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnObservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObservaciones.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnObservaciones.Location = New System.Drawing.Point(743, 42)
        Me.btnObservaciones.Name = "btnObservaciones"
        Me.btnObservaciones.Size = New System.Drawing.Size(85, 24)
        Me.btnObservaciones.TabIndex = 27
        Me.btnObservaciones.Text = "Guardar"
        Me.btnObservaciones.UseVisualStyleBackColor = False
        '
        'txtObserPedido
        '
        Me.txtObserPedido.Location = New System.Drawing.Point(17, 21)
        Me.txtObserPedido.Multiline = True
        Me.txtObserPedido.Name = "txtObserPedido"
        Me.txtObserPedido.Size = New System.Drawing.Size(717, 58)
        Me.txtObserPedido.TabIndex = 0
        '
        'FrmInfoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1164, 701)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmInfoCliente"
        Me.cmsCliente.ResumeLayout(False)
        Me.pnlDiferido.ResumeLayout(False)
        Me.pnlDiferido.PerformLayout()
        CType(Me.DgvDomicilios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDomicilios.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPedidos.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panMain.ResumeLayout(False)
        Me.panMain.PerformLayout()
        Me.panDial.ResumeLayout(False)
        Me.panDial.PerformLayout()
        Me.panCommands.ResumeLayout(False)
        Me.panLine1.ResumeLayout(False)
        Me.panLine1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbxDetalle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.pnlObservacion.ResumeLayout(False)
        Me.pnlObservacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvDomicilios As System.Windows.Forms.DataGridView
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents cmsDomicilios As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnModificarDom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btbPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NuevoDomicilioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmsPedidos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReclamoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents cmsCliente As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents panCommands As System.Windows.Forms.Panel
    Private WithEvents cmdConfig As System.Windows.Forms.Button
    Private WithEvents panLcd As System.Windows.Forms.Panel
    Private WithEvents panMain As System.Windows.Forms.Panel
    Private WithEvents progressLevelOutput As System.Windows.Forms.ProgressBar
    Private WithEvents progressLevelInput As System.Windows.Forms.ProgressBar
    Private WithEvents panDial As System.Windows.Forms.Panel
    Private WithEvents txtDial As System.Windows.Forms.TextBox
    Private WithEvents txtStatus As System.Windows.Forms.TextBox
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private WithEvents lblUser As System.Windows.Forms.Label
    Private WithEvents notifyMain As System.Windows.Forms.NotifyIcon
    Private WithEvents timTime As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents cmdTransfer As System.Windows.Forms.Button
    Private WithEvents cmdCall As System.Windows.Forms.Button
    Private WithEvents panLine1 As System.Windows.Forms.Panel
    Private WithEvents lblTime1 As System.Windows.Forms.Label
    Private WithEvents lblNumber1 As System.Windows.Forms.Label
    Private WithEvents lblStatus1 As System.Windows.Forms.Label
    Private WithEvents cmdHangup As System.Windows.Forms.Button
    Private WithEvents cmdLine1 As System.Windows.Forms.Button
    Private WithEvents cmdPickUp As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lblTime2 As System.Windows.Forms.Label
    Private WithEvents lblNumber2 As System.Windows.Forms.Label
    Private WithEvents lblStatus2 As System.Windows.Forms.Label
    Private WithEvents cmdDigit0 As System.Windows.Forms.Button
    Private WithEvents cmdLine2 As System.Windows.Forms.Button
    Private WithEvents cmdDigitSharp As System.Windows.Forms.Button
    Private WithEvents cmdDigit1 As System.Windows.Forms.Button
    Private WithEvents cmdDigitAsterisk As System.Windows.Forms.Button
    Private WithEvents cmdDigit3 As System.Windows.Forms.Button
    Private WithEvents cmdDigit8 As System.Windows.Forms.Button
    Private WithEvents cmdDigit2 As System.Windows.Forms.Button
    Private WithEvents cmdDigit9 As System.Windows.Forms.Button
    Private WithEvents cmdDigit4 As System.Windows.Forms.Button
    Private WithEvents cmdDigit7 As System.Windows.Forms.Button
    Private WithEvents cmdDigit6 As System.Windows.Forms.Button
    Private WithEvents cmdDigit5 As System.Windows.Forms.Button
    Friend WithEvents dtpDiferido As System.Windows.Forms.DateTimePicker
    Friend WithEvents PedidoDiferidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlDiferido As System.Windows.Forms.Panel
    Friend WithEvents btnDiferido As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCallDirection1 As System.Windows.Forms.Label
    Friend WithEvents lblCallDirection2 As System.Windows.Forms.Label
    Friend WithEvents CancelarPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnReclamos As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnModCte As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ModificarDiferidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDomicilioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancelarPedido As System.Windows.Forms.Button
    Friend WithEvents ReclamoPorTardanzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colBtn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColInterseccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_movil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancelado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgregarModificarObservacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlObservacion As System.Windows.Forms.Panel
    Friend WithEvents btnObservaciones As System.Windows.Forms.Button
    Friend WithEvents txtObserPedido As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelarObservaciones As System.Windows.Forms.Button
    Friend WithEvents BtnAdd50 As System.Windows.Forms.Button
End Class
