﻿
using System;
using System.Windows.Forms;

namespace Zestaw4Zad2
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
