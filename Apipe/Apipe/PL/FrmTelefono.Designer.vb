<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelefono
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpHorarioTardeH = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpHorarioTardeD = New System.Windows.Forms.DateTimePicker()
        Me.dtpHorarioMananaH = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpHorarioMananaD = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodArea = New System.Windows.Forms.TextBox()
        Me.CbxTipo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.BtoCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpHorarioTardeH)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dtpHorarioTardeD)
        Me.GroupBox1.Controls.Add(Me.dtpHorarioMananaH)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpHorarioMananaD)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCodArea)
        Me.GroupBox1.Controls.Add(Me.CbxTipo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 211)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teléfonos"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObservaciones.Location = New System.Drawing.Point(99, 139)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(227, 57)
        Me.txtObservaciones.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Observaciones:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(217, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "a"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(217, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "a"
        '
        'dtpHorarioTardeH
        '
        Me.dtpHorarioTardeH.CustomFormat = "HH:mm"
        Me.dtpHorarioTardeH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpHorarioTardeH.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHorarioTardeH.Location = New System.Drawing.Point(239, 107)
        Me.dtpHorarioTardeH.Name = "dtpHorarioTardeH"
        Me.dtpHorarioTardeH.Size = New System.Drawing.Size(87, 20)
        Me.dtpHorarioTardeH.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Horario de Tarde:"
        '
        'dtpHorarioTardeD
        '
        Me.dtpHorarioTardeD.CustomFormat = "HH:mm"
        Me.dtpHorarioTardeD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpHorarioTardeD.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHorarioTardeD.Location = New System.Drawing.Point(127, 107)
        Me.dtpHorarioTardeD.Name = "dtpHorarioTardeD"
        Me.dtpHorarioTardeD.Size = New System.Drawing.Size(84, 20)
        Me.dtpHorarioTardeD.TabIndex = 25
        '
        'dtpHorarioMananaH
        '
        Me.dtpHorarioMananaH.CustomFormat = "HH:mm"
        Me.dtpHorarioMananaH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpHorarioMananaH.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHorarioMananaH.Location = New System.Drawing.Point(239, 79)
        Me.dtpHorarioMananaH.Name = "dtpHorarioMananaH"
        Me.dtpHorarioMananaH.Size = New System.Drawing.Size(87, 20)
        Me.dtpHorarioMananaH.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Horario de Mañana:"
        '
        'dtpHorarioMananaD
        '
        Me.dtpHorarioMananaD.CustomFormat = "HH:mm"
        Me.dtpHorarioMananaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpHorarioMananaD.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHorarioMananaD.Location = New System.Drawing.Point(127, 79)
        Me.dtpHorarioMananaD.Name = "dtpHorarioMananaD"
        Me.dtpHorarioMananaD.Size = New System.Drawing.Size(84, 20)
        Me.dtpHorarioMananaD.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(193, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Número:"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNumero.Location = New System.Drawing.Point(196, 38)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(130, 20)
        Me.txtNumero.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(124, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Cód. Área:"
        '
        'txtCodArea
        '
        Me.txtCodArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodArea.Location = New System.Drawing.Point(127, 37)
        Me.txtCodArea.Name = "txtCodArea"
        Me.txtCodArea.Size = New System.Drawing.Size(60, 20)
        Me.txtCodArea.TabIndex = 6
        '
        'CbxTipo
        '
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CbxTipo.FormattingEnabled = True
        Me.CbxTipo.Items.AddRange(New Object() {"PARTICULAR", "CELULAR", "TRABAJO", "OTRO"})
        Me.CbxTipo.Location = New System.Drawing.Point(6, 37)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(115, 21)
        Me.CbxTipo.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(187, 223)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'BtoCancelar
        '
        Me.BtoCancelar.Location = New System.Drawing.Point(268, 223)
        Me.BtoCancelar.Name = "BtoCancelar"
        Me.BtoCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtoCancelar.TabIndex = 21
        Me.BtoCancelar.Text = "&Cancelar"
        Me.BtoCancelar.UseVisualStyleBackColor = True
        '
        'FrmTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(346, 248)
        Me.Controls.Add(Me.BtoCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(346, 248)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(346, 248)
        Me.Name = "FrmTelefono"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(346, 248)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Telefono"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpHorarioTardeH As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpHorarioTardeD As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHorarioMananaH As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpHorarioMananaD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCodArea As System.Windows.Forms.TextBox
    Friend WithEvents CbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtoCancelar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
