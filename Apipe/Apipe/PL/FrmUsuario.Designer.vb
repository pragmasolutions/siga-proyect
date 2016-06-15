<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
    Inherits FrmEntidad

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnSetearClave = New System.Windows.Forms.Button()
        Me.chkUsuarioActivo = New System.Windows.Forms.CheckBox()
        CType(Me.bgsTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgsEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAceptar.Location = New System.Drawing.Point(557, 497)
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(638, 497)
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(351, 22)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 13)
        Me.lblUsuario.TabIndex = 65
        Me.lblUsuario.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(416, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(477, 9)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(236, 21)
        Me.txtUsuario.TabIndex = 195
        '
        'btnSetearClave
        '
        Me.btnSetearClave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetearClave.Location = New System.Drawing.Point(477, 39)
        Me.btnSetearClave.Name = "btnSetearClave"
        Me.btnSetearClave.Size = New System.Drawing.Size(236, 23)
        Me.btnSetearClave.TabIndex = 196
        Me.btnSetearClave.Text = "Setear Clave por Defecto"
        Me.btnSetearClave.UseVisualStyleBackColor = True
        '
        'chkUsuarioActivo
        '
        Me.chkUsuarioActivo.AutoSize = True
        Me.chkUsuarioActivo.Checked = True
        Me.chkUsuarioActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUsuarioActivo.Location = New System.Drawing.Point(477, 67)
        Me.chkUsuarioActivo.Name = "chkUsuarioActivo"
        Me.chkUsuarioActivo.Size = New System.Drawing.Size(114, 17)
        Me.chkUsuarioActivo.TabIndex = 199
        Me.chkUsuarioActivo.Text = "Usuario Activo?"
        Me.chkUsuarioActivo.UseVisualStyleBackColor = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 523)
        Me.Controls.Add(Me.chkUsuarioActivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnSetearClave)
        Me.MaximumSize = New System.Drawing.Size(724, 557)
        Me.MinimumSize = New System.Drawing.Size(724, 557)
        Me.Name = "FrmUsuario"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(800, 600)
        Me.Controls.SetChildIndex(Me.btnSetearClave, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.chkUsuarioActivo, 0)
        CType(Me.bgsTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgsEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnSetearClave As System.Windows.Forms.Button
    Friend WithEvents chkUsuarioActivo As System.Windows.Forms.CheckBox

End Class
