﻿Imports MySql.Data.MySqlClient
Public Class formulario
#Region "Miembros"
	Private _id As Integer
	Private _nombre_form As String
	Private _detalle As String
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _lst_FormularioRol As List(Of formulario_rol)
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
	Public Property nombre_form As String
		Get
			Return _nombre_form
		End Get
		Set(ByVal Value As String)
			_nombre_form = Value
		End Set
	End Property
	Public Property detalle As String
		Get
			Return _detalle
		End Get
		Set(ByVal Value As String)
			_detalle = Value
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
                '_lst_FormularioRol=formulario_rol.FillListByFormulario(Me.id, ClsVariableSesion.Instancia.getConn) 
			End If
			Return _lst_FormularioRol
		End Get
		Set(ByVal Value As List(Of formulario_rol))
			_lst_FormularioRol = Value
		End Set
	End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "f.id,f.nombre_form,f.detalle"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.id=0
			.nombre_form=""
			.detalle=""
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of formulario)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of formulario)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM formulario f"
				.Connection = _Conexion
				Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
				Ta.Fill(Dt)
				CargarLista(Dt, Lista)
			 End With
			 Return Lista
		End Using
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of formulario))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New formulario
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As formulario)
				If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id=0
				If Fila.Item("nombre_form") IsNot DBNull.Value Then O.nombre_form = Fila.Item("nombre_form") Else O.nombre_form=""
				If Fila.Item("detalle") IsNot DBNull.Value Then O.detalle = Fila.Item("detalle") Else O.detalle=""
	End Sub
	Public Sub FillByformulario(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM formulario f WHERE id=?id"

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
	Public Function Clone() As formulario
		Clone = New formulario
			With Clone
				.id = Me.id
				.nombre_form = Me.nombre_form
				.detalle = Me.detalle
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
					cmd.CommandText = "INSERT INTO formulario (nombre_form,detalle) VALUES (?nombre_form,?detalle)"
					sqlParam = cmd.Parameters.Add("?nombre_form", MySqlDbType.VarChar, 30)
					sqlParam.Value = nombre_form
					sqlParam = cmd.Parameters.Add("?detalle", MySqlDbType.VarChar, 150)
					sqlParam.Value = detalle
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
					cmd.CommandText = "UPDATE formulario SET nombre_form=?nombre_form,detalle=?detalle WHERE id=?id"

					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int24, 6)
					sqlParam.Value = id
					sqlParam = cmd.Parameters.Add("?nombre_form", MySqlDbType.VarChar, 30)
					sqlParam.Value = nombre_form
					sqlParam = cmd.Parameters.Add("?detalle", MySqlDbType.VarChar, 150)
					sqlParam.Value = detalle
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
					cmd.CommandText = "INSERT INTO formulario (id,nombre_form,detalle) VALUES (?id,?nombre_form,?detalle)" & vbCrLf _
					& " ON DUPLICATE KEY UPDATE nombre_form=?nombre_form,detalle=?detalle"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int24, 6)
					If id = 0 Then
						sqlParam.Value = DBNull.Value
					Else
						sqlParam.Value = id
					End If
					sqlParam = cmd.Parameters.Add("?nombre_form", MySqlDbType.VarChar, 30)
					sqlParam.Value = nombre_form
					sqlParam = cmd.Parameters.Add("?detalle", MySqlDbType.VarChar, 150)
					sqlParam.Value = detalle
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
					cmd.CommandText = "DELETE FROM formulario WHERE id=?id"
					sqlParam = cmd.Parameters.Add("?id", MySqlDbType.Int24, 6)
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
