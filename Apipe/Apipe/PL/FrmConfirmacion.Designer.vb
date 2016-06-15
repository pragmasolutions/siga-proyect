<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmacion
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
        Me.lklConfirmar = New System.Windows.Forms.LinkLabel()
        Me.lklCancelar = New System.Windows.Forms.LinkLabel()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lklConfirmar
        '
        Me.lklConfirmar.AutoSize = True
        Me.lklConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.lklConfirmar.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklConfirmar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lklConfirmar.Location = New System.Drawing.Point(63, 51)
        Me.lklConfirmar.Name = "lklConfirmar"
        Me.lklConfirmar.Size = New System.Drawing.Size(80, 18)
        Me.lklConfirmar.TabIndex = 1
        Me.lklConfirmar.TabStop = True
        Me.lklConfirmar.Text = "Confirmar"
        '
        'lklCancelar
        '
        Me.lklCancelar.AutoSize = True
        Me.lklCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.lklCancelar.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancelar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lklCancelar.Location = New System.Drawing.Point(163, 51)
        Me.lklCancelar.Name = "lklCancelar"
        Me.lklCancelar.Size = New System.Drawing.Size(72, 18)
        Me.lklCancelar.TabIndex = 0
        Me.lklCancelar.TabStop = True
        Me.lklCancelar.Text = "Cancelar"
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Black
        Me.lblMensaje.Location = New System.Drawing.Point(12, 9)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(275, 42)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Mensaje"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmConfirmacion
        '
        Me.AcceptButton = Me.lklConfirmar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(299, 76)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lklCancelar)
        Me.Controls.Add(Me.lklConfirmar)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmConfirmacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Confirmacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lklConfirmar As System.Windows.Forms.LinkLabel
    Friend WithEvents lklCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
