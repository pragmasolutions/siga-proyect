<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigPhone
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigPhone))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.tabAudio = New System.Windows.Forms.TabPage()
        Me.grbAudioDevices = New System.Windows.Forms.GroupBox()
        Me.cboRing = New System.Windows.Forms.ComboBox()
        Me.lblRingDevice = New System.Windows.Forms.Label()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.lblOutputDevice = New System.Windows.Forms.Label()
        Me.cboInput = New System.Windows.Forms.ComboBox()
        Me.lblInputDevice = New System.Windows.Forms.Label()
        Me.tabVisual = New System.Windows.Forms.TabPage()
        Me.grbAppearance = New System.Windows.Forms.GroupBox()
        Me.panCommands = New System.Windows.Forms.Panel()
        Me.cmdCall = New System.Windows.Forms.Button()
        Me.cmdHangup = New System.Windows.Forms.Button()
        Me.cmdLine2 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblCallDirection2 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.cboColorScheme = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tabCredits = New System.Windows.Forms.TabPage()
        Me.lblIAX = New System.Windows.Forms.Label()
        Me.lblSharpIAX = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.tabpanConfig.SuspendLayout()
        Me.tabNetwork.SuspendLayout()
        Me.grbCodecs.SuspendLayout()
        Me.grbAllowed.SuspendLayout()
        Me.grbPreferred.SuspendLayout()
        Me.grbNetwork.SuspendLayout()
        Me.tabAudio.SuspendLayout()
        Me.grbAudioDevices.SuspendLayout()
        Me.tabVisual.SuspendLayout()
        Me.grbAppearance.SuspendLayout()
        Me.panCommands.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.tabCredits.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tabpanConfig)
        Me.Panel1.Controls.Add(Me.button2)
        Me.Panel1.Controls.Add(Me.cmdOk)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 374)
        Me.Panel1.TabIndex = 0
        '
        'tabpanConfig
        '
        Me.tabpanConfig.Controls.Add(Me.tabNetwork)
        Me.tabpanConfig.Controls.Add(Me.tabAudio)
        Me.tabpanConfig.Controls.Add(Me.tabVisual)
        Me.tabpanConfig.Controls.Add(Me.tabCredits)
        Me.tabpanConfig.Location = New System.Drawing.Point(64, 13)
        Me.tabpanConfig.Name = "tabpanConfig"
        Me.tabpanConfig.SelectedIndex = 0
        Me.tabpanConfig.Size = New System.Drawing.Size(372, 319)
        Me.tabpanConfig.TabIndex = 6
        '
        'tabNetwork
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
        'grbCodecs
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
        'grbAllowed
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
        'chkSpeex
        '
        Me.chkSpeex.AutoSize = True
        Me.chkSpeex.Location = New System.Drawing.Point(194, 19)
        Me.chkSpeex.Name = "chkSpeex"
        Me.chkSpeex.Size = New System.Drawing.Size(56, 17)
        Me.chkSpeex.TabIndex = 4
        Me.chkSpeex.Text = "Speex"
        Me.chkSpeex.UseVisualStyleBackColor = True
        '
        'chkiLBC
        '
        Me.chkiLBC.AutoSize = True
        Me.chkiLBC.Location = New System.Drawing.Point(116, 43)
        Me.chkiLBC.Name = "chkiLBC"
        Me.chkiLBC.Size = New System.Drawing.Size(48, 17)
        Me.chkiLBC.TabIndex = 3
        Me.chkiLBC.Text = "iLBC"
        Me.chkiLBC.UseVisualStyleBackColor = True
        '
        'chkGSM
        '
        Me.chkGSM.AutoSize = True
        Me.chkGSM.Location = New System.Drawing.Point(116, 19)
        Me.chkGSM.Name = "chkGSM"
        Me.chkGSM.Size = New System.Drawing.Size(50, 17)
        Me.chkGSM.TabIndex = 2
        Me.chkGSM.Text = "GSM"
        Me.chkGSM.UseVisualStyleBackColor = True
        '
        'chkG711Alaw
        '
        Me.chkG711Alaw.AutoSize = True
        Me.chkG711Alaw.Location = New System.Drawing.Point(15, 43)
        Me.chkG711Alaw.Name = "chkG711Alaw"
        Me.chkG711Alaw.Size = New System.Drawing.Size(81, 17)
        Me.chkG711Alaw.TabIndex = 1
        Me.chkG711Alaw.Text = "G.711 Alaw"
        Me.chkG711Alaw.UseVisualStyleBackColor = True
        '
        'chkG711Ulaw
        '
        Me.chkG711Ulaw.AutoSize = True
        Me.chkG711Ulaw.Location = New System.Drawing.Point(15, 20)
        Me.chkG711Ulaw.Name = "chkG711Ulaw"
        Me.chkG711Ulaw.Size = New System.Drawing.Size(82, 17)
        Me.chkG711Ulaw.TabIndex = 0
        Me.chkG711Ulaw.Text = "G.711 Ulaw"
        Me.chkG711Ulaw.UseVisualStyleBackColor = True
        '
        'grbPreferred
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
        'rbSpeex
        '
        Me.rbSpeex.AutoSize = True
        Me.rbSpeex.Location = New System.Drawing.Point(194, 20)
        Me.rbSpeex.Name = "rbSpeex"
        Me.rbSpeex.Size = New System.Drawing.Size(55, 17)
        Me.rbSpeex.TabIndex = 4
        Me.rbSpeex.Text = "Speex"
        Me.rbSpeex.UseVisualStyleBackColor = True
        '
        'rbiLBC
        '
        Me.rbiLBC.AutoSize = True
        Me.rbiLBC.Location = New System.Drawing.Point(116, 43)
        Me.rbiLBC.Name = "rbiLBC"
        Me.rbiLBC.Size = New System.Drawing.Size(47, 17)
        Me.rbiLBC.TabIndex = 3
        Me.rbiLBC.Text = "iLBC"
        Me.rbiLBC.UseVisualStyleBackColor = True
        '
        'rbG711Alaw
        '
        Me.rbG711Alaw.AutoSize = True
        Me.rbG711Alaw.Location = New System.Drawing.Point(15, 43)
        Me.rbG711Alaw.Name = "rbG711Alaw"
        Me.rbG711Alaw.Size = New System.Drawing.Size(80, 17)
        Me.rbG711Alaw.TabIndex = 2
        Me.rbG711Alaw.Text = "G.711 Alaw"
        Me.rbG711Alaw.UseVisualStyleBackColor = True
        '
        'rbG711Ulaw
        '
        Me.rbG711Ulaw.AutoSize = True
        Me.rbG711Ulaw.Location = New System.Drawing.Point(15, 20)
        Me.rbG711Ulaw.Name = "rbG711Ulaw"
        Me.rbG711Ulaw.Size = New System.Drawing.Size(81, 17)
        Me.rbG711Ulaw.TabIndex = 1
        Me.rbG711Ulaw.Text = "G.711 Ulaw"
        Me.rbG711Ulaw.UseVisualStyleBackColor = True
        '
        'rbGSM
        '
        Me.rbGSM.AutoSize = True
        Me.rbGSM.Location = New System.Drawing.Point(116, 20)
        Me.rbGSM.Name = "rbGSM"
        Me.rbGSM.Size = New System.Drawing.Size(49, 17)
        Me.rbGSM.TabIndex = 0
        Me.rbGSM.Text = "GSM"
        Me.rbGSM.UseVisualStyleBackColor = True
        '
        'grbNetwork
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
        Me.grbNetwork.Text = "Red"
        '
        'lblCallerIdNumber
        '
        Me.lblCallerIdNumber.AutoSize = True
        Me.lblCallerIdNumber.Location = New System.Drawing.Point(120, 62)
        Me.lblCallerIdNumber.Name = "lblCallerIdNumber"
        Me.lblCallerIdNumber.Size = New System.Drawing.Size(85, 13)
        Me.lblCallerIdNumber.TabIndex = 17
        Me.lblCallerIdNumber.Text = "Caller Id Number"
        '
        'txtCallerIdNumber
        '
        Me.txtCallerIdNumber.Location = New System.Drawing.Point(123, 78)
        Me.txtCallerIdNumber.Name = "txtCallerIdNumber"
        Me.txtCallerIdNumber.Size = New System.Drawing.Size(105, 20)
        Me.txtCallerIdNumber.TabIndex = 16
        '
        'lblCallerIdName
        '
        Me.lblCallerIdName.AutoSize = True
        Me.lblCallerIdName.Location = New System.Drawing.Point(9, 62)
        Me.lblCallerIdName.Name = "lblCallerIdName"
        Me.lblCallerIdName.Size = New System.Drawing.Size(76, 13)
        Me.lblCallerIdName.TabIndex = 15
        Me.lblCallerIdName.Text = "Caller Id Name"
        '
        'txtCallerIdName
        '
        Me.txtCallerIdName.Location = New System.Drawing.Point(12, 78)
        Me.txtCallerIdName.Name = "txtCallerIdName"
        Me.txtCallerIdName.Size = New System.Drawing.Size(105, 20)
        Me.txtCallerIdName.TabIndex = 14
        '
        'chkRegistration
        '
        Me.chkRegistration.AutoSize = True
        Me.chkRegistration.Location = New System.Drawing.Point(249, 79)
        Me.chkRegistration.Name = "chkRegistration"
        Me.chkRegistration.Size = New System.Drawing.Size(82, 17)
        Me.chkRegistration.TabIndex = 13
        Me.chkRegistration.Text = "Registration"
        Me.chkRegistration.UseVisualStyleBackColor = True
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(231, 19)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(29, 13)
        Me.lblHost.TabIndex = 12
        Me.lblHost.Text = "Host"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(234, 35)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(105, 20)
        Me.txtHost.TabIndex = 11
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(120, 19)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(123, 35)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(105, 20)
        Me.txtPassword.TabIndex = 9
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(9, 19)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(29, 13)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "User"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 35)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(105, 20)
        Me.txtUser.TabIndex = 7
        '
        'tabAudio
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
        'grbAudioDevices
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
        'cboRing
        '
        Me.cboRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRing.FormattingEnabled = True
        Me.cboRing.Location = New System.Drawing.Point(12, 116)
        Me.cboRing.Name = "cboRing"
        Me.cboRing.Size = New System.Drawing.Size(304, 21)
        Me.cboRing.TabIndex = 13
        '
        'lblRingDevice
        '
        Me.lblRingDevice.AutoSize = True
        Me.lblRingDevice.Location = New System.Drawing.Point(9, 100)
        Me.lblRingDevice.Name = "lblRingDevice"
        Me.lblRingDevice.Size = New System.Drawing.Size(66, 13)
        Me.lblRingDevice.TabIndex = 12
        Me.lblRingDevice.Text = "Ring Device"
        '
        'cboOutput
        '
        Me.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(12, 75)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(304, 21)
        Me.cboOutput.TabIndex = 11
        '
        'lblOutputDevice
        '
        Me.lblOutputDevice.AutoSize = True
        Me.lblOutputDevice.Location = New System.Drawing.Point(9, 59)
        Me.lblOutputDevice.Name = "lblOutputDevice"
        Me.lblOutputDevice.Size = New System.Drawing.Size(76, 13)
        Me.lblOutputDevice.TabIndex = 10
        Me.lblOutputDevice.Text = "Output Device"
        '
        'cboInput
        '
        Me.cboInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInput.FormattingEnabled = True
        Me.cboInput.Location = New System.Drawing.Point(12, 35)
        Me.cboInput.Name = "cboInput"
        Me.cboInput.Size = New System.Drawing.Size(304, 21)
        Me.cboInput.TabIndex = 9
        '
        'lblInputDevice
        '
        Me.lblInputDevice.AutoSize = True
        Me.lblInputDevice.Location = New System.Drawing.Point(9, 19)
        Me.lblInputDevice.Name = "lblInputDevice"
        Me.lblInputDevice.Size = New System.Drawing.Size(68, 13)
        Me.lblInputDevice.TabIndex = 8
        Me.lblInputDevice.Text = "Input Device"
        '
        'tabVisual
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
        'grbAppearance
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
        'panCommands
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
        'cmdCall
        '
        Me.cmdCall.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCall.ForeColor = System.Drawing.Color.White
        Me.cmdCall.Location = New System.Drawing.Point(7, 61)
        Me.cmdCall.Name = "cmdCall"
        Me.cmdCall.Size = New System.Drawing.Size(98, 23)
        Me.cmdCall.TabIndex = 47
        Me.cmdCall.Text = "Call"
        Me.cmdCall.UseVisualStyleBackColor = True
        '
        'cmdHangup
        '
        Me.cmdHangup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHangup.ForeColor = System.Drawing.Color.White
        Me.cmdHangup.Location = New System.Drawing.Point(108, 61)
        Me.cmdHangup.Name = "cmdHangup"
        Me.cmdHangup.Size = New System.Drawing.Size(98, 23)
        Me.cmdHangup.TabIndex = 46
        Me.cmdHangup.Text = "Hangup"
        Me.cmdHangup.UseVisualStyleBackColor = True
        '
        'cmdLine2
        '
        Me.cmdLine2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLine2.ForeColor = System.Drawing.Color.Lime
        Me.cmdLine2.Location = New System.Drawing.Point(7, 13)
        Me.cmdLine2.Name = "cmdLine2"
        Me.cmdLine2.Size = New System.Drawing.Size(14, 43)
        Me.cmdLine2.TabIndex = 30
        Me.cmdLine2.Tag = "1"
        Me.cmdLine2.Text = "L2"
        Me.cmdLine2.UseVisualStyleBackColor = True
        '
        'panel2
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
        'lblTime2
        '
        Me.lblTime2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(132, 3)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(46, 13)
        Me.lblTime2.TabIndex = 4
        Me.lblTime2.Text = "00:00"
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCallDirection2
        '
        Me.lblCallDirection2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallDirection2.Location = New System.Drawing.Point(3, 19)
        Me.lblCallDirection2.Name = "lblCallDirection2"
        Me.lblCallDirection2.Size = New System.Drawing.Size(92, 18)
        Me.lblCallDirection2.TabIndex = 3
        Me.lblCallDirection2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumber2
        '
        Me.lblNumber2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(3, 3)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(130, 13)
        Me.lblNumber2.TabIndex = 1
        Me.lblNumber2.Text = "0"
        Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus2
        '
        Me.lblStatus2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.Location = New System.Drawing.Point(99, 19)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(79, 18)
        Me.lblStatus2.TabIndex = 0
        Me.lblStatus2.Text = "None"
        Me.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboColorScheme
        '
        Me.cboColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColorScheme.FormattingEnabled = True
        Me.cboColorScheme.Items.AddRange(New Object() {"SharpIAX", "Back in Black", "Deep Blue", "HellBoy", "Ladies Room", "The Garden"})
        Me.cboColorScheme.Location = New System.Drawing.Point(12, 35)
        Me.cboColorScheme.Name = "cboColorScheme"
        Me.cboColorScheme.Size = New System.Drawing.Size(304, 21)
        Me.cboColorScheme.TabIndex = 9
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Color Scheme"
        '
        'tabCredits
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
        'lblIAX
        '
        Me.lblIAX.Location = New System.Drawing.Point(4, 274)
        Me.lblIAX.Name = "lblIAX"
        Me.lblIAX.Size = New System.Drawing.Size(329, 13)
        Me.lblIAX.TabIndex = 2
        '
        'lblSharpIAX
        '
        Me.lblSharpIAX.Location = New System.Drawing.Point(4, 6)
        Me.lblSharpIAX.Name = "lblSharpIAX"
        Me.lblSharpIAX.Size = New System.Drawing.Size(354, 29)
        Me.lblSharpIAX.TabIndex = 1
        Me.lblSharpIAX.Text = "SharpIAX version 1.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright (r) 2006 Andre Luis Azevedo (az.andrel@yahoo.com" & _
    ".br)"
        Me.lblSharpIAX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(3, 47)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(355, 218)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button2.Location = New System.Drawing.Point(361, 338)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 5
        Me.button2.Text = "&Cancel"
        Me.button2.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(280, 338)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmConfigPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 420)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmConfigPhone"
        Me.Text = "FrmConfigPhone"
        Me.Panel1.ResumeLayout(False)
        Me.tabpanConfig.ResumeLayout(False)
        Me.tabNetwork.ResumeLayout(False)
        Me.grbCodecs.ResumeLayout(False)
        Me.grbAllowed.ResumeLayout(False)
        Me.grbAllowed.PerformLayout()
        Me.grbPreferred.ResumeLayout(False)
        Me.grbPreferred.PerformLayout()
        Me.grbNetwork.ResumeLayout(False)
        Me.grbNetwork.PerformLayout()
        Me.tabAudio.ResumeLayout(False)
        Me.grbAudioDevices.ResumeLayout(False)
        Me.grbAudioDevices.PerformLayout()
        Me.tabVisual.ResumeLayout(False)
        Me.grbAppearance.ResumeLayout(False)
        Me.grbAppearance.PerformLayout()
        Me.panCommands.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.tabCredits.ResumeLayout(False)
        Me.tabCredits.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents tabpanConfig As System.Windows.Forms.TabControl
    Private WithEvents tabNetwork As System.Windows.Forms.TabPage
    Private WithEvents grbCodecs As System.Windows.Forms.GroupBox
    Private WithEvents grbAllowed As System.Windows.Forms.GroupBox
    Private WithEvents chkSpeex As System.Windows.Forms.CheckBox
    Private WithEvents chkiLBC As System.Windows.Forms.CheckBox
    Private WithEvents chkGSM As System.Windows.Forms.CheckBox
    Private WithEvents chkG711Alaw As System.Windows.Forms.CheckBox
    Private WithEvents chkG711Ulaw As System.Windows.Forms.CheckBox
    Private WithEvents grbPreferred As System.Windows.Forms.GroupBox
    Private WithEvents rbSpeex As System.Windows.Forms.RadioButton
    Private WithEvents rbiLBC As System.Windows.Forms.RadioButton
    Private WithEvents rbG711Alaw As System.Windows.Forms.RadioButton
    Private WithEvents rbG711Ulaw As System.Windows.Forms.RadioButton
    Private WithEvents rbGSM As System.Windows.Forms.RadioButton
    Private WithEvents grbNetwork As System.Windows.Forms.GroupBox
    Private WithEvents lblCallerIdNumber As System.Windows.Forms.Label
    Private WithEvents txtCallerIdNumber As System.Windows.Forms.TextBox
    Private WithEvents lblCallerIdName As System.Windows.Forms.Label
    Private WithEvents txtCallerIdName As System.Windows.Forms.TextBox
    Private WithEvents chkRegistration As System.Windows.Forms.CheckBox
    Private WithEvents lblHost As System.Windows.Forms.Label
    Private WithEvents txtHost As System.Windows.Forms.TextBox
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents lblUser As System.Windows.Forms.Label
    Private WithEvents txtUser As System.Windows.Forms.TextBox
    Private WithEvents tabAudio As System.Windows.Forms.TabPage
    Private WithEvents grbAudioDevices As System.Windows.Forms.GroupBox
    Private WithEvents cboRing As System.Windows.Forms.ComboBox
    Private WithEvents lblRingDevice As System.Windows.Forms.Label
    Private WithEvents cboOutput As System.Windows.Forms.ComboBox
    Private WithEvents lblOutputDevice As System.Windows.Forms.Label
    Private WithEvents cboInput As System.Windows.Forms.ComboBox
    Private WithEvents lblInputDevice As System.Windows.Forms.Label
    Private WithEvents tabVisual As System.Windows.Forms.TabPage
    Private WithEvents grbAppearance As System.Windows.Forms.GroupBox
    Private WithEvents panCommands As System.Windows.Forms.Panel
    Private WithEvents cmdCall As System.Windows.Forms.Button
    Private WithEvents cmdHangup As System.Windows.Forms.Button
    Private WithEvents cmdLine2 As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents lblTime2 As System.Windows.Forms.Label
    Private WithEvents lblCallDirection2 As System.Windows.Forms.Label
    Private WithEvents lblNumber2 As System.Windows.Forms.Label
    Private WithEvents lblStatus2 As System.Windows.Forms.Label
    Private WithEvents cboColorScheme As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents tabCredits As System.Windows.Forms.TabPage
    Private WithEvents lblIAX As System.Windows.Forms.Label
    Private WithEvents lblSharpIAX As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents cmdOk As System.Windows.Forms.Button
End Class
