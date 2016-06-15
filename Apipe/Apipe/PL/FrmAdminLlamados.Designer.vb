<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminLlamados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminLlamados))
        Me.PnlPhone = New System.Windows.Forms.Panel()
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
        Me.cmdConfig = New System.Windows.Forms.Button()
        Me.panLcd = New System.Windows.Forms.Panel()
        Me.panMain = New System.Windows.Forms.Panel()
        Me.progressLevelOutput = New System.Windows.Forms.ProgressBar()
        Me.progressLevelInput = New System.Windows.Forms.ProgressBar()
        Me.panDial = New System.Windows.Forms.Panel()
        Me.txtDial = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.timTime = New System.Windows.Forms.Timer(Me.components)
        Me.notifyMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PnlPhone.SuspendLayout()
        Me.panCommands.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panLine1.SuspendLayout()
        Me.panLcd.SuspendLayout()
        Me.panMain.SuspendLayout()
        Me.panDial.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlPhone
        '
        Me.PnlPhone.Controls.Add(Me.panCommands)
        Me.PnlPhone.Controls.Add(Me.cmdConfig)
        Me.PnlPhone.Controls.Add(Me.panLcd)
        Me.PnlPhone.Location = New System.Drawing.Point(12, 12)
        Me.PnlPhone.Name = "PnlPhone"
        Me.PnlPhone.Size = New System.Drawing.Size(298, 406)
        Me.PnlPhone.TabIndex = 0
        '
        'panCommands
        '
        Me.panCommands.BackColor = System.Drawing.Color.Black
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
        Me.panCommands.Location = New System.Drawing.Point(45, 140)
        Me.panCommands.Name = "panCommands"
        Me.panCommands.Size = New System.Drawing.Size(209, 253)
        Me.panCommands.TabIndex = 24
        '
        'cmdTransfer
        '
        Me.cmdTransfer.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTransfer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdTransfer.ForeColor = System.Drawing.Color.White
        Me.cmdTransfer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTransfer.Location = New System.Drawing.Point(108, 119)
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.Size = New System.Drawing.Size(98, 23)
        Me.cmdTransfer.TabIndex = 48
        Me.cmdTransfer.Text = "Transferir"
        Me.cmdTransfer.UseVisualStyleBackColor = False
        '
        'cmdCall
        '
        Me.cmdCall.BackColor = System.Drawing.Color.Silver
        Me.cmdCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCall.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCall.ForeColor = System.Drawing.Color.White
        Me.cmdCall.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCall.Location = New System.Drawing.Point(7, 93)
        Me.cmdCall.Name = "cmdCall"
        Me.cmdCall.Size = New System.Drawing.Size(98, 23)
        Me.cmdCall.TabIndex = 47
        Me.cmdCall.Text = "Llamar"
        Me.cmdCall.UseVisualStyleBackColor = False
        '
        'cmdHangup
        '
        Me.cmdHangup.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdHangup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdHangup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdHangup.ForeColor = System.Drawing.Color.White
        Me.cmdHangup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHangup.Location = New System.Drawing.Point(108, 93)
        Me.cmdHangup.Name = "cmdHangup"
        Me.cmdHangup.Size = New System.Drawing.Size(98, 23)
        Me.cmdHangup.TabIndex = 46
        Me.cmdHangup.Text = "Cortar"
        Me.cmdHangup.UseVisualStyleBackColor = False
        '
        'cmdPickUp
        '
        Me.cmdPickUp.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPickUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdPickUp.ForeColor = System.Drawing.Color.White
        Me.cmdPickUp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPickUp.Location = New System.Drawing.Point(7, 119)
        Me.cmdPickUp.Name = "cmdPickUp"
        Me.cmdPickUp.Size = New System.Drawing.Size(98, 23)
        Me.cmdPickUp.TabIndex = 45
        Me.cmdPickUp.Text = "Atender"
        Me.cmdPickUp.UseVisualStyleBackColor = False
        '
        'cmdDigit0
        '
        Me.cmdDigit0.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit0.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit0.ForeColor = System.Drawing.Color.White
        Me.cmdDigit0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit0.Location = New System.Drawing.Point(74, 227)
        Me.cmdDigit0.Name = "cmdDigit0"
        Me.cmdDigit0.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit0.TabIndex = 44
        Me.cmdDigit0.Text = "0"
        Me.cmdDigit0.UseVisualStyleBackColor = False
        '
        'cmdDigitSharp
        '
        Me.cmdDigitSharp.BackColor = System.Drawing.Color.Orange
        Me.cmdDigitSharp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigitSharp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigitSharp.ForeColor = System.Drawing.Color.White
        Me.cmdDigitSharp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigitSharp.Location = New System.Drawing.Point(142, 227)
        Me.cmdDigitSharp.Name = "cmdDigitSharp"
        Me.cmdDigitSharp.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigitSharp.TabIndex = 43
        Me.cmdDigitSharp.Text = "#"
        Me.cmdDigitSharp.UseVisualStyleBackColor = False
        '
        'cmdDigitAsterisk
        '
        Me.cmdDigitAsterisk.BackColor = System.Drawing.Color.Orange
        Me.cmdDigitAsterisk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigitAsterisk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigitAsterisk.ForeColor = System.Drawing.Color.White
        Me.cmdDigitAsterisk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigitAsterisk.Location = New System.Drawing.Point(7, 227)
        Me.cmdDigitAsterisk.Name = "cmdDigitAsterisk"
        Me.cmdDigitAsterisk.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigitAsterisk.TabIndex = 42
        Me.cmdDigitAsterisk.Text = "*"
        Me.cmdDigitAsterisk.UseVisualStyleBackColor = False
        '
        'cmdDigit8
        '
        Me.cmdDigit8.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit8.ForeColor = System.Drawing.Color.White
        Me.cmdDigit8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit8.Location = New System.Drawing.Point(74, 200)
        Me.cmdDigit8.Name = "cmdDigit8"
        Me.cmdDigit8.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit8.TabIndex = 41
        Me.cmdDigit8.Text = "8"
        Me.cmdDigit8.UseVisualStyleBackColor = False
        '
        'cmdDigit9
        '
        Me.cmdDigit9.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit9.ForeColor = System.Drawing.Color.White
        Me.cmdDigit9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit9.Location = New System.Drawing.Point(142, 200)
        Me.cmdDigit9.Name = "cmdDigit9"
        Me.cmdDigit9.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit9.TabIndex = 40
        Me.cmdDigit9.Text = "9"
        Me.cmdDigit9.UseVisualStyleBackColor = False
        '
        'cmdDigit7
        '
        Me.cmdDigit7.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit7.ForeColor = System.Drawing.Color.White
        Me.cmdDigit7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit7.Location = New System.Drawing.Point(7, 200)
        Me.cmdDigit7.Name = "cmdDigit7"
        Me.cmdDigit7.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit7.TabIndex = 39
        Me.cmdDigit7.Text = "7"
        Me.cmdDigit7.UseVisualStyleBackColor = False
        '
        'cmdDigit5
        '
        Me.cmdDigit5.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit5.ForeColor = System.Drawing.Color.White
        Me.cmdDigit5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit5.Location = New System.Drawing.Point(74, 173)
        Me.cmdDigit5.Name = "cmdDigit5"
        Me.cmdDigit5.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit5.TabIndex = 38
        Me.cmdDigit5.Text = "5"
        Me.cmdDigit5.UseVisualStyleBackColor = False
        '
        'cmdDigit6
        '
        Me.cmdDigit6.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit6.ForeColor = System.Drawing.Color.White
        Me.cmdDigit6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit6.Location = New System.Drawing.Point(142, 173)
        Me.cmdDigit6.Name = "cmdDigit6"
        Me.cmdDigit6.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit6.TabIndex = 37
        Me.cmdDigit6.Text = "6"
        Me.cmdDigit6.UseVisualStyleBackColor = False
        '
        'cmdDigit4
        '
        Me.cmdDigit4.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit4.ForeColor = System.Drawing.Color.White
        Me.cmdDigit4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit4.Location = New System.Drawing.Point(7, 173)
        Me.cmdDigit4.Name = "cmdDigit4"
        Me.cmdDigit4.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit4.TabIndex = 36
        Me.cmdDigit4.Text = "4"
        Me.cmdDigit4.UseVisualStyleBackColor = False
        '
        'cmdDigit2
        '
        Me.cmdDigit2.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit2.ForeColor = System.Drawing.Color.White
        Me.cmdDigit2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit2.Location = New System.Drawing.Point(74, 146)
        Me.cmdDigit2.Name = "cmdDigit2"
        Me.cmdDigit2.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit2.TabIndex = 35
        Me.cmdDigit2.Text = "2"
        Me.cmdDigit2.UseVisualStyleBackColor = False
        '
        'cmdDigit3
        '
        Me.cmdDigit3.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit3.ForeColor = System.Drawing.Color.White
        Me.cmdDigit3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit3.Location = New System.Drawing.Point(142, 146)
        Me.cmdDigit3.Name = "cmdDigit3"
        Me.cmdDigit3.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit3.TabIndex = 34
        Me.cmdDigit3.Text = "3"
        Me.cmdDigit3.UseVisualStyleBackColor = False
        '
        'cmdDigit1
        '
        Me.cmdDigit1.BackColor = System.Drawing.Color.DimGray
        Me.cmdDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDigit1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdDigit1.ForeColor = System.Drawing.Color.White
        Me.cmdDigit1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit1.Location = New System.Drawing.Point(7, 146)
        Me.cmdDigit1.Name = "cmdDigit1"
        Me.cmdDigit1.Size = New System.Drawing.Size(64, 23)
        Me.cmdDigit1.TabIndex = 33
        Me.cmdDigit1.Text = "1"
        Me.cmdDigit1.UseVisualStyleBackColor = False
        '
        'cmdLine2
        '
        Me.cmdLine2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdLine2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdLine2.ForeColor = System.Drawing.Color.White
        Me.cmdLine2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLine2.Location = New System.Drawing.Point(7, 46)
        Me.cmdLine2.Name = "cmdLine2"
        Me.cmdLine2.Size = New System.Drawing.Size(14, 43)
        Me.cmdLine2.TabIndex = 30
        Me.cmdLine2.Tag = "1"
        Me.cmdLine2.Text = "L2"
        Me.cmdLine2.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.White
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
        'lblTime2
        '
        Me.lblTime2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTime2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTime2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTime2.Location = New System.Drawing.Point(132, 3)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(46, 13)
        Me.lblTime2.TabIndex = 4
        Me.lblTime2.Text = "00:00"
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCallDirection2
        '
        Me.lblCallDirection2.BackColor = System.Drawing.Color.White
        Me.lblCallDirection2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCallDirection2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCallDirection2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCallDirection2.Location = New System.Drawing.Point(3, 19)
        Me.lblCallDirection2.Name = "lblCallDirection2"
        Me.lblCallDirection2.Size = New System.Drawing.Size(92, 18)
        Me.lblCallDirection2.TabIndex = 3
        Me.lblCallDirection2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumber2
        '
        Me.lblNumber2.BackColor = System.Drawing.Color.White
        Me.lblNumber2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblNumber2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNumber2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumber2.Location = New System.Drawing.Point(3, 3)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(130, 13)
        Me.lblNumber2.TabIndex = 1
        Me.lblNumber2.Text = "0"
        Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus2
        '
        Me.lblStatus2.BackColor = System.Drawing.Color.White
        Me.lblStatus2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblStatus2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatus2.Location = New System.Drawing.Point(99, 19)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(79, 18)
        Me.lblStatus2.TabIndex = 0
        Me.lblStatus2.Text = "None"
        Me.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdLine1
        '
        Me.cmdLine1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdLine1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdLine1.ForeColor = System.Drawing.Color.Lime
        Me.cmdLine1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLine1.Location = New System.Drawing.Point(7, 1)
        Me.cmdLine1.Name = "cmdLine1"
        Me.cmdLine1.Size = New System.Drawing.Size(14, 43)
        Me.cmdLine1.TabIndex = 28
        Me.cmdLine1.Tag = "0"
        Me.cmdLine1.Text = "L1"
        Me.cmdLine1.UseVisualStyleBackColor = True
        '
        'panLine1
        '
        Me.panLine1.BackColor = System.Drawing.Color.White
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
        'lblTime1
        '
        Me.lblTime1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTime1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTime1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTime1.Location = New System.Drawing.Point(132, 3)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(46, 13)
        Me.lblTime1.TabIndex = 3
        Me.lblTime1.Text = "00:00"
        Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCallDirection1
        '
        Me.lblCallDirection1.BackColor = System.Drawing.Color.White
        Me.lblCallDirection1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCallDirection1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCallDirection1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCallDirection1.Location = New System.Drawing.Point(3, 19)
        Me.lblCallDirection1.Name = "lblCallDirection1"
        Me.lblCallDirection1.Size = New System.Drawing.Size(92, 18)
        Me.lblCallDirection1.TabIndex = 2
        Me.lblCallDirection1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumber1
        '
        Me.lblNumber1.BackColor = System.Drawing.Color.White
        Me.lblNumber1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblNumber1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNumber1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumber1.Location = New System.Drawing.Point(3, 3)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(130, 13)
        Me.lblNumber1.TabIndex = 1
        Me.lblNumber1.Text = "0"
        Me.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus1
        '
        Me.lblStatus1.BackColor = System.Drawing.Color.White
        Me.lblStatus1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblStatus1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatus1.Location = New System.Drawing.Point(99, 19)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(79, 18)
        Me.lblStatus1.TabIndex = 0
        Me.lblStatus1.Text = "None"
        Me.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdConfig
        '
        Me.cmdConfig.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdConfig.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdConfig.ForeColor = System.Drawing.Color.White
        Me.cmdConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfig.Location = New System.Drawing.Point(52, 14)
        Me.cmdConfig.Name = "cmdConfig"
        Me.cmdConfig.Size = New System.Drawing.Size(14, 124)
        Me.cmdConfig.TabIndex = 23
        Me.cmdConfig.Text = "Configl"
        Me.cmdConfig.UseVisualStyleBackColor = True
        '
        'panLcd
        '
        Me.panLcd.BackColor = System.Drawing.Color.White
        Me.panLcd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panLcd.Controls.Add(Me.panMain)
        Me.panLcd.Location = New System.Drawing.Point(67, 14)
        Me.panLcd.Name = "panLcd"
        Me.panLcd.Size = New System.Drawing.Size(184, 124)
        Me.panLcd.TabIndex = 22
        '
        'panMain
        '
        Me.panMain.BackColor = System.Drawing.Color.White
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
        'progressLevelOutput
        '
        Me.progressLevelOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.progressLevelOutput.Location = New System.Drawing.Point(87, 105)
        Me.progressLevelOutput.Name = "progressLevelOutput"
        Me.progressLevelOutput.Size = New System.Drawing.Size(85, 8)
        Me.progressLevelOutput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressLevelOutput.TabIndex = 16
        '
        'progressLevelInput
        '
        Me.progressLevelInput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.progressLevelInput.Location = New System.Drawing.Point(1, 105)
        Me.progressLevelInput.Name = "progressLevelInput"
        Me.progressLevelInput.Size = New System.Drawing.Size(85, 8)
        Me.progressLevelInput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressLevelInput.TabIndex = 15
        '
        'panDial
        '
        Me.panDial.BackColor = System.Drawing.Color.White
        Me.panDial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panDial.Controls.Add(Me.txtDial)
        Me.panDial.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.panDial.Location = New System.Drawing.Point(-1, 32)
        Me.panDial.Name = "panDial"
        Me.panDial.Size = New System.Drawing.Size(176, 27)
        Me.panDial.TabIndex = 1
        '
        'txtDial
        '
        Me.txtDial.BackColor = System.Drawing.Color.White
        Me.txtDial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDial.Enabled = False
        Me.txtDial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtDial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDial.Location = New System.Drawing.Point(3, 4)
        Me.txtDial.Name = "txtDial"
        Me.txtDial.Size = New System.Drawing.Size(167, 16)
        Me.txtDial.TabIndex = 0
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStatus.Location = New System.Drawing.Point(3, 61)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(167, 39)
        Me.txtStatus.TabIndex = 14
        Me.txtStatus.TabStop = False
        Me.txtStatus.Text = "Espere..."
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTime.Location = New System.Drawing.Point(98, 4)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(72, 23)
        Me.lblTime.TabIndex = 13
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.White
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUser.Location = New System.Drawing.Point(3, 4)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 23)
        Me.lblUser.TabIndex = 10
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'timTime
        '
        Me.timTime.Interval = 1000
        '
        'notifyMain
        '
        Me.notifyMain.Icon = CType(resources.GetObject("notifyMain.Icon"), System.Drawing.Icon)
        Me.notifyMain.Text = "IAXClient"
        Me.notifyMain.Visible = True
        '
        'FrmAdminLlamados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 451)
        Me.Controls.Add(Me.PnlPhone)
        Me.Name = "FrmAdminLlamados"
        Me.Text = "FrmAdminLlamados"
        Me.PnlPhone.ResumeLayout(False)
        Me.panCommands.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panLine1.ResumeLayout(False)
        Me.panLcd.ResumeLayout(False)
        Me.panMain.ResumeLayout(False)
        Me.panMain.PerformLayout()
        Me.panDial.ResumeLayout(False)
        Me.panDial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlPhone As System.Windows.Forms.Panel
    Private WithEvents panCommands As System.Windows.Forms.Panel
    Private WithEvents cmdTransfer As System.Windows.Forms.Button
    Private WithEvents cmdCall As System.Windows.Forms.Button
    Private WithEvents cmdHangup As System.Windows.Forms.Button
    Private WithEvents cmdPickUp As System.Windows.Forms.Button
    Private WithEvents cmdDigit0 As System.Windows.Forms.Button
    Private WithEvents cmdDigitSharp As System.Windows.Forms.Button
    Private WithEvents cmdDigitAsterisk As System.Windows.Forms.Button
    Private WithEvents cmdDigit8 As System.Windows.Forms.Button
    Private WithEvents cmdDigit9 As System.Windows.Forms.Button
    Private WithEvents cmdDigit7 As System.Windows.Forms.Button
    Private WithEvents cmdDigit5 As System.Windows.Forms.Button
    Private WithEvents cmdDigit6 As System.Windows.Forms.Button
    Private WithEvents cmdDigit4 As System.Windows.Forms.Button
    Private WithEvents cmdDigit2 As System.Windows.Forms.Button
    Private WithEvents cmdDigit3 As System.Windows.Forms.Button
    Private WithEvents cmdDigit1 As System.Windows.Forms.Button
    Private WithEvents cmdLine2 As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents lblTime2 As System.Windows.Forms.Label
    Private WithEvents lblCallDirection2 As System.Windows.Forms.Label
    Private WithEvents lblNumber2 As System.Windows.Forms.Label
    Private WithEvents lblStatus2 As System.Windows.Forms.Label
    Private WithEvents cmdLine1 As System.Windows.Forms.Button
    Private WithEvents panLine1 As System.Windows.Forms.Panel
    Private WithEvents lblTime1 As System.Windows.Forms.Label
    Private WithEvents lblCallDirection1 As System.Windows.Forms.Label
    Private WithEvents lblNumber1 As System.Windows.Forms.Label
    Private WithEvents lblStatus1 As System.Windows.Forms.Label
    Private WithEvents cmdConfig As System.Windows.Forms.Button
    Private WithEvents panLcd As System.Windows.Forms.Panel
    Private WithEvents panMain As System.Windows.Forms.Panel
    Private WithEvents progressLevelOutput As System.Windows.Forms.ProgressBar
    Private WithEvents progressLevelInput As System.Windows.Forms.ProgressBar
    Private WithEvents panDial As System.Windows.Forms.Panel
    Private WithEvents txtDial As System.Windows.Forms.TextBox
    Private WithEvents txtStatus As System.Windows.Forms.TextBox
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private WithEvents lblUser As System.Windows.Forms.Label
    Private WithEvents timTime As System.Windows.Forms.Timer
    Private WithEvents notifyMain As System.Windows.Forms.NotifyIcon
End Class
