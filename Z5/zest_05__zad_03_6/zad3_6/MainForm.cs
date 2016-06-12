using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
namespace zad3_6
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Tylor T;
        string cos;
        string sin;
        string arcs;
        public MainForm()
        {

            InitializeComponent();
            T = new Tylor();

        }
        void MainFormLoad(object sender, EventArgs e)
        {

        }
        private void BworkerChange(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }
        private void Koniec(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Przerwano");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else MessageBox.Show("koniec!");
        }
        void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double wielomian = Convert.ToDouble(textBox3.Text);
            double skok = Convert.ToDouble(textBox4.Text);
            long licznik = 0;
            sin = ""; cos = ""; arcs = "";
            for (double i = x; i <= y; i = i + skok)
            {
                sin = T.SinT(i, wielomian).ToString();
                cos = T.CosT(i, wielomian).ToString();
                arcs = T.ArcSint(i, wielomian).ToString();
                licznik++;
                backgroundWorker1.ReportProgress(Convert.ToInt32(i));
                if (licznik % 200 == 0)
                {

                    listBox1.Invoke(new Action(delegate()
                    {
                        listBox1.Items.Add(sin);
                    }));


                    listBox2.Invoke(new Action(delegate()
                    {
                        listBox2.Items.Add(cos);
                    }));


                    listBox3.Invoke(new Action(delegate()
                    {
                        listBox3.Items.Add(arcs);
                    }));
                }


                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            e.Result = sin + cos + arcs;
        }
        void Button1Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        void Button2Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }

    public class Tylor
    {


        public double Silnia(double s)
        {
            double _silnia = 1;
            double bufor = 1;
            while (bufor <= s)
            {
                _silnia = _silnia * bufor;
                bufor++;
            } return _silnia;

        }
        public int indeks = 0;
        public double CosT(double C, double Wielomian_interpolacji)
        {
            double _cos = 0;
            double bufor = 0;
            indeks = 0;
            while (true)
            {
                _cos += (Math.Pow(-1, indeks) / Silnia(2 * indeks)) * Math.Pow(C, 2 * indeks);
                if (_cos == bufor)
                {
                    break;
                }
                else if (indeks >= Wielomian_interpolacji)
                {
                    break;
                }
                else
                {
                    bufor = _cos;
                    indeks++;
                }
            } return _cos;


        }
        public double SinT(double C, double Wielomian_interpolacji)
        {
            double _sin = 0;
            double bufor = 0;
            indeks = 0;
            while (true)
            {
                _sin += (Math.Pow(-1, indeks) / Silnia((2 * indeks + 1))) * Math.Pow(C, ((2 * indeks) + 1));

                if (_sin == bufor)
                {
                    break;
                }
                else if (indeks >= Wielomian_interpolacji)
                {
                    break;
                }
                else
                {
                    bufor = _sin;
                    indeks++;
                }
            } return _sin;


        }
        public double ArcSint(double C, double Wielomian_interpolacji)
        {
            double _sin = 0;
            double bufor = 0;
            indeks = 0;
            indeks = 0;
            while (true)
            {
                _sin += (Silnia(2 * indeks) * Math.Pow(C, (2 * indeks) + 1)) / (Math.Pow(4, indeks) * Math.Pow(Silnia(indeks), 2) * ((2 * indeks) + 1));
                if (_sin == bufor)
                {
                    break;
                }
                else if (indeks >= Wielomian_interpolacji)
                {
                    break;
                }
                else
                {
                    bufor = _sin;
                    indeks++;
                }
            } return _sin;


        }


    }
}

