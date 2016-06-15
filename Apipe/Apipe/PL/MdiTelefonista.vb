Imports System.Windows.Forms
Imports DespachoAutomatico


Public Class MDITelefonista


#Region "Inicializar"
    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargar Status Bar
        Try
            lblEmpresa.Text = "Empresa: REMISES APIPE S.R.L."
            lblUsuario.Text = "Usuario: " & ClsVariableSesion.Instancia.Usuario.usuario
            lblVersion.Text = "Version: " & My.Application.Deployment.CurrentVersion.ToString
        Catch ex As Exception
            Me.lblVersion.Text = "Version: " & "1.0.0.0"
        End Try
    End Sub
#End Region

#Region "Navegacion"
    Private Sub mdiPrincipal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Visible = True
    End Sub
    Private Sub mdiPrincipal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.R Then
            ClsEnumerados.Instancia = Nothing
            ClsPermisos.Instancia = Nothing
            ClsSettings.getSettings.Forms_Permitidos = ClsVariableSesion.Instancia.Forms_Permitidos
            MessageBox.Show("La cache del sistema se limpio correctamente", "Cache Limpiada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub mdiPrincipal_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ClsSettings.getSettings.OpenForms = My.Application.OpenForms
    End Sub
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmInfoCliente As New FrmInfoCliente
        FrmInfoCliente.MdiParent = Me
        FrmInfoCliente.Show()
    End Sub

    Private Sub SoftPhoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClsPermisos.loadForm(New FrmInfoCliente)
    End Sub

    Private Sub SoftPhoneToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoftPhoneToolStripMenuItem.Click
        Dim FrmInfoCliente As New FrmInfoCliente
        'FrmInfoCliente.MdiParent = Me
        FrmInfoCliente.WindowState = FormWindowState.Maximized
        FrmInfoCliente.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frm As New FrmBuscarClientes
        frm.Show()
    End Sub

    Private Sub MensajeriaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MensajeriaToolStripMenuItem.Click
        Dim frm As New FrmMensajero
        frm.Show()
    End Sub

    Private Sub BuscadorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuscadorToolStripMenuItem.Click
        Dim frm As New FrmBuscadorPedidos
        frm.Show()
    End Sub

    Private Sub PanelDeControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelDeControlToolStripMenuItem.Click
        'Dim frm As New PantallaPedidos
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()

        Dim frm As New PantallaPedidos
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub CambiarFrecuenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFrecuenciasToolStripMenuItem.Click
        Dim frm As New FrmFrecuencias
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub CorreciónCallesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreciónCallesToolStripMenuItem.Click
        Dim frm As New FrmCorrecionCalles
        frm.Show()
    End Sub

    Private Sub CQVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CQVToolStripMenuItem.Click
        'Dim frm As New Apipe.fr
        'frm.show()
        'Dim frm As New DespachoAutomatico.FrmDespachoAutomatico
        'frm.Show()
    End Sub
End Class
