Imports System.Windows.Forms

Public Class MDIOperador
#Region "Inicializar"

    Private Sub MDIOperador_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cls As New ClsClientes
        cls.FillFrecuenciabyID(ClsVariableSesion.Instancia.Usuario.Operador.frecuencia_id)
        'SE LIBERA LA FRECUENCIA COLOCANDO "a" EN SU ESTADOFILA
        cls.frecuencia.EstadoFila = "a"
        cls.UpdateFrecuencia()
    End Sub
    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargar Status Bar
        Try
            lblEmpresa.Text = "Empresa: REMISES APIPE S.R.L."
            lblUsuario.Text = "Usuario: " & ClsVariableSesion.Instancia.Usuario.usuario
            lblVersion.Text = "Version: " & My.Application.Deployment.CurrentVersion.ToString
        Catch ex As Exception
            Me.lblVersion.Text = "Version: " & "2.0.0.0"
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
    Private Sub AdministrarPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarPedidosToolStripMenuItem.Click
        'ClsPermisos.loadForm(New FrmAdministrarPedidos)
        Dim Frm As New FrmOperadores2
        Frm.Show()
        'If ClsPermisos.getPermisoForm(Frm) Then
        '    Frm.Show()
        'Else
        '    MessageBox.Show("No tiene permisos para esta acción.")
        'End If
    End Sub

    Private Sub TransferirPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferirPedidosToolStripMenuItem.Click
        ClsPermisos.loadForm(New FrmTraspasoPedidos)
    End Sub

    Private Sub OperadoresNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperadoresNuevoToolStripMenuItem.Click
        Dim frm As New FrmOperadores2
        frm.Show()
    End Sub
End Class
