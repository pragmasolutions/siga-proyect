Imports MySql.Data.MySqlClient
Partial Public Class zona
    Public Shared Function FillListByZona(ByVal id As Integer, ByRef _Conexion As MySqlConnection) As List(Of zona)
        Try
            Dim Lista As New List(Of zona)
            Using exe As New MySqlCommand

                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM zona z" & vbCrLf
                    .CommandText &= "WHERE id = ?id"
                    .Parameters.AddWithValue("?id", id)
                    .Connection = _Conexion
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
    End Function

End Class
