Imports MySql.Data.MySqlClient
Public Class reclamo
#Region "Miembros"
	Private _id As Integer
	Private _fechahora As DateTime
	Private _asunto As String
	Private _finalizo As DateTime
	Private _cliente_id As Integer
	Private _reclamo_categoria_id As Integer
	Private _pedido_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Pedido As pedido
	Private _Cliente As cliente
	Private _Reclamo_categoria As reclamo_categoria
	Private _lst_ReclamoLinea As List(Of reclamo_linea)
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
	Public Property fechahora As DateTime
		Get
			Return _fechahora
		End Get
		Set(ByVal Value As DateTime)
			_fechahora = Value
		End Set
	End Property
	Public Property asunto As String
		Get
			Return _asunto
		End Get
		Set(ByVal Value As String)
			_asunto = Value
		End Set
	End Property
	Public Property finalizo As DateTime
		Get
			Return _finalizo
		End Get
		Set(ByVal Value As DateTime)
			_finalizo = Value
		End Set
	End Property
	Public Property cliente_id As Integer
		Get
			Return _cliente_id
		End Get
		Set(ByVal Value As Integer)
			_cliente_id = Value
		End Set
	End Property
	Public Property reclamo_categoria_id As Integer
		Get
			Return _reclamo_categoria_id
		End Get
		Set(ByVal Value As Integer)
			_reclamo_categoria_id = Value
		End Set
	End Property
	Public Property pedido_id As Integer
		Get
			Return _pedido_id
		End Get
		Set(ByVal Value As Integer)
			_pedido_id = Value
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
	Public Property Pedido As pedido
		Get
			If Me._pedido Is Nothing Then
				_pedido = New pedido
				If Me._pedido_id > 0 Then 
                    _Pedido.StoreFillBypedido(Me._pedido_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _pedido
        End Get
        Set(ByVal Value As pedido)
            _pedido = Value
        End Set
    End Property
    Public Property Cliente As cliente
        Get
            If Me._cliente Is Nothing Then
                _cliente = New cliente
                If Me._cliente_id > 0 Then
                    _Cliente.StoreFillBycliente(Me._cliente_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _cliente
        End Get
        Set(ByVal Value As cliente)
            _cliente = Value
        End Set
    End Property
    Public Property Reclamo_categoria As reclamo_categoria
        Get
            If Me._reclamo_categoria Is Nothing Then
                _reclamo_categoria = New reclamo_categoria
                If Me._reclamo_categoria_id > 0 Then
                    _reclamo_categoria.FillByReclamo_categoria(Me._reclamo_categoria_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _reclamo_categoria
        End Get
        Set(ByVal Value As reclamo_categoria)
            _reclamo_categoria = Value
        End Set
    End Property
    Public Property lst_ReclamoLinea As List(Of reclamo_linea)
        Get
            If Me._lst_ReclamoLinea Is Nothing Then
                _lst_ReclamoLinea = New List(Of reclamo_linea)
                _lst_ReclamoLinea = reclamo_linea.FillListByReclamo(Me.id, ClsVariableSesion.Instancia.getConn)
            End If
            Return _lst_ReclamoLinea
        End Get
        Set(ByVal Value As List(Of reclamo_linea))
            _lst_ReclamoLinea = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "r.id,r.fechahora,r.asunto,r.finalizo,r.cliente_id,r.reclamo_categoria_id,r.pedido_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.fechahora="1900-01-01 00:00:00"
			.asunto=""
			.finalizo="1900-01-01 00:00:00"
			.cliente_id=0
			.reclamo_categoria_id=0
			.pedido_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of reclamo)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of reclamo)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM reclamo r"
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
	Public Shared Function FillListByPedido(ByVal pedido_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of reclamo)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of reclamo)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM reclamo r" & vbCrLf
	            .CommandText &= "WHERE pedido_id = ?pedido_id"
	            .Parameters.AddWithValue("?pedido_id", pedido_id)
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
	Public Shared Function FillListByCliente(ByVal cliente_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of reclamo)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of reclamo)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM reclamo r" & vbCrLf
	            .CommandText &= "WHERE cliente_id = ?cliente_id"
	            .Parameters.AddWithValue("?cliente_id", cliente_id)
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
	Public Shared Function FillListByReclamo_categoria(ByVal reclamo_categoria_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of reclamo)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of reclamo)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM reclamo r" & vbCrLf
	            .CommandText &= "WHERE reclamo_categoria_id = ?reclamo_categoria_id"
	            .Parameters.AddWithValue("?reclamo_categoria_id", reclamo_categoria_id)
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
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of reclamo))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New reclamo
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As reclamo)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("fechahora") IsNot DBNull.Value Then O.fechahora = DateTime.Parse(Fila.Item("fechahora").ToString) Else O.fechahora="1900-01-01 00:00:00"
				If Fila.Item("asunto") IsNot DBNull.Value Then O.asunto = Fila.Item("asunto") Else O.asunto=""
				If Fila.Item("finalizo") IsNot DBNull.Value Then O.finalizo = DateTime.Parse(Fila.Item("finalizo").ToString) Else O.finalizo="1900-01-01 00:00:00"
				If Fila.Item("cliente_id") IsNot DBNull.Value Then O.cliente_id = Fila.Item("cliente_id") Else O.cliente_id=0
				If Fila.Item("reclamo_categoria_id") IsNot DBNull.Value Then O.reclamo_categoria_id = Fila.Item("reclamo_categoria_id") Else O.reclamo_categoria_id=0
				If Fila.Item("pedido_id") IsNot DBNull.Value Then O.pedido_id = Fila.Item("pedido_id") Else O.pedido_id=0
	End Sub
	Public Sub FillByreclamo(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM reclamo r WHERE id=?id"

				.Connection = _Conexion
				.Parameters.AddWithValue("id", Id)
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
	Public Function Clone() As reclamo
		Clone = New reclamo
			With Clone
				.id = Me.id
				.fechahora = Me.fechahora
				.asunto = Me.asunto
				.finalizo = Me.finalizo
				.cliente_id = Me.cliente_id
				.reclamo_categoria_id = Me.reclamo_categoria_id
				.pedido_id = Me.pedido_id
				.EstadoFila = Me.EstadoFila
			End With
	End Function
    'Public Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer 
    '	Dim sqlParam As New MySqlParameter
    '	Dim transaction As MySqlTransaction
    '	Using cmd As New MySqlCommand
    '		If _Conexion Is Nothing Then
    '		        _Conexion.Open()
    '		End If
    '		If _tran Is Nothing Then
    '		        transaction = _Conexion.BeginTransaction()
    '		    Else
    '		        transaction = _tran
    '		    End If
    '		    cmd.Transaction = transaction
    '		    cmd.Connection = _Conexion
    '		    Try
    '				cmd.CommandText = "INSERT INTO reclamo (fechahora,asunto,finalizo,cliente_id,reclamo_categoria_id,pedido_id) VALUES (?fechahora,?asunto,?finalizo,?cliente_id,?reclamo_categoria_id,?pedido_id)"
    '				sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
    '				sqlParam.Value = fechahora
    '				sqlParam = cmd.Parameters.Add("?asunto", MySqlDbType.VarChar, 120)
    '				sqlParam.Value = asunto
    '				sqlParam = cmd.Parameters.Add("?finalizo", MySqlDbType.DateTime, 0)
    '				If finalizo = "1900-01-01 00:00:00" Then
    '					sqlParam.Value = DBNull.Value
    '				Else
    '					sqlParam.Value = finalizo
    '				End If
    '				sqlParam = cmd.Parameters.Add("?cliente_id", MySqlDbType.UInt32, 10)
    '				sqlParam.Value = cliente_id
    '				sqlParam = cmd.Parameters.Add("?reclamo_categoria_id", MySqlDbType.UInt24, 5)
    '				sqlParam.Value = reclamo_categoria_id
    '				sqlParam = cmd.Parameters.Add("?pedido_id", MySqlDbType.UInt32, 10)
    '				If pedido_id = 0 Then
    '					sqlParam.Value = DBNull.Value
    '				Else
    '					sqlParam.Value = pedido_id
    '				End If
    '		cmd.ExecuteNonQuery()
    '		If _tran Is Nothing Then
    '			transaction.Commit()
    '		End If
    '		Catch ex As Exception
    '		If _tran Is Nothing Then
    '			transaction.Rollback()
    '		End If
    '			Throw New Exception(ex.Message)
    '		End Try
    '		Me.id = cmd.LastInsertedId
    '		Return cmd.LastInsertedId
    '	End Using
    'End Function
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
					cmd.CommandText = "UPDATE reclamo SET fechahora=?fechahora,asunto=?asunto,finalizo=?finalizo,cliente_id=?cliente_id,reclamo_categoria_id=?reclamo_categoria_id,pedido_id=?pedido_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
					sqlParam.Value = fechahora
					sqlParam = cmd.Parameters.Add("?asunto", MySqlDbType.VarChar, 120)
					sqlParam.Value = asunto
					sqlParam = cmd.Parameters.Add("?finalizo", MySqlDbType.DateTime, 0)
					If finalizo = "1900-01-01 00:00:00" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = finalizo
					End If
					sqlParam = cmd.Parameters.Add("?cliente_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = cliente_id
					sqlParam = cmd.Parameters.Add("?reclamo_categoria_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = reclamo_categoria_id
					sqlParam = cmd.Parameters.Add("?pedido_id", MySqlDbType.UInt32, 10)
					If pedido_id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = pedido_id
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
					cmd.CommandText = "INSERT INTO reclamo (id,fechahora,asunto,finalizo,cliente_id,reclamo_categoria_id,pedido_id) VALUES (?id,?fechahora,?asunto,?finalizo,?cliente_id,?reclamo_categoria_id,?pedido_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE fechahora=?fechahora,asunto=?asunto,finalizo=?finalizo,cliente_id=?cliente_id,reclamo_categoria_id=?reclamo_categoria_id,pedido_id=?pedido_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
					sqlParam.Value = fechahora
					sqlParam = cmd.Parameters.Add("?asunto", MySqlDbType.VarChar, 120)
					sqlParam.Value = asunto
					sqlParam = cmd.Parameters.Add("?finalizo", MySqlDbType.DateTime, 0)
					If finalizo = "1900-01-01 00:00:00" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = finalizo
					End If
					sqlParam = cmd.Parameters.Add("?cliente_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = cliente_id
					sqlParam = cmd.Parameters.Add("?reclamo_categoria_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = reclamo_categoria_id
					sqlParam = cmd.Parameters.Add("?pedido_id", MySqlDbType.UInt32, 10)
					If pedido_id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = pedido_id
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
					cmd.CommandText = "DELETE FROM reclamo WHERE id=?id"
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
