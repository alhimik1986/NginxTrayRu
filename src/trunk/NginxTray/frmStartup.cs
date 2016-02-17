using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Reflection;
using IWshRuntimeLibrary;

namespace NginxTray
{
    public partial class frmStartup : Form
    {
        // Process object for 
        protected ProcessManagement processList;

        // Constructor
        public frmStartup()
        {
            // including IWshRuntimeLibrary.dll in the .exe-project
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
            //IWshRuntimeLibrary.FileSystemObject a = new IWshRuntimeLibrary.FileSystemObject();
           this.foo();

            InitializeComponent();
            base.SetVisibleCore(false); // Hide this form at startup

        }

        // check is the program in auto run
        private void frmStartup_Load(object sender, EventArgs e)
        {
            AutoRun autoRun = new AutoRun();

            if (System.IO.File.Exists(autoRun.appName + ".settings.xml"))
            {
                // Read the configuration object from a file and write it to the Properties.Settings.Default (if it exists!)
                XMLSettingsManager xml = XMLSettingsManager.Deserialize(autoRun.appName + ".settings.xml");
                Properties.Settings.Default.Files                = xml.Files.Replace("\n", "\r\n");
                Properties.Settings.Default.Arguments            = xml.Arguments.Replace("\n", "\r\n");
                Properties.Settings.Default.FilesTerminate       = xml.FilesTerminate.Replace("\n", "\r\n");
                Properties.Settings.Default.ArgumentsTerminate   = xml.ArgumentsTerminate.Replace("\n", "\r\n");
                Properties.Settings.Default.EnvironmentVariables = xml.EnvironmentVariables.Replace("\n", "\r\n");
                Properties.Settings.Default.Notify               = xml.Notify;
                Properties.Settings.Default.Restart              = xml.Restart;
            }

            this.MenuItemStart_Click1();
        }

        // Start Nginx Group
        private void MenuItemStart_Click(object sender, EventArgs e)
        {
            this.MenuItemStart_Click1();
        }

        public void MenuItemStart_Click1()
        {
            this.processList = new ProcessManagement();
            this.MenuItemStart.Enabled = false;
            this.MenuItemStop.Enabled = true;

            if (this.processList.start()) // Call function to start Nginx
            {
                this.showIcon(startIcon);
                timer1.Enabled = true;
                return;
            }
            else
            {
                this.showIcon(errorIcon);
                errorIcon.ShowBalloonTip(1000, "Ошибка в командной строке", "Не удалось запустить " + this.processList.ProcessIndex + "-й процесс", ToolTipIcon.Error);
            }
        }

        // Stop Nginx Group
        private void MenuItemStop_Click(object sender, EventArgs e)
        {
            this.MenuItemStop_Click1();
        }

        private void MenuItemStop_Click1()
        {
            timer1.Enabled = false;
            //this.processList = new ProcessManagement();
            this.processList.stop();

            this.MenuItemStart.Enabled = true;
            this.MenuItemStop.Enabled = false;
            this.showIcon(stopIcon);
        }

        // Restart Nginx Group
        private void MenuItemRestart_Click(object sender, EventArgs e)
        {
            this.MenuItemRestart_Click1();
        }

        private void MenuItemRestart_Click1()
        {
            this.MenuItemStop_Click1();
            Thread.Sleep(500);
            this.MenuItemStart_Click1();
        }

        // Show Settings Form
        private void MenuItemSettings_Click(object sender, EventArgs e)
        {
            frmSettings form = new frmSettings();
            form.Show();
        }

        // Exit NginxTray
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.MenuItemStop_Click1();
            Application.Exit();
        }

        // Enable contextstripmenu with left click and with right click
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


        // Periodically check all processes is launced.
        private void timer1_Tick(object sender, EventArgs e)
        {
            string process = this.processList.checkProcessesExists();

            if (process.Length != 0)
            {
                if (errorIcon.Visible == false)
                {
                    this.showIcon(errorIcon);
                    if (Properties.Settings.Default.Notify) errorIcon.ShowBalloonTip(1000, process + " не запущен", "Не найден процесс с именем " + process + ".exe", ToolTipIcon.Error);
                }
                if (Properties.Settings.Default.Restart)
                {
                    Thread.Sleep(1000);
                    this.MenuItemRestart_Click1();
                }
            }
            else
            {
                if (errorIcon.Visible && MenuItemStart.Enabled)
                {
                    this.showIcon(startIcon);
                }
            }
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

        private void foo()
        {
            IWshRuntimeLibrary.FileSystemObject a = new IWshRuntimeLibrary.FileSystemObject();
        }

    }

}
