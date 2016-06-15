
Public Class DlgUsuarios
    Dim Cls As New ClsEntidades
    Dim bgsUsuarios As New BindingSource

#Region "Inicializar"
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dgvUsuarios.AutoGenerateColumns = False
    End Sub
    Private Sub DlgClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtApellido.Control.Select()
    End Sub
#End Region

#Region "Aceptar Cancelar"

    Public Function UsuarioSeleccionado() As usuario
        If bgsUsuarios.Position <> -1 Then
            Return bgsUsuarios.Item(bgsUsuarios.Position)
        Else : Return Nothing
        End If
    End Function
#End Region

#Region "ABM"
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmUsuario())
        With Frm
            .MdiParent = Nothing
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                bgsUsuarios.ResetBindings(False)
            End If
        End With
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Cls.Usuario = bgsUsuarios.Item(bgsUsuarios.Position)
        Dim Frm As Form
        Frm = ClsPermisos.loadForm(New FrmUsuario(Cls.Usuario))
        With Frm
            .MdiParent = Nothing
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                btnBuscar_Click(Nothing, Nothing)
            End If
        End With
    End Sub
    Private Sub btnCambiarClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarClave.Click
        Cls.Usuario = UsuarioSeleccionado()
        Dim Frm As Form
        'Frm = ClsPermisos.loadForm(New FrmCambiarClave(ClsVariableSesion.Instancia))
        Frm = ClsPermisos.loadForm(New FrmCambiarClave(Cls.Usuario))
        With Frm
            .MdiParent = Nothing
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                bgsUsuarios.ResetBindings(False)
            End If
        End With
    End Sub
#End Region

#Region "Opciones"
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        bgsUsuarios.DataSource = (From u As usuario In ClsEnumerados.Instancia.lst_Usuario Where u.activo = chkActivo.Checked).ToList
        If txtApellido.TextLength > 0 Then
            bgsUsuarios.DataSource = (From u As usuario In bgsUsuarios.List Where u.apellido.ToLower.Contains(txtApellido.Text.ToLower)).ToList
        End If
        If txtNombre.TextLength > 0 Then
            bgsUsuarios.DataSource = (From u As usuario In bgsUsuarios.List Where u.nombre.ToLower.Contains(txtNombre.Text.ToLower)).ToList
        End If
        dgvUsuarios.DataSource = bgsUsuarios
        If bgsUsuarios.List.Count > 0 Then
            bgsUsuarios.ResetBindings(False)
        Else
            MessageBox.Show("No se encontraron resultados para la busqueda", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtApellido.SelectAll()
        txtNombre.SelectAll()
    End Sub
    Private Sub txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If e.KeyChar = Chr(13) Then
            btnBuscar_Click(sender, e)
        End If
    End Sub
#End Region

#Region "Navegacion"
    Private Sub dgvUsuarios_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        If dgvUsuarios.SelectedRows.Count = 1 Then
            Cls.Usuario = UsuarioSeleccionado()
            Me.Tag = UsuarioSeleccionado()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
        Me.Close()
    End Sub
    Private Sub Escape_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub cmsUsuarios_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsUsuarios.Opening
        'NO ELIMINAR - Rodrigo
        For Each Ctrl As ToolStripItem In cmsUsuarios.Items
            Ctrl.Enabled = False
        Next
        If UsuarioSeleccionado() IsNot Nothing Then
            btnModificar.Enabled = True
            btnCambiarClave.Enabled = True
        End If
        btnNuevo.Enabled = True
    End Sub
#End Region
End Class