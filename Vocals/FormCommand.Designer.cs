namespace Vocals
{
    partial class FormCommand
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
			this.TextVoiceCommand = new System.Windows.Forms.TextBox();
			this.ListCommands = new System.Windows.Forms.ListBox();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ButtonDelete = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ButtomDown = new System.Windows.Forms.Button();
			this.ButtonUp = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonEdit = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.TextVoiceAnswer = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.CheckUseSoundFile = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonOpen = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextVoiceCommand
			// 
			this.TextVoiceCommand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextVoiceCommand.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextVoiceCommand.Location = new System.Drawing.Point(3, 29);
			this.TextVoiceCommand.Name = "TextVoiceCommand";
			this.TextVoiceCommand.Size = new System.Drawing.Size(348, 27);
			this.TextVoiceCommand.TabIndex = 0;
			this.TextVoiceCommand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// ListCommands
			// 
			this.ListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListCommands.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListCommands.FormattingEnabled = true;
			this.ListCommands.ItemHeight = 20;
			this.ListCommands.Location = new System.Drawing.Point(3, 43);
			this.ListCommands.Name = "ListCommands";
			this.ListCommands.Size = new System.Drawing.Size(338, 336);
			this.ListCommands.TabIndex = 4;
			this.ListCommands.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.AutoSize = true;
			this.ButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAdd.Location = new System.Drawing.Point(3, 3);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(47, 30);
			this.ButtonAdd.TabIndex = 5;
			this.ButtonAdd.Text = "Add";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// ButtonDelete
			// 
			this.ButtonDelete.AutoSize = true;
			this.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDelete.Location = new System.Drawing.Point(107, 3);
			this.ButtonDelete.Name = "ButtonDelete";
			this.ButtonDelete.Size = new System.Drawing.Size(63, 30);
			this.ButtonDelete.TabIndex = 7;
			this.ButtonDelete.Text = "Delete";
			this.ButtonDelete.UseVisualStyleBackColor = true;
			this.ButtonDelete.Click += new System.EventHandler(this.button3_Click);
			// 
			// ButtonSave
			// 
			this.ButtonSave.AutoSize = true;
			this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSave.Location = new System.Drawing.Point(636, 3);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(119, 30);
			this.ButtonSave.TabIndex = 8;
			this.ButtonSave.Text = "Save and Close";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.button4_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.AutoSize = true;
			this.ButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCancel.Location = new System.Drawing.Point(567, 3);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(63, 30);
			this.ButtonCancel.TabIndex = 9;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TextVoiceCommand);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(354, 71);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Voice Command";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(354, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(404, 420);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 29);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 388);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.ButtomDown, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.ButtonUp, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(353, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(42, 382);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// ButtomDown
			// 
			this.ButtomDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtomDown.Image = global::Vocals.Properties.Resources.arrow483;
			this.ButtomDown.Location = new System.Drawing.Point(3, 194);
			this.ButtomDown.Name = "ButtomDown";
			this.ButtomDown.Size = new System.Drawing.Size(36, 28);
			this.ButtomDown.TabIndex = 10;
			this.ButtomDown.UseVisualStyleBackColor = true;
			this.ButtomDown.Click += new System.EventHandler(this.button7_Click);
			// 
			// ButtonUp
			// 
			this.ButtonUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonUp.Image = global::Vocals.Properties.Resources.navigate6;
			this.ButtonUp.Location = new System.Drawing.Point(3, 160);
			this.ButtonUp.Name = "ButtonUp";
			this.ButtonUp.Size = new System.Drawing.Size(36, 28);
			this.ButtonUp.TabIndex = 9;
			this.ButtonUp.UseVisualStyleBackColor = true;
			this.ButtonUp.Click += new System.EventHandler(this.button6_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.ListCommands, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(344, 382);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.ButtonAdd);
			this.flowLayoutPanel2.Controls.Add(this.ButtonEdit);
			this.flowLayoutPanel2.Controls.Add(this.ButtonDelete);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 34);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(338, 34);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// ButtonEdit
			// 
			this.ButtonEdit.AutoSize = true;
			this.ButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEdit.Location = new System.Drawing.Point(56, 3);
			this.ButtonEdit.Name = "ButtonEdit";
			this.ButtonEdit.Size = new System.Drawing.Size(45, 30);
			this.ButtonEdit.TabIndex = 8;
			this.ButtonEdit.Text = "Edit";
			this.ButtonEdit.UseVisualStyleBackColor = true;
			this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(166, 24);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Use voice synthetizer";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// TextVoiceAnswer
			// 
			this.TextVoiceAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextVoiceAnswer.Location = new System.Drawing.Point(3, 33);
			this.TextVoiceAnswer.Name = "TextVoiceAnswer";
			this.TextVoiceAnswer.Size = new System.Drawing.Size(342, 207);
			this.TextVoiceAnswer.TabIndex = 13;
			this.TextVoiceAnswer.Text = "";
			this.TextVoiceAnswer.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel4);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(0, 71);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(354, 349);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Command Answer";
			this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.checkBox1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.CheckUseSoundFile, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.TextVoiceAnswer, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 29);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(348, 317);
			this.tableLayoutPanel4.TabIndex = 18;
			// 
			// CheckUseSoundFile
			// 
			this.CheckUseSoundFile.AutoSize = true;
			this.CheckUseSoundFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckUseSoundFile.Location = new System.Drawing.Point(3, 246);
			this.CheckUseSoundFile.Name = "CheckUseSoundFile";
			this.CheckUseSoundFile.Size = new System.Drawing.Size(216, 24);
			this.CheckUseSoundFile.TabIndex = 14;
			this.CheckUseSoundFile.Text = "Use sound file (*.mp3, *.wav)";
			this.CheckUseSoundFile.UseVisualStyleBackColor = true;
			this.CheckUseSoundFile.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.Controls.Add(this.ButtonOpen, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.textBox2, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 276);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(342, 38);
			this.tableLayoutPanel5.TabIndex = 15;
			// 
			// ButtonOpen
			// 
			this.ButtonOpen.AutoSize = true;
			this.ButtonOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonOpen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOpen.Location = new System.Drawing.Point(275, 3);
			this.ButtonOpen.Name = "ButtonOpen";
			this.ButtonOpen.Size = new System.Drawing.Size(64, 30);
			this.ButtonOpen.TabIndex = 16;
			this.ButtonOpen.Text = "Open...";
			this.ButtonOpen.UseVisualStyleBackColor = true;
			this.ButtonOpen.Click += new System.EventHandler(this.button9_Click);
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(3, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(266, 33);
			this.textBox2.TabIndex = 17;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.ButtonSave);
			this.flowLayoutPanel1.Controls.Add(this.ButtonCancel);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 420);
			this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 34);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 34);
			this.flowLayoutPanel1.TabIndex = 18;
			// 
			// FormCommand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 454);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(600, 380);
			this.Name = "FormCommand";
			this.Text = "New Command";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextVoiceCommand;
        private System.Windows.Forms.ListBox ListCommands;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtomDown;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox TextVoiceAnswer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CheckUseSoundFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonOpen;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
	}
}