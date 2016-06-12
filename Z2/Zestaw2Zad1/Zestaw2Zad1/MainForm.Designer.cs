
namespace Zestaw2Zad1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.ListBox listBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox Dostepnosc;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dostepnosc = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(181, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 69);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(181, 150);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(115, 69);
            this.listBox2.TabIndex = 1;
            this.listBox2.Click += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(389, 259);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(115, 69);
            this.listBox3.TabIndex = 2;
            this.listBox3.Click += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(220, 259);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(115, 69);
            this.listBox4.TabIndex = 3;
            this.listBox4.Click += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(334, 150);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(115, 69);
            this.listBox5.TabIndex = 4;
            this.listBox5.Click += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(334, 49);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(115, 69);
            this.listBox6.TabIndex = 5;
            this.listBox6.Click += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Click += new System.EventHandler(this.TextBox3Click);
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // Dostepnosc
            // 
            this.Dostepnosc.Checked = true;
            this.Dostepnosc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Dostepnosc.Location = new System.Drawing.Point(15, 123);
            this.Dostepnosc.Name = "Dostepnosc";
            this.Dostepnosc.Size = new System.Drawing.Size(100, 57);
            this.Dostepnosc.TabIndex = 7;
            this.Dostepnosc.Text = "widzialnosc";
            this.Dostepnosc.UseVisualStyleBackColor = true;
            this.Dostepnosc.Click += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Click += new System.EventHandler(this.TextBox3Click);
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(11, 308);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(99, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(11, 200);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 19);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "dostepnosc";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "left";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "top";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "szerokosc";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "dlugosc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Dostepnosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Zestaw2Zad1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button button1;
	}
}
