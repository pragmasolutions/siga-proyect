Imports MySql.Data.MySqlClient
Public Class session
#Region "Miembros"
	Private _usuario_id As Integer
	Private _ip As String
	Private _ttl As String
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Usuario As usuario
#End Region
#Region "Propiedades"
	Public Property usuario_id As Integer
		Get
			Return _usuario_id
		End Get
		Set(ByVal Value As Integer)
			_usuario_id = Value
		End Set
	End Property
	Public Property ip As String
		Get
			Return _ip
		End Get
		Set(ByVal Value As String)
			_ip = Value
		End Set
	End Property
	Public Property ttl As String
		Get
			Return _ttl
		End Get
		Set(ByVal Value As String)
			_ttl = Value
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
                    _Usuario.FillByusuario(Me._usuario_id, ClsVariableSesion.Instancia.getConn)
				End If
			End If
			Return _usuario
		End Get
		Set(ByVal Value As usuario)
			_usuario = Value
		End Set
	End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "s.usuario_id,s.ip,s.ttl"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.usuario_id=0
			.ip=""
			.ttl=""
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of session)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of session)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM session s"
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
	Public Shared Function FillListByUsuario(ByVal usuario_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of session)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of session)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM session s" & vbCrLf
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
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of session))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New session
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As session)
				If Fila.Item("usuario_id") IsNot DBNull.Value Then O.usuario_id = Fila.Item("usuario_id") Else O.usuario_id=0
				If Fila.Item("ip") IsNot DBNull.Value Then O.ip = Fila.Item("ip") Else O.ip=""
				If Fila.Item("ttl") IsNot DBNull.Value Then O.ttl = Fila.Item("ttl") Else O.ttl=""
	End Sub
	Public Sub FillBysession(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM session s WHERE usuario_id=?usuario_id"

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
	Public Function Clone() As session
		Clone = New session
			With Clone
				.usuario_id = Me.usuario_id
				.ip = Me.ip
				.ttl = Me.ttl
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
                cmd.CommandText = "INSERT INTO session (usuario_id,ip) VALUES (?usuario_id,?ip)"
					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?ip", MySqlDbType.VarChar, 15)
					sqlParam.Value = ip
					
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
			Me.usuario_id = cmd.LastInsertedId
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
                cmd.CommandText = "UPDATE session SET ip=?ip WHERE usuario_id=?usuario_id"

					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?ip", MySqlDbType.VarChar, 15)
					sqlParam.Value = ip
					sqlParam = cmd.Parameters.Add("?ttl", MySqlDbType.String, 0)
					sqlParam.Value = ttl
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
                cmd.CommandText = "INSERT INTO session (usuario_id,ip) VALUES (?usuario_id,?ip)" & vbCrLf _
                                & " ON DUPLICATE KEY UPDATE ip=?ip"
					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?ip", MySqlDbType.VarChar, 15)
					sqlParam.Value = ip
					
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
				Me.usuario_id = cmd.LastInsertedId
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
					cmd.CommandText = "DELETE FROM session WHERE usuario_id=?usuario_id"
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
#End Region
End Class
