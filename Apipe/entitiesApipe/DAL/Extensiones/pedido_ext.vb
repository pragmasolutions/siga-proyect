Imports MySql.Data.MySqlClient

Partial Public Class pedido
#Region "Propiedades para la vista"
    Public ReadOnly Property v_reclamos As String
        Get
            v_reclamos = ""
            For Each r In lst_Reclamo
                For Each rl In r.lst_ReclamoLinea
                    If v_reclamos.Trim.Length > 0 Then v_reclamos &= vbNewLine
                    v_reclamos &= rl.comentario
                Next
            Next
        End Get
    End Property
    Public ReadOnly Property v_hora As String
        Get
            If fechahora.Date = Now.Date Then
                Return Me.fechahora.ToShortTimeString
                'Return Me.fechahora
            ElseIf fechahora.Date = "01/01/1900" Then
                Return ""
            Else
                If Me.fechahora <> Nothing Then Return Me.fechahora.ToShortDateString
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_hora_viaje As String
        Get
            If fechahora_viaje.Date = Now.Date Then
                Return Me.fechahora_viaje.ToShortTimeString
                'Return Me.fechahora_viaje
            ElseIf fechahora_viaje.Date = "01/01/1900" Then
                Return ""
            Else
                If Me.fechahora_viaje <> Nothing Then Return Format(Me.fechahora_viaje, "dd/MM HH:mm")
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_hora_asignado As String
        Get
            If asignado.Date = Now.Date Then
                Return Me.asignado.ToShortTimeString
                'Return Me.asignado
            ElseIf asignado.Date = "01/01/1900" Then
                Return ""
            Else
                If Me.asignado <> Nothing Then
                    'Return Me.asignado.ToShortDateString
                    Return Me.asignado
                End If
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_hora_asignado2 As String
        Get
            If asignado.Date = Now.Date Then
                Return Me.asignado.ToShortTimeString
            ElseIf asignado.Date = "01/01/1900" Then
                Return ""
            ElseIf Me.asignado <> Nothing Then
                'Return Me.asignado.ToShortDateString
                Return Me.asignado
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_hora_completado As String
        Get
            If completado.Date = Now.Date Then
                Return Me.completado.ToShortTimeString
            ElseIf completado.Date = "01/01/1900" Then
                Return ""
            Else
                If Me.completado <> Nothing Then
                    'Return Me.completado.ToShortDateString
                    Return Me.completado
                End If
            End If
                Return ""
        End Get
    End Property
    Public ReadOnly Property v_hora_completado2 As String
        Get
            If completado.Date = Now.Date Then
                Return Me.completado.ToShortTimeString
            ElseIf completado.Date = "01/01/1900" Then
                Return ""
            ElseIf Me.completado <> Nothing Then
                'Return Me.completado.ToShortDateString
                Return Me.completado
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_hora_cancelado As String
        Get
            If cancelado.Date = Now.Date Then
                Return Me.cancelado.ToShortTimeString
            ElseIf cancelado.Date = "01/01/1900" Then
                Return ""
            ElseIf Me.cancelado <> Nothing Then
                'Return Me.cancelado.ToShortDateString
                Return Me.cancelado
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_domicilio As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                If Me.TelefonoDomicilio.Domicilio.barrio_id <> 1 And Me.TelefonoDomicilio.Domicilio.barrio_id <> 116 Then
                    Return "Barrio: " & Me.TelefonoDomicilio.Domicilio.Barrio.nombre & " " & Me.TelefonoDomicilio.Domicilio.calle & " " & Me.TelefonoDomicilio.Domicilio.numero & " " & Me.TelefonoDomicilio.Domicilio.descripcion & " " & Me.TelefonoDomicilio.Domicilio.interseccion
                Else
                    Return Me.TelefonoDomicilio.Domicilio.calle & " " & Me.TelefonoDomicilio.Domicilio.numero & " " & Me.TelefonoDomicilio.Domicilio.descripcion & " " & Me.TelefonoDomicilio.Domicilio.interseccion
                End If

            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_domicilioCQV As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                If Me.TelefonoDomicilio.Domicilio.barrio_id <> 1 And Me.TelefonoDomicilio.Domicilio.barrio_id <> 116 Then
                    Return ""
                    'Return Me.TelefonoDomicilio.Domicilio.calle & " " & Me.TelefonoDomicilio.Domicilio.numero
                Else
                    Return Me.TelefonoDomicilio.Domicilio.calle & " " & Me.TelefonoDomicilio.Domicilio.numero
                End If

            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property v_EstadoDomicilio As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                If Me.TelefonoDomicilio.Domicilio.Estado = 0 Then
                    Return "Validar"
                ElseIf Me.TelefonoDomicilio.Domicilio.Estado = 1 Then
                    Return "Valido"
                Else
                    Return "No Validar"
                End If

            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property v_observacionesCQV As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                If Me.TelefonoDomicilio.Domicilio.barrio_id <> 1 And Me.TelefonoDomicilio.Domicilio.barrio_id <> 116 Then
                    Return ""
                Else
                    Return Me.TelefonoDomicilio.Domicilio.descripcion
                End If

            End If
            Return ""
        End Get
    End Property


    Public ReadOnly Property v_descripcion As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Domicilio.descripcion & " "
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_interseccion As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Domicilio.interseccion & " "
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_observacion As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Domicilio.observacion & " "
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_telefono As Integer
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Telefono.numero
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_cod_area As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Telefono.cod_area.ToString
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property v_tel_completo As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Telefono.cod_area.ToString & Me.TelefonoDomicilio.Telefono.numero.ToString
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property v_nroMovil As String
        Get
            If Me.movil_id > 0 Then
                Return Me.ChoferMovil.Movil.numero
            Else : Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property v_choferAyN As String
        Get
            If Me.chofer_id > 0 Then
                With Me.ChoferMovil.Chofer.Entidad
                    Return .apellido & ", " & .nombre
                End With
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_clienteAyN As String
        Get
            'If Me.chofer_id > 0 Then
            '    With Me.ChoferMovil.Chofer.Entidad
            '        Return .apellido & ", " & .nombre
            '    End With
            'End If
            'Return ""
            Return Me.TelefonoDomicilio.Telefono.Entidad.v_AyN
        End Get
    End Property
    Public ReadOnly Property v_movilCel As String
        Get
            'If Me.chofer_id > 0 Then
            '    With Me.ChoferMovil.Chofer.Entidad
            '        Return .apellido & ", " & .nombre
            '    End With
            'End If
            'Return ""
            Return Me.TelefonoDomicilio.Telefono.Entidad.v_AyN
        End Get
    End Property

    Public ReadOnly Property v_Telefonista As String
        Get
            If Me.usuario_id > 0 Then
                Return Me.Usuario.usuario
            Else : Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property v_Operador As String
        Get
            If Me.operador_id > 0 Then
                Return Me.Operador.Entidad.nombre

            Else : Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property v_zona As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Domicilio.zona_id & " "
            End If
            Return ""
        End Get
    End Property
#End Region

#Region "Funciones"

    Public Sub StoreFillBypedido(ByVal Id As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "FillByPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?Numero", Id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    If Dt.Rows.Count > 0 Then
                        Dim Fila As DataRow = Dt.Rows(0)
                        CargarFila(Fila, Me)
                    End If
                End With
            End Using
        Catch ex As Exception
            'Return li
        End Try

    End Sub

    Public Function StoreFillPedidoByCQV(ByVal IdCQV As Integer, ByRef _Conexion As MySqlConnection)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "FillPedidoByCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?id", IdCQV)
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

    Public Shared Function FillListByTelefonoDomicilio(ByVal domicilio_id As Integer, ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
                    .CommandText &= "WHERE domicilio_id = ?domicilio_id AND telefono_id=?telefono_id"
                    .Parameters.AddWithValue("?domicilio_id", domicilio_id)
                    .Parameters.AddWithValue("?telefono_id", telefono_id)
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

    Public Shared Function StoreFillListPendientes(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)

                With exe
                    .CommandText = "FillListPendientes"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?operador", operador_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try

    End Function
    Public Shared Function StoreFillListPendientesCQV(ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "FillListPendientesCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try

    End Function
    Public Shared Function StoreFillListPendientesApipe(ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "FillListPendientesApipe"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try

    End Function
    Public Shared Function StoreFillListPendientesIVR(ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "FillListPendientesIVR"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try

    End Function

    Public Shared Function StoreFillListPendientesCount(ByRef _Conexion As MySqlConnection) As Integer
        Try
            Using exe As New MySqlCommand
                'Dim Lista As New List(Of String)
                With exe
                    .CommandText = "CargarPedidosCount"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _Conexion
                    'exe.ExecuteNonQuery()
                    Return exe.ExecuteScalar()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function StoreFillListCancelados(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "FillListCancelados"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?operador", operador_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            'Return li
        End Try
    End Function

    Public Shared Function StoreFillListCanceladosCount(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As Integer
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of String)
                With exe
                    .CommandText = "CargarCanceladosCount"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?parmoperadorid", operador_id)
                    .Connection = _Conexion
                    Return exe.ExecuteScalar()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Shared Function StoreFillListACompletar(ByRef _Conexion As MySqlConnection, Optional ByVal operador_id As Integer = 0, Optional ByVal frecuencia_id As Integer = 0) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandType = CommandType.StoredProcedure
                    If frecuencia_id <> 0 Then
                        .CommandText = "FillListACompletarFrecuencia"
                        .Parameters.AddWithValue("?frecuencia", frecuencia_id)
                    Else
                        .CommandText = "FillListACompletar"
                        If operador_id <> 0 Then
                            .CommandText = "FillListACompletarOperador"
                            .Parameters.AddWithValue("?operador_id", operador_id)

                        End If
                    End If

                    '.CommandText = "CargarMovilesZonaI"
                    .CommandType = CommandType.StoredProcedure
                    '.Parameters.AddWithValue("?zonaid", zonas)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return New List(Of pedido)
        End Try

    End Function

    Public Shared Function FillListCompletados(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As List(Of pedido)

        Using exe As New MySqlCommand
            Dim Lista As New List(Of pedido)
            Try
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
                    .CommandText &= "WHERE operador_id = ?operador_id AND NOT ISNULL(completado) AND NOT ISNULL(movil_id)  ORDER BY asignado ASC"
                    .Parameters.AddWithValue("?operador_id", operador_id)
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Try
                        Ta.Fill(Dt)
                        CargarLista(Dt, Lista)
                    Catch ex As Exception

                    End Try

                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return Lista
            Catch ex As Exception
                Return Lista
            End Try
        End Using
    End Function

    Public Shared Function StoreFillListCompletadosUltimos(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer, ByVal frecuencia_id As Integer) As List(Of pedido)
        Dim Lista As New List(Of pedido)
        Try
            Using exe As New MySqlCommand

                With exe
                    If frecuencia_id <> 0 Then
                        .CommandText = "ListCompletadosUltimosFrecuencia"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("?frecuencia", frecuencia_id)
                    Else
                        .CommandText = "ListCompletadosUltimosOperador"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("?operador", operador_id)
                    End If

                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return Lista
        End Try


    End Function

    Public Function FillListByTelefono(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
                    .CommandText &= "WHERE telefono_id = ?telefono_id ORDER BY fechahora_viaje DESC"
                    .Parameters.AddWithValue("?telefono_id", telefono_id)
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Try
                        Ta.Fill(Dt)
                        CargarLista(Dt, Lista)
                    Catch ex As Exception

                    End Try

                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception

        End Try
    End Function

    Public Function FillListByTelefono10(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of pedido)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
                    .CommandText &= "WHERE telefono_id = ?telefono_id ORDER BY fechahora_viaje DESC LIMIT 50 "
                    .Parameters.AddWithValue("?telefono_id", telefono_id)
                    .Connection = _Conexion
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Try
                        Ta.Fill(Dt)
                        CargarLista(Dt, Lista)
                    Catch ex As Exception

                    End Try

                    Ta.Dispose()
                    Dt.Dispose()
                End With
                Return Lista
            End Using
        Catch ex As Exception

        End Try
    End Function

    Public Function StoreFillListByTelefono5(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Dim Lista As New List(Of pedido)
        Try
            Using exe As New MySqlCommand

                With exe
                    .CommandText = "FillPedidoByTelefono"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?telefono", telefono_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return Lista
        End Try

    End Function

    Public Function StoreFillListByTelefono50(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Dim Lista As New List(Of pedido)
        Try
            Using exe As New MySqlCommand

                With exe
                    .CommandText = "FillPedidoByTelefono50"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?telefono", telefono_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                End With
                Return Lista
            End Using
        Catch ex As Exception
            Return Lista
        End Try

    End Function

    'Public Function FillListByTelefono50(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
    '    Try
    '        Using exe As New MySqlCommand
    '            Dim Lista As New List(Of pedido)
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
    '                .CommandText &= "WHERE telefono_id = ?telefono_id ORDER BY fechahora_viaje DESC LIMIT 50"
    '                .Parameters.AddWithValue("?telefono_id", telefono_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)
    '                Catch ex As Exception

    '                End Try

    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Function

    Public Overloads Shared Function FillListBuscador(ByRef _Conexion As MySqlConnection, ByVal desde As String, ByVal hasta As String, ByVal pedido_categoria_id As Integer) As List(Of pedido)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of pedido)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM pedido p "
                If desde <> "1900-01-01 00:00:00" Then

                    .CommandText &= "WHERE fechahora_viaje between '" & desde & "' AND '" & hasta & "' And pedido_categoria_id = ?pedido_categoria_id order by fechahora_viaje DESC"
                    .Parameters.AddWithValue("?pedido_categoria_id", pedido_categoria_id)
                End If

                '            If frecuencia_id <> 0 Then
                '                .CommandText &= "JOIN operador o ON o.entidad_id=p.operador_id " & vbNewLine & "WHERE o.frecuencia_id=?frecuencia_id "
                '                .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)
                '                If operador_id <> 0 Then
                '                    .CommandText &= "AND operador_id <> ?operador_id "
                '                    .Parameters.AddWithValue("?operador_id", operador_id)
                '                End If
                '            Else
                '                .CommandText &= "WHERE 1=1 "
                '                If operador_id <> 0 Then
                '                    .CommandText &= "AND operador_id = ?operador_id "
                '                    .Parameters.AddWithValue("?operador_id", operador_id)
                '                End If
                '            End If



                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Try
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)
                Catch ex As Exception

                End Try

                Ta.Dispose()
                Dt.Dispose()
            End With
            Return Lista
        End Using
    End Function

    Public Shared Function StoreDomicilioZona(ByRef _Conexion As MySqlConnection, ByVal domicilio As Integer, ByVal zona As Integer) As Boolean
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "DomicilioZona"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?domicilio", domicilio)
                    .Parameters.AddWithValue("?zona", zona)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function TomarLiberar(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional operador_id As Integer = 0) As Boolean

    Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "TomarLiberar"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?operador", operador_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception
          
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function CancelarPedido(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional telefonista As Integer = 0) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CancelarPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?telefonista", telefonista)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function CancelarPedidoCQV(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional telefonista As Integer = 0, Optional movilNro As Integer = 0) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CancelarPedidoCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?telefonista", telefonista)
                    .Parameters.AddWithValue("?movilNro", movilNro)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function ModificarPedido(ByVal fechahoraviaje As DateTime, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional telefonista As Integer = 0) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ModificarPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?telefonista", telefonista)
                    .Parameters.AddWithValue("?fechahoraviaje", fechahoraviaje)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function
    Public Function ModificarPedidoObservaciones(ByVal observaciones As String, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional telefonista As Integer = 0) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ModificarPedidoObservaciones"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?telefonista", telefonista)
                    .Parameters.AddWithValue("?observacionparm", observaciones)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function GenerarPedido(ByVal clientenya As String, ByVal fechahoraviaje As Object, ByVal obs As Object, ByVal usuarioid As Object, ByVal categoria As Object, ByVal dom As Object, ByVal tel As Object, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "GenerarPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?cliente", clientenya)
                    .Parameters.AddWithValue("?fechahoraviaje", fechahoraviaje)
                    .Parameters.AddWithValue("?observacion", obs)
                    .Parameters.AddWithValue("?usuario", usuarioid)
                    .Parameters.AddWithValue("?categoria", categoria)
                    .Parameters.AddWithValue("?domicilio", dom)
                    .Parameters.AddWithValue("?telefono", tel)

                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function GenerarPedidoCQV(ByVal clientenya As String, ByVal fechahoraviaje As Object, ByVal obs As Object, ByVal usuarioid As Object, ByVal categoria As Object, ByVal dom As Object, ByVal tel As Object, ByVal idCQV As Integer, ByVal Estado As String, ByVal movil As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "GenerarPedidoCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?cliente", clientenya)
                    .Parameters.AddWithValue("?fechahoraviaje", fechahoraviaje)
                    .Parameters.AddWithValue("?observacion", obs)
                    .Parameters.AddWithValue("?usuario", usuarioid)
                    .Parameters.AddWithValue("?categoria", categoria)
                    .Parameters.AddWithValue("?domicilio", dom)
                    .Parameters.AddWithValue("?telefono", tel)
                    .Parameters.AddWithValue("?idCQV", idCQV)
                    .Parameters.AddWithValue("?Estado", Estado)
                    .Parameters.AddWithValue("?Movil", movil)

                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function TraspasarPedidos(ByVal frecuencia As Integer, ByVal operador As Integer, ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "PedidoTraspasar"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?frecuencia", frecuencia)
                    .Parameters.AddWithValue("?operador", operador)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function

    Public Function Liberar(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0) As Boolean
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "Liberar"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
        End Function

    Public Function LiberarCQV(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0) As Boolean
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "LiberarCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True
    End Function
    Public Function AsignarPedido(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional movil_id As Integer = 0, Optional chofer_id As Integer = 0, Optional operador_id As Integer = 0) As Boolean

        'Dim sqlParam As New MySqlParameter
        'Dim transaction As MySqlTransaction
        'Using cmd As New MySqlCommand
        '    If _Conexion Is Nothing Then
        '        _Conexion.Open()
        '    End If
        '    If _tran Is Nothing Then
        '        transaction = _Conexion.BeginTransaction()
        '    Else
        '        transaction = _tran
        '    End If
        '    cmd.Transaction = transaction
        '    cmd.Connection = _Conexion
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "AsignarPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?movil", movil_id)
                    .Parameters.AddWithValue("?chofer", chofer_id)
                    .Parameters.AddWithValue("?operador", operador_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

            'cmd.ExecuteNonQuery()
            'If _tran Is Nothing Then
            '    transaction.Commit()
            'End If
            'cmd.Dispose()


        Catch ex As Exception
            'If _tran Is Nothing Then
            '    transaction.Rollback()
            'End If
            Throw New Exception(ex.Message)
        End Try
        Return True
        'End Using
    End Function

    Public Function AsignarPedidoCQV(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional movil_id As Integer = 0) As Boolean

        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "AsignarPedidoCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?movil", movil_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return True

    End Function

    Public Function ModificarEstadoPedido(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional idCQV As Integer = 0, Optional estado As String = "") As Boolean
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ModificarEstadoPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?idCQV", idCQV)
                    .Parameters.AddWithValue("?estado", estado)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
        Return True
        'End Using
    End Function

    Public Function CompletarPedido(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional _
                                       ByVal operador As Integer = 0, Optional ByVal obs As String = "") As Boolean

        'Dim sqlParam As New MySqlParameter
        'Dim transaction As MySqlTransaction
        'Using cmd As New MySqlCommand
        '    If _Conexion Is Nothing Then
        '        _Conexion.Open()
        '    End If
        '    If _tran Is Nothing Then
        '        transaction = _Conexion.BeginTransaction()
        '    Else
        '        transaction = _tran
        '    End If
        '    cmd.Transaction = transaction
        '    cmd.Connection = _Conexion
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CompletarPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?operador", operador)
                    .Parameters.AddWithValue("?observacionparm", obs)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

            'cmd.ExecuteNonQuery()
            'If _tran Is Nothing Then
            '    transaction.Commit()
            'End If
            'cmd.Dispose()


        Catch ex As Exception
            'If _tran Is Nothing Then
            '    transaction.Rollback()
            'End If
            Throw New Exception(ex.Message)
        End Try
        Return True
        'End Using
    End Function


    Public Function CompletarPedidoCQV(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional _
                                       ByVal operador As Integer = 0, Optional ByVal obs As String = "") As Boolean
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CompletarPedidoCQV"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?operador", operador)
                    .Parameters.AddWithValue("?observacionparm", obs)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using


        Catch ex As Exception
     
            Throw New Exception(ex.Message)
        End Try
        Return True

    End Function

    Public Function Resetear(ByRef _Conexion As MySqlConnection, Optional ByRef _tran As MySqlTransaction = Nothing, Optional pedido_id As Integer = 0, Optional operador_id As Integer = 0) As Boolean

        'Dim sqlParam As New MySqlParameter
        'Dim transaction As MySqlTransaction
        'Using cmd As New MySqlCommand
        '    If _Conexion Is Nothing Then
        '        _Conexion.Open()
        '    End If
        '    If _tran Is Nothing Then
        '        transaction = _Conexion.BeginTransaction()
        '    Else
        '        transaction = _tran
        '    End If
        '    cmd.Transaction = transaction
        '    cmd.Connection = _Conexion
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ResetearPedido"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?pedido", pedido_id)
                    .Parameters.AddWithValue("?operador", operador_id)
                    .Connection = _Conexion
                    exe.ExecuteNonQuery()
                End With
            End Using

            'cmd.ExecuteNonQuery()
            'If _tran Is Nothing Then
            '    transaction.Commit()
            'End If
            'cmd.Dispose()


        Catch ex As Exception
            'If _tran Is Nothing Then
            '    transaction.Rollback()
            'End If
            Throw New Exception(ex.Message)
        End Try
        Return True
        'End Using
    End Function

    'Public Shared Function FillListPendientes(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As List(Of pedido)

    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of pedido)
    '        Try
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
    '                .CommandText &= "WHERE ISNULL(movil_id) AND((SELECT TIMEDIFF(p.fechahora_viaje,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))<'00:11:00') AND (ISNULL(operador_id) OR operador_id=?operador_id) AND ISNULL(cancelado) ORDER BY pedido_categoria_id DESC, fechahora_viaje ASC"
    '                .Parameters.AddWithValue("?operador_id", operador_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)
    '                Catch ex As Exception

    '                End Try

    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        Catch ex As Exception
    '            'Return Lista
    '            '_Conexion.Close()
    '            '_Conexion.Open()
    '        End Try
    '    End Using
    'End Function

    'Public Shared Function FillListPendientesCount(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As Integer

    '    Using exe As New MySqlCommand
    '        Try
    '            With exe
    '                .CommandText = "SELECT count(*) FROM pedido p" & vbCrLf
    '                .CommandText &= "WHERE ISNULL(movil_id) AND((SELECT TIMEDIFF(p.fechahora_viaje,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))<'00:11:00') AND (ISNULL(operador_id) OR operador_id=?operador_id) AND ISNULL(cancelado) ORDER BY pedido_categoria_id DESC, fechahora_viaje ASC"
    '                .Parameters.AddWithValue("?operador_id", operador_id)
    '                .Connection = _Conexion

    '            End With
    '            Return exe.ExecuteScalar
    '        Catch ex As Exception
    '            Return 0
    '        End Try
    '    End Using
    'End Function

    'Public Function FillListCancelados(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As List(Of pedido)

    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of pedido)
    '        Try
    '            With exe
    '                '.CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
    '                '.CommandText &= "WHERE ((SELECT TIMEDIFF(p.fechahora_viaje,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))<'00:12:00') AND (ISNULL(operador_id) OR operador_id=?operador_id) AND (cancelado) is not null ORDER BY cancelado ASC"
    '                .CommandText = "SELECT * FROM pedido p WHERE (SELECT TIMEDIFF(NOW(),p.fechahora_viaje))<'00:20:00' AND (SELECT TIMEDIFF(NOW(),p.fechahora_viaje))>'00:00:00' AND (ISNULL(operador_id) OR operador_id=?operador_id) AND (cancelado) IS NOT NULL ORDER BY cancelado ASC"
    '                .Parameters.AddWithValue("?operador_id", operador_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)
    '                Catch ex As Exception
    '                End Try
    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        Catch ex As Exception
    '            'Return Lista
    '        End Try
    '    End Using
    'End Function

    'Public Function FillListCanceladosCount(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer) As Integer

    '    Using exe As New MySqlCommand
    '        Try
    '            With exe
    '                .CommandText = "SELECT COUNT(*) FROM pedido p WHERE (SELECT TIMEDIFF(NOW(),p.fechahora_viaje))<'00:20:00' AND (SELECT TIMEDIFF(NOW(),p.fechahora_viaje))>'00:00:00' AND (ISNULL(operador_id) OR operador_id=?operador_id) AND (cancelado) IS NOT NULL"
    '                .Parameters.AddWithValue("?operador_id", operador_id)
    '                .Connection = _Conexion

    '            End With
    '            Return exe.ExecuteScalar
    '        Catch ex As Exception
    '            Return 0
    '        End Try
    '    End Using
    'End Function

    'Public Shared Function FillListACompletar(ByRef _Conexion As MySqlConnection, Optional ByVal operador_id As Integer = 0, Optional ByVal frecuencia_id As Integer = 0) As List(Of pedido)

    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of pedido)
    '        Try
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
    '                If frecuencia_id <> 0 Then
    '                    .CommandText &= "JOIN movil o ON o.id=p.movil_id " & vbNewLine & "WHERE o.frecuencia_id=?frecuencia_id "
    '                    .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)
    '                Else
    '                    .CommandText &= "JOIN movil o ON o.id=p.movil_id "
    '                    .CommandText &= "WHERE 1=1 "
    '                    If operador_id <> 0 Then
    '                        .CommandText &= "AND operador_id = ?operador_id "
    '                        .Parameters.AddWithValue("?operador_id", operador_id)

    '                    End If
    '                End If
    '                .CommandText &= "AND ISNULL(completado) AND NOT ISNULL(movil_id) "
    '                .CommandText &= "ORDER BY o.numero ASC "
    '                .Connection = _Conexion

    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)

    '                Catch ex As Exception

    '                End Try
    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        Catch ex As Exception
    '            Return Lista
    '        End Try
    '    End Using
    'End Function

    'Public Shared Function FillListCompletadosUltimos(ByRef _Conexion As MySqlConnection, ByVal operador_id As Integer, ByVal frecuencia_id As Integer) As List(Of pedido)

    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of pedido)
    '        Try
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
    '                If frecuencia_id <> 0 Then
    '                    .CommandText &= "JOIN movil o ON o.id=p.movil_id " & vbNewLine & "WHERE o.frecuencia_id=?frecuencia_id "
    '                    .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)

    '                Else
    '                    .CommandText &= "WHERE 1=1 "
    '                    If operador_id <> 0 Then
    '                        .CommandText &= "AND operador_id = ?operador_id "
    '                        .Parameters.AddWithValue("?operador_id", operador_id)
    '                    End If
    '                End If
    '                .CommandText &= "AND NOT ISNULL(completado) AND NOT ISNULL(movil_id) AND (((SELECT TIMEDIFF(p.completado,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))<'-00:45:00')or ((SELECT TIMEDIFF(p.completado,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))>'00:00:00')) ORDER BY completado DESC LIMIT 50"
    '                .Connection = _Conexion
    '                Try
    '                    Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                    Try
    '                        Ta.Fill(Dt)
    '                        CargarLista(Dt, Lista)
    '                    Catch ex As Exception

    '                    End Try

    '                    Ta.Dispose()
    '                    Dt.Dispose()
    '                Catch ex As Exception

    '                End Try

    '            End With
    '            Return Lista
    '        Catch ex As Exception
    '            Return Lista
    '        End Try
    '    End Using
    'End Function

    'Public Function FillListByTelefono5(ByVal telefono_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
    '    Try
    '        Using exe As New MySqlCommand
    '            Dim Lista As New List(Of pedido)
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
    '                .CommandText &= "WHERE telefono_id = ?telefono_id ORDER BY fechahora_viaje DESC LIMIT 5"
    '                .Parameters.AddWithValue("?telefono_id", telefono_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Try
    '                    Ta.Fill(Dt)
    '                    CargarLista(Dt, Lista)
    '                Catch ex As Exception

    '                End Try

    '                Ta.Dispose()
    '                Dt.Dispose()
    '            End With
    '            Return Lista
    '        End Using
    '    Catch ex As Exception

    '    End Try
#End Region

End Class
