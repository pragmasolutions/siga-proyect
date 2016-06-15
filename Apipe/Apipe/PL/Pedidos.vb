Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Public Class FrmPedidos
    Dim Cls As New ClsClientes



#Region "Pedidos"
    Private Sub BuscarPedidos()
        Cls.FillListPedido()
        bgsPedido.DataSource = Cls.LstPedido
        dgvPedidos.DataSource = bgsPedido
        MarcarReclamos()
    End Sub

    Private Sub MarcarReclamos()
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
    End Sub




#End Region
#Region "Reclamos"
    Private Sub ReclamoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReclToolStripMenuItem.Click
        Cls.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
        ' Cls.FillByTelefono(Cls.Pedido.telefono_id)
        Dim frm As New FrmReclamos(Cls.Pedido.id)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            BgsPedido.ResetBindings(False)
        End If
        BuscarPedidos()
    End Sub
    'Private Sub ReclToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReclToolStripMenuItem.Click
    '    Dim FormReclamo As New FrmReclamosCliente(Cls.cliente.entidad_id)
    '    FormReclamo.ShowDialog()
    'End Sub
    
#End Region
#Region "Detalle Yugoo"
    Private Sub dgvPedidos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPedidos.SelectionChanged
        Dim indicePedido As Integer = -1
        If bgsPedido.Count > 0 Then
            If indicePedido > -1 Then bgsPedido.Position = indicePedido
            Cls.Pedido = bgsPedido.Item(bgsPedido.Position)
            DatosPedido()
        End If
    End Sub
    Private Sub DatosPedido()

        txtDetalle.Text = ""
        If dgvPedidos.CurrentRow IsNot Nothing Then
            txtDetalle.Font = New System.Drawing.Font("Verdana", 9, FontStyle.Regular)
            txtDetalle.ForeColor = Color.White
            With Cls.Pedido
                txtDetalle.Text = "Domicilio: " & .v_domicilio
                txtDetalle.Text &= " Cliente: " & .cliente
                If .v_nroMovil.Length > 0 Then txtDetalle.Text &= vbNewLine & "Movil: " & .v_nroMovil
                txtDetalle.Text &= vbNewLine & "Pedido: " & .v_hora
                txtDetalle.Text &= " Viaje: " & .v_hora_viaje
                If .observacion.Length > 0 Then txtDetalle.Text &= " Observaciones: " & .observacion
                If .lst_Reclamo.Count > 0 Then txtDetalle.Text &= vbNewLine & "Reclamo: " & .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
                Detalle("Domicilio:")
                Detalle(.v_domicilio, True)
                Detalle("Cliente:")
                Detalle(.cliente, True)
                Detalle("Movil:")
                Detalle(.v_nroMovil, True)
                Detalle("Observaciones:")
                Detalle("Pedido:")
                Detalle("Viaje:")
                Detalle("Reclamo:")
                If .lst_Reclamo.Count > 0 Then Detalle(.lst_Reclamo.First.lst_ReclamoLinea.First.comentario, True)
            End With
        End If
    End Sub
    Private Sub Detalle(ByVal palabra As String, Optional ByVal pintar As Boolean = False)
        txtDetalle.Find(palabra, RichTextBoxFinds.MatchCase)
        txtDetalle.SelectionFont = New System.Drawing.Font("Verdana", 11, FontStyle.Bold)
        If pintar Then txtDetalle.SelectionColor = ColorTranslator.FromOle(RGB(232, 81, 29))
    End Sub



#End Region
#Region "Cancelar Pedido"
   
    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Dim frm As New FrmOkCancel("¿Confirma cancelación de pedido?", MousePosition)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cls.Pedido = CType(dgvPedidos.CurrentRow.DataBoundItem, pedido)
            Cls.Pedido.completado = Now
            Cls.Pedido.cancelado = Now
            Cls.ModificarPedido()
            BgsPedido.ResetBindings(False)
        End If
        BuscarPedidos()
    End Sub
#End Region

   
   
    Private Sub FrmPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarPedidos()
    End Sub
End Class