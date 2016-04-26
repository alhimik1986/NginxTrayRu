namespace NginxTray
{
    partial class frmStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartup));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ManageMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.stopIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ManageMenuStrip.SuspendLayout();
            this.SettingsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.ManageMenuStrip;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Nginx-сервер";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // ManageMenuStrip
            // 
            this.ManageMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStart,
            this.MenuItemStop,
            this.MenuItemRestart});
            this.ManageMenuStrip.Name = "ManageStrip";
            this.ManageMenuStrip.Size = new System.Drawing.Size(163, 70);
            // 
            // MenuItemStart
            // 
            this.MenuItemStart.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemStart.Image")));
            this.MenuItemStart.Name = "MenuItemStart";
            this.MenuItemStart.Size = new System.Drawing.Size(162, 22);
            this.MenuItemStart.Text = "Запустить";
            this.MenuItemStart.Click += new System.EventHandler(this.MenuItemStart_Click);
            // 
            // MenuItemStop
            // 
            this.MenuItemStop.Enabled = false;
            this.MenuItemStop.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemStop.Image")));
            this.MenuItemStop.Name = "MenuItemStop";
            this.MenuItemStop.Size = new System.Drawing.Size(162, 22);
            this.MenuItemStop.Text = "Остановить";
            this.MenuItemStop.Click += new System.EventHandler(this.MenuItemStop_Click);
            // 
            // MenuItemRestart
            // 
            this.MenuItemRestart.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemRestart.Image")));
            this.MenuItemRestart.Name = "MenuItemRestart";
            this.MenuItemRestart.Size = new System.Drawing.Size(162, 22);
            this.MenuItemRestart.Text = "Перезапустить";
            this.MenuItemRestart.Click += new System.EventHandler(this.MenuItemRestart_Click);
            // 
            // SettingsMenuStrip
            // 
            this.SettingsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettings,
            this.SettingsMenuSeparator1,
            this.MenuItemExit});
            this.SettingsMenuStrip.Name = "contextMenuStrip1";
            this.SettingsMenuStrip.Size = new System.Drawing.Size(140, 54);
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSettings.Image")));
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.Size = new System.Drawing.Size(139, 22);
            this.MenuItemSettings.Text = "Настройки";
            this.MenuItemSettings.Click += new System.EventHandler(this.MenuItemSettings_Click);
            // 
            // SettingsMenuSeparator1
            // 
            this.SettingsMenuSeparator1.Name = "SettingsMenuSeparator1";
            this.SettingsMenuSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemExit.Image")));
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(139, 22);
            this.MenuItemExit.Text = "Выход";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startIcon
            // 
            this.startIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("startIcon.Icon")));
            this.startIcon.Text = "Nginx-сервер запущен";
            this.startIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // stopIcon
            // 
            this.stopIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("stopIcon.Icon")));
            this.stopIcon.Text = "Nginx-сервер остановлен";
            this.stopIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // errorIcon
            // 
            this.errorIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("errorIcon.Icon")));
            this.errorIcon.Text = "Ошибка";
            this.errorIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartup";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nginx-сервер";
            this.Load += new System.EventHandler(this.frmStartup_Load);
            this.ManageMenuStrip.ResumeLayout(false);
            this.SettingsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip ManageMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStop;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRestart;
        private System.Windows.Forms.ContextMenuStrip SettingsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripSeparator SettingsMenuSeparator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon startIcon;
        private System.Windows.Forms.NotifyIcon stopIcon;
        private System.Windows.Forms.NotifyIcon errorIcon;
    }
}

