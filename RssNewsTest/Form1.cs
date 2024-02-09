using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace RssNewsTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string siteAdresi;

		void siteGit()
		{				
				siteAdresi = TxtSiteAdress.Text;
				listBox1.Items.Clear();

				XmlTextReader xmloku = new XmlTextReader(siteAdresi);

				while (xmloku.Read())
				{
					if (xmloku.Name == "title")
					{
						listBox1.Items.Add(xmloku.ReadString());
					}
				}			
		}

		private void BtnHurriyet_Click(object sender, EventArgs e)
		{
			siteGit();
		}
	}
}
