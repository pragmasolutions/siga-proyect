Imports MySql.Data.MySqlClient
Partial Public Class reclamo_linea
    
    Public Function NuevaLineaReclamo(ByVal reclamo As Integer, ByVal telefonista As Integer, ByVal comentario As String,
                                      ByVal operador As Integer, ByVal movil As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ReclamoLineaNueva"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?reclamo", reclamo)
                    .Parameters.AddWithValue("?telefonista", telefonista)
                    .Parameters.AddWithValue("?comentario", comentario)
                    .Parameters.AddWithValue("?operador", operador)
                    .Parameters.AddWithValue("?movil", movil)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function
End Class
