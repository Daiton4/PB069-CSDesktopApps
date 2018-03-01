using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB069cv1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
			string input = Console.ReadLine();
			int num = 0;
			int.TryParse(input,out num);
			/*Console.WriteLine("Factorial is {0}",Factorial(num));
			Console.ReadLine();
			Console.WriteLine("{0} of Fibonnacci", num);
			Fibon(num);
			Console.ReadLine();*/
			Console.WriteLine(Palindrom(input));
			Console.ReadLine();
		}

		public static bool Palindrom(string input)
		{
			for(int i=0; i < input.Length / 2; i++)
			{
				if ( ! input[i].Equals(input[input.Length - 1 - i]))
				{
					return false;
				}
			}
			return true;
		}

		public static int Factorial(int num)
		{
			if (num > 1)
			{
				return num*Factorial(num-1);
			}
			else
			{
				return 1;
			}
		}

		public static void Fibon(int num)
		{
			int first = 0;
			int second = 1;
			int temp = 0;
			Console.Write("1, ");
			for(int i=0; i<num-1; i++)
			{
				Console.Write("{0}, ",first+second);
				temp = first;
				first = second;
				second = temp + second;
			}
		}
	}
}
