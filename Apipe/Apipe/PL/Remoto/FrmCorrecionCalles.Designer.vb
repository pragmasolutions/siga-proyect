<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorrecionCalles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCalles = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcalleOK = New System.Windows.Forms.TextBox()
        Me.btnGuardarNuevo = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la calle a corregir"
        '
        'cbxCalles
        '
        Me.cbxCalles.FormattingEnabled = True
        Me.cbxCalles.Location = New System.Drawing.Point(35, 88)
        Me.cbxCalles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxCalles.Name = "cbxCalles"
        Me.cbxCalles.Size = New System.Drawing.Size(279, 26)
        Me.cbxCalles.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(399, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese el nombre correcto de la calle"
        '
        'txtcalleOK
        '
        Me.txtcalleOK.Location = New System.Drawing.Point(432, 85)
        Me.txtcalleOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcalleOK.Name = "txtcalleOK"
        Me.txtcalleOK.Size = New System.Drawing.Size(279, 25)
        Me.txtcalleOK.TabIndex = 3
        '
        'btnGuardarNuevo
        '
        Me.btnGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnGuardarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNuevo.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarNuevo.Location = New System.Drawing.Point(767, 85)
        Me.btnGuardarNuevo.Name = "btnGuardarNuevo"
        Me.btnGuardarNuevo.Size = New System.Drawing.Size(197, 30)
        Me.btnGuardarNuevo.TabIndex = 5
        Me.btnGuardarNuevo.Text = "Corregir"
        Me.btnGuardarNuevo.UseVisualStyleBackColor = False
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(12, 9)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(272, 18)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Cantidad de Calles por corregir: "
        '
        'FrmCorrecionCalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1060, 533)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.btnGuardarNuevo)
        Me.Controls.Add(Me.txtcalleOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxCalles)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCorrecionCalles"
        Me.Text = "Correción de Calles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCalles As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcalleOK As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarNuevo As System.Windows.Forms.Button
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
End Class
