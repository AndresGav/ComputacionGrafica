using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Onda: Vector
    {
        public double t;
        Color[] paleta1 = new Color[16];

        public void GrafO(Bitmap bmp)
        {
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int i, j, color;
            double x, y;
            double z;
            Color c;


            for (i = 0; i < 700; i++)
            {
                for( j = 0; j < 500; j++)
                {
                    Tranformar(i, j, out x, out y);
                    z = 1.5 * (Math.Sqrt( ( Math.Pow(x,2)) + (Math.Pow(y, 2))) ) - 9.3 * t;
                    z = Math.Sin(z) + 1;
                    color = (int)(z * 7.5);
                    c = paleta1[color];

                    bmp.SetPixel(i, j, c);
                    
                }
            }
        }
    }
}
