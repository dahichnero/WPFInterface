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

namespace Lab5_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd=new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_ClickToolBack(object sender, RoutedEventArgs e)
        {
            int i = rnd.Next(1, 6);
            switch (i)
            {
                case 1:
                    main_dock.Background = Brushes.Red;
                    break;
                case 2:
                    main_dock.Background = Brushes.Blue;
                    break;
                case 3:
                    main_dock.Background = Brushes.LightCoral;
                    break;
                case 4:
                    main_dock.Background = Brushes.Gray;
                    break;
                case 5:
                    main_dock.Background = Brushes.LightYellow;
                    break;
            }
        }

        private void Button_MouseMoveToolBack(object sender, MouseEventArgs e)
        {
            work.Text = "Хотите поменять фон?";
        }

        private void Button_ClickToolClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_MouseMoveToolClose(object sender, MouseEventArgs e)
        {
            work.Text = "Хотите закрыть окно?";
        }

        private void Button_ClickToolAbout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация может обновляться.\nКстати, фон можно поменять нажав на функцию меню\nили на функцию в панели инструментов.");
        }

        private void Button_MouseMoveToolAbout(object sender, MouseEventArgs e)
        {
            work.Text = "Вы узнаете много об этой программе.";
        }
    }
}
