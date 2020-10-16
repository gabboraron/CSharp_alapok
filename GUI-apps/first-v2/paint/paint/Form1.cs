using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024,720);
        Pen p = new Pen(Color.Black, 5);

        bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3 , 1);
                pictureBox1.Image = bmp;
            }
        }

        private void btnBlue(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void btnRed(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void btnGreen(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void btnOrange(object sender, EventArgs e)
        {
            p.Color = Color.Orange;
        }

        private void btnBlack(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Jpeg Image|* jpg| Bitmap Image *. bmp| PNG Image|*. png|";
            sfd.Title = "Kép mentése...";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();

                switch (sfd.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }
    }
}
