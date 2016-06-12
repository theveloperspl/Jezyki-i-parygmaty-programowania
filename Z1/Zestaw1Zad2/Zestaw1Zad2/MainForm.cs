
using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;

namespace Zestaw1Zad2
{

    public partial class MainForm : Form
    {
        Srednia y;
        public MainForm()
        {

            InitializeComponent();
            y = new Srednia();
            Random T = new Random();

            double[] liczby = new double[15];
            for (int i = 0; i < 15; i++)
            {
                double r = T.Next(1, 100) + T.NextDouble();
                liczby[i] = r;
                listBox1.Items.Add(Convert.ToString(liczby[i]));

            }




        }
        void Button1Click(object sender, EventArgs e)
        {

            int lcc = listBox1.Items.Count;
            string[] ccc = new string[lcc];
            double[] ddd = new double[lcc];
            for (int i = 0; i < lcc; i++)
            {

                ccc[i] = listBox1.Items[i].ToString();
                ddd[i] = Convert.ToDouble(ccc[i]);
            }

            double srednia = y.AVG(ddd);
            label1.Text = srednia.ToString();
            y.Odch(ddd, srednia, label2, lcc);
            y.minmax(ddd, label3, label4);
        }
        void Button2Click(object sender, EventArgs e)
        {
            Random T = new Random();
            double[] liczby = new double[15];
            for (int i = 0; i < 15; i++)
            {
                double r = T.Next(1, 100) + T.NextDouble();
                liczby[i] = r;
                listBox1.Items.Add(Convert.ToString(liczby[i]));
            }

        }

        void Label1Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}



public class Srednia
{
    public double AVG(double[] tabliczka_)
    {
        double suma = 0;
        for (int i = 0; i < tabliczka_.Length; i++)
        {
            suma += tabliczka_[i];
        }
        double srednia = suma / tabliczka_.Length;
        return srednia;
    }
    public void Odch(double[] liczby, double sr, Label KaliT, int LL)
    {
        double bufor = 0;
        double wynik = 0;
        for (int i = 0; i < LL; i++)
        {
            bufor += Math.Pow((liczby[i] - sr), 2);
            wynik = Math.Sqrt(bufor / 2);

        }
        KaliT.Text = Convert.ToString(wynik);
    }
    public void minmax(double[] than, Label Thhh, Label _Thhh)
    {
        double max = than[0];
        for (int i = 1; i < than.Length; i++)
        {
            if (max < than[i]) max = than[i];
        }
        double min = than[0];
        for (int i = 1; i < than.Length; i++)
        {
            if (min > than[i]) min = than[i];
        }
        Thhh.Text = Convert.ToString(max);
        _Thhh.Text = Convert.ToString(min);
    }
}


