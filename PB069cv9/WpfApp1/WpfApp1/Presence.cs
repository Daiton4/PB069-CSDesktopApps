using System;
using System.Linq;

namespace WpfApp1
{
	public class Presence
	{
		public DateTime From { get; set; }
		public DateTime To { get; set; }

	    public override string ToString()
	    {
	        return From.ToString() + ";" + To.ToString();
	    }

	    public Presence(string input)
	    {
	        string[] split = input.Split(';');
	        if (split.Count() != 2) throw new FormatException();
            From = DateTime.Parse(split[0]);
	        To = DateTime.Parse(split[1]);
	    }

	    public Presence()
	    {
	    }
	}
}