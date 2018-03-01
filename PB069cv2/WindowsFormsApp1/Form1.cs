using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private class Month
		{
			public string Name;
			public int Number;

			public Month(string Name, int Number)
			{
				this.Name = Name;
				this.Number = Number;
			}

			public override string ToString()
			{
				return Name;
			}
		}

		public Form1()
		{
			InitializeComponent();
			comboBox2.Items.Add(new Month("January", 1));
			comboBox2.Items.Add(new Month("February", 2));
			comboBox2.Items.Add(new Month("March", 3));
			comboBox2.Items.Add(new Month("April", 4));
			comboBox2.Items.Add(new Month("May", 5));
			comboBox2.Items.Add(new Month("June", 6));
			comboBox2.Items.Add(new Month("July", 7));
			comboBox2.Items.Add(new Month("August", 8));
			comboBox2.Items.Add(new Month("September", 9));
			comboBox2.Items.Add(new Month("October", 10));
			comboBox2.Items.Add(new Month("November", 11));
			comboBox2.Items.Add(new Month("December", 12));
			for (int i = 1; i < 32; i++)
			{
				comboBox1.Items.Add(i);
			}
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && textBox1.Text != "")
			{
				listBox1.Items.Add(new Absence(textBox1.Text, (int)comboBox1.SelectedItem, ((Month)comboBox2.SelectedItem).Number, checkBox1.Checked));
				listBox1.Update();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex != -1)
			{
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
				listBox1.Update();
			}
		}
	}
}
