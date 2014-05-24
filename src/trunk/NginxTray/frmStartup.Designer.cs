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
            this.StartNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TrayIcon.BalloonTipClosed += new System.EventHandler(this.TrayIcon_BalloonTipClosed);
            this.TrayIcon.BalloonTipShown += new System.EventHandler(this.TrayIcon_BalloonTipShown);
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // ManageMenuStrip
            // 
            this.ManageMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartNginxMenuItem,
            this.StopNginxMenuItem,
            this.RestartNginxMenuItem});
            this.ManageMenuStrip.Name = "ManageStrip";
            this.ManageMenuStrip.Size = new System.Drawing.Size(163, 70);
            // 
            // StartNginxMenuItem
            // 
            this.StartNginxMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StartNginxMenuItem.Image")));
            this.StartNginxMenuItem.Name = "StartNginxMenuItem";
            this.StartNginxMenuItem.Size = new System.Drawing.Size(162, 22);
            this.StartNginxMenuItem.Text = "Запустить";
            this.StartNginxMenuItem.Click += new System.EventHandler(this.StartNginxMenuItem_Click);
            // 
            // StopNginxMenuItem
            // 
            this.StopNginxMenuItem.Enabled = false;
            this.StopNginxMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StopNginxMenuItem.Image")));
            this.StopNginxMenuItem.Name = "StopNginxMenuItem";
            this.StopNginxMenuItem.Size = new System.Drawing.Size(162, 22);
            this.StopNginxMenuItem.Text = "Остановить";
            this.StopNginxMenuItem.Click += new System.EventHandler(this.StopNginxMenuItem_Click);
            // 
            // RestartNginxMenuItem
            // 
            this.RestartNginxMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RestartNginxMenuItem.Image")));
            this.RestartNginxMenuItem.Name = "RestartNginxMenuItem";
            this.RestartNginxMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RestartNginxMenuItem.Text = "Перезапустить";
            this.RestartNginxMenuItem.Click += new System.EventHandler(this.RestartNginxMenuItem_Click);
            // 
            // SettingsMenuStrip
            // 
            this.SettingsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.autoRunToolStripMenuItem,
            this.SettingsMenuSeparator1,
            this.выходToolStripMenuItem});
            this.SettingsMenuStrip.Name = "contextMenuStrip1";
            this.SettingsMenuStrip.Size = new System.Drawing.Size(156, 76);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкиToolStripMenuItem.Image")));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.SettingsNginxMenuItem_Click);
            // 
            // autoRunToolStripMenuItem
            // 
            this.autoRunToolStripMenuItem.Name = "autoRunToolStripMenuItem";
            this.autoRunToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.autoRunToolStripMenuItem.Text = "Автозагрузка";
            this.autoRunToolStripMenuItem.Click += new System.EventHandler(this.autoRunToolStripMenuItem_Click);
            // 
            // SettingsMenuSeparator1
            // 
            this.SettingsMenuSeparator1.Name = "SettingsMenuSeparator1";
            this.SettingsMenuSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitNginxMenuItem_Click);
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
            this.startIcon.BalloonTipClosed += new System.EventHandler(this.TrayIcon_BalloonTipClosed);
            this.startIcon.BalloonTipShown += new System.EventHandler(this.TrayIcon_BalloonTipShown);
            this.startIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // stopIcon
            // 
            this.stopIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("stopIcon.Icon")));
            this.stopIcon.Text = "Nginx-сервер остановлен";
            this.stopIcon.BalloonTipClosed += new System.EventHandler(this.TrayIcon_BalloonTipClosed);
            this.stopIcon.BalloonTipShown += new System.EventHandler(this.TrayIcon_BalloonTipShown);
            this.stopIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // errorIcon
            // 
            this.errorIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("errorIcon.Icon")));
            this.errorIcon.Text = "Ошибка";
            this.errorIcon.BalloonTipClicked += new System.EventHandler(this.TrayIcon_BalloonTipClosed);
            this.errorIcon.BalloonTipClosed += new System.EventHandler(this.TrayIcon_BalloonTipClosed);
            this.errorIcon.BalloonTipShown += new System.EventHandler(this.TrayIcon_BalloonTipShown);
            this.errorIcon.Click += new System.EventHandler(this.TrayIcon_BalloonTipClosed);
            this.errorIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
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
        private System.Windows.Forms.ToolStripMenuItem StartNginxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopNginxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartNginxMenuItem;
        private System.Windows.Forms.ContextMenuStrip SettingsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator SettingsMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem autoRunToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon startIcon;
        private System.Windows.Forms.NotifyIcon stopIcon;
        private System.Windows.Forms.NotifyIcon errorIcon;
    }
}

