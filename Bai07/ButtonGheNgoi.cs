using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    class ButtonGheNgoi : Button
    {
        public ButtonGheNgoi()
        {
            this.Height = 60;
            this.Width = 60;
            this.Font = new Font(FontFamily.GenericSansSerif, 13);
        }

        public colorSeats myCorlorSeats { get; set; } = colorSeats.None;
        public int priceSeat { get; set; } = 0;

        public void ChangeColorToNone()
        {
            myCorlorSeats = colorSeats.None;
            this.BackColor = Color.FromArgb(Color.White.ToArgb());
        }

        public void ChangeColorToAreChosing()
        {
            myCorlorSeats = colorSeats.AreChosing;
            this.BackColor = Color.FromArgb(Color.Blue.ToArgb());
        }

        public void ChangeColorToHasChosen()
        {
            myCorlorSeats = colorSeats.HasChosen;
            this.BackColor = Color.FromArgb(Color.Yellow.ToArgb());
        }


    }
    enum colorSeats
    {
        None,
        AreChosing,
        HasChosen
    }

}
