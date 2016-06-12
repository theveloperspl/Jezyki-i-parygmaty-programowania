
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zestaw1Zad5
{
	
	public partial class Form1 : Form
	{	
		public Form1()
		{
			
			InitializeComponent();
		
			textBox1.Text = "0";
			textBox2.Text = "250";
			textBox3.Text ="150";
			textBox4.Text = "50";
			textBox5.Text = "50";
			
		}
		public string jak = "Poziomo";
		public string co = "Textbox";
		public void Button1Click(object sender, EventArgs e)
		{
			Kontrolki Alfa = new Kontrolki();
			int liczba = Convert.ToInt16(textBox1.Text);
			switch(co){
				case("Textbox"):
					Alfa.TxtBoxy( Convert.ToInt16(textBox2.Text),Convert.ToInt16(textBox3.Text),Convert.ToInt16(textBox4.Text),Convert.ToInt16(textBox5.Text),liczba,jak);
			Alfa.Show();break;
		case("Przyciski"):
			Alfa.Przyciski(Convert.ToInt16(textBox2.Text),Convert.ToInt16(textBox3.Text),Convert.ToInt16(textBox4.Text),Convert.ToInt16(textBox5.Text),liczba,jak);
			Alfa.Show();
			break;
		case("Labely"):
			Alfa.Labely(Convert.ToInt16(textBox2.Text),Convert.ToInt16(textBox3.Text),Convert.ToInt16(textBox4.Text),Convert.ToInt16(textBox5.Text),liczba,jak);
			Alfa.Show();
			break;
			}
		
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			jak = "Poziomo";
			checkBox2.Checked = false;
			checkBox1.Checked = true;
			Kaskada.Checked = false;
		}
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			jak = "Pionowo";
			checkBox1.Checked = false;
			checkBox2.Checked = true;
			Kaskada.Checked = false;
		}
		void KaskadaCheckedChanged(object sender, EventArgs e)
		{
			jak = "Kaskada";
			checkBox1.Checked = false;
			checkBox2.Checked = false;
			Kaskada.Checked = true;
		}
		void TextboxyCheckedChanged(object sender, EventArgs e)
		{
			co = "Textbox";
			checkBox4.Checked = false;
			checkBox5.Checked = false;
			Textboxy.Checked = true;
		}
		void CheckBox4CheckedChanged(object sender, EventArgs e)
		{
			co = "Przyciski";
			Textboxy.Checked = false;
			checkBox4.Checked = true;
			checkBox5.Checked = false;
		}
		void CheckBox5CheckedChanged(object sender, EventArgs e)
		{
			co = "Labely";
			Textboxy.Checked = false;
			checkBox4.Checked = false;
			checkBox5.Checked = true;
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
		
	
	}
	
	class Kontrolki : Form1
	{
		
		public void TxtBoxy(int Lewo,int Top, int Szerokosc, int Dlugosc,int ilosc,string g)
		{	if(ilosc ==1 || ilosc ==0)
			{
			TextBox t = new TextBox();
			t.Left = Lewo;
			t.Top = Top;
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			this.Controls.Add(t);
			}
			else{
				switch(g)
				{case("Pionowo"):
						for (int i = 0; i <ilosc; i++) {
			TextBox t = new TextBox();
			t.Left = Lewo;
			t.Top = Top + i*(Szerokosc +10);
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			this.Controls.Add(t);
				
						}break;
					case("Poziomo"):
						for (int i = 0; i <ilosc; i++) {
			TextBox t = new TextBox();
			t.Left = Lewo +i *(Dlugosc +10);
			t.Top = Top ;
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			this.Controls.Add(t);
						}break;
					case("Kaskada"):
						for(int i = 0;i<=ilosc;i++){
							TxtBoxy(Lewo,Top+i*(Szerokosc +10),Szerokosc,Dlugosc,ilosc,"Poziomo");}
						TxtBoxy(Lewo,Top,Szerokosc,Dlugosc,ilosc,"Pionowo");
						break;
							
			
			}
		}
	
	
	
	}
			public void Przyciski(int Lewo,int Top, int Szerokosc, int Dlugosc,int ilosc,string g)
		{	if(ilosc ==1 || ilosc ==0)
			{
			Button t = new Button();
			t.Left = Lewo;
			t.Top = Top;
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			this.Controls.Add(t);
			}
			else{
				switch(g)
				{case("Pionowo"):
						for (int i = 0; i <ilosc; i++) {
			Button t = new Button();
			t.Left = Lewo;
			t.Top = Top + i*(Szerokosc +10);
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			this.Controls.Add(t);
				
						}break;
					case("Poziomo"):
						for (int i = 0; i <ilosc; i++) {
			Button t = new Button();
			t.Left = Lewo +i *(Dlugosc +10);
			t.Top = Top ;
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			this.Controls.Add(t);
						}break;
					case("Kaskada"):
						for(int i = 0;i<=ilosc;i++){
							Przyciski(Lewo,Top+i*(Szerokosc +10),Szerokosc,Dlugosc,ilosc,"Poziomo");}
						Przyciski(Lewo,Top,Szerokosc,Dlugosc,ilosc,"Pionowo");
						break;
							
			
			}
		}
	
	
	
	}
	public void Labely(int Lewo,int Top, int Szerokosc, int Dlugosc,int ilosc,string g)
		{	if(ilosc ==1 || ilosc ==0)
			{
			Label t = new Label();
			t.Left = Lewo;
			t.Top = Top;
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			t.BackColor = Color.PaleGreen;
			this.Controls.Add(t);
			}
			else{
				switch(g)
				{case("Pionowo"):
						for (int i = 0; i <ilosc; i++) {
			Label t = new Label();
			t.Left = Lewo;
			t.Top = Top + i*(Szerokosc +10);
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			t.BackColor = Color.PaleGreen;
			this.Controls.Add(t);
				
						}break;
					case("Poziomo"):
						for (int i = 0; i <ilosc; i++) {
			Label t = new Label();
			t.Left = Lewo +i *(Dlugosc +10);
			t.Top = Top ;
			t.Width = Szerokosc;
			t.Height = Dlugosc;
			t.Visible = true;
			t.BackColor = Color.PaleGreen;
			this.Controls.Add(t);
						}break;
					case("Kaskada"):
						for(int i = 0;i<=ilosc;i++){
							Labely(Lewo,Top+i*(Szerokosc +10),Szerokosc,Dlugosc,ilosc,"Poziomo");}
						Labely(Lewo,Top,Szerokosc,Dlugosc,ilosc,"Pionowo");
						break;
							
			
			}
		}
	
	
	
	}
	}}
