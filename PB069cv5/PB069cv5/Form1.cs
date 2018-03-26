using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PB069cv5
{
	public partial class Form1 : Form
	{
		private List<Contact> _contacts;
		public Contact AddedContact { get; set; }

		public Form1()
		{
			InitializeComponent();
			_contacts = new List<Contact>();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				LoadContacts(openFileDialog1.FileName);
			}
		}

		private void LoadContacts(string fileName)
		{
			using (StreamReader reader = new StreamReader(fileName))
			{
				_contacts = new List<Contact>();
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					_contacts.Add(Contact.FromString(line));
				}
			}

			RefreshView();
		}

		private void RefreshView()
		{
			listBox1.Items.Clear();
			foreach (var contact in _contacts)
			{
				listBox1.Items.Add(contact);
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			openToolStripMenuItem_Click(sender,e);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_contacts = new List<Contact>();
			RefreshView();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				SaveContacts(saveFileDialog1.FileName);
			}
		}

		private void SaveContacts(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				foreach (var contact in _contacts)
				{
					writer.WriteLine(contact.ToString());
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void contactToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_contacts.Remove((Contact) listBox1.SelectedItem);
			RefreshView();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddContactDialog dialog = new AddContactDialog();
			if (dialog.ShowDialog(this) == DialogResult.OK)
			{
				_contacts.Add(AddedContact);
				RefreshView();
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			newToolStripMenuItem_Click(sender,e);
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			saveToolStripMenuItem_Click(sender,e);
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			addToolStripMenuItem_Click(sender,e);
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			removeToolStripMenuItem_Click(sender,e);
		}
	}
}
