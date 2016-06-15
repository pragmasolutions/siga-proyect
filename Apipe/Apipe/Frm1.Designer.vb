<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxAccesos = New System.Windows.Forms.GroupBox()
        Me.BtnPedidos = New System.Windows.Forms.Button()
        Me.BtnBuscarMovil = New System.Windows.Forms.Button()
        Me.btnTraspasoPedidos = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnAdministrarPedidos = New System.Windows.Forms.Button()
        Me.BtnMdi = New System.Windows.Forms.Button()
        Me.BtnDgvCliente = New System.Windows.Forms.Button()
        Me.BtnDomicilios = New System.Windows.Forms.Button()
        Me.BtnIax = New System.Windows.Forms.Button()
        Me.BtnInfoCliente = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.gbxAccesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Conectar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbxAccesos
        '
        Me.gbxAccesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxAccesos.Controls.Add(Me.Button7)
        Me.gbxAccesos.Controls.Add(Me.BtnPedidos)
        Me.gbxAccesos.Controls.Add(Me.BtnBuscarMovil)
        Me.gbxAccesos.Controls.Add(Me.btnTraspasoPedidos)
        Me.gbxAccesos.Controls.Add(Me.Button6)
        Me.gbxAccesos.Controls.Add(Me.Button5)
        Me.gbxAccesos.Controls.Add(Me.btnAdministrarPedidos)
        Me.gbxAccesos.Controls.Add(Me.BtnMdi)
        Me.gbxAccesos.Controls.Add(Me.BtnDgvCliente)
        Me.gbxAccesos.Controls.Add(Me.BtnDomicilios)
        Me.gbxAccesos.Controls.Add(Me.BtnIax)
        Me.gbxAccesos.Controls.Add(Me.BtnInfoCliente)
        Me.gbxAccesos.Controls.Add(Me.Button4)
        Me.gbxAccesos.Controls.Add(Me.Button3)
        Me.gbxAccesos.Controls.Add(Me.Button2)
        Me.gbxAccesos.Enabled = False
        Me.gbxAccesos.Location = New System.Drawing.Point(13, 77)
        Me.gbxAccesos.Name = "gbxAccesos"
        Me.gbxAccesos.Size = New System.Drawing.Size(325, 320)
        Me.gbxAccesos.TabIndex = 1
        Me.gbxAccesos.TabStop = False
        Me.gbxAccesos.Text = "Accesos"
        '
        'BtnPedidos
        '
        Me.BtnPedidos.Location = New System.Drawing.Point(178, 209)
        Me.BtnPedidos.Name = "BtnPedidos"
        Me.BtnPedidos.Size = New System.Drawing.Size(75, 23)
        Me.BtnPedidos.TabIndex = 2
        Me.BtnPedidos.Text = "Pedidos"
        Me.BtnPedidos.UseVisualStyleBackColor = True
        '
        'BtnBuscarMovil
        '
        Me.BtnBuscarMovil.Location = New System.Drawing.Point(178, 87)
        Me.BtnBuscarMovil.Name = "BtnBuscarMovil"
        Me.BtnBuscarMovil.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarMovil.TabIndex = 21
        Me.BtnBuscarMovil.Text = "BuscMovil"
        Me.BtnBuscarMovil.UseVisualStyleBackColor = True
        '
        'btnTraspasoPedidos
        '
        Me.btnTraspasoPedidos.Location = New System.Drawing.Point(178, 154)
        Me.btnTraspasoPedidos.Name = "btnTraspasoPedidos"
        Me.btnTraspasoPedidos.Size = New System.Drawing.Size(75, 49)
        Me.btnTraspasoPedidos.TabIndex = 20
        Me.btnTraspasoPedidos.Text = "Traspaso de Pedidos"
        Me.btnTraspasoPedidos.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(97, 154)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 49)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Reclamo Categorías"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 49)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Pedido Categorías"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnAdministrarPedidos
        '
        Me.btnAdministrarPedidos.Location = New System.Drawing.Point(178, 21)
        Me.btnAdministrarPedidos.Name = "btnAdministrarPedidos"
        Me.btnAdministrarPedidos.Size = New System.Drawing.Size(75, 43)
        Me.btnAdministrarPedidos.TabIndex = 18
        Me.btnAdministrarPedidos.Text = "Administrar Pedidos"
        Me.btnAdministrarPedidos.UseVisualStyleBackColor = True
        '
        'BtnMdi
        '
        Me.BtnMdi.Location = New System.Drawing.Point(16, 116)
        Me.BtnMdi.Name = "BtnMdi"
        Me.BtnMdi.Size = New System.Drawing.Size(75, 23)
        Me.BtnMdi.TabIndex = 17
        Me.BtnMdi.Text = "MDI"
        Me.BtnMdi.UseVisualStyleBackColor = True
        '
        'BtnDgvCliente
        '
        Me.BtnDgvCliente.Location = New System.Drawing.Point(178, 116)
        Me.BtnDgvCliente.Name = "BtnDgvCliente"
        Me.BtnDgvCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnDgvCliente.TabIndex = 16
        Me.BtnDgvCliente.Text = "DGV Cli"
        Me.BtnDgvCliente.UseVisualStyleBackColor = True
        '
        'BtnDomicilios
        '
        Me.BtnDomicilios.Location = New System.Drawing.Point(97, 116)
        Me.BtnDomicilios.Name = "BtnDomicilios"
        Me.BtnDomicilios.Size = New System.Drawing.Size(75, 23)
        Me.BtnDomicilios.TabIndex = 15
        Me.BtnDomicilios.Text = "Mensajero"
        Me.BtnDomicilios.UseVisualStyleBackColor = True
        '
        'BtnIax
        '
        Me.BtnIax.Location = New System.Drawing.Point(178, 70)
        Me.BtnIax.Name = "BtnIax"
        Me.BtnIax.Size = New System.Drawing.Size(75, 23)
        Me.BtnIax.TabIndex = 14
        Me.BtnIax.Text = "Movil"
        Me.BtnIax.UseVisualStyleBackColor = True
        '
        'BtnInfoCliente
        '
        Me.BtnInfoCliente.Location = New System.Drawing.Point(16, 70)
        Me.BtnInfoCliente.Name = "BtnInfoCliente"
        Me.BtnInfoCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnInfoCliente.TabIndex = 13
        Me.BtnInfoCliente.Text = "Info Cliente"
        Me.BtnInfoCliente.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Provincia"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(97, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Buscar Clientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Barrio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(97, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "FrmZonas"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 409)
        Me.Controls.Add(Me.gbxAccesos)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm1"
        Me.Text = "Frm1"
        Me.gbxAccesos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbxAccesos As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdministrarPedidos As System.Windows.Forms.Button
    Friend WithEvents BtnMdi As System.Windows.Forms.Button
    Friend WithEvents BtnDgvCliente As System.Windows.Forms.Button
    Friend WithEvents BtnDomicilios As System.Windows.Forms.Button
    Friend WithEvents BtnIax As System.Windows.Forms.Button
    Friend WithEvents BtnInfoCliente As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnTraspasoPedidos As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarMovil As System.Windows.Forms.Button
    Friend WithEvents BtnPedidos As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
