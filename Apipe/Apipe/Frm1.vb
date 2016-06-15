Imports SharpIAX
Imports System.Net

Public Class Frm1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Try
        '    ClsVariableSesion.Db = "apipe"
        '    ClsVariableSesion.DbDomain = "yugoo2.com.ar"
        '    ClsVariableSesion.DbPass = "apipe"
        '    ClsVariableSesion.DbUser = "apipe"
        '    ClsVariableSesion.Instancia.getConn.Open()
        '    gbxAccesos.Enabled = True
        '    Button1.Enabled = False
        '    'Esto lo deberiamos hacer cada 5 minutos en algun hilo
        '    session.setSession(999, ClsVariableSesion.Instancia.getConn) '1 ' 23313 ' 999

        'Catch ex As Exception
        '    MessageBox.Show("No se pudo abrir la conexion." & vbNewLine & ex.Message)
        'End Try
        Try
            ClsVariableSesion.Db = "apipe"
            ClsVariableSesion.DbDomain = "192.168.1.1"
            ClsVariableSesion.DbPass = "apipe"
            ClsVariableSesion.DbUser = "apipe"
            ClsVariableSesion.Instancia.getConn.Open()
            gbxAccesos.Enabled = True
            Button1.Enabled = False
            'Esto lo deberiamos hacer cada 5 minutos en algun hilo
            session.setSession(999, ClsVariableSesion.Instancia.getConn) '1 ' 23313 ' 999

        Catch ex As Exception
            MessageBox.Show("No se pudo abrir la conexion." & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmBarrio.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDomicilios.Click
        ' FrmDomicilio.Show(0)
        FrmMensajero.Show()
    End Sub
    Private Sub BtnInfoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfoCliente.Click
        FrmInfoCliente.Show()
    End Sub
    Private Sub BtnIax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIax.Click
        FrmMovil.Show()
    End Sub

    Private Sub BtnMdi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMdi.Click
        MdiTelefonista.Show()
    End Sub
    Private Sub btnAdministrarPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministrarPedidos.Click
        Dim frm As New FrmAdministrarPedidos
        frm.Show()
    End Sub

    Private Sub BtnDgvCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDgvCliente.Click
        DlgTelefonos.Show()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frm As New FrmBuscarClientes
        frm.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim frm As New FrmPedidoCategoria
        frm.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frm As New FrmReclamoCategoria
        frm.Show()
    End Sub

    Private Sub btnTraspasoPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraspasoPedidos.Click
        Dim frm As New FrmTraspasoPedidos
        frm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Dim frm As New frmMain
        'frm.Show()
    End Sub

    Private Sub BtnBuscarMovil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarMovil.Click
        FrmBuscarMovil.Show()
    End Sub

    Private Sub BtnPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPedidos.Click
        FrmPedidos.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim frm As New FrmSeleccionarZonabtns
        frm.Show()
    End Sub
End Class