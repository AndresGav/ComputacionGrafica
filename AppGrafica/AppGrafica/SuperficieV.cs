using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class SuperficieV:Vector3D
    {
        public int tipo;
        public float rd;

        public void Encender(Bitmap canva, Color color)
        {
            switch (tipo)
            {
                case 1:
                    Caso1(canva,color);
                    break;
                 case 2:
                    Caso2(canva, color);
                    break;
            }
        }

        public void Caso1(Bitmap canva, Color color)
        {
            Vector3D v3d = new Vector3D();
            float t = 0, dt = 0.02f;
            v3d.color = color;
            do
            {
                float h = 0, dh = 0.2f;
                do
                {
                    v3d.setX( x0 + rd * Math.Cos(t));
                    v3d.setY( y0 + rd * Math.Sin(t));
                    v3d.setZ ( z0 + h);
                    v3d.Encender(canva);
                    h += dh;
                } while (h <= 2);
                t += dt;
            }while (t <= 2*Math.PI);
        }

        public void Caso2(Bitmap canva, Color color)
        {
            Vector3D v3d = new Vector3D();

            float t = -3.1416f/2f;
            float dt = 0.2f;

            v3d.color = color;


            do
            {
                float h = 0, dh = 0.02f;

                do
                {

                    v3d.setX(x0 + rd * Math.Cos(t) * Math.Cos(h));
                    v3d.setY(y0 + rd * Math.Cos(t) * Math.Sin(h));
                    v3d.setZ(z0 + rd * Math.Sin(t));


                    v3d.Encender(canva);
                    h += dh;

                } while (h <= 2 * Math.PI);

                t += dt;

            } while (t <=  Math.PI/2);
        }
    }
}
