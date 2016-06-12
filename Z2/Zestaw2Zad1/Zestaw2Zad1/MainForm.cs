
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zestaw2Zad1
{

    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            Prop Teta = new Prop();


        }
        public ListBox T = new ListBox();
        void ListBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            T = (ListBox)sender;
        }
        void TextBox1TextChanged(object sender, EventArgs e)
        {
            Prop Dzeta = new Prop();

            Dzeta.Zmien(textBox1, textBox2, checkBox2, Dostepnosc, T, textBox4, textBox5);
        }
        void TextBox3Click(object sender, EventArgs e)
        {

        }
        void TextBox3TextChanged(object sender, EventArgs e)
        {

        }




        public class Prop
        {
            private int pole1;
            public int Pole1 { get { return pole1; } set { pole1 = value; } }
            public int A()
            {
                return pole1 * 10;
            }
            public int B(int n)
            {
                return pole1 * n;
            }

            public void C(ref int n)
            {
                n = pole1 * 10;


            }
            public void Zmien(TextBox ts, TextBox Raiza, CheckBox ths, CheckBox thy, ListBox gt, TextBox thss, TextBox Qli)
            {
                if (ts.Text != "")
                {
                    gt.Width = Convert.ToInt16(ts.Text);
                }
                if (Raiza.Text != "")
                {
                    gt.Size = new Size(gt.Width, Convert.ToInt16(Raiza.Text));
                }
                if (ths.Text != "")
                {
                    gt.Enabled = ths.Checked;

                }
                gt.Visible = thy.Checked;
                if (thss.Text != "")
                {
                    gt.Left = Convert.ToInt16(thss.Text);
                }
                if (Qli.Text != "")
                {
                    gt.Top = Convert.ToInt16(Qli.Text);

                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prop Teta = new Prop();
            Teta.Pole1 = 123;
            int a=0;
            Teta.C(ref a);
            MessageBox.Show(a.ToString());
            int b = Teta.B(a);
            MessageBox.Show(b.ToString());
            


        }
    }
}
