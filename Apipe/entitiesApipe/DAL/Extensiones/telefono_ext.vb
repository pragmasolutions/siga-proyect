Imports MySql.Data.MySqlClient
Partial Public Class telefono
#Region "Propiedades"
    Public ReadOnly Property v_Apellido As String
        Get
            Return Me.Entidad.apellido
        End Get
    End Property

    Public ReadOnly Property v_Nombre As String
        Get
            Return Me.Entidad.nombre
        End Get
    End Property

    Public ReadOnly Property v_Observación As String
        Get
            Return Me.Entidad.observacion
        End Get
    End Property
#End Region

    Public Sub StoreFillByNumeroYCaracteristica(ByVal numero As String, ByVal caracteristica As String, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                ' Dim Lista As New List(Of telefono)
                With exe
                    .CommandText = "FillByNumeroCarac"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?numero", numero)
                    .Parameters.AddWithValue("?caracteristica", caracteristica)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    'Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    'Ta.Fill(Dt)
                    'CargarLista(Dt, Lista)

                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If

                End With
                ' Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try

        'Using exe As New MySqlCommand
        '    With exe
        '        .CommandText = "SELECT " & CAMPOS & " FROM telefono t WHERE numero=?numero AND cod_area=?caracteristica"

        '        .Connection = _Conexion
        '        .Parameters.AddWithValue("numero", numero)
        '        .Parameters.AddWithValue("caracteristica", caracteristica)
        '        Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '        Ta.Fill(Dt)
        '        If Dt.Rows.Count > 0 Then
        '            Dim Fila As DataRow = Dt.Rows(0)
        '            CargarFila(Fila, Me)
        '        End If
        '        Ta.Dispose()
        '        Dt.Dispose()
        '    End With
        'End Using
    End Sub

    Public Function TelefonoNuevo(ByVal tipo As String, ByVal codarea As String, ByVal numero As String,
                                  ByVal entidadid As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "TelefonoNuevo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?tipo", tipo)
                    .Parameters.AddWithValue("?codarea", codarea)
                    .Parameters.AddWithValue("?numero", numero)
                    .Parameters.AddWithValue("?entidadid", entidadid)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Sub FillById(ByVal id As Integer, ByRef _Conexion As MySqlConnection)
        Using exe As New MySqlCommand
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM telefono t WHERE id=?id"

                .Connection = _Conexion
                .Parameters.AddWithValue("id", id)

                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    Dim Fila As DataRow = Dt.Rows(0)
                    CargarFila(Fila, Me)
                End If
                Ta.Dispose()
                Dt.Dispose()
            End With
        End Using
    End Sub

    'Public Sub FillByNumeroYCaracteristica(ByVal numero As Integer, ByVal caracteristica As Integer, ByRef _Conexion As MySqlConnection)
    '    Using exe As New MySqlCommand
    '        With exe
    '            .CommandText = "SELECT " & CAMPOS & " FROM telefono t WHERE numero=?numero AND cod_area=?caracteristica"

    '            .Connection = _Conexion
    '            .Parameters.AddWithValue("numero", numero)
    '            .Parameters.AddWithValue("caracteristica", caracteristica)
    '            Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '            Ta.Fill(Dt)
    '            If Dt.Rows.Count > 0 Then
    '                Dim Fila As DataRow = Dt.Rows(0)
    '                CargarFila(Fila, Me)
    '            End If
    '            Ta.Dispose()
    '            Dt.Dispose()
    '        End With
    '    End Using
    'End Sub
End Class
