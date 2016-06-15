Imports System.Threading
Public Class FrmLogin
    Dim clsvarios As New ClsVarios
    Dim cls As New ClsClientes
    Const iTIME_INTERVAL As Integer = 300000      ' 5 minutos.
    Private oTimer As System.Threading.Timer
    Private tDelegate As Threading.TimerCallback = AddressOf setSession
    Private Trd As Thread
#Region "Inicializar"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Try
            'My.Settings.DbDomain = "192.168.1.1"
            My.Settings.DbDomain = "190.228.83.52"
            'My.Settings.DbDomain = "190.183.45.81"
            ClsVariableSesion.DbDomain = My.Settings.DbDomain
            ClsVariableSesion.Db = "apipe2909"
            ClsVariableSesion.DbUser = "apipe"
            ClsVariableSesion.DbPass = "apipe"
            ClsVariableSesion.Instancia.getConn.Open()
        Catch ex As Exception
            If MessageBox.Show("No se pudo conectar a la base de datos, ¿desea configurar nuevamente?", "Conexion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If FrmConfiguracion.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    End
                End If
            Else
                End
            End If
        End Try

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.DbDomain.Length = 0 Then
                Dim Dlg As New FrmConfiguracion
                If Dlg.ShowDialog <> Windows.Forms.DialogResult.OK Then
                    End
                End If
            End If
            'lleno los combobox
            CargarLoggin()
        Catch ex As Exception
            If MessageBox.Show("Error en la conexión a la Base de Datos.Desea volver a la configuracion inicial", "Configuracion Inicial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                My.Settings.DbDomain = ""
                My.Settings.Save()
                End
            End If
        End Try
    End Sub
    Private Sub FrmLogin_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ClsEnumerados.Instancia = Nothing
            CargarLoggin()
        End If
    End Sub
    Private Sub CargarLoggin()
        'cbxEmpresa.Items.Clear()
        'cbxSucursal.Items.Clear()
        'cbxUsuario.Items.Clear()
        'clsvarios.FillcbxbyEmpresas(cbxEmpresa)
        With cbxUsuario
            .DisplayMember = "usuario"
            .ValueMember = "entidad_id"
            .DataSource = ClsEnumerados.Instancia.lst_Usuario
        End With
        With My.Settings
            cbxUsuario.SelectedValue = .idUsuario
        End With
        With cbxFrecuencia
            .ValueMember = "id"
            .DisplayMember = "numero"
            .DataSource = ClsEnumerados.Instancia.lstFrecuencia
        End With
    End Sub
#End Region
#Region "OK cancel"
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtcontraseña.Text = "" Then
            MessageBox.Show("Por favor, ingrese una contraseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtcontraseña.Text.ToLower = "reiniciar" Then
            If MessageBox.Show("Esta seguro que desea volver a la configuracion inicial", "Configuracion Inicial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                My.Settings.DbDomain = ""
                My.Settings.Save()
                End
            End If
        Else
            If Not txtcontraseña.Text = cbxUsuario.SelectedItem.password.ToString Then
                MessageBox.Show("Contraseña incorrecta, intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtcontraseña.Text = ""
            Else
                ClsVariableSesion.Instancia.Usuario = cbxUsuario.SelectedItem
                ClsVariableSesion.Instancia.Usuario.id = ClsVariableSesion.Instancia.Usuario.entidad_id
                With My.Settings
                    .idUsuario = cbxUsuario.SelectedValue
                    .subsistema = cbxSistema.Text
                    .Save()
                End With
                Dim seguir As Boolean = True
                If cbxFrecuencia.Visible Then
                    If ControlarFrecuencia = True then
                    Dim clsEnt As New ClsEntidades
                    With clsEnt
                        .Usuario = cbxUsuario.SelectedItem
                        .Usuario.Operador.entidad_id = .Usuario.entidad_id
                        .Usuario.Operador.frecuencia_id = cbxFrecuencia.SelectedValue
                        Try
                                .PersistirOperador()
                                cls.FillFrecuenciabyID(cbxFrecuencia.SelectedValue)
                                'SE BLOQUEA LA FRECUENCIA GUARDANDO "I" EN SU ESTADOFILA
                                cls.frecuencia.EstadoFila = "a"
                                cls.UpdateFrecuencia()
                        Catch ex As Exception
                            seguir = False
                            MessageBox.Show(ex.Message)
                        End Try
                        End With
                    Else
                        seguir = False
                    End If
                End If
                If seguir Then
                    'If txtcontraseña.Text = "cambiame" Then
                    '    Dim dlg As New FrmPassword
                    '    If dlg.ShowDialog <> Windows.Forms.DialogResult.OK Then
                    '        Me.Close()
                    '    Else
                    '    End If
                    'End If
                    'Seteo los datos de Permisos
                    'ClsConexion.DbDomain = My.Settings.DbDomain
                    'ClsConexion.DbName = "antuan"
                    'ClsConexion.DbUser = "antuan"
                    'ClsConexion.DbPassword = "antuan"
                    'ClsPermisos.Instancia = Nothing 'New List(Of String)

                    ClsSettings.getSettings.Forms_Permitidos = ClsPermisos.Instancia.FormulariosPermitidos(ClsVariableSesion.Instancia)
                    ''''''''''''''''''''''''''''''''''
                    Dim Mdi As String = ""
                    Mdi = CType(cbxSistema.SelectedItem, formulario).nombre_form 'BaseClassLibrary.ClsSettings.getSettings.Forms_Permitidos.Find(Function(x) x.Contains("MDI")).ToString
                    Dim MDIForm As New Form
                    Select Case Mdi.ToLower
                        Case "MDIPrincipal".ToLower
                            MDIForm = MDIPrincipal
                        Case "MdiTelefonista".ToLower
                            MDIForm = MDITelefonista
                        Case "MdiOperador".ToLower
                            MDIForm = MDIOperador
                        Case Is = "MDIServicio".ToLower
                            ' MDIForm = MDIServicio
                        Case Else
                            MDIForm = MDIPrincipal
                    End Select

                    MDIForm.Show()
                    txtcontraseña.Text = ""
                    Me.Visible = False
                    'Dim clsNotif As New ClsNotificaciones
                    'clsNotif.CrearMenuNotificaciones(MDIForm)
                    '  Cls.getInstanciaNotificaciones.CrearMenuNotificaciones(MDIForm)
                    '   Dim clsPnl As New ClsPanelColapsable
                    '  clsPnl.CrearPanelColapsable(MDIForm)
                End If
            End If
        End If
        setSession()
        Trd = New Thread(AddressOf ThreadTask)
        Trd.IsBackground = True
        Trd.Start()
    End Sub
    Private Sub ThreadTask()
        Thread.Sleep(200000)
        oTimer = New System.Threading.Timer(tDelegate, Me, 0, iTIME_INTERVAL)
    End Sub
    <STAThread()> _
    Private Sub setSession()
        Try
            'Notificaciones
            session.setSession(ClsVariableSesion.Instancia.Usuario.id, ClsVariableSesion.Instancia.getConn) '1 ' 23313 ' 999
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
#End Region
#Region "Navegacion"
    Private Sub cbxUsuario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxUsuario.SelectedIndexChanged
        cbxSistema.DataSource = Nothing
        cbxSistema.Refresh()
        If cbxUsuario.SelectedValue > 0 Then
            With cbxSistema
                .DisplayMember = "detalle"
                .ValueMember = "id"
                .DataSource = (From FR As formulario_rol In ClsEnumerados.Instancia.lstFormularioRol
                                Join F As formulario In ClsEnumerados.Instancia.lstFormulario On FR.formulario_id Equals F.id
                                Join UR As usuario_rol In ClsEnumerados.Instancia.lstUsuarioRol On UR.rol_id Equals FR.rol_id
                                Where UR.usuario_id = cbxUsuario.SelectedValue And F.nombre_form.Contains("MDI") Select F Distinct).ToList
            End With
            If cbxSistema.Items.Count < 2 Then
                cbxSistema.Enabled = False
            Else
                cbxSistema.Enabled = True
                If My.Settings.subsistema.Length > 0 Then
                    cbxSistema.SelectedItem = CType(cbxSistema.DataSource, List(Of formulario)).Find(Function(x) x.detalle.Contains(My.Settings.subsistema))
                End If
            End If
        End If
        txtcontraseña.Text = ""
    End Sub
#End Region
    Private Sub cbxSistema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxSistema.SelectedIndexChanged
        If cbxSistema.Text.ToLower.Contains("operador") Then
            lblFrecuencia.Visible = True
            cbxFrecuencia.Visible = True
            txtcontraseña.Top += cbxFrecuencia.Height
            PasswordLabel.Top = txtcontraseña.Top
            OK.Top += cbxFrecuencia.Height
            Cancel.Top += cbxFrecuencia.Height
        ElseIf cbxFrecuencia.Visible Then
            lblFrecuencia.Visible = False
            cbxFrecuencia.Visible = False
            txtcontraseña.Top -= cbxFrecuencia.Height
            PasswordLabel.Top = txtcontraseña.Top
            OK.Top -= cbxFrecuencia.Height
            Cancel.Top -= cbxFrecuencia.Height
        End If
    End Sub
    Private Sub cbxFrecuencia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFrecuencia.SelectedIndexChanged
        With cbxFrecuencia
            .ValueMember = "id"
            .DisplayMember = "numero"
            .DataSource = ClsEnumerados.Instancia.lstFrecuencia
        End With
    End Sub
    Private Sub cbxFrecuencia_LostFocus(sender As Object, e As System.EventArgs) Handles cbxFrecuencia.LostFocus
        ControlarFrecuencia()
    End Sub
    Private Function ControlarFrecuencia() As Boolean
        If cls.ControlarFrecuencia(cbxFrecuencia.SelectedValue) = False Then
            ErrorProvider1.SetError(cbxFrecuencia, "Frecuencia en uso")
            ControlarFrecuencia = False
        Else
            ErrorProvider1.SetError(cbxFrecuencia, Nothing)
            ControlarFrecuencia = True
        End If
    End Function


End Class
