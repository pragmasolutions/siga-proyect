﻿Imports MySql.Data.MySqlClient
Public Class rol
#Region "Miembros"
	Private _id As Integer
	Private _nombre As String
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _lst_FormularioRol As List(Of formulario_rol)
	Private _lst_UsuarioRol As List(Of usuario_rol)
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
	Public Property EstadoFila As Char
		Get
			Return _EstadoFila
		End Get
		Set(ByVal Value As Char)
			_EstadoFila = Value
		End Set
	End Property
	'Encapsulamiento de Entidades
	Public Property lst_FormularioRol As List(Of formulario_rol)
		Get
			If Me._lst_FormularioRol Is Nothing Then
				_lst_FormularioRol = New List(Of formulario_rol)
                '_lst_FormularioRol=formulario_rol.FillListByRol(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_FormularioRol
        End Get
        Set(ByVal Value As List(Of formulario_rol))
            _lst_FormularioRol = Value
        End Set
    End Property
    Public Property lst_UsuarioRol As List(Of usuario_rol)
        Get
            If Me._lst_UsuarioRol Is Nothing Then
                _lst_UsuarioRol = New List(Of usuario_rol)
                '_lst_UsuarioRol=usuario_rol.FillListByRol(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_UsuarioRol
        End Get
        Set(ByVal Value As List(Of usuario_rol))
            _lst_UsuarioRol = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "r.id,r.nombre"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.nombre=""
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of rol)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of rol)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM rol r"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of rol))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New rol
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As rol)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("nombre") IsNot DBNull.Value Then O.nombre = Fila.Item("nombre") Else O.nombre=""
	End Sub
	Public Sub FillByrol(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM rol r WHERE id=?id"

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
	Public Function Clone() As rol
		Clone = New rol
			With Clone
				.id = Me.id
				.nombre = Me.nombre
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
					cmd.CommandText = "INSERT INTO rol (nombre) VALUES (?nombre)"
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 60)
					If nombre = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = nombre
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
					cmd.CommandText = "UPDATE rol SET nombre=?nombre WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 60)
					If nombre = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = nombre
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
					cmd.CommandText = "INSERT INTO rol (id,nombre) VALUES (?id,?nombre)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE nombre=?nombre"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt24, 5)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 60)
					If nombre = "" Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = nombre
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
					cmd.CommandText = "DELETE FROM rol WHERE id=?id"
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
End Class
