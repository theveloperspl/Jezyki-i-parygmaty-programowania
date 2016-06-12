
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Zestaw3Zad1
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Figura f = new Figura();
        Okrag o = new Okrag();
        Troj t = new Troj();
        Prost p = new Prost();
        public MainForm()
        {

            InitializeComponent();


        }
        void Button1Click(object sender, EventArgs e)
        {

            Graphics H = CreateGraphics();
            f.Rysuj(H);
        }
        void Button2Click(object sender, EventArgs e)
        {
            Graphics K = CreateGraphics();
            o.Rysuj(K);
        }
        void Button3Click(object sender, EventArgs e)
        {
            Graphics T = CreateGraphics();
            t.Rysuj(T);
        }
        void Button4Click(object sender, EventArgs e)
        {
            Graphics P = CreateGraphics();
            p.Rysuj(P);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }


    public class Figura
    {

        protected double[] Parametry = new double[3];


        public void Rysuj(Graphics gr)
        {
            Parametry[0] = 150;
            Parametry[1] = 100;
            gr.DrawString("Nie potrafię rysować, gdyż jestem zbyt prosta.",
                           new Font("Arial", 16), Brushes.Red, (float)Parametry[0], (float)Parametry[1]);

        }
    }

    public class Okrag : Figura
    {

        public void Rysuj(Graphics gr)
        {
            Parametry[0] = 150;
            Parametry[1] = 50;
            gr.DrawEllipse(new Pen(Color.Blue), (float)Parametry[0], (float)Parametry[1], 60, 60);

        }
    }
    public class Troj : Figura
    {
        public void Rysuj(Graphics gr)
        {
            Parametry[0] = 200;
            Parametry[1] = 250;
            Parametry[2] = 150;
            PointF[] Tr = new PointF[3];
            Tr[0] = new PointF((float)Parametry[0], (float)Parametry[1]);
            Tr[1] = new PointF((float)Parametry[0], (float)Parametry[2]);
            Tr[2] = new PointF((float)Parametry[1], (float)Parametry[2]);
            gr.DrawPolygon(new Pen(Color.Pink), Tr);
        }

    }
    public class Prost : Figura
    {

        public void Rysuj(Graphics gr)
        {
            Parametry[0] = 250;
            Parametry[1] = 170;
            gr.DrawRectangle(new Pen(Color.Green), (float)Parametry[0], (float)Parametry[1], 60, 60);

        }

    }
}
