namespace zad11
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private zad11.myTextbox myTextbox1;
		private zad11.myCheckBox myCheckBox1;
		
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
            this.myTextbox1 = new zad11.myTextbox();
            this.myCheckBox1 = new zad11.myCheckBox();
            this.SuspendLayout();
            // 
            // myTextbox1
            // 
            this.myTextbox1.cenzura = new string[] {
        "hello",
        "there"};
            this.myTextbox1.Location = new System.Drawing.Point(122, 30);
            this.myTextbox1.Name = "myTextbox1";
            this.myTextbox1.Size = new System.Drawing.Size(100, 20);
            this.myTextbox1.TabIndex = 0;
            // 
            // myCheckBox1
            // 
            this.myCheckBox1.liczba_cykli = 3;
            this.myCheckBox1.Location = new System.Drawing.Point(12, 28);
            this.myCheckBox1.Name = "myCheckBox1";
            this.myCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.myCheckBox1.TabIndex = 1;
            this.myCheckBox1.Text = "myCheckBox1";
            this.myCheckBox1.UseVisualStyleBackColor = true;
            this.myCheckBox1.abc += new System.EventHandler(this.myCheckBox1_abc);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 80);
            this.Controls.Add(this.myCheckBox1);
            this.Controls.Add(this.myTextbox1);
            this.Name = "MainForm";
            this.Text = "zad11";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		}
	}

