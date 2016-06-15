<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmForms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmForms))
        Me.cbxRoles = New System.Windows.Forms.ComboBox()
        Me.lbxFormularios = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsbFormulariosAsignados = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarRol = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxRoles
        '
        Me.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRoles.Location = New System.Drawing.Point(24, 33)
        Me.cbxRoles.Name = "cbxRoles"
        Me.cbxRoles.Size = New System.Drawing.Size(220, 21)
        Me.cbxRoles.TabIndex = 1
        '
        'lbxFormularios
        '
        Me.lbxFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbxFormularios.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxFormularios.ForeColor = System.Drawing.Color.White
        Me.lbxFormularios.FormattingEnabled = True
        Me.lbxFormularios.ItemHeight = 14
        Me.lbxFormularios.Location = New System.Drawing.Point(24, 85)
        Me.lbxFormularios.Name = "lbxFormularios"
        Me.lbxFormularios.Size = New System.Drawing.Size(220, 284)
        Me.lbxFormularios.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Formularios Disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Roles"
        '
        'lsbFormulariosAsignados
        '
        Me.lsbFormulariosAsignados.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lsbFormulariosAsignados.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lsbFormulariosAsignados.ForeColor = System.Drawing.Color.White
        Me.lsbFormulariosAsignados.FormattingEnabled = True
        Me.lsbFormulariosAsignados.ItemHeight = 14
        Me.lsbFormulariosAsignados.Location = New System.Drawing.Point(339, 85)
        Me.lsbFormulariosAsignados.Name = "lsbFormulariosAsignados"
        Me.lsbFormulariosAsignados.Size = New System.Drawing.Size(220, 284)
        Me.lsbFormulariosAsignados.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(335, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Formularios Asignados"
        '
        'btnAgregarRol
        '
        Me.btnAgregarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgregarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarRol.Image = My.Resources.add1
        Me.btnAgregarRol.Location = New System.Drawing.Point(251, 33)
        Me.btnAgregarRol.Name = "btnAgregarRol"
        Me.btnAgregarRol.Size = New System.Drawing.Size(28, 21)
        Me.btnAgregarRol.TabIndex = 46
        Me.btnAgregarRol.UseVisualStyleBackColor = False
        '
        'btnRemover
        '
        Me.btnRemover.Image = My.Resources.left
        Me.btnRemover.Location = New System.Drawing.Point(264, 243)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(45, 23)
        Me.btnRemover.TabIndex = 6
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = My.Resources.right
        Me.btnAgregar.Location = New System.Drawing.Point(264, 198)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'FrmAdmForms
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(576, 391)
        Me.Controls.Add(Me.btnAgregarRol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lsbFormulariosAsignados)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxFormularios)
        Me.Controls.Add(Me.cbxRoles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAdmForms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Formularios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxRoles As System.Windows.Forms.ComboBox
    Friend WithEvents lbxFormularios As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents lsbFormulariosAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarRol As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
