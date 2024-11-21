using Buoi5.Bai7Lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MoFormCon(Form f)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == f.Name)
                {
                    child.Activate();
                    return;
                }
            }
            f.MdiParent = this;
            f.Show();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmKhoa());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSinhVien());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            MoFormCon(new frmMonHoc());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhapDiem());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmXemDiem());
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThongKe());
        }
    }
}
