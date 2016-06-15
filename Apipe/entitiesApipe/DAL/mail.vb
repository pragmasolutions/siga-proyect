Imports MySql.Data.MySqlClient
Public Class mail
#Region "Miembros"
	Private _id As Integer
    Private _direccion As String
    Private _dominio As String
    Private _contacto As String
    Private _entidad_id As Integer
    Private _EstadoFila As Char
    'Definicion de Entidades
    Private _Entidad As entidad
#End Region
#Region "Propiedades"
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal Value As String)
            _direccion = Value
        End Set
    End Property
    Public Property dominio As String
        Get
            Return _dominio
        End Get
        Set(ByVal Value As String)
            _dominio = Value
        End Set
    End Property
    Public Property contacto As String
        Get
            Return _contacto
        End Get
        Set(ByVal Value As String)
            _contacto = Value
        End Set
    End Property
    Public Property entidad_id As Integer
        Get
            Return _entidad_id
        End Get
        Set(ByVal Value As Integer)
            _entidad_id = Value
        End Set
    End Property
    Public Property EstadoFila As Char
        Get
            Return _EstadoFila
        End Get
        Set(ByVal Value As Char)
            _EstadoFila = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property Entidad As entidad
        Get
            If Me._entidad Is Nothing Then
                _entidad = New entidad
                _Entidad.StoreFillByentidad(Me._entidad_id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _entidad
        End Get
        Set(ByVal Value As entidad)
            _entidad = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "m.id,m.direccion,m.dominio,m.contacto,m.entidad_id"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .direccion = ""
            .dominio = ""
            .contacto = ""
            .entidad_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of mail)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of mail)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM mail m"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByEntidad(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of mail)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of mail)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM mail m " & vbCrLf
                .CommandText &= "WHERE entidad_id = ?entidad_id"
                .Parameters.AddWithValue("?entidad_id", entidad_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of mail))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New mail
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As mail)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("direccion") IsNot DBNull.Value Then O.direccion = Fila.Item("direccion") Else O.direccion = ""
        If Fila.Item("dominio") IsNot DBNull.Value Then O.dominio = Fila.Item("dominio") Else O.dominio = ""
        If Fila.Item("contacto") IsNot DBNull.Value Then O.contacto = Fila.Item("contacto") Else O.contacto = ""
        If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id") Else O.entidad_id = 0
    End Sub
    Public Sub FillBymail(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM mail m WHERE id=?id"
                .Connection = _Conexion
                .Parameters.AddWithValue("id", Id)
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    Dim Fila As DataRow = Dt.Rows(0)
                    CargarFila(Fila, Me)
                End If
            End With
        End Using
    End Sub
    Public Function Clone() As mail
        Clone = New mail
        With Clone
            .id = Me.id
            .direccion = Me.direccion
            .dominio = Me.dominio
            .contacto = Me.contacto
            .entidad_id = Me.entidad_id
            .EstadoFila = Me.EstadoFila
        End With
    End Function
    Public Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
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
                cmd.CommandText = "INSERT INTO mail (direccion,dominio,contacto,entidad_id) VALUES (?direccion,?dominio,?contacto,?entidad_id)"
                sqlParam = cmd.Parameters.Add("?direccion", MySqlDbType.VarChar, 100)
                If direccion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = direccion
                End If
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?dominio", MySqlDbType.VarChar, 80)
                sqlParam.Value = dominio
                sqlParam = cmd.Parameters.Add("?contacto", MySqlDbType.VarChar, 80)
                If contacto = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = contacto
                End If
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
    Public Function Update(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "UPDATE mail SET direccion=?direccion,dominio=?dominio,contacto=?contacto,entidad_id=?entidad_id WHERE id=?id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int32, 11)
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?direccion", MySqlDbType.VarChar, 100)
                If direccion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = direccion
                End If
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?dominio", MySqlDbType.VarChar, 80)
                sqlParam.Value = dominio
                sqlParam = cmd.Parameters.Add("?contacto", MySqlDbType.VarChar, 80)
                If contacto = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = contacto
                End If
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
                cmd.CommandText = "INSERT INTO mail (id,direccion,dominio,contacto,entidad_id) VALUES (?id,?direccion,?dominio,?contacto,?entidad_id)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE direccion=?direccion,entidad_id=?entidad_id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int32, 11)
                sqlParam.Value = DBNull.Value
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?direccion", MySqlDbType.VarChar, 100)
                If direccion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = direccion
                End If
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?dominio", MySqlDbType.VarChar, 80)
                sqlParam.Value = dominio
                sqlParam = cmd.Parameters.Add("?contacto", MySqlDbType.VarChar, 80)
                If contacto = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = contacto
                End If
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
                cmd.CommandText = "DELETE FROM mail WHERE id=?id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int32, 11)
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
End Class
