Imports Microsoft.VisualBasic.Devices
Imports System.IO

'Imports libSoporte
Public Class FrmConfiguracion
    'Private Soporte As libSoporte.soporte
    Private flag As Boolean
    Private Suc As Integer
    Private strConn As String
    Private Sub AceptButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptButton1.Click
        My.Settings.DbDomain = strConn
        My.Settings.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub FrmConfiguracion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not flag Then
            'End
        End If
    End Sub
    Private Sub TESTButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TESTButton1.Click
        '  strConn = ProbarTextBox1.Text.Trim
        '   strConn = cbxProbarApipe1.SelectedItem.ToString.Trim
        strConn = cbxProbarApipe1.Text.Trim
        If String.IsNullOrEmpty(strConn) Then
            MessageBox.Show("Error la direccion IP no puede ser nula, Ejemplo: 10.0.0.1", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Not ProbarConnexion(strConn) Then
                MessageBox.Show("Error en la conexion con la Base de Datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' ProbarTextBox1.SelectAll()
                If Not My.Computer.Network.Ping(strConn) Then
                    MessageBox.Show("No es posible llegar hasta el servidor" & vbCrLf _
                    & "Realice las siguientes verificaciones:" & vbCrLf _
                    & " * Verifique que servidor se encuentre encendido" & vbCrLf _
                    & " * Existe algún problema en la RED (reinicie MODEM / ROUTER)" & vbCrLf _
                    & " * Verifique si tiene acceso a INTERNET" & vbCrLf _
                    & " * Por ultimo intenta APAGAR el servidor y luego volver a encenderlo (NO USER EL BOTON DE RESET)", "CONSEJOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("El servidor es visible, es probable que exista un problema con la BASE DE DATOS" & vbCrLf _
                    & "Comunicarce con el administrador del sistema", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Conexion Satisfactoria con la Base de Datos ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AceptButton1.Enabled = True
            End If
        End If
    End Sub

    Private Function ProbarConnexion(ByVal strPrueba As String) As Boolean
        ClsVariableSesion.Instancia = Nothing
        ClsVariableSesion.DbDomain = strPrueba
        Try
            ClsVariableSesion.Instancia.getConn.Open()
            My.Settings.DbDomain = strPrueba
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        'Try
        '    Soporte = New libSoporte.soporte(My.Application.Info.DirectoryPath & Path.DirectorySeparatorChar & "winvnc")
        '    Soporte.conectar()
        '    Label5.Enabled = False
        'Catch ex As Exception
        '    MessageBox.Show("Verifique que disponga de conexion a internet", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub Label5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        Cursor = Cursors.Hand
    End Sub
    Private Sub Label5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

End Class