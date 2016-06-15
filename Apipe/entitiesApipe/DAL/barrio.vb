Imports MySql.Data.MySqlClient
Public Class barrio
#Region "Miembros"
	Private _id As Integer
	Private _nombre As String
	Private _lectura As Boolean
	Private _voz_id As Integer
	Private _localidad_id As Integer
	Private _EstadoFila As Char
	'Definicion de Entidades
	Private _Localidad As localidad
	Private _Voz As voz
	Private _lst_BarrioZona As List(Of barrio_zona)
	Private _lst_Domicilio As List(Of domicilio)
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
	Public Property lectura As Boolean
		Get
			Return _lectura
		End Get
		Set(ByVal Value As Boolean)
			_lectura = Value
		End Set
	End Property
	Public Property voz_id As Integer
		Get
			Return _voz_id
		End Get
		Set(ByVal Value As Integer)
			_voz_id = Value
		End Set
	End Property
	Public Property localidad_id As Integer
		Get
			Return _localidad_id
		End Get
		Set(ByVal Value As Integer)
			_localidad_id = Value
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
	Public Property Localidad As localidad
		Get
			If Me._localidad Is Nothing Then
				_localidad = New localidad
				If Me._localidad_id > 0 Then 
                    _Localidad.StoreFillBylocalidad(Me._localidad_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _localidad
        End Get
        Set(ByVal Value As localidad)
            _localidad = Value
        End Set
    End Property
    Public Property Voz As voz
        Get
            If Me._voz Is Nothing Then
                _voz = New voz
                If Me._voz_id > 0 Then
                    _voz.FillByVoz(Me._voz_id, ClsVariableSesion.Instancia.getConn)
                End If
            End If
            Return _voz
        End Get
        Set(ByVal Value As voz)
            _voz = Value
        End Set
    End Property
    Public Property lst_BarrioZona As List(Of barrio_zona)
        Get
            If Me._lst_BarrioZona Is Nothing Then
                _lst_BarrioZona = New List(Of barrio_zona)
                '_lst_BarrioZona=barrio_zona.FillListByBarrio(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_BarrioZona
        End Get
        Set(ByVal Value As List(Of barrio_zona))
            _lst_BarrioZona = Value
        End Set
    End Property
    Public Property lst_Domicilio As List(Of domicilio)
        Get
            If Me._lst_Domicilio Is Nothing Then
                _lst_Domicilio = New List(Of domicilio)
                '_lst_Domicilio=domicilio.FillListByBarrio(Me.id, ClsVariableSesion.Instancia.getConn) 
            End If
            Return _lst_Domicilio
        End Get
        Set(ByVal Value As List(Of domicilio))
            _lst_Domicilio = Value
        End Set
    End Property
	Public Shared ReadOnly Property CAMPOS As String
		Get
			Return "b.id,b.nombre,b.lectura,b.voz_id,b.localidad_id"
		End Get
	End Property
#End Region
#Region "Funciones Publicas"
    Public Sub New()
        Try

        
        With Me
            .id = 0
            .nombre = ""
            .lectura = False
            .voz_id = 0
            .localidad_id = 0
            End With
        Catch ex As Exception

        End Try
    End Sub
	Public Overloads Shared Function FillList(ByRef _Conexion As MySqlConnection) As List(Of barrio)
        Try

        
        Using exe As New MySqlCommand
            Dim Lista As New List(Of barrio)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM barrio b"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
            End Using

        Catch ex As Exception

        End Try
	End Function
    Public Shared Function StoreFillListByLocalidad(ByVal localidad_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of barrio)

        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of barrio)
                With exe
                    .CommandText = "FillBarrioByLocalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?localidad", localidad_id)
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

        'Try
        '    Using exe As New MySqlCommand
        '        Dim Lista As New List(Of barrio)
        '        With exe
        '            .CommandText = "SELECT " & CAMPOS & " FROM barrio b" & vbCrLf
        '            .CommandText &= "WHERE localidad_id = ?localidad_id ORDER BY b.nombre ASC"
        '            .Parameters.AddWithValue("?localidad_id", localidad_id)
        '            .Connection = _Conexion
        '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '            Ta.Fill(Dt)
        '            CargarLista(Dt, Lista)
        '        End With
        '        Return Lista
        '    End Using
        'Catch ex As Exception

        'End Try
    End Function
	Public Shared Function FillListByVoz(ByVal voz_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of barrio)
        Try

        
        Using exe As New MySqlCommand
            Dim Lista As New List(Of barrio)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM barrio b" & vbCrLf
                .CommandText &= "WHERE voz_id = ?voz_id"
                .Parameters.AddWithValue("?voz_id", voz_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
            End Using
        Catch ex As Exception

        End Try
	End Function
	Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of barrio))
        Try

        
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As New barrio
                CargarFila(Fila, O)
                Lista.Add(O)
            Next
            End If
        Catch ex As Exception

        End Try
	End Sub
	Private Shared Sub CargarFila(ByRef Fila As DataRow, ByRef O As barrio)
        Try

        
        If Fila.Item("id") IsNot DBNull.Value Then O.id = Fila.Item("id") Else O.id = 0
				If Fila.Item("nombre") IsNot DBNull.Value Then O.nombre = Fila.Item("nombre") Else O.nombre=""
				If Fila.Item("lectura") IsNot DBNull.Value Then O.lectura = Fila.Item("lectura") Else O.lectura=False
				If Fila.Item("voz_id") IsNot DBNull.Value Then O.voz_id = Fila.Item("voz_id") Else O.voz_id=0
            If Fila.Item("localidad_id") IsNot DBNull.Value Then O.localidad_id = Fila.Item("localidad_id") Else O.localidad_id = 0
        Catch ex As Exception

        End Try
	End Sub
    Public Sub StoreFillBybarrio(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)

        Try
            Using exe As New MySqlCommand
                'Dim Lista As New List(Of entidad)
                With exe
                    .CommandText = "FillBarrioById"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?barrio", Id)
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
        'Try

        '    Using exe As New MySqlCommand
        '        With exe
        '            .CommandText = "SELECT " & CAMPOS & " FROM barrio b WHERE id=?id"

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
        'Catch ex As Exception

        'End Try
    End Sub
	Public Function Clone() As barrio
        Try
            Clone = New barrio
			With Clone
				.id = Me.id
				.nombre = Me.nombre
				.lectura = Me.lectura
				.voz_id = Me.voz_id
				.localidad_id = Me.localidad_id
				.EstadoFila = Me.EstadoFila
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Function
	Public Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer 
		Dim sqlParam As New MySqlParameter
		Dim transaction As MySqlTransaction

        Try

        
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
                cmd.CommandText = "INSERT INTO barrio (nombre,lectura,voz_id,localidad_id) VALUES (?nombre,?lectura,?voz_id,?localidad_id)"
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 120)
                sqlParam.Value = nombre
                sqlParam = cmd.Parameters.Add("?lectura", MySqlDbType.Bit, 1)
                sqlParam.Value = lectura
                sqlParam = cmd.Parameters.Add("?voz_id", MySqlDbType.UInt32, 10)
                If voz_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = voz_id
                End If
                sqlParam = cmd.Parameters.Add("?localidad_id", MySqlDbType.UInt24, 5)
                sqlParam.Value = localidad_id
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
        Catch ex As Exception

        End Try
	End Function
	Public Function Update(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean 
		Dim sqlParam As New MySqlParameter
		Dim transaction As MySqlTransaction
        Try

        
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
                cmd.CommandText = "UPDATE barrio SET nombre=?nombre,lectura=?lectura,voz_id=?voz_id,localidad_id=?localidad_id WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                sqlParam.Value = id
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 120)
                sqlParam.Value = nombre
                sqlParam = cmd.Parameters.Add("?lectura", MySqlDbType.Bit, 1)
                sqlParam.Value = lectura
                sqlParam = cmd.Parameters.Add("?voz_id", MySqlDbType.UInt32, 10)
                If voz_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = voz_id
                End If
                sqlParam = cmd.Parameters.Add("?localidad_id", MySqlDbType.UInt24, 5)
                sqlParam.Value = localidad_id
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
        Catch ex As Exception

        End Try
	End Function
	Public Function InsertUpdate(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer 
		Dim sqlParam As New MySqlParameter
		Dim transaction As MySqlTransaction

        Try

        
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
                cmd.CommandText = "INSERT INTO barrio (id,nombre,lectura,voz_id,localidad_id) VALUES (?id,?nombre,?lectura,?voz_id,?localidad_id)" & vbCrLf _
                & " ON DUPLICATE KEY UPDATE nombre=?nombre,lectura=?lectura,voz_id=?voz_id,localidad_id=?localidad_id"
                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt32, 10)
                If id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = id
                End If
                sqlParam = cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 120)
                sqlParam.Value = nombre
                sqlParam = cmd.Parameters.Add("?lectura", MySqlDbType.Bit, 1)
                sqlParam.Value = lectura
                sqlParam = cmd.Parameters.Add("?voz_id", MySqlDbType.UInt32, 10)
                If voz_id = 0 Then
                    sqlParam.Value = DBNull.Value
                Else
                    sqlParam.Value = voz_id
                End If
                sqlParam = cmd.Parameters.Add("?localidad_id", MySqlDbType.UInt24, 5)
                sqlParam.Value = localidad_id
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
        Catch ex As Exception

        End Try
	End Function
	Public Function Delete(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean 
		Dim sqlParam As New MySqlParameter
		Dim transaction As MySqlTransaction

        Try

        
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
                cmd.CommandText = "DELETE FROM barrio WHERE id=?id"
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
	End Function
#End Region
End Class
