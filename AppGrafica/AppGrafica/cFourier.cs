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
        public void Fourier(float x , out double fou)
        {
            double ak, bk, sumF=0, real;
            int n=0;
            double c = 1;

            do
            {
                n += 1;
                ak = (3 / 6) * (0 + 4 * f(1.5) * Math.Sin(n*3.14*(1.5/3)) + f(3) * Math.Sin(n*3.14) );
                ak*=(2/3);
                bk = (3 / 6) * (0 + 4 * g(1.5) * Math.Sin(n * 3.14 * (1.5/3)) + g(3) * Math.Sin(n * 3.14));
                bk *= 2 / (n * 3.14 * c);
                sumF += (ak * Math.Cos(n * (3.14 * c * t)/3) + bk * Math.Sin(n * (3.14 * c * t)/3)) * Math.Sin(n * 3.14 * (x / 3));


            }while (n<=20);
             fou=sumF;
        }
        
        public double f(double n)
        {
            return n;
        }
        public double g(double n)
        {
            return n;
        }
    }
}
