Imports MySql.Data.MySqlClient
Public Class zona
#Region "Miembros"
	Private _id As Integer
	Private _nombre As String
	Private _zona_padre_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Zona As zona
	Private _lst_BarrioZona As List(Of barrio_zona)
	Private _lst_Movil As List(Of movil)
	Private _lst_Zona As List(Of zona)
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
	Public Property zona_padre_id As Integer
		Get
			Return _zona_padre_id
		End Get
		Set(ByVal Value As Integer)
			_zona_padre_id = Value
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
	Public Property Zona As zona
		Get
			If Me._zona Is Nothing Then
				_zona = New zona
				If Me._zona_padre_id > 0 Then 
                    _zona.FillByZona(Me._zona_padre_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _zona
        End Get
        Set(ByVal Value As zona)
            _zona = Value
        End Set
    End Property
    Public Property lst_BarrioZona As List(Of barrio_zona)
        Get
            If Me._lst_BarrioZona Is Nothing Then
                _lst_BarrioZona = New List(Of barrio_zona)
                '_lst_BarrioZona=barrio_zona.FillListByZona(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_BarrioZona
        End Get
        Set(ByVal Value As List(Of barrio_zona))
            _lst_BarrioZona = Value
        End Set
    End Property
    Public Property lst_Movil As List(Of movil)
        Get
            If Me._lst_Movil Is Nothing Then
                _lst_Movil = New List(Of movil)
                '_lst_Movil=movil.FillListByZona(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Movil
        End Get
        Set(ByVal Value As List(Of movil))
            _lst_Movil = Value
        End Set
    End Property
    Public Property lst_Zona As List(Of zona)
        Get
            If Me._lst_Zona Is Nothing Then
                _lst_Zona = New List(Of zona)
                '_lst_Zona=zona.FillListByZona(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Zona
        End Get
        Set(ByVal Value As List(Of zona))
            _lst_Zona = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "z.id,z.nombre,z.zona_padre_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.nombre=""
			.zona_padre_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of zona)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of zona)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM zona z"
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
    Public Shared Function FillListByZonaPadre(ByVal zona_padre_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of zona)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of zona)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM zona z" & vbCrLf
                .CommandText &= "WHERE zona_padre_id = ?zona_padre_id"
                .Parameters.AddWithValue("?zona_padre_id", zona_padre_id)
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
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of zona))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New zona
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As zona)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("nombre") IsNot DBNull.Value Then O.nombre = Fila.Item("nombre") Else O.nombre=""
				If Fila.Item("zona_padre_id") IsNot DBNull.Value Then O.zona_padre_id = Fila.Item("zona_padre_id") Else O.zona_padre_id=0
	End Sub
	Public Sub FillByzona(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM zona z WHERE id=?id"

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
	Public Function Clone() As zona
		Clone = New zona
			With Clone
				.id = Me.id
				.nombre = Me.nombre
				.zona_padre_id = Me.zona_padre_id
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
					cmd.CommandText = "INSERT INTO zona (nombre,zona_padre_id) VALUES (?nombre,?zona_padre_id)"
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 80)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?zona_padre_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = zona_padre_id
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
					cmd.CommandText = "UPDATE zona SET nombre=?nombre,zona_padre_id=?zona_padre_id WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 80)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?zona_padre_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = zona_padre_id
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
					cmd.CommandText = "INSERT INTO zona (id,nombre,zona_padre_id) VALUES (?id,?nombre,?zona_padre_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE nombre=?nombre,zona_padre_id=?zona_padre_id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 80)
					sqlParam.Value = nombre
					sqlParam = cmd.Parameters.Add("?zona_padre_id", MySqlDbType.UInt32, 10)
					sqlParam.Value = zona_padre_id
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
					cmd.CommandText = "DELETE FROM zona WHERE id=?id"
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
