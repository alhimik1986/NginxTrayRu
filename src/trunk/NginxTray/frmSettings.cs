using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NginxTray
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            textBoxFiles.Text                = Properties.Settings.Default.Files;
            textBoxArguments.Text            = Properties.Settings.Default.Arguments;
            textBoxEnvironmentVariables.Text = Properties.Settings.Default.EnvironmentVariables;
            checkBoxNotify.Checked           = Properties.Settings.Default.Notify;
            checkBoxRestart.Checked          = Properties.Settings.Default.Restart;

            AutoRun autoRun = new AutoRun();
            checkBoxAutoRun.Checked = autoRun.isAutoRun();

        }

        //Save Settings textbox in settings variables
        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Files                = textBoxFiles.Text;
            Properties.Settings.Default.Arguments            = textBoxArguments.Text;
            Properties.Settings.Default.EnvironmentVariables = textBoxEnvironmentVariables.Text;
            Properties.Settings.Default.Notify               = checkBoxNotify.Checked;
            Properties.Settings.Default.Restart              = checkBoxRestart.Checked;
            Properties.Settings.Default.Save();

            AutoRun autoRun = new AutoRun();
            autoRun.appShortcutToAutoRunFolder(checkBoxAutoRun.Checked);

            this.Close();

        }

        // Close Settings Windows
        private void SettingsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
