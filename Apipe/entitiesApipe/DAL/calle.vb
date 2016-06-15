Imports MySql.Data.MySqlClient
Public Class calle
#Region "Miembros"
    Private _id As Integer
    Private _calle As String
    Private _voz_id As Integer
    'Private _EstadoFila As Char
    'Definicion de Entidades
    Private _lst_calle As List(Of calle)
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
    Public Property calle As String
        Get
            Return _calle
        End Get
        Set(ByVal Value As String)
            _calle = Value
        End Set
    End Property
    Public Property voz_id As Integer
        Get
            Return _voz_id
        End Get
        Set(ByVal Value As Integer)
            _voz_id = Value
        End Set
    End Property
    'Encapsulamiento de Entidades
    Public Property lst_calle As List(Of calle)
        Get
            If Me._lst_calle Is Nothing Then
                _lst_calle = New List(Of calle)
                '_lst_Provincia=provincia.FillListByPais(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_calle
        End Get
        Set(ByVal Value As List(Of calle))
            _lst_calle = Value
        End Set
    End Property
    Public Shared ReadOnly Property CAMPOS As String
        Get
            Return "p.id,p.calle,p.voz_id"
        End Get
    End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .calle = ""
            .voz_id = 0
        End With
    End Sub
    Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of calle)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of calle)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM calle p"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of calle))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New calle
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As calle)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("calle") IsNot DBNull.Value Then O.calle = Fila.Item("calle") Else O.calle = ""
        If Fila.Item("voz_id") IsNot DBNull.Value Then O.voz_id = Fila.Item("voz_id") Else O.voz_id = 0
    End Sub
    Public Sub FillByCalle(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM calle p WHERE id=?id"

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
    Public Function Clone() As calle
        Clone = New calle
        With Clone
            .id = Me.id
            .calle = Me.calle
            .voz_id = Me.voz_id
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
                cmd.CommandText = "INSERT INTO calle (calle) VALUES (?nombre)"
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 50)
                sqlParam.Value = calle
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
                cmd.CommandText = "UPDATE calle SET calle=?nombre WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 50)
                sqlParam.Value = calle
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
                cmd.CommandText = "INSERT INTO calle (id,calle) VALUES (?id,?nombre)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE calle=?nombre"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
                If id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = id
                End If
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 50)
                sqlParam.Value = calle
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
                cmd.CommandText = "DELETE FROM calle WHERE id=?id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
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
