﻿
using System;
using System.Windows.Forms;

namespace Zestaw1Zad1
{
	
	internal sealed class Program
	{
		
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
