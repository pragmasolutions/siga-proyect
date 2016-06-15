<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarMovil
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
        Me.DgvMovil = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Baul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmsBuscarMovil = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BgsMovil = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgvMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsBuscarMovil.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BgsMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvMovil
        '
        Me.DgvMovil.AllowUserToAddRows = False
        Me.DgvMovil.AllowUserToDeleteRows = False
        Me.DgvMovil.AllowUserToResizeColumns = False
        Me.DgvMovil.AllowUserToResizeRows = False
        Me.DgvMovil.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMovil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMovil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Chapa, Me.Color, Me.Marca, Me.Modelo, Me.Habilitacion, Me.Aire, Me.Baul, Me.Seguro, Me.Observacion, Me.Habilitado})
        Me.DgvMovil.ContextMenuStrip = Me.CmsBuscarMovil
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMovil.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMovil.Location = New System.Drawing.Point(0, 28)
        Me.DgvMovil.MultiSelect = False
        Me.DgvMovil.Name = "DgvMovil"
        Me.DgvMovil.RowHeadersVisible = False
        Me.DgvMovil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMovil.Size = New System.Drawing.Size(1080, 360)
        Me.DgvMovil.TabIndex = 0
        '
        'Numero
        '
        Me.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Numero.DataPropertyName = "Numero"
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 77
        '
        'Chapa
        '
        Me.Chapa.DataPropertyName = "chapa"
        Me.Chapa.HeaderText = "Patente"
        Me.Chapa.Name = "Chapa"
        '
        'Color
        '
        Me.Color.DataPropertyName = "color"
        Me.Color.HeaderText = "Color"
        Me.Color.Name = "Color"
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        '
        'Habilitacion
        '
        Me.Habilitacion.DataPropertyName = "habilitacion"
        Me.Habilitacion.HeaderText = "Habilitacion"
        Me.Habilitacion.Name = "Habilitacion"
        '
        'Aire
        '
        Me.Aire.DataPropertyName = "v_aire"
        Me.Aire.HeaderText = "Aire"
        Me.Aire.Name = "Aire"
        '
        'Baul
        '
        Me.Baul.DataPropertyName = "baul"
        Me.Baul.HeaderText = "Baul"
        Me.Baul.Name = "Baul"
        '
        'Seguro
        '
        Me.Seguro.DataPropertyName = "seguro"
        Me.Seguro.HeaderText = "Seguro"
        Me.Seguro.Name = "Seguro"
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "observacion"
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "v_habilitado"
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        '
        'CmsBuscarMovil
        '
        Me.CmsBuscarMovil.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.CmsBuscarMovil.Name = "CmsBuscarMovil"
        Me.CmsBuscarMovil.Size = New System.Drawing.Size(153, 48)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.BtnNuevo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1092, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Buscar"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Apipe.My.Resources.Resources.buscar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Buscar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.Apipe.My.Resources.Resources._auto
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.BtnNuevo.Text = "Nuevo"
        '
        'FrmBuscarMovil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1092, 436)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DgvMovil)
        Me.Name = "FrmBuscarMovil"
        Me.Text = "Buscar Movil"
        CType(Me.DgvMovil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsBuscarMovil.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BgsMovil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvMovil As System.Windows.Forms.DataGridView
    Friend WithEvents BgsMovil As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chapa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aire As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Baul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seguro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmsBuscarMovil As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
