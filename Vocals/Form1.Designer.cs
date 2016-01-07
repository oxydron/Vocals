namespace Vocals
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ComboApps = new System.Windows.Forms.ComboBox();
			this.ButtonAddCmd = new System.Windows.Forms.Button();
			this.ComboProfiles = new System.Windows.Forms.ComboBox();
			this.ButtonAddProfile = new System.Windows.Forms.Button();
			this.ListCommands = new System.Windows.Forms.ListBox();
			this.ButtonDeleteProfile = new System.Windows.Forms.Button();
			this.ButtonDeleteCmd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ButtonEditCmd = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ButtonDefaultApp = new System.Windows.Forms.Button();
			this.LogGroup = new System.Windows.Forms.GroupBox();
			this.ProgressVoiceCaptured = new System.Windows.Forms.ProgressBar();
			this.TextBoxLog = new System.Windows.Forms.RichTextBox();
			this.advancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAdvancedSettings = new System.Windows.Forms.MenuStrip();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.LogGroup.SuspendLayout();
			this.MenuAdvancedSettings.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ComboApps
			// 
			this.ComboApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboApps.FormattingEnabled = true;
			this.ComboApps.Location = new System.Drawing.Point(29, 38);
			this.ComboApps.Name = "ComboApps";
			this.ComboApps.Size = new System.Drawing.Size(187, 21);
			this.ComboApps.TabIndex = 1;
			this.ComboApps.SelectedIndexChanged += new System.EventHandler(this.ComboApps_SelectedIndexChanged);
			// 
			// ButtonAddCmd
			// 
			this.ButtonAddCmd.Location = new System.Drawing.Point(3, 3);
			this.ButtonAddCmd.Name = "ButtonAddCmd";
			this.ButtonAddCmd.Size = new System.Drawing.Size(70, 23);
			this.ButtonAddCmd.TabIndex = 4;
			this.ButtonAddCmd.Text = "New";
			this.ButtonAddCmd.UseVisualStyleBackColor = true;
			this.ButtonAddCmd.Click += new System.EventHandler(this.ButtonAddCmd_Click);
			// 
			// ComboProfiles
			// 
			this.ComboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboProfiles.FormattingEnabled = true;
			this.ComboProfiles.Location = new System.Drawing.Point(29, 52);
			this.ComboProfiles.Name = "ComboProfiles";
			this.ComboProfiles.Size = new System.Drawing.Size(226, 21);
			this.ComboProfiles.TabIndex = 5;
			this.ComboProfiles.SelectedIndexChanged += new System.EventHandler(this.ComboProfiles_SelectedIndexChanged);
			// 
			// ButtonAddProfile
			// 
			this.ButtonAddProfile.Location = new System.Drawing.Point(29, 23);
			this.ButtonAddProfile.Name = "ButtonAddProfile";
			this.ButtonAddProfile.Size = new System.Drawing.Size(98, 23);
			this.ButtonAddProfile.TabIndex = 7;
			this.ButtonAddProfile.Text = "Add profile";
			this.ButtonAddProfile.UseVisualStyleBackColor = true;
			this.ButtonAddProfile.Click += new System.EventHandler(this.ButtonAddProfile_Click);
			// 
			// ListCommands
			// 
			this.ListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListCommands.FormattingEnabled = true;
			this.ListCommands.Location = new System.Drawing.Point(3, 49);
			this.ListCommands.Name = "ListCommands";
			this.ListCommands.Size = new System.Drawing.Size(271, 467);
			this.ListCommands.TabIndex = 8;
			this.ListCommands.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListCommands_MouseDoubleClick);
			// 
			// ButtonDeleteProfile
			// 
			this.ButtonDeleteProfile.Location = new System.Drawing.Point(151, 23);
			this.ButtonDeleteProfile.Name = "ButtonDeleteProfile";
			this.ButtonDeleteProfile.Size = new System.Drawing.Size(104, 23);
			this.ButtonDeleteProfile.TabIndex = 10;
			this.ButtonDeleteProfile.Text = "Delete profile";
			this.ButtonDeleteProfile.UseVisualStyleBackColor = true;
			this.ButtonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteProfile_Click);
			// 
			// ButtonDeleteCmd
			// 
			this.ButtonDeleteCmd.Location = new System.Drawing.Point(155, 3);
			this.ButtonDeleteCmd.Name = "ButtonDeleteCmd";
			this.ButtonDeleteCmd.Size = new System.Drawing.Size(70, 23);
			this.ButtonDeleteCmd.TabIndex = 11;
			this.ButtonDeleteCmd.Text = "Delete";
			this.ButtonDeleteCmd.UseVisualStyleBackColor = true;
			this.ButtonDeleteCmd.Click += new System.EventHandler(this.ButtonDeleteCmd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ButtonAddProfile);
			this.groupBox1.Controls.Add(this.ButtonDeleteProfile);
			this.groupBox1.Controls.Add(this.ComboProfiles);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(277, 227);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profiles";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ListCommands);
			this.groupBox2.Controls.Add(this.flowLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox2.Location = new System.Drawing.Point(612, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(277, 519);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Commands ";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// ButtonEditCmd
			// 
			this.ButtonEditCmd.Location = new System.Drawing.Point(79, 3);
			this.ButtonEditCmd.Name = "ButtonEditCmd";
			this.ButtonEditCmd.Size = new System.Drawing.Size(70, 23);
			this.ButtonEditCmd.TabIndex = 12;
			this.ButtonEditCmd.Text = "Edit";
			this.ButtonEditCmd.UseVisualStyleBackColor = true;
			this.ButtonEditCmd.Click += new System.EventHandler(this.ButtonEditCmd_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.ButtonDefaultApp);
			this.groupBox4.Controls.Add(this.ComboApps);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(277, 24);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(335, 227);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Application";
			this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
			// 
			// ButtonDefaultApp
			// 
			this.ButtonDefaultApp.Location = new System.Drawing.Point(222, 38);
			this.ButtonDefaultApp.Name = "ButtonDefaultApp";
			this.ButtonDefaultApp.Size = new System.Drawing.Size(33, 23);
			this.ButtonDefaultApp.TabIndex = 2;
			this.ButtonDefaultApp.Text = "#";
			this.ButtonDefaultApp.UseVisualStyleBackColor = true;
			this.ButtonDefaultApp.Click += new System.EventHandler(this.button6_Click);
			// 
			// LogGroup
			// 
			this.LogGroup.Controls.Add(this.TextBoxLog);
			this.LogGroup.Controls.Add(this.ProgressVoiceCaptured);
			this.LogGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LogGroup.Location = new System.Drawing.Point(0, 251);
			this.LogGroup.Name = "LogGroup";
			this.LogGroup.Size = new System.Drawing.Size(612, 292);
			this.LogGroup.TabIndex = 16;
			this.LogGroup.TabStop = false;
			this.LogGroup.Text = "Logs";
			this.LogGroup.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// ProgressVoiceCaptured
			// 
			this.ProgressVoiceCaptured.Dock = System.Windows.Forms.DockStyle.Top;
			this.ProgressVoiceCaptured.Location = new System.Drawing.Point(3, 16);
			this.ProgressVoiceCaptured.Name = "ProgressVoiceCaptured";
			this.ProgressVoiceCaptured.Size = new System.Drawing.Size(606, 11);
			this.ProgressVoiceCaptured.Step = 11;
			this.ProgressVoiceCaptured.TabIndex = 1;
			// 
			// TextBoxLog
			// 
			this.TextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxLog.Location = new System.Drawing.Point(3, 27);
			this.TextBoxLog.Name = "TextBoxLog";
			this.TextBoxLog.ReadOnly = true;
			this.TextBoxLog.Size = new System.Drawing.Size(606, 262);
			this.TextBoxLog.TabIndex = 0;
			this.TextBoxLog.Text = "";
			// 
			// advancedSettingsToolStripMenuItem
			// 
			this.advancedSettingsToolStripMenuItem.Name = "advancedSettingsToolStripMenuItem";
			this.advancedSettingsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
			this.advancedSettingsToolStripMenuItem.Text = "Advanced Settings";
			this.advancedSettingsToolStripMenuItem.Click += new System.EventHandler(this.advancedSettingsToolStripMenuItem_Click);
			// 
			// MenuAdvancedSettings
			// 
			this.MenuAdvancedSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSettingsToolStripMenuItem});
			this.MenuAdvancedSettings.Location = new System.Drawing.Point(0, 0);
			this.MenuAdvancedSettings.Name = "MenuAdvancedSettings";
			this.MenuAdvancedSettings.Size = new System.Drawing.Size(889, 24);
			this.MenuAdvancedSettings.TabIndex = 17;
			this.MenuAdvancedSettings.Text = "menuStrip1";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.ButtonAddCmd);
			this.flowLayoutPanel1.Controls.Add(this.ButtonEditCmd);
			this.flowLayoutPanel1.Controls.Add(this.ButtonDeleteCmd);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 33);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 543);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LogGroup);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.MenuAdvancedSettings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuAdvancedSettings;
			this.Name = "Form1";
			this.Text = "Vocals";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.LogGroup.ResumeLayout(false);
			this.MenuAdvancedSettings.ResumeLayout(false);
			this.MenuAdvancedSettings.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox ComboApps;
        private System.Windows.Forms.Button ButtonAddCmd;
        private System.Windows.Forms.ComboBox ComboProfiles;
        private System.Windows.Forms.Button ButtonAddProfile;
        private System.Windows.Forms.ListBox ListCommands;
        private System.Windows.Forms.Button ButtonDeleteProfile;
        private System.Windows.Forms.Button ButtonDeleteCmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox LogGroup;
        private System.Windows.Forms.RichTextBox TextBoxLog;
        private System.Windows.Forms.Button ButtonEditCmd;
        private System.Windows.Forms.ToolStripMenuItem advancedSettingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuAdvancedSettings;
        private System.Windows.Forms.ProgressBar ProgressVoiceCaptured;
        private System.Windows.Forms.Button ButtonDefaultApp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

