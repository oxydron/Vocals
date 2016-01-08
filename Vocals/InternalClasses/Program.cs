using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vocals
{
	internal static class Program
	{
		[DllImport("winmm.dll")]
		public static extern int waveInGetNumDevs();

		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		///
		///
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (waveInGetNumDevs() == 0)
			{
				MessageBox.Show("Please plug a valid microphone before launching the application", "No microphone found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else {
				Application.Run(new Main());
			}
		}
	}
}