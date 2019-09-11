using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
namespace try2
{
    public enum Color { Green,Yellow,White,Orange,Red,Blue}
   public class Square
    {
        public Color color;
        float[] col = new float[3];
        float [,]Vertexes = new float[4,3];
        public Square(Color color,float x1,float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4)
        {
            SetColor(color);
            Vertexes[0, 0] = x1;
            Vertexes[0, 1] = y1;
            Vertexes[0, 2] = z1;
            Vertexes[1, 0] = x2;
            Vertexes[1, 1] = y2;
            Vertexes[1, 2] = z2;
            Vertexes[2, 0] = x3;
            Vertexes[2, 1] = y3;
            Vertexes[2, 2] = z3;
            Vertexes[3, 0] = x4;
            Vertexes[3, 1] = y4;
            Vertexes[3, 2] = z4;
        }
        
        public void Init()
        {
            Page2.gl.Begin(OpenGL.GL_QUADS);//green
            Page2.gl.Color(col[0],col[1],col[2]);
            Page2.gl.Vertex(Vertexes[0, 0], Vertexes[0, 1], Vertexes[0, 2]);
            Page2.gl.Vertex(Vertexes[1, 0], Vertexes[1, 1], Vertexes[1, 2]);
            Page2.gl.Vertex(Vertexes[2, 0], Vertexes[2, 1], Vertexes[2, 2]);
            Page2.gl.Vertex(Vertexes[3, 0], Vertexes[3, 1], Vertexes[3, 2]);
            Page2.gl.End();
        }

        public void SetColor(Color color)
        {
            this.color = color;
            switch (color)
            {
                case Color.Green:
                    col[0]= 0f;
                    col[1] = 1f;
                    col[2] = 0f;
                    break;
                case Color.Yellow:
                    col[0] = 1f;
                    col[1] = 1f;
                    col[2] = 0f;
                    break;
                case Color.Blue:
                    col[0] = 0f;
                    col[1] = 0f;
                    col[2] = 1f;
                    break;
                case Color.Orange:
                    col[0] = 1f;
                    col[1] = 0.7f;
                    col[2] = 0f;
                    break;
                case Color.Red:
                    col[0] = 1f;
                    col[1] = 0f;
                    col[2] = 0f;
                    break;
                case Color.White:
                    col[0] = 1f;
                    col[1] = 1f;
                    col[2] = 1f;
                    break;
            }
        }

    }
}
