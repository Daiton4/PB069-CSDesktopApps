using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer.Entities;

namespace TSFront
{
	public partial class PrereqForm : Form
	{
		private List<Task> tasks { get; set; }
		public List<Task> prerequisitiesAdded { get; set; } = new List<Task>();
		public List<Task> prerequisitiesRemoved { get; set; } = new List<Task>();

		public PrereqForm(List<Task> tasks, List<Task> prerequisities)
		{
			InitializeComponent();
			this.tasks = tasks;
			foreach (var task in tasks)
			{
				tasksListBox.Items.Add(task);
			}
			
			foreach (var task in prerequisities)
			{
				prereqListBox.Items.Add(task);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void addPrereqButton_Click(object sender, EventArgs e)
		{
			if (tasksListBox.SelectedIndex < 0) return;
			var selected = (Task) tasksListBox.SelectedItem;
			if (prereqListBox.Items.Contains(selected)) return;
			prereqListBox.Items.Add(selected);
			prerequisitiesAdded.Add(selected);
			prereqListBox.Refresh();
		}

		private void removePrereqButton_Click(object sender, EventArgs e)
		{
			if (prereqListBox.SelectedIndex < 0) return;
			var selected = (Task)prereqListBox.SelectedItem;
			if (prerequisitiesAdded.Contains(selected)) {prerequisitiesAdded.Remove(selected);}
			else
			{
				prerequisitiesRemoved.Add(selected);
			}
			prereqListBox.Items.Remove(selected);
			prereqListBox.Refresh();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
