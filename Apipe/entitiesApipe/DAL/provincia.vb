Imports MySql.Data.MySqlClient
Public Class provincia
#Region "Miembros"
	Private _id As Integer
	Private _nombre As String
	Private _pais_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Pais As pais
	Private _lst_Localidad As List(Of localidad)
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
	Public Property pais_id As Integer
		Get
			Return _pais_id
		End Get
		Set(ByVal Value As Integer)
			_pais_id = Value
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
	Public Property Pais As pais
		Get
			If Me._pais Is Nothing Then
				_pais = New pais
				If Me._pais_id > 0 Then 
                    _pais.FillByPais(Me._pais_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _pais
        End Get
        Set(ByVal Value As pais)
            _pais = Value
        End Set
    End Property
    Public Property lst_Localidad As List(Of localidad)
        Get
            If Me._lst_Localidad Is Nothing Then
                _lst_Localidad = New List(Of localidad)
                '_lst_Localidad=localidad.FillListByProvincia(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Localidad
        End Get
        Set(ByVal Value As List(Of localidad))
            _lst_Localidad = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "p.id,p.nombre,p.pais_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.nombre=""
			.pais_id=0
		End With
	End Sub
    Public Overloads Shared Function StoreFillList(ByRef _Conexion As MySqlConnection) As List(Of provincia)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of provincia)
                With exe
                    .CommandText = "FillProvincia"
                    .CommandType = CommandType.StoredProcedure
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
	Public Shared Function FillListByPais(ByVal pais_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of provincia)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of provincia)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM provincia p" & vbCrLf
	            .CommandText &= "WHERE pais_id = ?pais_id"
	            .Parameters.AddWithValue("?pais_id", pais_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of provincia))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New provincia
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As provincia)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("nombre") IsNot DBNull.Value Then O.nombre = Fila.Item("nombre") Else O.nombre=""
				If Fila.Item("pais_id") IsNot DBNull.Value Then O.pais_id = Fila.Item("pais_id") Else O.pais_id=0
	End Sub
    Public Sub StoreFillByprovincia(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                'Dim Lista As New List(Of entidad)
                With exe
                    .CommandText = "FillProvinciaByProvincia"
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
        '	With exe
        '		.CommandText = "SELECT " & CAMPOS & " FROM provincia p WHERE id=?id"

        '		.Connection = _Conexion
        '		.Parameters.AddWithValue("id", Id)
        '		Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '		Ta.Fill(Dt)
        '	If Dt.Rows.Count > 0 Then
        '		Dim Fila As DataRow = Dt.Rows(0)
        '		CargarFila(Fila, Me)
        '	End If
        '	 End With
        'End Using
    End Sub
	Public Function Clone() As provincia
		Clone = New provincia
			With Clone
				.id = Me.id
				.nombre = Me.nombre
				.pais_id = Me.pais_id
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
					cmd.CommandText = "INSERT INTO provincia (nombre,pais_id) VALUES (?nombre,?pais_id)"
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 22)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?pais_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = pais_id
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
					cmd.CommandText = "UPDATE provincia SET nombre=?nombre,pais_id=?pais_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 22)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?pais_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = pais_id
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
					cmd.CommandText = "INSERT INTO provincia (id,nombre,pais_id) VALUES (?id,?nombre,?pais_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE nombre=?nombre,pais_id=?pais_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 22)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?pais_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = pais_id
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
					cmd.CommandText = "DELETE FROM provincia WHERE id=?id"
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
    'Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of provincia)
    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of provincia)
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM provincia p"
    '            .Connection = _Conexion
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            CargarLista(Dt, Lista)
    '        End With
    '        Return Lista
    '    End Using
    'End Function
End Class
