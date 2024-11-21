using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buoi5.Model;

namespace Buoi5
{
    public partial class frmSinhVien : Form
    {
       
        public frmSinhVien()
        {
           
            InitializeComponent();
        }
        Model1 database = new Model1();
        private void btSau_Click(object sender, EventArgs e)
        {

        }

        BT7DTHD.BT7DTHD data = new BT7DTHD.BT7DTHD();

        void LayDuLieuSinhVien(string MaKhoa)
        {
            //string sql = "select * from SinhVien";
            if (MaKhoa != "")
                //    sql += $" where MaKhoa='{MaKhoa}';";
                dgvSinhVien.DataSource = database.SinhVien.ToList<SinhVien>().FindAll(s => s.MaKhoa == MaKhoa);
            else
                dgvSinhVien.DataSource = database.SinhVien.ToList<SinhVien>();
        }

        void LayDuLieuKhoa()
        {

            cbbKhoa.ComboBox.DataSource = database.Khoa.ToList<Khoa>();
            cbbKhoa.ComboBox.DisplayMember = "TenKhoa";
            cbbKhoa.ComboBox.ValueMember = "MaKhoa";
            cbbKhoa.ComboBox.SelectedValueChanged += ComboBox_SelectedValueChanged;

        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LayDuLieuSinhVien(cbbKhoa.ComboBox.SelectedValue.ToString());
        }
        int ViTriHienTai = 0;
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LayDuLieuKhoa();
            dgvSinhVien.DataSource = data.LayDuLieu("select * from SinhVien;");
            ViTriHienTai = 0;
            if (dgvSinhVien.Rows.Count > 0)
            {
                txtViTri.Text = (ViTriHienTai + 1) + "";
                lbTongSo.Text = " / " + dgvSinhVien.RowCount;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            (new frmThemSinhVien()).ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }
            frmSuaSinhVien f = new frmSuaSinhVien();
            f.ms = int.Parse(dgvSinhVien.SelectedRows[0].Cells[0].Value.ToString());
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }
            int ms = int.Parse(dgvSinhVien.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult rs = MessageBox.Show($"Bạn có chắc xóa sinh viên '{ms}' không?", "Cảnh báo xóa dữ liệu sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.No) return;

            if (database.KetQua.FirstOrDefault(k => k.MaSo == ms) != null)
            {
                MessageBox.Show("Không được xóa vì sinh viên này có dữ liệu học tập liên quan!");
                return;
            }

            SinhVien sv = database.SinhVien.FirstOrDefault(s => s.MaSo == ms);
            database.SinhVien.Remove(sv);
            database.SaveChanges();
            MessageBox.Show($"Đã xóa thông tin sinh viên '{ms}'");

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            database = new Model1();
            dgvSinhVien.DataSource = data.LayDuLieu("select * from SinhVien;");
        }
    }
}
