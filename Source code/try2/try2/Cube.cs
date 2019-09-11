using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SharpGL;
using System.Windows;
namespace try2
{
    public class Cube
    {
        Verge[] verges;

        public Cube()
        {
            verges = new Verge[6];
            //1
            verges[0] = new Verge();
            verges[1] = new Verge();
            verges[2] = new Verge();
            verges[3] = new Verge();
            verges[4] = new Verge();
            verges[5] = new Verge();
            verges[0].top1 = new Square(Color.Green, -1.2f, 3.2f, 3.2f, -1.2f, 1.2f, 3.2f, -3.2f, 1.2f, 3.2f, -3.2f, 3.2f, 3.2f);
            verges[0].top2 = new Square(Color.Green, -1f, 3.2f, 3.2f, -1f, 1.2f, 3.2f, 1f, 1.2f, 3.2f, 1f, 3.2f, 3.2f);
            verges[0].top3 = new Square(Color.Green, 1.2f, 3.2f, 3.2f, 1.2f, 1.2f, 3.2f, 3.2f, 1.2f, 3.2f, 3.2f, 3.2f, 3.2f);

            verges[0].center1 = new Square(Color.Green, -1.2f, 1.0f, 3.2f, -1.2f, -1.0f, 3.2f, -3.2f, -1.0f, 3.2f, -3.2f, 1.0f, 3.2f);
            verges[0].center2 = new Square(Color.Green, -1.0f, 1.0f, 3.2f, -1.0f, -1.0f, 3.2f, 1.0f, -1.0f, 3.2f, 1.0f, 1.0f, 3.2f);
            verges[0].center3 = new Square(Color.Green, 1.2f, 1.0f, 3.2f, 1.2f, -1.0f, 3.2f, 3.2f, -1.0f, 3.2f, 3.2f, 1.0f, 3.2f);

            verges[0].bottom1 = new Square(Color.Green, -1.2f, -3.2f, 3.2f, -1.2f, -1.2f, 3.2f, -3.2f, -1.2f, 3.2f, -3.2f, -3.2f, 3.2f);
            verges[0].bottom2 = new Square(Color.Green, -1.0f, -3.2f, 3.2f, -1.0f, -1.2f, 3.2f, 1.0f, -1.2f, 3.2f, 1.0f, -3.2f, 3.2f);
            verges[0].bottom3 = new Square(Color.Green, 1.2f, -3.2f, 3.2f, 1.2f, -1.2f, 3.2f, 3.2f, -1.2f, 3.2f, 3.2f, -3.2f, 3.2f);

            //4
            verges[3].top1 = new Square(Color.Red, 3.2f, 3.2f, 3.2f, 3.2f, 1.2f, 3.2f, 3.2f, 1.2f, 1.2f, 3.2f, 3.2f, 1.2f);
            verges[3].top2 = new Square(Color.Red, 3.2f, 3.2f, -1f, 3.2f, 1.2f, -1f, 3.2f, 1.2f, 1f, 3.2f, 3.2f, 1f);
            verges[3].top3 = new Square(Color.Red, 3.2f, 3.2f, -3.2f, 3.2f, 1.2f, -3.2f, 3.2f, 1.2f, -1.2f, 3.2f, 3.2f, -1.2f);

            verges[3].center1 = new Square(Color.Red, 3.2f, 1f, 3.2f, 3.2f, -1f, 3.2f, 3.2f, -1f, 1.2f, 3.2f, 1f, 1.2f);
            verges[3].center2 = new Square(Color.Red, 3.2f, 1f, 1f, 3.2f, -1f, 1f, 3.2f, -1f, -1f, 3.2f, 1f, -1f);
            verges[3].center3 = new Square(Color.Red, 3.2f, 1f, -3.2f, 3.2f, -1f, -3.2f, 3.2f, -1f, -1.2f, 3.2f, 1f, -1.2f);

            verges[3].bottom1 = new Square(Color.Red, 3.2f, -3.2f, 3.2f, 3.2f, -1.2f, 3.2f, 3.2f, -1.2f, 1.2f, 3.2f, -3.2f, 1.2f);
            verges[3].bottom2 = new Square(Color.Red, 3.2f, -3.2f, -1f, 3.2f, -1.2f, -1f, 3.2f, -1.2f, 1f, 3.2f, -3.2f, 1f);
            verges[3].bottom3 = new Square(Color.Red, 3.2f, -3.2f, -1.2f, 3.2f, -1.2f, -1.2f, 3.2f, -1.2f, -3.2f, 3.2f, -3.2f, -3.2f);

            //3
            verges[2].top1 = new Square(Color.Blue, -3.2f, 3.2f, -3.2f, -3.2f, 1.2f, -3.2f, -3.2f, 1.2f, -1.2f, -3.2f, 3.2f, -1.2f);
            verges[2].top2 = new Square(Color.Blue, -3.2f, 3.2f, -1f, -3.2f, 1.2f, -1f, -3.2f, 1.2f, 1f, -3.2f, 3.2f, 1f);
            verges[2].top3 = new Square(Color.Blue, -3.2f, 3.2f, 3.2f, -3.2f, 1.2f, 3.2f, -3.2f, 1.2f, 1.2f, -3.2f, 3.2f, 1.2f);

            verges[2].center1 = new Square(Color.Blue, -3.2f, 1f, -3.2f, -3.2f, -1f, -3.2f, -3.2f, -1f, -1.2f, -3.2f, 1f, -1.2f);
            verges[2].center2 = new Square(Color.Blue, -3.2f, 1f, 1f, -3.2f, -1f, 1f, -3.2f, -1f, -1f, -3.2f, 1f, -1f);
            verges[2].center3 = new Square(Color.Blue, -3.2f, 1f, 3.2f, -3.2f, -1f, 3.2f, -3.2f, -1f, 1.2f, -3.2f, 1f, 1.2f);

            verges[2].bottom1 = new Square(Color.Blue, -3.2f, -3.2f, -1.2f, -3.2f, -1.2f, -1.2f, -3.2f, -1.2f, -3.2f, -3.2f, -3.2f, -3.2f);
            verges[2].bottom2 = new Square(Color.Blue, -3.2f, -3.2f, -1f, -3.2f, -1.2f, -1f, -3.2f, -1.2f, 1f, -3.2f, -3.2f, 1f);
            verges[2].bottom3 = new Square(Color.Blue, -3.2f, -3.2f, 3.2f, -3.2f, -1.2f, 3.2f, -3.2f, -1.2f, 1.2f, -3.2f, -3.2f, 1.2f);

            //2
            verges[1].top1 = new Square(Color.Yellow, -3.2f, 3.2f, -1.2f, -1.2f, 3.2f, -1.2f, -1.2f, 3.2f, -3.2f, -3.2f, 3.2f, -3.2f);
            verges[1].top2 = new Square(Color.Yellow, -1f, 3.2f, -1.2f, 1f, 3.2f, -1.2f, 1f, 3.2f, -3.2f, -1f, 3.2f, -3.2f);
            verges[1].top3 = new Square(Color.Yellow, 3.2f, 3.2f, -1.2f, 1.2f, 3.2f, -1.2f, 1.2f, 3.2f, -3.2f, 3.2f, 3.2f, -3.2f);

            verges[1].center1 = new Square(Color.Yellow, -3.2f, 3.2f, 1f, -1.2f, 3.2f, 1f, -1.2f, 3.2f, -1f, -3.2f, 3.2f, -1f);
            verges[1].center2 = new Square(Color.Yellow, -1f, 3.2f, 1f, 1f, 3.2f, 1f, 1f, 3.2f, -1f, -1f, 3.2f, -1f);
            verges[1].center3 = new Square(Color.Yellow, 3.2f, 3.2f, 1f, 1.2f, 3.2f, 1f, 1.2f, 3.2f, -1f, 3.2f, 3.2f, -1f);

            verges[1].bottom1 = new Square(Color.Yellow, -3.2f, 3.2f, 1.2f, -1.2f, 3.2f, 1.2f, -1.2f, 3.2f, 3.2f, -3.2f, 3.2f, 3.2f);
            verges[1].bottom2 = new Square(Color.Yellow, -1f, 3.2f, 1.2f, 1f, 3.2f, 1.2f, 1f, 3.2f, 3.2f, -1f, 3.2f, 3.2f);
            verges[1].bottom3 = new Square(Color.Yellow, 3.2f, 3.2f, 1.2f, 1.2f, 3.2f, 1.2f, 1.2f, 3.2f, 3.2f, 3.2f, 3.2f, 3.2f);

            //5
            verges[4].top1 = new Square(Color.Orange, -3.2f, -3.2f, 1.2f, -1.2f, -3.2f, 1.2f, -1.2f, -3.2f, 3.2f, -3.2f, -3.2f, 3.2f);
            verges[4].top2 = new Square(Color.Orange, -1f, -3.2f, 1.2f, 1f, -3.2f, 1.2f, 1f, -3.2f, 3.2f, -1f, -3.2f, 3.2f);
            verges[4].top3 = new Square(Color.Orange, 3.2f, -3.2f, 1.2f, 1.2f, -3.2f, 1.2f, 1.2f, -3.2f, 3.2f, 3.2f, -3.2f, 3.2f);

            verges[4].center1 = new Square(Color.Orange, -3.2f, -3.2f, 1f, -1.2f, -3.2f, 1f, -1.2f, -3.2f, -1f, -3.2f, -3.2f, -1f);
            verges[4].center2 = new Square(Color.Orange, -1f, -3.2f, 1f, 1f, -3.2f, 1f, 1f, -3.2f, -1f, -1f, -3.2f, -1f);
            verges[4].center3 = new Square(Color.Orange, 3.2f, -3.2f, 1f, 1.2f, -3.2f, 1f, 1.2f, -3.2f, -1f, 3.2f, -3.2f, -1f);

            verges[4].bottom1 = new Square(Color.Orange, -3.2f, -3.2f, -1.2f, -1.2f, -3.2f, -1.2f, -1.2f, -3.2f, -3.2f, -3.2f, -3.2f, -3.2f);
            verges[4].bottom2 = new Square(Color.Orange, -1f, -3.2f, -1.2f, 1f, -3.2f, -1.2f, 1f, -3.2f, -3.2f, -1f, -3.2f, -3.2f);
            verges[4].bottom3 = new Square(Color.Orange, 3.2f, -3.2f, -1.2f, 1.2f, -3.2f, -1.2f, 1.2f, -3.2f, -3.2f, 3.2f, -3.2f, -3.2f);

            //6
            verges[5].top1 = new Square(Color.White, -1.2f, -3.2f, -3.2f, -1.2f, -1.2f, -3.2f, -3.2f, -1.2f, -3.2f, -3.2f, -3.2f, -3.2f);
            verges[5].top2 = new Square(Color.White, -1.0f, -3.2f, -3.2f, -1.0f, -1.2f, -3.2f, 1.0f, -1.2f, -3.2f, 1.0f, -3.2f, -3.2f);
            verges[5].top3 = new Square(Color.White, 1.2f, -3.2f, -3.2f, 1.2f, -1.2f, -3.2f, 3.2f, -1.2f, -3.2f, 3.2f, -3.2f, -3.2f);

            verges[5].center1 = new Square(Color.White, -1.2f, 1.0f, -3.2f, -1.2f, -1.0f, -3.2f, -3.2f, -1.0f, -3.2f, -3.2f, 1.0f, -3.2f);
            verges[5].center2 = new Square(Color.White, -1.0f, 1.0f, -3.2f, -1.0f, -1.0f, -3.2f, 1.0f, -1.0f, -3.2f, 1.0f, 1.0f, -3.2f);
            verges[5].center3 = new Square(Color.White, 1.2f, 1.0f, -3.2f, 1.2f, -1.0f, -3.2f, 3.2f, -1.0f, -3.2f, 3.2f, 1.0f, -3.2f);

            verges[5].bottom1 = new Square(Color.White, -1.2f, 3.2f, -3.2f, -1.2f, 1.2f, -3.2f, -3.2f, 1.2f, -3.2f, -3.2f, 3.2f, -3.2f);
            verges[5].bottom2 = new Square(Color.White, -1.0f, 3.2f, -3.2f, -1.0f, 1.2f, -3.2f, 1.0f, 1.2f, -3.2f, 1.0f, 3.2f, -3.2f);
            verges[5].bottom3 = new Square(Color.White, 1.2f, 3.2f, -3.2f, 1.2f, 1.2f, -3.2f, 3.2f, 1.2f, -3.2f, 3.2f, 3.2f, -3.2f);

            buffer = new Buffer[4];
            buffer[0] = new Buffer();
            buffer[1] = new Buffer();
            buffer[2] = new Buffer();
            buffer[3] = new Buffer();
        }

        public void Init()
        {

            Page2.gl.Begin(OpenGL.GL_QUADS);
            Page2.gl.Color(0, 0, 0);

            Page2.gl.Vertex(-3.2f, -3.2f, 3.19f);
            Page2.gl.Vertex(-3.2f, 3.2f, 3.19f);
            Page2.gl.Vertex(3.2f, 3.2f, 3.19f);
            Page2.gl.Vertex(3.2f, -3.2f, 3.19f);

            Page2.gl.Vertex(3.19f, 3.2f, 3.2f);
            Page2.gl.Vertex(3.19f, 3.2f, -3.2f);
            Page2.gl.Vertex(3.19f, -3.2f, -3.2f);
            Page2.gl.Vertex(3.19f, -3.2f, 3.2f);

            Page2.gl.Vertex(-3.19f, 3.2f, 3.2f);
            Page2.gl.Vertex(-3.19f, 3.2f, -3.2f);
            Page2.gl.Vertex(-3.19f, -3.2f, -3.2f);
            Page2.gl.Vertex(-3.19f, -3.2f, 3.2f);

            Page2.gl.Vertex(3.2f, 3.19f, 3.2f);
            Page2.gl.Vertex(3.2f, 3.19f, -3.2f);
            Page2.gl.Vertex(-3.2f, 3.19f, -3.2f);
            Page2.gl.Vertex(-3.2f, 3.19f, 3.2f);

            Page2.gl.Vertex(3.2f, -3.19f, 3.2f);
            Page2.gl.Vertex(3.2f, -3.19f, -3.2f);
            Page2.gl.Vertex(-3.2f, -3.19f, -3.2f);
            Page2.gl.Vertex(-3.2f, -3.19f, 3.2f);


            Page2.gl.Vertex(-3.2f, -3.2f, -3.19f);
            Page2.gl.Vertex(-3.2f, 3.2f, -3.19f);
            Page2.gl.Vertex(3.2f, 3.2f, -3.19f);
            Page2.gl.Vertex(3.2f, -3.2f, -3.19f);

            Page2.gl.End();

            foreach (Verge verge in verges) verge.Init();
        }

        void SetColor(Buffer buffer, Color color)
        {
            buffer.color = color;
        }

        class Buffer
        {
            public Color color;
        }
        Buffer[] buffer;

        public void MoveY1(bool way)
        {
            SetColor((way)? buffer[0] :buffer[2], verges[0].top1.color);
            SetColor((way)? buffer[1] : buffer[3], verges[1].top1.color);
            SetColor((way)? buffer[2] : buffer[0], verges[5].top1.color);
            SetColor((way)? buffer[3] : buffer[1], verges[4].top1.color);
           
            verges[0].top1.SetColor(buffer[3].color);
            verges[1].top1.SetColor(buffer[0].color);
            verges[5].top1.SetColor(buffer[1].color);
            verges[4].top1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].center1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].center1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center1.color);

            verges[0].center1.SetColor(buffer[3].color);
            verges[1].center1.SetColor(buffer[0].color);
            verges[5].center1.SetColor(buffer[1].color);
            verges[4].center1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].bottom1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].bottom1.color);

            verges[0].bottom1.SetColor(buffer[3].color);
            verges[1].bottom1.SetColor(buffer[0].color);
            verges[5].bottom1.SetColor(buffer[1].color);
            verges[4].bottom1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[2].bottom1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[2].bottom3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].top3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].top1.color);

            verges[2].bottom1.SetColor(buffer[3].color);
            verges[2].bottom3.SetColor(buffer[0].color);
            verges[2].top3.SetColor(buffer[1].color);
            verges[2].top1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[2].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[2].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].center3.color);

            verges[2].top2.SetColor(buffer[3].color);
            verges[2].center1.SetColor(buffer[0].color);
            verges[2].bottom2.SetColor(buffer[1].color);
            verges[2].center3.SetColor(buffer[2].color);
        }
        
        public void MoveY2(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[0].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].top2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].top2.color);

            verges[0].top2.SetColor(buffer[3].color);
            verges[1].top2.SetColor(buffer[0].color);
            verges[5].top2.SetColor(buffer[1].color);
            verges[4].top2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].center2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].center2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center2.color);

            verges[0].center2.SetColor(buffer[3].color);
            verges[1].center2.SetColor(buffer[0].color);
            verges[5].center2.SetColor(buffer[1].color);
            verges[4].center2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].bottom2.color);

            verges[0].bottom2.SetColor(buffer[3].color);
            verges[1].bottom2.SetColor(buffer[0].color);
            verges[5].bottom2.SetColor(buffer[1].color);
            verges[4].bottom2.SetColor(buffer[2].color);
        }


        public void MoveY3(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[0].top3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].top3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].top3.color);

            verges[0].top3.SetColor(buffer[3].color);
            verges[1].top3.SetColor(buffer[0].color);
            verges[5].top3.SetColor(buffer[1].color);
            verges[4].top3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].center3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].center3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center3.color);

            verges[0].center3.SetColor(buffer[3].color);
            verges[1].center3.SetColor(buffer[0].color);
            verges[5].center3.SetColor(buffer[1].color);
            verges[4].center3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].bottom3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].bottom3.color);

            verges[0].bottom3.SetColor(buffer[3].color);
            verges[1].bottom3.SetColor(buffer[0].color);
            verges[5].bottom3.SetColor(buffer[1].color);
            verges[4].bottom3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].bottom3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].bottom1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[3].top1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[3].top3.color);

            verges[3].bottom3.SetColor(buffer[3].color);
            verges[3].bottom1.SetColor(buffer[0].color);
            verges[3].top1.SetColor(buffer[1].color);
            verges[3].top3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].center3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[3].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[3].center1.color);

            verges[3].top2.SetColor(buffer[3].color);
            verges[3].center3.SetColor(buffer[0].color);
            verges[3].bottom2.SetColor(buffer[1].color);
            verges[3].center1.SetColor(buffer[2].color);
        }

        public void MoveX1(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[0].top1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].top1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].bottom3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].top1.color);

            verges[0].top1.SetColor(buffer[3].color);
            verges[3].top1.SetColor(buffer[0].color);
            verges[5].bottom3.SetColor(buffer[1].color);
            verges[2].top1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].top2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].top2.color);

            verges[0].top2.SetColor(buffer[3].color);
            verges[3].top2.SetColor(buffer[0].color);
            verges[5].bottom2.SetColor(buffer[1].color);
            verges[2].top2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].top3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].top3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].bottom1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].top3.color);

            verges[0].top3.SetColor(buffer[3].color);
            verges[3].top3.SetColor(buffer[0].color);
            verges[5].bottom1.SetColor(buffer[1].color);
            verges[2].top3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[1].bottom1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[1].top3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[1].top1.color);

            verges[1].bottom1.SetColor(buffer[3].color);
            verges[1].bottom3.SetColor(buffer[0].color);
            verges[1].top3.SetColor(buffer[1].color);
            verges[1].top1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[1].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[1].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[1].center3.color);

            verges[1].top2.SetColor(buffer[3].color);
            verges[1].center1.SetColor(buffer[0].color);
            verges[1].bottom2.SetColor(buffer[1].color);
            verges[1].center3.SetColor(buffer[2].color);
        }

        public void MoveX2(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[0].center1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].center3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].center1.color);

            verges[0].center1.SetColor(buffer[3].color);
            verges[3].center1.SetColor(buffer[0].color);
            verges[5].center3.SetColor(buffer[1].color);
            verges[2].center1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].center2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].center2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].center2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].center2.color);

            verges[0].center2.SetColor(buffer[3].color);
            verges[3].center2.SetColor(buffer[0].color);
            verges[5].center2.SetColor(buffer[1].color);
            verges[2].center2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].center3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].center3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].center1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].center3.color);

            verges[0].center3.SetColor(buffer[3].color);
            verges[3].center3.SetColor(buffer[0].color);
            verges[5].center1.SetColor(buffer[1].color);
            verges[2].center3.SetColor(buffer[2].color);
        }

        public void MoveX3(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].bottom1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].bottom1.color);

            verges[0].bottom1.SetColor(buffer[3].color);
            verges[3].bottom1.SetColor(buffer[0].color);
            verges[5].top3.SetColor(buffer[1].color);
            verges[2].bottom1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].bottom2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].bottom2.color);

            verges[0].bottom2.SetColor(buffer[3].color);
            verges[3].bottom2.SetColor(buffer[0].color);
            verges[5].top2.SetColor(buffer[1].color);
            verges[2].bottom2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[3].bottom3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[2].bottom3.color);

            verges[0].bottom3.SetColor(buffer[3].color);
            verges[3].bottom3.SetColor(buffer[0].color);
            verges[5].top1.SetColor(buffer[1].color);
            verges[2].bottom3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[4].bottom3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[4].bottom1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[4].top1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].top3.color);

            verges[4].bottom3.SetColor(buffer[3].color);
            verges[4].bottom1.SetColor(buffer[0].color);
            verges[4].top1.SetColor(buffer[1].color);
            verges[4].top3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[4].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[4].center3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[4].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center1.color);

            verges[4].top2.SetColor(buffer[3].color);
            verges[4].center3.SetColor(buffer[0].color);
            verges[4].bottom2.SetColor(buffer[1].color);
            verges[4].center1.SetColor(buffer[2].color);
        }

        public void MoveZ1(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[3].top1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].bottom3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].top3.color);

            verges[3].top1.SetColor(buffer[3].color);
            verges[1].bottom1.SetColor(buffer[0].color);
            verges[2].bottom3.SetColor(buffer[1].color);
            verges[4].top3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].center1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].center3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].top2.color);

            verges[3].center1.SetColor(buffer[3].color);
            verges[1].bottom2.SetColor(buffer[0].color);
            verges[2].center3.SetColor(buffer[1].color);
            verges[4].top2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].bottom1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].bottom3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].top3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].top1.color);

            verges[3].bottom1.SetColor(buffer[3].color);
            verges[1].bottom3.SetColor(buffer[0].color);
            verges[2].top3.SetColor(buffer[1].color);
            verges[4].top1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].bottom1.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[0].bottom3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[0].top3.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[0].top1.color);

            verges[0].bottom1.SetColor(buffer[3].color);
            verges[0].bottom3.SetColor(buffer[0].color);
            verges[0].top3.SetColor(buffer[1].color);
            verges[0].top1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[0].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[0].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[0].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[0].center3.color);

            verges[0].top2.SetColor(buffer[3].color);
            verges[0].center1.SetColor(buffer[0].color);
            verges[0].bottom2.SetColor(buffer[1].color);
            verges[0].center3.SetColor(buffer[2].color);
        }


        public void MoveZ2(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[3].top2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].bottom2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center3.color);

            verges[3].top2.SetColor(buffer[3].color);
            verges[1].center1.SetColor(buffer[0].color);
            verges[2].bottom2.SetColor(buffer[1].color);
            verges[4].center3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].center2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].center2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center2.color);

            verges[3].center2.SetColor(buffer[3].color);
            verges[1].center2.SetColor(buffer[0].color);
            verges[2].center2.SetColor(buffer[1].color);
            verges[4].center2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].bottom2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].center3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].top2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].center1.color);

            verges[3].bottom2.SetColor(buffer[3].color);
            verges[1].center3.SetColor(buffer[0].color);
            verges[2].top2.SetColor(buffer[1].color);
            verges[4].center1.SetColor(buffer[2].color);
        }


        public void MoveZ3(bool way)
        {
            SetColor((way) ? buffer[0] : buffer[2], verges[3].top3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].top1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].bottom1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].bottom3.color);

            verges[3].top3.SetColor(buffer[3].color);
            verges[1].top1.SetColor(buffer[0].color);
            verges[2].bottom1.SetColor(buffer[1].color);
            verges[4].bottom3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].center3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].top2.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].center1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].bottom2.color);

            verges[3].center3.SetColor(buffer[3].color);
            verges[1].top2.SetColor(buffer[0].color);
            verges[2].center1.SetColor(buffer[1].color);
            verges[4].bottom2.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[3].bottom3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[1].top3.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[2].top1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[4].bottom1.color);

            verges[3].bottom3.SetColor(buffer[3].color);
            verges[1].top3.SetColor(buffer[0].color);
            verges[2].top1.SetColor(buffer[1].color);
            verges[4].bottom1.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[5].bottom3.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[5].bottom1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top1.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[5].top3.color);

            verges[5].bottom3.SetColor(buffer[3].color);
            verges[5].bottom1.SetColor(buffer[0].color);
            verges[5].top1.SetColor(buffer[1].color);
            verges[5].top3.SetColor(buffer[2].color);

            SetColor((way) ? buffer[0] : buffer[2], verges[5].bottom2.color);
            SetColor((way) ? buffer[1] : buffer[3], verges[5].center1.color);
            SetColor((way) ? buffer[2] : buffer[0], verges[5].top2.color);
            SetColor((way) ? buffer[3] : buffer[1], verges[5].center3.color);

            verges[5].bottom2.SetColor(buffer[3].color);
            verges[5].center1.SetColor(buffer[0].color);
            verges[5].top2.SetColor(buffer[1].color);
            verges[5].center3.SetColor(buffer[2].color);
        }
    }
}