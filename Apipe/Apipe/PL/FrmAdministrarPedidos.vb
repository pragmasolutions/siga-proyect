Imports System.Net.Sockets
Imports System.Net
Imports System.Threading

Public Class FrmAdministrarPedidos
    Dim cls As New ClsAdministrarPedidos
    Dim bgsPedidos, bgsMoviles, bgsACompletar, bgsCompletados, bgsZona1, bgsZona2, bgsZona3, bgsZona4, bgsZona5, bgsZona6, bgsZona7, bgsZona8, bgsZona9, bgsZona10, bgsZonaP, bgsZonaT As New BindingSource
    Dim Servidor As TcpListener = New TcpListener(IPAddress.Any, 6600)
    Dim tipoAsignacion As String = "" ' FRECUENCIA | ZONA
    Dim t As New Threading.Thread(AddressOf listen)

#Region "Inicializar"
    Public Sub New()
        InitializeComponent()
        cls.Operador = ClsVariableSesion.Instancia.Usuario.Operador 'hago esto para evitar poner tanto código... cada vez que quiero consultar por el operador accedo a Cls.Operador        
    End Sub
    Private Sub Prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvPedidos.AutoGenerateColumns = False
        dgvMoviles.AutoGenerateColumns = False
        dgvACompletar.AutoGenerateColumns = False
        dgvCompletados.AutoGenerateColumns = False
        cls.TraspasarPedidosFrecuencia() 'necesito que esté cargado el Operador (se hace en el new)
        t.IsBackground = True
        t.Start()
        dgvPedidos.DataSource = bgsPedidos
        dgvMoviles.DataSource = bgsMoviles
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
        'BuscarMoviles()
        lklFiltroMoviles_LinkClicked(lklPorFrecuencia, Nothing)
        BuscarACompletar()
        BuscarCompletados()
        Habilitar("P")
        btnMostrarCompletados_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "Pedidos"
    Private Sub BuscarPedidos()
        cls.CargarPedidos()
        bgsPedidos.DataSource = cls.lstPedido
        bgsPedidos.ResetBindings(False)
        PintarPedidos()
    End Sub

    Private Sub TratarPedidoTomado()
        For Each p In (From ped In cls.lstPedido Where ped.operador_id > 0 And ped.operador_id = cls.Operador.entidad_id And ped.movil_id = 0).ToList
            bgsPedidos.Position = bgsPedidos.List.IndexOf(p)
            indicePedido = bgsPedidos.Position
            Habilitar("M")
            Exit For
        Next
    End Sub

    Private Sub PintarPedidos()
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
                    r.Cells(colPedReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
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
    End Sub

    Private Sub PintarPedidoActual()
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
                .Cells(colPedReclamo.Name).ToolTipText = cls.Pedido.v_reclamos ' cls.Pedido.lst_Reclamo.First.lst_ReclamoLinea.First.comentario
            Else
                .Cells(colPedReclamo.Name).Value = My.Resources.vacio
                .Cells(colPedReclamo.Name).ToolTipText = "Sin reclamo"
            End If
        End With
    End Sub

    Private Sub dgvPedidos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPedidos.SelectionChanged
        If bgsPedidos.Count > 0 Then
            If indicePedido > -1 Then bgsPedidos.Position = indicePedido
            cls.Pedido = bgsPedidos.Item(bgsPedidos.Position)
            DatosPedido()
        End If
    End Sub

    Private Sub dgvPedidos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPedidos.Enter
        bgsPedidos.ResetCurrentItem()
        spcAsignados.Panel1.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcAsignados.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcPedidos.Panel2.BackColor = Color.DarkGray
        spcArriba.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        dgvMoviles.CurrentCell = Nothing
        dgvACompletar.CurrentCell = Nothing
        dgvCompletados.CurrentCell = Nothing
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
        DatosPedido()
    End Sub

    Private Sub dgvPedidos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvPedidos.DataBindingComplete
        txtPedidos.Text = dgvPedidos.RowCount & " PEDIDOS PENDIENTES"
        txtPedidos.SelectAll()
        txtPedidos.SelectionAlignment = HorizontalAlignment.Center
        txtPedidos.Find("PEDIDOS PENDIENTES")
        txtPedidos.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub

    Private Sub DatosPedido()
        Dim reclamo As String = ""
        txtDetalle.Text = ""
        gbxDetalle.Text = "PEDIDO PENDIENTE"
        If dgvPedidos.CurrentRow IsNot Nothing Then
            txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
            txtDetalle.ForeColor = Color.White
            With cls.Pedido
                If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
                txtDetalle.Text &= "Domicilio: " & .v_domicilio
                If .v_descripcion.Length > 0 Then txtDetalle.Text &= " " & .v_descripcion
                If .v_interseccion.Length > 0 Then txtDetalle.Text &= " " & .v_interseccion
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
                Detalle(.v_descripcion, True)
                Detalle(.v_interseccion, True)
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
    End Sub

    Private Sub dgvPedidos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        If cls.Operador.entidad_id <> 0 And e.ColumnIndex = colPedAsignar.Index Then 'sólo permito asignar si el usuario tiene un operador asignado
            If cls.Pedido.operador_id = 0 Then
                indicePedido = bgsPedidos.Position
                cls.Pedido.operador_id = cls.Operador.entidad_id
                cls.PersistirPedido()
                PintarPedidoActual()
                Habilitar("M")
                txtBuscador.Visible = True
                txtBuscador.Focus()
            Else
                cls.Pedido.operador_id = 0
                cls.Pedido.asignado = "1900-01-01 00:00:00"
                cls.PersistirPedido()
                Habilitar("P")
            End If
        End If
    End Sub
#End Region

#Region "Moviles"
    Private Sub BuscarMoviles()
        If tipoAsignacion = "ZONA" Then
            cls.CargarMovilesZona()
            bgsMoviles.DataSource = cls.lstChoferMovil
            PintarMoviles()

        Else
            cls.CargarMoviles()
            bgsMoviles.DataSource = cls.lstChoferMovil
            PintarMoviles()
        End If
    End Sub
    Private Sub BuscarMovilesFrecuencia()
        'If tipoAsignacion = "ZONA" Then
        '    cls.CargarMovilesZona()
        '    bgsMoviles.DataSource = cls.lstChoferMovil
        '    PintarMoviles()

        'Else
        cls.CargarMoviles()
        bgsMoviles.DataSource = cls.lstChoferMovil
        PintarMoviles()
        ' End If
    End Sub
    Private Sub CargarSubBases()
        'para grilla
        'Dim lst As New List(Of zona)
        'lst.AddRange(ClsEnumerados.Instancia.lstZonas)

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

        '
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


        dgvMoviles.CurrentCell = Nothing
    End Sub
    Private Sub PintarMoviles()
        For Each r As DataGridViewRow In dgvMoviles.Rows
            With CType(r.DataBoundItem, chofer_movil)
                If .Movil.frecuencia_id = cls.Operador.frecuencia_id And (tipoAsignacion = "FRECUENCIA" Or dgvMoviles.Rows.IndexOf(r) = 0) Then
                    r.Cells(colMovAsignar.Name).ToolTipText = "Asignar"
                Else
                    r.Cells(colMovAsignar.Name).ToolTipText = "No se puede asignar"
                End If
                If .Movil.aire Then
                    r.Cells(colMovAire.Name).Value = My.Resources.aire
                    r.Cells(colMovAire.Name).ToolTipText = "Con Aire"
                Else
                    r.Cells(colMovAire.Name).Value = My.Resources.vacio
                    r.Cells(colMovAire.Name).ToolTipText = "Sin Aire"
                End If
                If .Chofer.factura Then
                    r.Cells(colMovFactura.Name).Value = My.Resources.factura
                    r.Cells(colMovFactura.Name).ToolTipText = "Con Factura"
                Else
                    r.Cells(colMovFactura.Name).Value = My.Resources.vacio
                    r.Cells(colMovFactura.Name).ToolTipText = "Sin Factura"
                End If
                Select Case .Movil.baul
                    Case "GRANDE"
                        r.Cells(colMovBaul.Name).Value = My.Resources.baul3
                        r.Cells(colMovBaul.Name).ToolTipText = "Baúl grande"
                    Case "MEDIANO"
                        r.Cells(colMovBaul.Name).Value = My.Resources.baul2
                        r.Cells(colMovBaul.Name).ToolTipText = "Baúl mediano"
                    Case "CHICO"
                        r.Cells(colMovBaul.Name).Value = My.Resources.baul1
                        r.Cells(colMovBaul.Name).ToolTipText = "Baúl chico"
                    Case Else
                        r.Cells(colMovBaul.Name).Value = My.Resources.vacio
                        r.Cells(colMovBaul.Name).ToolTipText = "Baúl no especificado"
                End Select
                r.Cells(colMovBase.Name).ToolTipText = "Colocar en Base"
                r.Cells(colMovQuitar.Name).ToolTipText = "Quitar Móvil"
            End With
        Next
        dgvMoviles.Refresh()
    End Sub
    Private Sub dgvMoviles_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMoviles.SelectionChanged
        If bgsMoviles.Count > 0 Then
            cls.ChoferMovil = bgsMoviles.Item(bgsMoviles.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvZ1.SelectionChanged
        If bgsZona1.Count > 0 Then
            cls.ChoferMovil = bgsZona1.Item(bgsZona1.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvZ2.SelectionChanged
        If bgsZona2.Count > 0 Then
            cls.ChoferMovil = bgsZona2.Item(bgsZona2.Position)
            DatosMovil()
        End If
    End Sub



    Private Sub dgvMoviles_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMoviles.Enter
        spcAsignados.Panel1.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcAsignados.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcPedidos.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcArriba.Panel2.BackColor = Color.DarkGray
        DatosMovil()
    End Sub
    Private Sub dgvMoviles_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvMoviles.DataBindingComplete
        txtMoviles.Text = dgvMoviles.RowCount & " MÓVILES " & IIf(tipoAsignacion = "ZONA", "EN " & cls.Zona.nombre.ToUpper, "EN FRECUENCIA " & cls.Operador.Frecuencia.numero)
        txtMoviles.SelectAll()
        txtMoviles.SelectionAlignment = HorizontalAlignment.Center
        txtMoviles.Find("MÓVILES " & IIf(tipoAsignacion = "ZONA", "EN " & cls.Zona.nombre.ToUpper, "EN FRECUENCIA " & cls.Operador.Frecuencia.numero))
        txtMoviles.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub
    Private Sub DatosMovil()
        txtDetalle.Text = ""
        gbxDetalle.Text = "MÓVIL"
        If dgvMoviles.CurrentRow IsNot Nothing Then
            txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
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
    End Sub

    Private Sub dgvMoviles_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMoviles.CellClick
        tipoAsignacion = "FRECUENCIA"
        AsignarMovil(sender, e)
    End Sub
    Private Sub dgvZ1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvZ1.CellClick, dgvZ2.CellClick, dgvZ3.CellClick, dgvZ4.CellClick, dgvZ5.CellClick, dgvZ6.CellClick, dgvZ7.CellClick, dgvZ8.CellClick, dgvZ9.CellClick, dgvZ10.CellClick, dgvZP.CellClick, dgvZT.CellClick
        tipoAsignacion = "ZONA"
        AsignarMovil(sender, e)
    End Sub
    Private Sub AsignarMovil(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = colMovAsignar.Index Then 'ASIGNAR MOVIL
            If asignar Then 'sólo permito si está en modo Asignar
                ' If tipoAsignacion = "FRECUENCIA" OrElse (e.RowIndex = 0 AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
                If (tipoAsignacion = "FRECUENCIA" AndAlso cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00") OrElse (tipoAsignacion = "ZONA" AndAlso e.RowIndex = 0 AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
                    With cls.ChoferMovil
                        Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", Nothing)
                        ' frm.Focus() 'no toma el enter en el frmConfirmacion, ni con focus ni select. Ya tiene la prop KeyPreview
                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Dim cambioMovil As Boolean = cls.Pedido.movil_id > 0  'Estoy cambiando el móvil de un pedido A Completar..
                            cls.Pedido.movil_id = .movil_id
                            cls.Pedido.chofer_id = .chofer_id
                            cls.Pedido.asignado = cls.FechaHora
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
                                '.v_ultimoPedido = cls.FechaHora **
                                '.v_cantPedidos += 1 **
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
                                BuscarMoviles()
                                CargarSubBases()
                                'bgsMoviles.DataSource = (From cm In cls.lstChoferMovil Order By cm.v_ultimoPedido Ascending).ToList **
                                'bgsMoviles.ResetBindings(False) **
                                'PintarMoviles() **
                                'Habilitar("P") lo subo..
                                PintarPedidos()
                                dgvPedidos_Enter(Nothing, Nothing)
                                txtBuscador.Text = ""
                                txtBuscador.Visible = False
                            End If
                        End If
                    End With
                End If
            End If
        ElseIf e.ColumnIndex = colMovBase.Index AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id Then 'COLOCAR EN BASE
            Dim frm As New FrmSeleccionarZonabtns(Nothing, cls.ChoferMovil.Movil.Zona, True)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                With cls.ChoferMovil.Movil
                    If CType(frm.Tag, zona).id <> 0 Then
                        cls.Zona = frm.Tag
                        .Zona = cls.Zona
                        .zona_id = .Zona.id
                        .en_zona = cls.FechaHora
                        '.en_zona = "2012-09-19 12:09:30"
                    Else
                        .en_zona = "1900-01-01 00:00:00"
                    End If
                    Try
                        cls.PersistirMovil()
                        'MessageBox.Show("El móvil " & .numero & " se encuentra ahora " & IIf(CType(frm.Tag, zona).id <> 0, "en " & .Zona.nombre, "fuera de base") & ".")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    ' BuscarMoviles()
                    BuscarMovilesFrecuencia()
                    CargarSubBases()
                End With
            End If
        ElseIf e.ColumnIndex = colMovQuitar.Index AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id Then 'QUITAR MÓVIL
            With cls.ChoferMovil
                Dim frm As New FrmConfirmacion("¿Confirma que desea quitar el móvil " & .v_nroMovil & "?", System.Windows.Forms.Control.MousePosition)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    .activo = False
                    Try
                        cls.PersistirChoferMovil()
                        MessageBox.Show("El móvil ha sido quitado.")
                    Catch ex As Exception
                        MessageBox.Show("Ha ocurrido un error." + vbNewLine + ex.Message)
                    End Try
                    BuscarMoviles()
                    CargarSubBases()
                End If
            End With
        End If

    End Sub
    'Buscador de móvil
    Private Sub dgvMoviles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvMoviles.KeyPress
        If Not pnlBuscarMovil.Visible Then
            pnlBuscarMovil.Visible = True
            If IsNumeric(e.KeyChar) Then
                txtBuscarMovil_KeyPress(txtBuscarMovil, e)
                txtBuscarMovil.Text = e.KeyChar
                txtBuscarMovil.Focus()
                txtBuscarMovil.Select(txtBuscarMovil.TextLength, 0)
            End If
        End If
    End Sub
    Private Sub txtBuscarMovil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarMovil.KeyPress
        pnlBuscarMovil.Visible = True
        'timer
        'tmrBuscarMovil.Stop()
        'tmrBuscarMovil.Start()
        If e.KeyChar = Chr(Keys.Enter) Then
            With cls.ChoferMovil
                ' falta buscar el movil de acuerdo al txtbuscar movil
                Dim pos As New System.Drawing.Point(dgvMoviles.Location.X + spcArriba.SplitterDistance, dgvMoviles.Location.Y + (bgsMoviles.Count + 1) * 24)
                Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", pos)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    cls.Pedido.movil_id = .movil_id
                    cls.Pedido.chofer_id = .chofer_id
                    cls.Pedido.asignado = cls.FechaHora
                    cls.PersistirPedido()
                    cls.lstPedido.Remove(cls.Pedido)
                    cls.lstPedidoACompletar.Add(cls.Pedido)
                    .v_ultimoPedido = cls.FechaHora
                    .v_cantPedidos += 1
                    bgsPedidos.ResetBindings(False)
                    bgsMoviles.DataSource = (From cm In cls.lstChoferMovil Order By cm.v_ultimoPedido Ascending).ToList
                    bgsMoviles.ResetBindings(False)
                    bgsACompletar.ResetBindings(False)
                    PintarMoviles()
                    PintarACompletar()
                    Habilitar("P")
                    PintarPedidos()
                End If
            End With
        Else
            If Not (IsNumeric(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete)) Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub
    Private Sub txtBuscarMovil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMovil.TextChanged
        txtBuscarMovil.Select(txtBuscarMovil.Text.Length, 0)
        'txtBuscarMovil.Select(0, txtBuscarMovil.Text.Length)
    End Sub
    Private Sub tmrBuscarMovil_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBuscarMovil.Tick
        'timer
        'If pnlBuscarMovil.Visible Then
        '    pnlBuscarMovil.Visible = False
        '    txtBuscarMovil.Text = ""
        '    tmrBuscarMovil.Stop()
        '    dgvMoviles.Select()
        'End If
    End Sub
    'Parpadeo para indicar que se debe asignar móvil
    Private Sub tmrAsignar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsignar.Tick
        If txtMoviles.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9)) Then
            txtMoviles.BackColor = ColorTranslator.FromOle(RGB(232, 81, 29))
            pbxAgregarMovil.BackColor = ColorTranslator.FromOle(RGB(232, 81, 29))
            pbxBase.BackColor = ColorTranslator.FromOle(RGB(232, 81, 29))
            txtMoviles.Find("Moviles" & IIf(tipoAsignacion = "ZONA", " EN " & cls.Zona.nombre.ToUpper, ""))
            txtMoviles.SelectionColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        Else
            txtMoviles.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
            pbxAgregarMovil.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
            pbxBase.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
            txtMoviles.Find("Moviles" & IIf(tipoAsignacion = "ZONA", " EN " & cls.Zona.nombre.ToUpper, ""))
            txtMoviles.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        End If
    End Sub
#End Region

#Region "ACompletar"
    Private Sub BuscarACompletar()
        cls.CargarPedidosACompletar()
        bgsACompletar.DataSource = cls.lstPedidoACompletar
        PintarACompletar()
    End Sub
    Private Sub PintarACompletar()
        For Each r In dgvACompletar.Rows
            With CType(r.DataBoundItem, pedido)
                r.Cells(colACompCompletar.Name).ToolTipText = "Completar pedido"
                If .cancelado <> "1900-01-01 00:00:00" Then
                    r.Cells(colACompCambiarMovil.Name).Value = My.Resources.notiene
                    r.Cells(colACompCambiarMovil.Name).ToolTipText = "Pedido cancelado"
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
                        'r.Cells(8).Style.BackColor = Color.Green
                    ElseIf .lst_Reclamo.First.lst_ReclamoLinea.Count = 2 Then
                        r.Cells(0).Style.BackColor = Color.Orange
                        r.Cells(1).Style.BackColor = Color.Orange
                        r.Cells(2).Style.BackColor = Color.Orange
                        r.Cells(3).Style.BackColor = Color.Orange
                        r.Cells(4).Style.BackColor = Color.Orange
                        r.Cells(5).Style.BackColor = Color.Orange
                        r.Cells(6).Style.BackColor = Color.Orange
                        r.Cells(7).Style.BackColor = Color.Orange
                        ' r.Cells(8).Style.BackColor = Color.Orange
                    Else
                        r.Cells(0).Style.BackColor = Color.Red
                        r.Cells(1).Style.BackColor = Color.Red
                        r.Cells(2).Style.BackColor = Color.Red
                        r.Cells(3).Style.BackColor = Color.Red
                        r.Cells(4).Style.BackColor = Color.Red
                        r.Cells(5).Style.BackColor = Color.Red
                        r.Cells(6).Style.BackColor = Color.Red
                        r.Cells(7).Style.BackColor = Color.Red
                        ' r.Cells(8).Style.BackColor = Color.Red
                    End If
                Else
                    r.Cells(colACompReclamo.Name).Value = My.Resources.vacio
                    r.Cells(colACompReclamo.Name).ToolTipText = "Sin reclamo"
                End If
            End With
        Next
    End Sub
    Private Sub dgvACompletar_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvACompletar.SelectionChanged
        If bgsACompletar.Count > 0 Then
            If indiceACompletar > -1 Then bgsACompletar.Position = indiceACompletar
            cls.PedidoACompletar = bgsACompletar.Item(bgsACompletar.Position)
            DatosACompletar()
        End If
    End Sub
    Private Sub dgvACompletar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvACompletar.Enter
        spcAsignados.Panel1.BackColor = Color.DarkGray
        spcAsignados.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcPedidos.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcArriba.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        If Not asignar Then ' dgvMoviles.Enabled 
            dgvPedidos.CurrentCell = Nothing
        End If
        If indiceACompletar = -1 Then dgvMoviles.CurrentCell = Nothing
        dgvCompletados.CurrentCell = Nothing
        DatosACompletar()
    End Sub
    Private Sub dgvACompletar_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvACompletar.DataBindingComplete
        txtACompletar.Text = dgvACompletar.RowCount & " PEDIDOS A COMPLETAR"
        txtACompletar.SelectAll()
        txtACompletar.SelectionAlignment = HorizontalAlignment.Center
        txtACompletar.Find("PEDIDOS A COMPLETAR")
        txtACompletar.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub
    Private Sub DatosACompletar()
        Dim reclamo As String = ""
        txtDetalle.Text = ""
        gbxDetalle.Text = "PEDIDO A COMPLETAR"
        If dgvACompletar.CurrentRow IsNot Nothing Then
            txtDetalle.Font = New System.Drawing.Font("Verdana", 10, FontStyle.Regular)
            txtDetalle.ForeColor = Color.White
            With cls.PedidoACompletar
                If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
                txtDetalle.Text &= "Domicilio: " & .v_domicilio
                If .v_descripcion.Length > 0 Then txtDetalle.Text &= " " & .v_descripcion
                If .v_interseccion.Length > 0 Then txtDetalle.Text &= " " & .v_interseccion
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
                Detalle(.v_descripcion, True)
                Detalle(.v_interseccion, True)
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
    End Sub
    Dim indiceACompletar As Integer = -1
    Private Sub dgvACompletar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvACompletar.CellClick
        If e.ColumnIndex = colACompCompletar.Index Then
            With cls.PedidoACompletar
                Dim frm As New FrmConfirmacion("¿Completar el pedido del móvil " & .ChoferMovil.v_nroMovil & "?", System.Windows.Forms.Control.MousePosition)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    .completado = cls.FechaHora
                    cls.Pedido = cls.PedidoACompletar
                    cls.PersistirPedido()
                    cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
                    cls.lstPedidoCompletado.Add(cls.PedidoACompletar)
                    bgsACompletar.ResetBindings(False)
                    bgsCompletados.ResetBindings(False)
                    PintarACompletar()
                    PintarCompletados()
                End If
            End With
        ElseIf e.ColumnIndex = colmensajero.Index Then 'mensajero
            '    MsgBox("mensaje")

            If cls.PedidoACompletar.Movil.telefono <> "" Then
                With cls.PedidoACompletar
                    Dim frm As New FrmConfirmacion("¿Completar el pedido del móvil mediante SMS " & .ChoferMovil.v_nroMovil & "?", System.Windows.Forms.Control.MousePosition)
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
                            Dim frm As New FrmConfirmacion("¿Cambiar el móvil " & .ChoferMovil.v_nroMovil & " por otro?", System.Windows.Forms.Control.MousePosition)
                            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                indiceACompletar = bgsACompletar.Position
                                dgvPedidos.Enabled = False
                                cls.Pedido = cls.PedidoACompletar
                                dgvCompletados.Enabled = False
                                dgvACompletar.CurrentCell.Value = My.Resources.manoce
                                dgvACompletar.CurrentCell.ToolTipText = "Cancelar asignación"
                                Habilitar("M")
                            End If
                        Else
                            Habilitar("P")
                        End If
                    End If
                End If
            End With
        End If
    End Sub
#End Region

#Region "Completados"
    Private Sub BuscarCompletados()
        cls.CargarPedidosCompletados()
        bgsCompletados.DataSource = cls.lstPedidoCompletado
        PintarCompletados()
    End Sub
    Private Sub PintarCompletados()
        For Each r In dgvCompletados.Rows
            With CType(r.DataBoundItem, pedido)
                If .cancelado <> "1900-01-01 00:00:00" Then
                    r.Cells(colComVolver.Name).Value = My.Resources.notiene
                    r.Cells(colComVolver.Name).ToolTipText = "Pedido cancelado"
                Else
                    r.Cells(colComVolver.Name).Value = My.Resources.deshacer
                    r.Cells(colComVolver.Name).ToolTipText = "Colocar como 'A Completar'"
                End If
                If .lst_Reclamo.Count > 0 Then
                    r.Cells(colComReclamo.Name).Value = My.Resources.signoreclamo
                    r.Cells(colComReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
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
    End Sub
    Private Sub dgvCompletados_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCompletados.SelectionChanged
        If bgsCompletados.Count > 0 Then
            cls.PedidoCompletado = bgsCompletados.Item(bgsCompletados.Position)
            DatosCompletado()
        End If
    End Sub
    Private Sub dgvCompletados_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCompletados.Enter
        spcAsignados.Panel1.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcAsignados.Panel2.BackColor = Color.DarkGray
        spcPedidos.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        spcArriba.Panel2.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
        If Not asignar Then ' dgvMoviles.Enabled
            dgvPedidos.CurrentCell = Nothing
        End If
        dgvACompletar.CurrentCell = Nothing
        DatosCompletado()
    End Sub
    Private Sub dgvCompletados_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvCompletados.DataBindingComplete
        txtCompletados.Text = dgvCompletados.RowCount & " PEDIDOS COMPLETADOS"
        txtCompletados.SelectAll()
        txtCompletados.SelectionAlignment = HorizontalAlignment.Center
        txtCompletados.Find("PEDIDOS COMPLETADOS")
        txtCompletados.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub
    Private Sub DatosCompletado()
        Dim reclamo As String = ""
        txtDetalle.Text = ""
        gbxDetalle.Text = "PEDIDO COMPLETADO"
        If dgvCompletados.CurrentRow IsNot Nothing Then
            txtDetalle.Font = New System.Drawing.Font("Verdana", 10, FontStyle.Regular)
            txtDetalle.ForeColor = Color.White
            With cls.PedidoCompletado
                If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
                txtDetalle.Text &= "Domicilio: " & .v_domicilio
                If .v_descripcion.Length > 0 Then txtDetalle.Text &= " " & .v_descripcion
                If .v_interseccion.Length > 0 Then txtDetalle.Text &= " " & .v_interseccion
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
                Detalle(.v_descripcion, True)
                Detalle(.v_interseccion, True)
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
    End Sub
    Private Sub dgvCompletados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCompletados.CellClick
        If e.ColumnIndex = colComVolver.Index Then
            With cls.PedidoCompletado
                Dim frm As New FrmConfirmacion("¿Colocar el pedido del móvil " & .ChoferMovil.v_nroMovil & " como 'A Completar'?", System.Windows.Forms.Control.MousePosition)
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
        End If
    End Sub
    Dim mostrarCompletados As Boolean = True
    Private Sub btnMostrarCompletados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarCompletados.Click
        If mostrarCompletados Then 'se están mostrando y quiero que se oculten
            spcAsignados.SplitterDistance = spcArriba.Height - txtCompletados.Height - 20 'spcArriba.Height / 4 * 3
            mostrarCompletados = False
            btnMostrarCompletados.Text = "^" '** debería ser una imagen
        Else
            spcAsignados.SplitterDistance = txtACompletar.Height + 20 ' spcArriba.Height / 4
            mostrarCompletados = True
            btnMostrarCompletados.Text = "v" '** debería ser una imagen
        End If
    End Sub
#End Region

#Region "Procedimientos y Funciones"
    Dim indicePedido As Integer = -1
    Dim asignar As Boolean = False
    ''' <summary>Habilita la sección indicada e inhabilita la otra.</summary>
    ''' <param name="s">Sección a habilitar: P=Pedido, M=Móvil</param>
    Private Sub Habilitar(ByVal s As Char)
        If s = "P" Then
            asignar = False
            indicePedido = -1
            'dgvMoviles.Enabled = False
            If Not dgvCompletados.Enabled Then dgvCompletados.Enabled = True
            If indiceACompletar > -1 Then 'Not dgvACompletar.Enabled
                indiceACompletar = -1
                dgvPedidos.Enabled = True
                dgvACompletar.CurrentCell.Value = My.Resources.movil
                dgvACompletar.CurrentCell.ToolTipText = "Asignar móvil"
                dgvACompletar.Focus()
            Else
                dgvPedidos.Focus()
                PintarPedidoActual()
            End If
            tmrAsignar.Stop()
            txtMoviles.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
            txtMoviles.Find("Moviles")
            txtMoviles.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
            TratarPedidoTomado()
        Else
            asignar = True
            'dgvMoviles.Enabled = True
            pnlBuscarMovil.BackColor = ColorTranslator.FromOle(RGB(9, 9, 9))
            dgvMoviles.Focus()
            tmrAsignar.Start()
        End If
    End Sub
    Private Sub Detalle(ByVal palabra As String, Optional ByVal pintar As Boolean = False)
        txtDetalle.Find(palabra, RichTextBoxFinds.MatchCase)
        txtDetalle.SelectionFont = New System.Drawing.Font("Verdana", 11, FontStyle.Bold)
        If pintar Then txtDetalle.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        'txtDetalle.Select() 'para limpiar la selección (no sé si anda, estoy probando)
    End Sub
    Private Sub PedidoCambiado(ByVal pedido As pedido) 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
        Dim pedSel
        If dgvPedidos.CurrentCell IsNot Nothing Then pedSel = bgsPedidos.Current
        BuscarPedidos()
        BuscarACompletar()
        BuscarCompletados()
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

        'Dim p = cls.lstPedido.Find(Function(x) x.id = pedido.id)
        'If p Is Nothing Then
        '    If pedido.chofer_id = 0 And (pedido.operador_id = 0 Or pedido.operador_id = cls.Operador.entidad_id) Then
        '        cls.lstPedido.Add(pedido)
        '        cls.lstPedido = (From ped In cls.lstPedido Order By ped.fechahora_viaje Ascending).ToList
        '        p = cls.lstPedido.Find(Function(x) x.id = pedido.id)
        '        If cls.lstPedido.IndexOf(p) < bgsPedidos.Position Then bgsPedidos.Position += 1
        '        bgsPedidos.DataSource = cls.lstPedido
        '        bgsPedidos.ResetBindings(True)
        '        PintarPedidos()
        '    End If
        'Else
        '    If pedido.movil_id > 0 Or (pedido.operador_id > 0 And pedido.operador_id <> cls.Operador.entidad_id) Then
        '        If cls.lstPedido.IndexOf(p) < bgsPedidos.Position Then
        '            cls.lstPedido.Remove(p)
        '            bgsPedidos.Position -= 1
        '        Else : cls.lstPedido.Remove(p)
        '        End If
        '        bgsPedidos.ResetBindings(False)
        '        PintarPedidos()
        '    Else
        '        cls.lstPedido.Item(cls.lstPedido.IndexOf(p)) = pedido.Clone
        '        bgsPedidos.ResetBindings(False)
        '        PintarPedidos()
        '    End If
        'End If
    End Sub
    Private Sub NuevoReclamo(ByVal reclamoLinea As reclamo_linea)
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
    End Sub
#End Region

#Region "PUSH"
    Dim CallPedidoCambiado As New MethodInvoker(AddressOf Me.PedidoCambiado)
    Dim CallNuevoReclamo As New MethodInvoker(AddressOf Me.NuevoReclamo)
    Dim P2 As New pedido
    Dim RL As New reclamo_linea
    Private Sub PedidoCambiado() 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
        PedidoCambiado(P2)
    End Sub
    Private Sub NuevoReclamo()
        NuevoReclamo(RL)
    End Sub
    Private Sub listen()
        Do
            Servidor.Start()
            Dim client As TcpClient = Servidor.AcceptTcpClient()
            Dim stream As NetworkStream = client.GetStream()
            Dim i As Int32
            Dim bytes(1024) As Byte
            Dim data As String = Nothing
            ' Loop to receive all the data sent by the client.
            i = stream.Read(bytes, 0, bytes.Length)
            While (i <> 0)
                ' Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i)
                'MsgBox([String].Format("Received: {0}", data))
                Thread.Sleep(1000)
                My.Application.DoEvents()
                If IsNumeric(data) Then 'para pedidos recibo únicamente el id de pedido
                    P2 = New pedido
                    P2.StoreFillBypedido(data, cls.getConn) '**estaba comentado, no sé por qué....
                    Me.BeginInvoke(CallPedidoCambiado)
                Else 'para reclamos recibo "RECLAMO_LINEA," & idReclamoLinea
                    If data.Contains("RECLAMO_LINEA") Then
                        Dim idRL = data.Split(",")(1)
                        If IsNumeric(idRL) Then
                            RL = New reclamo_linea
                            RL.FillByreclamo_linea(idRL, cls.getConn)
                            Me.BeginInvoke(CallNuevoReclamo)
                        End If
                    End If
                End If
                i = stream.Read(bytes, 0, bytes.Length)
            End While
            stream.Close()
        Loop
    End Sub

    Private Sub FrmAdministrarPedidos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        t.Abort()
        Servidor.Stop()
    End Sub
#End Region

    'Cosas extras sólo para prueba.. 
    ' Dim nro As Integer = 999
    'Private Sub btnEntraPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklIngresarPedido.LinkClicked
    '    Dim p As New pedido
    '    With p
    '        nro += 1
    '        .id = nro
    '        .cliente = 1
    '        .fechahora = Now
    '        .fechahora_viaje = Now
    '        .usuario_id = 1
    '        .pedido_categoria_id = 1
    '        .domicilio_id = 1
    '        .telefono_id = 1
    '    End With
    '    PedidoCambiado(p)
    'End Sub

    'Private Sub btnBloqueaPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklBloquearPedido.LinkClicked
    '    Dim p = cls.lstPedido(CInt(cls.lstPedido.Count / 2))
    '    If p IsNot Nothing Then
    '        With p
    '            If p.operador_id > 0 Then
    '                .operador_id = Nothing
    '            Else
    '                .operador_id = 1
    '            End If
    '        End With
    '        PedidoCambiado(p)
    '    End If
    'End Sub

#Region "Frecuencia/Zonas"
    Private Sub lklFiltroMoviles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklPorFrecuencia.LinkClicked, lklPorBase.LinkClicked
        Dim FuenteSel As New System.Drawing.Font("console UI", 9, FontStyle.Bold)
        Dim FuenteNoSel As New System.Drawing.Font("console UI", 9, FontStyle.Regular)
        If sender Is lklPorFrecuencia Then
            lklPorFrecuencia.Font = FuenteSel
            lklPorFrecuencia.LinkVisited = True
            lklPorBase.Font = FuenteNoSel
            lklPorBase.LinkVisited = False
            pbxAgregarMovil.Visible = True
            pbxBase.Visible = False
            If tipoAsignacion <> "FRECUENCIA" Then
                tipoAsignacion = "FRECUENCIA"
                BuscarMoviles()
                CargarSubBases()
            End If
        Else
            lklPorBase.Font = FuenteSel
            lklPorBase.LinkVisited = True
            lklPorFrecuencia.Font = FuenteNoSel
            lklPorFrecuencia.LinkVisited = False
            pbxAgregarMovil.Visible = False
            pbxBase.Visible = True
            If tipoAsignacion <> "ZONA" Then
                tipoAsignacion = "ZONA"
                If cls.Zona.id = 0 Then
                    pbxBase_Click(Nothing, Nothing)
                End If
                If cls.Zona.id > 0 Then
                    BuscarMoviles()
                    CargarSubBases()
                Else : lklFiltroMoviles_LinkClicked(lklPorFrecuencia, Nothing)
                End If
            End If
            'agregado para grilla
            CargarSubBases()
        End If

    End Sub
    Private Sub pbxAgregarMovil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxAgregarMovil.Click
        Dim frm As New FrmChoferMovil(True, True, "INACTIVOS")
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            cls.ChoferMovil = frm.Tag
            cls.ChoferMovil.activo = True
            Try
                cls.PersistirChoferMovil()
                BuscarMoviles()
                CargarSubBases()
            Catch ex As Exception
                MessageBox.Show("No se ha podido agregar el móvil.")
            End Try
        End If
    End Sub
    'Private Sub pbxBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxBase.Click
    '    Dim frm As New FrmSeleccionarZona(System.Windows.Forms.Control.MousePosition, cls.Zona)
    '    frm.Parent = Me.MdiParent
    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If frm.Tag IsNot Nothing Then
    '            cls.Zona = frm.Tag
    '            tipoAsignacion = "ZONA"
    '            BuscarMoviles()
    '        End If
    '    End If
    'End Sub
    Private Sub pbxBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxBase.Click
        Dim frm As New FrmSeleccionarZona(Nothing, cls.Zona)
        frm.Parent = Me.MdiParent
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frm.Tag IsNot Nothing Then
                cls.Zona = frm.Tag
                tipoAsignacion = "ZONA"
                BuscarMoviles()
                CargarSubBases()
            End If
        End If
    End Sub
    'Private Sub txtMoviles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMoviles.Click
    '    If tipoAsignacion = "FRECUENCIA" Then
    '        tipoAsignacion = "ZONA"
    '        pbxBase.Visible = True
    '        If cls.Zona.id = 0 Then btnVerZona_Click(Nothing, Nothing)
    '    Else
    '        tipoAsignacion = "FRECUENCIA"
    '        pbxBase.Visible = False
    '    End If
    '    BuscarMoviles()
    'End Sub
#End Region


#Region "Mensajero"
    Private Sub MandarMensaje(ByVal numero As String, ByVal mensaje As String)
        ' Dim texto As String = "Argentina - Personal;379;4396187;1;Este es un mensaje de prueba"
        If numero > 7 Then
            Dim tel = numero.Substring(numero.Length - 7, 7)
            Dim cod_area = numero.Substring(0, numero.Length - 7)

            Dim texto As String = "Argentina - Personal;"
            texto &= cod_area & ";"
            texto &= tel & ";1;"
            texto &= mensaje

            Dim cadena As String = "C:\Program Files (x86)\TSM\Mensajes\tsmmensajes.exe /apipe:" & String.Format("""{0}""", texto)

            '  MsgBox(cadena)
            Shell(cadena, AppWinStyle.NormalFocus)
        End If

    End Sub
#End Region

   
    Private Sub dgvZ3_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ3.SelectionChanged
        If bgsZona3.Count > 0 Then
            cls.ChoferMovil = bgsZona3.Item(bgsZona3.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ4_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ4.SelectionChanged
        If bgsZona4.Count > 0 Then
            cls.ChoferMovil = bgsZona4.Item(bgsZona4.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ5_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ5.SelectionChanged
        If bgsZona5.Count > 0 Then
            cls.ChoferMovil = bgsZona5.Item(bgsZona5.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ6_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ6.SelectionChanged
        If bgsZona6.Count > 0 Then
            cls.ChoferMovil = bgsZona6.Item(bgsZona6.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ7_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ7.SelectionChanged
        If bgsZona7.Count > 0 Then
            cls.ChoferMovil = bgsZona7.Item(bgsZona7.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ8_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ8.SelectionChanged
        If bgsZona8.Count > 0 Then
            cls.ChoferMovil = bgsZona8.Item(bgsZona8.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ9_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ9.SelectionChanged
        If bgsZona9.Count > 0 Then
            cls.ChoferMovil = bgsZona9.Item(bgsZona9.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZ10_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZ10.SelectionChanged
        If bgsZona10.Count > 0 Then
            cls.ChoferMovil = bgsZona10.Item(bgsZona10.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZP_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZP.SelectionChanged
        If bgsZonaP.Count > 0 Then
            cls.ChoferMovil = bgsZonaP.Item(bgsZonaP.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub dgvZT_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvZT.SelectionChanged
        If bgsZonaT.Count > 0 Then
            cls.ChoferMovil = bgsZonaT.Item(bgsZonaT.Position)
            DatosMovil()
        End If
    End Sub

    Private Sub txtBuscador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscador.KeyPress
        Dim val As Integer
        If e.KeyChar = Chr(Keys.Enter) Then
            If Int32.TryParse(txtBuscador.Text, val) Then

                If Buscador(txtBuscador.Text, colMovNro.Name, dgvMoviles) Then
                    cls.BuscarMovil(txtBuscador.Text)
                    bgsMoviles.DataSource = cls.lstChoferMovil
                    bgsMoviles.ResetCurrentItem()
                    PintarMoviles()
                    If cls.Pedido.id <> 0 Then
                        If asignar Then 'sólo permito si está en modo Asignar
                            ' If tipoAsignacion = "FRECUENCIA" OrElse (e.RowIndex = 0 AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
                            If (tipoAsignacion = "FRECUENCIA" AndAlso cls.ChoferMovil.Movil.en_zona = "1900-01-01 00:00:00") OrElse (tipoAsignacion = "ZONA" AndAlso cls.ChoferMovil.Movil.frecuencia_id = cls.Operador.frecuencia_id) Then
                                With cls.ChoferMovil
                                    Dim frm As New FrmConfirmacion("¿Asignar el móvil " & .v_nroMovil & "?", Nothing)
                                    ' frm.Focus() 'no toma el enter en el frmConfirmacion, ni con focus ni select. Ya tiene la prop KeyPreview
                                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                        Dim cambioMovil As Boolean = cls.Pedido.movil_id > 0  'Estoy cambiando el móvil de un pedido A Completar..
                                        cls.Pedido.movil_id = .movil_id
                                        cls.Pedido.chofer_id = .chofer_id
                                        cls.Pedido.asignado = cls.FechaHora
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
                                            '.v_ultimoPedido = cls.FechaHora **
                                            '.v_cantPedidos += 1 **
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
                                            BuscarMoviles()
                                            CargarSubBases()
                                            PintarPedidos()
                                            dgvPedidos_Enter(Nothing, Nothing)
                                            txtBuscador.Text = ""
                                            txtBuscador.Visible = False
                                        End If
                                    End If
                                End With
                            End If
                        End If
                    End If
                End If

            End If
        End If
    End Sub
    Function Buscador(ByVal TextoABuscar As String, ByVal Columna As String, ByRef grid As DataGridView) As Boolean
        Dim encontrado As Boolean = False
        If TextoABuscar = String.Empty Then Return False
        If grid.RowCount = 0 Then Return False
        grid.ClearSelection()
        If Columna = String.Empty Then
            For Each row As DataGridViewRow In grid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value.ToString() = TextoABuscar Then
                        row.Selected = True
                        Return True
                    End If
                Next
            Next
        Else
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Return False
                If row.Cells(Columna).Value.ToString() = TextoABuscar Then
                    row.Selected = True
                    Return True
                End If
            Next
        End If
        Return encontrado
    End Function

End Class