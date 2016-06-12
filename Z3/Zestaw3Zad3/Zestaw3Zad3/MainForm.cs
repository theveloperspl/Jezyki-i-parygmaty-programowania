
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zestaw3Zad3
{
    public partial class MainForm : Form
    {
        Firma_Pierwsza F1 = new Firma_Pierwsza();
        Firma_Druga F2 = new Firma_Druga();
        Faktura F = new Faktura();

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            Firma_Druga Jean = new Firma_Druga { Kod = "921-21", Nazwa = "Jean inc.", Stawka = 0.25, Zysk = 20000, Kara = false };
            F._Faktura(Jean);
            label1.Text = F.Dokument;
        }
        void Button1Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (checkBox2.Checked == true)
                {
                    Firma_Druga Nowa = new Firma_Druga
                    {
                        Kod = textBox1.Text,
                        Nazwa = textBox2.Text,
                        Stawka = Convert.ToDouble(textBox3.Text),
                        Zysk = Convert.ToDouble(textBox4.Text),
                        Kara = checkBox1.Checked
                    }; F._Faktura(Nowa); label1.Text = F.Dokument;

                }
                else
                {
                    Firma_Pierwsza Nowa = new Firma_Pierwsza
                    {
                        Kod = textBox1.Text,
                        Nazwa = textBox2.Text,
                        Stawka = Convert.ToDouble(textBox3.Text),
                        Zysk = Convert.ToDouble(textBox4.Text),
                        Kara = checkBox1.Checked
                    }; F._Faktura(Nowa); label1.Text = F.Dokument;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }


    public interface IPodatek
    {
        string Kod { get; set; }
        string Nazwa { get; set; }
        double Stawka { get; set; }
        double Zysk { get; set; }
        double Oblicz(double Kwota);
        bool Kara { get; set; }
    }

    public class Firma_Pierwsza : IPodatek
    {
        public bool Kara { get; set; }
        public double Zysk { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public double Stawka { get; set; }
        public double Oblicz(double Kwota) { Kwota = Zysk * Stawka; return Kwota; }
        //public Firma_Pierwsza Jeryho = new Firma_Pierwsza{Zysk = 2000,Kod = "973-424", Nazwa = "JerY inc.",Stawka = 0.15 };
    }

    public class Firma_Druga : IPodatek
    {
        public bool Kara { get; set; }
        public double Zysk { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public double Stawka { get; set; }
        public double Oblicz(double Kwota) { Kwota = Zysk * (2 * Stawka) - 5000; return Kwota; }

    }

    public class Faktura
    {
        public string Dokument = "";
        public void _Faktura(IPodatek x)
        {
            if (x.Kara == false)
            {
                Dokument = "Nazwa Firmy  " + x.Nazwa + "    " + "Kod  " + x.Kod + "\n\n\n" +
                    "Podatek  " + (x.Stawka * 100) + "%" + "    " + "Zyski  " + x.Zysk +
                    "\n\n" + "Kwota Podatku  " + x.Oblicz(x.Zysk)
                    + "\n\n" + x.Oblicz(x.Zysk);
            }
            else if (x.Kara == true)
            {
                Dokument = "Nazwa Firmy  " + x.Nazwa + "    " + "Kod  " + x.Kod + "\n\n\n" +
                        "Podatek  " + (x.Stawka * 100) + "%" + "    " + "Zyski  " + x.Zysk +
                    "\n\n" + "Kwota Podatku  " + x.Oblicz(x.Zysk) + "\n\n\n" + "Kara  " + (x.Zysk * 0.4) +
                    "\n\n" + " Do zapłaty  " + (x.Oblicz(x.Zysk) + x.Zysk * 0.4);

            }
        }

    }

}
