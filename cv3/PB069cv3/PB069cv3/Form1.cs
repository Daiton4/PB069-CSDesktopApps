using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PB069cv3
{
	public partial class Form1 : Form
	{
		private List<GraphicElements> elements = new List<GraphicElements>();
		private GraphicElements current = null;
		private bool draw = false;

		public Form1()
		{
			InitializeComponent();
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(Graphics g = Graphics.FromImage(pictureBox1.Image))
			{
				g.Clear(pictureBox1.BackColor);
			}
			elements = new List<GraphicElements>();
			Refresh();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Image.Save("./picture.bmp");
		}

		private void endToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			toolStripStatusLabel2.Text = e.X.ToString();
			toolStripStatusLabel4.Text = e.Y.ToString();
			if (draw)
			{
				clearCurrent();
				current.DX = e.X - current.X;
				current.DY = e.Y - current.Y;
				DrawCurrent();

			}
		}

		private void DrawCurrent()
		{
			using (Graphics g = Graphics.FromImage(pictureBox1.Image))
			{
				Pen pen = Pens.Black;
				switch (current.type)
				{
					case ElementType.ELIPSE:
						drawEllipse(g, current, pen);
						break;
					case ElementType.LINE:
						drawLine(g, current, pen);
						break;
					case ElementType.RECTANGLE:
						drawRectangle(g, current, pen);
						break;
				}
			}
			Refresh();
		}

		private void clearCurrent()
		{
			using (Graphics g = Graphics.FromImage(pictureBox1.Image))
			{
				Pen pen = new Pen(pictureBox1.BackColor);
				switch (current.type)
				{
					case ElementType.ELIPSE:
						drawEllipse(g, current, pen);
						break;
					case ElementType.LINE:
						drawLine(g, current, pen);
						break;
					case ElementType.RECTANGLE:
						drawRectangle(g, current, pen);
						break;
				}
			}
			Refresh();
		}

		private void drawRectangle(Graphics g, GraphicElements current, Pen pen)
		{
			int x = current.X, y = current.Y, dx = current.DX, dy = current.DY;
			if (dx < 0)
			{
				x = x + dx;
				dx = -dx;
			}
			if (dy < 0)
			{
				y = y + dy;
				dy = -dy;
			}
			g.DrawRectangle(pen, x, y, dx, dy);
		}

		private void drawLine(Graphics g, GraphicElements current, Pen pen)
		{
			g.DrawLine(pen, current.X, current.Y, current.X + current.DX, current.Y + current.DY);
		}

		private void drawEllipse(Graphics g, GraphicElements current, Pen pen)
		{
			int x = current.X, y = current.Y, dx = current.DX, dy = current.DY;
			if (current.DX < 0)
			{
				x = current.X + current.DX;
				dx = -current.DX;
			}
			if (current.DY < 0)
			{
				y = current.Y + current.DY;
				dy = -current.DY;
			}
			g.DrawEllipse(pen, x, y, dx, dy);
		}

		private void lineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearChecked();
			lineToolStripMenuItem.Checked = true;
			CreateCurrent(ElementType.LINE);
		}

		private void CreateCurrent(ElementType type)
		{
			current = new GraphicElements {type = type};
		}

		private void ClearChecked()
		{
			lineToolStripMenuItem.Checked = false;
			rectangleToolStripMenuItem.Checked = false;
			circleToolStripMenuItem.Checked = false;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (current == null) return;
			draw = true;
			current.X = e.X;
			current.Y = e.Y;
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (current == null) return;
			elements.Add(current);
			refreshElements();
			draw = false;
			pictureBox1.Refresh();
			CreateCurrent(current.type);
		}

		private void refreshElements()
		{
			using (Graphics g = Graphics.FromImage(pictureBox1.Image))
			{
				g.Clear(pictureBox1.BackColor);
				foreach (GraphicElements element in elements)
				{
					Pen pen = Pens.Black;
					switch (element.type)
					{
						case ElementType.ELIPSE:
							drawEllipse(g, element, pen);
							break;
						case ElementType.LINE:
							drawLine(g, element, pen);
							break;
						case ElementType.RECTANGLE:
							drawRectangle(g, element, pen);
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}
				}
			}
		}

		private void circleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearChecked();
			circleToolStripMenuItem.Checked = true;
			CreateCurrent(ElementType.ELIPSE);
		}

		private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearChecked();
			rectangleToolStripMenuItem.Checked = true;
			CreateCurrent(ElementType.RECTANGLE);
		}
	}
}
