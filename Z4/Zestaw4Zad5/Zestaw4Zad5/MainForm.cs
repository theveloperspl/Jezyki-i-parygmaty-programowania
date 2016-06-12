
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Linq;
namespace Zestaw4Zad5
{
	
	public partial class MainForm : Form
	{
		szyfry d;
		public MainForm()
		{
			
			InitializeComponent();
			d = new szyfry();
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			d.wybor("AtBash");
			d.S("random.txt");
			textBox1.Text = d.Tekst_zaszyfrowany;
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(textBox2.Text !=""){	d.Klucz = textBox2.Text;}
			if (checkBox1.Checked == true) { d.Strona = true;}
			else if(checkBox1.Checked == false){d.Strona = false;}
			
			d.wybor("Cezar");
			d.S("random.txt");
			textBox1.Text = d.Tekst_zaszyfrowany;
		}

		
	}
	
	
	public class szyfry
	{
		public delegate void szyfr(string Nazwapliku);
		public szyfr S ;
	
		public string Tekst_zaszyfrowany;
		public string Klucz = "1";
		public bool Strona = true;
		public void Atbash(string Nazwapliku)
		{	
			string alfabet ="ABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
			string _alfabet = "abcdefghijklmnopqrstuvwxyz";
			string Ralfabet = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
			string _Ralfabet = "zyxwvutsrqponmlkjihgfedcba";
			string tekst_jawny = File.ReadAllText(Nazwapliku);
			Tekst_zaszyfrowany = "";
				for (int i = 0; i < tekst_jawny.Length; i++) {
					for (int j = 0; j < alfabet.Length; j++) {
						if (tekst_jawny[i] == alfabet[j]) {
						Tekst_zaszyfrowany = Tekst_zaszyfrowany +  Ralfabet[j];
						}
					else if (tekst_jawny[i]==_alfabet[j]) {
						Tekst_zaszyfrowany = Tekst_zaszyfrowany + _Ralfabet[j];
					}
					
					}
				if (tekst_jawny[i]==' ') {Tekst_zaszyfrowany = Tekst_zaszyfrowany + " ";
					
				}
				}}
	
		public void Cezar(string Nazwapliku)
		{
			
			Tekst_zaszyfrowany = " ";
			int przesuniecie = Convert.ToInt16(Klucz);
			string tekst_jawny = File.ReadAllText(Nazwapliku);
		 	string alfabet ="ABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
			string _alfabet = "abcdefghijklmnopqrstuvwxyz";
			
			string palfabet = "";
			string _palfabet = "";
			if(Strona == true){
			przesuniecie %= alfabet.Length;
     palfabet =  alfabet.Substring(alfabet.Length - przesuniecie) + alfabet.Substring(0, alfabet.Length - przesuniecie);
	 _palfabet =  _alfabet.Substring(_alfabet.Length - przesuniecie) + _alfabet.Substring(0, _alfabet.Length - przesuniecie);	
			}
			else if (Strona == false) {
			
				palfabet = alfabet.Remove(0,przesuniecie) + alfabet.Substring(0,przesuniecie);
		 _palfabet = _alfabet.Remove(0,przesuniecie) + _alfabet.Substring(0,przesuniecie);
			}
			
			
			for (int i = 0; i < tekst_jawny.Length; i++) {
				for (int j = 0; j < alfabet.Length; j++) {
					if (tekst_jawny[i] == alfabet[j]) {
						Tekst_zaszyfrowany = Tekst_zaszyfrowany + palfabet[j];
					}
					else if (tekst_jawny[i] == _alfabet[j]) {
						Tekst_zaszyfrowany = Tekst_zaszyfrowany + _palfabet[j];
					}
					
				}
				if (tekst_jawny[i]==' ') {Tekst_zaszyfrowany = Tekst_zaszyfrowany + " ";
			}
		}	}

			public void wybor(string szyfrowanie)
		{
				switch (szyfrowanie) {
						case("AtBash"): S = Atbash ;break;
						case("Cezar"): S = Cezar ;break;
					default:{break;}
		}
		
		}
	}
	
		
		
		
		
		}