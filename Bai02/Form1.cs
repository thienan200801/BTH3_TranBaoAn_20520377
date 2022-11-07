using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Bai02
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }
        string content = "Hello world";
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        private void drawText(int X, int Y)
        {
            Bitmap bm = new Bitmap(600, 400);
            Graphics g = Graphics.FromImage(bm);
            Font f = new Font("Arial", 25, FontStyle.Bold);
            g.DrawString(content, f, Brushes.Red, X, Y);
            this.pic.Image = bm;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            drawText(x, y);
        }

    }
}
