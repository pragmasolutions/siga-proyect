Imports MySql.Data.MySqlClient
Public Class aseguradora
#Region "Miembros"
	Private _entidad_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Entidad As entidad
	Private _lst_Poliza As List(Of poliza)
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
    Public Property lst_Poliza As List(Of poliza)
        Get
            If Me._lst_Poliza Is Nothing Then
                _lst_Poliza = New List(Of poliza)
                '_lst_Poliza=poliza.FillListByAseguradora(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Poliza
        End Get
        Set(ByVal Value As List(Of poliza))
            _lst_Poliza = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "a.entidad_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.entidad_id=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of aseguradora)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of aseguradora)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM aseguradora a"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Public Shared Function FillListByEntidad(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of aseguradora)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of aseguradora)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM aseguradora a" & vbCrLf
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
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of aseguradora))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New aseguradora
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As aseguradora)
				If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id") Else O.entidad_id=0
	End Sub
	Public Sub FillByaseguradora(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM aseguradora a WHERE entidad_id=?entidad_id"

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
	Public Function Clone() As aseguradora
		Clone = New aseguradora
			With Clone
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
					cmd.CommandText = "INSERT INTO aseguradora (entidad_id) VALUES (?entidad_id)"
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
					cmd.CommandText = "UPDATE aseguradora SET WHERE entidad_id=?entidad_id"

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
					cmd.CommandText = "INSERT INTO aseguradora (entidad_id) VALUES (?entidad_id)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE"
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
					cmd.CommandText = "DELETE FROM aseguradora WHERE entidad_id=?entidad_id"
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
