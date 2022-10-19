using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace AppGrafica
{
    public partial class Form1 : Form
    {
        public static int width = 700, height = 500;

        //bitmap
        Bitmap bmp = new Bitmap(width, height);
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp.SetPixel(100, 100, Color.FromArgb(44, 62, 80));
            bmp.SetPixel(100, 101, Color.FromArgb(44, 62, 80));
            bmp.SetPixel(101, 100, Color.FromArgb(44, 62, 80));
            bmp.SetPixel(101, 101, Color.FromArgb(44, 62, 80));

            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 700; x++)
            {

                for (int y = 0; y < 500; y++)
                {
                    if (x < 350)
                        bmp.SetPixel(x, y, Color.FromArgb(44, 62, 80));
                    else
                        bmp.SetPixel(x, y, Color.FromArgb(133, 146, 158));

                }
            }
            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int red1 = 44, green1 = 62, blue1 = 80;
            int red2 = 133, green2 = 146, blue2 = 158;
            int red, green, blue;

            for (int x = 0; x < 700; x++)
            {
                red = (int)lagrange(x, red1, red2);
                green = (int)lagrange(x, green1, green2);
                blue = (int)lagrange(x, blue1, blue2);

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }

            }

            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private int lagrange(int x, int inicial, int final)
        {
            return ((inicial * (x - 700)) / -700) + ((final * x) / 700);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Segmento objSeg = new Segmento();
            Circunferencia objCir = new Circunferencia();
           
            objSeg.x0 = -5;
            objSeg.y0 = 3;
            objSeg.xf = 2;
            objSeg.yf = -3;
            objSeg.color = Color.Red;
            objSeg.Encender(bmp);

            objSeg.x0 = -5;
            objSeg.y0 = -3;
            objSeg.xf = 2;
            objSeg.yf = 3;
            objSeg.color = Color.Black;
            objSeg.Encender(bmp);


            objSeg.x0 = -3;
            objSeg.y0 = -3;
            objSeg.xf = -3 ;
            objSeg.yf = 3;
            objSeg.color = Color.Blue;
            objSeg.Encender(bmp);

            //CIRCULOS
            objCir.rd = 0.3;
            objCir.x0 = -2.5;
            objCir.color = Color.DarkGreen;
            objCir.Encender(bmp);

            objCir.rd = 0.6;
            objCir.x0 = -1.4;
            objCir.y0 = 1;
            objCir.color = Color.YellowGreen;
            objCir.Encender(bmp);


            objCir.rd = 1;
            objCir.x0 = 1;
            objCir.y0 = 0;
            objCir.color = Color.Red;
            objCir.Encender(bmp);

            pictureBox1.Image = bmp;
        }

        internal class Vector
        {
            public double x0;
            public double y0;
            public Color color;

            public static int sx1 = 0;
            public static int sy1 = 0;
            public static int sx2 = 700;
            public static int sy2 = 500;

            private double x1 = -7, x2 = 5;
            private double y1 = -5, y2 = 4;

            public Vector()
            {
            }

            public Vector(double x0, double y0, Color color)
            {
                this.x0 = x0;
                this.y0 = y0;
                this.color = color;
            }

            public void setX(double x)
            {
                this.x0 = x;
            }
            public void setY(double y)
            {
                this.y0 = y;
            }

            public double getX()
            {
                return x0;
            }
            public double getY()
            {
                return y0;
            }

            public void Encender(Bitmap canva)
            {
                int sX;
                int sY;

                Pantalla(x0, y0, out sX, out sY);

                if (sX >= 0 && sX < 700 && sY >= 0 && sY < 500)
                {
                    canva.SetPixel(sX, sY, this.color);
                }
            }


            public void Pantalla(double x, double y, out int sx, out int sy)
            {
                sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
                sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
            }
        }


        internal class Segmento : Vector
        {
            public int xf;
            public int yf;

            public void Encender(Bitmap bmp)
            {
                double t = 0;
                double dt = 0.001;

                Vector obj = new Vector();

                do
                {
                    obj.setX(x0 + (xf - x0) * t);
                    obj.setY(y0 + (yf - y0) * t);
                    obj.color = color;
                    obj.Encender(bmp);
                    t += dt;

                } while (t <= 1);
            }
        }

        internal class Circunferencia: Vector
        {
           
            public double rd;
            
             public void Encender(Bitmap bmp)
            {
                double t = 0;
                double dt = 0.001;

                Vector obj = new Vector();

                do
                {
                    obj.setX(x0 + rd * Math.Cos(t));
                    obj.setY(y0 + rd * Math.Sin(t));
                    obj.color = color;
                    obj.Encender(bmp);
                    t += dt;

                } while (t <= 2* Math.PI);
            }
        }


    }
}