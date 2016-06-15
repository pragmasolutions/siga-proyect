Imports MySql.Data.MySqlClient
Public Class agenda
#Region "Miembros"
    Private _id As Integer
    Private _cliente As String
    Private _inicio As Date
    Private _fin As Date
    Private _domicilio_id As Integer
    Private _EstadoFila As Char
    'Definicion de Entidades
    Private _Domicilio As domicilio
    Private _lst_Cita As List(Of cita)
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
    Public Property cliente As String
        Get
            Return _cliente
        End Get
        Set(ByVal Value As String)
            _cliente = Value
        End Set
    End Property
    Public Property inicio As Date
        Get
            Return _inicio
        End Get
        Set(ByVal Value As Date)
            _inicio = Value
        End Set
    End Property
    Public Property fin As Date
        Get
            Return _fin
        End Get
        Set(ByVal Value As Date)
            _fin = Value
        End Set
    End Property
    Public Property domicilio_id As Integer
        Get
            Return _domicilio_id
        End Get
        Set(ByVal Value As Integer)
            _domicilio_id = Value
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
            _domicilio = Value
        End Set
    End Property
    Public Property lst_Cita As List(Of cita)
        Get
            If Me._lst_Cita Is Nothing Then
                _lst_Cita = New List(Of cita)
                '_lst_Cita=cita.FillListByAgenda(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Cita
        End Get
        Set(ByVal Value As List(Of cita))
            _lst_Cita = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "a.id,a.cliente,a.inicio,a.fin,a.domicilio_id"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .cliente = ""
            .inicio = "1900-01-01 00:00:00"
            .fin = "1900-01-01 00:00:00"
            .domicilio_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of agenda)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of agenda)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM agenda a"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListByDomicilio(ByVal domicilio_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of agenda)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of agenda)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM agenda a" & vbCrLf
                .CommandText &= "WHERE domicilio_id = ?domicilio_id"
                .Parameters.AddWithValue("?domicilio_id", domicilio_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista

        End Using

    End Function
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of agenda))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New agenda
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As agenda)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("cliente") IsNot DBNull.Value Then O.cliente = Fila.Item("cliente") Else O.cliente = ""
        If Fila.Item("inicio") IsNot DBNull.Value Then O.inicio = Date.Parse(Fila.Item("inicio").ToString) Else O.inicio = "1900-01-01 00:00:00"
        If Fila.Item("fin") IsNot DBNull.Value Then O.fin = Date.Parse(Fila.Item("fin").ToString) Else O.fin = "1900-01-01 00:00:00"
        If Fila.Item("domicilio_id") IsNot DBNull.Value Then O.domicilio_id = Fila.Item("domicilio_id") Else O.domicilio_id = 0
    End Sub
    Public Sub FillByagenda(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM agenda a WHERE id=?id"

                .Connection = _Conexion
                .Parameters.AddWithValue("id", Id)
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    Dim Fila As DataRow = Dt.Rows(0)
                    CargarFila(Fila, Me)
                End If
                Ta.Dispose()
                Dt.Dispose()
            End With
        End Using
    End Sub
    Public Function Clone() As agenda
        Clone = New agenda
        With Clone
            .id = Me.id
            .cliente = Me.cliente
            .inicio = Me.inicio
            .fin = Me.fin
            .domicilio_id = Me.domicilio_id
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
                cmd.CommandText = "INSERT INTO agenda (cliente,inicio,fin,domicilio_id) VALUES (?cliente,?inicio,?fin,?domicilio_id)"
                sqlParam = cmd.Parameters.Add("?cliente", MySqlDbType.VarChar, 80)
                If cliente = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cliente
                End If
                sqlParam = cmd.Parameters.Add("?inicio", MySqlDbType.Date, 0)
                sqlParam.Value = inicio
                sqlParam = cmd.Parameters.Add("?fin", MySqlDbType.Date, 0)
                sqlParam.Value = fin
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
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
                cmd.CommandText = "UPDATE agenda SET cliente=?cliente,inicio=?inicio,fin=?fin,domicilio_id=?domicilio_id WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?cliente", MySqlDbType.VarChar, 80)
                If cliente = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cliente
                End If
                sqlParam = cmd.Parameters.Add("?inicio", MySqlDbType.Date, 0)
                sqlParam.Value = inicio
                sqlParam = cmd.Parameters.Add("?fin", MySqlDbType.Date, 0)
                sqlParam.Value = fin
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                _tran.Dispose()
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
                cmd.CommandText = "INSERT INTO agenda (id,cliente,inicio,fin,domicilio_id) VALUES (?id,?cliente,?inicio,?fin,?domicilio_id)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE cliente=?cliente,inicio=?inicio,fin=?fin,domicilio_id=?domicilio_id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                If id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = id
                End If
                sqlParam = cmd.Parameters.Add("?cliente", MySqlDbType.VarChar, 80)
                If cliente = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = cliente
                End If
                sqlParam = cmd.Parameters.Add("?inicio", MySqlDbType.Date, 0)
                sqlParam.Value = inicio
                sqlParam = cmd.Parameters.Add("?fin", MySqlDbType.Date, 0)
                sqlParam.Value = fin
                sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = domicilio_id
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                _tran.Dispose()
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
                cmd.CommandText = "DELETE FROM agenda WHERE id=?id"
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
End Class
