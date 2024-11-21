using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2Demo
{
    public partial class Lab2Bai4From1 : Form
    {
        public Lab2Bai4From1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_nhap.Text))
            {
                lstBox_hienthi.Items.Add(txt_nhap.Text);
                txt_hienthi.Text = lstBox_hienthi.Items.Count.ToString();
                txt_nhap.Clear();
                txt_nhap.Focus();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);
            if (lstBox_hienthi.SelectedItems.Count != 0)
            {
                lstBox_hienthi.Items.Remove(lstBox_hienthi.SelectedItems[0]);
            }
            txt_hienthi.Text = (a - 1).ToString();

        }

        private void txt_hienthi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);
            lstBox_hienthi.Items.RemoveAt(0);
            txt_hienthi.Text = (a - 1).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);
            lstBox_hienthi.Items.RemoveAt(lstBox_hienthi.Items.Count - 1);
            txt_hienthi.Text = (a - 1).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstBox_hienthi.Items.Clear();
            txt_hienthi.Text = "0";

        }
    }
}
