using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;

namespace TSFront
{
	public partial class AddUserForm : Form
	{
		public User newUser;

		public AddUserForm()
		{
			InitializeComponent();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (passwordTextBox.Text.Equals(passwordTextBox2.Text))
			{
				newUser = new User()
				{
					EMail = emailTextBox.Text,
					IsAdmin = adminRadioButton.Checked,
					Name = nameTextbox.Text,
					PasswordHash = passwordTextBox.Text
				};
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				passwordTextBox.Text = String.Empty;
				passwordTextBox2.Text = String.Empty;
				MessageBox.Show(@"Passwords dont match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
