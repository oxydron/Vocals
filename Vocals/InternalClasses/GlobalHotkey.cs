using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vocals.InternalClasses
{
	internal class GlobalHotkey
	{
		private int modifier;
		private int key;
		private IntPtr hWnd;
		private int id;

		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		public GlobalHotkey(int mod, Keys k, Main hw)
		{
			this.modifier = mod;
			this.key = (int)k;
			this.hWnd = hw.Handle;
			this.id = this.GetHashCode();
		}

		public void modifyKey(int mod, Keys k)
		{
			this.modifier = mod;
			this.key = (int)k;
		}

		public override int GetHashCode()
		{
			return modifier ^ key ^ hWnd.ToInt32();
		}

		public bool register()
		{
			return RegisterHotKey(hWnd, id, modifier, key);
		}

		public bool unregister()
		{
			return UnregisterHotKey(hWnd, id);
		}
	}
}