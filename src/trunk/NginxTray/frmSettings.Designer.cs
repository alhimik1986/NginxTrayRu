namespace NginxTray
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panelSettingsPHP = new System.Windows.Forms.Panel();
            this.labelPHPINIExample = new System.Windows.Forms.Label();
            this.labelPHPINI = new System.Windows.Forms.Label();
            this.textBoxPHPINIFile = new System.Windows.Forms.TextBox();
            this.labelPHPAddress = new System.Windows.Forms.Label();
            this.labelPHPFile = new System.Windows.Forms.Label();
            this.labelPHPAddressExample = new System.Windows.Forms.Label();
            this.textBoxPHPAddress = new System.Windows.Forms.TextBox();
            this.labelPHPFileExample = new System.Windows.Forms.Label();
            this.textBoxPHPFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PHPSettingsSaveButton = new System.Windows.Forms.Button();
            this.checkBoxPHPEnable = new System.Windows.Forms.CheckBox();
            this.ExampleLabel2 = new System.Windows.Forms.Label();
            this.NginxProcessLabel = new System.Windows.Forms.Label();
            this.textBoxNginxFile = new System.Windows.Forms.TextBox();
            this.panelSettingsPHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettingsPHP
            // 
            this.panelSettingsPHP.Controls.Add(this.labelPHPINIExample);
            this.panelSettingsPHP.Controls.Add(this.labelPHPINI);
            this.panelSettingsPHP.Controls.Add(this.textBoxPHPINIFile);
            this.panelSettingsPHP.Controls.Add(this.labelPHPAddress);
            this.panelSettingsPHP.Controls.Add(this.labelPHPFile);
            this.panelSettingsPHP.Controls.Add(this.labelPHPAddressExample);
            this.panelSettingsPHP.Controls.Add(this.textBoxPHPAddress);
            this.panelSettingsPHP.Controls.Add(this.labelPHPFileExample);
            this.panelSettingsPHP.Controls.Add(this.textBoxPHPFile);
            this.panelSettingsPHP.Location = new System.Drawing.Point(27, 122);
            this.panelSettingsPHP.Name = "panelSettingsPHP";
            this.panelSettingsPHP.Size = new System.Drawing.Size(389, 152);
            this.panelSettingsPHP.TabIndex = 23;
            // 
            // labelPHPINIExample
            // 
            this.labelPHPINIExample.AutoSize = true;
            this.labelPHPINIExample.Location = new System.Drawing.Point(117, 133);
            this.labelPHPINIExample.Name = "labelPHPINIExample";
            this.labelPHPINIExample.Size = new System.Drawing.Size(97, 13);
            this.labelPHPINIExample.TabIndex = 28;
            this.labelPHPINIExample.Text = "Например: c:\\php";
            // 
            // labelPHPINI
            // 
            this.labelPHPINI.AutoSize = true;
            this.labelPHPINI.Location = new System.Drawing.Point(47, 113);
            this.labelPHPINI.Name = "labelPHPINI";
            this.labelPHPINI.Size = new System.Drawing.Size(71, 13);
            this.labelPHPINI.TabIndex = 28;
            this.labelPHPINI.Text = "php.ini папка";
            // 
            // textBoxPHPINIFile
            // 
            this.textBoxPHPINIFile.Location = new System.Drawing.Point(120, 110);
            this.textBoxPHPINIFile.Name = "textBoxPHPINIFile";
            this.textBoxPHPINIFile.Size = new System.Drawing.Size(258, 20);
            this.textBoxPHPINIFile.TabIndex = 27;
            // 
            // labelPHPAddress
            // 
            this.labelPHPAddress.AutoSize = true;
            this.labelPHPAddress.Location = new System.Drawing.Point(11, 65);
            this.labelPHPAddress.Name = "labelPHPAddress";
            this.labelPHPAddress.Size = new System.Drawing.Size(103, 13);
            this.labelPHPAddress.TabIndex = 17;
            this.labelPHPAddress.Text = "PHP FastCGI адрес";
            // 
            // labelPHPFile
            // 
            this.labelPHPFile.AutoSize = true;
            this.labelPHPFile.Location = new System.Drawing.Point(15, 13);
            this.labelPHPFile.Name = "labelPHPFile";
            this.labelPHPFile.Size = new System.Drawing.Size(99, 13);
            this.labelPHPFile.TabIndex = 16;
            this.labelPHPFile.Text = "PHP FastCGI файл";
            // 
            // labelPHPAddressExample
            // 
            this.labelPHPAddressExample.AutoSize = true;
            this.labelPHPAddressExample.Location = new System.Drawing.Point(117, 85);
            this.labelPHPAddressExample.Name = "labelPHPAddressExample";
            this.labelPHPAddressExample.Size = new System.Drawing.Size(137, 13);
            this.labelPHPAddressExample.TabIndex = 15;
            this.labelPHPAddressExample.Text = "Например: 127.0.0.1:9000";
            // 
            // textBoxPHPAddress
            // 
            this.textBoxPHPAddress.Location = new System.Drawing.Point(120, 62);
            this.textBoxPHPAddress.Name = "textBoxPHPAddress";
            this.textBoxPHPAddress.Size = new System.Drawing.Size(258, 20);
            this.textBoxPHPAddress.TabIndex = 14;
            // 
            // labelPHPFileExample
            // 
            this.labelPHPFileExample.AutoSize = true;
            this.labelPHPFileExample.Location = new System.Drawing.Point(117, 33);
            this.labelPHPFileExample.Name = "labelPHPFileExample";
            this.labelPHPFileExample.Size = new System.Drawing.Size(165, 13);
            this.labelPHPFileExample.TabIndex = 12;
            this.labelPHPFileExample.Text = "Например: \\..\\php5\\php-cgi.exe";
            // 
            // textBoxPHPFile
            // 
            this.textBoxPHPFile.Location = new System.Drawing.Point(120, 10);
            this.textBoxPHPFile.Name = "textBoxPHPFile";
            this.textBoxPHPFile.Size = new System.Drawing.Size(258, 20);
            this.textBoxPHPFile.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SettingsCloseButton_Click);
            // 
            // PHPSettingsSaveButton
            // 
            this.PHPSettingsSaveButton.Location = new System.Drawing.Point(171, 280);
            this.PHPSettingsSaveButton.Name = "PHPSettingsSaveButton";
            this.PHPSettingsSaveButton.Size = new System.Drawing.Size(111, 29);
            this.PHPSettingsSaveButton.TabIndex = 21;
            this.PHPSettingsSaveButton.Text = "Сохранить";
            this.PHPSettingsSaveButton.UseVisualStyleBackColor = true;
            this.PHPSettingsSaveButton.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // checkBoxPHPEnable
            // 
            this.checkBoxPHPEnable.AutoSize = true;
            this.checkBoxPHPEnable.Location = new System.Drawing.Point(33, 87);
            this.checkBoxPHPEnable.Name = "checkBoxPHPEnable";
            this.checkBoxPHPEnable.Size = new System.Drawing.Size(148, 17);
            this.checkBoxPHPEnable.TabIndex = 20;
            this.checkBoxPHPEnable.Text = "Разрешить PHP FastCGI";
            this.checkBoxPHPEnable.UseVisualStyleBackColor = true;
            this.checkBoxPHPEnable.CheckedChanged += new System.EventHandler(this.checkBoxPHPEnable_CheckedChanged_1);
            // 
            // ExampleLabel2
            // 
            this.ExampleLabel2.AutoSize = true;
            this.ExampleLabel2.Location = new System.Drawing.Point(108, 51);
            this.ExampleLabel2.Name = "ExampleLabel2";
            this.ExampleLabel2.Size = new System.Drawing.Size(154, 13);
            this.ExampleLabel2.TabIndex = 26;
            this.ExampleLabel2.Text = "Например: c:\\nginx\\nginx.exe";
            // 
            // NginxProcessLabel
            // 
            this.NginxProcessLabel.AutoSize = true;
            this.NginxProcessLabel.Location = new System.Drawing.Point(42, 31);
            this.NginxProcessLabel.Name = "NginxProcessLabel";
            this.NginxProcessLabel.Size = new System.Drawing.Size(63, 13);
            this.NginxProcessLabel.TabIndex = 25;
            this.NginxProcessLabel.Text = "Nginx файл";
            // 
            // textBoxNginxFile
            // 
            this.textBoxNginxFile.Location = new System.Drawing.Point(111, 28);
            this.textBoxNginxFile.Name = "textBoxNginxFile";
            this.textBoxNginxFile.Size = new System.Drawing.Size(294, 20);
            this.textBoxNginxFile.TabIndex = 24;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 325);
            this.Controls.Add(this.ExampleLabel2);
            this.Controls.Add(this.NginxProcessLabel);
            this.Controls.Add(this.textBoxNginxFile);
            this.Controls.Add(this.panelSettingsPHP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PHPSettingsSaveButton);
            this.Controls.Add(this.checkBoxPHPEnable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Настройки";
            this.panelSettingsPHP.ResumeLayout(false);
            this.panelSettingsPHP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSettingsPHP;
        private System.Windows.Forms.Label labelPHPAddressExample;
        private System.Windows.Forms.TextBox textBoxPHPAddress;
        private System.Windows.Forms.Label labelPHPFileExample;
        private System.Windows.Forms.TextBox textBoxPHPFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PHPSettingsSaveButton;
        private System.Windows.Forms.CheckBox checkBoxPHPEnable;
        private System.Windows.Forms.Label ExampleLabel2;
        private System.Windows.Forms.Label NginxProcessLabel;
        private System.Windows.Forms.TextBox textBoxNginxFile;
        private System.Windows.Forms.Label labelPHPFile;
        private System.Windows.Forms.Label labelPHPAddress;
        private System.Windows.Forms.Label labelPHPINI;
        private System.Windows.Forms.TextBox textBoxPHPINIFile;
        private System.Windows.Forms.Label labelPHPINIExample;


    }
}