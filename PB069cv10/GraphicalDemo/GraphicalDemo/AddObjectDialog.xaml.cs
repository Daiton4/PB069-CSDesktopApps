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

namespace GraphicalDemo
{
    /// <summary>
    /// Interaction logic for AddObjectDialog.xaml
    /// </summary>
    public partial class AddObjectDialog : Window
    {

        public GraphicalObject Obj { get;  set;}

        public AddObjectDialog(string title)
        {
            InitializeComponent();
            this.Title = title;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checkInputs())
            {
                Obj.X = int.Parse(XBox.Text);
                Obj.Y = int.Parse(YBox.Text);
                Obj.DX = int.Parse(DXBox.Text);
                Obj.DY = int.Parse(DYBox.Text);
                DialogResult = true;
            }
        }

        private bool checkInputs()
        {
            return XBox.Text != "" && YBox.Text != ""
                   && DXBox.Text != "" && DYBox.Text != "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
