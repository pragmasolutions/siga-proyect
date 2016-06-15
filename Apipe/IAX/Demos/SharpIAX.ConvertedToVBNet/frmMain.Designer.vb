Partial Class frmMain
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.timTime = New System.Windows.Forms.Timer(Me.components)
		Me.lblUser = New System.Windows.Forms.Label()
		Me.lblTime = New System.Windows.Forms.Label()
		Me.panLcd = New System.Windows.Forms.Panel()
		Me.panMain = New System.Windows.Forms.Panel()
		Me.progressLevelOutput = New System.Windows.Forms.ProgressBar()
		Me.progressLevelInput = New System.Windows.Forms.ProgressBar()
		Me.panDial = New System.Windows.Forms.Panel()
		Me.txtDial = New System.Windows.Forms.TextBox()
		Me.txtStatus = New System.Windows.Forms.TextBox()
		Me.cmdConfig = New System.Windows.Forms.Button()
		Me.panCommands = New System.Windows.Forms.Panel()
		Me.cmdTransfer = New System.Windows.Forms.Button()
		Me.cmdCall = New System.Windows.Forms.Button()
		Me.cmdHangup = New System.Windows.Forms.Button()
		Me.cmdPickUp = New System.Windows.Forms.Button()
		Me.cmdDigit0 = New System.Windows.Forms.Button()
		Me.cmdDigitSharp = New System.Windows.Forms.Button()
		Me.cmdDigitAsterisk = New System.Windows.Forms.Button()
		Me.cmdDigit8 = New System.Windows.Forms.Button()
		Me.cmdDigit9 = New System.Windows.Forms.Button()
		Me.cmdDigit7 = New System.Windows.Forms.Button()
		Me.cmdDigit5 = New System.Windows.Forms.Button()
		Me.cmdDigit6 = New System.Windows.Forms.Button()
		Me.cmdDigit4 = New System.Windows.Forms.Button()
		Me.cmdDigit2 = New System.Windows.Forms.Button()
		Me.cmdDigit3 = New System.Windows.Forms.Button()
		Me.cmdDigit1 = New System.Windows.Forms.Button()
		Me.cmdLine2 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.lblTime2 = New System.Windows.Forms.Label()
		Me.lblCallDirection2 = New System.Windows.Forms.Label()
		Me.lblNumber2 = New System.Windows.Forms.Label()
		Me.lblStatus2 = New System.Windows.Forms.Label()
		Me.cmdLine1 = New System.Windows.Forms.Button()
		Me.panLine1 = New System.Windows.Forms.Panel()
		Me.lblTime1 = New System.Windows.Forms.Label()
		Me.lblCallDirection1 = New System.Windows.Forms.Label()
		Me.lblNumber1 = New System.Windows.Forms.Label()
		Me.lblStatus1 = New System.Windows.Forms.Label()
		Me.notifyMain = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.panLcd.SuspendLayout()
		Me.panMain.SuspendLayout()
		Me.panDial.SuspendLayout()
		Me.panCommands.SuspendLayout()
		Me.panel2.SuspendLayout()
		Me.panLine1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' timTime
		' 
		Me.timTime.Interval = 1000
		AddHandler Me.timTime.Tick, New System.EventHandler(AddressOf Me.timTime_Tick)
		' 
		' lblUser
		' 
		Me.lblUser.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblUser.ForeColor = System.Drawing.Color.Black
		Me.lblUser.Location = New System.Drawing.Point(3, 4)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(88, 23)
		Me.lblUser.TabIndex = 10
		Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' lblTime
		' 
		Me.lblTime.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblTime.ForeColor = System.Drawing.Color.Black
		Me.lblTime.Location = New System.Drawing.Point(98, 4)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(72, 23)
		Me.lblTime.TabIndex = 13
		Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' panLcd
		' 
		Me.panLcd.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.panLcd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panLcd.Controls.Add(Me.panMain)
		Me.panLcd.Location = New System.Drawing.Point(22, 7)
		Me.panLcd.Name = "panLcd"
		Me.panLcd.Size = New System.Drawing.Size(184, 124)
		Me.panLcd.TabIndex = 8
		' 
		' panMain
		' 
		Me.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panMain.Controls.Add(Me.progressLevelOutput)
		Me.panMain.Controls.Add(Me.progressLevelInput)
		Me.panMain.Controls.Add(Me.panDial)
		Me.panMain.Controls.Add(Me.txtStatus)
		Me.panMain.Controls.Add(Me.lblTime)
		Me.panMain.Controls.Add(Me.lblUser)
		Me.panMain.Location = New System.Drawing.Point(2, 2)
		Me.panMain.Name = "panMain"
		Me.panMain.Size = New System.Drawing.Size(176, 116)
		Me.panMain.TabIndex = 0
		' 
		' progressLevelOutput
		' 
		Me.progressLevelOutput.Location = New System.Drawing.Point(87, 105)
		Me.progressLevelOutput.Name = "progressLevelOutput"
		Me.progressLevelOutput.Size = New System.Drawing.Size(85, 8)
		Me.progressLevelOutput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.progressLevelOutput.TabIndex = 16
		' 
		' progressLevelInput
		' 
		Me.progressLevelInput.Location = New System.Drawing.Point(1, 105)
		Me.progressLevelInput.Name = "progressLevelInput"
		Me.progressLevelInput.Size = New System.Drawing.Size(85, 8)
		Me.progressLevelInput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.progressLevelInput.TabIndex = 15
		' 
		' panDial
		' 
		Me.panDial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panDial.Controls.Add(Me.txtDial)
		Me.panDial.Font = New System.Drawing.Font("Tahoma", 8F)
		Me.panDial.Location = New System.Drawing.Point(-1, 32)
		Me.panDial.Name = "panDial"
		Me.panDial.Size = New System.Drawing.Size(176, 27)
		Me.panDial.TabIndex = 1
		' 
		' txtDial
		' 
		Me.txtDial.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.txtDial.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDial.Enabled = False
		Me.txtDial.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.txtDial.Location = New System.Drawing.Point(3, 4)
		Me.txtDial.Name = "txtDial"
		Me.txtDial.Size = New System.Drawing.Size(167, 16)
		Me.txtDial.TabIndex = 0
		AddHandler Me.txtDial.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.txtDial_KeyDown)
		' 
		' txtStatus
		' 
		Me.txtStatus.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.txtStatus.Location = New System.Drawing.Point(3, 61)
		Me.txtStatus.Multiline = True
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.[ReadOnly] = True
		Me.txtStatus.Size = New System.Drawing.Size(167, 39)
		Me.txtStatus.TabIndex = 14
		Me.txtStatus.TabStop = False
		Me.txtStatus.Text = "Wait..."
		' 
		' cmdConfig
		' 
		Me.cmdConfig.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdConfig.ForeColor = System.Drawing.Color.White
		Me.cmdConfig.Location = New System.Drawing.Point(7, 7)
		Me.cmdConfig.Name = "cmdConfig"
		Me.cmdConfig.Size = New System.Drawing.Size(14, 124)
		Me.cmdConfig.TabIndex = 20
		Me.cmdConfig.Text = "Configl"
		Me.cmdConfig.UseVisualStyleBackColor = True
		AddHandler Me.cmdConfig.Click, New System.EventHandler(AddressOf Me.cmdConfig_Click)
		' 
		' panCommands
		' 
		Me.panCommands.Controls.Add(Me.cmdTransfer)
		Me.panCommands.Controls.Add(Me.cmdCall)
		Me.panCommands.Controls.Add(Me.cmdHangup)
		Me.panCommands.Controls.Add(Me.cmdPickUp)
		Me.panCommands.Controls.Add(Me.cmdDigit0)
		Me.panCommands.Controls.Add(Me.cmdDigitSharp)
		Me.panCommands.Controls.Add(Me.cmdDigitAsterisk)
		Me.panCommands.Controls.Add(Me.cmdDigit8)
		Me.panCommands.Controls.Add(Me.cmdDigit9)
		Me.panCommands.Controls.Add(Me.cmdDigit7)
		Me.panCommands.Controls.Add(Me.cmdDigit5)
		Me.panCommands.Controls.Add(Me.cmdDigit6)
		Me.panCommands.Controls.Add(Me.cmdDigit4)
		Me.panCommands.Controls.Add(Me.cmdDigit2)
		Me.panCommands.Controls.Add(Me.cmdDigit3)
		Me.panCommands.Controls.Add(Me.cmdDigit1)
		Me.panCommands.Controls.Add(Me.cmdLine2)
		Me.panCommands.Controls.Add(Me.panel2)
		Me.panCommands.Controls.Add(Me.cmdLine1)
		Me.panCommands.Controls.Add(Me.panLine1)
		Me.panCommands.Enabled = False
		Me.panCommands.ForeColor = System.Drawing.SystemColors.ControlText
		Me.panCommands.Location = New System.Drawing.Point(0, 133)
		Me.panCommands.Name = "panCommands"
		Me.panCommands.Size = New System.Drawing.Size(209, 253)
		Me.panCommands.TabIndex = 21
		' 
		' cmdTransfer
		' 
		Me.cmdTransfer.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdTransfer.ForeColor = System.Drawing.Color.White
		Me.cmdTransfer.Location = New System.Drawing.Point(108, 119)
		Me.cmdTransfer.Name = "cmdTransfer"
		Me.cmdTransfer.Size = New System.Drawing.Size(98, 23)
		Me.cmdTransfer.TabIndex = 48
		Me.cmdTransfer.Text = "Transfer"
		Me.cmdTransfer.UseVisualStyleBackColor = True
		AddHandler Me.cmdTransfer.Click, New System.EventHandler(AddressOf Me.cmdTransfer_Click)
		' 
		' cmdCall
		' 
		Me.cmdCall.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdCall.ForeColor = System.Drawing.Color.White
		Me.cmdCall.Location = New System.Drawing.Point(7, 93)
		Me.cmdCall.Name = "cmdCall"
		Me.cmdCall.Size = New System.Drawing.Size(98, 23)
		Me.cmdCall.TabIndex = 47
		Me.cmdCall.Text = "Call"
		Me.cmdCall.UseVisualStyleBackColor = True
		AddHandler Me.cmdCall.Click, New System.EventHandler(AddressOf Me.cmdCall_Click)
		' 
		' cmdHangup
		' 
		Me.cmdHangup.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdHangup.ForeColor = System.Drawing.Color.White
		Me.cmdHangup.Location = New System.Drawing.Point(108, 93)
		Me.cmdHangup.Name = "cmdHangup"
		Me.cmdHangup.Size = New System.Drawing.Size(98, 23)
		Me.cmdHangup.TabIndex = 46
		Me.cmdHangup.Text = "Hangup"
		Me.cmdHangup.UseVisualStyleBackColor = True
		AddHandler Me.cmdHangup.Click, New System.EventHandler(AddressOf Me.cmdDropCall_Click)
		' 
		' cmdPickUp
		' 
		Me.cmdPickUp.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdPickUp.ForeColor = System.Drawing.Color.White
		Me.cmdPickUp.Location = New System.Drawing.Point(7, 119)
		Me.cmdPickUp.Name = "cmdPickUp"
		Me.cmdPickUp.Size = New System.Drawing.Size(98, 23)
		Me.cmdPickUp.TabIndex = 45
		Me.cmdPickUp.Text = "Pickup"
		Me.cmdPickUp.UseVisualStyleBackColor = True
		AddHandler Me.cmdPickUp.Click, New System.EventHandler(AddressOf Me.cmdPickUp_Click)
		' 
		' cmdDigit0
		' 
		Me.cmdDigit0.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit0.ForeColor = System.Drawing.Color.White
		Me.cmdDigit0.Location = New System.Drawing.Point(74, 227)
		Me.cmdDigit0.Name = "cmdDigit0"
		Me.cmdDigit0.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit0.TabIndex = 44
		Me.cmdDigit0.Text = "0"
		Me.cmdDigit0.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit0.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigitSharp
		' 
		Me.cmdDigitSharp.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigitSharp.ForeColor = System.Drawing.Color.White
		Me.cmdDigitSharp.Location = New System.Drawing.Point(142, 227)
		Me.cmdDigitSharp.Name = "cmdDigitSharp"
		Me.cmdDigitSharp.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigitSharp.TabIndex = 43
		Me.cmdDigitSharp.Text = "#"
		Me.cmdDigitSharp.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigitSharp.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigitAsterisk
		' 
		Me.cmdDigitAsterisk.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigitAsterisk.ForeColor = System.Drawing.Color.White
		Me.cmdDigitAsterisk.Location = New System.Drawing.Point(7, 227)
		Me.cmdDigitAsterisk.Name = "cmdDigitAsterisk"
		Me.cmdDigitAsterisk.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigitAsterisk.TabIndex = 42
		Me.cmdDigitAsterisk.Text = "*"
		Me.cmdDigitAsterisk.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigitAsterisk.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit8
		' 
		Me.cmdDigit8.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit8.ForeColor = System.Drawing.Color.White
		Me.cmdDigit8.Location = New System.Drawing.Point(74, 200)
		Me.cmdDigit8.Name = "cmdDigit8"
		Me.cmdDigit8.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit8.TabIndex = 41
		Me.cmdDigit8.Text = "8"
		Me.cmdDigit8.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit8.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit9
		' 
		Me.cmdDigit9.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit9.ForeColor = System.Drawing.Color.White
		Me.cmdDigit9.Location = New System.Drawing.Point(142, 200)
		Me.cmdDigit9.Name = "cmdDigit9"
		Me.cmdDigit9.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit9.TabIndex = 40
		Me.cmdDigit9.Text = "9"
		Me.cmdDigit9.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit9.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit7
		' 
		Me.cmdDigit7.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit7.ForeColor = System.Drawing.Color.White
		Me.cmdDigit7.Location = New System.Drawing.Point(7, 200)
		Me.cmdDigit7.Name = "cmdDigit7"
		Me.cmdDigit7.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit7.TabIndex = 39
		Me.cmdDigit7.Text = "7"
		Me.cmdDigit7.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit7.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit5
		' 
		Me.cmdDigit5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit5.ForeColor = System.Drawing.Color.White
		Me.cmdDigit5.Location = New System.Drawing.Point(74, 173)
		Me.cmdDigit5.Name = "cmdDigit5"
		Me.cmdDigit5.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit5.TabIndex = 38
		Me.cmdDigit5.Text = "5"
		Me.cmdDigit5.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit5.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit6
		' 
		Me.cmdDigit6.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit6.ForeColor = System.Drawing.Color.White
		Me.cmdDigit6.Location = New System.Drawing.Point(142, 173)
		Me.cmdDigit6.Name = "cmdDigit6"
		Me.cmdDigit6.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit6.TabIndex = 37
		Me.cmdDigit6.Text = "6"
		Me.cmdDigit6.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit6.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit4
		' 
		Me.cmdDigit4.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit4.ForeColor = System.Drawing.Color.White
		Me.cmdDigit4.Location = New System.Drawing.Point(7, 173)
		Me.cmdDigit4.Name = "cmdDigit4"
		Me.cmdDigit4.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit4.TabIndex = 36
		Me.cmdDigit4.Text = "4"
		Me.cmdDigit4.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit4.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit2
		' 
		Me.cmdDigit2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit2.ForeColor = System.Drawing.Color.White
		Me.cmdDigit2.Location = New System.Drawing.Point(74, 146)
		Me.cmdDigit2.Name = "cmdDigit2"
		Me.cmdDigit2.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit2.TabIndex = 35
		Me.cmdDigit2.Text = "2"
		Me.cmdDigit2.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit2.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit3
		' 
		Me.cmdDigit3.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit3.ForeColor = System.Drawing.Color.White
		Me.cmdDigit3.Location = New System.Drawing.Point(142, 146)
		Me.cmdDigit3.Name = "cmdDigit3"
		Me.cmdDigit3.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit3.TabIndex = 34
		Me.cmdDigit3.Text = "3"
		Me.cmdDigit3.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit3.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdDigit1
		' 
		Me.cmdDigit1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdDigit1.ForeColor = System.Drawing.Color.White
		Me.cmdDigit1.Location = New System.Drawing.Point(7, 146)
		Me.cmdDigit1.Name = "cmdDigit1"
		Me.cmdDigit1.Size = New System.Drawing.Size(64, 23)
		Me.cmdDigit1.TabIndex = 33
		Me.cmdDigit1.Text = "1"
		Me.cmdDigit1.UseVisualStyleBackColor = True
		AddHandler Me.cmdDigit1.Click, New System.EventHandler(AddressOf Me.cmdDigit1_Click)
		' 
		' cmdLine2
		' 
		Me.cmdLine2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdLine2.ForeColor = System.Drawing.Color.White
		Me.cmdLine2.Location = New System.Drawing.Point(7, 46)
		Me.cmdLine2.Name = "cmdLine2"
		Me.cmdLine2.Size = New System.Drawing.Size(14, 43)
		Me.cmdLine2.TabIndex = 30
		Me.cmdLine2.Tag = "1"
		Me.cmdLine2.Text = "L2"
		Me.cmdLine2.UseVisualStyleBackColor = True
		AddHandler Me.cmdLine2.Click, New System.EventHandler(AddressOf Me.cmdLine1_Click)
		' 
		' panel2
		' 
		Me.panel2.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel2.Controls.Add(Me.lblTime2)
		Me.panel2.Controls.Add(Me.lblCallDirection2)
		Me.panel2.Controls.Add(Me.lblNumber2)
		Me.panel2.Controls.Add(Me.lblStatus2)
		Me.panel2.Location = New System.Drawing.Point(22, 46)
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
		' cmdLine1
		' 
		Me.cmdLine1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.cmdLine1.ForeColor = System.Drawing.Color.Lime
		Me.cmdLine1.Location = New System.Drawing.Point(7, 1)
		Me.cmdLine1.Name = "cmdLine1"
		Me.cmdLine1.Size = New System.Drawing.Size(14, 43)
		Me.cmdLine1.TabIndex = 28
		Me.cmdLine1.Tag = "0"
		Me.cmdLine1.Text = "L1"
		Me.cmdLine1.UseVisualStyleBackColor = True
		AddHandler Me.cmdLine1.Click, New System.EventHandler(AddressOf Me.cmdLine1_Click)
		' 
		' panLine1
		' 
		Me.panLine1.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.panLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panLine1.Controls.Add(Me.lblTime1)
		Me.panLine1.Controls.Add(Me.lblCallDirection1)
		Me.panLine1.Controls.Add(Me.lblNumber1)
		Me.panLine1.Controls.Add(Me.lblStatus1)
		Me.panLine1.Location = New System.Drawing.Point(22, 1)
		Me.panLine1.Name = "panLine1"
		Me.panLine1.Size = New System.Drawing.Size(184, 43)
		Me.panLine1.TabIndex = 27
		' 
		' lblTime1
		' 
		Me.lblTime1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblTime1.Location = New System.Drawing.Point(132, 3)
		Me.lblTime1.Name = "lblTime1"
		Me.lblTime1.Size = New System.Drawing.Size(46, 13)
		Me.lblTime1.TabIndex = 3
		Me.lblTime1.Text = "00:00"
		Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' lblCallDirection1
		' 
		Me.lblCallDirection1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblCallDirection1.Location = New System.Drawing.Point(3, 19)
		Me.lblCallDirection1.Name = "lblCallDirection1"
		Me.lblCallDirection1.Size = New System.Drawing.Size(92, 18)
		Me.lblCallDirection1.TabIndex = 2
		Me.lblCallDirection1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' lblNumber1
		' 
		Me.lblNumber1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblNumber1.Location = New System.Drawing.Point(3, 3)
		Me.lblNumber1.Name = "lblNumber1"
		Me.lblNumber1.Size = New System.Drawing.Size(130, 13)
		Me.lblNumber1.TabIndex = 1
		Me.lblNumber1.Text = "0"
		Me.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		' 
		' lblStatus1
		' 
		Me.lblStatus1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lblStatus1.Location = New System.Drawing.Point(99, 19)
		Me.lblStatus1.Name = "lblStatus1"
		Me.lblStatus1.Size = New System.Drawing.Size(79, 18)
		Me.lblStatus1.TabIndex = 0
		Me.lblStatus1.Text = "None"
		Me.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' notifyMain
		' 
		Me.notifyMain.Icon = DirectCast(resources.GetObject("notifyMain.Icon"), System.Drawing.Icon)
		Me.notifyMain.Text = "IAXClient"
		Me.notifyMain.Visible = True
		AddHandler Me.notifyMain.DoubleClick, New System.EventHandler(AddressOf Me.notifyMain_DoubleClick)
		' 
		' frmMain
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.ClientSize = New System.Drawing.Size(212, 387)
		Me.Controls.Add(Me.panCommands)
		Me.Controls.Add(Me.cmdConfig)
		Me.Controls.Add(Me.panLcd)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SharpIAX"
		AddHandler Me.Resize, New System.EventHandler(AddressOf Me.frmMain_Resize)
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
		Me.panLcd.ResumeLayout(False)
		Me.panMain.ResumeLayout(False)
		Me.panMain.PerformLayout()
		Me.panDial.ResumeLayout(False)
		Me.panDial.PerformLayout()
		Me.panCommands.ResumeLayout(False)
		Me.panel2.ResumeLayout(False)
		Me.panLine1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private timTime As System.Windows.Forms.Timer
	Private lblTime As System.Windows.Forms.Label
	Private lblUser As System.Windows.Forms.Label
	Private panLcd As System.Windows.Forms.Panel
	Private cmdConfig As System.Windows.Forms.Button
	Private panDial As System.Windows.Forms.Panel
	Private panMain As System.Windows.Forms.Panel
	Private panCommands As System.Windows.Forms.Panel
	Private cmdLine2 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private lblTime2 As System.Windows.Forms.Label
	Private lblCallDirection2 As System.Windows.Forms.Label
	Private lblNumber2 As System.Windows.Forms.Label
	Private lblStatus2 As System.Windows.Forms.Label
	Private cmdLine1 As System.Windows.Forms.Button
	Private panLine1 As System.Windows.Forms.Panel
	Private lblTime1 As System.Windows.Forms.Label
	Private lblCallDirection1 As System.Windows.Forms.Label
	Private lblNumber1 As System.Windows.Forms.Label
	Private lblStatus1 As System.Windows.Forms.Label
	Private notifyMain As System.Windows.Forms.NotifyIcon
	Private cmdDigit0 As System.Windows.Forms.Button
	Private cmdDigitSharp As System.Windows.Forms.Button
	Private cmdDigitAsterisk As System.Windows.Forms.Button
	Private cmdDigit8 As System.Windows.Forms.Button
	Private cmdDigit9 As System.Windows.Forms.Button
	Private cmdDigit7 As System.Windows.Forms.Button
	Private cmdDigit5 As System.Windows.Forms.Button
	Private cmdDigit6 As System.Windows.Forms.Button
	Private cmdDigit4 As System.Windows.Forms.Button
	Private cmdDigit2 As System.Windows.Forms.Button
	Private cmdDigit3 As System.Windows.Forms.Button
	Private cmdDigit1 As System.Windows.Forms.Button
	Private cmdTransfer As System.Windows.Forms.Button
	Private cmdCall As System.Windows.Forms.Button
	Private cmdHangup As System.Windows.Forms.Button
	Private cmdPickUp As System.Windows.Forms.Button
	Private txtDial As System.Windows.Forms.TextBox
	Private txtStatus As System.Windows.Forms.TextBox
	Private progressLevelInput As System.Windows.Forms.ProgressBar
	Private progressLevelOutput As System.Windows.Forms.ProgressBar

End Class

