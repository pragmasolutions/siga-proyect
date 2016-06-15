Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports ALAZ.SystemEx.WindowsEx.FormEx
Imports ALAZ.SystemEx.RunTimeEx.InteropServicesEx
Imports ALAZ.TelephonyEx.Voip.IAX
'Imports SharpIAX
'caambio tonto
'otro cambioooo
Public Class FrmInfoCliente
    Dim clsCliente As New ClsClientes
    Dim bgsDomicilio As New BindingSource
    Dim bgsPedido As New BindingSource
    Dim bgsCliente As New BindingSource
    Public iaxc As IAXClientClass
    Dim numero As String
    Dim cod_area As Integer
    Dim fechaDiferido As String

#Region "Inicializar"

    Private Sub FrmInfoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VaciarEtiquetas()
        CargarCbxCategoriaPedido()
        DgvDomicilios.AutoGenerateColumns = False
        dgvPedidos.AutoGenerateColumns = False
        dgvPedidos.AutoGenerateColumns = False
        cmsPedidos.Enabled = False
        cmsDomicilios.Enabled = False

       timTime.Enabled = True

        '----- Create IAXClient object!
        Try
            iaxc = New IAXClientClass(AudioType.atAUDIO_INTERNAL_PA, 1)
            InitilizeIAX()
        Catch ex As Exception
        End Try

        '----- Verify properties!
        If Settings.[Default].ConfigStatus = -1 Then
            txtStatus.Text = "Configuración inválida"
            cmdConfig.Enabled = True
        Else
            '----- Initilize!

            InitializeVisual()
            InitilizeIAX()
        End If

        Refresh()

    End Sub
    Private Sub VaciarEtiquetas()
        DgvDomicilios.DataSource = ""
        dgvPedidos.DataSource = ""
        lblApellido.Text = ""
        lblNombre.Text = ""
        lblTipo.Text = ""
    End Sub
    Private Sub CargarCbxCategoriaPedido()
        Try
            With cbxCategoria
                .DisplayMember = "nombre"
                .ValueMember = "id"
                End With
            clsCliente.FillListPedidoCategoria()
            cbxCategoria.DataSource = clsCliente.LstPedidoCategoria
            cbxCategoria.SelectedIndex = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "01")
        End Try

    End Sub
#End Region

#Region "Cliente"
    Private Sub TxtTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTelefono.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                BuscarTelefono()
                '  GuardarLLamada()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "02")
        End Try
        
    End Sub

    Private Sub GuardarLLamada()
        clsCliente.Llamada = New llamada

        With clsCliente.Llamada
            .telefono_id = clsCliente.Telefono.id
            .usuario_id = ClsVariableSesion.Instancia.Usuario.id
            .fechaHora = Now
            .numero = TxtTelefono.Text
            clsCliente.IniciarTrn()
            Try
                clsCliente.GuardarLlamada(.usuario_id, .telefono_id, .numero)
                clsCliente.gettrn.Commit()
            Catch ex As Exception
                clsCliente.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try

        End With
    End Sub
    Private Sub BuscarTelefono()
        Try
            clsCliente = New ClsClientes
            VaciarEtiquetas()
            BuscarCliente()
            BuscarDomicilio()
            BuscarPedidos()
            GuardarLLamada()
            If DgvDomicilios.RowCount = 0 And clsCliente.Telefono.id <> 0 Then
                NuevoDomicilioToolStripMenuItem_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "03")
        End Try

    End Sub

    Public Sub BuscarCliente()
        Try
            Dim val As Int64 = 0
            If Int64.TryParse(TxtTelefono.Text, val) Then
                clsCliente = New ClsClientes
                If TxtTelefono.Text = 9999999 Then
                    numero = 9999999
                    cod_area = 0
                Else

                    If TxtTelefono.Text.Length > 7 Then
                        numero = TxtTelefono.Text.Substring(TxtTelefono.Text.Length - 7, 7)
                        cod_area = TxtTelefono.Text.Substring(0, TxtTelefono.Text.Length - 7)
                    Else
                        numero = TxtTelefono.Text
                        cod_area = 0
                    End If
                End If

                'Busqueda del registro telefono de acuerdo al nro ingresado
                clsCliente.FillTelefonoByNumeroYCarac(numero, cod_area)

                ''Si el cliente no existe, agrego cliente y domicilio
                If clsCliente.Telefono.id = 0 Then
                    ' Agrega Nueva Entidad, telefono, cliente
                    Dim Form As New FrmClienteDom(numero, cod_area)
                    If Form.ShowDialog = Windows.Forms.DialogResult.OK Then
                        clsCliente.FillTelefonoByNumeroYCarac(numero, cod_area)
                        bgsDomicilio.ResetBindings(False)
                        bgsCliente.ResetBindings(False)
                    End If
                End If

                ''''''''''''''''''
                clsCliente.FillEntidadByEntidad(clsCliente.Telefono.entidad_id)
                clsCliente.FillByCliente(clsCliente.Telefono.entidad_id)
                clsCliente.FillByCliente_Categoria(clsCliente.cliente.cliente_categoria_id)
                lblApellido.Text = clsCliente.cliente.v_Apellido
                lblNombre.Text = clsCliente.cliente.v_Nombre
                lblTipo.Text = clsCliente.cliente.v_Tipo
            End If
            DgvDomicilios.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "04")
        End Try
       
    End Sub

    Private Sub btnModCte_Click(sender As System.Object, e As System.EventArgs) Handles btnModCte.Click
        Try
            Dim Form As New FrmCliente(numero, cod_area)
            If Form.ShowDialog = Windows.Forms.DialogResult.OK Then
                clsCliente.FillTelefonoByNumeroYCarac(numero, cod_area)
                clsCliente.FillEntidadByEntidad(clsCliente.Telefono.entidad_id)
                BuscarCliente()
                bgsCliente.ResetBindings(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "05")
        End Try
       
    End Sub
#End Region

#Region "Pedidos"
    Private Sub BuscarPedidos()
        Try
            If clsCliente.Telefono.id <> 0 Then
                clsCliente.CargarPedidosxTelefono(clsCliente.Telefono.id)
                If clsCliente.LstPedido.Count > 0 Then
                    bgsPedido.DataSource = clsCliente.LstPedido
                    dgvPedidos.DataSource = bgsPedido
                    MarcarReclamos()
                    If dgvPedidos.RowCount > 0 Then
                        cmsPedidos.Enabled = True
                    Else
                        cmsPedidos.Enabled = False
                    End If
                End If
                
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "06")
        End Try
        
    End Sub

    Private Sub MarcarReclamos()
        Try
            For Each r As DataGridViewRow In dgvPedidos.Rows
                With CType(r.DataBoundItem, pedido)
                    If .lst_Reclamo.Count > 0 Then
                        r.Cells(colPedReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colPedReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
                    Else
                        r.Cells(colPedReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colPedReclamo.Name).ToolTipText = "Sin reclamo"
                    End If

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "07")
        End Try
        
    End Sub

    Private Sub DgvDomicilios_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDomicilios.CellContentClick
        Try
            If e.ColumnIndex = colBtn.Index Then
                GenerarPedido()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "08")
        End Try
       
    End Sub

    Private Sub btbPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbPedido.Click
        Try
            GenerarPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "09")
        End Try

    End Sub

    Private Sub CancelarPedidoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarPedidoToolStripMenuItem.Click
        Try
            If dgvPedidos.RowCount > 0 Then
                clsCliente.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
                If clsCliente.Pedido.cancelado <> "1900-01-01 00:00:00" Then
                    Dim frmm As New FrmMensajes("Pedido ya cancelado", Nothing)
                    frmm.Show()
                Else
                    Dim frm As New FrmOkCancel("¿Confirma cancelación de pedido?", Nothing)
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        clsCliente.Pedido.cancelado = DateAndTime.Now
                        'clsCliente.ModificarPedido()
                        clsCliente.CancelarPedido(clsCliente.Pedido.id, My.Settings.idUsuario)
                        bgsPedido.ResetBindings(False)
                    End If
                    BuscarPedidos()
                End If
            Else
                MsgBox("No existen pedidos")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "10")
        End Try
        

    End Sub

    Private Sub btnCancelarPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarPedido.Click
        Try
            pnlDiferido.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "11")
        End Try

    End Sub

    Private Sub GenerarPedido()
        Try
            Dim cls As New ClsClientes
            If DgvDomicilios.RowCount > 0 Then
                Dim mensaje As String
                mensaje = "¿Confirma la generación del pedido?"
                Dim Frm As New FrmOkCancel(mensaje, Nothing)
                If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Me.ValidateChildren Then
                        With cls.Pedido
                            .cliente = lblApellido.Text
                            .fechahora = DateAndTime.Now
                            If fechaDiferido = "" Then
                                .fechahora_viaje = DateAndTime.Now
                            Else
                                .fechahora_viaje = fechaDiferido
                                .observacion = "Pedido Diferido. "
                            End If

                            .usuario_id = My.Settings.idUsuario
                            .pedido_categoria_id = cbxCategoria.SelectedValue
                            .domicilio_id = CType(DgvDomicilios.CurrentRow.DataBoundItem, telefono_domicilio).domicilio_id
                            .telefono_id = clsCliente.Telefono.id
                            If cbxCategoria.SelectedValue = 2 Or cbxCategoria.SelectedValue = 3 Then
                                .observacion = .observacion & TxtObservacion.Text
                            Else
                                .observacion = .observacion & TxtObservacion.Text & cbxCategoria.Text
                            End If

                        End With
                        cls.IniciarTrn()
                        Try
                            'cls.PreservarPedidoNormal()
                            cls.GenerarPedido(cls.Pedido.cliente, cls.Pedido.fechahora_viaje, cls.Pedido.observacion, cls.Pedido.usuario_id, cls.Pedido.pedido_categoria_id, cls.Pedido.domicilio_id, cls.Pedido.telefono_id)
                            cls.gettrn.Commit()
                        Catch ex As Exception
                            cls.gettrn.Rollback()
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If
            End If
            fechaDiferido = ""
            TxtObservacion.Text = ""
            cbxCategoria.SelectedValue = 2
            bgsPedido.ResetBindings(False)
            BuscarPedidos()
            If TxtTelefono.Text = "9999999" Then
                EliminarDomicilio()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "12")
        End Try
       
    End Sub

    Private Sub ModificarPedido()
        Try
            Dim cls As New ClsClientes
            If DgvDomicilios.RowCount > 0 Then
                Dim mensaje As String
                mensaje = "¿Confirma la modificación del pedido?"
                Dim Frm As New FrmOkCancel(mensaje, Nothing)
                If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Me.ValidateChildren Then
                        cls.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
                        With cls.Pedido
                            .fechahora = DateAndTime.Now
                            If fechaDiferido = "" Then
                                .fechahora_viaje = DateAndTime.Now
                            Else
                                .fechahora_viaje = fechaDiferido
                            End If

                            .usuario_id = My.Settings.idUsuario
                            .pedido_categoria_id = cbxCategoria.SelectedValue
                        End With
                        cls.IniciarTrn()
                        Try
                            cls.ModificarPedido(cls.Pedido.fechahora_viaje, cls.Pedido.id, cls.Pedido.usuario_id)
                            cls.gettrn.Commit()
                        Catch ex As Exception
                            cls.gettrn.Rollback()
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If
            End If
            fechaDiferido = ""
            TxtObservacion.Text = ""
            bgsPedido.ResetBindings(False)
            BuscarPedidos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "13")
        End Try

       
    End Sub
#End Region

#Region "Domicilios"

    Public Sub BuscarDomicilio()
        Try
            If clsCliente.Telefono.id <> 0 Then

                clsCliente.FillDomiciliobyTelefonoBaja(clsCliente.Telefono.id)
                If clsCliente.LstDomicilioXTelefono.Count > 0 Then
                    bgsDomicilio.DataSource = clsCliente.LstDomicilioXTelefono
                    DgvDomicilios.DataSource = bgsDomicilio
                    HabilitarCmsDomicilio()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "14")
        End Try
    End Sub

    Private Sub HabilitarCmsDomicilio()
        Try
            If DgvDomicilios.RowCount > 0 Then
                cmsDomicilios.Enabled = True
                PedidoDiferidoToolStripMenuItem.Enabled = True
                btbPedido.Enabled = True
                btnModificarDom.Enabled = True
                NuevoDomicilioToolStripMenuItem.Enabled = True
                EliminarDomicilioToolStripMenuItem.Enabled = True
            Else
                cmsDomicilios.Enabled = True
                PedidoDiferidoToolStripMenuItem.Enabled = False
                btbPedido.Enabled = False
                btnModificarDom.Enabled = False
                EliminarDomicilioToolStripMenuItem.Enabled = False
                NuevoDomicilioToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "15")
        End Try
        
    End Sub

    Private Sub btnModificarDom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDom.Click
        Try
            If DgvDomicilios.SelectedRows.Count = 1 Then
                clsCliente.Telefono_Domicilio = CType(DgvDomicilios.CurrentRow.DataBoundItem, telefono_domicilio)
                Dim Frm As New FrmDomicilio(clsCliente.Telefono_Domicilio.Domicilio)

                If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    bgsDomicilio.ResetBindings(False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "16")
        End Try
       
    End Sub

    Private Sub NuevoDomicilioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoDomicilioToolStripMenuItem.Click
        Try
            Dim Frm As New FrmDomicilio(clsCliente.Telefono.id)
            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                bgsDomicilio.ResetBindings(False)
                BuscarDomicilio()
                HabilitarCmsDomicilio()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "17")
        End Try
        
    End Sub

    Private Sub EliminarDomicilioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDomicilioToolStripMenuItem.Click
        Try
            If DgvDomicilios.SelectedRows.Count = 1 Then
                Dim frm As New FrmOkCancel("¿Está seguro que desea eliminar el domicilio?", Nothing)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    EliminarDomicilio()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "18")
        End Try
       
    End Sub

    Private Sub EliminarDomicilio()
        Try
            clsCliente.Telefono_Domicilio = CType(DgvDomicilios.CurrentRow.DataBoundItem, telefono_domicilio)
            clsCliente.Telefono_Domicilio.baja = vbFalse

            clsCliente.IniciarTrn()

            Try
                clsCliente.ModificarTelefonoXDomicilio(clsCliente.Telefono_Domicilio.domicilio_id, clsCliente.Telefono_Domicilio.telefono_id,My.Settings.idUsuario)
                clsCliente.gettrn.Commit()
            Catch ex As Exception
                clsCliente.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
            BuscarDomicilio()
            bgsDomicilio.ResetBindings(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "19")
        End Try
        
    End Sub

    Private Sub DgvDomicilios_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DgvDomicilios.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GenerarPedido()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "20")
        End Try
        
    End Sub
    #End Region

#Region "Reclamos"
    Private Sub ReclamoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReclamoToolStripMenuItem.Click
        Try
            clsCliente.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
            Dim frm As New FrmReclamos(clsCliente.Pedido.id)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                bgsPedido.ResetBindings(False)
            End If
            BuscarPedidos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "21")
        End Try
        
    End Sub

    Private Sub btnReclamos_Click(sender As System.Object, e As System.EventArgs) Handles btnReclamos.Click
        Try
            Dim FormReclamo As New FrmReclamosCliente(clsCliente.cliente.entidad_id)
            FormReclamo.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "22")
        End Try
      
    End Sub
    Private Sub ReclamoPorTardanzaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReclamoPorTardanzaToolStripMenuItem.Click
        Try
            clsCliente.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
            If clsCliente.Reclamo.id <> 0 Then
                Dim mensaje As String
                mensaje = "¿Desea agregar nuevo reclamo?"
                Dim Frm As New FrmOkCancel(mensaje, Nothing)
                If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GuardarLinea()
                End If
            Else
                GuardarReclamo()
            End If
            BuscarPedidos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "23")
        End Try
        
    End Sub

    Private Sub GuardarLinea()
        Try
            If Me.ValidateChildren Then
                With clsCliente.ReclamoLinea
                    .fechahora = Now
                    .comentario = "Reclamo por tardanza de movil"
                    .usuario_id = My.Settings.idUsuario
                    .reclamo_id = clsCliente.Reclamo.id
                End With
                clsCliente.IniciarTrn()
                Try
                    clsCliente.PreservarReclamoLinea(clsCliente.ReclamoLinea.reclamo_id, clsCliente.ReclamoLinea.usuario_id, clsCliente.ReclamoLinea.comentario, clsCliente.Pedido.id, clsCliente.Pedido.movil_id)
                    clsCliente.gettrn.Commit()
                Catch ex As Exception
                    clsCliente.gettrn.Rollback()
                    MessageBox.Show(ex.Message)
                End Try
            End If

            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "24")
        End Try
       
    End Sub

    Public Sub GuardarReclamo()
        Try
            Dim mensaje As String
            mensaje = "¿Desea generar reclamo por tardanza?"

            clsCliente.FillByTelefono(clsCliente.Pedido.telefono_id)
            Dim Frm As New FrmOkCancel(mensaje, Nothing)
            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Me.ValidateChildren Then
                    With clsCliente.Reclamo
                        .fechahora = Now
                        .asunto = "Reclamo de nuevo tardanza"
                        .cliente_id = clsCliente.Telefono.entidad_id
                        .reclamo_categoria_id = 1
                        .pedido_id = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id
                    End With
                    clsCliente.IniciarTrn()

                    Try
                        clsCliente.PreservarReclamo(clsCliente.Reclamo.cliente_id, clsCliente.Reclamo.pedido_id, clsCliente.Reclamo.asunto, clsCliente.Reclamo.reclamo_categoria_id)
                        clsCliente.gettrn.Commit()
                    Catch ex As Exception
                        clsCliente.gettrn.Rollback()
                        MessageBox.Show(ex.Message)
                    End Try
                End If

                clsCliente.FillReclamobyPedido(CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).id)
                GuardarLinea()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "25")
        End Try

    End Sub
#End Region

#Region "Detalle Yugoo"
    Private Sub dgvPedidos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPedidos.SelectionChanged
        Try
            Dim indicePedido As Integer = -1
            If bgsPedido.Count > 0 Then
                If indicePedido > -1 Then bgsPedido.Position = indicePedido
                clsCliente.Pedido = bgsPedido.Item(bgsPedido.Position)
                DatosPedido()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "26")
        End Try
       
    End Sub

    Private Sub DatosPedido()
        Try
            Dim Reclamo As String = ""
            txtDetalle.Text = ""
            If dgvPedidos.CurrentRow IsNot Nothing Then
                txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
                txtDetalle.ForeColor = Color.White
                With clsCliente.Pedido
                    If .observacion.Length > 0 Then txtDetalle.Text = "Observaciones: " & .observacion & vbNewLine
                    txtDetalle.Text &= "Domicilio: " & .v_domicilio
                    If .v_descripcion.Length > 0 Then txtDetalle.Text &= " " & .v_descripcion
                    If .v_interseccion.Length > 0 Then txtDetalle.Text &= " " & .v_interseccion
                    If .v_observacion.Length > 0 Then txtDetalle.Text &= " " & .v_observacion
                    txtDetalle.Text &= " Cliente: " & .cliente
                    If .v_nroMovil.Length > 0 Then txtDetalle.Text &= vbNewLine & "Movil: " & .v_nroMovil
                    txtDetalle.Text &= " Viaje: " & .v_hora_viaje

                    If .lst_Reclamo.Count > 0 Then
                        For i As Integer = 0 To .lst_Reclamo.First.lst_ReclamoLinea.Count - 1
                            Reclamo = Reclamo & .lst_Reclamo.First.lst_ReclamoLinea.Item(i).comentario & "; "
                        Next
                        txtDetalle.Text &= vbNewLine & "Reclamo: " & Reclamo

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
                    Detalle("Hora:")
                    Detalle(.v_hora_viaje, True)
                    Detalle("Reclamo:")
                    If .lst_Reclamo.Count > 0 Then
                        Detalle(Reclamo, True)
                    End If

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "27")
        End Try
        
    End Sub

    Private Sub Detalle(ByVal palabra As String, Optional ByVal pintar As Boolean = False)
        Try
            txtDetalle.Find(palabra, RichTextBoxFinds.MatchCase)
            txtDetalle.SelectionFont = New System.Drawing.Font("Verdana", 11, FontStyle.Bold)
            If pintar Then txtDetalle.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "28")
        End Try
        
    End Sub

    Private Sub DgvDomicilios_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDomicilios.SelectionChanged
        Try
            Dim indiceDomicilio As Integer = -1
            If bgsDomicilio.Count > 0 Then
                If indiceDomicilio > -1 Then bgsDomicilio.Position = indiceDomicilio
                clsCliente.Telefono_Domicilio = bgsDomicilio.Item(bgsDomicilio.Position)
                DatosDomiclio()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "29")
        End Try
        
    End Sub

    Private Sub DatosDomiclio()
        Try
            txtDetalle.Text = ""
            If DgvDomicilios.CurrentRow IsNot Nothing Then
                txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
                txtDetalle.ForeColor = Color.White
                With clsCliente.Telefono_Domicilio
                    txtDetalle.Text = "Domicilio: " & .v_domicilio
                    If .v_descripcion.Length > 0 Then txtDetalle.Text &= .v_descripcion
                    If .v_interseccion.Length > 0 Then txtDetalle.Text &= vbNewLine & "Intersección" & .v_interseccion
                    txtDetalle.Text &= vbNewLine & "Tipo:" & .v_tipo
                    If .v_observacion.Length > 0 Then txtDetalle.Text &= " Observaciones: " & .v_observacion
                    Detalle("Domicilio:")
                    Detalle(.v_domicilio, True)
                    Detalle(.v_descripcion, True)
                    Detalle("Interseccion:")
                    Detalle(.v_interseccion, True)
                    Detalle("Tipo:")
                    Detalle(.v_tipo, True)
                    Detalle("Observaciones:")
                    Detalle(.v_observacion, True)
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "30")
        End Try
        
    End Sub
#End Region

#Region "Softphone"
    Public Sub New()
        Try
            InitializeComponent()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "31")
        End Try

    End Sub
#Region "Eventos"
    '----- Events
    Private Sub iaxc_OnAudioLevel(ByVal input As Integer, ByVal output As Integer)
        Try
            '----- Audio level event!
            progressLevelInput.Value = input
            progressLevelOutput.Value = output
        Catch ex As Exception
            MessageBox.Show(ex.Message, "32")
        End Try
       
    End Sub

    Private Sub iaxc_OnTextState(ByVal lineNumber As Integer, ByVal textType As TextType, ByVal text As String)
        Try
            '----- Text event!
            txtStatus.Text = text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "33")
        End Try
       
    End Sub

    Private Sub iaxc_OnLineState(ByVal lineNumber As Integer)
        Try
            '----- Line state event!

            '----- Adjust select line button!
            If lineNumber = 0 Then

                Select Case iaxc.Lines.SelectedLine

                    Case 0
                        If True Then
                            cmdLine1.ForeColor = Color.Orange
                            cmdLine2.ForeColor = Color.Black
                            Exit Select
                        End If

                    Case 1
                        If True Then
                            cmdLine1.ForeColor = Color.Orange
                            cmdLine2.ForeColor = Color.Black
                            Exit Select
                        End If

                End Select

                '----- Adjust line event components!
                Dim labelNumber As Label = Nothing
                Dim labelStatus As Label = Nothing
                Dim labelDirection As Label = Nothing
                Dim labelTime As Label = Nothing

                Select Case lineNumber
                    Case 0
                        If True Then
                            labelNumber = lblNumber1
                            labelStatus = lblStatus1
                            labelDirection = lblCallDirection1
                            labelTime = lblTime1
                            Exit Select
                        End If
                    Case 1
                        If True Then
                            labelNumber = lblNumber2
                            labelStatus = lblStatus2
                            labelDirection = lblCallDirection2
                            labelTime = lblTime2
                            Exit Select
                        End If
                End Select

                '----- Remote number!
                Dim remote As String = iaxc.Lines(lineNumber).Remote

                If remote = [String].Empty Then
                    labelNumber.Text = "0"
                Else
                    labelNumber.Text = remote
                End If

                '----- Call status!
                labelStatus.Text = iaxc.Lines(lineNumber).CallStatus.ToString().Substring(2)

                '     MsgBox(labelStatus.Text)
                If iaxc.Lines(lineNumber).Active Then
                    labelDirection.Text = "Llamada"
                   
                Else
                    '----- Call time!
                    labelTime.Text = "00:00"
                    labelDirection.Text = [String].Empty
                End If

                '----- Adjust buttons state!
                cmdCall.Enabled = iaxc.Lines(iaxc.Lines.SelectedLine).Active = False
                cmdHangup.Enabled = iaxc.Lines(iaxc.Lines.SelectedLine).Active = True
                cmdPickUp.Enabled = cmdHangup.Enabled AndAlso (iaxc.Lines(iaxc.Lines.SelectedLine).CallStatus = CallStatus.csRinging AndAlso iaxc.Lines(iaxc.Lines.SelectedLine).CallDirection = CallDirection.cdIncoming)
                cmdTransfer.Enabled = cmdHangup.Enabled AndAlso iaxc.Lines(iaxc.Lines.SelectedLine).CallStatus = CallStatus.csComplete


                If iaxc.Lines(lineNumber).CallStatus = CallStatus.csRinging Then
                    '----- Popup
                    Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "34")
        End Try
       
    End Sub

    Private Sub iaxc_OnRegistration()
        Try
            If iaxc.RegistrationRequired Then

                '----- If registration required check registration status!
                If iaxc.RegistrationStatus = RegistrationStatus.rsCompleted Then
                    txtStatus.Text = "Listo"
                    panCommands.Enabled = True
                    txtDial.Enabled = True
                Else
                    txtStatus.Text = "Error"
                    panCommands.Enabled = False
                    txtDial.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "35")
        End Try
       
    End Sub
#End Region


    Private Sub InitializeVisual()
    End Sub

    Private Sub InitilizeIAX()
        Try
            AddHandler iaxc.OnRegistration, New OnRegistrationDelegate(AddressOf iaxc_OnRegistration)
            AddHandler iaxc.OnAudioLevel, New OnAudioLevelDelegate(AddressOf iaxc_OnAudioLevel)
            AddHandler iaxc.OnLineState, New OnLineStateDelegate(AddressOf iaxc_OnLineState)
            AddHandler iaxc.OnTextState, New OnTextStateDelegate(AddressOf iaxc_OnTextState)

            '----- Initialize with 2 lines!
            'iaxc.CallerIdName = Settings.[Default].CallerIdName
            'iaxc.CallerIdNumber = Settings.[Default].CallerIdNumber
            'iaxc.Initialize(Settings.[Default].User, Encoding.[Default].GetString(Convert.FromBase64String(Settings.[Default].Password)), Settings.[Default].Host, Settings.[Default].Registration)

            clsCliente.FillTelefonistabyUsuario(My.Settings.idUsuario)
            '----- Initialize with 2 lines!

            iaxc.CallerIdName = clsCliente.telefonista.interno
            iaxc.CallerIdNumber = clsCliente.telefonista.interno
            Dim usuario As String = clsCliente.telefonista.interno
            Dim password As String = clsCliente.telefonista.password
            Dim server As String = clsCliente.telefonista.dominio

            iaxc.Initialize(usuario, password, server, True)
            ' iaxc.Initialize(Settings.[Default].User, Encoding.[Default].GetString(Convert.FromBase64String(Settings.[Default].Password)), Settings.[Default].Host, Settings.[Default].Registration)


            '----- Initialize formats!
            iaxc.PreferredFormat = AudioFormat.afIAXC_FORMAT_GSM
            iaxc.AllowedFormats = AudioFormat.afIAXC_FORMAT_GSM

            '----- Initialize audio devices!
            iaxc.AudioDevices.SelectInputAudioDevice(1)
            iaxc.AudioDevices.SelectOutPutAudioDevice(3)
            iaxc.AudioDevices.SelectOutPutAudioDevice(3)

            '----- Adjust user and registration message status!
            lblUser.Text = iaxc.User

            If iaxc.RegistrationRequired Then
                txtStatus.Text = "Iniciando..."
            Else
                txtStatus.Text = "Listo"
                panCommands.Enabled = True
                txtDial.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "36")
        End Try
      

    End Sub

    Private Sub cmdDropCall_Click(ByVal sender As Object, ByVal e As EventArgs)
        '----- Drop selected call!
        Try
            iaxc.Lines(0).DropCall()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "37")
        End Try


    End Sub

    Private Sub FrmInfoCliente_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '----- Shutdown IAXClient when closing!
        Try
            'iaxc.Lines(iaxc.Lines.SelectedLine).DropCall()
            'iaxc.Lines(0).DropCall()
            iaxc.ShutDown()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "38")
        End Try

        e.Cancel = False
        'Me.Close()
    End Sub

    Private Sub timTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timTime.Tick
        Try
            '-----Set datetime!
            lblTime.Text = DateTime.Now.ToShortTimeString()

            If iaxc IsNot Nothing AndAlso iaxc.Lines.Count > 0 Then

                For Each l As IAXLine In iaxc.Lines

                    If l.Active Then

                        '----- If Line is active, adjust the call time!
                        Dim secondsInt As Integer = l.CallTime \ 1000
                        Dim minutes As Integer = secondsInt \ 60
                        Dim seconds As Integer = secondsInt Mod 60
                        Dim time As String = minutes.ToString("00") & ":" & seconds.ToString("00")

                        Select Case l.Id

                            Case 0
                                lblTime1.Text = time
                                Exit Select

                            Case 1
                                lblTime2.Text = time
                                Exit Select


                        End Select

                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "39")
        End Try
       
    End Sub

    Private Sub txtDial_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDial.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Enter
                    If True Then

                        '---- Starts a new call if press <ENTER>!
                        If txtDial.Text.Length > 0 Then
                            iaxc.Lines(iaxc.Lines.SelectedLine).MakeCall(txtDial.Text.Trim())
                            txtDial.Text = [String].Empty
                        End If

                        Exit Select

                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "40")
        End Try
      
    End Sub

    Private Sub cmdLine1_Click(sender As System.Object, e As System.EventArgs) Handles cmdLine1.Click, cmdLine2.Click
        Try
            '----- Select the line!
            Dim line As Integer = Convert.ToInt32(DirectCast(sender, Button).Tag)
            iaxc.Lines.SelectLine(line)
            TxtTelefono.Text = iaxc.Lines(iaxc.Lines.SelectedLine).Remote
            BuscarTelefono()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "41")
        End Try
        
    End Sub

    Private Sub Linea1()
        Try
            '----- Select the line!
            Dim line As Integer = 0
            iaxc.Lines.SelectLine(line)

            'If iaxc.Lines(iaxc.Lines.SelectedLine).Remote = "" Then
            If iaxc.Lines(0).CallStatus = CallStatus.csRinging Then
                'If iaxc.Lines(0).CallStatus = 0 Then 'Ringing
                If iaxc.Lines(0).Remote = "" Then
                    TxtTelefono.Text = 9999999
                Else
                    TxtTelefono.Text = iaxc.Lines(0).Remote
                End If

                BuscarTelefono()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "42")
        End Try
       
    End Sub

    'COMENTADO PORQUE SE ELIMINA LINEA 2
    'Private Sub Linea2()
    '    Try
    '        '----- Select the line!
    '        Dim line As Integer = 1
    '        iaxc.Lines.SelectLine(line)

    '        TxtTelefono.Text = iaxc.Lines(iaxc.Lines.SelectedLine).Remote
    '        BuscarTelefono()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "43")
    '    End Try

    'End Sub

    Private Sub FrmInfoCliente_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Try
            '----- Hide to tray!
            If WindowState = FormWindowState.Minimized Then
                Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "44")
        End Try
      
    End Sub

    Private Sub notifyMain_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notifyMain.MouseDoubleClick
        Try
            '----- Show form from tray!
            Show()
            WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MessageBox.Show(ex.Message, "45")
        End Try
        
    End Sub

    Private Sub cmdDigit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDigit0.Click, cmdDigit1.Click, cmdDigit2.Click, cmdDigit3.Click, cmdDigit4.Click, cmdDigit5.Click, cmdDigit6.Click, cmdDigit7.Click, cmdDigit8.Click, cmdDigit9.Click, cmdDigitAsterisk.Click, cmdDigitSharp.Click
        Try
            Dim digit As Byte = Convert.ToByte(DirectCast(sender, Button).Text(0))
            iaxc.PlayDigit(digit)

            If iaxc.Lines(iaxc.Lines.SelectedLine).Active Then

                '----- Get button digit!
                'byte digit = Convert.ToByte(((Button)sender).Text[0]);

                iaxc.Lines(iaxc.Lines.SelectedLine).SendDTMF(digit)
            Else
                '---- Fill dial textbox!
                txtDial.Text += DirectCast(sender, Button).Text(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "46")
        End Try
     
    End Sub

    Private Sub cmdConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfig.Click
        Try
            Using config As New frmConfig(iaxc)

                Dim configStatus As Integer = Settings.[Default].ConfigStatus

                '----- Show config form!
                Dim result As DialogResult = config.ShowDialog()

                If result = DialogResult.OK AndAlso (configStatus = -1) AndAlso (Settings.[Default].ConfigStatus = 1) Then
                    '----- Initilize if press OK!
                    InitilizeIAX()
                End If


                InitializeVisual()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "47")
        End Try
       
    End Sub

    Private Sub cmdPickUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickUp.Click
        Try
            txtDetalle.Text = ""
            '----- Answer ringing call!
            'iaxc.Lines(iaxc.Lines.SelectedLine).AnswerCall()
            iaxc.Lines(0).AnswerCall()
        
            'TxtTelefono.Text = iaxc.Lines(iaxc.Lines.SelectedLine).Remote
            TxtTelefono.Text = iaxc.Lines(0).Remote
            BuscarTelefono()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "48")
        End Try
    End Sub

    Private Sub cmdCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCall.Click
        Try
            '----- Starts a new call!
            If txtDial.Text.Length > 0 Then
                iaxc.Lines(iaxc.Lines.SelectedLine).MakeCall(txtDial.Text.Trim())
                txtDial.Text = [String].Empty
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "49")
        End Try
        


    End Sub

    Private Sub cmdHangup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHangup.Click
        Try
        
            iaxc.Lines(iaxc.Lines.SelectedLine).DropCall()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "50")
        End Try
        
    End Sub

    Private Sub cmdTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransfer.Click
        Try
            iaxc.Lines(iaxc.Lines.SelectedLine).TransferCall(txtDial.Text.Trim())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "51")
        End Try


    End Sub
    Private Sub lblStatus1_TextChanged(sender As System.Object, e As System.EventArgs) Handles lblStatus1.TextChanged
        Try
            ' MsgBox("change")
            If lblStatus1.Text.ToUpper = "None".ToUpper Then
                panLine1.BackColor = Color.Black
                lblCallDirection1.Text = ""
            ElseIf lblStatus1.Text.ToUpper = "ringing".ToUpper Then
                panLine1.BackColor = Color.Green
                lblCallDirection1.Text = "Llamada entrante"
            ElseIf lblStatus1.Text.ToUpper = "calling".ToUpper Then
                panLine1.BackColor = Color.Green
                lblCallDirection1.Text = "Llamada Saliente"
            ElseIf lblStatus1.Text.ToUpper = "complete".ToUpper Then
                panLine1.BackColor = Color.Orange
                lblCallDirection1.Text = "Atendido"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "52")
        End Try
       
    End Sub
    Private Sub lblStatus2_TextChanged(sender As System.Object, e As System.EventArgs) Handles lblStatus2.TextChanged
        Try
            If lblStatus2.Text.ToUpper = "None".ToUpper Then
                Panel1.BackColor = Color.Black
                lblCallDirection1.Text = ""
            ElseIf lblStatus2.Text.ToUpper = "ringing".ToUpper Then
                Panel1.BackColor = Color.Green
                lblCallDirection1.Text = "Llamada entrante"
            ElseIf lblStatus2.Text.ToUpper = "calling".ToUpper Then
                Panel1.BackColor = Color.Green
                lblCallDirection1.Text = "Llamada Saliente"
            ElseIf lblStatus2.Text.ToUpper = "complete".ToUpper Then
                Panel1.BackColor = Color.Orange
                lblCallDirection1.Text = "Atendido"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "53")
        End Try
      
    End Sub
    Private Sub FrmInfoCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyValue = Keys.F1 Then
                If cmdLine1.Enabled = True Then
                    Linea1()
                End If
            End If

            If e.KeyValue = Keys.Escape Then
                cmdDropCall_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "54")
        End Try
   
    End Sub
#End Region

#Region "Diferidos"
    Private Sub PedidoDiferidoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PedidoDiferidoToolStripMenuItem.Click
        pnlDiferido.Visible = True
    End Sub

    Private Sub btnDiferido_Click(sender As System.Object, e As System.EventArgs) Handles btnDiferido.Click
        ' MsgBox(dtpDiferido.Text & " " & dtpHora.Text)

        If fechaDiferido = "" Then
            fechaDiferido = dtpDiferido.Text & " " & dtpHora.Text
            If fechaDiferido <= Now Then
                Dim frm As New FrmMensajes("Fecha y hora del pedido incorrectas", Nothing)
                frm.Show()
                fechaDiferido = ""

            Else
                If cbxCategoria.SelectedValue = 2 Then
                    cbxCategoria.SelectedValue = 3
                End If

                GenerarPedido()
                pnlDiferido.Visible = False
            End If
        Else
            fechaDiferido = dtpDiferido.Text & " " & dtpHora.Text
            If fechaDiferido <= Now Then
                Dim frm As New FrmMensajes("Fecha y hora del pedido incorrectas", Nothing)
                frm.Show()

                'fechaDiferido = ""

            Else

                ModificarPedido()
                pnlDiferido.Visible = False
            End If

        End If
    End Sub

    Private Sub ModificarDiferidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarDiferidoToolStripMenuItem.Click
        If CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).fechahora_viaje <> CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).fechahora Then
            pnlDiferido.Visible = True
            fechaDiferido = dtpDiferido.Text & " " & dtpHora.Text

            dtpDiferido.Value = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).fechahora_viaje
            dtpHora.Value = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido).fechahora_viaje
        Else
            Dim frm As New FrmMensajes("No se puede modificar pedido porque no es diferido")
            frm.Show()
        End If
    End Sub
#End Region
   
    Private Sub TxtObservacion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtObservacion.KeyDown
        If e.KeyValue = Keys.Enter Then
            GenerarPedido()
        End If
    End Sub

    Private Sub AgregarModificarObservacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarModificarObservacionesToolStripMenuItem.Click
        clsCliente.Pedido = dgvPedidos.CurrentRow.DataBoundItem
        pnlObservacion.Visible = True
        txtObserPedido.Text = clsCliente.Pedido.observacion
    End Sub

    Private Sub btnObservaciones_Click(sender As Object, e As EventArgs) Handles btnObservaciones.Click
        txtObserPedido.Focus()
        clsCliente.Pedido.observacion = txtObserPedido.Text
        clsCliente.IniciarTrn()
        Try
            clsCliente.ModificarPedidoObservaciones(clsCliente.Pedido.observacion, clsCliente.Pedido.id, My.Settings.idUsuario)
            clsCliente.gettrn.Commit()
        Catch ex As Exception
            clsCliente.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
        ' RegistrarBitacora(17, clsCliente.Pedido.id) ' ModificaPedido
        txtObserPedido.Text = ""
        pnlObservacion.Visible = False
    End Sub

    'Public Sub RegistrarBitacora(ByVal operacion As Integer, Optional ByVal pedido As Integer = 0, Optional ByVal domicilio As Integer = 0)
    '    Dim clsbitacora As New clsBitacora
    '    With clsbitacora.Bitacora
    '        .usuario_id = ClsVariableSesion.Instancia.Usuario.entidad_id
    '        .pedido_id_bitacora = pedido
    '        .domicilio_id_bitacora = domicilio
    '        .operacion_id = operacion
    '        .fechahora = Now
    '    End With

    '    Try
    '        clsbitacora.InsertarBitacora()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub BtnAdd50_Click(sender As Object, e As EventArgs) Handles BtnAdd50.Click
        clsCliente.CargarPedidosxTelefono50(clsCliente.Telefono.id)
        If clsCliente.LstPedido.Count > 0 Then
            bgsPedido.DataSource = clsCliente.LstPedido
            dgvPedidos.DataSource = bgsPedido
            MarcarReclamos()
            If dgvPedidos.RowCount > 0 Then
                cmsPedidos.Enabled = True
            Else
                cmsPedidos.Enabled = False
            End If
        End If
    End Sub

    Private Sub BtnCancelarObservaciones_Click(sender As Object, e As EventArgs) Handles BtnCancelarObservaciones.Click
        txtObserPedido.Text = ""
        pnlObservacion.Visible = False
    End Sub

End Class