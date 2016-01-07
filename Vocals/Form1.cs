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
	public partial class Form1 : Form {

		Options currentOptions;

		private GlobalHotkey ghk;

		bool listening = false;

		List<string> myWindows;

		List<Profile> profileList;

		SpeechRecognitionEngine speechEngine;

		IntPtr winPointer;

		public Form1()
		{
			currentOptions = new Options();

			InitializeComponent();
			initialyzeSpeechEngine();

			myWindows = new List<string>();
			refreshProcessesList();


			fetchProfiles();



			ghk = new GlobalHotkey(0x0004, Keys.None, this);

			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			System.Reflection.AssemblyName assemblyName = assembly.GetName();
			Version version = assemblyName.Version;
			this.Text += " version : " + version.ToString();

			refreshSettings();

		}

		protected delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
		public void handleHookedKeypress()
		{
			if (listening == false)
			{
				if (speechEngine.Grammars.Count > 0)
				{
					speechEngine.RecognizeAsync(RecognizeMode.Multiple);
					SpeechSynthesizer synth = new SpeechSynthesizer();
					synth.SpeakAsync(currentOptions.answer);
					listening = !listening;
				}

			}
			else {
				if (speechEngine.Grammars.Count > 0)
				{
					speechEngine.RecognizeAsyncCancel();
					SpeechSynthesizer synth = new SpeechSynthesizer();
					synth.SpeakAsync(currentOptions.answer);
					listening = !listening;
				}
			}
		}

		public void refreshProcessesList()
		{
			EnumWindows(new EnumWindowsProc(EnumTheWindows), IntPtr.Zero);
			ComboApps.DataSource = null;
			ComboApps.DataSource = myWindows;

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
				myWindows.Add(sb.ToString());
			}
			return true;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0312) {
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

			currentOptions = formOptions.opt;
			refreshSettings();
		}

		private void applyModificationToGlobalHotKey()
		{
			if (currentOptions.key == Keys.Shift ||
				currentOptions.key == Keys.ShiftKey ||
				currentOptions.key == Keys.LShiftKey ||
				currentOptions.key == Keys.RShiftKey)
			{
				ghk.modifyKey(0x0004, Keys.None);
			}
			else if (currentOptions.key == Keys.Control ||
				currentOptions.key == Keys.ControlKey ||
				currentOptions.key == Keys.LControlKey ||
				currentOptions.key == Keys.RControlKey)
			{
				ghk.modifyKey(0x0002, Keys.None);

			}
			else if (currentOptions.key == Keys.Alt)
			{
				ghk.modifyKey(0x0002, Keys.None);
			}
			else {
				ghk.modifyKey(0x0000, currentOptions.key);
			}
		}

		private void applyRecognitionSensibility()
		{
			if (speechEngine != null)
			{
				speechEngine.UpdateRecognizerSetting("CFGConfidenceRejectionThreshold", currentOptions.threshold);
			}

		}

		private void applyToggleListening()
		{
			if (currentOptions.toggleListening)
			{
				try
				{
					ghk.register();
				}
				catch
				{
					Console.WriteLine("Couldn't register key properly");
				}
			}
			else {
				try
				{
					ghk.unregister();
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
				if (speechEngine != null)
				{
					speechEngine.RecognizeAsyncCancel();
					listening = false;

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

					if (speechEngine.Grammars.Count != 0)
					{
						speechEngine.RecognizeAsync(RecognizeMode.Multiple);
						listening = true;
					}
				}
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
			profileList.Remove(p);
			ComboProfiles.DataSource = null;
			ComboProfiles.DataSource = profileList;

			if (profileList.Count == 0)
			{
				ListCommands.DataSource = null;
			}
			else {
				ComboProfiles.SelectedItem = profileList[0];
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
					if (speechEngine != null)
					{
						speechEngine.RecognizeAsyncCancel();
						listening = false;
						p.commandList.Remove(c);
						ListCommands.DataSource = null;
						ListCommands.DataSource = p.commandList;

						refreshProfile(p);

						if (speechEngine.Grammars.Count != 0)
						{
							speechEngine.RecognizeAsync(RecognizeMode.Multiple);
							listening = true;
						}
					}

				}
			}
		}

		private void ButtonEditCmd_Click(object sender, EventArgs e)
		{
			try
			{
				if (speechEngine != null)
				{
					speechEngine.RecognizeAsyncCancel();
					listening = false;


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

						if (speechEngine.Grammars.Count != 0)
						{
							speechEngine.RecognizeAsync(RecognizeMode.Multiple);
							listening = true;
						}
					}

				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			myWindows.Clear();
			refreshProcessesList();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void ComboApps_SelectedIndexChanged(object sender, EventArgs e)
		{
			Process[] pTab = Process.GetProcesses();
			for (int i = 0; i < pTab.Length; i++)
			{
				if (pTab[i] != null && ComboApps.SelectedItem != null)
				{
					if (pTab[i].MainWindowTitle.Equals(ComboApps.SelectedItem.ToString()))
					{
						winPointer = pTab[i].MainWindowHandle;
					}
				}
			}
		}

		private void ComboProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (speechEngine != null)
			{
				speechEngine.RecognizeAsyncCancel();
				listening = false;
			}

			Profile p = (Profile)ComboProfiles.SelectedItem;
			if (p != null)
			{
				refreshProfile(p);

				ListCommands.DataSource = null;
				ListCommands.DataSource = p.commandList;

				if (speechEngine.Grammars.Count != 0)
				{
					speechEngine.RecognizeAsync(RecognizeMode.Multiple);
					listening = true;
				}
			}
		}

		void createNewProfile()
		{
			FormNewProfile formNewProfile = new FormNewProfile();
			formNewProfile.ShowDialog();
			string profileName = formNewProfile.profileName;
			if (profileName != "")
			{
				Profile p = new Profile(profileName);
				profileList.Add(p);
				ComboProfiles.DataSource = null;
				ComboProfiles.DataSource = profileList;
				ComboProfiles.SelectedItem = p;
			}
		}

		void fetchProfiles()
		{
			string dir = @"";
            string serializationFile = Path.Combine(dir, "profiles.vd");
            string xmlSerializationFile = Path.Combine(dir, "profiles_xml.vc");
            try {
                Stream xmlStream = File.Open(xmlSerializationFile, FileMode.Open);
                XmlSerializer reader = new XmlSerializer(typeof(List<Profile>));
                profileList = (List<Profile>)reader.Deserialize(xmlStream);
                xmlStream.Close();
            }
            catch {
                try {
                    Stream stream = File.Open(serializationFile, FileMode.Open);
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    profileList = (List<Profile>)(bformatter.Deserialize(stream));
                    stream.Close();


                }
                catch {
                    profileList = new List<Profile>();
                }
            }
            ComboProfiles.DataSource = profileList;
        }
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			speechEngine.AudioLevelUpdated -= new EventHandler<AudioLevelUpdatedEventArgs>(sr_audioLevelUpdated);
			speechEngine.SpeechRecognized -= new EventHandler<SpeechRecognizedEventArgs>(sr_speechRecognized);

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
				bformatter.Serialize(stream, profileList);
				stream.Close();

				try
				{
					Stream xmlStream = File.Open(xmlSerializationFile, FileMode.Create);
					System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Profile>));
					writer.Serialize(xmlStream, profileList);
					xmlStream.Close();
				}
				catch (Exception ex)
				{
					DialogResult res = MessageBox.Show("Le fichier profiles_xml.vc est en cours d'utilisation par un autre processus. Voulez vous quitter sans sauvegarder ?", "Impossible de sauvegarder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				}

			}
			catch (Exception ex)
			{
				DialogResult res = MessageBox.Show("Le fichier profiles.vd est en cours d'utilisation par un autre processus. Voulez vous quitter sans sauvegarder ?", "Impossible de sauvegarder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Get45or451FromRegistry();

        }

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

		void initialyzeSpeechEngine()
		{
			TextBoxLog.AppendText("Starting Speech Recognition Engine \n");
            RecognizerInfo info = null;

            //Use system locale language if no language option can be retrieved
            if (currentOptions.language == null) {
                currentOptions.language = System.Globalization.CultureInfo.CurrentUICulture.DisplayName;
            }

            foreach (RecognizerInfo ri in SpeechRecognitionEngine.InstalledRecognizers()) {
                if(ri.Culture.DisplayName.Equals(currentOptions.language)) {
                    info = ri;
                    break;
                }
            }

            if (info == null && SpeechRecognitionEngine.InstalledRecognizers().Count != 0) {
                RecognizerInfo ri = SpeechRecognitionEngine.InstalledRecognizers()[0];
                info = ri;
            }

            if (info != null){
                TextBoxLog.AppendText("Setting VR engine language to " + info.Culture.DisplayName + "\n");
            } else {
                TextBoxLog.AppendText("Could not find any installed recognizers\n");
                TextBoxLog.AppendText("Trying to find a fix right now for this specific error\n");
                return;
            }
            speechEngine = new SpeechRecognitionEngine(info);
            speechEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_speechRecognized);
            speechEngine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(sr_audioLevelUpdated);

            try {
                speechEngine.SetInputToDefaultAudioDevice();
            }
            catch (InvalidOperationException ioe) {
                TextBoxLog.AppendText("No microphone were found\n");
            }

            speechEngine.MaxAlternates = 3;


        }

		void refreshProfile(Profile p)
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


				speechEngine.UnloadAllGrammars();
				speechEngine.LoadGrammar(mygram);

			}
			else {
				speechEngine.UnloadAllGrammars();
			}

		}

		private void refreshSettings()
		{
			applyModificationToGlobalHotKey();
			applyToggleListening();
			applyRecognitionSensibility();
			currentOptions.save();
		}

		void sr_audioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
		{
			if (speechEngine != null) {
                int val = (int)(10*Math.Sqrt(e.AudioLevel));
                this.ProgressVoiceCaptured.Value = val;
            }
        }



        void sr_speechRecognized(object sender, SpeechRecognizedEventArgs e) {

            TextBoxLog.AppendText("Commande reconnue \"" + e.Result.Text + "\" with confidence of : " + e.Result.Confidence + "\n");

            Profile p = (Profile)ComboProfiles.SelectedItem;

            if (p != null) {
                foreach (Command c in p.commandList) {
                    string[] multiCommands = c.commandString.Split(';');
                    foreach (string s in multiCommands) {
                        string correctedWord = s.Trim().ToLower();
                        if (correctedWord.Equals(e.Result.Text)) {
                            c.perform(winPointer);
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
	}
}
