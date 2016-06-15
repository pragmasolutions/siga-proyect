<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIOperador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIOperador))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AdministrarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferirPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadoresNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarPedidosToolStripMenuItem, Me.TransferirPedidosToolStripMenuItem, Me.OperadoresNuevoToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 48)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AdministrarPedidosToolStripMenuItem
        '
        Me.AdministrarPedidosToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarPedidosToolStripMenuItem.Image = Global.Apipe.My.Resources.Resources.page_edit1
        Me.AdministrarPedidosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AdministrarPedidosToolStripMenuItem.Name = "AdministrarPedidosToolStripMenuItem"
        Me.AdministrarPedidosToolStripMenuItem.Size = New System.Drawing.Size(166, 44)
        Me.AdministrarPedidosToolStripMenuItem.Text = "Administrar Pedidos"
        Me.AdministrarPedidosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TransferirPedidosToolStripMenuItem
        '
        Me.TransferirPedidosToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferirPedidosToolStripMenuItem.Image = Global.Apipe.My.Resources.Resources.transferir
        Me.TransferirPedidosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TransferirPedidosToolStripMenuItem.Name = "TransferirPedidosToolStripMenuItem"
        Me.TransferirPedidosToolStripMenuItem.Size = New System.Drawing.Size(151, 44)
        Me.TransferirPedidosToolStripMenuItem.Text = "Transferir Pedidos"
        Me.TransferirPedidosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TransferirPedidosToolStripMenuItem.Visible = False
        '
        'OperadoresNuevoToolStripMenuItem
        '
        Me.OperadoresNuevoToolStripMenuItem.Name = "OperadoresNuevoToolStripMenuItem"
        Me.OperadoresNuevoToolStripMenuItem.Size = New System.Drawing.Size(118, 44)
        Me.OperadoresNuevoToolStripMenuItem.Text = "Operadores Nuevo"
        Me.OperadoresNuevoToolStripMenuItem.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblVersion})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblVersion
        '
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(40, 3, 0, 2)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(46, 17)
        Me.lblVersion.Text = "Versión"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Image = Global.Apipe.My.Resources.Resources.house
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(68, 16)
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblUsuario
        '
        Me.lblUsuario.Image = Global.Apipe.My.Resources.Resources.user
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(40, 3, 0, 2)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(63, 16)
        Me.lblUsuario.Text = "Usuario"
        '
        'MDIOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIOperador"
        Me.Text = "Operador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministrarPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferirPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmpresa As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OperadoresNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
