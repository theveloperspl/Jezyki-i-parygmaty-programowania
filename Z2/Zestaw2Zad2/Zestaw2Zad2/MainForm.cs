
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zestaw2Zad2
{

    public partial class MainForm : Form
    {
        Mn g = new Mn();

        public MainForm()
        {

            InitializeComponent();
            Binding binding1 = new Binding("Text", g, "row1", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.DataBindings.Add(binding1);
            Binding binding2 = new Binding("Text", g, "row2", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add(binding2);
            Binding binding3 = new Binding("Text", g, "col1", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add(binding3);
            Binding binding4 = new Binding("Text", g, "col2", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox4.DataBindings.Add(binding4);
            g.T = Tabelka;

        }
        void Zmn(object sender, EventArgs e)
        {


        }

        private void Tabelka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
    public class Mn : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void zmiana(string Nazwa)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(Nazwa));

        }
        public DataGridView T;
        private int Row1;
        public int row1
        {
            get { return Row1; }
            set
            {
                if (Row1 != value)
                {
                    Row1 = value; zmiana("row1");
                    tworzenie_mn();
                }
            }
        }
        private int Row2;
        public int row2 { get { return Row2; } set { if (Row2 != value) { Row2 = value; zmiana("row2"); tworzenie_mn(); } } }
        private int Col1;
        public int col1 { get { return Col1; } set { if (Col1 != value) { Col1 = value; zmiana("col1"); tworzenie_mn(); } } }
        private int Col2;
        public int col2 { get { return Col2; } set { if (Col2 != value) { Col2 = value; zmiana("col2"); tworzenie_mn(); } } }
        public void tworzenie_mn()
        {

            T.RowCount = row2 - row1 + 1;
            T.ColumnCount = col2 - col1 + 1;
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    T.Rows[i - row1].Cells[j - col1].Value = i * j;
                }
            }

        }


    }

}









