using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using zad11;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace zad11
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void myCheckBox1_abc(object sender, EventArgs e)
        {
            MessageBox.Show("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
	
	}
	
	
	public class myCheckBox:CheckBox
	{
		public int cykl = 1;
		public int liczba_cykli{get;set;}
		public virtual void GetCykl(object sender, EventArgs e)
		{
			if (cykl ==liczba_cykli) {
                if (abc != null)
                {
                    abc(this, new EventArgs());


                }
				cykl = 1;
					
			}
			else cykl +=1;
		}
		public myCheckBox() : base()
		{
			
			liczba_cykli = 3;
			this.Click += GetCykl;
		}
        public event EventHandler abc;

	}
	
	public class myTextbox:TextBox
	{
		protected virtual void Usuwanie(object sender, EventArgs e)
		{
			if (this.Text == "") {
				MessageBox.Show("Textbox Czysty");
			}
		}
		protected virtual void Wklejanie(object sender, EventArgs e)
		{
			if (this.Text == Clipboard.GetText()) {
				MessageBox.Show("Skopiowano Pomyślnie");
			}
		}
		public string[] cenzura {get;set;}
		protected virtual void Ocenzurowano(object sender,EventArgs e)
		{
			foreach (string C  in cenzura) {
				if (this.Text.Contains(C)) {
					MessageBox.Show("Ocenzurowano");
				}
			}
		}
		public myTextbox():base()
		{
			Schowek s = new Schowek();
			cenzura = new string[]{"hello","there"};
			this.TextChanged += Ocenzurowano;		
			s.SChange += kopiowanie;
			this.TextChanged += Usuwanie;
			this.TextChanged += Wklejanie;
		}
	
		void kopiowanie(object sender, SChangeEventArgs e)
		{
			if( this.Text == Clipboard.GetText()){
			MessageBox.Show("Skopiowano zawartosc");
			}
			else{
				MessageBox.Show("Whoops");
			}
		}
	}
	public class Schowek:Control
	{
		public Schowek()
		{
			Snext = (IntPtr)SetClipboardViewer((int)this.Handle);
		}
		public virtual void Spokaz(bool stan)
		{
			ChangeClipboardChain(this.Handle,Snext);
		}
		IntPtr Snext;
		public event SChangeEventHandler SChange;
		[DllImport("User32.dll",CharSet = CharSet.Auto)]
		protected static extern int SetClipboardViewer(int hWndNewViewer);
		[DllImport("User32.dll",CharSet = CharSet.Auto)]
		protected static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
		[DllImport("User32.dll",CharSet = CharSet.Auto)]
		protected static extern int SendMessage(IntPtr hwnd,int wMsg,IntPtr wParam,IntPtr lParam);
		protected virtual void OnSChange(SChangeEventArgs e)
		{
			if (SChange != null) {
				SChange(this,e);
			}
		}
		protected override void WndProc(ref System.Windows.Forms.Message m)
		{
			const int DChange = 0x308;
			const int ScChange = 0x030D;
			switch (m.Msg) {
				case DChange:
					{
					onSchanged();
					SendMessage(Snext,m.Msg,m.WParam,m.LParam);
					break;
					}
				case ScChange:
					{
						if (m.WParam == Snext) {
							Snext = m.LParam;
						}
						else{
							SendMessage(Snext,m.Msg,m.WParam,m.LParam);
							
						}break;
						
					}
				default:
					base.WndProc(ref m);
					break;
			}
		}
		
		void onSchanged(){
			IDataObject iDane = Clipboard.GetDataObject();
			if (SChange!=null) {
				SChange(this,new SChangeEventArgs(iDane));
			}
		}
		
	}
	public class SChangeEventArgs:EventArgs
	{
		private IDataObject Dane;
		public	IDataObject dane 
		{get{
				return this.Dane;
			}
			}
		public SChangeEventArgs(IDataObject _Dane):base()
		{
			Dane = _Dane;
		}
			
	}
	public delegate void SChangeEventHandler(object sender, SChangeEventArgs e);
}












