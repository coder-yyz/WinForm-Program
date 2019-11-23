using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image origin;
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //初始化文件打开路径
            openFileDialog.InitialDirectory = "G:\\";  
            openFileDialog.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imgName = openFileDialog.FileName;
                origin = Image.FromFile(imgName);
                //img = img.GetThumbnailImage(openPicture.Width, openPicture.Height, null, IntPtr.Zero);
                openPicture.BackgroundImage = origin;
            }
            
        }
        /// <summary>
        /// 灰化处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGray_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(origin);
            for(int i = 0; i < bitmap.Width; i++)
            {
                for(int j = 0;j< bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;
                    //int gray = (r + b + g) / 3;
                    int gray = (int)(r * 0.299 + g * 0.587 + b * 0.114);
                    Color afterColor = Color.FromArgb(gray, gray, gray);
                    bitmap.SetPixel(i, j, afterColor);
                }
            }
             
            transformPic.BackgroundImage = bitmap;
        }
        /// <summary>
        /// 存储转换后的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Image image = transformPic.BackgroundImage;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //sfd.Filter = "文本文件文件（*.txt）|*.txt|word文件（*.doc）|*.doc";
            saveFileDialog.Filter = "图片文件(*.jpg;*.png)|*.jpg;*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        /// <summary>
        /// 取反处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Invert_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(origin);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;
                     
                    Color afterColor = Color.FromArgb(255-r,255-g,255-b);
                    bitmap.SetPixel(i, j, afterColor);
                }
            }

            transformPic.BackgroundImage = bitmap;
        }
        /// <summary>
        /// 雾化处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRain_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(origin);
            Random random = new Random();
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int dx = i + random.Next() % 19;
                    int dy = j + random.Next() % 19;
                    if (dx >= bitmap.Width - 1)
                    {
                        dx = bitmap.Width - 1;
                    }
                    if (dy >= bitmap.Height - 1)
                    {
                        dy = bitmap.Height - 1;
                    }

                    Color afterColor = bitmap.GetPixel(dx,dy);
                    bitmap.SetPixel(i, j, afterColor);
                }
            }

            transformPic.BackgroundImage = bitmap;
        }
        /// <summary>
        /// 浮雕处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Embossment_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(origin);
            Color pixel1, pixel2;
            for (int i = 0; i < bitmap.Width-1; i++)
            {
                for (int j = 0; j < bitmap.Height-1; j++)
                {
                    pixel1 = bitmap.GetPixel(i, j);
                    pixel2 = bitmap.GetPixel(i + 1, j + 1);
                    int r = 0, g = 0, b = 0;
                    r = Math.Abs(pixel1.R - pixel2.R + 128);
                    g = Math.Abs(pixel1.G - pixel2.G + 128);
                    b = Math.Abs(pixel1.B - pixel2.B + 128);
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;

                    Color afterColor = Color.FromArgb(r,g,b);
                    bitmap.SetPixel(i, j, afterColor);
                }
            }

            transformPic.BackgroundImage = bitmap;
        }

        private void Sharp_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(origin);
            Color pixel;
            //拉普拉斯模板
            int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            for (int i = 1; i < bitmap.Width-1; i++)
            {
                for (int j = 1; j < bitmap.Height-1; j++)
                {
                    int r = 0, g = 0, b = 0;
                    int Index = 0;
                    for (int col = -1; col <= 1; col++)
                    {
                        for (int row = -1; row <= 1; row++)
                        {
                            pixel = bitmap.GetPixel(i + row, j + col); r += pixel.R * Laplacian[Index];
                            g += pixel.G * Laplacian[Index];
                            b += pixel.B * Laplacian[Index];
                            Index++;
                        }
                    }
                    //处理颜色值溢出
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    Color afterColor = Color.FromArgb(r,g,b);
                    bitmap.SetPixel(i, j, afterColor);
                }
            }
            transformPic.BackgroundImage = bitmap;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int Height = this.openPicture.BackgroundImage.Height;
                int Width = this.openPicture.BackgroundImage.Width;
                Bitmap bitmap = new Bitmap(Width, Height);
                Bitmap MyBitmap = (Bitmap)this.openPicture.BackgroundImage;
                Color pixel;
                //高斯模板
                int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = MyBitmap.GetPixel(x + row, y + col);
                                r += pixel.R * Gauss[Index];
                                g += pixel.G * Gauss[Index];
                                b += pixel.B * Gauss[Index];
                                Index++;
                            }
                        r /= 16;
                        g /= 16;
                        b /= 16;
                        //处理颜色值溢出
                        r = r > 255 ? 255 : r;
                        r = r < 0 ? 0 : r;
                        g = g > 255 ? 255 : g;
                        g = g < 0 ? 0 : g;
                        b = b > 255 ? 255 : b;
                        b = b < 0 ? 0 : b;
                        bitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                this.transformPic.BackgroundImage = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }
        Image waterMark;
        Graphics g;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            //初始化文件打开路径
            //openFileDialog2.InitialDirectory = "G:\\大三上\\桌面程序设计\\水印";
            openFileDialog2.Filter = "图片文件(*.png)|*.png";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string imgName = openFileDialog2.FileName;
                waterMark = Image.FromFile(imgName).GetThumbnailImage(200, 200, null, IntPtr.Zero);
            }
            else return;
            g = Graphics.FromImage(openPicture.BackgroundImage);
            
            g.DrawImage(waterMark, new Point(origin.Width - 200, origin.Height - 200));
            transformPic.BackgroundImage = openPicture.BackgroundImage;
            transformPic.Invalidate();
        }
    }


}
