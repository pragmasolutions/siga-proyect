Public Class FrmMensajero
    Dim cls As New ClsAdministrarPedidos
#Region "ACompletar"
    Private Sub BuscarACompletar()
        cls.CargarPedidosACompletar()
        bgsACompletar.DataSource = cls.lstPedidoACompletar
        PintarACompletar()
    End Sub
    Private Sub PintarACompletar()
        For Each r In dgvACompletar.Rows
            With CType(r.DataBoundItem, pedido)
                r.Cells(colACompMovil.Name).ToolTipText = "Cambiar móvil"
                If .lst_Reclamo.Count > 0 Then
                    r.Cells(colACompReclamo.Name).Value = My.Resources.reclamo
                    r.Cells(colACompReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
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
    Private Sub DatosACompletar()
        txtDetalle.Text = ""
        ' gbxDetalle.Text = "PEDIDO A COMPLETAR"
        If dgvACompletar.CurrentRow IsNot Nothing Then
            txtDetalle.Font = New System.Drawing.Font("Verdana", 10, FontStyle.Regular)
            txtDetalle.ForeColor = Color.White
            With cls.PedidoACompletar
                txtDetalle.Text = "Domicilio: " & .v_domicilio
                txtDetalle.Text &= " Cliente: " & .cliente
                txtDetalle.Text &= vbNewLine & "Pedido: " & .v_hora
                txtDetalle.Text &= " Viaje: " & .v_hora_viaje
                If .observacion.Length > 0 Then txtDetalle.Text &= " Observaciones: " & .observacion
                txtDetalle.Text &= " Asignado: " & .v_hora_asignado
                txtDetalle.Text &= " Móvil: " & .v_nroMovil
                txtDetalle.Text &= " Chofer: " & .v_choferAyN
                Detalle("Domicilio:")
                Detalle(.v_domicilio, True)
                Detalle("Cliente:")
                Detalle(.cliente, True)
                Detalle("Pedido:")
                Detalle("Viaje:")
                Detalle("Observaciones:")
                Detalle("Asignado:")
                Detalle("Móvil:")
                Detalle("Chofer:")
            End With
        End If
    End Sub
    Dim indiceACompletar As Integer = -1
    Private Sub dgvACompletar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvACompletar.CellClick
        If e.ColumnIndex = colACompCompletar.Index Then
            If cls.PedidoACompletar.Movil.telefono <> "" Then
                With cls.PedidoACompletar
                    Dim frm As New FrmOkCancel("¿Completar el pedido del móvil mediante SMS " & .ChoferMovil.v_nroMovil & "?", System.Windows.Forms.Control.MousePosition)
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
        End If
    End Sub

#End Region

    Private Sub Detalle(ByVal palabra As String, Optional ByVal pintar As Boolean = False)
        txtDetalle.Find(palabra, RichTextBoxFinds.MatchCase)
        txtDetalle.SelectionFont = New System.Drawing.Font("Verdana", 11, FontStyle.Bold)
        If pintar Then txtDetalle.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub

    Private Sub FrmMensajero_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvACompletar.AutoGenerateColumns = False
        dgvACompletar.DataSource = bgsACompletar
        BuscarACompletar()
    End Sub

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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BuscarACompletar()
    End Sub
End Class