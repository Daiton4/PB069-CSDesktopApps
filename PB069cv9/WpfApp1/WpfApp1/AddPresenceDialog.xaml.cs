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
	/// Interaction logic for AddPresenceDialog.xaml
	/// </summary>
	public partial class AddPresenceDialog : Window
	{
		public Presence Presence { get; set; }

		public DateTime DatetimeProperty
		{
			get => (DateTime) GetValue(DatetimePropertyProperty);
			set => SetValue(DatetimePropertyProperty, value);
		}

		public static readonly DependencyProperty DatetimePropertyProperty = DependencyProperty.Register(
			"DatetimeProperty", typeof(DateTime), typeof(AddPresenceDialog), new PropertyMetadata(DateTime.Now, DatetimePropertyChanged));


		private static void DatetimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			AddPresenceDialog dialog = (AddPresenceDialog)d;
			dialog.ToPicker.DisplayDateStart = dialog.FromPicker.SelectedDate;
		}

		public AddPresenceDialog()
		{
			InitializeComponent();
			Presence = new Presence();
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			Presence.From = (DateTime)FromPicker.SelectedDate;
			Presence.To = (DateTime)ToPicker.SelectedDate;
			DialogResult = true;
		}
		

		private void FromPicker_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
		{
			if (FromPicker.SelectedDate == null) return;
			DatetimeProperty = (DateTime) FromPicker.SelectedDate;
		}

		private void CancelButton_OnClick(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}
	}
}
