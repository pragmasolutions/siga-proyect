Imports MySql.Data.MySqlClient
Public Class telefono
#Region "Miembros"
	Private _id As Integer
	Private _tipo As String
	Private _cod_area As String
	Private _numero As String
	Private _horario_manana As String
	Private _horario_tarde As String
	Private _observaciones As String
	Private _entidad_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Entidad As entidad
	Private _lst_TelefonoDomicilio As List(Of telefono_domicilio)
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
	Public Property tipo As String
		Get
			Return _tipo
		End Get
		Set(ByVal Value As String)
			_tipo = Value
		End Set
	End Property
	Public Property cod_area As String
		Get
			Return _cod_area
		End Get
		Set(ByVal Value As String)
			_cod_area = Value
		End Set
	End Property
	Public Property numero As String
		Get
			Return _numero
		End Get
		Set(ByVal Value As String)
			_numero = Value
		End Set
	End Property
	Public Property horario_manana As String
		Get
			Return _horario_manana
		End Get
		Set(ByVal Value As String)
			_horario_manana = Value
		End Set
	End Property
	Public Property horario_tarde As String
		Get
			Return _horario_tarde
		End Get
		Set(ByVal Value As String)
			_horario_tarde = Value
		End Set
	End Property
	Public Property observaciones As String
		Get
			Return _observaciones
		End Get
		Set(ByVal Value As String)
			_observaciones = Value
		End Set
	End Property
	Public Property entidad_id As Integer
		Get
			Return _entidad_id
		End Get
		Set(ByVal Value As Integer)
			_entidad_id = Value
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
    Public Property lst_TelefonoDomicilio As List(Of telefono_domicilio)
        Get
            If Me._lst_TelefonoDomicilio Is Nothing Then
                _lst_TelefonoDomicilio = New List(Of telefono_domicilio)
                '_lst_TelefonoDomicilio=telefono_domicilio.FillListByTelefono(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_TelefonoDomicilio
        End Get
        Set(ByVal Value As List(Of telefono_domicilio))
            _lst_TelefonoDomicilio = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "t.id,t.tipo,t.cod_area,t.numero,t.horario_manana,t.horario_tarde,t.observaciones,t.entidad_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.tipo=""
			.cod_area=""
			.numero=""
			.horario_manana=""
			.horario_tarde=""
			.observaciones=""
			.entidad_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of telefono)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of telefono)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM telefono t"
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
    Public Shared Function StoreFillListByEntidad(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of telefono)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of telefono)
                With exe
                    .CommandText = "FillTelefonoByEntidad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?entidad", entidad_id)
                    .Connection = _Conexion
                    ' Lista = exe.ExecuteScalar
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)
                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        'Using exe As New MySqlCommand
        '    Dim Lista As New List(Of telefono)
        '    With exe
        '        .CommandText = "SELECT " & CAMPOS & " FROM telefono t" & vbCrLf
        '        .CommandText &= "WHERE entidad_id = ?entidad_id"
        '        .Parameters.AddWithValue("?entidad_id", entidad_id)
        '        .Connection = _Conexion
        '        Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '        Ta.Fill(Dt)
        '        CargarLista(Dt, Lista)

        '        Dt.Dispose()
        '        Ta.Dispose()
        '    End With
        '    Return Lista
        'End Using
    End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of telefono))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New telefono
				CargarFila(Fila, O)
                Lista.Add(O)

			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As telefono)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("tipo") IsNot DBNull.Value Then O.tipo = Fila.Item("tipo") Else O.tipo=""
				If Fila.Item("cod_area") IsNot DBNull.Value Then O.cod_area = Fila.Item("cod_area") Else O.cod_area=""
				If Fila.Item("numero") IsNot DBNull.Value Then O.numero = Fila.Item("numero") Else O.numero=""
				If Fila.Item("horario_manana") IsNot DBNull.Value Then O.horario_manana = Fila.Item("horario_manana") Else O.horario_manana=""
				If Fila.Item("horario_tarde") IsNot DBNull.Value Then O.horario_tarde = Fila.Item("horario_tarde") Else O.horario_tarde=""
				If Fila.Item("observaciones") IsNot DBNull.Value Then O.observaciones = Fila.Item("observaciones") Else O.observaciones=""
				If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id") Else O.entidad_id=0
	End Sub
    Public Sub StoreFillBytelefono(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                ' Dim Lista As New List(Of telefono)
                With exe
                    .CommandText = "FillTelefonoById"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?id", Id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If

                End With
                ' Return Lista
            End Using
        Catch ex As Exception
        End Try

      End Sub
    Public Sub FillByNumero(ByVal numero As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefono t WHERE numero=?numero"

                .Connection = _Conexion
                .Parameters.AddWithValue("numero", numero)
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
    Public Function Clone() As telefono
        Clone = New telefono
        With Clone
            .id = Me.id
            .tipo = Me.tipo
            .cod_area = Me.cod_area
            .numero = Me.numero
            .horario_manana = Me.horario_manana
            .horario_tarde = Me.horario_tarde
            .observaciones = Me.observaciones
            .entidad_id = Me.entidad_id
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
					cmd.CommandText = "INSERT INTO telefono (tipo,cod_area,numero,horario_manana,horario_tarde,observaciones,entidad_id) VALUES (?tipo,?cod_area,?numero,?horario_manana,?horario_tarde,?observaciones,?entidad_id)"
					sqlParam = cmd.Parameters.Add("?tipo", MySqlDbType.Enum, 0)
					sqlParam.Value = tipo
					sqlParam = cmd.Parameters.Add("?cod_area", MySqlDbType.VarChar, 10)
					If cod_area = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = cod_area
					End If
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.VarChar, 20)
					sqlParam.Value = numero
					sqlParam = cmd.Parameters.Add("?horario_manana", MySqlDbType.VarChar, 40)
					If horario_manana = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = horario_manana
					End If
					sqlParam = cmd.Parameters.Add("?horario_tarde", MySqlDbType.VarChar, 40)
					If horario_tarde = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = horario_tarde
					End If
					sqlParam = cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar, 100)
					If observaciones = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = observaciones
					End If
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
					cmd.CommandText = "UPDATE telefono SET tipo=?tipo,cod_area=?cod_area,numero=?numero,horario_manana=?horario_manana,horario_tarde=?horario_tarde,observaciones=?observaciones,entidad_id=?entidad_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?tipo", MySqlDbType.Enum, 0)
					sqlParam.Value = tipo
					sqlParam = cmd.Parameters.Add("?cod_area", MySqlDbType.VarChar, 10)
					If cod_area = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = cod_area
					End If
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.VarChar, 20)
					sqlParam.Value = numero
					sqlParam = cmd.Parameters.Add("?horario_manana", MySqlDbType.VarChar, 40)
					If horario_manana = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = horario_manana
					End If
					sqlParam = cmd.Parameters.Add("?horario_tarde", MySqlDbType.VarChar, 40)
					If horario_tarde = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = horario_tarde
					End If
					sqlParam = cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar, 100)
					If observaciones = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = observaciones
					End If
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
					cmd.CommandText = "INSERT INTO telefono (id,tipo,cod_area,numero,horario_manana,horario_tarde,observaciones,entidad_id) VALUES (?id,?tipo,?cod_area,?numero,?horario_manana,?horario_tarde,?observaciones,?entidad_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE tipo=?tipo,cod_area=?cod_area,numero=?numero,horario_manana=?horario_manana,horario_tarde=?horario_tarde,observaciones=?observaciones,entidad_id=?entidad_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?tipo", MySqlDbType.Enum, 0)
					sqlParam.Value = tipo
					sqlParam = cmd.Parameters.Add("?cod_area", MySqlDbType.VarChar, 10)
					If cod_area = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = cod_area
					End If
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.VarChar, 20)
					sqlParam.Value = numero
					sqlParam = cmd.Parameters.Add("?horario_manana", MySqlDbType.VarChar, 40)
					If horario_manana = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = horario_manana
					End If
					sqlParam = cmd.Parameters.Add("?horario_tarde", MySqlDbType.VarChar, 40)
					If horario_tarde = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = horario_tarde
					End If
					sqlParam = cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar, 100)
					If observaciones = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = observaciones
					End If
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
					cmd.CommandText = "DELETE FROM telefono WHERE id=?id"
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
    'Public Sub FillBytelefono(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
    '    Try
    '        Using exe As New MySqlCommand
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM telefono t WHERE id=?id"

    '                .Connection = _Conexion
    '                .Parameters.AddWithValue("id", Id)
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Ta.Fill(Dt)
    '                If Dt.Rows.Count > 0 Then
    '                    Dim Fila As DataRow = Dt.Rows(0)
    '                    CargarFila(Fila, Me)
    '                End If

    '                Dt.Dispose()
    '                Ta.Dispose()
    '            End With
    '        End Using
    '    Catch ex As Exception

    '    End Try

    'End Sub
End Class
