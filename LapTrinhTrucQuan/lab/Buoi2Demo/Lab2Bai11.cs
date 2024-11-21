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
    public partial class Lab2Bai11 : Form
    {
        public Lab2Bai11()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Lab2Bai11_Load(object sender, EventArgs e)
        {

        }

        private void hiểnThịThờiGianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblTime.Text = String.Format("{0:hh:mm:ss tt}", dt);

        }

        private void hiểnThịNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblDate.Text = String.Format("{0:dd/MM/yyyy}", dt);

        }

        private void hiểnThịThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
