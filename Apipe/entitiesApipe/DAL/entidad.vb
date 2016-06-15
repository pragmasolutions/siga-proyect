Imports MySql.Data.MySqlClient
Public Class entidad
#Region "Miembros"
	Private _id As Integer
	Private _cuil As String
	Private _apellido As String
	Private _nombre As String
	Private _estado_civil As String
	Private _sexo As String
	Private _fecha_nacimiento As Date
	Private _tipo_documento As String
	Private _nro_documento As Integer
	Private _observacion As String
	Private _iva As String
    Private _foto As Byte()
    Private _baja As Boolean
	Private _EstadoFila As Char
	'Definicion de Entidades
    Private _Operador As operador
	Private _lst_Aseguradora As List(Of aseguradora)
	Private _lst_Chofer As List(Of chofer)
    Private _Cliente As cliente
	Private _lst_Mail As List(Of mail)
    'Private _lst_Operador As List(Of operador)
	Private _lst_Telefono As List(Of telefono)
	Private _lst_Usuario As List(Of usuario)
#End Region
#Region "Propiedades"
    Public Property id As Integer Implements IEntidad.id
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property
    Public Property cuil As String Implements IEntidad.cuil
        Get
            Return _cuil
        End Get
        Set(ByVal Value As String)
            _cuil = Value
        End Set
    End Property
    Public Property apellido As String Implements IEntidad.apellido
        Get
            Return _apellido
        End Get
        Set(ByVal Value As String)
            _apellido = Value
        End Set
    End Property
    Public Property nombre As String Implements IEntidad.nombre
        Get
            Return _nombre
        End Get
        Set(ByVal Value As String)
            _nombre = Value
        End Set
    End Property
    Public Property estado_civil As String Implements IEntidad.estado_civil
        Get
            Return _estado_civil
        End Get
        Set(ByVal Value As String)
            _estado_civil = Value
        End Set
    End Property
    Public Property sexo As String Implements IEntidad.sexo
        Get
            Return _sexo
        End Get
        Set(ByVal Value As String)
            _sexo = Value
        End Set
    End Property
    Public Property fecha_nacimiento As Date Implements IEntidad.fecha_nacimiento
        Get
            Return _fecha_nacimiento
        End Get
        Set(ByVal Value As Date)
            _fecha_nacimiento = Value
        End Set
    End Property
    Public Property tipo_documento As String Implements IEntidad.tipo_documento
        Get
            Return _tipo_documento
        End Get
        Set(ByVal Value As String)
            _tipo_documento = Value
        End Set
    End Property
    Public Property nro_documento As Integer Implements IEntidad.nro_documento
        Get
            Return _nro_documento
        End Get
        Set(ByVal Value As Integer)
            _nro_documento = Value
        End Set
    End Property
    Public Property observacion As String Implements IEntidad.observacion
        Get
            Return _observacion
        End Get
        Set(ByVal Value As String)
            _observacion = Value
        End Set
    End Property
    Public Property iva As String Implements IEntidad.iva
        Get
            Return _iva
        End Get
        Set(ByVal Value As String)
            _iva = Value
        End Set
    End Property
    Public Property foto As Byte() Implements IEntidad.foto
        Get
            Return _foto
        End Get
        Set(ByVal Value As Byte())
            _foto = Value
        End Set
    End Property
    Public Property baja As Boolean Implements IEntidad.baja
        Get
            Return _baja
        End Get
        Set(ByVal Value As Boolean)
            _baja = Value
        End Set
    End Property
    Public Property EstadoFila As Char Implements IEntidad.EstadoFila
        Get
            Return _EstadoFila
        End Get
        Set(ByVal Value As Char)
            _EstadoFila = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property Cliente As cliente Implements IEntidad.Cliente
        Get
            If _Cliente Is Nothing Then
                _Cliente = New cliente
                _Cliente.StoreFillBycliente(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _Cliente
        End Get
        Set(ByVal value As cliente)
            _Cliente = value
        End Set
    End Property
    Public Property Operador As operador Implements IEntidad.Operador
        Get
            If _Operador Is Nothing Then
                _Operador = New operador
                _Operador.FillByoperador(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _Operador
        End Get
        Set(ByVal value As operador)
            _Operador = value
        End Set
    End Property
    Public Property lst_Aseguradora As List(Of aseguradora) Implements IEntidad.lst_Aseguradora
        Get
            If Me._lst_Aseguradora Is Nothing Then
                _lst_Aseguradora = New List(Of aseguradora)
                If Me.id > 0 Then
                    _lst_Aseguradora = aseguradora.FillListByEntidad(Me.id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _lst_Aseguradora
        End Get
        Set(ByVal Value As List(Of aseguradora))
            _lst_Aseguradora = Value
        End Set
    End Property
    Public Property lst_Chofer As List(Of chofer) Implements IEntidad.lst_Chofer
        Get
            If Me._lst_Chofer Is Nothing Then
                _lst_Chofer = New List(Of chofer)
                If Me.id > 0 Then
                    _lst_Chofer = chofer.FillListByEntidad(Me.id, ClsVariableSesion.Instancia.getConn)
                End If

            End If
            Return _lst_Chofer
        End Get
        Set(ByVal Value As List(Of chofer))
            _lst_Chofer = Value
        End Set
    End Property
    Public Property lst_Mail As List(Of mail) Implements IEntidad.lstMail
        Get
            If Me._lst_Mail Is Nothing Then
                _lst_Mail = New List(Of mail)
                If Me.id > 0 Then
                    _lst_Mail = mail.FillListByEntidad(Me.id, ClsVariableSesion.Instancia.getConn)
                End If

            End If
            Return _lst_Mail
        End Get
        Set(ByVal Value As List(Of mail))
            _lst_Mail = Value
        End Set
    End Property

    'Public Property lst_Operador As List(Of operador)
    '    Get
    '        If Me._lst_Operador Is Nothing Then
    '            _lst_Operador = New List(Of operador)
    '            '_lst_Operador=operador.FillListByEntidad(Me.id, ClsVariableSesion.Instancia.getConn) 
    '        End If
    '        Return _lst_Operador
    '    End Get
    '    Set(ByVal Value As List(Of operador))
    '        _lst_Operador = Value
    '    End Set
    'End Property
    Public Property lst_Telefono As List(Of telefono) Implements IEntidad.lstTelefono
        Get
            If Me._lst_Telefono Is Nothing Then
                _lst_Telefono = New List(Of telefono)
                If Me.id > 0 Then
                    _lst_Telefono = telefono.StoreFillListByEntidad(Me.id, ClsVariableSesion.Instancia.getConn)
                End If

            End If
            Return _lst_Telefono
        End Get
        Set(ByVal Value As List(Of telefono))
            _lst_Telefono = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "e.id,e.cuil,e.apellido,e.nombre,e.estado_civil,e.sexo,e.fecha_nacimiento,e.tipo_documento,e.nro_documento,e.observacion,e.iva,e.foto,e.baja"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .cuil = ""
            .apellido = ""
            .nombre = ""
            .estado_civil = ""
            .sexo = ""
            .fecha_nacimiento = "1900-01-01 00:00:00"
            .tipo_documento = ""
            .nro_documento = 0
            .observacion = ""
            .iva = ""
            .foto = Nothing
            .baja = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of entidad)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of entidad)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM entidad e"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)

                Dt.Dispose()
                Ta.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByDomicilio(ByVal domicilio_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of entidad)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of entidad)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM entidad e" & vbCrLf
                .CommandText &= "WHERE domicilio_id = ?domicilio_id"
                .Parameters.AddWithValue("?domicilio_id", domicilio_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)

                Dt.Dispose()
                Ta.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of entidad))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New entidad
                O.CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Sub CargarFila(ByRef Fila As DataRow, ByRef O As entidad) Implements IEntidad.CargarFila
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("cuil") IsNot DBNull.Value Then O.cuil = Fila.Item("cuil") Else O.cuil = ""
        If Fila.Item("apellido") IsNot DBNull.Value Then O.apellido = Fila.Item("apellido") Else O.apellido = ""
        If Fila.Item("nombre") IsNot DBNull.Value Then O.nombre = Fila.Item("nombre") Else O.nombre = ""
        If Fila.Item("estado_civil") IsNot DBNull.Value Then O.estado_civil = Fila.Item("estado_civil") Else O.estado_civil = ""
        If Fila.Item("sexo") IsNot DBNull.Value Then O.sexo = Fila.Item("sexo") Else O.sexo = ""
        If Fila.Item("fecha_nacimiento") IsNot DBNull.Value Then O.fecha_nacimiento = Date.Parse(Fila.Item("fecha_nacimiento").ToString) Else O.fecha_nacimiento = "1900-01-01 00:00:00"
        If Fila.Item("tipo_documento") IsNot DBNull.Value Then O.tipo_documento = Fila.Item("tipo_documento") Else O.tipo_documento = ""
        If Fila.Item("nro_documento") IsNot DBNull.Value Then O.nro_documento = Fila.Item("nro_documento") Else O.nro_documento = 0
        If Fila.Item("observacion") IsNot DBNull.Value Then O.observacion = Fila.Item("observacion") Else O.observacion = ""
        If Fila.Item("iva") IsNot DBNull.Value Then O.iva = Fila.Item("iva") Else O.iva = ""
        If Fila.Item("foto") IsNot DBNull.Value Then O.foto = Fila.Item("foto") Else O.foto = Nothing
        If Fila.Item("baja") IsNot DBNull.Value Then O.baja = Fila.Item("baja") Else O.baja = 0
    End Sub
    Public Sub StoreFillByentidad(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of entidad)
                With exe
                    .CommandText = "FillEntidadById"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?entidad", Id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()

                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If
                End With
            End Using
        Catch ex As Exception
        End Try

    End Sub
    Public Function Clone() As entidad Implements IEntidad.Clone
        Clone = New entidad
        With Clone
            .id = Me.id
            .cuil = Me.cuil
            .apellido = Me.apellido
            .nombre = Me.nombre
            .estado_civil = Me.estado_civil
            .sexo = Me.sexo
            .fecha_nacimiento = Me.fecha_nacimiento
            .tipo_documento = Me.tipo_documento
            .nro_documento = Me.nro_documento
            .observacion = Me.observacion
            .iva = Me.iva
            .foto = Me.foto
            .baja = Me.baja
            .EstadoFila = Me.EstadoFila
        End With
    End Function
    Public Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer Implements IEntidad.Insert
        Dim sqlParam As New MySqlParameter
        Dim transaction As MySqlTransaction
        Using cmd As New MySqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "INSERT INTO entidad (cuil,apellido,nombre,estado_civil,sexo,fecha_nacimiento,tipo_documento,nro_documento,observacion,iva,foto,baja) VALUES (?cuil,?apellido,?nombre,?estado_civil,?sexo,?fecha_nacimiento,?tipo_documento,?nro_documento,?observacion,?iva,?foto,?baja)"
                sqlParam = cmd.Parameters.Add("?cuil", MySqlDbType.VarChar, 13)
                If cuil = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cuil
                End If
                sqlParam = cmd.Parameters.Add("?apellido", MySqlDbType.VarChar, 50)
                sqlParam.Value = apellido
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 50)
                If nombre = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = nombre
                End If
                sqlParam = cmd.Parameters.Add("?estado_civil", MySqlDbType.Enum, 0)
                If estado_civil = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = estado_civil
                End If
                sqlParam = cmd.Parameters.Add("?sexo", MySqlDbType.Enum, 0)
                sqlParam.Value = sexo
                sqlParam = cmd.Parameters.Add("?fecha_nacimiento", MySqlDbType.Date, 0)
                If fecha_nacimiento = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = fecha_nacimiento
                End If
                sqlParam = cmd.Parameters.Add("?tipo_documento", MySqlDbType.Enum, 0)
                If tipo_documento = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = tipo_documento
                End If
                sqlParam = cmd.Parameters.Add("?nro_documento", MySqlDbType.Int32, 11)
                sqlParam.Value = nro_documento
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 30)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?iva", MySqlDbType.VarChar, 100)
                If iva = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = iva
                End If
                sqlParam = cmd.Parameters.Add("?foto", MySqlDbType.Byte, 0)
                If foto Is Nothing Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = foto
                End If
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Bit, 4)
                sqlParam.Value = baja
                'sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                'sqlParam.Value = domicilio_id
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try
            Me.id = cmd.LastInsertedId
            Return cmd.LastInsertedId
        End Using
    End Function
    Public Function Update(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean Implements IEntidad.Update
        Dim sqlParam As New MySqlParameter
        Dim transaction As MySqlTransaction
        Using cmd As New MySqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "UPDATE entidad SET cuil=?cuil,apellido=?apellido,nombre=?nombre,estado_civil=?estado_civil,sexo=?sexo,fecha_nacimiento=?fecha_nacimiento,tipo_documento=?tipo_documento,nro_documento=?nro_documento,observacion=?observacion,iva=?iva,foto=?foto,baja=?baja WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?cuil", MySqlDbType.VarChar, 13)
                If cuil = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cuil
                End If
                sqlParam = cmd.Parameters.Add("?apellido", MySqlDbType.VarChar, 50)
                sqlParam.Value = apellido
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 50)
                If nombre = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = nombre
                End If
                sqlParam = cmd.Parameters.Add("?estado_civil", MySqlDbType.Enum, 0)
                If estado_civil = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = estado_civil
                End If
                sqlParam = cmd.Parameters.Add("?sexo", MySqlDbType.Enum, 0)
                sqlParam.Value = sexo
                sqlParam = cmd.Parameters.Add("?fecha_nacimiento", MySqlDbType.Date, 0)
                If fecha_nacimiento = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = fecha_nacimiento
                End If
                sqlParam = cmd.Parameters.Add("?tipo_documento", MySqlDbType.Enum, 0)
                If tipo_documento = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = tipo_documento
                End If
                sqlParam = cmd.Parameters.Add("?nro_documento", MySqlDbType.Int32, 11)
                sqlParam.Value = nro_documento
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 30)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?iva", MySqlDbType.VarChar, 100)
                If iva = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = iva
                End If
                sqlParam = cmd.Parameters.Add("?foto", MySqlDbType.Byte, 0)
                If foto Is Nothing Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = foto
                End If
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Int16, 4)
                sqlParam.Value = baja
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try
            Return True
        End Using
    End Function
    Public Function InsertUpdate(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
        Dim sqlParam As New MySqlParameter
        Dim transaction As MySqlTransaction
        Using cmd As New MySqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "INSERT INTO entidad (id,cuil,apellido,nombre,estado_civil,sexo,fecha_nacimiento,tipo_documento,nro_documento,observacion,iva,foto,baja,domicilio_id) VALUES (?id,?cuil,?apellido,?nombre,?estado_civil,?sexo,?fecha_nacimiento,?tipo_documento,?nro_documento,?observacion,?iva,?foto,?baja,?domicilio_id)" & vbCrLf _
     & " ON DUPLICATE KEY UPDATE cuil=?cuil,apellido=?apellido,nombre=?nombre,estado_civil=?estado_civil,sexo=?sexo,fecha_nacimiento=?fecha_nacimiento,tipo_documento=?tipo_documento,nro_documento=?nro_documento,observacion=?observacion,iva=?iva,foto=?foto,baja=?baja,domicilio_id=?domicilio_id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                If id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = id
                End If
                sqlParam = cmd.Parameters.Add("?cuil", MySqlDbType.VarChar, 13)
                If cuil = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cuil
                End If
                sqlParam = cmd.Parameters.Add("?apellido", MySqlDbType.VarChar, 50)
                sqlParam.Value = apellido
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 50)
                If nombre = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = nombre
                End If
                sqlParam = cmd.Parameters.Add("?estado_civil", MySqlDbType.Enum, 0)
                If estado_civil = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = estado_civil
                End If
                sqlParam = cmd.Parameters.Add("?sexo", MySqlDbType.Enum, 0)
                sqlParam.Value = sexo
                sqlParam = cmd.Parameters.Add("?fecha_nacimiento", MySqlDbType.Date, 0)
                If fecha_nacimiento = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = fecha_nacimiento
                End If
                sqlParam = cmd.Parameters.Add("?tipo_documento", MySqlDbType.Enum, 0)
                If tipo_documento = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = tipo_documento
                End If
                sqlParam = cmd.Parameters.Add("?nro_documento", MySqlDbType.Int32, 11)
                sqlParam.Value = nro_documento
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 30)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?iva", MySqlDbType.VarChar, 100)
                If iva = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = iva
                End If
                sqlParam = cmd.Parameters.Add("?foto", MySqlDbType.Byte, 0)
                If foto Is Nothing Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = foto
                End If
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Int16, 4)
                sqlParam.Value = baja
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try
            If cmd.LastInsertedId > 0 Then
                Me.id = cmd.LastInsertedId
            End If
            Return cmd.LastInsertedId
        End Using
    End Function
    Public Function Delete(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
        Dim sqlParam As New MySqlParameter
        Dim transaction As MySqlTransaction
        Using cmd As New MySqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "DELETE FROM entidad WHERE id=?id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                sqlParam.Value = id
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try
            Return True
        End Using
    End Function
#End Region
    'Public Sub StoreFillByentidad(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
    '    Using exe As New MySqlCommand
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM entidad e WHERE id=?id"

    '            .Connection = _Conexion
    '            .Parameters.AddWithValue("id", Id)
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            If Dt.Rows.Count > 0 Then
    '                Dim Fila As DataRow = Dt.Rows(0)
    '                CargarFila(Fila, Me)
    '            End If

    '            Dt.Dispose()
    '            Ta.Dispose()
    '        End With
    '    End Using
    'End Sub
End Class
