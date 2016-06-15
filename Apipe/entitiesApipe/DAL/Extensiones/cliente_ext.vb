Imports MySql.Data.MySqlClient
Partial Public Class cliente
    Public ReadOnly Property v_Apellido As String
        Get
            If Me.Entidad.id > 0 Then
                Return Me.Entidad.apellido
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property v_Nombre As String
        Get
            If Me.Entidad.id > 0 Then
                Return Me.Entidad.nombre
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property v_Tipo As String
        Get
            If Me.Entidad.id > 0 Then
                Return Me.Cliente_categoria.descripcion
            End If
            Return ""
        End Get
    End Property

    Public Function ClienteNuevo(ByVal entidadid As Integer, ByVal categoria As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ClienteNuevo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?entidad", entidadid)
                    .Parameters.AddWithValue("?categoria", categoria)
                 .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function
    Public Overloads Function FillListByFilter(ByRef _Conexion As MySqlConnection, Optional ByVal apellido As String = "", _
                                       Optional ByVal nombre As String = "", Optional ByVal nro_documento As Integer = 0) _
                                   As List(Of cliente)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of cliente)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM cliente c" & vbCrLf _
                            & " JOIN entidad e ON c.entidad_id=e.id" & vbCrLf _
                            & " WHERE 1=1  "
                If nro_documento > 0 Then
                    .CommandText &= " AND nro_documento LIKE ?nro_documento"
                    .Parameters.AddWithValue("nro_documento", "%" & nro_documento & "%")
                End If
                If nombre.Length > 0 Then
                    .CommandText &= " AND nombre LIKE ?nombre"
                    .Parameters.AddWithValue("nombre", "%" & nombre & "%")
                End If
                If apellido.Length > 0 Then
                    .CommandText &= " AND apellido LIKE ?apellido"
                    .Parameters.AddWithValue("apellido", "%" & apellido & "%")
                End If
                .CommandText &= " AND e.baja = 0 ORDER BY apellido ASC, nombre ASC"
                .CommandText &= " LIMIT 1000"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function
End Class
