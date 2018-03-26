using System;

namespace PV069cv4
{
	public enum Types { Circle, Line, Rectangle }

	public class GraphicalObject
	{
		public Types Type { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int DX { get; set; }
		public int DY { get; set; }

		public override string ToString()
		{
			return "" + this.Type.ToString() + "," + X + "," + Y + "," + DX + "," + DY + "\n";
		}
	}
}