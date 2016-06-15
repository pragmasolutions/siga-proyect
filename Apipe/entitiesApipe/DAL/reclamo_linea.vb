Imports MySql.Data.MySqlClient
Public Class reclamo_linea
#Region "Miembros"
	Private _id As Integer
	Private _fechahora As DateTime
	Private _comentario As String
	Private _usuario_id As Integer
	Private _reclamo_id As Integer
    Private _EstadoFila As Char
    Private _operador_id As Integer
    Private _movil_id As Integer
	'Definicion de Entidades
	Private _Reclamo As reclamo
	Private _Usuario As usuario
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
	Public Property comentario As String
		Get
			Return _comentario
		End Get
		Set(ByVal Value As String)
			_comentario = Value
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
	Public Property reclamo_id As Integer
		Get
			Return _reclamo_id
		End Get
		Set(ByVal Value As Integer)
			_reclamo_id = Value
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

    Public Property operador_id As Integer
        Get
            Return _operador_id
        End Get
        Set(ByVal Value As Integer)
            _operador_id = Value
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
	'Encapsulamiento de Entidades
	Public Property Reclamo As reclamo
		Get
			If Me._reclamo Is Nothing Then
				_reclamo = New reclamo
				If Me._reclamo_id > 0 Then 
                    _reclamo.FillByReclamo(Me._reclamo_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _reclamo
        End Get
        Set(ByVal Value As reclamo)
            _reclamo = Value
        End Set
    End Property
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
	Public Shared ReadOnly Property CAMPOS As String
		Get
            Return "r.id,r.fechahora,r.comentario,r.usuario_id,r.reclamo_id,r.operador_id,r.movil_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.fechahora="1900-01-01 00:00:00"
			.comentario=""
			.usuario_id=0
            .reclamo_id = 0
            .operador_id = 0
            .movil_id = 0
		End With
	End Sub
    Public Function FillList(ByRef _Conexion As MySqlConnection) As List(Of reclamo_linea)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of reclamo_linea)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM reclamo_linea r"
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                    Dt.Dispose()
                    Ta.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception

        End Try
        
    End Function
    Public Function FillListHora(ByRef _Conexion As MySqlConnection) As List(Of reclamo_linea)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of reclamo_linea)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM reclamo_linea r WHERE TIMEDIFF (NOW(),r.fechahora)<'01:00:00'"
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                    Dt.Dispose()
                    Ta.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception
            '  MsgBox("Error al cargar reclamo FillListHora")
        End Try
        
    End Function
    Public Function StoreFillListHora(ByRef _Conexion As MySqlConnection) As List(Of reclamo_linea)
     Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of reclamo_linea)
                With exe
                    .CommandText = "FillReclamoHora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try
    End Function
    Public Function FillListHoraCount(ByRef _Conexion As MySqlConnection) As Integer
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "SELECT count(*) FROM reclamo_linea r WHERE TIMEDIFF (NOW(),r.fechahora)<'01:00:00'"
                    .Connection = _Conexion
                End With
                Return exe.ExecuteScalar
            End Using
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Shared Function StoreFillListHoraCount(ByRef _Conexion As MySqlConnection) As Integer
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of String)
                With exe
                    .CommandText = "CargarReclamosCount"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    Return exe.ExecuteScalar()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return 0
        End Try

    End Function
	Public Shared Function FillListByReclamo(ByVal reclamo_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of reclamo_linea)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of reclamo_linea)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM reclamo_linea r" & vbCrLf
                    .CommandText &= "WHERE reclamo_id = ?reclamo_id"
                    .Parameters.AddWithValue("?reclamo_id", reclamo_id)
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                    Dt.Dispose()
                    Ta.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception

        End Try
        
	End Function
	Public Shared Function FillListByUsuario(ByVal usuario_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of reclamo_linea)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of reclamo_linea)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM reclamo_linea r" & vbCrLf
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
        Catch ex As Exception

        End Try
        
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of reclamo_linea))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New reclamo_linea
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As reclamo_linea)
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
        If Fila.Item("fechahora") IsNot DBNull.Value Then O.fechahora = DateTime.Parse(Fila.Item("fechahora").ToString) Else O.fechahora = "1900-01-01 00:00:00"
        If Fila.Item("comentario") IsNot DBNull.Value Then O.comentario = Fila.Item("comentario") Else O.comentario = ""
        If Fila.Item("usuario_id") IsNot DBNull.Value Then O.usuario_id = Fila.Item("usuario_id") Else O.usuario_id = 0
        If Fila.Item("reclamo_id") IsNot DBNull.Value Then O.reclamo_id = Fila.Item("reclamo_id") Else O.reclamo_id = 0
        If Fila.Item("operador_id") IsNot DBNull.Value Then O.operador_id = Fila.Item("operador_id") Else O.operador_id = 0
        If Fila.Item("movil_id") IsNot DBNull.Value Then O.movil_id = Fila.Item("movil_id") Else O.movil_id = 0

	End Sub
	Public Sub FillByreclamo_linea(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM reclamo_linea r WHERE id=?id"

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
        Catch ex As Exception

        End Try
        
	End Sub
	Public Function Clone() As reclamo_linea
		Clone = New reclamo_linea
        With Clone
            .id = Me.id
            .fechahora = Me.fechahora
            .comentario = Me.comentario
            .usuario_id = Me.usuario_id
            .reclamo_id = Me.reclamo_id
            .EstadoFila = Me.EstadoFila
            .operador_id = Me.operador_id
            .movil_id = Me.movil_id
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
    '				cmd.CommandText = "INSERT INTO reclamo_linea (fechahora,comentario,usuario_id,reclamo_id) VALUES (?fechahora,?comentario,?usuario_id,?reclamo_id)"
    '				sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
    '				sqlParam.Value = fechahora
    '				sqlParam = cmd.Parameters.Add("?comentario", MySqlDbType.VarChar, 250)
    '				sqlParam.Value = comentario
    '				sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
    '				sqlParam.Value = usuario_id
    '				sqlParam = cmd.Parameters.Add("?reclamo_id", MySqlDbType.UInt32, 10)
    '				sqlParam.Value = reclamo_id
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
					cmd.CommandText = "UPDATE reclamo_linea SET fechahora=?fechahora,comentario=?comentario,usuario_id=?usuario_id,reclamo_id=?reclamo_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
					sqlParam.Value = fechahora
					sqlParam = cmd.Parameters.Add("?comentario", MySqlDbType.VarChar, 250)
					sqlParam.Value = comentario
					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?reclamo_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = reclamo_id
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
					cmd.CommandText = "INSERT INTO reclamo_linea (id,fechahora,comentario,usuario_id,reclamo_id) VALUES (?id,?fechahora,?comentario,?usuario_id,?reclamo_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE fechahora=?fechahora,comentario=?comentario,usuario_id=?usuario_id,reclamo_id=?reclamo_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
					sqlParam.Value = fechahora
					sqlParam = cmd.Parameters.Add("?comentario", MySqlDbType.VarChar, 250)
					sqlParam.Value = comentario
					sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = usuario_id
					sqlParam = cmd.Parameters.Add("?reclamo_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = reclamo_id
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
					cmd.CommandText = "DELETE FROM reclamo_linea WHERE id=?id"
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
