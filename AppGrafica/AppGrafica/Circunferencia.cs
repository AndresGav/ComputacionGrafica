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
