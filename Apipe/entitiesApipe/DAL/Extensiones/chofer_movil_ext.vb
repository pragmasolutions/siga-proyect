Imports MySql.Data.MySqlClient

Partial Public Class chofer_movil
#Region "Propiedades para la Vista"
    Public ReadOnly Property v_nroMovil As String
        Get
            Return Me.Movil.numero
        End Get
    End Property
    Public ReadOnly Property v_zona As String
        Get

            If Me.Movil.en_zona = "1900-01-01 00:00:00" Then
                Return "S/B"
            Else
                Return Me.Movil.Zona.nombre
            End If
        End Get
    End Property

    Public ReadOnly Property v_Movil As String
        Get
            Return Me.Movil.numero & " " & Me.Movil.modelo & " " & Me.Movil.chapa
        End Get
    End Property
    Public ReadOnly Property v_chofer_AyN As String
        Get
            Return Me.Chofer.Entidad.apellido & ", " & Me.Chofer.Entidad.nombre
        End Get
    End Property
    Public ReadOnly Property v_modelo As String
        Get
            Return Me.Movil.modelo
        End Get
    End Property
    Private _v_cantPedidos As Integer
    Public Property v_cantPedidos As Integer
        Get
            Return _v_cantPedidos
        End Get
        Set(ByVal value As Integer)
            _v_cantPedidos = value
        End Set
    End Property
    Private _v_ultimoPedido As Date
    Public Property v_ultimoPedido As Date
        Get
            Return _v_ultimoPedido
        End Get
        Set(ByVal value As Date)
            _v_ultimoPedido = value
        End Set
    End Property
    Public ReadOnly Property v_horaUltPed As String
        Get
            If v_ultimoPedido.Date = Now.Date Then
                Return v_ultimoPedido.ToShortTimeString
            Else
                If v_ultimoPedido <> Nothing Then Return v_ultimoPedido.ToShortDateString
            End If
            Return ""
        End Get
    End Property
#End Region

#Region "Funciones"
    Public Shared Function StoreFillListByMovil(ByVal movil_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of chofer_movil)
         Dim Lista As New List(Of chofer_movil)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "ChoferMovilByMovil"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?movil", movil_id)
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

    Public Overloads Shared Function FillListByFilter(ByRef _Conexion As MySqlConnection, _
                                                      Optional ByVal soloVigenes As Boolean = True, _
                                                      Optional ByVal filtrarActivos As String = "TODOS") As List(Of chofer_movil)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of chofer_movil)
                With exe
                    .CommandText = "SELECT " & CAMPOS & " FROM chofer_movil c" & vbNewLine
                    .CommandText &= "WHERE 1=1 "
                    If soloVigenes Then
                        .CommandText &= " AND (ISNULL(fin) OR fin > NOW())"
                    End If
                    If filtrarActivos.ToUpper = "ACTIVOS" Then
                        .CommandText &= " AND activo"
                    ElseIf filtrarActivos.ToUpper = "INACTIVOS" Then
                        .CommandText &= " AND NOT activo"
                    End If
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

    Public Shared Function StoreFillListByFrecuencia(ByRef _Conexion As MySqlConnection, ByVal frecuencia_id As Integer, Optional ByVal soloActivos As Boolean = False) As List(Of chofer_movil)
        Dim Lista As New List(Of chofer_movil)
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CargarMovilesZonaFrecuencia"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?frecuencia", frecuencia_id)
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

    Public Shared Function StoreFillListByZona(ByRef _Conexion As MySqlConnection, ByVal zonas As Integer) As List(Of chofer_movil)
        Try
            Using exe As New MySqlCommand
                Dim Lista As New List(Of chofer_movil)
                With exe
                    .CommandText = "CargarMovilesZonaI"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?zonaid", zonas)
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

    Public Shared Function StoreFillListByZonaCount(ByRef _Conexion As MySqlConnection, ByVal zona_id As Integer) As Integer
        Try
            Using exe As New MySqlCommand
                With exe
                    .CommandText = "CargarZonasCount"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("?zonaid", zona_id)
                    .Connection = _Conexion
                    Return exe.ExecuteScalar()
                End With
                Return True
            End Using
        Catch ex As Exception
            Return 0
        End Try

    End Function
    'Public Shared Function FillListByZona(ByRef _Conexion As MySqlConnection, ByVal zona_id As Integer, Optional ByVal soloActivos As Boolean = False) As List(Of chofer_movil)

    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of chofer_movil)
    '        Try
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS
    '                '.CommandText &= ", (SELECT COUNT(*) FROM pedido p WHERE p.movil_id=c.movil_id AND p.chofer_id=c.chofer_id  LIMIT 1) as v_cantPedidos" '** controlar el tema del turno
    '                '.CommandText &= ", (SELECT p.asignado FROM pedido p WHERE p.movil_id=c.movil_id AND p.chofer_id=c.chofer_id ORDER BY p.asignado DESC LIMIT 1) as v_ultimoPedido" + vbNewLine
    '                .CommandText &= " FROM chofer_movil c" + vbNewLine
    '                .CommandText &= " JOIN movil m ON m.id=c.movil_id " + vbNewLine
    '                .CommandText &= "WHERE NOT ISNULL(m.en_zona) AND m.zona_id=?zona_id "
    '                If soloActivos Then .CommandText &= " AND c.activo "
    '                .CommandText &= vbNewLine & "ORDER BY m.en_zona ASC"
    '                .Parameters.AddWithValue("?zona_id", zona_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Ta.Fill(Dt)
    '                If Dt.Rows.Count > 0 Then
    '                    For Each Fila As DataRow In Dt.Rows
    '                        Dim O As New chofer_movil
    '                        CargarFila(Fila, O)
    '                        'If Fila.Item("v_cantPedidos") IsNot DBNull.Value Then O.v_cantPedidos = Fila.Item("v_cantPedidos") Else O.v_cantPedidos = 0
    '                        'If Fila.Item("v_ultimoPedido") IsNot DBNull.Value Then O.v_ultimoPedido = Date.Parse(Fila.Item("v_ultimoPedido").ToString) Else O.v_ultimoPedido = "1900-01-01 00:00:00"
    '                        Lista.Add(O)
    '                    Next
    '                End If

    '                Ta.Dispose()
    '                Dt.Dispose()
    '                '.Connection.Close()

    '            End With
    '            Return Lista

    '        Catch ex As Exception
    '            'Return Lista
    '        End Try
    '    End Using
    'End Function


    'Public Shared Function FillListByZonaCount(ByRef _Conexion As MySqlConnection, ByVal zona_id As Integer, Optional ByVal soloActivos As Boolean = False) As Integer
    '    Using exe As New MySqlCommand
    '        Try
    '            With exe
    '                .CommandText = "SELECT COUNT(*) FROM movil m WHERE en_zona AND m.zona_id=?zona_id "
    '                .Parameters.AddWithValue("?zona_id", zona_id)
    '                .Connection = _Conexion

    '            End With
    '            Return exe.ExecuteScalar

    '        Catch ex As Exception
    '            Return 0
    '        End Try
    '    End Using
    'End Function

    'Public Shared Function FillListByFrecuencia(ByRef _Conexion As MySqlConnection, ByVal frecuencia_id As Integer, Optional ByVal soloActivos As Boolean = False) As List(Of chofer_movil)
    '    Try
    '        Using exe As New MySqlCommand
    '            Dim Lista As New List(Of chofer_movil)
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS
    '                .CommandText &= ", (SELECT COUNT(*) FROM pedido p WHERE p.movil_id=c.movil_id AND p.chofer_id=c.chofer_id  LIMIT 1) as v_cantPedidos"
    '                .CommandText &= ", (SELECT p.asignado FROM pedido p WHERE p.movil_id=c.movil_id AND p.chofer_id=c.chofer_id ORDER BY p.asignado DESC LIMIT 1) as v_ultimoPedido"
    '                .CommandText &= " FROM chofer_movil c"
    '                .CommandText &= " JOIN movil m ON m.id=c.movil_id " & vbNewLine & "WHERE m.frecuencia_id=?frecuencia_id "
    '                If soloActivos Then .CommandText &= " AND c.activo "
    '                .CommandText &= vbNewLine & "ORDER BY m.numero"
    '                .Parameters.AddWithValue("?frecuencia_id", frecuencia_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Ta.Fill(Dt)
    '                CargarLista(Dt, Lista)
    '                If Dt.Rows.Count > 0 Then
    '                    For Each Fila As DataRow In Dt.Rows
    '                        Dim O As New chofer_movil
    '                        CargarFila(Fila, O)
    '                        If Fila.Item("v_cantPedidos") IsNot DBNull.Value Then O.v_cantPedidos = Fila.Item("v_cantPedidos") Else O.v_cantPedidos = 0
    '                        If Fila.Item("v_ultimoPedido") IsNot DBNull.Value Then O.v_ultimoPedido = Date.Parse(Fila.Item("v_ultimoPedido").ToString) Else O.v_ultimoPedido = "1900-01-01 00:00:00"
    '                        Lista.Add(O)
    '                    Next
    '                End If
    '                Dt.Dispose()
    '                Ta.Dispose()
    '            End With
    '            Return Lista
    '        End Using
    '       Catch ex As Exception

    '    End Try
    'End Function

    'Public Shared Function FillListByZona(ByRef _Conexion As MySqlConnection, ByVal zona_id As Integer, Optional ByVal soloActivos As Boolean = False) As List(Of chofer_movil)
    '    'ya tiene Store StoreFillListByZona
    '    Using exe As New MySqlCommand
    '        Dim Lista As New List(Of chofer_movil)
    '        Try
    '            With exe
    '                .CommandText = "SELECT " & CAMPOS
    '                .CommandText &= ", (SELECT COUNT(*) FROM pedido p WHERE p.movil_id=c.movil_id AND p.chofer_id=c.chofer_id  LIMIT 1) as v_cantPedidos" '** controlar el tema del turno
    '                .CommandText &= ", (SELECT p.asignado FROM pedido p WHERE p.movil_id=c.movil_id AND p.chofer_id=c.chofer_id ORDER BY p.asignado DESC LIMIT 1) as v_ultimoPedido" + vbNewLine
    '                .CommandText &= " FROM chofer_movil c" + vbNewLine
    '                .CommandText &= " JOIN movil m ON m.id=c.movil_id " + vbNewLine
    '                .CommandText &= "WHERE NOT ISNULL(m.en_zona) AND m.zona_id=?zona_id "
    '                If soloActivos Then .CommandText &= " AND c.activo "
    '                .CommandText &= vbNewLine & "ORDER BY m.en_zona ASC"
    '                .Parameters.AddWithValue("?zona_id", zona_id)
    '                .Connection = _Conexion
    '                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
    '                Ta.Fill(Dt)
    '                If Dt.Rows.Count > 0 Then
    '                    For Each Fila As DataRow In Dt.Rows
    '                        Dim O As New chofer_movil
    '                        CargarFila(Fila, O)
    '                        If Fila.Item("v_cantPedidos") IsNot DBNull.Value Then O.v_cantPedidos = Fila.Item("v_cantPedidos") Else O.v_cantPedidos = 0
    '                        If Fila.Item("v_ultimoPedido") IsNot DBNull.Value Then O.v_ultimoPedido = Date.Parse(Fila.Item("v_ultimoPedido").ToString) Else O.v_ultimoPedido = "1900-01-01 00:00:00"
    '                        Lista.Add(O)
    '                    Next
    '                End If

    '                Ta.Dispose()
    '                Dt.Dispose()
    '                '.Connection.Close()

    '            End With
    '            Return Lista

    '        Catch ex As Exception
    '            Return Lista
    '        End Try
    '    End Using
    'End Function
#End Region
End Class

