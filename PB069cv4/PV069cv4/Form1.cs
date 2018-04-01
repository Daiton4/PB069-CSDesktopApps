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

namespace PV069cv4
{
	public partial class Form1 : Form
	{
		public List<GraphicalObject> Objects { get; set; }
		private DisplayDialog drawArea = null;

		public Form1()
		{
			InitializeComponent();
			Objects = new List<GraphicalObject>();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Objects = new List<GraphicalObject>();
			refreshGUI();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				saveData(saveFileDialog1.FileName);
			}
		}

		private void saveData(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				foreach (var GrObject in Objects)
				{
					writer.Write(GrObject.ToString());
				}
			}
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddObjectDialog dialog = new AddObjectDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Objects.Add(dialog.GrObject);
				refreshGUI();
			}
		}

		private void refreshGUI()
		{
			listBox1.Items.Clear();
			foreach (var GrObject in Objects)
			{
				listBox1.Items.Add(GrObject);
			}
			listBox1.Update();
		}

		private void showToolStripMenuItem_Click(object sender, EventArgs e)
		{
			drawArea = new DisplayDialog();
			drawArea.Show();
			foreach (GraphicalObject obj in Objects)
			{
				drawArea.DrawObject(obj);
			}
		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
