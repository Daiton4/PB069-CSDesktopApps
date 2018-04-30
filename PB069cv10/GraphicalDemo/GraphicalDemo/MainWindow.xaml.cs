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

namespace GraphicalDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GraphicalObject> objects = new List<GraphicalObject>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            objects.Clear();
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            DrawArea.Children.Clear();
            foreach(GraphicalObject obj in objects)
            {
                Draw(obj);
            }
        }

        private void Draw(GraphicalObject obj)
        {
            switch(obj.Type)
            {
                case ObjectType.LINE:
                    DrawLine(obj);
                    break;
                case ObjectType.RECTANGLE:
                    DrawRectangle(obj);
                    break;
                case ObjectType.ELLIPSE:
                    DrawEllipse(obj);
                    break;
            }
        }

        private void DrawLine(GraphicalObject obj)
        {
            Line line = new Line();
            line.X1 = obj.X;
            line.Y1 = obj.Y;
            line.X2 = obj.X + obj.DX;
            line.Y2 = obj.Y + obj.DY;
            line.Stroke = Brushes.Black;
            DrawArea.Children.Add(line);
        }

        private void DrawRectangle(GraphicalObject obj)
        {
            Rectangle rect = new Rectangle();
            rect.Width = obj.DX;
            rect.Height = obj.DY;
            rect.Stroke = Brushes.Black;
            Canvas.SetTop(rect, obj.X);
            Canvas.SetLeft(rect, obj.Y);
            DrawArea.Children.Add(rect);
        }

        private void DrawEllipse(GraphicalObject obj)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = obj.DX;
            ellipse.Height = obj.DY;
            ellipse.Stroke = Brushes.Black;
            Canvas.SetTop(ellipse, obj.X);
            Canvas.SetLeft(ellipse, obj.Y);
            DrawArea.Children.Add(ellipse);

        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == true)
            {
                LoadData(dialog.FileName);
                RefreshGUI();
            }
        }

        private void LoadData(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                objects.Clear();
                string line;
                while((line=reader.ReadLine())!=null)
                {
                    GraphicalObject obj = GraphicalObject.ParseObject(line);
                    objects.Add(obj);
                }
            }
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                SaveData(dialog.FileName);
            }
        }

        private void SaveData(string filename)
        {
            using(StreamWriter writer = new StreamWriter(filename))
            {
                foreach(GraphicalObject obj in objects)
                {
                    writer.WriteLine(obj);
                }
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LineMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddObjectDialog dialog = new AddObjectDialog("Add Line");
            GraphicalObject line = new GraphicalObject();
            line.Type = ObjectType.LINE;
            dialog.Obj = line;

            if (dialog.ShowDialog() == true)
            {

                objects.Add(dialog.Obj);
                RefreshGUI();
            }

        }

        private void RectangleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddObjectDialog dialog = new AddObjectDialog("Add Rectangle");
            GraphicalObject rectangle = new GraphicalObject();
            rectangle.Type = ObjectType.RECTANGLE;
            dialog.Obj = rectangle;

            if (dialog.ShowDialog() == true)
            {
                objects.Add(dialog.Obj);
                RefreshGUI();
            }
        }

        private void EllipseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddObjectDialog dialog = new AddObjectDialog("Add Ellipse");
            GraphicalObject ellipse = new GraphicalObject();
            ellipse.Type = ObjectType.ELLIPSE;
            dialog.Obj = ellipse;


            if (dialog.ShowDialog() == true)
            {
                objects.Add(dialog.Obj);
                RefreshGUI();
            }
        }
    }
}
