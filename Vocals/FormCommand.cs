using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Vocals
{
	public partial class FormCommand : Form
	{
		public List<Actions> actionList { get; set; }
		public string commandString { get; set; }

		public bool answering { get; set; }
		public string answeringString { get; set; }

		public bool answeringSound { get; set; }
		public string answeringSoundPath { get; set; }

		public FormCommand()
		{
			InitializeComponent();
			actionList = new List<Actions>();
			commandString = "";

			answering = false;
			answeringString = "";

			ListCommands.DataSource = actionList;
		}

		public FormCommand(Command c)
		{
			InitializeComponent();
			actionList = c.actionList;
			commandString = c.commandString;

			answering = c.answering;
			checkBox1.Checked = answering;

			answeringString = c.answeringString;
			TextVoiceAnswer.Text = answeringString;

			answeringSound = c.answeringSound;
			CheckUseSoundFile.Checked = answeringSound;

			answeringSoundPath = c.answeringSoundPath;
			textBox2.Text = answeringSoundPath;

			ListCommands.DataSource = actionList;
			TextVoiceCommand.Text = commandString;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.commandString = TextVoiceCommand.Text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (ListCommands.SelectedItem != null)
			{
				actionList.RemoveAt(ListCommands.SelectedIndex);
				ListCommands.DataSource = null;
				ListCommands.DataSource = actionList;
			}
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			using (FormAction form = new FormAction())
			{				
				form.ShowDialog();

				if (form.SelectedType != "")
				{
					if (form.SelectedType == "Key press" && form.SelectedKey != Keys.None ||
						form.SelectedType == "Timer" && form.SelectedTimer != 0)
					{
						Actions myNewAction = new Actions(form.SelectedType,
							form.SelectedKey,
							form.modifier,
							form.SelectedTimer);

						actionList.Add(myNewAction);

						ListCommands.DataSource = null;
						ListCommands.DataSource = actionList;
					}
				} 
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			commandString = "";
			actionList.Clear();
			this.Close();
		}

		private void ButtonEdit_Click(object sender, EventArgs e)
		{
			Actions a = (Actions)ListCommands.SelectedItem;
			if (a != null)
			{
				FormAction formEditAction = new FormAction(a);
				formEditAction.ShowDialog();

				a.keys = formEditAction.SelectedKey;
				a.type = formEditAction.SelectedType;
				a.keyModifier = formEditAction.modifier;
				a.timer = (float)formEditAction.SelectedTimer;

				ListCommands.DataSource = null;
				ListCommands.DataSource = actionList;
			}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListCommands.SelectedIndex;
			if (selectedIndex > 0)
			{
				Actions actionToMoveDown = actionList.ElementAt(selectedIndex - 1);
				actionList.RemoveAt(selectedIndex - 1);
				actionList.Insert(selectedIndex, actionToMoveDown);

				ListCommands.DataSource = null;
				ListCommands.DataSource = actionList;
				ListCommands.SelectedIndex = selectedIndex - 1;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListCommands.SelectedIndex;
			if (selectedIndex < actionList.Count - 1)
			{
				Actions actionToMoveUp = actionList.ElementAt(selectedIndex + 1);
				actionList.RemoveAt(selectedIndex + 1);
				actionList.Insert(selectedIndex, actionToMoveUp);

				ListCommands.DataSource = null;
				ListCommands.DataSource = actionList;
				ListCommands.SelectedIndex = selectedIndex + 1;
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			answeringString = TextVoiceAnswer.Text;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				CheckUseSoundFile.Checked = false;
				answeringSound = false;
			}
			answering = checkBox1.Checked;
		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void button9_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Filter = "Sound file (*.wav,*.mp3)|*.wav;*.mp3";

			if (ofd.ShowDialog() == DialogResult.OK && ofd.CheckPathExists)
			{
				textBox2.Text = ofd.InitialDirectory + ofd.FileName;
				answeringSoundPath = textBox2.Text;
			}
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckUseSoundFile.Checked)
			{
				checkBox1.Checked = false;
				answering = false;
			}
			answeringSound = true;
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ButtonEdit_Click(sender, e);
		}
	}
}