using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Vector
    {
        public double x0;
        public double y0;
        public Color color;

        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 700;
        public static int sy2 = 500;

        private double x1 = -7, x2 = 7;
        private double y1 = -5, y2 = 5;

        //private double x1 = -10.5, x2 = 10.5;
        //private double y1 = -7.5, y2 = 7.5;

        //private double x1 = -70, x2 = 70;
        //private double y1 = -50, y2 = 50;

        public Vector()
        {
        }

        public Vector(double x0, double y0, Color color)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color = color;
        }

        public void setX(double x)
        {
            this.x0 = x;
        }
        public void setY(double y)
        {
            this.y0 = y;
        }

        public double getX()
        {
            return x0;
        }
        public double getY()
        {
            return y0;
        }

        public void Encender(Bitmap canva)
        {
            int sX;
            int sY;

            Pantalla(x0, y0, out sX, out sY);

            if (sX >= 0 && sX < 700 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, this.color);
            }
        }


        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        public void Apagar(Bitmap canva)
        {
            int sX;
            int sY;

            Pantalla(x0, y0, out sX, out sY);

            if (sX >= 0 && sX < 700 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, Color.WhiteSmoke);
            }
        }
    }
}
