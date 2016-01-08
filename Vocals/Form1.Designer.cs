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
			this.ListCommands = new System.Windows.Forms.ListBox();
			this.ButtonDeleteCmd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonEditCmd = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.GroupBoxLog = new System.Windows.Forms.GroupBox();
			this.TextBoxLog = new System.Windows.Forms.RichTextBox();
			this.ProgressVoiceCaptured = new System.Windows.Forms.ProgressBar();
			this.advancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAdvancedSettings = new System.Windows.Forms.MenuStrip();
			this.Tooltips = new System.Windows.Forms.ToolTip(this.components);
			this.ButtonDefaultApp = new System.Windows.Forms.Button();
			this.ButtonAddProfile = new System.Windows.Forms.Button();
			this.ButtonDeleteProfile = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.GroupBoxLog.SuspendLayout();
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
			this.ComboProfiles.Size = new System.Drawing.Size(388, 28);
			this.ComboProfiles.TabIndex = 5;
			this.ComboProfiles.SelectedIndexChanged += new System.EventHandler(this.ComboProfiles_SelectedIndexChanged);
			// 
			// ListCommands
			// 
			this.ListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListCommands.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListCommands.FormattingEnabled = true;
			this.ListCommands.ItemHeight = 20;
			this.ListCommands.Location = new System.Drawing.Point(3, 64);
			this.ListCommands.Name = "ListCommands";
			this.ListCommands.Size = new System.Drawing.Size(271, 452);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.flowLayoutPanel2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 24);
			this.groupBox1.MinimumSize = new System.Drawing.Size(0, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(469, 64);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profiles";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.ComboProfiles);
			this.flowLayoutPanel2.Controls.Add(this.ButtonAddProfile);
			this.flowLayoutPanel2.Controls.Add(this.ButtonDeleteProfile);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 29);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(463, 32);
			this.flowLayoutPanel2.TabIndex = 11;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ListCommands);
			this.groupBox2.Controls.Add(this.flowLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(469, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(277, 519);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Commands ";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.ButtonAddCmd);
			this.flowLayoutPanel1.Controls.Add(this.ButtonEditCmd);
			this.flowLayoutPanel1.Controls.Add(this.ButtonDeleteCmd);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 29);
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
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.flowLayoutPanel3);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(0, 88);
			this.groupBox4.MinimumSize = new System.Drawing.Size(0, 68);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(469, 68);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Applications";
			this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.ComboApps);
			this.flowLayoutPanel3.Controls.Add(this.ButtonDefaultApp);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 29);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(463, 36);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// GroupBoxLog
			// 
			this.GroupBoxLog.Controls.Add(this.TextBoxLog);
			this.GroupBoxLog.Controls.Add(this.ProgressVoiceCaptured);
			this.GroupBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupBoxLog.Location = new System.Drawing.Point(0, 156);
			this.GroupBoxLog.Name = "GroupBoxLog";
			this.GroupBoxLog.Size = new System.Drawing.Size(469, 387);
			this.GroupBoxLog.TabIndex = 16;
			this.GroupBoxLog.TabStop = false;
			this.GroupBoxLog.Text = "Logs";
			this.GroupBoxLog.Enter += new System.EventHandler(this.groupBox3_Enter);
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
			// ButtonAddProfile
			// 
			this.ButtonAddProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAddProfile.Image = global::Vocals.Properties.Resources.add186;
			this.ButtonAddProfile.Location = new System.Drawing.Point(397, 3);
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
			this.ButtonDeleteProfile.Location = new System.Drawing.Point(431, 3);
			this.ButtonDeleteProfile.Name = "ButtonDeleteProfile";
			this.ButtonDeleteProfile.Size = new System.Drawing.Size(28, 28);
			this.ButtonDeleteProfile.TabIndex = 10;
			this.Tooltips.SetToolTip(this.ButtonDeleteProfile, "Delete current profile");
			this.ButtonDeleteProfile.UseVisualStyleBackColor = true;
			this.ButtonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteProfile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 543);
			this.Controls.Add(this.GroupBoxLog);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.MenuAdvancedSettings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuAdvancedSettings;
			this.Name = "Form1";
			this.Text = "Vocals";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.GroupBoxLog.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox GroupBoxLog;
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

