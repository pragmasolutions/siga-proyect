Public Class FrmBarrio
    Dim Cls As New ClsZonas
    Private Sub FrmBarrio_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Cls.FillByBarrios(txtNombre.Text)
        dgvBarrios.DataSource = Cls.LstBarrio
    End Sub
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Panel2.Enabled = True
    End Sub
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren Then
            With Cls.Barrio
                .nombre = txtNombreBarrio.Text
            End With
            Cls.IniciarTrn()
            Try
                Cls.PreservarBarrio()
                Cls.gettrn.Commit()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dgvBarrios.AutoGenerateColumns = False
    End Sub

    
End Class