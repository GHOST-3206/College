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

namespace WPF_PR3_2
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
        void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItemRed_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void MenuItemBlue_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void MenuItemGreen_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void MenuItemDraw(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void MenuItemRedact(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.White;
        }
        private void MenuItemDelete(object sender, RoutedEventArgs e)
        {
            this.MainInk.Strokes.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
