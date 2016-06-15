Public Class FrmBuscadorPedidos
    Dim cls As New ClsAdministrarPedidos
    Dim clsCliente As New ClsClientes
    Dim bgsPedidos As New BindingSource
    Dim desde As String = "1900-01-01 00:00:00"
    Dim hasta As String = "1900-01-01 00:00:00"
    Dim pedcat As Integer = 2
    Private Sub FrmBuscadorPedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        dgvBuscadorPedidos.AutoGenerateColumns = False
        dgvBuscadorPedidos.DataSource = bgsPedidos

        desde = Format(Date.Now.AddHours(-1), "yyyy/MM/dd HH:mm:ss")
        hasta = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        cls.CargarPedidosBuscador(desde, hasta, pedcat)
        bgsPedidos.DataSource = cls.lstPedido

        cls.FillListPedidoCat()
        With cbCategoriaPedido
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
        cbCategoriaPedido.DataSource = cls.LstPedidoCategoria
        cbCategoriaPedido.SelectedValue = 2


    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        dgvBuscadorPedidos.DataSource = Nothing
        desde = Format(dtpDesde.Value, "yyyy/MM/dd HH:mm:ss")
        hasta = Format(dtpHasta.Value, "yyyy/MM/dd HH:mm:ss")
        pedcat = cbCategoriaPedido.SelectedValue

        cls.CargarPedidosBuscador(desde, hasta, pedCat)
        bgsPedidos.DataSource = cls.lstPedido
        dgvBuscadorPedidos.DataSource = bgsPedidos

    End Sub

    'Private Sub ReclamoPorTardanzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReclamoPorTardanzaToolStripMenuItem.Click
    '    Try
    '        clsCliente.Pedido = CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido)
    '        If clsCliente.Reclamo.id <> 0 Then
    '            Dim mensaje As String
    '            mensaje = "¿Desea agregar nuevo reclamo?"
    '            Dim Frm As New FrmOkCancel(mensaje, Nothing)
    '            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                GuardarReclamo()
    '            End If
    '        Else
    '            GuardarReclamo()
    '        End If
    '        '  BuscarPedidos()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "23")
    '    End Try

    'End Sub
    'Public Sub GuardarReclamo()
    '    Try
    '        Dim mensaje As String
    '        mensaje = "¿Desea generar reclamo por tardanza?"

    '        clsCliente.FillByTelefono(clsCliente.Pedido.telefono_id)
    '        Dim Frm As New FrmOkCancel(mensaje, Nothing)
    '        Frm.BackColor = Color.Black
    '        Frm.ForeColor = Color.Wheat
    '        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            If Me.ValidateChildren Then
    '                With clsCliente.Reclamo
    '                    .fechahora = Now
    '                    .asunto = "Reclamo de nuevo tardanza"
    '                    .cliente_id = clsCliente.Telefono.entidad_id
    '                    .reclamo_categoria_id = 1
    '                    .pedido_id = CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido).id
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

    '            clsCliente.FillReclamobyPedido(CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido).id)
    '            GuardarLinea()

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "25")
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

    'Private Sub CancelarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarPedidoToolStripMenuItem.Click
    '    Try
    '        If dgvBuscadorPedidos.RowCount > 0 Then
    '            clsCliente.Pedido = CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido)
    '            If clsCliente.Pedido.cancelado <> "1900-01-01 00:00:00" Then
    '                Dim frm As New FrmMensajes("Pedido ya cancelado", Nothing)
    '                Frm.BackColor = Color.Black
    '                Frm.ForeColor = Color.Wheat
    '                frm.Show()
    '            Else
    '                Dim frm As New FrmOkCancel("¿Confirma cancelación de pedido?", Nothing)
    '                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                    clsCliente.Pedido.cancelado = DateAndTime.Now
    '                    clsCliente.ModificarPedido()
    '                    bgsPedidos.ResetBindings(False)
    '                End If
    '                ' BuscarPedidos()
    '            End If
    '        Else
    '            MsgBox("No existen pedidos")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "10")
    '    End Try

    'End Sub

    'Private Sub ReclamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReclamoToolStripMenuItem.Click
    '    Try
    '        clsCliente.Pedido = CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido)
    '        Dim frm As New FrmReclamos(clsCliente.Pedido.id)
    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            bgsPedidos.ResetBindings(False)
    '        End If
    '        '  BuscarPedidos()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "21")
    '    End Try

    'End Sub

    'Private Sub ModificarDiferidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDiferidoToolStripMenuItem.Click
    '    If CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido).fechahora_viaje <> CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido).fechahora Then
    '        pnlDiferido.Visible = True
    '        fechaDiferido = dtpDiferido.Text & " " & dtpHora.Text

    '        dtpDiferido.Value = CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido).fechahora_viaje
    '        dtpHora.Value = CType(dgvBuscadorPedidos.CurrentRow.DataBoundItem, pedido).fechahora_viaje
    '    Else
    '        Dim frm As New FrmMensajes("No se puede modificar pedido porque no es diferido")
    '        frm.Show()
    '    End If
    'End Sub

End Class