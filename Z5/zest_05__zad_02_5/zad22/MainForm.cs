using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace zad22
{

    public partial class MainForm : Form
    {
        SimpleM S;
        LAdvancedM L;
        public MainForm()
        {

            InitializeComponent();
            S = new SimpleM();
            L = new LAdvancedM();
            S.t = label1;
            S.u = label2;
            S.m = label3;
            Binding B1 = new Binding("Text", S, "x", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.DataBindings.Add(B1);
            Binding B2 = new Binding("Text", S, "y", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add(B2);
        }
        void MainFormLoad(object sender, EventArgs e)
        {

        }
        void Button1Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = L.silnia(Convert.ToInt32(textBox3.Text)).ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.TargetSite);
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.TargetSite);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.TargetSite);
            }
        }
    }

    public class SimpleM
    {
        public Label t;
        public Label u;
        public Label m;
        private int x;
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (x != value)
                {
                    x = value;
                } Mn(t, u); sq(m);
            }
        }
        private int y;
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (y != value)
                {
                    y = value;
                } Mn(t, u); sq(m);
            }
        }
        public void Mn(object z, object h)
        {
            try
            {
                (z as Label).Text = (x / y).ToString();
                (h as Label).Text = (x * y).ToString();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message + "\n" + e.Source);
            }
            catch (StackOverflowException e)
            {
                MessageBox.Show(e.Message + "\n" + e.Source);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.Source);
            }
        }
        public void sq(object g)
        {

            try
            {
                if (x < 0)
                {
                    throw new NieRzeczywistaException("");
                }
                else
                {
                    (g as Label).Text = Math.Sqrt(x).ToString();
                }
            }

            catch (Exception z)
            {
                MessageBox.Show(z.Message + "\n" + z.TargetSite);
            }
            finally
            {

                (g as Label).Text = ("+" + (g as Label).Text);
            }
        }
    }
    public class NieRzeczywistaException : System.Exception
    {
        public NieRzeczywistaException(string m)
            : base("liczba zespolona" + m)
        {

        }
    }
    public class LAdvancedM
    {
        public int silnia(int x)
        {
            try
            {
                if (x == 0)
                {
                    return 1;
                }
                if (x < 2)
                {
                    return x;
                }
                else return x * silnia(x - 1);
            }

            catch (StackOverflowException ex)
            {

                ex.Source = "silnia";
                throw ex;

            }
            catch (Exception ex)
            {
                ex.Source = "silnia";
                throw ex;


            }
        }

    }

}
