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

namespace PB069ex1
{
	public partial class Form1 : Form
	{
		private List<Evaluation> evaluations;

		public Form1()
		{
			InitializeComponent();
			evaluations = new List<Evaluation>();
			toolStripStatusLabel1.Text = "0";
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddEvalForm dialog = new AddEvalForm();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				evaluations.Add(dialog.newEvaluation);
			}
			FillEvaluationsBox();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			evaluations.Clear();
			evaluationsListBox.Items.Clear();
			evaluationsListBox.Refresh();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						var values = line.Split(';');
						int.TryParse(values[1], out int grade);
						switch (values[0])
						{
							case "M":
								evaluations.Add(new Evaluation(Evaluation.Classes.M, grade, values[2]));
								break;
							case "AJ":
								evaluations.Add(new Evaluation(Evaluation.Classes.AJ, grade, values[2]));
								break;
							case "CJ":
								evaluations.Add(new Evaluation(Evaluation.Classes.CJ, grade, values[2]));
								break;
							case "Pr":
								evaluations.Add(new Evaluation(Evaluation.Classes.Pr, grade, values[2]));
								break;
						}
						
					}
				}

				FillEvaluationsBox();
			}
		}

		private void FillEvaluationsBox()
		{
			evaluationsListBox.Items.Clear();
			foreach (var evaluation in evaluations)
			{
				evaluationsListBox.Items.Add(evaluation);
			}
			evaluationsListBox.Refresh();
			toolStripStatusLabel1.Text = evaluations.Count().ToString();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
				{
					foreach (var evaluation in evaluations)
					{
						writer.WriteLine(evaluation.ToString());
					}
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (evaluationsListBox.SelectedIndex < 0) return;
			evaluations.Remove((Evaluation) evaluationsListBox.SelectedItem);
			FillEvaluationsBox();
		}
	}
}
