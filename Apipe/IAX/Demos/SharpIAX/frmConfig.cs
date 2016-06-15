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
using System.Windows.Forms;

using ALAZ.TelephonyEx.Voip.IAX;

namespace SharpIAX
{
    
    public partial class frmConfig : Form
    {

        private IAXClientClass iaxc;

        public static Color GetColorFromScheme(int colorScheme)
        {

            Color color = Color.Transparent;

            switch (colorScheme)
            {

                case 0:
                    {
                        color = Color.DarkGray;
                        break;
                    }


                case 1:
                    {
                        color = Color.Black;
                        break;
                    }

                case 2:
                    {
                        color = Color.SlateBlue;
                        break;
                    }


                case 3:
                    {
                        color = Color.Crimson;
                        break;
                    }

                case 4:
                    {
                        color = Color.LightPink;
                        break;
                    }

                case 5:
                    {
                        color = Color.MediumSeaGreen;
                        break;
                    }


            }

            return color;
        
        }

        public frmConfig(IAXClientClass iaxclient)
        {

            //----- Initialize form components!
            InitializeComponent();

            iaxc = iaxclient;
            lblIAX.Text = "IAX Library Version: " + iaxc.Version;

            //----- Initialize config components!

            cboInput.ValueMember = "Id";
            cboInput.DisplayMember = "Name";

            cboOutput.ValueMember = "Id";
            cboOutput.DisplayMember = "Name";

            cboRing.ValueMember = "Id";
            cboRing.DisplayMember = "Name";

            //----- Verify devices!
            foreach (IAXAudioDevice device in iaxc.AudioDevices)
            {

                //----- Input!
                if ((device.Capabilities & AudioCapability.acIAXC_AD_INPUT) == AudioCapability.acIAXC_AD_INPUT)
                {
                    cboInput.Items.Add(device);
                }

                //----- Output!
                if ((device.Capabilities & AudioCapability.acIAXC_AD_OUTPUT) == AudioCapability.acIAXC_AD_OUTPUT)
                {
                    cboOutput.Items.Add(device);
                }

                //----- Ring!
                if ((device.Capabilities & AudioCapability.axIAXC_AD_RING) == AudioCapability.axIAXC_AD_RING)
                {
                    cboRing.Items.Add(device);
                }

            }


        }

        private void frmConfig_Load(object sender, EventArgs e)
        {

            //----- Check config status!
            if (Properties.Settings.Default.ConfigStatus == -1)
            {

                //----- Load default values!
                txtUser.Text = String.Empty;
                txtPassword.Text = String.Empty;
                txtHost.Text = String.Empty;
                txtCallerIdName.Text = "SharpIAX";
                txtCallerIdNumber.Text = "(Not Specified)";
                chkRegistration.Checked = true;

                rbG711Alaw.Checked = false;
                rbG711Ulaw.Checked = false;
                rbiLBC.Checked = false;
                rbSpeex.Checked = false;
                rbGSM.Checked = true;

                chkG711Alaw.Checked = false;
                chkG711Ulaw.Checked = false;
                chkiLBC.Checked = false;
                chkSpeex.Checked = false;
                chkGSM.Checked = true;

                cboColorScheme.SelectedIndex = 0;

                if (cboInput.Items.Count > 0)
                    cboInput.SelectedIndex = cboInput.FindString(iaxc.AudioDevices[iaxc.AudioDevices.SelectedInputAudioDevice].Name);

                if (cboOutput.Items.Count > 0)
                    cboOutput.SelectedIndex = cboOutput.FindString(iaxc.AudioDevices[iaxc.AudioDevices.SelectedOutputAudioDevice].Name);

                if (cboRing.Items.Count > 0)
                    cboRing.SelectedIndex = cboRing.FindString(iaxc.AudioDevices[iaxc.AudioDevices.SelectedRingAudioDevice].Name);

            }
            else
            {

                //----- Load config values!
                txtUser.Text = Properties.Settings.Default.User;
                txtPassword.Text = Encoding.Default.GetString(Convert.FromBase64String(Properties.Settings.Default.Password));
                txtHost.Text = Properties.Settings.Default.Host;
                txtCallerIdName.Text = Properties.Settings.Default.CallerIdName;
                txtCallerIdNumber.Text = Properties.Settings.Default.CallerIdNumber;
                chkRegistration.Checked = Properties.Settings.Default.Registration;

                rbG711Alaw.Checked = Properties.Settings.Default.Preferred == (int) AudioFormat.afIAXC_FORMAT_ALAW;
                rbG711Ulaw.Checked = Properties.Settings.Default.Preferred == (int)AudioFormat.afIAXC_FORMAT_ULAW;
                rbiLBC.Checked = Properties.Settings.Default.Preferred == (int)AudioFormat.afIAXC_FORMAT_ILBC;
                rbSpeex.Checked = Properties.Settings.Default.Preferred == (int)AudioFormat.afIAXC_FORMAT_SPEEX;
                rbGSM.Checked = Properties.Settings.Default.Preferred == (int)AudioFormat.afIAXC_FORMAT_GSM;

                chkG711Alaw.Checked = ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_ALAW) == (int)AudioFormat.afIAXC_FORMAT_ALAW);
                chkG711Ulaw.Checked = ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_ULAW) == (int)AudioFormat.afIAXC_FORMAT_ULAW);
                chkiLBC.Checked = ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_ILBC) == (int)AudioFormat.afIAXC_FORMAT_ILBC);
                chkSpeex.Checked = ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_SPEEX) == (int)AudioFormat.afIAXC_FORMAT_SPEEX);
                chkGSM.Checked = ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_GSM) == (int)AudioFormat.afIAXC_FORMAT_GSM);

                cboColorScheme.SelectedIndex = Properties.Settings.Default.ColorScheme;

                if (cboInput.Items.Count > 0)
                    cboInput.SelectedIndex = cboInput.FindString(Properties.Settings.Default.Input);

                if (cboOutput.Items.Count > 0)
                    cboOutput.SelectedIndex = cboOutput.FindString(Properties.Settings.Default.Output);

                if (cboRing.Items.Count > 0)
                    cboRing.SelectedIndex = cboRing.FindString(Properties.Settings.Default.Ring);
                                      
            }

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            
            //----- Check config params!
            if ( 
                (txtUser.Text == String.Empty)
                || (txtHost.Text == String.Empty) )
            {
                MessageBox.Show("Invalid network settings - User or Host");
                tabpanConfig.SelectedTab = tabNetwork;
                return;
            }

            if ( !(rbG711Alaw.Checked
                || rbG711Ulaw.Checked
                || rbGSM.Checked
                || rbiLBC.Checked
                || rbSpeex.Checked) )
            {
                MessageBox.Show("Invalid codec settings - Preferred");
                tabpanConfig.SelectedTab = tabNetwork;
                return;
            }

            if ( !(chkG711Alaw.Checked
                || chkG711Ulaw.Checked
                || chkGSM.Checked
                || chkiLBC.Checked
                || chkSpeex.Checked) )
            {
                MessageBox.Show("Invalid codec settings - Allowed");
                tabpanConfig.SelectedTab = tabNetwork;
                return;
            }

            if ( (cboInput.SelectedIndex == -1)
                || (cboOutput.SelectedIndex == -1)
                || (cboRing.SelectedIndex == -1) )
            {
                MessageBox.Show("Invalid audio devices settings");
                tabpanConfig.SelectedTab = tabAudio;
                return;
            }

            try
            {

                //----- If all OK, save settings!
                Properties.Settings.Default.User = txtUser.Text;
                Properties.Settings.Default.Password = Convert.ToBase64String(Encoding.Default.GetBytes(txtPassword.Text));
                Properties.Settings.Default.Host = txtHost.Text;
                Properties.Settings.Default.CallerIdName = txtCallerIdName.Text;
                Properties.Settings.Default.CallerIdNumber = txtCallerIdNumber.Text;
                Properties.Settings.Default.Registration = chkRegistration.Checked;
                Properties.Settings.Default.ColorScheme = cboColorScheme.SelectedIndex;

                //----- Preferred!
                if (rbG711Alaw.Checked)
                {
                    Properties.Settings.Default.Preferred = (int)AudioFormat.afIAXC_FORMAT_ALAW;
                }

                if (rbG711Ulaw.Checked)
                {
                    Properties.Settings.Default.Preferred = (int)AudioFormat.afIAXC_FORMAT_ULAW;
                }

                if (rbGSM.Checked)
                {
                    Properties.Settings.Default.Preferred = (int)AudioFormat.afIAXC_FORMAT_GSM;
                }

                if (rbiLBC.Checked)
                {
                    Properties.Settings.Default.Preferred = (int)AudioFormat.afIAXC_FORMAT_ILBC;
                }

                if (rbSpeex.Checked)
                {
                    Properties.Settings.Default.Preferred = (int)AudioFormat.afIAXC_FORMAT_SPEEX;
                }

                //----- Allowed!
                if (chkG711Alaw.Checked)
                {
                    Properties.Settings.Default.Allowed |= (int)AudioFormat.afIAXC_FORMAT_ALAW;
                }
                else
                {

                    if( (Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_ALAW) == (int)AudioFormat.afIAXC_FORMAT_ALAW )
                    {
                        Properties.Settings.Default.Allowed ^= (int)AudioFormat.afIAXC_FORMAT_ALAW;
                    }

                }

                if (chkG711Ulaw.Checked)
                {
                    Properties.Settings.Default.Allowed |= (int)AudioFormat.afIAXC_FORMAT_ULAW;
                }
                else
                {
                    if ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_ULAW) == (int)AudioFormat.afIAXC_FORMAT_ULAW)
                    {
                        Properties.Settings.Default.Allowed ^= (int)AudioFormat.afIAXC_FORMAT_ULAW;
                    }
                }

                if (chkGSM.Checked)
                {
                    Properties.Settings.Default.Allowed |= (int)AudioFormat.afIAXC_FORMAT_GSM;
                }
                else
                {
                    if ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_GSM) == (int)AudioFormat.afIAXC_FORMAT_GSM)
                    {
                        Properties.Settings.Default.Allowed ^= (int)AudioFormat.afIAXC_FORMAT_GSM;
                    }
                }

                if (chkiLBC.Checked)
                {
                    Properties.Settings.Default.Allowed |= (int)AudioFormat.afIAXC_FORMAT_ILBC;
                }
                else
                {
                    if ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_ILBC) == (int)AudioFormat.afIAXC_FORMAT_ILBC)
                    {
                        Properties.Settings.Default.Allowed ^= (int)AudioFormat.afIAXC_FORMAT_ILBC;
                    }
                }

                if (chkSpeex.Checked)
                {
                    Properties.Settings.Default.Allowed |= (int)AudioFormat.afIAXC_FORMAT_SPEEX;
                }
                else
                {
                    if ((Properties.Settings.Default.Allowed & (int)AudioFormat.afIAXC_FORMAT_SPEEX) == (int)AudioFormat.afIAXC_FORMAT_SPEEX)
                    {
                        Properties.Settings.Default.Allowed ^= (int)AudioFormat.afIAXC_FORMAT_SPEEX;
                    }
                }

                //----- Audio devices!
                Properties.Settings.Default.Input = ((IAXAudioDevice) cboInput.SelectedItem).Name;
                Properties.Settings.Default.Output = ((IAXAudioDevice)cboOutput.SelectedItem).Name;
                Properties.Settings.Default.Ring = ((IAXAudioDevice) cboRing.SelectedItem).Name;

                //----- Save!
                Properties.Settings.Default.ConfigStatus = 1;
                Properties.Settings.Default.Save();

            }
            catch
            {
                MessageBox.Show("Configuration settings error");
            }

            DialogResult = DialogResult.OK;

        }

        private void cboColorScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = GetColorFromScheme(((ComboBox)sender).SelectedIndex);
            panCommands.BackColor = color;
        }

    }
}