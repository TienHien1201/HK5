using Buoi5.BT7DTHD;
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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        BT7DTHD.BT7DTHD data = new BT7DTHD.BT7DTHD();

        int ViTriHienTai = 0;
        void LayDuLieuKhoa()
        {
            dgvKhoa.DataSource= data.LayDuLieu("select * from Khoa;");
            ViTriHienTai = 0;
            if (dgvKhoa.Rows.Count > 0 )
            {
                txtViTri.Text = (ViTriHienTai + 1)+"";
                lbTongSo.Text = " / " + dgvKhoa.RowCount;
            }
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LayDuLieuKhoa();
        }

        //chọn 1 dòng trên lưới
        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvKhoa.SelectedRows.Count > 0) 
            {
                txtMaKhoa.Text= dgvKhoa.SelectedRows[0].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvKhoa.SelectedRows[0].Cells[1].Value.ToString();
                txtViTri.Text = (dgvKhoa.SelectedRows[0].Index+1).ToString();

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "") return;
            //kiểm tra các khóa ngoại
            string sql = $"select 1 from SinhVien where MaKhoa='{txtMaKhoa.Text}'";
            if(data.LayDuLieu(sql).Rows.Count > 0)
            {
                MessageBox.Show($"Khoa {txtTenKhoa.Text} có sinh viên đang học, không được xóa!");
                return;
            }
            //hỏi xác nhận
            if (MessageBox.Show($"Bạn có chắc xóa khoa {txtTenKhoa.Text} không", "Chú ý xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            sql= $"delete from Khoa where MaKhoa='{txtMaKhoa.Text}'";
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
            LayDuLieuKhoa();
        }

        bool CoThem = false;
        private void btThem_Click(object sender, EventArgs e)
        {
            CoThem = true;
            txtMaKhoa.Text = txtTenKhoa.Text = "";
            txtMaKhoa.ReadOnly = txtTenKhoa.ReadOnly = false;
            txtMaKhoa.Focus();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            CoThem = false;
            txtTenKhoa.ReadOnly = false;
            txtTenKhoa.Focus();
        }

        bool KiemTraLuu(bool ThemMoi)
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            //nếu thêm mơi thì kiểm tra khóa chính
            string sql;
            if (ThemMoi)
            {
                sql = $"select 1 from Khoa where MaKhoa='{txtMaKhoa.Text}'";
                if (data.LayDuLieu(sql).Rows.Count > 0)
                {
                    MessageBox.Show("Mã khoa bị trùng!");
                    txtMaKhoa.Focus();
                    return false;
                }
            }
            //kiểm tra ràng buộc duy nhất unique
            sql = $"select 1 from Khoa where TenKhoa=N'{txtTenKhoa.Text}'";
            if (data.LayDuLieu(sql).Rows.Count > 0)
            {
                MessageBox.Show("Tên khoa bị trùng!");
                txtTenKhoa.Focus();
                return false;
            }
            return true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraLuu(CoThem)) return;
            string sql;
            if (CoThem == true)
            {
                sql = $"insert into Khoa values('{txtMaKhoa.Text}',N'{txtTenKhoa.Text}');";
            }
            else
            {
                sql = $"update Khoa set TenKhoa=N'{txtTenKhoa.Text}' where MaKhoa='{txtMaKhoa.Text}';";
            }
            if (data.CapNhatDuLieu(sql) >= 0)
                MessageBox.Show("Đã lưu dữ liệu!");
            else
                MessageBox.Show("Không thể lưu, vui lòng thử lại sau!");
            btLamMoi.PerformClick();
            CoThem = false;
            txtMaKhoa.ReadOnly = txtTenKhoa.ReadOnly = true;
        }

        private void btKhongLuu_Click(object sender, EventArgs e)
        {
            CoThem = false;
            txtMaKhoa.ReadOnly = txtTenKhoa.ReadOnly = true;
            //xuất dữ liệu cũ
            txtMaKhoa.Text = dgvKhoa.SelectedRows[0].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ViTriHienTai = 0;
            dgvKhoa.Rows[ViTriHienTai].Selected = true;
        }

        private void btTruoc_Click(object sender, EventArgs e)
        {
            if(ViTriHienTai>0)
            {
                ViTriHienTai--;
                dgvKhoa.Rows[ViTriHienTai].Selected = true;
            }    
        }

        private void btSau_Click(object sender, EventArgs e)
        {
            if (ViTriHienTai < dgvKhoa.RowCount-1)
            {
                ViTriHienTai++;
                dgvKhoa.Rows[ViTriHienTai].Selected = true;
            }
        }

        private void btCuoi_Click(object sender, EventArgs e)
        {
            ViTriHienTai = dgvKhoa.RowCount - 1;
            dgvKhoa.Rows[ViTriHienTai].Selected = true;
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
