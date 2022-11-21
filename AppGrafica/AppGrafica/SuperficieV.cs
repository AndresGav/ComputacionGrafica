using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class SuperficieV:Vector3D
    {
        public int tipo;
        public float rd;
        public double a,b, c;

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
                case 3:
                    Caso3(canva, color);
                    break;
                case 4:
                    Caso4(canva, color);
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


        public void Caso3(Bitmap canva, Color color)
        {
            Vector3D v3d = new Vector3D();

            float d = 0, dt = 0.10f;

            v3d.color = color;

            do
            {
                float h = 0, dh = 0.011f;

                do
                {
                    v3d.setX(x0 + rd * (3 + Math.Cos(d)) * Math.Cos(h));
                    v3d.setY(y0 + rd * (3 + Math.Cos(d)) * Math.Sin(h) );
                    v3d.setZ(z0 + rd *  Math.Sin(d));
                    v3d.Encender(canva);
                    h += dh;

                } while (h <= 2 * Math.PI);

                d += dt;

            } while (d <= 2 * Math.PI);
        }

        //HIPERBOLOIDO DE UNA HOJA CON FUNCIONES HIPERBOLICA
        // x = a * cosh(u) * cos(v)  ELIPSE xy
        // y = b * cosh(u) * sin(v)  HIPERBOLA xz
        // z = c * sinh(u)           HIPERBOLA yz
        // u desde infinito a infinito
        // v desde 0 a dos PI
        public void Caso4(Bitmap canva, Color color)
        {
            Vector3D v3d = new Vector3D();

            float u = -(3.1416f * 2f), du = 0.050f;

            v3d.color = color;

            do
            {
                float v = 0, dv = 0.011f;

                do
                {
                    v3d.setX(x0 + a * Math.Cosh(u) * Math.Cos(v) );
                    v3d.setY(y0 + b * Math.Cosh(u) * Math.Sin(v));
                    v3d.setZ(z0 + c * Math.Sinh(u));
                    v3d.Encender(canva);
                    v += dv;

                } while (v <= 2 * Math.PI);

                u += du;

            } while (u <= 2 * Math.PI);
        }
    }
}
