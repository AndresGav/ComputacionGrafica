using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class gFunciones:Vector
    {

        public void Encender(Bitmap bmp)
        {

            double t = -5.5;
            double dt = 0.001f;

            Vector obj = new Vector();

            do
            {
                obj.setX(t);
                obj.setY(t*t -3);
                obj.color = Color.Red;
                obj.Encender(bmp);

                obj.setY( Math.Pow(2,t));
                obj.color = Color.Green;
                obj.Encender(bmp);

                obj.setY(Math.Cos(t));
                obj.color = Color.Blue;
                obj.Encender(bmp);


                t += dt;

            } while (t <= 5.5);
        }

    }
}
