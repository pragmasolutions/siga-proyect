Imports MySql.Data.MySqlClient
Public Class frecuencia
#Region "Miembros"
	Private _id As Integer
	Private _numero As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _lst_Movil As List(Of movil)
	Private _lst_Operador As List(Of operador)
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
	Public Property EstadoFila As Char
		Get
			Return _EstadoFila
		End Get
		Set(ByVal Value As Char)
			_EstadoFila = Value
		End Set
	End Property
	'Encapsulamiento de Entidades
	Public Property lst_Movil As List(Of movil)
		Get
			If Me._lst_Movil Is Nothing Then
				_lst_Movil = New List(Of movil)
                '_lst_Movil=movil.FillListByFrecuencia(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Movil
        End Get
        Set(ByVal Value As List(Of movil))
            _lst_Movil = Value
        End Set
    End Property
    Public Property lst_Operador As List(Of operador)
        Get
            If Me._lst_Operador Is Nothing Then
                _lst_Operador = New List(Of operador)
                '_lst_Operador=operador.FillListByFrecuencia(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Operador
        End Get
        Set(ByVal Value As List(Of operador))
            _lst_Operador = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "f.id,f.numero"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.numero=0
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of frecuencia)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of frecuencia)
			With exe
                .CommandText = "SELECT " & CAMPOS & " FROM frecuencia f"
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
    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of frecuencia))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New frecuencia
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
        End If
    End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As frecuencia)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("numero") IsNot DBNull.Value Then O.numero = Fila.Item("numero") Else O.numero=0
	End Sub
	Public Sub FillByfrecuencia(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM frecuencia f WHERE id=?id"

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
	Public Function Clone() As frecuencia
		Clone = New frecuencia
			With Clone
				.id = Me.id
				.numero = Me.numero
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
					cmd.CommandText = "INSERT INTO frecuencia (numero) VALUES (?numero)"
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt16, 3)
					sqlParam.Value = numero
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
                cmd.CommandText = "UPDATE frecuencia SET numero=?numero,EstadoFila=?EstadoFila WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
                sqlParam.Value = Id
                sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt16, 3)
                sqlParam.Value = numero
                sqlParam = cmd.Parameters.Add("?EstadoFila", MySqlDbType.String, 1)
                sqlParam.Value = EstadoFila
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
					cmd.CommandText = "INSERT INTO frecuencia (id,numero) VALUES (?id,?numero)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE numero=?numero"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.UInt16, 3)
					sqlParam.Value = numero
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
					cmd.CommandText = "DELETE FROM frecuencia WHERE id=?id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
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
