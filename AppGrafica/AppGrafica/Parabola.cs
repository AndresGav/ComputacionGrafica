using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Parabola: Vector
    {
        public void Encender(Bitmap bmp)
        {
          
            double x= 3;
            Vector obj = new Vector();

            do
            {
                obj.setX(x);
                obj.setY(-((x-3)*(x+0))/2);
                obj.color = Color.Black;
                obj.Encender(bmp);
                x += 0.01;

            } while (x <= 6);
        }
    }
}
