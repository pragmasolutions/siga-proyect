<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovil
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
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RdbNormal = New System.Windows.Forms.RadioButton()
        Me.CbxModelo = New System.Windows.Forms.ComboBox()
        Me.RdbGrande = New System.Windows.Forms.RadioButton()
        Me.CbxMarca = New System.Windows.Forms.ComboBox()
        Me.RdbChico = New System.Windows.Forms.RadioButton()
        Me.ChbHabilitado = New System.Windows.Forms.CheckBox()
        Me.DtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.DtpBaja = New System.Windows.Forms.DateTimePicker()
        Me.DtpSeguro = New System.Windows.Forms.DateTimePicker()
        Me.DtpHabilitacion = New System.Windows.Forms.DateTimePicker()
        Me.ChbAire = New System.Windows.Forms.CheckBox()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.TxtPatente = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.ErpMovil = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErpMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancela
        '
        Me.btnCancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancela.ForeColor = System.Drawing.Color.Black
        Me.btnCancela.Location = New System.Drawing.Point(370, 475)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(89, 30)
        Me.btnCancela.TabIndex = 18
        Me.btnCancela.Text = "Cancelar"
        Me.btnCancela.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(275, 475)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 30)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(94, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Numero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(108, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Baúl:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(87, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Patente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(94, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(108, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Aire:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(101, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Color:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(52, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Habilitación:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(101, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Marca:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(59, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Observación:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(108, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Baja:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(108, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Alta:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(94, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Seguro:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(66, 429)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Habilitado:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtTelefono)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.RdbNormal)
        Me.Panel1.Controls.Add(Me.CbxModelo)
        Me.Panel1.Controls.Add(Me.RdbGrande)
        Me.Panel1.Controls.Add(Me.CbxMarca)
        Me.Panel1.Controls.Add(Me.RdbChico)
        Me.Panel1.Controls.Add(Me.ChbHabilitado)
        Me.Panel1.Controls.Add(Me.DtpAlta)
        Me.Panel1.Controls.Add(Me.DtpBaja)
        Me.Panel1.Controls.Add(Me.DtpSeguro)
        Me.Panel1.Controls.Add(Me.DtpHabilitacion)
        Me.Panel1.Controls.Add(Me.ChbAire)
        Me.Panel1.Controls.Add(Me.TxtColor)
        Me.Panel1.Controls.Add(Me.TxtObservacion)
        Me.Panel1.Controls.Add(Me.TxtPatente)
        Me.Panel1.Controls.Add(Me.TxtNumero)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(7, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 458)
        Me.Panel1.TabIndex = 40
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(150, 398)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(286, 21)
        Me.TxtTelefono.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(10, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 15)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Celular línea baja:"
        '
        'RdbNormal
        '
        Me.RdbNormal.AutoSize = True
        Me.RdbNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.RdbNormal.Location = New System.Drawing.Point(338, 208)
        Me.RdbNormal.Name = "RdbNormal"
        Me.RdbNormal.Size = New System.Drawing.Size(58, 17)
        Me.RdbNormal.TabIndex = 9
        Me.RdbNormal.TabStop = True
        Me.RdbNormal.Text = "Normal"
        Me.RdbNormal.UseVisualStyleBackColor = True
        '
        'CbxModelo
        '
        Me.CbxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxModelo.FormattingEnabled = True
        Me.CbxModelo.Items.AddRange(New Object() {"Gol", "Uno", "Corsa"})
        Me.CbxModelo.Location = New System.Drawing.Point(150, 141)
        Me.CbxModelo.Name = "CbxModelo"
        Me.CbxModelo.Size = New System.Drawing.Size(286, 23)
        Me.CbxModelo.TabIndex = 5
        '
        'RdbGrande
        '
        Me.RdbGrande.AutoSize = True
        Me.RdbGrande.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.RdbGrande.Location = New System.Drawing.Point(242, 208)
        Me.RdbGrande.Name = "RdbGrande"
        Me.RdbGrande.Size = New System.Drawing.Size(60, 17)
        Me.RdbGrande.TabIndex = 8
        Me.RdbGrande.TabStop = True
        Me.RdbGrande.Text = "Grande"
        Me.RdbGrande.UseVisualStyleBackColor = True
        '
        'CbxMarca
        '
        Me.CbxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMarca.FormattingEnabled = True
        Me.CbxMarca.Items.AddRange(New Object() {"Fiat", "Volkswagen", "Ford"})
        Me.CbxMarca.Location = New System.Drawing.Point(150, 108)
        Me.CbxMarca.Name = "CbxMarca"
        Me.CbxMarca.Size = New System.Drawing.Size(286, 23)
        Me.CbxMarca.TabIndex = 4
        '
        'RdbChico
        '
        Me.RdbChico.AutoSize = True
        Me.RdbChico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.RdbChico.Location = New System.Drawing.Point(151, 208)
        Me.RdbChico.Name = "RdbChico"
        Me.RdbChico.Size = New System.Drawing.Size(52, 17)
        Me.RdbChico.TabIndex = 7
        Me.RdbChico.TabStop = True
        Me.RdbChico.Text = "Chico"
        Me.RdbChico.UseVisualStyleBackColor = True
        '
        'ChbHabilitado
        '
        Me.ChbHabilitado.AutoSize = True
        Me.ChbHabilitado.Location = New System.Drawing.Point(150, 428)
        Me.ChbHabilitado.Name = "ChbHabilitado"
        Me.ChbHabilitado.Size = New System.Drawing.Size(81, 17)
        Me.ChbHabilitado.TabIndex = 16
        Me.ChbHabilitado.Text = "CheckBox3"
        Me.ChbHabilitado.UseVisualStyleBackColor = True
        '
        'DtpAlta
        '
        Me.DtpAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAlta.Location = New System.Drawing.Point(150, 336)
        Me.DtpAlta.Name = "DtpAlta"
        Me.DtpAlta.Size = New System.Drawing.Size(286, 21)
        Me.DtpAlta.TabIndex = 13
        '
        'DtpBaja
        '
        Me.DtpBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpBaja.Location = New System.Drawing.Point(150, 369)
        Me.DtpBaja.Name = "DtpBaja"
        Me.DtpBaja.Size = New System.Drawing.Size(286, 21)
        Me.DtpBaja.TabIndex = 14
        '
        'DtpSeguro
        '
        Me.DtpSeguro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpSeguro.Location = New System.Drawing.Point(150, 270)
        Me.DtpSeguro.Name = "DtpSeguro"
        Me.DtpSeguro.Size = New System.Drawing.Size(286, 21)
        Me.DtpSeguro.TabIndex = 11
        '
        'DtpHabilitacion
        '
        Me.DtpHabilitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpHabilitacion.Location = New System.Drawing.Point(150, 237)
        Me.DtpHabilitacion.Name = "DtpHabilitacion"
        Me.DtpHabilitacion.Size = New System.Drawing.Size(286, 21)
        Me.DtpHabilitacion.TabIndex = 10
        '
        'ChbAire
        '
        Me.ChbAire.AutoSize = True
        Me.ChbAire.Location = New System.Drawing.Point(150, 177)
        Me.ChbAire.Name = "ChbAire"
        Me.ChbAire.Size = New System.Drawing.Size(81, 17)
        Me.ChbAire.TabIndex = 6
        Me.ChbAire.Text = "CheckBox1"
        Me.ChbAire.UseVisualStyleBackColor = True
        '
        'TxtColor
        '
        Me.TxtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(150, 42)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(286, 21)
        Me.TxtColor.TabIndex = 2
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(150, 306)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(286, 21)
        Me.TxtObservacion.TabIndex = 12
        '
        'TxtPatente
        '
        Me.TxtPatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatente.Location = New System.Drawing.Point(150, 75)
        Me.TxtPatente.Name = "TxtPatente"
        Me.TxtPatente.Size = New System.Drawing.Size(286, 21)
        Me.TxtPatente.TabIndex = 3
        '
        'TxtNumero
        '
        Me.TxtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(150, 9)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(286, 21)
        Me.TxtNumero.TabIndex = 1
        '
        'ErpMovil
        '
        Me.ErpMovil.ContainerControl = Me
        '
        'FrmMovil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(473, 514)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMovil"
        Me.Text = "Movil"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErpMovil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtColor As System.Windows.Forms.TextBox
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents ChbHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents DtpAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpSeguro As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpHabilitacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChbAire As System.Windows.Forms.CheckBox
    Friend WithEvents CbxModelo As System.Windows.Forms.ComboBox
    Friend WithEvents CbxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents RdbChico As System.Windows.Forms.RadioButton
    Friend WithEvents RdbGrande As System.Windows.Forms.RadioButton
    Friend WithEvents RdbNormal As System.Windows.Forms.RadioButton
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ErpMovil As System.Windows.Forms.ErrorProvider
End Class
