using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for AddCar.xaml
	/// </summary>
	public partial class AddCar : Window
	{
		public Car NewCar { get; set; }

		public AddCar()
		{
			InitializeComponent();
			foreach ( var item in Enum.GetValues(typeof(CarType)))
			{
				typeComboBox.Items.Add(item);
			}
			foreach (var item in Enum.GetValues(typeof(FuelType)))
			{
				fuelComboBox.Items.Add(item);
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			this.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (typeComboBox.SelectedIndex == -1 || fuelComboBox.SelectedIndex == -1 || PlateTextBox.Text == "" || PlateTextBox.Text.Length > 8) return;
			NewCar = new Car()
			{
				RegistrationPlate = PlateTextBox.Text,
				Type = (CarType)typeComboBox.SelectedValue,
				Fuel = (FuelType)fuelComboBox.SelectedValue
			};
			DialogResult = true;
			this.Close();
		}
	}
}
