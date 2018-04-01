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
using TaskSystem;

namespace TSFront
{
	public partial class EditUserForm : Form
	{
		private ITaskSystem TSystem { get; set; }
		private User Admin { get; set; }
		private User _selectedUser;

		public EditUserForm(ITaskSystem newSys, User newAdmin)
		{
			InitializeComponent();
			Admin = newAdmin;
			TSystem = newSys;
			_selectedUser = null;
			foreach (var user in TSystem.GetUsersByName(TSystem.ActualUser, ""))
			{
				usersListBox.Items.Add(user);
			}
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			var list = nameRadioButton.Checked ? TSystem.GetUsersByName(Admin, searchTextBox.Text) : TSystem.GetUsersByEMail(Admin, searchTextBox.Text);
			usersListBox.Items.Clear();
			foreach (var user in list)
			{
				usersListBox.Items.Add(user);
			}
			usersListBox.Refresh();
		}

		private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (usersListBox.SelectedIndex > -1)
			{
				_selectedUser = (User) usersListBox.SelectedItem;
				nameTextBox.Text = _selectedUser.Name;
				emailTextBox.Text = _selectedUser.EMail;
				adminRadioButton.Checked = _selectedUser.IsAdmin;
				notAdminRadioButton.Checked = !_selectedUser.IsAdmin;
			}
			else
			{
				_selectedUser = null;
				nameTextBox.Text = String.Empty;
				emailTextBox.Text = String.Empty;
			}
		}

		private void passwordButton_Click(object sender, EventArgs e)
		{
			if(_selectedUser == null) return;
			var dialog = new PasswordForm();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				TSystem.PasswordChange(Admin,_selectedUser, dialog.newPass);
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (_selectedUser == null) return;
			_selectedUser.Name = nameTextBox.Text;
			_selectedUser.EMail = emailTextBox.Text;
			_selectedUser.IsAdmin = adminRadioButton.Checked;
			TSystem.EditUser(Admin,_selectedUser);
			searchButton_Click(sender,e);
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (_selectedUser == null) return;
			if (MessageBox.Show("Do you really want to delete User: \n" + _selectedUser.Name, "Delete User",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
			TSystem.RemoveUser(Admin,_selectedUser);
			searchButton_Click(sender, e);

		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void addUserButton_Click(object sender, EventArgs e)
		{
			var dialog = new AddUserForm();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				TSystem.AddUser(Admin, dialog.newUser);
				searchButton_Click(sender,e);
			}
		}
	}
}
