<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDomicilio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDomicilio))
        Me.PnlDomicilio = New System.Windows.Forms.Panel()
        Me.cbxInterseccion = New System.Windows.Forms.ComboBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.CbxProvincia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbxLocalidad = New System.Windows.Forms.ComboBox()
        Me.CbxBarrio = New System.Windows.Forms.ComboBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxCalle = New System.Windows.Forms.ComboBox()
        Me.PnlDescripcion = New System.Windows.Forms.Panel()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtViviendas = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txthabitacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtOficina = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtLocal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.TxtCasa = New System.Windows.Forms.TextBox()
        Me.TxtMonoblock = New System.Windows.Forms.TextBox()
        Me.TxtPiso = New System.Windows.Forms.TextBox()
        Me.TxtSector = New System.Windows.Forms.TextBox()
        Me.TxtManzana = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnGuardarNuevo = New System.Windows.Forms.Button()
        Me.btnEdicion = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.PnlDomicilio.SuspendLayout()
        Me.PnlDescripcion.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlDomicilio
        '
        Me.PnlDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDomicilio.Controls.Add(Me.cbxInterseccion)
        Me.PnlDomicilio.Controls.Add(Me.cbxTipo)
        Me.PnlDomicilio.Controls.Add(Me.CbxProvincia)
        Me.PnlDomicilio.Controls.Add(Me.Label10)
        Me.PnlDomicilio.Controls.Add(Me.CbxLocalidad)
        Me.PnlDomicilio.Controls.Add(Me.CbxBarrio)
        Me.PnlDomicilio.Controls.Add(Me.TxtObservaciones)
        Me.PnlDomicilio.Controls.Add(Me.TxtDescripcion)
        Me.PnlDomicilio.Controls.Add(Me.TxtNumero)
        Me.PnlDomicilio.Controls.Add(Me.Label9)
        Me.PnlDomicilio.Controls.Add(Me.Label8)
        Me.PnlDomicilio.Controls.Add(Me.Label7)
        Me.PnlDomicilio.Controls.Add(Me.Label6)
        Me.PnlDomicilio.Controls.Add(Me.Label5)
        Me.PnlDomicilio.Controls.Add(Me.Label3)
        Me.PnlDomicilio.Controls.Add(Me.Label2)
        Me.PnlDomicilio.Controls.Add(Me.Label1)
        Me.PnlDomicilio.Controls.Add(Me.CbxCalle)
        Me.PnlDomicilio.Location = New System.Drawing.Point(12, 28)
        Me.PnlDomicilio.Name = "PnlDomicilio"
        Me.PnlDomicilio.Size = New System.Drawing.Size(464, 428)
        Me.PnlDomicilio.TabIndex = 1
        '
        'cbxInterseccion
        '
        Me.cbxInterseccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxInterseccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxInterseccion.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxInterseccion.FormattingEnabled = True
        Me.cbxInterseccion.Location = New System.Drawing.Point(136, 308)
        Me.cbxInterseccion.Name = "cbxInterseccion"
        Me.cbxInterseccion.Size = New System.Drawing.Size(294, 26)
        Me.cbxInterseccion.TabIndex = 19
        '
        'cbxTipo
        '
        Me.cbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxTipo.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Casa", "Departamento", "Hotel", "Local", "Oficina"})
        Me.cbxTipo.Location = New System.Drawing.Point(136, 209)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(294, 26)
        Me.cbxTipo.TabIndex = 6
        '
        'CbxProvincia
        '
        Me.CbxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxProvincia.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxProvincia.FormattingEnabled = True
        Me.CbxProvincia.Location = New System.Drawing.Point(136, 15)
        Me.CbxProvincia.Name = "CbxProvincia"
        Me.CbxProvincia.Size = New System.Drawing.Size(294, 26)
        Me.CbxProvincia.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(42, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Provincia:"
        '
        'CbxLocalidad
        '
        Me.CbxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxLocalidad.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxLocalidad.FormattingEnabled = True
        Me.CbxLocalidad.Location = New System.Drawing.Point(136, 54)
        Me.CbxLocalidad.Name = "CbxLocalidad"
        Me.CbxLocalidad.Size = New System.Drawing.Size(294, 26)
        Me.CbxLocalidad.TabIndex = 2
        '
        'CbxBarrio
        '
        Me.CbxBarrio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxBarrio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxBarrio.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxBarrio.FormattingEnabled = True
        Me.CbxBarrio.Location = New System.Drawing.Point(136, 93)
        Me.CbxBarrio.Name = "CbxBarrio"
        Me.CbxBarrio.Size = New System.Drawing.Size(294, 26)
        Me.CbxBarrio.TabIndex = 3
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(136, 346)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(294, 58)
        Me.TxtObservaciones.TabIndex = 9
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(136, 248)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(294, 47)
        Me.TxtDescripcion.TabIndex = 7
        '
        'TxtNumero
        '
        Me.TxtNumero.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(136, 171)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(294, 25)
        Me.TxtNumero.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(66, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Barrio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(42, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Localidad:"
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Observaciones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(77, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Intersección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(61, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calle:"
        '
        'CbxCalle
        '
        Me.CbxCalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxCalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxCalle.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCalle.FormattingEnabled = True
        Me.CbxCalle.Location = New System.Drawing.Point(136, 132)
        Me.CbxCalle.Name = "CbxCalle"
        Me.CbxCalle.Size = New System.Drawing.Size(294, 26)
        Me.CbxCalle.TabIndex = 4
        '
        'PnlDescripcion
        '
        Me.PnlDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDescripcion.Controls.Add(Me.txtGrupo)
        Me.PnlDescripcion.Controls.Add(Me.Label21)
        Me.PnlDescripcion.Controls.Add(Me.txtViviendas)
        Me.PnlDescripcion.Controls.Add(Me.Label20)
        Me.PnlDescripcion.Controls.Add(Me.Label18)
        Me.PnlDescripcion.Controls.Add(Me.txthabitacion)
        Me.PnlDescripcion.Controls.Add(Me.Label19)
        Me.PnlDescripcion.Controls.Add(Me.TxtOficina)
        Me.PnlDescripcion.Controls.Add(Me.Label17)
        Me.PnlDescripcion.Controls.Add(Me.TxtLocal)
        Me.PnlDescripcion.Controls.Add(Me.Label16)
        Me.PnlDescripcion.Controls.Add(Me.TxtDepartamento)
        Me.PnlDescripcion.Controls.Add(Me.TxtCasa)
        Me.PnlDescripcion.Controls.Add(Me.TxtMonoblock)
        Me.PnlDescripcion.Controls.Add(Me.TxtPiso)
        Me.PnlDescripcion.Controls.Add(Me.TxtSector)
        Me.PnlDescripcion.Controls.Add(Me.TxtManzana)
        Me.PnlDescripcion.Controls.Add(Me.Label15)
        Me.PnlDescripcion.Controls.Add(Me.Label14)
        Me.PnlDescripcion.Controls.Add(Me.Label13)
        Me.PnlDescripcion.Controls.Add(Me.Label12)
        Me.PnlDescripcion.Controls.Add(Me.Label11)
        Me.PnlDescripcion.Controls.Add(Me.Label4)
        Me.PnlDescripcion.Location = New System.Drawing.Point(494, 27)
        Me.PnlDescripcion.Name = "PnlDescripcion"
        Me.PnlDescripcion.Size = New System.Drawing.Size(289, 406)
        Me.PnlDescripcion.TabIndex = 2
        '
        'txtGrupo
        '
        Me.txtGrupo.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.txtGrupo.Location = New System.Drawing.Point(155, 205)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(100, 25)
        Me.txtGrupo.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(89, 208)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Grupo:"
        '
        'txtViviendas
        '
        Me.txtViviendas.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.txtViviendas.Location = New System.Drawing.Point(155, 99)
        Me.txtViviendas.Name = "txtViviendas"
        Me.txtViviendas.Size = New System.Drawing.Size(100, 25)
        Me.txtViviendas.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(57, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Viviendas:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 24)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Descripción"
        '
        'txthabitacion
        '
        Me.txthabitacion.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.txthabitacion.Location = New System.Drawing.Point(155, 379)
        Me.txthabitacion.Name = "txthabitacion"
        Me.txthabitacion.Size = New System.Drawing.Size(100, 25)
        Me.txthabitacion.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(52, 382)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Habitación:"
        '
        'TxtOficina
        '
        Me.TxtOficina.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtOficina.Location = New System.Drawing.Point(155, 344)
        Me.TxtOficina.Name = "TxtOficina"
        Me.TxtOficina.Size = New System.Drawing.Size(100, 25)
        Me.TxtOficina.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(76, 347)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Oficina:"
        '
        'TxtLocal
        '
        Me.TxtLocal.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtLocal.Location = New System.Drawing.Point(155, 309)
        Me.TxtLocal.Name = "TxtLocal"
        Me.TxtLocal.Size = New System.Drawing.Size(100, 25)
        Me.TxtLocal.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(92, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Local:"
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtDepartamento.Location = New System.Drawing.Point(155, 66)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(100, 25)
        Me.TxtDepartamento.TabIndex = 2
        '
        'TxtCasa
        '
        Me.TxtCasa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtCasa.Location = New System.Drawing.Point(155, 274)
        Me.TxtCasa.Name = "TxtCasa"
        Me.TxtCasa.Size = New System.Drawing.Size(100, 25)
        Me.TxtCasa.TabIndex = 8
        '
        'TxtMonoblock
        '
        Me.TxtMonoblock.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtMonoblock.Location = New System.Drawing.Point(155, 239)
        Me.TxtMonoblock.Name = "TxtMonoblock"
        Me.TxtMonoblock.Size = New System.Drawing.Size(100, 25)
        Me.TxtMonoblock.TabIndex = 7
        '
        'TxtPiso
        '
        Me.TxtPiso.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtPiso.Location = New System.Drawing.Point(155, 31)
        Me.TxtPiso.Name = "TxtPiso"
        Me.TxtPiso.Size = New System.Drawing.Size(100, 25)
        Me.TxtPiso.TabIndex = 1
        '
        'TxtSector
        '
        Me.TxtSector.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtSector.Location = New System.Drawing.Point(155, 169)
        Me.TxtSector.Name = "TxtSector"
        Me.TxtSector.Size = New System.Drawing.Size(100, 25)
        Me.TxtSector.TabIndex = 5
        '
        'TxtManzana
        '
        Me.TxtManzana.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TxtManzana.Location = New System.Drawing.Point(155, 134)
        Me.TxtManzana.Name = "TxtManzana"
        Me.TxtManzana.Size = New System.Drawing.Size(100, 25)
        Me.TxtManzana.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(36, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 18)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Departamento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(60, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Monoblock:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(100, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Casa:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(84, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sector:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(100, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Piso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(76, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Manzana:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnGuardarNuevo
        '
        Me.btnGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnGuardarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNuevo.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarNuevo.Location = New System.Drawing.Point(599, 455)
        Me.btnGuardarNuevo.Name = "btnGuardarNuevo"
        Me.btnGuardarNuevo.Size = New System.Drawing.Size(89, 30)
        Me.btnGuardarNuevo.TabIndex = 4
        Me.btnGuardarNuevo.Text = "Guardar"
        Me.btnGuardarNuevo.UseVisualStyleBackColor = False
        '
        'btnEdicion
        '
        Me.btnEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdicion.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdicion.ForeColor = System.Drawing.Color.Black
        Me.btnEdicion.Location = New System.Drawing.Point(540, 455)
        Me.btnEdicion.Name = "btnEdicion"
        Me.btnEdicion.Size = New System.Drawing.Size(148, 30)
        Me.btnEdicion.TabIndex = 3
        Me.btnEdicion.Text = "Guardar Edición"
        Me.btnEdicion.UseVisualStyleBackColor = False
        '
        'btnCancela
        '
        Me.btnCancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancela.ForeColor = System.Drawing.Color.Black
        Me.btnCancela.Location = New System.Drawing.Point(694, 455)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(89, 30)
        Me.btnCancela.TabIndex = 5
        Me.btnCancela.Text = "Cancelar"
        Me.btnCancela.UseVisualStyleBackColor = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Consolas", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(23, 10)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(160, 17)
        Me.lblTelefono.TabIndex = 0
        Me.lblTelefono.Text = "Número de Teléfono:"
        '
        'FrmDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(813, 507)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.btnGuardarNuevo)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.PnlDomicilio)
        Me.Controls.Add(Me.PnlDescripcion)
        Me.Controls.Add(Me.btnEdicion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDomicilio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Domicilio"
        Me.PnlDomicilio.ResumeLayout(False)
        Me.PnlDomicilio.PerformLayout()
        Me.PnlDescripcion.ResumeLayout(False)
        Me.PnlDescripcion.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlDomicilio As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbxCalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents CbxBarrio As System.Windows.Forms.ComboBox
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbxProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents PnlDescripcion As System.Windows.Forms.Panel
    Friend WithEvents TxtManzana As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMonoblock As System.Windows.Forms.TextBox
    Friend WithEvents TxtPiso As System.Windows.Forms.TextBox
    Friend WithEvents TxtSector As System.Windows.Forms.TextBox
    Friend WithEvents TxtDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents TxtCasa As System.Windows.Forms.TextBox
    Friend WithEvents TxtOficina As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEdicion As System.Windows.Forms.Button
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents txthabitacion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtViviendas As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents cbxInterseccion As System.Windows.Forms.ComboBox
End Class
