using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Test : Vector
    {
        public void Encender(Bitmap bmp)
        {
            double t = 0;
            double dt = 0.001;
            double n = 0.6;

            Vector obj = new Vector();

            do
            {
                obj.setX(Math.Sin(t) - 4 * Math.Sin(t * 2.0138 + n * 30));
                obj.setY( Math.Cos(t) - 4 * Math.Cos(t * 2.0138 + n * 30));
                obj.color = color;
                obj.Encender(bmp);
                t += dt;

            } while (t <= 1);
        }
    }
}
