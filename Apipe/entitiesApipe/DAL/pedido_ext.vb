Imports MySql.Data.MySqlClient

Partial Public Class pedido
#Region "Propiedades para la vista"
    Public ReadOnly Property v_hora As String
        Get
            Return Me.fechahora.TimeOfDay.ToString.Substring(0, 5)
        End Get
    End Property
    Public ReadOnly Property v_hora_viaje As String
        Get
            Return Me.fechahora_viaje.TimeOfDay.ToString.Substring(0, 5)
        End Get
    End Property
    Public ReadOnly Property v_hora_asignado As String
        Get
            Return Me.asignado.TimeOfDay.ToString.Substring(0, 5)
        End Get
    End Property
    Public ReadOnly Property v_domicilio As String
        Get
            If Me.domicilio_id > 0 And Me.telefono_id > 0 Then
                Return Me.TelefonoDomicilio.Domicilio.calle & " " & Me.TelefonoDomicilio.Domicilio.numero
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property v_modeloChapa As String
        Get
            If Me.movil_id > 0 Then
                With Me.ChoferMovil.Movil
                    Return .modelo & " " & .chapa
                End With
            End If
            Return ""
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
#End Region
#Region "Funciones"
    Public Shared Function FillListPendientes(ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of pedido)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
                .CommandText &= "WHERE ISNULL(movil_id) ORDER BY fechahora_viaje DESC"
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
    Public Shared Function FillListACompletar(ByVal operador_id As Integer, ByRef _Conexion As MySqlConnection) As List(Of pedido)
        Using exe As New MySqlCommand
            Dim Lista As New List(Of pedido)
            With exe
                .CommandText = "SELECT " & CAMPOS & " FROM pedido p" & vbCrLf
                .CommandText &= "WHERE operador_id = ?operador_id and ISNULL(completado) ORDER BY fechahora_viaje DESC"
                .Parameters.AddWithValue("?operador_id", operador_id)
                .Connection = _Conexion
                Dim Ta As New MySqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)
            End With
            Return Lista
        End Using
    End Function
#End Region

End Class
