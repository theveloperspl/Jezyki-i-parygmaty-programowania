using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Prime Jeden;
        public Form1()
        {
            InitializeComponent();
            Jeden = new Prime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jeden.wybór(true);
            Jeden.H("random.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jeden.wybór(false);
            Jeden.H("random.txt");
        }






        public class Prime
        {
            public delegate void doit(string x);
            public doit H;
            public void Linie(string FileName)
            {
                StringBuilder sb = new StringBuilder();
                string[] lines = File.ReadAllLines(FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    sb.Clear();
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        sb.Append(lines[i][j]);
                        sb.Append('_');
                    }
                    lines[i] = sb.ToString();
                }
                string FileName2 = FileName.Replace(".", "2.");
                File.WriteAllLines(FileName2, lines);
            }
            public void Kreski(string FileName)
            {
                StringBuilder sb = new StringBuilder();
                string[] lines = File.ReadAllLines(FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    sb.Clear();
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        sb.Append(lines[i][j]);
                        sb.Append("==");
                    }
                    lines[i] = sb.ToString();
                }
                string FileName2 = FileName.Replace(".", "_3.");
                File.WriteAllLines(FileName2, lines);
            }
            public void wybór(bool TRue)
            {
                if (TRue == true)H = Kreski ;
                if (TRue == false) H = Linie;
            
            
            }
        
        }

       
    }
}
