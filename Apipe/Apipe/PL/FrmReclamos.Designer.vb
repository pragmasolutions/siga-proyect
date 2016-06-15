<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReclamos
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
        Me.pnlReclamo = New System.Windows.Forms.Panel()
        Me.cbFinalizar = New System.Windows.Forms.CheckBox()
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReclamo = New System.Windows.Forms.DataGridView()
        Me.fechahora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLineas = New System.Windows.Forms.Label()
        Me.pnlLineas = New System.Windows.Forms.Panel()
        Me.pnlNuevo = New System.Windows.Forms.Panel()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNuevo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.ErrReclamos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlReclamo.SuspendLayout()
        CType(Me.dgvReclamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLineas.SuspendLayout()
        Me.pnlNuevo.SuspendLayout()
        CType(Me.ErrReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReclamo
        '
        Me.pnlReclamo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlReclamo.Controls.Add(Me.cbFinalizar)
        Me.pnlReclamo.Controls.Add(Me.cbxCategorias)
        Me.pnlReclamo.Controls.Add(Me.Label1)
        Me.pnlReclamo.Location = New System.Drawing.Point(12, 33)
        Me.pnlReclamo.Name = "pnlReclamo"
        Me.pnlReclamo.Size = New System.Drawing.Size(586, 68)
        Me.pnlReclamo.TabIndex = 0
        '
        'cbFinalizar
        '
        Me.cbFinalizar.AutoCheck = False
        Me.cbFinalizar.AutoSize = True
        Me.cbFinalizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbFinalizar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbFinalizar.ForeColor = System.Drawing.Color.White
        Me.cbFinalizar.Location = New System.Drawing.Point(468, 36)
        Me.cbFinalizar.Name = "cbFinalizar"
        Me.cbFinalizar.Size = New System.Drawing.Size(109, 23)
        Me.cbFinalizar.TabIndex = 3
        Me.cbFinalizar.Text = "Finalizar"
        Me.cbFinalizar.UseVisualStyleBackColor = True
        '
        'cbxCategorias
        '
        Me.cbxCategorias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxCategorias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.Location = New System.Drawing.Point(156, 11)
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(213, 21)
        Me.cbxCategorias.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipo de Reclamo"
        '
        'dgvReclamo
        '
        Me.dgvReclamo.AllowUserToAddRows = False
        Me.dgvReclamo.AllowUserToDeleteRows = False
        Me.dgvReclamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReclamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReclamo.ColumnHeadersVisible = False
        Me.dgvReclamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechahora, Me.Comentario})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReclamo.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReclamo.Location = New System.Drawing.Point(7, 30)
        Me.dgvReclamo.Name = "dgvReclamo"
        Me.dgvReclamo.ReadOnly = True
        Me.dgvReclamo.Size = New System.Drawing.Size(570, 138)
        Me.dgvReclamo.TabIndex = 12
        '
        'fechahora
        '
        Me.fechahora.DataPropertyName = "fechahora"
        Me.fechahora.HeaderText = "Fecha"
        Me.fechahora.Name = "fechahora"
        Me.fechahora.ReadOnly = True
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "comentario"
        Me.Comentario.HeaderText = "Comentario"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.ReadOnly = True
        '
        'lblLineas
        '
        Me.lblLineas.AutoSize = True
        Me.lblLineas.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLineas.ForeColor = System.Drawing.Color.White
        Me.lblLineas.Location = New System.Drawing.Point(3, 9)
        Me.lblLineas.Name = "lblLineas"
        Me.lblLineas.Size = New System.Drawing.Size(81, 19)
        Me.lblLineas.TabIndex = 15
        Me.lblLineas.Text = "Detalles"
        '
        'pnlLineas
        '
        Me.pnlLineas.Controls.Add(Me.dgvReclamo)
        Me.pnlLineas.Controls.Add(Me.lblLineas)
        Me.pnlLineas.Location = New System.Drawing.Point(12, 255)
        Me.pnlLineas.Name = "pnlLineas"
        Me.pnlLineas.Size = New System.Drawing.Size(586, 189)
        Me.pnlLineas.TabIndex = 16
        '
        'pnlNuevo
        '
        Me.pnlNuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNuevo.Controls.Add(Me.btnCancela)
        Me.pnlNuevo.Controls.Add(Me.btnGuardar)
        Me.pnlNuevo.Controls.Add(Me.txtNuevo)
        Me.pnlNuevo.Controls.Add(Me.Label2)
        Me.pnlNuevo.Location = New System.Drawing.Point(12, 107)
        Me.pnlNuevo.Name = "pnlNuevo"
        Me.pnlNuevo.Size = New System.Drawing.Size(586, 142)
        Me.pnlNuevo.TabIndex = 17
        '
        'btnCancela
        '
        Me.btnCancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancela.ForeColor = System.Drawing.Color.Black
        Me.btnCancela.Location = New System.Drawing.Point(488, 99)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(89, 30)
        Me.btnCancela.TabIndex = 6
        Me.btnCancela.Text = "Cancelar"
        Me.btnCancela.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(393, 99)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 30)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtNuevo
        '
        Me.txtNuevo.AcceptsReturn = True
        Me.txtNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevo.Location = New System.Drawing.Point(7, 30)
        Me.txtNuevo.Multiline = True
        Me.txtNuevo.Name = "txtNuevo"
        Me.txtNuevo.Size = New System.Drawing.Size(570, 63)
        Me.txtNuevo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nuevo ingreso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Estado"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(173, 11)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 19)
        Me.lblEstado.TabIndex = 17
        '
        'ErrReclamos
        '
        Me.ErrReclamos.ContainerControl = Me
        '
        'FrmReclamos
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(615, 456)
        Me.Controls.Add(Me.pnlNuevo)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.pnlReclamo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlLineas)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmReclamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reclamos"
        Me.pnlReclamo.ResumeLayout(False)
        Me.pnlReclamo.PerformLayout()
        CType(Me.dgvReclamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLineas.ResumeLayout(False)
        Me.pnlLineas.PerformLayout()
        Me.pnlNuevo.ResumeLayout(False)
        Me.pnlNuevo.PerformLayout()
        CType(Me.ErrReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlReclamo As System.Windows.Forms.Panel
    Friend WithEvents cbxCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFinalizar As System.Windows.Forms.CheckBox
    Friend WithEvents dgvReclamo As System.Windows.Forms.DataGridView
    Friend WithEvents lblLineas As System.Windows.Forms.Label
    Friend WithEvents pnlLineas As System.Windows.Forms.Panel
    Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents fechahora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrReclamos As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancela As System.Windows.Forms.Button
End Class
