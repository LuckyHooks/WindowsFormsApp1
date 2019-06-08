using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();

		}

		private void Form3_Load(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Заполните все поля.", "Ошибка.");
			}
			else
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
				dataGridView1.Rows[n].Cells[1].Value = numericUpDown1.Value;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
			}
			else
			{
				MessageBox.Show("Выберите строку для удаления.", "Ошибка.");
			}
		}

		private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			int n = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
			numericUpDown1.Value = n;


		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int n = dataGridView1.SelectedRows[0].Index;
				dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
				dataGridView1.Rows[n].Cells[1].Value = numericUpDown1.Value;
			}
			else
			{
				MessageBox.Show("Выберите строку для редактирования.", "Ошибка.");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form4 fr2 = new Form4();
			fr2.Show();
			Hide();

		}
	}
}
