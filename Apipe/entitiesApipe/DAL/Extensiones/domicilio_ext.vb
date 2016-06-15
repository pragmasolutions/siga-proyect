Imports MySql.Data.MySqlClient
Partial Public Class domicilio

#Region "Funciones"
    Public Shared Function FillListCalles(ByRef _Conexion As MySqlConnection) As List(Of String)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of String)
                With exe
                    .CommandText = "ListadoCallesDomicilio"
                    .CommandType = CommandType.StoredProcedure
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
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Shared Function StoreCorreccionCalle(ByRef _Conexion As MySqlConnection, ByVal aCorregir As String, ByVal Correccion As String) As Boolean
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of String)
                With exe
                    .CommandText = "CorrecionCalles"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?aCorregir", aCorregir)
                    .Parameters.AddWithValue("?Correccion", Correccion)
                    .Connection = _Conexion
                    ' Lista = exe.ExecuteScalar
                    exe.ExecuteNonQuery()
                    'Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    'Ta.Fill(Dt)
                    'CargarLista(Dt, Lista)
                    'Ta.Dispose()
                    'Dt.Dispose()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function DomicilioNuevo(ByVal calle As String, ByVal numero As Integer, ByVal tipo As String,
                                       ByVal descripcion As String, ByVal interseccion As String, ByVal observacion As String,
                                       ByVal barrio_id As Integer, ByVal zona As Integer, ByVal telefono As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Long

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "DomicilioNuevo"
                    .CommandType = CommandType.StoredProcedure
                    ' .Parameters.AddWithValue("?pid", id)
                    .Parameters.AddWithValue("?calle", calle)
                    .Parameters.AddWithValue("?numero", numero)
                    .Parameters.AddWithValue("?tipo", tipo)
                    .Parameters.AddWithValue("?descripcion", descripcion)
                    .Parameters.AddWithValue("?interseccion", interseccion)
                    .Parameters.AddWithValue("?observacion", observacion)
                    .Parameters.AddWithValue("?barrio", barrio_id)
                    .Parameters.AddWithValue("?telefono", telefono)
                    '.Parameters.AddWithValue("?vozinterseccion", vozinters)
                    .Parameters.AddWithValue("?zona", zona)

                    .Connection = _Conexion
                    exe.ExecuteScalar()
                    '  Me.id = exe.LastInsertedId
                    Return exe.LastInsertedId
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function


    Public Function UltimoDomicilio(ByRef _Conexion As MySqlConnection) As domicilio
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of domicilio)
                With exe
                    .CommandText = "UltimoDomicilio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    'exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)
                    '
                    'If Dt.Rows.Count > 0 Then
                    '    Dim Fila As DataRow = Dt.Rows(0)
                    '    CargarFila(Fila, Me)
                    'End If
                    Return Lista.First()
                End With
            End Using

        Catch ex As Exception

        End Try
    End Function

    Public Function ModificarDomicilio(ByVal id As Integer, ByVal calle As String, ByVal numero As Integer, ByVal tipo As String,
                                       ByVal descripcion As String, ByVal interseccion As String, ByVal observacion As String,
                                       ByVal barrio_id As Integer, ByVal zona As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "DomicilioActualizar"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pid", id)
                    .Parameters.AddWithValue("?calle", calle)
                    .Parameters.AddWithValue("?numero", numero)
                    .Parameters.AddWithValue("?tipo", tipo)
                    .Parameters.AddWithValue("?descripcion", descripcion)
                    .Parameters.AddWithValue("?interseccion", interseccion)
                    .Parameters.AddWithValue("?observacion", observacion)
                    .Parameters.AddWithValue("?barrio", barrio_id)
                    ' .Parameters.AddWithValue("?vozcalle", voz)
                    '.Parameters.AddWithValue("?vozinterseccion", vozinters)
                    .Parameters.AddWithValue("?zona", zona)

                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function ModificarEstadoDomicilio(ByVal id As Integer, ByVal estado As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "DomicilioEstadoActualizar"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pid", id)
                    .Parameters.AddWithValue("?estado", estado)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Private Shared Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of String))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim O As String
                If Fila.Item("calle") IsNot DBNull.Value Then O = Fila.Item("calle") Else O = ""
                Lista.Add(O)
            Next
        End If
    End Sub
#End Region
End Class
