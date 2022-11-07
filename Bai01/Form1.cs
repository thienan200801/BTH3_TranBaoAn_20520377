using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prob1.WriteLine("Load event");
            MessageBox.Show("Load event");
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            prob1.WriteLine("Move event");
            MessageBox.Show("Move event");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            prob1.WriteLine("Activated event");
            MessageBox.Show("Activated event");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            prob1.WriteLine("VisibleChanged event");
            MessageBox.Show("VisibleChanged event");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            prob1.WriteLine("Shown event");
            MessageBox.Show("Shown event");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            prob1.WriteLine("MouseClick event");
            MessageBox.Show("MouseClick event");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            prob1.WriteLine("Paint event");
            MessageBox.Show("Paint event");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            prob1.WriteLine("FormClosed event");
            MessageBox.Show("FormClosed event");
        }
    }
}
