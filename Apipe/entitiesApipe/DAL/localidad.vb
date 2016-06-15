Imports MySql.Data.MySqlClient
Public Class localidad
#Region "Miembros"
	Private _id As Integer
	Private _nombre As String
	Private _cp As Integer
	Private _provincia_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Provincia As provincia
	Private _lst_Barrio As List(Of barrio)
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
	Public Property nombre As String
		Get
			Return _nombre
		End Get
		Set(ByVal Value As String)
			_nombre = Value
		End Set
	End Property
	Public Property cp As Integer
		Get
			Return _cp
		End Get
		Set(ByVal Value As Integer)
			_cp = Value
		End Set
	End Property
	Public Property provincia_id As Integer
		Get
			Return _provincia_id
		End Get
		Set(ByVal Value As Integer)
			_provincia_id = Value
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
	Public Property Provincia As provincia
		Get
			If Me._provincia Is Nothing Then
				_provincia = New provincia
				If Me._provincia_id > 0 Then 
                    _Provincia.StoreFillByprovincia(Me._provincia_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _provincia
        End Get
        Set(ByVal Value As provincia)
            _provincia = Value
        End Set
    End Property
    Public Property lst_Barrio As List(Of barrio)
        Get
            If Me._lst_Barrio Is Nothing Then
                _lst_Barrio = New List(Of barrio)
                '_lst_Barrio=barrio.FillListByLocalidad(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Barrio
        End Get
        Set(ByVal Value As List(Of barrio))
            _lst_Barrio = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "l.id,l.nombre,l.cp,l.provincia_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.nombre=""
			.cp=0
			.provincia_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of localidad)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of localidad)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM localidad l"
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
    Public Shared Function StoreFillListByProvincia(ByVal provincia_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of localidad)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of localidad)
                With exe
                    .CommandText = "FillLocalidadByProvincia"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?provincia", provincia_id)
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

        End Try
    End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of localidad))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New localidad
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As localidad)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("nombre") IsNot DBNull.Value Then O.nombre = Fila.Item("nombre") Else O.nombre=""
				If Fila.Item("cp") IsNot DBNull.Value Then O.cp = Fila.Item("cp") Else O.cp=0
				If Fila.Item("provincia_id") IsNot DBNull.Value Then O.provincia_id = Fila.Item("provincia_id") Else O.provincia_id=0
	End Sub
    Public Sub StoreFillBylocalidad(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)

        Try
            Using exe As New MySqlCommand
                'Dim Lista As New List(Of entidad)
                With exe
                    .CommandText = "FillLocalidadByLocalidad"
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
            End Using
        Catch ex As Exception
        End Try

        'Using exe As New MySqlCommand
        '    With exe
        '        .CommandText = "SELECT " & CAMPOS & " FROM localidad l WHERE id=?id"

        '        .Connection = _Conexion
        '        .Parameters.AddWithValue("id", Id)
        '        Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '        Ta.Fill(Dt)
        '        If Dt.Rows.Count > 0 Then
        '            Dim Fila As DataRow = Dt.Rows(0)
        '            CargarFila(Fila, Me)
        '        End If

        '        Dt.Dispose()
        '        Ta.Dispose()
        '    End With
        'End Using
    End Sub
	Public Function Clone() As localidad
		Clone = New localidad
			With Clone
				.id = Me.id
				.nombre = Me.nombre
				.cp = Me.cp
				.provincia_id = Me.provincia_id
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
					cmd.CommandText = "INSERT INTO localidad (nombre,cp,provincia_id) VALUES (?nombre,?cp,?provincia_id)"
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 36)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?cp", MySqlDbType.Int24, 6)
					sqlParam.Value = cp
					sqlParam = cmd.Parameters.Add("?provincia_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = provincia_id
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
					cmd.CommandText = "UPDATE localidad SET nombre=?nombre,cp=?cp,provincia_id=?provincia_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 36)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?cp", MySqlDbType.Int24, 6)
					sqlParam.Value = cp
					sqlParam = cmd.Parameters.Add("?provincia_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = provincia_id
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
					cmd.CommandText = "INSERT INTO localidad (id,nombre,cp,provincia_id) VALUES (?id,?nombre,?cp,?provincia_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE nombre=?nombre,cp=?cp,provincia_id=?provincia_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 36)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?cp", MySqlDbType.Int24, 6)
					sqlParam.Value = cp
					sqlParam = cmd.Parameters.Add("?provincia_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = provincia_id
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
					cmd.CommandText = "DELETE FROM localidad WHERE id=?id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
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
    'Public Shared Function FillListByProvincia(ByVal provincia_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of localidad)
    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of localidad)
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM localidad l" & vbCrLf
    '            .CommandText &= "WHERE provincia_id = ?provincia_id"
    '            .Parameters.AddWithValue("?provincia_id", provincia_id)
    '            .Connection = _Conexion
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            CargarLista(Dt, Lista)

    '            Dt.Dispose()
    '            Ta.Dispose()
    '        End With
    '        Return Lista
    '    End Using
    'End Function
End Class
