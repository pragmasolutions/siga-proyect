Imports System.Net.Sockets
Imports System.Net
Imports System.Threading

Public Class FrmOperadores2
    Dim cls As New ClsAdministrarPedidos
    Dim bgsPedidos, bgsMoviles, bgsACompletar, bgsCompletados, bgsZona1, bgsZona2, bgsZona3, bgsZona4, bgsZona5, bgsZona6, bgsZona7, bgsZona8, bgsZona9, bgsZona10, bgsZonaP, bgsZonaT As New BindingSource
    Dim Servidor As TcpListener = New TcpListener(IPAddress.Any, 6600)
    Dim tipoAsignacion As String = "" ' FRECUENCIA | ZONA
    Dim t As New Threading.Thread(AddressOf listen)
    Dim SubBase As Integer
    Dim Funcion As String = ""
    Dim Negativo As Boolean = False

#Region "Inicializar"
    Public Sub New()
        Try
            InitializeComponent()
            cls.Operador = ClsVariableSesion.Instancia.Usuario.Operador 'hago esto para evitar poner tanto código... cada vez que quiero consultar por el operador accedo a Cls.Operador        
            TimerGral.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "1")
        End Try

    End Sub
    Private Sub Prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cls.TraspasarPedidosFrecuencia() 'necesito que esté cargado el Operador (se hace en el new)
            t.IsBackground = True
            t.Start()

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
            BuscarPedidos()

            CargarSubBases()
            BuscarACompletar()
            BuscarCompletados()
            Habilitar("P")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "2")
        End Try

    End Sub
#End Region

#Region "Pedidos"
    Private Sub BuscarPedidos()
        Try
            cls.CargarPedidos()
            bgsPedidos.DataSource = cls.lstPedido
            bgsPedidos.ResetBindings(False)
            PintarPedidos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "3")
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

    Private Sub PintarPedidos()
        Try
            For Each r As DataGridViewRow In dgvPedidos.Rows
                With CType(r.DataBoundItem, pedido)
                    If .operador_id > 0 Then
                        r.Cells(colPedAsignar.Name).Value = My.Resources.manoce
                        r.Cells(colPedAsignar.Name).ToolTipText = "Cancelar asignación"
                    Else
                        r.Cells(colPedAsignar.Name).Value = My.Resources.manoab
                        r.Cells(colPedAsignar.Name).ToolTipText = "Asignar móvil"
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
            ' txtPedidos.Find("PEDIDOS PENDIENTES")
            txtPedidos.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "8")
        End Try

    End Sub

    Private Sub DatosPedido()
        Try
            txtDetalle.Text = ""
            gbxDetalle.Text = "PEDIDO PENDIENTE"
            ' txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
            txtDetalle.ForeColor = Color.White

            Dim reclamo As String = ""
            If dgvPedidos.CurrentRow IsNot Nothing Then
                With cls.Pedido
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
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
                        'Detalle(.v_observacion, True)
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
                If cls.Pedido.operador_id = 0 Then
                    indicePedido = bgsPedidos.Position
                    cls.Pedido.operador_id = cls.Operador.entidad_id
                    cls.PersistirPedido()
                    PintarPedidoActual()
                    Habilitar("M")
                Else
                    cls.Pedido.operador_id = 0
                    cls.Pedido.asignado = "1900-01-01 00:00:00"
                    cls.PersistirPedido()
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
                '  PintarMoviles()
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
        Try
            'para grilla
            cls.CargarMovilesZonaI(1)
            bgsZona1.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(2)
            bgsZona2.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(3)
            bgsZona3.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(4)
            bgsZona4.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(5)
            bgsZona5.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(6)
            bgsZona6.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(7)
            bgsZona7.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(8)
            bgsZona8.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(9)
            bgsZona9.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(10)
            bgsZona10.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(11)
            bgsZonaP.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(12)
            bgsZonaT.DataSource = cls.lstChoferMovilZonai

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
            MessageBox.Show(ex.Message, "12")
        End Try

    End Sub
    Private Sub ActualizarSubBases()
        Try
            'para grilla
            cls.CargarMovilesZonaI(1)
            bgsZona1.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(2)
            bgsZona2.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(3)
            bgsZona3.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(4)
            bgsZona4.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(5)
            bgsZona5.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(6)
            bgsZona6.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(7)
            bgsZona7.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(8)
            bgsZona8.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(9)
            bgsZona9.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(10)
            bgsZona10.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(11)
            bgsZonaP.DataSource = cls.lstChoferMovilZonai
            cls.CargarMovilesZonaI(12)
            bgsZonaT.DataSource = cls.lstChoferMovilZonai

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

            ' dgvMoviles.CurrentCell = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Private Sub PintarMoviles(dgv As DataGridView)
        Try
            For Each r As DataGridViewRow In dgv.Rows
                With CType(r.DataBoundItem, chofer_movil)
                    If .Movil.frecuencia_id = cls.Operador.frecuencia_id Then
                        r.Cells(1).Style.BackColor = Color.Green
                    Else
                        r.Cells(1).Style.BackColor = Color.Gray
                    End If

                End With
            Next
            dgv.Refresh()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub dgvMoviles_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If bgsMoviles.Count > 0 Then
                cls.ChoferMovil = bgsMoviles.Item(bgsMoviles.Position)
                ' DatosMovil(sender)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "13")
        End Try

    End Sub

    Private Sub DatosMovil(ByRef dgv As DataGridView)
        Try
            txtDetalle.Text = ""
            gbxDetalle.Text = "MÓVIL"
            If dgv.CurrentRow IsNot Nothing Then
                cls.ChoferMovil = CType(dgv.CurrentRow.DataBoundItem, chofer_movil)
                ' txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
                txtDetalle.ForeColor = Color.White
                With cls.ChoferMovil
                    gbxDetalle.Text = "MÓVIL N° " & .v_nroMovil
                    txtDetalle.Text = " Automóvil: " & .Movil.marca & " " & .Movil.modelo & " " & .Movil.color & " " & .Movil.chapa
                    txtDetalle.Text &= " Chofer: " & .v_chofer_AyN
                    txtDetalle.Text &= " Aire Acondicionado: " & IIf(.Movil.aire, "Sí", "No")
                    txtDetalle.Text &= " Baúl:" & .Movil.baul & " Teléfono: " & .Movil.telefono
                    If .observacion.Length > 0 Then txtDetalle.Text &= " Observaciones: " & .observacion
                    Detalle("Automóvil:")
                    Detalle("Chofer:")
                    Detalle("Aire Acondicionado:")
                    Detalle("Baúl:")
                    Detalle("Teléfono:")
                    Detalle("Observaciones:")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "14")
        End Try

    End Sub

#End Region

#Region "ACompletar"
    Private Sub BuscarACompletar()
        Try
            cls.CargarACompletarFrecuencia()
            bgsACompletar.DataSource = cls.lstPedidoACompletar
            PintarACompletar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "16")
        End Try

    End Sub
    Private Sub PintarACompletar()

        Try
            For Each r In dgvACompletar.Rows
                With CType(r.DataBoundItem, pedido)
                    r.Cells(colACompCompletar.Name).ToolTipText = "Completar pedido"
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
                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colACompReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colACompReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
                        If .lst_Reclamo.First.lst_ReclamoLinea.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                            r.Cells(6).Style.BackColor = Color.Green
                            r.Cells(7).Style.BackColor = Color.Green
                        ElseIf .lst_Reclamo.First.lst_ReclamoLinea.Count = 2 Then
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
            ' txtACompletar.Find("PEDIDOS A COMPLETAR")
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
                ' txtDetalle.Font = New System.Drawing.Font("Verdana", 10, FontStyle.Regular)
                txtDetalle.ForeColor = Color.White
                With cls.PedidoACompletar
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
                    txtDetalle.Text &= "Domicilio: " & .v_domicilio
                    'If .v_descripcion.Length > 0 Then txtDetalle.Text &= " " & .v_descripcion
                    ' If .v_interseccion.Length > 0 Then txtDetalle.Text &= " " & .v_interseccion
                    If .v_observacion.Length > 0 Then txtDetalle.Text &= " " & .v_observacion
                    txtDetalle.Text &= " Cliente: " & .cliente
                    If .v_nroMovil.Length > 0 Then txtDetalle.Text &= vbNewLine & "Movil: " & .v_nroMovil
                    ' txtDetalle.Text &= vbNewLine & "Pedido: " & .v_hora
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
                    '  Detalle(.v_descripcion, True)
                    ' Detalle(.v_interseccion, True)
                    Detalle(.v_observacion, True)
                    Detalle("Cliente:")
                    Detalle(.cliente, True)
                    Detalle("Movil:")
                    Detalle(.v_nroMovil, True)
                    ' Detalle("Pedido:")
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
                        TimerGral.Stop()
                        .completado = cls.FechaHora
                        cls.Pedido = cls.PedidoACompletar
                        cls.PersistirPedido()
                        cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
                        cls.lstPedidoCompletado.Add(cls.PedidoACompletar)
                        bgsACompletar.ResetBindings(False)
                        bgsCompletados.ResetBindings(False)
                        PintarACompletar()
                        PintarCompletados()
                        TimerGral.Start()
                    End If
                End With
            ElseIf e.ColumnIndex = colmensajero.Index Then 'mensajero

                If cls.PedidoACompletar.Movil.telefono <> "" Then
                    With cls.PedidoACompletar
                        Dim frm As New FrmOkCancel("¿Completar el pedido del móvil mediante SMS " & .ChoferMovil.v_nroMovil & "?", Nothing)
                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            .completado = cls.FechaHora
                            cls.Pedido = cls.PedidoACompletar
                            cls.PersistirPedido()
                            cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
                            cls.lstPedidoCompletado.Add(cls.PedidoACompletar)
                            bgsACompletar.ResetBindings(False)
                            PintarACompletar()
                            Dim cliente As String = cls.Pedido.v_domicilio & " - " & cls.Pedido.v_clienteAyN
                            MandarMensaje(cls.Pedido.Movil.telefono, cliente)
                        End If
                    End With
                Else
                    Dim frm As New FrmMensajes("Este móvil no posee número agendado para el envío de mensajes", MousePosition)
                    frm.Show()
                End If

            ElseIf cls.Operador.entidad_id <> 0 And e.ColumnIndex = colACompCambiarMovil.Index Then 'sólo permito cambiar el móvil si el usuario tiene un operador asociado
                With cls.PedidoACompletar
                    If .cancelado = "1900-01-01 00:00:00" Then
                        If indicePedido = -1 Then 'si no estoy asignando móvil a un pedido
                            If indiceACompletar = -1 Then
                                Dim frm As New FrmOkCancel("¿Cambiar el móvil " & .ChoferMovil.v_nroMovil & " por otro?", Nothing)
                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    TimerGral.Stop()
                                    indiceACompletar = bgsACompletar.Position
                                    dgvPedidos.Enabled = False
                                    cls.Pedido = cls.PedidoACompletar
                                    dgvCompletados.Enabled = False
                                    ' dgvACompletar.CurrentCell.Value = My.Resources.manoce
                                    dgvACompletar.CurrentCell.ToolTipText = "Cancelar asignación"
                                    Habilitar("M")
                                    lblMensajes.Text = "Ingrese el numero de móvil que desea asignar"
                                    txtFuncionMovil.Visible = True
                                    txtFuncionMovil.Focus()
                                    Funcion = "movil"
                                    TimerGral.Start()
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
    Private Sub PintarCompletados()

        Try

            For Each r In dgvCompletados.Rows
                With CType(r.DataBoundItem, pedido)
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
                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colComReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colComReclamo.Name).ToolTipText = .v_reclamos '
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
                        r.Cells(colComReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colComReclamo.Name).ToolTipText = "Sin reclamo"
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
            ' txtCompletados.Find("PEDIDOS COMPLETADOS")
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

                '  txtDetalle.Font = New System.Drawing.Font("Verdana", 10, FontStyle.Regular)
                txtDetalle.ForeColor = Color.White
                With cls.PedidoCompletado
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
                    txtDetalle.Text &= "Domicilio: " & .v_domicilio
                    ' If .v_descripcion.Length > 0 Then txtDetalle.Text &= " " & .v_descripcion
                    '  If .v_interseccion.Length > 0 Then txtDetalle.Text &= " " & .v_interseccion
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
                    ' Detalle(.v_descripcion, True)
                    '   Detalle(.v_interseccion, True)
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
                TimerGral.Stop()
                TimerGral.Enabled = False
                With cls.PedidoCompletado
                    Dim frm As New FrmOkCancel("¿Colocar el pedido del móvil " & .ChoferMovil.v_nroMovil & " como 'A Completar'?", Nothing)
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        .completado = "1900-01-01 00:00:00"
                        cls.Pedido = cls.PedidoCompletado
                        cls.PersistirPedido()
                        cls.lstPedidoCompletado.Remove(cls.PedidoCompletado)
                        cls.lstPedidoACompletar.Add(cls.PedidoCompletado)
                        bgsCompletados.ResetBindings(False)
                        bgsACompletar.ResetBindings(False)
                        PintarACompletar()
                        PintarCompletados()
                    End If
                End With
                TimerGral.Start()
                TimerGral.Enabled = True
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
            '   txtDetalle.SelectionFont = New System.Drawing.Font("Verdana", 11, FontStyle.Bold)
            If pintar Then txtDetalle.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "31")
        End Try

    End Sub
    Private Sub PedidoCambiado(ByVal pedido As pedido) 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
        Try
            Dim pedSel
            If dgvPedidos.CurrentCell IsNot Nothing Then pedSel = bgsPedidos.Current
            BuscarPedidos()
            BuscarACompletar()
            BuscarCompletados()
            ' CargarSubBases()
            If pedSel IsNot Nothing Then
                Dim ped = (From p In cls.lstPedido Where p.id = pedSel.id)
                If ped.Count > 0 Then
                    If indicePedido > -1 Then
                        indicePedido = cls.lstPedido.IndexOf(CType(ped.First, pedido))
                    End If
                    bgsPedidos.Position = cls.lstPedido.IndexOf(CType(ped.First, pedido))
                End If
            Else
                dgvPedidos.CurrentCell = Nothing
            End If

            Dim pac = cls.lstPedidoACompletar.Find(Function(x) x.id = pedido.id)
            If pac IsNot Nothing Then
                cls.lstPedidoACompletar.Item(cls.lstPedidoACompletar.IndexOf(pac)) = pedido.Clone
                bgsACompletar.ResetBindings(False)
                PintarACompletar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "32")
        End Try

    End Sub
    Private Sub NuevoReclamo(ByVal reclamoLinea As reclamo_linea)
        Try
            Dim p = cls.lstPedido.Find(Function(x) x.id = reclamoLinea.Reclamo.pedido_id)
            If p IsNot Nothing Then
                p.lst_Reclamo = Nothing
                bgsPedidos.ResetBindings(False)
                PintarPedidos()
            Else
                p = cls.lstPedidoACompletar.Find(Function(x) x.id = reclamoLinea.Reclamo.pedido_id)
                If p IsNot Nothing Then
                    p.lst_Reclamo = Nothing
                    bgsACompletar.ResetBindings(False)
                    PintarACompletar()
                Else
                    p = cls.lstPedidoCompletado.Find(Function(x) x.id = reclamoLinea.Reclamo.pedido_id)
                    If p IsNot Nothing Then
                        p.lst_Reclamo = Nothing
                        bgsCompletados.ResetBindings(False)
                        PintarCompletados()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "PUSH"
    Dim CallPedidoCambiado As New MethodInvoker(AddressOf Me.PedidoCambiado)
    Dim CallNuevoReclamo As New MethodInvoker(AddressOf Me.NuevoReclamo)
    Dim P2 As New pedido
    Dim RL As New reclamo_linea
    Private Sub PedidoCambiado() 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
        Try
            PedidoCambiado(P2)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "33")
        End Try

    End Sub
    Private Sub NuevoReclamo()
        Try
            NuevoReclamo(RL)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "34")
        End Try

    End Sub
    Private Sub listen()
        'Try
        '    Do
        '        If TimerGral.Enabled Then
        '            Servidor.Start()
        '            'If lblMensajes.Text = "Sistema desactualizado - Presione ESC" Then
        '            'lblMensajes.Text = "Panel de Información actualizado"
        '            'End If
        '            Dim client As TcpClient = Servidor.AcceptTcpClient()
        '            Dim stream As NetworkStream = client.GetStream()
        '            Dim i As Int32
        '            Dim bytes(1024) As Byte
        '            Dim data As String = Nothing
        '            ' Loop to receive all the data sent by the client.
        '            i = stream.Read(bytes, 0, bytes.Length)
        '            While (i <> 0)
        '                ' Translate data bytes to a ASCII string.
        '                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i)

        '                Thread.Sleep(1000)
        '                My.Application.DoEvents()
        '                If IsNumeric(data) Then 'para pedidos recibo únicamente el id de pedido
        '                    P2 = New pedido
        '                    P2.FillBypedido(data, cls.getConn) '**estaba comentado, no sé por qué....
        '                    Me.BeginInvoke(CallPedidoCambiado)
        '                Else 'para reclamos recibo "RECLAMO_LINEA," & idReclamoLinea
        '                    If data.Contains("RECLAMO_LINEA") Then
        '                        Dim idRL = data.Split(",")(1)
        '                        If IsNumeric(idRL) Then
        '                            RL = New reclamo_linea
        '                            RL.FillByreclamo_linea(idRL, cls.getConn)
        '                            Me.BeginInvoke(CallNuevoReclamo)
        '                        End If
        '                    End If
        '                End If
        '                i = stream.Read(bytes, 0, bytes.Length)
        '            End While
        '            stream.Close()
        '        Else
        '            'lblMensajes.Text = "Sistema desactualizado - Presione ESC"
        '        End If
        '    Loop

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "35")
        'End Try

    End Sub

    Private Sub FrmAdministrarPedidos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            TimerGral.Stop()
            t.Abort()
            Servidor.Stop()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "36")
        End Try

    End Sub
#End Region

#Region "Frecuencia/Zonas"
    'Private Sub lklFiltroMoviles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklPorFrecuencia.LinkClicked
    '    Dim FuenteSel As New System.Drawing.Font("console UI", 9, FontStyle.Bold)
    '    Dim FuenteNoSel As New System.Drawing.Font("console UI", 9, FontStyle.Regular)
    '    If sender Is lklPorFrecuencia Then
    '        lklPorFrecuencia.Font = FuenteSel
    '        lklPorFrecuencia.LinkVisited = True
    '        lklPorBase.Font = FuenteNoSel
    '        lklPorBase.LinkVisited = False
    '        pbxAgregarMovil.Visible = True
    '        pbxBase.Visible = False
    '        If tipoAsignacion <> "FRECUENCIA" Then
    '            tipoAsignacion = "FRECUENCIA"
    '            BuscarMoviles()
    '            CargarSubBases()
    '        End If
    '    Else
    '        lklPorBase.Font = FuenteSel
    '        lklPorBase.LinkVisited = True
    '        lklPorFrecuencia.Font = FuenteNoSel
    '        lklPorFrecuencia.LinkVisited = False
    '        pbxAgregarMovil.Visible = False
    '        pbxBase.Visible = True
    '        If tipoAsignacion <> "ZONA" Then
    '            tipoAsignacion = "ZONA"
    '            If cls.Zona.id = 0 Then
    '                pbxBase_Click(Nothing, Nothing)
    '            End If
    '            If cls.Zona.id > 0 Then
    '                BuscarMoviles()
    '                CargarSubBases()
    '            Else : lklFiltroMoviles_LinkClicked(lklPorFrecuencia, Nothing)
    '            End If
    '        End If
    '        'agregado para grilla
    '        CargarSubBases()
    '    End If

    'End Sub
    'Private Sub pbxAgregarMovil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxAgregarMovil.Click
    '    Dim frm As New FrmChoferMovil(True, True, "INACTIVOS")
    '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        cls.ChoferMovil = frm.Tag
    '        cls.ChoferMovil.activo = True
    '        Try
    '            cls.PersistirChoferMovil()
    '            BuscarMoviles()
    '            CargarSubBases()
    '        Catch ex As Exception
    '            MessageBox.Show("No se ha podido agregar el móvil.")
    '        End Try
    '    End If
    'End Sub
    'Private Sub pbxBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxBase.Click
    '    Dim frm As New FrmSeleccionarZona(Nothing, cls.Zona)
    '    frm.Parent = Me.MdiParent
    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If frm.Tag IsNot Nothing Then
    '            cls.Zona = frm.Tag
    '            tipoAsignacion = "ZONA"
    '            BuscarMoviles()
    '            CargarSubBases()
    '        End If
    '    End If
    'End Sub
#End Region

#Region "Mensajero"
    Private Sub MandarMensaje(ByVal numero As String, ByVal mensaje As String)
        Try
            If numero > 7 Then
                Dim tel = numero.Substring(numero.Length - 7, 7)
                Dim cod_area = numero.Substring(0, numero.Length - 7)

                Dim texto As String = "Argentina - Personal;"
                texto &= cod_area & ";"
                texto &= tel & ";1;"
                texto &= mensaje

                Dim cadena As String = "C:\Program Files (x86)\TSM\Mensajes\tsmmensajes.exe /apipe:" & String.Format("""{0}""", texto)
                Shell(cadena, AppWinStyle.NormalFocus)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "37")
        End Try


    End Sub
#End Region

    Private Sub dgvZ1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvZ1.SelectionChanged, dgvZ2.SelectionChanged, dgvZ3.SelectionChanged, dgvZ4.SelectionChanged, dgvZ5.SelectionChanged, dgvZ6.SelectionChanged, dgvZ7.SelectionChanged, dgvZ8.SelectionChanged, dgvZ9.SelectionChanged, dgvZ10.SelectionChanged, dgvZP.SelectionChanged, dgvZT.SelectionChanged
        Try
            ' DatosMovil(sender)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "38")
        End Try

    End Sub

#Region "Buscador comentado"
    'Private Sub txtBuscador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim val As Integer
    '    If e.KeyChar = Chr(Keys.Enter) Then
    '        If Int32.TryParse(txtBuscador.Text, val) Then

    '            If Buscador(txtBuscador.Text, colMovNro.Name, dgvMoviles) Then
    '                cls.BuscarMovil(txtBuscador.Text)
    '                bgsMoviles.DataSource = cls.lstChoferMovil
    '                bgsMoviles.ResetCurrentItem()
    '                PintarMoviles()
    '                If cls.Pedido.id <> 0 Then
    '                    If asignar Then 'sólo permito si está en modo Asignar
    '                        ' If tipoAsignacion = "FRECUENCIA" OrElse (e.RowIndex = 0 AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
    '                        If (tipoAsignacion = "FRECUENCIA" AndAlso cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00") OrElse (tipoAsignacion = "ZONA" AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
    '                            With cls.ChoferMovil
    '                                Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", Nothing)
    '                                ' frm.Focus() 'no toma el enter en el frmConfirmacion, ni con focus ni select. Ya tiene la prop KeyPreview
    '                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                                    Dim cambioMovil As Boolean = cls.Pedido.movil_id > 0  'Estoy cambiando el móvil de un pedido A Completar..
    '                                    cls.Pedido.movil_id = .movil_id
    '                                    cls.Pedido.chofer_id = .chofer_id
    '                                    cls.Pedido.asignado = cls.FechaHora
    '                                    cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00"
    '                                    cls.IniciarTrn()
    '                                    Dim exito As Boolean = False
    '                                    Try
    '                                        cls.PersistirPedido(False)
    '                                        cls.PersistirMovil(False)
    '                                        cls.gettrn.Commit()
    '                                        exito = True
    '                                    Catch ex As Exception
    '                                        cls.gettrn.Rollback()
    '                                        MessageBox.Show(ex.Message)
    '                                    End Try
    '                                    If exito Then
    '                                        '.v_ultimoPedido = cls.FechaHora **
    '                                        '.v_cantPedidos += 1 **
    '                                        Habilitar("P")
    '                                        If cambioMovil Then
    '                                            cls.Pedido.ChoferMovil = Nothing 'para que refresque el valor
    '                                            bgsACompletar.ResetCurrentItem()
    '                                        Else
    '                                            cls.lstPedido.Remove(cls.Pedido)
    '                                            cls.lstPedidoACompletar.Add(cls.Pedido)
    '                                            bgsPedidos.ResetBindings(False)
    '                                            bgsACompletar.ResetBindings(False)
    '                                            PintarACompletar()
    '                                        End If
    '                                        BuscarMoviles()
    '                                        CargarSubBases()
    '                                        PintarPedidos()
    '                                        dgvPedidos_Enter(Nothing, Nothing)
    '                                        txtBuscador.Text = ""
    '                                        txtBuscador.Visible = False
    '                                    End If
    '                                End If
    '                            End With
    '                        End If
    '                    End If
    '                End If
    '            End If

    '        End If
    '    End If
    'End Sub
    'Function Buscador(ByVal TextoABuscar As String, ByVal Columna As String, ByRef grid As DataGridView) As Boolean
    '    Dim encontrado As Boolean = False
    '    If TextoABuscar = String.Empty Then Return False
    '    If grid.RowCount = 0 Then Return False
    '    grid.ClearSelection()
    '    If Columna = String.Empty Then
    '        For Each row As DataGridViewRow In grid.Rows
    '            For Each cell As DataGridViewCell In row.Cells
    '                If cell.Value.ToString() = TextoABuscar Then
    '                    row.Selected = True
    '                    Return True
    '                End If
    '            Next
    '        Next
    '    Else
    '        For Each row As DataGridViewRow In grid.Rows
    '            If row.IsNewRow Then Return False
    '            If row.Cells(Columna).Value.ToString() = TextoABuscar Then
    '                row.Selected = True
    '                Return True
    '            End If
    '        Next
    '    End If
    '    Return encontrado
    'End Function
    'Private Sub txtBuscarMovil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(Keys.Enter) Then
    '        With cls.ChoferMovil
    '            ' falta buscar el movil de acuerdo al txtbuscar movil
    '            Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", pos)
    '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                cls.Pedido.movil_id = .movil_id
    '                cls.Pedido.chofer_id = .chofer_id
    '                cls.Pedido.asignado = cls.FechaHora
    '                cls.PersistirPedido()
    '                cls.lstPedido.Remove(cls.Pedido)
    '                cls.lstPedidoACompletar.Add(cls.Pedido)
    '                .v_ultimoPedido = cls.FechaHora
    '                .v_cantPedidos += 1
    '                bgsPedidos.ResetBindings(False)
    '                bgsMoviles.DataSource = (From cm In cls.lstChoferMovil Order By cm.v_ultimoPedido Ascending).ToList
    '                bgsMoviles.ResetBindings(False)
    '                bgsACompletar.ResetBindings(False)
    '                PintarMoviles()
    '                PintarACompletar()
    '                Habilitar("P")
    '                PintarPedidos()
    '            End If
    '        End With
    '    Else
    '        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete)) Then
    '            e.KeyChar = Nothing
    '        End If
    '    End If
    'End Sub
#End Region


#Region "Asignacion de moviles a subbases con teclas de funcion"
    Private Sub FrmOperadores2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyValue = Keys.S Then
                txtFuncionMovil.Visible = True
                SubBase = 1000
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
                txtFuncionMovil.Focus()
            End If
            If e.KeyValue = Keys.F1 Then
                txtFuncionMovil.Visible = True
                SubBase = 1
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F2 Then
                txtFuncionMovil.Visible = True
                SubBase = 2
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F3 Then
                txtFuncionMovil.Visible = True
                SubBase = 3
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F4 Then
                txtFuncionMovil.Visible = True
                SubBase = 4
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F5 Then
                txtFuncionMovil.Visible = True
                SubBase = 5
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F6 Then
                txtFuncionMovil.Visible = True
                SubBase = 6
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F7 Then
                txtFuncionMovil.Visible = True
                SubBase = 7
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F8 Then
                txtFuncionMovil.Visible = True
                SubBase = 8
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F9 Then
                txtFuncionMovil.Visible = True
                SubBase = 9
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F10 Then
                txtFuncionMovil.Visible = True
                SubBase = 10
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F11 Then
                txtFuncionMovil.Visible = True
                SubBase = 11
                Funcion = "zonas"
                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.F12 Then
                txtFuncionMovil.Visible = True
                SubBase = 12
                Funcion = "zonas"

                TimerGral.Stop()
                TimerGral.Enabled = False
            End If
            If e.KeyValue = Keys.Escape Then
                TimerGral.Start()
                TimerGral.Enabled = True

            End If
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
            If cls.lstChoferMovil.Count > 0 Then
                If cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id Then 'COLOCAR EN BASE
                    With cls.ChoferMovil.Movil
                        If base <> 0 Then
                            If cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00" Or cls.ChoferMovil.Movil.zona_id <> base Then ' el movil no se encuentra en otra subbase o en ninguna
                                .zona_id = base
                                If Nega Then
                                    Dim ayer As Date
                                    ayer = Date.Now.AddDays(-1)
                                    .en_zona = ayer
                                Else
                                    .en_zona = cls.FechaHora
                                End If
                            ElseIf cls.ChoferMovil.Movil.zona_id = base Then ' el movil se encuentra en la subase, entonces lo saco
                                .en_zona = "1900-01-01 00:00:00"
                            End If
                        End If

                        Try
                            cls.PersistirMovil()
                            lblMensajes.Text = "El móvil " & movil & " se encuentra ahora " & IIf(.en_zona <> "1900-01-01 00:00:00", "en " & cls.Zona.Zona.nombre, "fuera de base") & "."
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
            TimerGral.Start()
            TimerGral.Enabled = True
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
                'End If
            ElseIf e.KeyValue = Keys.Escape Then
                If Funcion = "zonas" Then
                    lblMensajes.Text = "Panel de Información"
                    txtFuncionMovil.Text = ""
                    txtFuncionMovil.Visible = False

                    TimerGral.Enabled = True
                    TimerGral.Start()


                ElseIf Funcion = "movil" Then
                    lblMensajes.Text = "Asignación cancelada. 'Esc' para liberar pedido"
                    txtFuncionMovil.Text = ""
                    txtFuncionMovil.Visible = False

                    lblMensajes.Text = "Panel de Información"
                    cls.Pedido.operador_id = 0
                    cls.Pedido.asignado = "1900-01-01 00:00:00"
                    cls.PersistirPedido()
                    Habilitar("P")

                    TimerGral.Enabled = True
                    TimerGral.Start()
                    dgvPedidos.Focus()
                    'dgvPedidos_KeyDown(Nothing, Keys.Escape)
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

                    TimerGral.Enabled = True
                    TimerGral.Start()

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
                                cls.IniciarTrn()
                                Dim exito As Boolean = False
                                Try
                                    cls.PersistirPedido(False)
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
                            Else

                                Dim val As Int64 = 0
                                If Int64.TryParse(txtFuncionMovil.Text, val) Then
                                    cls.BuscarMovilFrecuencia(txtFuncionMovil.Text)
                                    ' If cls.ChoferMovil IsNot Nothing Then
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
                    TimerGral.Start()
                    TimerGral.Enabled = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "41")

        End Try

    End Sub
    Private Sub QuitarMovil(ByVal movil As Integer)
        cls.BuscarMovilFrecuencia(movil)
        If cls.lstChoferMovil.Count <> 0 Then
            cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00"
            cls.PersistirMovil()
            ActualizarSubBases()
            txtFuncionMovil.Visible = False
        End If
    End Sub
#Region "Asginacion de moviles a pedido "

    Private Sub AsignarPedido()
        Try
            '  cls.PedidobyId(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
            'If cls.Pedido.operador_id = cls.Operador.entidad_id Then
            ' MsgBox(cls.Pedido.operador_id)
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
                                    '  cls.PedidobyId(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
                                    If cls.Pedido.asignado = "1900-01-01 00:00:00" Or cambioMovil Then
                                        cls.Pedido.operador_id = cls.Operador.entidad_id
                                        cls.Pedido.movil_id = .movil_id
                                        cls.Pedido.chofer_id = .chofer_id
                                        cls.Pedido.asignado = DateAndTime.Now
                                        cls.BuscarChoferMovil(.movil_id)
                                        cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00"
                                        cls.IniciarTrn()
                                        Dim exito As Boolean = False
                                        Try
                                            cls.PersistirPedido(False)
                                            cls.PersistirMovil(False)
                                            cls.gettrn.Commit()
                                            exito = True
                                        Catch ex As Exception
                                            cls.gettrn.Rollback()
                                            MessageBox.Show(ex.Message)
                                        End Try
                                        If exito Then
                                            Habilitar("P")
                                            If cambioMovil Then
                                                cls.Pedido.ChoferMovil = Nothing 'para que refresque el valor
                                                bgsACompletar.ResetCurrentItem()
                                            Else
                                                cls.lstPedido.Remove(cls.Pedido)
                                                cls.lstPedidoACompletar.Add(cls.Pedido)
                                                bgsPedidos.ResetBindings(False)
                                                bgsACompletar.ResetBindings(False)
                                                PintarACompletar()
                                            End If


                                            lblMensajes.Text = "Pedido asignado al móvil " & txtFuncionMovil.Text
                                        Else
                                            lblMensajes.Text = "Error"
                                        End If
                                    Else
                                        MsgBox("No se puede enviar este pedido, ya fue asignado a otra FRECUENCIA")
                                        lblMensajes.Text = "No se puede enviar este pedido, ya fue asignado a otra frecuencia. Escape"
                                        txtFuncionMovil.Visible = False

                                    End If
                                Else

                                    PreAsignación()
                                    lblMensajes.Text = "Asignación cancelada"

                                    lblMensajes.Text = "Panel de Información"
                                    cls.Pedido.operador_id = 0
                                    cls.Pedido.asignado = "1900-01-01 00:00:00"
                                    cls.PersistirPedido()
                                    Habilitar("P")

                                    TimerGral.Enabled = True
                                    TimerGral.Start()
                                End If

                            End With
                        End If
                    End If
                End If
                CargarSubBases()
                PintarPedidos()
                txtFuncionMovil.Text = ""
                txtFuncionMovil.Visible = False
            Else
                MsgBox("Error en la conexion con la base de datos, vuelva a intentarlo")
            End If
            TimerGral.Enabled = True
            TimerGral.Start()
            'Else
            '    MsgBox("No se puede enviar este pedido, ya fue asignado a otra frecuencia")
            '    lblMensajes.Text = "No se puede enviar este pedido, ya fue asignado a otra frecuencia. Escape"
            '    txtFuncionMovil.Visible = False

            'End If

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

                TimerGral.Stop()
                TimerGral.Enabled = False

            End If
            If e.KeyValue = Keys.Escape Then
                'Esta funcion se repite en txtfuncion.key (Escape). Actualizar cambios si es necesario
                ' Tb se repite en el else de la pregunta Desea Asignar el movil?

                lblMensajes.Text = "Panel de Información"
                cls.Pedido.operador_id = 0
                cls.Pedido.asignado = "1900-01-01 00:00:00"
                cls.PersistirPedido()
                Habilitar("P")

                TimerGral.Enabled = True
                TimerGral.Start()



            End If

            If dgvPedidos.CurrentCell IsNot Nothing Then
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.F1 Or e.KeyValue = Keys.F2 Or e.KeyValue = Keys.F3 Or e.KeyValue = Keys.F4 Or e.KeyValue = Keys.F5 Or e.KeyValue = Keys.F6 Or e.KeyValue = Keys.F7 Or e.KeyValue = Keys.F8 Or e.KeyValue = Keys.F9 Or e.KeyValue = Keys.F10 Or e.KeyValue = Keys.F11 Or e.KeyValue = Keys.F12 Then
                    TimerGral.Stop()
                    TimerGral.Enabled = False
                    Dim id_pedido As Integer = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id
                    cls.PedidobyId(id_pedido)

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
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F3 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(3, dgvZ3) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F4 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(4, dgvZ4) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If


                        ElseIf e.KeyValue = Keys.F5 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(5, dgvZ5) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F6 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(6, dgvZ6) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F7 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(7, dgvZ7) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F8 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(8, dgvZ8) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F9 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(9, dgvZ9) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If


                        ElseIf e.KeyValue = Keys.F10 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(10, dgvZ10) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If

                        ElseIf e.KeyValue = Keys.F11 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(11, dgvZP) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
                            End If


                        ElseIf e.KeyValue = Keys.F12 Then
                            e.SuppressKeyPress = True
                            If AnalizarSubBase(12, dgvZT) = True Then
                                lblMensajes.Text = "Pedido Asigando al movil " & cls.ChoferMovil.v_nroMovil
                                Funcion = "bases"
                                tipoAsignacion = "ZONA"
                                PreAsignación()
                                AsignarPedido()
                            Else
                                lblMensajes.Text = "No se asignó movil "
                                txtFuncionMovil.Visible = False
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
                cls.PedidobyId(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
                If cls.Pedido.operador_id = 0 Then ' el pedido no fue tomado por ninggun operador
                    indicePedido = bgsPedidos.Position
                    cls.Pedido.operador_id = cls.Operador.entidad_id
                    cls.PersistirPedido()
                    PintarPedidoActual()
                    asignar = True
                    'MsgBox("Operador vacio")
                    '   Habilitar("M") ' habilita para asignar un movil al pedido
                Else
                    ' cls.Pedido.operador_id = 0
                    ' cls.Pedido.asignado = "1900-01-01 00:00:00"
                    'cls.PersistirPedido()
                    '   MsgBox("Otro else")
                    'Habilitar("P")
                    dgvPedidos.Focus()
                    TimerGral.Start()
                    TimerGral.Enabled = True
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
                        '  MsgBox("El movil se encuentra en una subbase, utilize las teclas F para la asignación")
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
                    TimerGral.Stop()
                    TimerGral.Enabled = False
                    If cls.Operador.entidad_id <> 0 Then 'sólo permito cambiar el móvil si el usuario tiene un operador asociado
                        cls.PedidoACompletar = CType(dgvACompletar.CurrentRow.DataBoundItem, pedido)
                        With cls.PedidoACompletar
                            If .cancelado = "1900-01-01 00:00:00" Then
                                If indicePedido = -1 Then 'si no estoy asignando móvil a un pedido
                                    If indiceACompletar = -1 Then
                                        Dim frm As New FrmOkCancel("¿Cambiar el móvil " & .ChoferMovil.v_nroMovil & " por otro?", Nothing)
                                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                            indiceACompletar = bgsACompletar.Position
                                            ' dgvPedidos.Enabled = False
                                            cls.Pedido = cls.PedidoACompletar
                                            'dgvCompletados.Enabled = False
                                            dgvACompletar.CurrentCell.ToolTipText = "Cancelar asignación"
                                            Habilitar("M")
                                            lblMensajes.Text = "Ingrese el numero de móvil que desea asignar"
                                            txtFuncionMovil.Visible = True
                                            txtFuncionMovil.Focus()
                                            Funcion = "movil"
                                        Else
                                            TimerGral.Start()
                                            TimerGral.Enabled = True

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
            TimerGral.Stop()
            TimerGral.Enabled = False

            With cls.PedidoACompletar
                Dim frm As New FrmOkCancel("¿Completar el pedido del móvil " & .ChoferMovil.v_nroMovil & "?", Nothing)
                'frm.Visible = False
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    .completado = cls.FechaHora
                    cls.Pedido = cls.PedidoACompletar
                    cls.PersistirPedido()
                    BuscarACompletar()
                    BuscarCompletados()
                    'cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
                    'cls.lstPedidoCompletado.Add(cls.PedidoACompletar)
                    'bgsACompletar.ResetBindings(False)
                    'bgsCompletados.ResetBindings(False)
                    'PintarACompletar()
                    'PintarCompletados()
                    lblMensajes.Text = "Pedido Completado"
                End If
            End With
            TimerGral.Start()
            TimerGral.Enabled = True

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
            '  MsgBox("satartttt")
            TimerGral.Start()
            TimerGral.Enabled = True
            dgvCompletados.BackgroundColor = ColorTranslator.FromOle(RGB(48, 48, 48))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "52")
        End Try
    End Sub

    Private Sub NegativoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NegativoToolStripMenuItem.Click
        Try
            TimerGral.Stop()
            TimerGral.Enabled = False

            cls.Pedido = CType(dgvCompletados.CurrentRow.DataBoundItem, pedido)
            cls.Pedido.completado = DateAndTime.Now
            cls.Pedido.observacion = "Pedido Negativo"
            cls.PersistirPedido(False)

            TimerGral.Start()
            TimerGral.Enabled = True
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
            ElseIf e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                TimerGral.Stop()
                TimerGral.Enabled = False
                lblMensajes.Text = "Sistema Desactualizado"
            Else
                TimerGral.Start()
                TimerGral.Enabled = True
                lblMensajes.Text = "Sistema Actualizado"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "53")
        End Try

    End Sub

    Private Sub btnCargarSubbases_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarSubbases.Click
        CargarSubBases()
    End Sub

    Private Sub TimerGral_Tick(sender As System.Object, e As System.EventArgs) Handles TimerGral.Tick
        CargarSubBases()
        BuscarPedidos()
        BuscarACompletar()
        BuscarCompletados()
    End Sub

    Private Sub dgvZ1_Click(sender As System.Object, e As System.EventArgs) Handles dgvZ1.Click, dgvZ2.Click, dgvZ3.Click, dgvZ4.Click, dgvZ5.Click, dgvZ6.Click, dgvZ7.Click, dgvZ8.Click, dgvZ9.Click, dgvZ10.Click, dgvZP.Click, dgvZT.Click
        DatosMovil(sender)
    End Sub

End Class