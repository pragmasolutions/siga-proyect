Public Class FrmPermisos
    Private Cls As New ClsPermisos
    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearArbol()
    End Sub

    Private Sub CrearArbol()
        ' Borra los nodos del treeview
        trvRoles.Nodes.Clear()
        ' Recorre el dataset y carga los usuarios y roles
        Cls.ArmarArbolUsuariosRoles(trvRoles)
    End Sub
    Private Sub trvRoles_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvRoles.AfterCheck
        'Si no tiene pariente es porque es un hijo (rol)
        If e.Node.Parent IsNot Nothing Then
            Try
                If e.Node.Checked Then
                    Cls.AddUsuarioRol(e.Node.Parent.Tag, e.Node.Tag)
                Else
                    Cls.DelUsuarioRol(e.Node.Parent.Tag, e.Node.Tag)
                End If
                'ClsEnumerados.Instancia.lst_Usuario = Nothing
                'ClsEnumerados.Instancia.UsuariosVendedores = Nothing
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error" & vbCrLf & "Descripcion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btoCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmPermisos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal ClsVarS As ClsVariableSesion)
        ClsVariableSesion.Instancia = ClsVarS
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class
