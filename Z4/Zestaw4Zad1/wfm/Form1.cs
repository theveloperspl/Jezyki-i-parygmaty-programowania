using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfm
{
    
    public partial class Form1 : Form
    {
        Firma MCD;
        Firma Gettlen;
        public Form1()
        {
            InitializeComponent();
            MCD = new Restauracja();
            Gettlen = new Zoo();
        }
        private void show()
        {
            label1.Text = MCD.nazwa() + "\n" + MCD.obroty();
            label2.Text = Gettlen.nazwa() + "\n" + Gettlen.obroty();
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MCD = new DobraLokacja(MCD);
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MCD = new Basen(MCD);
            show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gettlen = new DobraLokacja(Gettlen);
            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gettlen = new Basen(Gettlen);
            show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



    public abstract class Firma
    {
        public virtual string nazwa() { return "Null"; }
        public virtual double obroty() { return 0; }    
    
    }

    public class Restauracja:Firma
    {
        public override string nazwa()
        {
            return "Restauracja";
        }
        public override double obroty()
        {
            return 10000;
        }

    }
    public class Zoo : Firma
    {
        public override string nazwa()
        {
            return "Zoo";
        }
        public override double obroty()
        {
            return 400000;
        }

    }

    public abstract class Dekorator : Firma
    {

        public Firma TwojaFirma;
    
    }

    public class DobraLokacja : Dekorator
    {
         public DobraLokacja(Firma aFirma)
    {
     TwojaFirma = aFirma;
    }



        public override string nazwa()
        {
            return TwojaFirma.nazwa() + " Z dobrą lokacją";
        }
        public override double obroty()
        {
            return TwojaFirma.obroty() + 50000;
        }
    }
    public class Basen : Dekorator
    {
              public Basen(Firma aFirma)
    {
     TwojaFirma = aFirma;
    }

        public override string nazwa()
        {
            return TwojaFirma.nazwa() + " Z basenem";
        }
        public override double obroty()
        {
            return TwojaFirma.obroty() + 60000;
        }
    }



}
