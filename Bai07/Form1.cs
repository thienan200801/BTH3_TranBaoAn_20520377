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
            CreateSeatsButton();
        }

        private void CreateSeatsButton()
        {
            Random ran = new Random();
            for (int i = 1; i <= 15; i++)
            {
                ButtonGheNgoi buttonGheNgoi = new ButtonGheNgoi();
                buttonGheNgoi.Text = i.ToString();
                buttonGheNgoi.priceSeat = i;
                buttonGheNgoi.Click += ButtonGheNgoi_Click;
                if (i % 5 == 0) { flowLayoutPanel1.SetFlowBreak(buttonGheNgoi, true); }

                if (ran.Next(10) > 5)
                {
                    buttonGheNgoi.ChangeColorToHasChosen();
                }
                
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

        private void ButtonGheNgoi_Click(object sender, EventArgs e)
        {
            ButtonGheNgoi btn = (ButtonGheNgoi)sender;
            switch (btn.myCorlorSeats) {
                case colorSeats.None:
                    btn.ChangeColorToAreChosing();
                    break;
                case colorSeats.AreChosing:
                    btn.ChangeColorToNone();
                    break;
            }
            return;
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
                    MessageBox.Show("Ghế này đã được chọn. Vui lòng chọn ghế khác!", "...s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void button_pick_Click_1(object sender, EventArgs e)
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

        private void button_cancel_Click_1(object sender, EventArgs e)
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

        private void button_Quit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
