using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
            row.Cells[0].Value = mssvTxt.Text;
            row.Cells[1].Value = hotenTxt.Text;
            row.Cells[2].Value = chuyennganhTxt.Text;
            row.Cells[3].Value = namTxt.Checked ? "Nam" : "Nu";
            row.Cells[4].Value = "Cơ sở dữ liêu";
            dataGridView.Rows.Add(row);
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            //listBox2.Columns[0] = listBox1.SelectedIndex;
        }
    }
}
