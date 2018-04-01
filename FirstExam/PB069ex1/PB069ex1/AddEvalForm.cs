using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PB069ex1
{
	public partial class AddEvalForm : Form
	{
		public Evaluation newEvaluation { get; set; }

		public AddEvalForm()
		{
			InitializeComponent();
			classComboBox.Items.Add(Evaluation.Classes.M);
			classComboBox.Items.Add(Evaluation.Classes.AJ);
			classComboBox.Items.Add(Evaluation.Classes.CJ);
			classComboBox.Items.Add(Evaluation.Classes.Pr);
			classComboBox.SelectedIndex = 0;
			for (int i = 1; i < 6; i++)
			{
				gradeComboBox.Items.Add(i);
			}
			gradeComboBox.SelectedIndex = 0;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (nameTextBox.Text == "")
			{
				MessageBox.Show("Invalid Name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			newEvaluation = new Evaluation((Evaluation.Classes) classComboBox.SelectedItem, (int) gradeComboBox.SelectedItem, nameTextBox.Text);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
