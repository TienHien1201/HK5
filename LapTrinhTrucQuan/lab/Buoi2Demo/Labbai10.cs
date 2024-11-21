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
    public partial class Labbai10 : Form
    {
        public Labbai10()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hiểnThịToolStripMenuItem.SelectedItem == "Hiển thị giờ")
            {
                timerTime.Start();
            }
            else if (hiểnThịToolStripMenuItem.SelectedItem == "Hiển thị ngày tháng")
            {
                timerDate.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblTime.Text = String.Format("{0:hh:mm:ss tt}", dt);

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblDate.Text = String.Format("{0:dd/MM/yyyy}", dt);

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
