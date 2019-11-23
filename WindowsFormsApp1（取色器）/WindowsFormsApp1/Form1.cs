using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Bitmap zoomBitmap = new Bitmap(20,20);
        Color color1;
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Location.X > 0 && this.Location.X <= pictureBox1.Width && this.Location.Y > 0 && this.Location.Y <= pictureBox1.Height)
            {
                Color color = bitmap.GetPixel(e.X, e.Y);
                label1.Text = "A:" + color.A.ToString() + "  R:" + color.R.ToString() + "  G:" + color.G.ToString() + "  B:" + color.B.ToString();
                label1.Invalidate();
                for (int i = -10; i < 10; i++)
                {
                    for (int j = -10; j < 10; j++)
                    {
                        if (e.X + i > 0 && e.X + i <= pictureBox1.Width)
                        {
                            if (e.Y + j > 0 && e.Y + j <= pictureBox1.Height)
                            {
                                color1 = bitmap.GetPixel(e.X + i, e.Y + j);
                                zoomBitmap.SetPixel(i + 10, j + 10, color1);
                            }
                        }
                        else zoomBitmap.SetPixel(i + 10, j + 10, Color.Transparent);
                    }
                }
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = zoomBitmap;
                pictureBox2.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.BackgroundImage.GetThumbnailImage(pictureBox1.Width,pictureBox1.Height,null,IntPtr.Zero));
        }
    }
}
