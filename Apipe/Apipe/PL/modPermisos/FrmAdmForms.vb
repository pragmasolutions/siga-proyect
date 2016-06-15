Public Class FrmAdmForms
    Private Cls As New ClsPermisos
    Private Sub FrmAdmForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbxRoles
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = Cls.Roles
        End With
        With lbxFormularios
            .DisplayMember = "v_nombre_form"
            .ValueMember = "id"
        End With
        With lsbFormulariosAsignados
            .DisplayMember = "v_nombre_form"
            .ValueMember = "id"
        End With
    End Sub
    Private Sub CargarListas()
        lbxFormularios.DataSource = Cls.FillListaDisponible(cbxRoles.SelectedValue)
        lsbFormulariosAsignados.DataSource = Cls.FillListaAsignados(cbxRoles.SelectedValue)
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Try
            Cls.AgregarForm2Rol(lbxFormularios.SelectedItem, cbxRoles.SelectedValue)
            CargarListas()
        Catch ex As Exception
            MessageBox.Show("Seleccion un formulario a AGREGAR" + vbCr + "Descripcion " + vbCr + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        Try
            Cls.RemoveForm2Rol(lsbFormulariosAsignados.SelectedItem, cbxRoles.SelectedValue)
            CargarListas()
        Catch ex As Exception
            MessageBox.Show("Seleccion un formulario a REMOVER" + vbCr + "Descripcion " + vbCr + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAgregarRol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRol.Click
        Dim Str As String
        Str = InputBox("Ingrese el nombre del nuevo Rol", "Nuevo Rol")
        If Str.Trim.Length > 0 Then
            Cls.AltaRol(Str)
            With cbxRoles
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DataSource = Cls.Roles
            End With
        End If
    End Sub
    Private Sub FrmAdmForms_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub RolesComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRoles.SelectedIndexChanged
        If cbxRoles.SelectedValue > 0 Then
            CargarListas()
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