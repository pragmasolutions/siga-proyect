Imports MySql.Data.MySqlClient
Partial Public Class telefono_domicilio
    Public ReadOnly Property v_domicilio As String
        Get
            'If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
            '    Return Me.Domicilio.calle & " " & Me.Domicilio.numero & " " & Me.Domicilio.descripcion & " " & Me.Domicilio.interseccion
            'End If
            'Return ""
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then

                If Me.Domicilio.barrio_id <> 1 And Me.Domicilio.barrio_id <> 116 Then
                    Return "Barrio: " & Me.Domicilio.Barrio.nombre & " " & Me.Domicilio.calle & " " & Me.Domicilio.numero & " " & Me.Domicilio.descripcion & " " & Me.Domicilio.interseccion
                Else
                    Return Me.Domicilio.calle & " " & Me.Domicilio.numero & " " & Me.Domicilio.descripcion & " " & Me.Domicilio.interseccion
                End If

            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_calle As String
        Get
            If Me.Domicilio.id > 0 Then
                Return Me.Domicilio.calle
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_nro As Integer
        Get
            If Me.Domicilio.id > 0 Then
                Return Me.Domicilio.numero
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_tipo As String
        Get
            If Me.Domicilio.id > 0 Then
                Return Me.Domicilio.tipo
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_descripcion As String
        Get
            If Me.Domicilio.id > 0 Then
                Return Me.Domicilio.descripcion
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_interseccion As String
        Get
            If Me.Domicilio.id > 0 Then
                Return Me.Domicilio.interseccion
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_observacion As String
        Get
            If Me.Domicilio.id > 0 Then
                Return Me.Domicilio.observacion
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_entidad_id As String
        Get
            If Me.Telefono.id > 0 Then
                Return Me.Telefono.entidad_id
            End If
            Return ""
        End Get
    End Property
    Public Shared Function StoreFillListByTelefonoBaja(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of telefono_domicilio)

        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of telefono_domicilio)
                With exe
                    .CommandText = "FillTelefonoDomicilioByTelefono"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?telefono", telefono_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return New List(Of telefono_domicilio)()
        End Try
    End Function

    Public Function StoreBajaTelefonoDomicilio(ByVal domicilio As Integer, ByVal telefono As Integer, ByVal telefonista As Integer, _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "TelefonoDomicilioBaja"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?domicilio", domicilio)
                    .Parameters.AddWithValue("?telefono", telefono)
                    .Parameters.AddWithValue("?telefonista", telefonista)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using


            'Dim sqlParam As New MySqlParameter
            'Dim transaction As MySqlTransaction
            'Using cmd As New MySqlCommand
            '    If _Conexion Is Nothing Then
            '        _Conexion.Open()
            '    End If
            '    If _tran Is Nothing Then
            '        transaction = _Conexion.BeginTransaction()
            '    Else
            '        transaction = _tran
            '    End If
            '    cmd.Transaction = transaction
            '    cmd.Connection = _Conexion
            '    Try
            '        cmd.CommandText = "UPDATE telefono_domicilio SET baja=?baja WHERE domicilio_id=?domicilio_id AND telefono_id=?telefono_id"

            '        sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
            '        sqlParam.Value = domicilio_id
            '        sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
            '        sqlParam.Value = telefono_id
            '        sqlParam = cmd.Parameters.Add("?prioridad", MySqlDbType.UInt24, 5)
            '        sqlParam.Value = prioridad
            '        sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Bit, 1)
            '        sqlParam.Value = baja
            '        cmd.ExecuteNonQuery()
            '        If _tran Is Nothing Then
            '            transaction.Commit()
            '        End If
            '_tran.Dispose()
        Catch ex As Exception
            'If _tran Is Nothing Then
            '    transaction.Rollback()
            'End If
            Throw New Exception(ex.Message)
        End Try
        'Return True
        '    End Using
    End Function

    'Public Function UpdateBaja(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
    '    Dim sqlParam As New MySqlParameter
    '    Dim transaction As MySqlTransaction
    '    Using cmd As New MySqlCommand
    '        If _Conexion Is Nothing Then
    '            _Conexion.Open()
    '        End If
    '        If _tran Is Nothing Then
    '            transaction = _Conexion.BeginTransaction()
    '        Else
    '            transaction = _tran
    '        End If
    '        cmd.Transaction = transaction
    '        cmd.Connection = _Conexion
    '        Try
    '            cmd.CommandText = "UPDATE telefono_domicilio SET baja=?baja WHERE domicilio_id=?domicilio_id AND telefono_id=?telefono_id"

    '            sqlParam = cmd.Parameters.Add("?domicilio_id", MySqlDbType.UInt32, 10)
    '            sqlParam.Value = domicilio_id
    '            sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
    '            sqlParam.Value = telefono_id
    '            sqlParam = cmd.Parameters.Add("?prioridad", MySqlDbType.UInt24, 5)
    '            sqlParam.Value = prioridad
    '            sqlParam = cmd.Parameters.Add("?baja", MySqlDbType.Bit, 1)
    '            sqlParam.Value = baja
    '            cmd.ExecuteNonQuery()
    '            If _tran Is Nothing Then
    '                transaction.Commit()
    '            End If
    '            '_tran.Dispose()
    '        Catch ex As Exception
    '            If _tran Is Nothing Then
    '                transaction.Rollback()
    '            End If
    '            Throw New Exception(ex.Message)
    '        End Try
    '        Return True
    '    End Using
    'End Function

    'Public Shared Function FillListByTelefonoBaja(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of telefono_domicilio)
    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of telefono_domicilio)
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM telefono_domicilio t" & vbCrLf
    '            .CommandText &= "WHERE telefono_id = ?telefono_id AND baja=1"
    '            .Parameters.AddWithValue("?telefono_id", telefono_id)
    '            .Connection = _Conexion
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            CargarLista(Dt, Lista)
    '            Ta.Dispose()
    '            Dt.Dispose()
    '        End With
    '        Return Lista
    '    End Using
    'End Function
End Class
