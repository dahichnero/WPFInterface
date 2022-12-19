using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr9_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DrawingAttributes inkDA = new DrawingAttributes();
        public MainWindow()
        {
            InitializeComponent();
            inkDA.Color = Colors.Red;
            draw.DefaultDrawingAttributes = inkDA;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem comboBox = (ComboBoxItem)colors.SelectedItem;
            string res = comboBox.Content.ToString();
            switch (res)
            {
                case "Red":
                    inkDA.Color = Colors.Red;
                    break;
                case "Blue":
                    inkDA.Color = Colors.Blue;
                    break;
                case "Green":
                    inkDA.Color = Colors.SpringGreen;
                    break;
                case "Yellow":
                    inkDA.Color = Colors.Yellow;
                    break;
                case "Gray":
                    inkDA.Color = Colors.Gray;
                    break;
            }
        }




        private void option_one_Click(object sender, RoutedEventArgs e)
        {
            draw.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void option_two_Click(object sender, RoutedEventArgs e)
        {
            draw.EditingMode = InkCanvasEditingMode.Select;
        }

        private void option_three_Click(object sender, RoutedEventArgs e)
        {
            draw.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void heights_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            inkDA.Height = heights.Value;
        }
    }
}
