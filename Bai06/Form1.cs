using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double a, b, saveVariable = 0;
        private List<double> lastRest = new List<double>();
        private double Plus(double x, double y)
        {
            return x + y;
        }
        private double Minus(double x, double y)
        {
            return x - y;
        }
        private double Multiply(double x, double y)
        {
            return x * y;
        }
        private bool Divide(double x, double y, out double ans)
        {
            if (y != 0)
            {
                ans = x / y;
                return true;
            }
            else
            {
                ans = 0;
                return false;
            }
        }
        private double SqrtHandle(double x)
        {
            return Math.Sqrt(x);
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "1";
            else resultTxt.Text += Btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "2";
            else resultTxt.Text += Btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "3";
            else resultTxt.Text += Btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "4";
            else resultTxt.Text += Btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "5";
            else resultTxt.Text += Btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "6";
            else resultTxt.Text += Btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "7";
            else resultTxt.Text += Btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "8";
            else resultTxt.Text += Btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "9";
            else resultTxt.Text += Btn9.Text;
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            plusMinus.Visible = true;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") 
            { 
                resultTxt.Text = "0.";
            }
            else resultTxt.Text += BtnDot.Text;
        }

        private void bspBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultTxt.Text == "" || resultTxt.Text == "0") ;
                else resultTxt.Text = resultTxt.Text.Remove(resultTxt.Text.Length - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            int signIndex = 0;
            double ans = 0;
            char sign = ' ';
            for (int i = 0; i < resultTxt.Text.Length; i++)
            {
                if (resultTxt.Text[i] == '+' ||
                    resultTxt.Text[i] == '-' ||
                    resultTxt.Text[i] == '*' ||
                    resultTxt.Text[i] == '/')
                {
                    signIndex = i;
                    sign = resultTxt.Text[i];
                    break;
                }
            }
            a = Double.Parse(resultTxt.Text.Substring(0, signIndex));
            b = Double.Parse(resultTxt.Text.Substring(signIndex + 1));

            if (sign == '+') ans = Plus(a, b);
            else if (sign == '-') ans = Minus(a, b);
            else if (sign == '*') ans = Multiply(a, b);
            else if (sign == '/')
            {
                if (!Divide(a, b, out ans)) MessageBox.Show("Cannot divide for 0");
                else Divide(a, b, out ans);
            }
            lastRest.Add(ans);
            resultTxt.Text = ans.ToString();
        }

        private void CeBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "";
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "0.";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "/";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "-";
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "*";
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text != "" || resultTxt.Text != "0")
            {
                resultTxt.Text = SqrtHandle(Double.Parse(resultTxt.Text.ToString())).ToString();
            }
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            resultTxt.Text = Double.Parse(resultTxt.Text.ToString())*100 + "%";
        }

        private void BtnOneDivide_Click(object sender, EventArgs e)
        {
            resultTxt.Text = (1/Double.Parse(resultTxt.Text.ToString())).ToString();
        }

        private void McBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "0";
        }

        private void MrBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = lastRest[lastRest.Count-2].ToString();
        }

        private void MPlusBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = (saveVariable + lastRest[lastRest.Count-1]).ToString();
        }

        private void MsBtn_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = saveVariable.ToString();
            else
            {
                saveVariable = Double.Parse(resultTxt.Text);
                MessageBox.Show("Save value to memory");
            }
           
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "" || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += Btn0.Text;
        }
    }
}
