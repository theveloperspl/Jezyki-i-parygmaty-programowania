
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zestaw4Zad2
{
	
	public partial class MainForm : Form
	{
		IRestauracje wloska;
		IRestauracje chinska;
		public MainForm()
		{
			
			InitializeComponent();
			wloska = new Wloska();
			chinska = new Chinska();
			show();
			
		}
		
		public void show()
		{
			label1.Text = wloska.nazwa();
			label2.Text = wloska.przychody().ToString();
			label3.Text = chinska.nazwa();
			label4.Text = chinska.przychody().ToString();
		}
		
		
		
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			wloska = new Prestiz(wloska);
			show();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			wloska = new Nowa(wloska);
			show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			chinska = new Prestiz(chinska);
			show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			chinska = new Nowa(chinska);
			show();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
	}
	
	
	
	
	
	
	
	public interface IRestauracje
	{
		string nazwa();
		double przychody();
	}
	
	public class Wloska:IRestauracje
	{
		public  string nazwa(){return "Wloska";}
		public  double przychody(){return 50000;}
	}
	public class Chinska:IRestauracje
	{
		public  string nazwa(){return "Chinska";}
		public  double przychody(){return 100000;}
	}
	
	public abstract class Dekorator:IRestauracje
	{
		
		public abstract string nazwa();
		public abstract double przychody();
		public IRestauracje Restauracje;
		public Dekorator(IRestauracje _Restauracje)
		{
			Restauracje = _Restauracje;
		}
		
		
	}
	
	public class Prestiz:Dekorator
	{
		public Prestiz(IRestauracje _Restauracje):base(_Restauracje){}
		public override string nazwa(){return "Prestiżowa " + Restauracje.nazwa() ;}
		public override double przychody()
		{
			return Restauracje.przychody() + 5000;
		}
	}
	
		public class Nowa:Dekorator
	{
			public Nowa(IRestauracje _Restauracje):base(_Restauracje){}
		public override string nazwa(){return "Nowa " + Restauracje.nazwa();}
		public override double przychody()
		{
			return Restauracje.przychody() - 3000;
		}
	}
}
