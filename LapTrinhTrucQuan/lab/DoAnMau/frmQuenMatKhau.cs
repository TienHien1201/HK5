using DoAnMau.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMau
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            DoAnMauDB database = new DoAnMauDB();
            if(txtTenNguoiDung.Text=="" || txtEmail.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đúng tên người dùng và email đã được Admin tạo!");
                return;
            }
            NguoiDung user = database.NguoiDungs.FirstOrDefault(u => u.TenNguoiDung == txtTenNguoiDung.Text && u.Email == txtEmail.Text);
            if(user != null)
            {
                Random random = new Random();
                int mk = random.Next(100001, 999999);
                user.MatKhau = ThuVien.MD5Hash(mk + "");
                database.NguoiDungs.AddOrUpdate(user);
                database.SaveChanges();
                if (ThuVien.SendEmail(user.Email, "Mật khẩu của bạn là: " + mk))
                    MessageBox.Show("Mật khẩu đã được gửi đến email: " + user.Email);
                else
                    MessageBox.Show("Sự cố gửi mail, vui lòng thử lại sau ít phút!");

            }
            else
            {
                MessageBox.Show("Tên người dùng/Email không đúng!");
            }
        }
    }
}
