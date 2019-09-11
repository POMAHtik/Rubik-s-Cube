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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//left--
        {
            bool way = (((Button)e.Source).Name == "l1") ? true : false;
            switch(Page2.camera.position)
            {
                case 1:
                    switch(Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX1((way)?false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX3((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY1((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY3((way) ? true:false);
                            break;
                    }
                    break;
                case 2:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ3((way) ? true:false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ1((way) ? false:true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY1((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY3((way) ? true:false);
                            break;
                    }
                    break;
                case 3:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX1((way) ? false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX3((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ3((way) ? true:false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ1((way) ? false:true);
                            break;
                    }
                    break;
                case 4:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX1((way) ? false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX3((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ1((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ3((way) ? true:false);
                            break;
                    }
                    break;
                case 5:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ1((way) ? false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ3((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY1((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY3((way) ? true:false);
                            break;
                    }
                    break;
                case 6:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX3((way) ? true:false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX1((way) ? false:true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY1((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY3((way) ? true:false);
                            break;
                    }
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//-left-
        {
            bool way = (((Button)e.Source).Name == "l2") ? true : false;
            switch (Page2.camera.position)
            {
                case 1:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX2((way)?false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX2((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY2((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY2((way) ? true:false);
                            break;
                    }
                    break;
                case 2:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                    }
                    break;
                case 3:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                    }
                    break;
                case 4:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                    }
                    break;
                case 5:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                    }
                    break;
                case 6:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                    }
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//--left
        {
            bool way = (((Button)e.Source).Name == "l3") ? true : false;
            switch (Page2.camera.position)
            {
                case 1:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX3((way)?false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX1((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY3((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY1((way) ? true:false);
                            break;
                    }
                    break;
                case 2:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ1((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ3((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY3((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY1((way) ? true : false);
                            break;
                    }
                    break;
                case 3:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX3((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX1((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ1((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ3((way) ? false : true);
                            break;
                    }
                    break;
                case 4:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX3((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX1((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ3((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ1((way) ? true : false);
                            break;
                    }
                    break;
                case 5:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ3((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ1((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY3((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY1((way) ? true : false);
                            break;
                    }
                    break;
                case 6:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveX1((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveX3((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveY3((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveY1((way) ? true : false);
                            break;
                    }
                    break;
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)//up--
        {
            bool way = (((Button)e.Source).Name == "u1") ? true : false;
            switch (Page2.camera.position)
            {
                case 1:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY1((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY3((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX3((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX1((way) ? true : false);
                            break;
                    }
                    break;
                case 2:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY1((way) ? true:false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY3((way) ? false:true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ1((way) ? true:false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ3((way) ? false:true);
                            break;
                    }
                    break;
                case 3:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ3((way) ? false:true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ1((way) ? true:false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX3((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX1((way) ? true:false);
                            break;
                    }
                    break;
                case 4:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ1((way) ? true:false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ3((way) ? false:true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX3((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX1((way) ? true:false);
                            break;
                    }
                    break;
                case 5:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY1((way) ? true:false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY3((way) ? false:true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ3((way) ? false:true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ1((way) ? true:false);
                            break;
                    }
                    break;
                case 6:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY1((way) ? true:false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY3((way) ? false:true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX1((way) ? true:false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX3((way) ? false:true);
                            break;
                    }
                    break;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)//-up-
        {
            bool way = (((Button)e.Source).Name == "u2") ? true : false;
            switch (Page2.camera.position)
            {
                case 1:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                    }
                    break;
                case 2:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                    }
                    break;
                case 3:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                    }
                    break;
                case 4:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                    }
                    break;
                case 5:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ2((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ2((way) ? true : false);
                            break;
                    }
                    break;
                case 6:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY2((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY2((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX2((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX2((way) ? false : true);
                            break;
                    }
                    break;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)//--up
        {
            bool way = (((Button)e.Source).Name == "u3") ? true : false;
            switch (Page2.camera.position)
            {
                case 1:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY3((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY1((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX1((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX3((way) ? true : false);
                            break;
                    }
                    break;
                case 2:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY3((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY1((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ3((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ1((way) ? false : true);
                            break;
                    }
                    break;
                case 3:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ1((way) ? false : true);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ3((way) ? true : false);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX1((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX3((way) ? true : false);
                            break;
                    }
                    break;
                case 4:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveZ3((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveZ1((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX1((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX3((way) ? true : false);
                            break;
                    }
                    break;
                case 5:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY3((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY1((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveZ1((way) ? false : true);
                            break;
                        case directions.Right:
                            Page2.cube.MoveZ3((way) ? true : false);
                            break;
                    }
                    break;
                case 6:
                    switch (Page2.camera.direction)
                    {
                        case directions.Up:
                            Page2.cube.MoveY3((way) ? true : false);
                            break;
                        case directions.Down:
                            Page2.cube.MoveY1((way) ? false : true);
                            break;
                        case directions.Left:
                            Page2.cube.MoveX3((way) ? true : false);
                            break;
                        case directions.Right:
                            Page2.cube.MoveX1((way) ? false : true);
                            break;
                    }
                    break;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            for(int i=0;i<100;i++)
            switch(random.Next()%9)
                {
                    case 0:
                        Page2.cube.MoveX1(true);
                        break;
                    case 1:
                        Page2.cube.MoveX2(true);
                        break;
                    case 2:
                        Page2.cube.MoveX3(true);
                        break;
                    case 3:
                        Page2.cube.MoveY1(true);
                        break;
                    case 4:
                        Page2.cube.MoveY2(true);
                        break;
                    case 5:
                        Page2.cube.MoveY3(true);
                        break;
                    case 6:
                        Page2.cube.MoveZ1(true);
                        break;
                    case 7:
                        Page2.cube.MoveZ2(true);
                        break;
                    case 8:
                        Page2.cube.MoveZ2(true);
                        break;
                }
        }
    }
}
