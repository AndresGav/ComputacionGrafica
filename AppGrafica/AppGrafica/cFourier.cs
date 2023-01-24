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
        double  pi = Math.PI;
        public double t;
        public int c ;
        public double Fourier(double x)
        {
            Random rnd = new Random();
            double ak, bk, sumF=0;
            
           
            int n = 0;
            do
            {
                n += 1;
                /* 
                 ak = (3 / 6) * (0 + 4 * f(1.5) * Math.Sin(n*3.14*(1.5/3)) + f(3) * Math.Sin(n*3.14) );
                 ak*=(2/3);
                 bk = (3 / 6) * (0 + 4 * g(1.5) * Math.Sin(n * 3.14 * (1.5/3)) + g(3) * Math.Sin(n * 3.14));
                 bk *= (2 / (n * 3.14 * c));
                 sumF += (ak * Math.Cos((n * 3.14 * c * t)/3) + bk * Math.Sin((n * 3.14 * c * t)/3)) * Math.Sin(n * 3.14 * (x / 3));
                */

                //ak = (2 / 3) * (0 + 4 * f(1.5) * Math.Sin(n * 3.14) + f(3) * Math.Sin(n * 3.14));
                //ak = ak * (2/3);
                //bk = (3/6) * (0 + 4 * g(1.5) * Math.Sin(n * 3.14 * (1.5/3)) + ( g(3) * Math.Sin(n * 3.14)));
                //bk = bk * (2 / (n * 3.14 * c));
                //sumF = sumF + (ak * Math.Cos((n * 3.14 * t * t) / 3) + bk * Math.Sin((n * 3.14 * c * t) / 3)) * Math.Sin(n * 3.14 * x / 3);

                //ak = (1.33) * (0 + 4 * 5.33 * Math.Sin(n * 3.14 * 2) + 0 * Math.Sin(n * 3.14 * 6));
                //ak = ak * (0.25);
                //bk = (1.33) * (0 + 4 * 4 * Math.Sin(n * 3.14 * 2) + 8 * Math.Sin(n * 3.14));
                //bk = bk * (2 / (n * 3.14 * 1));
                //sumF = sumF + (ak * Math.Cos((n * 3.14 * t) / 8) + bk * Math.Sin((n * 3.14 * t) / 8)) * Math.Sin(n * 3.14 * x / 8);

                //ak = (1.33) * (0 + 4 * 5.33 * Math.Sin(n * 3.14 * 2) + 0 * Math.Sin(n * 3.14 * 6));
                //ak = ak * (0.25);
                //bk = (1.33) * (0 + 4 * 4 * Math.Sin(n * 3.14 * 2) + 8 * Math.Sin(n * 3.14));
                //bk = bk * (2 / (n * 3.14 * 1));
                //sumF = sumF + (ak * Math.Cos((n * 3.14 * t) / 8) + bk * Math.Sin((n * 3.14 * t) / 8)) * Math.Sin(n * 3.14 * x / 8);

                //3/6, el 0 representa un término que se anuló f(a), fórmula de Simpson
                //ak = (0.5) * (0 + 4 * f(x) * Math.Sin(n * Math.PI * 0.5) + f(3) * Math.Sin(n * Math.PI));
                //ak = ak * (2 / 3);

                // O porque el sen(0) en el punto inicial es 0, 1.5/3 = 0.5
                //bk = (0.5) * (0 + 4 * g(1) * Math.Sin(n * Math.PI * 0.5) + g(3) * Math.Sin(n * Math.PI));
                //bk = bk * (2 / (n * Math.PI * c));

                //l = 3
                //sumF = sumF + (ak * Math.Cos((n * Math.PI * c * t) / 3) + bk * Math.Sin((n * Math.PI * c * t) / 3)) * Math.Sin(n * Math.PI * x / 3);
                //ak = 0.66666 * (0 + 4 * f(2) * Math.Sin(n * pi * 0.5) + f(4) * Math.Sin(n * pi));
                //ak *= 0.5;
                //bk = 0.66666 * (0 + 4 * g(2) * Math.Sin(n * pi / 2) + g(4) * Math.Sin(n * pi));
                //bk *= 2 / (n * pi * c); //Factor (2/n pi c)
                //Console.WriteLine("LLEGO:" + ak + "-" + bk + "- " + (2 / 3));
                //sumF += (ak * Math.Cos((n * pi * c * t) / l) + bk * Math.Sin((n * pi * c * t) / 3)) * Math.Sin((n * pi * x) / l);

                //ak = (2 / 3) * (0 + 4 * f(2) * Math.Sin((n * Math.PI) / 2) + f(4) * Math.Sin(n * Math.PI));
                ak = (2 / 3) * (0 + 4 * 2 * Math.Sin((n * Math.PI) / 2) + 0 * Math.Sin(n * Math.PI));
                ak = ak * (0.5);
                //bk = (2 / 3) * (0 + 4 * g(2) * Math.Sin((n * Math.PI) / 2) + g(4) * Math.Sin(n * Math.PI));
                bk = (0.667) * (0 + 4 * 2 * Math.Sin((n * Math.PI) / 2) + 4 * Math.Sin(n * Math.PI));
                bk = bk * (2 / (n * Math.PI * c));
                sumF = sumF + (ak * Math.Cos((n * Math.PI * c * t) / 4) + bk * Math.Sin((n * Math.PI * c * t) / 4)) * Math.Sin((n * Math.PI * x) / 4);


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
            double h = 0, dh = 0.005;

            do
            {
                v.x0 = h;
                v.y0 = Fourier(h);
                v.Encender(bmp);
                h += dh;

            } while (h <= 4);
        }
    }
}
