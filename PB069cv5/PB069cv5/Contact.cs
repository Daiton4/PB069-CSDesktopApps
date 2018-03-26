using System;

namespace PB069cv5
{
	public class Adress 
	{
		public string Street { get; set; }
		public string HouseNumber { get; set; }
		public string Postcode { get; set; }
		public string Country { get; set; }

		public override string ToString()
		{
			return string.Join(",", Street, HouseNumber, Postcode, Country);
		}
	}

	public class Contact
	{
		public string  Name { get; set; }
		public string Surname { get; set; }
		public string Phone { get; set; }
		public Adress Adress { get; set; }

		public override string ToString()
		{
			return string.Join(",", Name, Surname, Phone, Adress.ToString());
		}

		public static Contact FromString(string input)
		{
			try
			{
				string[] values = input.Split(',');
				return new Contact()
				{
					Name = values[0],
					Surname = values[1],
					Phone = values[2],
					Adress = new Adress()
					{
						Street = values[3],
						HouseNumber = values[4],
						Postcode = values[5],
						Country = values[6]
					}

				};
			}
			catch (IndexOutOfRangeException)
			{
				return null;
			}
		}
	}
}