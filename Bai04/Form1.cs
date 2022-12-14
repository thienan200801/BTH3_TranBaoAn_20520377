using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        List<ButtonGheNgoi> buttonsGheNgoi = new List<ButtonGheNgoi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateSeatsButton()
        {
            for (int i = 1; i <= 15; i++)
            {
                ButtonGheNgoi buttonGheNgoi = new ButtonGheNgoi();
                buttonGheNgoi.Text = i.ToString();
                buttonGheNgoi.priceSeat = i;
                if (i <= 5)
                {
                    buttonGheNgoi.priceSeat = 5000;
                }
                else if (i <= 10)
                {
                    buttonGheNgoi.priceSeat = 6500;
                }
                else
                {
                    buttonGheNgoi.priceSeat = 8000;
                }


                buttonsGheNgoi.Add(buttonGheNgoi);
                flowLayoutPanel1.Controls.Add(buttonGheNgoi);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateSeatsButton();
            ChosingSeats();
        }

        private void ChosingSeats()
        {
            foreach (ButtonGheNgoi item in buttonsGheNgoi)
            {
                item.Click += ChoseSeats;
            }
        }

        private void ChoseSeats(object sender, EventArgs e)
        {
            ButtonGheNgoi button = (ButtonGheNgoi)sender;

            switch (button.myCorlorSeats)
            {
                case colorSeats.None:
                    button.myCorlorSeats = colorSeats.AreChosing;
                    button.ChangeColorToAreChosing();
                    break;
                case colorSeats.AreChosing:
                    button.myCorlorSeats = colorSeats.None;
                    button.ChangeColorToNone();
                    break;
                case colorSeats.HasChosen:
                    MessageBox.Show("Ghế này đã được chọn. Vui lòng chọn ghế khác!", "Mèo méo meo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void button_pick_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (var item in buttonsGheNgoi)
            {
                if (item.myCorlorSeats == colorSeats.AreChosing)
                {
                    item.myCorlorSeats = colorSeats.HasChosen;
                    item.ChangeColorToHasChosen();

                    total += item.priceSeat;
                }
            }
            textBox_thanhtien.Text = total.ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            foreach (var item in buttonsGheNgoi)
            {
                if (item.myCorlorSeats == colorSeats.AreChosing)
                {
                    item.myCorlorSeats = colorSeats.None;
                    item.ChangeColorToNone();
                }
            }
            textBox_thanhtien.Text = 0.ToString();
        }
        private void button_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
