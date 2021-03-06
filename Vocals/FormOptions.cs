﻿using System;
using System.Data;
using System.Linq;
using System.Speech.Recognition;
using System.Windows.Forms;
using Vocals.InternalClasses;

namespace Vocals
{
	public partial class FormOptions : Form
	{
		public Options opt;
		public Options saveOptions;

		public FormOptions()
		{
			InitializeComponent();
		}

		private void FormOptions_Load(object sender, EventArgs e)
		{
			Keys[] keyDataSource = (Keys[])Enum.GetValues(typeof(Keys)).Cast<Keys>();
			comboBox2.DataSource = keyDataSource;

			recognitionLanguageComboBox.DataSource = getInstalledRecognitionLanguages();

			opt = new Options();
			saveOptions = new Options(opt);

			checkBox1.Checked = opt.toggleListening;
			comboBox2.SelectedItem = opt.key;
			richTextBox1.Text = opt.answer;
			trackBar1.Value = opt.threshold;
			label5.Text = Convert.ToString(opt.threshold);
			recognitionLanguageComboBox.SelectedItem = opt.language;
			recognitionLanguageWarning.Visible = false;

			if (checkBox1.Checked)
			{
				comboBox2.Enabled = true;
				richTextBox1.Enabled = true;
			}
			else {
				comboBox2.Enabled = false;
				richTextBox1.Enabled = false;
			}
		}

		private string[] getInstalledRecognitionLanguages()
		{
			return SpeechRecognitionEngine.InstalledRecognizers().Select(ri => ri.Culture.DisplayName).ToArray();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (opt != null)
			{
				if (checkBox1.Checked)
				{
					comboBox2.Enabled = true;
					richTextBox1.Enabled = true;
					opt.toggleListening = true;
				}
				else {
					comboBox2.Enabled = false;
					richTextBox1.Enabled = false;
					opt.toggleListening = false;
				}
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			if (opt != null)
			{
				opt.threshold = trackBar1.Value;
				label5.Text = Convert.ToString(trackBar1.Value);
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (opt != null)
			{
				opt.key = (Keys)comboBox2.SelectedItem;
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			if (opt != null)
			{
				opt.answer = richTextBox1.Text;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			opt = saveOptions;
			this.Close();
		}

		private void recognitionLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (opt != null)
			{
				opt.language = (String)recognitionLanguageComboBox.SelectedItem;
				recognitionLanguageWarning.Visible = true;
			}
		}
	}
}