﻿// EditorTab.cs in bukkitgui2/bukkitgui2
// Created 2014/01/17
// Last edited at 2014/07/13 14:01
// ©Bertware, visit http://bertware.net

namespace Net.Bertware.Bukkitgui2.AddOn.Editor
{
	public partial class EditorTab : IAddonTab
	{
		public EditorTab()
		{
			InitializeComponent();
		}

		public IAddon ParentAddon { get; set; }
	}
}