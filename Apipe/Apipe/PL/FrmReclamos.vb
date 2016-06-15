Public Class FrmReclamos
    Dim pedido_id As Integer
    Dim cls As New ClsClientes
    Dim bgsReclamos As New BindingSource
#Region "Inicializar"
    Private Sub FrmReclamos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvReclamo.AutoGenerateColumns = False
        CargarCategorias()
        BuscarReclamo()
    End Sub
    Public Sub New(ByVal pedido As Integer)
        InitializeComponent()
        pedido_id = pedido
    End Sub
    Private Sub CargarCategorias()
        With cbxCategorias
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
        cls.FillListCategoriaReclamo()
        cbxCategorias.DataSource = cls.LstReclamoCat
    End Sub
#End Region

#Region "Cargar Reclamo"
    Public Sub BuscarReclamo()

        cls.FillReclamobyPedido(pedido_id)
        If cls.Reclamo.id = 0 Then
            ' Nuevoreclamo()
        Else
            CargarReclamo()
        End If
    End Sub

    Public Sub CargarReclamo()
        If cls.Reclamo.finalizo = #1/1/1900# Then
            lblEstado.Text = "Pendiente"
        Else
            lblEstado.Text = "Finalizado"
            cbFinalizar.Enabled = False
            pnlNuevo.Visible = False
        End If
        cbxCategorias.SelectedValue = cls.Reclamo.reclamo_categoria_id
        cbxCategorias.Enabled = False

        cls.FillListByReclamo(cls.Reclamo.id)
        bgsReclamos.DataSource = cls.LstReclamoLinea
        dgvReclamo.DataSource = bgsReclamos
    End Sub

#End Region

#Region "Guardar"

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If ControlErrorReclamos() = True Then
            If cls.Reclamo.id <> 0 Then
                Dim mensaje As String
                mensaje = "¿Desea agregar nuevo reclamo?"
                Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
                If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GuardarLinea()
                End If
            Else
                GuardarReclamo()
            End If
        End If
    End Sub

    Private Sub GuardarLinea()
        If Me.ValidateChildren Then
            With cls.ReclamoLinea
                .fechahora = Now
                .comentario = txtNuevo.Text
                .usuario_id = My.Settings.idUsuario
                .reclamo_id = cls.Reclamo.id
            End With
            cls.IniciarTrn()
            Try
                cls.PreservarReclamoLinea(cls.ReclamoLinea.reclamo_id, cls.ReclamoLinea.usuario_id, cls.ReclamoLinea.comentario, 0, 0)
                cls.gettrn.Commit()
            Catch ex As Exception
                cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If

            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
    End Sub

    Private Sub GuardarReclamo()
        Dim mensaje As String
        mensaje = "¿Desea agregar nuevo reclamo?"

        cls.FillPedidoByPedido(pedido_id)
        cls.FillByTelefono(cls.Pedido.telefono_id)
        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Me.ValidateChildren Then
                With cls.Reclamo
                    .fechahora = Now
                    .asunto = cbxCategorias.Text
                    .cliente_id = cls.Telefono.entidad_id
                    .reclamo_categoria_id = cbxCategorias.SelectedValue
                    .pedido_id = pedido_id
                End With
                cls.IniciarTrn()

                Try
                    cls.PreservarReclamo(cls.Reclamo.cliente_id, cls.Reclamo.pedido_id, cls.Reclamo.asunto, cls.Reclamo.reclamo_categoria_id)
                    cls.gettrn.Commit()
                Catch ex As Exception
                    cls.gettrn.Rollback()
                    MessageBox.Show(ex.Message)
                End Try
            End If

            cls.FillReclamobyPedido(pedido_id)
            GuardarLinea()

        End If
    End Sub

    Private Sub cbFinalizar_Click(sender As Object, e As System.EventArgs) Handles cbFinalizar.Click
        cbFinalizar.Checked = True
        Dim mensaje As String
        mensaje = "¿Desea finalizar el seguimiento de este reclamo?"
        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtNuevo.Text = "Reclamo Finalizado"
            cls.Reclamo.finalizo = Now
            cls.IniciarTrn()

            Try
                cls.FinalizarReclamo()
                cls.gettrn.Commit()
            Catch ex As Exception
                cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "Control de Errores"
    Private Sub txtAsunto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txtAsunto.Text = "" Then
        '    ErrReclamos.SetError(txtAsunto, "Ingrese asunto")
        'Else
        '    ErrReclamos.SetError(txtAsunto, Nothing)
        'End If
    End Sub

    Private Sub txtnuevo_lostfocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNuevo.LostFocus
        'If txtAsunto.Text = "" Then
        '    ErrReclamos.SetError(txtNuevo, "Ingrese asunto")
        'Else
        '    ErrReclamos.SetError(txtNuevo, Nothing)
        'End If
    End Sub

    Private Function ControlErrorReclamos() As Boolean
        ControlErrorReclamos = False
        If txtNuevo.Text = "" Then
            ErrReclamos.SetError(txtNuevo, "Ingrese reclamo")
            ControlErrorReclamos = False
        Else
            'ErrReclamos.SetError(txtAsunto, Nothing)
        ErrReclamos.SetError(txtNuevo, Nothing)
        ControlErrorReclamos = True
        End If
        Return ControlErrorReclamos
    End Function
#End Region

    Private Sub btnCancela_Click(sender As System.Object, e As System.EventArgs) Handles btnCancela.Click
        Dim mensaje As String
        mensaje = "¿Desea cancelar?"

        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    'Private Sub cbxCategorias_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxCategorias.SelectedIndexChanged
    '    txtAsunto.Text = cbxCategorias.Text

    'End Sub
End Class