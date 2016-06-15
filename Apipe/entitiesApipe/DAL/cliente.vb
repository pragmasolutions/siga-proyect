Imports MySql.Data.MySqlClient
Public Class cliente
    Inherits entidad
#Region "Miembros"
    Private _entidad_id As Integer
    Private _cliente_categoria_id As Integer
    Private _EstadoFila_Cliente As Char
    'Definicion de Entidades
    Private _Cliente_categoria As cliente_categoria
    Private _Entidad As entidad
    Private _lst_Reclamo As List(Of reclamo)
#End Region
#Region "Propiedades"
    Public Property entidad_id As Integer
        Get
            Return _entidad_id
        End Get
        Set(ByVal Value As Integer)
            _entidad_id = Value
        End Set
    End Property
    Public Property cliente_categoria_id As Integer
        Get
            Return _cliente_categoria_id
        End Get
        Set(ByVal Value As Integer)
            _cliente_categoria_id = Value
        End Set
    End Property
    Public Property EstadoFila_Cliente As Char
        Get
            Return _EstadoFila_Cliente
        End Get
        Set(ByVal Value As Char)
            _EstadoFila_Cliente = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property Cliente_categoria As cliente_categoria
        Get
            If Me._Cliente_categoria Is Nothing Then
                _Cliente_categoria = New cliente_categoria
                If Me._cliente_categoria_id > 0 Then
                    _Cliente_categoria.StoreFillByclientecategoria(Me._cliente_categoria_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Cliente_categoria
        End Get
        Set(ByVal Value As cliente_categoria)
            _Cliente_categoria = Value
        End Set
    End Property
    Public Property Entidad As entidad
        Get
            If Me._Entidad Is Nothing Then
                _Entidad = New entidad
                If Me._entidad_id > 0 Then
                    _Entidad.StoreFillByentidad(Me._entidad_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _Entidad
        End Get
        Set(ByVal Value As entidad)
            _Entidad = Value
        End Set
    End Property
    Public Property lst_Reclamo As List(Of reclamo)
        Get
            If Me._lst_Reclamo Is Nothing Then
                _lst_Reclamo = New List(Of reclamo)
                '_lst_Reclamo=reclamo.FillListByCliente(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Reclamo
        End Get
        Set(ByVal Value As List(Of reclamo))
            _lst_Reclamo = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "c.entidad_id,c.cliente_categoria_id"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .entidad_id = 0
            .cliente_categoria_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of cliente)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of cliente)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM cliente c"
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
    Public Shared Function FillListByCliente_categoria(ByVal cliente_categoria_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of cliente)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of cliente)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM cliente c" & vbCrLf
                .CommandText &= "WHERE cliente_categoria_id = ?cliente_categoria_id"
                .Parameters.AddWithValue("?cliente_categoria_id", cliente_categoria_id)
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
    Public Shared Function FillListByEntidad(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of cliente)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of cliente)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM cliente c" & vbCrLf
                .CommandText &= "WHERE entidad_id = ?entidad_id"
                .Parameters.AddWithValue("?entidad_id", entidad_id)
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
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of cliente))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New cliente
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As cliente)
        If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id") Else O.entidad_id = 0
        If Fila.Item("cliente_categoria_id") IsNot DBNull.Value Then O.cliente_categoria_id = Fila.Item("cliente_categoria_id") Else O.cliente_categoria_id = 0
    End Sub
    Public Sub StoreFillBycliente(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of cliente)
                With exe
                    .CommandText = "FillClienteByEntidad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?entidad", entidad_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If

                End With
                ' Return Lista
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Public Function Clone() As cliente
        Clone = New cliente
        With Clone
            .entidad_id = Me.entidad_id
            .cliente_categoria_id = Me.cliente_categoria_id
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
                cmd.CommandText = "INSERT INTO cliente (entidad_id,cliente_categoria_id) VALUES (?entidad_id,?cliente_categoria_id)"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?cliente_categoria_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = cliente_categoria_id
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
            Me.entidad_id = cmd.LastInsertedId
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
                cmd.CommandText = "UPDATE cliente SET cliente_categoria_id=?cliente_categoria_id WHERE entidad_id=?entidad_id"

                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?cliente_categoria_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = cliente_categoria_id
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
                cmd.CommandText = "INSERT INTO cliente (entidad_id,cliente_categoria_id) VALUES (?entidad_id,?cliente_categoria_id)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE cliente_categoria_id=?cliente_categoria_id"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?cliente_categoria_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = cliente_categoria_id
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
                Me.entidad_id = cmd.LastInsertedId
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
                cmd.CommandText = "DELETE FROM cliente WHERE entidad_id=?entidad_id"
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
    'Public Sub FillBycliente(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection)
    '    Using exe As New MySqlCommand
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM cliente c WHERE entidad_id=?entidad_id"
    '            .Connection = _Conexion
    '            .Parameters.AddWithValue("?entidad_id", entidad_id)
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
