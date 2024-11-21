using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MotSoBai
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void Bt_cong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            int tong = n + m;
            txt_ketqua.Text = tong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            int tru = n - m;
            txt_ketqua.Text = tru.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            int nhan = n * m;
            txt_ketqua.Text = nhan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            int chia = n / m;
            txt_ketqua.Text = chia.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_Som.Clear();
            txt_Son.Clear();
            txt_ketqua.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
