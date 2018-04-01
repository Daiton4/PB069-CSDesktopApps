using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSFront
{
	public partial class PasswordForm : Form
	{
		public string newPass;

		public PasswordForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Equals(textBox2.Text))
			{
				newPass = textBox1.Text;
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				textBox1.Text = string.Empty;
				textBox2.Text = string.Empty;
				MessageBox.Show(@"Passwords dont match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
