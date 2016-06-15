
Public Class FrmTraspasoPedidos
    Dim cls As New ClsAdministrarPedidos
    Dim bgsACompletar, bgsOperadores As New BindingSource
    Dim cantAAsignar As Integer

#Region "Inicializar"
    Private Sub FrmTraspasoPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvACompletar.AutoGenerateColumns = False
        dgvOperadores.AutoGenerateColumns = False
        dgvACompletar.DataSource = bgsACompletar
        dgvOperadores.DataSource = bgsOperadores
        cls.CargarACompletarTodos()
        CargarDatos()
        dgvACompletar.Select()
    End Sub
    Private Sub CargarDatos()
        cantAAsignar = 0
        cls.Operador = Nothing
        bgsACompletar.DataSource = (From p In cls.lstPedidoACompletar Where p.operador_id = cls.Operador.entidad_id).ToList '** poner usuario logueado!
        For Each o In ClsEnumerados.Instancia.lstOperadores
            o.v_CantACompletar = (From p In cls.lstPedidoACompletar Where p.operador_id = o.entidad_id).Count
        Next
        bgsOperadores.DataSource = (From o In ClsEnumerados.Instancia.lstOperadores Where o.entidad_id <> cls.Operador.entidad_id Order By o.v_CantACompletar Ascending).ToList
        ActualizarMensaje()
    End Sub
#End Region
#Region "Navegación"
    Private Sub dgvACompletar_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvACompletar.DataBindingComplete
        txtACompletar.Text = dgvACompletar.RowCount & " PEDIDOS DE " & cls.Operador.v_AyN.ToUpper
        txtACompletar.SelectAll()
        txtACompletar.SelectionAlignment = HorizontalAlignment.Center
        txtACompletar.Find("PEDIDOS DE " & cls.Operador.v_AyN.ToUpper)
        txtACompletar.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        PintarACompletar()
    End Sub
    Private Sub dgvOperadores_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvOperadores.DataBindingComplete
        txtOperadores.Text = dgvOperadores.RowCount & " OPERADORES"
        txtOperadores.SelectAll()
        txtOperadores.SelectionAlignment = HorizontalAlignment.Center
        txtOperadores.Find("OPERADORES")
        txtOperadores.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub
    Private Sub dgvOperadores_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOperadores.SelectionChanged
        cls.Operador = bgsOperadores.Item(bgsOperadores.Position)
        ActualizarMensaje()
    End Sub
    Private Sub dgvACompletar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvACompletar.CellClick
        If e.ColumnIndex = colACompCheck.Index Then
            dgvACompletar.CurrentCell.Value = Not dgvACompletar.CurrentCell.Value
            cantAAsignar = (From r As DataGridViewRow In dgvACompletar.Rows Where r.Cells(colACompCheck.Index).Value).Count
            ActualizarMensaje()
            chkSeleccionarTodos.Checked = (cantAAsignar = bgsACompletar.Count)
        End If
    End Sub
    Private Sub chkSeleccionarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.Click
        For Each r As DataGridViewRow In dgvACompletar.Rows
            r.Cells(colACompCheck.Index).Value = chkSeleccionarTodos.Checked
        Next
        cantAAsignar = IIf(chkSeleccionarTodos.Checked, bgsACompletar.Count, 0)
        ActualizarMensaje()
    End Sub
    Private Sub ActualizarMensaje()
        txtMensaje.Text = "TRASPASAR " & cantAAsignar.ToString & " PEDIDOS AL OPERADOR " & cls.Operador.v_AyN.ToUpper
        txtMensaje.SelectAll()
        txtMensaje.SelectionAlignment = HorizontalAlignment.Left
        txtMensaje.Find(cantAAsignar.ToString)
        txtMensaje.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
        txtMensaje.Find(cls.Operador.v_AyN.ToUpper)
        txtMensaje.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub
    Private Sub PintarACompletar()
        For Each r In dgvACompletar.Rows
            With CType(r.DataBoundItem, pedido)
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
#End Region

#Region "Traspasar"
    Private Sub btnTraspasar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraspasar.Click
        If cantAAsignar > 0 Then
            If MessageBox.Show("¿Confirma que desea asignar " & cantAAsignar & " pedidos a " & cls.Operador.v_AyN & "?", "Traspasar Pedidos", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim exito As Boolean = False
                cls.IniciarTrn()
                Try
                    For Each r As DataGridViewRow In dgvACompletar.Rows
                        If r.Cells(colACompCheck.Index).Value Then
                            CType(r.DataBoundItem, pedido).operador_id = cls.Operador.entidad_id
                            cls.Pedido = CType(r.DataBoundItem, pedido)
                            cls.PersistirPedido(False)
                        End If
                    Next
                    cls.gettrn.Commit()
                    MessageBox.Show("Se han traspasado los " & cantAAsignar.ToString & " pedidos a " & cls.Operador.v_AyN & ".")
                    exito = True
                Catch ex As Exception
                    cls.gettrn.Rollback()
                    MessageBox.Show("Ha ocurrido un error al traspasar los pedidos." & vbNewLine & ex.Message)
                End Try
                If exito Then
                    CargarDatos()
                End If
            End If
        End If
    End Sub
#End Region

End Class