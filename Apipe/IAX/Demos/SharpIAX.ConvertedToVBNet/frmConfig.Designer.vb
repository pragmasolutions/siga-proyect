Partial Class frmConfig
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
		Me.grbNetwork = New System.Windows.Forms.GroupBox()
		Me.lblCallerIdNumber = New System.Windows.Forms.Label()
		Me.txtCallerIdNumber = New System.Windows.Forms.TextBox()
		Me.lblCallerIdName = New System.Windows.Forms.Label()
		Me.txtCallerIdName = New System.Windows.Forms.TextBox()
		Me.chkRegistration = New System.Windows.Forms.CheckBox()
		Me.lblHost = New System.Windows.Forms.Label()
		Me.txtHost = New System.Windows.Forms.TextBox()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.lblUser = New System.Windows.Forms.Label()
		Me.txtUser = New System.Windows.Forms.TextBox()
		Me.cmdOk = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.tabpanConfig = New System.Windows.Forms.TabControl()
		Me.tabNetwork = New System.Windows.Forms.TabPage()
		Me.grbCodecs = New System.Windows.Forms.GroupBox()
		Me.grbAllowed = New System.Windows.Forms.GroupBox()
		Me.chkSpeex = New System.Windows.Forms.CheckBox()
		Me.chkiLBC = New System.Windows.Forms.CheckBox()
		Me.chkGSM = New System.Windows.Forms.CheckBox()
		Me.chkG711Alaw = New System.Windows.Forms.CheckBox()
		Me.chkG711Ulaw = New System.Windows.Forms.CheckBox()
		Me.grbPreferred = New System.Windows.Forms.GroupBox()
		Me.rbSpeex = New System.Windows.Forms.RadioButton()
		Me.rbiLBC = New System.Windows.Forms.RadioButton()
		Me.rbG711Alaw = New System.Windows.Forms.RadioButton()
		Me.rbG711Ulaw = New System.Windows.Forms.RadioButton()
		Me.rbGSM = New System.Windows.Forms.RadioButton()
		Me.tabAudio = New System.Windows.Forms.TabPage()
		Me.grbAudioDevices = New System.Windows.Forms.GroupBox()
		Me.cboRing = New System.Windows.Forms.ComboBox()
		Me.lblRingDevice = New System.Windows.Forms.Label()
		Me.cboOutput = New System.Windows.Forms.ComboBox()
		Me.lblOutputDevice = New System.Windows.Forms.Label()
		Me.cboInput = New System.Windows.Forms.ComboBox()
		Me.lblInputDevice = New System.Windows.Forms.Label()
		Me.tabCredits = New System.Windows.Forms.TabPage()
		Me.lblIAX = New System.Windows.Forms.Label()
		Me.lblSharpIAX = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.tabVisual = New System.Windows.Forms.TabPage()
		Me.grbAppearance = New System.Windows.Forms.GroupBox()
		Me.cboColorScheme = New System.Windows.Forms.ComboBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.panCommands = New System.Windows.Forms.Panel()
		Me.cmdCall = New System.Windows.Forms.Button()
		Me.cmdHangup = New System.Windows.Forms.Button()
		Me.cmdLine2 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.lblTime2 = New System.Windows.Forms.Label()
		Me.lblCallDirection2 = New System.Windows.Forms.Label()
		Me.lblNumber2 = New System.Windows.Forms.Label()
		Me.lblStatus2 = New System.Windows.Forms.Label()
		Me.grbNetwork.SuspendLayout()
		Me.tabpanConfig.SuspendLayout()
		Me.tabNetwork.SuspendLayout()
		Me.grbCodecs.SuspendLayout()
		Me.grbAllowed.SuspendLayout()
		Me.grbPreferred.SuspendLayout()
		Me.tabAudio.SuspendLayout()
		Me.grbAudioDevices.SuspendLayout()
		Me.tabCredits.SuspendLayout()
		Me.tabVisual.SuspendLayout()
		Me.grbAppearance.SuspendLayout()
		Me.panCommands.SuspendLayout()
		Me.panel2.SuspendLayout()
		Me.SuspendLayout()
		' 
		' grbNetwork
		' 
		Me.grbNetwork.Controls.Add(Me.lblCallerIdNumber)
		Me.grbNetwork.Controls.Add(Me.txtCallerIdNumber)
		Me.grbNetwork.Controls.Add(Me.lblCallerIdName)
		Me.grbNetwork.Controls.Add(Me.txtCallerIdName)
		Me.grbNetwork.Controls.Add(Me.chkRegistration)
		Me.grbNetwork.Controls.Add(Me.lblHost)
		Me.grbNetwork.Controls.Add(Me.txtHost)
		Me.grbNetwork.Controls.Add(Me.lblPassword)
		Me.grbNetwork.Controls.Add(Me.txtPassword)
		Me.grbNetwork.Controls.Add(Me.lblUser)
		Me.grbNetwork.Controls.Add(Me.txtUser)
		Me.grbNetwork.Location = New System.Drawing.Point(6, 6)
		Me.grbNetwork.Name = "grbNetwork"
		Me.grbNetwork.Size = New System.Drawing.Size(352, 110)
		Me.grbNetwork.TabIndex = 0
		Me.grbNetwork.TabStop = False
		Me.grbNetwork.Text = "Network"
		' 
		' lblCallerIdNumber
		' 
		Me.lblCallerIdNumber.AutoSize = True
		Me.lblCallerIdNumber.Location = New System.Drawing.Point(120, 62)
		Me.lblCallerIdNumber.Name = "lblCallerIdNumber"
		Me.lblCallerIdNumber.Size = New System.Drawing.Size(87, 13)
		Me.lblCallerIdNumber.TabIndex = 17
		Me.lblCallerIdNumber.Text = "Caller Id Number"
		' 
		' txtCallerIdNumber
		' 
		Me.txtCallerIdNumber.Location = New System.Drawing.Point(123, 78)
		Me.txtCallerIdNumber.Name = "txtCallerIdNumber"
		Me.txtCallerIdNumber.Size = New System.Drawing.Size(105, 21)
		Me.txtCallerIdNumber.TabIndex = 16
		' 
		' lblCallerIdName
		' 
		Me.lblCallerIdName.AutoSize = True
		Me.lblCallerIdName.Location = New System.Drawing.Point(9, 62)
		Me.lblCallerIdName.Name = "lblCallerIdName"
		Me.lblCallerIdName.Size = New System.Drawing.Size(77, 13)
		Me.lblCallerIdName.TabIndex = 15
		Me.lblCallerIdName.Text = "Caller Id Name"
		' 
		' txtCallerIdName
		' 
		Me.txtCallerIdName.Location = New System.Drawing.Point(12, 78)
		Me.txtCallerIdName.Name = "txtCallerIdName"
		Me.txtCallerIdName.Size = New System.Drawing.Size(105, 21)
		Me.txtCallerIdName.TabIndex = 14
		' 
		' chkRegistration
		' 
		Me.chkRegistration.AutoSize = True
		Me.chkRegistration.Location = New System.Drawing.Point(249, 79)
		Me.chkRegistration.Name = "chkRegistration"
		Me.chkRegistration.Size = New System.Drawing.Size(84, 17)
		Me.chkRegistration.TabIndex = 13
		Me.chkRegistration.Text = "Registration"
		Me.chkRegistration.UseVisualStyleBackColor = True
		' 
		' lblHost
		' 
		Me.lblHost.AutoSize = True
		Me.lblHost.Location = New System.Drawing.Point(231, 19)
		Me.lblHost.Name = "lblHost"
		Me.lblHost.Size = New System.Drawing.Size(29, 13)
		Me.lblHost.TabIndex = 12
		Me.lblHost.Text = "Host"
		' 
		' txtHost
		' 
		Me.txtHost.Location = New System.Drawing.Point(234, 35)
		Me.txtHost.Name = "txtHost"
		Me.txtHost.Size = New System.Drawing.Size(105, 21)
		Me.txtHost.TabIndex = 11
		' 
		' lblPassword
		' 
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(120, 19)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(53, 13)
		Me.lblPassword.TabIndex = 10
		Me.lblPassword.Text = "Password"
		' 
		' txtPassword
		' 
		Me.txtPassword.Location = New System.Drawing.Point(123, 35)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = "*"C
		Me.txtPassword.ShortcutsEnabled = False
		Me.txtPassword.Size = New System.Drawing.Size(105, 21)
		Me.txtPassword.TabIndex = 9
		' 
		' lblUser
		' 
		Me.lblUser.AutoSize = True
		Me.lblUser.Location = New System.Drawing.Point(9, 19)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(29, 13)
		Me.lblUser.TabIndex = 8
		Me.lblUser.Text = "User"
		' 
		' txtUser
		' 
		Me.txtUser.Location = New System.Drawing.Point(12, 35)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(105, 21)
		Me.txtUser.TabIndex = 7
		' 
		' cmdOk
		' 
		Me.cmdOk.Location = New System.Drawing.Point(222, 333)
		Me.cmdOk.Name = "cmdOk"
		Me.cmdOk.Size = New System.Drawing.Size(75, 23)
		Me.cmdOk.TabIndex = 1
		Me.cmdOk.Text = "&Ok"
		Me.cmdOk.UseVisualStyleBackColor = True
		AddHandler Me.cmdOk.Click, New System.EventHandler(AddressOf Me.cmdOk_Click)
		' 
		' button2
		' 
		Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.button2.Location = New System.Drawing.Point(303, 333)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 2
		Me.button2.Text = "&Cancel"
		Me.button2.UseVisualStyleBackColor = True
		' 
		' tabpanConfig
		' 
		Me.tabpanConfig.Controls.Add(Me.tabNetwork)
		Me.tabpanConfig.Controls.Add(Me.tabAudio)
		Me.tabpanConfig.Controls.Add(Me.tabVisual)
		Me.tabpanConfig.Controls.Add(Me.tabCredits)
		Me.tabpanConfig.Location = New System.Drawing.Point(6, 8)
		Me.tabpanConfig.Name = "tabpanConfig"
		Me.tabpanConfig.SelectedIndex = 0
		Me.tabpanConfig.Size = New System.Drawing.Size(372, 319)
		Me.tabpanConfig.TabIndex = 3
		' 
		' tabNetwork
		' 
		Me.tabNetwork.Controls.Add(Me.grbCodecs)
		Me.tabNetwork.Controls.Add(Me.grbNetwork)
		Me.tabNetwork.Location = New System.Drawing.Point(4, 22)
		Me.tabNetwork.Name = "tabNetwork"
		Me.tabNetwork.Padding = New System.Windows.Forms.Padding(3)
		Me.tabNetwork.Size = New System.Drawing.Size(364, 293)
		Me.tabNetwork.TabIndex = 0
		Me.tabNetwork.Text = "Network"
		Me.tabNetwork.UseVisualStyleBackColor = True
		' 
		' grbCodecs
		' 
		Me.grbCodecs.Controls.Add(Me.grbAllowed)
		Me.grbCodecs.Controls.Add(Me.grbPreferred)
		Me.grbCodecs.Location = New System.Drawing.Point(6, 119)
		Me.grbCodecs.Name = "grbCodecs"
		Me.grbCodecs.Size = New System.Drawing.Size(352, 170)
		Me.grbCodecs.TabIndex = 1
		Me.grbCodecs.TabStop = False
		Me.grbCodecs.Text = "Codecs"
		' 
		' grbAllowed
		' 
		Me.grbAllowed.Controls.Add(Me.chkSpeex)
		Me.grbAllowed.Controls.Add(Me.chkiLBC)
		Me.grbAllowed.Controls.Add(Me.chkGSM)
		Me.grbAllowed.Controls.Add(Me.chkG711Alaw)
		Me.grbAllowed.Controls.Add(Me.chkG711Ulaw)
		Me.grbAllowed.Location = New System.Drawing.Point(9, 92)
		Me.grbAllowed.Name = "grbAllowed"
		Me.grbAllowed.Size = New System.Drawing.Size(337, 69)
		Me.grbAllowed.TabIndex = 1
		Me.grbAllowed.TabStop = False
		Me.grbAllowed.Text = "Allowed"
		' 
		' chkSpeex
		' 
		Me.chkSpeex.AutoSize = True
		Me.chkSpeex.Location = New System.Drawing.Point(194, 19)
		Me.chkSpeex.Name = "chkSpeex"
		Me.chkSpeex.Size = New System.Drawing.Size(56, 17)
		Me.chkSpeex.TabIndex = 4
		Me.chkSpeex.Text = "Speex"
		Me.chkSpeex.UseVisualStyleBackColor = True
		' 
		' chkiLBC
		' 
		Me.chkiLBC.AutoSize = True
		Me.chkiLBC.Location = New System.Drawing.Point(116, 43)
		Me.chkiLBC.Name = "chkiLBC"
		Me.chkiLBC.Size = New System.Drawing.Size(46, 17)
		Me.chkiLBC.TabIndex = 3
		Me.chkiLBC.Text = "iLBC"
		Me.chkiLBC.UseVisualStyleBackColor = True
		' 
		' chkGSM
		' 
		Me.chkGSM.AutoSize = True
		Me.chkGSM.Location = New System.Drawing.Point(116, 19)
		Me.chkGSM.Name = "chkGSM"
		Me.chkGSM.Size = New System.Drawing.Size(47, 17)
		Me.chkGSM.TabIndex = 2
		Me.chkGSM.Text = "GSM"
		Me.chkGSM.UseVisualStyleBackColor = True
		' 
		' chkG711Alaw
		' 
		Me.chkG711Alaw.AutoSize = True
		Me.chkG711Alaw.Location = New System.Drawing.Point(15, 43)
		Me.chkG711Alaw.Name = "chkG711Alaw"
		Me.chkG711Alaw.Size = New System.Drawing.Size(81, 17)
		Me.chkG711Alaw.TabIndex = 1
		Me.chkG711Alaw.Text = "G.711 Alaw"
		Me.chkG711Alaw.UseVisualStyleBackColor = True
		' 
		' chkG711Ulaw
		' 
		Me.chkG711Ulaw.AutoSize = True
		Me.chkG711Ulaw.Location = New System.Drawing.Point(15, 20)
		Me.chkG711Ulaw.Name = "chkG711Ulaw"
		Me.chkG711Ulaw.Size = New System.Drawing.Size(81, 17)
		Me.chkG711Ulaw.TabIndex = 0
		Me.chkG711Ulaw.Text = "G.711 Ulaw"
		Me.chkG711Ulaw.UseVisualStyleBackColor = True
		' 
		' grbPreferred
		' 
		Me.grbPreferred.Controls.Add(Me.rbSpeex)
		Me.grbPreferred.Controls.Add(Me.rbiLBC)
		Me.grbPreferred.Controls.Add(Me.rbG711Alaw)
		Me.grbPreferred.Controls.Add(Me.rbG711Ulaw)
		Me.grbPreferred.Controls.Add(Me.rbGSM)
		Me.grbPreferred.Location = New System.Drawing.Point(9, 20)
		Me.grbPreferred.Name = "grbPreferred"
		Me.grbPreferred.Size = New System.Drawing.Size(337, 69)
		Me.grbPreferred.TabIndex = 0
		Me.grbPreferred.TabStop = False
		Me.grbPreferred.Text = "Preferred"
		' 
		' rbSpeex
		' 
		Me.rbSpeex.AutoSize = True
		Me.rbSpeex.Location = New System.Drawing.Point(194, 20)
		Me.rbSpeex.Name = "rbSpeex"
		Me.rbSpeex.Size = New System.Drawing.Size(55, 17)
		Me.rbSpeex.TabIndex = 4
		Me.rbSpeex.Text = "Speex"
		Me.rbSpeex.UseVisualStyleBackColor = True
		' 
		' rbiLBC
		' 
		Me.rbiLBC.AutoSize = True
		Me.rbiLBC.Location = New System.Drawing.Point(116, 43)
		Me.rbiLBC.Name = "rbiLBC"
		Me.rbiLBC.Size = New System.Drawing.Size(45, 17)
		Me.rbiLBC.TabIndex = 3
		Me.rbiLBC.Text = "iLBC"
		Me.rbiLBC.UseVisualStyleBackColor = True
		' 
		' rbG711Alaw
		' 
		Me.rbG711Alaw.AutoSize = True
		Me.rbG711Alaw.Location = New System.Drawing.Point(15, 43)
		Me.rbG711Alaw.Name = "rbG711Alaw"
		Me.rbG711Alaw.Size = New System.Drawing.Size(80, 17)
		Me.rbG711Alaw.TabIndex = 2
		Me.rbG711Alaw.Text = "G.711 Alaw"
		Me.rbG711Alaw.UseVisualStyleBackColor = True
		' 
		' rbG711Ulaw
		' 
		Me.rbG711Ulaw.AutoSize = True
		Me.rbG711Ulaw.Location = New System.Drawing.Point(15, 20)
		Me.rbG711Ulaw.Name = "rbG711Ulaw"
		Me.rbG711Ulaw.Size = New System.Drawing.Size(80, 17)
		Me.rbG711Ulaw.TabIndex = 1
		Me.rbG711Ulaw.Text = "G.711 Ulaw"
		Me.rbG711Ulaw.UseVisualStyleBackColor = True
		' 
		' rbGSM
		' 
		Me.rbGSM.AutoSize = True
		Me.rbGSM.Location = New System.Drawing.Point(116, 20)
		Me.rbGSM.Name = "rbGSM"
		Me.rbGSM.Size = New System.Drawing.Size(46, 17)
		Me.rbGSM.TabIndex = 0
		Me.rbGSM.Text = "GSM"
		Me.rbGSM.UseVisualStyleBackColor = True
		' 
		' tabAudio
		' 
		Me.tabAudio.Controls.Add(Me.grbAudioDevices)
		Me.tabAudio.Location = New System.Drawing.Point(4, 22)
		Me.tabAudio.Name = "tabAudio"
		Me.tabAudio.Padding = New System.Windows.Forms.Padding(3)
		Me.tabAudio.Size = New System.Drawing.Size(364, 293)
		Me.tabAudio.TabIndex = 1
		Me.tabAudio.Text = "Audio"
		Me.tabAudio.UseVisualStyleBackColor = True
		' 
		' grbAudioDevices
		' 
		Me.grbAudioDevices.Controls.Add(Me.cboRing)
		Me.grbAudioDevices.Controls.Add(Me.lblRingDevice)
		Me.grbAudioDevices.Controls.Add(Me.cboOutput)
		Me.grbAudioDevices.Controls.Add(Me.lblOutputDevice)
		Me.grbAudioDevices.Controls.Add(Me.cboInput)
		Me.grbAudioDevices.Controls.Add(Me.lblInputDevice)
		Me.grbAudioDevices.Location = New System.Drawing.Point(6, 6)
		Me.grbAudioDevices.Name = "grbAudioDevices"
		Me.grbAudioDevices.Size = New System.Drawing.Size(352, 150)
		Me.grbAudioDevices.TabIndex = 1
		Me.grbAudioDevices.TabStop = False
		Me.grbAudioDevices.Text = "Audio Devices"
		' 
		' cboRing
		' 
		Me.cboRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboRing.FormattingEnabled = True
		Me.cboRing.Location = New System.Drawing.Point(12, 116)
		Me.cboRing.Name = "cboRing"
		Me.cboRing.Size = New System.Drawing.Size(304, 21)
		Me.cboRing.TabIndex = 13
		' 
		' lblRingDevice
		' 
		Me.lblRingDevice.AutoSize = True
		Me.lblRingDevice.Location = New System.Drawing.Point(9, 100)
		Me.lblRingDevice.Name = "lblRingDevice"
		Me.lblRingDevice.Size = New System.Drawing.Size(63, 13)
		Me.lblRingDevice.TabIndex = 12
		Me.lblRingDevice.Text = "Ring Device"
		' 
		' cboOutput
		' 
		Me.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboOutput.FormattingEnabled = True
		Me.cboOutput.Location = New System.Drawing.Point(12, 75)
		Me.cboOutput.Name = "cboOutput"
		Me.cboOutput.Size = New System.Drawing.Size(304, 21)
		Me.cboOutput.TabIndex = 11
		' 
		' lblOutputDevice
		' 
		Me.lblOutputDevice.AutoSize = True
		Me.lblOutputDevice.Location = New System.Drawing.Point(9, 59)
		Me.lblOutputDevice.Name = "lblOutputDevice"
		Me.lblOutputDevice.Size = New System.Drawing.Size(76, 13)
		Me.lblOutputDevice.TabIndex = 10
		Me.lblOutputDevice.Text = "Output Device"
		' 
		' cboInput
		' 
		Me.cboInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboInput.FormattingEnabled = True
		Me.cboInput.Location = New System.Drawing.Point(12, 35)
		Me.cboInput.Name = "cboInput"
		Me.cboInput.Size = New System.Drawing.Size(304, 21)
		Me.cboInput.TabIndex = 9
		' 
		' lblInputDevice
		' 
		Me.lblInputDevice.AutoSize = True
		Me.lblInputDevice.Location = New System.Drawing.Point(9, 19)
		Me.lblInputDevice.Name = "lblInputDevice"
		Me.lblInputDevice.Size = New System.Drawing.Size(68, 13)
		Me.lblInputDevice.TabIndex = 8
		Me.lblInputDevice.Text = "Input Device"
		' 
		' tabCredits
		' 
		Me.tabCredits.Controls.Add(Me.lblIAX)
		Me.tabCredits.Controls.Add(Me.lblSharpIAX)
		Me.tabCredits.Controls.Add(Me.textBox1)
		Me.tabCredits.Location = New System.Drawing.Point(4, 22)
		Me.tabCredits.Name = "tabCredits"
		Me.tabCredits.Size = New System.Drawing.Size(364, 293)
		Me.tabCredits.TabIndex = 2
		Me.tabCredits.Text = "Credits"
		Me.tabCredits.UseVisualStyleBackColor = True
		' 
		' lblIAX
		' 
		Me.lblIAX.Location = New System.Drawing.Point(4, 274)
		Me.lblIAX.Name = "lblIAX"
		Me.lblIAX.Size = New System.Drawing.Size(329, 13)
		Me.lblIAX.TabIndex = 2
		' 
		' lblSharpIAX
		' 
		Me.lblSharpIAX.Location = New System.Drawing.Point(4, 6)
		Me.lblSharpIAX.Name = "lblSharpIAX"
		Me.lblSharpIAX.Size = New System.Drawing.Size(354, 29)
		Me.lblSharpIAX.TabIndex = 1
		Me.lblSharpIAX.Text = "SharpIAX version 1.00" & vbCr & vbLf & "Copyright (r) 2006 Andre Luis Azevedo (az.andrel@yahoo.com" & ".br)"
		Me.lblSharpIAX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' textBox1
		' 
		Me.textBox1.Location = New System.Drawing.Point(3, 47)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.[ReadOnly] = True
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(355, 218)
		Me.textBox1.TabIndex = 0
		Me.textBox1.Text = resources.GetString("textBox1.Text")
		' 
		' tabVisual
		' 
		Me.tabVisual.Controls.Add(Me.grbAppearance)
		Me.tabVisual.Location = New System.Drawing.Point(4, 22)
		Me.tabVisual.Name = "tabVisual"
		Me.tabVisual.Padding = New System.Windows.Forms.Padding(3)
		Me.tabVisual.Size = New System.Drawing.Size(364, 293)
		Me.tabVisual.TabIndex = 3
		Me.tabVisual.Text = "Visual"
		Me.tabVisual.UseVisualStyleBackColor = True
		' 
		' grbAppearance
		' 
		Me.grbAppearance.Controls.Add(Me.panCommands)
		Me.grbAppearance.Controls.Add(Me.cboColorScheme)
		Me.grbAppearance.Controls.Add(Me.label3)
		Me.grbAppearance.Location = New System.Drawing.Point(6, 6)
		Me.grbAppearance.Name = "grbAppearance"
		Me.grbAppearance.Size = New System.Drawing.Size(352, 281)
		Me.grbAppearance.TabIndex = 2
		Me.grbAppearance.TabStop = False
		Me.grbAppearance.Text = "Appearance"
		' 
		' cboColorScheme
		' 
		Me.cboColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboColorScheme.FormattingEnabled = True
		Me.cboColorScheme.Items.AddRange(New Object() {"SharpIAX", "Back in Black", "Deep Blue", "HellBoy", "Ladies Room", "The Garden"})
		Me.cboColorScheme.Location = New System.Drawing.Point(12, 35)
		Me.cboColorScheme.Name = "cboColorScheme"
		Me.cboColorScheme.Size = New System.Drawing.Size(304, 21)
		Me.cboColorScheme.TabIndex = 9
		AddHandler Me.cboColorScheme.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboColorScheme_SelectedIndexChanged)
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(9, 19)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(72, 13)
		Me.label3.TabIndex = 8
		Me.label3.Text = "Color Scheme"
		' 
		' panCommands
		' 
		Me.panCommands.BackColor = System.Drawing.Color.DarkGray
		Me.panCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panCommands.Controls.Add(Me.cmdCall)
		Me.panCommands.Controls.Add(Me.cmdHangup)
		Me.panCommands.Controls.Add(Me.cmdLine2)
		Me.panCommands.Controls.Add(Me.panel2)
		Me.panCommands.ForeColor = System.Drawing.SystemColors.ControlText
		Me.panCommands.Location = New System.Drawing.Point(12, 62)
		Me.panCommands.Name = "panCommands"
		Me.panCommands.Size = New System.Drawing.Size(304, 91)
		Me.panCommands.TabIndex = 22
		' 
		' cmdCall
		' 
		Me.cmdCall.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdCall.ForeColor = System.Drawing.Color.White
		Me.cmdCall.Location = New System.Drawing.Point(7, 61)
		Me.cmdCall.Name = "cmdCall"
		Me.cmdCall.Size = New System.Drawing.Size(98, 23)
		Me.cmdCall.TabIndex = 47
		Me.cmdCall.Text = "Call"
		Me.cmdCall.UseVisualStyleBackColor = True
		' 
		' cmdHangup
		' 
		Me.cmdHangup.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdHangup.ForeColor = System.Drawing.Color.White
		Me.cmdHangup.Location = New System.Drawing.Point(108, 61)
		Me.cmdHangup.Name = "cmdHangup"
		Me.cmdHangup.Size = New System.Drawing.Size(98, 23)
		Me.cmdHangup.TabIndex = 46
		Me.cmdHangup.Text = "Hangup"
		Me.cmdHangup.UseVisualStyleBackColor = True
		' 
		' cmdLine2
		' 
		Me.cmdLine2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdLine2.ForeColor = System.Drawing.Color.Lime
		Me.cmdLine2.Location = New System.Drawing.Point(7, 13)
		Me.cmdLine2.Name = "cmdLine2"
		Me.cmdLine2.Size = New System.Drawing.Size(14, 43)
		Me.cmdLine2.TabIndex = 30
		Me.cmdLine2.Tag = "1"
		Me.cmdLine2.Text = "L2"
		Me.cmdLine2.UseVisualStyleBackColor = True
		' 
		' panel2
		' 
		Me.panel2.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel2.Controls.Add(Me.lblTime2)
		Me.panel2.Controls.Add(Me.lblCallDirection2)
		Me.panel2.Controls.Add(Me.lblNumber2)
		Me.panel2.Controls.Add(Me.lblStatus2)
		Me.panel2.Location = New System.Drawing.Point(22, 13)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(184, 43)
		Me.panel2.TabIndex = 29
		' 
		' lblTime2
		' 
		Me.lblTime2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblTime2.Location = New System.Drawing.Point(132, 3)
		Me.lblTime2.Name = "lblTime2"
		Me.lblTime2.Size = New System.Drawing.Size(46, 13)
		Me.lblTime2.TabIndex = 4
		Me.lblTime2.Text = "00:00"
		Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' lblCallDirection2
		' 
		Me.lblCallDirection2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblCallDirection2.Location = New System.Drawing.Point(3, 19)
		Me.lblCallDirection2.Name = "lblCallDirection2"
		Me.lblCallDirection2.Size = New System.Drawing.Size(92, 18)
		Me.lblCallDirection2.TabIndex = 3
		Me.lblCallDirection2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' lblNumber2
		' 
		Me.lblNumber2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblNumber2.Location = New System.Drawing.Point(3, 3)
		Me.lblNumber2.Name = "lblNumber2"
		Me.lblNumber2.Size = New System.Drawing.Size(130, 13)
		Me.lblNumber2.TabIndex = 1
		Me.lblNumber2.Text = "0"
		Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' lblStatus2
		' 
		Me.lblStatus2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblStatus2.Location = New System.Drawing.Point(99, 19)
		Me.lblStatus2.Name = "lblStatus2"
		Me.lblStatus2.Size = New System.Drawing.Size(79, 18)
		Me.lblStatus2.TabIndex = 0
		Me.lblStatus2.Text = "None"
		Me.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' frmConfig
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(383, 361)
		Me.Controls.Add(Me.tabpanConfig)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.cmdOk)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmConfig"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SharpIAX Config"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmConfig_Load)
		Me.grbNetwork.ResumeLayout(False)
		Me.grbNetwork.PerformLayout()
		Me.tabpanConfig.ResumeLayout(False)
		Me.tabNetwork.ResumeLayout(False)
		Me.grbCodecs.ResumeLayout(False)
		Me.grbAllowed.ResumeLayout(False)
		Me.grbAllowed.PerformLayout()
		Me.grbPreferred.ResumeLayout(False)
		Me.grbPreferred.PerformLayout()
		Me.tabAudio.ResumeLayout(False)
		Me.grbAudioDevices.ResumeLayout(False)
		Me.grbAudioDevices.PerformLayout()
		Me.tabCredits.ResumeLayout(False)
		Me.tabCredits.PerformLayout()
		Me.tabVisual.ResumeLayout(False)
		Me.grbAppearance.ResumeLayout(False)
		Me.grbAppearance.PerformLayout()
		Me.panCommands.ResumeLayout(False)
		Me.panel2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private grbNetwork As System.Windows.Forms.GroupBox
	Private chkRegistration As System.Windows.Forms.CheckBox
	Private lblHost As System.Windows.Forms.Label
	Private txtHost As System.Windows.Forms.TextBox
	Private lblPassword As System.Windows.Forms.Label
	Private txtPassword As System.Windows.Forms.TextBox
	Private lblUser As System.Windows.Forms.Label
	Private txtUser As System.Windows.Forms.TextBox
	Private cmdOk As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private tabpanConfig As System.Windows.Forms.TabControl
	Private tabNetwork As System.Windows.Forms.TabPage
	Private tabAudio As System.Windows.Forms.TabPage
	Private tabCredits As System.Windows.Forms.TabPage
	Private textBox1 As System.Windows.Forms.TextBox
	Private grbCodecs As System.Windows.Forms.GroupBox
	Private grbPreferred As System.Windows.Forms.GroupBox
	Private rbG711Ulaw As System.Windows.Forms.RadioButton
	Private rbGSM As System.Windows.Forms.RadioButton
	Private rbiLBC As System.Windows.Forms.RadioButton
	Private rbG711Alaw As System.Windows.Forms.RadioButton
	Private grbAllowed As System.Windows.Forms.GroupBox
	Private rbSpeex As System.Windows.Forms.RadioButton
	Private chkG711Ulaw As System.Windows.Forms.CheckBox
	Private chkSpeex As System.Windows.Forms.CheckBox
	Private chkiLBC As System.Windows.Forms.CheckBox
	Private chkGSM As System.Windows.Forms.CheckBox
	Private chkG711Alaw As System.Windows.Forms.CheckBox
	Private grbAudioDevices As System.Windows.Forms.GroupBox
	Private cboRing As System.Windows.Forms.ComboBox
	Private lblRingDevice As System.Windows.Forms.Label
	Private cboOutput As System.Windows.Forms.ComboBox
	Private lblOutputDevice As System.Windows.Forms.Label
	Private cboInput As System.Windows.Forms.ComboBox
	Private lblInputDevice As System.Windows.Forms.Label
	Private lblSharpIAX As System.Windows.Forms.Label
	Private lblIAX As System.Windows.Forms.Label
	Private lblCallerIdNumber As System.Windows.Forms.Label
	Private txtCallerIdNumber As System.Windows.Forms.TextBox
	Private lblCallerIdName As System.Windows.Forms.Label
	Private txtCallerIdName As System.Windows.Forms.TextBox
	Private tabVisual As System.Windows.Forms.TabPage
	Private grbAppearance As System.Windows.Forms.GroupBox
	Private cboColorScheme As System.Windows.Forms.ComboBox
	Private label3 As System.Windows.Forms.Label
	Private panCommands As System.Windows.Forms.Panel
	Private cmdCall As System.Windows.Forms.Button
	Private cmdHangup As System.Windows.Forms.Button
	Private cmdLine2 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private lblTime2 As System.Windows.Forms.Label
	Private lblCallDirection2 As System.Windows.Forms.Label
	Private lblNumber2 As System.Windows.Forms.Label
	Private lblStatus2 As System.Windows.Forms.Label

End Class
