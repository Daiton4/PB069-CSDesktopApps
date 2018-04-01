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
	public partial class DisplayDialog : Form
	{
		public DisplayDialog()
		{
			InitializeComponent();
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
		}

		public void DrawObject(GraphicalObject obj)
		{
			using (Graphics g = Graphics.FromImage(pictureBox1.Image))
			{
				switch (obj.Type)
				{
					case Types.Line:
						g.DrawLine(Pens.Black, obj.X, obj.Y, obj.X + obj.DX, obj.Y + obj.DY);
						break;
					case Types.Circle:
						g.DrawArc(Pens.Black, obj.X - obj.DX, obj.Y - obj.DX, obj.X + obj.DX, obj.Y + obj.DX, 0, 359);
						break;
					case Types.Rectangle:
						g.DrawRectangle(Pens.Black, obj.X, obj.Y, obj.DX, obj.DY);
						break;
				}
				Refresh();
			}
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
