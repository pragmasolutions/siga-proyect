Imports MySql.Data
Imports MySql.Data.MySqlClient

Partial Public Class frecuencia
    Public Function ControlarFrecuencia(ByVal numero As Integer, ByRef _Conexion As MySqlConnection) As Boolean
        Using exe As New MySqlCommand
            Dim Lista As New List(Of frecuencia)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM frecuencia f where f.EstadoFila='a' AND f.id = " & numero
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            If Lista.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End Using
    End Function
    Public Function UpdateEstado(ByVal id As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "UPDATE frecuencia SET numero='i' WHERE id=?id"

                sqlParam = cmd.Parameters.Add("?id", MySqlDbType.UInt16, 3)
                sqlParam.Value = id
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
            Return True
        End Using
    End Function
End Class
