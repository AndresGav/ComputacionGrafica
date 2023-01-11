using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Onda3D: Vector3D
    {
        public double t; 
        public void Encender(Bitmap bmp, Color selectColor)
        {
            Vector3D v3d = new Vector3D();
            v3d.color = Color.Black;
            double x, y, z, d, m, w, v;
            x = -9;
            m = 0.7;
            w = 1.5;
            v = 9.8;
           
            do
            {
                y = -6.5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color = selectColor;
                    d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 0), 2))));
                    z = w * (d - v * t);
                    v3d.z0 = m * Math.Sin(z);
                    v3d.Encender(bmp);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }

        public void Interferencia2F(Bitmap bmp, Color selectColor)
        {
            double x, y, z1, z2, d1, d2,w,d,v,m;
            x = -9;
            m = 0.7;
            w = 1.5;
            v = 9.8;
           

            x =-9;

            Vector3D v3d = new Vector3D();
            v3d.color = Color.Black;

            do
            {
                y = -6.5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color = selectColor;
                    d1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    d2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));

                    z1 = w * (d1 - v * t);
                    z2 = w * (d2 - v * t);

                    v3d.z0 = (m * Math.Sin(z1)) + (m * Math.Sin(z2));
                    v3d.Encender(bmp);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }


        public void Interferencia3F(Bitmap bmp, Color selectColor)
        {
            double x, y, z1, z2,z3, d1, d2,d3, w, d, v, m;
            x = -9;
            m = 0.7;
            w = 1.5;
            v = 9.8;
            

            x = -9;

            Vector3D v3d = new Vector3D();
            v3d.color = Color.Black;

            do
            {
                y = -6.5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color = selectColor;
                    d1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    d2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    d3 = (Math.Sqrt((Math.Pow((x + 5), 2)) + (Math.Pow((y + 1), 2))));

                    z1 = w * (d1 - v * t);
                    z2 = w * (d2 - v * t);
                    z3 = w * (d3 - v * t);

                    v3d.z0 = (m * Math.Sin(z1)) + (m * Math.Sin(z2)) + (m * Math.Sin(z3));
                    v3d.Encender(bmp);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }

    
    }


}
