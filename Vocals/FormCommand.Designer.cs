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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ButtonDelete = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ButtomDown = new System.Windows.Forms.Button();
			this.ButtonUp = new System.Windows.Forms.Button();
			this.ButtonEdit = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button9 = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(267, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(15, 74);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(195, 134);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Location = new System.Drawing.Point(15, 34);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(60, 23);
			this.ButtonAdd.TabIndex = 5;
			this.ButtonAdd.Text = "Add action";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.button1_Click);
			// 
			// ButtonDelete
			// 
			this.ButtonDelete.Location = new System.Drawing.Point(150, 34);
			this.ButtonDelete.Name = "ButtonDelete";
			this.ButtonDelete.Size = new System.Drawing.Size(60, 23);
			this.ButtonDelete.TabIndex = 7;
			this.ButtonDelete.Text = "Delete action";
			this.ButtonDelete.UseVisualStyleBackColor = true;
			this.ButtonDelete.Click += new System.EventHandler(this.button3_Click);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Location = new System.Drawing.Point(484, 316);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(102, 23);
			this.ButtonSave.TabIndex = 8;
			this.ButtonSave.Text = "Save and Close";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(403, 316);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 9;
			this.button5.Text = "Cancel";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 71);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Voice Command";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ButtomDown);
			this.groupBox2.Controls.Add(this.ButtonUp);
			this.groupBox2.Controls.Add(this.ButtonEdit);
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.Controls.Add(this.ButtonAdd);
			this.groupBox2.Controls.Add(this.ButtonDelete);
			this.groupBox2.Location = new System.Drawing.Point(12, 89);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 221);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// ButtomDown
			// 
			this.ButtomDown.Location = new System.Drawing.Point(216, 140);
			this.ButtomDown.Name = "ButtomDown";
			this.ButtomDown.Size = new System.Drawing.Size(57, 23);
			this.ButtomDown.TabIndex = 10;
			this.ButtomDown.Text = "Down";
			this.ButtomDown.UseVisualStyleBackColor = true;
			this.ButtomDown.Click += new System.EventHandler(this.button7_Click);
			// 
			// ButtonUp
			// 
			this.ButtonUp.Location = new System.Drawing.Point(216, 111);
			this.ButtonUp.Name = "ButtonUp";
			this.ButtonUp.Size = new System.Drawing.Size(57, 23);
			this.ButtonUp.TabIndex = 9;
			this.ButtonUp.Text = "Up";
			this.ButtonUp.UseVisualStyleBackColor = true;
			this.ButtonUp.Click += new System.EventHandler(this.button6_Click);
			// 
			// ButtonEdit
			// 
			this.ButtonEdit.Location = new System.Drawing.Point(84, 34);
			this.ButtonEdit.Name = "ButtonEdit";
			this.ButtonEdit.Size = new System.Drawing.Size(60, 23);
			this.ButtonEdit.TabIndex = 8;
			this.ButtonEdit.Text = "Edit";
			this.ButtonEdit.UseVisualStyleBackColor = true;
			this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(6, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(127, 17);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Use voice synthetizer";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(6, 42);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(276, 92);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox2);
			this.groupBox4.Controls.Add(this.button9);
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Controls.Add(this.checkBox1);
			this.groupBox4.Controls.Add(this.richTextBox1);
			this.groupBox4.Location = new System.Drawing.Point(298, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(288, 298);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Command answering";
			this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(7, 195);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(275, 20);
			this.textBox2.TabIndex = 17;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(7, 165);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(71, 23);
			this.button9.TabIndex = 16;
			this.button9.Text = "Rechercher";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(7, 141);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(122, 17);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Use sound file (wav)";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// FormCommand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 349);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.ButtonSave);
			this.Name = "FormCommand";
			this.Text = "New Command";
			this.Load += new System.EventHandler(this.FormPopup_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtomDown;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
    }
}