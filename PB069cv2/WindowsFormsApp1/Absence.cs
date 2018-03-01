using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Absence
	{
		public string Name { get; set; }
		public int Day { get; set; }
		public int Month { get; set; }
		public bool Justified { get; set; }

		public Absence(string Name, int Day, int Month, bool Justified)
		{
			this.Name = Name;
			if(Day < 32 && Day > 0 && Month > 0 && Month < 13)
			{
				this.Month = Month;
				this.Day = Day;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Invalid date given");
			}
			this.Justified = Justified;
		}

		public override string ToString()
		{
			return " " + Day + " " + Month + " " + Justified + " " +Name;
		}
	}
}
