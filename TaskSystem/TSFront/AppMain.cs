using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using TaskSystem;
using Task = DataLayer.Entities.Task;

namespace TSFront
{
	public partial class AppMain : Form
	{
		private ITaskSystem _system;
		private User originalUser = null;

		public AppMain(ITaskSystem system)
		{
			this._system = system;
			originalUser = system.ActualUser;
			InitializeComponent();
			fillListBox( _system.GetTaskList(),taskListBox);
			countTotalTime();
			if (!_system.ActualUser.IsAdmin)
			{
				administrationToolStripMenuItem.Enabled = false;
				menuStrip1.Refresh();
			}

			this.Text = "Task System - " + (originalUser?.Name ?? _system.ActualUser.Name);
		}

		private void fillListBox(IList items, ListBox box)
		{
			box.Items.Clear();
			foreach (var item in items)
			{
				box.Items.Add(item);
			}
			box.Refresh();
		}

		private void countTotalTime()
		{
			if (taskListBox.SelectedIndex < 0)
			{
				double sum = 0;
				foreach (var item in taskListBox.Items)
				{
					sum += ((DataLayer.Entities.Task)item).Time.TotalHours;
				}

				timeLabel.Text = "Total time :" + sum.ToString("##") + "h " + ((sum%1)*60).ToString("##.##") + "m ";
			}
		}

		private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var user = originalUser ?? _system.ActualUser;
			ChangeUserForm dialog = new ChangeUserForm(_system,user);
			if (dialog.ShowDialog() == DialogResult.OK && !dialog.selected.Equals(_system.ActualUser))
			{
				if (dialog.selected.Equals(this.originalUser))
				{
					userLabel.Hide();
				}
				else
				{
					userLabel.Text = @"Acting as User: " + dialog.selected.Name;
					userLabel.Show();
				}
				_system.ActualUser = dialog.selected;
				fillListBox(_system.GetTaskList(), taskListBox);
				prereqListBox.Items.Clear();
				prereqListBox.Refresh();
				countTotalTime();
			}
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			var th = new Thread(() => Application.Run(new Form1()));
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void taskListBox_SelectedValueChanged(object sender, EventArgs e)
		{
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddTaskForm dialog = new AddTaskForm("",TimeSpan.Zero);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_system.AddTask(dialog.newName, dialog.newTime);
				fillListBox(_system.GetTaskList(), taskListBox);
				countTotalTime();

			}
		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (taskListBox.SelectedIndex > -1)
			{
				var task = (Task) taskListBox.SelectedItem;
				_system.RemoveTask(task);
				fillListBox(_system.GetTaskList(), taskListBox);
				countTotalTime();
			}
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (taskListBox.SelectedIndex > -1)
			{
				var task = (Task)taskListBox.SelectedItem;
				AddTaskForm dialog = new AddTaskForm(task.Name,task.Time);
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					task.Name = dialog.newName;
					task.Time = dialog.newTime;
					_system.EditTask(task);
					fillListBox(_system.GetTaskList(), taskListBox);
					countTotalTime();
				}
			}
		}

		private void editPrereqButton_Click(object sender, EventArgs e)
		{
			if (taskListBox.SelectedIndex > -1)
			{
				var tasks = _system.GetTaskList();
				var selected = (Task) taskListBox.SelectedItem;
				tasks.Remove(selected);
				PrereqForm dialog = new PrereqForm(tasks,_system.GetPrerequisityList(selected));
				dialog.Text = "Edit Prerequisities for Task: " + selected.Name;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					foreach (var prer in dialog.prerequisitiesAdded)
					{
						_system.AddPrerequisity(selected, prer);
					}
					foreach (var prer in dialog.prerequisitiesRemoved)
					{
						_system.RemovePrerequisity(selected, prer);
					}
					taskListBox_SelectedIndexChanged(sender,e);
				}
			}
		}

		private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var dialog = new EditUserForm(_system, originalUser ?? _system.ActualUser);
			dialog.ShowDialog();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@".\SetUp\Help.html");
		}

		private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (taskListBox.SelectedIndex < 0) return;
			var prereq = _system.GetPrerequisityList((DataLayer.Entities.Task)taskListBox.SelectedItem);
			fillListBox(prereq, prereqListBox);
		}

		private void AppMain_SizeChanged(object sender, EventArgs e)
		{
			
		}
	}
}
