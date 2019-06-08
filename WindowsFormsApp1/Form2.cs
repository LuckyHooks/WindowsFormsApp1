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


namespace WindowsFormsApp1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			LoadClass1();
		}



		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				propertyGrid1.SelectedObject = listBox1.SelectedItem;
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void LoadClass1()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("xmltext.xml");

			foreach (XmlNode node in doc.DocumentElement)
			{
				string view = node.Attributes[0].Value;
				int liter = int.Parse(node["Liter"].InnerText);
				int date = int.Parse(node["Date"].InnerText);
				listBox1.Items.Add(new Class1(view, liter, date));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form3 fr2 = new Form3();
			fr2.Show();
			Hide();
		}
	}
}
