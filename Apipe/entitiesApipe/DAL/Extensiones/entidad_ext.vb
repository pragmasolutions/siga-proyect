Imports MySql.Data.MySqlClient
Partial Public Class entidad
    Implements IEntidad
#Region "Propiedades para la Vista"
    Public ReadOnly Property v_AyN As String Implements IEntidad.vAyN
        Get
            If apellido <> "" And nombre <> "" Then
                Return apellido & ", " & nombre
            ElseIf apellido = "" And nombre <> "" Then
                Return nombre
            ElseIf apellido <> "" And nombre = "" Then
                Return apellido
            Else : Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property v_emails As String Implements IEntidad.vEmails
        Get
            v_emails = ""
            For Each m As mail In Me.lst_Mail
                v_emails &= m.v_email & " "
            Next
        End Get
    End Property
    Public ReadOnly Property v_telefonos As String Implements IEntidad.vTelefonos
        Get
            v_telefonos = ""
            For Each t As telefono In lst_Telefono
                If t.cod_area.Length > 0 Then
                    v_telefonos &= "(" & t.cod_area & ") " & t.numero & vbCrLf  '"/"
                Else
                    v_telefonos &= t.numero & vbCrLf '"/"
                End If
            Next
            If v_telefonos.Length > 0 Then
                v_telefonos = v_telefonos.Substring(0, v_telefonos.Length - 1)
            End If
        End Get
    End Property
#End Region
#Region "Funciones"

    Public Overloads Shared Function StoreFillListLast(ByRef _Conexion As MySqlConnection) As List(Of entidad)

        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of entidad)
                With exe
                    .CommandText = "FillEntidadLast"
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

        'Using exe As New MySqlCommand
        '    Dim Lista As New List(Of entidad)
        '    With exe
        '        .CommandText = "SELECT * FROM entidad e ORDER BY id DESC LIMIT 1"
        '        .Connection = _Conexion
        '        Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
        '        Ta.Fill(Dt)
        '        CargarLista(Dt, Lista)
        '        Ta.Dispose()
        '        Dt.Dispose()
        '    End With
        '    Return Lista
        'End Using
    End Function
    Public Function EntidadNueva(ByVal apellido As String, ByVal nombre As String, ByVal observacion As String, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "EntidadNueva"
                    .CommandType = CommandType.StoredProcedure
                    ' .Parameters.AddWithValue("?pid", id)
                    .Parameters.AddWithValue("?nombre", nombre)
                    .Parameters.AddWithValue("?apellido", apellido)
                    .Parameters.AddWithValue("?observacion", observacion)
                   .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function
    Public Shared Function FillListByApellido(ByVal apellido As String, ByRef _Conexion As MySqlConnection) As List(Of entidad)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of entidad)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM entidad e" & vbCrLf
                .CommandText &= "WHERE apellido = ?apellido"
                .Parameters.AddWithValue("?apellido", apellido)
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
    Public Shared Function FillListByFilter(ByRef _Conexion As MySqlConnection, Optional ByVal apellido As String = "", _
                                       Optional ByVal nombre As String = "", Optional ByVal nro_documento As Integer = 0, Optional ByVal list_id_not_in As String = "") _
                                   As List(Of entidad)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of entidad)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM entidad e" & vbCrLf
                .CommandText &= " WHERE 1=1 "
                If apellido <> "" Then
                    .CommandText &= " AND apellido LIKE ?apellido "
                    .Parameters.AddWithValue("apellido", "%" & apellido & "%")
                End If
                If nombre <> "" Then
                    .CommandText &= " AND nombre LIKE ?nombre"
                    .Parameters.AddWithValue("nombre", "%" & nombre & "%")
                End If
                If nro_documento <> 0 Then
                    .CommandText &= " AND nro_documento = ?nro_documento"
                    .Parameters.AddWithValue("nro_documento", nro_documento)
                End If
                If list_id_not_in <> "" Then
                    .CommandText &= " AND id NOT IN (" & list_id_not_in & ")"
                End If
                .CommandText &= vbCrLf & " ORDER BY apellido,nombre "
                .CommandText &= vbCrLf & " LIMIT 1000"
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
#End Region
End Class
