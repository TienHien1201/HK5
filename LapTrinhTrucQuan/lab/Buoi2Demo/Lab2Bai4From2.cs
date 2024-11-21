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
    public partial class Lab2Bai4From2 : Form
    {
        public Lab2Bai4From2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_doiMau_Click(object sender, EventArgs e)
        {
            if (cbo_color.Text == "Yellow")
            {
                lb_doimau.BackColor = Color.Red;
                lb_doimau.ForeColor = Color.Yellow;
            }
            if (cbo_color.Text == "Red")
            {
                lb_doimau.BackColor = Color.Yellow;
                lb_doimau.ForeColor = Color.Red;
            }
            if (cbo_color.Text == "Blue")
            {
                lb_doimau.BackColor = Color.Yellow;
                lb_doimau.ForeColor = Color.Blue;
            }
            if (cbo_color.Text == "Black")
            {
                lb_doimau.BackColor = Color.White;
                lb_doimau.ForeColor = Color.Black;
            }
        }
    }
}
