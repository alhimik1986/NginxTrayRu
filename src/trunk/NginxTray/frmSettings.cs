using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NginxTray
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            textBoxNginxFile.Text = Properties.Settings.Default.NginxFile;

            checkBoxPHPEnable.Checked = Properties.Settings.Default.PHPEnable;

            panelSettingsPHP.Enabled = checkBoxPHPEnable.Checked;

            textBoxPHPFile.Text = Properties.Settings.Default.PHPFile;

            textBoxPHPINIFile.Text = Properties.Settings.Default.PHPINIFile;

            textBoxPHPAddress.Text = Properties.Settings.Default.PHPAddress;
        }

        //Save Settings textbox in settings variables
        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NginxFile = textBoxNginxFile.Text;

            Properties.Settings.Default.PHPEnable = checkBoxPHPEnable.Checked;

            Properties.Settings.Default.PHPFile = textBoxPHPFile.Text;

            Properties.Settings.Default.PHPINIFile = textBoxPHPINIFile.Text;

            Properties.Settings.Default.PHPAddress = textBoxPHPAddress.Text;

            Properties.Settings.Default.Save();

            this.Close();

        }

        // Close Settings Windows
        private void SettingsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Enable and disable the PHP Settings panel
        private void checkBoxPHPEnable_CheckedChanged_1(object sender, EventArgs e)
        {
            panelSettingsPHP.Enabled = checkBoxPHPEnable.Checked;
        }

    }
}
