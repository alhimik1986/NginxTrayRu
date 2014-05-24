using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace NginxTray
{
    public partial class frmStartup : Form
    {
        // Constructor
        public frmStartup()
        {
            InitializeComponent();
            base.SetVisibleCore(false); // Hide this form at startup
        }


        // Start Nginx function
        private bool StartNginx()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxFile = Properties.Settings.Default.NginxFile; // Take Nginx Directory from settings
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            if (ProcM.StartProcess(nginxFile, "") == false) // If there are problems, show a ballontip error
            {
                TrayIcon.ShowBalloonTip(20000, "Nginx не запущен", "Неправильный путь к файлу\n " + nginxFile, ToolTipIcon.Error);
                return false;
            }

            return true;
        }

        // Stop Nginx function
        private void StopNginx()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxprocess;

            nginxprocess = Properties.Settings.Default.NginxFile.Replace(".exe", "");

            ProcM.StopProcess(nginxprocess);
        }

        // Start PHP function
        private bool StartPHP()
        {
            ProcessManagement ProcM = new ProcessManagement();
            string phpFile = Properties.Settings.Default.PHPFile; // Take Nginx Directory from settings
            string phparguments = "-b " + Properties.Settings.Default.PHPAddress;
            if (Properties.Settings.Default.PHPINIFile.Length != 0)
            {
                phparguments += " -c " + Properties.Settings.Default.PHPINIFile;
            }

            if (Properties.Settings.Default.PHPEnable)
            {
                // If there are problems, show a ballontip error
                if (ProcM.StartProcess(phpFile, phparguments) == false)
                {
                    TrayIcon.ShowBalloonTip(1, "PHP не запущен", "Неправильный путь к файлам или FastCGI-адрес\n " + phpFile + " " + phparguments, ToolTipIcon.Error);
                    return false;
                }
            }

            return true;
        }

        // Stop PHP function
        private void StopPHP()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string phpprocess;

            phpprocess = Properties.Settings.Default.PHPFile;

            ProcM.StopProcess(phpprocess);
        }

        // Start Nginx Group
        private void StartNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StartNginxMenuItem_Click1();
        }

        public void StartNginxMenuItem_Click1()
        {
            if (this.StartNginx()) // Call function to start Nginx
            {
                if (Properties.Settings.Default.PHPEnable)
                {
                    if (!this.StartPHP())
                    { // Call function to start PHP
                        return;
                    }
                }

                this.StartNginxMenuItem.Enabled = false;
                this.StopNginxMenuItem.Enabled = true;
                this.showIcon(startIcon);

                timer1.Enabled = true;
                return;
            }
        }

        // Stop Nginx Group
        private void StopNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StopNginxMenuItem_Click1();
        }

        private void StopNginxMenuItem_Click1()
        {
            this.StopNginx(); // Call function to stop Nginx
            this.StopPHP(); // Call function to stop PHP

            this.StartNginxMenuItem.Enabled = true;
            this.StopNginxMenuItem.Enabled = false;
            this.showIcon(stopIcon);

            timer1.Enabled = false;
        }

        // Restart Nginx Group
        private void RestartNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StopNginxMenuItem_Click1();
            this.StartNginxMenuItem_Click1();
            this.showIcon(startIcon);
        }

        // Show Settings Form
        private void SettingsNginxMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings form = new frmSettings();
            form.Show();
        }

        // Exit NginxTray
        private void ExitNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StopNginx(); // Call function to stop Nginx
            this.StopPHP(); // Call function to stop PHP

            Application.Exit();
        }

        // Enable contextstripmenu with left click
        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TrayIcon.ContextMenuStrip = ManageMenuStrip;
            }
            else
            {
                TrayIcon.ContextMenuStrip = SettingsMenuStrip;
            }

            System.Reflection.MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            mi.Invoke(TrayIcon, null);
        }

        // Add/Remove AutoRun (start when Windows is starting)
        private void autoRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoRun autoRun = new AutoRun();
            autoRunToolStripMenuItem.Checked = ! autoRunToolStripMenuItem.Checked;

            if (autoRunToolStripMenuItem.Checked) {
                autoRun.addAutoRun();
            } else {
                autoRun.removeAutoRun();
            }

            autoRunToolStripMenuItem.Checked = autoRun.IsStartupItem();
        }

        // check is the program in auto run
        private void frmStartup_Load(object sender, EventArgs e)
        {
            AutoRun autoRun = new AutoRun();
            autoRunToolStripMenuItem.Checked = autoRun.IsStartupItem();
            this.StartNginxMenuItem_Click1();
        }

        // Periodically check the Nginx is launced.
        private void timer1_Tick(object sender, EventArgs e)
        {
            string process;
            ProcessManagement ProcM = new ProcessManagement();
            Process[] processgroup;

            // Проверяю процесс nginx
            process = Properties.Settings.Default.NginxFile.Replace(".exe", "");
            process = Path.GetFileNameWithoutExtension(process);

            processgroup = Process.GetProcessesByName(process); // Select processes with that name
            if (processgroup == null || processgroup.Length == 0)
            {
                errorIcon.ShowBalloonTip(1000, "Nginx не запущен", "Не найден процесс с именем " + process + ".exe", ToolTipIcon.Error);
                this.showIcon(errorIcon);
                return;
            }

            // Проверяю наличие процесса php-cgi
            if (Properties.Settings.Default.PHPEnable)
            {
                process = Properties.Settings.Default.PHPFile.Replace(".exe", "");
                process = Path.GetFileNameWithoutExtension(process);

                processgroup = Process.GetProcessesByName(process); // Select processes with that name
                if (processgroup == null || processgroup.Length == 0)
                {
                    errorIcon.ShowBalloonTip(1000, "PHP не запущен", "Не найден процесс с именем " + process + ".exe", ToolTipIcon.Error);
                    this.showIcon(errorIcon);
                }
            }

        }

        // increase timeout when user close balloon tip to that does not cover mouse cursor
        private void TrayIcon_BalloonTipClosed(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
        }

        private void TrayIcon_BalloonTipShown(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }


        // Show tray icon, specified in sh_icon and hide remaining tray icons.
        public void showIcon(NotifyIcon sh_icon)
        {
            List<NotifyIcon> icons;
            icons = new List<NotifyIcon>();
            icons.Add(TrayIcon);
            icons.Add(startIcon);
            icons.Add(stopIcon);
            icons.Add(errorIcon);

            foreach(NotifyIcon icon in icons) {
                icon.Visible = sh_icon.Equals(icon);
            }
        }

    }

}
