Imports MySql.Data.MySqlClient
Public Class usuario
#Region "Miembros"
    Private _activo As Boolean
    Private _entidad_id As Integer
    Private _usuario As String
    Private _password As String
    Private _EstadoFila_usuario As Char
    'Definicion de Entidades
    Private _Entidad As entidad
    Private _lst_Cliente As List(Of cliente)
    ' Private _lst_Log As List(Of Log)
    Private _lst_UsuarioRol As List(Of usuario_rol)
    Private _lst_UsuarioSucursal As List(Of usuario_sucursal)
#End Region
#Region "Propiedades"
    Public Overloads Property entidad_id As Integer
        Get
            Return _entidad_id
        End Get
        Set(ByVal Value As Integer)
            _entidad_id = Value
        End Set
    End Property
    Public Property usuario As String
        Get
            Return _usuario
        End Get
        Set(ByVal Value As String)
            _usuario = Value
        End Set
    End Property
    Public Property password As String
        Get
            Return _password.ToLower
        End Get
        Set(ByVal Value As String)
            _password = Value.ToLower
        End Set
    End Property
    Public Property EstadoFila_usuario As Char
        Get
            Return _EstadoFila_usuario
        End Get
        Set(ByVal Value As Char)
            _EstadoFila_usuario = Value
        End Set
    End Property
    Public Property activo As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal Value As Boolean)
            _activo = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property Entidad As entidad
        Get
            If Me._Entidad Is Nothing Then
                _Entidad = New entidad
                _Entidad.StoreFillByentidad(Me._entidad_id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _Entidad
        End Get
        Set(ByVal Value As entidad)
            _Entidad = Value
        End Set
    End Property
    Public Property lst_UsuarioRol As List(Of usuario_rol)
        Get
            If Me._lst_UsuarioRol Is Nothing Then
                _lst_UsuarioRol = New List(Of usuario_rol)
                _lst_UsuarioRol = (From ur As usuario_rol In ClsEnumerados.Instancia.Usuario_Roles Where ur.usuario_id = Me.entidad_id).ToList
            End If
            Return _lst_UsuarioRol
        End Get
        Set(ByVal Value As List(Of usuario_rol))
            _lst_UsuarioRol = Value
        End Set
    End Property
    Public Property lst_UsuarioSucursal As List(Of usuario_sucursal)
        Get
            If Me._lst_UsuarioSucursal Is Nothing Then
                _lst_UsuarioSucursal = New List(Of usuario_sucursal)
                _lst_UsuarioSucursal = usuario_sucursal.FillListByUsuario(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _lst_UsuarioSucursal
        End Get
        Set(ByVal Value As List(Of usuario_sucursal))
            _lst_UsuarioSucursal = Value
        End Set
    End Property
    Public Overloads Shared ReadOnly Property CAMPOS As String
        Get
            Return Entidad.CAMPOS & ",u.entidad_id,u.usuario,u.password,u.activo"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .entidad_id = 0
            .usuario = ""
            .password = ""
            .activo = True
        End With
    End Sub
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of usuario))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New usuario
                O.CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Public Overloads Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
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
            Dim ie As IEntidad
            ie = Me.Entidad 'No cambiar esto
            If Me.entidad_id = 0 Then
                Me.entidad_id = ie.Insert(_Conexion, _tran)
                Me.id = entidad_id
            Else
                ie.Update(_Conexion, _tran)
            End If
            Try
                cmd.CommandText = "INSERT INTO usuario (entidad_id,usuario,password,activo) VALUES (?entidad_id,?usuario,?password,?activo)" & vbCrLf
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?usuario", MySqlDbType.VarChar, 16)
                sqlParam.Value = usuario
                sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 50)
                sqlParam.Value = password
                sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
                sqlParam.Value = activo
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
            Return Me.entidad_id
        End Using
    End Function
    Public Overloads Function InsertUpdate(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
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
            Dim ie As IEntidad
            ie = Me.Entidad
            If Me.entidad_id = 0 Then
                Me.entidad_id = ie.Insert(_Conexion, _tran)
                Me.id = entidad_id
            Else
                ie.Update(_Conexion, _tran)
            End If
            Try
                'cmd.CommandText = "UPDATE usuario SET usuario=?usuario,password=?password,activo=?activo WHERE entidad_id=?entidad_id"
                cmd.CommandText = "INSERT INTO usuario (entidad_id,usuario,password,activo) VALUES (?entidad_id,?usuario,?password,?activo)" & vbCrLf _
              & " ON DUPLICATE KEY UPDATE usuario=?usuario,password=?password,activo=?activo"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?usuario", MySqlDbType.VarChar, 16)
                sqlParam.Value = usuario
                sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 50)
                sqlParam.Value = password
                sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
                sqlParam.Value = activo
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
            Return Me.entidad_id
        End Using
    End Function
    Public Overloads Function Update(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
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
            Dim ie As IEntidad
            ie = Me.Entidad
            ie.Update(_Conexion, _tran)
            Try
                cmd.CommandText = "UPDATE usuario SET usuario=?usuario,password=?password,activo=?activo WHERE entidad_id=?entidad_id"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?usuario", MySqlDbType.VarChar, 16)
                sqlParam.Value = usuario
                sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 50)
                sqlParam.Value = password
                sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
                sqlParam.Value = activo
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
    'Public Overloads Function InsertUpdate(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
    '    Dim sqlParam As New MySqlParameter
    '    Dim transaction As MySqlTransaction
    '    Using cmd As New MySqlCommand
    '        If _Conexion Is Nothing Then
    '            _Conexion.Open()
    '        End If
    '        If _tran Is Nothing Then
    '            transaction = _Conexion.BeginTransaction()
    '        Else
    '            transaction = _tran
    '        End If
    '        cmd.Transaction = transaction
    '        cmd.Connection = _Conexion
    '        Try
    '            cmd.CommandText = "INSERT INTO usuario (entidad_id,usuario,password,activo) VALUES (?entidad_id,?usuario,?password,?activo)" & vbCrLf _
    '            & " ON DUPLICATE KEY UPDATE usuario=?usuario,password=?password,activo=?activo"
    '            sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
    '            sqlParam.Value = entidad_id
    '            sqlParam = cmd.Parameters.Add("?usuario", MySqlDbType.VarChar, 16)
    '            sqlParam.Value = usuario
    '            sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 50)
    '            sqlParam.Value = password
    '            sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
    '            sqlParam.Value = activo
    '            cmd.ExecuteNonQuery()
    '            If _tran Is Nothing Then
    '                transaction.Commit()
    '            End If
    '        Catch ex As Exception
    '            If _tran Is Nothing Then
    '                transaction.Rollback()
    '            End If
    '            Throw New Exception(ex.Message)
    '        End Try
    '        Me.id = cmd.LastInsertedId
    '        Return cmd.LastInsertedId
    '    End Using
    'End Function
    Public Overloads Function Delete(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "DELETE FROM usuario WHERE entidad_id=?entidad_id"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
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
End Class
