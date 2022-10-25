using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Lazo: Circunferencia
    {
        public void Encender(Bitmap bmp)
        {

            float t = 0;
            float dt = 0.001f;

            Vector obj = new Vector();

            do
            {
                obj.setX(x0 + rd *  Math.Sin(2*t));
                obj.setY(y0 + rd * Math.Cos(3 * t));
                obj.color = color;
                obj.Encender(bmp);
                t += dt;

            } while (t <= 2*Math.PI);
        }
    }
}
