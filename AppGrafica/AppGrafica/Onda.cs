using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Onda: Vector
    {
        public double t,w,v;
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
            
            int i;
            /*for ( i = 0; i < 16; i++)
            {
                float r = 8.66f * i + 100;
                float g = 8.66f * i + 100;
                float b = 7.66f * i + 105;
                paleta1[i] = Color.FromArgb((int)r, (int)g, (int)b);
            }*/

            int j, color;
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

        public void Interferencia(Bitmap bmp)
        {
            int i;
            /*for (i = 0; i < 16; i++)
            {
                float r = 8.66f * i + 100;
                float g = 8.66f * i + 100;
                float b = 7.66f * i + 105;
                paleta1[i] = Color.FromArgb((int)r, (int)g, (int)b);
            }*/
            //
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

            int  j, color0;
            double x, y, z, z1,z2,z3;
            Color c;

            for (i = 0; i < 700; i++)
            {
                for(j = 0; j < 500; j++)
                {
                    Tranformar(i, j, out x, out y);
                    z1= w * (Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3)) - (v * t));
                    z2= w * (Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3)) - (v * t));
                    z3 = w * (Math.Sqrt((x - 4) * (x - 4) + (y + 1) * (y + 1)) - (v * t));
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z1 + z2 + z3;
                    color0 = (int)(z * 2.5); 
                    c= paleta1[color0];
                    bmp.SetPixel(i, j, c);
                }
            }
        }
    }
}
