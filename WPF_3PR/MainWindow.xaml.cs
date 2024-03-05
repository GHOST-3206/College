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

namespace WPF_3PR
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Файл открыт");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО - Печенкин Артём Егвеньевич");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void Change_green_Click(object sender, RoutedEventArgs e)
        {
            Menu1.Background = new SolidColorBrush(Colors.Green);
        }

        private void Change_red_Click(object sender, RoutedEventArgs e)
        {
            Menu1.Background = new SolidColorBrush(Colors.Red);
        }

        private void Change_blue_Click(object sender, RoutedEventArgs e)
        {
            Menu1.Background = new SolidColorBrush(Colors.Blue);
        }
    }
}
