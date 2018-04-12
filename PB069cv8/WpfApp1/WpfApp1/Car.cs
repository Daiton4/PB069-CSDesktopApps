using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	public enum CarType
	{
		PassengerCar,
		Truck,
		Bus
	}

	public enum FuelType
	{
		Petrol,
		Diesel,
		LPG,
		CNG,
		Electricity
	}

	public class Car
	{
		public string RegistrationPlate { get; set; }
		public CarType Type { get; set; }
		public FuelType Fuel { get; set; }

		public override string ToString()
		{
			return RegistrationPlate + "," + Type + "," + Fuel;
		}
	}
}
