Imports MySql.Data.MySqlClient
Public Class chofer_movil
#Region "Miembros"
	Private _chofer_id As Integer
	Private _movil_id As Integer
	Private _inicio As Date
	Private _fin As Date
    Private _observacion As String
    Private _activo As Boolean
	Private _usuario_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Usuario As usuario
	Private _Chofer As chofer
	Private _Movil As movil
#End Region
#Region "Propiedades"
	Public Property chofer_id As Integer
		Get
			Return _chofer_id
		End Get
		Set(ByVal Value As Integer)
			_chofer_id = Value
		End Set
	End Property
	Public Property movil_id As Integer
		Get
			Return _movil_id
		End Get
		Set(ByVal Value As Integer)
			_movil_id = Value
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
	Public Property observacion As String
		Get
			Return _observacion
		End Get
		Set(ByVal Value As String)
			_observacion = Value
		End Set
    End Property
    Public Property activo As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
	Public Property usuario_id As Integer
		Get
			Return _usuario_id
		End Get
		Set(ByVal Value As Integer)
			_usuario_id = Value
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
	Public Property Usuario As usuario
		Get
			If Me._usuario Is Nothing Then
				_usuario = New usuario
				If Me._usuario_id > 0 Then 
                    _usuario.FillByUsuario(Me._usuario_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _usuario
        End Get
        Set(ByVal Value As usuario)
            _usuario = Value
        End Set
    End Property
    Public Property Chofer As chofer
        Get
            If Me._chofer Is Nothing Then
                _chofer = New chofer
                If Me._chofer_id > 0 Then
                    _chofer.FillByChofer(Me._chofer_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _chofer
        End Get
        Set(ByVal Value As chofer)
            _chofer = Value
        End Set
    End Property
    Public Property Movil As movil
        Get
            If Me._movil Is Nothing Then
                _movil = New movil
                If Me._movil_id > 0 Then
                    _movil.FillByMovil(Me._movil_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _movil
        End Get
        Set(ByVal Value As movil)
            _movil = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
            Return "c.chofer_id,c.movil_id,c.inicio,c.fin,c.observacion,c.activo,c.usuario_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.chofer_id=0
			.movil_id=0
			.inicio="1900-01-01 00:00:00"
			.fin="1900-01-01 00:00:00"
            .observacion = ""
            .activo = False
			.usuario_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of chofer_movil)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of chofer_movil)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM chofer_movil c"
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
	Public Shared Function FillListByUsuario(ByVal usuario_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of chofer_movil)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of chofer_movil)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM chofer_movil c" & vbCrLf
	            .CommandText &= "WHERE usuario_id = ?usuario_id"
	            .Parameters.AddWithValue("?usuario_id", usuario_id)
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
	Public Shared Function FillListByChofer(ByVal chofer_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of chofer_movil)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of chofer_movil)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM chofer_movil c" & vbCrLf
	            .CommandText &= "WHERE chofer_id = ?chofer_id"
	            .Parameters.AddWithValue("?chofer_id", chofer_id)
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
    
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of chofer_movil))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New chofer_movil
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
    Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As chofer_movil)
        If Fila.Item("chofer_id") IsNot DBNull.Value Then O.chofer_id = Fila.Item("chofer_id") Else O.chofer_id = 0
        If Fila.Item("movil_id") IsNot DBNull.Value Then O.movil_id = Fila.Item("movil_id") Else O.movil_id = 0
        If Fila.Item("inicio") IsNot DBNull.Value Then O.inicio = Date.Parse(Fila.Item("inicio").ToString) Else O.inicio = "1900-01-01 00:00:00"
        If Fila.Item("fin") IsNot DBNull.Value Then O.fin = Date.Parse(Fila.Item("fin").ToString) Else O.fin = "1900-01-01 00:00:00"
        If Fila.Item("observacion") IsNot DBNull.Value Then O.observacion = Fila.Item("observacion") Else O.observacion = ""
        If Fila.Item("activo") IsNot DBNull.Value Then O.activo = Fila.Item("activo") Else O.activo = ""
        If Fila.Item("usuario_id") IsNot DBNull.Value Then O.usuario_id = Fila.Item("usuario_id") Else O.usuario_id = 0
    End Sub
    Public Sub FillBychofer_movil(ByVal ChoferId As Integer, MovilID As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM chofer_movil c WHERE chofer_id=?chofer_id AND movil_id=?movil_id"

                .Connection = _Conexion
                .Parameters.AddWithValue("chofer_id", ChoferId)
                .Parameters.AddWithValue("movil_id", MovilID)
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Try

                
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    Dim Fila As DataRow = Dt.Rows(0)
                    CargarFila(Fila, Me)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Dt.Dispose()
                Ta.Dispose()
            End With
        End Using
    End Sub
    Public Function Clone() As chofer_movil
        Clone = New chofer_movil
        With Clone
            .chofer_id = Me.chofer_id
            .movil_id = Me.movil_id
            .inicio = Me.inicio
            .fin = Me.fin
            .observacion = Me.observacion
            .activo = Me.activo
            .usuario_id = Me.usuario_id
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
                cmd.CommandText = "INSERT INTO chofer_movil (chofer_id,movil_id,inicio,fin,observacion,activo,usuario_id) VALUES (?chofer_id,?movil_id,?inicio,?fin,?observacion,?activo,?usuario_id)"
                sqlParam = cmd.Parameters.Add("?chofer_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = chofer_id
                sqlParam = cmd.Parameters.Add("?movil_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = movil_id
                sqlParam = cmd.Parameters.Add("?inicio", MySqlDbType.Date, 0)
                sqlParam.Value = inicio
                sqlParam = cmd.Parameters.Add("?fin", MySqlDbType.Date, 0)
                If fin = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = fin
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
                sqlParam.Value = activo
                sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = usuario_id
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
                cmd.CommandText = "UPDATE chofer_movil SET inicio=?inicio,fin=?fin,observacion=?observacion,activo=?activo,usuario_id=?usuario_id WHERE chofer_id=?chofer_id AND movil_id=?movil_id"

                sqlParam = cmd.Parameters.Add("?chofer_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = chofer_id
                sqlParam = cmd.Parameters.Add("?movil_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = movil_id
                sqlParam = cmd.Parameters.Add("?inicio", MySqlDbType.Date, 0)
                sqlParam.Value = inicio
                sqlParam = cmd.Parameters.Add("?fin", MySqlDbType.Date, 0)
                If fin = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = fin
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
                sqlParam.Value = activo
                sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = usuario_id
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
                cmd.CommandText = "INSERT INTO chofer_movil (chofer_id,movil_id,inicio,fin,observacion,activo,usuario_id) VALUES (?chofer_id,?movil_id,?inicio,?fin,?observacion,?activo,?usuario_id)" & vbCrLf _
     & " ON DUPLICATE KEY UPDATE inicio=?inicio,fin=?fin,observacion=?observacion,activo=?activo,usuario_id=?usuario_id"
                sqlParam = cmd.Parameters.Add("?chofer_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = chofer_id
                sqlParam = cmd.Parameters.Add("?movil_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = movil_id
                sqlParam = cmd.Parameters.Add("?inicio", MySqlDbType.Date, 0)
                sqlParam.Value = inicio
                sqlParam = cmd.Parameters.Add("?fin", MySqlDbType.Date, 0)
                If fin = "1900-01-01 00:00:00" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = fin
                End If
                sqlParam = cmd.Parameters.Add("?observacion", MySqlDbType.VarChar, 250)
                If observacion = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observacion
                End If
                sqlParam = cmd.Parameters.Add("?activo", MySqlDbType.Bit, 1)
                sqlParam.Value = activo
                sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = usuario_id
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
				Me.chofer_id = cmd.LastInsertedId
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
					cmd.CommandText = "DELETE FROM chofer_movil WHERE chofer_id=?chofer_id AND movil_id=?movil_id"
					sqlParam = cmd.Parameters.Add("?chofer_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = chofer_id
					sqlParam = cmd.Parameters.Add("?movil_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = movil_id
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

    'Public Shared Function FillListByMovil(ByVal movil_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of chofer_movil)
    '    Try
    '        Using exe As New MySqlCommand
    '            Dim Lista As New List(Of chofer_movil)
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM chofer_movil c" & vbCrLf
    '                .CommandText &= "WHERE movil_id = ?movil_id"
    '                .Parameters.AddWithValue("?movil_id", movil_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Ta.Fill(Dt)
    '                CargarLista(Dt, Lista)

    '                Dt.Dispose()
    '                Ta.Dispose()
    '            End With
    '            Return Lista
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Function
#End Region
End Class
