using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class Vector3D: Vector
    {
        public double z0;

        public Vector3D() { }

        public void setZ(double z)
        {
            this.z0 = z;
        }

        public void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            ax = y - (x / 2) * Math.Cos(0.785);

            ay = z - (x / 2) * Math.Sin(0.785);
        }

        public void Encender(Bitmap canva)
        {
            double ax;
            double ay;
            int sx;
            int sy;

            Axonometria(x0, y0, z0, out ax, out ay);


            Pantalla(ax, ay, out sx, out sy);
           
             if(sx >= 0 && sx <700 && sy >= 0 && sy < 500)
             {
                canva.SetPixel(sx, sy, this.color);
             }
        }
    }
}
