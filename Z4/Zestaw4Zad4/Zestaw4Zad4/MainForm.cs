
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Zestaw4Zad4
{
	
	public partial class MainForm : Form
	{
		Czytanka hello;
		public MainForm()
		{
			
			InitializeComponent();
			hello = new Czytanka();
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			hello.choice("Odwrotnie");
			hello.H("random.txt");
			textBox1.Text = hello.teks_wynikowy;
		}
		void Button2Click(object sender, EventArgs e)
		{
			hello.choice("Normalnie");
			hello.H("random.txt");
			textBox1.Text = hello.teks_wynikowy;
		}
	}
	
	public class Czytanka
	{
		public delegate void Tekst(string x);
		public Tekst H;
		public string teks_wynikowy;
		public void Normalnie(string NazwaPliku)
	{
			string bufor = "";
			bufor = File.ReadAllText(NazwaPliku);
			teks_wynikowy = bufor;
			
	}
	
		public void Odwrotnie(string NazwaPliku)
	{
			
			FileStream Czytanka = new FileStream(NazwaPliku,FileMode.Open,FileAccess.Read);
			byte[] bufor = new byte[Czytanka.Length];
			Czytanka.Read(bufor,0,(int)Czytanka.Length);
			Array.Reverse(bufor);
			teks_wynikowy = Encoding.Default.GetString(bufor);
			Czytanka.Close();
	}
		
		public void choice(string wybor)
		{
		switch (wybor) {
					case("Odwrotnie"):{H = Odwrotnie;break;}
					case("Normalnie"):{H = Normalnie;break;}
					default:{break;}
		}
		
		}
	}
	
	
}
