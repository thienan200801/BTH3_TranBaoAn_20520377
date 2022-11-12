using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        String selectedSubject = null;
        bool isListBoxRightSelected;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = mssvTxt.Text;
                row.Cells[1].Value = hotenTxt.Text;
                row.Cells[2].Value = chuyennganhTxt.Text;
                row.Cells[3].Value = namTxt.Checked ? "Nam" : "Nu";
                row.Cells[4].Value = listBox2.Items[i];
                dataGridView.Rows.Add(row);

            }

        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null && isListBoxRightSelected == true)
            {
                listBox2.Items.Add(selectedSubject);
                listBox1.Items.Remove(selectedSubject);
                selectedSubject = null;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isListBoxRightSelected = true;
            ListBox subjects = (ListBox)sender;

            if (subjects.SelectedIndex < 0) return;
            String item = (String)subjects.Items[subjects.SelectedIndex];
            selectedSubject = item;
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox subjects = (ListBox)sender;
            isListBoxRightSelected = false;
            if (subjects.SelectedIndex < 0) return;
            String item = (String)subjects.Items[subjects.SelectedIndex];
            selectedSubject = item;
        }

        private void dltChooseBtn_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null && isListBoxRightSelected == false)
            {
                listBox1.Items.Add(selectedSubject);
                listBox2.Items.Remove(selectedSubject);
                selectedSubject = null;
            }
        }
    }
}
