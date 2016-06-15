<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgTelefonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgTelefonos))
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.toolTel = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCodArea = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNroTel = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmsTelefonos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolTel.SuspendLayout()
        Me.cmsTelefonos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(784, 289)
        Me.dgvClientes.TabIndex = 0
        '
        'toolTel
        '
        Me.toolTel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtCodArea, Me.ToolStripLabel2, Me.txtNroTel, Me.btnBuscar})
        Me.toolTel.Location = New System.Drawing.Point(0, 0)
        Me.toolTel.Name = "toolTel"
        Me.toolTel.Size = New System.Drawing.Size(784, 25)
        Me.toolTel.TabIndex = 1
        Me.toolTel.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel1.Text = "Cód.Area:"
        '
        'txtCodArea
        '
        Me.txtCodArea.Name = "txtCodArea"
        Me.txtCodArea.Size = New System.Drawing.Size(50, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel2.Text = "Nro.:"
        '
        'txtNroTel
        '
        Me.txtNroTel.Name = "txtNroTel"
        Me.txtNroTel.Size = New System.Drawing.Size(100, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscar.Text = "ToolStripButton1"
        '
        'cmsTelefonos
        '
        Me.cmsTelefonos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificar})
        Me.cmsTelefonos.Name = "cmsTelefonos"
        Me.cmsTelefonos.Size = New System.Drawing.Size(153, 48)
        '
        'btnModificar
        '
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'DlgTelefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 289)
        Me.Controls.Add(Me.toolTel)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "DlgTelefonos"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolTel.ResumeLayout(False)
        Me.toolTel.PerformLayout()
        Me.cmsTelefonos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents toolTel As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCodArea As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNroTel As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsTelefonos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
End Class
