Imports MySql.Data.MySqlClient
Public Class ClsVariableSesion
    Private Shared _Instancia As ClsVariableSesion
    Private _conn As MySqlConnection, _trn As MySqlTransaction
    Private Shared _DbDomain As String
    Private Shared _DbUser As String
    Private Shared _DbPass As String
    Private Shared _Db As String
#Region "Conexion"
    Public Sub New()
        _conn = New MySqlConnection
        'puerto para conexion remota
        '& " persist security info=False;port=7003;database=" & _Db & ";logging=True;" _

        'para conexion local
        '& " persist security info=False;database=" & _Db & ";logging=True;" _
        Try
            _conn.ConnectionString = "server=" & _DbDomain & ";" _
        & " persist security info=False;port=7003;database=" & _Db & ";logging=True;" _
            & "password=" & _DbPass & ";" _
& "user id=" & _DbUser & ";connect timeout=150;default command timeout=160;" _
& "Pooling=false;Connection Lifetime=0; Max Pool Size=1;Allow User Variables=True;allow zero datetime=yes"
            '_conn.Open()
        Catch ex As Exception
            'Throw (ex.Message)
        End Try
    End Sub
    Public Shared WriteOnly Property DbDomain As String
        Set(ByVal value As String)
            _DbDomain = value
        End Set
    End Property
    Public Shared WriteOnly Property DbUser As String
        Set(ByVal value As String)
            _DbUser = value
        End Set
    End Property
    Public Shared WriteOnly Property DbPass As String
        Set(ByVal value As String)
            _DbPass = value
        End Set
    End Property
    Public Shared WriteOnly Property Db As String
        Set(ByVal value As String)
            _Db = value
        End Set
    End Property
    Public Shared Property Instancia() As ClsVariableSesion
        Get
            If _Instancia Is Nothing Then
                _Instancia = New ClsVariableSesion
            End If
            Return _Instancia
        End Get
        Set(ByVal value As ClsVariableSesion)
            _Instancia = value
        End Set
    End Property
    Public Property getConn() As MySqlConnection
        Get
            Return _conn
        End Get
        Set(ByVal value As MySqlConnection)
            _conn = value
        End Set
    End Property
    Public Sub IniciarTrn()
        Try
            _trn = getConn.BeginTransaction
        Catch ex As Exception
            _trn.Rollback()
            _trn = getConn.BeginTransaction
        End Try

    End Sub
    Public ReadOnly Property getTrn As MySqlTransaction
        Get
            Return _trn
        End Get
    End Property
#End Region
#Region "Variable Sesion"
    Private _Usuario As usuario
    Public Property Usuario As usuario
        Get
            If _Usuario Is Nothing Then
                _Usuario = New usuario
            End If
            Return _Usuario
        End Get
        Set(ByVal value As usuario)
            _Usuario = value
            'Cuando hago el Set del usuario creo la variable de session en mysql
            '_Usuario.setUsuarioIdMysqlSession()
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            '    Return "e.id,e.cuil,e.apellido,e.nombre,e.estado_civil,e.sexo,e.domicilio,e.fecha_nacimiento,e.tipo_documento,e.nro_documento," _
            '        & "e.mail,e.observacion,e.iva,e.foto,e.localidad_id,e.baja" _
            '        & ",u.entidad_id,u.usuario,u.password,u.activo"
            Return "u.entidad_id,u.usuario,u.password,u.activo"
        End Get
    End Property
    Public Sub FillByusuario(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM usuario u" & vbCrLf _
                     & " WHERE u.entidad_id=?id"
                '  & " JOIN entidad e ON e.id=u.entidad_id" & vbCrLf _
                .Connection = _Conexion
                .Parameters.AddWithValue("id", Id)
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    Dim Fila As DataRow = Dt.Rows(0)
                    CargarFila(Fila, Usuario)
                End If
            End With
        End Using
    End Sub
    Private Sub CargarFila(ByRef Fila As DataRow, ByRef O As entitiesApipe.usuario)
        If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id")
        If Fila.Item("usuario") IsNot DBNull.Value Then O.usuario = Fila.Item("usuario")
        If Fila.Item("password") IsNot DBNull.Value Then O.password = Fila.Item("password")
        If Fila.Item("activo") IsNot DBNull.Value Then O.activo = Fila.Item("activo")

        'If Fila.Item("id") IsNot DBNull.Value Then O.Entidad.id = Fila.Item("id")
        'If Fila.Item("cuil") IsNot DBNull.Value Then O.Entidad.cuil = Fila.Item("cuil")
        'If Fila.Item("apellido") IsNot DBNull.Value Then O.Entidad.apellido = Fila.Item("apellido")
        'If Fila.Item("nombre") IsNot DBNull.Value Then O.Entidad.nombre = Fila.Item("nombre")
        'If Fila.Item("estado_civil") IsNot DBNull.Value Then O.Entidad.estado_civil = Fila.Item("estado_civil")
        'If Fila.Item("sexo") IsNot DBNull.Value Then O.Entidad.sexo = Fila.Item("sexo")
        'If Fila.Item("fecha_nacimiento") IsNot DBNull.Value Then O.Entidad.fecha_nacimiento = Date.Parse(Fila.Item("fecha_nacimiento").ToString)
        'If Fila.Item("tipo_documento") IsNot DBNull.Value Then O.Entidad.tipo_documento = Fila.Item("tipo_documento")
        'If Fila.Item("nro_documento") IsNot DBNull.Value Then O.Entidad.nro_documento = Fila.Item("nro_documento")
        'If Fila.Item("mail") IsNot DBNull.Value Then O.Entidad.mail = Fila.Item("mail")
        'If Fila.Item("observacion") IsNot DBNull.Value Then O.Entidad.observacion = Fila.Item("observacion")
        'If Fila.Item("iva") IsNot DBNull.Value Then O.Entidad.iva = Fila.Item("iva")
        'If Fila.Item("foto") IsNot DBNull.Value Then O.Entidad.foto = Fila.Item("foto")
        'If Fila.Item("baja") IsNot DBNull.Value Then O.Entidad.baja = Fila.Item("baja") Else O.Entidad.baja = False
    End Sub
#End Region
    Private _Forms_Permitidos As List(Of String)
    Public ReadOnly Property Forms_Permitidos As List(Of String)
        Get
            If _Forms_Permitidos Is Nothing Then
                _Forms_Permitidos = (From FR As formulario_rol In ClsEnumerados.Instancia.lstFormularioRol
                                         Join F As formulario In ClsEnumerados.Instancia.lstFormulario On FR.formulario_id Equals F.id
                                         Join UR As usuario_rol In ClsEnumerados.Instancia.lstUsuarioRol On UR.rol_id Equals FR.rol_id
                                         Where UR.usuario_id = Usuario.entidad_id Select F.nombre_form).ToList
            End If
            Return _Forms_Permitidos
        End Get
    End Property
End Class
