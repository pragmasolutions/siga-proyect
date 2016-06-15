namespace SharpIAX
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.grbNetwork = new System.Windows.Forms.GroupBox();
            this.lblCallerIdNumber = new System.Windows.Forms.Label();
            this.txtCallerIdNumber = new System.Windows.Forms.TextBox();
            this.lblCallerIdName = new System.Windows.Forms.Label();
            this.txtCallerIdName = new System.Windows.Forms.TextBox();
            this.chkRegistration = new System.Windows.Forms.CheckBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabpanConfig = new System.Windows.Forms.TabControl();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.grbCodecs = new System.Windows.Forms.GroupBox();
            this.grbAllowed = new System.Windows.Forms.GroupBox();
            this.chkSpeex = new System.Windows.Forms.CheckBox();
            this.chkiLBC = new System.Windows.Forms.CheckBox();
            this.chkGSM = new System.Windows.Forms.CheckBox();
            this.chkG711Alaw = new System.Windows.Forms.CheckBox();
            this.chkG711Ulaw = new System.Windows.Forms.CheckBox();
            this.grbPreferred = new System.Windows.Forms.GroupBox();
            this.rbSpeex = new System.Windows.Forms.RadioButton();
            this.rbiLBC = new System.Windows.Forms.RadioButton();
            this.rbG711Alaw = new System.Windows.Forms.RadioButton();
            this.rbG711Ulaw = new System.Windows.Forms.RadioButton();
            this.rbGSM = new System.Windows.Forms.RadioButton();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.grbAudioDevices = new System.Windows.Forms.GroupBox();
            this.cboRing = new System.Windows.Forms.ComboBox();
            this.lblRingDevice = new System.Windows.Forms.Label();
            this.cboOutput = new System.Windows.Forms.ComboBox();
            this.lblOutputDevice = new System.Windows.Forms.Label();
            this.cboInput = new System.Windows.Forms.ComboBox();
            this.lblInputDevice = new System.Windows.Forms.Label();
            this.tabCredits = new System.Windows.Forms.TabPage();
            this.lblIAX = new System.Windows.Forms.Label();
            this.lblSharpIAX = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabVisual = new System.Windows.Forms.TabPage();
            this.grbAppearance = new System.Windows.Forms.GroupBox();
            this.cboColorScheme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panCommands = new System.Windows.Forms.Panel();
            this.cmdCall = new System.Windows.Forms.Button();
            this.cmdHangup = new System.Windows.Forms.Button();
            this.cmdLine2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblCallDirection2 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.grbNetwork.SuspendLayout();
            this.tabpanConfig.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            this.grbCodecs.SuspendLayout();
            this.grbAllowed.SuspendLayout();
            this.grbPreferred.SuspendLayout();
            this.tabAudio.SuspendLayout();
            this.grbAudioDevices.SuspendLayout();
            this.tabCredits.SuspendLayout();
            this.tabVisual.SuspendLayout();
            this.grbAppearance.SuspendLayout();
            this.panCommands.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNetwork
            // 
            this.grbNetwork.Controls.Add(this.lblCallerIdNumber);
            this.grbNetwork.Controls.Add(this.txtCallerIdNumber);
            this.grbNetwork.Controls.Add(this.lblCallerIdName);
            this.grbNetwork.Controls.Add(this.txtCallerIdName);
            this.grbNetwork.Controls.Add(this.chkRegistration);
            this.grbNetwork.Controls.Add(this.lblHost);
            this.grbNetwork.Controls.Add(this.txtHost);
            this.grbNetwork.Controls.Add(this.lblPassword);
            this.grbNetwork.Controls.Add(this.txtPassword);
            this.grbNetwork.Controls.Add(this.lblUser);
            this.grbNetwork.Controls.Add(this.txtUser);
            this.grbNetwork.Location = new System.Drawing.Point(6, 6);
            this.grbNetwork.Name = "grbNetwork";
            this.grbNetwork.Size = new System.Drawing.Size(352, 110);
            this.grbNetwork.TabIndex = 0;
            this.grbNetwork.TabStop = false;
            this.grbNetwork.Text = "Network";
            // 
            // lblCallerIdNumber
            // 
            this.lblCallerIdNumber.AutoSize = true;
            this.lblCallerIdNumber.Location = new System.Drawing.Point(120, 62);
            this.lblCallerIdNumber.Name = "lblCallerIdNumber";
            this.lblCallerIdNumber.Size = new System.Drawing.Size(87, 13);
            this.lblCallerIdNumber.TabIndex = 17;
            this.lblCallerIdNumber.Text = "Caller Id Number";
            // 
            // txtCallerIdNumber
            // 
            this.txtCallerIdNumber.Location = new System.Drawing.Point(123, 78);
            this.txtCallerIdNumber.Name = "txtCallerIdNumber";
            this.txtCallerIdNumber.Size = new System.Drawing.Size(105, 21);
            this.txtCallerIdNumber.TabIndex = 16;
            // 
            // lblCallerIdName
            // 
            this.lblCallerIdName.AutoSize = true;
            this.lblCallerIdName.Location = new System.Drawing.Point(9, 62);
            this.lblCallerIdName.Name = "lblCallerIdName";
            this.lblCallerIdName.Size = new System.Drawing.Size(77, 13);
            this.lblCallerIdName.TabIndex = 15;
            this.lblCallerIdName.Text = "Caller Id Name";
            // 
            // txtCallerIdName
            // 
            this.txtCallerIdName.Location = new System.Drawing.Point(12, 78);
            this.txtCallerIdName.Name = "txtCallerIdName";
            this.txtCallerIdName.Size = new System.Drawing.Size(105, 21);
            this.txtCallerIdName.TabIndex = 14;
            // 
            // chkRegistration
            // 
            this.chkRegistration.AutoSize = true;
            this.chkRegistration.Location = new System.Drawing.Point(249, 79);
            this.chkRegistration.Name = "chkRegistration";
            this.chkRegistration.Size = new System.Drawing.Size(84, 17);
            this.chkRegistration.TabIndex = 13;
            this.chkRegistration.Text = "Registration";
            this.chkRegistration.UseVisualStyleBackColor = true;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(231, 19);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 12;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(234, 35);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(105, 21);
            this.txtHost.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(120, 19);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(105, 21);
            this.txtPassword.TabIndex = 9;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 35);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(105, 21);
            this.txtUser.TabIndex = 7;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(222, 333);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(303, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabpanConfig
            // 
            this.tabpanConfig.Controls.Add(this.tabNetwork);
            this.tabpanConfig.Controls.Add(this.tabAudio);
            this.tabpanConfig.Controls.Add(this.tabVisual);
            this.tabpanConfig.Controls.Add(this.tabCredits);
            this.tabpanConfig.Location = new System.Drawing.Point(6, 8);
            this.tabpanConfig.Name = "tabpanConfig";
            this.tabpanConfig.SelectedIndex = 0;
            this.tabpanConfig.Size = new System.Drawing.Size(372, 319);
            this.tabpanConfig.TabIndex = 3;
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.grbCodecs);
            this.tabNetwork.Controls.Add(this.grbNetwork);
            this.tabNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetwork.Size = new System.Drawing.Size(364, 293);
            this.tabNetwork.TabIndex = 0;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // grbCodecs
            // 
            this.grbCodecs.Controls.Add(this.grbAllowed);
            this.grbCodecs.Controls.Add(this.grbPreferred);
            this.grbCodecs.Location = new System.Drawing.Point(6, 119);
            this.grbCodecs.Name = "grbCodecs";
            this.grbCodecs.Size = new System.Drawing.Size(352, 170);
            this.grbCodecs.TabIndex = 1;
            this.grbCodecs.TabStop = false;
            this.grbCodecs.Text = "Codecs";
            // 
            // grbAllowed
            // 
            this.grbAllowed.Controls.Add(this.chkSpeex);
            this.grbAllowed.Controls.Add(this.chkiLBC);
            this.grbAllowed.Controls.Add(this.chkGSM);
            this.grbAllowed.Controls.Add(this.chkG711Alaw);
            this.grbAllowed.Controls.Add(this.chkG711Ulaw);
            this.grbAllowed.Location = new System.Drawing.Point(9, 92);
            this.grbAllowed.Name = "grbAllowed";
            this.grbAllowed.Size = new System.Drawing.Size(337, 69);
            this.grbAllowed.TabIndex = 1;
            this.grbAllowed.TabStop = false;
            this.grbAllowed.Text = "Allowed";
            // 
            // chkSpeex
            // 
            this.chkSpeex.AutoSize = true;
            this.chkSpeex.Location = new System.Drawing.Point(194, 19);
            this.chkSpeex.Name = "chkSpeex";
            this.chkSpeex.Size = new System.Drawing.Size(56, 17);
            this.chkSpeex.TabIndex = 4;
            this.chkSpeex.Text = "Speex";
            this.chkSpeex.UseVisualStyleBackColor = true;
            // 
            // chkiLBC
            // 
            this.chkiLBC.AutoSize = true;
            this.chkiLBC.Location = new System.Drawing.Point(116, 43);
            this.chkiLBC.Name = "chkiLBC";
            this.chkiLBC.Size = new System.Drawing.Size(46, 17);
            this.chkiLBC.TabIndex = 3;
            this.chkiLBC.Text = "iLBC";
            this.chkiLBC.UseVisualStyleBackColor = true;
            // 
            // chkGSM
            // 
            this.chkGSM.AutoSize = true;
            this.chkGSM.Location = new System.Drawing.Point(116, 19);
            this.chkGSM.Name = "chkGSM";
            this.chkGSM.Size = new System.Drawing.Size(47, 17);
            this.chkGSM.TabIndex = 2;
            this.chkGSM.Text = "GSM";
            this.chkGSM.UseVisualStyleBackColor = true;
            // 
            // chkG711Alaw
            // 
            this.chkG711Alaw.AutoSize = true;
            this.chkG711Alaw.Location = new System.Drawing.Point(15, 43);
            this.chkG711Alaw.Name = "chkG711Alaw";
            this.chkG711Alaw.Size = new System.Drawing.Size(81, 17);
            this.chkG711Alaw.TabIndex = 1;
            this.chkG711Alaw.Text = "G.711 Alaw";
            this.chkG711Alaw.UseVisualStyleBackColor = true;
            // 
            // chkG711Ulaw
            // 
            this.chkG711Ulaw.AutoSize = true;
            this.chkG711Ulaw.Location = new System.Drawing.Point(15, 20);
            this.chkG711Ulaw.Name = "chkG711Ulaw";
            this.chkG711Ulaw.Size = new System.Drawing.Size(81, 17);
            this.chkG711Ulaw.TabIndex = 0;
            this.chkG711Ulaw.Text = "G.711 Ulaw";
            this.chkG711Ulaw.UseVisualStyleBackColor = true;
            // 
            // grbPreferred
            // 
            this.grbPreferred.Controls.Add(this.rbSpeex);
            this.grbPreferred.Controls.Add(this.rbiLBC);
            this.grbPreferred.Controls.Add(this.rbG711Alaw);
            this.grbPreferred.Controls.Add(this.rbG711Ulaw);
            this.grbPreferred.Controls.Add(this.rbGSM);
            this.grbPreferred.Location = new System.Drawing.Point(9, 20);
            this.grbPreferred.Name = "grbPreferred";
            this.grbPreferred.Size = new System.Drawing.Size(337, 69);
            this.grbPreferred.TabIndex = 0;
            this.grbPreferred.TabStop = false;
            this.grbPreferred.Text = "Preferred";
            // 
            // rbSpeex
            // 
            this.rbSpeex.AutoSize = true;
            this.rbSpeex.Location = new System.Drawing.Point(194, 20);
            this.rbSpeex.Name = "rbSpeex";
            this.rbSpeex.Size = new System.Drawing.Size(55, 17);
            this.rbSpeex.TabIndex = 4;
            this.rbSpeex.Text = "Speex";
            this.rbSpeex.UseVisualStyleBackColor = true;
            // 
            // rbiLBC
            // 
            this.rbiLBC.AutoSize = true;
            this.rbiLBC.Location = new System.Drawing.Point(116, 43);
            this.rbiLBC.Name = "rbiLBC";
            this.rbiLBC.Size = new System.Drawing.Size(45, 17);
            this.rbiLBC.TabIndex = 3;
            this.rbiLBC.Text = "iLBC";
            this.rbiLBC.UseVisualStyleBackColor = true;
            // 
            // rbG711Alaw
            // 
            this.rbG711Alaw.AutoSize = true;
            this.rbG711Alaw.Location = new System.Drawing.Point(15, 43);
            this.rbG711Alaw.Name = "rbG711Alaw";
            this.rbG711Alaw.Size = new System.Drawing.Size(80, 17);
            this.rbG711Alaw.TabIndex = 2;
            this.rbG711Alaw.Text = "G.711 Alaw";
            this.rbG711Alaw.UseVisualStyleBackColor = true;
            // 
            // rbG711Ulaw
            // 
            this.rbG711Ulaw.AutoSize = true;
            this.rbG711Ulaw.Location = new System.Drawing.Point(15, 20);
            this.rbG711Ulaw.Name = "rbG711Ulaw";
            this.rbG711Ulaw.Size = new System.Drawing.Size(80, 17);
            this.rbG711Ulaw.TabIndex = 1;
            this.rbG711Ulaw.Text = "G.711 Ulaw";
            this.rbG711Ulaw.UseVisualStyleBackColor = true;
            // 
            // rbGSM
            // 
            this.rbGSM.AutoSize = true;
            this.rbGSM.Location = new System.Drawing.Point(116, 20);
            this.rbGSM.Name = "rbGSM";
            this.rbGSM.Size = new System.Drawing.Size(46, 17);
            this.rbGSM.TabIndex = 0;
            this.rbGSM.Text = "GSM";
            this.rbGSM.UseVisualStyleBackColor = true;
            // 
            // tabAudio
            // 
            this.tabAudio.Controls.Add(this.grbAudioDevices);
            this.tabAudio.Location = new System.Drawing.Point(4, 22);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(364, 293);
            this.tabAudio.TabIndex = 1;
            this.tabAudio.Text = "Audio";
            this.tabAudio.UseVisualStyleBackColor = true;
            // 
            // grbAudioDevices
            // 
            this.grbAudioDevices.Controls.Add(this.cboRing);
            this.grbAudioDevices.Controls.Add(this.lblRingDevice);
            this.grbAudioDevices.Controls.Add(this.cboOutput);
            this.grbAudioDevices.Controls.Add(this.lblOutputDevice);
            this.grbAudioDevices.Controls.Add(this.cboInput);
            this.grbAudioDevices.Controls.Add(this.lblInputDevice);
            this.grbAudioDevices.Location = new System.Drawing.Point(6, 6);
            this.grbAudioDevices.Name = "grbAudioDevices";
            this.grbAudioDevices.Size = new System.Drawing.Size(352, 150);
            this.grbAudioDevices.TabIndex = 1;
            this.grbAudioDevices.TabStop = false;
            this.grbAudioDevices.Text = "Audio Devices";
            // 
            // cboRing
            // 
            this.cboRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRing.FormattingEnabled = true;
            this.cboRing.Location = new System.Drawing.Point(12, 116);
            this.cboRing.Name = "cboRing";
            this.cboRing.Size = new System.Drawing.Size(304, 21);
            this.cboRing.TabIndex = 13;
            // 
            // lblRingDevice
            // 
            this.lblRingDevice.AutoSize = true;
            this.lblRingDevice.Location = new System.Drawing.Point(9, 100);
            this.lblRingDevice.Name = "lblRingDevice";
            this.lblRingDevice.Size = new System.Drawing.Size(63, 13);
            this.lblRingDevice.TabIndex = 12;
            this.lblRingDevice.Text = "Ring Device";
            // 
            // cboOutput
            // 
            this.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOutput.FormattingEnabled = true;
            this.cboOutput.Location = new System.Drawing.Point(12, 75);
            this.cboOutput.Name = "cboOutput";
            this.cboOutput.Size = new System.Drawing.Size(304, 21);
            this.cboOutput.TabIndex = 11;
            // 
            // lblOutputDevice
            // 
            this.lblOutputDevice.AutoSize = true;
            this.lblOutputDevice.Location = new System.Drawing.Point(9, 59);
            this.lblOutputDevice.Name = "lblOutputDevice";
            this.lblOutputDevice.Size = new System.Drawing.Size(76, 13);
            this.lblOutputDevice.TabIndex = 10;
            this.lblOutputDevice.Text = "Output Device";
            // 
            // cboInput
            // 
            this.cboInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInput.FormattingEnabled = true;
            this.cboInput.Location = new System.Drawing.Point(12, 35);
            this.cboInput.Name = "cboInput";
            this.cboInput.Size = new System.Drawing.Size(304, 21);
            this.cboInput.TabIndex = 9;
            // 
            // lblInputDevice
            // 
            this.lblInputDevice.AutoSize = true;
            this.lblInputDevice.Location = new System.Drawing.Point(9, 19);
            this.lblInputDevice.Name = "lblInputDevice";
            this.lblInputDevice.Size = new System.Drawing.Size(68, 13);
            this.lblInputDevice.TabIndex = 8;
            this.lblInputDevice.Text = "Input Device";
            // 
            // tabCredits
            // 
            this.tabCredits.Controls.Add(this.lblIAX);
            this.tabCredits.Controls.Add(this.lblSharpIAX);
            this.tabCredits.Controls.Add(this.textBox1);
            this.tabCredits.Location = new System.Drawing.Point(4, 22);
            this.tabCredits.Name = "tabCredits";
            this.tabCredits.Size = new System.Drawing.Size(364, 293);
            this.tabCredits.TabIndex = 2;
            this.tabCredits.Text = "Credits";
            this.tabCredits.UseVisualStyleBackColor = true;
            // 
            // lblIAX
            // 
            this.lblIAX.Location = new System.Drawing.Point(4, 274);
            this.lblIAX.Name = "lblIAX";
            this.lblIAX.Size = new System.Drawing.Size(329, 13);
            this.lblIAX.TabIndex = 2;
            // 
            // lblSharpIAX
            // 
            this.lblSharpIAX.Location = new System.Drawing.Point(4, 6);
            this.lblSharpIAX.Name = "lblSharpIAX";
            this.lblSharpIAX.Size = new System.Drawing.Size(354, 29);
            this.lblSharpIAX.TabIndex = 1;
            this.lblSharpIAX.Text = "SharpIAX version 1.00\r\nCopyright (r) 2006 Andre Luis Azevedo (az.andrel@yahoo.com" +
                ".br)";
            this.lblSharpIAX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(355, 218);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tabVisual
            // 
            this.tabVisual.Controls.Add(this.grbAppearance);
            this.tabVisual.Location = new System.Drawing.Point(4, 22);
            this.tabVisual.Name = "tabVisual";
            this.tabVisual.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisual.Size = new System.Drawing.Size(364, 293);
            this.tabVisual.TabIndex = 3;
            this.tabVisual.Text = "Visual";
            this.tabVisual.UseVisualStyleBackColor = true;
            // 
            // grbAppearance
            // 
            this.grbAppearance.Controls.Add(this.panCommands);
            this.grbAppearance.Controls.Add(this.cboColorScheme);
            this.grbAppearance.Controls.Add(this.label3);
            this.grbAppearance.Location = new System.Drawing.Point(6, 6);
            this.grbAppearance.Name = "grbAppearance";
            this.grbAppearance.Size = new System.Drawing.Size(352, 281);
            this.grbAppearance.TabIndex = 2;
            this.grbAppearance.TabStop = false;
            this.grbAppearance.Text = "Appearance";
            // 
            // cboColorScheme
            // 
            this.cboColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorScheme.FormattingEnabled = true;
            this.cboColorScheme.Items.AddRange(new object[] {
            "SharpIAX",
            "Back in Black",
            "Deep Blue",
            "HellBoy",
            "Ladies Room",
            "The Garden"});
            this.cboColorScheme.Location = new System.Drawing.Point(12, 35);
            this.cboColorScheme.Name = "cboColorScheme";
            this.cboColorScheme.Size = new System.Drawing.Size(304, 21);
            this.cboColorScheme.TabIndex = 9;
            this.cboColorScheme.SelectedIndexChanged += new System.EventHandler(this.cboColorScheme_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color Scheme";
            // 
            // panCommands
            // 
            this.panCommands.BackColor = System.Drawing.Color.DarkGray;
            this.panCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCommands.Controls.Add(this.cmdCall);
            this.panCommands.Controls.Add(this.cmdHangup);
            this.panCommands.Controls.Add(this.cmdLine2);
            this.panCommands.Controls.Add(this.panel2);
            this.panCommands.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panCommands.Location = new System.Drawing.Point(12, 62);
            this.panCommands.Name = "panCommands";
            this.panCommands.Size = new System.Drawing.Size(304, 91);
            this.panCommands.TabIndex = 22;
            // 
            // cmdCall
            // 
            this.cmdCall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCall.ForeColor = System.Drawing.Color.White;
            this.cmdCall.Location = new System.Drawing.Point(7, 61);
            this.cmdCall.Name = "cmdCall";
            this.cmdCall.Size = new System.Drawing.Size(98, 23);
            this.cmdCall.TabIndex = 47;
            this.cmdCall.Text = "Call";
            this.cmdCall.UseVisualStyleBackColor = true;
            // 
            // cmdHangup
            // 
            this.cmdHangup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHangup.ForeColor = System.Drawing.Color.White;
            this.cmdHangup.Location = new System.Drawing.Point(108, 61);
            this.cmdHangup.Name = "cmdHangup";
            this.cmdHangup.Size = new System.Drawing.Size(98, 23);
            this.cmdHangup.TabIndex = 46;
            this.cmdHangup.Text = "Hangup";
            this.cmdHangup.UseVisualStyleBackColor = true;
            // 
            // cmdLine2
            // 
            this.cmdLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLine2.ForeColor = System.Drawing.Color.Lime;
            this.cmdLine2.Location = new System.Drawing.Point(7, 13);
            this.cmdLine2.Name = "cmdLine2";
            this.cmdLine2.Size = new System.Drawing.Size(14, 43);
            this.cmdLine2.TabIndex = 30;
            this.cmdLine2.Tag = "1";
            this.cmdLine2.Text = "L2";
            this.cmdLine2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTime2);
            this.panel2.Controls.Add(this.lblCallDirection2);
            this.panel2.Controls.Add(this.lblNumber2);
            this.panel2.Controls.Add(this.lblStatus2);
            this.panel2.Location = new System.Drawing.Point(22, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 43);
            this.panel2.TabIndex = 29;
            // 
            // lblTime2
            // 
            this.lblTime2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(132, 3);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(46, 13);
            this.lblTime2.TabIndex = 4;
            this.lblTime2.Text = "00:00";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCallDirection2
            // 
            this.lblCallDirection2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallDirection2.Location = new System.Drawing.Point(3, 19);
            this.lblCallDirection2.Name = "lblCallDirection2";
            this.lblCallDirection2.Size = new System.Drawing.Size(92, 18);
            this.lblCallDirection2.TabIndex = 3;
            this.lblCallDirection2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber2
            // 
            this.lblNumber2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(3, 3);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(130, 13);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "0";
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus2
            // 
            this.lblStatus2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus2.Location = new System.Drawing.Point(99, 19);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(79, 18);
            this.lblStatus2.TabIndex = 0;
            this.lblStatus2.Text = "None";
            this.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 361);
            this.Controls.Add(this.tabpanConfig);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdOk);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpIAX Config";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.grbNetwork.ResumeLayout(false);
            this.grbNetwork.PerformLayout();
            this.tabpanConfig.ResumeLayout(false);
            this.tabNetwork.ResumeLayout(false);
            this.grbCodecs.ResumeLayout(false);
            this.grbAllowed.ResumeLayout(false);
            this.grbAllowed.PerformLayout();
            this.grbPreferred.ResumeLayout(false);
            this.grbPreferred.PerformLayout();
            this.tabAudio.ResumeLayout(false);
            this.grbAudioDevices.ResumeLayout(false);
            this.grbAudioDevices.PerformLayout();
            this.tabCredits.ResumeLayout(false);
            this.tabCredits.PerformLayout();
            this.tabVisual.ResumeLayout(false);
            this.grbAppearance.ResumeLayout(false);
            this.grbAppearance.PerformLayout();
            this.panCommands.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNetwork;
        private System.Windows.Forms.CheckBox chkRegistration;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabpanConfig;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.TabPage tabCredits;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbCodecs;
        private System.Windows.Forms.GroupBox grbPreferred;
        private System.Windows.Forms.RadioButton rbG711Ulaw;
        private System.Windows.Forms.RadioButton rbGSM;
        private System.Windows.Forms.RadioButton rbiLBC;
        private System.Windows.Forms.RadioButton rbG711Alaw;
        private System.Windows.Forms.GroupBox grbAllowed;
        private System.Windows.Forms.RadioButton rbSpeex;
        private System.Windows.Forms.CheckBox chkG711Ulaw;
        private System.Windows.Forms.CheckBox chkSpeex;
        private System.Windows.Forms.CheckBox chkiLBC;
        private System.Windows.Forms.CheckBox chkGSM;
        private System.Windows.Forms.CheckBox chkG711Alaw;
        private System.Windows.Forms.GroupBox grbAudioDevices;
        private System.Windows.Forms.ComboBox cboRing;
        private System.Windows.Forms.Label lblRingDevice;
        private System.Windows.Forms.ComboBox cboOutput;
        private System.Windows.Forms.Label lblOutputDevice;
        private System.Windows.Forms.ComboBox cboInput;
        private System.Windows.Forms.Label lblInputDevice;
        private System.Windows.Forms.Label lblSharpIAX;
        private System.Windows.Forms.Label lblIAX;
        private System.Windows.Forms.Label lblCallerIdNumber;
        private System.Windows.Forms.TextBox txtCallerIdNumber;
        private System.Windows.Forms.Label lblCallerIdName;
        private System.Windows.Forms.TextBox txtCallerIdName;
        private System.Windows.Forms.TabPage tabVisual;
        private System.Windows.Forms.GroupBox grbAppearance;
        private System.Windows.Forms.ComboBox cboColorScheme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panCommands;
        private System.Windows.Forms.Button cmdCall;
        private System.Windows.Forms.Button cmdHangup;
        private System.Windows.Forms.Button cmdLine2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblCallDirection2;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblStatus2;

    }
}