﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace Vocals
{
	[Serializable]
	public class Command
	{
		public string commandString;
		public List<Actions> actionList;

		public bool answering { get; set; }

		public string answeringString { get; set; }

		public bool answeringSound { get; set; }

		public string answeringSoundPath { get; set; }

		public Command()
		{
		}

		public Command(string commandString, List<Actions> actionList)
		{
			this.commandString = commandString;
			this.actionList = actionList;
			this.answering = false;
			this.answeringString = "";
		}

		public Command(string commandString, List<Actions> actionList, bool answering, string answeringString, bool answeringSound, string answeringSoundPath)
		{
			this.commandString = commandString;
			this.actionList = actionList;
			this.answering = answering;
			this.answeringString = answeringString;
			if (answeringString == null)
			{
				answeringString = "";
			}
			this.answeringSound = answeringSound;
			this.answeringSoundPath = answeringSoundPath;
			if (answeringSoundPath == null)
			{
				answeringSoundPath = "";
			}
		}

		~Command()
		{
		}

		public override string ToString()
		{
			string returnString = commandString + " : " + actionList.Count.ToString();
			if (actionList.Count > 1)
			{
				returnString += " actions";
			}
			else {
				returnString += " action";
			}

			return returnString;
		}

		[DllImport("User32.dll")]
		private static extern int SetForegroundWindow(IntPtr point);

		[DllImport("User32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		public void perform(IntPtr winPointer)
		{
			SetForegroundWindow(winPointer);
			ShowWindow(winPointer, 5);
			foreach (Actions a in actionList)
			{
				a.perform();
			}
			if (answering && answeringString != null)
			{
				try
				{
					SpeechSynthesizer synth = new SpeechSynthesizer();
					if (synth != null)
					{
						synth.SpeakAsync(answeringString);
					}
				}
				catch { }
			}

			if (answeringSound && answeringSoundPath != null)
			{
				if (answeringSoundPath.IndexOf(".wav") == answeringSoundPath.Length - 4)
				{
					System.Media.SoundPlayer player = new System.Media.SoundPlayer();
					player.SoundLocation = answeringSoundPath;
					player.Play();
				}
				else if (answeringSoundPath.IndexOf(".mp3") == answeringSoundPath.Length - 4)
				{
					WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

					wplayer.URL = answeringSoundPath;
					wplayer.controls.play();
				}
			}
		}
	}
}