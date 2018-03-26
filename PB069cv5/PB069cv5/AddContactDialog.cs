using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PB069cv5
{
	public partial class AddContactDialog : Form
	{
		public AddContactDialog()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (true)
			{
				((Form1) this.Owner).AddedContact = new Contact()
				{
					Name = nameTextBox1.Text,
					Surname = surnameTextBox2.Text,
					Phone = phoneTextBox.Text,
					Adress = new Adress()
					{
						Street = streetTextBox.Text,
						Country = countryTextBox.Text,
						HouseNumber = houseNumTextBox.Text,
						Postcode = postCodeTextBox.Text
					}
				};
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
