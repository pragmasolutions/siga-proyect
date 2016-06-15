Imports MySql.Data.MySqlClient
Public Class formulario_rol
#Region "Miembros"
	Private _formulario_id As Integer
	Private _rol_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Rol As rol
	Private _Formulario As formulario
#End Region
#Region "Propiedades"
	Public Property formulario_id As Integer
		Get
			Return _formulario_id
		End Get
		Set(ByVal Value As Integer)
			_formulario_id = Value
		End Set
	End Property
	Public Property rol_id As Integer
		Get
			Return _rol_id
		End Get
		Set(ByVal Value As Integer)
			_rol_id = Value
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
	Public Property Rol As rol
		Get
			If Me._rol Is Nothing Then
				_rol = New rol
				If Me._rol_id > 0 Then 
                    _rol.FillByRol(Me._rol_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _rol
        End Get
        Set(ByVal Value As rol)
            _rol = Value
        End Set
    End Property
    Public Property Formulario As formulario
        Get
            If Me._formulario Is Nothing Then
                _formulario = New formulario
                If Me._formulario_id > 0 Then
                    _formulario.FillByFormulario(Me._formulario_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _formulario
        End Get
        Set(ByVal Value As formulario)
            _formulario = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "f.formulario_id,f.rol_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.formulario_id=0
			.rol_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of formulario_rol)
        Try

        
        Using exe As New MySqlCommand
            Dim Lista As New List(Of formulario_rol)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM formulario_rol f"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Function
	Public Shared Function FillListByRol(ByVal rol_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of formulario_rol)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of formulario_rol)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM formulario_rol f" & vbCrLf
	            .CommandText &= "WHERE rol_id = ?rol_id"
	            .Parameters.AddWithValue("?rol_id", rol_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Public Shared Function FillListByFormulario(ByVal formulario_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of formulario_rol)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of formulario_rol)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM formulario_rol f" & vbCrLf
	            .CommandText &= "WHERE formulario_id = ?formulario_id"
	            .Parameters.AddWithValue("?formulario_id", formulario_id)
	            .Connection = _Conexion
	            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
	            Ta.Fill(Dt)
	            CargarLista(Dt, Lista)
	        End With
	        Return Lista
	    End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of formulario_rol))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New formulario_rol
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As formulario_rol)
				If Fila.Item("formulario_id") IsNot DBNull.Value Then O.formulario_id = Fila.Item("formulario_id") Else O.formulario_id=0
				If Fila.Item("rol_id") IsNot DBNull.Value Then O.rol_id = Fila.Item("rol_id") Else O.rol_id=0
	End Sub
	Public Sub FillByformulario_rol(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM formulario_rol f WHERE formulario_id=?formulario_id AND rol_id=?rol_id"

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
	Public Function Clone() As formulario_rol
		Clone = New formulario_rol
			With Clone
				.formulario_id = Me.formulario_id
				.rol_id = Me.rol_id
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
					cmd.CommandText = "INSERT INTO formulario_rol (formulario_id,rol_id) VALUES (?formulario_id,?rol_id)"
					sqlParam = cmd.Parameters.Add("?formulario_id", MySqlDbType.Int24, 6)
					sqlParam.Value = formulario_id
					sqlParam = cmd.Parameters.Add("?rol_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = rol_id
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
					cmd.CommandText = "UPDATE formulario_rol SET WHERE formulario_id=?formulario_id AND rol_id=?rol_id"

					sqlParam = cmd.Parameters.Add("?formulario_id", MySqlDbType.Int24, 6)
					sqlParam.Value = formulario_id
					sqlParam = cmd.Parameters.Add("?rol_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = rol_id
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
					cmd.CommandText = "INSERT INTO formulario_rol (formulario_id,rol_id) VALUES (?formulario_id,?rol_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE"
					sqlParam = cmd.Parameters.Add("?formulario_id", MySqlDbType.Int24, 6)
					sqlParam.Value = formulario_id
					sqlParam = cmd.Parameters.Add("?rol_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = rol_id
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
				Me.formulario_id = cmd.LastInsertedId
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
					cmd.CommandText = "DELETE FROM formulario_rol WHERE formulario_id=?formulario_id AND rol_id=?rol_id"
					sqlParam = cmd.Parameters.Add("?formulario_id", MySqlDbType.Int24, 6)
					sqlParam.Value = formulario_id
					sqlParam = cmd.Parameters.Add("?rol_id", MySqlDbType.UInt24, 5)
					sqlParam.Value = rol_id
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
