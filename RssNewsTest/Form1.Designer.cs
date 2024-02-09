namespace RssNewsTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnHurriyet = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.TxtSiteAdress = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnHurriyet
			// 
			this.BtnHurriyet.Location = new System.Drawing.Point(831, 13);
			this.BtnHurriyet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnHurriyet.Name = "BtnHurriyet";
			this.BtnHurriyet.Size = new System.Drawing.Size(323, 35);
			this.BtnHurriyet.TabIndex = 0;
			this.BtnHurriyet.Text = "Haber Başlıklarını Listele";
			this.BtnHurriyet.UseVisualStyleBackColor = true;
			this.BtnHurriyet.Click += new System.EventHandler(this.BtnHurriyet_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 25;
			this.listBox1.Location = new System.Drawing.Point(27, 73);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(1127, 554);
			this.listBox1.TabIndex = 6;
			// 
			// TxtSiteAdress
			// 
			this.TxtSiteAdress.Location = new System.Drawing.Point(27, 18);
			this.TxtSiteAdress.Name = "TxtSiteAdress";
			this.TxtSiteAdress.Size = new System.Drawing.Size(760, 30);
			this.TxtSiteAdress.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 703);
			this.Controls.Add(this.TxtSiteAdress);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.BtnHurriyet);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "News RSS";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnHurriyet;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox TxtSiteAdress;
	}
}

