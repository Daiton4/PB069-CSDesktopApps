using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PB069ex1
{
	public class Evaluation
	{
		public enum Classes
		{
			M,
			CJ,
			AJ,
			Pr
		};
		
		private Classes Class { get; }
		private int Grade { get; }
		private string Student { get; }

		public Evaluation(Classes @class, int grade, string student)
		{
			Class = @class;
			if(grade < 1 || grade > 5) throw new InvalidEnumArgumentException("Not Valid Grade");
			Grade = grade;
			if(student.Equals(String.Empty) || student.Equals(null)) throw new InvalidEnumArgumentException("Not Valid Name for Student");
			Student = student;
		}

		public override string ToString()
		{
			return Class.ToString() + ";" + Grade + ";" + Student;
		}
	}
}