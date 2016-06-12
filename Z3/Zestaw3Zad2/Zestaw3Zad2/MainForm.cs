
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
namespace Zestaw3Zad2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Wykonawca W;
		Wykonawca R ;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			W = new Wykonawca();
			R = new Rec();

		}
		void Button1Click(object sender, EventArgs e)
		{
			W.PracaA("text.txt");
		
		}
		void Button2Click(object sender, EventArgs e)
		{	
	
		R.PracaA("text.txt");
		}
		void Button3Click(object sender, EventArgs e)
		{
			W.PracaB("text.txt");
		
		}
		void Button4Click(object sender, EventArgs e)
		{
			R.PracaB("Text.txt");
			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
	}
	
	
	
	
	
	public class Wykonawca
{		
    public void PracaA(string FileName) 
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
	
    public virtual void PracaB(string FileName)
    {
      StringBuilder sb = new StringBuilder();
      string[] lines = File.ReadAllLines(FileName);
      foreach (string s in lines)
      {
          sb.AppendLine(s);
          sb.AppendLine("---------------------------------------------");
      }
      string FileName2 = FileName.Replace(".", "2.");
      File.WriteAllText(FileName2, sb.ToString());
    }
}
	
	public class Rec:Wykonawca
	{
	
	 new public void PracaA(string FileName) 
    {
      StringBuilder sb = new StringBuilder();
      string[] lines = File.ReadAllLines(FileName);
      for (int i = 0; i < lines.Length; i++)
      {
        sb.Clear();
        for (int j = 0; j < lines[i].Length; j++)
        {
          sb.Append(lines[i][j]);
          sb.Append('+');
        }
        lines[i] = sb.ToString();
      }
      string FileName2 = FileName.Replace(".", "2.");
      File.WriteAllLines(FileName2, lines);
    }
	
	public override void PracaB(string FileName)
    {
      StringBuilder sb = new StringBuilder();
      string[] lines = File.ReadAllLines(FileName);
      foreach (string s in lines)
      {
          sb.AppendLine(s);
          sb.AppendLine("++++++++++++++++++++++++++++++++++++++++++");
      }
      string FileName2 = FileName.Replace(".", "2.");
      File.WriteAllText(FileName2, sb.ToString());
    }
	}
}
