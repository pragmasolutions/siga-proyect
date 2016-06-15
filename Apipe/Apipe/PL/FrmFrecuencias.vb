Public Class FrmFrecuencias
    Dim cls As New ClsAdministrarPedidos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim frm As New FrmConfirmacion("¿Desea guardar los cambios de frecuencia?")
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CambiarFrecuencias()
        End If


    End Sub

    Private Sub CambiarFrecuencias()
        Dim resultado As New Boolean
        resultado = False
        If txtDesde1.Text <> "" And txtHasta1.Text <> "" Then
            cls.CambiarFrecuencias(txtDesde1.Text, txtHasta1.Text, 1)
            resultado = True
        End If

        If txtDesde2.Text <> "" And txtHasta2.Text <> "" Then
            cls.CambiarFrecuencias(txtDesde2.Text, txtHasta2.Text, 2)
            resultado = True
        End If

        If txtDesde3.Text <> "" And txtHasta3.Text <> "" Then
            cls.CambiarFrecuencias(txtDesde3.Text, txtHasta3.Text, 3)
            resultado = True
        End If

        If txtDesde4.Text <> "" And txtHasta4.Text <> "" Then
            cls.CambiarFrecuencias(txtDesde4.Text, txtHasta4.Text, 4)
            resultado = True
        End If

        If resultado = True Then
            Dim frm As New FrmMensajes("Los cambios  se han registrado exitosamente")
            frm.ShowDialog()

            RegistrarBitacora()
        End If
    End Sub

    Public Sub RegistrarBitacora()
        Dim clsbitacora As New clsBitacora
        With clsbitacora.Bitacora
            .usuario_id = ClsVariableSesion.Instancia.Usuario.entidad_id
            .operacion_id = 29 ' cambia frecuencias
            .fechahora = Now
        End With

        Try
            clsbitacora.InsertarBitacora()
            'clsbitacora.gettrn.Commit()
        Catch ex As Exception
            'clsbitacora.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class