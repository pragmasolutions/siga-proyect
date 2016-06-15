
Imports System
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports ALAZ.TelephonyEx.Voip.IAX

Public Class FrmConfigPhone
    Private iaxc As IAXClientClass

    Public Shared Function GetColorFromScheme(colorScheme As Integer) As Color

        Dim color As Color = color.Transparent

        Select Case colorScheme

            Case 0
                If True Then
                    color = color.DarkGray
                    Exit Select
                End If


            Case 1
                If True Then
                    color = color.Black
                    Exit Select
                End If

            Case 2
                If True Then
                    color = color.SlateBlue
                    Exit Select
                End If


            Case 3
                If True Then
                    color = color.Crimson
                    Exit Select
                End If

            Case 4
                If True Then
                    color = color.LightPink
                    Exit Select
                End If

            Case 5
                If True Then
                    color = color.MediumSeaGreen
                    Exit Select
                End If


        End Select

        Return color

    End Function

    Public Sub New(iaxclient As IAXClientClass)

        '----- Initialize form components!
        InitializeComponent()

        iaxc = iaxclient
        lblIAX.Text = "IAX Library Version: " + iaxc.Version

        '----- Initialize config components!

        cboInput.ValueMember = "Id"
        cboInput.DisplayMember = "Name"

        cboOutput.ValueMember = "Id"
        cboOutput.DisplayMember = "Name"

        cboRing.ValueMember = "Id"
        cboRing.DisplayMember = "Name"

        '----- Verify devices!
        For Each device As IAXAudioDevice In iaxc.AudioDevices

            '----- Input!
            If (device.Capabilities And AudioCapability.acIAXC_AD_INPUT) = AudioCapability.acIAXC_AD_INPUT Then
                cboInput.Items.Add(device)
            End If

            '----- Output!
            If (device.Capabilities And AudioCapability.acIAXC_AD_OUTPUT) = AudioCapability.acIAXC_AD_OUTPUT Then
                cboOutput.Items.Add(device)
            End If

            '----- Ring!
            If (device.Capabilities And AudioCapability.axIAXC_AD_RING) = AudioCapability.axIAXC_AD_RING Then
                cboRing.Items.Add(device)

            End If


        Next
    End Sub
    Private Sub FrmConfigPhone_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '----- Check config status!
        If Settings.[Default].ConfigStatus = -1 Then

            '----- Load default values!

            txtUser.Text = [String].Empty
            txtPassword.Text = [String].Empty
            '                txtPassword.Text = "sadfad";
            txtHost.Text = [String].Empty
            txtCallerIdName.Text = "SharpIAX"
            txtCallerIdNumber.Text = "(Not Specified)"
            chkRegistration.Checked = True

            rbG711Alaw.Checked = False
            rbG711Ulaw.Checked = False
            rbiLBC.Checked = False
            rbSpeex.Checked = False
            rbGSM.Checked = True

            chkG711Alaw.Checked = False
            chkG711Ulaw.Checked = False
            chkiLBC.Checked = False
            chkSpeex.Checked = False
            chkGSM.Checked = True

            cboColorScheme.SelectedIndex = 0

            If cboInput.Items.Count > 0 Then
                cboInput.SelectedIndex = cboInput.FindString(iaxc.AudioDevices(iaxc.AudioDevices.SelectedInputAudioDevice).Name)
            End If

            If cboOutput.Items.Count > 0 Then
                cboOutput.SelectedIndex = cboOutput.FindString(iaxc.AudioDevices(iaxc.AudioDevices.SelectedOutputAudioDevice).Name)
            End If

            If cboRing.Items.Count > 0 Then
                cboRing.SelectedIndex = cboRing.FindString(iaxc.AudioDevices(iaxc.AudioDevices.SelectedRingAudioDevice).Name)

            End If
        Else

            '----- Load config values!
            txtUser.Text = Settings.[Default].User
            txtPassword.Text = Encoding.[Default].GetString(Convert.FromBase64String(Settings.[Default].Password))
            'txtPassword.Text = "adsf";
            txtHost.Text = Settings.[Default].Host
            txtCallerIdName.Text = Settings.[Default].CallerIdName
            txtCallerIdNumber.Text = Settings.[Default].CallerIdNumber
            chkRegistration.Checked = Settings.[Default].Registration

            rbG711Alaw.Checked = Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer)
            rbG711Ulaw.Checked = Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer)
            rbiLBC.Checked = Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer)
            rbSpeex.Checked = Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer)
            rbGSM.Checked = Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer)

            chkG711Alaw.Checked = ((Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer))
            chkG711Ulaw.Checked = ((Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer))
            chkiLBC.Checked = ((Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer))
            chkSpeex.Checked = ((Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer))
            chkGSM.Checked = ((Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer))

            cboColorScheme.SelectedIndex = Settings.[Default].ColorScheme

            If cboInput.Items.Count > 0 Then
                cboInput.SelectedIndex = cboInput.FindString(Settings.[Default].Input)
            End If

            If cboOutput.Items.Count > 0 Then
                cboOutput.SelectedIndex = cboOutput.FindString(Settings.[Default].Output)
            End If

            If cboRing.Items.Count > 0 Then
                cboRing.SelectedIndex = cboRing.FindString(Settings.[Default].Ring)

            End If
        End If
    End Sub
    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click

        '----- Check config params!
        If (txtUser.Text = [String].Empty) OrElse (txtHost.Text = [String].Empty) Then
            MessageBox.Show("Configuración de red inválida - Usuario o Host")
            tabpanConfig.SelectedTab = tabNetwork
            Return
        End If

        If Not (rbG711Alaw.Checked OrElse rbG711Ulaw.Checked OrElse rbGSM.Checked OrElse rbiLBC.Checked OrElse rbSpeex.Checked) Then
            MessageBox.Show("Configuración de Codec inválida - Preferred")
            tabpanConfig.SelectedTab = tabNetwork
            Return
        End If

        If Not (chkG711Alaw.Checked OrElse chkG711Ulaw.Checked OrElse chkGSM.Checked OrElse chkiLBC.Checked OrElse chkSpeex.Checked) Then
            MessageBox.Show("Configuración de Codec inválida - Allowed")
            tabpanConfig.SelectedTab = tabNetwork
            Return
        End If

        If (cboInput.SelectedIndex = -1) OrElse (cboOutput.SelectedIndex = -1) OrElse (cboRing.SelectedIndex = -1) Then
            MessageBox.Show("Configuración de dispositivos de audio inválidas")
            tabpanConfig.SelectedTab = tabAudio
            Return
        End If

        Try

            '----- guardo las configuraciones si todo esta OK - esto se debe automatizar!!!!!!
            Settings.[Default].User = txtUser.Text
            Settings.[Default].Password = Convert.ToBase64String(Encoding.[Default].GetBytes(txtPassword.Text))
            Settings.[Default].Host = txtHost.Text
            Settings.[Default].CallerIdName = txtCallerIdName.Text
            Settings.[Default].CallerIdNumber = txtCallerIdNumber.Text
            Settings.[Default].Registration = chkRegistration.Checked
            Settings.[Default].ColorScheme = cboColorScheme.SelectedIndex

            '----- Preferred!
            If rbG711Alaw.Checked Then
                Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer)
            End If

            If rbG711Ulaw.Checked Then
                Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer)
            End If

            If rbGSM.Checked Then
                Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer)
            End If

            If rbiLBC.Checked Then
                Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer)
            End If

            If rbSpeex.Checked Then
                Settings.[Default].Preferred = DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer)
            End If

            '----- Allowed!
            If chkG711Alaw.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer)
            Else

                If (Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor DirectCast(AudioFormat.afIAXC_FORMAT_ALAW, Integer)

                End If
            End If

            If chkG711Ulaw.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer)
            Else
                If (Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor DirectCast(AudioFormat.afIAXC_FORMAT_ULAW, Integer)
                End If
            End If

            If chkGSM.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer)
            Else
                If (Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor DirectCast(AudioFormat.afIAXC_FORMAT_GSM, Integer)
                End If
            End If

            If chkiLBC.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer)
            Else
                If (Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor DirectCast(AudioFormat.afIAXC_FORMAT_ILBC, Integer)
                End If
            End If

            If chkSpeex.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer)
            Else
                If (Settings.[Default].Allowed And DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer)) = DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor DirectCast(AudioFormat.afIAXC_FORMAT_SPEEX, Integer)
                End If
            End If

            '----- Audio devices!
            Settings.[Default].Input = (DirectCast(cboInput.SelectedItem, IAXAudioDevice)).Name
            Settings.[Default].Output = (DirectCast(cboOutput.SelectedItem, IAXAudioDevice)).Name
            Settings.[Default].Ring = (DirectCast(cboRing.SelectedItem, IAXAudioDevice)).Name

            '----- Save!
            Settings.[Default].ConfigStatus = 1

            Settings.[Default].Save()
        Catch
            MessageBox.Show("Error de configuraciones")
        End Try

        DialogResult = DialogResult.OK

    End Sub
    Private Sub cboColorScheme_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim color As Color = GetColorFromScheme((DirectCast(sender, ComboBox)).SelectedIndex)
        panCommands.BackColor = color
    End Sub

End Class