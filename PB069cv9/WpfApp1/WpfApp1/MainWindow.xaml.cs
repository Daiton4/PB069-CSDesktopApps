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
using Microsoft.Win32;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<Presence> presences = new List<Presence>();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void OpenMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
		    if (dialog.ShowDialog() == true)
		    {
                presences = new List<Presence>();
		        using (var reader = new StreamReader(dialog.OpenFile()))
		        {
		            string line;
		            while ((line = reader.ReadLine()) != null)
		            {
		                presences.Add(new Presence(line));
		            }
		        }
                RefreshGUI();
		    }
		}

		private void NewMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
			presences = new List<Presence>();
            RefreshGUI();
		}

		private void SaveMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
            SaveFileDialog dialog = new SaveFileDialog();
		    if (dialog.ShowDialog() == true)
		    {
		        using (var writer = new StreamWriter(dialog.OpenFile()))
		        {
		            foreach (var item in presences)
		            {
		                writer.WriteLine(item.ToString());
		            }
		        }
		    }
		}

		private void ExitMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void AddPresenceMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
			AddPresenceDialog dialog = new AddPresenceDialog();
			if (dialog.ShowDialog() == true)
			{
				presences.Add(dialog.Presence);
				RefreshGUI();
			}
		}

		private void RefreshGUI()
		{
			PresenceListBox.Items.Clear();
		    foreach (var item in presences)
		    {
		        PresenceListBox.Items.Add(item);
		    }
		}

		private void RemovePresenceMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
		    if (PresenceListBox.SelectedIndex == -1) return;
            presences.RemoveAt(PresenceListBox.SelectedIndex);
            RefreshGUI();
		}
	}
}
