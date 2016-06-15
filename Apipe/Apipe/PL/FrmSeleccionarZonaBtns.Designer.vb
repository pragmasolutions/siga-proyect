<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarZonabtns
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
        Me.lklCancelar = New System.Windows.Forms.LinkLabel()
        Me.lklConfirmar = New System.Windows.Forms.LinkLabel()
        Me.cbxZona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.BtnSinBase = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.BtnBase = New System.Windows.Forms.Button()
        Me.BtnTerminal = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn10 = New System.Windows.Forms.Button()
        Me.LblBase = New System.Windows.Forms.Label()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lklCancelar
        '
        Me.lklCancelar.AutoSize = True
        Me.lklCancelar.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancelar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lklCancelar.Location = New System.Drawing.Point(168, 169)
        Me.lklCancelar.Name = "lklCancelar"
        Me.lklCancelar.Size = New System.Drawing.Size(72, 18)
        Me.lklCancelar.TabIndex = 2
        Me.lklCancelar.TabStop = True
        Me.lklCancelar.Text = "Cancelar"
        '
        'lklConfirmar
        '
        Me.lklConfirmar.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklConfirmar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lklConfirmar.Location = New System.Drawing.Point(75, 169)
        Me.lklConfirmar.Name = "lklConfirmar"
        Me.lklConfirmar.Size = New System.Drawing.Size(87, 18)
        Me.lklConfirmar.TabIndex = 1
        Me.lklConfirmar.TabStop = True
        Me.lklConfirmar.Text = "Aceptar"
        Me.lklConfirmar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbxZona
        '
        Me.cbxZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxZona.FormattingEnabled = True
        Me.cbxZona.Location = New System.Drawing.Point(125, 18)
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Size = New System.Drawing.Size(212, 22)
        Me.cbxZona.TabIndex = 3
        Me.cbxZona.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base:"
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.Black
        Me.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn1.Location = New System.Drawing.Point(53, 3)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(37, 37)
        Me.Btn1.TabIndex = 30
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.Black
        Me.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn2.Location = New System.Drawing.Point(89, 3)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(37, 37)
        Me.Btn2.TabIndex = 31
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.Black
        Me.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn4.Location = New System.Drawing.Point(162, 3)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(37, 37)
        Me.Btn4.TabIndex = 32
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.Black
        Me.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn3.Location = New System.Drawing.Point(125, 3)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(37, 37)
        Me.Btn3.TabIndex = 33
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.Black
        Me.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn6.Location = New System.Drawing.Point(235, 3)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(37, 37)
        Me.Btn6.TabIndex = 34
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.Black
        Me.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn5.Location = New System.Drawing.Point(199, 3)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(37, 37)
        Me.Btn5.TabIndex = 35
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'PnlBotones
        '
        Me.PnlBotones.Controls.Add(Me.BtnSinBase)
        Me.PnlBotones.Controls.Add(Me.Btn7)
        Me.PnlBotones.Controls.Add(Me.BtnBase)
        Me.PnlBotones.Controls.Add(Me.BtnTerminal)
        Me.PnlBotones.Controls.Add(Me.Btn8)
        Me.PnlBotones.Controls.Add(Me.Btn9)
        Me.PnlBotones.Controls.Add(Me.Btn10)
        Me.PnlBotones.Controls.Add(Me.Btn1)
        Me.PnlBotones.Controls.Add(Me.Btn6)
        Me.PnlBotones.Controls.Add(Me.Btn5)
        Me.PnlBotones.Controls.Add(Me.Btn2)
        Me.PnlBotones.Controls.Add(Me.Btn3)
        Me.PnlBotones.Controls.Add(Me.Btn4)
        Me.PnlBotones.Location = New System.Drawing.Point(18, 64)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(274, 80)
        Me.PnlBotones.TabIndex = 36
        '
        'BtnSinBase
        '
        Me.BtnSinBase.BackColor = System.Drawing.Color.Black
        Me.BtnSinBase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnSinBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSinBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSinBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSinBase.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSinBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnSinBase.Location = New System.Drawing.Point(3, 3)
        Me.BtnSinBase.Name = "BtnSinBase"
        Me.BtnSinBase.Size = New System.Drawing.Size(49, 75)
        Me.BtnSinBase.TabIndex = 42
        Me.BtnSinBase.Text = "S/B"
        Me.BtnSinBase.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.Color.Black
        Me.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn7.Location = New System.Drawing.Point(53, 41)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(37, 37)
        Me.Btn7.TabIndex = 36
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'BtnBase
        '
        Me.BtnBase.BackColor = System.Drawing.Color.Black
        Me.BtnBase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBase.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnBase.Location = New System.Drawing.Point(199, 41)
        Me.BtnBase.Name = "BtnBase"
        Me.BtnBase.Size = New System.Drawing.Size(37, 37)
        Me.BtnBase.TabIndex = 40
        Me.BtnBase.Text = "Base"
        Me.BtnBase.UseVisualStyleBackColor = False
        '
        'BtnTerminal
        '
        Me.BtnTerminal.BackColor = System.Drawing.Color.Black
        Me.BtnTerminal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTerminal.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTerminal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BtnTerminal.Location = New System.Drawing.Point(235, 41)
        Me.BtnTerminal.Name = "BtnTerminal"
        Me.BtnTerminal.Size = New System.Drawing.Size(37, 37)
        Me.BtnTerminal.TabIndex = 41
        Me.BtnTerminal.Text = "Terminal"
        Me.BtnTerminal.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.Color.Black
        Me.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn8.Location = New System.Drawing.Point(89, 41)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(37, 37)
        Me.Btn8.TabIndex = 37
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.Color.Black
        Me.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn9.Location = New System.Drawing.Point(125, 41)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(37, 37)
        Me.Btn9.TabIndex = 39
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn10
        '
        Me.Btn10.BackColor = System.Drawing.Color.Black
        Me.Btn10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn10.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn10.Location = New System.Drawing.Point(162, 41)
        Me.Btn10.Name = "Btn10"
        Me.Btn10.Size = New System.Drawing.Size(37, 37)
        Me.Btn10.TabIndex = 38
        Me.Btn10.Text = "10"
        Me.Btn10.UseVisualStyleBackColor = False
        '
        'LblBase
        '
        Me.LblBase.AutoSize = True
        Me.LblBase.Location = New System.Drawing.Point(66, 21)
        Me.LblBase.Name = "LblBase"
        Me.LblBase.Size = New System.Drawing.Size(49, 14)
        Me.LblBase.TabIndex = 37
        Me.LblBase.Text = "Label2"
        '
        'FrmSeleccionarZonabtns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 203)
        Me.Controls.Add(Me.LblBase)
        Me.Controls.Add(Me.PnlBotones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxZona)
        Me.Controls.Add(Me.lklCancelar)
        Me.Controls.Add(Me.lklConfirmar)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSeleccionarZonabtns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmSeleccionarZona"
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lklCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lklConfirmar As System.Windows.Forms.LinkLabel
    Friend WithEvents cbxZona As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents PnlBotones As System.Windows.Forms.Panel
    Friend WithEvents BtnSinBase As System.Windows.Forms.Button
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents BtnBase As System.Windows.Forms.Button
    Friend WithEvents BtnTerminal As System.Windows.Forms.Button
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Btn10 As System.Windows.Forms.Button
    Friend WithEvents LblBase As System.Windows.Forms.Label
End Class
