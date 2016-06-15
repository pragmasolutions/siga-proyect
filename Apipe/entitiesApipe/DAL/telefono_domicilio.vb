Imports MySql.Data.MySqlClient
Public Class telefono_domicilio
#Region "Miembros"
    Private _domicilio_id As Integer
    Private _telefono_id As Integer
    Private _prioridad As Integer
    Private _EstadoFila As Char
    Private _baja As Boolean
    'Definicion de Entidades
    Private _Telefono As telefono
    Private _Domicilio As domicilio

#End Region
#Region "Propiedades"
    Public Property domicilio_id As Integer
        Get
            Return _domicilio_id
        End Get
        Set(ByVal Value As Integer)
            _domicilio_id = Value
        End Set
    End Property
    Public Property telefono_id As Integer
        Get
            Return _telefono_id
        End Get
        Set(ByVal Value As Integer)
            _telefono_id = Value
        End Set
    End Property
    Public Property prioridad As Integer
        Get
            Return _prioridad
        End Get
        Set(ByVal Value As Integer)
            _prioridad = Value
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
    Public Property baja As Boolean
        Get
            Return _baja
        End Get
        Set(ByVal Value As Boolean)
            _baja = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property Telefono As telefono
        Get
            If Me._telefono Is Nothing Then
                _telefono = New telefono
                If Me._telefono_id > 0 Then
                    _Telefono.StoreFillBytelefono(Me._telefono_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _telefono
        End Get
        Set(ByVal Value As telefono)
            _telefono = Value
        End Set
    End Property
    Public Property Domicilio As domicilio
        Get
            If Me._domicilio Is Nothing Then
                _domicilio = New domicilio
                If Me._domicilio_id > 0 Then
                    _domicilio.FillByDomicilio(Me._domicilio_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _domicilio
        End Get
        Set(ByVal Value As domicilio)
            _Domicilio = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "t.domicilio_id,t.telefono_id,t.prioridad,t.baja"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .domicilio_id = 0
            .telefono_id = 0
            .prioridad = 0
            .Baja = True
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of telefono_domicilio)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of telefono_domicilio)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefono_domicilio t"
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
    Public Shared Function FillListByTelefono(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of telefono_domicilio)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of telefono_domicilio)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefono_domicilio t" & vbCrLf
                .CommandText &= "WHERE telefono_id = ?telefono_id"
                .Parameters.AddWithValue("?telefono_id", telefono_id)
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
    Public Shared Function FillListByDomicilio(ByVal domicilio_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of telefono_domicilio)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of telefono_domicilio)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefono_domicilio t" & vbCrLf
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
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of telefono_domicilio))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New telefono_domicilio
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As telefono_domicilio)
        If Fila.Item("domicilio_id") IsNot DBNull.Value Then O.domicilio_id = Fila.Item("domicilio_id") Else O.domicilio_id = 0
        If Fila.Item("telefono_id") IsNot DBNull.Value Then O.telefono_id = Fila.Item("telefono_id") Else O.telefono_id = 0
        If Fila.Item("prioridad") IsNot DBNull.Value Then O.prioridad = Fila.Item("prioridad") Else O.prioridad = 0
        If Fila.Item("baja") IsNot DBNull.Value Then O.Baja = Fila.Item("baja") Else O.Baja = ""

    End Sub
    Public Sub FillBytelefono_domicilio(ByVal DomId As Integer, TelID As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM telefono_domicilio t WHERE domicilio_id=?domicilio_id AND telefono_id=?telefono_id"

                    .Connection = _Conexion
                    .Parameters.AddWithValue("domicilio_id", DomId)
                    .Parameters.AddWithValue("telefono_id", TelID)
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If
                    Dt.Dispose()
                    Ta.Dispose()
                End With
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Function Clone() As telefono_domicilio
        Clone = New telefono_domicilio
        With Clone
            .domicilio_id = Me.domicilio_id
            .telefono_id = Me.telefono_id
            .prioridad = Me.prioridad
            .EstadoFila = Me.EstadoFila
            .Baja = Me.Baja
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
                cmd.CommandText = "INSERT INTO telefono_domicilio (domicilio_id,telefono_id,prioridad,baja) VALUES (?domicilio_id,?telefono_id,?prioridad,?baja)"
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = telefono_id
                sqlParam = cmd.Parameters.Add("?prioridad", MySqlDbType.UInt24, 5)
                sqlParam.Value = prioridad
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Bit, 1)
                sqlParam.Value = Baja
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
                cmd.CommandText = "UPDATE telefono_domicilio SET prioridad=?prioridad WHERE domicilio_id=?domicilio_id AND telefono_id=?telefono_id"

                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = telefono_id
                sqlParam = cmd.Parameters.Add("?prioridad", MySqlDbType.UInt24, 5)
                sqlParam.Value = prioridad
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Bit, 1)
                sqlParam.Value = Baja
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
                cmd.CommandText = "INSERT INTO telefono_domicilio (domicilio_id,telefono_id,prioridad,baja) VALUES (?domicilio_id,?telefono_id,?prioridad,?baja)" & vbCrLf _
              & " ON DUPLICATE KEY UPDATE prioridad=?prioridad"
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = telefono_id
                sqlParam = cmd.Parameters.Add("?prioridad", MySqlDbType.UInt24, 5)
                sqlParam.Value = prioridad
                sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Bit, 1)
                sqlParam.Value = Baja
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
                Me.domicilio_id = cmd.LastInsertedId
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
                cmd.CommandText = "DELETE FROM telefono_domicilio WHERE domicilio_id=?domicilio_id AND telefono_id=?telefono_id"
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = telefono_id
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
