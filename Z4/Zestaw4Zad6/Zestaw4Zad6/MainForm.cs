
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Linq;

namespace Zestaw4Zad6
{
	
	public partial class MainForm : Form
	{
		deszyfry d;
		public MainForm()
		{
			
			InitializeComponent();
			d = new deszyfry();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			d.Atbash("random.txt");
			textBox1.Text = d.Tekst_odszyfrowany;
		}
		void Button2Click(object sender, EventArgs e)
		{
		if(textBox2.Text !=""){	d.Klucz = textBox2.Text;}
			if (checkBox1.Checked == true) { d.Strona = true;}
			else if(checkBox1.Checked == false){d.Strona = false;}
			d.Cezar("random.txt");
			textBox1.Text = d.Tekst_odszyfrowany;
		}
	}
	
	public class deszyfry
	{
		public string Tekst_odszyfrowany;
		public string Klucz = "1";
		public bool Strona = true;
		public void Atbash(string Nazwapliku)
		{	
			string alfabet ="ABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
			string _alfabet = "abcdefghijklmnopqrstuvwxyz";
			string Ralfabet = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
			string _Ralfabet = "zyxwvutsrqponmlkjihgfedcba";
			string tekst_jawny = File.ReadAllText(Nazwapliku);
			Tekst_odszyfrowany = "";
				for (int i = 0; i < tekst_jawny.Length; i++) {
					for (int j = 0; j < alfabet.Length; j++) {
						if (tekst_jawny[i] == Ralfabet[j]) {
						Tekst_odszyfrowany = Tekst_odszyfrowany +  alfabet[j];
						}
					else if (tekst_jawny[i]==_Ralfabet[j]) {
						Tekst_odszyfrowany = Tekst_odszyfrowany + _alfabet[j];
					}
					
					}
				if (tekst_jawny[i]==' ') {Tekst_odszyfrowany = Tekst_odszyfrowany + " ";
					
				}
				}}
	
		public void Cezar(string Nazwapliku)
		{
			
			Tekst_odszyfrowany = " ";
			int przesuniecie = Convert.ToInt16(Klucz);
			string tekst_jawny = File.ReadAllText(Nazwapliku);
		 	string alfabet ="ABCDEFGHIJKLMNOPQRSTUVWXYZ" ;
			string _alfabet = "abcdefghijklmnopqrstuvwxyz";
			
			string palfabet = "";
			string _palfabet = "";
			if(Strona == false){
			przesuniecie %= alfabet.Length;
     palfabet =  alfabet.Substring(alfabet.Length - przesuniecie) + alfabet.Substring(0, alfabet.Length - przesuniecie);
	 _palfabet =  _alfabet.Substring(_alfabet.Length - przesuniecie) + _alfabet.Substring(0, _alfabet.Length - przesuniecie);	
			}
			else if (Strona == true) {
			
				palfabet = alfabet.Remove(0,przesuniecie) + alfabet.Substring(0,przesuniecie);
		 _palfabet = _alfabet.Remove(0,przesuniecie) + _alfabet.Substring(0,przesuniecie);
			}
			
			
			for (int i = 0; i < tekst_jawny.Length; i++) {
				for (int j = 0; j < alfabet.Length; j++) {
					if (tekst_jawny[i] == alfabet[j]) {
						Tekst_odszyfrowany = Tekst_odszyfrowany + palfabet[j];
					}
					else if (tekst_jawny[i] == _alfabet[j]) {
						Tekst_odszyfrowany = Tekst_odszyfrowany + _palfabet[j];
					}
					
				}
				if (tekst_jawny[i]==' ') {Tekst_odszyfrowany = Tekst_odszyfrowany + " ";
			}
		}	}

	
	}
}
