﻿// BackupTab.cs in bukkitgui2/bukkitgui2
// Created 2014/01/17
// Last edited at 2014/07/13 14:01
// ©Bertware, visit http://bertware.net

using System.Windows.Forms;

namespace Net.Bertware.Bukkitgui2.AddOn.Backup
{
	public partial class BackupTab : UserControl, IAddonTab
	{
		public BackupTab()
		{
			InitializeComponent();
		}

		public IAddon ParentAddon { get; set; }
	}
}