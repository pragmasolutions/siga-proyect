Public Class Prueba
    Dim cls As New ClsAdministrarPedidos
    Dim bgsPedidos, bgsMoviles, bgsACompletar As New BindingSource

#Region "Inicializar"
    Private Sub Prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvPedidos.AutoGenerateColumns = False
        dgvMoviles.AutoGenerateColumns = False
        dgvACompletar.AutoGenerateColumns = False
        dgvPedidos.DataSource = bgsPedidos
        dgvMoviles.DataSource = bgsMoviles
        dgvACompletar.DataSource = bgsACompletar
        BuscarPedidos()
        BuscarMoviles()
        BuscarACompletar()
        Habilitar("P")
        spcCol2y3.SplitterDistance = 600
    End Sub
#End Region
#Region "Pedidos"
    Private Sub BuscarPedidos()
        cls.CargarPedidos()
        bgsPedidos.DataSource = cls.lstPedido
        PintarPedidos()
    End Sub
    Private Sub PintarPedidos()
        For Each r As DataGridViewRow In dgvPedidos.Rows
            With CType(r.DataBoundItem, pedido)
                If .operador_id > 0 Then 'pedido bloqueado por otro usuario
                    r.DefaultCellStyle.ForeColor = Color.Gray
                    r.DefaultCellStyle.SelectionForeColor = Color.Gray
                Else
                    r.DefaultCellStyle.ForeColor = Color.White
                    r.DefaultCellStyle.SelectionForeColor = Color.Tomato
                End If
                If .lst_Reclamo.Count > 0 Then
                    r.DefaultCellStyle.BackColor = Color.DarkCyan
                    r.DefaultCellStyle.SelectionBackColor = Color.Cyan
                Else
                    r.DefaultCellStyle.BackColor = ColorTranslator.FromOle(RGB(48, 48, 48))
                    r.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromOle(RGB(4, 64, 64))
                End If
            End With
        Next
    End Sub
    Private Sub PintarPedidoActual()
        With dgvPedidos.CurrentRow
            If cls.Pedido.operador_id > 0 Then 'pedido bloqueado por otro usuario
                .DefaultCellStyle.ForeColor = Color.Gray
                .DefaultCellStyle.SelectionForeColor = Color.Gray
            Else
                .DefaultCellStyle.ForeColor = Color.White
                .DefaultCellStyle.SelectionForeColor = Color.Tomato
            End If
            If cls.Pedido.lst_Reclamo.Count > 0 Then
                .DefaultCellStyle.BackColor = Color.DarkCyan
                .DefaultCellStyle.SelectionBackColor = Color.Cyan
            Else
                .DefaultCellStyle.BackColor = ColorTranslator.FromOle(RGB(48, 48, 48))
                .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromOle(RGB(4, 64, 64))
            End If
        End With
    End Sub
    Private Sub DatosPedido()
        With cls.Pedido
            txtDirTel.Text = .v_domicilio & vbNewLine & .TelefonoDomicilio.Telefono.numero
            txtPedido.Text = .Pedido_categoria.nombre & vbNewLine & "Viaje: " & .v_hora_viaje & " | Pedido: " & .v_hora
            txtObservPedido.Text = IIf(.observacion.Length > 0, "----" & vbNewLine & .observacion, "")
        End With
    End Sub
    Private Sub dgvPedidos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPedidos.SelectionChanged
        cls.Pedido = bgsPedidos.Item(bgsPedidos.Position)
        DatosPedido()
    End Sub
    Private Sub dgvPedidos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        If e.ColumnIndex = colPedAsignar.Index And cls.Pedido.operador_id = 0 Then
            cls.Pedido.operador_id = ClsVariableSesion.Instancia.Usuario.entidad_id
            'PERSISTIR!
            'PUSH!
            PintarPedidoActual()
            Habilitar("M")
        End If
    End Sub
#End Region
#Region "Moviles"
    Private Sub BuscarMoviles()
        cls.CargarMoviles()
        bgsMoviles.DataSource = cls.lstChoferMovil
    End Sub
    Private Sub DatosMovil()
        With cls.ChoferMovil
            txtChoferMovil.Text = .v_chofer_AyN & vbNewLine & .Movil.marca & " " & .Movil.modelo & " " & .Movil.color & " " & .Movil.chapa
            chkAire.Checked = .Movil.aire
            lblBaul.Text = .Movil.baul
            txtObservMovil.Text = IIf(.observacion.Length > 0, "----" & vbNewLine & .observacion & vbNewLine, "")
            txtObservMovil.Text &= IIf(.Movil.observacion.Length > 0, "----" & vbNewLine & .Movil.observacion, "")
        End With
    End Sub
    Private Sub dgvMoviles_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMoviles.SelectionChanged
        cls.ChoferMovil = bgsMoviles.Item(bgsMoviles.Position)
        DatosMovil()
    End Sub
    Private Sub dgvMoviles_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMoviles.CellClick
        If e.ColumnIndex = colMovAsignar.Index Then
            With cls.ChoferMovil
                cls.Pedido.movil_id = .movil_id
                cls.Pedido.chofer_id = .chofer_id
                cls.Pedido.asignado = cls.FechaHora
                'PERSISTIR!
            End With
            'PUSH!
            cls.lstPedido.Remove(cls.Pedido)
            cls.lstPedidoACompletar.Add(cls.Pedido)
            'capaz puedo setear chofermovil.v_ultimopedido, pero sacarle el readonly
            'actualizar lista de móviles para que se ponga último este móvil.... 
            bgsPedidos.ResetBindings(False)
            bgsMoviles.ResetBindings(False)
            bgsACompletar.ResetBindings(False)
            Habilitar("P")
            PintarPedidos()
        End If
    End Sub
    Private Sub lklCancelarAsignacion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklCancelarAsignacion.LinkClicked
        cls.Pedido.operador_id = Nothing
        'PUSH!
        Habilitar("P")
    End Sub
#End Region
#Region "ACompletar"
    Private Sub BuscarACompletar()
        cls.CargarPedidosACompletar()
        bgsACompletar.DataSource = cls.lstPedidoACompletar
    End Sub
    Private Sub dgvACompletar_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvACompletar.SelectionChanged
        cls.PedidoACompletar = bgsACompletar.Item(bgsACompletar.Position)
    End Sub
    Private Sub dgvACompletar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvACompletar.CellClick
        If e.ColumnIndex = colACompCompletar.Index Then
            With cls.PedidoACompletar
                .completado = cls.FechaHora
                'PERSISTIR!
            End With
            cls.lstPedidoACompletar.Remove(cls.PedidoACompletar)
            bgsACompletar.ResetBindings(False)
        End If
    End Sub
#End Region
#Region "Procedimientos y Funciones"
    ''' <summary>
    ''' Habilita la sección indicada e inhabilita la otra.
    ''' </summary>
    ''' <param name="s">Sección a habilitar: P=Pedido, M=Móvil</param>
    Private Sub Habilitar(ByVal s As Char)
        If s = "P" Then
            'gbxMovil.Enabled = False
            dgvMoviles.Enabled = False
            spcCol2y3.SplitterDistance += 200
            dgvPedidos.BorderStyle = BorderStyle.Fixed3D 'algo de la grilla para que se note
            dgvMoviles.BorderStyle = BorderStyle.None
            dgvPedidos.CurrentCell = Nothing
            'gbxPedido.Enabled = True
            dgvPedidos.Enabled = True
        Else
            'gbxPedido.Enabled = False
            dgvPedidos.Enabled = False
            spcCol2y3.SplitterDistance -= 200
            dgvPedidos.BorderStyle = BorderStyle.None 'algo de la grilla para que se note
            dgvMoviles.BorderStyle = BorderStyle.Fixed3D
            'gbxMovil.Enabled = True
            dgvMoviles.Enabled = True
        End If
    End Sub
    Private Sub PedidoCambiado(ByVal pedido As pedido) 'MANEJA CUANDO ALGUIEN ME HACE UN PUSH AL CAMBIAR UN PEDIDO
        Dim p = cls.lstPedido.Find(Function(x) x.id = pedido.id)
        If p Is Nothing Then
            cls.lstPedido.Add(pedido)
        Else
            p = pedido.Clone
        End If
        bgsPedidos.ResetBindings(False)
        PintarPedidos()
    End Sub
#End Region

    'Cosas extras sólo para prueba.. 
    Dim nro As Integer = 999
    Private Sub btnEntraPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntraPedido.Click
        Dim p As New pedido
        With p
            nro += 1
            .id = nro
            .cliente = 1
            .fechahora = Now
            .fechahora_viaje = Now
            .usuario_id = 1
            .pedido_categoria_id = 1
            .domicilio_id = 1
            .telefono_id = 1
        End With
        PedidoCambiado(p)
    End Sub
    Private Sub btnBloqueaPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloqueaPedido.Click
        Dim p = cls.lstPedido(CInt(cls.lstPedido.Count / 2))
        If p IsNot Nothing Then
            With p
                If p.operador_id > 0 Then
                    .operador_id = Nothing
                Else
                    .operador_id = 1
                End If
            End With
            PedidoCambiado(p)
        End If
    End Sub
    
End Class