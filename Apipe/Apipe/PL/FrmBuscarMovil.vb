Public Class FrmBuscarMovil
    Dim Cls As New ClsClientes
#Region "Inicializar"
    Private Sub FrmBuscarMovil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvMovil.AutoGenerateColumns = False
        'DgvMovil.CurrentCell = Nothing

        'Carga todos los moviles
        Cls.FillListMovil()
        BgsMovil.DataSource = Cls.LstMovil
        DgvMovil.DataSource = BgsMovil
     
    End Sub
#End Region
#Region "Guardar/Editar"


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        If FrmMovil.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Cls.FillListMovil()
            BgsMovil.DataSource = Cls.LstMovil
            DgvMovil.DataSource = BgsMovil
        End If

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If DgvMovil.SelectedRows.Count = 1 Then
            Cls.movil = CType(DgvMovil.CurrentRow.DataBoundItem, movil)
            Dim Frm As New FrmMovil(Cls.movil)
            ' Frm.ShowDialog()

            If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                BgsMovil.ResetBindings(False)
            End If
        End If
    End Sub

    Private Sub ModifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DgvMovil.SelectedRows.Count = 1 Then
            Cls.movil = CType(DgvMovil.CurrentRow.DataBoundItem, movil)
            Cls.IniciarTrn()
            Try
                Cls.GuardarEdicion()
                Cls.gettrn.Commit()
                Me.Close()
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Actualizado")

        End If
    End Sub
#End Region

   
End Class