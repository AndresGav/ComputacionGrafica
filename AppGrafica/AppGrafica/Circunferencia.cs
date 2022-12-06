using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Circunferencia: Vector
    {
        public double rd;


        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 700;
        public static int sy2 = 500;

        private double x1 = -7, x2 = 7;
        private double y1 = -5, y2 = 5;

        public void Encender(Bitmap bmp)
        {
            double t = 0;
            double dt = 0.001;

            Vector obj = new Vector();

            do
            {
                obj.setX(x0 + rd * Math.Cos(t));
                obj.setY(y0 + rd * Math.Sin(t));
                obj.color = color;
                obj.Encender(bmp);
                t += dt;

            } while (t <= 2 * Math.PI);
        }

        public void PantallaReal(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        public void Apagar(Bitmap bmp)
        {
            double t = 0;
            double dt = 0.001;

            Vector obj = new Vector();

            do
            {
                obj.setX(x0 + rd * Math.Cos(t));
                obj.setY(y0 + rd * Math.Sin(t));
    
                obj.Encender(bmp);
                t += dt;

            } while (t <= 2 * Math.PI);
        }
    }
}
