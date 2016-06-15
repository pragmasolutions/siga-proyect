Imports MySql.Data.MySqlClient
Public Class poliza
#Region "Miembros"
	Private _id As Integer
	Private _numero As Integer
	Private _aseguradora_id As Integer
	Private _movil_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Movil As movil
	Private _Aseguradora As aseguradora
	Private _lst_Cupon As List(Of cupon)
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
	Public Property numero As Integer
		Get
			Return _numero
		End Get
		Set(ByVal Value As Integer)
			_numero = Value
		End Set
	End Property
	Public Property aseguradora_id As Integer
		Get
			Return _aseguradora_id
		End Get
		Set(ByVal Value As Integer)
			_aseguradora_id = Value
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
	Public Property EstadoFila As Char
		Get
			Return _EstadoFila
		End Get
		Set(ByVal Value As Char)
			_EstadoFila = Value
		End Set
	End Property
	'Encapsulamiento de Entidades
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
    Public Property Aseguradora As aseguradora
        Get
            If Me._aseguradora Is Nothing Then
                _aseguradora = New aseguradora
                If Me._aseguradora_id > 0 Then
                    _aseguradora.FillByAseguradora(Me._aseguradora_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _aseguradora
        End Get
        Set(ByVal Value As aseguradora)
            _aseguradora = Value
        End Set
    End Property
    Public Property lst_Cupon As List(Of cupon)
        Get
            If Me._lst_Cupon Is Nothing Then
                _lst_Cupon = New List(Of cupon)
                '_lst_Cupon=cupon.FillListByPoliza(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Cupon
        End Get
        Set(ByVal Value As List(Of cupon))
            _lst_Cupon = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "p.id,p.numero,p.aseguradora_id,p.movil_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.numero=0
			.aseguradora_id=0
			.movil_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of poliza)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of poliza)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM poliza p"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Public Shared Function FillListByMovil(ByVal movil_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of poliza)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of poliza)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM poliza p" & vbCrLf
	            .CommandText &= "WHERE movil_id = ?movil_id"
	            .Parameters.AddWithValue("?movil_id", movil_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Public Shared Function FillListByAseguradora(ByVal aseguradora_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of poliza)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of poliza)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM poliza p" & vbCrLf
	            .CommandText &= "WHERE aseguradora_id = ?aseguradora_id"
	            .Parameters.AddWithValue("?aseguradora_id", aseguradora_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of poliza))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New poliza
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As poliza)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("numero") IsNot DBNull.Value Then O.numero = Fila.Item("numero") Else O.numero=0
				If Fila.Item("aseguradora_id") IsNot DBNull.Value Then O.aseguradora_id = Fila.Item("aseguradora_id") Else O.aseguradora_id=0
				If Fila.Item("movil_id") IsNot DBNull.Value Then O.movil_id = Fila.Item("movil_id") Else O.movil_id=0
	End Sub
	Public Sub FillBypoliza(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM poliza p WHERE id=?id"

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
	Public Function Clone() As poliza
		Clone = New poliza
			With Clone
				.id = Me.id
				.numero = Me.numero
				.aseguradora_id = Me.aseguradora_id
				.movil_id = Me.movil_id
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
					cmd.CommandText = "INSERT INTO poliza (numero,aseguradora_id,movil_id) VALUES (?numero,?aseguradora_id,?movil_id)"
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt32, 10)
					sqlParam.Value = numero
					sqlParam = cmd.Parameters.Add("?aseguradora_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = aseguradora_id
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
					cmd.CommandText = "UPDATE poliza SET numero=?numero,aseguradora_id=?aseguradora_id,movil_id=?movil_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt32, 10)
					sqlParam.Value = numero
					sqlParam = cmd.Parameters.Add("?aseguradora_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = aseguradora_id
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
					cmd.CommandText = "INSERT INTO poliza (id,numero,aseguradora_id,movil_id) VALUES (?id,?numero,?aseguradora_id,?movil_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE numero=?numero,aseguradora_id=?aseguradora_id,movil_id=?movil_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt32, 10)
					sqlParam.Value = numero
					sqlParam = cmd.Parameters.Add("?aseguradora_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = aseguradora_id
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
					cmd.CommandText = "DELETE FROM poliza WHERE id=?id"
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
