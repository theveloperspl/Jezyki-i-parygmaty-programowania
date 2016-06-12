
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zestaw1Zad4
{
	
	public partial class MainForm : Form
	{
		Tylor S;
		public MainForm()
		{
			
			InitializeComponent();
			S = new Tylor();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			
				
			double stopnie_na_radiany = Convert.ToDouble(textBox1.Text) * (Math.PI/180);
			double wielomian;
			if(textBox2.Text == "") {wielomian = 1000;}
			else{ wielomian = Convert.ToDouble(textBox2.Text);}			
			label1.Text =Convert.ToString(S.CosT(stopnie_na_radiany,wielomian));
			label3.Text = Convert.ToString(S.indeks);
			label5.Text = Convert.ToString(Math.Abs(S.Blad(Convert.ToInt16(label3.Text),stopnie_na_radiany)));
			
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
	}
	
	
	
	
	
	
	public class Tylor
	{
		public double Silnia (double s)
		{
			double _silnia = 1;
			double bufor = 1;
			while (bufor<=s)
			{
				_silnia = _silnia*bufor;
				bufor++;
			}return _silnia;
		
		}
		public int indeks = 0;
		public double CosT (double C,double Wielomian_interpolacji)
		{
			indeks = 0;
			double _cos = 0;
			double bufor = 0;

			while(true)
			{
				_cos += (Math.Pow(-1,indeks)/Silnia(2*indeks))*Math.Pow(C,2*indeks);
				if(_cos == bufor)
				{
					break;
				}
				else if (indeks>=Wielomian_interpolacji) {
					break;
				}
				else
				{
					bufor = _cos;
					indeks++;
				}
			}return _cos;
		
		
		}
		
		public double Blad(int wielomian,double x)
		{
			double wynik;
			wynik = (Math.Pow(-1,wielomian)/Silnia(2*wielomian)) * Math.Pow(x,2*wielomian);
			return wynik;
		}

		
		}		
	}

