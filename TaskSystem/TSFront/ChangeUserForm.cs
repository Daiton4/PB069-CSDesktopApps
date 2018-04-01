using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSystem;

namespace TSFront
{
	public partial class ChangeUserForm : Form
	{
		public ITaskSystem TSystem;
		public User selected { get; set; }
		private readonly User _admin;

		public ChangeUserForm(ITaskSystem tsystem,User Admin)
		{
			InitializeComponent();
			TSystem = tsystem;
			_admin = Admin;
			foreach (var user in TSystem.GetUsersByName(_admin,""))
			{
				usersListBox.Items.Add(user);
			}

		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			List<User> list;
			list = nameRadioButton.Checked ? TSystem.GetUsersByName(_admin, searchTextBox.Text) : TSystem.GetUsersByEMail(_admin, searchTextBox.Text);
			usersListBox.Items.Clear();
			foreach (var user in list)
			{
				usersListBox.Items.Add(user);
			}
			usersListBox.Refresh();
		}

		private void selectButton_Click(object sender, EventArgs e)
		{
			if (usersListBox.SelectedIndex > -1)
			{
				selected = (User) usersListBox.SelectedItem;
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}

			
		}
	}
}
