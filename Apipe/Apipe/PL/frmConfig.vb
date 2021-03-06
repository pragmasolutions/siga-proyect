Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms

Imports ALAZ.TelephonyEx.Voip.IAX


Public Partial Class frmConfig
	Inherits Form

	Private iaxc As IAXClientClass

    'Public Shared Function GetColorFromScheme(colorScheme As Integer) As Color

    '	Dim color__1 As Color = Color.Transparent

    '       'Select Case colorScheme

    '       '	Case 0
    '       '		If True Then
    '       '			color__1 = Color.DarkGray
    '       '			Exit Select
    '       '		End If


    '       '	Case 1
    '       '		If True Then
    '       '			color__1 = Color.Black
    '       '			Exit Select
    '       '		End If

    '       '	Case 2
    '       '		If True Then
    '       '			color__1 = Color.SlateBlue
    '       '			Exit Select
    '       '		End If


    '       '	Case 3
    '       '		If True Then
    '       '			color__1 = Color.Crimson
    '       '			Exit Select
    '       '		End If

    '       '	Case 4
    '       '		If True Then
    '       '			color__1 = Color.LightPink
    '       '			Exit Select
    '       '		End If

    '       '	Case 5
    '       '		If True Then
    '       '			color__1 = Color.MediumSeaGreen
    '       '			Exit Select
    '       '		End If


    '       'End Select

    '       Return color__1

    '   End Function

	Public Sub New(iaxclient As IAXClientClass)

		'----- Initialize form components!
		InitializeComponent()

		iaxc = iaxclient
        'lblIAX.Text = "IAX Library Version: " & iaxc.Version

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

	Private Sub frmConfig_Load(sender As Object, e As EventArgs)

		'----- Check config status!
        If Settings.[Default].ConfigStatus = -1 Then

            '----- Load default values!
            txtUser.Text = [String].Empty
            txtPassword.Text = [String].Empty
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
            txtHost.Text = Settings.[Default].Host
            txtCallerIdName.Text = Settings.[Default].CallerIdName
            txtCallerIdNumber.Text = Settings.[Default].CallerIdNumber
            chkRegistration.Checked = Settings.[Default].Registration

            rbG711Alaw.Checked = Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_ALAW)
            rbG711Ulaw.Checked = Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_ULAW)
            rbiLBC.Checked = Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_ILBC)
            rbSpeex.Checked = Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_SPEEX)
            rbGSM.Checked = Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_GSM)

            chkG711Alaw.Checked = ((Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_ALAW)) = CInt(AudioFormat.afIAXC_FORMAT_ALAW))
            chkG711Ulaw.Checked = ((Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_ULAW)) = CInt(AudioFormat.afIAXC_FORMAT_ULAW))
            chkiLBC.Checked = ((Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_ILBC)) = CInt(AudioFormat.afIAXC_FORMAT_ILBC))
            chkSpeex.Checked = ((Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_SPEEX)) = CInt(AudioFormat.afIAXC_FORMAT_SPEEX))
            chkGSM.Checked = ((Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_GSM)) = CInt(AudioFormat.afIAXC_FORMAT_GSM))

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

    Private Sub cmdOk_Click(ByVal sender As Object, ByVal e As EventArgs)

        '----- Check config params!
        If (txtUser.Text = [String].Empty) OrElse (txtHost.Text = [String].Empty) Then
            MessageBox.Show("Invalid network settings - User or Host")
            tabpanConfig.SelectedTab = tabNetwork
            Return
        End If

        If Not (rbG711Alaw.Checked OrElse rbG711Ulaw.Checked OrElse rbGSM.Checked OrElse rbiLBC.Checked OrElse rbSpeex.Checked) Then
            MessageBox.Show("Invalid codec settings - Preferred")
            tabpanConfig.SelectedTab = tabNetwork
            Return
        End If

        If Not (chkG711Alaw.Checked OrElse chkG711Ulaw.Checked OrElse chkGSM.Checked OrElse chkiLBC.Checked OrElse chkSpeex.Checked) Then
            MessageBox.Show("Invalid codec settings - Allowed")
            tabpanConfig.SelectedTab = tabNetwork
            Return
        End If

        If (cboInput.SelectedIndex = -1) OrElse (cboOutput.SelectedIndex = -1) OrElse (cboRing.SelectedIndex = -1) Then
            MessageBox.Show("Configuración de dispositivo de audio invalida")
            tabpanConfig.SelectedTab = tabAudio
            Return
        End If

        Try

            '----- If all OK, save settings!
            Settings.[Default].User = txtUser.Text
            Settings.[Default].Password = Convert.ToBase64String(Encoding.[Default].GetBytes(txtPassword.Text))
            Settings.[Default].Host = txtHost.Text
            Settings.[Default].CallerIdName = txtCallerIdName.Text
            Settings.[Default].CallerIdNumber = txtCallerIdNumber.Text
            Settings.[Default].Registration = chkRegistration.Checked
            Settings.[Default].ColorScheme = cboColorScheme.SelectedIndex

            '----- Preferred!
            If rbG711Alaw.Checked Then
                Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_ALAW)
            End If

            If rbG711Ulaw.Checked Then
                Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_ULAW)
            End If

            If rbGSM.Checked Then
                Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_GSM)
            End If

            If rbiLBC.Checked Then
                Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_ILBC)
            End If

            If rbSpeex.Checked Then
                Settings.[Default].Preferred = CInt(AudioFormat.afIAXC_FORMAT_SPEEX)
            End If

            '----- Allowed!
            If chkG711Alaw.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or CInt(AudioFormat.afIAXC_FORMAT_ALAW)
            Else

                If (Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_ALAW)) = CInt(AudioFormat.afIAXC_FORMAT_ALAW) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor CInt(AudioFormat.afIAXC_FORMAT_ALAW)

                End If
            End If

            If chkG711Ulaw.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or CInt(AudioFormat.afIAXC_FORMAT_ULAW)
            Else
                If (Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_ULAW)) = CInt(AudioFormat.afIAXC_FORMAT_ULAW) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor CInt(AudioFormat.afIAXC_FORMAT_ULAW)
                End If
            End If

            If chkGSM.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or CInt(AudioFormat.afIAXC_FORMAT_GSM)
            Else
                If (Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_GSM)) = CInt(AudioFormat.afIAXC_FORMAT_GSM) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor CInt(AudioFormat.afIAXC_FORMAT_GSM)
                End If
            End If

            If chkiLBC.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or CInt(AudioFormat.afIAXC_FORMAT_ILBC)
            Else
                If (Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_ILBC)) = CInt(AudioFormat.afIAXC_FORMAT_ILBC) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor CInt(AudioFormat.afIAXC_FORMAT_ILBC)
                End If
            End If

            If chkSpeex.Checked Then
                Settings.[Default].Allowed = Settings.[Default].Allowed Or CInt(AudioFormat.afIAXC_FORMAT_SPEEX)
            Else
                If (Settings.[Default].Allowed And CInt(AudioFormat.afIAXC_FORMAT_SPEEX)) = CInt(AudioFormat.afIAXC_FORMAT_SPEEX) Then
                    Settings.[Default].Allowed = Settings.[Default].Allowed Xor CInt(AudioFormat.afIAXC_FORMAT_SPEEX)
                End If
            End If

            '----- Audio devices!
            Settings.[Default].Input = DirectCast(cboInput.SelectedItem, IAXAudioDevice).Name
            Settings.[Default].Output = DirectCast(cboOutput.SelectedItem, IAXAudioDevice).Name
            Settings.[Default].Ring = DirectCast(cboRing.SelectedItem, IAXAudioDevice).Name

            '----- Save!
            Settings.[Default].ConfigStatus = 1

            Settings.[Default].Save()
        Catch
            MessageBox.Show("Error de configuración")
        End Try

        DialogResult = DialogResult.OK

    End Sub

    'Private Sub cboColorScheme_SelectedIndexChanged(sender As Object, e As EventArgs)
    '	Dim color As Color = GetColorFromScheme(DirectCast(sender, ComboBox).SelectedIndex)
    '	panCommands.BackColor = color
    'End Sub

End Class
