Public Class FormPanelContTelefonistas

    Dim bgsPendientes, bgsAcompletar, bgsCompletados As New BindingSource
    Dim cls As New ClsAdministrarPedidos
    Dim clsCliente As New ClsClientes
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Try
            'My.Settings.DbDomain = "192.168.1.1"
            ClsVariableSesion.DbDomain = "192.168.1.1"
            ClsVariableSesion.Db = "apipe"
            ClsVariableSesion.DbUser = "apipe"
            ClsVariableSesion.DbPass = "apipe"
            ClsVariableSesion.Instancia.getConn.Open()
        Catch ex As Exception
            'If MessageBox.Show("No se pudo conectar a la base de datos, ¿desea configurar nuevamente?", "Conexion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            '    If FrmConfiguracion.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            '        End
            '    End If
            'Else
            '    End
            'End If
        End Try

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub PantallaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPedidos.AutoGenerateColumns = False
        dgvACompletar.AutoGenerateColumns = False
        dgvCompletados.AutoGenerateColumns = False

        dgvPedidos.DataSource = bgsPendientes
        dgvACompletar.DataSource = bgsAcompletar
        dgvCompletados.DataSource = bgsCompletados

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cls.CargarPedidos()
        cls.CargarPedidosACompletarTodos()
        cls.CargarPedidosCompletadosUltimos()

        bgsPendientes.DataSource = cls.lstPedido
        bgsAcompletar.DataSource = cls.lstPedidoACompletar
        bgsCompletados.DataSource = cls.lstPedidoCompletado

        PintarPedidos()
        PintarACompletar()
        

    End Sub

    Public Sub PintarPedidos()
        Try
            For Each r As DataGridViewRow In dgvPedidos.Rows
                With CType(r.DataBoundItem, pedido)
                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colPedReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colPedReclamo.Name).ToolTipText = .v_reclamos
                        If .lst_Reclamo.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                        ElseIf .lst_Reclamo.Count = 2 Then
                            'ElseIf .lst_Reclamo.First.lst_ReclamoLinea.Count = 2 Then
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
                    If .pedido_categoria_id = 3 Then 'Pedido diferido

                        r.Cells(0).Style.BackColor = Color.Maroon
                        r.Cells(1).Style.BackColor = Color.Maroon
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Maroon
                        r.Cells(4).Style.BackColor = Color.Maroon
                        r.Cells(5).Style.BackColor = Color.Maroon
                    ElseIf .pedido_categoria_id = 5 Then 'ART
                        r.Cells(0).Style.BackColor = Color.Purple
                        r.Cells(1).Style.BackColor = Color.Purple
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Purple
                        r.Cells(4).Style.BackColor = Color.Purple
                        r.Cells(5).Style.BackColor = Color.Purple
                    ElseIf .pedido_categoria_id = 6 Then 'IVR
                        r.Cells(0).Style.BackColor = Color.Pink
                        r.Cells(1).Style.BackColor = Color.Pink
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Pink
                        r.Cells(3).Style.ForeColor = Color.Black
                        r.Cells(4).Style.BackColor = Color.Pink
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Pink
                        r.Cells(5).Style.ForeColor = Color.Black
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "5")
        End Try
    End Sub

    Public Sub PintarACompletar()

        Try
            For Each r In dgvACompletar.Rows
                With CType(r.DataBoundItem, pedido)
                    If .pedido_categoria_id = 3 Then 'diferido

                        r.Cells(0).Style.BackColor = Color.Maroon
                        r.Cells(1).Style.BackColor = Color.Maroon
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Maroon
                        r.Cells(4).Style.BackColor = Color.Maroon
                        r.Cells(5).Style.BackColor = Color.Maroon

                    ElseIf .pedido_categoria_id = 5 Then 'art
                        r.Cells(0).Style.BackColor = Color.Purple
                        r.Cells(1).Style.BackColor = Color.Purple
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Purple
                        r.Cells(4).Style.BackColor = Color.Purple
                        r.Cells(5).Style.BackColor = Color.Purple

                    ElseIf .pedido_categoria_id = 6 Then 'ivr
                        r.Cells(0).Style.BackColor = Color.Pink
                        r.Cells(1).Style.BackColor = Color.Pink
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Pink
                        r.Cells(3).Style.ForeColor = Color.Black
                        r.Cells(4).Style.BackColor = Color.Pink
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Pink
                        r.Cells(5).Style.ForeColor = Color.Black
                    End If
                    If .cancelado <> "1900-01-01 00:00:00" Then
                        r.Cells(0).Style.BackColor = Color.Blue
                        r.Cells(1).Style.BackColor = Color.Blue
                        r.Cells(2).Style.BackColor = Color.Blue
                        r.Cells(3).Style.BackColor = Color.Blue
                        r.Cells(4).Style.BackColor = Color.Blue
                        r.Cells(5).Style.BackColor = Color.Blue
                    End If
                    If .lst_Reclamo.Count > 0 Then

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
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "17")
        End Try
    End Sub

    Public Sub PintarCompletados()

        Try

            For Each r In dgvCompletados.Rows
                With CType(r.DataBoundItem, pedido)
                    If .cancelado <> "1900-01-01 00:00:00" Then
                        r.Cells(0).Style.BackColor = Color.Blue
                        r.Cells(1).Style.BackColor = Color.Blue
                        r.Cells(2).Style.BackColor = Color.Blue
                        r.Cells(3).Style.BackColor = Color.Blue
                        r.Cells(4).Style.BackColor = Color.Blue
                        r.Cells(5).Style.BackColor = Color.Blue
                    End If
                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colComReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colComReclamo.Name).ToolTipText = .v_reclamos '
                        'If .lst_Reclamo.First.lst_ReclamoLinea.Count = 1 Then
                        If .lst_Reclamo.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                            'ElseIf .lst_Reclamo.First.lst_ReclamoLinea.Count = 2 Then
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

                    If .pedido_categoria_id = 3 Then 'diferido

                        r.Cells(0).Style.BackColor = Color.Maroon
                        r.Cells(1).Style.BackColor = Color.Maroon
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Maroon
                        r.Cells(4).Style.BackColor = Color.Maroon
                        r.Cells(5).Style.BackColor = Color.Maroon

                    ElseIf .pedido_categoria_id = 5 Then 'art
                        r.Cells(0).Style.BackColor = Color.Purple
                        r.Cells(1).Style.BackColor = Color.Purple
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Purple
                        r.Cells(4).Style.BackColor = Color.Purple
                        r.Cells(5).Style.BackColor = Color.Purple

                    ElseIf .pedido_categoria_id = 6 Then 'ivr
                        r.Cells(0).Style.BackColor = Color.Pink
                        r.Cells(1).Style.BackColor = Color.Pink
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Pink
                        r.Cells(3).Style.ForeColor = Color.Black
                        r.Cells(4).Style.BackColor = Color.Pink
                        r.Cells(4).Style.ForeColor = Color.Black
                        r.Cells(5).Style.BackColor = Color.Pink
                        r.Cells(5).Style.ForeColor = Color.Black
                    End If
                End With

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "24")
        End Try
    End Sub

    'Private Sub ReclamoPorTardanzaToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Try
    '        clsCliente.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
    '        If clsCliente.Reclamo.id <> 0 Then
    '            Dim mensaje As String
    '            mensaje = "¿Desea agregar nuevo reclamo?"
    '            Dim Frm As New FrmOkCancel(mensaje, Nothing)
    '            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                GuardarLinea()
    '            End If
    '        Else
    '            GuardarReclamo()
    '        End If
    '        ' BuscarPedidos()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "23")
    '    End Try
    'End Sub

    'Private Sub GuardarLinea()
    '    Try
    '        If Me.ValidateChildren Then
    '            With clsCliente.ReclamoLinea
    '                .fechahora = Now
    '                .comentario = "Reclamo por tardanza de movil"
    '                .usuario_id = My.Settings.idUsuario
    '                .reclamo_id = clsCliente.Reclamo.id
    '            End With
    '            clsCliente.IniciarTrn()
    '            Try
    '                clsCliente.PreservarReclamoLinea()
    '                clsCliente.gettrn.Commit()
    '            Catch ex As Exception
    '                clsCliente.gettrn.Rollback()
    '                MessageBox.Show(ex.Message)
    '            End Try
    '        End If

    '        DialogResult = Windows.Forms.DialogResult.OK
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "24")
    '    End Try

    'End Sub

    'Public Sub GuardarReclamo()
    '    Try
    '        Dim mensaje As String
    '        mensaje = "¿Desea generar reclamo por tardanza?"

    '        clsCliente.FillByTelefono(clsCliente.Pedido.telefono_id)
    '        Dim Frm As New FrmOkCancel(mensaje, Nothing)
    '        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            If Me.ValidateChildren Then
    '                With clsCliente.Reclamo
    '                    .fechahora = Now
    '                    .asunto = "Reclamo de nuevo tardanza"
    '                    .cliente_id = clsCliente.Telefono.entidad_id
    '                    .reclamo_categoria_id = 1
    '                    .pedido_id = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id
    '                End With
    '                clsCliente.IniciarTrn()

    '                Try
    '                    clsCliente.PreservarReclamo()
    '                    clsCliente.gettrn.Commit()
    '                Catch ex As Exception
    '                    clsCliente.gettrn.Rollback()
    '                    MessageBox.Show(ex.Message)
    '                End Try
    '            End If

    '            clsCliente.FillReclamobyPedido(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
    '            GuardarLinea()

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "25")
    '    End Try

    'End Sub

End Class
