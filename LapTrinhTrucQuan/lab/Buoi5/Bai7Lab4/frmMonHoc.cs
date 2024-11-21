using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.Bai7Lab4
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        BT7DTHD.BT7DTHD data = new BT7DTHD.BT7DTHD();

        int ViTriHienTai = 0;
        void LayDuLieuMonHoc()
        {
            dgvMH.DataSource = data.LayDuLieu("select * from MonHoc;");
            ViTriHienTai = 0;
            if (dgvMH.Rows.Count > 0)
            {
                txtViTri.Text = (ViTriHienTai + 1) + "";
                lbTongSo.Text = " / " + dgvMH.RowCount;
            }
        }
        bool KiemTraLuu(bool ThemMoi)
        {
            if (txtMaMH.Text == "" || txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            //nếu thêm mơi thì kiểm tra khóa chính
            string sql;
            if (ThemMoi)
            {
                sql = $"select 1 from MonHoc where MaMH='{txtMaMH.Text}'";
                if (data.LayDuLieu(sql).Rows.Count > 0)
                {
                    MessageBox.Show("Mã Môn học bị trùng!");
                    txtMaMH.Focus();
                    return false;
                }
            }
            //kiểm tra ràng buộc duy nhất unique
            sql = $"select 1 from MonHoc where TenMH=N'{txtTenMH.Text}'";
            if (data.LayDuLieu(sql).Rows.Count > 0)
            {
                MessageBox.Show("Tên môn học bị trùng!");
                txtTenMH.Focus();
                return false;
            }
            return true;
        }
        bool CoThem = false;
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LayDuLieuMonHoc();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            CoThem = true;
            txtMaMH.Text = txtTenMH.Text = textBox1.Text = "";
            txtMaMH.ReadOnly = txtTenMH.ReadOnly = textBox1.ReadOnly = false;
            txtMaMH.Focus();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMH.SelectedRows.Count > 0)
            {
                txtMaMH.Text = dgvMH.SelectedRows[0].Cells[0].Value.ToString();
                txtTenMH.Text = dgvMH.SelectedRows[0].Cells[1].Value.ToString();
                textBox1.Text = dgvMH.SelectedRows[0].Cells[2].Value.ToString();

                txtViTri.Text = (dgvMH.SelectedRows[0].Index + 1).ToString();

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (txtMaMH.Text == "") return;

            string sql = $"select 1 from SinhVien where MaKhoa='{txtMaMH.Text}'";

            //hỏi xác nhận
            if (MessageBox.Show($"Bạn có chắc xóa môn học: {txtTenMH.Text} không", "Chú ý xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            sql = $"delete from MonHoc where MaMH='{txtMaMH.Text}'";
            if (data.CapNhatDuLieu(sql) >= 0)
            {
                MessageBox.Show("Đã xóa!");
                btLamMoi.PerformClick();
            }
            else
                MessageBox.Show("Lỗi xóa dữ liệu, vui lòng thử lại sau!");
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LayDuLieuMonHoc();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            CoThem = false;
            txtTenMH.ReadOnly = false;
            txtTenMH.Focus();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraLuu(CoThem)) return;
            string sql;
            if (CoThem == true)
            {
                sql = $"insert into MonHoc values('{txtMaMH.Text}',N'{txtTenMH.Text}',{int.Parse(textBox1.Text)});";
            }
            else
            {
                sql = $"update MonHoc set TenKhoa=N'{txtTenMH.Text}' where MaMH='{txtMaMH.Text}';";
            }
            if (data.CapNhatDuLieu(sql) >= 0)
                MessageBox.Show("Đã lưu dữ liệu!");
            else
                MessageBox.Show("Không thể lưu, vui lòng thử lại sau!");
            btLamMoi.PerformClick();
            CoThem = false;
            txtMaMH.ReadOnly = txtTenMH.ReadOnly = textBox1.ReadOnly = true;
        }

        private void btKhongLuu_Click(object sender, EventArgs e)
        {
            CoThem = false;
            txtMaMH.ReadOnly = txtTenMH.ReadOnly = true;
            //xuất dữ liệu cũ
            txtMaMH.Text = dgvMH.SelectedRows[0].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMH.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dgvMH.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ViTriHienTai = 0;
            dgvMH.Rows[ViTriHienTai].Selected = true;
        }

        private void btTruoc_Click(object sender, EventArgs e)
        {
            if (ViTriHienTai > 0)
            {
                ViTriHienTai--;
                dgvMH.Rows[ViTriHienTai].Selected = true;
            }
        }

        private void btSau_Click(object sender, EventArgs e)
        {

            if (ViTriHienTai < dgvMH.RowCount - 1)
            {
                ViTriHienTai++;
                dgvMH.Rows[ViTriHienTai].Selected = true;
            }
        }

        private void btCuoi_Click(object sender, EventArgs e)
        {

            ViTriHienTai = dgvMH.RowCount - 1;
            dgvMH.Rows[ViTriHienTai].Selected = true;
        }
    }
}
