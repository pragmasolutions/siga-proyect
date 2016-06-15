<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraspasoPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraspasoPedidos))
        Me.txtMensaje = New System.Windows.Forms.RichTextBox()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.spcTodo = New System.Windows.Forms.SplitContainer()
        Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
        Me.txtACompletar = New System.Windows.Forms.RichTextBox()
        Me.dgvACompletar = New System.Windows.Forms.DataGridView()
        Me.colACompCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colACompReclamo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colACompAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colACompCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtOperadores = New System.Windows.Forms.RichTextBox()
        Me.btnTraspasar = New System.Windows.Forms.Button()
        Me.dgvOperadores = New System.Windows.Forms.DataGridView()
        Me.colOpeAyN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpeCantPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTodo.Panel1.SuspendLayout()
        Me.spcTodo.Panel2.SuspendLayout()
        Me.spcTodo.SuspendLayout()
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.White
        Me.txtMensaje.Location = New System.Drawing.Point(8, 22)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.Size = New System.Drawing.Size(800, 22)
        Me.txtMensaje.TabIndex = 8
        Me.txtMensaje.Text = "TRASPASAR 15 PEDIDOS AL OPERADOR PEREYRA, JOSÉ"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.txtMensaje)
        Me.gbxDetalle.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 8)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(814, 56)
        Me.gbxDetalle.TabIndex = 10
        Me.gbxDetalle.TabStop = False
        '
        'spcTodo
        '
        Me.spcTodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcTodo.Location = New System.Drawing.Point(13, 71)
        Me.spcTodo.Name = "spcTodo"
        '
        'spcTodo.Panel1
        '
        Me.spcTodo.Panel1.Controls.Add(Me.txtACompletar)
        Me.spcTodo.Panel1.Controls.Add(Me.dgvACompletar)
        Me.spcTodo.Panel1.Controls.Add(Me.chkSeleccionarTodos)
        '
        'spcTodo.Panel2
        '
        Me.spcTodo.Panel2.Controls.Add(Me.txtOperadores)
        Me.spcTodo.Panel2.Controls.Add(Me.btnTraspasar)
        Me.spcTodo.Panel2.Controls.Add(Me.dgvOperadores)
        Me.spcTodo.Size = New System.Drawing.Size(813, 524)
        Me.spcTodo.SplitterDistance = 482
        Me.spcTodo.TabIndex = 11
        '
        'chkSeleccionarTodos
        '
        Me.chkSeleccionarTodos.AutoSize = True
        Me.chkSeleccionarTodos.Location = New System.Drawing.Point(7, 24)
        Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
        Me.chkSeleccionarTodos.Size = New System.Drawing.Size(145, 18)
        Me.chkSeleccionarTodos.TabIndex = 15
        Me.chkSeleccionarTodos.Text = "Seleccionar Todos"
        Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'txtACompletar
        '
        Me.txtACompletar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtACompletar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtACompletar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtACompletar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACompletar.ForeColor = System.Drawing.Color.White
        Me.txtACompletar.Location = New System.Drawing.Point(0, 0)
        Me.txtACompletar.Name = "txtACompletar"
        Me.txtACompletar.ReadOnly = True
        Me.txtACompletar.Size = New System.Drawing.Size(479, 22)
        Me.txtACompletar.TabIndex = 14
        Me.txtACompletar.Text = "PEDIDOS DEL OPERADOR"
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
        Me.dgvACompletar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colACompCheck, Me.colACompReclamo, Me.colACompAsignado, Me.colACompMovil, Me.colACompDomicilio, Me.colACompCliente})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvACompletar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvACompletar.Location = New System.Drawing.Point(0, 41)
        Me.dgvACompletar.MultiSelect = False
        Me.dgvACompletar.Name = "dgvACompletar"
        Me.dgvACompletar.ReadOnly = True
        Me.dgvACompletar.RowHeadersVisible = False
        Me.dgvACompletar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvACompletar.Size = New System.Drawing.Size(479, 480)
        Me.dgvACompletar.TabIndex = 11
        '
        'colACompCheck
        '
        Me.colACompCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colACompCheck.HeaderText = ""
        Me.colACompCheck.Name = "colACompCheck"
        Me.colACompCheck.ReadOnly = True
        Me.colACompCheck.Width = 25
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
        'txtOperadores
        '
        Me.txtOperadores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOperadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtOperadores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperadores.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperadores.ForeColor = System.Drawing.Color.White
        Me.txtOperadores.Location = New System.Drawing.Point(47, 0)
        Me.txtOperadores.Name = "txtOperadores"
        Me.txtOperadores.ReadOnly = True
        Me.txtOperadores.Size = New System.Drawing.Size(274, 22)
        Me.txtOperadores.TabIndex = 16
        Me.txtOperadores.Text = "OPERADORES"
        '
        'btnTraspasar
        '
        Me.btnTraspasar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTraspasar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTraspasar.Location = New System.Drawing.Point(3, 92)
        Me.btnTraspasar.Name = "btnTraspasar"
        Me.btnTraspasar.Size = New System.Drawing.Size(38, 35)
        Me.btnTraspasar.TabIndex = 15
        Me.btnTraspasar.Text = ">"
        Me.btnTraspasar.UseVisualStyleBackColor = True
        '
        'dgvOperadores
        '
        Me.dgvOperadores.AllowUserToAddRows = False
        Me.dgvOperadores.AllowUserToDeleteRows = False
        Me.dgvOperadores.AllowUserToResizeRows = False
        Me.dgvOperadores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOperadores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOpeAyN, Me.colOpeCantPed})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperadores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOperadores.Location = New System.Drawing.Point(47, 41)
        Me.dgvOperadores.MultiSelect = False
        Me.dgvOperadores.Name = "dgvOperadores"
        Me.dgvOperadores.ReadOnly = True
        Me.dgvOperadores.RowHeadersVisible = False
        Me.dgvOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOperadores.Size = New System.Drawing.Size(274, 480)
        Me.dgvOperadores.TabIndex = 14
        '
        'colOpeAyN
        '
        Me.colOpeAyN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colOpeAyN.DataPropertyName = "v_AyN"
        Me.colOpeAyN.HeaderText = "Operador"
        Me.colOpeAyN.Name = "colOpeAyN"
        Me.colOpeAyN.ReadOnly = True
        Me.colOpeAyN.Width = 160
        '
        'colOpeCantPed
        '
        Me.colOpeCantPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colOpeCantPed.DataPropertyName = "v_CantACompletar"
        Me.colOpeCantPed.HeaderText = "Asignados"
        Me.colOpeCantPed.Name = "colOpeCantPed"
        Me.colOpeCantPed.ReadOnly = True
        Me.colOpeCantPed.Width = 95
        '
        'FrmTraspasoPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(838, 607)
        Me.Controls.Add(Me.spcTodo)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmTraspasoPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspaso de Pedidos"
        Me.gbxDetalle.ResumeLayout(False)
        Me.spcTodo.Panel1.ResumeLayout(False)
        Me.spcTodo.Panel1.PerformLayout()
        Me.spcTodo.Panel2.ResumeLayout(False)
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTodo.ResumeLayout(False)
        CType(Me.dgvACompletar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents spcTodo As System.Windows.Forms.SplitContainer
    Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtACompletar As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvACompletar As System.Windows.Forms.DataGridView
    Friend WithEvents colACompCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colACompReclamo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colACompAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACompCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtOperadores As System.Windows.Forms.RichTextBox
    Friend WithEvents btnTraspasar As System.Windows.Forms.Button
    Friend WithEvents dgvOperadores As System.Windows.Forms.DataGridView
    Friend WithEvents colOpeAyN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpeCantPed As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
