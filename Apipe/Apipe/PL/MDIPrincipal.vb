Imports System.Windows.Forms

Public Class MDIPrincipal

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
        Else
        End If
    End Sub
    Private Sub mdiPrincipal_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ClsSettings.getSettings.OpenForms = My.Application.OpenForms
    End Sub
#End Region

#Region "Pedidos"
    Private Sub btnAdmPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmPedidos.Click
        'Dim Frm As New FrmAdministrarPedidos
        'If ClsPermisos.getPermisoForm(Frm) Then
        '    Frm.Show()
        'Else
        '    MessageBox.Show("No tiene permisos para esta acción.")
        'End If
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmPedidoCategoria)
        Frm.Show()

    End Sub
#End Region
#Region "Administacion"
    Private Sub BarrioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarrioToolStripMenuItem.Click
        Dim frm As New FrmBarrio
        ' frm = ClsPermisos.loadForm(New FrmBarrio)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub TraspasarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraspasarToolStripMenuItem.Click
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmTraspasoPedidos)
        Frm.Show()
    End Sub
    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        'Dim Frm As Form
        'Frm = ClsPermisos.loadForm(New FrmInfoCliente)
        'Frm.Show()
        Dim Frm As New FrmInfoCliente
        If ClsPermisos.getPermisoForm(Frm) Then
            Frm.Show()
        Else
            MessageBox.Show("No tiene permisos para esta acción.")
        End If
    End Sub
#End Region

#Region "Reclamos"
    Private Sub AdministraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraToolStripMenuItem.Click
        'ACA SE TENDRIA QUE LLAMAR A UN DIALOGO DE PEDIDOS (BUSCADOR) Y A PARTIR DE ESTE PEDIDO PASANDO EL OBJETO COMO PARAMETRO
        ' DAR DE ALTA EL RECLAMO ASOCIADO AL MISMO
        '    ClsPermisos.loadForm(New DlgPedidos)
    End Sub
    Private Sub CategoriasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasToolStripMenuItem1.Click
        ClsPermisos.loadForm(New FrmReclamoCategoria)
    End Sub
#End Region
  
   
    Private Sub RolesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RolesToolStripMenuItem.Click
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmAdmForms(ClsVariableSesion.Instancia))
        Frm.Show()
    End Sub
    Private Sub PermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosToolStripMenuItem.Click
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmPermisos(ClsVariableSesion.Instancia))
        Frm.Show()
    End Sub

    Private Sub AdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraciónToolStripMenuItem.Click
        '  ClsPermisos.loadForm(New DlgUsuarios).Show()
    End Sub

    Private Sub ReclamosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReclamosToolStripMenuItem1.Click
        ' Dim frm As New FrmPedidos
        ' frm.Show()
    End Sub

    Private Sub MensajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensajeroToolStripMenuItem.Click
        Dim frm As New FrmMensajero
        frm.Show()
    End Sub
End Class
