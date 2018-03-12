using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB069cv3
{
	public enum ElementType { LINE, ELIPSE, RECTANGLE};
	class GraphicElements
	{
		public ElementType type { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int DX { get; set; }
		public int DY { get; set; }
	}
}
