namespace SharpIAX
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panLcd = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.progressLevelOutput = new System.Windows.Forms.ProgressBar();
            this.progressLevelInput = new System.Windows.Forms.ProgressBar();
            this.panDial = new System.Windows.Forms.Panel();
            this.txtDial = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmdConfig = new System.Windows.Forms.Button();
            this.panCommands = new System.Windows.Forms.Panel();
            this.cmdTransfer = new System.Windows.Forms.Button();
            this.cmdCall = new System.Windows.Forms.Button();
            this.cmdHangup = new System.Windows.Forms.Button();
            this.cmdPickUp = new System.Windows.Forms.Button();
            this.cmdDigit0 = new System.Windows.Forms.Button();
            this.cmdDigitSharp = new System.Windows.Forms.Button();
            this.cmdDigitAsterisk = new System.Windows.Forms.Button();
            this.cmdDigit8 = new System.Windows.Forms.Button();
            this.cmdDigit9 = new System.Windows.Forms.Button();
            this.cmdDigit7 = new System.Windows.Forms.Button();
            this.cmdDigit5 = new System.Windows.Forms.Button();
            this.cmdDigit6 = new System.Windows.Forms.Button();
            this.cmdDigit4 = new System.Windows.Forms.Button();
            this.cmdDigit2 = new System.Windows.Forms.Button();
            this.cmdDigit3 = new System.Windows.Forms.Button();
            this.cmdDigit1 = new System.Windows.Forms.Button();
            this.cmdLine2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblCallDirection2 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.cmdLine1 = new System.Windows.Forms.Button();
            this.panLine1 = new System.Windows.Forms.Panel();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblCallDirection1 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.notifyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.panLcd.SuspendLayout();
            this.panMain.SuspendLayout();
            this.panDial.SuspendLayout();
            this.panCommands.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panLine1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timTime
            // 
            this.timTime.Interval = 1000;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(3, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 23);
            this.lblUser.TabIndex = 10;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(98, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 23);
            this.lblTime.TabIndex = 13;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panLcd
            // 
            this.panLcd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panLcd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLcd.Controls.Add(this.panMain);
            this.panLcd.Location = new System.Drawing.Point(22, 7);
            this.panLcd.Name = "panLcd";
            this.panLcd.Size = new System.Drawing.Size(184, 124);
            this.panLcd.TabIndex = 8;
            // 
            // panMain
            // 
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Controls.Add(this.progressLevelOutput);
            this.panMain.Controls.Add(this.progressLevelInput);
            this.panMain.Controls.Add(this.panDial);
            this.panMain.Controls.Add(this.txtStatus);
            this.panMain.Controls.Add(this.lblTime);
            this.panMain.Controls.Add(this.lblUser);
            this.panMain.Location = new System.Drawing.Point(2, 2);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(176, 116);
            this.panMain.TabIndex = 0;
            // 
            // progressLevelOutput
            // 
            this.progressLevelOutput.Location = new System.Drawing.Point(87, 105);
            this.progressLevelOutput.Name = "progressLevelOutput";
            this.progressLevelOutput.Size = new System.Drawing.Size(85, 8);
            this.progressLevelOutput.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressLevelOutput.TabIndex = 16;
            // 
            // progressLevelInput
            // 
            this.progressLevelInput.Location = new System.Drawing.Point(1, 105);
            this.progressLevelInput.Name = "progressLevelInput";
            this.progressLevelInput.Size = new System.Drawing.Size(85, 8);
            this.progressLevelInput.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressLevelInput.TabIndex = 15;
            // 
            // panDial
            // 
            this.panDial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDial.Controls.Add(this.txtDial);
            this.panDial.Font = new System.Drawing.Font("Tahoma", 8F);
            this.panDial.Location = new System.Drawing.Point(-1, 32);
            this.panDial.Name = "panDial";
            this.panDial.Size = new System.Drawing.Size(176, 27);
            this.panDial.TabIndex = 1;
            // 
            // txtDial
            // 
            this.txtDial.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDial.Enabled = false;
            this.txtDial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDial.Location = new System.Drawing.Point(3, 4);
            this.txtDial.Name = "txtDial";
            this.txtDial.Size = new System.Drawing.Size(167, 16);
            this.txtDial.TabIndex = 0;
            this.txtDial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDial_KeyDown);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(3, 61);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(167, 39);
            this.txtStatus.TabIndex = 14;
            this.txtStatus.TabStop = false;
            this.txtStatus.Text = "Wait...";
            // 
            // cmdConfig
            // 
            this.cmdConfig.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfig.ForeColor = System.Drawing.Color.White;
            this.cmdConfig.Location = new System.Drawing.Point(7, 7);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(14, 124);
            this.cmdConfig.TabIndex = 20;
            this.cmdConfig.Text = "Configl";
            this.cmdConfig.UseVisualStyleBackColor = true;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // panCommands
            // 
            this.panCommands.Controls.Add(this.cmdTransfer);
            this.panCommands.Controls.Add(this.cmdCall);
            this.panCommands.Controls.Add(this.cmdHangup);
            this.panCommands.Controls.Add(this.cmdPickUp);
            this.panCommands.Controls.Add(this.cmdDigit0);
            this.panCommands.Controls.Add(this.cmdDigitSharp);
            this.panCommands.Controls.Add(this.cmdDigitAsterisk);
            this.panCommands.Controls.Add(this.cmdDigit8);
            this.panCommands.Controls.Add(this.cmdDigit9);
            this.panCommands.Controls.Add(this.cmdDigit7);
            this.panCommands.Controls.Add(this.cmdDigit5);
            this.panCommands.Controls.Add(this.cmdDigit6);
            this.panCommands.Controls.Add(this.cmdDigit4);
            this.panCommands.Controls.Add(this.cmdDigit2);
            this.panCommands.Controls.Add(this.cmdDigit3);
            this.panCommands.Controls.Add(this.cmdDigit1);
            this.panCommands.Controls.Add(this.cmdLine2);
            this.panCommands.Controls.Add(this.panel2);
            this.panCommands.Controls.Add(this.cmdLine1);
            this.panCommands.Controls.Add(this.panLine1);
            this.panCommands.Enabled = false;
            this.panCommands.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panCommands.Location = new System.Drawing.Point(0, 133);
            this.panCommands.Name = "panCommands";
            this.panCommands.Size = new System.Drawing.Size(209, 253);
            this.panCommands.TabIndex = 21;
            // 
            // cmdTransfer
            // 
            this.cmdTransfer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTransfer.ForeColor = System.Drawing.Color.White;
            this.cmdTransfer.Location = new System.Drawing.Point(108, 119);
            this.cmdTransfer.Name = "cmdTransfer";
            this.cmdTransfer.Size = new System.Drawing.Size(98, 23);
            this.cmdTransfer.TabIndex = 48;
            this.cmdTransfer.Text = "Transfer";
            this.cmdTransfer.UseVisualStyleBackColor = true;
            this.cmdTransfer.Click += new System.EventHandler(this.cmdTransfer_Click);
            // 
            // cmdCall
            // 
            this.cmdCall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCall.ForeColor = System.Drawing.Color.White;
            this.cmdCall.Location = new System.Drawing.Point(7, 93);
            this.cmdCall.Name = "cmdCall";
            this.cmdCall.Size = new System.Drawing.Size(98, 23);
            this.cmdCall.TabIndex = 47;
            this.cmdCall.Text = "Call";
            this.cmdCall.UseVisualStyleBackColor = true;
            this.cmdCall.Click += new System.EventHandler(this.cmdCall_Click);
            // 
            // cmdHangup
            // 
            this.cmdHangup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHangup.ForeColor = System.Drawing.Color.White;
            this.cmdHangup.Location = new System.Drawing.Point(108, 93);
            this.cmdHangup.Name = "cmdHangup";
            this.cmdHangup.Size = new System.Drawing.Size(98, 23);
            this.cmdHangup.TabIndex = 46;
            this.cmdHangup.Text = "Hangup";
            this.cmdHangup.UseVisualStyleBackColor = true;
            this.cmdHangup.Click += new System.EventHandler(this.cmdDropCall_Click);
            // 
            // cmdPickUp
            // 
            this.cmdPickUp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPickUp.ForeColor = System.Drawing.Color.White;
            this.cmdPickUp.Location = new System.Drawing.Point(7, 119);
            this.cmdPickUp.Name = "cmdPickUp";
            this.cmdPickUp.Size = new System.Drawing.Size(98, 23);
            this.cmdPickUp.TabIndex = 45;
            this.cmdPickUp.Text = "Pickup";
            this.cmdPickUp.UseVisualStyleBackColor = true;
            this.cmdPickUp.Click += new System.EventHandler(this.cmdPickUp_Click);
            // 
            // cmdDigit0
            // 
            this.cmdDigit0.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit0.ForeColor = System.Drawing.Color.White;
            this.cmdDigit0.Location = new System.Drawing.Point(74, 227);
            this.cmdDigit0.Name = "cmdDigit0";
            this.cmdDigit0.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit0.TabIndex = 44;
            this.cmdDigit0.Text = "0";
            this.cmdDigit0.UseVisualStyleBackColor = true;
            this.cmdDigit0.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigitSharp
            // 
            this.cmdDigitSharp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigitSharp.ForeColor = System.Drawing.Color.White;
            this.cmdDigitSharp.Location = new System.Drawing.Point(142, 227);
            this.cmdDigitSharp.Name = "cmdDigitSharp";
            this.cmdDigitSharp.Size = new System.Drawing.Size(64, 23);
            this.cmdDigitSharp.TabIndex = 43;
            this.cmdDigitSharp.Text = "#";
            this.cmdDigitSharp.UseVisualStyleBackColor = true;
            this.cmdDigitSharp.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigitAsterisk
            // 
            this.cmdDigitAsterisk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigitAsterisk.ForeColor = System.Drawing.Color.White;
            this.cmdDigitAsterisk.Location = new System.Drawing.Point(7, 227);
            this.cmdDigitAsterisk.Name = "cmdDigitAsterisk";
            this.cmdDigitAsterisk.Size = new System.Drawing.Size(64, 23);
            this.cmdDigitAsterisk.TabIndex = 42;
            this.cmdDigitAsterisk.Text = "*";
            this.cmdDigitAsterisk.UseVisualStyleBackColor = true;
            this.cmdDigitAsterisk.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit8
            // 
            this.cmdDigit8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit8.ForeColor = System.Drawing.Color.White;
            this.cmdDigit8.Location = new System.Drawing.Point(74, 200);
            this.cmdDigit8.Name = "cmdDigit8";
            this.cmdDigit8.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit8.TabIndex = 41;
            this.cmdDigit8.Text = "8";
            this.cmdDigit8.UseVisualStyleBackColor = true;
            this.cmdDigit8.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit9
            // 
            this.cmdDigit9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit9.ForeColor = System.Drawing.Color.White;
            this.cmdDigit9.Location = new System.Drawing.Point(142, 200);
            this.cmdDigit9.Name = "cmdDigit9";
            this.cmdDigit9.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit9.TabIndex = 40;
            this.cmdDigit9.Text = "9";
            this.cmdDigit9.UseVisualStyleBackColor = true;
            this.cmdDigit9.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit7
            // 
            this.cmdDigit7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit7.ForeColor = System.Drawing.Color.White;
            this.cmdDigit7.Location = new System.Drawing.Point(7, 200);
            this.cmdDigit7.Name = "cmdDigit7";
            this.cmdDigit7.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit7.TabIndex = 39;
            this.cmdDigit7.Text = "7";
            this.cmdDigit7.UseVisualStyleBackColor = true;
            this.cmdDigit7.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit5
            // 
            this.cmdDigit5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit5.ForeColor = System.Drawing.Color.White;
            this.cmdDigit5.Location = new System.Drawing.Point(74, 173);
            this.cmdDigit5.Name = "cmdDigit5";
            this.cmdDigit5.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit5.TabIndex = 38;
            this.cmdDigit5.Text = "5";
            this.cmdDigit5.UseVisualStyleBackColor = true;
            this.cmdDigit5.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit6
            // 
            this.cmdDigit6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit6.ForeColor = System.Drawing.Color.White;
            this.cmdDigit6.Location = new System.Drawing.Point(142, 173);
            this.cmdDigit6.Name = "cmdDigit6";
            this.cmdDigit6.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit6.TabIndex = 37;
            this.cmdDigit6.Text = "6";
            this.cmdDigit6.UseVisualStyleBackColor = true;
            this.cmdDigit6.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit4
            // 
            this.cmdDigit4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit4.ForeColor = System.Drawing.Color.White;
            this.cmdDigit4.Location = new System.Drawing.Point(7, 173);
            this.cmdDigit4.Name = "cmdDigit4";
            this.cmdDigit4.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit4.TabIndex = 36;
            this.cmdDigit4.Text = "4";
            this.cmdDigit4.UseVisualStyleBackColor = true;
            this.cmdDigit4.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit2
            // 
            this.cmdDigit2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit2.ForeColor = System.Drawing.Color.White;
            this.cmdDigit2.Location = new System.Drawing.Point(74, 146);
            this.cmdDigit2.Name = "cmdDigit2";
            this.cmdDigit2.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit2.TabIndex = 35;
            this.cmdDigit2.Text = "2";
            this.cmdDigit2.UseVisualStyleBackColor = true;
            this.cmdDigit2.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit3
            // 
            this.cmdDigit3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit3.ForeColor = System.Drawing.Color.White;
            this.cmdDigit3.Location = new System.Drawing.Point(142, 146);
            this.cmdDigit3.Name = "cmdDigit3";
            this.cmdDigit3.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit3.TabIndex = 34;
            this.cmdDigit3.Text = "3";
            this.cmdDigit3.UseVisualStyleBackColor = true;
            this.cmdDigit3.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit1
            // 
            this.cmdDigit1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDigit1.ForeColor = System.Drawing.Color.White;
            this.cmdDigit1.Location = new System.Drawing.Point(7, 146);
            this.cmdDigit1.Name = "cmdDigit1";
            this.cmdDigit1.Size = new System.Drawing.Size(64, 23);
            this.cmdDigit1.TabIndex = 33;
            this.cmdDigit1.Text = "1";
            this.cmdDigit1.UseVisualStyleBackColor = true;
            this.cmdDigit1.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdLine2
            // 
            this.cmdLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLine2.ForeColor = System.Drawing.Color.White;
            this.cmdLine2.Location = new System.Drawing.Point(7, 46);
            this.cmdLine2.Name = "cmdLine2";
            this.cmdLine2.Size = new System.Drawing.Size(14, 43);
            this.cmdLine2.TabIndex = 30;
            this.cmdLine2.Tag = "1";
            this.cmdLine2.Text = "L2";
            this.cmdLine2.UseVisualStyleBackColor = true;
            this.cmdLine2.Click += new System.EventHandler(this.cmdLine1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTime2);
            this.panel2.Controls.Add(this.lblCallDirection2);
            this.panel2.Controls.Add(this.lblNumber2);
            this.panel2.Controls.Add(this.lblStatus2);
            this.panel2.Location = new System.Drawing.Point(22, 46);
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
            // cmdLine1
            // 
            this.cmdLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLine1.ForeColor = System.Drawing.Color.Lime;
            this.cmdLine1.Location = new System.Drawing.Point(7, 1);
            this.cmdLine1.Name = "cmdLine1";
            this.cmdLine1.Size = new System.Drawing.Size(14, 43);
            this.cmdLine1.TabIndex = 28;
            this.cmdLine1.Tag = "0";
            this.cmdLine1.Text = "L1";
            this.cmdLine1.UseVisualStyleBackColor = true;
            this.cmdLine1.Click += new System.EventHandler(this.cmdLine1_Click);
            // 
            // panLine1
            // 
            this.panLine1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLine1.Controls.Add(this.lblTime1);
            this.panLine1.Controls.Add(this.lblCallDirection1);
            this.panLine1.Controls.Add(this.lblNumber1);
            this.panLine1.Controls.Add(this.lblStatus1);
            this.panLine1.Location = new System.Drawing.Point(22, 1);
            this.panLine1.Name = "panLine1";
            this.panLine1.Size = new System.Drawing.Size(184, 43);
            this.panLine1.TabIndex = 27;
            // 
            // lblTime1
            // 
            this.lblTime1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(132, 3);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(46, 13);
            this.lblTime1.TabIndex = 3;
            this.lblTime1.Text = "00:00";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCallDirection1
            // 
            this.lblCallDirection1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallDirection1.Location = new System.Drawing.Point(3, 19);
            this.lblCallDirection1.Name = "lblCallDirection1";
            this.lblCallDirection1.Size = new System.Drawing.Size(92, 18);
            this.lblCallDirection1.TabIndex = 2;
            this.lblCallDirection1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber1
            // 
            this.lblNumber1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(3, 3);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(130, 13);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "0";
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus1
            // 
            this.lblStatus1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus1.Location = new System.Drawing.Point(99, 19);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(79, 18);
            this.lblStatus1.TabIndex = 0;
            this.lblStatus1.Text = "None";
            this.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyMain
            // 
            this.notifyMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyMain.Icon")));
            this.notifyMain.Text = "IAXClient";
            this.notifyMain.Visible = true;
            this.notifyMain.DoubleClick += new System.EventHandler(this.notifyMain_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(212, 387);
            this.Controls.Add(this.panCommands);
            this.Controls.Add(this.cmdConfig);
            this.Controls.Add(this.panLcd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpIAX";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panLcd.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.panDial.ResumeLayout(false);
            this.panDial.PerformLayout();
            this.panCommands.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panLine1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panLcd;
        private System.Windows.Forms.Button cmdConfig;
        private System.Windows.Forms.Panel panDial;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panCommands;
        private System.Windows.Forms.Button cmdLine2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblCallDirection2;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Button cmdLine1;
        private System.Windows.Forms.Panel panLine1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblCallDirection1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.NotifyIcon notifyMain;
        private System.Windows.Forms.Button cmdDigit0;
        private System.Windows.Forms.Button cmdDigitSharp;
        private System.Windows.Forms.Button cmdDigitAsterisk;
        private System.Windows.Forms.Button cmdDigit8;
        private System.Windows.Forms.Button cmdDigit9;
        private System.Windows.Forms.Button cmdDigit7;
        private System.Windows.Forms.Button cmdDigit5;
        private System.Windows.Forms.Button cmdDigit6;
        private System.Windows.Forms.Button cmdDigit4;
        private System.Windows.Forms.Button cmdDigit2;
        private System.Windows.Forms.Button cmdDigit3;
        private System.Windows.Forms.Button cmdDigit1;
        private System.Windows.Forms.Button cmdTransfer;
        private System.Windows.Forms.Button cmdCall;
        private System.Windows.Forms.Button cmdHangup;
        private System.Windows.Forms.Button cmdPickUp;
        private System.Windows.Forms.TextBox txtDial;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ProgressBar progressLevelInput;
        private System.Windows.Forms.ProgressBar progressLevelOutput;

    }
}

