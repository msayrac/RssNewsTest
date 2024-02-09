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
			//listBox1.Items.Clear();

			//XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");

			//while (xmloku.Read())
			//{
			//	if (xmloku.Name == "title")
			//	{
			//		listBox1.Items.Add(xmloku.ReadString());
			//	}

			//}

		}

		private void BtnMilliyet_Click(object sender, EventArgs e)
		{
			siteGit();
			//listBox1.Items.Clear();

			//XmlTextReader xmloku = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/gundemrss.xml");

			//while (xmloku.Read())
			//{
			//	if (xmloku.Name == "title")
			//	{
			//		listBox1.Items.Add(xmloku.ReadString());
			//	}

			//}
		}

		private void BtnFotomac_Click(object sender, EventArgs e)
		{
			siteGit();
			//listBox1.Items.Clear();

			//XmlTextReader xmloku = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");

			//while (xmloku.Read())
			//{
			//	if (xmloku.Name == "title")
			//	{
			//		listBox1.Items.Add(xmloku.ReadString());
			//	}

			//}
		}

		
	}
}
