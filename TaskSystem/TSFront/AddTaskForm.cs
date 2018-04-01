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
	public partial class AddTaskForm : Form
	{
		public string newName { get; set; }
		public TimeSpan newTime { get; set; }

		public AddTaskForm(string name, TimeSpan time)
		{
			InitializeComponent();
			nameTextBox.Text = name;
			nameTextBox.Refresh();
			timeNumericUpDown.Text = time.TotalHours.ToString("N0");
			timeNumericUpDown2.Text = (time.TotalMinutes - time.TotalHours * 60).ToString("N2");
			timeNumericUpDown.Refresh();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			newName = nameTextBox.Text;
			newTime = TimeSpan.FromMinutes((double) (timeNumericUpDown.Value * 60 + timeNumericUpDown2.Value));
			DialogResult = DialogResult.OK;
		}
	}
}
