<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxProbarApipe1 = New System.Windows.Forms.ComboBox()
        Me.ProbarTextBox1 = New System.Windows.Forms.TextBox()
        Me.TESTButton1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AceptButton1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 164)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.cbxProbarApipe1)
        Me.GroupBox1.Controls.Add(Me.ProbarTextBox1)
        Me.GroupBox1.Controls.Add(Me.TESTButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 89)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IP Servidor"
        '
        'cbxProbarApipe1
        '
        Me.cbxProbarApipe1.FormattingEnabled = True
        Me.cbxProbarApipe1.Items.AddRange(New Object() {"190.228.83.52", "190.183.224.37"})
        Me.cbxProbarApipe1.Location = New System.Drawing.Point(6, 49)
        Me.cbxProbarApipe1.Name = "cbxProbarApipe1"
        Me.cbxProbarApipe1.Size = New System.Drawing.Size(294, 22)
        Me.cbxProbarApipe1.TabIndex = 1
        '
        'ProbarTextBox1
        '
        Me.ProbarTextBox1.Location = New System.Drawing.Point(6, 21)
        Me.ProbarTextBox1.Name = "ProbarTextBox1"
        Me.ProbarTextBox1.Size = New System.Drawing.Size(294, 22)
        Me.ProbarTextBox1.TabIndex = 7
        Me.ProbarTextBox1.Visible = False
        '
        'TESTButton1
        '
        Me.TESTButton1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TESTButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TESTButton1.ForeColor = System.Drawing.Color.White
        Me.TESTButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TESTButton1.Location = New System.Drawing.Point(306, 48)
        Me.TESTButton1.Name = "TESTButton1"
        Me.TESTButton1.Size = New System.Drawing.Size(50, 23)
        Me.TESTButton1.TabIndex = 8
        Me.TESTButton1.Text = "TEST"
        Me.TESTButton1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(366, 43)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Este cuadro lo guiara para establecer la configuración inicial de la aplicación, " & _
    "luego la aplicación correrá normalmente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AceptButton1
        '
        Me.AceptButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptButton1.Enabled = False
        Me.AceptButton1.Image = CType(resources.GetObject("AceptButton1.Image"), System.Drawing.Image)
        Me.AceptButton1.Location = New System.Drawing.Point(292, 189)
        Me.AceptButton1.Name = "AceptButton1"
        Me.AceptButton1.Size = New System.Drawing.Size(103, 23)
        Me.AceptButton1.TabIndex = 0
        Me.AceptButton1.Text = "Aceptar"
        Me.AceptButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AceptButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(-1, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Solicitar Asistencia Online"
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(394, 212)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AceptButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(410, 250)
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de la Base de Datos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AceptButton1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TESTButton1 As System.Windows.Forms.Button
    Friend WithEvents ProbarTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxProbarApipe1 As System.Windows.Forms.ComboBox
End Class
