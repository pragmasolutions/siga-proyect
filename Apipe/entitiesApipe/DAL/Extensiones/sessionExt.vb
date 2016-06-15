Imports MySql.Data.MySqlClient

Partial Public Class session
    Public Shared Function setSession(ByVal usuario_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of session)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SET @IP=(select substr(host,1,POSITION(':' IN host)-1) from information_schema.processlist WHERE ID=connection_id());" & vbCrLf _
                & "INSERT INTO session (usuario_id,ip,ttl) VALUES (?usuario_id,@IP,NOW()) ON DUPLICATE KEY UPDATE ip=@IP, ttl=NOW()"
                .Parameters.AddWithValue("?usuario_id", usuario_id)
                .Connection = _Conexion
                .ExecuteNonQuery()
            End With
        End Using
    End Function
End Class
