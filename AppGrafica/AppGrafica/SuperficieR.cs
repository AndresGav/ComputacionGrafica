using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    internal class SuperficieR: Vector3D
    {
        public float Fv;
        public int tipo;
        public void Encender(Bitmap canva, Color color)
        {
            switch (tipo)
            {
                case 1:
                    Caso1(canva, color);
                    break;
                case 2:
                    Caso2(canva, color);
                    break;

              
            }
        }

        public void Caso1(Bitmap canva, Color color)
        {
            Vector3D v3d = new Vector3D();
            float x = -5, dx = 0.15f;
            v3d.color = color;
            do
            {
                float y = -3.5f, dy = 0.15f;
                do
                {
                    v3d.setX(x);
                    v3d.setY(y);
                    v3d.setZ(Fv * (Math.Pow(x,2) + Math.Pow(y,2))  -2.5f );
                    v3d.Encender(canva);
                    y += dy;

                } while (y <= 3.5f);

                x += dx;

            } while (x <= 5);
        }

        public void Caso2(Bitmap canva, Color color)
        {
            Vector3D v3d = new Vector3D();
            float x = -5, dx = 0.071f;
            v3d.color = color;
            do
            {
                float y = -3.5f, dy = 0.071f;
                do
                {
                    v3d.setX(x0 +x);
                    v3d.setY(y0 + y);
                    v3d.setZ(z0+ Fv * (Math.Pow(y, 2) - Math.Pow(x, 2)  ) - 1f);
                    v3d.Encender(canva);
                    y += dy;

                } while (y <= 3.5f);

                x += dx;

            } while (x <= 5);
        }




    }
}
