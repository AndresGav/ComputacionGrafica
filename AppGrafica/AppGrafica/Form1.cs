using System.Runtime.InteropServices;
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

        //OBJETOS 3D
        SuperficieV objSuV = new SuperficieV();


        //PALETAS TAPETES VARIABLES
        Random rd = new Random();
        int colorT;
        Color c;
        Color[] paleta1 = new Color[16];
        Color[] paleta2 = new Color[16];
        Color[] paleta3 = new Color[16];

        Color[] paletaAgua = new Color[16];

        Color[] paletaE = new Color[16];

        //VARIABLES AUXILIARES
        bool proyectar = false;

        public Form1()
        {
            InitializeComponent();

            //labels
            labelX.Text = "";
            labelY.Text = "";

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

            for(int i = 0; i < 16; i++)
            {
                float x = 2.66f * i + 90;
                paleta2[i] = Color.FromArgb(180, (int)x, 40);
            }

            for (int i = 0; i < 16; i++)
            {
                float x = 2.3f * i + 220;
                paleta3[i] = Color.FromArgb((int)x, (int)x, (int)x);
            }

            //PALETA AGUA
            for (int i = 0; i < 16; i++)
            {
                float r = 14.33f * i + 4;
                float g = 11.66f * i + 69;
                float b = 5.6f * i + 153;
                paletaAgua[i] = Color.FromArgb((int)r, (int)g, (int)b);
            }


            //PALETA E 
            for (int i = 0; i < 16; i++)
            {
                float r = 8.66f * i + 100;
                float g = 8.66f * i + 100;
                float b = 7.66f * i + 105;
                paleta3[i] = Color.FromArgb((int)r, (int)g, (int)b);
            }
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
            proyectar = false;
            pictureBox1.Image = null;
            bmp = new Bitmap(width, height);

            //labels
            labelX.Text = "";
            labelY.Text = "";

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
        
           
        }

        private void axonometriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector3D obj3D = new Vector3D();

            obj3D.x0 = 0;
            obj3D.y0 = 0;
            obj3D.z0 = 0;
            obj3D.color = Color.Red;
            double t = 0;

            do
            {
                obj3D.setX(t-5 +Math.Sin(t));
                obj3D.setY( Math.Cos(t)-t+10);
                obj3D.setZ(2);

                obj3D.Encender(bmp);

                t += 0.002;

            } while (t <= 100);


            
            /*obj3D.color = Color.Purple;
            t = 0;

            do
            {
                obj3D.setX(.5 * Math.Sin(t));
                obj3D.setY( 3+  Math.Cos(t*2));
                obj3D.setZ((t / 30) );

                obj3D.Encender(bmp);

                t += 0.002;

            } while (t <= 200);

        
            obj3D.color = Color.Black;
            t = 1;

            do
            {
                obj3D.setX(Math.Sin(t+3));
                obj3D.setY(1-Math.Cos(t));
                obj3D.setZ(t);

                obj3D.Encender(bmp);

                t += 0.002;

            } while (t <= 100);
            */


            pictureBox1.Image = bmp;
        }

        private void segmento3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento3D obj = new Segmento3D();
            obj.color = Color.Red;

            //EJE X
            obj.x0 = 0; obj.xf = 0;
            obj.y0 = 0; obj.yf = 0;
            obj.z0 = 0; obj.zf = 4;
            obj.Encender(bmp);

            //EJE Y
            obj.x0 = 0; obj.xf = 8;
            obj.y0 = 0; obj.yf = 0;
            obj.z0 = 0; obj.zf = 0;
            obj.Encender(bmp);

            //EJE Z
            obj.x0 = 0; obj.xf = 0;
            obj.y0 = 0; obj.yf = 5;
            obj.z0 = 0; obj.zf = 0;
            obj.Encender(bmp);

            obj.color = Color.LightGray;
            //EJE 4
            obj.x0 = 0; obj.xf = 0;
            obj.y0 = 0; obj.yf = 5;
            obj.z0 = 4; obj.zf = 4;
            obj.Encender(bmp);

            //EJE 5
            obj.x0 = 0; obj.xf = 0;
            obj.y0 = 5; obj.yf = 5;
            obj.z0 = 0; obj.zf = 4;
            obj.Encender(bmp);


            //EJE 6
            obj.x0 = 0; obj.xf = 8;
            obj.y0 = 5; obj.yf = 5;
            obj.z0 = 0; obj.zf = 0;
            obj.Encender(bmp);

            //EJE 7
            obj.x0 = 8; obj.xf = 8;
            obj.y0 = 0; obj.yf = 5;
            obj.z0 = 0; obj.zf = 0;
            obj.Encender(bmp);

            //EJE 8
            obj.x0 = 8; obj.xf = 8;
            obj.y0 = 0; obj.yf = 0;
            obj.z0 = 0; obj.zf = 4;
            obj.Encender(bmp);

             //EJE 9
             obj.x0 = 0; obj.xf = 8;
             obj.y0 = 0; obj.yf = 0;
             obj.z0 = 4; obj.zf = 4;
             obj.Encender(bmp);


            /* //EJE 10
             obj.x0 = 8; obj.xf = 8;
             obj.y0 = 5; obj.yf = 5;
             obj.z0 = 0; obj.zf = 4;
             obj.Encender(bmp);


             //EJE 11
             obj.x0 = 0; obj.xf = 8;
             obj.y0 = 5; obj.yf = 5;
             obj.z0 = 4; obj.zf = 4;
             obj.Encender(bmp);

             //EJE 12
             obj.x0 = 8; obj.xf = 8;
             obj.y0 = 0; obj.yf = 5;
             obj.z0 = 4; obj.zf = 4;
             obj.Encender(bmp);*/




            pictureBox1.Image = bmp;
        }

        private void tipo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tipo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tipo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuperficieR obj = new SuperficieR();
            obj.tipo = 1;
            obj.Fv = 0.15f;
            
            obj.Encender(bmp, Color.Black);

            pictureBox1.Image = bmp;

        }

        private void tipo1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            objSuV.tipo = 1;
            objSuV.rd = 0.5f;
            objSuV.setX( 1);
            objSuV.setY( 4);
            objSuV.setZ(0);

            objSuV.Encender(bmp, Color.Blue);

            pictureBox1.Image = bmp;
        }

        private void tipo2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            objSuV.tipo = 2;
            objSuV.rd = 1.5f;
            objSuV.setX(1);
            objSuV.setY(4);
            objSuV.setZ(0);

            objSuV.Encender(bmp, Color.Red);

            pictureBox1.Image = bmp;
        }

        private void correcionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void tipo2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //PARABOLOIDE HIPERBOLICO
            SuperficieR obj = new SuperficieR();
            obj.tipo = 2;
            obj.Fv = 0.1f;
            obj.z0 = 3;
            obj.Encender(bmp, Color.Black);

            pictureBox1.Image = bmp;
        }

       async private void animacionToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void parcialIIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objSuV.tipo = 3;
            objSuV.rd = 1f;
            objSuV.setX(1);
            objSuV.setY(0.5);
            objSuV.setZ(1);

            objSuV.Encender(bmp, Color.Red);

            pictureBox1.Image = bmp;
        }

        private void tipo4HiperboloiddeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objSuV.tipo = 4;
            objSuV.a = 0.8;
            objSuV.b = 0.8;
            objSuV.c = 0.8;
            objSuV.setX(-.5);
            objSuV.setY(0.8);
            objSuV.setZ(0);

            objSuV.Encender(bmp, Color.Red);

            pictureBox1.Image = bmp;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

          

  

        }

        private void tipo1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                
           
                    colorT = (int)(((i - 100 * (Math.Sin(i) - 700)) / -700 * -.2) + ((0.8 * j - i) / 700)) % 13; 

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(0, 15);
                    }

                    c = paleta1[colorT];

                    bmp.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = bmp;
        }

        private void tipo2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
            
               
                    colorT = (int)((i * j + i * j) + (i * j + i * j) * 0.2 + 1) % 10; ;

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(0, 15);
                    }

                    c = paleta1[colorT];

                    bmp.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = bmp;
        }

        private void tipo3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
               
                    colorT = (int)((i * i + j * j) + (i * i + j * j)) % 15;

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(0, 15);
                    }

                    c = paleta1[colorT];

                    bmp.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = bmp;
        }

        private void tipo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
               
                    
                    colorT = (int)((i * i + j * j) + (i * i + j * j) - (i * i + j * j) * (i * i + j * j)) % 15;

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(15, 15);
                    }

                    c = paleta1[colorT];

                    bmp.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = bmp;
        }

        private void tipo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(Math.Abs(Math.Sin(j + 10) * Math.Cos(i + 10)) * i * 0.1) % rd.Next(15, 15);

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(0, 15);
                    }

                    c = paleta1[colorT];

                    bmp.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = bmp;
        }

        private void tipo6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            float  x = 0;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    //i*j * j*i + i * j * j * i
                    //(int)( Math.PI + x * j ) % 15; 
                    colorT = (int)( Math.PI + x * j + i ) % 3; 


                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(15, 15);
                    }

                    c = paleta1[colorT];

                    bmp.SetPixel(i, j, c);

                    //x += MathF.PI ;
                }
                x += MathF.PI *0.8f;
            }

            pictureBox1.Image = bmp;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

           

            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {



        }

        private void aguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                    colorT = (int)((i * i + j * j) * (i * i + j * j) + i * .69 + j + 100) % 4;

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(5, 10);
                    }

                    c = paletaAgua[colorT];

                    bmp.SetPixel(i, j, c);


                }

            }

            pictureBox1.Image = bmp;
        }

        private void hieloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                    colorT = (int)(Math.E * (i / 2) + Math.PI * (Math.Pow(j, 2)) + j * i) % 6;

                    if (colorT > 15 || colorT < 0)
                    {
                        colorT = rd.Next(15, 15);
                    }

                    c = paleta3[colorT];

                    bmp.SetPixel(i, j, c);


                }

            }

            pictureBox1.Image = bmp;
        }

        async private void button1_Click_4(object sender, EventArgs e)
        {
           


      
        }

        async private void button3_Click_3(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (proyectar)
            {
                int sx1 = 0;
                int sy1 = 0;
                int sx2 = 700;
                int sy2 = 500;

                double x1 = -7, x2 = 7;
                double y1 = -5, y2 = 5;

                void init(double sx, double sy, out double x, out double y)
                {
                    x = ((x1 - x2) * (sx - sx1) / (sx1 - sx2)) + x1;
                    y = ((y2 - y1) * (sy - sy1) / (sy1 - sy2)) + y2;
                }
                double x, y;
                objCir.rd = 0.3;
                objCir.color = Color.DarkBlue;

                init(e.X, e.Y, out x, out y);

                objCir.x0 = (x);
                objCir.y0 = (y);
                objCir.Encender(bmp);



                //SEGMENTO
                Segmento s = new Segmento();
                s.color = Color.Yellow;
                s.x0 = x;
                s.y0 = y;
                double хFinal = x;
                double yfinal = -(((x + 7) * (x - 7)) / 18);
                s.xf = хFinal;
                s.yf = yfinal;
                s.Encender(bmp);

                pictureBox1.Image = bmp;


                //REBOTE
                Segmento sr = new Segmento();
                sr.color = Color.Yellow;
                sr.x0 = x;
                sr.y0 = y;
                хFinal = x;
                yfinal = -(((x + 7) * (x - 7)) / 18);
                sr.xf = хFinal;
                sr.yf = yfinal;
                sr.Encender(bmp);


                double xp = хFinal;
                double yp = yfinal;
                //int m = 
                Segmento segr = new Segmento();
                segr.x0 = xp;
                segr.y0 = yp;
                segr.color = Color.Red;


                if (xp < 0)
                {
                    segr.xf = 7;
                    segr.yf = (9 / xp) * (7 - xp) + yp;
                }
                else
                {
                    segr.xf = -7;
                    segr.yf = (9 / xp) * (-7 - xp) + yp;
                }

                segr.Encender(bmp);




                //dibujar
                pictureBox1.Image = bmp;


                //labels
                labelX.Text = (x).ToString();
                labelY.Text = (y).ToString();
            }
            
        }

        async private void animacionParabolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float x = -5;
            objCir.rd = 0.8;
            objCir.color = Color.DarkBlue;
            objCir.y0 = 0;



            pictureBox1.Image = bmp;

            Vector vec = new Vector();
            vec.color = Color.Red;
            double t = -8, dt = 0.0001;

            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (12 * t) + 32);
                vec.Encender(bmp);
                t = t + dt;
            } while (t <= -4);

            t = -4;
            do
            {
                vec.x0 = t;
                vec.y0 = (-Math.Pow(t, 2) - (4 * t)) / 1.3;
                vec.Encender(bmp);
                t = t + dt;
            } while (t <= 0);
            t = 0;
            do
            {
                vec.x0 = t;
                vec.y0 = (-Math.Pow(t, 2) + (4 * t)) / 1.8;
                vec.Encender(bmp);
                t = t + dt;
            } while (t <= 4);
            t = 4;
            do
            {
                vec.x0 = t;
                vec.y0 = (-Math.Pow(t, 2) + (12 * t) - 32) / 3;
                vec.Encender(bmp);
                t = t + dt;

            } while (t <= 8);

            pictureBox1.Image = bmp;

            //ANIMACION 1
            x = -5;
            objCir.rd = 0.3;
            objCir.color = Color.DarkBlue;
            objCir.y0 = 0;
            t = -8;
            do
            {
                objCir.x0 = t;
                objCir.y0 = -(Math.Pow(t, 2) + (12 * t) + 32);

                objCir.Encender(bmp);
                pictureBox1.Image = bmp;

                await Task.Delay(100);

                objCir.Apagar(bmp);
                pictureBox1.Image = bmp;


                t += 0.2f;

            } while (t <= -4);

            pictureBox1.Image = bmp;

            //ANIMACION 2
            x = -5;
            objCir.rd = 0.3;
            objCir.color = Color.DarkBlue;
            objCir.y0 = 0;
            t = -4;
            do
            {
                objCir.x0 = t;
                objCir.y0 = (-Math.Pow(t, 2) - (4 * t)) / 1.3;

                objCir.Encender(bmp);
                pictureBox1.Image = bmp;

                await Task.Delay(100);

                objCir.Apagar(bmp);
                pictureBox1.Image = bmp;


                t += 0.2f;

            } while (t <= 0);

            pictureBox1.Image = bmp;

            //ANIMACION 3
            x = -5;
            objCir.rd = 0.3;
            objCir.color = Color.DarkBlue;
            objCir.y0 = 0;
            t = 0;
            do
            {
                objCir.x0 = t;
                objCir.y0 = (-Math.Pow(t, 2) + (4 * t)) / 1.8;

                objCir.Encender(bmp);
                pictureBox1.Image = bmp;

                await Task.Delay(100);

                objCir.Apagar(bmp);
                pictureBox1.Image = bmp;


                t += 0.2f;

            } while (t <= 4);

            pictureBox1.Image = bmp;


            //ANIMACION 4
            x = -5;
            objCir.rd = 0.3;
            objCir.color = Color.DarkBlue;
            objCir.y0 = 0;
            t = 4;
            do
            {
                objCir.x0 = t;
                objCir.y0 = (-Math.Pow(t, 2) + (12 * t) - 32) / 3;

                objCir.Encender(bmp);
                pictureBox1.Image = bmp;

                await Task.Delay(100);

                objCir.Apagar(bmp);
                pictureBox1.Image = bmp;


                t += 0.2f;

            } while (t <= 8);

            pictureBox1.Image = bmp;
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
           
        }

        private void proyeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proyectar = true;

            Vector vec = new Vector();
            vec.color = Color.Yellow;
            double x = -7, dx = 0.001;

            do
            {
                vec.x0 = x;
                vec.y0 = -(((x - 7) * (x + 7)) / 18);
                vec.Encender(bmp);
                x = x + dx;
            } while (x <= 7);


            pictureBox1.Image = bmp;
        }

        async private void button3_Click_4(object sender, EventArgs e)
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



            // animación
            double t = 0.05;
            double r = 4;
            do
            {
                c3.x0 = 0 + r * (double)Math.Cos(t);
                c3.y0 = 0 + r * (double)Math.Sin(t);
                c3.color = Color.Orange;
                c3.Encender(bmp);
                pictureBox1.Image = bmp;

                // wait
                await Task.Delay(100);

                c3.Apagar(bmp);
                pictureBox1.Image = bmp;
                t += 0.1;



            } while (t <= (2 * Math.PI)); */
        }

        async private void button4_Click_2(object sender, EventArgs e)
        {
          
            
        }

        async private void button3_Click_5(object sender, EventArgs e)
        {
            
        }

         async private void correccionParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia c2 = new Circunferencia();
            c2.x0 = 2;
            c2.y0 = 1;
            c2.rd = 2;
            c2.color = Color.Blue;
            c2.Encender(bmp);
            pictureBox1.Image = bmp;
            Circunferencia c3 = new Circunferencia();
            c3.rd = 0.4;



            // animación
            objSeg.x0 = 2;
            objSeg.y0 = 1;
            objSeg.color = Color.Orange;

            double t = 0.05;
            double r = 1.5;
            do
            {
                objSeg.xf = 2 + r * (double)Math.Sin(t);
                objSeg.yf = 1 + r * (double)Math.Cos(t);

                objSeg.Encender(bmp);
                pictureBox1.Image = bmp;

                // wait
                await Task.Delay(100);

                objSeg.Apagar(bmp);
                pictureBox1.Image = bmp;
                t += 0.1;


            } while (t <= (2 * Math.PI));
        }

        async private void examenParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia c2 = new Circunferencia();
            c2.x0 = -3;
            c2.y0 = -2.5;
            c2.rd = 2;
            c2.color = Color.Blue;
            c2.Encender(bmp);
            pictureBox1.Image = bmp;
            Circunferencia c3 = new Circunferencia();
            c3.rd = 0.4;



            // animación
            objSeg.x0 = -3;
            objSeg.y0 = -2.5;
            objSeg.color = Color.Orange;

            double t = 0.05;
            double r = 1.5;
            do
            {
                objSeg.xf = 0 + r * (double)Math.Sin(t) - 3;
                objSeg.yf = 0 + r * (double)Math.Cos(t) - 2.5;

                objSeg.Encender(bmp);
                pictureBox1.Image = bmp;

                // wait
                await Task.Delay(100);

                objSeg.Apagar(bmp);
                pictureBox1.Image = bmp;
                t += 0.1;


            } while (t <= (2 * Math.PI));
        }

        private void ondasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda objO = new Onda();

            objO.t = 0;
            objO.w = 1.5;
            objO.v = 9.3;
            objO.Interferencia(bmp);

            pictureBox1.Image = bmp;
        }

        async private void animacionOndasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* double t = 0;
             Onda objO = new Onda();
             objO.w = 1.5;
             objO.v = 9.3;
             objO.t = 0;
             objO.GrafO(bmp);
             pictureBox1.Image = bmp;*/

             double t = 0;
             Onda objO = new Onda();
             objO.w = 1.5;
             objO.v = 9.3;
             objO.t = t;
             do
             {
                 objO.Interferencia(bmp);
                 t += 0.02;
                 objO.t = t;
                 await Task.Delay(100);
                 pictureBox1.Image = bmp;

             }while (t <= 6 * Math.PI);
            

        }

        private void onda3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda3D objO = new Onda3D();

            /*objO.t = 0;
            objO.w = 3;
            objO.v = 9.8;
            objO.m = 0.4;*/
           
            objO.Interferencia3F(bmp, Color.Gainsboro);

            pictureBox1.Image = bmp;
        }

        async private void animacion3D1FuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda3D objO = new Onda3D();
            double t = 0;
           
            do
            {
                objO.Encender(bmp,Color.Red);
                
                await Task.Delay(100);
                pictureBox1.Image = bmp;
                objO.Encender(bmp, Color.Gainsboro);
                pictureBox1.Image = bmp;
                t += 0.02;
                objO.t = t;

            } while (t <= 6 * Math.PI);

   

        }

        async private void animacion3D2FuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda3D objO = new Onda3D();
            double t = 0;

            do
            {
                objO.Interferencia2F(bmp, Color.Red);

                await Task.Delay(100);
                pictureBox1.Image = bmp;
                objO.Interferencia2F(bmp, Color.Gainsboro);
                pictureBox1.Image = bmp;
                t += 0.02;
                objO.t = t;

            } while (t <= 6 * Math.PI);
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {

        }




    }
}