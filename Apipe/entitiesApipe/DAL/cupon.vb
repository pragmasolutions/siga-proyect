Imports MySql.Data.MySqlClient
Public Class cupon
#Region "Miembros"
	Private _id As Integer
	Private _cuota As Integer
	Private _vencimiento As Date
	Private _importe As Decimal
	Private _pagado As Boolean
	Private _poliza_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Poliza As poliza
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
	Public Property cuota As Integer
		Get
			Return _cuota
		End Get
		Set(ByVal Value As Integer)
			_cuota = Value
		End Set
	End Property
	Public Property vencimiento As Date
		Get
			Return _vencimiento
		End Get
		Set(ByVal Value As Date)
			_vencimiento = Value
		End Set
	End Property
	Public Property importe As Decimal
		Get
			Return _importe
		End Get
		Set(ByVal Value As Decimal)
			_importe = Value
		End Set
	End Property
	Public Property pagado As Boolean
		Get
			Return _pagado
		End Get
		Set(ByVal Value As Boolean)
			_pagado = Value
		End Set
	End Property
	Public Property poliza_id As Integer
		Get
			Return _poliza_id
		End Get
		Set(ByVal Value As Integer)
			_poliza_id = Value
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
	Public Property Poliza As poliza
		Get
			If Me._poliza Is Nothing Then
				_poliza = New poliza
				If Me._poliza_id > 0 Then 
                    _poliza.FillByPoliza(Me._poliza_id, ClsVariableSesion.Instancia.getConn)
				End If
			End If
			Return _poliza
		End Get
		Set(ByVal Value As poliza)
			_poliza = Value
		End Set
	End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "c.id,c.cuota,c.vencimiento,c.importe,c.pagado,c.poliza_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.cuota=0
			.vencimiento="1900-01-01 00:00:00"
			.importe=0
			.pagado=False
			.poliza_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of cupon)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of cupon)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM cupon c"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Public Shared Function FillListByPoliza(ByVal poliza_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of cupon)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of cupon)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM cupon c" & vbCrLf
	            .CommandText &= "WHERE poliza_id = ?poliza_id"
	            .Parameters.AddWithValue("?poliza_id", poliza_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of cupon))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New cupon
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As cupon)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("cuota") IsNot DBNull.Value Then O.cuota = Fila.Item("cuota") Else O.cuota=0
				If Fila.Item("vencimiento") IsNot DBNull.Value Then O.vencimiento = Date.Parse(Fila.Item("vencimiento").ToString) Else O.vencimiento="1900-01-01 00:00:00"
				If Fila.Item("importe") IsNot DBNull.Value Then O.importe = Fila.Item("importe") Else O.importe=0
				If Fila.Item("pagado") IsNot DBNull.Value Then O.pagado = Fila.Item("pagado") Else O.pagado=False
				If Fila.Item("poliza_id") IsNot DBNull.Value Then O.poliza_id = Fila.Item("poliza_id") Else O.poliza_id=0
	End Sub
	Public Sub FillBycupon(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM cupon c WHERE id=?id"

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
	Public Function Clone() As cupon
		Clone = New cupon
			With Clone
				.id = Me.id
				.cuota = Me.cuota
				.vencimiento = Me.vencimiento
				.importe = Me.importe
				.pagado = Me.pagado
				.poliza_id = Me.poliza_id
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
					cmd.CommandText = "INSERT INTO cupon (cuota,vencimiento,importe,pagado,poliza_id) VALUES (?cuota,?vencimiento,?importe,?pagado,?poliza_id)"
					sqlParam = cmd.Parameters.Add("?cuota", MySqlDbType.UInt16, 3)
					sqlParam.Value = cuota
					sqlParam = cmd.Parameters.Add("?vencimiento", MySqlDbType.Date, 0)
					sqlParam.Value = vencimiento
					sqlParam = cmd.Parameters.Add("?importe", MySqlDbType.Decimal, 7)
					sqlParam.Value = importe
					sqlParam = cmd.Parameters.Add("?pagado", MySqlDbType.bit, 1)
					sqlParam.Value = pagado
					sqlParam = cmd.Parameters.Add("?poliza_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = poliza_id
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
					cmd.CommandText = "UPDATE cupon SET cuota=?cuota,vencimiento=?vencimiento,importe=?importe,pagado=?pagado,poliza_id=?poliza_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?cuota", MySqlDbType.UInt16, 3)
					sqlParam.Value = cuota
					sqlParam = cmd.Parameters.Add("?vencimiento", MySqlDbType.Date, 0)
					sqlParam.Value = vencimiento
					sqlParam = cmd.Parameters.Add("?importe", MySqlDbType.Decimal, 7)
					sqlParam.Value = importe
					sqlParam = cmd.Parameters.Add("?pagado", MySqlDbType.bit, 1)
					sqlParam.Value = pagado
					sqlParam = cmd.Parameters.Add("?poliza_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = poliza_id
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
					cmd.CommandText = "INSERT INTO cupon (id,cuota,vencimiento,importe,pagado,poliza_id) VALUES (?id,?cuota,?vencimiento,?importe,?pagado,?poliza_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE cuota=?cuota,vencimiento=?vencimiento,importe=?importe,pagado=?pagado,poliza_id=?poliza_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?cuota", MySqlDbType.UInt16, 3)
					sqlParam.Value = cuota
					sqlParam = cmd.Parameters.Add("?vencimiento", MySqlDbType.Date, 0)
					sqlParam.Value = vencimiento
					sqlParam = cmd.Parameters.Add("?importe", MySqlDbType.Decimal, 7)
					sqlParam.Value = importe
					sqlParam = cmd.Parameters.Add("?pagado", MySqlDbType.bit, 1)
					sqlParam.Value = pagado
					sqlParam = cmd.Parameters.Add("?poliza_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = poliza_id
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
					cmd.CommandText = "DELETE FROM cupon WHERE id=?id"
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
