<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarZona
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
        Me.SuspendLayout()
        '
        'lklCancelar
        '
        Me.lklCancelar.AutoSize = True
        Me.lklCancelar.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancelar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lklCancelar.Location = New System.Drawing.Point(176, 49)
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
        Me.lklConfirmar.Location = New System.Drawing.Point(83, 49)
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
        Me.cbxZona.Location = New System.Drawing.Point(63, 21)
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Size = New System.Drawing.Size(212, 22)
        Me.cbxZona.TabIndex = 3
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
        'FrmSeleccionarZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(303, 76)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxZona)
        Me.Controls.Add(Me.lklCancelar)
        Me.Controls.Add(Me.lklConfirmar)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSeleccionarZona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmSeleccionarZona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lklCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lklConfirmar As System.Windows.Forms.LinkLabel
    Friend WithEvents cbxZona As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
