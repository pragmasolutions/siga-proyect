' ====================================================================
' * Copyright (c) 2006 Andre Luis Azevedo (az.andrel@yahoo.com.br)
' * All rights reserved.
' *                       
' * Redistribution and use in source and binary forms, with or without
' * modification, are permitted provided that the following conditions
' * are met:
' *
' * 1. Redistributions of source code must retain the above copyright
' *    notice, this list of conditions and the following disclaimer. 
' *
' * 2. Redistributions in binary form must reproduce the above copyright
' *    notice, this list of conditions and the following disclaimer in
' *    the documentation and/or other materials provided with the
' *    distribution.
' * 
' * 3. The name "SharpIAX" must not be used to endorse or promote 
' *    products derived from this software without prior written permission.
' *
' * 4. Products derived from this software may not be called "SharpIAX" nor 
' *    may "SharpIAX" appear in their names without prior written 
' *    permission of the author.
' * 
' * THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY
' * EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
' * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
' * PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR
' * ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
' * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
' * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
' * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
' * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
' * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
' * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
' * OF THE POSSIBILITY OF SUCH DAMAGE. 
' 


Imports System.Text
Imports System.Drawing
Imports System.Configuration
Imports System.Windows.Forms

Imports ALAZ.SystemEx.WindowsEx.FormEx
Imports ALAZ.SystemEx.RunTimeEx.InteropServicesEx
Imports ALAZ.TelephonyEx.Voip.IAX

Imports SharpIAX


Public Partial Class frmMain
	Inherits Form

	'----- Iax client!
	Public iaxc As IAXClientClass

	Public Sub New()
		InitializeComponent()
	End Sub

	'----- Events
	Private Sub iaxc_OnAudioLevel(input As Integer, output As Integer)
		'----- Audio level event!
		progressLevelInput.Value = input
		progressLevelOutput.Value = output
	End Sub

	Private Sub iaxc_OnTextState(lineNumber As Integer, textType As TextType, text As String)
		'----- Text event!
		txtStatus.Text = text
	End Sub

	Private Sub iaxc_OnLineState(lineNumber As Integer)

		'----- Line state event!

		'----- Adjust select line button!
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

		'----- Adjust line event components!
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

		'----- Remote number!
		Dim remote As String = iaxc.Lines(lineNumber).Remote

		If remote = [String].Empty Then
			labelNumber.Text = "0"
		Else
			labelNumber.Text = remote
		End If

		'----- Call status!
		labelStatus.Text = iaxc.Lines(lineNumber).CallStatus.ToString().Substring(2)


		If iaxc.Lines(lineNumber).Active Then
			'----- Call direction!
			labelDirection.Text = iaxc.Lines(lineNumber).CallDirection.ToString().Substring(2)
		Else
			'----- Call time!
			labelTime.Text = "00:00"
			labelDirection.Text = [String].Empty
		End If

		'----- Adjust buttons state!
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


	Private Sub iaxc_OnRegistration()

		If iaxc.RegistrationRequired Then

			'----- If registration required check registration status!
			If iaxc.RegistrationStatus = RegistrationStatus.rsCompleted Then
				txtStatus.Text = "Ready"
				panCommands.Enabled = True
				txtDial.Enabled = True
			Else
				txtStatus.Text = "Registration Error"
				panCommands.Enabled = False
				txtDial.Enabled = False
			End If
		End If
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs)

		timTime.Enabled = True

		'----- Create IAXClient object!
		iaxc = New IAXClientClass(AudioType.atAUDIO_INTERNAL_PA, 2)

		'----- Verify properties!
		If Properties.Settings.[Default].ConfigStatus = -1 Then
			txtStatus.Text = "Invalid Configuration"
			cmdConfig.Enabled = True
		Else
			'----- Initilize!
			InitializeVisual()
			InitilizeIAX()
		End If

		Refresh()

	End Sub

	Private Sub InitializeVisual()
		Dim color As Color = frmConfig.GetColorFromScheme(Properties.Settings.[Default].ColorScheme)
		BackColor = color
	End Sub

	Private Sub InitilizeIAX()

		AddHandler iaxc.OnRegistration, New OnRegistrationDelegate(AddressOf iaxc_OnRegistration)
		AddHandler iaxc.OnAudioLevel, New OnAudioLevelDelegate(AddressOf iaxc_OnAudioLevel)
		AddHandler iaxc.OnLineState, New OnLineStateDelegate(AddressOf iaxc_OnLineState)
		AddHandler iaxc.OnTextState, New OnTextStateDelegate(AddressOf iaxc_OnTextState)

		'----- Initialize with 2 lines!
		iaxc.CallerIdName = Properties.Settings.[Default].CallerIdName
		iaxc.CallerIdNumber = Properties.Settings.[Default].CallerIdNumber
		iaxc.Initialize(Properties.Settings.[Default].User, Encoding.[Default].GetString(Convert.FromBase64String(Properties.Settings.[Default].Password)), Properties.Settings.[Default].Host, Properties.Settings.[Default].Registration)

		'----- Initialize formats!
		iaxc.PreferredFormat = AudioFormat.afIAXC_FORMAT_GSM
		iaxc.AllowedFormats = AudioFormat.afIAXC_FORMAT_GSM

		'----- Initialize audio devices!
		iaxc.AudioDevices.SelectInputAudioDevice(1)
		iaxc.AudioDevices.SelectOutPutAudioDevice(3)
		iaxc.AudioDevices.SelectOutPutAudioDevice(3)

		'----- Adjust user and registration message status!
		lblUser.Text = iaxc.User

		If iaxc.RegistrationRequired Then
			txtStatus.Text = "Initializing..."
		Else
			txtStatus.Text = "Ready"
			panCommands.Enabled = True
			txtDial.Enabled = True
		End If

	End Sub

	Private Sub cmdDropCall_Click(sender As Object, e As EventArgs)
		'----- Drop selected call!
		iaxc.Lines(iaxc.Lines.SelectedLine).DropCall()
	End Sub

	Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs)
		'----- Shutdown IAXClient when closing!
		iaxc.ShutDown()
		e.Cancel = False
	End Sub

	Private Sub timTime_Tick(sender As Object, e As EventArgs)

		'----- Set datetime!
		lblTime.Text = DateTime.Now.ToShortTimeString()

		If iaxc IsNot Nothing AndAlso iaxc.Lines.Count > 0 Then

			For Each l As IAXLine In iaxc.Lines

				If l.Active Then

					'----- If Line is active, adjust the call time!
					Dim secondsInt As Integer = l.CallTime \ 1000
					Dim minutes As Integer = secondsInt \ 60
					Dim seconds As Integer = secondsInt Mod 60
					Dim time As String = minutes.ToString("00") & ":" & seconds.ToString("00")

					Select Case l.Id

						Case 0
							lblTime1.Text = time
							Exit Select

						Case 1
							lblTime2.Text = time
							Exit Select


					End Select

				End If
			Next
		End If
	End Sub

	Private Sub txtDial_KeyDown(sender As Object, e As KeyEventArgs)

		Select Case e.KeyCode

			Case Keys.Enter
				If True Then

					'---- Starts a new call if press <ENTER>!
					If txtDial.Text.Length > 0 Then
						iaxc.Lines(iaxc.Lines.SelectedLine).MakeCall(txtDial.Text.Trim())
						txtDial.Text = [String].Empty
					End If

					Exit Select

				End If

		End Select

	End Sub

	Private Sub cmdLine1_Click(sender As Object, e As EventArgs)
		'----- Select the line!
		Dim line As Integer = Convert.ToInt32(DirectCast(sender, Button).Tag)
		iaxc.Lines.SelectLine(line)
	End Sub

	Private Sub cmdCall_Click(sender As Object, e As EventArgs)

		'----- Starts a new call!
		If txtDial.Text.Length > 0 Then
			iaxc.Lines(iaxc.Lines.SelectedLine).MakeCall(txtDial.Text.Trim())
			txtDial.Text = [String].Empty
		End If

	End Sub

	Private Sub cmdConfig_Click(sender As Object, e As EventArgs)

		Using config As New frmConfig(iaxc)

			Dim configStatus As Integer = Properties.Settings.[Default].ConfigStatus

			'----- Show config form!
			Dim result As DialogResult = config.ShowDialog()

			If result = DialogResult.OK AndAlso (configStatus = -1) AndAlso (Properties.Settings.[Default].ConfigStatus = 1) Then
				'----- Initilize if press OK!
				InitilizeIAX()
			End If


			InitializeVisual()
		End Using

	End Sub

	Private Sub cmdPickUp_Click(sender As Object, e As EventArgs)
		'----- Answer ringing call!
		iaxc.Lines(iaxc.Lines.SelectedLine).AnswerCall()
	End Sub

	Private Sub frmMain_Resize(sender As Object, e As EventArgs)
		'----- Hide to tray!
		If WindowState = FormWindowState.Minimized Then
			Hide()
		End If
	End Sub

	Private Sub notifyMain_DoubleClick(sender As Object, e As EventArgs)
		'----- Show form from tray!
		Show()
		WindowState = FormWindowState.Normal
	End Sub

	Private Sub cmdDigit1_Click(sender As Object, e As EventArgs)

		Dim digit As Byte = Convert.ToByte(DirectCast(sender, Button).Text(0))
		iaxc.PlayDigit(digit)

		If iaxc.Lines(iaxc.Lines.SelectedLine).Active Then

			'----- Get button digit!
			'byte digit = Convert.ToByte(((Button)sender).Text[0]);

			iaxc.Lines(iaxc.Lines.SelectedLine).SendDTMF(digit)
		Else
			'---- Fill dial textbox!
			txtDial.Text += DirectCast(sender, Button).Text(0)
		End If


	End Sub

	Private Sub cmdTransfer_Click(sender As Object, e As EventArgs)
		iaxc.Lines(iaxc.Lines.SelectedLine).TransferCall(txtDial.Text.Trim())
	End Sub

	Private Sub button1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub button1_Click_1(sender As Object, e As EventArgs)

	End Sub

	Private Sub button1_Click_2(sender As Object, e As EventArgs)

	End Sub

End Class

