
using System;

using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zestaw2Zad3
{
    
    public partial class MainForm : Form
    {
        Tablice S = new Tablice();
        public MainForm()
        {

            InitializeComponent();
            Binding jeden = new Binding("Text", S, "Angle0", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.DataBindings.Add(jeden);
            Binding dwa = new Binding("Text", S, "Angle1", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add(dwa);
            Binding trzy = new Binding("Text", S, "DeltaA", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add(trzy);
        }
        void Button1Click(object sender, EventArgs e)
        {
            label1.Text = S.Ctablica;
            label2.Text = S.Stablica;
            label3.Text = S.Ttablica;
            label4.Text = S.cTtablica;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
    public class Tablice : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        void Zmiana(string Nazwa)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Nazwa));
            }
        }
        private double angle0;
        public double Angle0 { get { return angle0; } set { if (angle0 != value) { angle0 = value; funkcje(); Zmiana("Angle0"); funkcje(); } } }
        private double angle1;
        public double Angle1 { get { return angle1; } set { if (angle1 != value) { angle1 = value; funkcje(); Zmiana("Angle1"); funkcje(); } } }
        private double deltaA;
        public double DeltaA { get { return deltaA; } set { if (deltaA != value) { deltaA = value; funkcje(); Zmiana("DeltaA"); funkcje(); } } }
        public string Ctablica = "";
        public string Stablica = "";
        public string Ttablica = "";
        public string cTtablica = "";
        private double SnR(double x) { x = x * Math.PI / 180; return x; }

        private void funkcje()
        {
            if (deltaA != 0)
            {
                Ctablica = "";
                for (double i = SnR(angle0); i <= SnR(angle1); i += SnR(deltaA))
                {

                    Ctablica = Ctablica + Convert.ToString(i * 180 / Math.PI) + "  " + Math.Cos(i) + "\n";
                }

            }
            if (deltaA > 0)
            {
                Stablica = "";
                for (double i = SnR(angle0); i <= SnR(angle1); i += SnR(deltaA))
                {

                    Stablica = Stablica + Convert.ToString(i * 180 / Math.PI) + "  " + Math.Sin(i) + "\n";
                }

            }
            if (deltaA > 0)
            {
                Ttablica = "";
                for (double i = SnR(angle0); i <= SnR(angle1); i += SnR(deltaA))
                {

                    Ttablica = Ttablica + Convert.ToString(i * 180 / Math.PI) + "  " + Math.Tan(i) + "\n";
                }

            }
            if (deltaA > 0)
            {
                cTtablica = "";
                for (double i = SnR(angle0); i <= SnR(angle1); i += SnR(deltaA))
                {

                    cTtablica = cTtablica + Convert.ToString(i * 180 / Math.PI) + "  " + (1 / Math.Tan(i)) + "\n";
                }

            }
        }


    }


}







