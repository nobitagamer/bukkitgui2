﻿using System.Windows.Forms;

namespace Net.Bertware.Bukkitgui2.AddOn.Settings
{
	internal class Settings : IAddon
	{
		public Settings()
		{
			TabPage = null;
		}

		/// <summary>
		/// True if this addon has a tab page
		/// </summary>
		public bool HasTab
		{
			get { return true; }
		}

		/// <summary>
		/// True if this addon has a config field
		/// </summary>
		public bool HasConfig
		{
			get { return false; }
		}

		/// <summary>
		///     The tab control for this addon
		/// </summary>
		/// <returns>Returns the tabpage</returns>
		public UserControl TabPage { get; private set; }

		public UserControl ConfigPage { get; private set; }

		/// <summary>
		///     The addon name, ideally this name is the same as used in the tabpage
		/// </summary>
		public string Name
		{
			get { return "Settings"; }
		}

		/// <summary>
		///     Initialize all functions and the tabcontrol
		/// </summary>
		void IAddon.Initialize()
		{
			TabPage = new SettingsTab {Text = Name, ParentAddon = this};
		}
	}
}