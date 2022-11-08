using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace AppGrafica
{
    public partial class Form1 : Form
    {
        public static int width = 700, height = 500;
        Bitmap bmp = new Bitmap(width, height);

        //objetos para dibujar
        Segmento objSeg = new Segmento();
        Circunferencia objCir = new Circunferencia();
        Test obj = new Test();
        Lazo objLazo = new Lazo();
        Margarita objMarga = new Margarita();
        gFunciones objFun = new gFunciones();
        Parabola objPara = new Parabola();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = null;
            bmp = new Bitmap(width, height);

        }

        private int lagrange(int x, int inicial, int final, int xinicial, int xfinal )
        {

            return ((inicial * (x - 700)) / -700) + ((final * x) / 700);
        }

 
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void gFunciones_Click(object sender, EventArgs e)
        {
            


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void encerderPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp.SetPixel(100, 100, Color.FromArgb(44, 62, 80));
            bmp.SetPixel(100, 101, Color.FromArgb(44, 62, 80));
            bmp.SetPixel(101, 100, Color.FromArgb(44, 62, 80));
            bmp.SetPixel(101, 101, Color.FromArgb(44, 62, 80));

            pictureBox1.Image = bmp;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void degradarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int red1 = 44, green1 = 62, blue1 = 80;
            int red2 = 133, green2 = 146, blue2 = 158;
            int red, green, blue;

            for (int x = 0; x < 700; x++)
            {
                red = (int)lagrange(x, red1, red2,0,0);
                green = (int)lagrange(x, green1, green2,0,0);
                blue = (int)lagrange(x, blue1, blue2,0,0);

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }

            }

            pictureBox1.Image = bmp;
        }

        private void parabolaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            objPara.Encender(bmp);
            pictureBox1.Image = bmp;
        }

        private void lazoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            objLazo.x0 = 0;
            objLazo.y0 = 0;
            objLazo.rd = 1;
            objLazo.color = Color.Red;
            objLazo.Encender(bmp);

            pictureBox1.Image = bmp;
        }

        private void encenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objLazo.x0 = -4;
            objLazo.y0 = 1;
            objLazo.rd = 1.3;
            objLazo.color = Color.DarkBlue;
            objLazo.Encender(bmp);

            objMarga.x0 = 0;
            objMarga.y0 = 0;
            objMarga.rd = 1;
            objMarga.color = Color.Red;
            objMarga.Encender(bmp);

            pictureBox1.Image = bmp;
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objLazo.Apagar(bmp);
            pictureBox1.Image = bmp;

            
        }

        private void animacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.picture = pictureBox1;
            obj.x0 = 0;
            obj.y0 = 0;
            obj.color = Color.Red;
            obj.Encender(bmp);

            pictureBox1.Image = bmp;
        }

        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objMarga.x0 = -1;
            objMarga.y0 = 3;
            objMarga.rd = 0.3;
            objMarga.color = Color.Red;
            objMarga.Encender(bmp);


            objMarga.x0 = 2;
            objMarga.y0 = 1;
            objMarga.rd = 1.3;
            objMarga.color = Color.Brown;
            objMarga.Encender(bmp);


            objLazo.x0 = -4;
            objLazo.y0 = 1;
            objLazo.rd = 1.3;
            objLazo.color = Color.DarkBlue;
            objLazo.Encender(bmp);

            objLazo.x0 = -1;
            objLazo.y0 = -3;
            objLazo.rd = 0.6;
            objLazo.color = Color.Red;
            objLazo.Encender(bmp);

            objLazo.x0 = -1;
            objLazo.y0 = 1;
            objLazo.rd = 2;
            objLazo.color = Color.Green;
            objLazo.Encender(bmp);
            objMarga.x0 = -1;
            objMarga.y0 = -1;
            objMarga.rd = 2;
            objMarga.color = Color.Purple;
            objMarga.Encender(bmp);


            objCir.rd = 1;
            objCir.x0 = -1;
            objCir.y0 = 1;
            objCir.color = Color.DarkGreen;
            objCir.Encender(bmp);

            pictureBox1.Image = bmp;
        }

        private void graficoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
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
            objSeg.xf = -3;
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

        private void gFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objFun.color = Color.DarkGreen;
            objFun.Encender(bmp);




            objSeg.x0 = -7;
            objSeg.y0 = 0;
            objSeg.xf = 7;
            objSeg.yf = 0;
            objSeg.color = Color.Black;
            objSeg.Encender(bmp);


            objSeg.x0 = 0;
            objSeg.y0 = -5;
            objSeg.xf = 0;
            objSeg.yf = 5;
            objSeg.color = Color.Black;
            objSeg.Encender(bmp);



            pictureBox1.Image = bmp;
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        async private void button1_Click_1(object sender, EventArgs e)
        {
            float x = -5;
            objLazo.rd = 0.8;
            objLazo.color = Color.DarkBlue;
            objLazo.y0 = 0;

            do
            {
                objLazo.x0 = x;
                objLazo.y0 = -Math.Sin(objLazo.x0);

                objLazo.Encender(bmp);
                pictureBox1.Image = bmp;

                await Task.Delay(100);

                objLazo.Apagar(bmp);
                pictureBox1.Image = bmp;


                x += 0.2f;

            } while (x < 5);

            pictureBox1.Image = bmp;

        }

        async private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Circunferencia c = new Circunferencia();
            c.x0 = 0;
            c.y0 = 0;
            c.rd = 3;
            c.color = Color.Red;
            c.Encender(bmp);
            pictureBox1.Image = bmp;
            Circunferencia c2 = new Circunferencia();
            c2.x0 = 0;
            c2.y0 = 0;
            c2.rd = 5;
            c2.color = Color.Blue;
            c2.Encender(bmp);
            pictureBox1.Image = bmp;
            Circunferencia c3 = new Circunferencia();
            c3.rd = 0.4;
            c3.color = Color.Orange;

            // animacion
            double t = 0.05;
            double r = 4;

            do
            {
                c3.x0 = 0 + r * (double)Math.Cos(t);
                c3.y0 = 0 + r * (double)Math.Sin(t);
                
                c3.Encender(bmp);
                pictureBox1.Image = bmp;

                // esperar
                await Task.Delay(100);

                // apagar
                c3.Apagar(bmp);
                pictureBox1.Image = bmp;

                t += 0.1;

            } while (t <= Math.PI * 2);
            */
            int red1 = 44, green1 = 62, blue1 = 80;
            int red2 = 255, green2 = 255, blue2 = 255;
            int red, green, blue;

            for (int x = 0; x < 1; x++)
            {
                red = (int)lagrange(x, red1, red2,0,0);
                green = (int)lagrange(x, green1, green2,0,0);
                blue = (int)lagrange(x, blue1, blue2,0,0);

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }

            }

            red1 = 255; green1 = 255; blue1 = 255;
            red2 = 44; green2 = 62; blue2 = 80;


            for (int x = 350; x <700; x++)
            {
                red = (int)lagrange(x, red1, red2,0,0);
                green = (int)lagrange(x, green1, green2,0,0);
                blue = (int)lagrange(x, blue1, blue2,0,0);

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }

            }

            pictureBox1.Image = bmp;
        }

        private void planoCartesianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objSeg.x0 = -7;
            objSeg.y0 = 0;
            objSeg.xf = 7;
            objSeg.yf = 0;
            objSeg.color = Color.Black;
            objSeg.Encender(bmp);


            objSeg.x0 = 0;
            objSeg.y0 = -5;
            objSeg.xf = 0;
            objSeg.yf = 5;
            objSeg.color = Color.Black;
            objSeg.Encender(bmp);



            pictureBox1.Image = bmp;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        
            double red, green, blue;

            for (int x = 0; x < 350; x++)
            {
                red = ((0.4428 * x) + 100);
                green = ((0.4428 * x) + 100);
                blue = ((0.3 * x) + 150);

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb((int)red, (int)green, (int)blue));
                }

            }

            for (int x = 350; x < 700; x++)
            {
                red = ((-0.4428 * x) + 410);
                green = ((-0.4428 * x) + 410);
                blue = ((-0.3 * x) + 360);

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb((int)red, (int)green, (int)blue));
                }

            }



            /*for (int x = 350; x < 700; x++)
            {
                red = (int)-0.44 * x + 410;
                green = (int)-0.44 * x + 410;
                blue = (int)-0.33 * x + 360;

                for (int y = 0; y < 500; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }

            }*/



            pictureBox1.Image = bmp;
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {

        }




    }
}