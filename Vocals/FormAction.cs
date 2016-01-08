using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vocals
{
	public partial class FormAction : Form
	{
		private Keys[] keyDataSource;

		public float SelectedTimer { get; set; }

		public Keys SelectedKey { get; set; }

		public string SelectedType { get; set; }

		public Keys modifier { get; set; }

		public FormAction()
		{
			InitializeComponent();

			keyDataSource = (Keys[])Enum.GetValues(typeof(Keys)).Cast<Keys>();

			ComboKeys.DataSource = keyDataSource;
			this.RadioCommand.Checked = true;
			NumericTimer.DecimalPlaces = 2;
			NumericTimer.Increment = 0.1M;
		}

		public FormAction(Actions action)
		{
			InitializeComponent();
			keyDataSource = (Keys[])Enum.GetValues(typeof(Keys)).Cast<Keys>();

			ComboKeys.DataSource = keyDataSource;

			NumericTimer.DecimalPlaces = 2;
			NumericTimer.Increment = 0.1M;

			ComboKeys.SelectedItem = action.keys;
			NumericTimer.Value = Convert.ToDecimal(action.timer);

			if (action.type == "Key press")
				this.RadioCommand.Checked = true;
			else
				this.RadioTimer.Checked = true;

			switch (action.keyModifier)
			{
				case Keys.ControlKey:
					checkBox1.Checked = true;
					break;

				case Keys.ShiftKey:
					checkBox2.Checked = true;
					break;

				case Keys.Alt:
					checkBox3.Checked = true;
					break;

				default:
					break;
			}
		}

		private void FormAction_Load(object sender, System.EventArgs e)
		{
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			SelectedTimer = (float)NumericTimer.Value;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectedKey = (Keys)ComboKeys.SelectedItem;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SelectedType = "";
			SelectedTimer = 0;
			SelectedKey = Keys.None;
			this.Close();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				checkBox2.Checked = false;
				checkBox3.Checked = false;
				modifier = Keys.ControlKey;
			}
			else {
				modifier = Keys.None;
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				checkBox1.Checked = false;
				checkBox3.Checked = false;
				modifier = Keys.ShiftKey;
			}
			else {
				modifier = Keys.None;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked)
			{
				checkBox1.Checked = false;
				checkBox2.Checked = false;
				modifier = Keys.Alt;
			}
			else {
				modifier = Keys.None;
			}
		}

		private void RadioCommand_CheckedChanged(object sender, EventArgs e)
		{
			this.SelectedType = "Key press";

			NumericTimer.Enabled = false;
			ComboKeys.Enabled = true;
			checkBox1.Enabled = true;
			checkBox2.Enabled = true;
			checkBox3.Enabled = true;

			TableCommands.Visible = true;
			TableTimer.Visible = false;
		}

		private void RadioTimer_CheckedChanged(object sender, EventArgs e)
		{
			this.SelectedType = "Timer";
			NumericTimer.Enabled = true;
			ComboKeys.Enabled = false;
			checkBox1.Enabled = false;
			checkBox2.Enabled = false;
			checkBox3.Enabled = false;

			TableCommands.Visible = false;
			TableTimer.Visible = true;
		}
	}
}