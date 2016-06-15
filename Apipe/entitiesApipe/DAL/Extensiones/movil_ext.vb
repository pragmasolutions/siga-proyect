Imports MySql.Data.MySqlClient
Partial Public Class movil
    Public ReadOnly Property v_aire As String
        Get
            If Me.aire = True Then
                Return "Si"
            Else
                Return "No"
            End If
        End Get
    End Property

    Public ReadOnly Property v_habilitado As String
        Get
            If Me.habilitado = True Then
                Return "Si"
            Else
                Return "No"
            End If
        End Get
    End Property

    Public Shared Function ListaNumeroDuplicado(ByVal numero_movil As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of movil)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
                    .CommandText &= "WHERE ?numero_movil = m.numero"
                    .Parameters.AddWithValue("?numero_movil", numero_movil)
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Try
                        Ta.Fill(Dt)
                        CargarLista(Dt, Lista)
                    Catch ex As Exception

                    End Try
                    
                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function StoreFillListByNumero(ByVal numero As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
            Dim Lista As New List(Of movil)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "MovilByNumero"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?numero", numero)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return Lista
        End Try
    End Function

    Public Shared Function StoreFillListByNumeroFrecuencia(ByVal numero As Integer, ByVal frecuencia_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
        Dim Lista As New List(Of movil)
        Try
            Using exe As New MySqlCommand

                With exe

                    .CommandText = "ListMovilNumeroFrecuencia"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?numero", numero)
                    .Parameters.AddWithValue("?frecuencia", frecuencia_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return Lista
        End Try
    End Function

    Public Shared Sub StoreQuitarDeZona(ByVal movil As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "QuitarDeZona"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?movil", movil)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With

            End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Overloads Shared Function FillListZonas(ByRef _Conexion As MySqlConnection) As List(Of movil)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of movil)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM movil m WHERE en_zona"
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Try
                        Ta.Fill(Dt)
                        CargarLista(Dt, Lista)
                    Catch ex As Exception

                    End Try

                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception
            'MsgBox("Error: FillListZonas")
        End Try


    End Function

    Public Shared Function StoreFillListZonasCount(ByRef _Conexion As MySqlConnection) As Integer
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CargarZonasCount"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    Return exe.ExecuteScalar()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Sub CambiarFrecuencia(ByVal desde As Integer, ByVal hasta As Integer, ByVal frecuencia_id As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing)
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
                cmd.CommandText = "UPDATE movil SET frecuencia_id = ?frecuencia_id WHERE numero >= ?desde AND numero <=?hasta"

                sqlParam = cmd.Parameters.Add("?frecuencia_id", MySqlDbType.UInt32, 10)
                sqlParam.Value = frecuencia_id

                sqlParam = cmd.Parameters.Add("?desde", MySqlDbType.UInt32, 10)
                sqlParam.Value = desde

                sqlParam = cmd.Parameters.Add("?hasta", MySqlDbType.UInt32, 10)
                sqlParam.Value = hasta

                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
                cmd.Dispose()
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try


        End Using
    End Sub

    'Public Function FillListZonasCount(ByRef _Conexion As MySqlConnection) As Integer
    '    Try
    '        Using exe As New MySqlCommand
    '            With exe
    '                .CommandText = "SELECT COUNT(*) FROM movil m WHERE en_zona"
    '                .Connection = _Conexion
    '            End With
    '            Return exe.ExecuteScalar
    '        End Using
    '    Catch ex As Exception
    '        Return 0
    '    End Try
    'End Function
    'Public Shared Function FillListByNumeroFrecuencia(ByVal numero As Integer, ByVal frecuencia_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
    '    Try
    '        Using exe As New MySqlCommand
    '            Dim Lista As New List(Of movil)
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
    '                .CommandText &= "WHERE numero = ?numero AND frecuencia_id=?frecuencia_id"
    '                .Parameters.AddWithValue("?numero", numero)
    '                .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)
    '                Catch ex As Exception

    '                End Try

    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Function
    'Public Shared Function FillListByNumero(ByVal numero As Integer, ByRef _Conexion As MySqlConnection) As List(Of movil)
    '    Try
    '        Using exe As New MySqlCommand
    '            Dim Lista As New List(Of movil)
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM movil m" & vbCrLf
    '                .CommandText &= "WHERE numero = ?numero"
    '                .Parameters.AddWithValue("?numero", numero)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)
    '                Catch ex As Exception

    '                End Try

    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Function
End Class
