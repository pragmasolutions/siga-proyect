Public Class FrmReclamosCliente
    Dim cliente As Integer
    Dim cls As New ClsClientes

#Region "Inicializar"
    Public Sub New(ByVal cte As Integer)
        InitializeComponent()
        cliente = cte
        CargarReclamos()
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmReclamosCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvReclamos.AutoGenerateColumns = False
        dgvLineaReclamo.AutoGenerateColumns = False
        dgvReclamos.DataSource = bgsReclamos
        dgvLineaReclamo.DataSource = bgsLineaReclamo
    End Sub

#End Region

    Private Sub BuscarCliente()
        cls = New ClsClientes
        If TxtTelefono.Text = "" Then
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
        cls.FillTelefonoByNumeroYCarac(numero, cod_area)
        cls.FillEntidadByEntidad(cls.Telefono.entidad_id)
    End Sub

    Private Sub CargarReclamos()
        cls.FillListReclamoByCliente(cliente)
        bgsReclamos.DataSource = cls.LstReclamo
        bgsReclamos.ResetBindings(False)
        ' dgvReclamos.DataSource = cls.LstReclamo
    End Sub

    Private Sub dgvReclamos_SelectionChanged(sender As Object, e As System.EventArgs) Handles dgvReclamos.SelectionChanged
        cls.FillListByReclamo(CType(dgvReclamos.CurrentRow.DataBoundItem, reclamo).id)
        bgsLineaReclamo.DataSource = cls.LstReclamoLinea
        bgsLineaReclamo.ResetBindings(False)
    End Sub

    Private Sub txtTelefono_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarCliente()
            cliente = cls.entidad.id
            CargarReclamos()
        End If
    End Sub

    Private Sub ReclamoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReclamoToolStripMenuItem.Click
        Dim frm As New FrmReclamos(CType(dgvReclamos.CurrentRow.DataBoundItem, reclamo).pedido_id)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            bgsReclamos.ResetBindings(False)
            bgsLineaReclamo.ResetBindings(False)
        End If
    End Sub

    Private Sub btnCancela_Click(sender As System.Object, e As System.EventArgs) Handles btnCancela.Click
        Dim mensaje As String
        mensaje = "¿Desea cancelar?"

        Dim Frm As New FrmOkCancel(mensaje, System.Windows.Forms.Control.MousePosition)
        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class