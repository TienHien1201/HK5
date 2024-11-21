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
    public partial class Bai5_3 : Form
    {
        public Bai5_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvDanhSachNhanVien.Items.Add(tbHoTen.Text);
            lvi.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            lvi.SubItems.Add(tbDienThoai.Text); 
            lvi.SubItems.Add(tbDiaChi.Text);
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                tbHoTen.Text =
                lvDanhSachNhanVien.SelectedItems[0].SubItems[0].Text; dtpNgaySinh.Text =
                lvDanhSachNhanVien.SelectedItems[0].SubItems[1].Text; tbDienThoai.Text =
                lvDanhSachNhanVien.SelectedItems[0].SubItems[2].Text; tbDiaChi.Text =
                lvDanhSachNhanVien.SelectedItems[0].SubItems[3].Text;
            }


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                lvDanhSachNhanVien.Items.Remove(lvDanhSachNhanVien.SelectedItems[0]);
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                lvDanhSachNhanVien.SelectedItems[0].SubItems[0].Text = tbHoTen.Text; lvDanhSachNhanVien.SelectedItems[0].SubItems[1].Text =
                dtpNgaySinh.Value.ToShortDateString(); lvDanhSachNhanVien.SelectedItems[0].SubItems[2].Text =
                tbDienThoai.Text; lvDanhSachNhanVien.SelectedItems[0].SubItems[3].Text =
                tbDiaChi.Text;
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
