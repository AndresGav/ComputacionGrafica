using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Test : Vector
    {
        public PictureBox picture;
        async public void Encender(Bitmap bmp)
        {
            double t = -7;
            double dt = 0.01;
            double rd = 1;
            

            Random rnd = new Random();

            Vector obj = new Vector();

            int cont=0;

            do
            {
                double x = 1 * 7 *  Math.Sin(t) + 4 * Math.Cos(t * 3.1416) ;
                double y = 2 * 7 * Math.Cos(t) + 4 * Math.Sin(t * 3.1416);

                obj.setX(x + rd * Math.Cos(t));
                obj.setY(y + rd * Math.Sin(t));


                obj.color = color;

                obj.Encender(bmp);

                picture.Image = bmp;
                cont++;
                if (cont >= 5)
                {
                    await Task.Delay(1);
                    cont = 0;

                }
                

                t += dt;

            } while (t <= 300);
        }
    }
}



