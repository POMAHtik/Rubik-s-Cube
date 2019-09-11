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

namespace try2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page2.camera.ToScroll(false);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2.camera.ToScroll(true);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page2.camera.ChangeX();
            A1.IsEnabled = !A1.IsEnabled;
            A2.IsEnabled = !A2.IsEnabled;
        }
        
        private void B_Click(object sender, RoutedEventArgs e)
        {
            Page2.camera.ChangeY();
            B1.IsEnabled = !B1.IsEnabled;
            B2.IsEnabled = !B2.IsEnabled;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page2.camera.Up();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Page2.camera.Down();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Page2.camera.Right();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Page2.camera.Left();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            switch(Page2.camera.direction)
            {
                case directions.Up:
                    Page2.camera.SetDirection(directions.Right);
                    break;
                case directions.Down:
                    Page2.camera.SetDirection(directions.Left);
                    break;
                case directions.Left:
                    Page2.camera.SetDirection(directions.Up);
                    break;
                case directions.Right:
                    Page2.camera.SetDirection(directions.Down);
                    break;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            switch (Page2.camera.direction)
            {
                case directions.Up:
                    Page2.camera.SetDirection(directions.Left);
                    break;
                case directions.Down:
                    Page2.camera.SetDirection(directions.Right);
                    break;
                case directions.Left:
                    Page2.camera.SetDirection(directions.Down);
                    break;
                case directions.Right:
                    Page2.camera.SetDirection(directions.Up);
                    break;
            }
        }
    }
}
