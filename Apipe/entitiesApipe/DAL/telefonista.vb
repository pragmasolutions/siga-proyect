Imports MySql.Data.MySqlClient
Public Class telefonista
#Region "Miembros"
	Private _usuario_id As Integer
	Private _interno As Integer
	Private _password As String
	Private _dominio As String
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
	Public Property interno As Integer
		Get
			Return _interno
		End Get
		Set(ByVal Value As Integer)
			_interno = Value
		End Set
	End Property
	Public Property password As String
		Get
			Return _password
		End Get
		Set(ByVal Value As String)
			_password = Value
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
			Return "t.usuario_id,t.interno,t.password,t.dominio"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.usuario_id=0
			.interno=0
			.password=""
			.dominio=""
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of telefonista)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of telefonista)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM telefonista t"
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
	Public Shared Function FillListByUsuario(ByVal usuario_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of telefonista)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of telefonista)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM telefonista t" & vbCrLf
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
    Public Sub FillBytelefonista(ByVal usuario_id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefonista t WHERE usuario_id=?usuario_id"

                .Connection = _Conexion
                .Parameters.AddWithValue("?usuario_id", usuario_id)
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
    End Sub
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of telefonista))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New telefonista
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As telefonista)
				If Fila.Item("usuario_id") IsNot DBNull.Value Then O.usuario_id = Fila.Item("usuario_id") Else O.usuario_id=0
				If Fila.Item("interno") IsNot DBNull.Value Then O.interno = Fila.Item("interno") Else O.interno=0
				If Fila.Item("password") IsNot DBNull.Value Then O.password = Fila.Item("password") Else O.password=""
				If Fila.Item("dominio") IsNot DBNull.Value Then O.dominio = Fila.Item("dominio") Else O.dominio=""
	End Sub
	
	Public Function Clone() As telefonista
		Clone = New telefonista
			With Clone
				.usuario_id = Me.usuario_id
				.interno = Me.interno
				.password = Me.password
				.dominio = Me.dominio
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
					cmd.CommandText = "INSERT INTO telefonista (usuario_id,interno,password,dominio) VALUES (?usuario_id,?interno,?password,?dominio)"
					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?interno", MySqlDbType.UInt24, 5)
					sqlParam.Value = interno
					sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 80)
					sqlParam.Value = password
					sqlParam = cmd.Parameters.Add("?dominio", MySqlDbType.VarChar, 60)
					sqlParam.Value = dominio
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
					cmd.CommandText = "UPDATE telefonista SET interno=?interno,password=?password,dominio=?dominio WHERE usuario_id=?usuario_id"

					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?interno", MySqlDbType.UInt24, 5)
					sqlParam.Value = interno
					sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 80)
					sqlParam.Value = password
					sqlParam = cmd.Parameters.Add("?dominio", MySqlDbType.VarChar, 60)
					sqlParam.Value = dominio
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
					cmd.CommandText = "INSERT INTO telefonista (usuario_id,interno,password,dominio) VALUES (?usuario_id,?interno,?password,?dominio)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE interno=?interno,password=?password,dominio=?dominio"
					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?interno", MySqlDbType.UInt24, 5)
					sqlParam.Value = interno
					sqlParam = cmd.Parameters.Add("?password", MySqlDbType.VarChar, 80)
					sqlParam.Value = password
					sqlParam = cmd.Parameters.Add("?dominio", MySqlDbType.VarChar, 60)
					sqlParam.Value = dominio
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
					cmd.CommandText = "DELETE FROM telefonista WHERE usuario_id=?usuario_id"
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
