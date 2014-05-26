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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.panelSettingsPHP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnvironmentVariables = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAutoRun = new System.Windows.Forms.CheckBox();
            this.textBoxArguments = new System.Windows.Forms.TextBox();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.panelSettingsPHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(570, 284);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 29);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.SettingsCloseButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(440, 284);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 29);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.Location = new System.Drawing.Point(14, 33);
            this.textBoxFiles.Multiline = true;
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFiles.Size = new System.Drawing.Size(319, 154);
            this.textBoxFiles.TabIndex = 8;
            this.textBoxFiles.WordWrap = false;
            // 
            // panelSettingsPHP
            // 
            this.panelSettingsPHP.Controls.Add(this.label2);
            this.panelSettingsPHP.Controls.Add(this.label1);
            this.panelSettingsPHP.Controls.Add(this.textBoxArguments);
            this.panelSettingsPHP.Controls.Add(this.textBoxFiles);
            this.panelSettingsPHP.Location = new System.Drawing.Point(12, 84);
            this.panelSettingsPHP.Name = "panelSettingsPHP";
            this.panelSettingsPHP.Size = new System.Drawing.Size(672, 190);
            this.panelSettingsPHP.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Запускаемый файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Аргументы запуска";
            // 
            // textBoxEnvironmentVariables
            // 
            this.textBoxEnvironmentVariables.Location = new System.Drawing.Point(354, 31);
            this.textBoxEnvironmentVariables.Multiline = true;
            this.textBoxEnvironmentVariables.Name = "textBoxEnvironmentVariables";
            this.textBoxEnvironmentVariables.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEnvironmentVariables.Size = new System.Drawing.Size(327, 39);
            this.textBoxEnvironmentVariables.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Переменные окружения";
            // 
            // checkBoxAutoRun
            // 
            this.checkBoxAutoRun.AutoSize = true;
            this.checkBoxAutoRun.Location = new System.Drawing.Point(29, 13);
            this.checkBoxAutoRun.Name = "checkBoxAutoRun";
            this.checkBoxAutoRun.Size = new System.Drawing.Size(156, 17);
            this.checkBoxAutoRun.TabIndex = 26;
            this.checkBoxAutoRun.Text = "Добавить в автозагрузку";
            this.checkBoxAutoRun.UseVisualStyleBackColor = true;
            // 
            // textBoxArguments
            // 
            this.textBoxArguments.Location = new System.Drawing.Point(339, 33);
            this.textBoxArguments.Multiline = true;
            this.textBoxArguments.Name = "textBoxArguments";
            this.textBoxArguments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArguments.Size = new System.Drawing.Size(330, 154);
            this.textBoxArguments.TabIndex = 14;
            this.textBoxArguments.WordWrap = false;
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Location = new System.Drawing.Point(29, 37);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(211, 17);
            this.checkBoxNotify.TabIndex = 27;
            this.checkBoxNotify.Text = "Уведомлять о \"крушении\" процесса";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.AutoSize = true;
            this.checkBoxRestart.Location = new System.Drawing.Point(29, 61);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(269, 17);
            this.checkBoxRestart.TabIndex = 28;
            this.checkBoxRestart.Text = "Рестартовать сервер при \"крушении\" процесса";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 325);
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.checkBoxNotify);
            this.Controls.Add(this.checkBoxAutoRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEnvironmentVariables);
            this.Controls.Add(this.panelSettingsPHP);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Настройки";
            this.panelSettingsPHP.ResumeLayout(false);
            this.panelSettingsPHP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFiles;
        private System.Windows.Forms.Panel panelSettingsPHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnvironmentVariables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAutoRun;
        private System.Windows.Forms.TextBox textBoxArguments;
        private System.Windows.Forms.CheckBox checkBoxNotify;
        private System.Windows.Forms.CheckBox checkBoxRestart;


    }
}