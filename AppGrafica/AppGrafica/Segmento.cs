using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Segmento: Vector
    {
        public int xf;
        public int yf;

         public void Encender(Bitmap bmp)
        {
            double t = 0;
            double dt = 0.001;

            Vector obj = new Vector();

            do
            {

                obj.setX(x0 + (xf - x0) * t);
                obj.setY(y0 + (yf - y0) * t);
                //vertor.setZ = z0 + (zf - z0) * t;
                obj.color = color;
                
                obj.Encender(bmp);

                t += dt;

            } while (t <= 1);
        }

        public void Apagar(Bitmap bmp)
        {
            double t = 0;
            double dt = 0.001;

            Vector obj = new Vector();

            do
            {

                obj.setX(x0 + (xf - x0) * t);
                obj.setY(y0 + (yf - y0) * t);
                

                obj.Apagar(bmp);

                t += dt;

            } while (t <= 1);
        }
       

    }
}
