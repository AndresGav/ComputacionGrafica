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
    }
}