using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Segmento3D:Vector3D
    {
        public int xf;
        public int yf;
        public int zf;

        public void Encender(Bitmap bmp)
        {
            double t = 0;
            double dt = 0.001;

            Vector3D obj = new Vector3D();

            do
            {

                obj.setX(x0 + (xf - x0) * t);
                obj.setY(y0 + (yf - y0) * t);
                obj.setZ (z0 + (zf - z0) * t);

                

                obj.color = color;

                obj.Encender(bmp);

                t += dt;

            } while (t <= 1);
        }
    }
}
