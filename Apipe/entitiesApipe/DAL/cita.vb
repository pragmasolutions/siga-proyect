Imports MySql.Data.MySqlClient
Public Class cita
#Region "Miembros"
	Private _id As Integer
	Private _dia As String
	Private _hora As String
	Private _agenda_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Agenda As agenda
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
	Public Property dia As String
		Get
			Return _dia
		End Get
		Set(ByVal Value As String)
			_dia = Value
		End Set
	End Property
	Public Property hora As String
		Get
			Return _hora
		End Get
		Set(ByVal Value As String)
			_hora = Value
		End Set
	End Property
	Public Property agenda_id As Integer
		Get
			Return _agenda_id
		End Get
		Set(ByVal Value As Integer)
			_agenda_id = Value
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
	Public Property Agenda As agenda
		Get
			If Me._agenda Is Nothing Then
				_agenda = New agenda
				If Me._agenda_id > 0 Then 
                    _agenda.FillByAgenda(Me._agenda_id, ClsVariableSesion.Instancia.getConn)
				End If
			End If
			Return _agenda
		End Get
		Set(ByVal Value As agenda)
			_agenda = Value
		End Set
	End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "c.id,c.dia,c.hora,c.agenda_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.dia=""
			.hora=""
			.agenda_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of cita)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of cita)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM cita c"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Public Shared Function FillListByAgenda(ByVal agenda_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of cita)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of cita)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM cita c" & vbCrLf
	            .CommandText &= "WHERE agenda_id = ?agenda_id"
	            .Parameters.AddWithValue("?agenda_id", agenda_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of cita))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New cita
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As cita)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("dia") IsNot DBNull.Value Then O.dia = Fila.Item("dia") Else O.dia=""
				If Fila.Item("hora") IsNot DBNull.Value Then O.hora = Fila.Item("hora") Else O.hora=""
				If Fila.Item("agenda_id") IsNot DBNull.Value Then O.agenda_id = Fila.Item("agenda_id") Else O.agenda_id=0
	End Sub
	Public Sub FillBycita(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM cita c WHERE id=?id"

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
	Public Function Clone() As cita
		Clone = New cita
			With Clone
				.id = Me.id
				.dia = Me.dia
				.hora = Me.hora
				.agenda_id = Me.agenda_id
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
					cmd.CommandText = "INSERT INTO cita (dia,hora,agenda_id) VALUES (?dia,?hora,?agenda_id)"
					sqlParam = cmd.Parameters.Add("?dia", MySqlDbType.Enum, 0)
					If dia = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = dia
					End If
					sqlParam = cmd.Parameters.Add("?hora", MySqlDbType.String, 0)
					sqlParam.Value = hora
					sqlParam = cmd.Parameters.Add("?agenda_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = agenda_id
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
					cmd.CommandText = "UPDATE cita SET dia=?dia,hora=?hora,agenda_id=?agenda_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?dia", MySqlDbType.Enum, 0)
					If dia = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = dia
					End If
					sqlParam = cmd.Parameters.Add("?hora", MySqlDbType.String, 0)
					sqlParam.Value = hora
					sqlParam = cmd.Parameters.Add("?agenda_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = agenda_id
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
					cmd.CommandText = "INSERT INTO cita (id,dia,hora,agenda_id) VALUES (?id,?dia,?hora,?agenda_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE dia=?dia,hora=?hora,agenda_id=?agenda_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?dia", MySqlDbType.Enum, 0)
					If dia = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = dia
					End If
					sqlParam = cmd.Parameters.Add("?hora", MySqlDbType.String, 0)
					sqlParam.Value = hora
					sqlParam = cmd.Parameters.Add("?agenda_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = agenda_id
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
					cmd.CommandText = "DELETE FROM cita WHERE id=?id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
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
