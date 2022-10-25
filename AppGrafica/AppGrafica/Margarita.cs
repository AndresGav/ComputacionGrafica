using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Margarita: Circunferencia
    {
        public void Encender(Bitmap bmp)
        {

            float t = 0;
            float dt = 0.001f;

            Vector obj = new Vector();

            do
            {
                obj.setX(x0 + rd * Math.Cos(4 * t) * Math.Cos(t));
                obj.setY(y0 + rd * Math.Cos(4 * t) * Math.Sin(t));
                
                obj.color = color;
                obj.Encender(bmp);
                t += dt;

            } while (t <= 2 * Math.PI);
        }
    }
}
