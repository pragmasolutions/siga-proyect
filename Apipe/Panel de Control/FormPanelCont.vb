Imports Apipe
Imports entitiesApipe
Public Class PantallaPedidos

    Dim bgsPendientes, bgsAcompletar, bgsBase1, bgsBase2, bgsBase3, bgsBase4, bgsBase5, bgsBase6, bgsBase7, bgsBase8, bgsBase9, bgsBase10, bgsBase11, bgsBase12 As New BindingSource
    Dim cls As New ClsAdministrarPedidos
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Try
            'My.Settings.DbDomain = "192.168.1.1"
            ClsVariableSesion.DbDomain = "190.228.83.52"
            ClsVariableSesion.Db = "apipe2"
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
        dgvZ1.AutoGenerateColumns = False
        dgvZ2.AutoGenerateColumns = False
        dgvZ3.AutoGenerateColumns = False
        dgvZ4.AutoGenerateColumns = False
        dgvZ5.AutoGenerateColumns = False
        dgvZ6.AutoGenerateColumns = False
        dgvZ7.AutoGenerateColumns = False
        dgvZ8.AutoGenerateColumns = False
        dgvZ9.AutoGenerateColumns = False
        dgvZ10.AutoGenerateColumns = False
        dgvZP.AutoGenerateColumns = False
        dgvZT.AutoGenerateColumns = False

        dgvPedidos.DataSource = bgsPendientes
        dgvACompletar.DataSource = bgsAcompletar
        dgvZ1.DataSource = bgsBase1
        dgvZ2.DataSource = bgsBase2
        dgvZ3.DataSource = bgsBase3
        dgvZ4.DataSource = bgsBase4
        dgvZ5.DataSource = bgsBase5
        dgvZ6.DataSource = bgsBase6
        dgvZ7.DataSource = bgsBase7
        dgvZ8.DataSource = bgsBase8
        dgvZ9.DataSource = bgsBase9
        dgvZ10.DataSource = bgsBase10
        dgvZP.DataSource = bgsBase11
        dgvZT.DataSource = bgsBase12

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cls.CargarPedidos()
        cls.CargarPedidosACompletarTodos()
        For i = 1 To 12
            cls.CargarMovilesZonaI(i)
            Select Case i
                Case 1
                    bgsBase1.DataSource = cls.lstChoferMovilZonai
                Case 2
                    bgsBase2.DataSource = cls.lstChoferMovilZonai
                Case 3
                    bgsBase3.DataSource = cls.lstChoferMovilZonai
                Case 4
                    bgsBase4.DataSource = cls.lstChoferMovilZonai
                Case 5
                    bgsBase5.DataSource = cls.lstChoferMovilZonai
                Case 6
                    bgsBase6.DataSource = cls.lstChoferMovilZonai
                Case 7
                    bgsBase7.DataSource = cls.lstChoferMovilZonai
                Case 8
                    bgsBase8.DataSource = cls.lstChoferMovilZonai
                Case 9
                    bgsBase9.DataSource = cls.lstChoferMovilZonai
                Case 10
                    bgsBase10.DataSource = cls.lstChoferMovilZonai
                Case 11
                    bgsBase11.DataSource = cls.lstChoferMovilZonai
                Case 12
                    bgsBase12.DataSource = cls.lstChoferMovilZonai

            End Select

        Next
        bgsPendientes.DataSource = cls.lstPedido
        bgsAcompletar.DataSource = cls.lstPedidoACompletar

        PintarPedidos()
        PintarACompletar()

    End Sub

    Private Sub PintarPedidos()
        Try
            For Each r As DataGridViewRow In dgvPedidos.Rows
                With CType(r.DataBoundItem, pedido)

                    If .lst_Reclamo.Count > 0 Then
                        ' r.Cells(colPedReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colPedReclamo.Name).ToolTipText = .v_reclamos
                        'If .lst_Reclamo.First.lst_ReclamoLinea.Count = 1 Then
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
                        '   r.Cells(colPedReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colPedReclamo.Name).ToolTipText = "Sin reclamo"
                    End If

                    If .pedido_categoria_id = 3 Then

                        r.Cells(0).Style.BackColor = Color.Maroon
                        r.Cells(1).Style.BackColor = Color.Maroon
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Maroon
                        r.Cells(4).Style.BackColor = Color.Maroon
                        r.Cells(5).Style.BackColor = Color.Maroon
                    ElseIf .pedido_categoria_id = 5 Then
                        r.Cells(0).Style.BackColor = Color.Purple
                        r.Cells(1).Style.BackColor = Color.Purple
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Purple
                        r.Cells(4).Style.BackColor = Color.Purple
                        r.Cells(5).Style.BackColor = Color.Purple
                    ElseIf .pedido_categoria_id = 1 Then
                        r.Cells(0).Style.BackColor = Color.Pink
                        r.Cells(1).Style.BackColor = Color.Pink
                        'r.Cells(2).Style.BackColor = Color.Cyan
                        r.Cells(3).Style.BackColor = Color.Pink
                        r.Cells(4).Style.BackColor = Color.Pink
                        r.Cells(5).Style.BackColor = Color.Pink
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "5")
        End Try
    End Sub

    Private Sub PintarACompletar()

        Try
            For Each r In dgvACompletar.Rows
                With CType(r.DataBoundItem, pedido)
                    r.Cells(colACompCompletar.Name).ToolTipText = "Completar pedido"
                    If .cancelado <> "1900-01-01 00:00:00" Then
                        ' r.Cells(colACompCambiarMovil.Name).Value = My.Resources.notiene
                        r.Cells(colACompCambiarMovil.Name).ToolTipText = "Pedido cancelado"
                        r.Cells(0).Style.BackColor = Color.Blue
                        r.Cells(1).Style.BackColor = Color.Blue
                        r.Cells(2).Style.BackColor = Color.Blue
                        r.Cells(3).Style.BackColor = Color.Blue
                        r.Cells(4).Style.BackColor = Color.Blue
                        r.Cells(5).Style.BackColor = Color.Blue
                        r.Cells(6).Style.BackColor = Color.Blue
                        r.Cells(7).Style.BackColor = Color.Blue
                    Else
                        '    r.Cells(colACompCambiarMovil.Name).Value = My.Resources.movil
                        r.Cells(colACompCambiarMovil.Name).ToolTipText = "Cambiar móvil"
                    End If
                    If .lst_Reclamo.Count > 0 Then
                        '  r.Cells(colACompReclamo.Name).Value = My.Resources.signoreclamo
                        r.Cells(colACompReclamo.Name).ToolTipText = .v_reclamos ' .lst_Reclamo.First.lst_ReclamoLinea.First.comentario
                        'If .lst_Reclamo.First.lst_ReclamoLinea.Count = 1 Then
                        If .lst_Reclamo.Count = 1 Then
                            r.Cells(0).Style.BackColor = Color.Green
                            r.Cells(1).Style.BackColor = Color.Green
                            r.Cells(2).Style.BackColor = Color.Green
                            r.Cells(3).Style.BackColor = Color.Green
                            r.Cells(4).Style.BackColor = Color.Green
                            r.Cells(5).Style.BackColor = Color.Green
                            r.Cells(6).Style.BackColor = Color.Green
                            r.Cells(7).Style.BackColor = Color.Green
                            'ElseIf .lst_Reclamo.First.lst_ReclamoLinea.Count = 2 Then
                        ElseIf .lst_Reclamo.Count = 2 Then
                            r.Cells(0).Style.BackColor = Color.Orange
                            r.Cells(1).Style.BackColor = Color.Orange
                            r.Cells(2).Style.BackColor = Color.Orange
                            r.Cells(3).Style.BackColor = Color.Orange
                            r.Cells(4).Style.BackColor = Color.Orange
                            r.Cells(5).Style.BackColor = Color.Orange
                            r.Cells(6).Style.BackColor = Color.Orange
                            r.Cells(7).Style.BackColor = Color.Orange
                        Else
                            r.Cells(0).Style.BackColor = Color.Red
                            r.Cells(1).Style.BackColor = Color.Red
                            r.Cells(2).Style.BackColor = Color.Red
                            r.Cells(3).Style.BackColor = Color.Red
                            r.Cells(4).Style.BackColor = Color.Red
                            r.Cells(5).Style.BackColor = Color.Red
                            r.Cells(6).Style.BackColor = Color.Red
                            r.Cells(7).Style.BackColor = Color.Red
                        End If
                    Else
                        ' r.Cells(colACompReclamo.Name).Value = My.Resources.vacio
                        r.Cells(colACompReclamo.Name).ToolTipText = "Sin reclamo"
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "17")
        End Try
    End Sub

End Class
