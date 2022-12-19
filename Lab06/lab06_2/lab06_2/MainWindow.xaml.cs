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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Schema;

namespace lab06_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome");
        }

        private void colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem comboBox = (ComboBoxItem)colors.SelectedItem;
            string res = comboBox.Content.ToString();
            switch (res)
            {
                case "Aqua":
                    text1.Foreground=Brushes.Aqua;
                    text2.Foreground = Brushes.Aqua;
                    break;
                case "Blue":
                    text1.Foreground = Brushes.Blue;
                    text2.Foreground = Brushes.Blue;
                    break;
                case "Yellow":
                    text1.Foreground = Brushes.Yellow;
                    text2.Foreground = Brushes.Yellow;
                    break;
                case "Gray":
                    text1.Foreground = Brushes.Gray;
                    text2.Foreground = Brushes.Gray;
                    break;
            }
        }

        private void sizes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem comboBox = (ComboBoxItem)sizes.SelectedItem;
            string res = comboBox.Content.ToString();
            switch (res)
            {
                case "10":
                    text1.FontSize = 10;
                    text2.FontSize = 10;
                    break;
                case "20":
                    text1.FontSize = 20;
                    text2.FontSize = 20;
                    break;
                case "30":
                    text1.FontSize = 30;
                    text2.FontSize = 30;
                    break;
                case "40":
                    text1.FontSize = 40;
                    text2.FontSize = 40;
                    break;
                case "25":
                    text1.FontSize = 25;
                    text2.FontSize = 25;
                    break;
            }
        }

    }
}
