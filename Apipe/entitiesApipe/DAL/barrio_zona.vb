Imports MySql.Data.MySqlClient
Public Class barrio_zona
#Region "Miembros"
    Private _barrio_id As Integer
    Private _zona_id As Integer
    Private _EstadoFila As Char
    'Definicion de Entidades
    Private _Zona As zona
    Private _Barrio As barrio
#End Region
#Region "Propiedades"
    Public Property barrio_id As Integer
        Get
            Return _barrio_id
        End Get
        Set(ByVal Value As Integer)
            _barrio_id = Value
        End Set
    End Property
    Public Property zona_id As Integer
        Get
            Return _zona_id
        End Get
        Set(ByVal Value As Integer)
            _zona_id = Value
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
    Public Property Zona As zona
        Get
            If Me._zona Is Nothing Then
                _zona = New zona
                If Me._zona_id > 0 Then
                    _zona.FillByZona(Me._zona_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _zona
        End Get
        Set(ByVal Value As zona)
            _zona = Value
        End Set
    End Property
    Public Property Barrio As barrio
        Get
            If Me._barrio Is Nothing Then
                _barrio = New barrio
                If Me._barrio_id > 0 Then
                    _Barrio.StoreFillBybarrio(Me._barrio_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _barrio
        End Get
        Set(ByVal Value As barrio)
            _barrio = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "b.barrio_id,b.zona_id"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .barrio_id = 0
            .zona_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of barrio_zona)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of barrio_zona)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM barrio_zona b"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByZona(ByVal zona_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of barrio_zona)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of barrio_zona)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM barrio_zona b" & vbCrLf
                .CommandText &= "WHERE zona_id = ?zona_id"
                .Parameters.AddWithValue("?zona_id", zona_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByBarrio(ByVal barrio_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of barrio_zona)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of barrio_zona)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM barrio_zona b" & vbCrLf
                .CommandText &= "WHERE barrio_id = ?barrio_id"
                .Parameters.AddWithValue("?barrio_id", barrio_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of barrio_zona))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New barrio_zona
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As barrio_zona)
        If Fila.Item("barrio_id") IsNot DBNull.Value Then O.barrio_id = Fila.Item("barrio_id") Else O.barrio_id = 0
        If Fila.Item("zona_id") IsNot DBNull.Value Then O.zona_id = Fila.Item("zona_id") Else O.zona_id = 0
    End Sub
    Public Sub FillBybarrio_zona(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM barrio_zona b WHERE barrio_id=?barrio_id AND zona_id=?zona_id"

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
    Public Function Clone() As barrio_zona
        Clone = New barrio_zona
        With Clone
            .barrio_id = Me.barrio_id
            .zona_id = Me.zona_id
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
                cmd.CommandText = "INSERT INTO barrio_zona (barrio_id,zona_id) VALUES (?barrio_id,?zona_id)"
                sqlParam = cmd.Parameters.Add("?barrio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = barrio_id
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
                cmd.CommandText = "UPDATE barrio_zona SET WHERE barrio_id=?barrio_id AND zona_id=?zona_id"

                sqlParam = cmd.Parameters.Add("?barrio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = barrio_id
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
                cmd.CommandText = "INSERT INTO barrio_zona (barrio_id,zona_id) VALUES (?barrio_id,?zona_id)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE"
                sqlParam = cmd.Parameters.Add("?barrio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = barrio_id
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
                Me.barrio_id = cmd.LastInsertedId
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
                cmd.CommandText = "DELETE FROM barrio_zona WHERE barrio_id=?barrio_id AND zona_id=?zona_id"
                sqlParam = cmd.Parameters.Add("?barrio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = barrio_id
                sqlParam = cmd.Parameters.Add("?zona_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = zona_id
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
