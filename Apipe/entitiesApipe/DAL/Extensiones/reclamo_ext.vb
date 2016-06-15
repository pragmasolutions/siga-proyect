Imports MySql.Data.MySqlClient
Partial Public Class reclamo

    Public ReadOnly Property v_categoria As String
        Get
            ' If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
            Return Me.Reclamo_categoria.nombre
            '  End If
            ' Return ""
        End Get
    End Property

    Public Shared Function StoreFillByPedido(ByVal pedido_id As Integer, ByRef _Conexion As MySqlConnection) As reclamo
        Try
            Using exe As New MySqlCommand
                Dim rec As New reclamo
                ' Dim Lista As New List(Of entidad)
                With exe
                    .CommandText = "FillReclamoByPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        For Each fila As DataRow In Dt.Rows
                            If fila.Item("id") IsNot DBNull.Value Then rec.id = fila.Item("id") Else rec.id = 0
                            If fila.Item("fechahora") IsNot DBNull.Value Then rec.fechahora = DateTime.Parse(fila.Item("fechahora").ToString) Else rec.fechahora = "1900-01-01 00:00:00"
                            If fila.Item("asunto") IsNot DBNull.Value Then rec.asunto = fila.Item("asunto") Else rec.asunto = ""
                            If fila.Item("finalizo") IsNot DBNull.Value Then rec.finalizo = DateTime.Parse(fila.Item("finalizo").ToString) Else rec.finalizo = "1900-01-01 00:00:00"
                            If fila.Item("cliente_id") IsNot DBNull.Value Then rec.cliente_id = fila.Item("cliente_id") Else rec.cliente_id = 0
                            If fila.Item("reclamo_categoria_id") IsNot DBNull.Value Then rec.reclamo_categoria_id = fila.Item("reclamo_categoria_id") Else rec.reclamo_categoria_id = 0
                            If fila.Item("pedido_id") IsNot DBNull.Value Then rec.pedido_id = fila.Item("pedido_id") Else rec.pedido_id = 0
                        Next
                    End If
                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return rec
            End Using
        Catch ex As Exception
            Return New reclamo()
        End Try
       
    End Function


    Public Function ReclamoNuevo(ByVal cliente As Integer, ByVal pedido As Integer, ByVal asunto As String,
                                      ByVal categoria As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ReclamoNuevo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?asunto", asunto)
                    .Parameters.AddWithValue("?cliente", cliente)
                    .Parameters.AddWithValue("?categoria", categoria)
                    .Parameters.AddWithValue("?pedido", pedido)
                    '   .Parameters.AddWithValue("?movil", movil)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    'Public Shared Function FillByPedido(ByVal pedido_id As Integer, ByRef _Conexion As MySqlConnection) As reclamo
    '    Using exe As New MySqlCommand
    '        Dim rec As New reclamo
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM reclamo r" & vbCrLf
    '            .CommandText &= "WHERE pedido_id = ?pedido_id"
    '            .Parameters.AddWithValue("?pedido_id", pedido_id)
    '            .Connection = _Conexion
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            If Dt.Rows.Count > 0 Then
    '                For Each fila As DataRow In Dt.Rows
    '                    If fila.Item("id") IsNot DBNull.Value Then rec.id = fila.Item("id") Else rec.id = 0
    '                    If fila.Item("fechahora") IsNot DBNull.Value Then rec.fechahora = DateTime.Parse(fila.Item("fechahora").ToString) Else rec.fechahora = "1900-01-01 00:00:00"
    '                    If fila.Item("asunto") IsNot DBNull.Value Then rec.asunto = fila.Item("asunto") Else rec.asunto = ""
    '                    If fila.Item("finalizo") IsNot DBNull.Value Then rec.finalizo = DateTime.Parse(fila.Item("finalizo").ToString) Else rec.finalizo = "1900-01-01 00:00:00"
    '                    If fila.Item("cliente_id") IsNot DBNull.Value Then rec.cliente_id = fila.Item("cliente_id") Else rec.cliente_id = 0
    '                    If fila.Item("reclamo_categoria_id") IsNot DBNull.Value Then rec.reclamo_categoria_id = fila.Item("reclamo_categoria_id") Else rec.reclamo_categoria_id = 0
    '                    If fila.Item("pedido_id") IsNot DBNull.Value Then rec.pedido_id = fila.Item("pedido_id") Else rec.pedido_id = 0
    '                Next
    '            End If
    '            Ta.Dispose()
    '            Dt.Dispose()
    '        End With
    '        Return rec
    '    End Using
    'End Function
End Class
