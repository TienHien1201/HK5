using Buoi5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class frmThemSinhVien : Form
    {
        public frmThemSinhVien()
        {
            InitializeComponent();
        }

       Model1 database = new Model1();

        void LayDuLieuKhoa()
        {

            cbbKhoa.DataSource = database.Khoa.ToList<Khoa>();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            LayDuLieuKhoa();
            txtMaSo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KTThem()
        {
            if(txtMaSo.Text=="" || txtHoTen.Text=="" || cbbGioiTinh.Text=="" || cbbKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ít nhất các thông tin: Mã số, họ tên, giới tính, khoa!");
                return false;
            }
            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18)
            {
                MessageBox.Show("Sinh viên phải từ 18 tuổi!");
                dtpNgaySinh.Focus();
                return false;
            }
            //kiểm tra trùng mã sinh viên
            int ms = int.Parse(txtMaSo.Text);
            if (database.SinhVien.FirstOrDefault(s => s.MaSo == ms) != null)
            {
                MessageBox.Show("Mã sinh viên bị trùng!");
                txtMaSo.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!KTThem()) return;

            SinhVien s = new SinhVien();
            s.MaSo = int.Parse(txtMaSo.Text);
            s.HoTen = txtHoTen.Text;
            s.NgaySinh = dtpNgaySinh.Value;
            s.GioiTinh = (cbbGioiTinh.Text == "Nam") ? false : true;
            s.DiaChi = txtDiaChi.Text;
            s.DienThoai = txtDienThoai.Text;
            s.MaKhoa = cbbKhoa.SelectedValue.ToString();
            s.HinhThe = "";
            if (pictureBox1.ImageLocation != "")
            {
                string imagename = pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf(@"\"));
                s.HinhThe = "HinhThe" + imagename;
            }
            database.SinhVien.AddOrUpdate(s);
            database.SaveChanges();
            MessageBox.Show("Đã thêm sinh viên vào danh sách!");
            LuuHinh();
        }

        void LuuHinh()
        {
            if (pictureBox1.ImageLocation != "")
            {
                //cắt tên hình
                string imagename = pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf(@"\"));
                //MessageBox.Show(Application.StartupPath + "\\HinhThe" +imagename);
                File.Copy(pictureBox1.ImageLocation, Application.StartupPath + "\\HinhThe" + imagename, true);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(png images)|*.png|(jpeg images)|*.jpg";
            ofd.Multiselect = false;
            DialogResult ok = ofd.ShowDialog();
            if (ok == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                //MessageBox.Show(ofd.FileName);
            }
            
        }
    }
}
