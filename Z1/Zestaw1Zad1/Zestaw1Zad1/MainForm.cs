
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Zestaw1Zad1
{

    public partial class MainForm : Form
    {
        Liczenie t;
        public MainForm()
        {

            InitializeComponent();
            t = new Liczenie();

        }
        void TextBox1TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
             int d=   t.BinD2(textBox1.Text);
             label1.Text = d.ToString();
            }
        }
        void TextBox2TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string s0 = textBox2.Text;
                int d = int.Parse(s0);
               string a = t.DziesSzes(d);
               label2.Text = a;
            }
        }
        void TextBox3TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {

                t.SzesDzies(label3, textBox3.Text, 0);
            }
        }
        void Label2Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }



    // binarny na dziesietny 
    public class Liczenie
    {
        public void BinD(string liczba_binarna, Label Wynik, int bufor)
        {
            bufor = 0;
            for (int i = 0; i < liczba_binarna.Length; i++)
            {
                if (liczba_binarna[liczba_binarna.Length - i - 1] == '0') continue;
                bufor += (int)Math.Pow(2, i);

            }
            Wynik.Text = Convert.ToString(bufor);
        }
        public int BinD2(string liczba_binarna)
        {
            int bufor = 0;
            for (int i = 0; i < liczba_binarna.Length; i++)
            {
                if (liczba_binarna[liczba_binarna.Length - i - 1] == '0') continue;
                bufor += (int)Math.Pow(2, i);
            }
            return bufor;
        }

        //dziesietny na szesnastkowy
        public string DziesSzes(int liczba_dziesietna)
        {
            string bufor = "";
            string[] wartosci_hexadecymalne = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };

            int liczba = Convert.ToInt16(liczba_dziesietna);
            int reszta = 0;
            while (liczba != 0)
            {
                reszta = liczba % 16;
                if (reszta <= 9)
                {

                    bufor = Convert.ToString(reszta) + bufor;
                    liczba = liczba / 16;
                }
                else
                {
                    bufor = wartosci_hexadecymalne[reszta] + bufor;

                    liczba = liczba / 16;
                }
            }
            return bufor;
        }
        //szesnastkowy na dziesietny
        public void SzesDzies(Label wynik, string wartosc_hex, int bufor)
        {
            for (int i = 0; i < wartosc_hex.Length; i++)
            {
                int Lilith = 0;
                switch (wartosc_hex[wartosc_hex.Length - i - 1].ToString().ToLower())
                {
                    case ("0"): Lilith = 0; break;
                    case ("1"): Lilith = 1; break;
                    case ("2"): Lilith = 2; break;
                    case ("3"): Lilith = 3; break;
                    case ("4"): Lilith = 4; break;
                    case ("5"): Lilith = 5; break;
                    case ("6"): Lilith = 6; break;
                    case ("7"): Lilith = 7; break;
                    case ("8"): Lilith = 8; break;
                    case ("9"): Lilith = 9; break;
                    case ("a"): Lilith = 10; break;
                    case ("b"): Lilith = 11; break;
                    case ("c"): Lilith = 12; break;
                    case ("d"): Lilith = 13; break;
                    case ("e"): Lilith = 14; break;
                    case ("f"): Lilith = 15; break;
                }
                bufor += Lilith * (int)Math.Pow(16, i);
            }
            wynik.Text = Convert.ToString(bufor);
        }
    }
}
