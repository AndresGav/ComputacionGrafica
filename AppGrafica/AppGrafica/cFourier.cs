using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class cFourier: Vector
    {
        public double t;
        public double Fourier(double x)
        {
            Random rnd = new Random();
            double ak, bk, sumF=0;
            int n=0;
            double c = 1;

            do
            {
                n += 1;
                /* 
                 ak = (3 / 6) * (0 + 4 * f(1.5) * Math.Sin(n*3.14*(1.5/3)) + f(3) * Math.Sin(n*3.14) );
                 ak*=(2/3);
                 bk = (3 / 6) * (0 + 4 * g(1.5) * Math.Sin(n * 3.14 * (1.5/3)) + g(3) * Math.Sin(n * 3.14));
                 bk *= (2 / (n * 3.14 * c));
                 sumF += (ak * Math.Cos((n * 3.14 * c * t)/3) + bk * Math.Sin((n * 3.14 * c * t)/3)) * Math.Sin(n * 3.14 * (x / 3));
                

                 ak = (3 / 6) * (0 + 4 * f(1.5) * Math.Sin(n * 3.14) + f(3) * Math.Sin(n * 3.14));
                 ak = ak * (2/3);
                 bk = (3/6) * (0 + 4 * g(1.5) * Math.Sin(n * 3.14 * (1.5/3)) + ( g(3) * Math.Sin(n * 3.14)));
                 bk = bk * (2 / (n * 3.14 * c));
                 sumF = sumF + (ak * Math.Cos((n * 3.14 * t * t) / 3) + bk * Math.Sin((n * 3.14 * c * t) / 3)) * Math.Sin(n * 3.14 * x / 3);*/

            

                // 3/6, el 0 representa un término que se anuló f(a), fórmula de Simpson
                ak = (0.5) * (0 + 4 * f(x) * Math.Sin(n * Math.PI * 0.5) + f(3) * Math.Sin(n * Math.PI));
                ak = ak * (2 / 3);

                // O porque el sen(0) en el punto inicial es 0, 1.5/3 = 0.5
                bk = (0.5) * (0 + 4 * g(1) * Math.Sin(n * Math.PI * 0.5) + g(3) * Math.Sin(n * Math.PI));
                bk = bk * (2 / (n * Math.PI * c));

                // l = 3
                sumF = sumF + (ak * Math.Cos((n * Math.PI * c * t) / 3) + bk * Math.Sin((n * Math.PI * c * t) / 3)) * Math.Sin(n * Math.PI * x / 3);


            } while (n<=20);

            return sumF;
        }
        
        public double f(double n)
        {
            return (-(n)*(n-3))/2;
        }
        public double g(double n)
        {
            return 1;
        }

        public void GraficarCuerdaV(Bitmap bmp)
        {
            Vector v = new Vector();
            v.color = Color.Red;
            double h = 0, dh = 0.02;

            do
            {
                v.x0 = h;
                v.y0 = Fourier(h);
                v.Encender(bmp);
                h += dh;

            } while (h <= 3);
        }
    }
}
