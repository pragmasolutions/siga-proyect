Public Class FrmCambiarClave
    Dim Cls As New ClsPermisos

#Region "Inicializar"

    Private Sub FrmCambiarClave_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Cambiar Clave de: " & Cls.Usuario.Entidad.v_AyN
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.Usuario = New usuario
        '  Cls.Usuario = Usr
        '  Cls.Usuario.entidad_id = Usr.entidad_id
        'Cls.Usuario.EstadoFila_usuario = "U" 'GUARDAR SIN CONTRASEÑAS
        'Cls.NoFrmHijo = False
    End Sub

    ' Public Sub New(ByVal ClsVarS As ClsVariableSesion)
    Public Sub New(ByVal ClsVarS As entidad)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cls.Usuario = ClsVarS
        Cls.Usuario.EstadoFila_usuario = "U" 'GUARDAR SIN CONTRASEÑAS
    End Sub

#End Region

#Region "Aceptar Cancelar"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtClaveActual.Text <> Cls.Usuario.password Then
            MessageBox.Show("La clave actual  no es igual a la contraseña ingresada")
        Else
            If txtClaveNueva.Text <> txtClaveNueva2.Text Then
                MessageBox.Show("La Nueva Clave Ingresada deben ser iguales")
            Else
                Cls.IniciarTrn()
                Cls.Usuario.password = txtClaveNueva.Text
                Cls.PersistirUsuario()
                Try
                    Cls.PersistirUsuario()
                    Cls.gettrn.Commit()
                    MessageBox.Show("Los datos se actualizaron correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    Cls.gettrn.Rollback()
                    MessageBox.Show("Erro en la actualización", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#End Region

#Region "Navegacion"

    Private Sub Escape_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#End Region

End Class