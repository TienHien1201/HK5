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
    public partial class frmSuaSinhVien : Form
    {
        public frmSuaSinhVien()
        {
            InitializeComponent();
        }

        public int ms;
        

        Model1 database = new Model1();
        void LayDuLieuKhoa()
        {
            cbbKhoa.DataSource = database.Khoa.ToList<Khoa>();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
        SinhVien sv;
        void LayThongTinSinhVien()
        {
            sv = database.SinhVien.FirstOrDefault(s => s.MaSo == ms);
            txtMaSo.Text = sv.MaSo + "";
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = (DateTime)sv.NgaySinh;
            if (sv.GioiTinh == true)
                cbbGioiTinh.SelectedIndex = 1;
            else
                cbbGioiTinh.SelectedIndex = 0;
            txtDiaChi.Text = sv.DiaChi;
            txtDienThoai.Text = sv.DienThoai;
            cbbKhoa.SelectedValue = sv.MaKhoa;
            if (sv.HinhThe.Trim() != "")
                pictureBox1.ImageLocation = Application.StartupPath + "\\" + sv.HinhThe;
        }

        private void frmSuaSinhVien_Load(object sender, EventArgs e)
        {
            LayDuLieuKhoa();
            //lấy thông tin sinh viên cần sửa
            LayThongTinSinhVien();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KTSua()
        {
            if (txtMaSo.Text == "" || txtHoTen.Text == "" || cbbGioiTinh.Text == "" || cbbKhoa.Text == "")
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
            return true;
        }

        void LuuHinh()
        {
            if (pictureBox1.ImageLocation != "")
            {
                //cắt tên hình
                string imagename = pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf(@"\"));
                //MessageBox.Show(Application.StartupPath + "\\HinhThe" +imagename);
                string newpath = Application.StartupPath + "\\HinhThe" + imagename;
                if (pictureBox1.ImageLocation != newpath)
                    File.Copy(pictureBox1.ImageLocation, newpath, true);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!KTSua()) return;
            sv.HoTen = txtHoTen.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = (cbbGioiTinh.Text == "Nam") ? false : true;
            sv.DiaChi = txtDiaChi.Text;
            sv.DienThoai = txtDienThoai.Text;
            sv.MaKhoa = cbbKhoa.SelectedValue.ToString();
            //nếu có chọn hình mới
            string imagename = pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf(@"\"));
            string newpath = Application.StartupPath + "\\HinhThe" + imagename;
            if (pictureBox1.ImageLocation != newpath)
                sv.HinhThe = "HinhThe" + imagename;
            database.SinhVien.AddOrUpdate(sv);
            database.SaveChanges();
            MessageBox.Show("Đã lưu thông tin sinh viên!");
            LuuHinh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
