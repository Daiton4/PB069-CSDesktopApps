using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV069cv4
{
	public partial class AddObjectDialog : Form
	{
		public GraphicalObject GrObject = new GraphicalObject() {Type = Types.Circle};

		public AddObjectDialog()
		{
			InitializeComponent();
			foreach (var type in Enum.GetValues(typeof(Types)))
			{
				comboBox1.Items.Add(type);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((Types) comboBox1.SelectedItem)
			{
				case Types.Circle:
					Xlabel.Show();
					Ylabel.Show();
					DXlabel.Show();
					DXlabel.Text = "Radius";
					DYlabel.Hide();
					DYnumericUpDown4.Hide();
					break;
				case Types.Line:
					Xlabel.Show();
					Ylabel.Show();
					DXlabel.Show();
					DXlabel.Text = "DX";
					DYlabel.Show();
					DYnumericUpDown4.Show();
					break;
				case Types.Rectangle:
					Xlabel.Show();
					Ylabel.Show();
					DXlabel.Show();
					DXlabel.Text = "DX";
					DYlabel.Show();
					DYnumericUpDown4.Show();
					break;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GrObject.Type = (Types) comboBox1.SelectedItem;
			GrObject.X = (int) XnumericUpDown1.Value;
			GrObject.Y = (int) YnumericUpDown2.Value; 
			GrObject.DX = (int) DXnumericUpDown3.Value;
			GrObject.DY = (int) DYnumericUpDown4.Value;
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
