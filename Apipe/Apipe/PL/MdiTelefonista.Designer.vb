<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDITelefonista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDITelefonista))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SoftPhoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDeControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReclamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensajeriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFrecuenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreciónCallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CQVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoftPhoneToolStripMenuItem, Me.BuscadorToolStripMenuItem, Me.PanelDeControlToolStripMenuItem, Me.ReclamosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.MensajeriaToolStripMenuItem, Me.CambiarFrecuenciasToolStripMenuItem, Me.CorreciónCallesToolStripMenuItem, Me.CQVToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1057, 48)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SoftPhoneToolStripMenuItem
        '
        Me.SoftPhoneToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftPhoneToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.SoftPhoneToolStripMenuItem.Image = Global.Apipe.My.Resources.Resources.telemarket
        Me.SoftPhoneToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SoftPhoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SoftPhoneToolStripMenuItem.Name = "SoftPhoneToolStripMenuItem"
        Me.SoftPhoneToolStripMenuItem.Size = New System.Drawing.Size(98, 44)
        Me.SoftPhoneToolStripMenuItem.Text = "Soft Phone"
        Me.SoftPhoneToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BuscadorToolStripMenuItem
        '
        Me.BuscadorToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscadorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BuscadorToolStripMenuItem.Name = "BuscadorToolStripMenuItem"
        Me.BuscadorToolStripMenuItem.Size = New System.Drawing.Size(93, 44)
        Me.BuscadorToolStripMenuItem.Text = "Buscador"
        '
        'PanelDeControlToolStripMenuItem
        '
        Me.PanelDeControlToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PanelDeControlToolStripMenuItem.Name = "PanelDeControlToolStripMenuItem"
        Me.PanelDeControlToolStripMenuItem.Size = New System.Drawing.Size(165, 44)
        Me.PanelDeControlToolStripMenuItem.Text = "Panel de Control"
        '
        'ReclamosToolStripMenuItem
        '
        Me.ReclamosToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReclamosToolStripMenuItem.Image = Global.Apipe.My.Resources.Resources.reclamo2
        Me.ReclamosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReclamosToolStripMenuItem.Name = "ReclamosToolStripMenuItem"
        Me.ReclamosToolStripMenuItem.Size = New System.Drawing.Size(90, 44)
        Me.ReclamosToolStripMenuItem.Text = "Reclamos"
        Me.ReclamosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ReclamosToolStripMenuItem.Visible = False
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ClientesToolStripMenuItem.Image = Global.Apipe.My.Resources.Resources.cliente
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(79, 44)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        Me.ClientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ClientesToolStripMenuItem.Visible = False
        '
        'MensajeriaToolStripMenuItem
        '
        Me.MensajeriaToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MensajeriaToolStripMenuItem.Image = Global.Apipe.My.Resources.Resources.mensajeria
        Me.MensajeriaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MensajeriaToolStripMenuItem.Name = "MensajeriaToolStripMenuItem"
        Me.MensajeriaToolStripMenuItem.Size = New System.Drawing.Size(100, 44)
        Me.MensajeriaToolStripMenuItem.Text = "Mensajeria"
        Me.MensajeriaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MensajeriaToolStripMenuItem.Visible = False
        '
        'CambiarFrecuenciasToolStripMenuItem
        '
        Me.CambiarFrecuenciasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.CambiarFrecuenciasToolStripMenuItem.Name = "CambiarFrecuenciasToolStripMenuItem"
        Me.CambiarFrecuenciasToolStripMenuItem.Size = New System.Drawing.Size(192, 44)
        Me.CambiarFrecuenciasToolStripMenuItem.Text = "Cambiar Frecuencias"
        '
        'CorreciónCallesToolStripMenuItem
        '
        Me.CorreciónCallesToolStripMenuItem.Name = "CorreciónCallesToolStripMenuItem"
        Me.CorreciónCallesToolStripMenuItem.Size = New System.Drawing.Size(174, 44)
        Me.CorreciónCallesToolStripMenuItem.Text = "Corrección Calles"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblVersion, Me.lblEmpresa, Me.lblUsuario})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1057, 22)
        Me.StatusStrip.TabIndex = 9
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
        Me.lblEmpresa.Size = New System.Drawing.Size(68, 17)
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblUsuario
        '
        Me.lblUsuario.Image = Global.Apipe.My.Resources.Resources.user
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(40, 3, 0, 2)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(63, 17)
        Me.lblUsuario.Text = "Usuario"
        '
        'CQVToolStripMenuItem
        '
        Me.CQVToolStripMenuItem.Name = "CQVToolStripMenuItem"
        Me.CQVToolStripMenuItem.Size = New System.Drawing.Size(48, 44)
        Me.CQVToolStripMenuItem.Text = "CQV"
        '
        'MDITelefonista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDITelefonista"
        Me.Text = "Telefonista"
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
    Friend WithEvents ReclamosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmpresa As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SoftPhoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MensajeriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelDeControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarFrecuenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorreciónCallesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CQVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
