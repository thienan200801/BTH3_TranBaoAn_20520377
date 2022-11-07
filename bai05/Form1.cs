using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            no1.Text = "2";
            no2.Text = "3";
        }
        int choice = 0;
        private void divide_Click(object sender, EventArgs e)
        {
            choice = 3;
            Calculate(choice);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            choice = 0;
            Calculate(choice);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            choice = 1;
            Calculate(choice);
        }

        private void times_Click(object sender, EventArgs e)
        {
            choice = 2;
            Calculate(choice);
        }
        private void Calculate(int x)
        {
            double num1 = double.Parse(no1.Text);
            double num2 = double.Parse(no2.Text);
            double res = 0;
            switch (x)
            {
                case 0:
                    res = num1 + num2;
                    break;
                case 1:
                    res = num1 - num2;
                    break;
                case 2:
                    res = num1 * num2;
                    break;
                case 3:
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                    }
                    else MessageBox.Show("Cannot divided by 0");
                    break;
                default: MessageBox.Show("Choose a button");
                    break;
            }
            ans.Text = res.ToString();
        }
    }
}
