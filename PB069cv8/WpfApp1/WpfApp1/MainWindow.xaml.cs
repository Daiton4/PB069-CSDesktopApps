using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<Car> CarList;

		public MainWindow()
		{
			InitializeComponent();
			CarList = new List<Car>();
			RefreshList();
		}

		private void RefreshList()
		{
			carListView.Items.Clear();
			foreach (var item in CarList)
			{
				carListView.Items.Add(item);
			}
			countLabel.Content = CarList.Count;
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			AddCar dialog = new AddCar();
			dialog.ShowDialog();
			if(dialog.DialogResult == true)
			{
				CarList.Add(dialog.NewCar);
			}
			RefreshList();
		}

		private void MenuItem_Click_1(object sender, RoutedEventArgs e)
		{
			if (carListView.SelectedIndex == -1) return;
			CarList.Remove((Car) carListView.SelectedValue);
			RefreshList();
		}

		private void MenuItem_Click_2(object sender, RoutedEventArgs e)
		{
			CarList = new List<Car>();
			RefreshList();
		}

		private void MenuItem_Click_3(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog();
			if(dialog.ShowDialog() == true)
			{
				using (var reader = new StreamReader(dialog.OpenFile()) ) {
					string line;
					string[] values;
					if ((line = reader.ReadLine()) != null)
					{
						values = line.Split(',');
						if (values.Length == 3)
						{
							CarList.Add(new Car()
							{
								RegistrationPlate = values[0],
								Type = (CarType)Enum.Parse(typeof(CarType), values[1]),
								Fuel = (FuelType)Enum.Parse(typeof(FuelType), values[2])
							});
						}

					}
				}
			}
			RefreshList();
		}

		private void MenuItem_Click_4(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void MenuItem_Click_5(object sender, RoutedEventArgs e)
		{
			var dialog = new SaveFileDialog();
			if(dialog.ShowDialog() == true)
			{
				using(var writer = new StreamWriter(dialog.OpenFile()))
				{
					foreach(var item in CarList)
					{
						writer.WriteLine(item.ToString());
					}
				}
			}
		}
	}
}
