Imports MySql.Data.MySqlClient
Public Class cliente_categoria
#Region "Miembros"
	Private _id As Integer
	Private _categoria As String
	Private _descripcion As String
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _lst_Cliente As List(Of cliente)
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
	Public Property categoria As String
		Get
			Return _categoria
		End Get
		Set(ByVal Value As String)
			_categoria = Value
		End Set
	End Property
	Public Property descripcion As String
		Get
			Return _descripcion
		End Get
		Set(ByVal Value As String)
			_descripcion = Value
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
	Public Property lst_Cliente As List(Of cliente)
		Get
			If Me._lst_Cliente Is Nothing Then
				_lst_Cliente = New List(Of cliente)
                '_lst_Cliente=cliente.FillListByCliente_categoria(Me.id, ClsVariableSesion.Instancia.getConn) 
			End If
			Return _lst_Cliente
		End Get
		Set(ByVal Value As List(Of cliente))
			_lst_Cliente = Value
		End Set
	End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "c.id,c.categoria,c.descripcion"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.categoria=""
			.descripcion=""
		End With
	End Sub
    Public Overloads Shared Function StoreFillList(ByRef _Conexion As MySqlConnection) As List(Of cliente_categoria)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of cliente_categoria)
                With exe
                    .CommandText = "FillClienteCategoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)
                    End With
                Return Lista
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


        'Using exe As New MySqlCommand
        '    Dim Lista As New List(Of cliente_categoria)
        '    With exe
        '        .CommandText = "SELECT " & CAMPOS & " FROM cliente_categoria c"
        '        .Connection = _Conexion
        '        Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '        Ta.Fill(Dt)
        '        CargarLista(Dt, Lista)
        '    End With
        '    Return Lista
        'End Using
    End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of cliente_categoria))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New cliente_categoria
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As cliente_categoria)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("categoria") IsNot DBNull.Value Then O.categoria = Fila.Item("categoria") Else O.categoria=""
				If Fila.Item("descripcion") IsNot DBNull.Value Then O.descripcion = Fila.Item("descripcion") Else O.descripcion=""
	End Sub
    Public Sub StoreFillByclientecategoria(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of cliente_categoria)
                With exe
                    .CommandText = "FillClienteCategoriaById"
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
    End Sub
	Public Function Clone() As cliente_categoria
		Clone = New cliente_categoria
			With Clone
				.id = Me.id
				.categoria = Me.categoria
				.descripcion = Me.descripcion
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
					cmd.CommandText = "INSERT INTO cliente_categoria (categoria,descripcion) VALUES (?categoria,?descripcion)"
					sqlParam = cmd.Parameters.Add("?categoria", MySqlDbType.VarChar, 50)
					sqlParam.Value = categoria
					sqlParam = cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar, 50)
					sqlParam.Value = descripcion
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
					cmd.CommandText = "UPDATE cliente_categoria SET categoria=?categoria,descripcion=?descripcion WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?categoria", MySqlDbType.VarChar, 50)
					sqlParam.Value = categoria
					sqlParam = cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar, 50)
					sqlParam.Value = descripcion
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
					cmd.CommandText = "INSERT INTO cliente_categoria (id,categoria,descripcion) VALUES (?id,?categoria,?descripcion)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE categoria=?categoria,descripcion=?descripcion"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?categoria", MySqlDbType.VarChar, 50)
					sqlParam.Value = categoria
					sqlParam = cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar, 50)
					sqlParam.Value = descripcion
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
					cmd.CommandText = "DELETE FROM cliente_categoria WHERE id=?id"
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
    'Public Sub FillBycliente_categoria(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
    '    Using exe As New MySqlCommand
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM cliente_categoria c WHERE id=?id"

    '            .Connection = _Conexion
    '            .Parameters.AddWithValue("id", Id)
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            If Dt.Rows.Count > 0 Then
    '                Dim Fila As DataRow = Dt.Rows(0)
    '                CargarFila(Fila, Me)
    '            End If
    '        End With
    '    End Using
    'End Sub
End Class
