Imports System
Imports System.Text
Imports System.Drawing
Imports System.Configuration
Imports System.Windows.Forms

Imports ALAZ.SystemEx.WindowsEx.FormEx
Imports ALAZ.SystemEx.RunTimeEx.InteropServicesEx
Imports ALAZ.TelephonyEx.Voip.IAX

'Imports SharpIAX

Public Class FrmAdminLlamados
    Dim iaxc As ALAZ.TelephonyEx.Voip.IAX.IAXClientClass

    '---------------Falta el FrmMain 

    '----- Events
    Sub iaxc_OnAudioLevel(input As Integer, output As Integer)
        '----- Audio level eventNot 
        progressLevelInput.Value = input
        progressLevelOutput.Value = output
    End Sub
    Sub iaxc_OnTextState(lineNumber As Integer, textType As TextType, text As String)
        '----- Text eventNot 
        txtStatus.Text = text
    End Sub
    Sub iaxc_OnLineState(lineNumber As Integer)

        '----- Line state eventNot 
        Select Case iaxc.Lines.SelectedLine

            Case 0
                If True Then
                    cmdLine1.ForeColor = Color.Lime
                    cmdLine2.ForeColor = Color.White
                    Exit Select
                End If

            Case 1
                If True Then
                    cmdLine1.ForeColor = Color.White
                    cmdLine2.ForeColor = Color.Lime
                    Exit Select
                End If

        End Select

        '----- Adjust line event componentsNot 
        Dim labelNumber As Label = Nothing
        Dim labelStatus As Label = Nothing
        Dim labelDirection As Label = Nothing
        Dim labelTime As Label = Nothing
        Select Case lineNumber
            Case 0
                If True Then
                    labelNumber = lblNumber1
                    labelStatus = lblStatus1
                    labelDirection = lblCallDirection1
                    labelTime = lblTime1
                    Exit Select
                End If
            Case 1
                If True Then
                    labelNumber = lblNumber2
                    labelStatus = lblStatus2
                    labelDirection = lblCallDirection2
                    labelTime = lblTime2
                    Exit Select
                End If
        End Select

        '----- Número remoto 
        Dim remote As String = iaxc.Lines(lineNumber).Remote
        If remote = String.Empty Then
            labelNumber.Text = "0"

        Else
            labelNumber.Text = remote

        End If

        '----- Estado de llamadaNot 
        labelStatus.Text = iaxc.Lines(lineNumber).CallStatus.ToString().Substring(2)

        If iaxc.Lines(lineNumber).Active Then
            '----- Llamada domicilioNot 
            labelDirection.Text = iaxc.Lines(lineNumber).CallDirection.ToString().Substring(2)

        Else
            '----- Duración de llamadaNot 
            labelTime.Text = "00:00"
            labelDirection.Text = String.Empty

        End If

        '----- Modificar el estado de los botonesNot 
        cmdCall.Enabled = iaxc.Lines(iaxc.Lines.SelectedLine).Active = False
        cmdHangup.Enabled = iaxc.Lines(iaxc.Lines.SelectedLine).Active = True
        cmdPickUp.Enabled = cmdHangup.Enabled AndAlso (iaxc.Lines(iaxc.Lines.SelectedLine).CallStatus = CallStatus.csRinging AndAlso iaxc.Lines(iaxc.Lines.SelectedLine).CallDirection = CallDirection.cdIncoming)
        cmdTransfer.Enabled = cmdHangup.Enabled AndAlso iaxc.Lines(iaxc.Lines.SelectedLine).CallStatus = CallStatus.csComplete

        If iaxc.Lines(lineNumber).CallStatus = CallStatus.csRinging Then
            '----- Popup
            Show()
            WindowState = FormWindowState.Normal

        End If


    End Sub
    Sub iaxc_OnRegistration()
        If iaxc.RegistrationRequired Then

            '----- Si el registro se requiere el estado de registro de verificaciónNot 
            If iaxc.RegistrationStatus = RegistrationStatus.rsCompleted Then
                txtStatus.Text = "Listo"
                panCommands.Enabled = True
                txtDial.Enabled = True

            Else
                txtStatus.Text = "Error de registracion"
                panCommands.Enabled = False
                txtDial.Enabled = False

            End If

        End If

    End Sub
    Private Sub FrmAdminLlamados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        timTime.Enabled = True
        '----- Crea el objeto IAXClientNot 
        iaxc = New IAXClientClass(AudioType.atAUDIO_INTERNAL_PA, 2)

        '----- Verifica las propiedades
        If Settings.Default.ConfigStatus = -1 Then
            txtStatus.Text = "Configuracion inválida"
            cmdConfig.Enabled = True
        Else
            '----- InicializaNot 
            InitializeVisual()
            InitilizeIAX()
        End If
        Refresh()
    End Sub
    Private Sub InitializeVisual()
        Dim color As Color = FrmConfigPhone.GetColorFromScheme(Settings.Default.ColorScheme)
        BackColor = color
    End Sub

    Private Sub InitilizeIAX()
        'error
        'iaxc.OnRegistration += New OnRegistrationDelegate(iaxc_OnRegistration)
        'iaxc.OnAudioLevel += New OnAudioLevelDelegate(iaxc_OnAudioLevel)
        'iaxc.OnLineState += New OnLineStateDelegate(iaxc_OnLineState)
        'iaxc.OnTextState += New OnTextStateDelegate(iaxc_OnTextState)
        'error

        '----- Inicializa con 2 líneas
        iaxc.CallerIdName = Settings.Default.CallerIdName
        iaxc.CallerIdNumber = Settings.Default.CallerIdNumber
        iaxc.Initialize(Settings.Default.User, Encoding.Default.GetString(Convert.FromBase64String(Settings.Default.Password)), Settings.Default.Host, Settings.Default.Registration)
        '----- Inicializa formatos
        iaxc.PreferredFormat = AudioFormat.afIAXC_FORMAT_GSM
        iaxc.AllowedFormats = AudioFormat.afIAXC_FORMAT_GSM
        '----- Inicializa dispositivos de audio
        iaxc.AudioDevices.SelectInputAudioDevice(1)
        iaxc.AudioDevices.SelectOutPutAudioDevice(3)
        iaxc.AudioDevices.SelectOutPutAudioDevice(3)
        '----- Ajuste de usuario y estado de los mensajes de registro
        lblUser.Text = iaxc.User
        If iaxc.RegistrationRequired Then
            txtStatus.Text = "Inicializando..."

        Else
            txtStatus.Text = "Listo"
            panCommands.Enabled = True
            txtDial.Enabled = True

        End If

    End Sub
    Private Sub cmdHangup_Click(sender As System.Object, e As System.EventArgs) Handles cmdHangup.Click
        '----- Finaliza la llamada seleccionada
        iaxc.Lines(iaxc.Lines.SelectedLine).DropCall()
    End Sub
    Private Sub cmdDropCall_Click(sender As Object, e As EventArgs)
        '----- Finaliza la llamada seleccionadaNot 
        iaxc.Lines(iaxc.Lines.SelectedLine).DropCall()

    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs)
        '----- Apaga el IAXClient cuando se cierraNot 
        iaxc.ShutDown()
        e.Cancel = False
    End Sub
    Private Sub txtDial_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                '---- Inicia una nueva llamada si se presiona <ENTER>Not 
                If txtDial.Text.Length > 0 Then
                    iaxc.Lines(iaxc.Lines.SelectedLine).MakeCall(txtDial.Text.Trim())
                    txtDial.Text = String.Empty
                End If
        End Select
    End Sub
    Private Sub cmdLine1_Click(sender As System.Object, e As System.EventArgs) Handles cmdLine1.Click
        '----- Selecciona la línea 
        Dim line As Integer = Convert.ToInt32((CType(sender, Button)).Tag)
        iaxc.Lines.SelectLine(line)
    End Sub
    Private Sub cmdLine2_Click(sender As System.Object, e As System.EventArgs) Handles cmdLine2.Click
        '----- Selecciona la línea 
        Dim line As Integer = Convert.ToInt32((CType(sender, Button)).Tag)
        iaxc.Lines.SelectLine(line)
    End Sub
    Private Sub cmdCall_Click(sender As System.Object, e As System.EventArgs) Handles cmdCall.Click
        '----- Inicia una nueva llamadaNot 
        If txtDial.Text.Length > 0 Then
            iaxc.Lines(iaxc.Lines.SelectedLine).MakeCall(txtDial.Text.Trim())

            txtDial.Text = String.Empty

        End If
    End Sub
    Private Sub cmdConfig_Click(sender As System.Object, e As System.EventArgs) Handles cmdConfig.Click
        Using config As New FrmConfigPhone(iaxc)

            Dim configStatus As Integer = Settings.Default.ConfigStatus
            '----- Muestra el formulario ConfigNot 
            Dim result As DialogResult = config.ShowDialog()
            If result = DialogResult.OK AndAlso (configStatus = -1) AndAlso (Settings.Default.ConfigStatus = 1) Then
                '----- Inicializa si se presiona OKNot 
                InitilizeIAX()

            End If

            InitializeVisual()

        End Using
    End Sub
    Private Sub cmdPickUp_Click(sender As System.Object, e As System.EventArgs) Handles cmdPickUp.Click
        '----- Atiende la llamada entranteNot 
        iaxc.Lines(iaxc.Lines.SelectedLine).AnswerCall()
    End Sub
    Private Sub FrmAdminLlamados_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        '----- Oculta en la bandejaNot 
        If WindowState = FormWindowState.Minimized Then
            Hide()
        End If
    End Sub
    Private Sub cmdDigit1_Click(sender As System.Object, e As System.EventArgs) Handles cmdDigit1.Click
        Dim digit As Byte = Convert.ToByte((CType(sender, Button)).Text(0))
        iaxc.PlayDigit(digit)

        If iaxc.Lines(iaxc.Lines.SelectedLine).Active Then

            '----- Obtiene la tecla numéricaNot 
            'byte digit = Convert.ToByte(((Button)sender).Text[0]);
            iaxc.Lines(iaxc.Lines.SelectedLine).SendDTMF(digit)

        Else
            '---- Llena el textbox "dial"Not 
            txtDial.Text += (CType(sender, Button)).Text(0)

        End If
    End Sub

    Private Sub cmdTransfer_Click(sender As System.Object, e As System.EventArgs) Handles cmdTransfer.Click
        iaxc.Lines(iaxc.Lines.SelectedLine).TransferCall(txtDial.Text.Trim())
    End Sub
End Class