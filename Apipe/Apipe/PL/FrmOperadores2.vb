Imports System.Net.Sockets
Imports System.Net
Imports System.Threading

Public Class FrmOperadores2
    Dim cls As New ClsAdministrarPedidos
    Dim clsStore As New ClsStores
    Dim bgsPedidos, bgsMoviles, bgsACompletar, bgsCompletados, bgsZona1, bgsZona2, bgsZona3, bgsZona4, bgsZona5, bgsZona6, bgsZona7, bgsZona8, bgsZona9, bgsZona10, bgsZonaP, bgsZonaT As New BindingSource
    Dim Servidor As TcpListener = New TcpListener(IPAddress.Any, 6600)
    Dim tipoAsignacion As String = "" ' FRECUENCIA | ZONA
    ' Dim t As New Threading.Thread(AddressOf listen)
    Dim SubBase As Integer
    Dim Funcion As String = ""
    Dim Negativo As Boolean = False
    Dim CantidadReclamos As Integer = 0
    Dim CantidadCancelados As Integer = 0
    'Dim CantidadEnZona As Integer = 0
    Dim ContadorCancelados As Integer = 0
    Dim ContadorReclamos As Integer = 0

#Region "Inicializar"
    Public Sub New()
        Try
            InitializeComponent()
            cls.Operador = ClsVariableSesion.Instancia.Usuario.Operador 'hago esto para evitar poner tanto c|digo... cada vez que quiero consultar por el operador accedo a Cls.Operador        
         TimerSubbases.Start()
            TimerPendientes.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "1")
        End Try

    End Sub
    Private Sub Prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Store OK
        Try
            cls.TraspasarPedidosFrecuencia(cls.Operador.frecuencia_id, My.Settings.idUsuario) 'necesito que esté cargado el Operador (se hace en el new)

            CantidadReclamos = cls.FillReclamosCount
            CantidadCancelados = cls.CargarPedidosCanceladosCount
            'CantidadEnZona = cls.ContarMovilesEnZona

            dgvPedidos.AutoGenerateColumns = False
            dgvACompletar.AutoGenerateColumns = False
            dgvCompletados.AutoGenerateColumns = False

            dgvPedidos.DataSource = bgsPedidos

            'para grilla
            dgvZ1.AutoGenerateColumns = False
            dgvZ1.DataSource = bgsZona1
            dgvZ2.AutoGenerateColumns = False
            dgvZ2.DataSource = bgsZona2
            dgvZ3.AutoGenerateColumns = False
            dgvZ3.DataSource = bgsZona3
            dgvZ4.AutoGenerateColumns = False
            dgvZ4.DataSource = bgsZona4
            dgvZ5.AutoGenerateColumns = False
            dgvZ5.DataSource = bgsZona5
            dgvZ6.AutoGenerateColumns = False
            dgvZ6.DataSource = bgsZona6
            dgvZ7.AutoGenerateColumns = False
            dgvZ7.DataSource = bgsZona7
            dgvZ8.AutoGenerateColumns = False
            dgvZ8.DataSource = bgsZona8
            dgvZ9.AutoGenerateColumns = False
            dgvZ9.DataSource = bgsZona9
            dgvZ10.AutoGenerateColumns = False
            dgvZ10.DataSource = bgsZona10
            dgvZP.AutoGenerateColumns = False
            dgvZP.DataSource = bgsZonaP
            dgvZT.AutoGenerateColumns = False
            dgvZT.DataSource = bgsZonaT

            '
            dgvACompletar.DataSource = bgsACompletar
            dgvCompletados.DataSource = bgsCompletados


            ActualizarSubBases()
            ActualizarPedidos()
            BuscarACompletar()
            BuscarCompletados()
            Habilitar("P")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "2")
        End Try

    End Sub
#End Region

#Region "Pedidos"
    ''' <summary>Busca los pedidos cuando la cantidad de pedidos en el DGVpendientes es distinta a la cantidad en la base de datos.</summary>
    Private Sub BuscarPedidos()
        'Store OK
        Dim idactual As Integer = 0
        Dim rowindex As Integer = 0
        Dim dcantpedidos As Integer = 0
        Dim ultimopedido As Integer = 0
        Try
            If asignar = False Then
                If dgvPedidos.CurrentRow IsNot Nothing Then
                    idactual = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id
                    rowindex = dgvPedidos.CurrentRow.Index
                    dcantpedidos = dgvPedidos.Rows.Count
                    ultimopedido = CType(dgvPedidos.Rows(dcantpedidos - 1).DataBoundItem, pedido).id
                End If

                Dim pendientes As Integer = cls.CargarPedidosCount
                'Dim pendientes As Integer = 999
                'mantiene la seleccion de la fila del dgv cuando cambian los pedidos.
                If pendientes > 0 Then
                    cls.CargarPedidos()
                    ' If (dgvPedidos.RowCount <> pendientes Or cls.lstPedido.Last.id <> ultimopedido) Then
                    bgsPedidos.DataSource = cls.lstPedido
                    bgsPedidos.ResetBindings(False)
                    PintarPedidos()
                    If idactual <> CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id Then
                        If rowindex <> 0 Then
                            dgvPedidos.Item(0, rowindex + (cls.lstPedido.Count - dcantpedidos)).Selected = True
                        End If
                    End If
                    'End If
                Else
                    ActualizarPedidos()
                End If
                If dgvACompletar.Focused = True Or dgvCompletados.Focused = True Then
                    dgvPedidos.CurrentCell = Nothing
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "3a")
        End Try

    End Sub
    Private Sub ActualizarPedidos()
        'Store Ok
        Try
            cls.CargarPedidos()
            bgsPedidos.DataSource = cls.lstPedido
            bgsPedidos.ResetBindings(False)
            PintarPedidos()
            'End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "3b")
        End Try

    End Sub
    Private Sub ActualizarCancelados()
        Try
            If ContadorCancelados = 0 And ContadorReclamos = 0 Then
                lblNotificaciones.Visible = False
                lblNotificaciones.Text = ""

            ElseIf ContadorCancelados <> 0 Then
                ManejarContador(ContadorCancelados)
            End If

            Dim cancelados As Integer = cls.CargarPedidosCanceladosCount
            If cancelados <> CantidadCancelados Then
                ContadorCancelados = 1
                CantidadCancelados = cancelados
                cls.CargarPedidosCancelados()

                If cls.LstPedidoCancelado.Last.Movil.frecuencia_id = ClsVariableSesion.Instancia.Usuario.Operador.frecuencia_id Then
                    lblNotificaciones.Visible = True
                    If cls.LstPedidoCancelado.Last.completado <> "1900-01-01 00:00:00" Then
                        lblNotificaciones.Text = "Nuevo Pedido Cancelado en Completados del movil " + cls.LstPedidoCancelado.Last.v_nroMovil
                        BuscarCompletados()
                    ElseIf cls.LstPedidoCancelado.Last.asignado <> "1900-01-01 00:00:00" Then
                        lblNotificaciones.Text = "Nuevo Pedido Cancelado en A Completar del movil " + cls.LstPedidoCancelado.Last.v_nroMovil
                        BuscarACompletar()
                    Else
                        ActualizarPedidos()
                    End If
                End If
            End If
        Catch ex As Exception
            lblMensajes.Text = "Fallo en la conexión cancelados"
        End Try

    End Sub
    Private Sub ManejarContador(ByRef contador As Integer)
        If contador < 10 Then
            contador = contador + 1
        Else
            contador = 0
        End If
    End Sub

    Private Sub ActualizarReclamos()

        Try
            If ContadorReclamos = 0 And ContadorCancelados = 0 Then
                lblNotificaciones.Visible = False
                lblNotificaciones.Text = ""

            ElseIf ContadorReclamos <> 0 Then
                ManejarContador(ContadorReclamos)
            End If

            Dim reclamos As Integer = cls.FillReclamosCount()
            If reclamos <> CantidadReclamos Then
                lblNotificaciones.Text = ""
                ContadorReclamos = 1
                cls.FillReclamos()

                Dim rl As New reclamo_linea
                rl = cls.LstReclamo_Linea.Last
                CantidadReclamos = reclamos
                If rl.Reclamo.Pedido.completado <> "1900-01-01 00:00:00" Then
                    If rl.Reclamo.Pedido.Movil.frecuencia_id = cls.Operador.frecuencia_id Then
                        lblNotificaciones.Visible = True
                        lblNotificaciones.Text = "Nuevo Reclamo en Completados del movil " + rl.Reclamo.Pedido.v_nroMovil
                        BuscarCompletados()
                    End If
                ElseIf rl.Reclamo.Pedido.asignado <> "1900-01-01 00:00:00" Then
                    If rl.Reclamo.Pedido.Movil.frecuencia_id = cls.Operador.frecuencia_id Then
                        lblNotificaciones.Visible = True
                        lblNotificaciones.Text = "Nuevo Reclamo en A Completar del movil " + rl.Reclamo.Pedido.v_nroMovil
                        BuscarACompletar()
                    End If
                Else
                    If rl.Reclamo.Pedido.Movil.frecuencia_id = cls.Operador.frecuencia_id Then
                        lblNotificaciones.Visible = True
                        lblNotificaciones.Text = "Nuevo Reclamo en Pendientes"
                        ActualizarPedidos()
                    End If
                End If
            End If
        Catch ex As Exception

            lblMensajes.Text = "Fallo en la conexión"
            ClsVariableSesion.Instancia.getConn.Close()
            ClsVariableSesion.Instancia.getConn.Open()
        End Try


    End Sub

    Private Sub TratarPedidoTomado()
        Try
            For Each p In (From ped In cls.lstPedido Where ped.operador_id > 0 And ped.operador_id = cls.Operador.entidad_id And ped.movil_id = 0).ToList
                bgsPedidos.Position = bgsPedidos.List.IndexOf(p)
                indicePedido = bgsPedidos.Position
                Habilitar("M")
                Exit For
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "4")
        End Try

    End Sub

    Public Sub PintarPedidos()
        Try
            For Each r As DataGridViewRow In dgvPedidos.Rows
                Dim pedido As pedido = CType(r.DataBoundItem, pedido)
                With pedido
                    If .operador_id > 0 Then
                        r.Cells(colPedAsignar.Name).Value = My.Resources.manoce
                        r.Cells(colPedAsignar.Name).ToolTipText = "Cancelar asignación"
                    Else
                        r.Cells(colPedAsignar.Name).Value = My.Resources.manoab
                        r.Cells(colPedAsignar.Name).ToolTipText = "Asignar móvil"
                    End If
                    If .pedido_categoria_id = 3 Then 'Pedido diferido
                        r.Cells(0).Style.BackColor = Color.Maroon
                        r.Cells(1).Style.BackColor = Color.Maroon
                        r.Cells(3).Style.BackColor = Color.Maroon
                        r.Cells(4).Style.BackColor = Color.Maroon
                        r.Cells(5).Style.BackColor = Color.Maroon
                    ElseIf .pedido_categoria_id = 5 Then 'ART
                        r.Cells(0).Style.BackColor = Color.Purple
                        r.Cells(1).Style.BackColor = Color.Purple
                        r.Cells(3).Style.BackColor = Color.Purple
                        r.Cells(4).Style.BackColor = Color.Purple
                        r.Cells(5).Style.BackColor = Color.Purple
                    ElseIf .pedido_categoria_id = 6 Then 'IVR
                        r.Cells(0).Style.BackColor = Color.Pink
                        r.Cells(1).Style.BackColor = Color.Pink
                        r.Cells(3).Style.BackColor = Color.Pink
                        r.Cells(3).Style.ForeColor = Color.Black
                        r.Cells(4).Style.BackColor = Color.Pink
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Pink
                        r.Cells(5).Style.ForeColor = Color.Black
                    ElseIf .pedido_categoria_id = 7 Then 'CQV
                        r.Cells(0).Style.BackColor = Color.Cyan
                        r.Cells(1).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.ForeColor = Color.Cyan
                        r.Cells(4).Style.BackColor = Color.Cyan
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Cyan
                        r.Cells(5).Style.ForeColor = Color.Black
                    End If

                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colPedReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colPedReclamo.Name).ToolTipText = .v_reclamos
                        If .lst_Reclamo.First.lst_ReclamoLinea.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                        ElseIf .lst_Reclamo.First.lst_ReclamoLinea.Count = 2 Then
                            r.Cells(0).Style.BackColor = Color.Orange
                            r.Cells(1).Style.BackColor = Color.Orange
                            r.Cells(2).Style.BackColor = Color.Orange
                            r.Cells(3).Style.BackColor = Color.Orange
                            r.Cells(4).Style.BackColor = Color.Orange
                            r.Cells(5).Style.BackColor = Color.Orange
                        Else
                            r.Cells(0).Style.BackColor = Color.Red
                            r.Cells(1).Style.BackColor = Color.Red
                            r.Cells(2).Style.BackColor = Color.Red
                            r.Cells(3).Style.BackColor = Color.Red
                            r.Cells(4).Style.BackColor = Color.Red
                            r.Cells(5).Style.BackColor = Color.Red
                        End If
                    Else
                        r.Cells(colPedReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colPedReclamo.Name).ToolTipText = "Sin reclamo"
                    End If
            
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "5")
        End Try
    End Sub

    Private Sub PintarPedidoActual()
        Try
            If dgvPedidos.CurrentRow IsNot Nothing Then
                With dgvPedidos.CurrentRow
                    If cls.Pedido.operador_id > 0 Then 'pedido tomado por este usuario
                        .Cells(colPedAsignar.Name).Value = My.Resources.manoce
                        .Cells(colPedAsignar.Name).ToolTipText = "Cancelar asignación"
                    Else
                        .Cells(colPedAsignar.Name).Value = My.Resources.manoab
                        .Cells(colPedAsignar.Name).ToolTipText = "Asignar móvil"
                    End If
                    If cls.Pedido.lst_Reclamo.Count > 0 Then
                        .Cells(colPedReclamo.Name).Value = My.Resources.signoreclamo
                        .Cells(colPedReclamo.Name).ToolTipText = cls.Pedido.v_reclamos
                    Else
                        .Cells(colPedReclamo.Name).Value = My.Resources.vacio
                        .Cells(colPedReclamo.Name).ToolTipText = "Sin reclamo"
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "6")
        End Try
    End Sub

    Private Sub dgvPedidos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPedidos.SelectionChanged
        Try
            If bgsPedidos.Count > 0 Then
                If indicePedido > -1 Then bgsPedidos.Position = indicePedido
                cls.Pedido = bgsPedidos.Item(bgsPedidos.Position)
                If dgvPedidos.Focused Then
                    DatosPedido()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "7")
        End Try

    End Sub

    Private Sub dgvPedidos_Enter(sender As System.Object, e As System.EventArgs) Handles dgvPedidos.Enter
        Try
            dgvPedidos.Focus()
            txtPedidos.BackColor = Color.White
            txtACompletar.BackColor = Color.Black
            txtCompletados.BackColor = Color.Black

            dgvPedidos.BackgroundColor = Color.Gray
            dgvCompletados.CurrentCell = Nothing
            DatosPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "49")
        End Try

    End Sub

    Private Sub dgvPedidos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvPedidos.DataBindingComplete
        Try
            txtPedidos.Text = dgvPedidos.RowCount & " PEDIDOS PENDIENTES"
            txtPedidos.SelectAll()
            txtPedidos.SelectionAlignment = HorizontalAlignment.Center
            txtPedidos.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "8")
        End Try

    End Sub

    Private Sub DatosPedido()
        Try
            txtDetalle.Text = ""
            gbxDetalle.Text = "PEDIDO PENDIENTE"
            txtDetalle.ForeColor = Color.White

            Dim reclamo As String = ""
            If dgvPedidos.CurrentRow IsNot Nothing Then
                With cls.Pedido
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & " " & .Estado & vbNewLine
                    txtDetalle.Text &= "Domicilio: " & .v_domicilio
                    If .v_observacion.Length > 0 Then txtDetalle.Text &= " " & .v_observacion
                    txtDetalle.Text &= " Cliente: " & .cliente
                    If .v_nroMovil.Length > 0 Then txtDetalle.Text &= vbNewLine & "Movil: " & .v_nroMovil
                    txtDetalle.Text &= " Viaje: " & .v_hora_viaje

                    If .lst_Reclamo.Count > 0 Then
                        For i As Integer = 0 To .lst_Reclamo.First.lst_ReclamoLinea.Count - 1
                            reclamo = reclamo & .lst_Reclamo.First.lst_ReclamoLinea.Item(i).comentario & "; "
                        Next
                        txtDetalle.Text &= vbNewLine & "Reclamo: " & reclamo
                    End If
                    Try
                        Detalle("Observaciones:")
                        Detalle(.observacion, True)
                        Detalle("Domicilio:")
                        Detalle(.v_domicilio, True)
                        Detalle("Cliente:")
                        Detalle(.cliente, True)
                        Detalle("Movil:")
                        Detalle(.v_nroMovil, True)
                        Detalle("Hora:")
                        Detalle(.v_hora_viaje, True)
                        Detalle("Reclamo:")
                        If .lst_Reclamo.Count > 0 Then
                            Detalle(reclamo, True)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "9b")
                    End Try

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "9")
        End Try

    End Sub

    Private Sub dgvPedidos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        Try
            If cls.Operador.entidad_id <> 0 And e.ColumnIndex = colPedAsignar.Index Then 'sólo permito asignar si el usuario tiene un operador asignado
                cls.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
                'BITACORA PEDIDO - TOMA PEDIDO
                cls.PedidobyId(cls.Pedido.id)
                If cls.Pedido.operador_id = 0 Then
                    indicePedido = bgsPedidos.Position
                    cls.Pedido.operador_id = cls.Operador.entidad_id
                    'cls.PersistirPedido()
                    cls.TomarLiberarPedido(cls.Pedido.id, cls.Operador.entidad_id)
                    PintarPedidoActual()
                    Habilitar("M")
                Else
                    cls.Pedido.operador_id = 0
                    cls.Pedido.asignado = "1900-01-01 00:00:00"
                    'cls.TomarLiberarPedido(cls.Pedido.id, vbNull)
                    cls.LiberarPedido(cls.Pedido.id)
                    'cls.PersistirPedido()
                    Habilitar("P")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "10")
        End Try

    End Sub
#End Region

#Region "Moviles"
    Private Sub BuscarMoviles()
        Try
            If tipoAsignacion = "ZONA" Then
                cls.CargarMovilesZona()
                bgsMoviles.DataSource = cls.lstChoferMovil
            Else
                cls.CargarMoviles()
                bgsMoviles.DataSource = cls.lstChoferMovil
            End If
            PintarMoviles(dgvZ1)
            PintarMoviles(dgvZ2)
            PintarMoviles(dgvZ3)
            PintarMoviles(dgvZ4)
            PintarMoviles(dgvZ5)
            PintarMoviles(dgvZ6)
            PintarMoviles(dgvZ7)
            PintarMoviles(dgvZ8)
            PintarMoviles(dgvZ9)
            PintarMoviles(dgvZ10)
            PintarMoviles(dgvZP)
            PintarMoviles(dgvZT)
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "11")
        End Try

    End Sub
    Private Sub CargarSubBases()
        'StoreOK
        ' esta funcion se ejecuta en el timersubbases, siempre
        Try

            Dim zona As Integer = cls.ContarMovilesZonaI(1)
            If dgvZ1.RowCount <> zona Then
                cls.CargarMovilesZonaI(1)
                bgsZona1.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ1)
                dgvZ1.CurrentCell = Nothing
            End If

            zona = cls.ContarMovilesZonaI(2)
            If dgvZ2.RowCount <> zona Then
                cls.CargarMovilesZonaI(2)
                bgsZona2.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ2)
                dgvZ2.CurrentCell = Nothing
            End If

            zona = cls.ContarMovilesZonaI(3)
            If dgvZ3.RowCount <> zona Then
                cls.CargarMovilesZonaI(3)
                bgsZona3.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ3)
                dgvZ3.CurrentCell = Nothing
            End If


            zona = cls.ContarMovilesZonaI(4)
            If dgvZ4.RowCount <> zona Then
                cls.CargarMovilesZonaI(4)
                bgsZona4.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ4)
                dgvZ4.CurrentCell = Nothing
            End If


            zona = cls.ContarMovilesZonaI(5)
            If dgvZ5.RowCount <> zona Then
                cls.CargarMovilesZonaI(5)
                bgsZona5.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ5)
                dgvZ5.CurrentCell = Nothing
            End If

            zona = cls.ContarMovilesZonaI(6)
            If dgvZ6.RowCount <> zona Then
                cls.CargarMovilesZonaI(6)
                bgsZona6.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ6)
                dgvZ6.CurrentCell = Nothing
            End If

            zona = cls.ContarMovilesZonaI(7)
            If dgvZ7.RowCount <> zona Then
                cls.CargarMovilesZonaI(7)
                bgsZona7.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ7)
                dgvZ7.CurrentCell = Nothing
            End If

            zona = cls.ContarMovilesZonaI(8)
            If dgvZ8.RowCount <> zona Then
                cls.CargarMovilesZonaI(8)
                bgsZona8.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ8)
                dgvZ8.CurrentCell = Nothing
            End If

            zona = cls.ContarMovilesZonaI(9)
            If dgvZ9.RowCount <> zona Then
                cls.CargarMovilesZonaI(9)
                bgsZona9.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ9)
                dgvZ9.CurrentCell = Nothing
            End If


            zona = cls.ContarMovilesZonaI(10)
            If dgvZ10.RowCount <> zona Then
                cls.CargarMovilesZonaI(10)
                bgsZona10.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ10)
                dgvZ10.CurrentCell = Nothing
            End If


            zona = cls.ContarMovilesZonaI(11)
            If dgvZP.RowCount <> zona Then
                cls.CargarMovilesZonaI(11)
                bgsZonaP.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZP)
                dgvZP.CurrentCell = Nothing
            End If


            zona = cls.ContarMovilesZonaI(12)
            If dgvZT.RowCount <> zona Then
                cls.CargarMovilesZonaI(12)
                bgsZonaT.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZT)
                dgvZT.CurrentCell = Nothing
            End If

            '     End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "12")
        End Try
    End Sub
   
    Private Sub ActualizarSubBases()
        'storeOk
        ' esta funcion se ejecuta cuando se modifica la ubicacion de un movil en una subbase..
        Try
            If dgvZ1.RowCount <> cls.ContarMovilesZonaI(1) Then
                cls.CargarMovilesZonaI(1)
                bgsZona1.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ1)
                dgvZ1.CurrentCell = Nothing

            End If


            If dgvZ2.RowCount <> cls.ContarMovilesZonaI(2) Then
                cls.CargarMovilesZonaI(2)
                bgsZona2.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ2)
                dgvZ2.CurrentCell = Nothing
            End If



            If dgvZ3.RowCount <> cls.ContarMovilesZonaI(3) Then
                cls.CargarMovilesZonaI(3)
                bgsZona3.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ3)
                dgvZ3.CurrentCell = Nothing
            End If



            If dgvZ4.RowCount <> cls.ContarMovilesZonaI(4) Then
                cls.CargarMovilesZonaI(4)
                bgsZona4.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ4)
                dgvZ4.CurrentCell = Nothing
            End If



            If dgvZ5.RowCount <> cls.ContarMovilesZonaI(5) Then
                cls.CargarMovilesZonaI(5)
                bgsZona5.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ5)
                dgvZ5.CurrentCell = Nothing
            End If


            If dgvZ6.RowCount <> cls.ContarMovilesZonaI(6) Then
                cls.CargarMovilesZonaI(6)
                bgsZona6.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ6)
                dgvZ6.CurrentCell = Nothing
            End If

            If dgvZ7.RowCount <> cls.ContarMovilesZonaI(7) Then
                cls.CargarMovilesZonaI(7)
                bgsZona7.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ7)
                dgvZ7.CurrentCell = Nothing
            End If

            If dgvZ8.RowCount <> cls.ContarMovilesZonaI(8) Then
                cls.CargarMovilesZonaI(8)
                bgsZona8.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ8)
                dgvZ8.CurrentCell = Nothing
            End If

            If dgvZ9.RowCount <> cls.ContarMovilesZonaI(9) Then
                cls.CargarMovilesZonaI(9)
                bgsZona9.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ9)
                dgvZ9.CurrentCell = Nothing
            End If

            If dgvZ10.RowCount <> cls.ContarMovilesZonaI(10) Then
                cls.CargarMovilesZonaI(10)
                bgsZona10.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZ10)
                dgvZ10.CurrentCell = Nothing
            End If

            If dgvZP.RowCount <> cls.ContarMovilesZonaI(11) Then
                cls.CargarMovilesZonaI(11)
                bgsZonaP.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZP)
                dgvZP.CurrentCell = Nothing
            End If


            If dgvZT.RowCount <> cls.ContarMovilesZonaI(12) Then
                cls.CargarMovilesZonaI(12)
                bgsZonaT.DataSource = cls.lstChoferMovilZonai
                PintarMoviles(dgvZT)
                dgvZT.CurrentCell = Nothing
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "12")
        End Try
    End Sub

    Private Sub PintarMoviles(dgv As DataGridView)
        Try
            For Each r As DataGridViewRow In dgv.Rows
                With CType(r.DataBoundItem, chofer_movil)
                    If .Movil.frecuencia_id = cls.Operador.frecuencia_id Then
                        r.Cells(0).Style.BackColor = Color.Green
                    Else
                        r.Cells(0).Style.BackColor = Color.Gray
                    End If

                End With
            Next
            dgv.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    'Private Sub dgvMoviles_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If bgsMoviles.Count > 0 Then
    '            cls.ChoferMovil = bgsMoviles.Item(bgsMoviles.Position)
    '            End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "13")
    '    End Try

    'End Sub
    'Private Sub DatosMovil(ByRef dgv As DataGridView)
    '    Try
    '        txtDetalle.Text = ""
    '        gbxDetalle.Text = "MÓVIL"
    '        If dgv.CurrentRow IsNot Nothing Then
    '            cls.ChoferMovil = CType(dgv.CurrentRow.DataBoundItem, chofer_movil)
    '            txtDetalle.ForeColor = Color.White
    '            With cls.ChoferMovil
    '                gbxDetalle.Text = "MÓVIL N° " & .v_nroMovil
    '                txtDetalle.Text = " Automóvil: " & .Movil.marca & " " & .Movil.modelo & " " & .Movil.color & " " & .Movil.chapa
    '                txtDetalle.Text &= " Chofer: " & .v_chofer_AyN
    '                txtDetalle.Text &= " Aire Acondicionado: " & IIf(.Movil.aire, "Sí", "No")
    '                txtDetalle.Text &= " Baúl:" & .Movil.baul & " Teléfono: " & .Movil.telefono
    '                If .observacion.Length > 0 Then txtDetalle.Text &= " Observaciones: " & .observacion
    '                Detalle("Automóvil:")
    '                Detalle("Chofer:")
    '                Detalle("Aire Acondicionado:")
    '                Detalle("Baúl:")
    '                Detalle("Teléfono:")
    '                Detalle("Observaciones:")
    '            End With
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "14")
    '    End Try
    '
    'End Sub

#End Region

#Region "ACompletar"
    Private Sub BuscarACompletar()
        'StoreOK
        Try
            cls.CargarACompletarFrecuencia()
            bgsACompletar.DataSource = cls.lstPedidoACompletar
            PintarACompletar()
            If dgvACompletar.Focused = False Then
                dgvACompletar.CurrentCell = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "16")
        End Try

    End Sub

    Public Sub PintarACompletar()
        Try
            For Each r In dgvACompletar.Rows
                With CType(r.DataBoundItem, pedido)
                    r.Cells(colACompCompletar.Name).ToolTipText = "Completar pedido"
                    If .pedido_categoria_id = 3 Then
                        r.Cells(0).Style.BackColor = Color.Maroon
                        r.Cells(1).Style.BackColor = Color.Maroon
                        r.Cells(3).Style.BackColor = Color.Maroon
                        r.Cells(4).Style.BackColor = Color.Maroon
                        r.Cells(5).Style.BackColor = Color.Maroon
                        r.Cells(6).Style.BackColor = Color.Maroon
                        r.Cells(7).Style.BackColor = Color.Maroon
                    ElseIf .pedido_categoria_id = 5 Then
                        r.Cells(0).Style.BackColor = Color.Purple
                        r.Cells(1).Style.BackColor = Color.Purple
                        r.Cells(3).Style.BackColor = Color.Purple
                        r.Cells(4).Style.BackColor = Color.Purple
                        r.Cells(5).Style.BackColor = Color.Purple
                        r.Cells(6).Style.BackColor = Color.Purple
                        r.Cells(7).Style.BackColor = Color.Purple
                    ElseIf .pedido_categoria_id = 6 Then
                        r.Cells(0).Style.BackColor = Color.Pink
                        r.Cells(1).Style.BackColor = Color.Pink
                        r.Cells(3).Style.BackColor = Color.Pink
                        r.Cells(3).Style.ForeColor = Color.Black
                        r.Cells(4).Style.BackColor = Color.Pink
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Pink
                        r.Cells(5).Style.ForeColor = Color.Black
                        r.Cells(6).Style.BackColor = Color.Pink
                        r.Cells(6).Style.ForeColor = Color.Black
                        r.Cells(7).Style.BackColor = Color.Pink
                        r.Cells(7).Style.ForeColor = Color.Black
                    ElseIf .pedido_categoria_id = 7 Then 'CQV
                        r.Cells(0).Style.BackColor = Color.Cyan
                        r.Cells(1).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.ForeColor = Color.Black
                        r.Cells(4).Style.BackColor = Color.Cyan
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Cyan
                        r.Cells(5).Style.ForeColor = Color.Black
                        r.Cells(6).Style.BackColor = Color.Cyan
                        r.Cells(6).Style.ForeColor = Color.Black
                        r.Cells(7).Style.BackColor = Color.Cyan
                        r.Cells(7).Style.ForeColor = Color.Black
                    End If

                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colACompReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colACompReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
                        If .lst_Reclamo.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                            r.Cells(6).Style.BackColor = Color.Green
                            r.Cells(7).Style.BackColor = Color.Green
                        ElseIf .lst_Reclamo.Count = 2 Then
                            r.Cells(0).Style.BackColor = Color.Orange
                            r.Cells(1).Style.BackColor = Color.Orange
                            r.Cells(2).Style.BackColor = Color.Orange
                            r.Cells(3).Style.BackColor = Color.Orange
                            r.Cells(4).Style.BackColor = Color.Orange
                            r.Cells(5).Style.BackColor = Color.Orange
                            r.Cells(6).Style.BackColor = Color.Orange
                            r.Cells(7).Style.BackColor = Color.Orange
                        Else
                            r.Cells(0).Style.BackColor = Color.Red
                            r.Cells(1).Style.BackColor = Color.Red
                            r.Cells(2).Style.BackColor = Color.Red
                            r.Cells(3).Style.BackColor = Color.Red
                            r.Cells(4).Style.BackColor = Color.Red
                            r.Cells(5).Style.BackColor = Color.Red
                            r.Cells(6).Style.BackColor = Color.Red
                            r.Cells(7).Style.BackColor = Color.Red
                        End If
                    Else
                        r.Cells(colACompReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colACompReclamo.Name).ToolTipText = "Sin reclamo"
                    End If

                    If .cancelado <> "1900-01-01 00:00:00" Then
                        r.Cells(colACompCambiarMovil.Name).Value = My.Resources.notiene
                        r.Cells(colACompCambiarMovil.Name).ToolTipText = "Pedido cancelado"
                        r.Cells(0).Style.BackColor = Color.Blue
                        r.Cells(1).Style.BackColor = Color.Blue
                        r.Cells(2).Style.BackColor = Color.Blue
                        r.Cells(3).Style.BackColor = Color.Blue
                        r.Cells(4).Style.BackColor = Color.Blue
                        r.Cells(5).Style.BackColor = Color.Blue
                        r.Cells(6).Style.BackColor = Color.Blue
                        r.Cells(7).Style.BackColor = Color.Blue
                    Else
                        r.Cells(colACompCambiarMovil.Name).Value = My.Resources.movil
                        r.Cells(colACompCambiarMovil.Name).ToolTipText = "Cambiar móvil"
                    End If

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "17")
        End Try
    End Sub

    Private Sub dgvACompletar_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvACompletar.SelectionChanged
        Try
            If bgsACompletar.Count > 0 Then
                If indiceACompletar > -1 Then bgsACompletar.Position = indiceACompletar
                cls.PedidoACompletar = bgsACompletar.Item(bgsACompletar.Position)
                If dgvACompletar.Focused Then
                    DatosACompletar()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "18")
        End Try

    End Sub

    Private Sub dgvACompletar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvACompletar.Enter
        Try
            dgvACompletar.Focus()
            txtPedidos.BackColor = Color.Black
            txtACompletar.BackColor = Color.White
            txtCompletados.BackColor = Color.Black
            dgvACompletar.BackgroundColor = Color.Gray
            If Not asignar Then ' dgvMoviles.Enabled 
                dgvPedidos.CurrentCell = Nothing
            End If
            dgvCompletados.CurrentCell = Nothing
            DatosACompletar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "19")
        End Try

    End Sub

    Private Sub dgvACompletar_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvACompletar.DataBindingComplete
        Try
            txtACompletar.Text = dgvACompletar.RowCount & " PEDIDOS A COMPLETAR"
            txtACompletar.SelectAll()
            txtACompletar.SelectionAlignment = HorizontalAlignment.Center
            txtACompletar.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "20")
        End Try

    End Sub

    Private Sub DatosACompletar()
        Try
            txtDetalle.Text = ""
            gbxDetalle.Text = "PEDIDO A COMPLETAR"

            Dim reclamo As String = ""

            If dgvACompletar.CurrentRow IsNot Nothing Then
                txtDetalle.ForeColor = Color.White
                With cls.PedidoACompletar
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & " " & .Estado & vbNewLine
                    txtDetalle.Text &= "Domicilio: " & .v_domicilio
                    If .v_observacion.Length > 0 Then txtDetalle.Text &= " " & .v_observacion
                    txtDetalle.Text &= " Cliente: " & .cliente
                    If .v_nroMovil.Length > 0 Then txtDetalle.Text &= vbNewLine & "Movil: " & .v_nroMovil
                    txtDetalle.Text &= " Viaje: " & .v_hora_viaje

                    If .lst_Reclamo.Count > 0 Then
                        For i As Integer = 0 To .lst_Reclamo.First.lst_ReclamoLinea.Count - 1
                            reclamo = reclamo & .lst_Reclamo.First.lst_ReclamoLinea.Item(i).comentario & "; "
                        Next
                        txtDetalle.Text &= vbNewLine & "Reclamo: " & reclamo

                    End If
                    Detalle("Observaciones:")
                    Detalle(.observacion, True)
                    Detalle("Domicilio:")
                    Detalle(.v_domicilio, True)
                    Detalle(.v_observacion, True)
                    Detalle("Cliente:")
                    Detalle(.cliente, True)
                    Detalle("Movil:")
                    Detalle(.v_nroMovil, True)
                    Detalle("Hora:")
                    Detalle(.v_hora_viaje, True)
                    Detalle("Reclamo:")
                    If .lst_Reclamo.Count > 0 Then
                        Detalle(reclamo, True)
                    End If

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "21")
        End Try

    End Sub

    Dim indiceACompletar As Integer = -1

    Private Sub dgvACompletar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvACompletar.CellClick
        Try
            If e.ColumnIndex = colACompCompletar.Index Then
                With cls.PedidoACompletar
                    Dim frm As New FrmOkCancel("¿Completar el pedido del móvil " & .ChoferMovil.v_nroMovil & "?", Nothing)
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        .completado = cls.FechaHora
                        cls.Pedido = cls.PedidoACompletar

                        cls.CompletarPedido(cls.Pedido.id, My.Settings.idUsuario)
                        'cls.PersistirPedido()

                        ' cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
                        'cls.lstPedidoCompletado.Add(cls.PedidoACompletar)
                        bgsACompletar.ResetBindings(False)
                        bgsCompletados.ResetBindings(False)
                        BuscarACompletar()
                        BuscarCompletados()
                    End If
                End With

                'ElseIf e.ColumnIndex = colmensajero.Index Then 'mensajero

                '    If cls.PedidoACompletar.Movil.telefono <> "" Then
                '        With cls.PedidoACompletar
                '            Dim frm As New FrmOkCancel("¿Completar el pedido del móvil mediante SMS " & .ChoferMovil.v_nroMovil & "?", Nothing)
                '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                '                .completado = cls.FechaHora
                '                cls.Pedido = cls.PedidoACompletar
                '                cls.PersistirPedido()
                '                cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
                '                cls.lstPedidoCompletado.Add(cls.PedidoACompletar)
                '                bgsACompletar.ResetBindings(False)
                '                PintarACompletar()
                '                Dim cliente As String = cls.Pedido.v_domicilio & " - " & cls.Pedido.v_clienteAyN
                '                MandarMensaje(cls.Pedido.Movil.telefono, cliente)
                '            End If
                '            ' dgvCompletados.Enabled
                '        End With
                '    Else
                '        Dim frm As New FrmMensajes("Este móvil no posee número agendado para el envío de mensajes", MousePosition)
                '        frm.Show()
                '    End If

            ElseIf cls.Operador.entidad_id <> 0 And e.ColumnIndex = colACompCambiarMovil.Index Then 'sólo permito cambiar el móvil si el usuario tiene un operador asociado
                With cls.PedidoACompletar
                    If .cancelado = "1900-01-01 00:00:00" Then
                        If indicePedido = -1 Then 'si no estoy asignando móvil a un pedido
                            If indiceACompletar = -1 Then
                                Dim frm As New FrmOkCancel("¿Cambiar el móvil " & .ChoferMovil.v_nroMovil & " por otro?", Nothing)
                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    indiceACompletar = bgsACompletar.Position
                                    cls.Pedido = cls.PedidoACompletar
                                    dgvCompletados.Enabled = False
                                    dgvACompletar.CurrentCell.ToolTipText = "Cancelar asignación"
                                    Habilitar("M")
                                    lblMensajes.Text = "Ingrese el numero de móvil que desea asignar"
                                    txtFuncionMovil.Visible = True
                                    txtFuncionMovil.Focus()
                                    Funcion = "movil"
                                    BuscarACompletar()
                                End If
                            Else
                                Habilitar("P")
                            End If
                        End If
                    End If
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "22")
        End Try
    End Sub
#End Region

#Region "Completados"
    Private Sub BuscarCompletados()
        Try
            cls.CargarPedidosCompletadosUltimos()
            bgsCompletados.DataSource = cls.lstPedidoCompletado
            PintarCompletados()
            dgvCompletados.CurrentCell = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "23")
        End Try

    End Sub
    Public Sub PintarCompletados()
        Try
            For Each r In dgvCompletados.Rows
                With CType(r.DataBoundItem, pedido)
                    
                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colComReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colComReclamo.Name).ToolTipText = .v_reclamos '
                        If .lst_Reclamo.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                        ElseIf .lst_Reclamo.Count = 2 Then
                            r.Cells(0).Style.BackColor = Color.Orange
                            r.Cells(1).Style.BackColor = Color.Orange
                            r.Cells(2).Style.BackColor = Color.Orange
                            r.Cells(3).Style.BackColor = Color.Orange
                            r.Cells(4).Style.BackColor = Color.Orange
                            r.Cells(5).Style.BackColor = Color.Orange
                        Else
                            r.Cells(0).Style.BackColor = Color.Red
                            r.Cells(1).Style.BackColor = Color.Red
                            r.Cells(2).Style.BackColor = Color.Red
                            r.Cells(3).Style.BackColor = Color.Red
                            r.Cells(4).Style.BackColor = Color.Red
                            r.Cells(5).Style.BackColor = Color.Red
                        End If
                    Else
                        r.Cells(colComReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colComReclamo.Name).ToolTipText = "Sin reclamo"
                    End If

                    If .cancelado <> "1900-01-01 00:00:00" Then
                        r.Cells(colComVolver.Name).Value = My.Resources.notiene
                        r.Cells(colComVolver.Name).ToolTipText = "Pedido cancelado"
                        r.Cells(0).Style.BackColor = Color.Blue
                        r.Cells(1).Style.BackColor = Color.Blue
                        r.Cells(2).Style.BackColor = Color.Blue
                        r.Cells(3).Style.BackColor = Color.Blue
                        r.Cells(4).Style.BackColor = Color.Blue
                        r.Cells(5).Style.BackColor = Color.Blue
                    Else
                        r.Cells(colComVolver.Name).Value = My.Resources.deshacer
                        r.Cells(colComVolver.Name).ToolTipText = "Colocar como 'A Completar'"
                    End If
                End With
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "24")
        End Try
    End Sub

    Private Sub dgvCompletados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCompletados.SelectionChanged
        Try
            If bgsCompletados.Count > 0 Then
                cls.PedidoCompletado = bgsCompletados.Item(bgsCompletados.Position)
                If dgvCompletados.Focused Then
                    DatosCompletado()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "25")
        End Try

    End Sub

    Private Sub dgvCompletados_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCompletados.Enter
        Try
            dgvCompletados.Focus()
            txtPedidos.BackColor = Color.Black
            txtACompletar.BackColor = Color.Black
            txtCompletados.BackColor = Color.White

            dgvCompletados.BackgroundColor = Color.Gray
            If Not asignar Then ' dgvMoviles.Enabled
                dgvPedidos.CurrentCell = Nothing
            End If
            dgvACompletar.CurrentCell = Nothing
            DatosCompletado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "26")
        End Try

    End Sub

    Private Sub dgvCompletados_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvCompletados.DataBindingComplete
        Try
            txtCompletados.Text = dgvCompletados.RowCount & " PEDIDOS COMPLETADOS"
            txtCompletados.SelectAll()
            txtCompletados.SelectionAlignment = HorizontalAlignment.Center
            txtCompletados.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "27")
        End Try

    End Sub

    Private Sub DatosCompletado()
        Try
            txtDetalle.Text = ""
            gbxDetalle.Text = "PEDIDO COMPLETADO"

            Dim reclamo As String = ""
            If dgvCompletados.CurrentRow IsNot Nothing Then

                txtDetalle.ForeColor = Color.White
                With cls.PedidoCompletado
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & " " & .Estado & vbNewLine
                    txtDetalle.Text &= "Domicilio: " & .v_domicilio
                    If .v_observacion.Length > 0 Then txtDetalle.Text &= " " & .v_observacion
                    txtDetalle.Text &= " Cliente: " & .cliente
                    If .v_nroMovil.Length > 0 Then txtDetalle.Text &= vbNewLine & "Movil: " & .v_nroMovil
                    txtDetalle.Text &= " Viaje: " & .v_hora_viaje

                    If .lst_Reclamo.Count > 0 Then
                        For i As Integer = 0 To .lst_Reclamo.First.lst_ReclamoLinea.Count - 1
                            reclamo = reclamo & .lst_Reclamo.First.lst_ReclamoLinea.Item(i).comentario & "; "
                        Next
                        txtDetalle.Text &= vbNewLine & "Reclamo: " & reclamo

                    End If
                    Detalle("Observaciones:")
                    Detalle(.observacion, True)
                    Detalle("Domicilio:")
                    Detalle(.v_domicilio, True)
                    Detalle(.v_observacion, True)
                    Detalle("Cliente:")
                    Detalle(.cliente, True)
                    Detalle("Movil:")
                    Detalle(.v_nroMovil, True)
                    Detalle("Hora:")
                    Detalle(.v_hora_viaje, True)
                    Detalle("Reclamo:")
                    If .lst_Reclamo.Count > 0 Then
                        Detalle(reclamo, True)
                    End If

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "28")
        End Try

    End Sub

    Private Sub dgvCompletados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCompletados.CellClick
        Try
            If e.ColumnIndex = colComVolver.Index Then
                With cls.PedidoCompletado
                    Dim frm As New FrmOkCancel("¿Colocar el pedido del móvil " & .ChoferMovil.v_nroMovil & " como 'A Completar'?", Nothing)
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        .completado = "1900-01-01 00:00:00"
                        cls.Pedido = cls.PedidoCompletado
                        cls.PersistirPedido()
                        ' cls.lstPedidoCompletado.Remove(cls.PedidoCompletado)
                        'cls.lstPedidoACompletar.Add(cls.PedidoCompletado)
                        bgsCompletados.ResetBindings(False)
                        bgsACompletar.ResetBindings(False)

                        BuscarACompletar()
                        BuscarCompletados()
                    End If
                End With
                lblMensajes.Text = "Pedido A Completar"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "29")
        End Try

    End Sub

#End Region

#Region "Procedimientos y Funciones"
    Dim indicePedido As Integer = -1
    Dim asignar As Boolean = False
    ''' <summary>Habilita la sección indicada e inhabilita la otra.</summary>
    ''' <param name="s">Sección a habilitar: P=Pedido, M=Móvil</param>
    Private Sub Habilitar(ByVal s As Char)
        Try
            If s = "P" Then
                asignar = False
                indicePedido = -1

                If indiceACompletar > -1 Then
                    indiceACompletar = -1
                Else
                    dgvPedidos.Focus()
                    PintarPedidoActual()
                End If

                TratarPedidoTomado()
            Else
                asignar = True

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "30")
        End Try

    End Sub

    Private Sub Detalle(ByVal palabra As String, Optional ByVal pintar As Boolean = False)
        Try
            txtDetalle.Find(palabra, RichTextBoxFinds.MatchCase)
            If pintar Then txtDetalle.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "31")
        End Try

    End Sub
#End Region
    'Private Sub PedidoCambiado(ByVal pedido As pedido) 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
    '    Try
    '        Dim pedSel
    '        If dgvPedidos.CurrentCell IsNot Nothing Then pedSel = bgsPedidos.Current
    '        'BuscarPedidos()
    '        BuscarACompletar()
    '        BuscarCompletados()
    '        ' CargarSubBases()
    '        If pedSel IsNot Nothing Then
    '            Dim ped = (From p In cls.lstPedido Where p.id = pedSel.id)
    '            If ped.Count > 0 Then
    '                If indicePedido > -1 Then
    '                    indicePedido = cls.lstPedido.IndexOf(CType(ped.First, pedido))
    '                End If
    '                bgsPedidos.Position = cls.lstPedido.IndexOf(CType(ped.First, pedido))
    '            End If
    '        Else
    '            dgvPedidos.CurrentCell = Nothing
    '        End If

    '        Dim pac = cls.lstPedidoACompletar.Find(Function(x) x.id = pedido.id)
    '        If pac IsNot Nothing Then
    '            cls.lstPedidoACompletar.Item(cls.lstPedidoACompletar.IndexOf(pac)) = pedido.Clone
    '            bgsACompletar.ResetBindings(False)
    '            PintarACompletar()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "32")
    '    End Try

    'End Sub

    'Private Sub NuevoReclamo(ByVal reclamoLinea As reclamo_linea)
    '    Try
    '        Dim p = cls.lstPedido.Find(Function(x) x.id = reclamoLinea.Reclamo.pedido_id)
    '        If p IsNot Nothing Then
    '            p.lst_Reclamo = Nothing
    '            bgsPedidos.ResetBindings(False)
    '            PintarPedidos()
    '        Else
    '            p = cls.lstPedidoACompletar.Find(Function(x) x.id = reclamoLinea.Reclamo.pedido_id)
    '            If p IsNot Nothing Then
    '                p.lst_Reclamo = Nothing
    '                bgsACompletar.ResetBindings(False)
    '                PintarACompletar()
    '            Else
    '                p = cls.lstPedidoCompletado.Find(Function(x) x.id = reclamoLinea.Reclamo.pedido_id)
    '                If p IsNot Nothing Then
    '                    p.lst_Reclamo = Nothing
    '                    bgsCompletados.ResetBindings(False)
    '                    PintarCompletados()
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error funcion NuevoReclamo")
    '    End Try

    'End Sub


    '#Region "PUSH"
    '    'Dim CallPedidoCambiado As New MethodInvoker(AddressOf Me.PedidoCambiado)
    '    'Dim CallNuevoReclamo As New MethodInvoker(AddressOf Me.NuevoReclamo)
    '    'Dim P2 As New pedido
    '    'Dim RL As New reclamo_linea
    '    'Private Sub PedidoCambiado() 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
    '    '    Try
    '    '        PedidoCambiado(P2)

    '    '    Catch ex As Exception
    '    '        MessageBox.Show(ex.Message, "33")
    '    '    End Try

    '    'End Sub
    '    'Private Sub NuevoReclamo()
    '    '    Try
    '    '        NuevoReclamo(RL)
    '    '    Catch ex As Exception
    '    '        MessageBox.Show(ex.Message, "34")
    '    '    End Try

    '    'End Sub
    '    'Private Sub listen()
    '    '    'Try
    '    '    '    Do
    '    '    '        If TimerGral.Enabled Then
    '    '    '            Servidor.Start()
    '    '    '            'If lblMensajes.Text = "Sistema desactualizado - Presione ESC" Then
    '    '    '            'lblMensajes.Text = "Panel de Información actualizado"
    '    '    '            'End If
    '    '    '            Dim client As TcpClient = Servidor.AcceptTcpClient()
    '    '    '            Dim stream As NetworkStream = client.GetStream()
    '    '    '            Dim i As Int32
    '    '    '            Dim bytes(1024) As Byte
    '    '    '            Dim data As String = Nothing
    '    '    '            ' Loop to receive all the data sent by the client.
    '    '    '            i = stream.Read(bytes, 0, bytes.Length)
    '    '    '            While (i <> 0)
    '    '    '                ' Translate data bytes to a ASCII string.
    '    '    '                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i)

    '    '    '                Thread.Sleep(1000)
    '    '    '                My.Application.DoEvents()
    '    '    '                If IsNumeric(data) Then 'para pedidos recibo únicamente el id de pedido
    '    '    '                    P2 = New pedido
    '    '    '                    P2.FillBypedido(data, cls.getConn) '**estaba comentado, no sé por qué....
    '    '    '                    Me.BeginInvoke(CallPedidoCambiado)
    '    '    '                Else 'para reclamos recibo "RECLAMO_LINEA," & idReclamoLinea
    '    '    '                    If data.Contains("RECLAMO_LINEA") Then
    '    '    '                        Dim idRL = data.Split(",")(1)
    '    '    '                        If IsNumeric(idRL) Then
    '    '    '                            RL = New reclamo_linea
    '    '    '                            RL.FillByreclamo_linea(idRL, cls.getConn)
    '    '    '                            Me.BeginInvoke(CallNuevoReclamo)
    '    '    '                        End If
    '    '    '                    End If
    '    '    '                End If
    '    '    '                i = stream.Read(bytes, 0, bytes.Length)
    '    '    '            End While
    '    '    '            stream.Close()
    '    '    '        Else
    '    '    '            'lblMensajes.Text = "Sistema desactualizado - Presione ESC"
    '    '    '        End If
    '    '    '    Loop

    '    '    'Catch ex As Exception
    '    '    '    MessageBox.Show(ex.Message, "35")
    '    '    'End Try

    '    'End Sub

    '    Private Sub FrmAdministrarPedidos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '        Try

    '            TimerPendientes.Stop()
    '            't.Abort()
    '            'Servidor.Stop()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "36")
    '        End Try

    '    End Sub
    '#End Region

    '#Region "Frecuencia/Zonas"
    '    'Private Sub lklFiltroMoviles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklPorFrecuencia.LinkClicked
    '    '    Dim FuenteSel As New System.Drawing.Font("console UI", 9, FontStyle.Bold)
    '    '    Dim FuenteNoSel As New System.Drawing.Font("console UI", 9, FontStyle.Regular)
    '    '    If sender Is lklPorFrecuencia Then
    '    '        lklPorFrecuencia.Font = FuenteSel
    '    '        lklPorFrecuencia.LinkVisited = True
    '    '        lklPorBase.Font = FuenteNoSel
    '    '        lklPorBase.LinkVisited = False
    '    '        pbxAgregarMovil.Visible = True
    '    '        pbxBase.Visible = False
    '    '        If tipoAsignacion <> "FRECUENCIA" Then
    '    '            tipoAsignacion = "FRECUENCIA"
    '    '            BuscarMoviles()
    '    '            CargarSubBases()
    '    '        End If
    '    '    Else
    '    '        lklPorBase.Font = FuenteSel
    '    '        lklPorBase.LinkVisited = True
    '    '        lklPorFrecuencia.Font = FuenteNoSel
    '    '        lklPorFrecuencia.LinkVisited = False
    '    '        pbxAgregarMovil.Visible = False
    '    '        pbxBase.Visible = True
    '    '        If tipoAsignacion <> "ZONA" Then
    '    '            tipoAsignacion = "ZONA"
    '    '            If cls.Zona.id = 0 Then
    '    '                pbxBase_Click(Nothing, Nothing)
    '    '            End If
    '    '            If cls.Zona.id > 0 Then
    '    '                BuscarMoviles()
    '    '                CargarSubBases()
    '    '            Else : lklFiltroMoviles_LinkClicked(lklPorFrecuencia, Nothing)
    '    '            End If
    '    '        End If
    '    '        'agregado para grilla
    '    '        CargarSubBases()
    '    '    End If

    '    'End Sub
    '    'Private Sub pbxAgregarMovil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxAgregarMovil.Click
    '    '    Dim frm As New FrmChoferMovil(True, True, "INACTIVOS")
    '    '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '    '        cls.ChoferMovil = frm.Tag
    '    '        cls.ChoferMovil.activo = True
    '    '        Try
    '    '            cls.PersistirChoferMovil()
    '    '            BuscarMoviles()
    '    '            CargarSubBases()
    '    '        Catch ex As Exception
    '    '            MessageBox.Show("No se ha podido agregar el móvil.")
    '    '        End Try
    '    '    End If
    '    'End Sub
    '    'Private Sub pbxBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxBase.Click
    '    '    Dim frm As New FrmSeleccionarZona(Nothing, cls.Zona)
    '    '    frm.Parent = Me.MdiParent
    '    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '    '        If frm.Tag IsNot Nothing Then
    '    '            cls.Zona = frm.Tag
    '    '            tipoAsignacion = "ZONA"
    '    '            BuscarMoviles()
    '    '            CargarSubBases()
    '    '        End If
    '    '    End If
    '    'End Sub
    '#End Region

    '#Region "Mensajero"
    '    Private Sub MandarMensaje(ByVal numero As String, ByVal mensaje As String)
    '        Try
    '            If numero > 7 Then
    '                Dim tel = numero.Substring(numero.Length - 7, 7)
    '                Dim cod_area = numero.Substring(0, numero.Length - 7)

    '                Dim texto As String = "Argentina - Personal;"
    '                texto &= cod_area & ";"
    '                texto &= tel & ";1;"
    '                texto &= mensaje
    '                Dim cadena As String = "C:\Program Files (x86)\TSM\Mensajes\tsmmensajes.exe /apipe:" & String.Format("""{0}""", texto)
    '                Shell(cadena, AppWinStyle.NormalFocus)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "37")
    '        End Try


    '    End Sub
    '#End Region

    '    'Private Sub dgvZ1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvZ1.SelectionChanged, dgvZ2.SelectionChanged, dgvZ3.SelectionChanged, dgvZ4.SelectionChanged, dgvZ5.SelectionChanged, dgvZ6.SelectionChanged, dgvZ7.SelectionChanged, dgvZ8.SelectionChanged, dgvZ9.SelectionChanged, dgvZ10.SelectionChanged, dgvZP.SelectionChanged, dgvZT.SelectionChanged
    '    '    Try
    '    '        ' DatosMovil(sender)
    '    '    Catch ex As Exception
    '    '        MessageBox.Show(ex.Message, "38")
    '    '    End Try

    '    'End Sub

    '#Region "Buscador comentado"
    '    'Private Sub txtBuscador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
    '    '    Dim val As Integer
    '    '    If e.KeyChar = Chr(Keys.Enter) Then
    '    '        If Int32.TryParse(txtBuscador.Text, val) Then

    '    '            If Buscador(txtBuscador.Text, colMovNro.Name, dgvMoviles) Then
    '    '                cls.BuscarMovil(txtBuscador.Text)
    '    '                bgsMoviles.DataSource = cls.lstChoferMovil
    '    '                bgsMoviles.ResetCurrentItem()
    '    '                PintarMoviles()
    '    '                If cls.Pedido.id <> 0 Then
    '    '                    If asignar Then 'sólo permito si está en modo Asignar
    '    '                        ' If tipoAsignacion = "FRECUENCIA" OrElse (e.RowIndex = 0 AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
    '    '                        If (tipoAsignacion = "FRECUENCIA" AndAlso cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00") OrElse (tipoAsignacion = "ZONA" AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
    '    '                            With cls.ChoferMovil
    '    '                                Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", Nothing)
    '    '                                ' frm.Focus() 'no toma el enter en el frmConfirmacion, ni con focus ni select. Ya tiene la prop KeyPreview
    '    '                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '    '                                    Dim cambioMovil As Boolean = cls.Pedido.movil_id > 0  'Estoy cambiando el móvil de un pedido A Completar..
    '    '                                    cls.Pedido.movil_id = .movil_id
    '    '                                    cls.Pedido.chofer_id = .chofer_id
    '    '                                    cls.Pedido.asignado = cls.FechaHora
    '    '                                    cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00"
    '    '                                    cls.IniciarTrn()
    '    '                                    Dim exito As Boolean = False
    '    '                                    Try
    '    '                                        cls.PersistirPedido(False)
    '    '                                        cls.PersistirMovil(False)
    '    '                                        cls.gettrn.Commit()
    '    '                                        exito = True
    '    '                                    Catch ex As Exception
    '    '                                        cls.gettrn.Rollback()
    '    '                                        MessageBox.Show(ex.Message)
    '    '                                    End Try
    '    '                                    If exito Then
    '    '                                        '.v_ultimoPedido = cls.FechaHora **
    '    '                                        '.v_cantPedidos += 1 **
    '    '                                        Habilitar("P")
    '    '                                        If cambioMovil Then
    '    '                                            cls.Pedido.ChoferMovil = Nothing 'para que refresque el valor
    '    '                                            bgsACompletar.ResetCurrentItem()
    '    '                                        Else
    '    '                                            cls.lstPedido.Remove(cls.Pedido)
    '    '                                            cls.lstPedidoACompletar.Add(cls.Pedido)
    '    '                                            bgsPedidos.ResetBindings(False)
    '    '                                            bgsACompletar.ResetBindings(False)
    '    '                                            PintarACompletar()
    '    '                                        End If
    '    '                                        BuscarMoviles()
    '    '                                        CargarSubBases()
    '    '                                        PintarPedidos()
    '    '                                        dgvPedidos_Enter(Nothing, Nothing)
    '    '                                        txtBuscador.Text = ""
    '    '                                        txtBuscador.Visible = False
    '    '                                    End If
    '    '                                End If
    '    '                            End With
    '    '                        End If
    '    '                    End If
    '    '                End If
    '    '            End If

    '    '        End If
    '    '    End If
    '    'End Sub
    '    'Function Buscador(ByVal TextoABuscar As String, ByVal Columna As String, ByRef grid As DataGridView) As Boolean
    '    '    Dim encontrado As Boolean = False
    '    '    If TextoABuscar = String.Empty Then Return False
    '    '    If grid.RowCount = 0 Then Return False
    '    '    grid.ClearSelection()
    '    '    If Columna = String.Empty Then
    '    '        For Each row As DataGridViewRow In grid.Rows
    '    '            For Each cell As DataGridViewCell In row.Cells
    '    '                If cell.Value.ToString() = TextoABuscar Then
    '    '                    row.Selected = True
    '    '                    Return True
    '    '                End If
    '    '            Next
    '    '        Next
    '    '    Else
    '    '        For Each row As DataGridViewRow In grid.Rows
    '    '            If row.IsNewRow Then Return False
    '    '            If row.Cells(Columna).Value.ToString() = TextoABuscar Then
    '    '                row.Selected = True
    '    '                Return True
    '    '            End If
    '    '        Next
    '    '    End If
    '    '    Return encontrado
    '    'End Function
    '    'Private Sub txtBuscarMovil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    '    If e.KeyChar = Chr(Keys.Enter) Then
    '    '        With cls.ChoferMovil
    '    '            ' falta buscar el movil de acuerdo al txtbuscar movil
    '    '            Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", pos)
    '    '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '    '                cls.Pedido.movil_id = .movil_id
    '    '                cls.Pedido.chofer_id = .chofer_id
    '    '                cls.Pedido.asignado = cls.FechaHora
    '    '                cls.PersistirPedido()
    '    '                cls.lstPedido.Remove(cls.Pedido)
    '    '                cls.lstPedidoACompletar.Add(cls.Pedido)
    '    '                .v_ultimoPedido = cls.FechaHora
    '    '                .v_cantPedidos += 1
    '    '                bgsPedidos.ResetBindings(False)
    '    '                bgsMoviles.DataSource = (From cm In cls.lstChoferMovil Order By cm.v_ultimoPedido Ascending).ToList
    '    '                bgsMoviles.ResetBindings(False)
    '    '                bgsACompletar.ResetBindings(False)
    '    '                PintarMoviles()
    '    '                PintarACompletar()
    '    '                Habilitar("P")
    '    '                PintarPedidos()
    '    '            End If
    '    '        End With
    '    '    Else
    '    '        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete)) Then
    '    '            e.KeyChar = Nothing
    '    '        End If
    '    '    End If
    '    'End Sub
    '#End Region


#Region "Asignacion de moviles a subbases con teclas de funcion"
    Private Sub FrmOperadores2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Is = Keys.R
                    RefrescarTodo()
                Case Is = Keys.S
                    txtFuncionMovil.Visible = True
                    SubBase = 1000
                    Funcion = "zonas"
                    txtFuncionMovil.Focus()
                Case Is = Keys.F1
                    txtFuncionMovil.Visible = True
                    SubBase = 1
                    Funcion = "zonas"
                Case Is = Keys.F2
                    txtFuncionMovil.Visible = True
                    SubBase = 2
                    Funcion = "zonas"
                Case Is = Keys.F3
                    txtFuncionMovil.Visible = True
                    SubBase = 3
                    Funcion = "zonas"
                Case Is = Keys.F4
                    txtFuncionMovil.Visible = True
                    SubBase = 4
                    Funcion = "zonas"
                Case Is = Keys.F5
                    txtFuncionMovil.Visible = True
                    SubBase = 5
                    Funcion = "zonas"
                Case Is = Keys.F6
                    txtFuncionMovil.Visible = True
                    SubBase = 6
                    Funcion = "zonas"
                Case Is = Keys.F7
                    txtFuncionMovil.Visible = True
                    SubBase = 7
                    Funcion = "zonas"
                Case Is = Keys.F8
                    txtFuncionMovil.Visible = True
                    SubBase = 8
                    Funcion = "zonas"
                Case Is = Keys.F9
                    txtFuncionMovil.Visible = True
                    SubBase = 9
                    Funcion = "zonas"
                Case Is = Keys.F10
                    txtFuncionMovil.Visible = True
                    SubBase = 10
                    Funcion = "zonas"
                Case Is = Keys.F11
                    txtFuncionMovil.Visible = True
                    SubBase = 11
                    Funcion = "zonas"
                Case Is = Keys.F12
                    txtFuncionMovil.Visible = True
                    SubBase = 12
                    Funcion = "zonas"
                Case Is = Keys.Escape
                    lblMensajes.Text = "Panel de Información"
                    'cls.Pedido.operador_id = 0
                    'cls.Pedido.asignado = "1900-01-01 00:00:00"
                    'cls.PersistirPedido()
                    cls.LiberarPedido(cls.Pedido.id)
                    Habilitar("P")
                    If dgvPedidos.Enabled = False Then
                        dgvPedidos.Enabled = True
                    End If
            End Select

            If SubBase > 0 Then
                lblMensajes.Text = "Ingrese el movil que desea asignar a la Sub Base " & SubBase
                txtFuncionMovil.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "39")
        End Try


    End Sub


    Private Sub AsignarEnBase(ByVal movil As Integer, base As Integer, ByVal Nega As Boolean)
        Try
            cls.BuscarMovil(movil)
            cls.FillZonaById(base)
            'If cls.lstChoferMovil.Count > 0 Then
            If cls.LstMovil.Count > 0 Then
                'If cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id Then 'COLOCAR EN BASE
                If cls.Movil.frecuencia_id = cls.Operador.frecuencia_id Then 'COLOCAR EN BASE
                    'With cls.ChoferMovil.Movil
                    With cls.Movil
                        If base <> 0 Then
                            'If cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00" Or cls.ChoferMovil.Movil.zona_id <> base Then ' el movil no se encuentra en otra subbase o en ninguna
                            If cls.Movil.en_zona = "1900-01-01 00:00:00" Or cls.Movil.zona_id <> base Then ' el movil no se encuentra en otra subbase o en ninguna
                                .zona_id = base
                                If Nega Then
                                    Dim ayer As Date
                                    ayer = Date.Now.AddDays(-1)
                                    .en_zona = ayer
                                Else
                                    '.en_zona = cls.FechaHora
                                    .en_zona = Date.Now
                                End If

                                'ElseIf cls.ChoferMovil.Movil.zona_id = base Then ' el movil se encuentra en la subase, entonces lo saco
                            ElseIf cls.Movil.zona_id = base Then ' el movil se encuentra en la subase, entonces lo saco
                                .en_zona = "1900-01-01 00:00:00"
                            End If
                        End If

                        Try
                            cls.PersistirMovil()
                            lblMensajes.Text = "El móvil " & movil & " se encuentra ahora " & IIf(.en_zona <> "1900-01-01 00:00:00", "en " & cls.Zona.Zona.nombre, "fuera de base") & "."
                            ActualizarSubBases()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        CargarSubBases()
                    End With
                Else
                    lblMensajes.Text = "El móvil no pudo ser asignado a la base"
                End If
            Else
                lblMensajes.Text = "No se encuentra el móvil en su frecuencia"
            End If
            txtFuncionMovil.Text = ""
            txtFuncionMovil.Visible = False
            SubBase = 0
            Negativo = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "40")
        End Try

    End Sub
#End Region

    Private Sub txtFuncionMovil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFuncionMovil.KeyDown
        Try
            If e.KeyValue = Keys.F1 Then
                If AnalizarSubBase(1, dgvZ1) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 1"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F2 Then
                If AnalizarSubBase(2, dgvZ2) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 2"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F3 Then
                If AnalizarSubBase(3, dgvZ3) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 3"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F4 Then
                If AnalizarSubBase(4, dgvZ4) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 4"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F5 Then
                If AnalizarSubBase(5, dgvZ5) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 5"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F6 Then
                If AnalizarSubBase(6, dgvZ6) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 6"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F7 Then
                If AnalizarSubBase(7, dgvZ7) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 7"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F8 Then
                If AnalizarSubBase(8, dgvZ8) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 8"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F9 Then
                If AnalizarSubBase(9, dgvZ9) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 9"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F10 Then
                If AnalizarSubBase(10, dgvZ10) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la subbase 10"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F11 Then
                If AnalizarSubBase(11, dgvZP) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la Playa"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If

            ElseIf e.KeyValue = Keys.F12 Then
                If AnalizarSubBase(12, dgvZT) = True Then
                    tipoAsignacion = "ZONA"
                    AsignarPedido()
                Else
                    lblMensajes.Text = "No se puede asignar de la Terminal"
                    txtFuncionMovil.Visible = False
                    Habilitar("P")
                End If
            ElseIf e.KeyValue = Keys.Escape Then
                If Funcion = "zonas" Then
                    txtFuncionMovil.Visible = False
                    lblMensajes.Text = "Panel de Información"
                    cls.Pedido.operador_id = 0
                    cls.Pedido.asignado = "1900-01-01 00:00:00"

                    'Controlar si es necesario modificar las horas
                    'cls.TomarLiberarPedido(cls.Pedido.id, vbNull)
                    cls.LiberarPedido(cls.Pedido.id)
                    ' cls.PersistirPedido()

                    Habilitar("P")
                    If dgvPedidos.Enabled = False Then
                        dgvPedidos.Enabled = True
                    End If
                ElseIf Funcion = "movil" Then
                    lblMensajes.Text = "Asignación cancelada. 'Esc' para liberar pedido"
                    txtFuncionMovil.Text = ""
                    txtFuncionMovil.Visible = False

                    lblMensajes.Text = "Panel de Información"
                    cls.Pedido.operador_id = 0
                    'Controlar si es necesario modificar las horas
                    cls.Pedido.asignado = "1900-01-01 00:00:00"
                    cls.Pedido.completado = "1900-01-01 00:00:00"

                    'cls.TomarLiberarPedido(cls.Pedido.id, vbNull)
                    cls.LiberarPedido(cls.Pedido.id)
                    'cls.PersistirPedido()

                    BuscarCompletados()
                    Habilitar("P")
                    dgvPedidos.Focus()

                End If
            End If

            If Funcion = "zonas" Then
                If e.KeyValue = Keys.Enter Then
                    Dim val As Int64 = 0
                    If Int64.TryParse(txtFuncionMovil.Text, val) Then
                        If SubBase = 1000 Then
                            QuitarMovil(txtFuncionMovil.Text)
                        Else
                            AsignarEnBase(txtFuncionMovil.Text, SubBase, Negativo)
                        End If

                    Else
                        lblMensajes.Text = "Ingrese solo números"
                        txtFuncionMovil.Text = ""
                    End If
                End If
                If e.KeyValue = Keys.Escape Then
                    lblMensajes.Text = "Panel de Información"
                    txtFuncionMovil.Visible = False

                    cls.Pedido.operador_id = 0
                    cls.Pedido.asignado = "1900-01-01 00:00:00"
                    'cls.PersistirPedido()

                    'Controlar si es necesario modificar las horas
                    'cls.TomarLiberarPedido(cls.Pedido.id, vbNull)
                    cls.LiberarPedido(cls.Pedido.id)
                    Habilitar("P")
                    If dgvPedidos.Enabled = False Then
                        dgvPedidos.Enabled = True
                    End If
                End If

            ElseIf Funcion = "movil" Then
                If e.KeyValue = Keys.Enter Then
                    Dim val2 As Int64 = 0
                    If Int64.TryParse(txtFuncionMovil.Text, val2) Then
                        If txtFuncionMovil.Text <> "" Then
                            If txtFuncionMovil.Text = 0 Then
                                cls.Pedido.movil_id = 0
                                cls.Pedido.chofer_id = 0
                                cls.Pedido.operador_id = 0
                                cls.Pedido.asignado = "1900-01-01 00:00:00"
                                cls.Pedido.completado = "1900-01-01 00:00:00"
                                cls.IniciarTrn()
                                Dim exito As Boolean = False
                                Try
                                    cls.Resetear(cls.Pedido.id, cls.Operador.entidad_id)
                                    'cls.PersistirPedido(False)
                                    cls.gettrn.Commit()
                                    exito = True
                                Catch ex As Exception
                                    cls.gettrn.Rollback()
                                    MessageBox.Show(ex.Message)
                                End Try

                                If exito Then
                                    Habilitar("P")
                                    cls.Pedido.ChoferMovil = Nothing 'para que refresque el valor
                                    bgsACompletar.ResetCurrentItem()

                                    BuscarMoviles()
                                    PintarPedidos()
                                    lblMensajes.Text = "Pedido desasignado"
                                    txtFuncionMovil.Text = ""
                                    txtFuncionMovil.Visible = False
                                End If
                                BuscarACompletar()
                                BuscarCompletados()
                            Else

                                Dim val As Int64 = 0
                                If Int64.TryParse(txtFuncionMovil.Text, val) Then
                                    cls.BuscarMovilFrecuencia(txtFuncionMovil.Text)
                                    If cls.lstChoferMovil.Count <> 0 Then
                                        tipoAsignacion = "FRECUENCIA" '  ver esto 
                                        If cls.lstChoferMovil.First.Movil.en_zona <> "1900-01-01 00:00:00" Then
                                            MsgBox("Movil en SubBase, " & cls.lstChoferMovil.First.Movil.Zona.nombre & ". Asigna con teclas F")
                                        Else
                                            AsignarPedido()
                                        End If


                                    Else
                                        lblMensajes.Text = "El móvil no pertenece a su frecuencia"
                                        txtFuncionMovil.Text = ""
                                        ' 
                                    End If

                                Else
                                    lblMensajes.Text = "Ingrese solo números"
                                    txtFuncionMovil.Text = ""
                                End If
                            End If
                        End If
                    Else
                        lblMensajes.Text = "Ingrese solo numeros"
                    End If
                    If dgvPedidos.Enabled = False Then
                        dgvPedidos.Enabled = True
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "41")

        End Try

    End Sub
    Private Sub QuitarMovil(ByVal movil As Integer)
        cls.BuscarMovilFrecuencia(movil)
        If cls.LstMovil.Count <> 0 Then
            'cls.Movil.en_zona = "1900-01-01 00:00:00"
            'cls.PersistirMovil()
            cls.QuitarDeZona(cls.Movil.id)
            CargarSubBases()
            txtFuncionMovil.Text = ""
            txtFuncionMovil.Visible = False
        End If
      End Sub
#Region "Asginacion de moviles a pedido "

    Private Sub AsignarPedido()
        Try
            If cls.Operador.entidad_id <> 0 Then
                If asignar Then 'sólo permito si está en modo Asignar
                    If (tipoAsignacion = "FRECUENCIA" AndAlso cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00") OrElse (tipoAsignacion = "ZONA") Then
                        If cls.ChoferMovil IsNot Nothing Then
                            With cls.ChoferMovil
                                Dim numero As Integer
                                numero = .v_nroMovil
                                Dim frm As New FrmOkCancel("¿Asignar el móvil " & numero & "?", Nothing)
                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    Dim cambioMovil As Boolean = cls.Pedido.movil_id > 0  'Estoy cambiando el móvil de un pedido A Completar..
                                    If dgvPedidos.Focused Then
                                        cls.PedidobyId(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
                                    ElseIf dgvACompletar.Focused Then
                                        cls.PedidobyId(CType(dgvACompletar.CurrentRow.DataBoundItem, pedido).id)
                                    ElseIf dgvCompletados.Focused Then
                                        cls.PedidobyId(CType(dgvCompletados.CurrentRow.DataBoundItem, pedido).id)
                                    End If

                                    cls.PedidobyId(cls.Pedido.id)
                                    If cls.Pedido.asignado = "1900-01-01 00:00:00" Or cambioMovil Then
                                        cls.Pedido.operador_id = cls.Operador.entidad_id
                                        cls.Pedido.movil_id = .movil_id
                                        cls.Pedido.chofer_id = .chofer_id
                                        cls.Pedido.asignado = DateAndTime.Now

                                        'cls.Movil.en_zona = "1900-01-01 00:00:00"
                                        cls.IniciarTrn()
                                        Dim exito As Boolean = False
                                        'BITACORA PEDIDO-ASIGNACION PEDIDO
                                        Try

                                            'cls.PersistirPedido(False)
                                            'cls.PersistirMovil(False)

                                            cls.AsignarPedido(cls.Pedido.id, cls.Pedido.movil_id, cls.Pedido.chofer_id, cls.Operador.entidad_id)
                                            cls.QuitarDeZona(cls.Movil.id)
                                            cls.gettrn.Commit()
                                            exito = True
                                        Catch ex As Exception
                                            cls.gettrn.Rollback()
                                            MessageBox.Show(ex.Message)
                                            exito = False
                                        End Try
                                        If exito Then
                                            Habilitar("P")
                                            If cambioMovil Then
                                                cls.Pedido.ChoferMovil = Nothing 'para que refresque el valor
                                                bgsACompletar.ResetCurrentItem()
                                                'BITOCORA PEDIDO - CAMBIO DE MOVIL
                                            Else
                                                'cls.lstPedido.Remove(cls.Pedido)
                                                'cls.lstPedidoACompletar.Add(cls.Pedido)
                                                bgsPedidos.ResetBindings(False)
                                                bgsACompletar.ResetBindings(False)
                                                PintarACompletar()
                                            End If
                                            lblMensajes.Text = "Pedido asignado al móvil " & txtFuncionMovil.Text
                                            CargarSubBases()
                                            ActualizarPedidos()
                                            BuscarACompletar()
                                            BuscarCompletados()
                                        Else
                                            lblMensajes.Text = "Error"
                                            MessageBox.Show("Ocurrió un error, no se asignó el movil al pedido")
                                        End If
                                    Else
                                        MsgBox("No se puede enviar este pedido, ya fue asignado a otra FRECUENCIA")
                                        lblMensajes.Text = "No se puede enviar este pedido, ya fue asignado a otra frecuencia. Escape"
                                        txtFuncionMovil.Visible = False
                                        Habilitar("P")
                                        RefrescarTodo()
                                        'BuscarPedidos()
                                    End If
                                Else

                                    PreAsignación()
                                    lblMensajes.Text = "Asignación cancelada"

                                    lblMensajes.Text = "Panel de Información"
                                    'cls.Pedido.operador_id = 0
                                    'cls.Pedido.asignado = "1900-01-01 00:00:00"
                                    'cls.TomarLiberarPedido(cls.Pedido.id, vbNull)
                                    cls.LiberarPedido(cls.Pedido.id)
                                    RefrescarTodo()
                                    'BuscarPedidos()

                                    'cls.PersistirPedido()
                                    'habilitar p agregado
                                    Habilitar("P")
                                    If dgvPedidos.Enabled = False Then
                                        dgvPedidos.Enabled = True
                                    End If

                                End If

                            End With
                        End If
                    End If
                End If
                
                txtFuncionMovil.Text = ""
                txtFuncionMovil.Visible = False
                If dgvACompletar.Focused = False Then
                    dgvACompletar.CurrentCell = Nothing
                End If

            Else
                MsgBox("Error en la conexion con la base de datos, vuelva a intentarlo")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "42")
        End Try

    End Sub

    Private Sub dgvPedidos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPedidos.KeyDown
        Try

            If e.KeyValue = Keys.B Or e.KeyValue = Keys.S Then
                lblMensajes.Focus()
                dgvPedidos.CurrentCell = Nothing
                lblMensajes.Text = "Manejo de subbases"
                txtFuncionMovil.Focus()

            End If
            If e.KeyValue = Keys.N Then
                lblMensajes.Focus()
                dgvPedidos.CurrentCell = Nothing
                lblMensajes.Text = "Manejo de subbases - Negativo"
                Negativo = True

            End If
            If e.KeyValue = Keys.Escape Then
                'Esta funcion se repite en txtfuncion.key (Escape). Actualizar cambios si es necesario
                ' Tb se repite en el else de la pregunta Desea Asignar el movil?

                lblMensajes.Text = "Panel de Información"
                'cls.Pedido.operador_id = 0
                'cls.Pedido.asignado = "1900-01-01 00:00:00"
                'cls.PersistirPedido()
                'cls.TomarLiberarPedido(cls.Pedido.id, vbNull)
                cls.LiberarPedido(cls.Pedido.id)

                Habilitar("P")
                If dgvPedidos.Enabled = False Then
                    dgvPedidos.Enabled = True
                End If
            End If

            If dgvPedidos.CurrentCell IsNot Nothing Then
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.F1 Or e.KeyValue = Keys.F2 Or e.KeyValue = Keys.F3 Or e.KeyValue = Keys.F4 Or e.KeyValue = Keys.F5 Or e.KeyValue = Keys.F6 Or e.KeyValue = Keys.F7 Or e.KeyValue = Keys.F8 Or e.KeyValue = Keys.F9 Or e.KeyValue = Keys.F10 Or e.KeyValue = Keys.F11 Or e.KeyValue = Keys.F12 Then
      
                    cls.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
                    'BITACORA PEDIDO - TOMA PEDIDO
                    cls.PedidobyId(cls.Pedido.id)
                    If cls.Pedido IsNot Nothing Then
                        If e.KeyValue = Keys.Enter Then
                            e.SuppressKeyPress = True
                            lblMensajes.Text = "Ingrese el numero de móvil que desea asignar"
                            txtFuncionMovil.Visible = True
                            txtFuncionMovil.Focus()
                            Funcion = "movil"
                            PreAsignación()

                        ElseIf e.KeyValue = Keys.F1 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(1, dgvZ1) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 1)
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False

                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F2 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(2, dgvZ2) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 2)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F3 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(3, dgvZ3) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 3)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F4 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(4, dgvZ4) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 4)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If


                        ElseIf e.KeyValue = Keys.F5 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(5, dgvZ5) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 5)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F6 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(6, dgvZ6) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 6)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F7 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(7, dgvZ7) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 7)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F8 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(8, dgvZ8) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 8)
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F9 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(9, dgvZ9) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 9)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If


                        ElseIf e.KeyValue = Keys.F10 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(10, dgvZ10) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 10)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        ElseIf e.KeyValue = Keys.F11 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(11, dgvZP) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 11)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If


                        ElseIf e.KeyValue = Keys.F12 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(12, dgvZT) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                clsStore.StoreDomicilioZona(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).domicilio_id, 12)
                                PreAsignación()
                                AsignarPedido()

                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                                dgvPedidos.Focus()
                            End If

                        End If
                    End If
                End If

            Else
                lblMensajes.Text = "No hay pedidos pendientes"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "43")
        End Try


    End Sub

    Private Sub PreAsignación()
        Try
            If cls.Operador.entidad_id <> 0 Then 'sólo permito asignar si el usuario tiene un operador asignado
                If cls.Pedido.id <> CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id Then
                    cls.PedidobyId(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
                End If
                If cls.Pedido.operador_id = 0 Then ' el pedido no fue tomado por ninggun operador
                    indicePedido = bgsPedidos.Position
                    cls.Pedido.operador_id = cls.Operador.entidad_id
                    'cls.PersistirPedido()
                    cls.TomarLiberarPedido(cls.Pedido.id, cls.Operador.entidad_id)
                    PintarPedidoActual()
                    asignar = True
                Else
                    Habilitar("P")
                    dgvPedidos.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "44")
        End Try

    End Sub

    Private Function AnalizarSubBase(ByVal base As Integer, ByRef dgv As DataGridView) As Boolean
        Try
            Dim resultado As Boolean = False

            dgv.Focus()
            If dgv.RowCount > 0 Then

                Dim movil As Integer = CType(dgv.CurrentRow.DataBoundItem, chofer_movil).Movil.numero
                cls.BuscarMovil(movil)

                If cls.ChoferMovil IsNot Nothing Then
                    If cls.ChoferMovil.Movil.zona_id = base AndAlso cls.ChoferMovil.Movil.en_zona <> "1900-01-01 00:00:00" AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id Then
                        resultado = True
                    Else
                        lblMensajes.Text = "No se puede asignar "
                        resultado = False
                    End If
                Else
                    lblMensajes.Text = "Ningún móvil en la subbase"
                    resultado = False
                End If
            End If
            dgv.CurrentCell = Nothing

            Return resultado
        Catch ex As Exception
            MessageBox.Show(ex.Message, "45")
            Return False
        End Try

    End Function
#End Region

    Private Sub dgvACompletar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvACompletar.KeyDown
        Try
            If e.KeyValue = Keys.B Or e.KeyValue = Keys.S Then
                lblMensajes.Focus()
                dgvPedidos.CurrentCell = Nothing
                lblMensajes.Text = "Manejo de subbases"
            ElseIf e.KeyValue = Keys.N Then
                lblMensajes.Focus()
                dgvPedidos.CurrentCell = Nothing
                lblMensajes.Text = "Manejo de subbases - Negativo"
                Negativo = True

            ElseIf e.KeyValue = Keys.C Then
                Try
                    If cls.Operador.entidad_id <> 0 Then 'sólo permito cambiar el móvil si el usuario tiene un operador asociado
                        cls.PedidoACompletar = CType(dgvACompletar.CurrentRow.DataBoundItem, pedido)
                        With cls.PedidoACompletar
                            If .cancelado = "1900-01-01 00:00:00" Then
                                If indicePedido = -1 Then 'si no estoy asignando móvil a un pedido
                                    If indiceACompletar = -1 Then
                                        Dim frm As New FrmOkCancel("¿Cambiar el móvil " & .ChoferMovil.v_nroMovil & " por otro?", Nothing)
                                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                            indiceACompletar = bgsACompletar.Position
                                            cls.Pedido = cls.PedidoACompletar
                                            dgvACompletar.CurrentCell.ToolTipText = "Cancelar asignación"
                                            Habilitar("M")
                                            lblMensajes.Text = "Ingrese el numero de móvil que desea asignar"
                                            txtFuncionMovil.Visible = True
                                            txtFuncionMovil.Focus()
                                            Funcion = "movil"
                                            BuscarACompletar()
                                        End If
                                    Else
                                        Habilitar("P")
                                    End If
                                End If
                            End If
                        End With
                    End If

                Catch ex As Exception

                End Try
            End If

            If dgvACompletar.CurrentCell IsNot Nothing Then
                If e.KeyValue = Keys.Enter Then
                    lblMensajes.Text = "Completar el pedido"
                    CompletarDirección()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "46")
        End Try

    End Sub

    Private Sub CompletarDirección()
        Try
            With cls.PedidoACompletar
                Dim frm As New FrmOkCancel("¿Completar el pedido del móvil " & .ChoferMovil.v_nroMovil & "?", Nothing)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '.completado = DateAndTime.Now
                    'cls.Pedido = cls.PedidoACompletar
                    'cls.PersistirPedido()
                    cls.CompletarPedido(cls.PedidoACompletar.id, My.Settings.idUsuario)
                    BuscarACompletar()
                    BuscarCompletados()
                    'RefrescarTodo()
                    lblMensajes.Text = "Pedido Completado"
                End If
            End With
            BuscarCompletados()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "47")
        End Try

    End Sub

    Private Sub dgvZ1_Leave(sender As System.Object, e As System.EventArgs) Handles dgvZ1.Leave, dgvZ2.Leave, dgvZ3.Leave, dgvZ4.Leave, dgvZ5.Leave, dgvZ6.Leave, dgvZ7.Leave, dgvZ8.Leave, dgvZ9.Leave, dgvZ10.Leave, dgvZP.Leave, dgvZT.Leave
        Try
            dgvZ1.CurrentCell = Nothing
            dgvZ2.CurrentCell = Nothing
            dgvZ3.CurrentCell = Nothing
            dgvZ4.CurrentCell = Nothing
            dgvZ5.CurrentCell = Nothing
            dgvZ6.CurrentCell = Nothing
            dgvZ7.CurrentCell = Nothing
            dgvZ8.CurrentCell = Nothing
            dgvZ9.CurrentCell = Nothing
            dgvZ10.CurrentCell = Nothing
            dgvZP.CurrentCell = Nothing
            dgvZT.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "48")
        End Try

    End Sub

    Private Sub dgvPedidos_Leave(sender As System.Object, e As System.EventArgs) Handles dgvPedidos.Leave
        Try
            dgvPedidos.BackgroundColor = ColorTranslator.FromOle(RGB(48, 48, 48))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "50")
        End Try
    End Sub

    Private Sub dgvACompletar_Leave(sender As System.Object, e As System.EventArgs) Handles dgvACompletar.Leave
        Try
            dgvACompletar.BackgroundColor = ColorTranslator.FromOle(RGB(48, 48, 48))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "51")
        End Try
    End Sub

    Private Sub dgvCompletados_Leave(sender As System.Object, e As System.EventArgs) Handles dgvCompletados.Leave
        Try
            dgvCompletados.BackgroundColor = ColorTranslator.FromOle(RGB(48, 48, 48))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "52")
        End Try
    End Sub

    Private Sub NegativoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NegativoToolStripMenuItem.Click
        Try
            cls.Pedido = CType(dgvCompletados.CurrentRow.DataBoundItem, pedido)
            'cls.Pedido.completado = DateAndTime.Now
            'cls.Pedido.observacion = "Pedido Negativo"
            'cls.PersistirPedido(False)
            cls.CompletarPedido(cls.Pedido.id, "Pedido Negativo")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvCompletados_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCompletados.KeyDown
        Try
            If e.KeyValue = Keys.B Or e.KeyValue = Keys.S Then
                lblMensajes.Focus()
                dgvPedidos.CurrentCell = Nothing
                lblMensajes.Text = "Manejo de subbases"
            ElseIf e.KeyValue = Keys.N Then
                lblMensajes.Focus()
                dgvPedidos.CurrentCell = Nothing
                lblMensajes.Text = "Manejo de subbases - Negativo"
                Negativo = True
                NegativoToolStripMenuItem_Click(Nothing, Nothing)
            ElseIf e.KeyValue = Keys.C Then
                Try
                    If cls.Operador.entidad_id <> 0 Then 'sólo permito cambiar el móvil si el usuario tiene un operador asociado
                        cls.PedidoCompletado = CType(dgvCompletados.CurrentRow.DataBoundItem, pedido)
                        With cls.PedidoCompletado
                            If .cancelado = "1900-01-01 00:00:00" Then
                                If indicePedido = -1 Then 'si no estoy asignando móvil a un pedido
                                    If indiceACompletar = -1 Then
                                        Dim frm As New FrmOkCancel("¿Cambiar el móvil " & .ChoferMovil.v_nroMovil & " por otro?", Nothing)
                                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                            cls.Pedido = cls.PedidoCompletado
                                            dgvCompletados.CurrentCell.ToolTipText = "Cancelar asignación"
                                            Habilitar("M")
                                            lblMensajes.Text = "Ingrese el numero de móvil que desea asignar"
                                            txtFuncionMovil.Visible = True
                                            txtFuncionMovil.Focus()
                                            Funcion = "movil"
                                            BuscarCompletados()
                                        Else
                                            
                                        End If
                                    Else
                                        Habilitar("P")
                                    End If
                                End If
                            End If
                        End With
                    End If
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "53")
        End Try
    End Sub

    'Private Sub dgvZ1_Click(sender As System.Object, e As System.EventArgs) Handles dgvZ1.Click, dgvZ2.Click, dgvZ3.Click, dgvZ4.Click, dgvZ5.Click, dgvZ6.Click, dgvZ7.Click, dgvZ8.Click, dgvZ9.Click, dgvZ10.Click, dgvZP.Click, dgvZT.Click
    '    DatosMovil(sender)
    'End Sub
    Private Sub TimerPendientes_Tick(sender As Object, e As EventArgs) Handles TimerPendientes.Tick
        BuscarPedidos()
    End Sub


    Private Sub TimerSubbases_Tick(sender As Object, e As EventArgs) Handles TimerSubbases.Tick
        CargarSubBases()
        ActualizarReclamos()
        ActualizarCancelados()
        'BuscarACompletar()
        'BuscarCompletados()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        RefrescarTodo()
    End Sub
   

#Region "Funciones Varias"
    Private Sub RefrescarTodo()
        ActualizarPedidos()
        ActualizarReclamos()
        ActualizarSubBases()
        BuscarACompletar()
        BuscarCompletados()
        TimerPendientes.Enabled = True
        TimerPendientes.Start()
        ActualizarCancelados()
        End Sub

#End Region




End Class