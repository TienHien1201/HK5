using DoAnMau.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMau
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        int count = 0;
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Bạn đã đăng nhập sai quá số lần quy định, chương trình sẽ tự động thoát!");
                Application.Exit();
            }
            DoAnMauDB database = new DoAnMauDB();
            string matkhau = ThuVien.MD5Hash(txtMatKhau.Text);
            ThuVien.LoggedUser = database.NguoiDungs.FirstOrDefault(u => u.TenNguoiDung == txtTenNguoiDung.Text && u.MatKhau == matkhau && u.TrangThai == true);
            if (ThuVien.LoggedUser != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                if (ThuVien.LoggedUser.MaQuyen == 1)//chủ shop
                    (new frmChuShop()).ShowDialog();
                else if (ThuVien.LoggedUser.MaQuyen == 2)//nhân viên
                    (new frmNhanVien()).ShowDialog();
                this.Hide();
            }
            else
            {
                count++;
                MessageBox.Show($"Thông tin đăng nhập không đúng hoặc tài khoản đã bị khóa!\nBạn đã đăng nhập sai {count} lần, còn {3-count} lần!");
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmQuenMatKhau()).ShowDialog();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btDangNhap.PerformClick();
            }
        }
    }
}
