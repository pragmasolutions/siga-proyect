Imports MySql.Data.MySqlClient
Public Class operador
#Region "Miembros"
	Private _entidad_id As Integer
	Private _frecuencia_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Frecuencia As frecuencia
	Private _Entidad As entidad
	Private _lst_Pedido As List(Of pedido)
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
	Public Property frecuencia_id As Integer
		Get
			Return _frecuencia_id
		End Get
		Set(ByVal Value As Integer)
			_frecuencia_id = Value
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
	Public Property Frecuencia As frecuencia
		Get
			If Me._frecuencia Is Nothing Then
				_frecuencia = New frecuencia
				If Me._frecuencia_id > 0 Then 
                    _frecuencia.FillByFrecuencia(Me._frecuencia_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _frecuencia
        End Get
        Set(ByVal Value As frecuencia)
            _frecuencia = Value
        End Set
    End Property
    Public Property Entidad As entidad
        Get
            If Me._entidad Is Nothing Then
                _entidad = New entidad
                If Me._entidad_id > 0 Then
                    _Entidad.StoreFillByentidad(Me._entidad_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _entidad
        End Get
        Set(ByVal Value As entidad)
            _entidad = Value
        End Set
    End Property
    Public Property lst_Pedido As List(Of pedido)
        Get
            If Me._lst_Pedido Is Nothing Then
                _lst_Pedido = New List(Of pedido)
                '_lst_Pedido=pedido.FillListByOperador(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Pedido
        End Get
        Set(ByVal Value As List(Of pedido))
            _lst_Pedido = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "o.entidad_id,o.frecuencia_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.entidad_id=0
			.frecuencia_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of operador)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of operador)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM operador o"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Public Shared Function FillListByFrecuencia(ByVal frecuencia_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of operador)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of operador)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM operador o" & vbCrLf
	            .CommandText &= "WHERE frecuencia_id = ?frecuencia_id"
	            .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Public Shared Function FillListByEntidad(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of operador)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of operador)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM operador o" & vbCrLf
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
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of operador))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New operador
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As operador)
				If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id") Else O.entidad_id=0
				If Fila.Item("frecuencia_id") IsNot DBNull.Value Then O.frecuencia_id = Fila.Item("frecuencia_id") Else O.frecuencia_id=0
	End Sub
	Public Sub FillByoperador(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM operador o WHERE entidad_id=?entidad_id"

				.Connection = _Conexion
                .Parameters.AddWithValue("?entidad_id", Id)
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
			If Dt.Rows.Count > 0 Then
				Dim Fila As DataRow = Dt.Rows(0)
				CargarFila(Fila, Me)
			End If
			 End With
		End Using
	End Sub
	Public Function Clone() As operador
		Clone = New operador
			With Clone
				.entidad_id = Me.entidad_id
				.frecuencia_id = Me.frecuencia_id
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
					cmd.CommandText = "INSERT INTO operador (entidad_id,frecuencia_id) VALUES (?entidad_id,?frecuencia_id)"
					sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = entidad_id
					sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt16, 3)
					If frecuencia_id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = frecuencia_id
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
					cmd.CommandText = "UPDATE operador SET frecuencia_id=?frecuencia_id WHERE entidad_id=?entidad_id"

					sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = entidad_id
					sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt16, 3)
					If frecuencia_id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = frecuencia_id
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
					cmd.CommandText = "INSERT INTO operador (entidad_id,frecuencia_id) VALUES (?entidad_id,?frecuencia_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE frecuencia_id=?frecuencia_id"
					sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = entidad_id
					sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt16, 3)
					If frecuencia_id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = frecuencia_id
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
					cmd.CommandText = "DELETE FROM operador WHERE entidad_id=?entidad_id"
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
End Class
