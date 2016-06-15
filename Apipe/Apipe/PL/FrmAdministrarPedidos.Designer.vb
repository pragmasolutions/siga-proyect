<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministrarPedidos
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdministrarPedidos))
        Me.spcTodo = New System.Windows.Forms.SplitContainer()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.txtDetalle = New System.Windows.Forms.RichTextBox()
        Me.spcArriba = New System.Windows.Forms.SplitContainer()
        Me.spcPedidos = New System.Windows.Forms.SplitContainer()
        Me.spcAsignados = New System.Windows.Forms.SplitContainer()
        Me.txtACompletar = New System.Windows.Forms.RichTextBox()
        Me.dgvACompletar = New System.Windows.Forms.DataGridView()
        Me.colACompCompletar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colmensajero = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCambiarMovil = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMostrarCompletados = New System.Windows.Forms.Button()
        Me.dgvCompletados = New System.Windows.Forms.DataGridView()
        Me.colComVolver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colComReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCompletados = New System.Windows.Forms.RichTextBox()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.colPedAsignar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colPedReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colPedHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedHoraViaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPedObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPedidos = New System.Windows.Forms.RichTextBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.lklPorBase = New System.Windows.Forms.LinkLabel()
        Me.lklPorFrecuencia = New System.Windows.Forms.LinkLabel()
        Me.pnlBuscarMovil = New System.Windows.Forms.Panel()
        Me.txtBuscarMovil = New System.Windows.Forms.TextBox()
        Me.dgvMoviles = New System.Windows.Forms.DataGridView()
        Me.colMovAsignar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colMovNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovAire = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colMovBaul = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colMovFactura = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colMovCantPedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovUltPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmovzona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMovBase = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colMovQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pbxBase = New System.Windows.Forms.PictureBox()
        Me.pbxAgregarMovil = New System.Windows.Forms.PictureBox()
        Me.txtMoviles = New System.Windows.Forms.RichTextBox()
        Me.tmrAsignar = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvZT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn68 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn69 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn70 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn71 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn72 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn73 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZP = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn74 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn75 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn76 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn77 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn78 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn79 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ10 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn56 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn57 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn58 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn59 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn60 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn61 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ9 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn62 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn63 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn64 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn65 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn66 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn67 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ8 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn44 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn45 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn46 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn47 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn48 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn49 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ7 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn50 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn51 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn52 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn53 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn54 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn55 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ6 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn32 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn33 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn34 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn35 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn36 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn37 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ5 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn38 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn39 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn40 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn41 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn42 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn43 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn20 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn21 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn22 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn23 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn24 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn25 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn26 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn27 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn28 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn29 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn30 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn31 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn14 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn15 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn16 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn17 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn18 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn19 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvZ1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn13 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tmrBuscarMovil = New System.Windows.Forms.Timer(Me.components)
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTodo.Panel1.SuspendLayout()
        Me.spcTodo.Panel2.SuspendLayout()
        Me.spcTodo.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.spcArriba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcArriba.Panel1.SuspendLayout()
        Me.spcArriba.Panel2.SuspendLayout()
        Me.spcArriba.SuspendLayout()
        CType(Me.spcPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcPedidos.Panel1.SuspendLayout()
        Me.spcPedidos.Panel2.SuspendLayout()
        Me.spcPedidos.SuspendLayout()
        CType(Me.spcAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcAsignados.Panel1.SuspendLayout()
        Me.spcAsignados.Panel2.SuspendLayout()
        Me.spcAsignados.SuspendLayout()
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompletados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscarMovil.SuspendLayout()
        CType(Me.dgvMoviles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAgregarMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvZT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZ1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcTodo
        '
        Me.spcTodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcTodo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spcTodo.Location = New System.Drawing.Point(0, 0)
        Me.spcTodo.Name = "spcTodo"
        Me.spcTodo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcTodo.Panel1
        '
        Me.spcTodo.Panel1.Controls.Add(Me.gbxDetalle)
        '
        'spcTodo.Panel2
        '
        Me.spcTodo.Panel2.Controls.Add(Me.spcArriba)
        Me.spcTodo.Size = New System.Drawing.Size(1192, 588)
        Me.spcTodo.SplitterDistance = 96
        Me.spcTodo.SplitterWidth = 5
        Me.spcTodo.TabIndex = 0
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.txtDetalle)
        Me.gbxDetalle.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxDetalle.Location = New System.Drawing.Point(9, 3)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(1173, 90)
        Me.gbxDetalle.TabIndex = 2
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
        Me.txtDetalle.Location = New System.Drawing.Point(9, 17)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDetalle.Size = New System.Drawing.Size(1157, 62)
        Me.txtDetalle.TabIndex = 7
        Me.txtDetalle.TabStop = False
        Me.txtDetalle.Text = "(Detalle)"
        '
        'spcArriba
        '
        Me.spcArriba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcArriba.Location = New System.Drawing.Point(0, 0)
        Me.spcArriba.Name = "spcArriba"
        '
        'spcArriba.Panel1
        '
        Me.spcArriba.Panel1.Controls.Add(Me.spcPedidos)
        '
        'spcArriba.Panel2
        '
        Me.spcArriba.Panel2.Controls.Add(Me.txtBuscador)
        Me.spcArriba.Panel2.Controls.Add(Me.lklPorBase)
        Me.spcArriba.Panel2.Controls.Add(Me.lklPorFrecuencia)
        Me.spcArriba.Panel2.Controls.Add(Me.pnlBuscarMovil)
        Me.spcArriba.Panel2.Controls.Add(Me.dgvMoviles)
        Me.spcArriba.Panel2.Controls.Add(Me.pbxBase)
        Me.spcArriba.Panel2.Controls.Add(Me.pbxAgregarMovil)
        Me.spcArriba.Panel2.Controls.Add(Me.txtMoviles)
        Me.spcArriba.Size = New System.Drawing.Size(1192, 487)
        Me.spcArriba.SplitterDistance = 815
        Me.spcArriba.SplitterWidth = 5
        Me.spcArriba.TabIndex = 0
        '
        'spcPedidos
        '
        Me.spcPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcPedidos.Location = New System.Drawing.Point(0, 0)
        Me.spcPedidos.Name = "spcPedidos"
        '
        'spcPedidos.Panel1
        '
        Me.spcPedidos.Panel1.Controls.Add(Me.spcAsignados)
        '
        'spcPedidos.Panel2
        '
        Me.spcPedidos.Panel2.Controls.Add(Me.dgvPedidos)
        Me.spcPedidos.Panel2.Controls.Add(Me.txtPedidos)
        Me.spcPedidos.Size = New System.Drawing.Size(815, 487)
        Me.spcPedidos.SplitterDistance = 404
        Me.spcPedidos.SplitterWidth = 5
        Me.spcPedidos.TabIndex = 0
        '
        'spcAsignados
        '
        Me.spcAsignados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcAsignados.Location = New System.Drawing.Point(0, 0)
        Me.spcAsignados.Name = "spcAsignados"
        Me.spcAsignados.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcAsignados.Panel1
        '
        Me.spcAsignados.Panel1.Controls.Add(Me.txtACompletar)
        Me.spcAsignados.Panel1.Controls.Add(Me.dgvACompletar)
        '
        'spcAsignados.Panel2
        '
        Me.spcAsignados.Panel2.Controls.Add(Me.btnMostrarCompletados)
        Me.spcAsignados.Panel2.Controls.Add(Me.dgvCompletados)
        Me.spcAsignados.Panel2.Controls.Add(Me.txtCompletados)
        Me.spcAsignados.Size = New System.Drawing.Size(404, 487)
        Me.spcAsignados.SplitterDistance = 338
        Me.spcAsignados.TabIndex = 0
        '
        'txtACompletar
        '
        Me.txtACompletar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtACompletar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtACompletar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtACompletar.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACompletar.ForeColor = System.Drawing.Color.White
        Me.txtACompletar.Location = New System.Drawing.Point(9, 14)
        Me.txtACompletar.Name = "txtACompletar"
        Me.txtACompletar.ReadOnly = True
        Me.txtACompletar.Size = New System.Drawing.Size(388, 28)
        Me.txtACompletar.TabIndex = 6
        Me.txtACompletar.Text = "PEDIDOS A COMPLETAR"
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
        Me.dgvACompletar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colACompCompletar, Me.colmensajero, Me.colACompReclamo, Me.colACompAsignado, Me.colACompMovil, Me.colACompCambiarMovil, Me.colACompDomicilio, Me.colACompCliente})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvACompletar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvACompletar.Location = New System.Drawing.Point(9, 42)
        Me.dgvACompletar.MultiSelect = False
        Me.dgvACompletar.Name = "dgvACompletar"
        Me.dgvACompletar.ReadOnly = True
        Me.dgvACompletar.RowHeadersVisible = False
        Me.dgvACompletar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvACompletar.Size = New System.Drawing.Size(388, 287)
        Me.dgvACompletar.TabIndex = 5
        '
        'colACompCompletar
        '
        Me.colACompCompletar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCompletar.HeaderText = ""
        Me.colACompCompletar.Image = Global.Apipe.My.Resources.Resources.tilde
        Me.colACompCompletar.Name = "colACompCompletar"
        Me.colACompCompletar.ReadOnly = True
        Me.colACompCompletar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colACompCompletar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colACompCompletar.ToolTipText = "Completar"
        Me.colACompCompletar.Width = 20
        '
        'colmensajero
        '
        Me.colmensajero.HeaderText = ""
        Me.colmensajero.Image = Global.Apipe.My.Resources.Resources.mensajeria
        Me.colmensajero.Name = "colmensajero"
        Me.colmensajero.ReadOnly = True
        Me.colmensajero.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colmensajero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colmensajero.Width = 20
        '
        'colACompReclamo
        '
        Me.colACompReclamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompReclamo.HeaderText = ""
        Me.colACompReclamo.Name = "colACompReclamo"
        Me.colACompReclamo.ReadOnly = True
        Me.colACompReclamo.Width = 20
        '
        'colACompAsignado
        '
        Me.colACompAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompAsignado.DataPropertyName = "v_hora_asignado"
        Me.colACompAsignado.HeaderText = "Asignado"
        Me.colACompAsignado.Name = "colACompAsignado"
        Me.colACompAsignado.ReadOnly = True
        Me.colACompAsignado.Width = 80
        '
        'colACompMovil
        '
        Me.colACompMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompMovil.DataPropertyName = "v_nroMovil"
        Me.colACompMovil.HeaderText = "Movil"
        Me.colACompMovil.Name = "colACompMovil"
        Me.colACompMovil.ReadOnly = True
        Me.colACompMovil.Width = 50
        '
        'colACompCambiarMovil
        '
        Me.colACompCambiarMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCambiarMovil.HeaderText = ""
        Me.colACompCambiarMovil.Image = Global.Apipe.My.Resources.Resources.movil
        Me.colACompCambiarMovil.Name = "colACompCambiarMovil"
        Me.colACompCambiarMovil.ReadOnly = True
        Me.colACompCambiarMovil.ToolTipText = "Cambiar móvil"
        Me.colACompCambiarMovil.Width = 20
        '
        'colACompDomicilio
        '
        Me.colACompDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompDomicilio.DataPropertyName = "v_domicilio"
        Me.colACompDomicilio.HeaderText = "Domicilio"
        Me.colACompDomicilio.Name = "colACompDomicilio"
        Me.colACompDomicilio.ReadOnly = True
        Me.colACompDomicilio.Width = 150
        '
        'colACompCliente
        '
        Me.colACompCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCliente.DataPropertyName = "cliente"
        Me.colACompCliente.HeaderText = "Cliente"
        Me.colACompCliente.Name = "colACompCliente"
        Me.colACompCliente.ReadOnly = True
        Me.colACompCliente.Width = 150
        '
        'btnMostrarCompletados
        '
        Me.btnMostrarCompletados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarCompletados.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMostrarCompletados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMostrarCompletados.Location = New System.Drawing.Point(357, 4)
        Me.btnMostrarCompletados.Name = "btnMostrarCompletados"
        Me.btnMostrarCompletados.Size = New System.Drawing.Size(40, 20)
        Me.btnMostrarCompletados.TabIndex = 9
        Me.btnMostrarCompletados.Text = "^"
        Me.btnMostrarCompletados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMostrarCompletados.UseVisualStyleBackColor = False
        '
        'dgvCompletados
        '
        Me.dgvCompletados.AllowUserToAddRows = False
        Me.dgvCompletados.AllowUserToDeleteRows = False
        Me.dgvCompletados.AllowUserToResizeRows = False
        Me.dgvCompletados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCompletados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvCompletados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompletados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colComVolver, Me.colComReclamo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompletados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCompletados.Location = New System.Drawing.Point(9, 31)
        Me.dgvCompletados.MultiSelect = False
        Me.dgvCompletados.Name = "dgvCompletados"
        Me.dgvCompletados.ReadOnly = True
        Me.dgvCompletados.RowHeadersVisible = False
        Me.dgvCompletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompletados.Size = New System.Drawing.Size(388, 106)
        Me.dgvCompletados.TabIndex = 8
        '
        'colComVolver
        '
        Me.colComVolver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colComVolver.HeaderText = ""
        Me.colComVolver.Image = Global.Apipe.My.Resources.Resources.deshacer
        Me.colComVolver.Name = "colComVolver"
        Me.colComVolver.ReadOnly = True
        Me.colComVolver.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colComVolver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colComVolver.Width = 20
        '
        'colComReclamo
        '
        Me.colComReclamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colComReclamo.HeaderText = ""
        Me.colComReclamo.Name = "colComReclamo"
        Me.colComReclamo.ReadOnly = True
        Me.colComReclamo.Width = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "v_hora_asignado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Asignado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Movil"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "v_domicilio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'txtCompletados
        '
        Me.txtCompletados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompletados.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtCompletados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompletados.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompletados.ForeColor = System.Drawing.Color.White
        Me.txtCompletados.Location = New System.Drawing.Point(9, 5)
        Me.txtCompletados.Name = "txtCompletados"
        Me.txtCompletados.ReadOnly = True
        Me.txtCompletados.Size = New System.Drawing.Size(388, 22)
        Me.txtCompletados.TabIndex = 7
        Me.txtCompletados.Text = "PEDIDOS COMPLETADOS"
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
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPedAsignar, Me.colPedReclamo, Me.colPedHora, Me.colPedHoraViaje, Me.colPedDomicilio, Me.colPedObservaciones})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPedidos.Location = New System.Drawing.Point(11, 42)
        Me.dgvPedidos.MultiSelect = False
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(367, 437)
        Me.dgvPedidos.TabIndex = 2
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
        'colPedReclamo
        '
        Me.colPedReclamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedReclamo.HeaderText = ""
        Me.colPedReclamo.Name = "colPedReclamo"
        Me.colPedReclamo.ReadOnly = True
        Me.colPedReclamo.Width = 20
        '
        'colPedHora
        '
        Me.colPedHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedHora.DataPropertyName = "v_hora"
        Me.colPedHora.HeaderText = "Pedido"
        Me.colPedHora.Name = "colPedHora"
        Me.colPedHora.ReadOnly = True
        Me.colPedHora.Visible = False
        Me.colPedHora.Width = 80
        '
        'colPedHoraViaje
        '
        Me.colPedHoraViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedHoraViaje.DataPropertyName = "v_hora_viaje"
        Me.colPedHoraViaje.HeaderText = "Viaje"
        Me.colPedHoraViaje.Name = "colPedHoraViaje"
        Me.colPedHoraViaje.ReadOnly = True
        Me.colPedHoraViaje.Width = 80
        '
        'colPedDomicilio
        '
        Me.colPedDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPedDomicilio.DataPropertyName = "v_domicilio"
        Me.colPedDomicilio.HeaderText = "Domicilio"
        Me.colPedDomicilio.Name = "colPedDomicilio"
        Me.colPedDomicilio.ReadOnly = True
        Me.colPedDomicilio.Width = 150
        '
        'colPedObservaciones
        '
        Me.colPedObservaciones.DataPropertyName = "observacion"
        Me.colPedObservaciones.HeaderText = "Observaciones"
        Me.colPedObservaciones.Name = "colPedObservaciones"
        Me.colPedObservaciones.ReadOnly = True
        '
        'txtPedidos
        '
        Me.txtPedidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPedidos.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidos.ForeColor = System.Drawing.Color.White
        Me.txtPedidos.Location = New System.Drawing.Point(12, 14)
        Me.txtPedidos.Name = "txtPedidos"
        Me.txtPedidos.ReadOnly = True
        Me.txtPedidos.Size = New System.Drawing.Size(367, 28)
        Me.txtPedidos.TabIndex = 4
        Me.txtPedidos.Text = "PEDIDOS PENDIENTES"
        '
        'txtBuscador
        '
        Me.txtBuscador.BackColor = System.Drawing.Color.Gold
        Me.txtBuscador.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(236, 48)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(100, 23)
        Me.txtBuscador.TabIndex = 2
        Me.txtBuscador.Visible = False
        '
        'lklPorBase
        '
        Me.lklPorBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lklPorBase.AutoSize = True
        Me.lklPorBase.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklPorBase.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lklPorBase.LinkColor = System.Drawing.Color.White
        Me.lklPorBase.Location = New System.Drawing.Point(273, -1)
        Me.lklPorBase.Name = "lklPorBase"
        Me.lklPorBase.Size = New System.Drawing.Size(63, 15)
        Me.lklPorBase.TabIndex = 15
        Me.lklPorBase.TabStop = True
        Me.lklPorBase.Text = "Por Base"
        Me.ToolTip1.SetToolTip(Me.lklPorBase, "Mostrar móviles por base")
        Me.lklPorBase.VisitedLinkColor = System.Drawing.Color.Gold
        '
        'lklPorFrecuencia
        '
        Me.lklPorFrecuencia.AutoSize = True
        Me.lklPorFrecuencia.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklPorFrecuencia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lklPorFrecuencia.LinkColor = System.Drawing.Color.White
        Me.lklPorFrecuencia.LinkVisited = True
        Me.lklPorFrecuencia.Location = New System.Drawing.Point(6, -1)
        Me.lklPorFrecuencia.Name = "lklPorFrecuencia"
        Me.lklPorFrecuencia.Size = New System.Drawing.Size(105, 15)
        Me.lklPorFrecuencia.TabIndex = 15
        Me.lklPorFrecuencia.TabStop = True
        Me.lklPorFrecuencia.Text = "Por Frecuencia"
        Me.ToolTip1.SetToolTip(Me.lklPorFrecuencia, "Mostrar móviles por frecuencia")
        Me.lklPorFrecuencia.VisitedLinkColor = System.Drawing.Color.Gold
        '
        'pnlBuscarMovil
        '
        Me.pnlBuscarMovil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlBuscarMovil.Controls.Add(Me.txtBuscarMovil)
        Me.pnlBuscarMovil.Location = New System.Drawing.Point(18, 412)
        Me.pnlBuscarMovil.Name = "pnlBuscarMovil"
        Me.pnlBuscarMovil.Size = New System.Drawing.Size(87, 40)
        Me.pnlBuscarMovil.TabIndex = 12
        Me.pnlBuscarMovil.Visible = False
        '
        'txtBuscarMovil
        '
        Me.txtBuscarMovil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarMovil.Location = New System.Drawing.Point(11, 8)
        Me.txtBuscarMovil.Name = "txtBuscarMovil"
        Me.txtBuscarMovil.Size = New System.Drawing.Size(65, 23)
        Me.txtBuscarMovil.TabIndex = 0
        '
        'dgvMoviles
        '
        Me.dgvMoviles.AllowUserToAddRows = False
        Me.dgvMoviles.AllowUserToDeleteRows = False
        Me.dgvMoviles.AllowUserToResizeRows = False
        Me.dgvMoviles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMoviles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvMoviles.ColumnHeadersHeight = 24
        Me.dgvMoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMoviles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMovAsignar, Me.colMovNro, Me.colMovAire, Me.colMovBaul, Me.colMovFactura, Me.colMovCantPedidos, Me.colMovUltPed, Me.colmovzona, Me.colMovBase, Me.colMovQuitar})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMoviles.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMoviles.Location = New System.Drawing.Point(9, 42)
        Me.dgvMoviles.MultiSelect = False
        Me.dgvMoviles.Name = "dgvMoviles"
        Me.dgvMoviles.ReadOnly = True
        Me.dgvMoviles.RowHeadersVisible = False
        Me.dgvMoviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMoviles.Size = New System.Drawing.Size(327, 437)
        Me.dgvMoviles.TabIndex = 1
        '
        'colMovAsignar
        '
        Me.colMovAsignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovAsignar.HeaderText = ""
        Me.colMovAsignar.Image = Global.Apipe.My.Resources.Resources.movil
        Me.colMovAsignar.Name = "colMovAsignar"
        Me.colMovAsignar.ReadOnly = True
        Me.colMovAsignar.ToolTipText = "Asignar"
        Me.colMovAsignar.Width = 20
        '
        'colMovNro
        '
        Me.colMovNro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovNro.DataPropertyName = "v_nroMovil"
        Me.colMovNro.HeaderText = "Movil"
        Me.colMovNro.Name = "colMovNro"
        Me.colMovNro.ReadOnly = True
        Me.colMovNro.Width = 50
        '
        'colMovAire
        '
        Me.colMovAire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovAire.HeaderText = ""
        Me.colMovAire.Name = "colMovAire"
        Me.colMovAire.ReadOnly = True
        Me.colMovAire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMovAire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colMovAire.Width = 20
        '
        'colMovBaul
        '
        Me.colMovBaul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovBaul.HeaderText = ""
        Me.colMovBaul.Name = "colMovBaul"
        Me.colMovBaul.ReadOnly = True
        Me.colMovBaul.Width = 20
        '
        'colMovFactura
        '
        Me.colMovFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovFactura.HeaderText = ""
        Me.colMovFactura.Name = "colMovFactura"
        Me.colMovFactura.ReadOnly = True
        Me.colMovFactura.Width = 20
        '
        'colMovCantPedidos
        '
        Me.colMovCantPedidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovCantPedidos.DataPropertyName = "v_cantPedidos"
        Me.colMovCantPedidos.HeaderText = "# Ped"
        Me.colMovCantPedidos.Name = "colMovCantPedidos"
        Me.colMovCantPedidos.ReadOnly = True
        Me.colMovCantPedidos.Visible = False
        Me.colMovCantPedidos.Width = 60
        '
        'colMovUltPed
        '
        Me.colMovUltPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovUltPed.DataPropertyName = "v_horaUltPed"
        Me.colMovUltPed.HeaderText = "Último"
        Me.colMovUltPed.Name = "colMovUltPed"
        Me.colMovUltPed.ReadOnly = True
        Me.colMovUltPed.Visible = False
        Me.colMovUltPed.Width = 80
        '
        'colmovzona
        '
        Me.colmovzona.DataPropertyName = "v_zona"
        Me.colmovzona.HeaderText = "Base"
        Me.colmovzona.Name = "colmovzona"
        Me.colmovzona.ReadOnly = True
        '
        'colMovBase
        '
        Me.colMovBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovBase.HeaderText = ""
        Me.colMovBase.Image = Global.Apipe.My.Resources.Resources.base
        Me.colMovBase.Name = "colMovBase"
        Me.colMovBase.ReadOnly = True
        Me.colMovBase.Width = 20
        '
        'colMovQuitar
        '
        Me.colMovQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMovQuitar.HeaderText = ""
        Me.colMovQuitar.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.colMovQuitar.Name = "colMovQuitar"
        Me.colMovQuitar.ReadOnly = True
        Me.colMovQuitar.Width = 20
        '
        'pbxBase
        '
        Me.pbxBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.pbxBase.Image = Global.Apipe.My.Resources.Resources.base
        Me.pbxBase.Location = New System.Drawing.Point(306, 10)
        Me.pbxBase.Name = "pbxBase"
        Me.pbxBase.Size = New System.Drawing.Size(30, 32)
        Me.pbxBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxBase.TabIndex = 14
        Me.pbxBase.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxBase, "Elegir Base")
        '
        'pbxAgregarMovil
        '
        Me.pbxAgregarMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.pbxAgregarMovil.Image = Global.Apipe.My.Resources.Resources.agregar_movil
        Me.pbxAgregarMovil.Location = New System.Drawing.Point(9, 10)
        Me.pbxAgregarMovil.Name = "pbxAgregarMovil"
        Me.pbxAgregarMovil.Size = New System.Drawing.Size(30, 32)
        Me.pbxAgregarMovil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxAgregarMovil.TabIndex = 14
        Me.pbxAgregarMovil.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxAgregarMovil, "Incorporar Móvil")
        '
        'txtMoviles
        '
        Me.txtMoviles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoviles.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtMoviles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMoviles.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoviles.ForeColor = System.Drawing.Color.White
        Me.txtMoviles.Location = New System.Drawing.Point(9, 10)
        Me.txtMoviles.Name = "txtMoviles"
        Me.txtMoviles.ReadOnly = True
        Me.txtMoviles.Size = New System.Drawing.Size(344, 28)
        Me.txtMoviles.TabIndex = 4
        Me.txtMoviles.Text = "MÓVILES"
        '
        'tmrAsignar
        '
        Me.tmrAsignar.Interval = 400
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.ToolTipText = "Completar"
        Me.DataGridViewImageColumn1.Width = 20
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.FillWeight = 120.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
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
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.ToolTipText = "Asignar al pedido"
        Me.DataGridViewImageColumn3.Width = 20
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn4.FillWeight = 120.0!
        Me.DataGridViewImageColumn4.HeaderText = ""
        Me.DataGridViewImageColumn4.Image = Global.Apipe.My.Resources.Resources.page_edit
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn4.ToolTipText = "Asignar un móvil"
        Me.DataGridViewImageColumn4.Width = 20
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn5.Width = 20
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn6.HeaderText = ""
        Me.DataGridViewImageColumn6.Image = Global.Apipe.My.Resources.Resources.house
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.ReadOnly = True
        Me.DataGridViewImageColumn6.Width = 25
        '
        'DataGridViewImageColumn7
        '
        Me.DataGridViewImageColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn7.HeaderText = ""
        Me.DataGridViewImageColumn7.Image = Global.Apipe.My.Resources.Resources.notiene
        Me.DataGridViewImageColumn7.Name = "DataGridViewImageColumn7"
        Me.DataGridViewImageColumn7.Width = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvZT)
        Me.GroupBox1.Controls.Add(Me.dgvZP)
        Me.GroupBox1.Controls.Add(Me.dgvZ10)
        Me.GroupBox1.Controls.Add(Me.dgvZ9)
        Me.GroupBox1.Controls.Add(Me.dgvZ8)
        Me.GroupBox1.Controls.Add(Me.dgvZ7)
        Me.GroupBox1.Controls.Add(Me.dgvZ6)
        Me.GroupBox1.Controls.Add(Me.dgvZ5)
        Me.GroupBox1.Controls.Add(Me.dgvZ4)
        Me.GroupBox1.Controls.Add(Me.dgvZ3)
        Me.GroupBox1.Controls.Add(Me.dgvZ2)
        Me.GroupBox1.Controls.Add(Me.dgvZ1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 586)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1188, 162)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SubBases"
        '
        'dgvZT
        '
        Me.dgvZT.AllowUserToAddRows = False
        Me.dgvZT.AllowUserToDeleteRows = False
        Me.dgvZT.AllowUserToResizeRows = False
        Me.dgvZT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZT.ColumnHeadersHeight = 24
        Me.dgvZT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn68, Me.DataGridViewTextBoxColumn45, Me.DataGridViewImageColumn69, Me.DataGridViewImageColumn70, Me.DataGridViewImageColumn71, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewImageColumn72, Me.DataGridViewImageColumn73})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZT.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvZT.Location = New System.Drawing.Point(1124, 10)
        Me.dgvZT.MultiSelect = False
        Me.dgvZT.Name = "dgvZT"
        Me.dgvZT.ReadOnly = True
        Me.dgvZT.RowHeadersVisible = False
        Me.dgvZT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZT.Size = New System.Drawing.Size(99, 148)
        Me.dgvZT.TabIndex = 13
        '
        'DataGridViewImageColumn68
        '
        Me.DataGridViewImageColumn68.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn68.HeaderText = ""
        Me.DataGridViewImageColumn68.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn68.Name = "DataGridViewImageColumn68"
        Me.DataGridViewImageColumn68.ReadOnly = True
        Me.DataGridViewImageColumn68.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn68.Width = 20
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Terminal"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Width = 35
        '
        'DataGridViewImageColumn69
        '
        Me.DataGridViewImageColumn69.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn69.HeaderText = ""
        Me.DataGridViewImageColumn69.Name = "DataGridViewImageColumn69"
        Me.DataGridViewImageColumn69.ReadOnly = True
        Me.DataGridViewImageColumn69.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn69.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn69.Visible = False
        Me.DataGridViewImageColumn69.Width = 20
        '
        'DataGridViewImageColumn70
        '
        Me.DataGridViewImageColumn70.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn70.HeaderText = ""
        Me.DataGridViewImageColumn70.Name = "DataGridViewImageColumn70"
        Me.DataGridViewImageColumn70.ReadOnly = True
        Me.DataGridViewImageColumn70.Visible = False
        Me.DataGridViewImageColumn70.Width = 20
        '
        'DataGridViewImageColumn71
        '
        Me.DataGridViewImageColumn71.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn71.HeaderText = ""
        Me.DataGridViewImageColumn71.Name = "DataGridViewImageColumn71"
        Me.DataGridViewImageColumn71.ReadOnly = True
        Me.DataGridViewImageColumn71.Visible = False
        Me.DataGridViewImageColumn71.Width = 20
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn46.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Visible = False
        Me.DataGridViewTextBoxColumn46.Width = 60
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Visible = False
        Me.DataGridViewTextBoxColumn47.Width = 80
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Visible = False
        '
        'DataGridViewImageColumn72
        '
        Me.DataGridViewImageColumn72.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn72.HeaderText = ""
        Me.DataGridViewImageColumn72.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn72.Name = "DataGridViewImageColumn72"
        Me.DataGridViewImageColumn72.ReadOnly = True
        Me.DataGridViewImageColumn72.Width = 20
        '
        'DataGridViewImageColumn73
        '
        Me.DataGridViewImageColumn73.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn73.HeaderText = ""
        Me.DataGridViewImageColumn73.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn73.Name = "DataGridViewImageColumn73"
        Me.DataGridViewImageColumn73.ReadOnly = True
        Me.DataGridViewImageColumn73.Visible = False
        Me.DataGridViewImageColumn73.Width = 20
        '
        'dgvZP
        '
        Me.dgvZP.AllowUserToAddRows = False
        Me.dgvZP.AllowUserToDeleteRows = False
        Me.dgvZP.AllowUserToResizeRows = False
        Me.dgvZP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZP.ColumnHeadersHeight = 24
        Me.dgvZP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn74, Me.DataGridViewTextBoxColumn49, Me.DataGridViewImageColumn75, Me.DataGridViewImageColumn76, Me.DataGridViewImageColumn77, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewImageColumn78, Me.DataGridViewImageColumn79})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZP.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvZP.Location = New System.Drawing.Point(1022, 10)
        Me.dgvZP.MultiSelect = False
        Me.dgvZP.Name = "dgvZP"
        Me.dgvZP.ReadOnly = True
        Me.dgvZP.RowHeadersVisible = False
        Me.dgvZP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZP.Size = New System.Drawing.Size(99, 148)
        Me.dgvZP.TabIndex = 12
        '
        'DataGridViewImageColumn74
        '
        Me.DataGridViewImageColumn74.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn74.HeaderText = ""
        Me.DataGridViewImageColumn74.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn74.Name = "DataGridViewImageColumn74"
        Me.DataGridViewImageColumn74.ReadOnly = True
        Me.DataGridViewImageColumn74.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn74.Width = 20
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Playa"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Width = 35
        '
        'DataGridViewImageColumn75
        '
        Me.DataGridViewImageColumn75.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn75.HeaderText = ""
        Me.DataGridViewImageColumn75.Name = "DataGridViewImageColumn75"
        Me.DataGridViewImageColumn75.ReadOnly = True
        Me.DataGridViewImageColumn75.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn75.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn75.Visible = False
        Me.DataGridViewImageColumn75.Width = 20
        '
        'DataGridViewImageColumn76
        '
        Me.DataGridViewImageColumn76.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn76.HeaderText = ""
        Me.DataGridViewImageColumn76.Name = "DataGridViewImageColumn76"
        Me.DataGridViewImageColumn76.ReadOnly = True
        Me.DataGridViewImageColumn76.Visible = False
        Me.DataGridViewImageColumn76.Width = 20
        '
        'DataGridViewImageColumn77
        '
        Me.DataGridViewImageColumn77.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn77.HeaderText = ""
        Me.DataGridViewImageColumn77.Name = "DataGridViewImageColumn77"
        Me.DataGridViewImageColumn77.ReadOnly = True
        Me.DataGridViewImageColumn77.Visible = False
        Me.DataGridViewImageColumn77.Width = 20
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn50.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Visible = False
        Me.DataGridViewTextBoxColumn50.Width = 60
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Visible = False
        Me.DataGridViewTextBoxColumn51.Width = 80
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Visible = False
        '
        'DataGridViewImageColumn78
        '
        Me.DataGridViewImageColumn78.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn78.HeaderText = ""
        Me.DataGridViewImageColumn78.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn78.Name = "DataGridViewImageColumn78"
        Me.DataGridViewImageColumn78.ReadOnly = True
        Me.DataGridViewImageColumn78.Width = 20
        '
        'DataGridViewImageColumn79
        '
        Me.DataGridViewImageColumn79.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn79.HeaderText = ""
        Me.DataGridViewImageColumn79.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn79.Name = "DataGridViewImageColumn79"
        Me.DataGridViewImageColumn79.ReadOnly = True
        Me.DataGridViewImageColumn79.Visible = False
        Me.DataGridViewImageColumn79.Width = 20
        '
        'dgvZ10
        '
        Me.dgvZ10.AllowUserToAddRows = False
        Me.dgvZ10.AllowUserToDeleteRows = False
        Me.dgvZ10.AllowUserToResizeRows = False
        Me.dgvZ10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ10.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ10.ColumnHeadersHeight = 24
        Me.dgvZ10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ10.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn56, Me.DataGridViewTextBoxColumn37, Me.DataGridViewImageColumn57, Me.DataGridViewImageColumn58, Me.DataGridViewImageColumn59, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewImageColumn60, Me.DataGridViewImageColumn61})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ10.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvZ10.Location = New System.Drawing.Point(920, 10)
        Me.dgvZ10.MultiSelect = False
        Me.dgvZ10.Name = "dgvZ10"
        Me.dgvZ10.ReadOnly = True
        Me.dgvZ10.RowHeadersVisible = False
        Me.dgvZ10.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ10.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ10.TabIndex = 11
        '
        'DataGridViewImageColumn56
        '
        Me.DataGridViewImageColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn56.HeaderText = ""
        Me.DataGridViewImageColumn56.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn56.Name = "DataGridViewImageColumn56"
        Me.DataGridViewImageColumn56.ReadOnly = True
        Me.DataGridViewImageColumn56.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn56.Width = 20
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn37.HeaderText = "B/10"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 35
        '
        'DataGridViewImageColumn57
        '
        Me.DataGridViewImageColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn57.HeaderText = ""
        Me.DataGridViewImageColumn57.Name = "DataGridViewImageColumn57"
        Me.DataGridViewImageColumn57.ReadOnly = True
        Me.DataGridViewImageColumn57.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn57.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn57.Visible = False
        Me.DataGridViewImageColumn57.Width = 20
        '
        'DataGridViewImageColumn58
        '
        Me.DataGridViewImageColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn58.HeaderText = ""
        Me.DataGridViewImageColumn58.Name = "DataGridViewImageColumn58"
        Me.DataGridViewImageColumn58.ReadOnly = True
        Me.DataGridViewImageColumn58.Visible = False
        Me.DataGridViewImageColumn58.Width = 20
        '
        'DataGridViewImageColumn59
        '
        Me.DataGridViewImageColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn59.HeaderText = ""
        Me.DataGridViewImageColumn59.Name = "DataGridViewImageColumn59"
        Me.DataGridViewImageColumn59.ReadOnly = True
        Me.DataGridViewImageColumn59.Visible = False
        Me.DataGridViewImageColumn59.Width = 20
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn38.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Visible = False
        Me.DataGridViewTextBoxColumn38.Width = 60
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Visible = False
        Me.DataGridViewTextBoxColumn39.Width = 80
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewImageColumn60
        '
        Me.DataGridViewImageColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn60.HeaderText = ""
        Me.DataGridViewImageColumn60.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn60.Name = "DataGridViewImageColumn60"
        Me.DataGridViewImageColumn60.ReadOnly = True
        Me.DataGridViewImageColumn60.Width = 20
        '
        'DataGridViewImageColumn61
        '
        Me.DataGridViewImageColumn61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn61.HeaderText = ""
        Me.DataGridViewImageColumn61.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn61.Name = "DataGridViewImageColumn61"
        Me.DataGridViewImageColumn61.ReadOnly = True
        Me.DataGridViewImageColumn61.Visible = False
        Me.DataGridViewImageColumn61.Width = 20
        '
        'dgvZ9
        '
        Me.dgvZ9.AllowUserToAddRows = False
        Me.dgvZ9.AllowUserToDeleteRows = False
        Me.dgvZ9.AllowUserToResizeRows = False
        Me.dgvZ9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ9.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ9.ColumnHeadersHeight = 24
        Me.dgvZ9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn62, Me.DataGridViewTextBoxColumn41, Me.DataGridViewImageColumn63, Me.DataGridViewImageColumn64, Me.DataGridViewImageColumn65, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewImageColumn66, Me.DataGridViewImageColumn67})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ9.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvZ9.Location = New System.Drawing.Point(818, 10)
        Me.dgvZ9.MultiSelect = False
        Me.dgvZ9.Name = "dgvZ9"
        Me.dgvZ9.ReadOnly = True
        Me.dgvZ9.RowHeadersVisible = False
        Me.dgvZ9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ9.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ9.TabIndex = 10
        '
        'DataGridViewImageColumn62
        '
        Me.DataGridViewImageColumn62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn62.HeaderText = ""
        Me.DataGridViewImageColumn62.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn62.Name = "DataGridViewImageColumn62"
        Me.DataGridViewImageColumn62.ReadOnly = True
        Me.DataGridViewImageColumn62.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn62.Width = 20
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn41.HeaderText = "B/9"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Width = 35
        '
        'DataGridViewImageColumn63
        '
        Me.DataGridViewImageColumn63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn63.HeaderText = ""
        Me.DataGridViewImageColumn63.Name = "DataGridViewImageColumn63"
        Me.DataGridViewImageColumn63.ReadOnly = True
        Me.DataGridViewImageColumn63.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn63.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn63.Visible = False
        Me.DataGridViewImageColumn63.Width = 20
        '
        'DataGridViewImageColumn64
        '
        Me.DataGridViewImageColumn64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn64.HeaderText = ""
        Me.DataGridViewImageColumn64.Name = "DataGridViewImageColumn64"
        Me.DataGridViewImageColumn64.ReadOnly = True
        Me.DataGridViewImageColumn64.Visible = False
        Me.DataGridViewImageColumn64.Width = 20
        '
        'DataGridViewImageColumn65
        '
        Me.DataGridViewImageColumn65.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn65.HeaderText = ""
        Me.DataGridViewImageColumn65.Name = "DataGridViewImageColumn65"
        Me.DataGridViewImageColumn65.ReadOnly = True
        Me.DataGridViewImageColumn65.Visible = False
        Me.DataGridViewImageColumn65.Width = 20
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn42.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        Me.DataGridViewTextBoxColumn42.Width = 60
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        Me.DataGridViewTextBoxColumn43.Width = 80
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Visible = False
        '
        'DataGridViewImageColumn66
        '
        Me.DataGridViewImageColumn66.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn66.HeaderText = ""
        Me.DataGridViewImageColumn66.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn66.Name = "DataGridViewImageColumn66"
        Me.DataGridViewImageColumn66.ReadOnly = True
        Me.DataGridViewImageColumn66.Width = 20
        '
        'DataGridViewImageColumn67
        '
        Me.DataGridViewImageColumn67.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn67.HeaderText = ""
        Me.DataGridViewImageColumn67.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn67.Name = "DataGridViewImageColumn67"
        Me.DataGridViewImageColumn67.ReadOnly = True
        Me.DataGridViewImageColumn67.Visible = False
        Me.DataGridViewImageColumn67.Width = 20
        '
        'dgvZ8
        '
        Me.dgvZ8.AllowUserToAddRows = False
        Me.dgvZ8.AllowUserToDeleteRows = False
        Me.dgvZ8.AllowUserToResizeRows = False
        Me.dgvZ8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ8.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ8.ColumnHeadersHeight = 24
        Me.dgvZ8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ8.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn44, Me.DataGridViewTextBoxColumn29, Me.DataGridViewImageColumn45, Me.DataGridViewImageColumn46, Me.DataGridViewImageColumn47, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewImageColumn48, Me.DataGridViewImageColumn49})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ8.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvZ8.Location = New System.Drawing.Point(716, 10)
        Me.dgvZ8.MultiSelect = False
        Me.dgvZ8.Name = "dgvZ8"
        Me.dgvZ8.ReadOnly = True
        Me.dgvZ8.RowHeadersVisible = False
        Me.dgvZ8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ8.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ8.TabIndex = 9
        '
        'DataGridViewImageColumn44
        '
        Me.DataGridViewImageColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn44.HeaderText = ""
        Me.DataGridViewImageColumn44.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn44.Name = "DataGridViewImageColumn44"
        Me.DataGridViewImageColumn44.ReadOnly = True
        Me.DataGridViewImageColumn44.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn44.Width = 20
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn29.HeaderText = "B/8"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 35
        '
        'DataGridViewImageColumn45
        '
        Me.DataGridViewImageColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn45.HeaderText = ""
        Me.DataGridViewImageColumn45.Name = "DataGridViewImageColumn45"
        Me.DataGridViewImageColumn45.ReadOnly = True
        Me.DataGridViewImageColumn45.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn45.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn45.Visible = False
        Me.DataGridViewImageColumn45.Width = 20
        '
        'DataGridViewImageColumn46
        '
        Me.DataGridViewImageColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn46.HeaderText = ""
        Me.DataGridViewImageColumn46.Name = "DataGridViewImageColumn46"
        Me.DataGridViewImageColumn46.ReadOnly = True
        Me.DataGridViewImageColumn46.Visible = False
        Me.DataGridViewImageColumn46.Width = 20
        '
        'DataGridViewImageColumn47
        '
        Me.DataGridViewImageColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn47.HeaderText = ""
        Me.DataGridViewImageColumn47.Name = "DataGridViewImageColumn47"
        Me.DataGridViewImageColumn47.ReadOnly = True
        Me.DataGridViewImageColumn47.Visible = False
        Me.DataGridViewImageColumn47.Width = 20
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn30.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        Me.DataGridViewTextBoxColumn30.Width = 60
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        Me.DataGridViewTextBoxColumn31.Width = 80
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewImageColumn48
        '
        Me.DataGridViewImageColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn48.HeaderText = ""
        Me.DataGridViewImageColumn48.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn48.Name = "DataGridViewImageColumn48"
        Me.DataGridViewImageColumn48.ReadOnly = True
        Me.DataGridViewImageColumn48.Width = 20
        '
        'DataGridViewImageColumn49
        '
        Me.DataGridViewImageColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn49.HeaderText = ""
        Me.DataGridViewImageColumn49.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn49.Name = "DataGridViewImageColumn49"
        Me.DataGridViewImageColumn49.ReadOnly = True
        Me.DataGridViewImageColumn49.Visible = False
        Me.DataGridViewImageColumn49.Width = 20
        '
        'dgvZ7
        '
        Me.dgvZ7.AllowUserToAddRows = False
        Me.dgvZ7.AllowUserToDeleteRows = False
        Me.dgvZ7.AllowUserToResizeRows = False
        Me.dgvZ7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ7.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ7.ColumnHeadersHeight = 24
        Me.dgvZ7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn50, Me.DataGridViewTextBoxColumn33, Me.DataGridViewImageColumn51, Me.DataGridViewImageColumn52, Me.DataGridViewImageColumn53, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewImageColumn54, Me.DataGridViewImageColumn55})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ7.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvZ7.Location = New System.Drawing.Point(614, 10)
        Me.dgvZ7.MultiSelect = False
        Me.dgvZ7.Name = "dgvZ7"
        Me.dgvZ7.ReadOnly = True
        Me.dgvZ7.RowHeadersVisible = False
        Me.dgvZ7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ7.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ7.TabIndex = 8
        '
        'DataGridViewImageColumn50
        '
        Me.DataGridViewImageColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn50.HeaderText = ""
        Me.DataGridViewImageColumn50.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn50.Name = "DataGridViewImageColumn50"
        Me.DataGridViewImageColumn50.ReadOnly = True
        Me.DataGridViewImageColumn50.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn50.Width = 20
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn33.HeaderText = "B/7"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 35
        '
        'DataGridViewImageColumn51
        '
        Me.DataGridViewImageColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn51.HeaderText = ""
        Me.DataGridViewImageColumn51.Name = "DataGridViewImageColumn51"
        Me.DataGridViewImageColumn51.ReadOnly = True
        Me.DataGridViewImageColumn51.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn51.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn51.Visible = False
        Me.DataGridViewImageColumn51.Width = 20
        '
        'DataGridViewImageColumn52
        '
        Me.DataGridViewImageColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn52.HeaderText = ""
        Me.DataGridViewImageColumn52.Name = "DataGridViewImageColumn52"
        Me.DataGridViewImageColumn52.ReadOnly = True
        Me.DataGridViewImageColumn52.Visible = False
        Me.DataGridViewImageColumn52.Width = 20
        '
        'DataGridViewImageColumn53
        '
        Me.DataGridViewImageColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn53.HeaderText = ""
        Me.DataGridViewImageColumn53.Name = "DataGridViewImageColumn53"
        Me.DataGridViewImageColumn53.ReadOnly = True
        Me.DataGridViewImageColumn53.Visible = False
        Me.DataGridViewImageColumn53.Width = 20
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn34.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Visible = False
        Me.DataGridViewTextBoxColumn34.Width = 60
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        Me.DataGridViewTextBoxColumn35.Width = 80
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewImageColumn54
        '
        Me.DataGridViewImageColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn54.HeaderText = ""
        Me.DataGridViewImageColumn54.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn54.Name = "DataGridViewImageColumn54"
        Me.DataGridViewImageColumn54.ReadOnly = True
        Me.DataGridViewImageColumn54.Width = 20
        '
        'DataGridViewImageColumn55
        '
        Me.DataGridViewImageColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn55.HeaderText = ""
        Me.DataGridViewImageColumn55.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn55.Name = "DataGridViewImageColumn55"
        Me.DataGridViewImageColumn55.ReadOnly = True
        Me.DataGridViewImageColumn55.Visible = False
        Me.DataGridViewImageColumn55.Width = 20
        '
        'dgvZ6
        '
        Me.dgvZ6.AllowUserToAddRows = False
        Me.dgvZ6.AllowUserToDeleteRows = False
        Me.dgvZ6.AllowUserToResizeRows = False
        Me.dgvZ6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ6.ColumnHeadersHeight = 24
        Me.dgvZ6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn32, Me.DataGridViewTextBoxColumn21, Me.DataGridViewImageColumn33, Me.DataGridViewImageColumn34, Me.DataGridViewImageColumn35, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewImageColumn36, Me.DataGridViewImageColumn37})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ6.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvZ6.Location = New System.Drawing.Point(512, 10)
        Me.dgvZ6.MultiSelect = False
        Me.dgvZ6.Name = "dgvZ6"
        Me.dgvZ6.ReadOnly = True
        Me.dgvZ6.RowHeadersVisible = False
        Me.dgvZ6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ6.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ6.TabIndex = 7
        '
        'DataGridViewImageColumn32
        '
        Me.DataGridViewImageColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn32.HeaderText = ""
        Me.DataGridViewImageColumn32.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn32.Name = "DataGridViewImageColumn32"
        Me.DataGridViewImageColumn32.ReadOnly = True
        Me.DataGridViewImageColumn32.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn32.Width = 20
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn21.HeaderText = "B/6"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 35
        '
        'DataGridViewImageColumn33
        '
        Me.DataGridViewImageColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn33.HeaderText = ""
        Me.DataGridViewImageColumn33.Name = "DataGridViewImageColumn33"
        Me.DataGridViewImageColumn33.ReadOnly = True
        Me.DataGridViewImageColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn33.Visible = False
        Me.DataGridViewImageColumn33.Width = 20
        '
        'DataGridViewImageColumn34
        '
        Me.DataGridViewImageColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn34.HeaderText = ""
        Me.DataGridViewImageColumn34.Name = "DataGridViewImageColumn34"
        Me.DataGridViewImageColumn34.ReadOnly = True
        Me.DataGridViewImageColumn34.Visible = False
        Me.DataGridViewImageColumn34.Width = 20
        '
        'DataGridViewImageColumn35
        '
        Me.DataGridViewImageColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn35.HeaderText = ""
        Me.DataGridViewImageColumn35.Name = "DataGridViewImageColumn35"
        Me.DataGridViewImageColumn35.ReadOnly = True
        Me.DataGridViewImageColumn35.Visible = False
        Me.DataGridViewImageColumn35.Width = 20
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn22.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 80
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewImageColumn36
        '
        Me.DataGridViewImageColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn36.HeaderText = ""
        Me.DataGridViewImageColumn36.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn36.Name = "DataGridViewImageColumn36"
        Me.DataGridViewImageColumn36.ReadOnly = True
        Me.DataGridViewImageColumn36.Width = 20
        '
        'DataGridViewImageColumn37
        '
        Me.DataGridViewImageColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn37.HeaderText = ""
        Me.DataGridViewImageColumn37.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn37.Name = "DataGridViewImageColumn37"
        Me.DataGridViewImageColumn37.ReadOnly = True
        Me.DataGridViewImageColumn37.Visible = False
        Me.DataGridViewImageColumn37.Width = 20
        '
        'dgvZ5
        '
        Me.dgvZ5.AllowUserToAddRows = False
        Me.dgvZ5.AllowUserToDeleteRows = False
        Me.dgvZ5.AllowUserToResizeRows = False
        Me.dgvZ5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ5.ColumnHeadersHeight = 24
        Me.dgvZ5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn38, Me.DataGridViewTextBoxColumn25, Me.DataGridViewImageColumn39, Me.DataGridViewImageColumn40, Me.DataGridViewImageColumn41, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewImageColumn42, Me.DataGridViewImageColumn43})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ5.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvZ5.Location = New System.Drawing.Point(410, 10)
        Me.dgvZ5.MultiSelect = False
        Me.dgvZ5.Name = "dgvZ5"
        Me.dgvZ5.ReadOnly = True
        Me.dgvZ5.RowHeadersVisible = False
        Me.dgvZ5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ5.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ5.TabIndex = 6
        '
        'DataGridViewImageColumn38
        '
        Me.DataGridViewImageColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn38.HeaderText = ""
        Me.DataGridViewImageColumn38.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn38.Name = "DataGridViewImageColumn38"
        Me.DataGridViewImageColumn38.ReadOnly = True
        Me.DataGridViewImageColumn38.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn38.Width = 20
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn25.HeaderText = "B/5"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 35
        '
        'DataGridViewImageColumn39
        '
        Me.DataGridViewImageColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn39.HeaderText = ""
        Me.DataGridViewImageColumn39.Name = "DataGridViewImageColumn39"
        Me.DataGridViewImageColumn39.ReadOnly = True
        Me.DataGridViewImageColumn39.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn39.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn39.Visible = False
        Me.DataGridViewImageColumn39.Width = 20
        '
        'DataGridViewImageColumn40
        '
        Me.DataGridViewImageColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn40.HeaderText = ""
        Me.DataGridViewImageColumn40.Name = "DataGridViewImageColumn40"
        Me.DataGridViewImageColumn40.ReadOnly = True
        Me.DataGridViewImageColumn40.Visible = False
        Me.DataGridViewImageColumn40.Width = 20
        '
        'DataGridViewImageColumn41
        '
        Me.DataGridViewImageColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn41.HeaderText = ""
        Me.DataGridViewImageColumn41.Name = "DataGridViewImageColumn41"
        Me.DataGridViewImageColumn41.ReadOnly = True
        Me.DataGridViewImageColumn41.Visible = False
        Me.DataGridViewImageColumn41.Width = 20
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn26.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 60
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 80
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewImageColumn42
        '
        Me.DataGridViewImageColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn42.HeaderText = ""
        Me.DataGridViewImageColumn42.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn42.Name = "DataGridViewImageColumn42"
        Me.DataGridViewImageColumn42.ReadOnly = True
        Me.DataGridViewImageColumn42.Width = 20
        '
        'DataGridViewImageColumn43
        '
        Me.DataGridViewImageColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn43.HeaderText = ""
        Me.DataGridViewImageColumn43.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn43.Name = "DataGridViewImageColumn43"
        Me.DataGridViewImageColumn43.ReadOnly = True
        Me.DataGridViewImageColumn43.Visible = False
        Me.DataGridViewImageColumn43.Width = 20
        '
        'dgvZ4
        '
        Me.dgvZ4.AllowUserToAddRows = False
        Me.dgvZ4.AllowUserToDeleteRows = False
        Me.dgvZ4.AllowUserToResizeRows = False
        Me.dgvZ4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ4.ColumnHeadersHeight = 24
        Me.dgvZ4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn20, Me.DataGridViewTextBoxColumn13, Me.DataGridViewImageColumn21, Me.DataGridViewImageColumn22, Me.DataGridViewImageColumn23, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewImageColumn24, Me.DataGridViewImageColumn25})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ4.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvZ4.Location = New System.Drawing.Point(308, 10)
        Me.dgvZ4.MultiSelect = False
        Me.dgvZ4.Name = "dgvZ4"
        Me.dgvZ4.ReadOnly = True
        Me.dgvZ4.RowHeadersVisible = False
        Me.dgvZ4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ4.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ4.TabIndex = 5
        '
        'DataGridViewImageColumn20
        '
        Me.DataGridViewImageColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn20.HeaderText = ""
        Me.DataGridViewImageColumn20.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn20.Name = "DataGridViewImageColumn20"
        Me.DataGridViewImageColumn20.ReadOnly = True
        Me.DataGridViewImageColumn20.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn20.Width = 20
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn13.HeaderText = "B/4"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 35
        '
        'DataGridViewImageColumn21
        '
        Me.DataGridViewImageColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn21.HeaderText = ""
        Me.DataGridViewImageColumn21.Name = "DataGridViewImageColumn21"
        Me.DataGridViewImageColumn21.ReadOnly = True
        Me.DataGridViewImageColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn21.Visible = False
        Me.DataGridViewImageColumn21.Width = 20
        '
        'DataGridViewImageColumn22
        '
        Me.DataGridViewImageColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn22.HeaderText = ""
        Me.DataGridViewImageColumn22.Name = "DataGridViewImageColumn22"
        Me.DataGridViewImageColumn22.ReadOnly = True
        Me.DataGridViewImageColumn22.Visible = False
        Me.DataGridViewImageColumn22.Width = 20
        '
        'DataGridViewImageColumn23
        '
        Me.DataGridViewImageColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn23.HeaderText = ""
        Me.DataGridViewImageColumn23.Name = "DataGridViewImageColumn23"
        Me.DataGridViewImageColumn23.ReadOnly = True
        Me.DataGridViewImageColumn23.Visible = False
        Me.DataGridViewImageColumn23.Width = 20
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 60
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewImageColumn24
        '
        Me.DataGridViewImageColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn24.HeaderText = ""
        Me.DataGridViewImageColumn24.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn24.Name = "DataGridViewImageColumn24"
        Me.DataGridViewImageColumn24.ReadOnly = True
        Me.DataGridViewImageColumn24.Width = 20
        '
        'DataGridViewImageColumn25
        '
        Me.DataGridViewImageColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn25.HeaderText = ""
        Me.DataGridViewImageColumn25.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn25.Name = "DataGridViewImageColumn25"
        Me.DataGridViewImageColumn25.ReadOnly = True
        Me.DataGridViewImageColumn25.Width = 20
        '
        'dgvZ3
        '
        Me.dgvZ3.AllowUserToAddRows = False
        Me.dgvZ3.AllowUserToDeleteRows = False
        Me.dgvZ3.AllowUserToResizeRows = False
        Me.dgvZ3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ3.ColumnHeadersHeight = 24
        Me.dgvZ3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn26, Me.DataGridViewTextBoxColumn17, Me.DataGridViewImageColumn27, Me.DataGridViewImageColumn28, Me.DataGridViewImageColumn29, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewImageColumn30, Me.DataGridViewImageColumn31})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ3.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvZ3.Location = New System.Drawing.Point(206, 10)
        Me.dgvZ3.MultiSelect = False
        Me.dgvZ3.Name = "dgvZ3"
        Me.dgvZ3.ReadOnly = True
        Me.dgvZ3.RowHeadersVisible = False
        Me.dgvZ3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ3.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ3.TabIndex = 4
        '
        'DataGridViewImageColumn26
        '
        Me.DataGridViewImageColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn26.HeaderText = ""
        Me.DataGridViewImageColumn26.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn26.Name = "DataGridViewImageColumn26"
        Me.DataGridViewImageColumn26.ReadOnly = True
        Me.DataGridViewImageColumn26.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn26.Width = 20
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn17.HeaderText = "B/3"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 35
        '
        'DataGridViewImageColumn27
        '
        Me.DataGridViewImageColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn27.HeaderText = ""
        Me.DataGridViewImageColumn27.Name = "DataGridViewImageColumn27"
        Me.DataGridViewImageColumn27.ReadOnly = True
        Me.DataGridViewImageColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn27.Visible = False
        Me.DataGridViewImageColumn27.Width = 20
        '
        'DataGridViewImageColumn28
        '
        Me.DataGridViewImageColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn28.HeaderText = ""
        Me.DataGridViewImageColumn28.Name = "DataGridViewImageColumn28"
        Me.DataGridViewImageColumn28.ReadOnly = True
        Me.DataGridViewImageColumn28.Visible = False
        Me.DataGridViewImageColumn28.Width = 20
        '
        'DataGridViewImageColumn29
        '
        Me.DataGridViewImageColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn29.HeaderText = ""
        Me.DataGridViewImageColumn29.Name = "DataGridViewImageColumn29"
        Me.DataGridViewImageColumn29.ReadOnly = True
        Me.DataGridViewImageColumn29.Visible = False
        Me.DataGridViewImageColumn29.Width = 20
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn18.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 60
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewImageColumn30
        '
        Me.DataGridViewImageColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn30.HeaderText = ""
        Me.DataGridViewImageColumn30.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn30.Name = "DataGridViewImageColumn30"
        Me.DataGridViewImageColumn30.ReadOnly = True
        Me.DataGridViewImageColumn30.Width = 20
        '
        'DataGridViewImageColumn31
        '
        Me.DataGridViewImageColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn31.HeaderText = ""
        Me.DataGridViewImageColumn31.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn31.Name = "DataGridViewImageColumn31"
        Me.DataGridViewImageColumn31.ReadOnly = True
        Me.DataGridViewImageColumn31.Visible = False
        Me.DataGridViewImageColumn31.Width = 20
        '
        'dgvZ2
        '
        Me.dgvZ2.AllowUserToAddRows = False
        Me.dgvZ2.AllowUserToDeleteRows = False
        Me.dgvZ2.AllowUserToResizeRows = False
        Me.dgvZ2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ2.ColumnHeadersHeight = 24
        Me.dgvZ2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn14, Me.DataGridViewTextBoxColumn9, Me.DataGridViewImageColumn15, Me.DataGridViewImageColumn16, Me.DataGridViewImageColumn17, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewImageColumn18, Me.DataGridViewImageColumn19})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ2.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvZ2.Location = New System.Drawing.Point(104, 10)
        Me.dgvZ2.MultiSelect = False
        Me.dgvZ2.Name = "dgvZ2"
        Me.dgvZ2.ReadOnly = True
        Me.dgvZ2.RowHeadersVisible = False
        Me.dgvZ2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvZ2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ2.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ2.TabIndex = 3
        '
        'DataGridViewImageColumn14
        '
        Me.DataGridViewImageColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn14.HeaderText = ""
        Me.DataGridViewImageColumn14.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn14.Name = "DataGridViewImageColumn14"
        Me.DataGridViewImageColumn14.ReadOnly = True
        Me.DataGridViewImageColumn14.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn14.Width = 20
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn9.HeaderText = "B/2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 35
        '
        'DataGridViewImageColumn15
        '
        Me.DataGridViewImageColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn15.HeaderText = ""
        Me.DataGridViewImageColumn15.Name = "DataGridViewImageColumn15"
        Me.DataGridViewImageColumn15.ReadOnly = True
        Me.DataGridViewImageColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn15.Visible = False
        Me.DataGridViewImageColumn15.Width = 20
        '
        'DataGridViewImageColumn16
        '
        Me.DataGridViewImageColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn16.HeaderText = ""
        Me.DataGridViewImageColumn16.Name = "DataGridViewImageColumn16"
        Me.DataGridViewImageColumn16.ReadOnly = True
        Me.DataGridViewImageColumn16.Visible = False
        Me.DataGridViewImageColumn16.Width = 20
        '
        'DataGridViewImageColumn17
        '
        Me.DataGridViewImageColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn17.HeaderText = ""
        Me.DataGridViewImageColumn17.Name = "DataGridViewImageColumn17"
        Me.DataGridViewImageColumn17.ReadOnly = True
        Me.DataGridViewImageColumn17.Visible = False
        Me.DataGridViewImageColumn17.Width = 20
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn10.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewImageColumn18
        '
        Me.DataGridViewImageColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn18.HeaderText = ""
        Me.DataGridViewImageColumn18.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn18.Name = "DataGridViewImageColumn18"
        Me.DataGridViewImageColumn18.ReadOnly = True
        Me.DataGridViewImageColumn18.Width = 20
        '
        'DataGridViewImageColumn19
        '
        Me.DataGridViewImageColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn19.HeaderText = ""
        Me.DataGridViewImageColumn19.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn19.Name = "DataGridViewImageColumn19"
        Me.DataGridViewImageColumn19.ReadOnly = True
        Me.DataGridViewImageColumn19.Visible = False
        Me.DataGridViewImageColumn19.Width = 20
        '
        'dgvZ1
        '
        Me.dgvZ1.AllowUserToAddRows = False
        Me.dgvZ1.AllowUserToDeleteRows = False
        Me.dgvZ1.AllowUserToResizeRows = False
        Me.dgvZ1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvZ1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvZ1.ColumnHeadersHeight = 24
        Me.dgvZ1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvZ1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn8, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn9, Me.DataGridViewImageColumn10, Me.DataGridViewImageColumn11, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn12, Me.DataGridViewImageColumn13})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZ1.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvZ1.Location = New System.Drawing.Point(2, 10)
        Me.dgvZ1.MultiSelect = False
        Me.dgvZ1.Name = "dgvZ1"
        Me.dgvZ1.ReadOnly = True
        Me.dgvZ1.RowHeadersVisible = False
        Me.dgvZ1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZ1.Size = New System.Drawing.Size(99, 148)
        Me.dgvZ1.TabIndex = 2
        '
        'DataGridViewImageColumn8
        '
        Me.DataGridViewImageColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn8.HeaderText = ""
        Me.DataGridViewImageColumn8.Image = Global.Apipe.My.Resources.Resources.movil
        Me.DataGridViewImageColumn8.Name = "DataGridViewImageColumn8"
        Me.DataGridViewImageColumn8.ReadOnly = True
        Me.DataGridViewImageColumn8.ToolTipText = "Asignar"
        Me.DataGridViewImageColumn8.Width = 20
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "v_nroMovil"
        Me.DataGridViewTextBoxColumn5.HeaderText = "B/1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 35
        '
        'DataGridViewImageColumn9
        '
        Me.DataGridViewImageColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn9.HeaderText = ""
        Me.DataGridViewImageColumn9.Name = "DataGridViewImageColumn9"
        Me.DataGridViewImageColumn9.ReadOnly = True
        Me.DataGridViewImageColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn9.Visible = False
        Me.DataGridViewImageColumn9.Width = 20
        '
        'DataGridViewImageColumn10
        '
        Me.DataGridViewImageColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn10.HeaderText = ""
        Me.DataGridViewImageColumn10.Name = "DataGridViewImageColumn10"
        Me.DataGridViewImageColumn10.ReadOnly = True
        Me.DataGridViewImageColumn10.Visible = False
        Me.DataGridViewImageColumn10.Width = 20
        '
        'DataGridViewImageColumn11
        '
        Me.DataGridViewImageColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn11.HeaderText = ""
        Me.DataGridViewImageColumn11.Name = "DataGridViewImageColumn11"
        Me.DataGridViewImageColumn11.ReadOnly = True
        Me.DataGridViewImageColumn11.Visible = False
        Me.DataGridViewImageColumn11.Width = 20
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "v_cantPedidos"
        Me.DataGridViewTextBoxColumn6.HeaderText = "# Ped"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "v_horaUltPed"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Último"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "v_zona"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewImageColumn12
        '
        Me.DataGridViewImageColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn12.HeaderText = ""
        Me.DataGridViewImageColumn12.Image = Global.Apipe.My.Resources.Resources.base
        Me.DataGridViewImageColumn12.Name = "DataGridViewImageColumn12"
        Me.DataGridViewImageColumn12.ReadOnly = True
        Me.DataGridViewImageColumn12.Width = 20
        '
        'DataGridViewImageColumn13
        '
        Me.DataGridViewImageColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn13.HeaderText = ""
        Me.DataGridViewImageColumn13.Image = Global.Apipe.My.Resources.Resources.quitar_movil
        Me.DataGridViewImageColumn13.Name = "DataGridViewImageColumn13"
        Me.DataGridViewImageColumn13.ReadOnly = True
        Me.DataGridViewImageColumn13.Visible = False
        Me.DataGridViewImageColumn13.Width = 20
        '
        'tmrBuscarMovil
        '
        Me.tmrBuscarMovil.Interval = 5000000
        '
        'FrmAdministrarPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1194, 750)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.spcTodo)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdministrarPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.spcTodo.Panel1.ResumeLayout(False)
        Me.spcTodo.Panel2.ResumeLayout(False)
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTodo.ResumeLayout(False)
        Me.gbxDetalle.ResumeLayout(False)
        Me.spcArriba.Panel1.ResumeLayout(False)
        Me.spcArriba.Panel2.ResumeLayout(False)
        Me.spcArriba.Panel2.PerformLayout()
        CType(Me.spcArriba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcArriba.ResumeLayout(False)
        Me.spcPedidos.Panel1.ResumeLayout(False)
        Me.spcPedidos.Panel2.ResumeLayout(False)
        CType(Me.spcPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcPedidos.ResumeLayout(False)
        Me.spcAsignados.Panel1.ResumeLayout(False)
        Me.spcAsignados.Panel2.ResumeLayout(False)
        CType(Me.spcAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcAsignados.ResumeLayout(False)
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompletados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscarMovil.ResumeLayout(False)
        Me.pnlBuscarMovil.PerformLayout()
        CType(Me.dgvMoviles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAgregarMovil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvZT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZ1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcTodo As System.Windows.Forms.SplitContainer
    Friend WithEvents spcArriba As System.Windows.Forms.SplitContainer
    Friend WithEvents spcPedidos As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents colPedObservacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMoviles As System.Windows.Forms.DataGridView
    Friend WithEvents txtPedidos As System.Windows.Forms.RichTextBox
    Friend WithEvents txtMoviles As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlBuscarMovil As System.Windows.Forms.Panel
    Friend WithEvents txtBuscarMovil As System.Windows.Forms.TextBox
    Friend WithEvents tmrAsignar As System.Windows.Forms.Timer
    Friend WithEvents spcAsignados As System.Windows.Forms.SplitContainer
    Friend WithEvents txtACompletar As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvACompletar As System.Windows.Forms.DataGridView
    Friend WithEvents txtCompletados As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvCompletados As System.Windows.Forms.DataGridView
    Friend WithEvents colComVolver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colComReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents btnMostrarCompletados As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pbxAgregarMovil As System.Windows.Forms.PictureBox
    Friend WithEvents lklPorBase As System.Windows.Forms.LinkLabel
    Friend WithEvents lklPorFrecuencia As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridViewImageColumn7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pbxBase As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents colMovAsignar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colMovNro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovAire As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colMovBaul As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colMovFactura As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colMovCantPedidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovUltPed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmovzona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovBase As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colMovQuitar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvZ2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZT As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZP As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ10 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ9 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ8 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ7 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ6 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ5 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ4 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvZ3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn20 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn21 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn22 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn23 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn24 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn25 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn68 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn69 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn70 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn71 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn72 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn73 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn74 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn75 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn76 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn77 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn78 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn79 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn56 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn57 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn58 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn59 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn60 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn61 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn62 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn63 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn64 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn65 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn66 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn67 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn44 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn45 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn46 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn47 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn48 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn49 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn50 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn51 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn52 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn53 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn54 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn55 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn32 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn33 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn34 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn35 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn36 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn37 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn38 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn39 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn40 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn41 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn42 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn43 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn26 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn27 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn28 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn29 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn30 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn31 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn14 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn15 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn16 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn17 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn18 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn19 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn9 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn10 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn11 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn12 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn13 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompCompletar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colmensajero As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCambiarMovil As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmrBuscarMovil As System.Windows.Forms.Timer
    Friend WithEvents colPedAsignar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPedReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPedHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedHoraViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPedObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
End Class
