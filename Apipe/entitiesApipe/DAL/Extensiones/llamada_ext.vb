Imports MySql.Data.MySqlClient
Partial Public Class llamada
#Region "Funciones Publicas"
    Public Sub New()
        With Me
            .id = 0
            .fechaHora = "1900-01-01 00:00:00"
            .usuario_id = 0
            .telefono_id = 0
            .numero = ""
        End With
    End Sub
    Public Function GuardarLlamada(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional usuario_id As Integer = 0, Optional telefono_id As Integer = 0, Optional numero As String = "") As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "GuardarLlamada"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?usuario", usuario_id)
                    .Parameters.AddWithValue("?telefono", telefono_id)
                    .Parameters.AddWithValue("?numero", numero)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True

    End Function
    'Public Function Insert(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Integer
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
    '            cmd.CommandText = "INSERT INTO llamada (fechahora,usuario_id,telefono_id,numero) VALUES (?fechahora,?usuario_id,?telefono_id,?numero)"
    '            sqlParam = cmd.Parameters.Add("?fechahora", MySqlDbType.DateTime, 0)
    '            sqlParam.Value = fechahora

    '            sqlParam = cmd.Parameters.Add("?usuario_id", MySqlDbType.UInt32, 10)
    '            sqlParam.Value = usuario_id

    '            sqlParam = cmd.Parameters.Add("?telefono_id", MySqlDbType.UInt32, 10)
    '            sqlParam.Value = telefono_id

    '            sqlParam = cmd.Parameters.Add("?numero", MySqlDbType.VarChar, 20)
    '            sqlParam.Value = numero

    '            cmd.ExecuteNonQuery()
    '            If _tran Is Nothing Then
    '                transaction.Commit()
    '            End If

    '            cmd.Dispose()
    '        Catch ex As Exception
    '            If _tran Is Nothing Then
    '                transaction.Rollback()
    '            End If
    '            Throw New Exception(ex.Message)
    '        End Try
    '        Me.id = cmd.LastInsertedId
    '        Return cmd.LastInsertedId
    '    End Using
    'End Function

#End Region

End Class
