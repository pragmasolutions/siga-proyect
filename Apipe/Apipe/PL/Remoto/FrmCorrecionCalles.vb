Public Class FrmCorrecionCalles
    Dim cls As New ClsStores
#Region "Inicializar"
    Private Sub FrmCorrecionCalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCalles()
    End Sub
#End Region

#Region "Métodos"
    Private Sub CargarCalles()
        With cbxCalles
            .DisplayMember = "calle"
            '.ValueMember = "id"
        End With
        cls.FillCalles()
        cbxCalles.DataSource = cls.LstCalle
        lblCantidad.Text = "Cantidad de Calles por corregir: " & cls.LstCalle.Count
    End Sub
#End Region

#Region "Controles"

    Private Sub btnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles btnGuardarNuevo.Click
        Dim frm As New FrmConfirmacion("¿Desea cambiar la calle " & cbxCalles.Text & " por " & txtcalleOK.Text & "?")
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            If cls.StoreCorreccionCalle(cbxCalles.Text.ToUpper, txtcalleOK.Text.ToUpper) Then
                CargarCalles()
                txtcalleOK.Text = ""
                Dim frm2 As New FrmMensajes("Correcion Satisfactoria")
                frm2.ShowDialog()
            End If
            
        End If
    End Sub
#End Region

   

End Class