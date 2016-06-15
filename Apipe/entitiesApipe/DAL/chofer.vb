Imports MySql.Data.MySqlClient
Public Class chofer
#Region "Miembros"
	Private _entidad_id As Integer
    Private _turno As String
    Private _factura As Boolean
	Private _carnet_vencimiento As Date
	Private _transporte_vencimiento As Date
	Private _observaciones As String
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Entidad As entidad
	Private _lst_ChoferMovil As List(Of chofer_movil)
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
	Public Property turno As String
		Get
			Return _turno
		End Get
		Set(ByVal Value As String)
			_turno = Value
		End Set
    End Property
    Public Property factura As Boolean
        Get
            Return _factura
        End Get
        Set(ByVal value As Boolean)
            _factura = value
        End Set
    End Property
	Public Property carnet_vencimiento As Date
		Get
			Return _carnet_vencimiento
		End Get
		Set(ByVal Value As Date)
			_carnet_vencimiento = Value
		End Set
	End Property
	Public Property transporte_vencimiento As Date
		Get
			Return _transporte_vencimiento
		End Get
		Set(ByVal Value As Date)
			_transporte_vencimiento = Value
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
    Public Property lst_ChoferMovil As List(Of chofer_movil)
        Get
            If Me._lst_ChoferMovil Is Nothing Then
                _lst_ChoferMovil = New List(Of chofer_movil)
                '_lst_ChoferMovil=chofer_movil.FillListByChofer(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_ChoferMovil
        End Get
        Set(ByVal Value As List(Of chofer_movil))
            _lst_ChoferMovil = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
            Return "c.entidad_id,c.turno,c.factura,c.carnet_vencimiento,c.transporte_vencimiento,c.observaciones"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
	Public Sub New()
		With Me
			.entidad_id=0
            .turno = ""
            .factura = False
			.carnet_vencimiento="1900-01-01 00:00:00"
			.transporte_vencimiento="1900-01-01 00:00:00"
			.observaciones=""
		End With
	End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of chofer)
		Using exe As New MySqlCommand
			Dim Lista As New List(Of chofer)
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM chofer c"
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
	Public Shared Function FillListByEntidad(ByVal entidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of chofer)
	    Using exe As New MySqlCommand
	        Dim Lista As New List(Of chofer)
	        With exe
	            .CommandText = "SELECT " & CAMPOS & " FROM chofer c" & vbCrLf
	            .CommandText &= "WHERE entidad_id = ?entidad_id"
	            .Parameters.AddWithValue("?entidad_id", entidad_id)
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
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of chofer))
		If Dt.Rows.Count > 0 Then
			For Each Fila As DataRow In Dt.Rows
				Dim O As New chofer
				CargarFila(Fila, O)
				Lista.Add(O)
			Next
		End If
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As chofer)
        If Fila.Item("entidad_id") IsNot DBNull.Value Then O.entidad_id = Fila.Item("entidad_id") Else O.entidad_id = 0
        If Fila.Item("turno") IsNot DBNull.Value Then O.turno = Fila.Item("turno") Else O.turno = ""
        If Fila.Item("factura") IsNot DBNull.Value Then O.factura = Fila.Item("factura") Else O.factura = False
        If Fila.Item("carnet_vencimiento") IsNot DBNull.Value Then O.carnet_vencimiento = Date.Parse(Fila.Item("carnet_vencimiento").ToString) Else O.carnet_vencimiento = "1900-01-01 00:00:00"
        If Fila.Item("transporte_vencimiento") IsNot DBNull.Value Then O.transporte_vencimiento = Date.Parse(Fila.Item("transporte_vencimiento").ToString) Else O.transporte_vencimiento = "1900-01-01 00:00:00"
        If Fila.Item("observaciones") IsNot DBNull.Value Then O.observaciones = Fila.Item("observaciones") Else O.observaciones = ""
	End Sub
	Public Sub FillBychofer(ByVal Id As Integer, ByRef _Conexion As MySqlConnection) 
		Using exe As New MySqlCommand
			With exe
				.CommandText = "SELECT " & CAMPOS & " FROM chofer c WHERE entidad_id=?entidad_id"

				.Connection = _Conexion
                .Parameters.AddWithValue("?entidad_id", Id)
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
	Public Function Clone() As chofer
		Clone = New chofer
        With Clone
            .entidad_id = Me.entidad_id
            .turno = Me.turno
            .factura = Me.factura
            .carnet_vencimiento = Me.carnet_vencimiento
            .transporte_vencimiento = Me.transporte_vencimiento
            .observaciones = Me.observaciones
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

                cmd.CommandText = "INSERT INTO chofer (entidad_id,turno,factura,carnet_vencimiento,transporte_vencimiento,observaciones) VALUES (?entidad_id,?turno,?factura,?carnet_vencimiento,?transporte_vencimiento,?observaciones)"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?turno", MySqlDbType.Enum, 0)
                sqlParam.Value = turno
                sqlParam = cmd.Parameters.Add("?factura", MySqlDbType.Bit, 1)
                sqlParam.Value = factura
                sqlParam = cmd.Parameters.Add("?carnet_vencimiento", MySqlDbType.Date, 0)
                sqlParam.Value = carnet_vencimiento
                sqlParam = cmd.Parameters.Add("?transporte_vencimiento", MySqlDbType.Date, 0)
                sqlParam.Value = transporte_vencimiento
                sqlParam = cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar, 250)
                If observaciones = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observaciones
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
                cmd.CommandText = "UPDATE chofer SET turno=?turno,factura=?factura,carnet_vencimiento=?carnet_vencimiento,transporte_vencimiento=?transporte_vencimiento,observaciones=?observaciones WHERE entidad_id=?entidad_id"

                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?turno", MySqlDbType.Enum, 0)
                sqlParam.Value = turno
                sqlParam = cmd.Parameters.Add("?factura", MySqlDbType.Bit, 1)
                sqlParam.Value = factura
                sqlParam = cmd.Parameters.Add("?carnet_vencimiento", MySqlDbType.Date, 0)
                sqlParam.Value = carnet_vencimiento
                sqlParam = cmd.Parameters.Add("?transporte_vencimiento", MySqlDbType.Date, 0)
                sqlParam.Value = transporte_vencimiento
                sqlParam = cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar, 250)
                If observaciones = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observaciones
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
                cmd.CommandText = "INSERT INTO chofer (entidad_id,turno,factura,carnet_vencimiento,transporte_vencimiento,observaciones) VALUES (?entidad_id,?turno,?factura,?carnet_vencimiento,?transporte_vencimiento,?observaciones)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE turno=?turno,factura=?factura,carnet_vencimiento=?carnet_vencimiento,transporte_vencimiento=?transporte_vencimiento,observaciones=?observaciones"
                sqlParam = cmd.Parameters.Add("?entidad_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = entidad_id
                sqlParam = cmd.Parameters.Add("?turno", MySqlDbType.Enum, 0)
                sqlParam.Value = turno
                sqlParam = cmd.Parameters.Add("?factura", MySqlDbType.Bit, 1)
                sqlParam.Value = factura
                sqlParam = cmd.Parameters.Add("?carnet_vencimiento", MySqlDbType.Date, 0)
                sqlParam.Value = carnet_vencimiento
                sqlParam = cmd.Parameters.Add("?transporte_vencimiento", MySqlDbType.Date, 0)
                sqlParam.Value = transporte_vencimiento
                sqlParam = cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar, 250)
                If observaciones = "" Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = observaciones
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
					cmd.CommandText = "DELETE FROM chofer WHERE entidad_id=?entidad_id"
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
