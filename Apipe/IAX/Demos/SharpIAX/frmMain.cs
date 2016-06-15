/* ====================================================================
 * Copyright (c) 2006 Andre Luis Azevedo (az.andrel@yahoo.com.br)
 * All rights reserved.
 *                       
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer. 
 *
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in
 *    the documentation and/or other materials provided with the
 *    distribution.
 * 
 * 3. The name "SharpIAX" must not be used to endorse or promote 
 *    products derived from this software without prior written permission.
 *
 * 4. Products derived from this software may not be called "SharpIAX" nor 
 *    may "SharpIAX" appear in their names without prior written 
 *    permission of the author.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY
 * EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
 * PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR
 * ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
 * OF THE POSSIBILITY OF SUCH DAMAGE. 
 */

using System;
using System.Text;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;

using ALAZ.SystemEx.WindowsEx.FormEx;
using ALAZ.SystemEx.RunTimeEx.InteropServicesEx;
using ALAZ.TelephonyEx.Voip.IAX;

using SharpIAX;

namespace SharpIAX
{

    public partial class frmMain : Form
    {

        //----- Iax client!
        public IAXClientClass iaxc;

        public frmMain()
        {
            InitializeComponent();
        }

        //----- Events
        void iaxc_OnAudioLevel(int input, int output)
        {
            //----- Audio level event!
            progressLevelInput.Value = input;
            progressLevelOutput.Value = output;
        }

        void iaxc_OnTextState(int lineNumber, TextType textType, string text)
        {
            //----- Text event!
            txtStatus.Text = text;
        }

        void iaxc_OnLineState(int lineNumber)
        {

            //----- Line state event!

            //----- Adjust select line button!
            switch (iaxc.Lines.SelectedLine)
            {
                
                case 0:
                    {
                        cmdLine1.ForeColor = Color.Lime;
                        cmdLine2.ForeColor = Color.White;
                        break;
                    }

                case 1:
                    {
                        cmdLine1.ForeColor = Color.White;
                        cmdLine2.ForeColor = Color.Lime;
                        break;
                    }

            }

            //----- Adjust line event components!
            Label labelNumber = null;
            Label labelStatus = null;
            Label labelDirection = null;
            Label labelTime = null;

            switch (lineNumber)
            {
                case 0:
                    {
                        labelNumber = lblNumber1;
                        labelStatus = lblStatus1;
                        labelDirection = lblCallDirection1;
                        labelTime = lblTime1;
                        break;
                    }
                case 1:
                    {
                        labelNumber = lblNumber2;
                        labelStatus = lblStatus2;
                        labelDirection = lblCallDirection2;
                        labelTime = lblTime2;
                        break;
                    }
            }

            //----- Remote number!
            string remote = iaxc.Lines[lineNumber].Remote;

            if (remote == String.Empty)
            {
                labelNumber.Text = "0";
            }
            else
            {
                labelNumber.Text = remote;
            }

            //----- Call status!
            labelStatus.Text = iaxc.Lines[lineNumber].CallStatus.ToString().Substring(2);

            
            if (iaxc.Lines[lineNumber].Active)
            {
                //----- Call direction!
                labelDirection.Text = iaxc.Lines[lineNumber].CallDirection.ToString().Substring(2);
            }
            else
            {
                //----- Call time!
                labelTime.Text = "00:00";
                labelDirection.Text = String.Empty;
            }

            //----- Adjust buttons state!
            cmdCall.Enabled = iaxc.Lines[iaxc.Lines.SelectedLine].Active == false;
            cmdHangup.Enabled = iaxc.Lines[iaxc.Lines.SelectedLine].Active == true;
            cmdPickUp.Enabled = cmdHangup.Enabled && (iaxc.Lines[iaxc.Lines.SelectedLine].CallStatus == CallStatus.csRinging && iaxc.Lines[iaxc.Lines.SelectedLine].CallDirection == CallDirection.cdIncoming);
            cmdTransfer.Enabled = cmdHangup.Enabled && iaxc.Lines[iaxc.Lines.SelectedLine].CallStatus == CallStatus.csComplete;


            if (iaxc.Lines[lineNumber].CallStatus == CallStatus.csRinging)
            {
                //----- Popup
                Show();
                WindowState = FormWindowState.Normal;
            }

        }


        void iaxc_OnRegistration()
        {

            if (iaxc.RegistrationRequired)
            {

                //----- If registration required check registration status!
                if (iaxc.RegistrationStatus == RegistrationStatus.rsCompleted)
                {
                    txtStatus.Text = "Ready";
                    panCommands.Enabled = true;
                    txtDial.Enabled = true;
                }
                else
                {
                    txtStatus.Text = "Registration Error";
                    panCommands.Enabled = false;
                    txtDial.Enabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timTime.Enabled = true;

            //----- Create IAXClient object!
            iaxc = new IAXClientClass(AudioType.atAUDIO_INTERNAL_PA, 2);

            //----- Verify properties!
            if (Properties.Settings.Default.ConfigStatus == -1) 
            {
                txtStatus.Text = "Invalid Configuration";
                cmdConfig.Enabled = true;
            }
            else
            {
                //----- Initilize!
                InitializeVisual();
                InitilizeIAX();
            }

            Refresh();

        }

        private void InitializeVisual()
        {
            Color color = frmConfig.GetColorFromScheme(Properties.Settings.Default.ColorScheme);
            BackColor = color;
        }

        private void InitilizeIAX()
        {

            iaxc.OnRegistration += new OnRegistrationDelegate(iaxc_OnRegistration);
            iaxc.OnAudioLevel += new OnAudioLevelDelegate(iaxc_OnAudioLevel);
            iaxc.OnLineState += new OnLineStateDelegate(iaxc_OnLineState);
            iaxc.OnTextState += new OnTextStateDelegate(iaxc_OnTextState);

            //----- Initialize with 2 lines!
            iaxc.CallerIdName = Properties.Settings.Default.CallerIdName;
            iaxc.CallerIdNumber = Properties.Settings.Default.CallerIdNumber;
            iaxc.Initialize(Properties.Settings.Default.User, Encoding.Default.GetString(Convert.FromBase64String(Properties.Settings.Default.Password)), Properties.Settings.Default.Host, Properties.Settings.Default.Registration);

            //----- Initialize formats!
            iaxc.PreferredFormat = AudioFormat.afIAXC_FORMAT_GSM;
            iaxc.AllowedFormats = AudioFormat.afIAXC_FORMAT_GSM;

            //----- Initialize audio devices!
            iaxc.AudioDevices.SelectInputAudioDevice(1);
            iaxc.AudioDevices.SelectOutPutAudioDevice(3);
            iaxc.AudioDevices.SelectOutPutAudioDevice(3);

            //----- Adjust user and registration message status!
            lblUser.Text = iaxc.User;

            if (iaxc.RegistrationRequired)
            {
                txtStatus.Text = "Initializing...";
            }
            else
            {
                txtStatus.Text = "Ready";
                panCommands.Enabled = true;
                txtDial.Enabled = true;
            }

        }

        private void cmdDropCall_Click(object sender, EventArgs e)
        {
            //----- Drop selected call!
            iaxc.Lines[iaxc.Lines.SelectedLine].DropCall();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //----- Shutdown IAXClient when closing!
            iaxc.ShutDown();
            e.Cancel = false;
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            
            //----- Set datetime!
            lblTime.Text = DateTime.Now.ToShortTimeString();

            if (iaxc != null && iaxc.Lines.Count > 0)
            {

                foreach (IAXLine l in iaxc.Lines)
                {

                    if (l.Active)
                    {

                        //----- If Line is active, adjust the call time!
                        int secondsInt = l.CallTime / 1000;
                        int minutes = secondsInt / 60;
                        int seconds = secondsInt % 60;
                        string time = minutes.ToString("00") + ":" + seconds.ToString("00");

                        switch (l.Id)
                        {

                            case 0: lblTime1.Text = time;
                                break;

                            case 1: lblTime2.Text = time;
                                break;

                        }

                    }

                }
            }
        }

        private void txtDial_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch(e.KeyCode)
            {

                case Keys.Enter:
                {

                    //---- Starts a new call if press <ENTER>!
                    if (txtDial.Text.Length > 0)
                    {
                        iaxc.Lines[iaxc.Lines.SelectedLine].MakeCall(txtDial.Text.Trim());
                        txtDial.Text = String.Empty;
                    }

                    break;

                }

            }

        }

        private void cmdLine1_Click(object sender, EventArgs e)
        {
            //----- Select the line!
            int line = Convert.ToInt32(((Button)sender).Tag);
            iaxc.Lines.SelectLine(line);
        }

        private void cmdCall_Click(object sender, EventArgs e)
        {

            //----- Starts a new call!
            if (txtDial.Text.Length > 0)
            {
                iaxc.Lines[iaxc.Lines.SelectedLine].MakeCall(txtDial.Text.Trim());
                txtDial.Text = String.Empty;
            }

        }

        private void cmdConfig_Click(object sender, EventArgs e)
        {

            using (frmConfig config = new frmConfig(iaxc))
            {

                int configStatus = Properties.Settings.Default.ConfigStatus;

                //----- Show config form!
                DialogResult result = config.ShowDialog();

                if (result == DialogResult.OK && (configStatus == -1) && (Properties.Settings.Default.ConfigStatus == 1))
                {
                    //----- Initilize if press OK!
                    InitilizeIAX();
                }

                InitializeVisual();

            }

        }

        private void cmdPickUp_Click(object sender, EventArgs e)
        {
            //----- Answer ringing call!
            iaxc.Lines[iaxc.Lines.SelectedLine].AnswerCall();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //----- Hide to tray!
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void notifyMain_DoubleClick(object sender, EventArgs e)
        {
            //----- Show form from tray!
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void cmdDigit1_Click(object sender, EventArgs e)
        {

            byte digit = Convert.ToByte(((Button)sender).Text[0]);
            iaxc.PlayDigit(digit);
               
            if (iaxc.Lines[iaxc.Lines.SelectedLine].Active)
            {

                //----- Get button digit!
                //byte digit = Convert.ToByte(((Button)sender).Text[0]);
                iaxc.Lines[iaxc.Lines.SelectedLine].SendDTMF(digit);

            }
            else
            {
                //---- Fill dial textbox!
                txtDial.Text += ((Button)sender).Text[0];
            }

            
        }

        private void cmdTransfer_Click(object sender, EventArgs e)
        {
            iaxc.Lines[iaxc.Lines.SelectedLine].TransferCall(txtDial.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

    }

}