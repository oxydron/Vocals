namespace Vocals
{
    partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ComboApps = new System.Windows.Forms.ComboBox();
			this.ButtonAddCmd = new System.Windows.Forms.Button();
			this.ComboProfiles = new System.Windows.Forms.ComboBox();
			this.ListCommands = new System.Windows.Forms.ListBox();
			this.ButtonDeleteCmd = new System.Windows.Forms.Button();
			this.GroupProfiles = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonAddProfile = new System.Windows.Forms.Button();
			this.ButtonDeleteProfile = new System.Windows.Forms.Button();
			this.GroupCommands = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonEditCmd = new System.Windows.Forms.Button();
			this.GroupApps = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonDefaultApp = new System.Windows.Forms.Button();
			this.GroupLogs = new System.Windows.Forms.GroupBox();
			this.TextBoxLog = new System.Windows.Forms.RichTextBox();
			this.ProgressVoiceCaptured = new System.Windows.Forms.ProgressBar();
			this.advancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAdvancedSettings = new System.Windows.Forms.MenuStrip();
			this.Tooltips = new System.Windows.Forms.ToolTip(this.components);
			this.GroupProfiles.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.GroupCommands.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.GroupApps.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.GroupLogs.SuspendLayout();
			this.MenuAdvancedSettings.SuspendLayout();
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
			this.ComboApps.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboApps.FormattingEnabled = true;
			this.ComboApps.Location = new System.Drawing.Point(3, 3);
			this.ComboApps.Name = "ComboApps";
			this.ComboApps.Size = new System.Drawing.Size(422, 28);
			this.ComboApps.TabIndex = 1;
			this.ComboApps.SelectedIndexChanged += new System.EventHandler(this.ComboApps_SelectedIndexChanged);
			// 
			// ButtonAddCmd
			// 
			this.ButtonAddCmd.AutoSize = true;
			this.ButtonAddCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAddCmd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAddCmd.Location = new System.Drawing.Point(3, 3);
			this.ButtonAddCmd.Name = "ButtonAddCmd";
			this.ButtonAddCmd.Size = new System.Drawing.Size(49, 30);
			this.ButtonAddCmd.TabIndex = 4;
			this.ButtonAddCmd.Text = "New";
			this.Tooltips.SetToolTip(this.ButtonAddCmd, "Create a new voice command");
			this.ButtonAddCmd.UseVisualStyleBackColor = true;
			this.ButtonAddCmd.Click += new System.EventHandler(this.ButtonAddCmd_Click);
			// 
			// ComboProfiles
			// 
			this.ComboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboProfiles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboProfiles.FormattingEnabled = true;
			this.ComboProfiles.Location = new System.Drawing.Point(3, 3);
			this.ComboProfiles.Name = "ComboProfiles";
			this.ComboProfiles.Size = new System.Drawing.Size(389, 28);
			this.ComboProfiles.TabIndex = 5;
			this.ComboProfiles.SelectedIndexChanged += new System.EventHandler(this.ComboProfiles_SelectedIndexChanged);
			// 
			// ListCommands
			// 
			this.ListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListCommands.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListCommands.FormattingEnabled = true;
			this.ListCommands.ItemHeight = 20;
			this.ListCommands.Location = new System.Drawing.Point(3, 62);
			this.ListCommands.Name = "ListCommands";
			this.ListCommands.Size = new System.Drawing.Size(271, 454);
			this.ListCommands.TabIndex = 8;
			this.ListCommands.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListCommands_MouseDoubleClick);
			// 
			// ButtonDeleteCmd
			// 
			this.ButtonDeleteCmd.AutoSize = true;
			this.ButtonDeleteCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonDeleteCmd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDeleteCmd.Location = new System.Drawing.Point(109, 3);
			this.ButtonDeleteCmd.Name = "ButtonDeleteCmd";
			this.ButtonDeleteCmd.Size = new System.Drawing.Size(63, 30);
			this.ButtonDeleteCmd.TabIndex = 11;
			this.ButtonDeleteCmd.Text = "Delete";
			this.Tooltips.SetToolTip(this.ButtonDeleteCmd, "Delete a voice command");
			this.ButtonDeleteCmd.UseVisualStyleBackColor = true;
			this.ButtonDeleteCmd.Click += new System.EventHandler(this.ButtonDeleteCmd_Click);
			// 
			// GroupProfiles
			// 
			this.GroupProfiles.Controls.Add(this.flowLayoutPanel2);
			this.GroupProfiles.Dock = System.Windows.Forms.DockStyle.Top;
			this.GroupProfiles.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupProfiles.Location = new System.Drawing.Point(0, 24);
			this.GroupProfiles.MinimumSize = new System.Drawing.Size(0, 64);
			this.GroupProfiles.Name = "GroupProfiles";
			this.GroupProfiles.Size = new System.Drawing.Size(469, 64);
			this.GroupProfiles.TabIndex = 12;
			this.GroupProfiles.TabStop = false;
			this.GroupProfiles.Text = "Profiles";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.ComboProfiles);
			this.flowLayoutPanel2.Controls.Add(this.ButtonAddProfile);
			this.flowLayoutPanel2.Controls.Add(this.ButtonDeleteProfile);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 27);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(463, 34);
			this.flowLayoutPanel2.TabIndex = 11;
			// 
			// ButtonAddProfile
			// 
			this.ButtonAddProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAddProfile.Image = global::Vocals.Properties.Resources.add186;
			this.ButtonAddProfile.Location = new System.Drawing.Point(398, 3);
			this.ButtonAddProfile.Name = "ButtonAddProfile";
			this.ButtonAddProfile.Size = new System.Drawing.Size(28, 28);
			this.ButtonAddProfile.TabIndex = 7;
			this.Tooltips.SetToolTip(this.ButtonAddProfile, "Add a new profile");
			this.ButtonAddProfile.UseVisualStyleBackColor = true;
			this.ButtonAddProfile.Click += new System.EventHandler(this.ButtonAddProfile_Click);
			// 
			// ButtonDeleteProfile
			// 
			this.ButtonDeleteProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDeleteProfile.Image = global::Vocals.Properties.Resources.rubbish;
			this.ButtonDeleteProfile.Location = new System.Drawing.Point(432, 3);
			this.ButtonDeleteProfile.Name = "ButtonDeleteProfile";
			this.ButtonDeleteProfile.Size = new System.Drawing.Size(28, 28);
			this.ButtonDeleteProfile.TabIndex = 10;
			this.Tooltips.SetToolTip(this.ButtonDeleteProfile, "Delete current profile");
			this.ButtonDeleteProfile.UseVisualStyleBackColor = true;
			this.ButtonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteProfile_Click);
			// 
			// GroupCommands
			// 
			this.GroupCommands.Controls.Add(this.ListCommands);
			this.GroupCommands.Controls.Add(this.flowLayoutPanel1);
			this.GroupCommands.Dock = System.Windows.Forms.DockStyle.Right;
			this.GroupCommands.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupCommands.Location = new System.Drawing.Point(469, 24);
			this.GroupCommands.Name = "GroupCommands";
			this.GroupCommands.Size = new System.Drawing.Size(277, 519);
			this.GroupCommands.TabIndex = 13;
			this.GroupCommands.TabStop = false;
			this.GroupCommands.Text = "Commands ";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.ButtonAddCmd);
			this.flowLayoutPanel1.Controls.Add(this.ButtonEditCmd);
			this.flowLayoutPanel1.Controls.Add(this.ButtonDeleteCmd);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 27);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 35);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// ButtonEditCmd
			// 
			this.ButtonEditCmd.AutoSize = true;
			this.ButtonEditCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonEditCmd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEditCmd.Location = new System.Drawing.Point(58, 3);
			this.ButtonEditCmd.Name = "ButtonEditCmd";
			this.ButtonEditCmd.Size = new System.Drawing.Size(45, 30);
			this.ButtonEditCmd.TabIndex = 12;
			this.ButtonEditCmd.Text = "Edit";
			this.Tooltips.SetToolTip(this.ButtonEditCmd, "Edit a existing voice command");
			this.ButtonEditCmd.UseVisualStyleBackColor = true;
			this.ButtonEditCmd.Click += new System.EventHandler(this.ButtonEditCmd_Click);
			// 
			// GroupApps
			// 
			this.GroupApps.Controls.Add(this.flowLayoutPanel3);
			this.GroupApps.Dock = System.Windows.Forms.DockStyle.Top;
			this.GroupApps.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupApps.Location = new System.Drawing.Point(0, 88);
			this.GroupApps.MinimumSize = new System.Drawing.Size(0, 68);
			this.GroupApps.Name = "GroupApps";
			this.GroupApps.Size = new System.Drawing.Size(469, 68);
			this.GroupApps.TabIndex = 15;
			this.GroupApps.TabStop = false;
			this.GroupApps.Text = "Applications";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.ComboApps);
			this.flowLayoutPanel3.Controls.Add(this.ButtonDefaultApp);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 27);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(463, 38);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// ButtonDefaultApp
			// 
			this.ButtonDefaultApp.Image = global::Vocals.Properties.Resources.history6;
			this.ButtonDefaultApp.Location = new System.Drawing.Point(431, 3);
			this.ButtonDefaultApp.Name = "ButtonDefaultApp";
			this.ButtonDefaultApp.Size = new System.Drawing.Size(28, 28);
			this.ButtonDefaultApp.TabIndex = 2;
			this.Tooltips.SetToolTip(this.ButtonDefaultApp, "Reload process list");
			this.ButtonDefaultApp.UseVisualStyleBackColor = true;
			this.ButtonDefaultApp.Click += new System.EventHandler(this.button6_Click);
			// 
			// GroupLogs
			// 
			this.GroupLogs.Controls.Add(this.TextBoxLog);
			this.GroupLogs.Controls.Add(this.ProgressVoiceCaptured);
			this.GroupLogs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupLogs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupLogs.Location = new System.Drawing.Point(0, 156);
			this.GroupLogs.Name = "GroupLogs";
			this.GroupLogs.Size = new System.Drawing.Size(469, 387);
			this.GroupLogs.TabIndex = 16;
			this.GroupLogs.TabStop = false;
			this.GroupLogs.Text = "Logs";
			// 
			// TextBoxLog
			// 
			this.TextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxLog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxLog.Location = new System.Drawing.Point(3, 44);
			this.TextBoxLog.Name = "TextBoxLog";
			this.TextBoxLog.ReadOnly = true;
			this.TextBoxLog.Size = new System.Drawing.Size(463, 340);
			this.TextBoxLog.TabIndex = 0;
			this.TextBoxLog.Text = "";
			// 
			// ProgressVoiceCaptured
			// 
			this.ProgressVoiceCaptured.Dock = System.Windows.Forms.DockStyle.Top;
			this.ProgressVoiceCaptured.Location = new System.Drawing.Point(3, 29);
			this.ProgressVoiceCaptured.MinimumSize = new System.Drawing.Size(0, 15);
			this.ProgressVoiceCaptured.Name = "ProgressVoiceCaptured";
			this.ProgressVoiceCaptured.Size = new System.Drawing.Size(463, 15);
			this.ProgressVoiceCaptured.Step = 11;
			this.ProgressVoiceCaptured.TabIndex = 1;
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
			this.MenuAdvancedSettings.Size = new System.Drawing.Size(746, 24);
			this.MenuAdvancedSettings.TabIndex = 17;
			this.MenuAdvancedSettings.Text = "menuStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 543);
			this.Controls.Add(this.GroupLogs);
			this.Controls.Add(this.GroupApps);
			this.Controls.Add(this.GroupProfiles);
			this.Controls.Add(this.GroupCommands);
			this.Controls.Add(this.MenuAdvancedSettings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuAdvancedSettings;
			this.Name = "Form1";
			this.Text = "Vocals";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.GroupProfiles.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.GroupCommands.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.GroupApps.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.GroupLogs.ResumeLayout(false);
			this.MenuAdvancedSettings.ResumeLayout(false);
			this.MenuAdvancedSettings.PerformLayout();
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
        private System.Windows.Forms.GroupBox GroupProfiles;
        private System.Windows.Forms.GroupBox GroupCommands;
        private System.Windows.Forms.GroupBox GroupApps;
        private System.Windows.Forms.GroupBox GroupLogs;
        private System.Windows.Forms.RichTextBox TextBoxLog;
        private System.Windows.Forms.Button ButtonEditCmd;
        private System.Windows.Forms.ToolStripMenuItem advancedSettingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuAdvancedSettings;
        private System.Windows.Forms.ProgressBar ProgressVoiceCaptured;
        private System.Windows.Forms.Button ButtonDefaultApp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.ToolTip Tooltips;
	}
}

