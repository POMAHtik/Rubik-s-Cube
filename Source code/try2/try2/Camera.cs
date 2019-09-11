using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using System.Windows;
namespace try2
{
    public enum directions { Up, Down, Left, Right }
    public class Camera//Done
    {
        float distance = 20;
        float X = 20;
        float Y = 20;
        public int position = 1;
        float x = 0, y = 0, z = 0;

        public void SetPosition(int pos)
        {
            position = pos;
            switch (position)
            {
                case 1:
                    x = 0;
                    y = 0;
                    break;
                case 2:
                    y = 0;
                    x = 90;
                    break;
                case 3:
                    x = 0;
                    y = 90;
                    break;
                case 4:
                    x = 0;
                    y = 270;
                    break;
                case 5:
                    y = 0;
                    x = 270;
                    break;
                case 6:
                    y = 0;
                    x = 180;
                    break;
            }
        }

        public void SetPosition(directions dir)
        {
            switch (position)
            {
                case 1:
                    switch (dir)
                    {
                        case directions.Up:
                            SetPosition(2);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Down:
                            SetPosition(5);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Left:
                            SetPosition(3);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Right:
                            SetPosition(4);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                    }
                    break;

                case 2:
                    switch (dir)
                    {
                        case directions.Up:
                            SetPosition(6);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Down:
                            SetPosition(1);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Left:
                            SetPosition(3);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Up);
                                    break;
                            }
                            break;
                        case directions.Right:
                            SetPosition(4);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Down);
                                    break;
                            }
                            break;
                    }
                    break;

                case 3:
                    switch (dir)
                    {
                        case directions.Up:
                            SetPosition(2);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Down);
                                    break;
                            }
                            break;
                        case directions.Down:
                            SetPosition(5);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Up);
                                    break;
                            }
                            break;
                        case directions.Left:
                            SetPosition(6);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Left);
                                    break;
                            }
                            break;
                        case directions.Right:
                            SetPosition(1);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                    }
                    break;

                case 4:
                    switch (dir)
                    {
                        case directions.Up:
                            SetPosition(2);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Up);
                                    break;
                            }
                            break;
                        case directions.Down:
                            SetPosition(5);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Down);
                                    break;
                            }
                            break;
                        case directions.Left:
                            SetPosition(1);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Right:
                            SetPosition(6);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Left);
                                    break;
                            }
                            break;
                    }
                    break;

                case 5:
                    switch (dir)
                    {
                        case directions.Up:
                            SetPosition(1);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Down:
                            SetPosition(6);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Left:
                            SetPosition(3);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Down);
                                    break;
                            }
                            break;
                        case directions.Right:
                            SetPosition(4);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Up);
                                    break;
                            }
                            break;
                    }
                    break;

                case 6:
                    switch (dir)
                    {
                        case directions.Up:
                            SetPosition(5);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Down:
                            SetPosition(2);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Left);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Right);
                                    break;
                            }
                            break;
                        case directions.Left:
                            SetPosition(3);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Left);
                                    break;
                            }
                            break;
                        case directions.Right:
                            SetPosition(4);
                            switch (direction)
                            {
                                case directions.Up:
                                    SetDirection(directions.Down);
                                    break;
                                case directions.Down:
                                    SetDirection(directions.Up);
                                    break;
                                case directions.Left:
                                    SetDirection(directions.Right);
                                    break;
                                case directions.Right:
                                    SetDirection(directions.Left);
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        public directions direction = directions.Up;
        public void SetDirection(directions dir)
        {
            direction = dir;
           switch (direction)
            {
                case directions.Up:
                    z = 0;
                    break;
                case directions.Down:
                    z = 180;
                    break;
                case directions.Left:
                    z = 270;
                    break;
                case directions.Right:
                    z = 90;
                    break;
            }
        }
    



        public void Init()
        {

            Page2.gl.Translate(0, 0, -distance);
            Page2.gl.Rotate(Y, X, 0);
            Page2.gl.Rotate(z, 0, 0, 1);
            Page2.gl.Rotate(x, 1, 0, 0);
            Page2.gl.Rotate(y, 0, 1, 0);
        }

        public void ToScroll(bool way)
        {
            if (way) { if (distance < 50) distance += 5; }
            else if (distance > 5) distance-=5;
            //MessageBox.Show(distance.ToString());
        }

        public void ChangeX()
        {
            X = -X;   
        }


        public void ChangeY()
        {
            Y = -Y;
        }

        public void Up()
        {
            switch (direction)
            {
                case directions.Up:
                    SetPosition(directions.Up);
                    break;
                case directions.Down:
                    SetPosition(directions.Down);
                    break;
                case directions.Left:
                    SetPosition(directions.Left);
                    break;
                case directions.Right:
                    SetPosition(directions.Right);
                    break;
            }
        }

        public void Left()
        {
            switch (direction)
            {
                case directions.Up:
                    SetPosition(directions.Left);
                    break;
                case directions.Down:
                    SetPosition(directions.Right);
                    break;
                case directions.Left:
                    SetPosition(directions.Down);
                    break;
                case directions.Right:
                    SetPosition(directions.Up);
                    break;
            }
        }

        public void Down()
        {
            switch (direction)
            {
                case directions.Up:
                    SetPosition(directions.Down);
                    break;
                case directions.Down:
                    SetPosition(directions.Up);
                    break;
                case directions.Left:
                    SetPosition(directions.Right);
                    break;
                case directions.Right:
                    SetPosition(directions.Left);
                    break;
            }
        }

        public void Right()
        {
            switch (direction)
            {
                case directions.Up:
                    SetPosition(directions.Right);
                    break;
                case directions.Down:
                    SetPosition(directions.Left);
                    break;
                case directions.Left:
                    SetPosition(directions.Up);
                    break;
                case directions.Right:
                    SetPosition(directions.Down);
                    break;
            }
        }
    }
}
