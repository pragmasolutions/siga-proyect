<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensajero
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
        Me.dgvACompletar = New System.Windows.Forms.DataGridView()
        Me.bgsACompletar = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDetalle = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.colACompCompletar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCambiarMovil = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgsACompletar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvACompletar
        '
        Me.dgvACompletar.AllowUserToAddRows = False
        Me.dgvACompletar.AllowUserToDeleteRows = False
        Me.dgvACompletar.AllowUserToResizeRows = False
        Me.dgvACompletar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvACompletar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvACompletar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvACompletar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvACompletar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvACompletar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colACompCompletar, Me.colACompReclamo, Me.colACompAsignado, Me.colACompMovil, Me.colACompCambiarMovil, Me.colACompDomicilio, Me.colACompCliente})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvACompletar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvACompletar.Location = New System.Drawing.Point(12, 130)
        Me.dgvACompletar.MultiSelect = False
        Me.dgvACompletar.Name = "dgvACompletar"
        Me.dgvACompletar.ReadOnly = True
        Me.dgvACompletar.RowHeadersVisible = False
        Me.dgvACompletar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvACompletar.Size = New System.Drawing.Size(856, 417)
        Me.dgvACompletar.TabIndex = 6
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDetalle.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.White
        Me.txtDetalle.Location = New System.Drawing.Point(0, 0)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDetalle.Size = New System.Drawing.Size(880, 97)
        Me.txtDetalle.TabIndex = 8
        Me.txtDetalle.TabStop = False
        Me.txtDetalle.Text = "(Detalle)"
        '
        'Timer1
        '
        '
        'colACompCompletar
        '
        Me.colACompCompletar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCompletar.HeaderText = ""
        Me.colACompCompletar.Image = Global.Apipe.My.Resources.Resources.mensajeria
        Me.colACompCompletar.Name = "colACompCompletar"
        Me.colACompCompletar.ReadOnly = True
        Me.colACompCompletar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colACompCompletar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colACompCompletar.ToolTipText = "Completar"
        Me.colACompCompletar.Width = 20
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
        'FrmMensajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(880, 569)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.dgvACompletar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMensajero"
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgsACompletar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvACompletar As System.Windows.Forms.DataGridView
    Friend WithEvents bgsACompletar As System.Windows.Forms.BindingSource
    Friend WithEvents txtDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents colACompCompletar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCambiarMovil As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
