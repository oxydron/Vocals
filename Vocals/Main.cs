using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Vocals.InternalClasses;

namespace Vocals
{
	public partial class Main : Form
	{
		private Options _CurrentOptions;

		private GlobalHotkey _GlobalHotkey;

		private bool _Listening = false;

		private List<string> _WindowsList;

		private List<Profile> _ProfileList;

		private SpeechRecognitionEngine _SpeechEngine;

		private IntPtr _WinPointer;
		private bool _OKToSave = false;

		public Main()
		{
			_CurrentOptions = new Options();

			InitializeComponent();
			initialyzeSpeechEngine();

			_WindowsList = new List<string>();
			refreshProcessesList();

			fetchProfiles();

			_GlobalHotkey = new GlobalHotkey(0x0004, Keys.None, this);

			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			System.Reflection.AssemblyName assemblyName = assembly.GetName();
			Version version = assemblyName.Version;
			this.Text += " version : " + version.ToString();

			refreshSettings();

			this._OKToSave = true;
		}

		protected delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

		public void handleHookedKeypress()
		{
			if (_Listening == false)
			{
				if (_SpeechEngine.Grammars.Count > 0)
				{
					_SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
					SpeechSynthesizer synth = new SpeechSynthesizer();
					synth.SpeakAsync(_CurrentOptions.answer);
					_Listening = !_Listening;
				}
			}
			else {
				if (_SpeechEngine.Grammars.Count > 0)
				{
					_SpeechEngine.RecognizeAsyncCancel();
					SpeechSynthesizer synth = new SpeechSynthesizer();
					synth.SpeakAsync(_CurrentOptions.answer);
					_Listening = !_Listening;
				}
			}
		}

		public void refreshProcessesList()
		{
			EnumWindows(new EnumWindowsProc(EnumTheWindows), IntPtr.Zero);
			ComboApps.DataSource = null;
			ComboApps.DataSource = _WindowsList;
		}

		[DllImport("user32.dll")]
		protected static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		protected static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		protected static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll")]
		protected static extern bool IsWindowVisible(IntPtr hWnd);

		protected bool EnumTheWindows(IntPtr hWnd, IntPtr lParam)
		{
			int size = GetWindowTextLength(hWnd);
			if (size++ > 0 && IsWindowVisible(hWnd))
			{
				StringBuilder sb = new StringBuilder(size);
				GetWindowText(hWnd, sb, size);
				_WindowsList.Add(sb.ToString());
			}
			return true;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0312)
			{
				handleHookedKeypress();
			}
			base.WndProc(ref m);
		}

		private static void Get45or451FromRegistry()
		{
			using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
			   RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\"))
			{
				int releaseKey = (int)ndpKey.GetValue("Release");
				{
					if (releaseKey == 378389)

						Console.WriteLine("The .NET Framework version 4.5 is installed");

					if (releaseKey == 378758)

						Console.WriteLine("The .NET Framework version 4.5.1  is installed");
				}
			}
		}

		private void advancedSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormOptions formOptions = new FormOptions();
			formOptions.ShowDialog();

			_CurrentOptions = formOptions.opt;
			refreshSettings();
		}

		private void applyModificationToGlobalHotKey()
		{
			if (_CurrentOptions.key == Keys.Shift ||
				_CurrentOptions.key == Keys.ShiftKey ||
				_CurrentOptions.key == Keys.LShiftKey ||
				_CurrentOptions.key == Keys.RShiftKey)
			{
				_GlobalHotkey.modifyKey(0x0004, Keys.None);
			}
			else if (_CurrentOptions.key == Keys.Control ||
				_CurrentOptions.key == Keys.ControlKey ||
				_CurrentOptions.key == Keys.LControlKey ||
				_CurrentOptions.key == Keys.RControlKey)
			{
				_GlobalHotkey.modifyKey(0x0002, Keys.None);
			}
			else if (_CurrentOptions.key == Keys.Alt)
			{
				_GlobalHotkey.modifyKey(0x0002, Keys.None);
			}
			else {
				_GlobalHotkey.modifyKey(0x0000, _CurrentOptions.key);
			}
		}

		private void applyRecognitionSensibility()
		{
			if (_SpeechEngine != null)
			{
				_SpeechEngine.UpdateRecognizerSetting("CFGConfidenceRejectionThreshold", _CurrentOptions.threshold);
			}
		}

		private void applyToggleListening()
		{
			if (_CurrentOptions.toggleListening)
			{
				try
				{
					_GlobalHotkey.register();
				}
				catch
				{
					Console.WriteLine("Couldn't register key properly");
				}
			}
			else {
				try
				{
					_GlobalHotkey.unregister();
				}
				catch
				{
					Console.WriteLine("Couldn't unregister key properly");
				}
			}
		}

		/// <summary>
		/// New command
		/// </summary>
		private void ButtonAddCmd_Click(object sender, EventArgs e)
		{
			try
			{
				if (_SpeechEngine != null)
				{
					_SpeechEngine.RecognizeAsyncCancel();
					_Listening = false;

					FormCommand formCommand = new FormCommand();
					formCommand.ShowDialog();

					Profile p = (Profile)ComboProfiles.SelectedItem;

					if (p != null)
					{
						if (formCommand.commandString != null && formCommand.commandString != "" && formCommand.actionList.Count != 0)
						{
							Command c;
							c = new Command(formCommand.commandString, formCommand.actionList, formCommand.answering, formCommand.answeringString, formCommand.answeringSound, formCommand.answeringSoundPath);
							p.addCommand(c);
							ListCommands.DataSource = null;
							ListCommands.DataSource = p.commandList;
						}
						refreshProfile(p);
					}

					if (_SpeechEngine.Grammars.Count != 0)
					{
						_SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
						_Listening = true;
					}
				}

				this.DataModified(sender, e);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void ButtonAddProfile_Click(object sender, EventArgs e)
		{
			createNewProfile();
		}

		private void ButtonDeleteProfile_Click(object sender, EventArgs e)
		{
			Profile p = (Profile)(ComboProfiles.SelectedItem);
			_ProfileList.Remove(p);
			ComboProfiles.DataSource = null;
			ComboProfiles.DataSource = _ProfileList;

			if (_ProfileList.Count == 0)
			{
				ListCommands.DataSource = null;
			}
			else {
				ComboProfiles.SelectedItem = _ProfileList[0];
				refreshProfile((Profile)ComboProfiles.SelectedItem);
			}
		}

		private void ButtonDeleteCmd_Click(object sender, EventArgs e)
		{
			Profile p = (Profile)(ComboProfiles.SelectedItem);
			if (p != null)
			{
				Command c = (Command)ListCommands.SelectedItem;
				if (c != null)
				{
					if (_SpeechEngine != null)
					{
						_SpeechEngine.RecognizeAsyncCancel();
						_Listening = false;
						p.commandList.Remove(c);
						ListCommands.DataSource = null;
						ListCommands.DataSource = p.commandList;

						refreshProfile(p);

						if (_SpeechEngine.Grammars.Count != 0)
						{
							_SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
							_Listening = true;
						}
					}
				}
			}

			this.DataModified(sender, e);
		}

		private void ButtonEditCmd_Click(object sender, EventArgs e)
		{
			try
			{
				if (_SpeechEngine != null)
				{
					_SpeechEngine.RecognizeAsyncCancel();
					_Listening = false;

					Command c = (Command)ListCommands.SelectedItem;
					if (c != null)
					{
						FormCommand formCommand = new FormCommand(c);
						formCommand.ShowDialog();

						Profile p = (Profile)ComboProfiles.SelectedItem;

						if (p != null)
						{
							if (formCommand.commandString != "" && formCommand.actionList.Count != 0)
							{
								c.commandString = formCommand.commandString;
								c.actionList = formCommand.actionList;
								c.answering = formCommand.answering;
								c.answeringString = formCommand.answeringString;
								c.answeringSound = formCommand.answeringSound;
								c.answeringSoundPath = formCommand.answeringSoundPath;

								if (c.answeringSoundPath == null)
								{
									c.answeringSoundPath = "";
								}
								if (c.answeringString == null)
								{
									c.answeringString = "";
								}

								ListCommands.DataSource = null;
								ListCommands.DataSource = p.commandList;
							}
							refreshProfile(p);
						}

						if (_SpeechEngine.Grammars.Count != 0)
						{
							_SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
							_Listening = true;
						}
					}
				}

				this.DataModified(sender, e);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			_WindowsList.Clear();
			refreshProcessesList();
		}

		private void ComboApps_SelectedIndexChanged(object sender, EventArgs e)
		{
			Process[] currProcesses = Process.GetProcesses();
			for (int i = 0; i < currProcesses.Length; i++)
			{
				if (currProcesses[i] != null && ComboApps.SelectedItem != null)
				{
					if (currProcesses[i].MainWindowTitle.Equals(ComboApps.SelectedItem.ToString()))
					{
						_WinPointer = currProcesses[i].MainWindowHandle;
					}
				}
			}

			if (this._OKToSave)
				this.SaveData();
		}

		private void ComboProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_SpeechEngine != null)
			{
				_SpeechEngine.RecognizeAsyncCancel();
				_Listening = false;
			}

			Profile p = (Profile)ComboProfiles.SelectedItem;
			if (p != null)
			{
				refreshProfile(p);

				ListCommands.DataSource = null;
				ListCommands.DataSource = p.commandList;

				if (_SpeechEngine.Grammars.Count != 0)
				{
					_SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
					_Listening = true;
				}
			}
		}

		private void createNewProfile()
		{
			FormNewProfile formNewProfile = new FormNewProfile();
			formNewProfile.ShowDialog();
			string profileName = formNewProfile.profileName;
			if (profileName != "")
			{
				Profile p = new Profile(profileName);
				_ProfileList.Add(p);
				ComboProfiles.DataSource = null;
				ComboProfiles.DataSource = _ProfileList;
				ComboProfiles.SelectedItem = p;
			}
		}

		private void fetchProfiles()
		{
			string dir = @"";
			string serializationFile = Path.Combine(dir, "profiles.vd");
			string xmlSerializationFile = Path.Combine(dir, "profiles_xml.vc");
			try
			{
				Stream xmlStream = File.Open(xmlSerializationFile, FileMode.Open);
				XmlSerializer reader = new XmlSerializer(typeof(List<Profile>));
				_ProfileList = (List<Profile>)reader.Deserialize(xmlStream);
				xmlStream.Close();
			}
			catch
			{
				try
				{
					Stream stream = File.Open(serializationFile, FileMode.Open);
					var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					_ProfileList = (List<Profile>)(bformatter.Deserialize(stream));
					stream.Close();
				}
				catch
				{
					_ProfileList = new List<Profile>();
				}
			}
			ComboProfiles.DataSource = _ProfileList;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_SpeechEngine.AudioLevelUpdated -= new EventHandler<AudioLevelUpdatedEventArgs>(sr_audioLevelUpdated);
			_SpeechEngine.SpeechRecognized -= new EventHandler<SpeechRecognizedEventArgs>(sr_speechRecognized);

			SaveData();
		}

		/// <summary>
		/// Saves that data on disk
		/// </summary>
		private void SaveData()
		{
			string dir = @"";
			string serializationFile = Path.Combine(dir, "profiles.vd");
			string xmlSerializationFile = Path.Combine(dir, "profiles_xml.vc");
			try
			{
				Stream stream = File.Open(serializationFile, FileMode.Create);
				var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				bformatter.Serialize(stream, _ProfileList);
				stream.Close();

				try
				{
					Stream xmlStream = File.Open(xmlSerializationFile, FileMode.Create);
					XmlSerializer writer = new XmlSerializer(typeof(List<Profile>));
					writer.Serialize(xmlStream, _ProfileList);
					xmlStream.Close();
				}
				catch
				{
					// TODO refatorar para regionalização
					DialogResult res = MessageBox.Show("Le fichier profiles_xml.vc est en cours d'utilisation par un autre processus. Voulez vous quitter sans sauvegarder ?",
						"Impossible de sauvegarder",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button1);
				}
			}
			catch
			{
				// TODO refatorar para regionalização
				DialogResult res = MessageBox.Show("Le fichier profiles.vd est en cours d'utilisation par un autre processus. Voulez vous quitter sans sauvegarder ?",
					"Impossible de sauvegarder",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1);
			}

			// TODO regionalization
			this.TextBoxLog.AppendText("Profile saved!\n");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Get45or451FromRegistry();
		}

		private void initialyzeSpeechEngine()
		{
			TextBoxLog.AppendText("Welcome to Vocals, a Speech Recognition Engine!\nForked from Al-th, maintained by Oxydron\n");
			RecognizerInfo info = null;

			//Use system locale language if no language option can be retrieved
			if (_CurrentOptions.language == null)
			{
				_CurrentOptions.language = System.Globalization.CultureInfo.CurrentUICulture.DisplayName;
			}

			foreach (RecognizerInfo ri in SpeechRecognitionEngine.InstalledRecognizers())
			{
				if (ri.Culture.DisplayName.Equals(_CurrentOptions.language))
				{
					info = ri;
					break;
				}
			}

			if (info == null && SpeechRecognitionEngine.InstalledRecognizers().Count != 0)
			{
				RecognizerInfo ri = SpeechRecognitionEngine.InstalledRecognizers()[0];
				info = ri;
			}

			if (info != null)
			{
				TextBoxLog.AppendText("Setting VR engine language to " + info.Culture.DisplayName + "\n");
			}
			else
			{
				TextBoxLog.AppendText("Could not find any installed recognizers\n");
				TextBoxLog.AppendText("Trying to find a fix right now for this specific error\n");
				return;
			}

			_SpeechEngine = new SpeechRecognitionEngine(info);
			_SpeechEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_speechRecognized);
			_SpeechEngine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(sr_audioLevelUpdated);

			try
			{
				_SpeechEngine.SetInputToDefaultAudioDevice();
			}
			catch
			{
				TextBoxLog.AppendText("No microphone were found\n");
			}

			_SpeechEngine.MaxAlternates = 3;
		}

		private void refreshProfile(Profile p)
		{
			if (p.commandList.Count != 0)
			{
				Choices myWordChoices = new Choices();

				foreach (Command c in p.commandList)
				{
					string[] commandList = c.commandString.Split(';');
					foreach (string s in commandList)
					{
						string correctedWord;
						correctedWord = s.Trim().ToLower();
						if (correctedWord != null && correctedWord != "")
						{
							myWordChoices.Add(correctedWord);
						}
					}
				}

				GrammarBuilder builder = new GrammarBuilder();
				builder.Append(myWordChoices);
				Grammar mygram = new Grammar(builder);

				_SpeechEngine.UnloadAllGrammars();
				_SpeechEngine.LoadGrammar(mygram);
			}
			else {
				_SpeechEngine.UnloadAllGrammars();
			}
		}

		private void refreshSettings()
		{
			applyModificationToGlobalHotKey();
			applyToggleListening();
			applyRecognitionSensibility();
			_CurrentOptions.save();
		}

		private void sr_audioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
		{
			if (_SpeechEngine != null)
			{
				int val = (int)(10 * Math.Sqrt(e.AudioLevel));
				this.ProgressVoiceCaptured.Value = val;
			}
		}

		private void sr_speechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			TextBoxLog.AppendText("Commande reconnue \"" + e.Result.Text + "\" with confidence of : " + e.Result.Confidence + "\n");

			Profile p = (Profile)ComboProfiles.SelectedItem;

			if (p != null)
			{
				foreach (Command c in p.commandList)
				{
					string[] multiCommands = c.commandString.Split(';');
					foreach (string s in multiCommands)
					{
						string correctedWord = s.Trim().ToLower();
						if (correctedWord.Equals(e.Result.Text))
						{
							c.perform(_WinPointer);
							break;
						}
					}
				}
			}
		}

		private void ListCommands_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ButtonEditCmd_Click(sender, e);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			this.SaveData();
		}

		private void DataModified(object sender, EventArgs e)
		{
			this.SaveData();
		}
	}
}